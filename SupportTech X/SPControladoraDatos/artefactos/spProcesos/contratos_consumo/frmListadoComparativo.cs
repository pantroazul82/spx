using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmListadoComparativo : Form
    {
        private void frmListadoComparativo_Load(object sender, EventArgs e)
        {
            buscar();
        }
        public frmListadoComparativo()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string generarSql()
        {
            string top = "";
            if (chkLimitarNumeroResultados.Checked) top = " top " + nmRegistros.Value;
            string sql = @"select distinct 
 numero_contrato, '' 'Diferencia',
contrato_legalizado 'Legalizado', otro_si, 
fecha_inicio_contrato, fecha_finalizacion_contrato,
contrato_consumo.nitCliente 'Nit',
clientes.numeroSocio 'SN',clientes.nombreCliente 'Cliente',
usuario.nombre 'Asesor',
modalidad_contrato.nombre_modalidad_contrato 'Modalidad',sub_modalidad_contrato.nombresub_modalidad_contrato 'SubModalidad',

observaciones,      contrato_consumo.cod_contrato_consumo
 from contrato_consumo
 join 
 (
 select 
max(cod_contrato_consumo) cod_contrato_consumo
 from contrato_consumo
 group by numero_contrato
 ) st on st.cod_contrato_consumo = contrato_consumo.cod_contrato_consumo

 left join clientes on clientes.nitCliente = contrato_consumo.nitCliente
 left join usuario on usuario.cod_usuario= contrato_consumo.cod_asesor
 left join sub_modalidad_contrato on sub_modalidad_contrato.cod_sub_modalidad_contrato =contrato_consumo.cod_sub_modalidad_contrato
 left join modalidad_contrato on modalidad_contrato.cod_modalidad_contrato = sub_modalidad_contrato.cod_modalidad_contrato
 left join usuario us on us.cod_usuario= contrato_consumo.cod_asesor

 left join equiposxcontrato_consumo on equiposxcontrato_consumo.cod_contrato_consumo=contrato_consumo.cod_contrato_consumo  
 left join fabricante on fabricante.codFabricante = equiposxcontrato_consumo.codFabricante
 left join modelos on modelos.codFabricante = equiposxcontrato_consumo.codFabricante and
 modelos.codModelo = equiposxcontrato_consumo.codModelo
 left join linea_consumoxcontrato_consumo on linea_consumoxcontrato_consumo.cod_contrato_consumo = contrato_consumo.cod_contrato_consumo
 left join linea_consumo on linea_consumo.cod_linea_consumo = linea_consumoxcontrato_consumo.cod_linea_consumo

 ";
            string filtro = "";
/*
            ///armamos los filtros
            if (cmbCampo.Text == "Numero Contrato") filtro = " where contrato_consumo.numero_contrato like '" + txtCampo.Text.Trim() + "'";
            if (cmbCampo.Text == "Nit Cliente") filtro = " where clientes.nitCliente like '" + txtCampo.Text.Trim() + "'";
            if (cmbCampo.Text == "Cliente") filtro = " where clientes.nombreCliente like '" + txtCampo.Text.Trim() + "'";
            if (cmbCampo.Text == "Numero Socio") filtro = " where clientes.numeroSocio like '" + txtCampo.Text.Trim() + "'";
            if (cmbCampo.Text == "Modelos") filtro = " where Modelos.NombreModelo like '" + txtCampo.Text.Trim() + "'";
            if (cmbCampo.Text == "Fabricantes") filtro = " where fabricante.nombre_fabricante like '" + txtCampo.Text.Trim() + "'";
            if (cmbCampo.Text == "Serial") filtro = " where equiposxcontrato_consumo.serial like '" + txtCampo.Text.Trim() + "'";
            if (cmbCampo.Text == "Lineas de Consumo") filtro = " where linea_consumo.nombre_linea_consumo like '" + txtCampo.Text.Trim() + "'";

            */
            if (rdLegalizados.Checked)
            {
                if (filtro.Trim() == string.Empty) filtro = " where";
                else filtro = filtro + " and ";
                filtro = filtro + " contrato_consumo.contrato_legalizado=1";

            }
            else if (rdNoLegalizados.Checked)
            {
                if (filtro.Trim() == string.Empty) filtro = " where";
                else filtro = filtro + " and ";
                filtro = filtro + " contrato_consumo.contrato_legalizado=0";
            }

            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(2047))
            {
                if (filtro.Trim() == string.Empty) filtro = " where";
                else filtro = filtro + " and ";
                filtro = filtro + " contrato_consumo.cod_asesor=" + SPXSeguridad.logica.sesion.CodUsuarioAutenticado;
            }

            return sql + " " + filtro;
        }



        private void buscar()
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tb= bd.ejecutarConsulta(generarSql()).Tables[0];
            grdDatos.DataSource = tb;
            //--
            SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter pltEquipos = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter();
            
            SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                string cod = tb.Rows[k]["cod_contrato_consumo"].ToString();
                string nit = tb.Rows[k]["Nit"].ToString();
                pltEquipos.FillBycod_contrato_consumo(ds.pltEquiposxContrato, int.Parse(cod));
                string sql = "select nombreFabricante,nombreModelo from dbo.vistaEquipo where nitCliente='"+nit.Trim()+"'";
                System.Data.DataTable tbTemp = bd.ejecutarConsulta(sql).Tables[0];

                for (int j = 0; j < ds.pltEquiposxContrato.Count; j++)
                {
                    if (ds.pltEquiposxContrato[j].IsNombreModeloNull())
                    {
                        ds.pltEquiposxContrato.Rows.RemoveAt(j);
                        j--;
                    }
                }
                //ya aca en ambos dataset solo estan equipos
                if (ds.pltEquiposxContrato.Count > tbTemp.Rows.Count)
                {
                    tb.Rows[k]["Diferencia"] = "Equipos de mas En Contrato";
                }
                else if (ds.pltEquiposxContrato.Count < tbTemp.Rows.Count)
                {
                    tb.Rows[k]["Diferencia"] = "Faltan Equipos En Contrato";
                }
                else { 
                //en teoria son la misma cantidad vamos a verificar que sean los mismos
                    for (int j = 0; j < ds.pltEquiposxContrato.Count; j++)
                    {
                        if (tbTemp.Select("nombreFabricante='" + ds.pltEquiposxContrato [j].nombre_fabricante.Trim()
                            + "' and nombreModelo='" + ds.pltEquiposxContrato[j].NombreModelo + "'").Length > 0)
                        {
                            tb.Rows[k]["Diferencia"] = "Equipos corresponden a contrato.";
                            //tbTemp.Rows.Remove(tbTemp.Select("nombreFabricante='" + ds.pltEquiposxContrato[j].nombre_fabricante.Trim()
                            //+ "' and nombreModelo='" + ds.pltEquiposxContrato[j].NombreModelo + "'")[0]);
                            //ds.pltEquiposxContrato.Rows.RemoveAt(j);
                            
                            //j--;
                        }
                        else {

                            tb.Rows[k]["Diferencia"] = "Equipos no Coinciden Con Instalaciones ";
                            break;
                        }
                    }
                    if (ds.pltEquiposxContrato.Rows.Count == 0 && tbTemp.Rows.Count == 0)
                    { 
                    //son iguales
                        tb.Rows[k]["Diferencia"] = "Equipos corresponden a contrato.";
                        //tb.Rows.RemoveAt(k);
                        //k--;
                    }
                }

            }
        }

        private void btnNuevoContrato_Click(object sender, EventArgs e)
        {
            contratosConsumo fr = new contratosConsumo();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                buscar();
            }
        }

        private void btnVerContrato_Click(object sender, EventArgs e)
        {
            frmDiferenciasDetalle fr = new frmDiferenciasDetalle();
            fr.codContratoConsumo = int.Parse(grdDatos.Columns["cod_contrato_consumo"].Text.Trim());

            fr.nit = grdDatos.Columns["Nit"].Text.Trim();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              //  buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}

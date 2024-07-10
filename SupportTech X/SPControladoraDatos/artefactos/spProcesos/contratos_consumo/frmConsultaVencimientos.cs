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
    public partial class frmConsultaVencimientos : Form
    { 
        
        private void frmConsultaVencimientos_Load(object sender, EventArgs e)
        {
            buscar();
        }

        public frmConsultaVencimientos()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string generarSql()
        {
            string top = "";
            if (chkLimitarNumeroResultados.Checked) top = " top " + nmRegistros.Value;
            string sql = @"select distinct " + top + @"
 datediff(day,getdate(),fecha_finalizacion_contrato) 'Vence En',
 numero_contrato,
contrato_legalizado, otro_si, 
fecha_inicio_contrato, fecha_finalizacion_contrato,fecha_otro_si,
contrato_consumo.nitCliente,
clientes.numeroSocio,clientes.nombreCliente,
usuario.nombre 'Asesor',
modalidad_contrato.nombre_modalidad_contrato,sub_modalidad_contrato.nombresub_modalidad_contrato,

observaciones,      incrementos,us.nombre creado_por, fecha_creacion,contrato_consumo.cod_contrato_consumo
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

            ///armamos los filtros
            string filtro = "";
            if (cmbCampo.Text == "Numero Contrato") filtro = " where contrato_consumo.numero_contrato like '" + txtCampo.Text.Trim() + "%'";
            if (cmbCampo.Text == "Nit Cliente") filtro = " where clientes.nitCliente like '" + txtCampo.Text.Trim() + "%'";
            if (cmbCampo.Text == "Cliente") filtro = " where clientes.nombreCliente like '" + txtCampo.Text.Trim() + "%'";
            if (cmbCampo.Text == "Numero Socio") filtro = " where clientes.numeroSocio like '" + txtCampo.Text.Trim() + "%'";
            if (cmbCampo.Text == "Modelos") filtro = " where Modelos.NombreModelo like '" + txtCampo.Text.Trim() + "%'";
            if (cmbCampo.Text == "Fabricantes") filtro = " where fabricante.nombre_fabricante like '" + txtCampo.Text.Trim() + "%'";
            if (cmbCampo.Text == "Serial") filtro = " where equiposxcontrato_consumo.serial like '" + txtCampo.Text.Trim() + "%'";
            if (cmbCampo.Text == "Lineas de Consumo") filtro = " where linea_consumo.nombre_linea_consumo like '" + txtCampo.Text.Trim() + "%'";


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

            return sql + " " + filtro + "  order by datediff(day,getdate(),fecha_finalizacion_contrato)";
        }



        private void buscar()
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource = bd.ejecutarConsulta(generarSql()).Tables[0];
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
            contratosConsumo fr = new contratosConsumo();
            fr.NumeroContrato = grdDatos.Columns["numero_contrato"].Text.Trim();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}

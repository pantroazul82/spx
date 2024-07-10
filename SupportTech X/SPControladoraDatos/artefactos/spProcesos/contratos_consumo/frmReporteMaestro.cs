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
    public partial class frmReporteMaestro : Form
    {
        private void frmReporteMaestro_Load(object sender, EventArgs e)
        {
            calFin.Value = DateTime.Now;
            calFin.MonthCalendar.DisplayMonth = DateTime.Now;

            calInicio.Value = DateTime.Now.AddMonths(-2);
            calInicio.MonthCalendar.DisplayMonth = DateTime.Now;
        }

        public frmReporteMaestro()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string generarSql()
        {
            string top = "";
            if (chkLimitarNumeroResultados.Checked) top = " top " + nmRegistros.Value;
            string sql = @"set dateformat ymd select  " + top + @"  
  numero_contrato '# Contrato',
clientes.nombreCliente 'Cliente',
contrato_consumo.nitCliente 'Nit',
clientes.numeroSocio 'SN',usuario.nombre 'Asesor',
modalidad_contrato.nombre_modalidad_contrato 'Modalidad',sub_modalidad_contrato.nombresub_modalidad_contrato 'Sub Modalidad',
linea_consumo.nombre_linea_consumo 'clasificacion_consumo',
linea_consumoxcontrato_consumo.valor_exigido ,
contrato_legalizado
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


 join linea_consumoxcontrato_consumo on linea_consumoxcontrato_consumo.cod_contrato_consumo = contrato_consumo.cod_contrato_consumo
 join linea_consumo on linea_consumo.cod_linea_consumo = linea_consumoxcontrato_consumo.cod_linea_consumo

 ";
            if (!chkReporteResumido.Checked)
            { //cambia el sql
                sql = @"set dateformat ymd select  " + top + @"  
  numero_contrato '# Contrato',otro_si,contrato_legalizado,
fecha_inicio_contrato 'Inicia',  fecha_finalizacion_contrato ,datediff(day,getdate(),fecha_finalizacion_contrato) 'Vence En',
datediff(month,fecha_inicio_contrato,fecha_finalizacion_contrato) 'Vigencia',
clientes.nombreCliente 'Cliente',
contrato_consumo.nitCliente 'Nit',
clientes.numeroSocio 'SN',usuario.nombre 'Asesor','12345678901234567890' 'Ciudad',


modalidad_contrato.nombre_modalidad_contrato 'Modalidad',sub_modalidad_contrato.nombresub_modalidad_contrato 'Submodalidad',
'123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890' 
'Equipos',
'123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890' 
'Fecha_Envio_Equipos',
incrementos,observaciones,

linea_consumo.nombre_linea_consumo 'clasificacion_consumo',
linea_consumoxcontrato_consumo.valor_exigido 

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


 join linea_consumoxcontrato_consumo on linea_consumoxcontrato_consumo.cod_contrato_consumo = contrato_consumo.cod_contrato_consumo
 join linea_consumo on linea_consumo.cod_linea_consumo = linea_consumoxcontrato_consumo.cod_linea_consumo
";
            }
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

            if (chkFechas.Checked)
            {
                if (filtro.Trim() == string.Empty) filtro = " where";
                else filtro = filtro + " and ";
                string f1 = calInicio.Value.Year +"/"+ calInicio.Value.Month.ToString().PadLeft(2,'0')+"/" + calInicio.Value.Day.ToString().PadLeft(2,'0');
                string f2 = calFin.Value.Year + "/" + calFin.Value.Month.ToString().PadLeft(2, '0') + "/" + calFin.Value.Day.ToString().PadLeft(2, '0');
                filtro = filtro + " contrato_consumo.fecha_creacion between '"+f1+"' and '"+f2+"' " ;
            }

            return sql + " " + filtro;
        }



        private void buscar()
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tb= bd.ejecutarConsulta(generarSql()).Tables[0];
            grdDatos.DataSource = tb;
            //modificamos la ciudad
            if (tb.Columns.Contains("Ciudad"))
            {
                tb.Columns["Ciudad"].ReadOnly = false;
            }

            if (tb.Columns.Contains("Equipos"))
            {
                tb.Columns["Equipos"].ReadOnly = false;

                tb.Columns["Equipos"].MaxLength = 10000;
            }
            if (tb.Columns.Contains("Fecha_Envio_Equipos"))
            {
                tb.Columns["Fecha_Envio_Equipos"].ReadOnly = false;

                tb.Columns["Fecha_Envio_Equipos"].MaxLength = 20000;
            }
            if (!chkReporteResumido.Checked)
            {
                string sql = "";
                SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
                SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter equipos = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltEquiposxContratoTableAdapter();

                SPControladoraDatos.dsContratoConsumoTableAdapters.pltIncrementosLineaConsumoxContratoTableAdapter incrementosT = new SPControladoraDatos.dsContratoConsumoTableAdapters.pltIncrementosLineaConsumoxContratoTableAdapter();
                for (int k = 0; k < tb.Rows.Count; k++)
                {
                    string nitCliente = tb.Rows[k]["Nit"].ToString();
                    string contrato = tb.Rows[k]["# Contrato"].ToString();
                    sql = "select nombreSucursal from sucursalCliente where nitCliente = '"+nitCliente.Trim()+"'";
                    tb.Rows[k]["Ciudad"] = bd.ejecutarProcedimiento(sql).ToString();

                    sql = "select max(cod_contrato_consumo) from contrato_consumo where numero_contrato = '"+contrato.Trim()+"'";
                    contrato = bd.ejecutarProcedimiento(sql).ToString();
                    equipos.FillBycod_contrato_consumo(ds.pltEquiposxContrato, int.Parse(contrato));
                    string res = "";
                    string resFecha = "";
                    incrementosT.Fill(ds.pltIncrementosLineaConsumoxContrato, int.Parse(contrato));

                    for (int j = 0; j < ds.pltIncrementosLineaConsumoxContrato.Count; j++)
                    {
                        res = res + ds.pltIncrementosLineaConsumoxContrato[j].nombre_linea_consumo + " (" +
                                    ds.pltIncrementosLineaConsumoxContrato[j].incremento.Trim() + ") ,";
                    }

                    if (res.Length > 2) res = res.Substring(0, res.Length - 2);
                        tb.Rows[k]["Incrementos"] = res;

                    res="";

                    for (int j = 0; j < ds.pltEquiposxContrato.Count; j++) 
                    {
                        if (!ds.pltEquiposxContrato[j].IsNombreModeloNull())
                        {
                            res = res+ds.pltEquiposxContrato[j].NombreModelo +" ("+
                                ds.pltEquiposxContrato[j].nombre_fabricante.Trim()+")";
                            if (!ds.pltEquiposxContrato[j].IsserialNull())
                            {
                                res = res + " " + ds.pltEquiposxContrato[j].serial.Trim();
                            }
                            res = res + ", ";
                            //fecha de contrato
                            resFecha = resFecha + ds.pltEquiposxContrato[j].NombreModelo + " (" +
                                ds.pltEquiposxContrato[j].nombre_fabricante.Trim() + ")";
                            if (!ds.pltEquiposxContrato[j].IsserialNull())
                            {
                                resFecha = resFecha + " " + ds.pltEquiposxContrato[j].serial.Trim()
                                    +" - "+ bd.ejecutarProcedimiento("select top 1 left(isnull(cast(fechaSalida as date),''),10) from equipos where serial ='" + ds.pltEquiposxContrato[j].serial.Trim() + "'").ToString();
                            }
                            resFecha = resFecha + ", ";
                        }
                        else {
                            res = res+ ds.pltEquiposxContrato[j].descripcion_software_incluido + ", ";
                        }
                    }
                    if (res.Length > 2) res = res.Substring(0, res.Length - 2);
                        tb.Rows[k]["Equipos"] = res;

                        if (res.Length > 2) resFecha = resFecha.Substring(0, resFecha.Length - 2);
                        tb.Rows[k]["Fecha_Envio_Equipos"] = resFecha;
                }
            }
            grdDatos.Columns["valor_exigido"].NumberFormat = "Currency";
            grdDatos.Columns["valor_exigido"].Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Sum;

            grdDatos.GroupedColumns.Add(grdDatos.Columns["# Contrato"]);
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
            fr.NumeroContrato = grdDatos.Columns["# contrato"].Text.Trim();
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

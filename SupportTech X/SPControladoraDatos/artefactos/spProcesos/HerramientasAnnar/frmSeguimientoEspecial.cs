using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.HerramientasAnnar
{
    public partial class frmSeguimientoEspecial : Form
    {
        public frmSeguimientoEspecial()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string sentenciaSQL()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(@" select nombreFabricante as 'Fabricante',NombreModelo as 'Modelo', 
            nombreTipoEquipo 'Tipo Equipo',  nombreSubTipo 'Subtipo Equipo', 
isnull(nombreModalidadEquipo,'Sin Modalidad') as 'Modalidad', 
isnull(nombreEstadoLocal,'Sin Estado Local') as 'Estado Local', 
c.nitCliente as 'Nit Cliente',  c.nombreCliente as 'Cliente',  
nombreSucursal as 'Sucursal', nombrePais as 'Pais', 
NombreDepartamento as 'Departamento',  nombreCiudad as 'Ciudad', 
vistaEquipo.serial as 'Serial',  vistaEquipo.fechaLlegada as 'Llegada', 
TipoServicio.nombretipoServicio as 'Tipo Servicio',  isnull(tipoPropiedad.nombreTipoPropiedad,'No Asignada') as 'Tipo Propiedad', 
 vistaEquipo.observacionesUltimoMante as 'Observaciones', 
vistaEquipo.nitClienteUbicacionReal as 'Nit Cliente Real', 
vistaEquipo.clienteReal as 'Cliente Real', 
vistaEquipo.sucursalLocal as 'Sucursal Real', 
vistaEquipo.ultimo_responsable as 'Ultimo Responsable',

c.numeroSocio as 'Socio de Negocio',  vistaEquipo.fechaProximoMante as 'Proximo Mantenimiento',
vistaEquipo.fechaSalida as 'Salida',  vistaEquipo.fechaUltimoMante as 'Ultimo Mantenimiento', 
cast(null as datetime) fechaUltimopreventivo,
'' codigoPreventivo ");
            
            sb.Append(" from vistaEquipo");
            sb.Append(" join equipos on equipos.serial = vistaEquipo.serial ");
            sb.Append(" left join TipoServicio on TipoServicio.codTipoServicio = vistaEquipo.codTipoServicio ");
            sb.Append(" left join tipoPropiedad on tipoPropiedad.codTipoPropiedad = Equipos.codTipoPropiedad  ");
            sb.Append(" left join clientes c on vistaEquipo.nitCliente = c.nitCliente ");

            return sb.ToString();
        }


        private void buscar()
        {
           
            string sql = sentenciaSQL();
            if (sql == string.Empty) return;
            string filtro = "";
            System.Data.DataTable tb;
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            tb = objData.ejecutarConsulta(sql + filtro).Tables[0];
            //buscamos el ultimo mantenimiento
            tb.Columns["fechaUltimopreventivo"].ReadOnly = false;
            //tb.Columns["fechaUltimopreventivo"].DataType= typeof(DateTime);
            tb.Columns["codigoPreventivo"].ReadOnly = false;
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                    if (tb.Rows[k]["serial"].ToString().Trim() == string.Empty) continue;
                    sql = @"select codOrdenServicio,fechaProgramacion from ordenServicio where serial = '" + tb.Rows[k]["serial"].ToString().Trim() +
@"' and codTiposervicio in('PREV','PREVC') order by fechaProgramacion desc";
                System.Data.DataTable tbTmp = objData.ejecutarConsulta(sql + filtro).Tables[0];
                if (tbTmp.Rows.Count > 0)
                {
                    tb.Rows[k]["fechaUltimopreventivo"] = tbTmp.Rows[0][1];
                    tb.Rows[k]["codigoPreventivo"] = tbTmp.Rows[0][0];
                }
            
            }

            grdDatos.DataSource = tb;
            txtTotal.Text = tb.Rows.Count.ToString();
            //
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\Layout\" + "spProcesos.HerramientasAnnar.frmSeguimientoEspecial-grdDatos-controladorColumnas1.xs";
            if (System.IO.File.Exists(str))
                grdDatos.LoadLayout(str);
            //COMO HAY UNAS COLUMNAS QUE NO ESTAN VISIBLES LAS DEBEMOS OCULTAR
         
            if (grdDatos.Splits[0].DisplayColumns["Serial"].Visible)
            {
                grdDatos.Columns["Serial"].Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Count;
                grdDatos.Columns["Serial"].GroupInfo.ColumnVisible = true;
            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void frmSeguimientoEspecial_Load(object sender, EventArgs e)
        {

        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns.Count <= 0) return;
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
         
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = grdDatos.Columns["serial"].Text;
            frm.ShowDialog();
        }

        private void btnVerOrdenServicio_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codigoPreventivo"].Text != string.Empty)
            {
                //aca se deberian verificar permisos
                ordenesTrabajo.frmNuevaOrdenTrabajo frmObj = new ordenesTrabajo.frmNuevaOrdenTrabajo();
                frmObj.CodOrdenServicio = grdDatos.Columns["codigoPreventivo"].Text;
                frmObj.Show();
            } 
        }
    }
}

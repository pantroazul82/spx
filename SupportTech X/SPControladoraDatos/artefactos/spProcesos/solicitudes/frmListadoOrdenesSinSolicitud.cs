using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.solicitudes
{
    public partial class frmListadoOrdenesSinSolicitud : Form
    {
        public frmListadoOrdenesSinSolicitud()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        public int codOrdenServicio { set; get; }
        public string serial { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            codOrdenServicio = int.Parse(grdDatos.Columns["codOrdenServicio"].Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmListadoOrdenesSinSolicitud_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            #region va la cadena de la plantilla
            string sql = "   set dateformat dmy             select " +
" codOrdenServicio, fechaCreacion, fechaProgramacion, fechaFinProgramacion, " +
" fechaCierre, fechaAprobacion, fechaAnulacion, " +
" us1.nombre 'creadaPor',us4.nombre 'asignadoA' " +
" ,us5.nombre 'cerradaPor',us6.nombre 'aprobadaPor', " +
 " us7.nombre 'anuladaPor', esInterno,  " +
" v.nombreFabricante,v.NombreModelo,v.nombreTipoEquipo, " +
" v.nombreSubTipo,v.serial 'serial', " +
" clientes.nombreCliente,clientes.nitCliente, " +
" v2.nombreSucursal,v2.NombreDepartamento,v2.nombreCiudad, " +
" tipoServicio.nombretipoServicio, modalidadequipo.nombreModalidadEquipo, " +
" estadosOrdenServicio.nombreEstado, " +
 " prioridadesOrdenServicio.nombre 'prioridad', " +
" observaciones, observacionesIngeniero, fallasReportadas, diagnostico, numEntrada, horaEntradaControl, " +
 " horaSalidaControl, nombreUsuarioCliente, asesoresComerciales.NombreAsesor " +
 " from ordenServicio  " +
" left join usuario  us1 on us1.login = ordenServicio.creadaPor " +
" left join usuario  us4 on us4.login = ordenServicio.asignadoA " +
" left join usuario  us5 on us5.login = ordenServicio.cerradaPor " +
" left join usuario  us6 on us6.login = ordenServicio.aprobadaPor " +
" left join usuario  us7 on us7.login = ordenServicio.anuladaPor " +
"  " +
" left join modalidadEquipo on modalidadEquipo.codModalidadEquipo = ordenServicio.codModalidad " +
" left join asesoresComerciales on asesoresComerciales.codAsesor = ordenServicio.codAsesor " +
" join dbo.vistaEquipo v on v.serial = ordenServicio.serial " +
" join clientes on clientes.nitCliente = ordenServicio.nitcliente " +
" join dbo.VistaSucursal  v2 on v2.nitCliente = ordenServicio.nitCliente and v2.codSucursal = ordenServicio.codSucursal " +
" left join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio " +
" join estadosOrdenServicio on estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio " +
" left join prioridadesOrdenServicio on prioridadesOrdenServicio.codPrioridadOS = ordenServicio.codPrioridadOS ";

            #endregion

            sql += " WHERE ";

            //agregamos los filtros dependiendo lo escogido en el combo
 sql += " ordenServicio.serial = '" + serial + "' ";
 dsPlantillas1.EnforceConstraints = false;
            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoOrdenServicio.Clear();
            dsPlantillas1.pltListadoOrdenServicio.Merge(objD.ejecutarConsulta(sql + " order by ordenServicio.codOrdenservicio desc").Tables[0]);
            if (dsPlantillas1.pltListadoOrdenServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron resultados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

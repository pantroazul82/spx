using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmVincularOrdenExistente : Form
    {
        public frmVincularOrdenExistente()
        {
            InitializeComponent();
        }

        public string serial { set; get; }

        public List<int> ordenesElegidas { set; get; }

        private void frmVincularOrdenExistente_Load(object sender, EventArgs e)
        {
            lblSerial.Text = serial;

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

            sql+=" WHERE ";
            //agregamos los filtros dependiendo lo escogido en el combo
            sql += " ordenServicio.serial = '" + lblSerial.Text + "' ";
            sql += " and (porContrato is null or porContrato =0) ";
        
            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoOrdenServicio.Clear();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltListadoOrdenServicio.Merge(objD.ejecutarConsulta(sql + " order by ordenServicio.codOrdenservicio desc").Tables[0]);
            if (dsPlantillas1.pltListadoOrdenServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron ordenes abiertas asociadas a este serial", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (grdDatos.Columns["codOrdenServicio"].Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar una orden de servicio!");
                    return;
                }
            int orden = int.Parse(grdDatos.Columns["codOrdenServicio"].Text);
            if(ordenesElegidas.Contains(orden))
            {
                MessageBox.Show("Esta orden ya fue vinculada previmente!");
                return;
            }
            ordenesElegidas.Add(orden);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmInformacionEquipo info = new Equipos.frmInformacionEquipo();
            info.Serial = lblSerial.Text;
            info.ShowDialog();
        }
    }
}

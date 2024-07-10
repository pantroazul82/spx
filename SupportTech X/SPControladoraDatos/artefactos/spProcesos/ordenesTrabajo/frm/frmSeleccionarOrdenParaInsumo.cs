using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo.frm
{
    public partial class frmSeleccionarOrdenParaInsumo : Form
    {
        public frmSeleccionarOrdenParaInsumo()
        {
            InitializeComponent();
        }

        private bool cargarserial(string serial)
        {
            //miramos si existe el serial
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
            if (dsSpx1.equipos.Rows.Count <= 0)
            {
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }
             //
            fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx1.fabricante, dsSpx1.equipos[0].codFabricante.Trim());
            txtFabricante.Text = dsSpx1.fabricante[0].nombre_fabricante;
            //
            modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx1.Modelos, dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
            txtModelo.Text = dsSpx1.Modelos[0].NombreModelo;

      

           
                if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
                {
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(
                        dsSpx1.equipos[0].codModalidadEquipo
                        ).ToString();
                }
           

            
            return true;
        }


        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text);
            }
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese un serial");
                return;
            }
            buscar();
        }

               private void buscar()
        {
            #region va la cadena de la plantilla
            string sql = "   set dateformat dmy select top " +cmbTop.Text.ToString()
                +" codOrdenServicio, fechaCreacion, fechaProgramacion, fechaFinProgramacion, " +
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
 " horaSalidaControl, nombreUsuarioCliente, asesoresComerciales.NombreAsesor,mantenimientoSegunIndicaciones,fechaUltimoMantenimientoxUsuario " +
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
 sql += " ordenServicio.serial = '" + txtSerial.Text + "' "; 


          

            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoOrdenServicio.Clear();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltListadoOrdenServicio.Merge(objD.ejecutarConsulta(sql + " order by ordenServicio.codOrdenservicio desc").Tables[0]);
            if (dsPlantillas1.pltListadoOrdenServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron resultados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

               private void btnGenerarSolicitudInsumos_Click(object sender, EventArgs e)
               {
                   if (grdDatos.Columns["codOrdenServicio"].Text == string.Empty)
                   {
                       MessageBox.Show("Seleccione una orden");
                       return;
                   }
                   frmSolicitudInsumos fr = new frmSolicitudInsumos();
                   fr.CodOrdenServicio = grdDatos.Columns["codOrdenServicio"].Text;
                   fr.ShowDialog();
                   this.Close();
               }

               private void frmSeleccionarOrdenParaInsumo_Load(object sender, EventArgs e)
               {
                   cmbTop.SelectedIndex = 0;
               }

               private void txtSerial_Validated(object sender, EventArgs e)
               {

               }

               private void txtSerial_KeyDown(object sender, KeyEventArgs e)
               {
                   if (e.KeyCode == Keys.Enter)
                   {
                       spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
                       if (fr.ShowDialog() == DialogResult.OK)
                       {
                           txtSerial.Text = fr.Serial;
                           txtSerial.Focus();
                           cargarserial(txtSerial.Text);
                       }
                   }
               }

               private void txtSerial_DoubleClick(object sender, EventArgs e)
               {
                   spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
                   if (fr.ShowDialog() == DialogResult.OK)
                   {
                       txtSerial.Text = fr.Serial;
                       txtSerial.Focus();
                       cargarserial(txtSerial.Text);
                   }
               }

               private void txtSerial_Validating(object sender, CancelEventArgs e)
               {
                   if (txtSerial.Text.Trim() == string.Empty) return;
                   e.Cancel = !cargarserial(txtSerial.Text);
                   if (e.Cancel) txtSerial.Text = "";
               }
    }
}

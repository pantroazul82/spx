using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo.frm
{
    public partial class frmDisponibilidad : Form
    {
        public frmDisponibilidad()
        {
            InitializeComponent();
        }

        private DateTime fechaInicio = DateTime.Now;
        private DateTime fechaFin = DateTime.Now;
        private string ingenieroAsignado = "";

        public DateTime FechaInicio { set { fechaInicio = value; } get { return fechaInicio; } }
        public DateTime FechaFin { set { fechaFin = value; } get { return fechaFin; } }
        public string ingenieroASignado { set { ingenieroAsignado = value; } get { return ingenieroAsignado; } }

        bool cargando = false;
        DateTime ultimaFecha;
        private void frmDisponibilidad_Load(object sender, EventArgs e)
        {
            cargando = true;
            //cargamos el combo con los ingenieros
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            
            cmbIngeniero.SelectedValue = ingenieroASignado;
            ultimaFecha = fechaInicio;
            contextMenuStrip1.Items.Add("Ver Orden de Servicio");
            contextMenuStrip1.Items.Add("Ver Resumen");
            calendario.GoToDate(fechaInicio);
            cargarOrdenesDiaingeniero();
            cargando = false;
        }

        public string sentenciaMaestraSchedulle(string filtroOrdenServicio, string filtroActividades)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" set dateformat ymd ");
            sb.Append(" select ");
            sb.Append(" codOrdenServicio,fechaProgramacion,fechaFinProgramacion, ");
            sb.Append(" 'OS: '+cast(codOrdenServicio as char(5))+ ");
            sb.Append(" '@i@Estado:'+nombreEstado+ ");
            sb.Append(" '@i@Tipo de Servicio: '+rtrim(tipoServicio.nombretipoServicio)+ ");
            sb.Append(" '@i@Equipo: '+v.NombreModelo+' ('+v.nombreFabricante+')'+ ");
            sb.Append(" '@i@Serial:'+v.serial+ ");
            sb.Append(" '@i@'+ordenServicio.observaciones ");
            sb.Append(" 'cuerpo', ");
            sb.Append(" rtrim(tipoServicio.nombretipoServicio)+': '+ ");
            sb.Append(" v.NombreModelo+' ('+v.nombreFabricante+')' ");
            sb.Append(" 'asunto', ");
            sb.Append(" rtrim(clientes.nombreCliente)+'- ('+ dbo.vistaSucursal.nombreDepartamento +', '+dbo.vistaSucursal.nombreCiudad+')' ");
            sb.Append(" 'ubicacion', ");
            sb.Append(" ordenServicio.codEstadoOrdenServicio ");
            sb.Append(" from ordenServicio ");
            sb.Append(" join clientes on clientes.nitCliente = ordenServicio.nitCliente ");
            sb.Append(" join dbo.vistaSucursal on dbo.vistaSucursal.nitCliente = ordenServicio.nitcliente and dbo.vistaSucursal.codSucursal = ordenServicio.codSucursal ");
            sb.Append(" join dbo.vistaEquipo v on v.serial = ordenServicio.serial ");
            sb.Append(" join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio ");
            sb.Append(" join estadosOrdenServicio on estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio ");
            sb.Append(filtroOrdenServicio);

            sb.Append(" union ");

            sb.Append(" select cod_actividad_adicional 'codigo',fecha_inicio,fecha_fin, ");
            sb.Append(" 'Actividad: '+nombre_actividad+' Ubicacion:'+ubicacion+' '+ descripcion_actividad +' ' as  'Cuerpo', ");
            sb.Append(" 'Actividad: '+nombre_actividad +' ' asunto, ");
            sb.Append(" 'Ubicacion:'+ubicacion+' ' 'Ubicacion','PROGR' estado ");
            sb.Append(" from actividad_adicional ");
            sb.Append(filtroActividades);
            return sb.ToString();
        }

        private void cargarOrdenesDiaingeniero() 
        {
            if (ultimaFecha.Year < 2000) return;

            dsPlantillas1.pltOrdenServicioSchedulle.Clear();
            if (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString().Trim() == string.Empty)
                return;

            DateTime fechaInicio = ultimaFecha.AddDays(ultimaFecha.Day - 1).AddMonths(-1);
            DateTime fechaFin = ultimaFecha.AddDays(ultimaFecha.Day - 1).AddMonths(2);
            string fIni = fechaInicio.Year + "/" + fechaInicio.Month.ToString().PadLeft(2, '0') + "/" + fechaInicio.Day.ToString().PadLeft(2, '0');
            string fFin = fechaFin.Year + "/" + fechaFin.Month.ToString().PadLeft(2, '0') + "/" + fechaFin.Day.ToString().PadLeft(2, '0');

            string filtroOrden = " where " +
" ordenServicio.asignadoA= '" + cmbIngeniero.SelectedValue + "' " +
" and fechaprogramacion between '" + fIni + "' and '" + fFin + "' ";

            string filtroActividad = " where " +
" actividad_adicional.login = '" + cmbIngeniero.SelectedValue + "' " +
" and fecha_inicio between '" + fIni + "' and '" + fFin + "' ";
            dsPlantillas1.pltOrdenServicioSchedulle.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltOrdenServicioSchedulle.Merge(
            objData.ejecutarConsulta(sentenciaMaestraSchedulle(filtroOrden, filtroActividad)).Tables[0]
            );

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbIngeniero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            cargarOrdenesDiaingeniero();
        }

        private void calendario_SelectedDaysChanged(object sender, EventArgs e)
        {
            
        }

        private void calendario_BeforeAppointmentShow(object sender, C1.C1Schedule.CancelAppointmentEventArgs e)
        {
            if (e.Appointment == null) return;

            if (e.Appointment.Subject.IndexOf("Actividad:") == 0)
            {
                SpFrm.actividades.frmNuevaActividad fr = new SpFrm.actividades.frmNuevaActividad();
                fr.codActividad = int.Parse(e.Appointment.Key[0].ToString());
                fr.editable = false;
                fr.Show();
            }
            else
            {
                spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new frmNuevaOrdenTrabajo();
                fr.CodOrdenServicio = e.Appointment.Key[0].ToString();
                fr.ShowDialog();
            }
        }

        bool cancelarMostrarMenu = false;

        private void calendario_BeforeContextMenuShow(object sender, C1.Win.C1Schedule.BeforeContextMenuShowEventArgs e)
        {
            cancelarMostrarMenu = false;
            if (e.Appointment == null)
            {
                cancelarMostrarMenu = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = cancelarMostrarMenu;
        }

        private void calendario_SelectedIntervalChanged(object sender, C1.Win.C1Schedule.SelectedIntervalChangedEventArgs e)
        {
            if (cargando) return;
            try
            {
                if (ultimaFecha.Month != calendario.SelectedDates[0].Month)
                {
                    ultimaFecha = calendario.SelectedDates[0];
                    cargarOrdenesDiaingeniero();
                }
            }catch{
                
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (calendario.SelectedAppointments == null || calendario.SelectedAppointments.Count <= 0) return;
            if (e.ClickedItem.Text.Trim() == "Ver Orden de Servicio")
            {
                if (calendario.SelectedAppointments[0].Subject.IndexOf("Actividad:") == 0)
                {
                    SpFrm.actividades.frmNuevaActividad fr = new SpFrm.actividades.frmNuevaActividad();
                    fr.codActividad = int.Parse(calendario.SelectedAppointments[0].Key[0].ToString());
                    fr.editable = false;
                    fr.Show();
                }else{

                    spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();

                    fr.CodOrdenServicio = calendario.SelectedAppointments[0].Key[0].ToString();
                    fr.Show();
                }
            }
            else if (e.ClickedItem.Text.Trim() == "Ver Resumen")
            {
                if (calendario.SelectedAppointments[0].Subject.IndexOf("Actividad:") == 0)
                {
                    SpFrm.actividades.frmNuevaActividad fr = new SpFrm.actividades.frmNuevaActividad();
                    fr.codActividad = int.Parse(calendario.SelectedAppointments[0].Key[0].ToString());
                    fr.editable = false;
                    fr.Show();
                }
                else
                {
                    Application.DoEvents();
                    contextMenuStrip1.Visible = false;
                    MessageBox.Show(
                        "Inicia:" + calendario.SelectedAppointments[0].Start + "\nTermina:" + calendario.SelectedAppointments[0].End + "\n" +
                        "Ubicacion:" + calendario.SelectedAppointments[0].Location + "\n" +
                        "Resumen:\n" + calendario.SelectedAppointments[0].Body.Replace("@i@", "\n") + "\n"
                    , "Resumen Orden", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }
            }
        }
    }
}

using SPControladoraDatos.artefactos.SPXUtilidades.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spHorarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            controladorColumnasListadoLlamadas1.grilla = grdLlamadas;
            controladorColumnasSeguimientoLlamadas.grilla = grdSeguimientosProgramados;

            controladorColumnasEntradaSinSalida.grilla = grdEntradasSinSalida;
            controladorColumnasEntradasSinOrden.grilla = grdEntradasSinOrden;
            controladorColumnasEntradasSinSeguimiento.grilla = grdEntradasSinSeguimiento;

            controladorColumnasContratosxVencer.grilla = grdContratosxVencer;
            controladorColumnasContratoVencido.grilla = grdContratosVencidos;
        }

        string estadoEnEspera = "";

        private void cargarPermisos() 
        {
            //miramos si tiene los permisos
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1081)) tabMisActividades.Visible = false;
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1014)) tabActividadesIng.Visible = false;
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1046)) tabLlamadas.Visible = false;
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1084)) tabListadoEntradas.Visible = false;
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1029)) tabContratos.Visible = false;
        }

        private void actualizar()
        {
            cargarPermisos();
            //dependiendo el tab que este abierto actualiza
            //tab mis ordenes
            if (tabEntradas.SelectedTab.Text == "Mis Actividades")
            {
                cargarCalendario();
                pltListadoOrdenServicioTableAdapter1.FillByIngenieropendietesRespuesta(dsMisOrdenesEnEspera.pltListadoOrdenServicio, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
                pltListadoOrdenServicioTableAdapter1.FillByPendientesIngeniero(dsMisOrdenes.pltListadoOrdenServicio, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
            }else if (tabEntradas.SelectedTab.Text == "Actividades de Ingenieros")
            {
                if (cmbIngenieros.SelectedValue != null && cmbIngenieros.SelectedValue.ToString().Trim() != string.Empty)
                {
                    cargarCalendarioIngeniero();
                    pltListadoOrdenServicioTableAdapter1.FillByIngenieropendietesRespuesta(dsOrdenesIngenieroEnEspera.pltListadoOrdenServicio, cmbIngenieros.SelectedValue.ToString());
                    pltListadoOrdenServicioTableAdapter1.FillByPendientesIngeniero(dsOrdenesIngeniero.pltListadoOrdenServicio, cmbIngenieros.SelectedValue.ToString());
                }else{
                    dsPlantillasIngenieros.pltOrdenServicioSchedulle.Clear();
                    dsOrdenesIngenieroEnEspera.pltListadoOrdenServicio.Clear();
                    dsOrdenesIngeniero.pltListadoOrdenServicio.Clear();
                }
            }else if (tabEntradas.SelectedTab.Text == "Llamadas Tecnicas")
            {
                cargarListadoLlamadas();
            }else if (tabEntradas.SelectedTab.Text == "Entradas")
            {
                actualizarEntradas();
            }else if (tabEntradas.SelectedTab.Text == "Contratos")
            {
                cargarContratos();
            }
            
        }

        DateTime ultimafecha;
        DateTime ultimafechaIngeniero;
        DateTime nn;
        private bool eventosEncendidos = false;
        public bool TestMode { set; get; } 

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.TestMode) return;
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            nn = dc.fechaServer;

            dsPlantillasIngenieros.EnforceConstraints = false;
            dsMisOrdenes.EnforceConstraints = false;
            dsMisOrdenesEnEspera.EnforceConstraints = false;
            dsOrdenesIngeniero.EnforceConstraints = false;
            dsOrdenesIngenieroEnEspera.EnforceConstraints = false;
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillasIngenieros.EnforceConstraints = false;
            dsSpx1.EnforceConstraints = false;
            

            calListadoLlamadas.Value = nn.AddDays(-20);
            cargarInfoGrillas();
            cargarConfigColores();
            estadoEnEspera = estadosOrdenServicioTableAdapter1.GetData()
                .Select("codEstadoOrdenServicio='ENESP'")[0]["nombreEstado"].ToString().Trim();
            
            eventosEncendidos = false;
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            lblIngeniero.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
            

            cmbIngenieros.SelectedValue = "";

            contextMenuStrip1.Items.Add("Ver Orden de Servicio");
            contextMenuStrip1.Items.Add("Ver Resumen");
            //
            contextMenuIngeniero.Items.Add("Ver Orden de Servicio");
            contextMenuIngeniero.Items.Add("Ver Resumen");
       
            calendarioIngeniero.GoToDate(nn);
            calendario.GoToDate(nn);
            ultimafecha = nn;
            ultimafechaIngeniero = nn;
            eventosEncendidos = true;
            actualizar();
            
        }

        public string sentenciaMaestraSchedulle(string filtroOrdenServicio,string filtroActividades) 
        {
            System.Text.StringBuilder sb=new StringBuilder();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizar();
        }
        private void tabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            actualizar();
        }
        #region mis actividades

        private void cargarCalendario()
        {
           
            if (ultimafecha.Year < 2000) return;
            DateTime fechaInicio = ultimafecha.AddDays(ultimafecha.Day-1).AddMonths(-1);
            DateTime fechaFin = ultimafecha.AddDays(ultimafecha.Day-1).AddMonths(2);
            string fIni = fechaInicio.Year + "/" + fechaInicio.Month.ToString().PadLeft(2,'0') + "/"+ fechaInicio.Day.ToString().PadLeft(2,'0');
            string fFin = fechaFin.Year + "/" + fechaFin.Month.ToString().PadLeft(2, '0') + "/" + fechaFin.Day.ToString().PadLeft(2, '0');

            string filtroOrden = " where " +
" ordenServicio.asignadoA= '" + SPXSeguridad.logica.sesion.LoginUsuarioAutenticado + "' " +
" and fechaprogramacion between '" + fIni + "' and '" + fFin + "' ";

            string filtroActividad = " where " +
" actividad_adicional.login = '" + SPXSeguridad.logica.sesion.LoginUsuarioAutenticado + "' " +
" and fecha_inicio between '" + fIni + "' and '" + fFin + "' ";
            dsPlantillas1.pltOrdenServicioSchedulle.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltOrdenServicioSchedulle.Merge(
              objData.ejecutarConsulta( sentenciaMaestraSchedulle(filtroOrden, filtroActividad)).Tables[0]
            );
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calendario.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.DayView;
            calendario.GoToDate(n);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            calendario.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.MonthView;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calendario.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WeekView;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calendario.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            calendario.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.DayView;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void c1Calendar1_SelectionChanged(object sender, C1.Win.C1Schedule.SelectionChangedEventArgs e)
        {
            if (calendario.SelectedDates.Length > 0)
                if (calendario.SelectedDates[0].Year != ultimafecha.Year || calendario.SelectedDates[0].Month != ultimafecha.Month)
                {
                    ultimafecha = calendario.SelectedDates[0];
                    cargarCalendario();
                }
        }

        private void calendario_BeforeAppointmentShow(object sender, C1.C1Schedule.CancelAppointmentEventArgs e)
        {
            if (e.Appointment == null) return;
            frmResumen fr = new frmResumen();
            fr.codOrdenServicio = int.Parse(e.Appointment.Key[0].ToString());
            fr.cuerpo = e.Appointment.Body;
            fr.ubicacion = e.Appointment.Location;
            fr.asunto = e.Appointment.Subject;
            fr.fechaInicio = e.Appointment.Start;
            fr.fechaFin = e.Appointment.End;
            fr.ShowDialog();
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
            }else if (e.ClickedItem.Text.Trim() == "Ver Resumen")
                {
                    if (calendario.SelectedAppointments[0].Subject.IndexOf("Actividad:")==0)
                    {
                        SpFrm.actividades.frmNuevaActividad fr = new SpFrm.actividades.frmNuevaActividad();
                        fr.codActividad = int.Parse(calendario.SelectedAppointments[0].Key[0].ToString());
                        fr.editable = false;
                        fr.Show();
                    }else{
                        frmResumen fr = new frmResumen();
                        fr.codOrdenServicio = int.Parse(calendario.SelectedAppointments[0].Key[0].ToString());
                        fr.cuerpo = calendario.SelectedAppointments[0].Body;
                        fr.ubicacion = calendario.SelectedAppointments[0].Location;
                        fr.asunto = calendario.SelectedAppointments[0].Subject;
                        fr.fechaInicio = calendario.SelectedAppointments[0].Start;
                        fr.fechaFin = calendario.SelectedAppointments[0].End;
                        fr.ShowDialog();
                    }
                }
        }

        private void grdASignadas_DoubleClick(object sender, EventArgs e)
        {
            if (grdASignadas.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdASignadas.Columns["codOrdenServicio"].Text;
            fr.Show();
        }

        private void grdRespuesta_DoubleClick(object sender, EventArgs e)
        {
            if (grdRespuesta.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdRespuesta.Columns["codOrdenServicio"].Text;
            fr.Show();
        }
        
        private void grdASignadas_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
          
            if (!eventosEncendidos) return;
            if (dsMisOrdenes.pltListadoOrdenServicio[grdASignadas.RowBookmark(e.Row)].IsfechaProgramacionNull())
                return;
            DateTime f = dsMisOrdenes.pltListadoOrdenServicio[grdASignadas.RowBookmark(e.Row)].fechaProgramacion;
            if (nn.Subtract(f).TotalDays > SPControladoraDatos.Properties.Settings.Default.limiteTres)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel3;
            }
            else if (nn.Subtract(f).TotalDays > SPControladoraDatos.Properties.Settings.Default.limiteDos)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel2;
            }
            else if (DateTime.Now.Subtract(f).TotalDays > SPControladoraDatos.Properties.Settings.Default.limiteUno)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel1;
            }

            if (dsMisOrdenes.pltListadoOrdenServicio[grdASignadas.RowBookmark(e.Row)].prioridad.ToUpper().IndexOf("ALTA") >= 0)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.prioridadAlta;
            }//ENESP
            if (dsMisOrdenes.pltListadoOrdenServicio[grdASignadas.RowBookmark(e.Row)].nombreEstado.Trim() == estadoEnEspera)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.esperaRespuesta;
            }//ENESP
        }
        #endregion
        /// ////////////////

        #region actividades ingeniero
        private void cmbIngenieros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            actualizar();
        }

        private void cargarCalendarioIngeniero()
        {
            if (ultimafechaIngeniero.Year < 2000) return;
                dsPlantillasIngenieros.pltOrdenServicioSchedulle.Clear();
            if (cmbIngenieros.SelectedValue == null || cmbIngenieros.SelectedValue.ToString().Trim() == string.Empty)
                return;

            DateTime fechaInicio = ultimafechaIngeniero.AddDays(ultimafechaIngeniero.Day -1 ).AddMonths(-1);
            DateTime fechaFin = ultimafechaIngeniero.AddDays(ultimafecha.Day -1).AddMonths(2);
            string fIni = fechaInicio.Year + "/" + fechaInicio.Month.ToString().PadLeft(2, '0') + "/" + fechaInicio.Day.ToString().PadLeft(2, '0');
            string fFin = fechaFin.Year + "/" + fechaFin.Month.ToString().PadLeft(2, '0') + "/" + fechaFin.Day.ToString().PadLeft(2, '0');

            string filtroOrden = " where " +
" ordenServicio.asignadoA= '" + cmbIngenieros.SelectedValue + "' " +
" and fechaprogramacion between '" + fIni + "' and '" + fFin + "' ";

            string filtroActividad = " where " +
" actividad_adicional.login = '" + cmbIngenieros.SelectedValue + "' " +
" and fecha_inicio between '" + fIni + "' and '" + fFin + "' ";
            dsPlantillasIngenieros.pltOrdenServicioSchedulle.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillasIngenieros.pltOrdenServicioSchedulle.Merge(
              objData.ejecutarConsulta(sentenciaMaestraSchedulle(filtroOrden, filtroActividad)).Tables[0]
            );

        }

        private void contextMenuIngeniero_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = cancelarMostrarMenuIng;
        }

        private void contextMenuIngeniero_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (calendarioIngeniero.SelectedAppointments == null || calendarioIngeniero.SelectedAppointments.Count <= 0) return;
            if (e.ClickedItem.Text.Trim() == "Ver Orden de Servicio")
            {
                if (calendarioIngeniero.SelectedAppointments[0].Subject.IndexOf("Actividad:") == 0)
                {
                    SpFrm.actividades.frmNuevaActividad fr = new SpFrm.actividades.frmNuevaActividad();
                    fr.codActividad = int.Parse(calendarioIngeniero.SelectedAppointments[0].Key[0].ToString());
                    fr.editable = false;
                    fr.Show();
                }else{
                    spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
                    fr.CodOrdenServicio = calendarioIngeniero.SelectedAppointments[0].Key[0].ToString();
                    fr.Show();
                }
            }
            else if (e.ClickedItem.Text.Trim() == "Ver Resumen")
            {
                if (calendarioIngeniero.SelectedAppointments[0].Subject.IndexOf("Actividad:") == 0)
                {
                    SpFrm.actividades.frmNuevaActividad fr = new SpFrm.actividades.frmNuevaActividad();
                    fr.codActividad = int.Parse(calendarioIngeniero.SelectedAppointments[0].Key[0].ToString());
                    fr.editable = false;
                    fr.Show();
                }
                else
                {
                    frmResumen fr = new frmResumen();
                    fr.codOrdenServicio = int.Parse(calendarioIngeniero.SelectedAppointments[0].Key[0].ToString());
                    fr.cuerpo = calendarioIngeniero.SelectedAppointments[0].Body;
                    fr.ubicacion = calendarioIngeniero.SelectedAppointments[0].Location;
                    fr.asunto = calendarioIngeniero.SelectedAppointments[0].Subject;
                    fr.fechaInicio = calendarioIngeniero.SelectedAppointments[0].Start;
                    fr.fechaFin = calendarioIngeniero.SelectedAppointments[0].End;
                    fr.ShowDialog();
                }
            }
        }

        private void calendarioIngeniero_BeforeAppointmentShow(object sender, C1.C1Schedule.CancelAppointmentEventArgs e)
        {
            if (e.Appointment == null) return;
            frmResumen fr = new frmResumen();
            fr.codOrdenServicio = int.Parse(e.Appointment.Key[0].ToString());
            fr.cuerpo = e.Appointment.Body;
            fr.ubicacion = e.Appointment.Location;
            fr.asunto = e.Appointment.Subject;
            fr.fechaInicio = e.Appointment.Start;
            fr.fechaFin = e.Appointment.End;
            fr.ShowDialog();
        }
        bool cancelarMostrarMenuIng = false;
        private void calendarioIngeniero_BeforeContextMenuShow(object sender, C1.Win.C1Schedule.BeforeContextMenuShowEventArgs e)
        {
            cancelarMostrarMenuIng = false;
            if (e.Appointment == null)
            {
                cancelarMostrarMenuIng = true;
            }
        }

        private void btnDiaIng_Click(object sender, EventArgs e)
        {
            calendarioIngeniero.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.DayView;
        }

        private void btn5ing_Click(object sender, EventArgs e)
        {
            calendarioIngeniero.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
        }

        private void btn7Ing_Click(object sender, EventArgs e)
        {
            calendarioIngeniero.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WeekView;
        }

        private void btn30Ing_Click(object sender, EventArgs e)
        {
            calendarioIngeniero.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.MonthView;
        }

        private void btnHoyIngeniero_Click(object sender, EventArgs e)
        {
            calendarioIngeniero.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.DayView;
            calendarioIngeniero.GoToDate(DateTime.Now);
        }

        private void btnActualizarIngeniero_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void c1CalendarIng_SelectionChanged(object sender, C1.Win.C1Schedule.SelectionChangedEventArgs e)
        {
            if (calendarioIngeniero.SelectedDates.Length > 0)
                if (calendarioIngeniero.SelectedDates[0].Year != ultimafechaIngeniero.Year || calendarioIngeniero.SelectedDates[0].Month != ultimafechaIngeniero.Month)
                {
                    ultimafechaIngeniero = calendarioIngeniero.SelectedDates[0];
                    cargarCalendarioIngeniero();
                }
        }

        private void grdOrdenesIngenieroEspRespuesta_DoubleClick(object sender, EventArgs e)
        {
                     if (grdOrdenesIngenieroEspRespuesta.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdOrdenesIngenieroEspRespuesta.Columns["codOrdenServicio"].Text;
            fr.Show();
        }

        private void grdOrdenesIngeniero_DoubleClick(object sender, EventArgs e)
        {
                    if (grdOrdenesIngeniero.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdOrdenesIngeniero.Columns["codOrdenServicio"].Text;
            fr.Show();
        }

        private void grdOrdenesIngeniero_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
            if (!eventosEncendidos) return;
            if (grdOrdenesIngeniero.RowBookmark(e.Row) < 0) return;

            if (dsOrdenesIngeniero.pltListadoOrdenServicio[grdOrdenesIngeniero.RowBookmark(e.Row)].IsfechaProgramacionNull())
                return;
            DateTime f = dsOrdenesIngeniero.pltListadoOrdenServicio[grdOrdenesIngeniero.RowBookmark(e.Row)].fechaProgramacion;
           
           if (DateTime.Now.Subtract(f).TotalDays > SPControladoraDatos.Properties.Settings.Default.limiteTres)
           {
               e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel3;
           }else if (DateTime.Now.Subtract(f).TotalDays > SPControladoraDatos.Properties.Settings.Default.limiteDos)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel2;
            }else if (DateTime.Now.Subtract(f).TotalDays > SPControladoraDatos.Properties.Settings.Default.limiteUno)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel1;
            }

            if (dsOrdenesIngeniero.pltListadoOrdenServicio[grdOrdenesIngeniero.RowBookmark(e.Row)].prioridad.ToUpper().IndexOf("ALTA") >= 0)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.prioridadAlta;
            }//ENESP
            if (dsOrdenesIngeniero.pltListadoOrdenServicio[grdOrdenesIngeniero.RowBookmark(e.Row)].nombreEstado.Trim() == estadoEnEspera)
            {
                e.CellStyle.BackColor = SPControladoraDatos.Properties.Settings.Default.esperaRespuesta;
            }//ENESP
        }


        private void btnEsquemaColores_Click(object sender, EventArgs e)
        {
            frmConfigurarColores fr = new frmConfigurarColores();
            fr.ShowDialog();
            cargarConfigColores();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmConfigurarColores fr = new frmConfigurarColores();
            fr.ShowDialog();
            cargarConfigColores();
        }
       private void btnExcelMis1_Click(object sender, EventArgs e)
        {
            clsExportarExcel obj = new clsExportarExcel();
            obj.exportar(grdASignadas, "Mis Ordenes", false);
        }
        public void cargarConfigColores()
        {
            lblNivel1.Text = SPControladoraDatos.Properties.Settings.Default.limiteUno+" dias de retrazo";
            lblNivel2.Text = SPControladoraDatos.Properties.Settings.Default.limiteDos + " dias de retrazo";
            lblNivel3.Text = SPControladoraDatos.Properties.Settings.Default.limiteTres + " dias de retrazo";
            picEnespera.BackColor = SPControladoraDatos.Properties.Settings.Default.esperaRespuesta;
            picPrioridadAlta.BackColor = SPControladoraDatos.Properties.Settings.Default.prioridadAlta;
            picNivel1.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel1;
            picNivel2.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel2;
            picnivel3.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel3;
            //--
            lblNivel1b.Text = SPControladoraDatos.Properties.Settings.Default.limiteUno + " dias de retrazo";
            lblnivel2b.Text = SPControladoraDatos.Properties.Settings.Default.limiteDos + " dias de retrazo";
            lblNivel3b.Text = SPControladoraDatos.Properties.Settings.Default.limiteTres + " dias de retrazo";
            picEnEsperab.BackColor = SPControladoraDatos.Properties.Settings.Default.esperaRespuesta;
            picPrioridadAltab.BackColor = SPControladoraDatos.Properties.Settings.Default.prioridadAlta;
            picNivel1b.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel1;
            picNivel2b.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel2;
            picNivel3b.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel3;
        }
        #endregion

        #region guarda la configuracion de las grillas del calendario
        private void cargarInfoGrillas()
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\segGrdRespuestaInicioLayt.xs";
            if(System.IO.File.Exists(str))  grdRespuesta.LoadLayout(str);
            
            str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\seggrdASignadasInicioLayt.xs";
            if (System.IO.File.Exists(str)) grdASignadas.LoadLayout(str);
            
            str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\seggrdOrdenesIngenieroInicioLayt.xs";
            if (System.IO.File.Exists(str)) grdOrdenesIngeniero.LoadLayout(str);

            str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\seggrdOrdenesIngenieroEspRespuestaInicioLayt.xs";
            if (System.IO.File.Exists(str)) grdOrdenesIngenieroEspRespuesta.LoadLayout(str);
        }

        private void btnGuardarGrdRespuesta_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\segGrdRespuestaInicioLayt.xs";
            grdRespuesta.SaveLayout(str);
            MessageBox.Show("Los cambios en la grilla se guardaron satisfactoriamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
        }

        private void btnRestaurargrdRespuestas_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\segGrdRespuestaInicioLayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando Inicie de nuevo el software.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGuardargrdAsignadas_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\seggrdASignadasInicioLayt.xs";
            grdASignadas.SaveLayout(str);
            MessageBox.Show("Los cambios en la grilla se guardaron satisfactoriamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReinicciargrdasignadas_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\seggrdASignadasInicioLayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando Inicie de nuevo el software.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
        }

        private void btnGuardarGrdIngAsignadas_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\seggrdOrdenesIngenieroInicioLayt.xs";
            grdOrdenesIngeniero.SaveLayout(str);
            MessageBox.Show("Los cambios en la grilla se guardaron satisfactoriamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestaurarGrdOrdenesINg_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\seggrdOrdenesIngenieroInicioLayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando Inicie de nuevo el software.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
        }

        private void btnGuardarGrdIngEspRespuesta_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\seggrdOrdenesIngenieroEspRespuestaInicioLayt.xs";
            grdOrdenesIngenieroEspRespuesta.SaveLayout(str);
            MessageBox.Show("Los cambios en la grilla se guardaron satisfactoriamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestaurarGrdIngEspRespuesta_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\seggrdOrdenesIngenieroEspRespuestaInicioLayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando Inicie de nuevo el software.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnMisASignadasHorario_Click(object sender, EventArgs e)
        {
            clsExportarExcel obj = new clsExportarExcel();
            obj.exportar(grdOrdenesIngeniero, "Ordenes Ingeniero", false);
        }
#endregion

        #region llamadas
        private string generarSQLListadoLLamadas()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" set dateformat dmy ");
            sb.Append(" select ");
            sb.Append(" solucionado,fechaCierre,us2.nombre 'cerradaPor',usuarios.nombre 'abiertaPor',");
            sb.Append(" idLlamadaSoporte,codEstadoLlamadaTecnica,nombreEstado,fechaLlamada,llamadaRecibida,");
            sb.Append(" clientes.nitCliente,clientes.nombreCliente,clientes.numeroSocio,");
            sb.Append(" contactosClientes.nombreContacto,contactosClientes.apellidosContacto,contactosClientes.telefono1 'telefono1Contacto',contactosClientes.telefono2 'telefono2Contacto',");
            sb.Append(" contactosClientes.celular 'celularcontacto',contactosClientes.email 'emailContacto',infAdicionalContacto,");
            sb.Append(" v.nombreSucursal,v.Direccion 'direccionSucursal',");
            sb.Append(" v.Telefono1 'telefono1Sucursal',v.Telefono2 'telefono2Sucursal',v.NombreDepartamento,v.nombreCiudad");
            sb.Append(" ,v2.serial,v2.nombreModelo,v2.nombreFabricante,v2.nombreTipoEquipo,v2.nombreSubTipo");
            sb.Append(" ,nombreModalidadEquipo");
            sb.Append(" ,obsCliente,obsAsesorTelefonico,obsFinales");
            sb.Append(" from LlamadaSoporte");
            sb.Append(" join estadosLLamadasTecnicas on estadosLLamadasTecnicas.codEstadoLlamada = LlamadaSoporte.codEstadoLlamadaTecnica ");
            sb.Append(" join usuario usuarios on usuarios.login = LlamadaSoporte.asesorTelefonico  ");
            sb.Append(" left join usuario us2 on us2.login = LlamadaSoporte.cerradaPor ");
            sb.Append(" join clientes on clientes.nitCliente  =LlamadaSoporte.nitCliente  ");
            sb.Append(" join dbo.vistaSucursal v on v.nitCliente = clientes.nitCliente and v.codSucursal = LlamadaSoporte.codUbicacion  ");
            sb.Append(" join contactosClientes on contactosClientes.nitCliente =LlamadaSoporte.nitCliente and   LlamadaSoporte.codContacto = contactosClientes.codContacto");
            sb.Append(" join dbo.vistaEquipo v2 on v2.serial =  LlamadaSoporte.serial ");
            return sb.ToString();
        }

        private void cargarListadoLlamadas()
        {
            string sql = generarSQLListadoLLamadas();
            sql = sql + " where fechaLlamada between "+
                "'" + calListadoLlamadas.Value.Day.ToString().PadLeft(2, '0') +
                "/"+ calListadoLlamadas.Value.Month.ToString().PadLeft(2, '0') +
                "/"+calListadoLlamadas.Value.Year.ToString() + "' and "+
            "'" + DateTime.Now.AddDays(1).Day.ToString().PadLeft(2, '0') +
                "/" + DateTime.Now.AddDays(1).Month.ToString().PadLeft(2, '0') +
                "/" + DateTime.Now.AddDays(1).Year.ToString() + "'";

            dsPlantillas1.pltListadoLlamadas.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoLlamadas.Merge(objData.ejecutarConsulta(sql + " order by idLlamadaSoporte desc").Tables[0]);
        //cargamos los seguimientos
            sql = "SET DATEFORMAT dmy select * from seguimiento where fechaSugerida between " +
                "'" + calListadoLlamadas.Value.Day.ToString().PadLeft(2, '0') +
                "/" + calListadoLlamadas.Value.Month.ToString().PadLeft(2, '0') +
                "/" + calListadoLlamadas.Value.Year.ToString() + "' and " +
            "'" + DateTime.Now.AddDays(1).Day.ToString().PadLeft(2, '0') +
                "/" + DateTime.Now.AddDays(1).Month.ToString().PadLeft(2, '0') +
                "/" + DateTime.Now.AddDays(1).Year.ToString() + "'";

            dsSpx1.seguimiento.Clear();
            dsSpx1.seguimiento.Merge(objData.ejecutarConsulta(sql).Tables[0]);
            cargarInfoGrillas();
        }

        private void calListadoLlamadas_ValueChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnVerSeguimientoLlamada_Click(object sender, EventArgs e)
        {
            if (grdSeguimientosProgramados.Columns["idSeguimiento"].Text.Trim() == string.Empty) return;
            spProcesos.llamadasTecnicas.frmAgregarSeguimiento frm = new spProcesos.llamadasTecnicas.frmAgregarSeguimiento();
            frm.IdSeguimiento = int.Parse(grdSeguimientosProgramados.Columns["idSeguimiento"].Text.Trim());
            frm.CodLlamada = int.Parse(grdSeguimientosProgramados.Columns["idLlamadaSoporte"].Text.Trim());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                actualizar();
            }
        }

        private void btnVerLlamada_Click(object sender, EventArgs e)
        {
            if (grdLlamadas.Columns["idLlamadaSoporte"].Text.Trim() == string.Empty) return;
            spProcesos.llamadasTecnicas.frmLlamadasSoporte frmO = new spProcesos.llamadasTecnicas.frmLlamadasSoporte();
            frmO.CodLLamada = int.Parse(grdLlamadas.Columns["idLlamadaSoporte"].Text);
            frmO.Show();
        }
#endregion

        #region entradas
        private string sentenciaPltEntradas()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" set dateformat dmy  ");
            sb.Append(" select  ");
            sb.Append(" codEntradaSalidaEquipos, fechaEntrada, EntradaSalidaEquipos.fechaSalida,  ");
            sb.Append(" v2.serial,v2.nombreFabricante,v2.NombreModelo,v2.nombreTipoEquipo,v2.nombreSubTipo ");
            sb.Append(" ,tipoServicio.nombretipoServicio,estadoFisicamente.NombreestadoFisicamente,modalidadEquipo.nombreModalidadEquipo, ");
            sb.Append(" clientes.nitCliente, clientes.nombreCliente, ");
            sb.Append(" v.nombreSucursal,v.NombreDepartamento,v.nombreCiudad, ");
            sb.Append(" cliens.nitCliente 'nitClienteSalida', cliens.nombreCliente 'clienteSalida', ");
            sb.Append(" sucus.nombreSucursal 'sucursalSalida',sucus.NombreDepartamento 'departamentoSalida',sucus.nombreCiudad 'ciudadSalida', ");
            sb.Append(" mod2.nombreModalidadEquipo 'modalidadSalida', ");
            sb.Append(" codOrdenServicio,obsEntrada ");
            sb.Append(" , obsSalida, fechaTerminacionMovto, nombre 'creadoPor' ");
            sb.Append(" , EntradaSalidaEquipos.fechaIngresoSeguimiento ,EntradaSalidaEquipos.fechaSeguimiento, EntradaSalidaEquipos.usuarioSeguimiento  ");
            sb.Append(" , EntradaSalidaEquipos.funcionaBien ,EntradaSalidaEquipos.observaciones 'ObseSeguimiento' ");
            sb.Append(" from dbo.EntradaSalidaEquipos ");
            sb.Append(" join usuario usuarios on usuarios.login = EntradaSalidaEquipos.creadoPor ");
            sb.Append(" join tipoServicio on tipoServicio.codTiposervicio = EntradaSalidaEquipos.codTiposervicio ");
            sb.Append(" join estadoFisicamente on estadoFisicamente.codEstadoFisicamente = EntradaSalidaEquipos.codEstadoFisicamente ");
            sb.Append(" join clientes on clientes.nitCliente  =EntradaSalidaEquipos.nitCliente ");
            sb.Append(" join dbo.vistaSucursal v on v.nitCliente = clientes.nitCliente and v.codSucursal = entradasalidaequipos.codSucursal ");
            sb.Append(" join dbo.vistaEquipo v2 on v2.serial =  entradasalidaequipos.serial ");
            sb.Append(" left join modalidadEquipo on modalidadEquipo.codModalidadEquipo = entradaSalidaEquipos.codModalidad ");
            sb.Append(" left join modalidadEquipo mod2 on mod2.codModalidadEquipo = entradaSalidaEquipos.codModalidadsalida ");
            sb.Append(" left join clientes clienS on cliens.nitCliente  =EntradaSalidaEquipos.nitClienteSalida ");
            sb.Append(" left join dbo.vistaSucursal sucuS on sucuS.nitCliente = cliens.nitCliente  ");
            sb.Append(" and sucuS.codSucursal = entradasalidaequipos.codSucursalSalida ");

            return sb.ToString();
        }

        private void actualizarEntradas()
        {
            string sql = sentenciaPltEntradas() + " WHERE ";
            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
             dsPlantillas1.pltListadoESequipos.Clear();
            
            dsPlantillas1.pltListadoESequipos.Merge(objD.ejecutarConsulta(sql + " codOrdenServicio is null " + " order by EntradaSalidaEquipos.codEntradaSalidaEquipos desc").Tables[0]);
            //
            dsPlantillasIngenieros.pltListadoESequipos.Clear();
            dsPlantillasIngenieros.pltListadoESequipos.Merge(objD.ejecutarConsulta(sql + " EntradaSalidaEquipos.fechaSalida is null " + " order by EntradaSalidaEquipos.codEntradaSalidaEquipos desc").Tables[0]);
            //
            dsOrdenesIngenieroEnEspera.pltListadoESequipos.Clear();
            dsOrdenesIngenieroEnEspera.pltListadoESequipos.Merge(objD.ejecutarConsulta(sql + " EntradaSalidaEquipos.fechaSalida is not null AND EntradaSalidaEquipos.fechaSeguimiento is null " + " order by EntradaSalidaEquipos.codEntradaSalidaEquipos desc").Tables[0]);

        }

        private void btnVerEntradaSinOrden_Click(object sender, EventArgs e)
        {
            if (grdEntradasSinOrden.Columns[0].Text.Trim() == string.Empty) return;
            spProcesos.ESequipos.frmEntradaSalidaEquipos frm = new spProcesos.ESequipos.frmEntradaSalidaEquipos();
            frm.CodEntradaSalidaEquipos = grdEntradasSinOrden.Columns["codEntradaSalidaEquipos"].Text.Trim();
            frm.Show();
        }

        private void btnVerEntradaSinSalida_Click(object sender, EventArgs e)
        {
            if (grdEntradasSinSalida.Columns[0].Text.Trim() == string.Empty) return;
            spProcesos.ESequipos.frmEntradaSalidaEquipos frm = new spProcesos.ESequipos.frmEntradaSalidaEquipos();
            frm.CodEntradaSalidaEquipos = grdEntradasSinSalida.Columns["codEntradaSalidaEquipos"].Text.Trim();
            frm.Show();
        }

        private void btnVerEntradaSinSeguimiento_Click(object sender, EventArgs e)
        {
            if (grdEntradasSinSeguimiento.Columns[0].Text.Trim() == string.Empty) return;
            spProcesos.ESequipos.frmEntradaSalidaEquipos frm = new spProcesos.ESequipos.frmEntradaSalidaEquipos();
            frm.CodEntradaSalidaEquipos = grdEntradasSinSeguimiento.Columns["codEntradaSalidaEquipos"].Text.Trim();
            frm.Show();
        }
        #endregion

        #region contratos
        private void cargarContratos() 
        {
            dsPlantillas1.pltListaContratosVencimiento.Clear();
            dsOrdenesIngeniero.pltListaContratosVencimiento.Clear();
           //dentor de un mes
                pltListaContratosVencimientoTableAdapter1.FillByFechas(dsPlantillas1.pltListaContratosVencimiento, DateTime.Now,
                    DateTime.Now.AddMonths(1));
            //los vencidos
                pltListaContratosVencimientoTableAdapter1.FillByFechas(dsOrdenesIngeniero.pltListaContratosVencimiento, DateTime.Now.AddMonths(-1),
                    DateTime.Now);
                cargarInfoGrillas();
        }
        
        private void btnVerContratoxVencer_Click(object sender, EventArgs e)
        {
            if (grdContratosxVencer.Columns["numeroContrato"].Text.Trim() == string.Empty) return;

            spProcesos.contratos.frmNuevoContrato objFrm = new spProcesos.contratos.frmNuevoContrato();
            objFrm.NumeroContrato = grdContratosxVencer.Columns["numeroContrato"].Text.Trim();
            objFrm.Show();
        }

        private void btnVerContratoVencido_Click(object sender, EventArgs e)
        {
            if (grdContratosVencidos.Columns["numeroContrato"].Text.Trim() == string.Empty) return;

            spProcesos.contratos.frmNuevoContrato objFrm = new spProcesos.contratos.frmNuevoContrato();
            objFrm.NumeroContrato = grdContratosVencidos.Columns["numeroContrato"].Text.Trim();
            objFrm.Show();
        }
        #endregion

        private void btnActualizarMaestro_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_calendar_frmCalendarComparativo : System.Web.UI.Page
{

  

    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 0);
        if (!IsPostBack)
        {
            cmbIngeniro.SelectedValue = Session["ss_cod_usuario"].ToString();

            string a = "";
            if (SPXSeguridad.verificadorPermisos.ejecutarAccion(2001, int.Parse(Session["ss_cod_usuario"].ToString()), ref a))
            {
                cmbIngeniro.Enabled = true;
            }
            else
            {
                cmbIngeniro.Enabled = false;
            }
        }

    }

    protected void RadScheduler1_AppointmentClick(object sender, Telerik.Web.UI.SchedulerEventArgs e)
    {
        string tipo = e.Appointment.ID.ToString().Split('|')[0];
        string cod = e.Appointment.ID.ToString().Split('|')[1];

        if (tipo == "orden")
        {
            Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + cod);
        }
        else if (tipo == "tarea")
        {
            Response.Redirect("frmNewTask.aspx?cod=" + e.Appointment.ID);
        }
    }

    protected void RadScheduler1_AppointmentCommand(object sender, Telerik.Web.UI.AppointmentCommandEventArgs e)
    {

    }
    protected void cmbIngeniro_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void RadScheduler1_AppointmentDataBound(object sender, Telerik.Web.UI.SchedulerEventArgs e)
    {
        e.Appointment.BackColor = System.Drawing.Color.Red;
        string a = (((System.Data.DataRowView)(e.Appointment.DataItem)).Row).ItemArray[0].ToString();
        string requiereAprobacion = (((System.Data.DataRowView)(e.Appointment.DataItem)).Row).ItemArray[9].ToString();
        string Aprobada = (((System.Data.DataRowView)(e.Appointment.DataItem)).Row).ItemArray[10].ToString();
        string[] arr = a.Split('|');
        if (arr[0].Trim() == "orden")
        {
            e.Appointment.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }
        else if (arr[0].Trim() == "tarea")
        {
            if (requiereAprobacion == "1" && Aprobada == "0")
            {
                e.Appointment.BackColor = System.Drawing.Color.Pink;
            }
            else
            {
                e.Appointment.BackColor = System.Drawing.Color.LightBlue;
            }

        }
    }
    protected void RadScheduler1_AppointmentsPopulating(object sender, Telerik.Web.UI.AppointmentsPopulatingEventArgs e)
    {

    }
    protected void btnImprimirSemana_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        objDef.Fill(dsSpx1.defaults);

        string ruta = Server.MapPath("../rpt/");
        ruta = ruta + "rpt2.xml";
        C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
        rpt.Load(ruta, "rptCal");
        Session["rutaReporte"] = ruta;
        Session["nombreReporte"] = "rptCal";

        DateTime fecha = RadScheduler1.SelectedDate;
        int cnt = 1;
        if (fecha.DayOfWeek == DayOfWeek.Monday) cnt = 0;
        else if (fecha.DayOfWeek == DayOfWeek.Tuesday) cnt = 1;
        else if (fecha.DayOfWeek == DayOfWeek.Wednesday) cnt = 2;
        else if (fecha.DayOfWeek == DayOfWeek.Thursday) cnt = 3;
        else if (fecha.DayOfWeek == DayOfWeek.Friday) cnt = 4;
        else if (fecha.DayOfWeek == DayOfWeek.Saturday) cnt = 5;
        else if (fecha.DayOfWeek == DayOfWeek.Sunday) cnt = 6;

        DateTime fechaInicio = fecha.AddDays(-1 * cnt);
        DateTime fechaFin = fechaInicio.AddDays(5);

        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@cod_usuario", cmbIngeniro.SelectedValue);
        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@inicio", "'" + fechaInicio.ToShortDateString() + "'");
        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@fin", "'" + fechaFin.ToShortDateString() + "'");



        if (rpt.Fields.Contains("lblDesde"))
        {
            rpt.Fields["lblDesde"].Value = fechaInicio.ToShortDateString();
        }
        if (rpt.Fields.Contains("lblHasta"))
        {
            rpt.Fields["lblHasta"].Value = fechaFin.ToShortDateString();
        }
        if (rpt.Fields.Contains("lblUsuario"))
        {
            rpt.Fields["lblUsuario"].Value = cmbIngeniro.SelectedItem.Text;
        }
        //rpt.DataSource.RecordSource = rpt.DataSo
        if (Session["c1report"] == null)
        {
            Session.Add("c1report", rpt);
        }
        else
        {
            Session["c1report"] = rpt;
        }
        //Session["tituloReporte"] 

        if (Session["tituloReporte"] == null)
        {
            Session.Add("tituloReporte", "Actividades Semanales");
        }
        else
        {
            Session["tituloReporte"] = "Actividades Semanales";
        }
        //    Session["showPdf"]
        Response.Redirect("../impresion/frmImprimir.aspx");
    }

 
}
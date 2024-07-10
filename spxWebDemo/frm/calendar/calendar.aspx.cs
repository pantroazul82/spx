using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_calendar_calendar : System.Web.UI.Page
{

     public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
    public static List<AutoCompleteResult> ObtCliente(string term)
    {

        string sql = @"select top " + 5 + @"
nitCliente,rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes
where nitCliente like '" + term + @"%'
or nombreCliente like '" + term + @"%'
or numeroSocio like '" + term + "%'";

        System.Data.DataTable tb = new System.Data.DataTable();
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        obj.ejecutarConsulta(sql, tb);
        //adaptador.Fill(tb);
        //if (tb.Rows.Count <= 0)
        //{
        //    return null;
        //}
        List<AutoCompleteResult> lista = new List<AutoCompleteResult>();

        for (int k = 0; k < tb.Rows.Count; k++)
        {
            AutoCompleteResult ar = new AutoCompleteResult();
            ar.id = tb.Rows[k][0].ToString();
            ar.value = tb.Rows[k][1].ToString();
            lista.Add(ar);
        }

        return lista;
    }


    private void registrarScriptCliente(Control c)
    {
        string query = @" <script type='text/javascript'>
          jQuery(document).ready(function () {
	        $('#" + c.ClientID + @"').autocomplete({
	            source: function (request, response) {
	                PageMethods.ObtCliente(
            request.term,
            function (data) {
                var cliente = (typeof data) == 'string' ? eval('(' + data + ')') : data;
                response(cliente);
            },
            fnLlamadaError);
	            },
	            minLength: 2
	        });
	    });

	    function fnLlamadaError(excepcion) {
	        alert('Ha ocurrido un error interno: ' + excepcion.get_message());
	    }
	</script>";

        if (!Page.ClientScript.IsStartupScriptRegistered("script" + c.ClientID))
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "script" + c.ClientID, query);

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 0);
        registrarScriptCliente(txtCliente);
        if (!IsPostBack)
        {
            //validamos que el combo contenga el cod usuario
            
            //for (int k = 0; k < cmbIngeniro.Items.Count; k++)
            //{
            //    if (cmbIngeniro.Items[k].Value.Trim() == Session["ss_cod_usuario"].ToString())
            //    { 
            cmbIngeniro.DataBind();
            cmbIngeniro.SelectedValue = Session["ss_cod_usuario"].ToString();
            //        break;
            //    }
            //}
                
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
        RadScheduler1.Style.Add("z-index", "1000");
        
    }

    protected void RadScheduler1_AppointmentClick(object sender, Telerik.Web.UI.SchedulerEventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.resolverLinkTarea(e.Appointment.ID.ToString(), Response);
        
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
        else if (arr[0].Trim() == "capacitacion")
        {
            e.Appointment.BackColor = System.Drawing.Color.LightGreen;
        }
        else if (arr[0].Trim() == "control")
        {
            e.Appointment.BackColor = System.Drawing.Color.LightGray;
        }
        else if (arr[0].Trim() == "rev")
        {
            e.Appointment.BackColor = System.Drawing.Color.DarkSalmon;
        }
        else if (arr[0].Trim() == "revision")
        {
            e.Appointment.BackColor = System.Drawing.Color.YellowGreen;
        }
    }
    protected void RadScheduler1_AppointmentsPopulating(object sender, Telerik.Web.UI.AppointmentsPopulatingEventArgs e)
    {

    }
    protected void btnImprimirSemana_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        dsSpx1.EnforceConstraints = false;
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
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        rpt.DataSource.ConnectionString = obj.CadenaConexionReportes;
        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@cod_usuario", cmbIngeniro.SelectedValue);
       // rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@inicio", "'" + fechaInicio.Month.ToString().PadLeft(2, '0') + "/" + fechaInicio.Day.ToString().PadLeft(2, '0') + "/" + fechaInicio.Year + "'");
        //rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@fin", "'" + fechaFin.Month.ToString().PadLeft(2, '0') + "/" + fechaFin.Day.ToString().PadLeft(2, '0') + "/" + fechaFin.Year + "'");
        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@inicio", "'" + fechaInicio.ToShortDateString()+ "'");
        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("@fin", "'" + fechaFin.ToShortDateString()+ "'");



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

    protected void btnfiltrosAvanzados_Click(object sender, EventArgs e)
    {
        odsCalendario.FilterExpression = "";
        string filtro = "";
        if (txtCliente.Text != string.Empty)
        {
            string nit="";
            if (txtCliente.Text.IndexOf("(") > 0 && txtCliente.Text.IndexOf("(")  <txtCliente.Text.IndexOf(")"))
            {
                nit = txtCliente.Text.Substring(txtCliente.Text.IndexOf("(")+1,
                   txtCliente.Text.Length - txtCliente.Text.IndexOf("(") - 2);
                //obtenemos el nit del cliente
                filtro = " nitCliente ='" + nit + "'";
            }
        }
        odsCalendario.FilterExpression = filtro;
    }
}
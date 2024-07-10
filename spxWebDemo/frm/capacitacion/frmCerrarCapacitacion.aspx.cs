using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmCerrarCapacitacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        if (Request.QueryString["cod"] != null)
            obj.comprobarAcceso(Page, Session, Response, 2021);
        else
            obj.comprobarAcceso(Page, Session, Response, 22222222);
        lblcodigoSesion.Text = Request.QueryString["cod"];
        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objCapacitacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objCapacitacion.FillBycod_capacitacion(ds.capacitacion, int.Parse(lblcodigoSesion.Text));
        if (!IsPostBack)
        {
            lblTexto.Text = " Capacitacion " + ds.capacitacion[0].nombre + " <br>fecha " + ds.capacitacion[0].fecha_inicio.ToLongDateString() + " - " + ds.capacitacion[0].fecha_fin.ToLongDateString();
   
            //validamos que no este ya cerrada
            if (ds.capacitacion[0].cod_estado_capacitacion == 3)
            {
                Response.Redirect("frmCapacitacion.aspx?cod=" + Request.QueryString["cod"]);
            }
        }

        //string a=(
        //    (int.Parse( (Eval("asistencia") == System.DBNull.Value)?("0"):(Eval("asistencia").ToString())) * 100 )/
        //    int.Parse( (Eval("clases")     == System.DBNull.Value)?("0"):(Eval("clases"    ).ToString()))
        //    ).ToString();
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCapacitacion.aspx?cod=" + Request.QueryString["cod"]);
    }

    public bool verBotonEjecutar(object obj)
    {
        bool permiso = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2021, int.Parse(Session["ss_cod_usuario"].ToString()), Session);

        string sql = @"select dictada_por from asistentexsession 
join capacitacion on capacitacion.cod_capacitacion= asistentexsession.cod_capacitacion
where codasistentexsession=" + obj;
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        object o = bd.ejecutarProcedimiento(sql);
        string profesor = "";
        if (o != null && o != System.DBNull.Value) profesor = o.ToString();

        if (!permiso && Session["ss_cod_usuario"].ToString() != profesor) return false;

        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter ta = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        ta.FillBycodasistentexsession(ds.asistentexsession, int.Parse(obj.ToString()));
        if (ds.asistentexsession[0].IsasistioNull())
            return true;

        return false;
    }

    
    

    protected void btnCerrarCapacitacion_Click(object sender, EventArgs e)
    {
        string sql = "select count(*) from asistente_capacitacion where cod_capacitacion="+lblcodigoSesion.Text+" and aprobo is null";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        string a = bd.ejecutarProcedimiento(sql).ToString();
        if (a.Trim() != "0")
        {
            lblError.Text = "Faltan "+a+" participantes por recibir calificacion!";
            return;
           
        } 
         SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objCapa = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
         objCapa.UpdateEstado(3, int.Parse(lblcodigoSesion.Text));
         Response.Redirect("frmCapacitacion.aspx?cod=" + Request.QueryString["cod"]);

    }

    protected void btnVerSubirAsistencia_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmSubirComprobante.aspx?tip=a&cod="+Request.QueryString["cod"]+"&user="+im.ValidationGroup);
    }

    protected void btnVerSubirEvaluacion_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmSubirComprobante.aspx?tip=e&cod=" + Request.QueryString["cod"] + "&user=" + im.ValidationGroup);

    }

    protected void btnVerSubirCertificado_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmSubirComprobante.aspx?tip=c&cod=" + Request.QueryString["cod"] + "&user=" + im.ValidationGroup);
    }

    protected void btnVerAsistencia_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = (byte[])obj.verAsistencia(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        string ext = obj.verExtensionAsistencia(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        bajarArchivo(arr, ext);
    }

    protected void btnVerEvaluacion_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = obj.verEvaluacion(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        string ext = obj.verExtensionEvaluacion(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        bajarArchivo(arr, ext);
    }

    protected void btnVerCertificado_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr= obj.verCertificado(int.Parse(Request.QueryString["cod"] ),int.Parse( im.ValidationGroup));
        string ext = obj.verExtensionCertificado(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        bajarArchivo(arr, ext);
    }

    public void bajarArchivo(byte[] arr,string extension)
    {
        if (arr != null)
        {
           
            string path = Server.MapPath("~/temp/");
            string file = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') +
                DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString() +
                extension;
            path = path + file;
            System.IO.File.WriteAllBytes(path, arr);
            Response.Redirect( "~/temp/" + file);
        }
    }

    protected void btnGuardar_Click(object sender,EventArgs e)
    {
        //al guardar debe validar si dice que si que tenga los tres adjuntos

        Button im = (Button)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        bool aprobo = false;
        for (int k = 0; k < RadGrid1.Items.Count; k++)
        {
            Button b = (Button)RadGrid1.Items[k].FindControl("btnGuardarinformacion");
            if (b.ValidationGroup == im.ValidationGroup)
            {  Label le = (Label)RadGrid1.Items[k].FindControl("lblError");
            le.Text = "";
                RadioButton rd = (RadioButton)RadGrid1.Items[k].FindControl("rdSi");
                RadioButton rdNo = (RadioButton)RadGrid1.Items[k].FindControl("rdNo");
                if (!rd.Checked && !rdNo.Checked)
                {
                    le.Text = "Seleccione si aprobo o no!";
                    return;
                }
                aprobo = rd.Checked;
                if (aprobo)
                {
                    //validamos con los botones de ver 
                    ImageButton a = (ImageButton)RadGrid1.Items[k].FindControl("btnVerAsistencia");
                    if (!a.Visible)
                    {
                        le.Text = "Debe ingresar el archivo de la asistencia";
                        return;
                    }

                    ImageButton bb = (ImageButton)RadGrid1.Items[k].FindControl("btnVerEvaluacion");
                    if (!bb.Visible)
                    {
                        le.Text = "Debe ingresar el archivo de la evaluacion";
                        return;
                    }

                    ImageButton c = (ImageButton)RadGrid1.Items[k].FindControl("btnVerCertificado");
                    if (!c.Visible)
                    {
                        le.Text = "Debe ingresar el archivo del certificado";
                        return;
                    }
                    
                }
                rd.Enabled = false;
                    rdNo.Enabled = false;
                    b.Visible = false;
            }
        }
            obj.UpdateAprobo(aprobo, int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        
    }
    
}
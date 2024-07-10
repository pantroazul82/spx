using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmSubirComprobante : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            obj.FillByUsuarioCapacitacion(ds.asistente_capacitacion, int.Parse(Request.QueryString["cod"]),
                int.Parse(Request.QueryString["user"]));
            
           
            byte[] arr=null;
            string extension = "";
            if (Request.QueryString["tip"] == "a")
            {
                arr = (byte[])obj.verAsistencia(
                        int.Parse(Request.QueryString["cod"]),
                        int.Parse(Request.QueryString["user"]));
                if (arr != null)
                {
                    extension = obj.verExtensionAsistencia(
                            int.Parse(Request.QueryString["cod"]),
                            int.Parse(Request.QueryString["user"])).ToString();
                }
            }
            else if (Request.QueryString["tip"] == "c")
            {
                arr = obj.verCertificado(
                        int.Parse(Request.QueryString["cod"]),
                        int.Parse(Request.QueryString["user"]));
                if (arr != null)
                {
                    extension = obj.verExtensionCertificado(
                            int.Parse(Request.QueryString["cod"]),
                            int.Parse(Request.QueryString["user"])).ToString();
                }
            }
            else if (Request.QueryString["tip"] == "e")
            {
                arr = obj.verEvaluacion(
                        int.Parse(Request.QueryString["cod"]),
                        int.Parse(Request.QueryString["user"]));
                if (arr != null)
                {
                    extension = obj.verExtensionEvaluacion(
                            int.Parse(Request.QueryString["cod"]),
                            int.Parse(Request.QueryString["user"])).ToString();
                }
            }
            if (arr != null)
            { 
                lnkArhivo.Visible = true;
                lblArchivoActual.Visible = true;
                string path=Server.MapPath("~/temp/");
                string file = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') +
                    DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString() +
                    extension;
                path = path +  file;
                System.IO.File.WriteAllBytes(path, arr);
                lnkArhivo.NavigateUrl = "~/temp/"+file;
            }
        }
    }
    
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!fileUpload1.HasFile)
        {
            lblError.Text = "Seleccione un Archivo";
        }
       
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        if (Request.QueryString["tip"] == "a")
        {
            obj.UpdateAsistencia(fileUpload1.FileBytes,
                System.IO.Path.GetExtension(fileUpload1.FileName ),
                int.Parse(Request.QueryString["cod"]),
                int.Parse(Request.QueryString["user"]));
        }else if (Request.QueryString["tip"] == "c")
        {
            obj.UpdateCertificado(fileUpload1.FileBytes,
                System.IO.Path.GetExtension(fileUpload1.FileName),
                   int.Parse(Request.QueryString["cod"]),
                   int.Parse(Request.QueryString["user"]));
        }
        else if (Request.QueryString["tip"] == "e")
        {
            obj.UpdateEvaluacion(fileUpload1.FileBytes,
                System.IO.Path.GetExtension(fileUpload1.FileName),
                   int.Parse(Request.QueryString["cod"]),
                   int.Parse(Request.QueryString["user"]));
        }

        Response.Redirect("frmCerrarCapacitacion.aspx?cod=" + Request.QueryString["cod"]);
        
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCerrarCapacitacion.aspx?cod="+Request.QueryString["cod"]);
    }
}
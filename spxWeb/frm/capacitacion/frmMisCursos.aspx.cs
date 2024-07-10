using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmMisCursos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnVerAsistencia_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = (byte[])obj.verAsistencia(int.Parse(im.ValidationGroup), int.Parse(Session["ss_cod_usuario"].ToString()));
        string ext = obj.verExtensionAsistencia(int.Parse(im.ValidationGroup), int.Parse(Session["ss_cod_usuario"].ToString()));
        bajarArchivo(arr, ext);
    }

    protected void btnVerEvaluacion_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = obj.verEvaluacion(int.Parse(im.ValidationGroup), int.Parse(Session["ss_cod_usuario"].ToString()));
        string ext = obj.verExtensionEvaluacion(int.Parse(im.ValidationGroup), int.Parse(Session["ss_cod_usuario"].ToString()));
        bajarArchivo(arr, ext);
    }

    protected void btnVerCertificado_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = obj.verCertificado(int.Parse(im.ValidationGroup), int.Parse(Session["ss_cod_usuario"].ToString()));
        string ext = obj.verExtensionCertificado(int.Parse(im.ValidationGroup), int.Parse(Session["ss_cod_usuario"].ToString()));
        bajarArchivo(arr, ext);
    }

    public void bajarArchivo(byte[] arr, string extension)
    {
        if (arr != null)
        {

            string path = Server.MapPath("~/temp/");
            string file = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') +
                DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString() +
                extension;
            path = path + file;
            System.IO.File.WriteAllBytes(path, arr);
            Response.Redirect("~/temp/" + file);
        }
    }

    public string verPorcentaje(object asistencia, object clases)
    {
        if (asistencia == null || asistencia == System.DBNull.Value || clases == System.DBNull.Value || clases == null) return "";
        int asis = int.Parse(asistencia.ToString());
        int cl = int.Parse(clases.ToString());
        return ((asis * 100) / cl) + "%";
    }

}
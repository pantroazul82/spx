using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmNewArchivoControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        if (Session["archivoQC"] != null)
        {
            string a = Session["archivoQC"].ToString();
            Session["archivoQC"] = null;
            Response.Redirect(a);
        }
        else
        {
            Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
        }
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!FileUpload1.HasFile)
        {
            lblError.Text = "Debe seleccionar un archivo";
            return;
        }


        SPControladoraDatos.dsCientificaTableAdapters.archivos_control_calidadTableAdapter archivos = new SPControladoraDatos.dsCientificaTableAdapters.archivos_control_calidadTableAdapter();

        archivos.Insert(
            int.Parse(Request.QueryString["cod"]), txtTipoArchivo.Text,
            FileUpload1.FileBytes, DateTime.Now,
            calFechaManual.SelectedDate,FileUpload1.FileName
            );
        if (Session["archivoQC"] != null)
        {
            string a = Session["archivoQC"].ToString();
            Session["archivoQC"] = null;
            Response.Redirect(a);
        }
        else
        {
            Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
        }
    }
}
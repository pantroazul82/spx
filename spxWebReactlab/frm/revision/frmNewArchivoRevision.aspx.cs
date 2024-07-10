using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmNewArchivoRevision : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        if (Session["archivoRev"] != null)
        {
            string a = Session["archivoRev"].ToString();
            Session["archivoRev"] = null;
            Response.Redirect(a);
        }
        else
        {
            Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
        }
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!FileUpload1.HasFile)
        {
            lblError.Text = "Debe seleccionar un archivo";
            return;
        }


        SPControladoraDatos.dsCientificaTableAdapters.archivos_revision_equiposTableAdapter archivos = new SPControladoraDatos.dsCientificaTableAdapters.archivos_revision_equiposTableAdapter();

        archivos.Insert(
            int.Parse(Request.QueryString["cod"]), txtTipoArchivo.Text,
            FileUpload1.FileBytes, DateTime.Now,
            calFechaManual.SelectedDate, FileUpload1.FileName
            );
        if (Session["archivoRev"] != null)
        {
            string a = Session["archivoRev"].ToString();
            Session["archivoRev"] = null;
            Response.Redirect(a);
        }
        else
        {
            Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
        }
    }
}
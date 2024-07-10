using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmAprobar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad objs = new clsSeguridad();
        objs.comprobarAcceso(Page, Session, Response, 2041);
        if (!IsPostBack)
        {
            SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
            SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
            revision.FillBycod_revision_equipos(ds.revision_equipos, int.Parse(Request.QueryString["cod"]));
            if (!ds.revision_equipos[0].IsadecuadoNull())
            {
                rdAdecuado.Checked = ds.revision_equipos[0].adecuado;
                rdNoAdecuado.Checked = !ds.revision_equipos[0].adecuado;
            }
            txtObservaciones.Text = ds.revision_equipos[0].observaciones;
        }

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar()) return;
        //guardamos la informacion
        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        estado.FillBycod_manual(ds.estado_revision_equipos, 4);
        revision.UpdateEstado_revision_equipos(ds.estado_revision_equipos[0].cod_estado_revision_equipos, int.Parse(Request.QueryString["cod"]));
        revision.UpdateObservaciones(txtObservaciones.Text, int.Parse(Request.QueryString["cod"]));
        revision.UpdateAdecuado(rdAdecuado.Checked, int.Parse(Request.QueryString["cod"]));
        revision.UpdateFechaAprobacion(DateTime.Now, int.Parse(Request.QueryString["cod"]));
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    private bool validar()
    {
        if (!rdAdecuado.Checked && !rdNoAdecuado.Checked)
        {
            lblError.Text = "Debe seleccionar el concepto cientifico.";
            return false;
        }

      
        return true;
    }
    protected void btnReabrir_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        estado.FillBycod_manual(ds.estado_revision_equipos, 2);
        revision.UpdateEstado_revision_equipos(ds.estado_revision_equipos[0].cod_estado_revision_equipos, int.Parse(Request.QueryString["cod"]));
        revision.UpdateCierre(null,null,null, int.Parse(Request.QueryString["cod"]));

        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }
}
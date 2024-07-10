using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmAnular : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            calAnulacion.SelectedDate = DateTime.Now;
            cmbAnuladoPor.SelectedValue = Session["ss_cod_usuario"].ToString();
            if (Request.QueryString["cod"] != null)
            {
                SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                obj.FillBycod_revision_equipos(ds.revision_equipos, int.Parse(Request.QueryString["cod"]));
                if (!ds.revision_equipos[0].Isanulada_porNull())
                {
                    cmbAnuladoPor.DataBind();
                    cmbAnuladoPor.SelectedValue = ds.revision_equipos[0].anulada_por.ToString();
                    calAnulacion.SelectedDate = ds.revision_equipos[0].fecha_anulacion;
                    txtMotivo.Text = ds.revision_equipos[0].motivo_anulacion;
                    txtMotivo.ReadOnly = true;
                    btnAceptar.Visible = false;
                    btnCancelar.Text = "Atras";
                }
                else {
                    clsSeguridad objs = new clsSeguridad();
                    objs.comprobarAcceso(Page, Session, Response, 2043);
                }
            }

        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        obj.UpdateAnulacion(int.Parse(cmbAnuladoPor.SelectedValue),DateTime.Now
            , txtMotivo.Text, int.Parse(Request.QueryString["cod"]));

        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter objestado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        objestado.FillBycod_manual(ds.estado_revision_equipos, 5);
        obj.UpdateEstado_revision_equipos(ds.estado_revision_equipos[0].cod_estado_revision_equipos, int.Parse(Request.QueryString["cod"]));
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }
}
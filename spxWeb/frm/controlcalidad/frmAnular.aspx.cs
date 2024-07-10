using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmAnular : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            calAnulacion.SelectedDate = DateTime.Now;
            cmbAnuladoPor.SelectedValue = Session["ss_cod_usuario"].ToString();
            if (Request.QueryString["cod"] != null)
            {
                SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                ds.EnforceConstraints = false;
                obj.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));
                if (!ds.control_calidad[0].Isanulada_porNull())
                {
                    cmbAnuladoPor.DataBind();
                    cmbAnuladoPor.SelectedValue = ds.control_calidad[0].anulada_por.ToString();
                    calAnulacion.SelectedDate = ds.control_calidad[0].fecha_anulacion;
                    txtMotivo.Text = ds.control_calidad[0].observaciones_anulacion;
                    txtMotivo.ReadOnly = true;
                    btnAceptar.Visible = false;
                    btnCancelar.Text = "Atras";
                }
            }

        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds=new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        obj.UpdateAnulacion(DateTime.Now,
            true,
            int.Parse(cmbAnuladoPor.SelectedValue), txtMotivo.Text, int.Parse(Request.QueryString["cod"]));

        SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter objestado=new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
        objestado.FillByCodmanual(ds.estado_control_calidad,6);
        obj.UpdateEstadoControlCalidad(ds.estado_control_calidad[0].cod_estado_control_calidad, int.Parse(Request.QueryString["cod"]));
        Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }
}
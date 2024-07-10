using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmAnularContrato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ss_cod_usuario"] == null)
        {
            Response.Redirect("~/default.aspx");
        }
        calFechaAnulacion.Date = DateTime.Now;
        cmbAnuladoPor.SelectedValue = Session["ss_cod_usuario"].ToString();
        SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter c = new  SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
        if (!IsPostBack)
        {
            c.FillByCod_contratos_suministro(ds.contratos_suministro, int.Parse(Request.QueryString["cod"]));

            if (ds.contratos_suministro.Count > 0 && !ds.contratos_suministro[0].Isfecha_anulacionNull())
            {
                cmbAnuladoPor.SelectedValue = ds.contratos_suministro[0].anulada_por.ToString();
                calFechaAnulacion.Date = ds.contratos_suministro[0].fecha_anulacion;
                cmbMotivoAnulacion.SelectedValue = ds.contratos_suministro[0].cod_motivo_anulacion_suministro.ToString();
                txtObservaciones.Text = ds.contratos_suministro[0].observaciones_anulacion;

                cmbMotivoAnulacion.Enabled = false;
                txtObservaciones.ReadOnly = true;

            }
        }

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod="+Request.QueryString["cod"]);
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if(txtObservaciones.Text.Trim() == string.Empty)
        {
            lblError.Text = "Las observaciones de anulacion son obligatorias.";
            return;
        }

        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter cs = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();

        if (lblCodTipo.Text.Trim() == string.Empty)
        {
            SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
            SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter estado = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter();
            SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter log = new SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter();
            estado.FillByCod_manual(ds.estado_contrato_suministro, "7");
            cs.UpdateEstado(ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,
                int.Parse(Request.QueryString["cod"]));
            //insertamos en el log
            log.FillByCod_contratos_suministroUltimo(ds.log_cambios_estado_contratos_suministro,
                int.Parse(Request.QueryString["cod"]));
            cs.UpdateAnulacion(int.Parse(cmbMotivoAnulacion.SelectedValue),
                           calFechaAnulacion.Date,
                           int.Parse(cmbAnuladoPor.SelectedValue), txtObservaciones.Text,
                           int.Parse(Request.QueryString["cod"]));
            log.Insert(DateTime.Now, int.Parse(cmbAnuladoPor.SelectedValue),
                txtObservaciones.Text, ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,
                int.Parse(Request.QueryString["cod"]),
                ds.log_cambios_estado_contratos_suministro[0].cod_estado_contrato_suministro,
                (int)DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).TotalHours,
                DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).Hours);
        }
        else
        {
           
        }
        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }
}
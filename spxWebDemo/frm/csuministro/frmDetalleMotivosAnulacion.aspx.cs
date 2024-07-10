using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmDetalleMotivosAnulacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.motivo_anulacion_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.motivo_anulacion_suministroTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillBycod_motivo_anulacion_suministro(ds.motivo_anulacion_suministro, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.motivo_anulacion_suministro[0].nombre_motivo_anulacion_suministro;


                lblCodTipo.Text = ds.motivo_anulacion_suministro[0].cod_motivo_anulacion_suministro.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoMotivosAnulacion.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.motivo_anulacion_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.motivo_anulacion_suministroTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoMotivosAnulacion.aspx");
    }
}
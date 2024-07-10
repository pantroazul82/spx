using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_parametrizacion_frmControlesCalidadInterno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsCientificaTableAdapters.control_calidad_internoTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.control_calidad_internoTableAdapter();
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                ds.EnforceConstraints = false;
                obj.FillBycod_control_calidad_interno(ds.control_calidad_interno, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.control_calidad_interno[0].descripcion;

                chkActivo.Checked = ds.control_calidad_interno[0].activo;

                lblCodTipo.Text = ds.control_calidad_interno[0].cod_control_calidad_interno.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoControlCalidadInterno.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsCientificaTableAdapters.control_calidad_internoTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.control_calidad_internoTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text, chkActivo.Checked);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, chkActivo.Checked, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoControlCalidadInterno.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmProductosExperiencia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_producto_experiencia_contrato(ds.producto_experiencia_contrato, int.Parse(Request.Params["cod"]));
                //--
                txtNombreProducto.Text = ds.producto_experiencia_contrato[0].nombre_producto;
                txtCodManual.Text = ds.producto_experiencia_contrato[0].codigo_manual_referencia;
                cmbFabricante.SelectedValue = ds.producto_experiencia_contrato[0].cod_fabricante.ToString();
                lblCodTipo.Text = ds.producto_experiencia_contrato[0].cod_producto_experiencia_contrato.ToString();
                cmbFabricante.Enabled = false;
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoProductosExperiencia.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtNombreProducto.Text == string.Empty)
        {
            lblError.Text = "EL nombre del producto es obligatorio";
            return;
        }

        if (txtCodManual.Text == string.Empty)
        {
            lblError.Text = "EL codigo manual del producto es obligatorio";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(int.Parse(cmbFabricante.SelectedValue), txtNombreProducto.Text,txtCodManual.Text);
        }
        else
        {
            obj.UpdateQuery(txtNombreProducto.Text,txtCodManual.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoProductosExperiencia.aspx");
    }
}
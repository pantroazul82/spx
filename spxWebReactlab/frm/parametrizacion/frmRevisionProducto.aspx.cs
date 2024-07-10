using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_parametrizacion_frmRevisionProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsCientificaTableAdapters.revision_estado_productoTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.revision_estado_productoTableAdapter();
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                obj.FillByCod_revision_estado_producto(ds.revision_estado_producto, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.revision_estado_producto[0].descripcion;

                    chkActivo.Checked = ds.revision_estado_producto[0].activo;

                lblCodTipo.Text = ds.revision_estado_producto[0].cod_revision_estado_producto.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmlistadoRevisionProducto.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsCientificaTableAdapters.revision_estado_productoTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.revision_estado_productoTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text, chkActivo.Checked);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, chkActivo.Checked, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmlistadoRevisionProducto.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.parametrizacion
{
    public partial class frmListadoControlesCalidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obj = new clsSeguridad();
            obj.comprobarAcceso(Page, Session, Response, 2009);
        }
        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmControlesCalidad.aspx");
        }

        protected void btnEditar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton im = (ImageButton)sender;
            Response.Redirect("frmControlesCalidad.aspx?cod=" + im.ValidationGroup.ToString());
        }

        protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                ImageButton im = (ImageButton)sender;
                SPControladoraDatos.dsCientificaTableAdapters.controles_calidadTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.controles_calidadTableAdapter();

                obj.DeleteQuery(int.Parse(im.ValidationGroup.ToString()));
                RadGrid1.DataBind();
            }
            catch (Exception)
            {
            }

        }
    }
}
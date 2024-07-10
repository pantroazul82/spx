using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.ordenPrestamo
{
    public partial class frmRechazarOp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verifiamos permisos
            clsSeguridad cls = new clsSeguridad();
            cls.comprobarAcceso(Page, Session, Response, 1017);
            if (Session["op"] == null)
                Response.Redirect("frmListadoOrdenesPrestamo.aspx");
        }

        protected void btnCancelar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmListadoOrdenesPrestamo.aspx");
        }

        protected void btnOk_Click(object sender, ImageClickEventArgs e)
        {
            int orden = int.Parse(Session["op"].ToString());

            BOLayer.OrdenPrestamoFactory f = new BOLayer.OrdenPrestamoFactory();
            BOLayer.OrdenPrestamo op = f.Get(orden);
            op.CodEstadoOrdenPrestamo = 3;
            op.LoginAutorizo = Session["ss_login"].ToString();
            op.ObsAprobacion = txtObsRechazo.Text;
            f.Save(op);
            f.Commit();
            Response.Redirect("frmListadoOrdenesPrestamo.aspx");
        }
    }
}
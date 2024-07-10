using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.calendar
{
    public partial class frmTareasxAprobar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obj = new clsSeguridad();
            obj.comprobarAcceso(Page, Session, Response, 0);

        }
        protected void btnAprobar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string a = b.ValidationGroup;
            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            obj.UpdateAprobacion("", int.Parse(Session["ss_cod_usuario"].ToString()), true, DateTime.Now, int.Parse(a));
            grdDatos.DataBind();

        }

        protected void btnRechazar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string a = b.ValidationGroup;
            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            obj.UpdateAprobacion("", int.Parse(Session["ss_cod_usuario"].ToString()), false, DateTime.Now, int.Parse(a));
            grdDatos.DataBind();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.parametrizacion
{
    public partial class frmListadoActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter f = new SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter();
                RadGrid1.DataSource = f.GetData();
                RadGrid1.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmActividad.aspx");
        }

        protected void btnEditar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton im = (ImageButton)sender;
            Response.Redirect("frmActividad.aspx?cod=" + im.ValidationGroup.ToString());
        }

        public string versubTipo(object codTipo)
        {
            if (codTipo == null) return "";
            SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter();
            return obj.GetDataBycod_subtipo_tarea_calendario(int.Parse(codTipo.ToString()))[0].descripcion;
        }

        protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                ImageButton im = (ImageButton)sender;
                SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter();
                obj.DeleteQuery(int.Parse(im.ValidationGroup.ToString()));
                RadGrid1.DataBind();
            }
            catch (Exception)
            {
            }

        }
    }
}
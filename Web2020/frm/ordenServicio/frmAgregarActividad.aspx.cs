using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.ordenServicio
{
    public partial class frmAgregarActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obS = new clsSeguridad();
            obS.comprobarAcceso(Page, Session, Response, 1054);
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmEjecutarOrden.aspx?osx=" + Session["osx"]);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            cls.ds2020TableAdapters.actividadxordenServicioTableAdapter f = new cls.ds2020TableAdapters.actividadxordenServicioTableAdapter();
            int ca = int.Parse(f.verNextId(int.Parse(Session["osx"].ToString())).ToString());

            f.Insert(int.Parse(Session["osx"].ToString()), ca, DateTime.Now, txtObservaciones.Text, Session["ss_login"].ToString(), chkConfidencial.Checked);


            BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
            BOLayer.OrdenServicio os = osf.Get(int.Parse(Session["osx"].ToString()));
            os.CodEstadoOrdenServicio = "EJECU";
            osf.Save(os);
            osf.Commit();
            Response.Redirect("frmEjecutarOrden.aspx?osx=" + Session["osx"].ToString());
        }

        protected void btnGuardarOtra_Click(object sender, EventArgs e)
        {
            cls.ds2020TableAdapters.actividadxordenServicioTableAdapter f = new cls.ds2020TableAdapters.actividadxordenServicioTableAdapter();
            int ca = int.Parse(f.verNextId(int.Parse(Session["osx"].ToString())).ToString());

            f.Insert(int.Parse(Session["osx"].ToString()), ca, DateTime.Now, txtObservaciones.Text, Session["ss_login"].ToString(), chkConfidencial.Checked);


            BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
            BOLayer.OrdenServicio os = osf.Get(int.Parse(Session["osx"].ToString()));
            os.CodEstadoOrdenServicio = "EJECU";
            osf.Save(os);
            osf.Commit();
            chkConfidencial.Checked = false;
            txtObservaciones.Text = "";
            lblError.Text = "Se guardo el registro satisfactoriamente<br>";
        }
    }
}
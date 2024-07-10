using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmDetalleCurso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SPXSeguridad.data.cls.clsTusuario usu = new SPXSeguridad.data.cls.clsTusuario();
            SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
            ds.EnforceConstraints = false;
            usu.FillBycod_usuario(ds.usuario, int.Parse(Request.QueryString["cod"]));
            lblNombre.Text=ds.usuario[0].nombre;
        }
    }
}
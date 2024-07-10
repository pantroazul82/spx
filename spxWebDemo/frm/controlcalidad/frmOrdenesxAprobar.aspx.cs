using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmOrdenesxAprobar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad cls = new clsSeguridad();
        cls.comprobarAcceso(Page, Session, Response, 2033);
        if (!IsPostBack)
        {
            calInicio.SelectedDate = DateTime.Now.AddMonths(-1);
            calFin.SelectedDate = DateTime.Now.AddDays(20);
        }
    }
}
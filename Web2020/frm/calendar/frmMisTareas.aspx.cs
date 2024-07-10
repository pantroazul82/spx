using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.calendar
{
    public partial class frmMisTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                calInicio.SelectedDate = DateTime.Now.AddMonths(-1);
                calFin.SelectedDate = DateTime.Now.AddDays(20);
            }
        }

        public string versocioNegocio(object nit)
        {
            string sql = "select numeroSocio from clientes where nitCliente='" + nit.ToString().Trim() + "'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            object ob = bd.ejecutarProcedimiento(sql);
            if (ob != null) return ob.ToString();
            else return "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
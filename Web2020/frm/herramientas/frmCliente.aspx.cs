using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.herramientas
{
    public partial class frmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nit = Request.QueryString["nit"];
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                string sql = "select top 1 nombreCliente,nitCliente,numeroSocio from clientes where nitCliente='" + nit + "'";
                System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
                txtNitCliente.Text = tb.Rows[0]["nitCliente"].ToString();
                txtNombreCliente.Text = tb.Rows[0]["nombreCliente"].ToString();
                txtSocioNegocio.Text = tb.Rows[0]["numeroSocio"].ToString();
                lblPaginaAnterior.Text = Request.UrlReferrer.AbsoluteUri;
            }
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect(lblPaginaAnterior.Text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate.Criterion;
using NHibernate;
using BOLayer;
using Web2020.cls;

namespace Web2020.frm.hojavida
{
    public partial class frmSeguimiento : System.Web.UI.Page
    {

      
        #region --- Class Methods --- 

        protected void Page_Load(object pSender, EventArgs pEventArgs)
        {
            clsSeguridad obS = new clsSeguridad();
            obS.comprobarAcceso(Page, Session, Response, 1115);

            if (!IsPostBack)
            {

                ViewState["querySeguimiento"] = SqlDataSource1.SelectCommand;
            }
          
        }




        protected void SearchBtn1_Click(object pSender, EventArgs pEventArgs)
        {
            string sql=ViewState["querySeguimiento"].ToString() ;
            //aplicamos los filtros
            if (cmbFiltros.SelectedValue == "1")//serial
            {
                sql = sql + " where serial like '"+SearchText1.Text+"%'";
            }

            if (cmbFiltros.SelectedValue == "2")//nit cliente
            {
                sql = sql + " where nitCliente like '" + SearchText1.Text + "%'";
            }

            if (cmbFiltros.SelectedValue == "3")//nombre cliente
            {
                sql = sql + " where nombreCliente like '" + SearchText1.Text + "%'";
            }

            if (cmbFiltros.SelectedValue == "4")//modelo
            {
                sql = sql + " where nombremodelo like '" + SearchText1.Text + "%'";
            }

            SqlDataSource1.SelectCommand=sql;
            Browse1.DataBind();
        }

      


        #endregion

        protected void oprimirBoton(object sender, System.Web.UI.ImageClickEventArgs eventoArgs)
        {
            Response.Redirect("frmHojaVida.aspx?sx=" + ((ImageButton)sender).ValidationGroup);
        }
    }
}
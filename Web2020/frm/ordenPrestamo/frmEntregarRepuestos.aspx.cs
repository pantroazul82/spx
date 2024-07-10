using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.ordenPrestamo
{
    public partial class frmEntregarRepuestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verifiamos permisos
            clsSeguridad cls = new clsSeguridad();
            cls.comprobarAcceso(Page, Session, Response, 1104);
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
            SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter r = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            r.FillBycodOrdenPrestamo(ds.repuestosxOrdenPrestamo, op.CodOrdenPrestamo);

            #region validamos
            for (int k = 0; k < GridView1.Rows.Count; k++)
            {
                for (int j = 0; j < ds.repuestosxOrdenPrestamo.Count; j++)
                {
                    if (GridView1.Rows[k].Cells[0].Text == ds.repuestosxOrdenPrestamo[j].codRepuesto)
                    {
                        int cantidadPrestad = int.Parse(GridView1.Rows[k].Cells[3].Text);
                        int CantidadSolicitada = int.Parse(((DropDownList)GridView1.Rows[k].FindControl("cmbCantidadAprobada")).Text);
                        int CantidadNota = int.Parse(((DropDownList)GridView1.Rows[k].FindControl("cmbCantidadNota")).Text);

                        if (CantidadSolicitada + CantidadNota > cantidadPrestad)
                        {
                            lblError.Text = "Error en las cantidades del repuesto (" + GridView1.Rows[k].Cells[0].Text.Trim() + ")" + GridView1.Rows[k].Cells[1].Text.Trim() + " la cantidad recibida mas la cantidad con nota de salida no puede superar lo recibido por el ingeniero";
                            return;
                        }
                    }
                }
            }
            #endregion



            op.CodEstadoOrdenPrestamo = 7;
            op.LoginRecibido = Session["ss_login"].ToString();
            op.ObsDevolucion = txtObsRechazo.Text;
            f.Save(op);
            f.Commit();

            for (int k = 0; k < GridView1.Rows.Count; k++)
            {
                for (int j = 0; j < ds.repuestosxOrdenPrestamo.Count; j++)
                {
                    if (GridView1.Rows[k].Cells[0].Text == ds.repuestosxOrdenPrestamo[j].codRepuesto)
                    {
                        int CantidadSolicitada = int.Parse(((DropDownList)GridView1.Rows[k].FindControl("cmbCantidadAprobada")).Text);
                        int CantidadNota = int.Parse(((DropDownList)GridView1.Rows[k].FindControl("cmbCantidadNota")).Text);
                        string obsNota = ((TextBox)GridView1.Rows[k].FindControl("txtNotaSalida")).Text;
                        //primero la quitamos
                        r.DeleteQuery(op.CodOrdenPrestamo, ds.repuestosxOrdenPrestamo[j].codRepuesto);
                        //luego agregamos de nuevo la fila

                        r.Insert(op.CodOrdenPrestamo, ds.repuestosxOrdenPrestamo[j].codRepuesto, true,
                            (CantidadSolicitada > 0), (CantidadNota > 0), obsNota, ds.repuestosxOrdenPrestamo[j].fechaEntregaIng, DateTime.Now

                            , DateTime.Now, ds.repuestosxOrdenPrestamo[j].cantidadSolicitada,
                            ds.repuestosxOrdenPrestamo[j].cantidadPrestada, CantidadSolicitada, CantidadNota);
                    }
                }
            }
            Response.Redirect("frmListadoOrdenesPrestamo.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //cargamos el combo
            if (e.Row.FindControl("cmbCantidadAprobada") != null)
            {
                DropDownList d = (DropDownList)e.Row.FindControl("cmbCantidadAprobada");
                string limite = e.Row.Cells[2].Text;
                for (int k = 0; k <= int.Parse(limite); k++)
                {

                    d.Items.Add(new ListItem((k).ToString(), (k).ToString()));
                }
                d.SelectedValue = limite;


                DropDownList dd = (DropDownList)e.Row.FindControl("cmbCantidadNota");

                for (int k = 0; k <= int.Parse(limite); k++)
                {

                    dd.Items.Add(new ListItem((k).ToString(), (k).ToString()));
                }
                dd.SelectedValue = "0";


            }
        }
    }
}
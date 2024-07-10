using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.ordenPrestamo
{
    public partial class frmRecibirRepuestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verifiamos permisos
            clsSeguridad cls = new clsSeguridad();
            cls.comprobarAcceso(Page, Session, Response, 1002);
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
            op.CodEstadoOrdenPrestamo = 5;
            op.LoginAceptado = Session["ss_login"].ToString();
            op.ObsEntrega = txtObsRechazo.Text;
            f.Save(op);
            f.Commit();

            SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter r = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            r.FillBycodOrdenPrestamo(ds.repuestosxOrdenPrestamo, op.CodOrdenPrestamo);
            for (int k = 0; k < GridView1.Rows.Count; k++)
            {
                for (int j = 0; j < ds.repuestosxOrdenPrestamo.Count; j++)
                {
                    if (GridView1.Rows[k].Cells[0].Text == ds.repuestosxOrdenPrestamo[j].codRepuesto)
                    {
                        int CantidadSolicitada = int.Parse(((DropDownList)GridView1.Rows[k].FindControl("cmbCantidadAprobada")).Text);
                        //primero la quitamos
                        r.DeleteQuery(op.CodOrdenPrestamo, ds.repuestosxOrdenPrestamo[j].codRepuesto);
                        //luego agregamos de nuevo la fila

                        r.Insert(op.CodOrdenPrestamo, ds.repuestosxOrdenPrestamo[j].codRepuesto, true,
                            false, false, "", DateTime.Now, null, null, ds.repuestosxOrdenPrestamo[j].cantidadSolicitada, CantidadSolicitada, 0, 0);
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
            }
        }
    }
}
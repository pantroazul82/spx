﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_parametrizacion_frmlistadoRevisionProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 2009);
    }
    protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("frmRevisionProducto.aspx");
    }

    protected void btnEditar_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmRevisionProducto.aspx?cod=" + im.ValidationGroup.ToString());
    }

    protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ImageButton im = (ImageButton)sender;
            SPControladoraDatos.dsCientificaTableAdapters.revision_estado_productoTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.revision_estado_productoTableAdapter();

            obj.DeleteQuery(int.Parse(im.ValidationGroup.ToString()));
            RadGrid1.DataBind();
        }
        catch (Exception)
        {
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmListadoDestinacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //validar permisos pendiente
    }
    protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("frmDetalleDestinacion.aspx");
    }

    protected void btnEditar_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmDetalleDestinacion.aspx?cod=" + im.ValidationGroup.ToString());
    }

    protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ImageButton im = (ImageButton)sender;
            SPControladoraDatos.dsContratosSuministroTableAdapters.destinacion_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.destinacion_suministroTableAdapter();

            obj.DeleteQuery(int.Parse(im.ValidationGroup.ToString()));
            RadGrid1.DataBind();
        }
        catch (Exception)
        {
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmDetalleAseguradora : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.aseguradora_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.aseguradora_suministroTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_aseguradora_suministro(ds.aseguradora_suministro, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.aseguradora_suministro[0].nombre_cod_aseguradora_suministro;


                lblCodTipo.Text = ds.aseguradora_suministro[0].cod_aseguradora_suministro.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoAseguradora.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "El nombre de la aseguradora es obligatoria";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.aseguradora_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.aseguradora_suministroTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoAseguradora.aspx");
    }

}
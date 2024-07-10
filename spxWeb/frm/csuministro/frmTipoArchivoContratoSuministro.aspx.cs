using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmTipoArchivoContratoSuministro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_tipoarchivoxcontratos_suministro(ds.tipoarchivoxcontratos_suministro, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.tipoarchivoxcontratos_suministro[0].nombre_archivoxcontratos_suministro;
                if (!ds.tipoarchivoxcontratos_suministro[0].Iscod_manualNull())
                {
                    txtCodManual.Text = ds.tipoarchivoxcontratos_suministro[0].cod_manual;
                }

                lblCodTipo.Text = ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadpTipoArchivoContratoSuministro.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text,txtCodManual.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text,txtCodManual.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadpTipoArchivoContratoSuministro.aspx");
    }
}
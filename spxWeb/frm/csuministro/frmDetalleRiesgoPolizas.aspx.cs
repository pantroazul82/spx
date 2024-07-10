using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmDetalleRiesgoPolizas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.riesgo_poliza_consumoTableAdapter obj = 
                    new SPControladoraDatos.dsContratosSuministroTableAdapters.riesgo_poliza_consumoTableAdapter ();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_riesgo_poliza_consumo(ds.riesgo_poliza_consumo, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.riesgo_poliza_consumo[0].nombre_riesgo_poliza_consumo;


                lblCodTipo.Text = ds.riesgo_poliza_consumo[0].cod_riesgo_poliza_consumo.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoRiesgoPolizas.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.riesgo_poliza_consumoTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.riesgo_poliza_consumoTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoRiesgoPolizas.aspx");
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmDivisionExperienciaDetalle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.division_experiencia_contrato_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.division_experiencia_contrato_suministroTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_division_experiencia_contrato_suministro(ds.division_experiencia_contrato_suministro, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.division_experiencia_contrato_suministro[0].nombre_division_experiencia_contrato_suministro;
             

                lblCodTipo.Text = ds.division_experiencia_contrato_suministro[0].cod_division_experiencia_contrato_suministro.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoDivisionExperiencia.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.division_experiencia_contrato_suministroTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.division_experiencia_contrato_suministroTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoDivisionExperiencia.aspx");
    }
}
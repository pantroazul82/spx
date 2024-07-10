using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmGrupoReactivoExperiencia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivo_experienciaTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivo_experienciaTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                ds.EnforceConstraints = false;
                obj.FillByCod_grupo_reactivo_experiencia(ds.grupo_reactivo_experiencia, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.grupo_reactivo_experiencia[0].nombre_grupo_reactivo_experiencia;


                lblCodTipo.Text = ds.grupo_reactivo_experiencia[0].cod_grupo_reactivo_experiencia.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoGrupoReactivoExperiencia.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }

        SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivo_experienciaTableAdapter obj = new SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivo_experienciaTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text);
        }
        else
        {
            obj.UpdateQuery(txtDescripcion.Text, int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoGrupoReactivoExperiencia.aspx");
    }

}
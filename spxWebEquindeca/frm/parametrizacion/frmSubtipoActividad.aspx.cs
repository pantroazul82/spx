using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_parametrizacion_frmSubtipoActividad : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter();
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                obj.FillBycod_subtipo_tarea_calendario(ds.sub_tipo_tarea_calendario, int.Parse(Request.Params["cod"]));
                //--
                cmbTipoActividad.SelectedValue = ds.sub_tipo_tarea_calendario[0].cod_tipo_tarea_calendario.ToString();
                txtDescripcion.Text = ds.sub_tipo_tarea_calendario[0].descripcion;
                    txtUrl.Text = ds.sub_tipo_tarea_calendario[0].url;
                    chkActivo.Checked = ds.sub_tipo_tarea_calendario[0].activo;

                lblCodSubTipo.Text = ds.sub_tipo_tarea_calendario[0].cod_subtipo_tarea_calendario.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoSubtipoActividad.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (cmbTipoActividad.SelectedValue == string.Empty)
        {
            lblError.Text = "El tipo de actividad es obligatoria";
            return;
        }
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter();
        if (lblCodSubTipo.Text == string.Empty)
        {
            obj.Insert(int.Parse(cmbTipoActividad.SelectedValue), txtDescripcion.Text, txtUrl.Text, chkActivo.Checked);
        }
        else
        {
            obj.UpdateQuery(int.Parse(cmbTipoActividad.SelectedValue),txtDescripcion.Text, txtUrl.Text, chkActivo.Checked, int.Parse(lblCodSubTipo.Text));
        }

        Response.Redirect("frmListadoSubtipoActividad.aspx");
    }
}
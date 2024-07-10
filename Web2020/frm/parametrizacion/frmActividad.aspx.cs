using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.parametrizacion
{
    public partial class frmActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //los permisos deben validarse al final masivamente
            if (Request.Params["cod"] != null)
            {
                if (!IsPostBack)
                {
                    SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter();
                    SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                    ds.EnforceConstraints = false;
                    obj.FillBycod_tipo_actividadxsubtipo_tarea_calendario(ds.tipo_actividadxsubtipo_tarea_calendario, int.Parse(Request.Params["cod"]));
                    //--
                    //cargamos el combo
                    SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter objS = new SPControladoraDatos.dsSpxTableAdapters.sub_tipo_tarea_calendarioTableAdapter();
                    objS.FillBycod_subtipo_tarea_calendario(ds.sub_tipo_tarea_calendario, ds.tipo_actividadxsubtipo_tarea_calendario[0].cod_subtipo_tarea_calendario);

                    cmbTipoActividad.DataBind();
                    cmbTipoActividad.SelectedValue = ds.sub_tipo_tarea_calendario[0].cod_tipo_tarea_calendario.ToString();
                    cmbSubTipoActividad.DataBind();
                    cmbSubTipoActividad.SelectedValue = ds.sub_tipo_tarea_calendario[0].cod_subtipo_tarea_calendario.ToString();
                    cmbSubTipoActividad.Enabled = false;
                    cmbTipoActividad.Enabled = false;

                    txtDescripcion.Text = ds.tipo_actividadxsubtipo_tarea_calendario[0].descripcion;

                    chkActivo.Checked = ds.tipo_actividadxsubtipo_tarea_calendario[0].activo;

                    lblCodActividad.Text = ds.tipo_actividadxsubtipo_tarea_calendario[0].cod_tipo_actividadxsubtipo_tarea_calendario.ToString();
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmListadoActividad.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos
            if (cmbSubTipoActividad.SelectedValue == string.Empty)
            {
                lblError.Text = "El tipo de actividad es obligatoria";
                return;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                lblError.Text = "La descipcion es obligatoria";
                return;
            }
            SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tipo_actividadxsubtipo_tarea_calendarioTableAdapter();
            if (lblCodActividad.Text == string.Empty)
            {
                obj.Insert(int.Parse(cmbSubTipoActividad.SelectedValue), txtDescripcion.Text, chkActivo.Checked);
            }
            else
            {
                obj.UpdateQuery(txtDescripcion.Text, chkActivo.Checked, int.Parse(lblCodActividad.Text));
            }

            Response.Redirect("frmListadoActividad.aspx");
        }
    }
}
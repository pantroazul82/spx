using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_parametrizacion_frmTipoActividad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //los permisos deben validarse al final masivamente
        if (Request.Params["cod"] != null)
        {
            if (!IsPostBack)
            {
                SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter();
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                ds.EnforceConstraints = false;
                obj.FillBycod_tipo_tarea_calendario(ds.tipo_tarea_calendario, int.Parse(Request.Params["cod"]));
                //--
                txtDescripcion.Text = ds.tipo_tarea_calendario[0].descripcion;
                if (!ds.tipo_tarea_calendario[0].IsurlNull())
                    txtUrl.Text = ds.tipo_tarea_calendario[0].url;
                if (!ds.tipo_tarea_calendario[0].IsactivoNull())
                    chkActivo.Checked = ds.tipo_tarea_calendario[0].activo;

                lblCodTipo.Text = ds.tipo_tarea_calendario[0].cod_tipo_tarea_calendario.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoTipoTarea.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        //validamos
        if (txtDescripcion.Text == string.Empty)
        {
            lblError.Text = "La descipcion es obligatoria";
            return;
        }
        SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter();
        if (lblCodTipo.Text == string.Empty)
        {
            obj.Insert(txtDescripcion.Text, txtUrl.Text, chkActivo.Checked);
        }
        else {
            obj.UpdateQuery(txtDescripcion.Text, txtUrl.Text, chkActivo.Checked,int.Parse(lblCodTipo.Text));
        }

        Response.Redirect("frmListadoTipoTarea.aspx");
    }
}
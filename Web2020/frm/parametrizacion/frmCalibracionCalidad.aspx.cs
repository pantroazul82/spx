using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.parametrizacion
{
    public partial class frmCalibracionCalidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //los permisos deben validarse al final masivamente
            if (Request.Params["cod"] != null)
            {
                if (!IsPostBack)
                {
                    SPControladoraDatos.dsCientificaTableAdapters.calibracion_calidadTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.calibracion_calidadTableAdapter();
                    SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                    ds.EnforceConstraints = false;
                    obj.FillBycod_calibracion_calidad(ds.calibracion_calidad, int.Parse(Request.Params["cod"]));
                    //--
                    txtDescripcion.Text = ds.calibracion_calidad[0].calibracion_calidad;

                    if (!ds.calibracion_calidad[0].IsactivoNull())
                        chkActivo.Checked = ds.calibracion_calidad[0].activo;

                    lblCodTipo.Text = ds.calibracion_calidad[0].cod_calibracion_calidad.ToString();
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmListadoCalibracionCalidad.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos
            if (txtDescripcion.Text == string.Empty)
            {
                lblError.Text = "La descipcion es obligatoria";
                return;
            }
            SPControladoraDatos.dsCientificaTableAdapters.calibracion_calidadTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.calibracion_calidadTableAdapter();
            if (lblCodTipo.Text == string.Empty)
            {
                obj.Insert(txtDescripcion.Text, chkActivo.Checked);
            }
            else
            {
                obj.UpdateQuery(txtDescripcion.Text, chkActivo.Checked, int.Parse(lblCodTipo.Text));
            }

            Response.Redirect("frmListadoCalibracionCalidad.aspx");
        }
    }
}
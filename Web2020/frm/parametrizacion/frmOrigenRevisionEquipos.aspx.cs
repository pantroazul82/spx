using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.parametrizacion
{
    public partial class frmOrigenRevisionEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //los permisos deben validarse al final masivamente
            if (Request.Params["cod"] != null)
            {
                if (!IsPostBack)
                {
                    SPControladoraDatos.dsCientificaTableAdapters.origen_revision_equiposTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.origen_revision_equiposTableAdapter();
                    SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                    ds.EnforceConstraints = false;
                    obj.FillBycod_origen_revision_equipos(ds.origen_revision_equipos, int.Parse(Request.Params["cod"]));
                    //--
                    txtDescripcion.Text = ds.origen_revision_equipos[0].nombre_origen_revision_equipos;
                    chkActivo.Checked = ds.origen_revision_equipos[0].activo;
                    lblCodTipo.Text = ds.origen_revision_equipos[0].cod_origen_revision_equipos.ToString();
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmListadoOrigenRevisionEquipos.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos
            if (txtDescripcion.Text == string.Empty)
            {
                lblError.Text = "La descipcion es obligatoria";
                return;
            }
            SPControladoraDatos.dsCientificaTableAdapters.origen_revision_equiposTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.origen_revision_equiposTableAdapter();

            if (lblCodTipo.Text == string.Empty)
            {
                obj.Insert(txtDescripcion.Text, chkActivo.Checked);
            }
            else
            {
                obj.UpdateQuery(txtDescripcion.Text, chkActivo.Checked, int.Parse(lblCodTipo.Text));
            }

            Response.Redirect("frmListadoOrigenRevisionEquipos.aspx");
        }
    }
}
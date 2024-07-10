using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.calendar
{
    public partial class frmCerrarPendientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obj = new clsSeguridad();
            obj.comprobarAcceso(Page, Session, Response, 2007);
            if (Request.QueryString["cod"] == null)
                obj.comprobarAcceso(Page, Session, Response, 80032972);
            lblCodActividad.Text = Request.QueryString["cod"].ToString();

        }

        public string verNombreUsuario(object codUser)
        {
            if (codUser == null || codUser == System.DBNull.Value) return "";

            string sql = "select nombre from usuario where cod_usuario =" + codUser;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            return bd.ejecutarProcedimiento(sql).ToString();
        }

        protected void btnGuardarFecha_Click(object sender, ImageClickEventArgs e)
        {

            ImageButton im = (ImageButton)sender;
            DateTime valor = DateTime.Now;
            for (int k = 0; k < RadGrid1.Items.Count; k++)
            {
                Telerik.Web.UI.RadDateTimePicker r = (Telerik.Web.UI.RadDateTimePicker)RadGrid1.Items[k].FindControl("RadDateTimePicker1");
                ImageButton btnI = (ImageButton)RadGrid1.Items[k].FindControl("btnVisible");
                if (btnI.ValidationGroup == im.ValidationGroup.ToString())
                {
                    if (r.SelectedDate.HasValue)
                        valor = r.SelectedDate.Value;
                }
                if (valor > DateTime.Now)
                {
                    lblErrorFirma.Text = "La fecha de cierre no puede ser mayor que el actual.";
                    return;
                }
            }
            SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter objP = new SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter();
            objP.UpdateFecha(valor, int.Parse(Session["ss_cod_usuario"].ToString()), int.Parse(im.ValidationGroup));
            RadGrid1.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmNewTask.aspx?cod=tarea|" + lblCodActividad.Text);
        }
        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            //validamos los pendientes
            SPControladoraDatos.dsCientifica dsPendienetes = new SPControladoraDatos.dsCientifica();
            dsPendienetes.EnforceConstraints = false;
            SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter objPendientes = new SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter();
            objPendientes.FillByCod_tarea_calendario(dsPendienetes.pendiente_tarea, int.Parse(lblCodActividad.Text));
            bool valido = true;
            for (int k = 0; k < dsPendienetes.pendiente_tarea.Count; k++)
            {
                if (dsPendienetes.pendiente_tarea[k].Isfecha_ejecucion_pendienteNull())
                {
                    valido = false;
                    break;
                }
            }

            if (!valido)
            {
                lblErrorFirma.Text = "Algunos pendientes no tienen fecha de ejecucion!";
                return;
            }
            valido = false;
            for (int k = 0; k < dsPendienetes.pendiente_tarea.Count; k++)
            {
                if (dsPendienetes.pendiente_tarea[k].fecha_ejecucion_pendiente > DateTime.Now)
                {
                    lblErrorFirma.Text = "Algunos pendientes no tienen fecha de ejecucion valida!";
                    break;
                }
            }


            for (int k = 0; k < dsPendienetes.pendiente_tarea.Count; k++)
            {
                if (dsPendienetes.pendiente_tarea[k].fecha_ejecucion_pendiente > DateTime.Now)
                {
                    lblErrorFirma.Text = "La fecha de ejecucion no puede ser mayor a la actual.";
                    break;
                }
            }

            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
            int est = 3;
            //DateTime fechaParcial = DateTime.Now;

            objEstado.FillByCod_manual(ds.estado_tarea_calendario, est);

            obj.UpdateEstadoAprobacion(ds.estado_tarea_calendario[0].cod_estado_tarea_calendario, int.Parse(lblCodActividad.Text));
            obj.UpdateTienePendientes(false, int.Parse(lblCodActividad.Text));
            obj.UpdateFechaCierre(DateTime.Now, int.Parse(lblCodActividad.Text));

            obj.UpdateObervaciones_aprobacion(txtObservacionesAprobacion.Text, int.Parse(lblCodActividad.Text));

            Response.Redirect("frmNewTask.aspx?cod=tarea|" + lblCodActividad.Text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmenviarAprobacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["aprobarOrden"] != "OK")
            {
                Response.Redirect("frmEjecutarControl.aspx?cod=" + Request.QueryString["cod"]);
            }
            Session["aprobarOrden"] = "";
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEjecutarControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if(cmbUsuarios.SelectedValue == null || cmbUsuarios.SelectedValue.Trim() == string.Empty)
        {
        //
            lblError.Text = "Seleccione un usuario";
            return;
        }
        SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter controlCalidad = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();

        estado.FillByCodmanual(ds.estado_control_calidad, 3);
        controlCalidad.UpdateEstadoControlCalidad(ds.estado_control_calidad[0].cod_estado_control_calidad, int.Parse(Request.QueryString["cod"]));
        controlCalidad.UpdateAprobacion(DateTime.Now, int.Parse(cmbUsuarios.SelectedValue), int.Parse(Request.QueryString["cod"]));
        //envia un email
        clsSeguridad cl = new clsSeguridad();
        string asunto = "Nuevo control de calidad requiere aprobacion";
        string cuerpo = "Nuevo control de calidad requiere aprobacion el codigo de la orden a aprobar es "+Request.QueryString["cod"];
        string sql = "select correo from usuario where cod_usuario = "+cmbUsuarios.SelectedValue;
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        string email = bd.ejecutarProcedimiento(sql).ToString();
        
        cl.enviarEmail(asunto, cuerpo, email);
        Response.Redirect("frmEjecutarControl.aspx?cod=" + Request.QueryString["cod"]);
    }
}
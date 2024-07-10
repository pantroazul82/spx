using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmCerrarControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 0);

        //debe validar el estado.     
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter objCalidad = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();

        SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter objEstado = new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
        objCalidad.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));

        objEstado.FillBycod_estado_control_calidad(ds.estado_control_calidad, ds.control_calidad[0].cod_estado_control_calidad);

        if (ds.estado_control_calidad[0].cod_manual != 5)//progrado o en ejecucion
        {
            Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
        }
        objCalidad.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));

        if(!ds.control_calidad[0].Isfecha_reporte_asesorNull())
        calEnvioReporteAsesor.SelectedDate = ds.control_calidad[0].fecha_reporte_asesor;

        if (!ds.control_calidad[0].Isfecha_reporte_clienteNull())
        calEnvioReporteCliente.SelectedDate = ds.control_calidad[0].fecha_reporte_cliente;
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter control = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        control.UpdatefechasCierre(calEnvioReporteAsesor.SelectedDate, 
            calEnvioReporteCliente.SelectedDate,
            int.Parse( Request.QueryString["cod"] ));
        lblError.Text = "Cambios Guardados Satisfactoriamente";
        //Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnCerrar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter control = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
        estado.FillByCodmanual(ds.estado_control_calidad, 4);
        control.UpdateEstadoControlCalidad(ds.estado_control_calidad[0].cod_estado_control_calidad,
             int.Parse(Request.QueryString["cod"]));
        Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnAgregarSeguimiento_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmObservacionesSeguimiento.aspx?cod=" + Request.QueryString["cod"]);
    }
}
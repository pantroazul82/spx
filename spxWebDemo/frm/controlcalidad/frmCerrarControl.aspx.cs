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
        if(Request.QueryString["cod"] == null)
        {
            Response.Redirect("~/default.aspx");
        }
        //debe validar el estado.     
        if (!IsPostBack)
        {
            SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter objCalidad = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
            SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
            ds.EnforceConstraints = false;
            SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter objEstado = new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
            objCalidad.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));

            objEstado.FillBycod_estado_control_calidad(ds.estado_control_calidad, ds.control_calidad[0].cod_estado_control_calidad);

            if (ds.estado_control_calidad[0].cod_manual != 5)//progrado o en ejecucion
            {
                Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
            }
            objCalidad.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));



            if (!ds.control_calidad[0].Isfecha_reporte_asesorNull())
            {
                calEnvioReporteAsesor.SelectedDate = ds.control_calidad[0].fecha_reporte_asesor;
                calEnvioReporteAsesor.Enabled = false;
            }

            if (!ds.control_calidad[0].Isfecha_reporte_clienteNull())
            {
                calEnvioReporteCliente.SelectedDate = ds.control_calidad[0].fecha_reporte_cliente;
                calEnvioReporteCliente.Enabled = false;
            }

            if (!ds.control_calidad[0].Isfecha_dar_bajaNull())
            {
                calDarBaja.SelectedDate = ds.control_calidad[0].fecha_dar_baja;
            }
            if (!ds.control_calidad[0].Isfecha_devolucion_clienteNull())
            {
                calDevolucionCliente.SelectedDate = ds.control_calidad[0].fecha_devolucion_cliente;
            }
            if (!ds.control_calidad[0].Isfecha_devolucion_proveedorNull())
            {
                calDevolucionProveedor.SelectedDate = ds.control_calidad[0].fecha_devolucion_proveedor;
            }
            if (!ds.control_calidad[0].Isdar_bajaNull())
            {
                rdDispoDardeBaja.Checked = ds.control_calidad[0].dar_baja;
            }
            if (!ds.control_calidad[0].Isdevolucion_clienteNull())
            {
                rdDispoDEvolucionCliente.Checked = ds.control_calidad[0].devolucion_cliente;
            }
            if (!ds.control_calidad[0].Isdevolucion_proveedorNull())
            {
                rdDispoDEvolucionProveedor.Checked = ds.control_calidad[0].devolucion_proveedor;
            }
            //--
            if (!ds.control_calidad[0].Isaplica_reclamo_proveedorNull())
            {
                rdAplicaReclamo.Checked = ds.control_calidad[0].aplica_reclamo_proveedor;
                rdNoAplicaReclamo.Checked = !ds.control_calidad[0].aplica_reclamo_proveedor;
            }
            if (!ds.control_calidad[0].Isfecha_envio_reclamoNull())
            {
                calFEchaReclamoProveedor.SelectedDate = ds.control_calidad[0].fecha_envio_reclamo;
            }
            if (!ds.control_calidad[0].Isreposicion_tramitada_porNull())
            {
                cmbTramitadoPor.SelectedValue = ds.control_calidad[0].reposicion_tramitada_por.ToString().Trim();
            }
            if (!ds.control_calidad[0].Isfecha_respuesta_proveedorNull())
            {
                calFechaRespuestaProveedor.SelectedDate = ds.control_calidad[0].fecha_respuesta_proveedor;
            }
            if (!ds.control_calidad[0].Isfecha_tramite_garantiaNull())
            {
                calFechaTramiteGarantia.SelectedDate = ds.control_calidad[0].fecha_tramite_garantia;
            }
            if (!ds.control_calidad[0].Isticket_garantiaNull())
            {
                txtIdGarantia.Text = ds.control_calidad[0].ticket_garantia.Trim();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter control = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        control.UpdateFechasCierre(calEnvioReporteAsesor.SelectedDate, 
            calEnvioReporteCliente.SelectedDate,
            int.Parse( Request.QueryString["cod"] ));

        control.UpdateTabAprobacion(txtIdGarantia.Text, calFechaTramiteGarantia.SelectedDate, rdAplicaReclamo.Checked,
            calFEchaReclamoProveedor.SelectedDate, calFechaRespuestaProveedor.SelectedDate,
            ((cmbTramitadoPor.SelectedValue == null || cmbTramitadoPor.SelectedValue == string.Empty) ? ((int?)null) : int.Parse(cmbTramitadoPor.SelectedValue)),
            int.Parse(Request.QueryString["cod"]));

        control.UpdateDisposicionProducto(rdDispoDardeBaja.Checked,calDarBaja.SelectedDate,rdDispoDEvolucionCliente.Checked,
            calDevolucionCliente.SelectedDate, rdDispoDEvolucionProveedor.Checked, calDevolucionProveedor.SelectedDate,
            int.Parse(Request.QueryString["cod"]));

        lblError.Text = "Cambios Guardados Satisfactoriamente";
        //Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnCerrar_Click(object sender, EventArgs e)
    {

        if (!rdAplicaReclamo.Checked && !rdNoAplicaReclamo.Checked)
        {
            lblError.Text = "Debe especificar si aplica reclamo o no.";
            return ;
        }

        if (rdAplicaReclamo.Checked && (cmbTramitadoPor.SelectedValue == null || cmbTramitadoPor.SelectedValue.Trim() == string.Empty))
        {
            lblError.Text = "Si aplica reclamo, debe especificar quien tramito la garantia!";
            return ;
        }
        if (rdAplicaReclamo.Checked && !calFEchaReclamoProveedor.SelectedDate.HasValue)
        {
            lblError.Text = "Si aplica reclamo, debe especificar la Fecha Envio Reclamo Proveedor!";
            return;
        }
        if (rdAplicaReclamo.Checked && !calFechaRespuestaProveedor.SelectedDate.HasValue)
        {
            lblError.Text = "Si aplica reclamo, debe especificar la Fecha de Respuesta Proveedor!";
            return;
        }
        if (rdAplicaReclamo.Checked && txtIdGarantia.Text.Trim() == string.Empty)
        {
            lblError.Text = "Si aplica reclamo, debe especificar el ID con que se tramito la Garantía!";
            return;
        }
        if (rdAplicaReclamo.Checked && !calFechaTramiteGarantia.SelectedDate.HasValue)
        {
            lblError.Text = "Si aplica reclamo, debe especificar la fecha de tramite de la Garantia!";
            return;
        }
        if (!rdDispoDardeBaja.Checked && !rdDispoDEvolucionCliente.Checked && !rdDispoDEvolucionProveedor.Checked)
        {
            lblError.Text = "Debe ingresar la Disposición del producto";
            return ;
        }

       
       

        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter control = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
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
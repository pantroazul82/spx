using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmResumenDetalladoControl : System.Web.UI.Page
{

    public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }
    }


    public static string nit = "";

    protected void controlLlamadas1_agregarElementos(object sender, EventArgs e)
    {
        cargarLlamada(sender.ToString());
    }

    protected void cargarLlamada(string codLlamada)
    {
        if (!string.IsNullOrEmpty(codLlamada))
        {
            SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter objCientifica = new SPControladoraDatos.dsSpxTableAdapters.asesoria_cientificaTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            objCientifica.FillByCod_asesoria_cientifica(ds.asesoria_cientifica, int.Parse(controlLlamadas1.verCodigos()[0]));
            string sql = "select rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + ds.asesoria_cientifica[0].nitCliente + "'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
            txtClienteLlamada.Text = tb.Rows[0][0].ToString();
            txtSocioNegocioLlamada.Text = tb.Rows[0][1].ToString();
            cargarClienteLlamada();

            cmbContactoLlamada.DataBind();
            cmbContactoLlamada.SelectedValue = ds.asesoria_cientifica[0].codContacto;
            cmbSucursalLlamada.DataBind();
            cmbSucursalLlamada.SelectedValue = ds.asesoria_cientifica[0].codSucursal;
       

          
                    txtNumeroLote.ReadOnly = true;
                  calVencimiento.Enabled = false;
              
            cmbSucursalLlamada.Enabled = false;
            cmbContactoLlamada.Enabled = false;
            txtClienteLlamada.ReadOnly = true;
            txtSocioNegocioLlamada.ReadOnly = true;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 0);
        controlLlamadas1.agregarElementos += new EventHandler(controlLlamadas1_agregarElementos);
        if (!IsPostBack)
        {
            if (controlLlamadas1.verCodigos().Count > 0)
            {
                cargarLlamada(controlLlamadas1.verCodigos()[0]);
            }
        }

        if (Request.QueryString["cod"] == null)
        {
            Response.Redirect("frmListadoControlCalidad.aspx");
        }
        //debe validar el estado.     
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter objCalidad = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter objEstado = new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
        objCalidad.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));

        objEstado.FillBycod_estado_control_calidad(ds.estado_control_calidad, ds.control_calidad[0].cod_estado_control_calidad);

        if (ds.estado_control_calidad[0].cod_manual == 1)
        {
            btnReabrir.Visible = false;
            btnAprobar.Visible = false;
            btnCerrar.Visible = false;
            btnReasignarApobador.Visible = false;

        }
        else if (ds.estado_control_calidad[0].cod_manual == 2)
        {
            btnReabrir.Visible = false;
            btnAprobar.Visible = false;
            btnCerrar.Visible = false;
            btnReasignarApobador.Visible = false;
            btneditar.Visible = false;

        }else if (ds.estado_control_calidad[0].cod_manual == 3)
        {//aprobar
            btnReabrir.Visible = true;
            //btnAprobar.Visible = false;
            btneditar.Visible = false;
            btnEjecutar.Visible = false;
            btnCerrar.Visible = false;
        }
        else if (ds.estado_control_calidad[0].cod_manual == 4)
        {
            btnReabrir.Visible = true;
            btnAprobar.Visible = false;
            btneditar.Visible = false;
            btnReasignarApobador.Visible = false;
            btnCerrar.Visible = false;
            btnEjecutar.Visible = false;
        }
        else if (ds.estado_control_calidad[0].cod_manual == 5)
        {
            btnReabrir.Visible = true;
            btnAprobar.Visible = false;
            btneditar.Visible = false;
            btnEjecutar.Visible = false;
            btnReasignarApobador.Visible = false;
        }
        else if (ds.estado_control_calidad[0].cod_manual == 6)//anulado
        {
            btnReabrir.Visible = false;
            btnAprobar.Visible = false;
            btnAnular.Text = "ver informacion Anulacion";
            btneditar.Visible = false;
            btnEjecutar.Visible = false;
            btnReabrir.Visible = false;
btnCerrar.Visible = false;
            btnReasignarApobador.Visible = false;
        }
        //ocultamos los botones de acuerdo a los permisos
        string msg="";
        bool b = SPXSeguridad.verificadorPermisos.ejecutarAccion(2033, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        if (!b)
        {
            btnAprobar.Visible = false;
        }
        b = SPXSeguridad.verificadorPermisos.ejecutarAccion(2032, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        if (!b)
        {
            btnEjecutar.Visible = false;
        }
        else { 
        //hasta aca tiene permisos de ejecucion, ahora validamos que tenga asignado el contorl si no lo tiene asignado 
            //no lo puede ejecutar
            if (ds.control_calidad[0].asignado_a.ToString() != Session["ss_cod_usuario"].ToString())
            {
                btnEjecutar.Visible = false;
            }
        }
        b = SPXSeguridad.verificadorPermisos.ejecutarAccion(2034, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        if (!b)
        {
            btnCerrar.Visible = false;
        }
        b = SPXSeguridad.verificadorPermisos.ejecutarAccion(2035, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        if (!b)
        {
            if (btnAnular.Text != "ver informacion Anulacion")
            btnAnular.Visible = false;
        }
        b = SPXSeguridad.verificadorPermisos.ejecutarAccion(2036, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        if (!b)
        {
            btnReasignarApobador.Visible = false;
        }

        b = SPXSeguridad.verificadorPermisos.ejecutarAccion(2066, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        if (!b)
        {
            btnReabrir.Visible = false;
        }



        if (!IsPostBack)
        {

            objCalidad.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));
            lblCodControlCalidad.Text = ds.control_calidad[0].cod_control_calidad.ToString();
            lblConsecutivo2.Text = lblCodControlCalidad.Text;
            cargarInformacion(ds.control_calidad);

            //chkAtadaCliente.Checked = ds.tarea_calendario[0].atado_cliente;
            //txtCliente.Text = ds.tarea_calendario[0].nit_cliente.Trim();

            controlLlamadas1.ReadOnly = true;
            txtCliente.ReadOnly = true;
            RadTabStrip1.Visible = false;
        }
    }

    private void cargarInformacion(SPControladoraDatos.dsCientifica.control_calidadDataTable tb)
    {
        #region cargamos la informacion del control de calidad

        if (!tb[0].Isasignado_aNull())
        {
                cmbAsignadoA.DataBind();
            cmbAsignadoA.SelectedValue = tb[0].asignado_a.ToString();
            if (cmbAsignadoA.SelectedValue == null || cmbAsignadoA.SelectedValue.ToString().Trim() == string.Empty|| cmbAsignadoA.SelectedValue != tb[0].asignado_a.ToString())
            {//significa que no esta e el grupo el usuario
                //traemos el nombre del usuario
                string sq = "select nombre from usuario where cod_usuario =" + tb[0].asignado_a;
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                string nombre=bd.ejecutarProcedimiento(sq).ToString();
                cmbAsignadoA.Items.Add(new ListItem(nombre, tb[0].asignado_a.ToString()));
                cmbAsignadoA.SelectedValue = tb[0].asignado_a.ToString();
            }
        }

        if (!tb[0].Isfecha_vencimiento_reactivoNull())
            calVencimiento.SelectedDate = tb[0].fecha_vencimiento_reactivo;
        if (!tb[0].Islote_reactivoNull())
            txtNumeroLote.Text = tb[0].lote_reactivo;

        txtMotivo.Text = tb[0].motivo;

        if (!tb[0].Iscod_llamadaNull())
        {
            List<string> lista = new List<string>();
            lista.Add(tb[0].cod_llamada.ToString());
            controlLlamadas1.asignarCodigos(lista);
        }


        #endregion

        #region cliente o cliente interno
        if (tb[0].IsnitClienteNull())
        {
            RadMultiPage2.SelectedIndex = 1;
        }
        else
        {
            RadMultiPage2.SelectedIndex = 2;
            string sql = "select rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + tb[0].nitCliente + "'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable table = bd.ejecutarConsulta(sql).Tables[0];
            txtCliente.Text = table.Rows[0][0].ToString();
            txtClienteLlamada.Text = table.Rows[0][0].ToString();
            if (!tb[0].Iscod_llamadaNull())
            {
                try
                {
                    cargarLlamada(tb[0].cod_llamada.ToString());
                    cargarClienteLlamada();
                    RadMultiPage2.SelectedIndex = 0;
                }
                catch (Exception) { }
            }
            cargarCliente();
            cmbSucursal.SelectedValue = tb[0].codSucursal;
            cmbContacto.SelectedValue = tb[0].codContacto;
        }
        #endregion

        cmbFabricante.DataBind();
        SPControladoraDatos.dsSpx dss = new SPControladoraDatos.dsSpx();
        dss.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter objReferenciaREactivo = new SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter();
        objReferenciaREactivo.FillBycod_referencia_reactivo(dss.referencia_reactivo, tb[0].cod_referencia_reactivo);
        cmbFabricante.SelectedValue = dss.referencia_reactivo[0].codFabricante;
        cmbReactivo.DataBind();
        cmbReactivo.SelectedValue = dss.referencia_reactivo[0].cod_referencia_reactivo.ToString();

        if (!tb[0].Iscliente_internoNull())
        {
            txtClienteInterno.Text = tb[0].cliente_interno;
        }
        if (!tb[0].Istxt_controles_calidadNull())
        {
            txtControles.Text = tb[0].txt_controles_calidad;
        }
        if (!tb[0].Isprocesamiento_muestra_valoresNull())
        {
            rdProcesamientoMuestrasSi.Checked = tb[0].procesamiento_muestra_valores;
            rdProcesamientoMuestrasNo.Checked = !tb[0].procesamiento_muestra_valores;
        }   
        if (!tb[0].Iscomparacion_resultadosNull())
        {
            txtComparacionResultados.Text = tb[0].comparacion_resultados;
        }
        if (!tb[0].Isresultados_control_calidadNull())
        {
            EditorResultados.Content = tb[0].resultados_control_calidad;
        }




        if (!tb[0].Isfecha_reporte_asesorNull())
        {
            calEnvioReporteAsesor.SelectedDate = tb[0].fecha_reporte_asesor;
        }
        if (!tb[0].Isfecha_reporte_clienteNull())
        {
            calEnvioReporteCliente.SelectedDate = tb[0].fecha_reporte_cliente;
        }

        if (!tb[0].Isrealizado_localNull())
        {
            rdRealizadoAnnar.Checked = tb[0].realizado_local;
            rdRealizadoCliente.Checked = !tb[0].realizado_local;
        }
        if (!tb[0].Iscantidad_recibidaNull())
        {
            txtCantidadRecibido.Text = tb[0].cantidad_recibida;
        }
        if (!tb[0].Isnumero_facturaNull())
        {
            txtFactura.Text = tb[0].numero_factura;
        }
        if (!tb[0].Isfecha_facturaNull())
        {
            calFactura.SelectedDate = tb[0].fecha_factura;
        }
        if (!tb[0].Isfecha_llegada_productoNull())
        {
            calLlegadaProducto.SelectedDate = tb[0].fecha_llegada_producto;
        }
        if (!tb[0].Isfecha_apertura_productoNull())
        {
            calAperturaProducto.SelectedDate = tb[0].fecha_apertura_producto;
        }
        if (!tb[0].Isfecha_inconvenienteNull())
        {
            calIncoveniente.SelectedDate = tb[0].fecha_inconveniente;
        }

        if (!tb[0].Isresponsable_aprobacionNull())
        {
           cmbResponsableAprobacion.SelectedValue = tb[0].responsable_aprobacion.ToString();
        }

        txtMotivo.Text = tb[0].motivo;
        if (!tb[0].Isresultados_previos_htmlNull())
        {
            EditorResultadosPrevios.Content = tb[0].resultados_previos_html;
        }
        //equipo medico utilizado
        if (!tb[0].Iscod_revision_estado_productoNull())
        {
            txtRevisionEstadoProducto.Text = tb[0].cod_revision_estado_producto.ToString();
        }
        if (!tb[0].Iscod_calibracion_calidadNull())
        {
            cmbCalibracion.DataBind();
            cmbCalibracion.SelectedValue = tb[0].cod_calibracion_calidad.ToString();
        }

        
        if (!tb[0].IscodFabricanteUtilizadoNull() && !tb[0].IscodModeloutilizadoNull())
        {
            cmbFabricanteModeloutilizado.DataBind();
            cmbFabricanteModeloutilizado.SelectedValue = tb[0].codFabricanteUtilizado;

            cmbModeloUtilizado.DataBind();
            cmbModeloUtilizado.SelectedValue = tb[0].codModeloutilizado;
        }

        if (!tb[0].IsmuestrasNull())
        {
            txtNumeroMuestras.Text = tb[0].muestras;
        }

        if (!tb[0].Isanalisis_posibles_fallasNull())
        {
            EditorPosiblesFallas.Content = tb[0].analisis_posibles_fallas;
        }

        if (!tb[0].Isanalisis_confidencialNull())
        {
            chkAnalisisDeFallasConfidencial.Checked = tb[0].analisis_confidencial;
        }

        if (!tb[0].IsantecedentesNull())
        {
            EditorAntecedentes.Content = tb[0].antecedentes;
        }

        if (!tb[0].Isacciones_implementadasNull())
        {
            EditorAcciones.Content = tb[0].acciones_implementadas;
        }

        if (!tb[0].IsconclusionesNull())
        {
            EditorConclusiones.Content = tb[0].conclusiones;
        }
        if (!tb[0].Isperformance_adecuadoNull())
        {
            rdDesempenoAdecuado.Checked = tb[0].performance_adecuado;
            rdDesempenoNoAdecuado.Checked = !tb[0].performance_adecuado;
        }


        if (!tb[0].Isproblema_identificadoNull())
        {
            rdIdentificadoNo.Checked = !tb[0].problema_identificado;
            rdMotivoIdentificadoSi.Checked = tb[0].problema_identificado;
        }
        if (!tb[0].Israzon_problema_identificadoNull())
        {
            txtTextoIdentificado.Text = tb[0].razon_problema_identificado;
        }
        if (!tb[0].IsrecomendacionesNull())
        {
            txtRecomendaciones.Text = tb[0].recomendaciones;
        }
        if (!tb[0].Isconcepto_reposicionNull())
        {
            rdSiReposicion.Checked = tb[0].concepto_reposicion;
            rdnoReposicion.Checked = !tb[0].concepto_reposicion;
        }

        if (!tb[0].Iscantidad_a_reponerNull())
        {
            txtCantidadAReponer.Text = tb[0].cantidad_a_reponer;
        }
        if (!tb[0].Israzon_concepto_reposicionNull())
        {
            txtMotivoReposicion.Text = tb[0].razon_concepto_reposicion;
        }

        if (!tb[0].Isfecha_dar_bajaNull())
        {
            calDarBaja.SelectedDate = tb[0].fecha_dar_baja;
        }
        if (!tb[0].Isfecha_devolucion_clienteNull())
        {
            calDevolucionCliente.SelectedDate = tb[0].fecha_devolucion_cliente;
        }
        if (!tb[0].Isfecha_devolucion_proveedorNull())
        {
            calDevolucionProveedor.SelectedDate = tb[0].fecha_devolucion_proveedor;
        }
        if (!tb[0].Isdar_bajaNull())
        {
            rdDispoDardeBaja.Checked = tb[0].dar_baja;
        }
        if (!tb[0].Isdevolucion_clienteNull())
        {
            rdDispoDEvolucionCliente.Checked = tb[0].devolucion_cliente;
        }
        if (!tb[0].Isdevolucion_proveedorNull())
        {
            rdDispoDEvolucionProveedor.Checked = tb[0].devolucion_proveedor;
        }
        //informacion de aprobacion
        if (!tb[0].Isaplica_reclamo_proveedorNull())
        {
            rdAplicaReclamo.Checked = tb[0].aplica_reclamo_proveedor;
            rdNoAplicaReclamo.Checked = !tb[0].aplica_reclamo_proveedor;
        }
        if (!tb[0].Isfecha_envio_reclamoNull())
        {
            calFEchaReclamoProveedor.SelectedDate = tb[0].fecha_envio_reclamo;
        }
        if (!tb[0].Isreposicion_tramitada_porNull())
        {
            cmbTramitadoPor.SelectedValue = tb[0].reposicion_tramitada_por.ToString();
        }
        if (!tb[0].Isfecha_respuesta_proveedorNull())
        {
            calFechaRespuestaProveedor.SelectedDate = tb[0].fecha_respuesta_proveedor;
        }
        if (!tb[0].Isfecha_tramite_garantiaNull())
        {
            calFechaTramiteGarantia.SelectedDate = tb[0].fecha_tramite_garantia;
        }
        if (!tb[0].Isticket_garantiaNull())
        {
            txtIdGarantia.Text = tb[0].ticket_garantia;
        }

        if (!tb[0].Isresultados_previos_txtNull())
        {
            txtResultadosPreviosTxt.Text = tb[0].resultados_previos_txt;
        }
        if (!tb[0].Isresultados_txtNull())
        {
            txtResultadosTxt.Text = tb[0].resultados_txt;
        }
        if (!tb[0].Isanalisis_posibles_fallas_txtNull())
        {
            txtAnalisisPosiblesFallasTxt.Text = tb[0].analisis_posibles_fallas_txt;
        }
        if (!tb[0].Isconclusiones_txtNull())
        {
            txtconclusionestxt.Text = tb[0].conclusiones_txt;
        }


        /*
        tb[0].acciones_implementadas;
        tb[0].analisis_confidencial;
        tb[0].analisis_posibles_fallas;
        tb[0].antecedentes;
        tb[0].aplica_reclamo_proveedor;
        tb[0].asignado_a;
        tb[0].cantidad_a_reponer;
        tb[0].cantidad_recibida;
        tb[0].cod_calibracion_calidad;
        tb[0].cod_control_calidad_interno;
        tb[0].cod_dar_baja;
        tb[0].cod_devolucion_cliente;
        tb[0].cod_devolucion_proveedor;
        tb[0].cod_disposicion_producto;
        tb[0].cod_estado_control_calidad;
        tb[0].cod_llamada;
        tb[0].cod_referencia_reactivo;
        tb[0].cod_revision_estado_producto;
        tb[0].codContacto;
        tb[0].codFabricanteUtilizado;
        tb[0].codModeloutilizado;
        tb[0].codSucursal;
        tb[0].concepto_reposicion;
        tb[0].conclusiones;
        t
         * b[0].controles_calidad;
        tb[0].creado_por;
        tb[0].entregado_por;
        tb[0].es_anulada;
        tb[0].especialista;
        tb[0].fecha_aprobacion;
        tb[0].fecha_creacion;
        tb[0].fecha_dar_baja;
        tb[0].fecha_devolucion_cliente;
        tb[0].fecha_envio_aprobacion;
        tb[0].fecha_envio_reclamo;
        tb[0].fecha_fin_programacion;
        tb[0].fecha_generacion_reporte;
        tb[0].fecha_inicio_programacion;
        tb[0].fecha_procesamiento;
        tb[0].fecha_reporte_asesor;
        tb[0].fecha_reporte_cliente;
        tb[0].fecha_respuesta_proveedor;
        tb[0].fecha_tramite_garantia;
        tb[0].fecha_vencimiento_reactivo;
        tb[0].motivo_performance;
        tb[0].motivo_solicitud;
        tb[0].muestras;
        tb[0].nitCliente;
        tb[0].observaciones;
        tb[0].observaciones_anulacion;
        tb[0].performance_adecuado;
        tb[0].problema_identificado;
        tb[0].razon_concepto_reposicion;
        tb[0].razon_problema_identificado;
        tb[0].recibido_por;
        tb[0].recomendaciones;
        tb[0].resultados_html;
        tb[0].resultados_previos_html;
        tb[0].ticket_garantia;
         * */
    }

    public string sacarNit(string texto)
    {
        if (texto.LastIndexOf('(') <= 0)
            return "";
        string res = texto.Substring(texto.LastIndexOf('(') + 1);
        res = res.Substring(0, res.Length - 1);
        return res;
    }

    protected void btnCliente_Click(object sender, EventArgs e)
    {
        cargarCliente();
    }

    private void cargarCliente()
    {
        nit = sacarNit(txtCliente.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {

            sql = @"select codSucursal,nombreSucursal from sucursalCliente
				where nitCliente ='" + nit + "' ";
            cmbSucursal.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbSucursal.DataValueField = "codSucursal";
            cmbSucursal.DataTextField = "nombreSucursal";
            cmbSucursal.DataBind();
            //contactos

            sql = "select numeroSocio from clientes where nitCliente ='" + nit + "'";
            txtSocioNegocio.Text = obj.ejecutarProcedimiento(sql).ToString();
            sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre',telefono1 from contactosClientes
				where nitCliente ='" + nit + "' ";
            
            System.Data.DataTable tb2=obj.ejecutarConsulta(sql).Tables[0];
            txtTelefonoContacto.Text= tb2.Rows[0]["telefono1"].ToString();
            cmbContacto.DataSource = tb2;
            cmbContacto.DataValueField = "codContacto";
            cmbContacto.DataTextField = "nombre";
            cmbContacto.DataBind();

        }
    }

    private void cargarClienteLlamada()
    {
        nit = sacarNit(txtClienteLlamada.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {

            sql = @"select codSucursal,nombreSucursal from sucursalCliente
				where nitCliente ='" + nit + "' ";
            cmbSucursalLlamada.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbSucursalLlamada.DataValueField = "codSucursal";
            cmbSucursalLlamada.DataTextField = "nombreSucursal";
            cmbSucursalLlamada.DataBind();
            //contactos
            
            sql = "select numeroSocio from clientes where nitCliente ='" + nit + "'";
            txtSocioNegocioLlamada.Text = obj.ejecutarProcedimiento(sql).ToString();
            sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre',telefono1 from contactosClientes
				where nitCliente ='" + nit + "' ";
            
            System.Data.DataTable tb2=obj.ejecutarConsulta(sql).Tables[0];
            cmbContactoLlamada.DataSource = tb2;
            txtTelefonoContacto.Text = tb2.Rows[0]["telefono1"].ToString(); 
            cmbContactoLlamada.DataValueField = "codContacto";
            cmbContactoLlamada.DataTextField = "nombre";
            cmbContactoLlamada.DataBind();

        }
    }

       private bool validar()
    {
        if (RadMultiPage2.SelectedIndex == 0)
        {
            //valida que tenga llamada
            if (controlLlamadas1.verCodigos().Count == 0)
            {
                lblError.Text = "debe especificar la llamada!";
                return false;
            }
        }

        if (RadMultiPage2.SelectedIndex == 1)
        {
            //valida que tenga llamada
            if (txtClienteInterno.Text.Trim() == string.Empty)
            {
                lblError.Text = "debe especificar el cliente interno!";
                return false;
            }
        }

        if (RadMultiPage2.SelectedIndex == 2)
        {
            //valida que tenga llamada
            if (txtCliente.Text.Trim() == string.Empty)
            {
                lblError.Text = "debe especificar el cliente!";
                return false;
            }
            if ((cmbSucursal.SelectedValue == null || cmbSucursal.SelectedValue == string.Empty))
            {
                lblError.Text = "debe especificar la sucursal!";
                return false;
            }

            if ((cmbContacto.SelectedValue == null || cmbContacto.SelectedValue == string.Empty))
            {
                lblError.Text = "debe especificar el Contacto!";
                return false;
            }
        }

        if ((cmbReactivo.SelectedValue == null || cmbReactivo.SelectedValue == string.Empty))
        {
            lblError.Text = "debe especificar el reactivo!";
            return false;
        }

        if (txtNumeroLote.Text.Trim() == string.Empty)
        {
            lblError.Text = "debe especificar el lote";
            return false;
        }

        if (!calVencimiento.SelectedDate.HasValue)
        {
            lblError.Text = "debe especificar la fecha de vencimiento!";
            return false;
        }

        if (txtMotivo.Text.Trim() == string.Empty)
        {
            lblError.Text = "El motivo es obligatorio.";
            return false;
        }
        if (EditorResultadosPrevios.Text.Trim() == string.Empty)
        {
            lblError.Text = "Los resultados previos son obligatorios.";
            return false;
        }



        if (txtRevisionEstadoProducto.Text.Trim() == string.Empty)
        {
            lblError.Text = "debe especificar la Revisión estado físico del producto!";
            return false;
        }


        if (cmbCalibracion.SelectedValue == null || cmbCalibracion.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "debe especificar la Calibracion!";
            return false;
        }


        if (txtControles.Text.Trim() == string.Empty)
        {
            lblError.Text = "debe especificar los Controles!";
            return false;
        }


        if (cmbModeloUtilizado.SelectedValue == null || cmbModeloUtilizado.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "debe especificar el equipo Dispositivo Medico Utilizado!";
            return false;
        }
        if (EditorAntecedentes.Text.Trim() == string.Empty)
        {
            lblError.Text = "Los antecedentes son obligatorio.";
            return false;
        }


        if (!rdDesempenoAdecuado.Checked && !rdDesempenoNoAdecuado.Checked)
        {
            lblError.Text = "Debe ingresar el desempeño del producto";
            return false;
        }

      
        if (!rdMotivoIdentificadoSi.Checked && !rdIdentificadoNo.Checked)
        {
            lblError.Text = "Debe ingresar el Motivo Identificado del producto";
            return false;
        }

        if (rdIdentificadoNo.Checked && txtTextoIdentificado.Text.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar el motivo por el cual el motivo no es identificado";
            return false;
        }

        if (!rdnoReposicion.Checked && !rdSiReposicion.Checked)
        {
            lblError.Text = "Debe ingresar si el Concepto Cientifico Aplica Reposicion";
            return false;
        }

        if (txtMotivoReposicion.Text.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar si el motivo de conepto Cientifico Aplica Reposicion";
            return false;
        }

        if (!rdDispoDardeBaja.Checked && !rdDispoDEvolucionCliente.Checked && !rdDispoDEvolucionProveedor.Checked)
        {
            lblError.Text = "Debe ingresar la Disposición del producto";
            return false;
        }

        if (!rdDispoDardeBaja.Checked && !rdDispoDEvolucionCliente.Checked && !rdDispoDEvolucionProveedor.Checked)
        {
            lblError.Text = "Debe ingresar la Disposición del producto";
            return false;
        }
        /*
         * obj.UpdateTabAprobacion(txtIdGarantia.Text, calFechaTramiteGarantia.SelectedDate, rdAplicaReclamo.Checked,
            calFEchaReclamoProveedor.SelectedDate, calFechaRespuestaProveedor.SelectedDate,
            int.Parse(cmbTramitadoPor.SelectedValue), int.Parse(Request.QueryString["cod"]));
         * */
        if (!rdAplicaReclamo.Checked && !rdNoAplicaReclamo.Checked)
        {
            lblError.Text = "Debe especificar si aplica reclamo o no.";
            return false;
        }

        if (rdAplicaReclamo.Checked && cmbTramitadoPor.SelectedValue == null || cmbTramitadoPor.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "debe especificar quien tramito la garantia!";
            return false;
        }
        return true;
    }

    private void guardar()
    {
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        obj.UpdateaprobacionTab1(cmbSucursal.SelectedValue,
            cmbContacto.SelectedValue,
            int.Parse(cmbReactivo.SelectedValue.ToString()),
            txtNumeroLote.Text,
            calVencimiento.SelectedDate,
            txtCantidadRecibido.Text,
            txtMotivo.Text,
            rdRealizadoAnnar.Checked,
            txtFactura.Text,
            calFactura.SelectedDate,
            calLlegadaProducto.SelectedDate,
            calAperturaProducto.SelectedDate,
            calIncoveniente.SelectedDate,
            EditorResultadosPrevios.Content,
            int.Parse(Request.QueryString["cod"]));

        obj.UpdateAprobacionTab2(
            txtRevisionEstadoProducto.Text,
            (cmbCalibracion.SelectedValue == null || cmbCalibracion.SelectedValue == string.Empty) ? (int?)null : int.Parse(cmbCalibracion.SelectedValue),
            txtControles.Text,
            (cmbFabricanteModeloutilizado.SelectedValue == null || cmbFabricanteModeloutilizado.SelectedValue == string.Empty) ? null : cmbFabricanteModeloutilizado.SelectedValue,
            (cmbModeloUtilizado.SelectedValue == null || cmbModeloUtilizado.SelectedValue == string.Empty) ? null : cmbModeloUtilizado.SelectedValue,
            txtNumeroMuestras.Text,
            chkAnalisisDeFallasConfidencial.Checked,
            EditorPosiblesFallas.Content,
            EditorAntecedentes.Content,
EditorAcciones.Content, int.Parse(Request.QueryString["cod"]));

        obj.UpdateAprobacionTab3(EditorConclusiones.Content,
            (!rdDesempenoAdecuado.Checked && !rdDesempenoNoAdecuado.Checked) ? ((bool?)null) : rdDesempenoAdecuado.Checked,
            "",
            (!rdMotivoIdentificadoSi.Checked && !rdIdentificadoNo.Checked) ? ((bool?)null) : rdMotivoIdentificadoSi.Checked,
            txtTextoIdentificado.Text, txtRecomendaciones.Text,
            (!rdnoReposicion.Checked && !rdSiReposicion.Checked) ? ((bool?)null) : rdSiReposicion.Checked,
            txtMotivoReposicion.Text, txtCantidadAReponer.Text,
            rdDispoDardeBaja.Checked, calDarBaja.SelectedDate,
            rdDispoDEvolucionCliente.Checked, calDevolucionCliente.SelectedDate,
            rdDispoDEvolucionProveedor.Checked, calDevolucionProveedor.SelectedDate, int.Parse(Request.QueryString["cod"]));
        //actualizamos el estado a en ejecucion
        obj.UpdateTabAprobacion(txtIdGarantia.Text, calFechaTramiteGarantia.SelectedDate, rdAplicaReclamo.Checked,
            calFEchaReclamoProveedor.SelectedDate, calFechaRespuestaProveedor.SelectedDate,
            ((cmbTramitadoPor.SelectedValue == null || cmbTramitadoPor.SelectedValue == string.Empty) ? ((int?)null) : int.Parse(cmbTramitadoPor.SelectedValue)),
            int.Parse(Request.QueryString["cod"]));
        obj.UpdateResultados(rdProcesamientoMuestrasSi.Checked,txtComparacionResultados.Text,
            EditorResultados.Content,   int.Parse(Request.QueryString["cod"]));
        
    }



    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoControlCalidad.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {   
            Response.Redirect("frmListadoControlCalidad.aspx");
    }

    protected void btnCrearYCrearOtra_Click(object sender, EventArgs e)
    {
            Response.Redirect("frmNewControlCalidad.aspx");
    }
  
    protected void btnCargarContactos_Click(object sender, ImageClickEventArgs e)
    {
        nit = sacarNit(txtCliente.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {
            sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
				where nitCliente ='" + nit + "' ";
            cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbContacto.DataValueField = "codContacto";
            cmbContacto.DataTextField = "nombre";
            cmbContacto.DataBind();
            //lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;
        }
        else
        {
            txtCliente.Text = "";
        }
    }

    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmPrintOrden.aspx?cod="+Request.QueryString["cod"]);
    }
    protected void btnAnular_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAnular.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btneditar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEditarcontrol.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnEjecutar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEjecutarControl.aspx?cod=" + Request.QueryString["cod"]);
    }
   
    protected void btnAprobar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAprobarControl.aspx?cod=" + Request.QueryString["cod"]);
        
    }

    protected void btnReabrir_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter control = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        estado.FillByCodmanual(ds.estado_control_calidad, 2);
        control.UpdateEstadoControlCalidad(ds.estado_control_calidad[0].cod_estado_control_calidad, int.Parse(Request.QueryString["cod"]));
        Response.Redirect("frmResumenDetalladoControl.aspx?cod=" + Request.QueryString["cod"]);
    }


    protected void btnReasignarApobador_Click(object sender, EventArgs e)
    {
     Session["aprobarOrden"] = "OK";
        Response.Redirect("frmenviarAprobacion.aspx?cod="+Request.QueryString["cod"]);
   
    }
    protected void btnCerrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCerrarControl.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnVerArchivo(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        int cod= int.Parse( b.CommandArgument);
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsCientificaTableAdapters.archivos_control_calidadTableAdapter archivos = new SPControladoraDatos.dsCientificaTableAdapters.archivos_control_calidadTableAdapter();
        archivos.FillBycod_archivos_control_calidad(ds.archivos_control_calidad, cod);
        string path = Server.MapPath("~/temp/");
        string extension = System.IO.Path.GetExtension(ds.archivos_control_calidad[0].nombre);
        string nombre=  ds.archivos_control_calidad[0].nombre.Replace(extension,"");
        
        int k=0;
        while( System.IO.File.Exists( path+nombre+extension  ) )
        {
            k++;
            nombre = nombre + k;
        }
        System.IO.File.WriteAllBytes(path+nombre+extension, ds.archivos_control_calidad[0].archivo);
        Response.Redirect("~/temp/" + nombre+extension);

        //Response.Redirect("frmCerrarControl.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnAgregarArchivo_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNewArchivoControl.aspx?cod="+Request.QueryString["cod"]);
    }
}
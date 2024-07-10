using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_controlcalidad_frmEditarcontrol : System.Web.UI.Page
{
    public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    #region webmetod de cliente
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
    public static List<AutoCompleteResult> ObtCliente(string term)
    {

        string sql = @"select top " + 5 + @"
nitCliente,rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes
where nitCliente like '%" + term + @"%'
or nombreCliente like '%" + term + @"%'
or numeroSocio like '%" + term + "%'";

        System.Data.DataTable tb = new System.Data.DataTable();
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        obj.ejecutarConsulta(sql, tb);
        //adaptador.Fill(tb);
        //if (tb.Rows.Count <= 0)
        //{
        //    return null;
        //}
        List<AutoCompleteResult> lista = new List<AutoCompleteResult>();

        for (int k = 0; k < tb.Rows.Count; k++)
        {
            AutoCompleteResult ar = new AutoCompleteResult();
            ar.id = tb.Rows[k][0].ToString();
            ar.value = tb.Rows[k][1].ToString();
            lista.Add(ar);
        }

        return lista;
    }

    private void registrarScriptCliente(Control c)
    {
        string query = @" <script type='text/javascript'>
		  jQuery(document).ready(function () {
			$('#" + c.ClientID + @"').autocomplete({
				source: function (request, response) {
					PageMethods.ObtCliente(
			request.term,
			function (data) {
				var cliente = (typeof data) == 'string' ? eval('(' + data + ')') : data;
				response(cliente);
			},
			fnLlamadaError);
				},
				minLength: 2
			});
		});

		function fnLlamadaError(excepcion) {
			alert('Ha ocurrido un error interno: ' + excepcion.get_message());
		}
	</script>";

        if (!Page.ClientScript.IsStartupScriptRegistered("script" + c.ClientID))
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "script" + c.ClientID, query);

    }


    #endregion
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
            //cargamos los telefonos del contacto
            sql = "select telefono1,celular from contactosClientes where codContacto = '" + ds.asesoria_cientifica[0].codContacto + "' and nitCliente='" + ds.asesoria_cientifica[0].nitCliente + "'";
            System.Data.DataTable tb2 = bd.ejecutarConsulta(sql).Tables[0];
            txtTelefonoContacto.Text = tb2.Rows[0][0].ToString();
            txtCelularContacto.Text = tb2.Rows[0][1].ToString();
            cmbSucursalLlamada.DataBind();
            cmbSucursalLlamada.SelectedValue = ds.asesoria_cientifica[0].codSucursal;
           

           
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
            txtNumeroLote.ReadOnly = false;
            txtNumeroLote.Enabled = true;
            cmbFabricante.Enabled = true;
            cmbReactivo.Enabled = true;
            calVencimiento.Enabled = true;

        }
        #region  registramos scripts y eventos onblur a los cuadros de texto
        registrarScriptCliente(txtCliente);
        string handler = ClientScript.GetPostBackEventReference(this.btnCliente, "");
        txtCliente.Attributes.Add("onblur", handler);
        #endregion
        #region validamos si hay seleccionado algo en el control de llamada cargamos todo de la llamada
        cmbSucursal.Enabled = true;
        cmbContacto.Enabled = true;
        txtCliente.ReadOnly = false;
      
        txtNumeroLote.ReadOnly = false;
        calVencimiento.Enabled = true;
        cmbFabricante.Enabled = true;
        cmbReactivo.Enabled = true;
#endregion


        if (!IsPostBack)
        {
              

            calCreacion.SelectedDate = DateTime.Now;
            if (Request.QueryString["cod"] != null)
            {
                SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter objCalidad = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                ds.EnforceConstraints = false;
                objCalidad.FillBycod_control_calidad(ds.control_calidad, int.Parse(Request.QueryString["cod"]));
                lblCodControlCalidad.Text = ds.control_calidad[0].cod_control_calidad.ToString();
                #region cargamos la informacion del control de calidad
                
                if (!ds.control_calidad[0].Iscantidad_recibidaNull())
                txtcantidadRecibida.Text = ds.control_calidad[0].cantidad_recibida;
                

                if (!ds.control_calidad[0].Iscliente_internoNull())
                {
                    txtClienteInterno.Text=  ds.control_calidad[0].cliente_interno.ToString().Trim();
                }
                
                calCreacion.SelectedDate = ds.control_calidad[0].fecha_creacion;

                if (!ds.control_calidad[0].Isasignado_aNull()){
                 
                    cmbAsignadoA.DataBind();
                    cmbAsignadoA.SelectedValue = ds.control_calidad[0].asignado_a.ToString();
                    if (cmbAsignadoA.SelectedValue == null || cmbAsignadoA.SelectedValue.ToString().Trim() == string.Empty || cmbAsignadoA.SelectedValue != ds.control_calidad[0].asignado_a.ToString())
                    {//significa que no esta e el grupo el usuario
                        //traemos el nombre del usuario
                        string sq = "select nombre from usuario where cod_usuario =" + ds.control_calidad[0].asignado_a;
                        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                        string nombre = bd.ejecutarProcedimiento(sq).ToString();
                        cmbAsignadoA.Items.Add(new ListItem(nombre, ds.control_calidad[0].asignado_a.ToString()));
                        cmbAsignadoA.SelectedValue = ds.control_calidad[0].asignado_a.ToString();
                    }
                }

                if (!ds.control_calidad[0].Isfecha_inicio_programacionNull())
                    calInicioProgramacion.SelectedDate = ds.control_calidad[0].fecha_inicio_programacion;

                if (!ds.control_calidad[0].Isfecha_facturaNull())
                    calfechaFactura.SelectedDate = ds.control_calidad[0].fecha_factura;
                if (!ds.control_calidad[0].Isfecha_apertura_productoNull())
                    calAperturaProducto.SelectedDate = ds.control_calidad[0].fecha_apertura_producto;
                if (!ds.control_calidad[0].Isfecha_inconvenienteNull())
                    calFechaInconveniente.SelectedDate = ds.control_calidad[0].fecha_inconveniente;
                if (!ds.control_calidad[0].Isfecha_llegada_productoNull())
                    calFechaLlegadaProducto.SelectedDate = ds.control_calidad[0].fecha_llegada_producto;
                if (!ds.control_calidad[0].Isnumero_facturaNull())
                    txtFactura.Text = ds.control_calidad[0].numero_factura;

                if (!ds.control_calidad[0].Isrealizado_localNull())
                {
                    rdRealizadoAnnar.Checked = ds.control_calidad[0].realizado_local;
                    rdRealizadoCliente.Checked = !ds.control_calidad[0].realizado_local;
                }

                if (!ds.control_calidad[0].Isfecha_fin_programacionNull())
                    calFinProgramacion.SelectedDate = ds.control_calidad[0].fecha_fin_programacion;
                if (!ds.control_calidad[0].Isfecha_vencimiento_reactivoNull())
                    calVencimiento.SelectedDate = ds.control_calidad[0].fecha_vencimiento_reactivo;
                if (!ds.control_calidad[0].Islote_reactivoNull())
                    txtNumeroLote.Text = ds.control_calidad[0].lote_reactivo;

                if (!ds.control_calidad[0].Isentregado_porNull())
                    txtEntregadoPor.Text = ds.control_calidad[0].entregado_por;

                txtMotivo.Text = ds.control_calidad[0].motivo;

                if (!ds.control_calidad[0].Isrecibido_porNull())
                    cmbQuienRecibe.SelectedValue = ds.control_calidad[0].recibido_por.ToString();

                txtObservaciones.Text = ds.control_calidad[0].observaciones;

                if (!ds.control_calidad[0].Iscod_llamadaNull())
                {
                    List<string> lista = new List<string>();
                    lista.Add(ds.control_calidad[0].cod_llamada.ToString());
                    controlLlamadas1.asignarCodigos(lista);
                }


                cmbFabricante.DataBind();
                SPControladoraDatos.dsSpx dss = new SPControladoraDatos.dsSpx();
                dss.EnforceConstraints = false;
                SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter objReferenciaREactivo = new SPControladoraDatos.dsSpxTableAdapters.referencia_reactivoTableAdapter();
                objReferenciaREactivo.FillBycod_referencia_reactivo(dss.referencia_reactivo, ds.control_calidad[0].cod_referencia_reactivo);
                cmbFabricante.SelectedValue = dss.referencia_reactivo[0].codFabricante;
                cmbReactivo.DataBind();
                cmbReactivo.SelectedValue = ds.control_calidad[0].cod_referencia_reactivo.ToString();
                #endregion
                //chkAtadaCliente.Checked = ds.tarea_calendario[0].atado_cliente;
                //txtCliente.Text = ds.tarea_calendario[0].nit_cliente.Trim();
                #region cliente o cliente interno

                if (ds.control_calidad[0].IsnitClienteNull())
                {
                    RadMultiPage2.SelectedIndex = 1;
                }
                else
                {
                    RadMultiPage2.SelectedIndex = 2;
                    string sql = "select rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + ds.control_calidad[0].nitCliente + "'";
                    SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                    System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
                    txtCliente.Text = tb.Rows[0][0].ToString();
                    txtClienteLlamada.Text = tb.Rows[0][0].ToString();
                    if (!ds.control_calidad[0].Iscod_llamadaNull())
                    {
                        cargarLlamada(ds.control_calidad[0].cod_llamada.ToString());
                        cargarClienteLlamada();
                        RadMultiPage2.SelectedIndex = 0;
                    }
                    cargarCliente();
                    cmbSucursal.SelectedValue = ds.control_calidad[0].codSucursal;
                    cmbContacto.SelectedValue = ds.control_calidad[0].codContacto;
                }
                #endregion

                //--


                
                controlLlamadas1.ReadOnly = true;
                txtCliente.ReadOnly = true;
                cmbSucursal.Enabled = false;
                cmbContacto.Enabled = false;
                btnCargarContactos.Visible = false;
                lnkNuevoContaco.Visible = false;
                txtEntregadoPor.ReadOnly = true;
                txtMotivo.ReadOnly = true;
                calInicioProgramacion.Enabled = false;
                calFinProgramacion.Enabled = false;

                RadTabStrip1.Visible = false;

                btnAceptar.Text = "Guardar";
                if (!ds.control_calidad[0].Isanulada_porNull())
                {
                    txtObservaciones.ReadOnly = true;
                    cmbFabricante.Enabled = false;
                    cmbReactivo.Enabled = false;
                    calVencimiento.Enabled = false;
                    txtNumeroLote.ReadOnly = true;
                    txtcantidadRecibida.Enabled = false;
                    txtClienteInterno.Enabled = false;
                    cmbAsignadoA.Enabled = false;
                    cmbQuienRecibe.Enabled = false;
                    calInicioProgramacion.Enabled = false;
                    calFinProgramacion.Enabled = false;
                }
                else
                {

                    SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter objEstado = new SPControladoraDatos.dsCientificaTableAdapters.estado_control_calidadTableAdapter();
                    objEstado.FillBycod_estado_control_calidad(ds.estado_control_calidad, ds.control_calidad[0].cod_estado_control_calidad);

                    if (ds.estado_control_calidad[0].cod_manual == 6)//anulado
                    {
                        //    btnAnular.Visible = true;
                    }
                    else if (ds.estado_control_calidad[0].cod_manual == 4)//cerrado
                    {
                        cmbAsignadoA.Enabled = false;
                        calInicioProgramacion.Enabled = false;
                        calFinProgramacion.Enabled = false;
                        txtcantidadRecibida.ReadOnly = true;
                        txtObservaciones.ReadOnly = true;
                        cmbQuienRecibe.Enabled = false;
                        txtNumeroLote.ReadOnly = true;
                        calVencimiento.Enabled = false;
                        cmbFabricante.Enabled = false;
                        cmbReactivo.Enabled = false;
                    }
                    else if (ds.estado_control_calidad[0].cod_manual == 5)//cerrado en seguimiento
                    {
                        cmbAsignadoA.Enabled = false;
                        calInicioProgramacion.Enabled = false;
                        calFinProgramacion.Enabled = false;
                        txtcantidadRecibida.ReadOnly = true;
                        txtObservaciones.ReadOnly = true;
                        cmbQuienRecibe.Enabled = false;
                        txtNumeroLote.ReadOnly = true;
                        calVencimiento.Enabled = false;
                        cmbFabricante.Enabled = false;
                        cmbReactivo.Enabled = false;
                    }
                    else if (ds.estado_control_calidad[0].cod_manual == 3)//En aprobacion
                    {
                        cmbAsignadoA.Enabled = false;
                        calInicioProgramacion.Enabled = false;
                        calFinProgramacion.Enabled = false;
                        txtcantidadRecibida.ReadOnly = true;
                        txtObservaciones.ReadOnly = true;
                        cmbQuienRecibe.Enabled = false;
                        txtNumeroLote.ReadOnly = true;
                        calVencimiento.Enabled = false;
                        cmbFabricante.Enabled = false;
                        cmbReactivo.Enabled = false;
                    }
                    else if (ds.estado_control_calidad[0].cod_manual == 2)//En ejecucion
                    {
                        cmbAsignadoA.Enabled = false;
                        calInicioProgramacion.Enabled = false;
                        calFinProgramacion.Enabled = false;
                        txtcantidadRecibida.ReadOnly = true;
                        txtObservaciones.ReadOnly = true;
                        cmbQuienRecibe.Enabled = false;
                        txtNumeroLote.ReadOnly = true;
                        calVencimiento.Enabled = false;
                        cmbFabricante.Enabled = false;
                        cmbReactivo.Enabled = false;

                    }
                    else if (ds.estado_control_calidad[0].cod_manual == 1)//programada
                    {
                        /*
                        btnEjecutar.Visible = true;
                        btnAnular.Visible = true;
                        btnCerrar.Visible = true;
                        btnCerrarEnSeguimiento.Visible = true;
                        btnEnviarAprobacion.Visible = true;
                         * */
                    }
                }
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoControl.aspx?cod="+Request.QueryString["cod"]);
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
            sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
				where nitCliente ='" + nit + "' ";

            cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbContacto.DataValueField = "codContacto";
            cmbContacto.DataTextField = "nombre";
            cmbContacto.DataBind();
            lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;
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
            sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
				where nitCliente ='" + nit + "' ";
            
            cmbContactoLlamada.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbContactoLlamada.DataValueField = "codContacto";
            cmbContactoLlamada.DataTextField = "nombre";
            cmbContactoLlamada.DataBind();

        }
    }

    /// <summary>
    /// Valida la creacion de la orden de control de calidad
    /// </summary>
    /// <returns></returns>
    private bool validar()
    {
        if (!rdRealizadoAnnar.Checked && !rdRealizadoCliente.Checked)
        {
            lblError.Text = "debe especificar si es realizado en annar o donde el cliente.";
            return false;
        }

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

        if (!calInicioProgramacion.SelectedDate.HasValue)
        {
            lblError.Text = "debe especificar la fecha de Inicio de la Actividad!";
            return false;
        }

        if (!calFinProgramacion.SelectedDate.HasValue)
        {
            lblError.Text = "debe especificar la fecha de Fin de la Actividad!";
            return false;
        }

        if (calInicioProgramacion.SelectedDate.Value > calFinProgramacion.SelectedDate.Value)
        {
            lblError.Text = "La fecha de Inicio y la fecha final de inicio de la actividad no son coherentes!";
            return false;
        }
        if (txtFactura.Text.Trim() == string.Empty)
        {
            lblError.Text = "debe especificar el numero de factura.";
            return false;
        }
        if (!calfechaFactura.SelectedDate.HasValue)
        {
            lblError.Text = "debe especificar la fecha de factura.";
            return false;
        }


        if (!calAperturaProducto.SelectedDate.HasValue)
        {
            lblError.Text = "debe especificar la fecha de apertura del producto.";
            return false;
        }
        if (!calFechaInconveniente.SelectedDate.HasValue)
        {
            lblError.Text = "debe especificar la fecha del inconveniente.";
            return false;
        }
        if (!calFechaLlegadaProducto.SelectedDate.HasValue)
        {
            lblError.Text = "debe especificar la fecha de llegada del producto!";
            return false;
        }


        return true;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (Aceptar())
            Response.Redirect("frmListadoControlCalidad.aspx");
    }

    protected bool Aceptar()
    {
        if (!validar()) return false;
        SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter obj = new SPControladoraDatos.dsCientificaTableAdapters.control_calidadTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        lblError.Text = "insertado";
        //        string modelo = null;
        //        string fabricante = null;
        //        string serial = null;        
            //al actualizar no deberia actualizar todos los campos
            #region zona de update
        obj.UpdateEdicion(int.Parse(cmbReactivo.SelectedValue),
                txtNumeroLote.Text, calVencimiento.SelectedDate.Value, txtcantidadRecibida.Text, txtObservaciones.Text,
                int.Parse(cmbAsignadoA.SelectedValue), rdRealizadoAnnar.Checked, txtFactura.Text,
                calfechaFactura.SelectedDate.Value, calAperturaProducto.SelectedDate.Value,
                calFechaInconveniente.SelectedDate.Value, calFechaLlegadaProducto.SelectedDate.Value,
                calInicioProgramacion.SelectedDate.Value, calFinProgramacion.SelectedDate.Value,
                int.Parse(lblCodControlCalidad.Text)
                );
            #endregion

        
        return true;
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

            lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;
        }
        else
        {
            txtCliente.Text = "";
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmCrearContrato : System.Web.UI.Page
{
    public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    protected void btnCliente_Click(object sender, EventArgs e)
    {
        cargarCliente();
    }

    public string sacarNit(string texto)
    {
        if (texto.LastIndexOf('(') <= 0)
            return "";
        string res = texto.Substring(texto.LastIndexOf('(') + 1);
        res = res.Substring(0, res.Length - 1);
        return res;
    }


    private void cargarCliente()
    {
        nitContrato = sacarNit(txtCliente.Text);
        string nit = nitContrato;
        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {
            lnkCliente.NavigateUrl = "~/frm/csuministro/frmHojaVidaCliente.aspx?nit=" + nit;
            lnkCliente.Visible = true;
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
            //cargamos el ultimo asesor comercial que halla tenido ese cliente
            sql = @"select top 1 asesoresComerciales.codAsesor from contratos_suministro
join asesoresComerciales on asesoresComerciales.codAsesor = contratos_suministro.codAsesor
where  (asesoresComerciales.activo =1) and nitCliente ='" + nit + "' order by cod_contratos_suministro desc";
            object c = obj.ejecutarProcedimiento(sql);
            if (c != null && c != System.DBNull.Value)
            {
                cmbAsesor.SelectedValue = c.ToString();
            }
            lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;
        }
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

    #region webmetod de productos experiencia
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
    public static List<AutoCompleteResult> ObtProducto(string term)
    {

        string sql = @"select top " + 5 + @" 1,rtrim(fabricante.nombre_fabricante)+' ('+
rtrim(nombre_producto)
+' - '+
rtrim(codigo_manual_referencia)+')'
 from producto_experiencia_contrato
 join fabricante on fabricante.cod_fabricante= producto_experiencia_contrato.cod_fabricante

where nombre_fabricante like '%" + term + @"%'
or nombre_producto like '%" + term + @"%'
or codigo_manual_referencia like '%" + term + "%' ";

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

    private void registrarScriptProducto(Control c)
    {
        string query = @" <script type='text/javascript'>
		  jQuery(document).ready(function () {
			$('#" + c.ClientID + @"').autocomplete({
				source: function (request, response) {
					PageMethods.ObtProducto(
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

    #region webmetod de contratos sumisnitros
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
    public static List<AutoCompleteResult> ObtContrato(string term)
    {
        
        string sql = @"select top " + 5 + @"  1,
 numero_contrato
  from contrato_consumo 
where numero_contrato like '%" + term + @"%' and nitcliente ='"+nitContrato+"'";

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

    private void registrarScriptContrato(Control c)
    {
        string query = @" <script type='text/javascript'>
		  jQuery(document).ready(function () {
			$('#" + c.ClientID + @"').autocomplete({
				source: function (request, response) {
					PageMethods.ObtContrato(
			request.term,
			function (data) {
				var cliente = (typeof data) == 'string' ? eval('(' + data + ')') : data;
				response(cliente);
			},
			fnLlamadaError);
				},
				minLength: 1
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

    public static string nitContrato = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        btnFileUploadCorreoAprobacion.Attributes.Add("onclick", "jQuery('#" + FileUploadCorreoAprobacion.ClientID + "').click();return false;");
        btnFileUploadDocumentoEscaneado.Attributes.Add("onclick", "jQuery('#" + FileUploadDocumentoEscaneado.ClientID + "').click();return false;");
        btnFileUploadOrdenanza.Attributes.Add("onclick", "jQuery('#" + FileUploadOrdenanza.ClientID + "').click();return false;");
        btnFileUploadPropuesta.Attributes.Add("onclick", "jQuery('#" + FileUploadPropuesta.ClientID + "').click();return false;");

   
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 0);
        if (Session["ss_cod_usuario"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
        registrarScriptCliente(txtCliente);
        registrarScriptProducto(txtProductos);
        registrarScriptContrato(txtContratoApoyo);
        string handler = ClientScript.GetPostBackEventReference(this.btnCliente, "");
        txtCliente.Attributes.Add("onblur", handler);

        SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
        if (!IsPostBack)
        {
            clsUtils utils = new clsUtils();
            chkOmiteFlujo.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2073, int.Parse(Session["ss_cod_usuario"].ToString()), Session);
            cmbCreadoPor.SelectedValue = Session["ss_cod_usuario"].ToString();
            calCreacion.Value = DateTime.Now;
            
            cmbPaisEnvioContrato.SelectedValue = "COL  ";
            Session["lstGrpCreac"] = null;
            Session["lstDiviCreac"]=null;
            Session["lstProdCreac"]=null;
            Session["lstStampillasCreac"] = null;
            Session["lstPolizasCreac"] = null;
            if (Request.QueryString["generaotrosi"] != null)
            {
                pnlOtroSi.Visible = true;
                cmbTipoOtroSi.Visible = true;
                lblTipoOtroSi.Visible = true;
            }
            
            if (Request.QueryString["cod"] == null)
            {
                //string s = @"select isnull(max(cast ([numero_contrato]as int)),0)  +1 from [dbo].[contratos_suministro]";
                //try
                //{
                //    txtNumeroContrato.Text = objData.ejecutarProcedimiento(s).ToString();
                //}catch(Exception){
                //    txtNumeroContrato.Text = "N/A";//esto es en el caso que ingresen texto en el numero de contrato
                //    txtNumeroContrato.ReadOnly = false;
                //}
            }

            //evaluamos si es edicion o es otro si
            if (Request.QueryString["cod"] != null)
            {
                calFechaInicio.Enabled = false;
                txtConsecutivoInterno.Enabled = false;    
                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter objContrato = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter objGrupo=new SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter objdivision=new SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.pltProductoExperienciaTableAdapter objPltProductos = new SPControladoraDatos.dsContratosSuministroTableAdapters.pltProductoExperienciaTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.pltEstampillaTableAdapter objEstampillas = new SPControladoraDatos.dsContratosSuministroTableAdapters.pltEstampillaTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.pltPolizasContratoConsumoTableAdapter objPolizas = new SPControladoraDatos.dsContratosSuministroTableAdapters.pltPolizasContratoConsumoTableAdapter();

                objContrato.FillByCod_contratos_suministro(ds.contratos_suministro, int.Parse(Request.QueryString["cod"]));


                if ( ds.contratos_suministro.Count > 0 )
                {
                    //miramos si la informacion viene de un otro si
                    if (ds.contratos_suministro[0].otrosi != null && ds.contratos_suministro[0].otrosi.Trim() != string.Empty)
                    {
                        pnlOtroSi.Visible = true;
                        cmbTipoOtroSi.Visible = true;
                        lblTipoOtroSi.Visible = true;
                        if (!ds.contratos_suministro[0].Isobservaciones_otro_siNull())
                        txtObservacionesOtroSi.Text = ds.contratos_suministro[0].observaciones_otro_si;
                        if (!ds.contratos_suministro[0].Iscod_tipo_otro_si_suministroNull())
                        cmbTipoOtroSi.SelectedValue = ds.contratos_suministro[0].cod_tipo_otro_si_suministro.ToString();
                        lblOtroSi.Text = ds.contratos_suministro[0].otrosi;
                        if (Request.QueryString["generaotrosi"] != null)
                        {
                            txtObservacionesOtroSi.Text = "";
                        }
                        txtConsecutivoInterno.Text = ds.contratos_suministro[0].cod_contratos_suministro.ToString();
                    }

                    if (!ds.contratos_suministro[0].Isfecha_creacionNull())
                        calCreacion.Date = ds.contratos_suministro[0].fecha_creacion;
                    
                        calFechaInicio.Date = ds.contratos_suministro[0].fecha_incio;
                    
                        calFechaTerminacion.Date = ds.contratos_suministro[0].fecha_terminacion;

                    if (!ds.contratos_suministro[0].Isfecha_creacionNull())
                        calCreacion.Date = ds.contratos_suministro[0].fecha_creacion;

                    cmbCreadoPor.SelectedValue = ds.contratos_suministro[0].cod_usuario_asesor.ToString();

                    txtCelularContactoJuridico.Text = ds.contratos_suministro[0].numero_celular_contacto_juridico.Trim();

                    string sql = @"select top 1 rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente = '" + ds.contratos_suministro[0].nitCliente.Trim() + "'";

                    System.Data.DataTable tb = new System.Data.DataTable();
                    objData.ejecutarConsulta(sql, tb);

                    txtCliente.Text = tb.Rows[0][0].ToString();
                    cargarCliente();

                    txtContactojuridico.Text = ds.contratos_suministro[0].contacto_juridico.Trim();
                    txtDireccionEnvioContrato.Text = ds.contratos_suministro[0].direccion_envio_contrato.Trim();
                    txtNumeroContrato.Text = ds.contratos_suministro[0].numero_contrato.Trim();
                    txtObservaciones.Text = ds.contratos_suministro[0].observaciones.Trim();                   
                    txtValorContrato.Text = string.Format("{0:c}", ds.contratos_suministro[0].valor_contrato);

                    cmbAsesor.DataBind();
                    cmbAsesor.SelectedValue = ds.contratos_suministro[0].codAsesor.ToString();
                    cmbPaisEnvioContrato.DataBind();
                    cmbPaisEnvioContrato.SelectedValue= ds.contratos_suministro[0].codPais_envio_contrato.ToString();
                    cmbDepartamentoEnvioContrato.DataBind();
                    cmbDepartamentoEnvioContrato.SelectedValue= ds.contratos_suministro[0].codDepartamento_envio_contrato.ToString();
                    cmbCiudadEnvioContrato.DataBind();

                    cmbCiudadEnvioContrato.SelectedValue= ds.contratos_suministro[0].codCiudad_envio_contrato.ToString();
                    
                    chkAplicaEstampilla.Checked= ds.contratos_suministro[0].aplica_estampilla;
                    chkAplicaPolizas.Checked= ds.contratos_suministro[0].aplica_polizas;

                    if (!ds.contratos_suministro[0].Isno_genera_flujoNull()) chkOmiteFlujo.Checked = ds.contratos_suministro[0].no_genera_flujo;
                    if (chkOmiteFlujo.Checked)
                    {
                        lblConsecutivoInterno.Visible = true;
                        txtConsecutivoInterno.Visible = true;
                    }

                    if (!ds.contratos_suministro[0].Ises_contratoNull()) rdContrato.Checked = ds.contratos_suministro[0].es_contrato;
                    if (!ds.contratos_suministro[0].Ises_orden_compraNull()) rdOrdenCompra.Checked = ds.contratos_suministro[0].es_orden_compra;
                    if (!ds.contratos_suministro[0].Isgenera_multaNull()) chkGeneraMulta.Checked = ds.contratos_suministro[0].genera_multa;
                    if (!ds.contratos_suministro[0].Isincluye_apoyo_tecnologicoNull()) chkIncluyeapoyo.Checked = ds.contratos_suministro[0].incluye_apoyo_tecnologico;
                    if (!ds.contratos_suministro[0].Iscontrato_apoyoNull()) txtContratoApoyo.Text = ds.contratos_suministro[0].contrato_apoyo.Trim();
                    if (!ds.contratos_suministro[0].Isfecha_limite_legalizacionNull()) calLimiteLegalizacion.Date = ds.contratos_suministro[0].fecha_limite_legalizacion;
                    if (!ds.contratos_suministro[0].IscodAsesorNull()) cmbAsesor.SelectedValue = ds.contratos_suministro[0].codAsesor.ToString();

                    objdivision.FillBycod_contratos_suministro(ds.divisionxcontrato_suministro,  ds.contratos_suministro[0].cod_contratos_suministro);
                    objGrupo.FillByCod_contratos_suministro(ds.grupo_reactivoxcontrato_suministro, ds.contratos_suministro[0].cod_contratos_suministro);
                    objPltProductos.FillBycod_contratos_suministro(ds.pltProductoExperiencia, ds.contratos_suministro[0].cod_contratos_suministro);
                    objEstampillas.FillByCod_contratos_suministro(ds.pltEstampilla, ds.contratos_suministro[0].cod_contratos_suministro);
                    objPolizas.FillByCod_contratos_suministro(ds.pltPolizasContratoConsumo, ds.contratos_suministro[0].cod_contratos_suministro);

                    List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f = (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreac"];
                    if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>();

                    SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaDataTable tbGrupo = new SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaDataTable();    
                    SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroDataTable tbDivision = new SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroDataTable();
                     
                    SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable tbProducto = new SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable();
                    List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> listaProducto = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
                    if (listaProducto == null) listaProducto = new List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>();

                    List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> fDivision = (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
                    if (fDivision == null) fDivision = new List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>();

                    SPControladoraDatos.dsContratosSuministro.pltEstampillaDataTable tbEstampillas = new SPControladoraDatos.dsContratosSuministro.pltEstampillaDataTable();
                    List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow> fEstampillas = (List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>)Session["lstStampillasCreac"];
                        if (fEstampillas == null) fEstampillas = new List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>();

                        SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoDataTable tbPolizas = new SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoDataTable();
                        List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow> fPolizas = (List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>)Session["lstPolizasCreac"];
                        if (fPolizas == null) fPolizas = new List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>();


                    //cargamos los grupos de reactivos
                    for(int k=0;k<ds.grupo_reactivoxcontrato_suministro.Count;k++)
                    {
        SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow fila = tbGrupo.Newgrupo_reactivo_experienciaRow();
        fila.cod_grupo_reactivo_experiencia = ds.grupo_reactivoxcontrato_suministro[k].cod_grupo_reactivo_experiencia;
        fila.nombre_grupo_reactivo_experiencia = objData.ejecutarProcedimiento("select nombre_grupo_reactivo_experiencia from grupo_reactivo_experiencia where cod_grupo_reactivo_experiencia="+ds.grupo_reactivoxcontrato_suministro[k].cod_grupo_reactivo_experiencia).ToString();
        f.Add(fila);
                    }

                    //cargamos las divisiones
                    for(int k=0;k<ds.divisionxcontrato_suministro.Count;k++)
                    {
        //validamos que no exista previamnete
       
        //
        SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow fila = tbDivision.Newdivision_experiencia_contrato_suministroRow();
        fila.cod_division_experiencia_contrato_suministro = ds.divisionxcontrato_suministro[k].cod_division_experiencia_contrato_suministro;
        fila.nombre_division_experiencia_contrato_suministro = objData.ejecutarProcedimiento("select nombre_division_experiencia_contrato_suministro from division_experiencia_contrato_suministro where cod_division_experiencia_contrato_suministro="+ds.divisionxcontrato_suministro[k].cod_division_experiencia_contrato_suministro).ToString();;
        fDivision.Add(fila);
                    }

                    //cargamos las productos
                    for (int k = 0; k < ds.pltProductoExperiencia.Count; k++)
                    {
                        SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow fila = tbProducto.NewpltProductoExperienciaRow();
                        fila.cod_fabricante = ds.pltProductoExperiencia[k].cod_fabricante;
                        fila.cod_producto_experiencia_contrato = ds.pltProductoExperiencia[k].cod_producto_experiencia_contrato;
                        fila.codigo_manual_referencia = ds.pltProductoExperiencia[k].codigo_manual_referencia;
                        fila.nombre_fabricante = ds.pltProductoExperiencia[k].nombre_fabricante;
                        fila.nombre_producto = ds.pltProductoExperiencia[k].nombre_producto; 
                        listaProducto.Add(fila);
                    }

                    if (Request.QueryString["generaotrosi"] == null)
                    {
#region cargamos las estampillas
                        for (int k = 0; k < ds.pltEstampilla.Count; k++)
                        {
                            SPControladoraDatos.dsContratosSuministro.pltEstampillaRow fila = tbEstampillas.NewpltEstampillaRow();
                            fila.cod_banco_suministro = ds.pltEstampilla[k].cod_banco_suministro;
                            fila.nombre_banco_suministro = ds.pltEstampilla[k].nombre_banco_suministro;
                            fila.beneficiario = ds.pltEstampilla[k].beneficiario;
                            fila.cod_estampillas_contrato_sumisnistro = ds.pltEstampilla[k].cod_estampillas_contrato_sumisnistro;
                            fila.cuentabanco = ds.pltEstampilla[k].cuentabanco;
                            fila.cod_destinacion_suministro = ds.pltEstampilla[k].cod_destinacion_suministro;
                            fila.nombre_destinacion_suministro = ds.pltEstampilla[k].nombre_destinacion_suministro;
                            if (!ds.pltEstampilla[k].Ispago_clienteNull())
                            {
                                fila.pago_cliente = ds.pltEstampilla[k].pago_cliente;
                            }
                            else {
                                fila.pago_cliente = false;
                            }
                            fila.porcentaje = ds.pltEstampilla[k].porcentaje;
                            if (!ds.pltEstampilla[k].Isurl_archivoNull())
                            fila.url_archivo = ds.pltEstampilla[k].url_archivo;
                            fila.cod_tipo_cuenta_banco = ds.pltEstampilla[k].cod_tipo_cuenta_banco;
                            fila.nombre_tipo_cuenta_banco = ds.pltEstampilla[k].nombre_tipo_cuenta_banco;
                            fila.valor = ds.pltEstampilla[k].valor;
                            fEstampillas.Add(fila);
                        }
#endregion
                        
#region cargamos las polizas
                        for (int k = 0; k < ds.pltPolizasContratoConsumo.Count; k++)
                        {
                            SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow fila = tbPolizas.NewpltPolizasContratoConsumoRow();
                            fila.cod_contratos_suministro = ds.pltPolizasContratoConsumo[k].cod_contratos_suministro;
                            fila.cod_polizas_contrato_suministro = ds.pltPolizasContratoConsumo[k].cod_polizas_contrato_suministro;
                            fila.cod_riesgo_poliza_consumo = ds.pltPolizasContratoConsumo[k].cod_riesgo_poliza_consumo;
                            fila.nombre_riesgo_poliza_consumo = ds.pltPolizasContratoConsumo[k].nombre_riesgo_poliza_consumo;
                            fila.observaciones = ds.pltPolizasContratoConsumo[k].observaciones;
                            fila.porcentaje = ds.pltPolizasContratoConsumo[k].porcentaje;
                            fila.valor_poliza = ds.pltPolizasContratoConsumo[k].valor_poliza;
                            fila.vigencia_meses = ds.pltPolizasContratoConsumo[k].vigencia_meses;
                            if (!ds.pltPolizasContratoConsumo[k].Iscod_aseguradora_suministroNull())
                            fila.cod_aseguradora_suministro = ds.pltPolizasContratoConsumo[k].cod_aseguradora_suministro;

                            if (!ds.pltPolizasContratoConsumo[k].Isurl_archivo_polizaNull())
                            fila.url_archivo_poliza = ds.pltPolizasContratoConsumo[k].url_archivo_poliza;
                            fPolizas.Add(fila);
                        }
#endregion

                    }
                    else {
                        pnlDocumentoEscaneado.Visible = false;
                    }
                    //cargamos los archivos
                    if (pnlDocumentoEscaneado.Visible)
                    {
                        SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter archivos = new SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter();
                        SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter tipoArchivo = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter();


                        tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "1");
                        archivos.FillByTipoarchivoxcontratos_suministro(ds.archivoxcontratos_suministro, int.Parse(Request.QueryString["cod"]), ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);
                        if (ds.archivoxcontratos_suministro.Count > 0)
                        {
                            lnkCorreoAprobacion.NavigateUrl = ds.archivoxcontratos_suministro[0].ruta_archivo;
                            lnkCorreoAprobacion.Visible = true;
                        }

                        tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "2");
                        archivos.FillByTipoarchivoxcontratos_suministro(ds.archivoxcontratos_suministro, int.Parse(Request.QueryString["cod"]), ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);
                        if (ds.archivoxcontratos_suministro.Count > 0)
                        {
                            lnkOrdenanza.NavigateUrl = ds.archivoxcontratos_suministro[0].ruta_archivo;
                            lnkOrdenanza.Visible = true;
                        }

                        tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "3");
                        archivos.FillByTipoarchivoxcontratos_suministro(ds.archivoxcontratos_suministro, int.Parse(Request.QueryString["cod"]), ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);
                        if (ds.archivoxcontratos_suministro.Count > 0)
                        {
                            linkPropuesta.NavigateUrl = ds.archivoxcontratos_suministro[0].ruta_archivo;
                            linkPropuesta.Visible = true;
                        }
                        tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "4");
                        archivos.FillByTipoarchivoxcontratos_suministro(ds.archivoxcontratos_suministro, int.Parse(Request.QueryString["cod"]), ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);
                        if (ds.archivoxcontratos_suministro.Count > 0)
                        {
                            lnkVerDocumentoEscaneado.NavigateUrl = ds.archivoxcontratos_suministro[0].ruta_archivo;
                            lnkVerDocumentoEscaneado.Visible = true;
                        }
                    }

                    //solamente edita el documento escaneado cuando lo crea
                    if (ds.contratos_suministro[0].otrosi != null && ds.contratos_suministro[0].otrosi != string.Empty)
                    {
                        pnlDocumentoEscaneado.Visible = false;
                    }

        Session["lstGrpCreac"] = f;
        Session["lstStampillasCreac"] = fEstampillas;
        Session["lstDiviCreac"] = fDivision;
        Session["lstProdCreac"] = listaProducto;
        Session["lstPolizasCreac"] = fPolizas;
        generarGrillas();
        lblFechaLimite.Visible = chkGeneraMulta.Checked;
        calLimiteLegalizacion.Visible = chkGeneraMulta.Checked;
        txtContratoApoyo.Visible = chkIncluyeapoyo.Checked;
        pnlPolizas.Visible = chkAplicaPolizas.Checked;
        pnlEstampillas.Visible = chkAplicaEstampilla.Checked;
        lblObligatorioOrdenanza.Visible = chkAplicaEstampilla.Checked;
                }
            
            }

        }
        generarGrillas();
    }

    protected void btnCargarContactos_Click(object sender, ImageClickEventArgs e)
    {
        string nit = sacarNit(txtCliente.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {
            sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
				where nitCliente ='" + nitContrato + "' ";
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

    private void cargarCargo()
    {
        string nit = sacarNit(txtCliente.Text);
        string sql = "select cargo from contactosClientes where nitCliente='"+nit+"' and codContacto ='"+cmbContacto.SelectedValue+"'" ;
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows[0][0] != null && tb.Rows[0][0] != System.DBNull.Value)
            lblCargoContacto.Text = tb.Rows[0][0].ToString();
        else
            lblCargoContacto.Text = "";

    }

    protected void cmbContacto_SelectedIndexChanged(object sender, EventArgs e)
    {
        cargarCargo();
    }

    private bool validar() 
    {
        lblError.Text = "";

        if (cmbTipoOtroSi.Visible && (cmbTipoOtroSi.SelectedValue == null || cmbTipoOtroSi.SelectedValue.Trim() == string.Empty))
        {
            lblError.Text = "El tipo de otro si es obligatorio.";
            return false;
        }

        if (txtCliente.Text.Trim() == string.Empty)
        {
            lblError.Text = "El cliente es obligatorio.";
            return false;
        }

        if (calFechaInicio.Value == null)
        {
            lblError.Text = "La fecha de inicio del contrato es obligatoria.";
            return false;
        }

        if (calFechaTerminacion.Value == null)
        {
            lblError.Text = "La fecha de terminacion del contrato es obligatoria.";
            return false;
        }

        if ( calFechaInicio.Date > calFechaTerminacion.Date)
        {
            lblError.Text = "Las fecha de inicio y de terminacion no son coherentes.";
            return false;
        }

        if (txtNumeroContrato.Text.Trim() == string.Empty)
        {
            lblError.Text = "El numero de contrato es obligatorio.";
            return false;
        }

        if (txtNumeroContrato.Text.Trim().ToUpper() == @"N\A" || txtNumeroContrato.Text.Trim().ToUpper() == @"N/A")
        {
            lblError.Text = @"El numero de contrato no puede ser N\A.";
            return false;
        }

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        //
        if (chkOmiteFlujo.Checked)
        {
            if (txtConsecutivoInterno.Text.Trim() == string.Empty)
            {
                lblError.Text = @"El consecutivo interno es obligatorio.";
                return false;
            }
            string sql = @"select count(*) from contratos_suministro where cod_contratos_suministro = "+txtConsecutivoInterno.Text;
            if (bd.ejecutarProcedimiento(sql).ToString() != "0")
            {
                lblError.Text = @"El consecutivo interno "+txtConsecutivoInterno.Text+" esta asignado a otro contrato.";
                return false;
            }
        }


        //validamos que el contrato de consumo pertenesca al cliente que esta guardando
        string nit = sacarNit(txtCliente.Text);
        if (chkIncluyeapoyo.Checked && txtContratoApoyo.Text.Trim() != string.Empty)
        {
            var capoyo = bd.ejecutarProcedimiento("select count(*) from contrato_consumo where numero_contrato='" + txtContratoApoyo.Text + "' and nitcliente ='" + nit + "'");
            if (capoyo == null || capoyo == System.DBNull.Value || capoyo.ToString().Trim() == "0")
            {
                lblError.Text = "El contrato de apoyo numero " + txtContratoApoyo.Text + " no esta relacionado con el cliente ." + txtCliente.Text;
                return false;
            }
        }
       
        if (cmbSucursal.SelectedValue == null || cmbSucursal.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "La sucursal es obligatoria.";
            return false;
        }

        if (cmbContacto.SelectedValue == null || cmbContacto.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "El contacto es obligatoria.";
            return false;
        }

        if (!chkOmiteFlujo.Checked && txtDireccionEnvioContrato.Text.Trim() == string.Empty)
        {
            lblError.Text = "la direccion de envio del contrato es obligatorio.";
            return false;
        }

        if (cmbCiudadEnvioContrato.SelectedValue == null || cmbCiudadEnvioContrato.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "La ciudad de envio del contrato es obligatoria.";
            return false;
        }

        if (!chkOmiteFlujo.Checked && txtContactojuridico.Text.Trim() == string.Empty)
        {
            lblError.Text = "El contacto juridico es obligatorio.";
            return false;
        }
        if (!chkOmiteFlujo.Checked && txtCelularContactoJuridico.Text.Trim() == string.Empty)
        {
            lblError.Text = "El celular del contacto juridico es obligatorio.";
            return false;
        }

        if (!chkOmiteFlujo.Checked && txtValorContrato.Text.Trim() == string.Empty)
        {
            lblError.Text = "El valor del contrato es obligatorio.";
            return false;
        }

        decimal vc = 0;
        if (!chkOmiteFlujo.Checked && !decimal.TryParse(obtenerValor(), out vc))
        {
            lblError.Text = "El valor del contrato ingresado no es valido.";
            return false;
        }

        if (vc > 9999999999999999)
        {
            lblError.Text = "El valor maximo para que esta diseñado el sistema es 9.999.999.999.999.999, lo cual son 9.999 billones de pesos si desean manejar cifras superiores debera adquirir una licencia adicional de spx.";
            return false;
        }
        if(chkGeneraMulta.Checked && calLimiteLegalizacion.Value == null)
        {
            lblError.Text = "Debe especificar la fecha limite de legalizacion.";
            return false;
        }

        //minimo debe ingresar una division
        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> f =
          (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>();
        if (!chkOmiteFlujo.Checked && f.Count == 0)
        {
            lblError.Text = "Debe ingresar por lo menos una Unidad de Negocio.";
            return false;
        }

       
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> f2 = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
        if (f2 == null) f2 = new List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>();
        if (!chkOmiteFlujo.Checked && f2.Count == 0)
        {
            lblError.Text = "Debe ingresar por lo menos un producto.";
            return false;
        }
       
        if (!chkOmiteFlujo.Checked && pnlDocumentoEscaneado.Visible && lnkVerDocumentoEscaneado.NavigateUrl == "")
        {
            lblError.Text = "El documento escaneado es obligatorio.";
            return false;
        }
        if (!chkOmiteFlujo.Checked && linkPropuesta.NavigateUrl == "")
        {
            lblError.Text = "La propuesta es obligatoria.";
            return false;
        }
        if (chkAplicaEstampilla.Checked && lnkOrdenanza.NavigateUrl == "")
        {
            lblError.Text = "La Ordenanza/Estatuto es obligatoria.";
            return false;
        }
        if (chkAplicaEstampilla.Checked)
        {
            List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow> fEstampilas = (List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>)Session["lstStampillasCreac"];
            if (fEstampilas == null) fEstampilas = new List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>();
            if ( fEstampilas.Count == 0)
            {
                lblError.Text = "Debe ingresar por lo menos una estampilla.";
                return false;
            }

            if (lnkCorreoAprobacion.NavigateUrl == "")
            {
                lblError.Text = "El correo de aprobacion es obligatorio.";
                return false;
            }
        }

        if (chkAplicaPolizas.Checked )
        {
            List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow> fPolizas = (List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>)Session["lstPolizasCreac"];
            if (fPolizas == null) fPolizas = new List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>();
            if (fPolizas.Count == 0)
            {
                lblError.Text = "Debe ingresar por lo menos una poliza.";
                return false;
            }
        }



        
        return true;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar())
        {
            return;
        }
         string nit = sacarNit(txtCliente.Text);   
            decimal vc = 0;
            decimal.TryParse(obtenerValor(), out vc);
            string otroSi = "";
              DateTime? fotroSi = null;
              DateTime? fechaLimiteLgalizacion = null;
              if (chkGeneraMulta.Checked && calLimiteLegalizacion.Value != null)
              {
                  fechaLimiteLgalizacion = calLimiteLegalizacion.Date;
              }
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
              string contratoVinculado = "";
              if (Request.QueryString["generaotrosi"] != null)
              {
                  

                  otroSi = bd.ejecutarProcedimiento(
@"select case when max(otrosi) is null or max(otrosi) ='' then 1 else
max(otrosi)+1 end from contratos_suministro where consecutivo_interno='"+txtNumeroContrato.Text.Trim()+"' ").ToString();
                  fotroSi = DateTime.Now;
                  if (Request.QueryString["cod"] != null)
                  {
                      //contrato vinculado debe tener el raiz 
                      contratoVinculado =
                          bd.ejecutarProcedimiento(
@"select min(cod_contratos_suministro) from contratos_suministro where consecutivo_interno='" + txtNumeroContrato.Text.Trim() + "' ").ToString();
                  }
                  
                  cmbTipoOtroSi.Visible = true;
                  lblTipoOtroSi.Visible = true;
                  pnlOtroSi.Visible = true;
              }
              int? codTipoOtroSi = null;
              if (cmbTipoOtroSi.Visible)
              {
                  codTipoOtroSi = int.Parse(cmbTipoOtroSi.SelectedValue);
                  if (Request.QueryString["generaotrosi"] == null)
                  {
                      otroSi = lblOtroSi.Text;//en el caso que no esta generando otro si debe mantener el que tenia al inicio.
                  }
              }

              int codContrato = 0;  
        SPControladoraDatos.dsContratosSuministro ds=new SPControladoraDatos.dsContratosSuministro();
        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter cs = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter log = new SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter();
          if (Request.QueryString["cod"] == null ||
              Request.QueryString["generaotrosi"] != null)
          {
              //creamos el contrato
              SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter estado = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter();
              bool enviaEmail = true;
              if (!chkOmiteFlujo.Checked)
              {
                  estado.FillByCod_manual(ds.estado_contrato_suministro, "1");
                  enviaEmail = true;
              }else {
                  estado.FillByCod_manual(ds.estado_contrato_suministro, "5");
                  enviaEmail = false;
              }

              //traemos el estado
              if (!chkIncluyeapoyo.Checked)
              {
                  txtContratoApoyo.Text = "";
              }

              int codigo = 0;
              if (chkOmiteFlujo.Checked)
              {
                  codigo = int.Parse(txtConsecutivoInterno.Text);
              }else{
                  codigo = int.Parse(bd.ejecutarProcedimiento("select isnull(max(cod_contratos_suministro),0) +1 from contratos_suministro ").ToString());
              }

              cs.Insert(codigo,txtNumeroContrato.Text,int.Parse(cmbCreadoPor.SelectedValue.ToString()),ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,
txtNumeroContrato.Text, nit,cmbContacto.SelectedValue.ToString(), txtDireccionEnvioContrato.Text,
                  cmbPaisEnvioContrato.SelectedValue.ToString(), cmbDepartamentoEnvioContrato.SelectedValue.ToString(),
                  cmbCiudadEnvioContrato.SelectedValue.ToString(),txtContactojuridico.Text, txtCelularContactoJuridico.Text,
 calFechaInicio.Date,calFechaTerminacion.Date,vc, otroSi,   fotroSi,contratoVinculado, txtObservaciones.Text, chkAplicaEstampilla.Checked, chkAplicaPolizas.Checked,
 DateTime.Now,cmbSucursal.SelectedValue,rdContrato.Checked,rdOrdenCompra.Checked,chkOmiteFlujo.Checked,chkIncluyeapoyo.Checked,chkGeneraMulta.Checked,
 fechaLimiteLgalizacion, int.Parse(cmbAsesor.SelectedValue), txtContratoApoyo.Text,null,null,null,null, codTipoOtroSi,txtObservacionesOtroSi.Text);

                  codContrato = int.Parse(cs.verIdentity(txtNumeroContrato.Text, int.Parse(cmbCreadoPor.SelectedValue), txtNumeroContrato.Text).ToString());
                 
              if (Request.QueryString["generaotrosi"] != null)
              {//si esta generando un otro si actualizamos el estado del contrato a cerrado
                  SPControladoraDatos.dsContratosSuministro dsTmp=new SPControladoraDatos.dsContratosSuministro();
                  estado.FillByCod_manual(dsTmp.estado_contrato_suministro, "7");
                  cs.UpdateEstado(dsTmp.estado_contrato_suministro[0].cod_estado_contrato_suministro,
                      int.Parse(Request.QueryString["cod"]));
              
              }
              //enviar correos
                  if (enviaEmail)
                  {
                      clsSeguridad cls = new clsSeguridad();
                      List<string> lista= cls.verCorreos(2055);
                      for(int k=0;k< lista.Count;k++){
                          string asunto="Nuevo contrato de suministro numero:"+txtNumeroContrato.Text;//codContrato;
                          if (Request.QueryString["generaotrosi"] != null)
                          {
                              asunto = "Nuevo otro si para el contrato: " + txtNumeroContrato.Text;
                          }
                          string cuerpo = @"Se creo un nuevo contrato de suministro<br>
Cod Contrato:" + txtNumeroContrato.Text + @"<br>
Cliente:" +txtCliente.Text+@"<br>
Vigencia desde:" + calFechaInicio.Date.ToLongDateString() + @" <br>
Vigencia hasta:" + calFechaTerminacion.Date.ToLongDateString() + @"<br> "+
                 @"<a href='" + cls.verIpSitiio() + @"frm/csuministro/frmDetalleContrato.aspx?cod="+codContrato+"'  >Ver Contrato</a><br>verifique la información para la respectiva aprobación. ";
                          if (!chkGeneraMulta.Checked)
                          {
                              cls.enviarEmail(asunto, cuerpo, lista[k]);
                          }else 
                          //if (chkGeneraMulta.Checked)
                          {
                              string asuntoI = "Se requiere de atencion urgente para un contrato de suministro para antes de: "+calLimiteLegalizacion.Date.ToLongDateString();
                              cls.enviarCalendario(asuntoI, asuntoI,asuntoI+"<br>"+ cuerpo, fechaLimiteLgalizacion.Value.Date.AddDays(-1),
                                  fechaLimiteLgalizacion.Value.Date, Server.MapPath("~/temp/"), lista[k]);
                          }
                      }
                  }
                  log.Insert(DateTime.Now, int.Parse(cmbCreadoPor.SelectedValue.ToString()), txtObservaciones.Text, ds.estado_contrato_suministro[0].cod_estado_contrato_suministro, codContrato, ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,0,0,null);
              //insertar en el log
              }else{
                  codContrato = int.Parse(Request.QueryString["cod"]);
           

        cs.UpdateQuery(txtNumeroContrato.Text, int.Parse(cmbCreadoPor.SelectedValue.ToString()),
                  txtNumeroContrato.Text, nit,cmbContacto.SelectedValue.ToString(), txtDireccionEnvioContrato.Text,
                  cmbPaisEnvioContrato.SelectedValue.ToString(), cmbDepartamentoEnvioContrato.SelectedValue.ToString(),
                  cmbCiudadEnvioContrato.SelectedValue.ToString(), txtContactojuridico.Text, txtCelularContactoJuridico.Text,
                  calFechaInicio.Date,
                  calFechaTerminacion.Date, vc,  txtObservaciones.Text,chkAplicaEstampilla.Checked, 
                  chkAplicaPolizas.Checked, cmbSucursal.SelectedValue,rdContrato.Checked,rdOrdenCompra.Checked,chkOmiteFlujo.Checked,chkIncluyeapoyo.Checked,chkGeneraMulta.Checked,
                  fechaLimiteLgalizacion, int.Parse(cmbAsesor.SelectedValue), txtContratoApoyo.Text, codTipoOtroSi,txtObservacionesOtroSi.Text,codContrato);
              }
          #region divisiones
          //agregamos las divisiones y los grupos
              List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> f =
                 (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
              //divisiones
              SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter division = new SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter();
              if (Request.QueryString["cod"]!= null)
              {
                  if (Request.QueryString["generaotrosi"] == null)
                  division.DeleteByContrato(int.Parse(Request.QueryString["cod"]));
              }
              if (f != null)
              {
                  foreach (var v in f)
                  {
                      division.Insert(v.cod_division_experiencia_contrato_suministro, codContrato);
                      //if (v.cod_division_experiencia_contrato_suministro == int.Parse(cmbDivisiones.SelectedValue)) return;
                  }
              }

          #endregion
              #region grupos
              List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f2 =
                  (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreac"];
              if (f2 == null)
                  f2 = new List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>();
              //grupos
              SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter grp = new SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter();
              if (Request.QueryString["cod"] != null)
              {
                  if (Request.QueryString["generaotrosi"] == null)
                  grp.DeleteByContratoSuministro(int.Parse(Request.QueryString["cod"]));
              }
        foreach (var v in f2)
              {
                  grp.Insert(v.cod_grupo_reactivo_experiencia, codContrato);
              }
#endregion
                #region productos
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> p =
              (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
        SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoxcontrato_conmsumoTableAdapter prd = new SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoxcontrato_conmsumoTableAdapter();
        if (Request.QueryString["cod"] != null)
        {
            if (Request.QueryString["generaotrosi"] == null)
            prd.DeleteQuery(int.Parse(Request.QueryString["cod"]));
        }
        if (p != null)
        {
            foreach (var v in p)
            {
                prd.Insert(v.cod_producto_experiencia_contrato, codContrato);
            }
        }
        #endregion

        #region estampillas
        List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow> pEstampillas =
              (List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>)Session["lstStampillasCreac"];
        SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter prdEstampillas = new SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter();
        if (Request.QueryString["cod"] != null)
        {
            if (Request.QueryString["generaotrosi"] == null)
            prdEstampillas.DeleteByCod_contratos_suministro(int.Parse(Request.QueryString["cod"]));
        }
        if (chkAplicaEstampilla.Checked && pEstampillas != null)
        {
            foreach (var v in pEstampillas)
            {

                decimal valor = 0;

                decimal.TryParse(obtenerValor(), out valor);

                v.valor = ((decimal)((decimal)valor * ((decimal)v.porcentaje / 100)));
                prdEstampillas.Insert(codContrato, v.valor, v.cuentabanco, v.beneficiario, v.cod_destinacion_suministro, v.cod_tipo_cuenta_banco, v.cod_banco_suministro, (v.Isurl_archivoNull() ? "" : v.url_archivo), v.porcentaje,v.pago_cliente);
            }
        }

        #endregion

        #region polizas
        List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow> pPolizas=
              (List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>)Session["lstPolizasCreac"];
        SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter prdPolizas = new SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter();
        if (Request.QueryString["cod"] != null)
        {
            if (Request.QueryString["generaotrosi"] == null)
            prdPolizas.DeleteByCod_contratos_suministro(int.Parse(Request.QueryString["cod"]));
        }
        if (chkAplicaEstampilla.Checked && pPolizas != null)
        {
            foreach (var v in pPolizas)
            {
                prdPolizas.Insert(codContrato, v.cod_riesgo_poliza_consumo, v.observaciones, v.valor_poliza, v.vigencia_meses, (v.Iscod_aseguradora_suministroNull() ? ((int?)null) : v.cod_aseguradora_suministro), (v.Isurl_archivo_polizaNull() ? "" : v.url_archivo_poliza), v.porcentaje);
            }
        }
        #endregion

#region archivos
        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";
        SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter tipoArchivo = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipoarchivoxcontratos_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter archivos = new SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter();
        tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "1");
        if (ds.tipoarchivoxcontratos_suministro.Count > 0)
        {
            archivos.DeleteByTipoarchivoxcontratos_suministro(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);

            if (lnkCorreoAprobacion.NavigateUrl.Trim() != string.Empty)
            {
                archivos.Insert(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro, System.IO.Path.GetFileName(lnkCorreoAprobacion.NavigateUrl),
                    DateTime.Now, lnkCorreoAprobacion.NavigateUrl);
            }
        }
        ////ordenanza
        tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "2");
        if (ds.tipoarchivoxcontratos_suministro.Count > 0)
        {
            archivos.DeleteByTipoarchivoxcontratos_suministro(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);
            if (lnkOrdenanza.NavigateUrl.Trim() != string.Empty)
            {
                archivos.Insert(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro, System.IO.Path.GetFileName(lnkOrdenanza.NavigateUrl),
                    DateTime.Now, lnkOrdenanza.NavigateUrl);
            }
        }
        ////propuesta
        tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "3");
        if (ds.tipoarchivoxcontratos_suministro.Count > 0)
        {
            archivos.DeleteByTipoarchivoxcontratos_suministro(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);
            if (linkPropuesta.NavigateUrl.Trim() != string.Empty)
            {
                archivos.Insert(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro, System.IO.Path.GetFileName(linkPropuesta.NavigateUrl),
                    DateTime.Now, linkPropuesta.NavigateUrl);
            }
        }
        ////documento escaneado
        if (pnlDocumentoEscaneado.Visible)
        {
            tipoArchivo.FillByCod_manual(ds.tipoarchivoxcontratos_suministro, "4");
            if (ds.tipoarchivoxcontratos_suministro.Count > 0)
            {
                archivos.DeleteByTipoarchivoxcontratos_suministro(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro);
                if (linkPropuesta.NavigateUrl.Trim() != string.Empty)
                {
                    archivos.Insert(codContrato, ds.tipoarchivoxcontratos_suministro[0].cod_tipoarchivoxcontratos_suministro, System.IO.Path.GetFileName(lnkVerDocumentoEscaneado.NavigateUrl),
                        DateTime.Now, linkPropuesta.NavigateUrl);
                }
            }
        }
#endregion
        if (Request.QueryString["cod"] == null)
        {
            //Response.Redirect("frmMennsajePostCreacion.aspx?codN=" + codContrato);
            Response.Redirect("frmMennsajePostCreacion.aspx?codN=" + txtNumeroContrato.Text+"&codI="+codContrato);
        }else {
            Response.Redirect("frmListadocontratos.aspx");
        }
    }


    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadocontratos.aspx");
    }


    protected void btnAgregarGrupoReactivos_Click(object sender, EventArgs e)
    {
        List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f =
            (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>();
        //validamos que no exista previamnete
        foreach (var v in f)
        {
            if (v.cod_grupo_reactivo_experiencia == int.Parse(cmbGruposReactivos.SelectedValue)) return;
        }
        //
        SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaDataTable tb = new SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaDataTable();
        SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow fila = tb.Newgrupo_reactivo_experienciaRow();
        fila.cod_grupo_reactivo_experiencia = int.Parse(cmbGruposReactivos.SelectedValue);
        fila.nombre_grupo_reactivo_experiencia = cmbGruposReactivos.SelectedItem.Text;
        f.Add(fila);
        Session["lstGrpCreac"] = f;
        generarGrillas();
    }

    private void generarGrillas()
    {
        List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f =
               (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreac"];
        grdGrupo.DataSource = f;
        grdGrupo.DataBind();

        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> d =
               (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
        grdDivisiones.DataSource = d;
        grdDivisiones.DataBind();

        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> p =
               (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
        grdProdcutos.DataSource = p;
        grdProdcutos.DataBind();


        List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow> fEstampillas =
            (List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>)Session["lstStampillasCreac"];
        grdEstampillas.DataSource = fEstampillas;
        grdEstampillas.DataBind();
        pnlGrdEstampillas.Update();

        List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow> fPolizas = 
            (List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>)Session["lstPolizasCreac"];
        grdPoliza.DataSource = fPolizas;
        grdPoliza.DataBind();
        updatePanelPolizas.Update();
    }


    protected void btnAgregarDivision_Click(object sender, EventArgs e)
    {
        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> f =
           (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>();
        //validamos que no exista previamnete
        foreach (var v in f)
        {
            if (v.cod_division_experiencia_contrato_suministro == int.Parse(cmbDivisiones.SelectedValue)) return;
        }
        //
        SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroDataTable tb = new SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroDataTable();
        SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow fila = tb.Newdivision_experiencia_contrato_suministroRow();
        fila.cod_division_experiencia_contrato_suministro = int.Parse(cmbDivisiones.SelectedValue);
        fila.nombre_division_experiencia_contrato_suministro = cmbDivisiones.SelectedItem.Text;
        f.Add(fila);
        Session["lstDiviCreac"] = f;
        generarGrillas();
    }
  
    protected void EliminarGrupo_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f =
           (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>();
        //validamos que no exista previamnete
        foreach (var v in f)
        {
            if (v.cod_grupo_reactivo_experiencia == int.Parse(b.CommandArgument))
            {
                f.Remove(v);
                break;
            }
        }
        Session["lstGrpCreac"] = f;
        generarGrillas();
    }
    protected void EliminarDivision_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> f =
         (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>();
        //validamos que no exista previamnete
        foreach (var v in f)
        {
            if (v.cod_division_experiencia_contrato_suministro == int.Parse(b.CommandArgument))
            {
                f.Remove(v);
                break;
            }
        }
        Session["lstDiviCreac"] = f;
        generarGrillas();
    }


    protected void btnAgregarProducto_Click(object sender, EventArgs e)
    {
        //obtenemos el codigo
        //Clinica Colsanitas (farmaco independiente - test)
        string sql = @"select top 1 cod_producto_experiencia_contrato,nombre_fabricante,nombre_producto,codigo_manual_referencia from producto_experiencia_contrato
 join fabricante on fabricante.cod_fabricante= producto_experiencia_contrato.cod_fabricante

where rtrim(fabricante.nombre_fabricante)+' ('+rtrim(nombre_producto)+' - '+rtrim(codigo_manual_referencia)+')' ='" +txtProductos.Text+"'";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count == 0) return;
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>();
        ////validamos que no exista previamnete
        foreach (var v in f)
        {
            if (v.cod_producto_experiencia_contrato == int.Parse(tb.Rows[0][0].ToString())) return;
        }
        ////
        SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable tb2 = new SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable();
        SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow fila = tb2.NewpltProductoExperienciaRow();
        fila.cod_producto_experiencia_contrato = int.Parse(tb.Rows[0][0].ToString());
        fila.nombre_fabricante = tb.Rows[0][1].ToString();
        fila.nombre_producto = tb.Rows[0][2].ToString();
        fila.codigo_manual_referencia = tb.Rows[0][3].ToString();
        //fila.nombre_division_experiencia_contrato_suministro = cmbGruposReactivos.SelectedItem.Text;
        f.Add(fila);
        Session["lstProdCreac"] = f;
        txtProductos.Text = "";
        generarGrillas();
    }

    protected void EliminarProucto_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>();
        //validamos que no exista previamnete
        foreach (var v in f)
        {
            if (v.cod_producto_experiencia_contrato == int.Parse(b.CommandArgument))
            {
                f.Remove(v);
                break;
            }
        }
        Session["lstProdCreac"] = f;
        generarGrillas();
    }

    protected void btnImportar_Click(object sender, EventArgs e)
    {
        lblErrorImportar.Text = "";
        //cargamos el archivo
        if(!fileImportar.HasFile)
        {
            lblErrorImportar.Text = "Seleccione un archivo.";

            Panel1_ModalPopupExtender.Show();
            return;
        }


        string ruta = Server.MapPath("~/temp/");
        string archivo="cls"+DateTime.Now.Ticks+""+System.IO.Path.GetExtension(fileImportar.FileName);
        fileImportar.SaveAs(ruta + archivo);
        C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
        libro.Load(ruta + archivo);
        SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.producto_experiencia_contratoTableAdapter();
        SPControladoraDatos.dsContratosSuministro ds=new SPControladoraDatos.dsContratosSuministro();
        lblErrorImportar.Text = "";
        for (int k = 0; k < libro.Sheets[0].Rows.Count; k++)
        { 
        //validamos que exista la referencia
            p.FillByCodigo_manual_referencia(ds.producto_experiencia_contrato, libro.Sheets[0][k, 0].Text);
            if (ds.producto_experiencia_contrato.Count <= 0)
            {
                lblErrorImportar.Text = "Error en la linea " + (k + 1) + " del archivo, la referencia ingresada no existe en la base de datos.";

                Panel1_ModalPopupExtender.Show();
                return;
            }
        }
        //ahora los agregamos a la lista 
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
            if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>();
    
        for (int k = 0; k < libro.Sheets[0].Rows.Count; k++)
        {
            //obtenemos el codigo
            //Clinica Colsanitas (farmaco independiente - test)
            string sql = @"select top 1 cod_producto_experiencia_contrato,nombre_fabricante,nombre_producto,codigo_manual_referencia from producto_experiencia_contrato
 join fabricante on fabricante.cod_fabricante= producto_experiencia_contrato.cod_fabricante

where codigo_manual_referencia ='" + libro.Sheets[0][k, 0].Text + "'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
             ////validamos que no exista previamnete
            foreach (var v in f)
            {
                if (v.cod_producto_experiencia_contrato == int.Parse(tb.Rows[0][0].ToString())) return;
            }
            ////
            SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable tb2 = new SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable();
            SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow fila = tb2.NewpltProductoExperienciaRow();
            fila.cod_producto_experiencia_contrato = int.Parse(tb.Rows[0][0].ToString());
            fila.nombre_fabricante = tb.Rows[0][1].ToString();
            fila.nombre_producto = tb.Rows[0][2].ToString();
            fila.codigo_manual_referencia = tb.Rows[0][3].ToString();
            //fila.nombre_division_experiencia_contrato_suministro = cmbGruposReactivos.SelectedItem.Text;
            f.Add(fila);
           
        }
        Session["lstProdCreac"] = f;
        txtProductos.Text = "";
        generarGrillas();

        Panel1_ModalPopupExtender.Hide();

    }

    protected void btnCancelarImportacion_Click(object sender, EventArgs e)
    {
        Panel1_ModalPopupExtender.Hide();
    }

    protected void btnImportarProductos_Click(object sender, EventArgs e)
    {
        Panel1_ModalPopupExtender.Show();
    }
    protected void btnCancelarEstampilla_Click(object sender, EventArgs e)
    {
        Panel1_ModalPopupEstampilla.Hide();
    }

    protected void btnAceptarEstampilla_Click(object sender, EventArgs e)
    {
        lblErrorEstampilla.Text = "";
        List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>)Session["lstStampillasCreac"];
         if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>();
        ////validamos que no exista previamnete
        if (cmbBanco.SelectedValue == null ||  cmbBanco.Text.Trim() == string.Empty)
        {
            lblErrorEstampilla.Text = "El banco es obligatorio.";
            return;
        }
        if (cmbtipocuenta.SelectedValue == null || cmbtipocuenta.Text.Trim() == string.Empty)
        {
            lblErrorEstampilla.Text = "El tipo de cuenta es obligatorio.";
            return;
        }
        if (txtValorEstampilla.Text.Trim() == string.Empty)
        {
            lblErrorEstampilla.Text = "El valor es obligatorio.";
            return;
        }
        if (txtPcEstampilla.Text.Trim() == string.Empty)
        {
            lblErrorEstampilla.Text = "El porcentaje es obligatorio.";
            return;
        }
        if (txtBeneficiarioEstampilla.Text.Trim() == string.Empty)
        {
            lblErrorEstampilla.Text = "El beneficiario es obligatorio.";
            return;
        }
        if (cmbDestinacion.SelectedValue == null || cmbDestinacion.Text.Trim() == string.Empty)
        {
            lblErrorEstampilla.Text = "La destinacion es obligatoria.";
            return;
        }



        SPControladoraDatos.dsContratosSuministro.pltEstampillaDataTable tb2 = new SPControladoraDatos.dsContratosSuministro.pltEstampillaDataTable();
        SPControladoraDatos.dsContratosSuministro.pltEstampillaRow fila = tb2.NewpltEstampillaRow();
        if (lblCodEstampilla.Text.Trim() != string.Empty)
        {
            for (int k = 0; k < f.Count; k++)
            {
                if (f[k].cod_estampillas_contrato_sumisnistro.ToString() == lblCodEstampilla.Text)
                {
                    f.RemoveAt(k);
                    break;
                }
            }
        }
        fila.cod_estampillas_contrato_sumisnistro = f.Count + 1;
        fila.cod_contratos_suministro = f.Count == 0 ? 0 : f[f.Count - 1].cod_contratos_suministro + 1;
        fila.cod_banco_suministro = int.Parse( cmbBanco.SelectedValue);
        fila.nombre_banco_suministro = cmbBanco.SelectedItem.Text;

        fila.beneficiario = txtBeneficiarioEstampilla.Text;
        fila.cuentabanco = txtNrocuentaEstampilla.Text;
        fila.cod_destinacion_suministro = int.Parse(cmbDestinacion.SelectedValue);
        fila.nombre_destinacion_suministro = cmbDestinacion.SelectedItem.Text;
        fila.cod_tipo_cuenta_banco = int.Parse(cmbtipocuenta.SelectedValue);
        fila.nombre_tipo_cuenta_banco= cmbtipocuenta.SelectedItem.Text;
        fila.pago_cliente = chkPagoClienteEstampilla.Checked;
        
        decimal pc = 0;
        if (!decimal.TryParse(txtPcEstampilla.Text.Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator), out pc))
        {
            lblErrorEstampilla.Text = "El porcentaje ingresado no es valido";
            return;
        }
        fila.porcentaje = pc;
        decimal valor = 0;

        decimal.TryParse(obtenerValor(), out valor);
        
        txtValorEstampilla.Text =((long)( (decimal)valor * ((decimal)pc / 100))).ToString();

        if (!decimal.TryParse(txtValorEstampilla.Text.Replace(",", ".").Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator), out valor))
        {
            lblErrorEstampilla.Text = "El valor ingresado no es valido";
            return;
        }

        fila.valor = valor;
        fila.url_archivo = "";
        //fila.nombre_division_experiencia_contrato_suministro = cmbGruposReactivos.SelectedItem.Text;
        f.Add(fila);
        Session["lstStampillasCreac"] = f;
      
        generarGrillas();
        Panel1_ModalPopupEstampilla.Hide();
    }

    protected void btnEliminarEstampilla_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        
        lblErrorEstampilla.Text = "";
        List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>)Session["lstStampillasCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>();



        for (int k = 0; k < f.Count; k++)
        {
            if (f[k].cod_estampillas_contrato_sumisnistro.ToString() == b.CommandArgument)
            {
                f.RemoveAt(k);
                break;
            }
        }
      
        Session["lstStampillasCreac"] = f;

        generarGrillas();
    }

    protected void btnEditarEstampilla_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;

        lblErrorEstampilla.Text = "";
        List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>)Session["lstStampillasCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltEstampillaRow>();


lblCodEstampilla.Text=b.CommandArgument;
if (lblCodEstampilla.Text.Trim() != string.Empty)
        {
            for (int k = 0; k < f.Count; k++)
            {
                if (f[k].cod_estampillas_contrato_sumisnistro.ToString() == b.CommandArgument)
                {
                    cmbBanco.SelectedValue = f[k].cod_banco_suministro.ToString();
                    txtBeneficiarioEstampilla.Text = f[k].beneficiario;
                    cmbDestinacion.SelectedValue = f[k].cod_destinacion_suministro.ToString();
                    txtNrocuentaEstampilla.Text = f[k].cuentabanco;
                    txtPcEstampilla.Text = f[k].porcentaje.ToString().Replace(",",".");
                    cmbtipocuenta.SelectedValue = f[k].cod_tipo_cuenta_banco.ToString();
                    txtValorEstampilla.Text = string.Format("{0:c}", ((long)f[k].valor)).ToString();
                    lblCodEstampilla.Text = f[k].cod_estampillas_contrato_sumisnistro.ToString();
                    chkPagoClienteEstampilla.Checked = f[k].pago_cliente;
                    lblErrorEstampilla.Text = "";
                    break;
                }
            }
        }

        Panel1_ModalPopupEstampilla.Show();
    }

    protected void btnAgregarEstampilla_Click(object sender, EventArgs e)
    {
        cmbBanco.SelectedValue = null;
        txtBeneficiarioEstampilla.Text = "";
        cmbDestinacion.SelectedValue= null;
        chkPagoClienteEstampilla.Checked = false;
        txtNrocuentaEstampilla.Text = "";
        txtPcEstampilla.Text = "";
        cmbtipocuenta.SelectedValue = null;
        txtValorEstampilla.Text = "";
        lblCodEstampilla.Text = "";
        lblErrorEstampilla.Text = "";
        Panel1_ModalPopupEstampilla.Show();
    }

    protected void btnCargarOrdenanza_Click(object sender, EventArgs e)
    {
        if (!FileUploadOrdenanza.HasFile)
        {
            lblError.Text = "Seleccione el archivo de la Ordenanza/Estatuto";
            return;
        }

        string ruta=Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "contratoConsumo" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUploadOrdenanza.FileName);
        FileUploadOrdenanza.SaveAs(ruta+archivo);
        lnkOrdenanza.NavigateUrl = "~/files/"+archivo;
        lnkOrdenanza.Visible = true;
    }

    protected void btnCargarCorreoAprobacion_Click(object sender, EventArgs e)
    {
        if (!FileUploadCorreoAprobacion.HasFile)
        {
            lblError.Text = "Seleccione el archivo del correo";
            return;
        }

        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "contratoConsumoCo" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUploadCorreoAprobacion.FileName);
        FileUploadCorreoAprobacion.SaveAs(ruta + archivo);
        lnkCorreoAprobacion.NavigateUrl = "~/files/" + archivo;
        lnkCorreoAprobacion.Visible = true;
    }

    protected void btnCargarPropuesta_Click(object sender, EventArgs e)
    {
        if (!FileUploadPropuesta.HasFile)
        {
            lblError.Text = "Seleccione el archivo de la propuesta ";
            return;
        }

        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "propuesta" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUploadPropuesta.FileName);
        FileUploadPropuesta.SaveAs(ruta + archivo);
        linkPropuesta.NavigateUrl = "~/files/" + archivo;
        linkPropuesta.Visible = true;
    }

    protected void btnAceptarPoliza_Click(object sender, EventArgs e)
    {
        //validamos
        lblErrorPoliza.Text = "";
        List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>)Session["lstPolizasCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>();
        ////validamos que no exista previamnete
        if (cmbRiesgoPoliza.SelectedValue == null || cmbRiesgoPoliza.SelectedValue.Trim() == string.Empty)
        {
            lblErrorPoliza.Text = "El riesgo de la poliza es obligatorio.";
            return;
        }
        if (txtPorcentajePoliza.Text.Trim() == string.Empty)
        {
            lblErrorPoliza.Text = "El porcentaje de la poliza es obligatorio.";
            return;
        }
        decimal tmp = 0;
        if (!decimal.TryParse(txtPorcentajePoliza.Text.Replace(",", ".").Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator), out tmp))
        {
            lblErrorPoliza.Text = "El porcentaje de la poliza no es valido.";
            return;
        }
        //if (txtValorPoliza.Text.Trim() == string.Empty)
        //{
        //    lblErrorPoliza.Text = "El valor es obligatorio.";
        //    return;
        //}



        SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoDataTable tb2 = new SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoDataTable();
        SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow fila = tb2.NewpltPolizasContratoConsumoRow();
        if (lblCodPoliza.Text.Trim() != string.Empty)
        {
            for (int k = 0; k < f.Count; k++)
            {
                if (f[k].cod_polizas_contrato_suministro.ToString() == lblCodPoliza.Text)
                {
                    f.RemoveAt(k);
                    break;
                }
            }
        }
        fila.cod_contratos_suministro = f.Count == 0 ? 0 : f[f.Count - 1].cod_contratos_suministro + 1;
        fila.cod_riesgo_poliza_consumo = int.Parse( cmbRiesgoPoliza.SelectedValue);
        fila.observaciones = txtObservacionesPoliza.Text;
        fila.porcentaje = decimal.Parse(txtPorcentajePoliza.Text.Replace(",",".").Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
        fila.valor_poliza = 0;
        //fila.valor_poliza = decimal.Parse( txtValorPoliza.Text);
        fila.vigencia_meses = int.Parse(cmbVigenciaPoliza.SelectedValue);
        fila.nombre_riesgo_poliza_consumo = cmbRiesgoPoliza.SelectedItem.Text;
        //fila.nombre_division_experiencia_contrato_suministro = cmbGruposReactivos.SelectedItem.Text;
        f.Add(fila);
        Session["lstPolizasCreac"] = f;
        generarGrillas();
        ModalPopupExtenderPolizas.Hide();
    }

    protected void btnCancelarPoliza_Click(object sender, EventArgs e)
    {
        ModalPopupExtenderPolizas.Hide();
    }
    protected void btnAgregarPoliza_Click(object sender, EventArgs e)
    {
        lblCodPoliza.Text = "";
        txtObservacionesPoliza.Text = "";
        txtPorcentajePoliza.Text = "";
        //txtValorPoliza.Text = "";
        cmbVigenciaPoliza.SelectedIndex = 0;
        cmbRiesgoPoliza.SelectedIndex = 0;

        ModalPopupExtenderPolizas.Show();
    }
    protected void btnEditarPolizas_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;

        lblErrorPoliza.Text = "";
        List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>)Session["lstPolizasCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>();


        lblCodPoliza.Text = b.CommandArgument;
        if (lblCodPoliza.Text.Trim() != string.Empty)
        {
            for (int k = 0; k < f.Count; k++)
            {
                if (f[k].cod_polizas_contrato_suministro.ToString() == b.CommandArgument)
                {
                    
                    cmbRiesgoPoliza.SelectedValue = f[k].cod_riesgo_poliza_consumo.ToString();
                    txtObservacionesPoliza.Text = f[k].observaciones;
                    txtPorcentajePoliza.Text = f[k].porcentaje.ToString().Replace(",",".");

                    cmbVigenciaPoliza.SelectedValue = ((int)f[k].vigencia_meses).ToString();
                    //txtValorPoliza.Text = ((int)f[k].valor_poliza).ToString();
                    lblErrorPoliza.Text = "";
                    break;
                }
            }
        }

        ModalPopupExtenderPolizas.Show();
    }
    protected void EliminarPolizas_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;

        lblErrorEstampilla.Text = "";
        List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>)Session["lstPolizasCreac"];
        if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.pltPolizasContratoConsumoRow>();

        for (int k = 0; k < f.Count; k++)
        {
            if (f[k].cod_polizas_contrato_suministro.ToString() == b.CommandArgument)
            {
                f.RemoveAt(k);
                break;
            }
        }

        Session["lstPolizasCreac"] = f;

        generarGrillas();
    }
    protected void Unnamed_Click(object sender, EventArgs e)
    {

    }

    public string obtenerValor()
    {
        string str = txtValorContrato.Text.Replace("$","");
        if (str.LastIndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator) > 0)
        {
            str = str.Substring(0, str.LastIndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator));
            str = str.Replace(",", "");
            str = str.Replace(".", "");
            str = str + System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator +
                txtValorContrato.Text.Substring(txtValorContrato.Text.LastIndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator) + 1);
        }else {
            str = str.Replace(",", "");
        }
        return str;
    }
    protected void btnCalcularValorEstampillas_Click(object sender, EventArgs e)
    {
        //long valor = 0;
        decimal pc = 0;
        
        //verificamos si termina en .00
        double valor = 0;
        double.TryParse(obtenerValor(), out valor);
        //long.TryParse(txtValorContrato.Text, out valor);
        decimal.TryParse(txtPcEstampilla.Text.Replace(",",".").Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator), out pc);
        txtValorEstampilla.Text = string.Format("{0:c}", ((long)((decimal)valor * ((decimal)pc / 100))));
    }

    protected void btnCargarDocumentoEscaneado_Click(object sender, EventArgs e)
    {
        if (!FileUploadDocumentoEscaneado.HasFile)
        {
            lblError.Text = "Seleccione el archivo del documento escaneado";
            return;
        }

        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "contratoConsumo" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUploadDocumentoEscaneado.FileName);
        FileUploadDocumentoEscaneado.SaveAs(ruta + archivo);
        lnkVerDocumentoEscaneado.NavigateUrl = "~/files/" + archivo;
        lnkVerDocumentoEscaneado.Visible = true;
    }

    protected void chkGeneraMulta_CheckedChanged(object sender, EventArgs e)
    {
        lblFechaLimite.Visible = chkGeneraMulta.Checked;
        calLimiteLegalizacion.Visible = chkGeneraMulta.Checked;
    }

    protected void chkIncluyeapoyo_CheckedChanged(object sender, EventArgs e)
    {
        txtContratoApoyo.Visible = chkIncluyeapoyo.Checked;
    }
    protected void chkAplicaPolizas_CheckedChanged(object sender, EventArgs e)
    {
        pnlPolizas.Visible = chkAplicaPolizas.Checked;
    }
    protected void chkAplicaEstampilla_CheckedChanged(object sender, EventArgs e)
    {
        pnlEstampillas.Visible = chkAplicaEstampilla.Checked;
        lblObligatorioOrdenanza.Visible = chkAplicaEstampilla.Checked;
        if(chkOmiteFlujo.Checked)
        {
        lblObligatorioOrdenanza.Visible =false;
        }
    }



    protected void chkOmiteFlujo_CheckedChanged(object sender, EventArgs e)
    {
        lblConsecutivoInterno.Visible = chkOmiteFlujo.Checked;
        txtConsecutivoInterno.Visible = chkOmiteFlujo.Checked;

        lblObligatorioPropuesta.Visible = !chkOmiteFlujo.Checked;
        lblObligatorioOrdenanza.Visible = chkAplicaEstampilla.Checked;

        lblDireccionEnvioObligatorio.Visible = !chkOmiteFlujo.Checked;
lblContactoJuridicoObligatorio.Visible = !chkOmiteFlujo.Checked;
lblCelularObligatorio.Visible = !chkOmiteFlujo.Checked;
lblProductosObligatorio.Visible = !chkOmiteFlujo.Checked;

        if (chkOmiteFlujo.Checked)
        {
            lblObligatorioOrdenanza.Visible = false;
        }
    }
}
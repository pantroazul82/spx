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
        nit = sacarNit(txtCliente.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {
            lnkCliente.NavigateUrl = lnkCliente.NavigateUrl + nit;
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
            sql = @"select top 1 codAsesor from contratos_suministro
where nitCliente ='"+nit+"' order by cod_contratos_suministro desc";
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
where numero_contrato like '%" + term + @"%'";

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


    public static string nit = "";

    protected void Page_Load(object sender, EventArgs e)
    {
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
        if (!IsPostBack)
        {

            cmbCreadoPor.SelectedValue = Session["ss_cod_usuario"].ToString();
            calCreacion.Value = DateTime.Now;
            cmbPaisEnvioContrato.SelectedValue = "COL  ";
            Session["lstGrpCreac"] = null;
            Session["lstDiviCreac"]=null;
            Session["lstProdCreac"]=null;
            //evaluamos si es edicion o es otro si
            if (Request.QueryString["cod"] != null)
            {
                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter objContrato = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter objGrupo=new SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter objdivision=new SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministroTableAdapters.pltProductoExperienciaTableAdapter objPltProductos = new SPControladoraDatos.dsContratosSuministroTableAdapters.pltProductoExperienciaTableAdapter();


                objContrato.FillByCod_contratos_suministro(ds.contratos_suministro, int.Parse(Request.QueryString["cod"]));
                if (ds.contratos_suministro.Count > 0)
                {
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
                    SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
                    objData.ejecutarConsulta(sql, tb);

                    txtCliente.Text = tb.Rows[0][0].ToString();
                    cargarCliente();

                    txtConsecutivoInterno.Text = ds.contratos_suministro[0].consecutivo_interno.Trim();
                    txtContactojuridico.Text = ds.contratos_suministro[0].contacto_juridico.Trim();
                    txtDireccionEnvioContrato.Text = ds.contratos_suministro[0].direccion_envio_contrato.Trim();
                    txtNumeroContrato.Text = ds.contratos_suministro[0].numero_contrato.Trim();
                    txtObservaciones.Text = ds.contratos_suministro[0].observaciones.Trim();                   
                    txtValorContrato.Text = ds.contratos_suministro[0].valor_contrato.ToString().Trim();

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

                     List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f = (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreac"];
                    if (f == null) f = new List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>();

                       SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaDataTable tbGrupo = new SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaDataTable();    
                      SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroDataTable tbDivision = new SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroDataTable();
                     
                    SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable tbProducto = new SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaDataTable();
                    List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> listaProducto = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
                    if (listaProducto == null) listaProducto = new List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>();

                       List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> fDivision = (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
                        if (fDivision == null) fDivision = new List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>();

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

                    //cargamos las divisiones
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

        Session["lstGrpCreac"] = f;
        Session["lstDiviCreac"] = fDivision;

        Session["lstProdCreac"] = listaProducto;
        generarGrillas();
                }
            
            }

        }
        generarGrillas();
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

    private void cargarCargo()
    {
        nit = sacarNit(txtCliente.Text);
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

        if (calFechaInicio.Date> calFechaTerminacion.Date)
        {
            lblError.Text = "Las fecha de inicio y de terminacion no son coherentes.";
            return false;
        }

        

        if (txtNumeroContrato.Text.Trim() == string.Empty)
        {
            lblError.Text = "El numero de contrato es obligatorio.";
            return false;
        }
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();


        if (txtConsecutivoInterno.Text.Trim() == string.Empty)
        {
            lblError.Text = "El numero de consecutivo interno es obligatorio.";
            return false;
        }

        //validamos que el consecutivo interno no este ya asignado
        if (Request.QueryString["otroS"] == null && Request.QueryString["cod"] == null)
        {
            var c=bd.ejecutarProcedimiento("select count(*) from contratos_suministro where consecutivo_interno='"+txtConsecutivoInterno.Text+"'");

            if (c != null && c != System.DBNull.Value && c.ToString().Trim() != "0")
            {
                lblError.Text = "El consecutivo interno '"+txtConsecutivoInterno.Text.Trim()+"' esta asignado a otro contrato.";
                return false;
            }

        }


        if (txtCliente.Text.Trim() == string.Empty)
        {
            lblError.Text = "El cliente es obligatorio.";
            return false;
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

        if (txtDireccionEnvioContrato.Text.Trim() == string.Empty)
        {
            lblError.Text = "la direccion de envio del contrato es obligatorio.";
            return false;
        }

        if (cmbCiudadEnvioContrato.SelectedValue == null || cmbCiudadEnvioContrato.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "La ciudad de envio del contrato es obligatoria.";
            return false;
        }

        if (txtContactojuridico.Text.Trim() == string.Empty)
        {
            lblError.Text = "El contacto juridico es obligatorio.";
            return false;
        }
        if (txtCelularContactoJuridico.Text.Trim() == string.Empty)
        {
            lblError.Text = "El celular del contacto juridico es obligatorio.";
            return false;
        }

        if (txtValorContrato.Text.Trim() == string.Empty)
        {
            lblError.Text = "El valor del contrato es obligatorio.";
            return false;
        }

        decimal vc = 0;
        if (!decimal.TryParse( txtValorContrato.Text.Trim(),out vc))
        {
            lblError.Text = "El valor del contrato ingresado no es valido.";
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
            lblError.Text = "Debe ingresar por lo menos una division.";
            return false;
        }

       
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> f2 = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreac"];
        if (f2 == null) f2 = new List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>();
        if (!chkOmiteFlujo.Checked && f2.Count == 0)
        {
            lblError.Text = "Debe ingresar por lo menos un producto.";
            return false;
        }
        return true;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar())
        {
            return;
        }
          nit = sacarNit(txtCliente.Text);   
            decimal vc = 0;
            decimal.TryParse(txtValorContrato.Text, out vc);
            string otroSi = "";
              DateTime? fotroSi = null;
              DateTime? fechaLimiteLgalizacion = null;
              if (calLimiteLegalizacion.Value != null)
              {
                  fechaLimiteLgalizacion = calLimiteLegalizacion.Date;
              }

              string contratoVinculado = "";
              if (Request.QueryString["otroS"] != null)
              {
                  otroSi = Request.QueryString["otroS"];
                  fotroSi = DateTime.Now;
                  if (Request.QueryString["cv"] != null)
                  {
                      contratoVinculado = Request.QueryString["cv"];
                  }
              }
              int codContrato = 0;  
        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter cs = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter log = new SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter();
          if (Request.QueryString["cod"] == null)
          {
              //creamos el contrato
              SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
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
        

              
              cs.Insert(txtNumeroContrato.Text,int.Parse(cmbCreadoPor.SelectedValue.ToString()),ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,
txtConsecutivoInterno.Text, nit,cmbContacto.SelectedValue.ToString(), txtDireccionEnvioContrato.Text,
                  cmbPaisEnvioContrato.SelectedValue.ToString(), cmbDepartamentoEnvioContrato.SelectedValue.ToString(),
                  cmbCiudadEnvioContrato.SelectedValue.ToString(),txtContactojuridico.Text, txtCelularContactoJuridico.Text,
 calFechaInicio.Date,calFechaTerminacion.Date,vc, otroSi,   fotroSi,contratoVinculado, txtObservaciones.Text, chkAplicaEstampilla.Checked, chkAplicaPolizas.Checked,
 DateTime.Now,cmbSucursal.SelectedValue,rdContrato.Checked,rdOrdenCompra.Checked,chkOmiteFlujo.Checked,chkIncluyeapoyo.Checked,chkGeneraMulta.Checked,
 fechaLimiteLgalizacion, int.Parse(cmbAsesor.SelectedValue), txtContratoApoyo.Text,null,null,null,null);

                  codContrato = int.Parse(cs.verIdentity(txtNumeroContrato.Text, int.Parse(cmbCreadoPor.SelectedValue), txtConsecutivoInterno.Text).ToString());

              //enviar correos
                  if (enviaEmail)
                  {
                      clsSeguridad cls = new clsSeguridad();
                      List<string> lista= cls.verCorreos(2055);
                      for(int k=0;k< lista.Count;k++){
                          string asunto="Nuevo contrato de suministro cod:"+codContrato;
                          string cuerpo = @"Se creo un nuevo contrato de suministro<br>
Cod Contrato:" + codContrato + @"<br>
Cliente:" +txtCliente.Text+@"<br>
Vigencia desde:" + calFechaInicio.Date.ToLongDateString() + @" <br>
Vigencia hasta:" + calFechaTerminacion.Date.ToLongDateString() + @"<br> "+
                 @"<a href='" + cls.verIpSitiio() + @"frm/csuministro/frmDetalleContrato.aspx?cod="+codContrato+"'  >Ver Contrato</a><br>verifique la información para la respectiva aprobación. ";
                          cls.enviarEmail(asunto, cuerpo, lista[k]);
                          if (chkGeneraMulta.Checked)
                          {
                              string asuntoI = "Se requiere de atencion urgente para un contrato de suministro para antes de: "+calLimiteLegalizacion.Date.ToLongDateString();
                              cls.enviarCalendario(asuntoI, asuntoI,asuntoI+"<br>"+ cuerpo, fechaLimiteLgalizacion.Value.Date.AddDays(-1), fechaLimiteLgalizacion.Value.Date, "", lista[k]);
                          }
                      }
                  }
                  log.Insert(DateTime.Now, int.Parse(cmbCreadoPor.SelectedValue.ToString()), txtObservaciones.Text, ds.estado_contrato_suministro[0].cod_estado_contrato_suministro, codContrato, ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,0,0);
              //insertar en el log
              }else{
                  codContrato = int.Parse(Request.QueryString["cod"]);
        cs.UpdateQuery(txtNumeroContrato.Text, int.Parse(cmbCreadoPor.SelectedValue.ToString()),
                  txtConsecutivoInterno.Text, nit,cmbContacto.SelectedValue.ToString(), txtDireccionEnvioContrato.Text,
                  cmbPaisEnvioContrato.SelectedValue.ToString(), cmbDepartamentoEnvioContrato.SelectedValue.ToString(),
                  cmbCiudadEnvioContrato.SelectedValue.ToString(), txtContactojuridico.Text, txtCelularContactoJuridico.Text, calFechaInicio.Date,
                  calFechaTerminacion.Date, vc, otroSi, fotroSi, contratoVinculado, txtObservaciones.Text,chkAplicaEstampilla.Checked, 
                  chkAplicaPolizas.Checked, cmbSucursal.SelectedValue,rdContrato.Checked,rdOrdenCompra.Checked,chkOmiteFlujo.Checked,chkIncluyeapoyo.Checked,chkGeneraMulta.Checked,
                  fechaLimiteLgalizacion, int.Parse(cmbAsesor.SelectedValue), txtContratoApoyo.Text, codContrato);
              }
          #region divisiones
          //agregamos las divisiones y los grupos
              List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> f =
                 (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreac"];
              //divisiones
              SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter division = new SPControladoraDatos.dsContratosSuministroTableAdapters.divisionxcontrato_suministroTableAdapter();
              if (Request.QueryString["cod"]!= null)
              {

                  division.DeleteByContrato(int.Parse(Request.QueryString["cod"]));
              }

              foreach (var v in f)
              {
                  division.Insert(v.cod_division_experiencia_contrato_suministro, codContrato);
                  //if (v.cod_division_experiencia_contrato_suministro == int.Parse(cmbDivisiones.SelectedValue)) return;
              }

          #endregion
              #region grupos
              List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f2 =
                  (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreac"];
              //grupos
              SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter grp = new SPControladoraDatos.dsContratosSuministroTableAdapters.grupo_reactivoxcontrato_suministroTableAdapter();
              if (Request.QueryString["cod"] != null)
              {
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
            prd.DeleteQuery(int.Parse(Request.QueryString["cod"]));
        }
        foreach (var v in p)
        {
            prd.Insert(v.cod_producto_experiencia_contrato, codContrato);
        }
        #endregion

        Response.Redirect("frmListadocontratos.aspx");
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
        fila.nombre_division_experiencia_contrato_suministro = cmbGruposReactivos.SelectedItem.Text;
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
        } generarGrillas();
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
        } generarGrillas();
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
}
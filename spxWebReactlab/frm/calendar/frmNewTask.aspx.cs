using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_calendar_frmNewTask : System.Web.UI.Page
{
	public class AutoCompleteResult
	{
		public string id { get; set; }
		public string value { get; set; }
	}

	private void registarScript()
	{
		Type cstype = this.GetType();
		string nombreScript = "alertar";
		ClientScriptManager cs = Page.ClientScript;
		System.Text.StringBuilder sb = new System.Text.StringBuilder();
		#region reactivo
		sb.AppendLine(" ");
        sb.AppendLine("function ocultarcheckReactivo()");
		sb.AppendLine("{");
        sb.AppendLine(" if(document.getElementById('" + chkAtadaReactivo.ClientID + "').checked ){ ");
        sb.AppendLine("  if(document.getElementById('" + cmbFabricanteReactivo.ClientID + "') != null )document.getElementById('" + cmbFabricanteReactivo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + cmbReactivo.ClientID + "') != null )document.getElementById('" + cmbReactivo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + lblReactivo.ClientID + "') != null )document.getElementById('" + lblReactivo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + btnAgregarReactivo.ClientID + "') != null )document.getElementById('" + btnAgregarReactivo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + btnQuitarReactivo.ClientID + "') != null )document.getElementById('" + btnQuitarReactivo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine(" }else{");
        sb.AppendLine("  if(document.getElementById('" + cmbFabricanteReactivo.ClientID + "') != null )document.getElementById('" + cmbFabricanteReactivo.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + cmbReactivo.ClientID + "') != null )document.getElementById('" + cmbReactivo.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + lblReactivo.ClientID + "') != null )document.getElementById('" + lblReactivo.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + btnAgregarReactivo.ClientID + "') != null )document.getElementById('" + btnAgregarReactivo.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + btnQuitarReactivo.ClientID + "') != null )document.getElementById('" + btnQuitarReactivo.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("} ");
        sb.AppendLine("} ");
#endregion
        #region serial
        sb.AppendLine("function ocultarcheckSerial()");
        sb.AppendLine("{");
		sb.AppendLine(" if(document.getElementById('" + chkAtadaSerial.ClientID + "').checked ){ ");
		sb.AppendLine("  if(document.getElementById('" + txtSerial.ClientID + "') != null )document.getElementById('" + txtSerial.ClientID + "').style.visibility = 'visible'; ");
		sb.AppendLine(" }else{");
		sb.AppendLine("  if(document.getElementById('" + txtSerial.ClientID + "') != null)document.getElementById('" + txtSerial.ClientID + "').style.visibility = 'hidden'; ");
		sb.AppendLine("} ");
        sb.AppendLine("} ");
#endregion
        #region modelo
        sb.AppendLine("function ocultarcheckModelo()");
        sb.AppendLine("{");
		sb.AppendLine(" if(document.getElementById('" + chkAtadaModelo.ClientID + "').checked ){ ");
		sb.AppendLine("  if(document.getElementById('" + txtModelo.ClientID + "') != null )document.getElementById('" + txtModelo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + btnAgregarModelo.ClientID + "') != null )document.getElementById('" + btnAgregarModelo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + btnQuitarModelo.ClientID + "') != null )document.getElementById('" + btnQuitarModelo.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + lblModelos.ClientID + "') != null )document.getElementById('" + lblModelos.ClientID + "').style.visibility = 'visible'; ");

		sb.AppendLine(" }else{");
		sb.AppendLine("  if(document.getElementById('" + txtModelo.ClientID + "') != null)document.getElementById('" + txtModelo.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + btnAgregarModelo.ClientID + "') != null)document.getElementById('" + btnAgregarModelo.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + lblModelos.ClientID + "') != null)document.getElementById('" + lblModelos.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + btnQuitarModelo.ClientID + "') != null )document.getElementById('" + btnQuitarModelo.ClientID + "').style.visibility = 'hidden'; ");
		sb.AppendLine("} ");
        sb.AppendLine("} ");
#endregion
        #region cliente
        sb.AppendLine("function ocultarcheckCliente()");
        sb.AppendLine("{");
		sb.AppendLine(" if(document.getElementById('" + chkAtadaCliente.ClientID + "').checked ){ ");
		sb.AppendLine("  if(document.getElementById('" + lblSucursal.ClientID + "') != null )document.getElementById('" + lblSucursal.ClientID + "').style.visibility = 'visible'; ");
		sb.AppendLine("  if(document.getElementById('" + lblContacto.ClientID + "') != null)document.getElementById('" + lblContacto.ClientID + "').style.visibility = 'visible'; ");
		sb.AppendLine("  if(document.getElementById('" + txtCliente.ClientID + "')  != null)document.getElementById('" + txtCliente.ClientID + "').style.visibility = 'visible'; ");
		sb.AppendLine("  if(document.getElementById('" + cmbSucursal.ClientID + "') != null)document.getElementById('" + cmbSucursal.ClientID + "').style.visibility = 'visible'; ");
		sb.AppendLine("  if(document.getElementById('" + cmbContacto.ClientID + "') != null)document.getElementById('" + cmbContacto.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + lnkNuevoContaco.ClientID + "') != null)document.getElementById('" + lnkNuevoContaco.ClientID + "').style.visibility = 'visible'; ");
        sb.AppendLine("  if(document.getElementById('" + btnCargarContactos.ClientID + "') != null)document.getElementById('" + btnCargarContactos.ClientID + "').style.visibility = 'visible'; ");
		sb.AppendLine(" }else{");
		sb.AppendLine("  if(document.getElementById('" + lblSucursal.ClientID + "') != null)document.getElementById('" + lblSucursal.ClientID + "').style.visibility = 'hidden'; ");
		sb.AppendLine("  if(document.getElementById('" + lblContacto.ClientID + "') != null)document.getElementById('" + lblContacto.ClientID + "').style.visibility = 'hidden'; ");
		sb.AppendLine("  if(document.getElementById('" + txtCliente.ClientID + "')  != null)document.getElementById('" + txtCliente.ClientID + "').style.visibility = 'hidden'; ");
		sb.AppendLine("  if(document.getElementById('" + cmbSucursal.ClientID + "') != null)document.getElementById('" + cmbSucursal.ClientID + "').style.visibility = 'hidden'; ");
		sb.AppendLine("  if(document.getElementById('" + cmbContacto.ClientID + "') != null)document.getElementById('" + cmbContacto.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + lnkNuevoContaco.ClientID + "') != null)document.getElementById('" + lnkNuevoContaco.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("  if(document.getElementById('" + btnCargarContactos.ClientID + "') != null)document.getElementById('" + btnCargarContactos.ClientID + "').style.visibility = 'hidden'; ");
        sb.AppendLine("} window.onload = ocultarcheckCliente();  ");
        sb.AppendLine(" window.onload = ocultarcheckModelo();  ");
        sb.AppendLine(" window.onload = ocultarcheck();  ");
        sb.AppendLine(" window.onload = ocultarcheck();  ");
		sb.AppendLine("}");
#endregion
		sb.AppendLine(" ");

		chkAtadaCliente.Attributes.Add("onclick", "ocultarcheckCliente()");
		chkAtadaModelo.Attributes.Add("onclick", "ocultarcheckModelo()");
        chkAtadaSerial.Attributes.Add("onclick", "ocultarcheckSerial()");
        chkAtadaReactivo.Attributes.Add("onclick", "ocultarcheckReactivo()");
		
		if (!cs.IsStartupScriptRegistered(nombreScript))
		{
			cs.RegisterStartupScript(cstype, nombreScript, sb.ToString(), true);
		}
	}

	#region webmetod de cliente
	[System.Web.Services.WebMethod]
	[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
	public static List<AutoCompleteResult> ObtCliente(string term)
	{

		string sql = @"select top " + 15 + @"
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
	#region webmetod de equipo serial
	[System.Web.Services.WebMethod]
	[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
	public static List<AutoCompleteResult> ObtEquipo(string term)
	{
		string sql = @"select top  5 
rtrim(serial)+' | '+nombreFabricante+' ('+rtrim(nombreModelo)+')'
'columna' from dbo.vistaEquipo
where serial like '%" + term + @"%'";
		if (nit != null && nit.Trim() != string.Empty)
		{
			sql = sql + " and nitCliente ='"+nit+"'";
		}

		System.Data.DataTable tb = new System.Data.DataTable();
		SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
		obj.ejecutarConsulta(sql, tb);
		
		List<AutoCompleteResult> lista = new List<AutoCompleteResult>();

		for (int k = 0;tb != null && k < tb.Rows.Count; k++)
		{
			AutoCompleteResult ar = new AutoCompleteResult();
			ar.id = tb.Rows[k][0].ToString();
			ar.value = tb.Rows[k][0].ToString();
			lista.Add(ar);
		}

		return lista;
	}
	private void registrarScriptEquipo(Control c)
	{
		string query = @" <script type='text/javascript'>
		  jQuery(document).ready(function () {
			$('#" + c.ClientID + @"').autocomplete({
				source: function (request, response) {
					PageMethods.ObtEquipo(
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

	

	#region webmetod de modelo
	[System.Web.Services.WebMethod]
	[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
	public static List<AutoCompleteResult> ObtModelo(string term)
	{

		string sql = @"select top 5 rtrim(NombreModelo)+' ('+rtrim(Nombre_Fabricante)+')' from modelos
join fabricante  f on f.codFabricante = modelos.codFabricante
where NombreModelo like '%" + term + @"%' or  Nombre_Fabricante like '%" + term + @"%'";

		System.Data.DataTable tb = new System.Data.DataTable();
		SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
		obj.ejecutarConsulta(sql, tb);

		List<AutoCompleteResult> lista = new List<AutoCompleteResult>();

		for (int k = 0; tb != null && k < tb.Rows.Count; k++)
		{
			AutoCompleteResult ar = new AutoCompleteResult();
			ar.id = tb.Rows[k][0].ToString();
			ar.value = tb.Rows[k][0].ToString();
			lista.Add(ar);
		}

		return lista;
	}

	private void registrarScriptModelo(Control c)
	{
		string query = @" <script type='text/javascript'>
		  jQuery(document).ready(function () {
			$('#" + c.ClientID + @"').autocomplete({
				source: function (request, response) {
					PageMethods.ObtModelo(
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

	protected void Page_Load(object sender, EventArgs e)
	{
		clsSeguridad obj = new clsSeguridad();
		obj.comprobarAcceso(Page, Session, Response, 0);
		#region  registramos scripts y eventos onblur a los cuadros de texto
		registarScript();
		registrarScriptCliente(txtCliente);
		registrarScriptEquipo(txtSerial);
		registrarScriptModelo(txtModelo);
        string handler = ClientScript.GetPostBackEventReference(this.btnCliente, "");
        txtCliente.Attributes.Add("onblur", handler);
		//string handler2 = ClientScript.GetPostBackEventReference(this.btnModelo, "");
		//txtSerial.Attributes.Add("onblur", handler2);
#endregion
		//verficiamos los permisos para habilitar o deshabilitar el combo de responsable
		if (!IsPostBack)
		{
			string a = "";
			if (SPXSeguridad.verificadorPermisos.ejecutarAccion(2001, int.Parse(Session["ss_cod_usuario"].ToString()), ref a))
			{
				lblResponsable.Visible = true;
				cmbResponsable.Visible = true;
                cmbResponsable.DataBind();
                if (cmbResponsable.Items.Count <= 0)
                {
                    cmbResponsable.Items.Add(new ListItem(Session["ss_nombre_usuario"].ToString(), Session["ss_cod_usuario"].ToString()));
                }
				cmbResponsable.SelectedValue = Session["ss_cod_usuario"].ToString();
			}
		}

        if (Request.QueryString["cod"] != null && !IsPostBack)
        {
            #region cargamos la informacion de la tarea selecionada

            lblCodACtividad.Text = Request.QueryString["cod"].Replace("tarea|", "");
            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter tar = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            tar.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(Request.QueryString["cod"].Replace("tarea|", "")));
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            //cargamos el estado 
            objEstado.FillByCod_estado_tarea_calendario(ds.estado_tarea_calendario, ds.tarea_calendario[0].cod_estado_tarea_calendario);
            cmbEstado.DataBind();
            cmbEstado.SelectedValue = ds.estado_tarea_calendario[0].cod_estado_tarea_calendario.ToString();
            //tiene pendientes
            if (!ds.tarea_calendario[0].Istiene_pendientesNull())
                chkPendientes.Checked = ds.tarea_calendario[0].tiene_pendientes;

            rdInterna.Checked = ds.tarea_calendario[0].es_interna;
            rdExterna.Checked = !ds.tarea_calendario[0].es_interna;
            if (!ds.tarea_calendario[0].IsconsecutivoxtipoNull())
            {
                lblConsecutivo.Text = "Consecutivo x Tipo: " + ds.tarea_calendario[0].consecutivoxtipo.ToString();
            }
            //fecha de ciere
            if (!ds.tarea_calendario[0].Isfecha_cierreNull())
            {
                calCierre.SelectedDate = ds.tarea_calendario[0].fecha_cierre;
                calCierre.Visible = true;
                lblFechaCierre.Visible = true;
            }


            if (!ds.tarea_calendario[0].Iscod_tipo_tarea_calendarioNull())
            {
                cmbtipoActividad.DataBind();
                cmbtipoActividad.SelectedValue = ds.tarea_calendario[0].cod_tipo_tarea_calendario.ToString();
            }

            if (!ds.tarea_calendario[0].Iscod_subtipo_tarea_calendarioNull())
            {
                cmbSubtipoActividad.DataBind();
                cmbSubtipoActividad.SelectedValue = ds.tarea_calendario[0].cod_subtipo_tarea_calendario.ToString();
            }

            if (cmbResponsable.Visible)
            {
                
                //validamos que el valor que le va asignar este en el combo si no lo agregagamos
                bool contiene = false;
                cmbResponsable.DataBind();
                for (int k=0;k<cmbResponsable.Items.Count;k++ )
                {
                    if(cmbResponsable.Items[k].Value == ds.tarea_calendario[0].cod_usuario.ToString())
                    {
                       contiene=true;
                        break;
                    }
                }
                if (!contiene)
                {
                    string sql = "select nombre from usuario where cod_usuario =" + ds.tarea_calendario[0].cod_usuario.ToString();
                    SPXdata.BD.DataConector objBd = new SPXdata.BD.DataConector();
                    
                    cmbResponsable.Items.Add(new ListItem(objBd.ejecutarProcedimiento(sql).ToString(),ds.tarea_calendario[0].cod_usuario.ToString()));
                }

                cmbResponsable.SelectedValue = ds.tarea_calendario[0].cod_usuario.ToString();
            }



            if (!ds.tarea_calendario[0].Isrequiere_aprobacionNull())
            {
                chkRequiereAprobacion.Checked = ds.tarea_calendario[0].requiere_aprobacion;
            }

            //descripcion

            if (!ds.tarea_calendario[0].IsdescripcionNull())
                txtDescripcion.Text = ds.tarea_calendario[0].descripcion;



            if (!ds.tarea_calendario[0].Isatado_clienteNull() && !ds.tarea_calendario[0].Isnit_clienteNull())
            {
                chkAtadaCliente.Checked = ds.tarea_calendario[0].atado_cliente;
                txtCliente.Text = ds.tarea_calendario[0].nit_cliente.Trim();
                string sql = "select rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + txtCliente.Text + "'";

                System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
                txtCliente.Text = tb.Rows[0][0].ToString();
                cargarCliente();
                //--
                cmbSucursal.SelectedValue = ds.tarea_calendario[0].cod_sucursal;
                cmbContacto.SelectedValue = ds.tarea_calendario[0].cod_contacto;
            }

            if (!ds.tarea_calendario[0].IsserialNull())
            {
                List<string> l=new List<string>();
                l.Add(ds.tarea_calendario[0].serial.Trim());
                txtSerial.asignarCodigos(l);
                chkAtadaSerial.Checked = true;
            }
            SPControladoraDatos.dsSpxTableAdapters.modeloxtareaTableAdapter objModelos = new SPControladoraDatos.dsSpxTableAdapters.modeloxtareaTableAdapter();
            objModelos.FillByCod_tarea_calendario(ds.modeloxtarea, int.Parse(lblCodACtividad.Text));
            for (int k = 0; k < ds.modeloxtarea.Count; k++)
            {
                chkAtadaModelo.Checked = true;
                string sql = @"select rtrim(nombreModelo) +' ('+rtrim(nombre_Fabricante)+')'
from modelos join fabricante on fabricante.codFabricante = modelos.codFabricante
where 
fabricante.codFabricante ='" + ds.modeloxtarea[k].codFabricante.Trim() + "' and codModelo ='" + ds.modeloxtarea[k].codModelo.Trim() + "'";
                lblModelos.Text = "<li>" + bd.ejecutarProcedimiento(sql).ToString() + "<br>" + lblModelos.Text;
            }
            SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter objReactivo = new SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter();
            objReactivo.FillByCod_tarea_calendario(ds.reactivoxtarea, int.Parse(lblCodACtividad.Text));
            for (int k = 0; k < ds.reactivoxtarea.Count; k++)
            {
                chkAtadaReactivo.Checked = true;
                string sql = @"select 
'('+rtrim(nombre_Fabricante)+') ' + rtrim(codigo_manual)
from 
referencia_reactivo
join fabricante on fabricante.codFabricante = referencia_reactivo.codfabricante
where 
cod_referencia_reactivo='" + ds.reactivoxtarea[k].cod_referencia_reactivo.ToString() + "'";
                lblReactivo.Text = "<li>" + bd.ejecutarProcedimiento(sql).ToString() + "<br>" + lblReactivo.Text;
            }

            if (!ds.tarea_calendario[0].IsobservacionesNull())
                txtObservaciones.Text = ds.tarea_calendario[0].observaciones;

            //if (!ds.tarea_calendario[0].Isobservaciones_inicialesNull())
            //    txtObservacionesEjecucion.Text = ds.tarea_calendario[0].observaciones_iniciales;

            //if (!ds.tarea_calendario[0].Isobervaciones_aprobacionNull())
            //{
            //    txtObservacionesApobacion.Text = ds.tarea_calendario[0].obervaciones_aprobacion;
            //    lblObsAprobacion.Visible = true;
            //    txtObservacionesApobacion.Visible = true;
            //}

            if (!ds.tarea_calendario[0].IsfinNull())
                calFin.SelectedDate = ds.tarea_calendario[0].fin;

            if (!ds.tarea_calendario[0].IsinicioNull())
                calInicio.SelectedDate = ds.tarea_calendario[0].inicio;

            if (!ds.tarea_calendario[0].Isinicio_ejecucionNull())
                calEjecucion.SelectedDate = ds.tarea_calendario[0].inicio_ejecucion;

            if (!ds.tarea_calendario[0].Isfecha_cierreNull())
                calCierre.SelectedDate = ds.tarea_calendario[0].fecha_cierre;

            if (!ds.tarea_calendario[0].IsactivaNull())
                chkActiva.Checked = ds.tarea_calendario[0].activa;
           
     
            if (ds.tarea_calendario[0].IsaceptadaxusuarioNull())
            {
                if (ds.tarea_calendario[0].cod_usuario.ToString() == Session["ss_cod_usuario"].ToString())
                {
                    btnAceptadaxUsuario.Visible = true;
                    btnNoAceptar.Visible = true;
                }
            }
            else if (!ds.tarea_calendario[0].aceptadaxusuario)
            {
                lblTittuloAceptacion.Visible = true;
                if (ds.tarea_calendario[0].cod_usuario.ToString() == Session["ss_cod_usuario"].ToString())
                {
                    //btnQuitarModelo.Visible = false;
                    //btnAceptar.Visible = false;
                    btnAceptadaxUsuario.Visible = true;
                    //btnEjecutar.Visible = false;
                }

            }


            #endregion
            lblFechaCreacion.Text = "Tarea Creada " + ds.tarea_calendario[0].fecha_creacion.ToShortDateString() + " " + ds.tarea_calendario[0].fecha_creacion.ToShortTimeString();

            btnAprobar.Enabled = SPXSeguridad.verificadorPermisos.ejecutarAccion(2008);
            btnAprobar.Enabled = true;
            btnImprimir.Visible = true;
            lblEstado.Visible = true;
            cmbEstado.Visible = true;

            if (!ds.tarea_calendario[0].Isrequiere_aprobacionNull() && ds.tarea_calendario[0].requiere_aprobacion)
            {
                #region acciones cuando requiere aprobacion
                if (ds.tarea_calendario[0].IsaprobadaNull())
                {
                    btnAprobar.Visible = true;
                }
                else
                {
                    //si no fu aprobada es casi como si fuera anulada
                    if (!ds.tarea_calendario[0].aprobada)
                    {
                        #region si no es aprobada
                        chkActiva.Checked = false;
                        chkActiva.Enabled = false;
                        chkRequiereAprobacion.Enabled = false;
                        lblEstadoAprobacion.Text = "La actividad no fue aprobada!!!";
                        btnAnular.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2006);
                        btnAnular.Visible = true;
                        btnCambiarEstado.Visible = false;
                        btnEjecutar.Visible = false;
                        #endregion
                    }else{
                        #region si fue aprobada deja hacer todo
                        btnAnular.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2006);
                        btnAnular.Visible = true;
                        btnCambiarEstado.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2007);
                        btnCambiarEstado.Visible = true;
                        btnEjecutar.Visible = ds.tarea_calendario[0].cod_usuario.ToString().Trim() == Session["ss_cod_usuario"].ToString();
                        //--
                        chkRequiereAprobacion.Enabled = false;
                        lblEstadoAprobacion.Text = "La actividad fue aprobada!!!";
                        #endregion
                    }
                }
                #endregion
            }else{
                btnAnular.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2006);
                

                btnCambiarEstado.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2007);

                btnEjecutar.Visible = ds.tarea_calendario[0].cod_usuario.ToString().Trim() == Session["ss_cod_usuario"].ToString();
            }




          

            calEjecucion.Visible = false;
            ///si no tiene permiso de administrador no puede modificar el combo

            if (!ds.tarea_calendario[0].Isinicio_ejecucionNull())
            {
                calFinEjecucion.SelectedDate = ds.tarea_calendario[0].inicio_ejecucion;
                calFinEjecucion.Visible = true;
                calEjecucion.Visible = true;
                lblFechaEjecucion.Visible = true;
                lblFechaFinEjecucion.Visible = true;
            }
            #region ajusta visibilidad dependiendo los controles
            if (ds.estado_tarea_calendario[0].cod_manual == 1)//si es abierta puede editar toda la informacion
            {
                cmbtipoActividad.Enabled = false;
                cmbSubtipoActividad.Enabled = false;
            }

            if (ds.estado_tarea_calendario[0].cod_manual >= 2)//si esta en ejecucion no deja editar varios campos
            {
                #region

                rdInterna.Enabled = false;
                rdExterna.Enabled = false;
                chkActiva.Enabled = false;
                cmbResponsable.Enabled = false;
                cmbtipoActividad.Enabled = false;
                cmbSubtipoActividad.Enabled = false;
                chkAtadaCliente.Enabled = false;
                chkAtadaModelo.Enabled = false;
                chkAtadaSerial.Enabled = false;
                txtSerial.ReadOnly = true;
                txtModelo.ReadOnly = true;
                txtCliente.ReadOnly = true;
                cmbSucursal.Enabled = false;
                cmbContacto.Enabled = false;
                txtObservaciones.ReadOnly = true;
                #endregion
                chkRequiereAprobacion.Enabled = false;
                calCierre.Enabled = false;
                calEjecucion.Enabled = false;
                calInicio.Enabled = false;
                chkAtadaReactivo.Enabled = false;
                calFin.Enabled = false;
                btnAgregarModelo.Visible = false;
                btnAgregarReactivo.Visible = false;
                btnQuitarModelo.Visible = false;
                btnQuitarReactivo.Visible = false;
                txtModelo.Visible = false;
                cmbFabricanteReactivo.Visible = false;
                cmbReactivo.Visible = false;
                btnCargarContactos.Visible = false;
            }

            if (ds.estado_tarea_calendario[0].cod_manual == 3)//cerrada
            {
                txtSerial.ReadOnly = true;
                calCierre.Visible = true;
                lblFechaCierre.Visible = true;
                btnEjecutar.Visible = false;
                btnCambiarEstado.Visible = false;
            }
            if (ds.estado_tarea_calendario[0].cod_manual == 4)//cerrada temporal
            {
                txtSerial.ReadOnly = true;
                calCierre.Visible = true;
                lblFechaCierre.Visible = true;
                btnEjecutar.Visible = false;
                btnCambiarEstado.Visible = true;
            }
            if (ds.estado_tarea_calendario[0].cod_manual > 4)//anulada
            {
                txtSerial.ReadOnly = true;
                calCierre.Visible = true;
                lblFechaCierre.Visible = true;
                btnEjecutar.Visible = false;
                btnAceptar.Visible = false;
                btnCambiarEstado.Visible = false;
                btnEjecutar.Visible = false;
                btnAnular.Visible = true;
                btnAnular.OnClientClick = "";
                btnAnular.Text = "Informacion de anulacion!";
            }
            #endregion
        }
        else {
            btnDetalles.Visible = false;
        }

		#region ajustamos visibilidad de los controles segun los check
	
		if (chkAtadaCliente.Checked)
		{
			txtCliente.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
			cmbSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
			cmbContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
			lblSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
			lblContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            lnkNuevoContaco.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            btnCargarContactos.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
 
		}else{
			txtCliente.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
			cmbSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
			cmbContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
			lblSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
			lblContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            lnkNuevoContaco.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            btnCargarContactos.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
		}
		if (chkAtadaSerial.Checked)
		{
			txtSerial.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
		}else{
			txtSerial.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
		}
		if (chkAtadaModelo.Checked)
		{
			txtModelo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            lblModelos.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            btnAgregarModelo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            btnQuitarModelo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
		}else{
			txtModelo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            lblModelos.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            btnAgregarModelo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            btnQuitarModelo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
		}

        if (chkAtadaReactivo.Checked)
        {
            cmbReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            cmbFabricanteReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            btnAgregarReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            lblReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
            btnQuitarReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
        }else{
            cmbReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            cmbFabricanteReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            btnAgregarReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            lblReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
            btnQuitarReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
        }
#endregion
        //calVencimientoReactivo.Visible = chkAtadaReactivo.Checked;
        //calInicioReactivo.Visible = chkAtadaReactivo.Checked;
        //lblFechaInicioReactivo.Visible = chkAtadaReactivo.Checked;
        //lblFechaVencimientoReactivo.Visible = chkAtadaReactivo.Checked;
        //cmbFabricanteReactivo.Visible = chkAtadaReactivo.Checked;
        //cmbReactivo.Visible = chkAtadaReactivo.Checked;
        //lblLoteReactivo.Visible = chkAtadaReactivo.Checked;
        //txtLoteReactivo.Visible = chkAtadaReactivo.Checked;
        #region confirmamos los permisos
        if (btnAnular.Visible ) btnAnular.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2006);


        if (btnCambiarEstado.Visible) btnCambiarEstado.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(2007);
        if (cmbEstado.SelectedItem != null && (cmbEstado.SelectedItem.Text.Trim() == "Cerrada" )) btnAnular.Visible = false;

        
        #endregion

    }

	protected void btnCancelar_Click(object sender, EventArgs e)
	{
		Response.Redirect("calendar.aspx");
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

	protected void btnModelo_Click(object sender, EventArgs e)
	{
		cargarModelo();
	}

	private void cargarModelo()
	{
        //string serial = txtSerial.Text;
        ////sacarNit(txtCliente.Text);
        //if (txtSerial.Text.IndexOf('|') > 0)
        //{
        //    serial = serial.Substring(0, serial.IndexOf('|'));
        //}

        //string sql = "select top 1 rtrim( nombreModelo)+' ('+rtrim(nombreFabricante)+')' from dbo.vistaequipo where serial ='" + serial + "'";
        //SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        //System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        //if (tb.Rows.Count > 0)
        //{
        //    txtModelo.Text = tb.Rows[0][0].ToString();
        //    chkAtadaModelo.Checked=true;
        //    txtModelo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
        //}

	}

	private void cargarCliente(){
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
			sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
				where nitCliente ='" + nit + "' ";
            txtSerial.nitCliente = nit;
			cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
			cmbContacto.DataValueField = "codContacto";
			cmbContacto.DataTextField = "nombre";
			cmbContacto.DataBind();
            lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit="+nit;
		}
		else
		{
            txtSerial.nitCliente = "";
		}

	}

	private bool validar() 
	{
		if (txtDescripcion.Text.Trim() == string.Empty)
		{
			lblError.Text = "La descripcion es Obligatoria";
			return false;
		}

		if (cmbSubtipoActividad.SelectedValue == null || cmbSubtipoActividad.SelectedValue.ToString().Trim() == string.Empty)
		{
			lblError.Text = "El sub tipo de Actividad es obligatorio!";
			return false;
		}

		if (!calInicio.SelectedDate.HasValue)
		{
			lblError.Text = "La fecha de inicio es obligatoria!";
			return false;
		}

		if (!calFin.SelectedDate.HasValue)
		{
			lblError.Text = "La fecha de fin es obligatoria!";
			return false;
		}

		if (calFin.SelectedDate.Value< calInicio.SelectedDate.Value)
		{
			lblError.Text = "La fecha de fin no puede ser menor que la fecha de inicio!";
			return false;
		}
	  
		if (chkAtadaCliente.Checked && txtCliente.Text.Trim() == string.Empty)
		{
			lblError.Text = "Si esta atada a un cliente debe especificar el Cliente!";
			return false;
		}

		if (chkAtadaCliente.Checked && (cmbSucursal.SelectedValue== null || cmbSucursal.SelectedValue == string.Empty))
		{
			lblError.Text = "Si esta atada a un cliente debe especificar la sucursal!";
			return false;
		}

		if (chkAtadaCliente.Checked && (cmbContacto.SelectedValue == null || cmbContacto.SelectedValue == string.Empty))
		{
			lblError.Text = "Si esta atada a un cliente debe especificar el Contacto!";
			return false;
		}

	 

		if (chkAtadaSerial.Checked && txtSerial.verCodigos().Count == 0)
		{
			lblError.Text = "Si esta atada a un serial debe especificar un serial valido!";
			return false;
		}

		if (chkAtadaSerial.Checked && !validarSerial())
		{
			lblError.Text = "El serial especificado no es valido!";
			return false;
		}

        if (chkAtadaModelo.Checked && lblModelos.Text.Replace("<li>", "").Replace("</li>", "").Trim() == string.Empty)
		{
			lblError.Text = "Si esta atada a un modelo debe especificar el modelo!";
			return false;
		}

		if (chkAtadaCliente.Checked && chkAtadaSerial.Checked)
		{
			if (!validarSerialCliente())
			{
				lblError.Text = "El serial seleccionado no esta relacionado con el cliente seleccionado!";
				return false;
			}
		}

        //if (chkAtadaReactivo.Checked && (cmbReactivo.SelectedValue == null || cmbReactivo.SelectedValue.Trim() == string.Empty))
        //{
        //    lblError.Text = "El reactivo es obligatorio!";
        //    return false;
        //}

        if (chkAtadaReactivo.Checked && lblReactivo.Text.Replace("<li>","").Replace("</li>","").Trim() == string.Empty)
        {
            lblError.Text = "El reactivo es obligatorio!";
            return false;
        }
        if (calInicio.SelectedDate > calFin.SelectedDate)
        {

            lblError.Text = "La fecha final no puede ser menor que la fecha de inicio";
            return false;
        }
        //esta validacion debe estar de ultimas
        string mensaje = "Esta creando una actividad para una fecha anterior esta seguro?";
        if (calInicio.SelectedDate.HasValue && calInicio.SelectedDate.Value < DateTime.Now && lblError.Text!= mensaje)
        {
            lblError.Text = mensaje;
            return false;

        }

		return true;
	}

	private bool validarSerialCliente()
	{
        string serial = "";
        if (txtSerial.verCodigos().Count>0)
        serial=txtSerial.verCodigos()[0];
		string nit = sacarNit(txtCliente.Text);
		if (serial.IndexOf("|") > 0)
		{
			serial = serial.Substring(0, serial.IndexOf("|"));
		}
		string sql = "select count(*) from equipos where serial = '" + serial.Trim() + "' and nitClienteUbica ='"+nit.Trim()+"' ";
		SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
		int a = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
		return (a > 0);
	}

	private bool validarSerial()
	{
        string serial = "";
        if (txtSerial.verCodigos().Count > 0)
            serial = txtSerial.verCodigos()[0];
		if (serial.IndexOf("|") > 0)
		{
			serial = serial.Substring(0, serial.IndexOf("|"));
		}
		string sql = "select count(*) from equipos where serial = '"+serial+"'";
		SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
		int a = int.Parse( bd.ejecutarProcedimiento(sql).ToString() );
		return (a > 0);
	}

	private bool validarModelo()
	{
		string modelo = txtModelo.Text;
		if (modelo.LastIndexOf("(") > 0)
		{
			modelo = modelo.Substring(0, modelo.LastIndexOf("("));
		}
		string sql = "select count(*) from modelos where nombreModelo = '" + modelo + "'";
		SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
		int a = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
		return (a > 0);
	}


	protected void btnAceptar_Click(object sender, EventArgs e)
	{
        
		Aceptar(false);
	}

	protected void Aceptar(bool omitirConflictos){
		if (!validar()) return;
		DateTime ini= calInicio.SelectedDate.Value;
		DateTime fin= calFin.SelectedDate.Value;  
        SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
		//validamos la concurrencia de actividades	
        int res = 0;
		if (cmbResponsable.Visible)
			res = int.Parse(cmbResponsable.SelectedValue);
		else 
			res=int.Parse(Session["ss_cod_usuario"].ToString());
		if (Request.QueryString["cod"] == null)
		{
			#region zona de nuevo registro
			
			string sql = @"set dateformat ymd
declare @f1 as datetime
declare @f2 as datetime
set @f1 = '" + ini.Year + "-" + ini.Month.ToString().PadLeft(2, '0') + "-" + ini.Day.ToString().PadLeft(2, '0') + " " + ini.Hour.ToString().PadLeft(2, '0') + ":" + ini.Minute.ToString().PadLeft(2, '0') + ":00 " + @"'
set @f2 = '" + fin.Year + "-" + fin.Month.ToString().PadLeft(2, '0') + "-" + fin.Day.ToString().PadLeft(2, '0') + " " + fin.Hour.ToString().PadLeft(2, '0') + ":" + fin.Minute.ToString().PadLeft(2, '0') + ":00 " + @"'
select cod_tarea_calendario
from tarea_calendario
where cod_usuario=" + res + @"
and 
(inicio between @f1 and @f2
 or
 @f1 between inicio and fin
 or
 @f2 between inicio and fin
 )";

			System.Data.DataTable tb = objData.ejecutarConsulta(sql).Tables[0];
			if (!omitirConflictos && tb.Rows.Count > 0)
			{
				lblError.Text = "Tiene un Conflicto con <a target='_blank' href='frmNewTask.aspx?cod=" + tb.Rows[0][0].ToString() + "' >otra actividad</a> para la misma fecha";
				// btnAceptar.Visible = false;
				btnAceptarConConflicto.Visible = true;
				return;
			}
			#endregion
		}
			
      
		SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
		SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
	
		
		decimal valorTiquetes=0;
		string modelo = null;
		string fabricante = null;
		string serial = null;
		
		#region cargamos el serial
		if (chkAtadaSerial.Checked)
		{
            serial = "" ;
            if (txtSerial.verCodigos().Count > 0)
            {
               serial= txtSerial.verCodigos()[0];
            }
			if (serial.IndexOf("|") > 0)
			{
				serial = serial.Substring(0, serial.IndexOf("|"));
			}
			string sql = "select codFabricante,codModelo  from equipos where serial = '"+serial+"'";
			SPXdata.BD.DataConector data = new SPXdata.BD.DataConector();
			System.Data.DataTable tb= data.ejecutarConsulta(sql).Tables[0];
			modelo = tb.Rows[0][1].ToString();
			fabricante = tb.Rows[0][0].ToString();
		}else if (chkAtadaModelo.Checked)
		{
//            string sql = @"select top 1 fabricante.codFabricante,codModelo from modelos
//join fabricante on fabricante.codFabricante = modelos.codFabricante
//where rtrim(nombreModelo) +' ('+rtrim(nombre_Fabricante)+')' = '" + txtModelo.Text+ "'";
//            SPXdata.BD.DataConector data = new SPXdata.BD.DataConector();
//            System.Data.DataTable tb = data.ejecutarConsulta(sql).Tables[0];
//            modelo = tb.Rows[0][1].ToString();
//            fabricante = tb.Rows[0][0].ToString();
		}
		#endregion


		if (Request.QueryString["cod"] == null)
        {
            #region zona de insercion
            
            //cargamos el estado
			SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado=new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
			objEstado.FillByCod_manual(ds.estado_tarea_calendario,1);
			//cargamos el consecutivo, no olvidar que no se debe pemitir cambiar el tipo
			//de actividad ya que el consecutivo se veria afectado

			int consecutivo= obj.verConsecutivoxTipo(int.Parse(cmbtipoActividad.SelectedValue)).Value;


			obj.Insert(int.Parse(Session["ss_cod_usuario"].ToString()), DateTime.Now, res,
txtDescripcion.Text,txtObservaciones.Text,calInicio.SelectedDate,calFin.SelectedDate,
chkActiva.Checked,int.Parse(cmbtipoActividad.SelectedValue),chkRequiereAprobacion.Checked,
false,valorTiquetes, chkAtadaCliente.Checked,
				(!chkAtadaCliente.Checked)?null:sacarNit(txtCliente.Text),
				(!chkAtadaCliente.Checked) ? null : cmbSucursal.SelectedValue,
				(!chkAtadaCliente.Checked) ? null : cmbContacto.SelectedValue,
			   int.Parse(cmbSubtipoActividad.SelectedValue),"",null,null,null,
			   ds.estado_tarea_calendario[0].cod_estado_tarea_calendario,
			   consecutivo,"",null,null,null,null,
			   fabricante,modelo,serial,
			   false,null,"",rdInterna.Checked,
			   (chkAtadaReactivo.Checked)?int.Parse(cmbReactivo.SelectedValue):(int?)null,
			   "",
			   (DateTime?)null,
			   (DateTime?)null,
               null, "", (res.ToString().Trim() == Session["ss_cod_usuario"].ToString()) ? true : (bool?)null
			   ,"",null,null,null);

            decimal? id = obj.verIdentity();
            if (!id.HasValue)
            {
                id = obj.verIdentityManual(int.Parse(Session["ss_cod_usuario"].ToString()));
            }

            lblCodACtividad.Text = id.Value.ToString();
			try
			{
				string sql = "select isnull(correo,'') from dbo.usuario where cod_usuario="+res;
				SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
				string em=bd.ejecutarProcedimiento(sql).ToString();
				clsSeguridad email = new clsSeguridad();
                sql = @"select 
rtrim(d.NombreDepartamento)+' ('+ rtrim( c.nombreCiudad)+')'
 from sucursalCliente
 join departamentos d on d.codPais = sucursalCliente.codPais
 and  d.codDepartamento = sucursalCliente.codDepartamento
 
 join ciudades c on c.codPais = sucursalCliente.codPais
 and  c.codDepartamento = sucursalCliente.codDepartamento
 and  c.codCiudad = sucursalCliente.codCiudad

 where sucursalCliente.nitCliente ='" + ((!chkAtadaCliente.Checked) ? "" : sacarNit(txtCliente.Text)) + @"' and
 sucursalCliente.codSucursal ='" + ((!chkAtadaCliente.Checked) ? "" : cmbSucursal.SelectedValue )+ "'";
                string cuerpo = txtObservaciones.Text;

                if (chkAtadaCliente.Checked)
                {
                    cuerpo = cuerpo + "<br>Cliente:" + txtCliente.Text + "<br>Ciudad: " + bd.ejecutarProcedimiento(sql).ToString();
                }
                email.enviarCalendario("Nueva Tarea Asignada", "" + txtCliente.Text, cuerpo, calInicio.SelectedDate.Value, calFin.SelectedDate.Value,
					Server.MapPath("~/temp/"), em);
			}catch(Exception){

            }
            #endregion
        }
        else{
            //al actualizar no deberia actualizar todos los campos
            #region zona de update  
            
            obj.UpdateQuery(txtDescripcion.Text, txtObservaciones.Text, calInicio.SelectedDate,
				calFin.SelectedDate, chkActiva.Checked, int.Parse(cmbtipoActividad.SelectedValue),
				chkRequiereAprobacion.Checked, false, chkAtadaCliente.Checked,
				(txtCliente.Text == string.Empty) ? null : sacarNit(txtCliente.Text),
				(txtCliente.Text == string.Empty) ? null : cmbSucursal.SelectedValue,
				(txtCliente.Text == string.Empty) ? null : cmbContacto.SelectedValue,
				int.Parse(cmbSubtipoActividad.SelectedValue),
				  null, null, serial, rdInterna.Checked,
				 null,
			   "",(DateTime?)null,
			   (DateTime?)null,
			   null,"",int.Parse(Request.QueryString["cod"].ToString().Split('|')[1].ToString())
			);
            obj.UpdateUsuario(res,int.Parse(Request.QueryString["cod"].ToString().Split('|')[1].ToString()));
            #endregion
        }
        SPControladoraDatos.dsSpxTableAdapters.modeloxtareaTableAdapter objModelo = new SPControladoraDatos.dsSpxTableAdapters.modeloxtareaTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter objReactivo = new SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter();
        objReactivo.DeleteByTarea(int.Parse(lblCodACtividad.Text));
        objModelo.DeleteByCodTareaCalendario(int.Parse(lblCodACtividad.Text));
        //--
        #region modelos
        
        string[] modelos = lblModelos.Text.Replace("<br>", "").Replace("<li>", "~").Split('~');
        for (int k = 0; k < modelos.Length; k++)
        {
            if (modelos[k].Trim() == string.Empty) continue;
            string sql = @"select fabricante.codFabricante,codModelo from modelos
join fabricante on fabricante.codFabricante = modelos.codFabricante
where 
rtrim(nombreModelo) +' ('+rtrim(nombre_Fabricante)+')'
= '"+modelos[k]+"'";
            System.Data.DataTable tb= objData.ejecutarConsulta(sql).Tables[0];
            string codF = tb.Rows[0][0].ToString(), codM = tb.Rows[0][1].ToString();
            objModelo.Insert(int.Parse(lblCodACtividad.Text), codF, codM, 1);
        }
#endregion
#region reactivos
        string[] reactivos = lblReactivo.Text.Replace("<br>", "").Replace("<li>", "~").Split('~');
        for (int k = 0; k < reactivos.Length; k++)
        {
            if (reactivos[k].Trim() == string.Empty) continue;
            string sql = @"select TOP 1 cod_referencia_reactivo 
from 
referencia_reactivo
join fabricante on fabricante.codfabricante = referencia_reactivo.codfabricante
where 
'('+rtrim(nombre_Fabricante)+') '+rtrim(codigo_manual)= '" + reactivos[k] + "'";
            int cr= int.Parse(objData.ejecutarProcedimiento(sql).ToString());
            
            objReactivo.Insert(int.Parse(lblCodACtividad.Text),cr,1,"",null,null);
        }
#endregion
        

            //SPControladoraDatos.dsSpxTableAdapters.ModeloTableAdapter 
            Response.Redirect("calendar.aspx");
	}

	protected void btnAceptarConConflicto_Click(object sender, EventArgs e)
	{
		Aceptar(true);
	}

	protected void btnImprimir_Click(object sender, EventArgs e)
	{
		Response.Redirect("frmImprimir.aspx?os=" + lblCodACtividad.Text);
	}

	protected void btnAnular_Click(object sender, EventArgs e)
	{
        string cod = "";
        if (Request.QueryString["cod"].IndexOf("|") > 0)
        {
            cod = Request.QueryString["cod"].Split('|')[1];
        }else {
            cod = Request.QueryString["cod"];
        }


        

		Response.Redirect("frmAnularTarea.aspx?cod=" + cod);
	}

	protected void btnCambiarEstado_Click(object sender, EventArgs e)
	{

		Response.Redirect("frmCerrarActividad.aspx?cod=" + Request.QueryString["cod"].ToString().Split('|')[1].ToString());
   
	}

	protected void btnAprobar_Click(object sender, EventArgs e)
	{
		Response.Redirect("frmAprobarActividad.aspx?cod=" + Request.QueryString["cod"].ToString().Split('|')[1].ToString());
	}

	protected void btnEjecutar_Click(object sender, EventArgs e)
	{
		Response.Redirect("frmEjectarTarea.aspx?cod=" + Request.QueryString["cod"].ToString().Split('|')[1].ToString());
	}

    protected void btnAgregarModelo_Click(object sender, ImageClickEventArgs e)
    {
        if( txtModelo.Text.Trim() == string.Empty  )
        {
            lblError.Text = "El modelo esta en blanco!";
            return;
        }

        if(!validarModelo() ){
            lblError.Text = "El modelo no es valido!";
            return;
        }

        if (lblModelos.Text.IndexOf(txtModelo.Text)<0)
        {
            lblModelos.Text = "<br><li>" + txtModelo.Text+""+lblModelos.Text;
            txtModelo.Text = "";
        }else{
            lblError.Text = "El modelo fue agregado previamente!";
        }
    }

    protected void btnAgregarReactivo_Click(object sender, ImageClickEventArgs e)
    {
        if(cmbReactivo.SelectedValue == null || cmbReactivo.SelectedValue == string.Empty )
        {
            lblError.Text = "Seleccione un reactivo valido!";
            return;
        }

        string it="(" +cmbFabricanteReactivo.SelectedItem.Text.Trim()+") "+ cmbReactivo.SelectedItem.Text.Trim();
        if (lblReactivo.Text.IndexOf(it) > 0 )
        {
            lblError.Text = "El reactivo ya fue agregado!";
            return;
        }else{
            lblReactivo.Text = "<br><li>"+it+lblReactivo.Text;
            cmbReactivo.SelectedIndex = -1;
        }
    }

    protected void btnQuitarModelo_Click(object sender, ImageClickEventArgs e)
    {
        lblModelos.Text = "";
    }

    protected void btnQuitarReactivo_Click(object sender, ImageClickEventArgs e)
    {
        lblReactivo.Text = "";
    }

    protected void btnAceptadaxUsuario_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        obj.UpdateAceptadaxusuario(true, int.Parse(lblCodACtividad.Text));
        btnAceptadaxUsuario.Visible = false;
        btnNoAceptar.Visible = false;
        lblTittuloAceptacion.Visible = false;
        //
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        obj.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(lblCodACtividad.Text));
        SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
        string sql = "select correo from usuario where cod_usuario ="+ds.tarea_calendario[0].cod_creador;
        string email=objData.ejecutarProcedimiento(sql).ToString();
        obj.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(lblCodACtividad.Text));
        clsSeguridad utils = new clsSeguridad();
        utils.enviarEmail("Tarea " + lblCodACtividad.Text + " Aceptada!", "El usuario " + Session["ss_nombre_usuario"].ToString().Trim() + " acepto la tarea.<br>" + txtDescripcion.Text, email);        
    }

    protected void btnNoAceptar_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        obj.UpdateAceptadaxusuario(false, int.Parse(lblCodACtividad.Text));
        btnAceptadaxUsuario.Visible = false;
        btnNoAceptar.Visible = false;
        lblTittuloAceptacion.Visible = true;
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        obj.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(lblCodACtividad.Text));
        SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
        string sql = "select correo from usuario where cod_usuario =" + ds.tarea_calendario[0].cod_creador;
        string email = objData.ejecutarProcedimiento(sql).ToString();
        obj.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(lblCodACtividad.Text));
        clsSeguridad utils = new clsSeguridad();
        utils.enviarEmail("Tarea " + lblCodACtividad.Text + " rechazada!", "El usuario " + Session["ss_nombre_usuario"].ToString().Trim() + " rechazo la tarea.<br>" + txtDescripcion.Text, email);
        
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

   
    protected void btnDetalles_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetallesTarea.aspx?cod=" + Request.QueryString["cod"].ToString().Split('|')[1].ToString());
   
    }
}
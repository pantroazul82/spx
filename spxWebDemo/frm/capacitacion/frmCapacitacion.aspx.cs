using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmCapacitacion : System.Web.UI.Page
{
    public string verTexto(object usuario)
    {
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objAsistentexSesion = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        objAsistentexSesion.FillByAceptadaUsuario(ds.asistentexsession, int.Parse(lblCod.Text), int.Parse(usuario.ToString()));
        if (ds.asistentexsession.Count > 0 )
        {
            return " "+ds.asistentexsession.Count+" Clases programadas!";
        }else{
            return "";
        }
    }

	System.Data.DataTable validarModelo()
	{
	string sql=@"select codModelo,f.codFabricante 
 from modelos
join fabricante f on f.codFabricante = modelos.codFabricante
where 
rtrim(nombreModelo)+' ('+rtrim(nombre_Fabricante)+')' ='"+txtModelo.Text+"'";
		SPXdata.BD.DataConector bd=new SPXdata.BD.DataConector();
		return bd.ejecutarConsulta(sql).Tables[0];
}

	System.Data.DataTable validarReactivo()
	{
		string sql = @"select cod_referencia_reactivo  from referencia_reactivo 
join fabricante f on f.codFabricante = referencia_reactivo.codFabricante
where
rtrim(nombre_referencia_reactivo)+' ('+rtrim(nombre_Fabricante)+')' ='"+txtReactivo.Text.Trim()+"'";
		SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
		return bd.ejecutarConsulta(sql).Tables[0];
	}

	public class AutoCompleteResult
	{
		public string id { get; set; }
		public string value { get; set; }
	}

	[System.Web.Services.WebMethod]
	[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
	public static List<AutoCompleteResult> ObtModelos(string term)
	{

		string sql = @"select top 5 rtrim(nombreModelo)+' ('+rtrim(nombre_Fabricante)+')'
 from modelos
join fabricante f on f.codFabricante = modelos.codFabricante
where 
nombreModelo like '%" + term + @"%'  or nombre_Fabricante like '%" + term + @"%'";

		System.Data.DataTable tb = new System.Data.DataTable();
		SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
		obj.ejecutarConsulta(sql, tb);
	
		List<AutoCompleteResult> lista = new List<AutoCompleteResult>();

		for (int k = 0; k < tb.Rows.Count; k++)
		{
			AutoCompleteResult ar = new AutoCompleteResult();
			ar.id = tb.Rows[k][0].ToString();
			ar.value = tb.Rows[k][0].ToString();
			lista.Add(ar);
		}

		return lista;
	}

	private void registrarScriptModelos(Control c)
	{
		string query = @" <script type='text/javascript'>
		  jQuery(document).ready(function () {
			$('#" + c.ClientID + @"').autocomplete({
				source: function (request, response) {
					PageMethods.ObtModelos(
			request.term,
			function (data) {
				var modelo = (typeof data) == 'string' ? eval('(' + data + ')') : data;
				response(modelo);
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

	[System.Web.Services.WebMethod]
	[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
	public static List<AutoCompleteResult> ObtReactivos(string term)
	{

		string sql = @"select top 5 rtrim(nombre_referencia_reactivo)+' ('+rtrim(nombre_Fabricante)+')' from referencia_reactivo 
join fabricante f on f.codFabricante = referencia_reactivo.codFabricante where
nombre_referencia_reactivo like '%" + term + @"%'  or nombre_Fabricante like '%" + term + @"%'";

		System.Data.DataTable tb = new System.Data.DataTable();
		SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
		obj.ejecutarConsulta(sql, tb);

		List<AutoCompleteResult> lista = new List<AutoCompleteResult>();

		for (int k = 0; k < tb.Rows.Count; k++)
		{
			AutoCompleteResult ar = new AutoCompleteResult();
			ar.id = tb.Rows[k][0].ToString();
			ar.value = tb.Rows[k][0].ToString();
			lista.Add(ar);
		}

		return lista;
	}

	private void registrarScriptReactivos(Control c)
	{
		string query = @" <script type='text/javascript'>
		  jQuery(document).ready(function () {
			$('#" + c.ClientID + @"').autocomplete({
				source: function (request, response) {
					PageMethods.ObtReactivos(
			request.term,
			function (data) {
				var modelo = (typeof data) == 'string' ? eval('(' + data + ')') : data;
				response(modelo);
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

    private void estadoControles(int estado)
    {
        if (estado == 1)//programada
        {
            cmbDictadaPor.Enabled = false;
            cmbInscrito.Enabled = false;
            
            txtModelo.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtotro.ReadOnly = true;
            txtReactivo.ReadOnly = true;
           
        }
    }

	protected void Page_Load(object sender, EventArgs e)
	{
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 2011);
		registrarScriptModelos(txtModelo);
		registrarScriptReactivos(txtReactivo);

		if (Request.Params["cod"] != null && !IsPostBack)
		{
			btnCambiarDeEstado.Visible = true;
			lblCod.Text = Request.Params["cod"];
			SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objC = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
			SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
			objC.FillBycod_capacitacion(ds.capacitacion, int.Parse(Request.Params["cod"]));

			txtNombre.Text = ds.capacitacion[0].nombre;
			if (ds.capacitacion[0].Isdictada_por_otroNull())
			{
				txtotro.Text = ds.capacitacion[0].dictada_por_otro.Trim();
                cmbDictadaPor.DataBind();
                cmbDictadaPor_PreRender(sender, e);
				cmbDictadaPor.SelectedValue = "OTRO";
			}else if (!ds.capacitacion[0].Isdictada_porNull())
			{
                cmbDictadaPor.DataBind();
                cmbDictadaPor_PreRender(sender, e);
				cmbDictadaPor.SelectedValue = ds.capacitacion[0].dictada_por.ToString();
			}
			txtObservaciones.Text = ds.capacitacion[0].descripcion;
			calInicio.SelectedDate = ds.capacitacion[0].fecha_inicio;
			calFin.SelectedDate = ds.capacitacion[0].fecha_fin;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            if (!ds.capacitacion[0].Iscod_modeloNull())
            {
                
                string sql = @"select top 1 rtrim(nombreModelo)+' ('+rtrim(nombre_Fabricante)+')'
 from modelos
join fabricante f on f.codFabricante = modelos.codFabricante
where modelos.codModelo ='"+ds.capacitacion[0].cod_modelo.Trim()  +@"' and f.codFabricante ='"+ds.capacitacion[0].cod_fabricante.Trim()+"'";
                txtModelo.Text = bd.ejecutarProcedimiento(sql).ToString().Trim();
            }

            if (!ds.capacitacion[0].Iscod_referencia_reactivoNull())
            {

                string sql = @"select top 1 rtrim(nombre_referencia_reactivo)+' ('+rtrim(nombre_Fabricante)+')' from referencia_reactivo 
join fabricante f on f.codFabricante = referencia_reactivo.codFabricante where referencia_reactivo.cod_referencia_reactivo ='"+ds.capacitacion[0].cod_referencia_reactivo+"'";

                txtReactivo.Text = bd.ejecutarProcedimiento(sql).ToString().Trim();
            }
            habilitarControles();
		}
	}

	private bool validar() 
	{
		lblError.Text = "";
		if (txtNombre.Text.Trim() == string.Empty)
		{
			lblError.Text = "El tema es obligatorio!";
			return false;
		}

		if ( !calInicio.SelectedDate.HasValue)
		{
			lblError.Text = "La fecha de inicio es obligatoria!";
			return false;
		}

		if (!calFin.SelectedDate.HasValue)
		{
			lblError.Text = "La fecha de fin es obligatoria!";
			return false;
		}

		if (txtModelo.Text != string.Empty)
		{
			if (validarModelo().Rows.Count <= 0)
			{
				lblError.Text = "El modelo ingresado no es valido!";
				return false;
			}
		}

		if (txtReactivo.Text != string.Empty)
		{
			if (validarReactivo().Rows.Count <= 0)
			{
				lblError.Text = "El reactivo ingresado no es valido!";
				return false;
			}
		}

		if (cmbDictadaPor.SelectedValue == "N/A" )
		{
			lblError.Text = "Debe especificar quien dicta la capacitacion, si son varios debe seleccionar el principal.";
			return false;
		}

		if (cmbDictadaPor.SelectedValue == "OTRO" && txtotro.Text.Trim() == string.Empty)
		{
				lblError.Text = "Debe especificar quien dicta la capacitacion, si es otro debe digitar el expositor.";
				return false;
		}
        

		return true;
	}

	protected void btnAceptar_Click(object sender, EventArgs e)
	{
		if (!validar()) return;
		lblErrorClases.Text = "";
		lblErrorIntegrante.Text = "";
		string modelo=null;
		string fabricante = null;
		if (txtModelo.Text != string.Empty)
		{ 
			System.Data.DataTable tb= validarModelo();
			modelo = tb.Rows[0]["codModelo"].ToString();
			fabricante = tb.Rows[0]["codFabricante"].ToString();
		}
		
		int? codReactivo=null;
		if (txtReactivo.Text.Trim() != string.Empty)
		{ 
		 codReactivo = int.Parse( validarReactivo().Rows[0][0].ToString() );
		}
		int? dictadaPor=null;
		if (cmbDictadaPor.SelectedValue != "N/A" && cmbDictadaPor.SelectedValue != "OTRO")
		{
			dictadaPor = int.Parse( cmbDictadaPor.SelectedValue.ToString() );
		}
		SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objCapacitacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
			  SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();
			SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
		if (lblCod.Text.Trim() != string.Empty)
		{
			objCapacitacion.UpdateQuery(txtNombre.Text,
				txtObservaciones.Text, calInicio.SelectedDate.Value,
				calFin.SelectedDate.Value,
				modelo, fabricante, codReactivo,
                dictadaPor, txtotro.Text, int.Parse(lblCod.Text.Trim())
				);

		}else{   
			objEstado.FillByCod_estado_capacitacion(ds.estado_capacitacion, 1);
            
			if (ds.estado_capacitacion.Count <= 0)
			{
				lblError.Text = "No tiene parametrizado correctamente los estados!!!";
			}
			objCapacitacion.Insert(txtNombre.Text, txtObservaciones.Text,
				calInicio.SelectedDate.Value, calFin.SelectedDate.Value,
				modelo, fabricante, codReactivo, dictadaPor, ds.estado_capacitacion[0].cod_estado_capacitacion,txtotro.Text);
			lblCod.Text = objCapacitacion.verIdentity().Value.ToString();
			lblTituloEstado.Visible = true;
			lblNombreEstado.Visible = true;
			lblNombreEstado.Text = ds.estado_capacitacion[0].descripcion;

		}
		
		//Response.Redirect("frmListadoCapacitaciones.aspx");
		}

	protected void cmbDictadaPor_PreRender(object sender, EventArgs e)
	{
		ListItem it = new ListItem("N/A", "N/A");
		ListItem it2 = new ListItem("Otro", "OTRO");
		
		if(!IsPostBack && !cmbDictadaPor.Items.Contains(it))
		{
			cmbDictadaPor.Items.Add(it);
			cmbDictadaPor.Items.Add(it2);
			cmbDictadaPor.SelectedValue = "N/A";
		}
	}

	protected void btnCancelar_Click(object sender, EventArgs e)
	{
		Response.Redirect("frmListadoCapacitaciones.aspx");
	}

	protected void btnAgregarClase_Click(object sender, EventArgs e)
	{
		lblErrorClases.Text = "";
		if (lblCod.Text.Trim() == string.Empty)
		{
			lblErrorClases.Text = "<br/>Primero debe guardar el encabezado!!!";
			return;
		}
		if (!calClaseIni.SelectedDate.HasValue)
		{
			lblErrorClases.Text = "<br/>La fecha de inicio es obligatoria!!!";
			return;
		}
		if (!calClaseFin.SelectedDate.HasValue)
		{
			lblErrorClases.Text = "<br/>El fin de la clase es obligatoria!!!";
			return;
		}
		if (calClaseFin.SelectedDate.Value < calClaseIni.SelectedDate.Value)
		{
			lblErrorClases.Text = "<br/>El fin de la clase no puede ser antes que el inicio!!!";
			return;
		}

		if (calClaseIni.SelectedDate.Value < calInicio.SelectedDate.Value || calClaseFin.SelectedDate.Value > calFin.SelectedDate.Value.AddDays(1))
		{
			lblErrorClases.Text = "<br/>El Inicio de la clase debe estar entra la fecha de inicio y fin";
			return;
		}
        //valida las clases de todos los que estan inscritos
        if (linkConflicto.Text == string.Empty)
        {
            DateTime ini=calClaseIni.SelectedDate.Value;
            DateTime fin= calClaseFin.SelectedDate.Value;
            clsSeguridad sg = new clsSeguridad();
            for (int k = 0; k < grdIntegrante.Items.Count; k++)
            {
                string cod = ((ImageButton)grdIntegrante.Items[k].FindControl("btnQuitarInscrito")).ValidationGroup;

                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                string sql = "select nombre from usuario where cod_usuario="+cod;
                string name = bd.ejecutarProcedimiento(sql).ToString().Trim();

                string codTarea=sg.validarCalendario( int.Parse(cod),ini,fin);

               if (codTarea !="") 
               {
                   CGWebUtils.utils.misc.messageBox(Page, "Actividad en Conflicto para "+name+", si presiona guardar nuevamente se guardara con conflicto");
                   lblConflicto.Text = "1";
                   linkConflicto.Target = "_Blank";
                   linkConflicto.Visible = true;
                   linkConflicto.Text = "Actividad en Conflicto para " + name + ", si presiona guardar nuevamente se guardara con conflicto";
                   linkConflicto.NavigateUrl = sg.resolverLinkTarea(codTarea);
                   return;
               }
            }
        }
        linkConflicto.Text = string.Empty;
        linkConflicto.Visible = false;
		SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter s = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
		s.Insert(int.Parse(lblCod.Text), calClaseIni.SelectedDate.Value, calClaseFin.SelectedDate.Value,false,"");
		grdClases.DataBind();
	
	}

    public bool vervisible()
    {
        return cmbInscrito.Visible;
    }
        
	protected void btnCambiarDeEstado_Click(object sender, EventArgs e)
	{
		//check for class must have one or more users
		SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
		SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();
	  
		SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
		obj.FillBycod_capacitacion(ds.capacitacion, int.Parse(lblCod.Text));

		
		if (ds.capacitacion[0].cod_estado_capacitacion == 1)
        {
            #region cambia de borrador a programada
			objEstado.FillByorden(ds.estado_capacitacion, 2);
			obj.UpdateEstado(ds.estado_capacitacion[0].cod_estado_capacitacion, int.Parse(lblCod.Text));
			//
            estadoControles(1);
			SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter objAsistente = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
			SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSession = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
			SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter objDetalle = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
            SPXSeguridad.data.dsSPXSeguridad dsSeguridad=new SPXSeguridad.data.dsSPXSeguridad();
            dsSeguridad.EnforceConstraints = false;
            SPXSeguridad.data.cls.clsTusuario objusuario=new SPXSeguridad.data.cls.clsTusuario();
            clsSeguridad objUtils = new clsSeguridad();
            objAsistente.FillBycod_capacitacion(ds.asistente_capacitacion, int.Parse(lblCod.Text));
			objSession.FillByCod_capacitacion(ds.session_capacitacion, int.Parse( lblCod.Text ));
            string asunto="Invitacion a Capacitacion "+txtNombre.Text;
            string cupero = "Ha sido invitado(a) a la capacitacion "+txtNombre.Text+" que va desde "+calInicio.SelectedDate.Value.ToLongDateString()+" hasta "+
                calFin.SelectedDate.Value.ToLongDateString()+"<br>Contamos con su asistencia."+txtObservaciones.Text;
            
            for (int j = 0; j < ds.asistente_capacitacion.Count; j++)
            {
                for (int k = 0; k < ds.session_capacitacion.Count; k++)
                {
                    objDetalle.Insert(int.Parse(lblCod.Text), ds.asistente_capacitacion[j].cod_usuario,
                        ds.session_capacitacion[k].cod_sesion_capacitacion, true, null, ""
                        );
                    //enviamos la notificacion
                }
                objusuario.FillBycod_usuario(dsSeguridad.usuario,ds.asistente_capacitacion[j].cod_usuario);
                objUtils.enviarEmail(asunto, cupero, dsSeguridad.usuario[0].correo);
            }
            lblNombreEstado.Text = "Programada";
            habilitarControles();
#endregion
		}
        else if (ds.capacitacion[0].cod_estado_capacitacion == 2)
        {
            Response.Redirect("frmCerrarCapacitacion.aspx?cod=" + lblCod.Text);
		}
	}

    private void habilitarControles()
    {
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objCapacitacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();
        objCapacitacion.FillBycod_capacitacion(ds.capacitacion, int.Parse(lblCod.Text));
        objEstado.FillByCod_estado_capacitacion(ds.estado_capacitacion, ds.capacitacion[0].cod_estado_capacitacion);
        if (ds.estado_capacitacion[0].orden == 1)
        { }else if (ds.estado_capacitacion[0].orden == 2)
        {
            estadoControles(1);
            btnAceptar.Visible = false;
        //programada
            btnAgregarClase.Visible = false;
            calClaseIni.Visible = false;
            calClaseFin.Visible = false;
            calInicio.Enabled = false;
            calFin.Enabled = false;
            lblNombreEstado.Text = "Programada";
            cmbInscrito.Visible = false;
            btnAgregar.Visible = false;
            lblTituloEstado.Visible = true;
            lblNombreEstado.Visible = true;
        }else if (ds.estado_capacitacion[0].orden == 3)
        {
            btnAceptar.Visible = false;
            estadoControles(1);
            txtObservaciones.ReadOnly = true;
            //ejecutada
            btnAceptar.Visible = false;
            txtModelo.Enabled = false;
            txtNombre.ReadOnly = true;
            txtObservaciones.ReadOnly = true;
            txtotro.ReadOnly = true;
            txtReactivo.Enabled = false;
            cmbDictadaPor.Enabled = false;
            calInicio.Enabled = false;
            calFin.Enabled = false;
            btnAgregarClase.Visible = false;
            calClaseIni.Visible = false;
            calClaseFin.Visible = false;
            btnAgregar.Visible = false;
            cmbInscrito.Visible = false;
            lblNombreEstado.Text = "Ejecutada";
            btnCambiarDeEstado.Visible = false;
            lblTituloEstado.Visible = true;
            lblNombreEstado.Visible = true;
            btnReabrir.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2023, int.Parse(Session["ss_cod_usuario"].ToString()), Session);
        }
        grdClases.DataBind();
        grdIntegrante.DataBind();

    }

	protected void cmbInscrito_PreRender(object sender, EventArgs e)
	{
		ListItem it = new ListItem("N/A", "N/A");
		if (!IsPostBack && !cmbInscrito.Items.Contains(it))
		{
			cmbInscrito.Items.Add(it);
			cmbInscrito.SelectedValue = "N/A";
		}
	}

    public string verPorcentaje(object asistencia,object clases)
    { 
        if(asistencia == null || asistencia== System.DBNull.Value || clases == System.DBNull.Value || clases == null)return "";
        int asis= int.Parse(asistencia.ToString());
        int cl= int.Parse(clases.ToString());
        return ((asis * 100) / cl) + "%";
    }

	protected void btnQuitarclase(object sender, ImageClickEventArgs e)
	{
		ImageButton im= (ImageButton)sender;
	 SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter s = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
		s.DeleteQuery(int.Parse( im.ValidationGroup));
		grdClases.DataBind();
	}

    protected void btnEjecutarclase(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        Response.Redirect("frmInscritosClases.aspx?cod="+im.ValidationGroup);
        
    }


	protected void QuitarInscrito(object sender, ImageClickEventArgs e)
	{
		ImageButton im= (ImageButton)sender;
		SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter s = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
		s.DeleteQuery( int.Parse(lblCod.Text),  int.Parse( im.ValidationGroup));
		grdIntegrante.DataBind();
	}

	protected void btnAgregar_Click(object sender, EventArgs e)
	{
		lblErrorIntegrante.Text = "";
		if (lblCod.Text.Trim() == string.Empty)
		{
			lblErrorIntegrante.Text = "<br/>Primero debe guardar el encabezado!!!";
			return;
		}
		if (cmbInscrito.SelectedValue == "N/A")
		{
			lblErrorIntegrante.Text = "<br/>Debe ingresar el integrante!";
			return;
		}
		btnCambiarDeEstado.Visible = true;   
		SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter asis = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
		if (asis.GetDataByUsuarioCapacitacion(int.Parse(lblCod.Text),int.Parse(cmbInscrito.SelectedValue)).Rows.Count > 0)
		{
			lblErrorIntegrante.Text = "<br/>El Asistente ya pertenece a la lista de inscritos!";
			return;
		}



        //valida las clases de todos los que estan inscritos
        if (linkConflicto.Text == string.Empty)
        {
            SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter objSessionCapacitacion = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            objSessionCapacitacion.FillByCod_capacitacion(ds.session_capacitacion, int.Parse(lblCod.Text));

           
            clsSeguridad sg = new clsSeguridad();
            for (int k = 0; k < ds.session_capacitacion.Count; k++)
            {
                string cod = cmbInscrito.SelectedValue;

                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                string sql = "select nombre from usuario where cod_usuario=" + cod;
                string name = bd.ejecutarProcedimiento(sql).ToString().Trim();

                string codTarea = sg.validarCalendario(int.Parse(cod), ds.session_capacitacion[k].fecha_inicio, ds.session_capacitacion[k].fecha_fin);

                if (codTarea != "")
                {
                    CGWebUtils.utils.misc.messageBox(Page, "Actividad en Conflicto para " + name + ", si presiona guardar nuevamente se guardara con conflicto");
                    lblConflicto.Text = "1";
                    linkConflicto.Target = "_Blank";
                    linkConflicto.Visible = true;
                    linkConflicto.Text = "Actividad en Conflicto para " + name + ", si presiona guardar nuevamente se guardara con conflicto";
                    linkConflicto.NavigateUrl = sg.resolverLinkTarea(codTarea);
                    return;
                }
            }
        }
        linkConflicto.Text = string.Empty;
        linkConflicto.Visible = false;
		asis.Insert(int.Parse(lblCod.Text), int.Parse(cmbInscrito.SelectedValue),null,null,null,null,null,null,null);
		grdIntegrante.DataBind();
	}

    protected void btnReabrir_Click(object sender, EventArgs e)
    {
        //check for class must have one or more users
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();

        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        obj.FillBycod_capacitacion(ds.capacitacion, int.Parse(lblCod.Text));

   objEstado.FillByorden(ds.estado_capacitacion, 2);
            obj.UpdateEstado(ds.estado_capacitacion[0].cod_estado_capacitacion, int.Parse(lblCod.Text));
            btnCambiarDeEstado.Visible = true;
            btnReabrir.Visible = false;
            lblNombreEstado.Text = ds.estado_capacitacion[0].descripcion;
    }

    protected void btnVerAsistencia_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = (byte[])obj.verAsistencia(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        string ext = obj.verExtensionAsistencia(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        bajarArchivo(arr, ext);
    }

    protected void btnVerEvaluacion_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = obj.verEvaluacion(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        string ext = obj.verExtensionEvaluacion(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        bajarArchivo(arr, ext);
    }

    protected void btnVerCertificado_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        byte[] arr = obj.verCertificado(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        string ext = obj.verExtensionCertificado(int.Parse(Request.QueryString["cod"]), int.Parse(im.ValidationGroup));
        bajarArchivo(arr, ext);
    }

    public void bajarArchivo(byte[] arr, string extension)
    {
        if (arr != null)
        {

            string path = Server.MapPath("~/temp/");
            string file = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') +
                DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString() +
                extension;
            path = path + file;
            System.IO.File.WriteAllBytes(path, arr);
            Response.Redirect("~/temp/" + file);
        }
    }
}
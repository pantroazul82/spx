using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmListadoMaestro : System.Web.UI.Page
{
 
    System.Data.DataTable validarModelo()
    {
        string sql = @"select codModelo,f.codFabricante 
 from modelos
join fabricante f on f.codFabricante = modelos.codFabricante
where 
rtrim(nombreModelo)+' ('+rtrim(nombre_Fabricante)+')' ='" + txtModelo.Text + "'";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        return bd.ejecutarConsulta(sql).Tables[0];
    }

    System.Data.DataTable validarReactivo()
    {
        string sql = @"select cod_referencia_reactivo  from referencia_reactivo 
join fabricante f on f.codFabricante = referencia_reactivo.codFabricante
where
rtrim(nombre_referencia_reactivo)+' ('+rtrim(nombre_Fabricante)+')' ='" + txtReactivo.Text.Trim() + "'";
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

    protected void Page_Load(object sender, EventArgs e)
    {
        registrarScriptModelos(txtModelo);
        registrarScriptReactivos(txtReactivo);

        if (!IsPostBack)
        {
            calInicio.SelectedDate = DateTime.Now.AddMonths(-2);
            calFin.SelectedDate = DateTime.Now.AddDays(1);
        }
    }

    private bool validar()
    {
        lblError.Text = "";
        //if (rdTema.Checked && txtNombre.Text.Trim() == string.Empty)
        //{
        //    lblError.Text = "El tema es obligatorio!";
        //    return false;
        //}

        if (chkFechas.Checked)
        {
            if (!calInicio.SelectedDate.HasValue || !calFin.SelectedDate.HasValue)
            {
                lblError.Text = "Debe ingresar las dos fechas";
                return false;
            }

            if(calFin.SelectedDate< calInicio.SelectedDate)
            {
                lblError.Text = "Las dos fechas no son coherentes";
                return false;
            }
        }

        if (chkModelo.Checked && txtModelo.Text != string.Empty)
        {
            if (validarModelo().Rows.Count <= 0)
            {
                lblError.Text = "El modelo ingresado no es valido!";
                return false;
            }
        }

        if (chkReactivo.Checked && txtReactivo.Text != string.Empty)
        {
            if (validarReactivo().Rows.Count <= 0)
            {
                lblError.Text = "El reactivo ingresado no es valido!";
                return false;
            }
        }

        

        return true;
    }


    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        Buscar();
    }

    private string generarFiltro() 
    {
        string filtro = "";
        //dateformat dmy

        DateTime i= calInicio.SelectedDate.Value;
        DateTime f = calFin.SelectedDate.Value;

       string fi= i.Day.ToString().PadLeft(2, '0') +"/"+ i.Month.ToString().PadLeft(2, '0')+"/"+i.Year.ToString();

       string ff = f.Day.ToString().PadLeft(2, '0') + "/" + f.Month.ToString().PadLeft(2, '0') + "/" + f.Year.ToString();

        if (chkFechas.Checked)
            filtro = " capacitacion.fecha_inicio between  '"+  fi + "' and '" + ff+"'";

        if (chkTema.Checked)
        {
            if (filtro.Trim() != string.Empty) filtro = filtro + " and ";

            filtro = filtro + " capacitacion.nombre like '%" + txtNombre.Text + "%'";
        }

        if (chkFabricante.Checked)
        {
            if (filtro.Trim() != string.Empty) filtro = filtro + " and ";

            filtro = filtro+" capacitacion.cod_fabricante = '" + cmbFabricante.SelectedValue + "'";
        }

        if (chkModelo.Checked)
        {
            if (filtro.Trim() != string.Empty) filtro = filtro + " and ";
            string modelo = null;
            string fabricante = null;
            if (txtModelo.Text != string.Empty)
            {
                System.Data.DataTable tb = validarModelo();
                modelo = tb.Rows[0]["codModelo"].ToString().Trim();
                fabricante = tb.Rows[0]["codFabricante"].ToString().Trim();
            }
            filtro = filtro+ " (modelos.codModelo= '" + modelo + "' and modelos.codFabricante = '" + fabricante + "')";
        }
        if (chkReactivo.Checked)
        {
            if (filtro.Trim() != string.Empty) filtro = filtro + " and ";
            int? codReactivo = null;
            if (txtReactivo.Text.Trim() != string.Empty)
            {
                codReactivo = int.Parse(validarReactivo().Rows[0][0].ToString());
            }
            filtro = filtro+ " referencia_reactivo.cod_referencia_reactivo = '" + codReactivo + "'";
        }
        if (chkUsuario.Checked)
        {
            if (filtro.Trim() != string.Empty) filtro = filtro + " and ";
            filtro = filtro+ " usuario.cod_usuario = '" + cmbDictadaPor.SelectedValue + "'";
        }

        return filtro;
    }

    private System.Data.DataTable GetTableData() 
    {
        if (!validar()) return null;
        string filtro = generarFiltro();
        if (filtro == string.Empty)
        {
            lblError.Text = "Debe seleccionar un filtro!";
            return null;
        }
        //--
        string sql = @"set dateformat dmy select distinct usuario.nombre,usuario.correo,usuario.cod_usuario,
capacitacion.nombre 'curso',capacitacion.fecha_inicio 'Dictada',
Modelos.NombreModelo 'Modelo',nombre_fabricante
from asistentexsession
left join usuario on usuario.cod_usuario = asistentexsession.cod_usuario
left join session_capacitacion on session_capacitacion.cod_sesion_capacitacion = asistentexsession.cod_session
join capacitacion on capacitacion.cod_capacitacion = session_capacitacion.cod_capacitacion
left join fabricante on fabricante.codFabricante = capacitacion.cod_fabricante
left join Modelos on modelos.codModelo = capacitacion.cod_modelo and 
fabricante.codFabricante = modelos.codFabricante
left join referencia_reactivo on referencia_reactivo.cod_referencia_reactivo = capacitacion.cod_referencia_reactivo
where  asistentexsession.aceptada=1";

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        return bd.ejecutarConsulta(sql + " and " + filtro).Tables[0];
    }

    private void Buscar()
    {
        RadGrid1.DataSource = GetTableData(); ;
        RadGrid1.DataBind();
    }

    protected void btnGenerarExcel_Click(object sender, EventArgs e)
    {
        string serverPath = Server.MapPath("~/temp/");
        string patfile = "../../temp/";
        string nombreArchivo = "capacitacion.xls";
        System.Data.DataTable tb=GetTableData();
        if(tb == null)return;
        SPXUtilidades.Misc.clsExportarExcel obj = new SPXUtilidades.Misc.clsExportarExcel();

        C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
        //--
        grilla.DataSource = tb.DataSet;
        grilla.DataMember = tb.TableName;
        for (int k = 0; k < tb.Columns.Count; k++)
        {
            grilla.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn(tb.Columns[k].Caption, typeof(string)));
        }

        //--

        obj.exportXlsWeb(tb, "Capacitacion", serverPath,
            nombreArchivo, patfile, Response);
    }
}
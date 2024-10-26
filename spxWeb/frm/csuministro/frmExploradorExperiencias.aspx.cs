﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmExploradorExperiencias : System.Web.UI.Page
{
    public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }


    }

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


    protected void Page_Load(object sender, EventArgs e)
    {
        registrarScriptProducto(txtProductos);
        if (!IsPostBack)
        {
            calIni.Value = DateTime.Now.AddYears(-1);
            calFin.Value = DateTime.Now.AddDays(1);
            Session["lstGrpCreacNav"] = null;
            Session["lstDiviCreacNav"] = null;
            Session["lstProdCreacNav"] = null;
        }
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


    protected void btnAgregarGrupoReactivos_Click(object sender, EventArgs e)
    {
        List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f =
            (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreacNav"];
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
        Session["lstGrpCreacNav"] = f;
        generarGrillas();
    }

    private void generarGrillas()
    {
        List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f =
               (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreacNav"];
        grdGrupo.DataSource = f;
        grdGrupo.DataBind();
        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> d =
               (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreacNav"];
        grdDivisiones.DataSource = d;
        grdDivisiones.DataBind();

        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> p =
               (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreacNav"];
        grdProdcutos.DataSource = p;
        grdProdcutos.DataBind();

    }


    protected void btnAgregarDivision_Click(object sender, EventArgs e)
    {
        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> f =
           (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreacNav"];
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
        Session["lstDiviCreacNav"] = f;
        generarGrillas();
    }

    protected void EliminarGrupo_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f =
           (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreacNav"];
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
        Session["lstGrpCreacNav"] = f;
        generarGrillas();
    }
    protected void EliminarDivision_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> f =
         (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreacNav"];
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

        Session["lstDiviCreacNav"] = f;
        generarGrillas();
    }


    protected void btnAgregarProducto_Click(object sender, EventArgs e)
    {
        //obtenemos el codigo
        //Clinica Colsanitas (farmaco independiente - test)
        string sql = @"select top 1 cod_producto_experiencia_contrato,nombre_fabricante,nombre_producto,codigo_manual_referencia from producto_experiencia_contrato
 join fabricante on fabricante.cod_fabricante= producto_experiencia_contrato.cod_fabricante

where rtrim(fabricante.nombre_fabricante)+' ('+rtrim(nombre_producto)+' - '+rtrim(codigo_manual_referencia)+')' ='" + txtProductos.Text + "'";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count == 0) return;
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreacNav"];
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
        Session["lstProdCreacNav"] = f;
        txtProductos.Text = "";
        generarGrillas();
    }

    protected void EliminarProucto_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> f = (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreacNav"];
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
        Session["lstProdCreacNav"] = f;
        generarGrillas();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        buscar();
    }

    private void buscar() 
    {
        grdContratos.DataSource = verDatos();
        grdContratos.DataBind();
    }

    private System.Data.DataTable verDatos(){
        string sql = @"set dateformat dmy 
declare @fini as datetime
declare @ffin as datetime
set @fini ='"+calIni.Date.Day.ToString().PadLeft(2,'0')+"-"+calIni.Date.Month.ToString().PadLeft(2,'0')+"-"+calIni.Date.Year+@"'
set @ffin ='" + calFin.Date.Day.ToString().PadLeft(2, '0') + "-" + calFin.Date.Month.ToString().PadLeft(2, '0') + "-" + calFin.Date.Year + @"'

SELECT contratos_suministro.cod_contratos_suministro,
   estado_contrato_suministro.nombre_estado_contrato_suministro, contratos_suministro.numero_contrato, asesoresComerciales.NombreAsesor, 
                         contratos_suministro.nitCliente, clientes.nombreCliente, clientes.numeroSocio, ciudades.nombreCiudad, departamentos.NombreDepartamento, 
                         contratos_suministro.fecha_incio, contratos_suministro.fecha_terminacion, contratos_suministro.valor_contrato, contratos_suministro.otrosi, 
                         contratos_suministro.aplica_estampilla, contratos_suministro.aplica_polizas, contratos_suministro.fecha_creacion, contratos_suministro.es_contrato, 
                         contratos_suministro.es_orden_compra
FROM            contratos_suministro 
JOIN
estado_contrato_suministro ON contratos_suministro.cod_estado_contrato_suministro = estado_contrato_suministro.cod_estado_contrato_suministro 
JOIN
asesoresComerciales ON contratos_suministro.codAsesor = asesoresComerciales.codAsesor 
JOIN
clientes ON contratos_suministro.nitCliente = clientes.nitCliente 
JOIN
ciudades ON contratos_suministro.codPais_envio_contrato = ciudades.codPais AND 
                         contratos_suministro.codDepartamento_envio_contrato = ciudades.codDepartamento AND 
                         contratos_suministro.codCiudad_envio_contrato = ciudades.codCiudad 
JOIN
departamentos ON ciudades.codPais = departamentos.codPais AND ciudades.codDepartamento = departamentos.codDepartamento
Where 
cod_contratos_suministro
 in(select max(cod_contratos_suministro) from contratos_suministro group by consecutivo_interno )

and
(
    contratos_suministro.fecha_incio between @fini and @ffin
    or 
    contratos_suministro.fecha_terminacion between @fini and @ffin
    or 
    (contratos_suministro.fecha_incio < @fini and contratos_suministro.fecha_terminacion  > @ffin)
)
";
        if (txtMontoMenor.Text.Trim() != string.Empty)
        {
            sql = sql + " and valor_contrato >= "+txtMontoMenor.Text;
        }

        if (txtMontoMayor.Text.Trim() != string.Empty)
        {
            sql = sql + " and valor_contrato <= " + txtMontoMayor.Text;
        }
        //armamos los filtros de grupo
        List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow> f =
              (List<SPControladoraDatos.dsContratosSuministro.grupo_reactivo_experienciaRow>)Session["lstGrpCreacNav"];
        if (f!= null && f.Count > 0)
        {
            string codigosGrupos = "";
            for (int k = 0; k < f.Count; k++)
            { 
            codigosGrupos= codigosGrupos+ f[k].cod_grupo_reactivo_experiencia.ToString();
            if (k != f.Count - 1)
            {
                codigosGrupos = codigosGrupos + ",";
            }
            }
            sql = sql + @" and contratos_suministro.cod_contratos_suministro in( 
            select cod_contratos_suministro from grupo_reactivoxcontrato_suministro
            where cod_grupo_reactivo_experiencia in ("+codigosGrupos+"))";
        }
        List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow> d =
               (List<SPControladoraDatos.dsContratosSuministro.division_experiencia_contrato_suministroRow>)Session["lstDiviCreacNav"];
        if (d!= null && d.Count > 0)
        {
            string codigosDivision = "";
            for (int k = 0; k < d.Count; k++)
            {
                codigosDivision = codigosDivision + d[k].cod_division_experiencia_contrato_suministro.ToString();
                if (k != d.Count - 1)
                {
                    codigosDivision = codigosDivision + ",";
                }
            }
            sql = sql + @" and contratos_suministro.cod_contratos_suministro in( 
            select cod_contratos_suministro from divisionxcontrato_suministro
where cod_division_experiencia_contrato_suministro in(" + codigosDivision + "))";
        }

        List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow> p =
               (List<SPControladoraDatos.dsContratosSuministro.pltProductoExperienciaRow>)Session["lstProdCreacNav"];
        if (p != null && p.Count > 0)
        {
            string codigosProductos = "";
            for (int k = 0; k < p.Count; k++)
            {
                codigosProductos = codigosProductos + p[k].cod_producto_experiencia_contrato.ToString();
                if (k != p.Count - 1)
                {
                    codigosProductos = codigosProductos + ",";
                }
            }
            sql = sql + @" and contratos_suministro.cod_contratos_suministro in( 
            select cod_contratos_suministro from producto_experiencia_contratoxcontrato_conmsumo
where cod_producto_experiencia_contrato in (" + codigosProductos + "))";
        }


        //ejecutamos el query
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        return bd.ejecutarConsulta(sql).Tables[0];
        
    }
    protected void btnExportarExcel_Click(object sender, EventArgs e)
    {
        SPXUtilidades.Misc.clsExportarExcel xls = new SPXUtilidades.Misc.clsExportarExcel();
        xls.exportXlsWeb(verDatos(), "Contratos Suministro",
            Server.MapPath("~/temp/"), "contratos.xls", "../../temp/", Response);
    }
}
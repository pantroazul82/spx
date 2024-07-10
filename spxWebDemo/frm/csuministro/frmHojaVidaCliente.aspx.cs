using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmHojaVidaCliente : System.Web.UI.Page
{

    private void buscar()
    {
        string sql = @"set dateformat dmy 
SELECT 
cod_contratos_suministro,
[numero_contrato], [consecutivo_interno], [nitCliente], [contacto_juridico], [numero_celular_contacto_juridico],
[fecha_incio], [fecha_terminacion],  [valor_contrato], [otrosi],estado_contrato_suministro.nombre_estado_contrato_suministro
FROM [contratos_suministro]
join estado_contrato_suministro on estado_contrato_suministro.cod_estado_contrato_suministro = contratos_suministro.cod_estado_contrato_suministro

";

        //armamos los filtros

        sql = sql + " where nitCliente ='" + Request.QueryString["nit"] + "' ";

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        grdDatos.DataSource = bd.ejecutarConsulta(sql + " order by cod_contratos_suministro desc ").Tables[0];
        grdDatos.DataBind();

        sql = @"select nitcliente,nombreCliente,numeroSocio from clientes where nitCliente ='"+Request.QueryString["nit"]+"'";

        System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {
            txtCliente.Text = tb.Rows[0][1].ToString();
            txtNitCliente.Text = tb.Rows[0][0].ToString();
            txtNumeroSocio.Text = tb.Rows[0][2].ToString();
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            buscar();
        }
    }
   
    protected void btnExportar_Click(object sender, EventArgs e)
    {
        ASPxGridViewExporter1.WriteXlsxToResponse();
    }

    protected void lnkVerArchivo_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        int cod = int.Parse(b.CommandArgument);
        SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter archivos = new SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter();

        archivos.FillByCod_archivoxcontratos_suministro(ds.archivoxcontratos_suministro, cod);
        string path = Server.MapPath("~/temp/");
        string extension = System.IO.Path.GetExtension(ds.archivoxcontratos_suministro[0].nombre_archivo);
        string nombre = ds.archivoxcontratos_suministro[0].nombre_archivo.Replace(extension, "");

        int k = 0;
        while (System.IO.File.Exists(path + nombre + extension))
        {
            k++;
            nombre = nombre + k;
        }
        System.IO.File.WriteAllBytes(path + nombre + extension, ds.archivoxcontratos_suministro[0].archivo);
        Response.Redirect("~/temp/" + nombre + extension);
    }

}
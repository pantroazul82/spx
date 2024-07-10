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

    

}
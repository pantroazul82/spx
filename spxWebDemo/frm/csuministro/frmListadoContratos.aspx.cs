using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmListadoContratos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            calInicio.Date = DateTime.Now.AddMonths(-2);
            calFin.Date = DateTime.Now.AddDays(1);
        }
        else {
            buscar();
        }
    }

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
        string f1 = "'"+calInicio.Date.Day.ToString().PadLeft(2,'0')+"/"+
            calInicio.Date.Month.ToString().PadLeft(2,'0')+"/"+calInicio.Date.Year+"'";
        string f2 = "'" + calFin.Date.Day.ToString().PadLeft(2, '0') + "/" +
            calFin.Date.Month.ToString().PadLeft(2, '0') + "/" + calFin.Date.Year + "'";
        sql = sql + " where fecha_creacion between  " + f1 + " and " + f2 +"  ";
        if (txtFiltro.Text.Trim() != string.Empty)
        { 
        
            switch(cmbFiltro.SelectedItem.Text)
            {
                case "Numero Contrato": { sql = sql + " or numero_contrato like '"+txtFiltro.Text.Trim()+"%'  "; break; }
                case "Cliente": { sql = sql + " or nitCliente in( select nitCliente from clientes where nombreCliente like '%"+txtFiltro.Text+"%')  "; break; }
                case "Numero Socio Cliente": { sql = sql + " or nitCliente in( select nitCliente from clientes where numeroSocio like '%" + txtFiltro.Text + "%')  "; break; }
                case "Nit Cliente": { sql = sql + " or nitCliente like '" + txtFiltro.Text.Trim() + "%'  "; break; }
            }
        }

        if (chkProximosVencer.Checked)
        {
            sql = sql + " and datediff(MONTH,GETDATE(),fecha_terminacion) > 0 and datediff(MONTH,GETDATE(),fecha_terminacion) <= "+cmbProximosAvencer.SelectedValue;
        }

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        grdDatos.DataSource = bd.ejecutarConsulta(sql + " order by cod_contratos_suministro desc ").Tables[0];
        grdDatos.DataBind();
    }


    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        buscar();
    }

    protected void btnExportarExcel_Click(object sender, EventArgs e)
    {
        ASPxGridViewExporter1.WriteXlsxToResponse("Contratos Suministro");
    }
}
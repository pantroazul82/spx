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
        if (Session["ss_cod_usuario"] == null)
        {
            Response.Redirect("~/default.aspx");
        }

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
[contratos_suministro].cod_contratos_suministro,no_genera_flujo,
[numero_contrato], [consecutivo_interno], contratos_suministro.nitCliente,nombreCliente,numeroSocio, [contacto_juridico], [numero_celular_contacto_juridico],
[fecha_incio], [fecha_terminacion],  [valor_contrato], [otrosi],estado_contrato_suministro.nombre_estado_contrato_suministro
,horas,minutos,fecha_cambio
FROM [contratos_suministro]
join clientes on clientes.nitCliente = contratos_suministro.nitcliente
join estado_contrato_suministro on estado_contrato_suministro.cod_estado_contrato_suministro = contratos_suministro.cod_estado_contrato_suministro
left join(
select max(fecha_cambio) 'fecha_cambio',
cod_contratos_suministro,
sum(horas) 'horas',sum(minutos) 'minutos' from log_cambios_estado_contratos_suministro
group by cod_contratos_suministro
) st on st.cod_contratos_suministro = contratos_suministro.cod_contratos_suministro
";

        //armamos los filtros
        string f1 = "'"+calInicio.Date.Day.ToString().PadLeft(2,'0')+"/"+
            calInicio.Date.Month.ToString().PadLeft(2,'0')+"/"+calInicio.Date.Year+"'";
        string f2 = "'" + calFin.Date.Day.ToString().PadLeft(2, '0') + "/" +
            calFin.Date.Month.ToString().PadLeft(2, '0') + "/" + calFin.Date.Year + "'";
        string filtro = "";
        filtro = filtro + " where fecha_creacion between  " + f1 + " and " + f2 +"  ";
        if (txtFiltro.Text.Trim() != string.Empty)
        {
            filtro = filtro.Replace("where"," where (");
            switch(cmbFiltro.SelectedItem.Text)
            {
                case "Numero Contrato": { filtro = ""+filtro + " and numero_contrato like '"+txtFiltro.Text.Trim()+"%' ) "; break; }
                case "Cliente": { filtro = "" + filtro + " and nitCliente in( select nitCliente from clientes where nombreCliente like '%" + txtFiltro.Text + "%') ) "; break; }
                case "Numero Socio Cliente": { filtro = "" + filtro + " and nitCliente in( select nitCliente from clientes where numeroSocio like '%" + txtFiltro.Text + "%') )  "; break; }
                case "Nit Cliente": { filtro = "" + filtro + " and nitCliente like '" + txtFiltro.Text.Trim() + "%' ) "; break; }
            }
        }
       
        if (chkProximosVencer.Checked)
        {
            filtro = filtro + " and datediff(MONTH,GETDATE(),fecha_terminacion) >= 0 and datediff(MONTH,GETDATE(),fecha_terminacion) <= "+cmbProximosAvencer.SelectedValue;
        }
        //esto es para tener solo el ultimo contrato en caso de que tenga otros si
        sql = sql + filtro + @"
 and [contratos_suministro].cod_contratos_suministro
 in(select max(cod_contratos_suministro) from contratos_suministro group by numero_contrato )";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        grdDatos.DataSource = bd.ejecutarConsulta(sql + " order by [contratos_suministro].cod_contratos_suministro desc ").Tables[0];
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
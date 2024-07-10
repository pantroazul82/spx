using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmPolizas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btnFileUpload1.Attributes.Add("onclick", "jQuery('#" + FileUpload1.ClientID + "').click();return false;");
        if (!IsPostBack)
        {

            cmbAseguradora.DataBind();
            cmbAseguradora.Items.Add(new ListItem("Seleccione","-1"));
            cmbAseguradora.SelectedValue = "-1";
            for(int k=1;k<37;k++)
            {
                cmbVigencia.Items.Add(new ListItem(k.ToString(),k.ToString()));    
            }
            if (Request.QueryString["codc"] != null)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                p.FillByCod_polizas_contrato_suministro(ds.polizas_contrato_suministro, int.Parse(Request.QueryString["codc"]));
                //---
                cmbRiesgo.SelectedValue = ds.polizas_contrato_suministro[0].cod_riesgo_poliza_consumo.ToString();
                txtObservaciones.Text = ds.polizas_contrato_suministro[0].observaciones;
                txtValor.Text = ds.polizas_contrato_suministro[0].valor_poliza.ToString();
                txtPorcentaje.Text = ds.polizas_contrato_suministro[0].porcentaje.ToString();
                cmbVigencia.SelectedValue = ds.polizas_contrato_suministro[0].vigencia_meses.ToString();
                if(!ds.polizas_contrato_suministro[0].Iscod_aseguradora_suministroNull())
                cmbAseguradora.SelectedValue = ds.polizas_contrato_suministro[0].cod_aseguradora_suministro.ToString();

                if (!ds.polizas_contrato_suministro[0].Isurl_archivo_polizaNull() && ds.polizas_contrato_suministro[0].url_archivo_poliza.Trim() != string.Empty)
                {
                    lnkVerArchivo.NavigateUrl = ds.polizas_contrato_suministro[0].url_archivo_poliza.ToString();
                    lnkVerArchivo.Visible = true;
                }
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod="+Request.QueryString["cod"]);
    }

    private bool validar() 
    {
        decimal pc = 0;
        if (cmbAseguradora.SelectedValue== null || cmbAseguradora.SelectedValue.Trim() == string.Empty
            || cmbAseguradora.SelectedValue.Trim() == "-1")
        {
            lblError.Text = "Ingrese la aseguradora";
            return false;
        }

        if (cmbRiesgo.SelectedValue == null || cmbRiesgo.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "Ingrese la riesgo";
            return false;
        }
      
        if (!decimal.TryParse(txtPorcentaje.Text.Replace(",",".").Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator), out pc))
        {
            lblError.Text = "EL porcentaje tiene un valor no valido";
            return false;
        }
        decimal vl = 0;
        ;
        if (!decimal.TryParse(txtValor.Text.Replace("$",""), out vl))
        {
            lblError.Text = "EL valor no es valido";
            return false;
        }
        return true;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar()) { return; }
        SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter();
        decimal pc=0;
        decimal.TryParse(txtPorcentaje.Text.Replace(",",".").Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator),out pc);
        decimal vl=0;
        decimal.TryParse(txtValor.Text,out vl);
        if (Request.QueryString["codc"] == null)
        {
            p.Insert(int.Parse(Request.QueryString["cod"]),
                int.Parse(cmbRiesgo.SelectedValue), txtObservaciones.Text, vl, int.Parse(cmbVigencia.SelectedValue),
                int.Parse(cmbAseguradora.SelectedValue),
                lnkVerArchivo.NavigateUrl,
                pc);

        }
        else
        {
            p.UpdateQuery(int.Parse(cmbRiesgo.SelectedValue),txtObservaciones.Text,
                pc, vl, int.Parse(cmbVigencia.SelectedValue),
                int.Parse(cmbAseguradora.SelectedValue),
                lnkVerArchivo.NavigateUrl,
                int.Parse(Request.QueryString["codc"]));
        }

        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnCargarArchivo_Click(object sender, EventArgs e)
    {
        if (!FileUpload1.HasFile)
        {
            lblError.Text = "Seleccione el archivo ";
            return;
        }

        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "poliza" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUpload1.FileName);
        FileUpload1.SaveAs(ruta + archivo);

        lnkVerArchivo.CssClass = "";
        lnkVerArchivo.NavigateUrl = "~/files/" + archivo;
        lnkVerArchivo.Visible = true;
        
    }
}
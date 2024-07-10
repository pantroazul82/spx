using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmEstampillas : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        btnFileUpload1.Attributes.Add("onclick", "jQuery('#" + FileUpload1.ClientID + "').click();return false;");
        
        if (!IsPostBack)
        {
          
            if (Request.QueryString["codc"] != null)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter();
                
                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
               p.FillByCod_estampillas_contrato_sumisnistro(ds.estampillas_contrato_sumisnistro, int.Parse(Request.QueryString["codc"]));
                //---

                txtBeneficiario.Text = ds.estampillas_contrato_sumisnistro[0].beneficiario;
                txtValor.Text = string.Format("{0:c}", (ds.estampillas_contrato_sumisnistro[0].valor));
                txtPorcentaje.Text = ds.estampillas_contrato_sumisnistro[0].porcentaje.ToString();
                txtcuenta.Text = ds.estampillas_contrato_sumisnistro[0].cuentabanco;
                cmbBanco.SelectedValue = ds.estampillas_contrato_sumisnistro[0].cod_banco_suministro.ToString();
                cmbTipoCuenta.SelectedValue = ds.estampillas_contrato_sumisnistro[0].cod_tipo_cuenta_banco.ToString();
                cmbDestinacion.SelectedValue = ds.estampillas_contrato_sumisnistro[0].cod_destinacion_suministro.ToString();
                
                if (!ds.estampillas_contrato_sumisnistro[0].Ispago_clienteNull())
                chkPagoCliente.Checked = ds.estampillas_contrato_sumisnistro[0].pago_cliente;

                if (!ds.estampillas_contrato_sumisnistro[0].Isurl_archivoNull())
                {
                    lnkVerArchivo.Visible = true;
                    lnkVerArchivo.NavigateUrl = ds.estampillas_contrato_sumisnistro[0].url_archivo;
                }
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }

    private bool validar()
    {
        decimal pc = 0;

     
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

        if (txtcuenta.Text.Trim() == string.Empty)
        {
            lblError.Text = "EL numero de cuenta es obligatorio";
            return false;
        }
        return true;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar()) { return; }
        SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter();
        
        decimal pc = 0;
        decimal.TryParse(txtPorcentaje.Text.Replace(",",".").Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator), out pc);
        decimal vl = 0;
        decimal.TryParse(txtValor.Text.Replace("$",""), out vl);
        calcularValor();
        if (Request.QueryString["codc"] == null)
        {
            p.Insert(int.Parse(Request.QueryString["cod"]), vl, txtcuenta.Text,txtBeneficiario.Text,
                int.Parse(cmbDestinacion.SelectedValue),int.Parse(cmbTipoCuenta.SelectedValue),
                int.Parse(cmbBanco.SelectedValue),lnkVerArchivo.NavigateUrl,  pc,chkPagoCliente.Checked);

        }
        else
        {
            p.UpdateQuery( pc, vl, txtcuenta.Text,txtBeneficiario.Text,
                int.Parse(cmbDestinacion.SelectedValue),int.Parse(cmbTipoCuenta.SelectedValue),
                int.Parse(cmbBanco.SelectedValue),lnkVerArchivo.NavigateUrl, 
                chkPagoCliente.Checked,
                int.Parse(Request.QueryString["codc"]));
        }

        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnCalcularValor_Click(object sender, EventArgs e)
    {
        calcularValor();
    }

    private void calcularValor()
    {
        //
        SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter ta = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
        ta.FillByCod_contratos_suministro(ds.contratos_suministro, int.Parse(Request.QueryString["cod"]));
        decimal valor=ds.contratos_suministro[0].valor_contrato;
        decimal pc = 0;
        decimal.TryParse(txtPorcentaje.Text.Replace(",",".").Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator), out pc);
        
        txtValor.Text = string.Format("{0:c}", ((decimal)((decimal)valor * ((decimal)pc / 100))));
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

        string archivo = "estampilla" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUpload1.FileName);
        FileUpload1.SaveAs(ruta + archivo);

        lnkVerArchivo.CssClass = "";
        lnkVerArchivo.NavigateUrl = "~/files/" + archivo;
        lnkVerArchivo.Visible = true;
    }
}
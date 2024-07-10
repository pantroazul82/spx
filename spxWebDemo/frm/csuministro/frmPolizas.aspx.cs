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
        if (!IsPostBack)
        { 
            for(int k=1;k<37;k++)
            {
                cmbVigencia.Items.Add(new ListItem(k.ToString(),k.ToString()));    
            }
            if (Request.QueryString["codc"] != null)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter();
                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                p.FillByCod_contratos_suministro(ds.polizas_contrato_suministro, int.Parse(Request.QueryString["codc"]));
                //---
                txtNombre.Text = ds.polizas_contrato_suministro[0].nombre_poliza;
                txtValor.Text = ds.polizas_contrato_suministro[0].valor_poliza.ToString();
                txtPorcentaje.Text = ds.polizas_contrato_suministro[0].porcentaje.ToString();
                cmbVigencia.SelectedValue = ds.polizas_contrato_suministro[0].vigencia_meses.ToString();
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod="+Request.QueryString["cod"]);
    }

    private bool validar() 
    {
        int pc = 0;

        if (txtNombre.Text.Trim() == string.Empty)
        {
            lblError.Text = "El nombre es obligatorio";
            return false;
        }
        if (!int.TryParse(txtPorcentaje.Text, out pc))
        {
            lblError.Text = "EL porcentaje tiene un valor no valido";
            return false;
        }
        decimal vl = 0;
        ;
        if (!decimal.TryParse(txtValor.Text, out vl))
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
        int pc=0;
        int.TryParse(txtPorcentaje.Text,out pc);
        decimal vl=0;
        decimal.TryParse(txtValor.Text,out vl);
        if (Request.QueryString["codc"] == null)
        {
            p.Insert(int.Parse(Request.QueryString["cod"]), txtNombre.Text, pc, vl, int.Parse(cmbVigencia.SelectedValue));
        
        }else {
            p.UpdateQuery( txtNombre.Text, pc, vl, int.Parse(cmbVigencia.SelectedValue),int.Parse(Request.QueryString["codc"]));
        }

        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }

}
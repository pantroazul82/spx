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
        if (!IsPostBack)
        {
          
            if (Request.QueryString["codc"] != null)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter();
                
                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                p.FillByCod_estampillas_contrato_sumisnistro(ds.estampillas_contrato_sumisnistro, int.Parse(Request.QueryString["codc"]));
                //---
                txtNombre.Text = ds.estampillas_contrato_sumisnistro[0].nombre;
                txtValor.Text = ds.estampillas_contrato_sumisnistro[0].valor.ToString();
                txtPorcentaje.Text = ds.estampillas_contrato_sumisnistro[0].porcentaje.ToString();
                txtDatosConsignacion.Text = ds.estampillas_contrato_sumisnistro[0].dato_consignacion;
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
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
        SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter();
        
        int pc = 0;
        int.TryParse(txtPorcentaje.Text, out pc);
        decimal vl = 0;
        decimal.TryParse(txtValor.Text, out vl);
        if (Request.QueryString["codc"] == null)
        {
            p.Insert(int.Parse(Request.QueryString["cod"]), txtNombre.Text, pc, vl, txtDatosConsignacion.Text);

        }
        else
        {
            p.UpdateQuery(txtNombre.Text, pc, vl, txtDatosConsignacion.Text, int.Parse(Request.QueryString["codc"]));
        }

        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }

}
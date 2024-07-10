using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_proceso_frmSolicitudGeneral : System.Web.UI.Page
{   
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
    public static List<AutoCompleteResult> ObtCliente(string term)
    {

        string sql = @"select top " + 5 + @"
nitCliente,rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes
where nitCliente like '" + term + @"%'
or nombreCliente like '" + term + @"%'
or numeroSocio like '" + term + "%'";
      
        System.Data.DataTable tb = new System.Data.DataTable();
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        obj.ejecutarConsulta(sql,tb);
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
   
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
    public static List<AutoCompleteResult> ObtReactivo(string term)
    {
        string sql = @"select top " + 5 + @"
rtrim(codigo_manual)+' ('+rtrim(nombre_referencia_reactivo)+')' from referencia_reactivo
where nombre_referencia_reactivo like '" + term + @"%'
or codigo_manual like '" + term + @"%'";

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
            ar.value = tb.Rows[k][0].ToString();
            lista.Add(ar);
        }

        return lista;
    }


    public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    private void registrarScriptCliente(Control c)
    {
        string query = @" <script type='text/javascript'>
          jQuery(document).ready(function () {
	        $('#" + c.ClientID + @"').autocomplete({
	            source: function (request, response) {
	                PageMethods.ObtCliente(
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

    private void registrarScriptReactivo(Control c)
    {
        string query = @" <script type='text/javascript'>
          jQuery(document).ready(function () {
	        $('#" + c.ClientID + @"').autocomplete({
	            source: function (request, response) {
	                PageMethods.ObtReactivo(
            request.term,
            function (data) {
                var cliente = (typeof data) == 'string' ? eval('(' + data + ')') : data;
                response(cliente);
            },
            fnLlamadaError2);
	            },
	            minLength: 2
	        });
	    });

	    function fnLlamadaError2(excepcion) {
	        alert('Ha ocurrido un error interno: ' + excepcion.get_message());
	    }
	</script>";

        if (!Page.ClientScript.IsStartupScriptRegistered("script" + c.ClientID))
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "script" + c.ClientID, query);

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 2002);

        
        registrarScriptCliente(txtCliente);
        registrarScriptReactivo(txtReactivo);
        string handler = ClientScript.GetPostBackEventReference(this.btnCliente, "");
        txtCliente.Attributes.Add("onblur", handler); 
        if( !IsPostBack)
        {
            cmbAsesorComercial.SelectedValue = Session["ss_cod_usuario"].ToString();
            cmbAsesorComercial.Enabled = false;
            calFechaSolicitud.SelectedDate = DateTime.Now;
            calFechaSolicitud.Enabled = false;
        }
    }
    protected void btnCliente_Click(object sender, EventArgs e)
    {
        string nit=sacarNit(txtCliente.Text);
        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='"+nit+"'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb= obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {
            txtSociodeNegocio.Text = tb.Rows[0]["numeroSocio"].ToString();
             sql = @"select codSucursal,nombreSucursal from sucursalCliente
                where nitCliente ='"+nit+"' ";
             cmbSucursal.DataSource= obj.ejecutarConsulta(sql).Tables[0];
             cmbSucursal.DataValueField = "codSucursal";
             cmbSucursal.DataTextField = "nombreSucursal";
             cmbSucursal.DataBind();
            //contactos
             sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
                where nitCliente ='" + nit + "' ";
             cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
             cmbContacto.DataValueField = "codContacto";
             cmbContacto.DataTextField = "nombre";
             cmbContacto.DataBind();
            //cargamos los seriales
              sql = @"
select serial, rtrim(serial)+'  '+rtrim(nombremodelo)+'('+rtrim(nombreFabricante)+')' 'nombre' from dbo.vistaequipo
where nitCliente = '" + nit+ "'";
              cmbSerial.DataSource = obj.ejecutarConsulta(sql).Tables[0];
              cmbSerial.DataValueField = "serial";
              cmbSerial.DataTextField = "nombre";
              cmbSerial.DataBind();
        }else {
            txtCliente.Text = "";
        }
        
    }

    public string sacarNit(string texto)
    {
        if (texto.LastIndexOf('(') <= 0)
            return "";
        string res=texto.Substring( texto.LastIndexOf('(')+1);
        res = res.Substring(0, res.Length - 1);
        return res;
    }

    protected void btnAgregarEquipo_Click(object sender, ImageClickEventArgs e)
    {
        if (cmbSerial.SelectedValue == null || cmbSerial.SelectedValue.Trim() == string.Empty) return;
        Telerik.Web.UI.RadListBoxItem o = new Telerik.Web.UI.RadListBoxItem(cmbSerial.SelectedItem.Text, cmbSerial.SelectedValue);
        
        for (int k = 0; k < rdEquipos.Items.Count; k++)
        {
                if (rdEquipos.Items[k].Value.Trim() == o.Value.Trim()) return;
        }

        rdEquipos.Items.Add(o);
    }
    protected void btnLimpiarEquipos_Click(object sender, ImageClickEventArgs e)
    {
        if(rdEquipos.SelectedItem != null)
        rdEquipos.Items.Remove(rdEquipos.SelectedItem);
    }

    protected void btnAgregarReactivo_Click(object sender, ImageClickEventArgs e)
    {
        if (txtReactivo.Text.Trim() == string.Empty || txtReactivo.Text.IndexOf("(")<0) return;
        Telerik.Web.UI.RadListBoxItem o = new Telerik.Web.UI.RadListBoxItem(txtReactivo.Text, txtReactivo.Text.Substring(0, txtReactivo.Text.IndexOf("(")-1));

        for (int k = 0; k < rdReactivos.Items.Count; k++)
        {
            if (rdReactivos.Items[k].Value.Trim() == o.Value.Trim()) return;
        }
        txtReactivo.Text = "";
        rdReactivos.Items.Add(o);
    }
    protected void btnLimpiarReactivo_Click(object sender, ImageClickEventArgs e)
    {
        if (rdReactivos.SelectedItem != null)
            rdReactivos.Items.Remove(rdReactivos.SelectedItem);
    }

    private bool validar()
    {
        lblError.Text = "";
        if (txtCliente.Text.Trim() == string.Empty)
        {
            lblError.Text = "El cliente es obligatorio!!!";
            return false;
        }
        if (!rdLegalizadoNo.Checked && !rdLegalizadoSi.Checked)
        {
            lblError.Text = "Debe especificar si el contrato es legalizado o no!!!";
            return false;
        }
        if (!rdLegalizadoNo.Checked && !rdLegalizadoSi.Checked)
        {
            lblError.Text = "Debe especificar la aceptacion de condiciones de instalacion!!!";
            return false;
        }
        int tipos = 0;
        //validamos los tipos de servicio de ingenieria o de cientifica
        for (int k = 0; k < dataTiposCientifica.Items.Count;k++ )
        {
            if (((CheckBox)dataTiposCientifica.Items[k].FindControl("chkTipo")).Checked)
                tipos++;
        }
        //
        for (int k = 0; k < dataTiposIng.Items.Count; k++)
        {
            if (((CheckBox)dataTiposIng.Items[k].FindControl("chkTipo")).Checked)
                tipos++;
        }
        if (tipos == 0)
        {
            lblError.Text = "Debe seleccionar por lo menos un tipo de servicio de ingenieria o de cientifica!!!";
            return false;
        }

        if (txtObservaciones.Text == string.Empty)
        {
            lblError.Text = "Debe especificar las observaciones!!!";
            return false;
        }
        return true;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (validar())
        {
            SPControladoraDatos.dsCientifica ds=new SPControladoraDatos.dsCientifica();
            SPControladoraDatos.dsCientificaTableAdapters.estado_solicitud_generalTableAdapter estado=new SPControladoraDatos.dsCientificaTableAdapters.estado_solicitud_generalTableAdapter();
            SPControladoraDatos.dsCientificaTableAdapters.solicitud_generalTableAdapter solicitud = new SPControladoraDatos.dsCientificaTableAdapters.solicitud_generalTableAdapter();
            SPControladoraDatos.dsCientificaTableAdapters.equipos_solicitudTableAdapter equipos = new SPControladoraDatos.dsCientificaTableAdapters.equipos_solicitudTableAdapter();
            SPControladoraDatos.dsCientificaTableAdapters.reactivo_solicitudTableAdapter reactivos = new SPControladoraDatos.dsCientificaTableAdapters.reactivo_solicitudTableAdapter();
            SPControladoraDatos.dsCientificaTableAdapters.tipo_servicioxsolicitudTableAdapter tipoServicio = new SPControladoraDatos.dsCientificaTableAdapters.tipo_servicioxsolicitudTableAdapter();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            estado.FillByCod_manual(ds.estado_solicitud_general,1);
            int personas=0;
            int.TryParse(txtNumeroPersonasEntrenamiento.Text,out personas);

            solicitud.Insert(ds.estado_solicitud_general[0].cod_estado_solicitud_general,
                int.Parse(cmbAsesorComercial.SelectedValue),null,null,DateTime.Now,
                null,null,sacarNit(txtCliente.Text),cmbSucursal.SelectedValue,
                cmbContacto.SelectedValue,rdLegalizadoSi.Checked,
                rdAceptacionSi.Checked,personas,
                calInstalacionIngenieria.SelectedDate.HasValue? calInstalacionIngenieria.SelectedDate:(DateTime?)null,
                calEntrenamientoCientifica.SelectedDate.HasValue ? calEntrenamientoCientifica.SelectedDate : (DateTime?)null,
                txtObservaciones.Text,"",
                null,null,null,null,null,null,null,null,null,null,
                null,null,null,null,null,null,null,null,null,null,false);
            decimal? a=solicitud.verIdentity();
            if (!a.HasValue || a.Value == 0)
            {
                a = solicitud.verIdentityxUsuario(int.Parse(cmbAsesorComercial.SelectedValue));
            }
            int id = (int)a;
             //vamos con los equipos involucrados
            for (int k = 0; k < rdEquipos.Items.Count; k++)
            {
                string serial = rdEquipos.Items[k].Value.Trim();
                equipos.Insert(serial, id, null);
            }
             //vamos con los reactivos
            string sql = " ";
            
            for (int k = 0; k < rdReactivos.Items.Count; k++)
            {
                string reactivo = rdReactivos.Items[k].Text.Trim();
                sql = @"select cod_referencia_reactivo
from referencia_reactivo where rtrim(codigo_manual)+' ('+rtrim(nombre_referencia_reactivo)+')' = '" + reactivo + "'";

                int r = int.Parse(obj.ejecutarProcedimiento(sql).ToString());
                reactivos.Insert(id,r,  null);
            }
            //vamos con los tipos de servicio de ingenieria

            for (int k = 0; k < dataTiposIng.Items.Count; k++)
            {
                CheckBox ch = (CheckBox)dataTiposIng.Items[k].FindControl("chkTipo");
                if (ch.Checked)
                {
                    tipoServicio.Insert(id, "TIPOSERVING", int.Parse(ch.ValidationGroup), null, null);
                }
            }

            //vamos con los tipos de servicio de cientifica

            for (int k = 0; k < dataTiposCientifica.Items.Count; k++)
            {
                CheckBox ch = (CheckBox)dataTiposCientifica.Items[k].FindControl("chkTipo");
                if (ch.Checked)
                {
                    tipoServicio.Insert(id, "TIPOSERVCIE", int.Parse(ch.ValidationGroup), null, null);
                }
            }
            Response.Redirect("frmListadoGeneralSolicitudes.aspx");
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {

        Response.Redirect("frmListadoGeneralSolicitudes.aspx");
    }
}
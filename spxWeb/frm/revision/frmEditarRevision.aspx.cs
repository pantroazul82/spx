using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmEditarRevision : System.Web.UI.Page
{
    public class AutoCompleteResult
    {
        public string id { get; set; }
        public string value { get; set; }
    }

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
    public static string nit = "";
    protected void btnCliente_Click(object sender, EventArgs e)
    {
        cargarCliente();
    }

    protected void btnClienteFinal_Click(object sender, EventArgs e)
    {
        cargarClienteFinal();
    }

    public string sacarNit(string texto)
    {
        if (texto.LastIndexOf('(') <= 0)
            return "";
        string res = texto.Substring(texto.LastIndexOf('(') + 1);
        res = res.Substring(0, res.Length - 1);
        return res;
    }


    private void cargarClienteFinal()
    {
        nit = sacarNit(txtClienteFinal.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {

            sql = @"select codSucursal,nombreSucursal from sucursalCliente
				where nitCliente ='" + nit + "' ";
            cmbSucursalFinal.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbSucursalFinal.DataValueField = "codSucursal";
            cmbSucursalFinal.DataTextField = "nombreSucursal";
            cmbSucursalFinal.DataBind();
            //contactos
            /*   sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
                   where nitCliente ='" + nit + "' ";
               txtSocioNegocio.Text = nit;
               cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
               cmbContacto.DataValueField = "codContacto";
               cmbContacto.DataTextField = "nombre";
               cmbContacto.DataBind();
               lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;*/
        }
    }


    private void cargarCliente()
    {
        nit = sacarNit(txtCliente.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {

            sql = @"select codSucursal,nombreSucursal from sucursalCliente
				where nitCliente ='" + nit + "' ";
            cmbSucursal.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbSucursal.DataValueField = "codSucursal";
            cmbSucursal.DataTextField = "nombreSucursal";
            cmbSucursal.DataBind();
            //contactos
            /*   sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
                   where nitCliente ='" + nit + "' ";
               txtSocioNegocio.Text = nit;
               cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
               cmbContacto.DataValueField = "codContacto";
               cmbContacto.DataTextField = "nombre";
               cmbContacto.DataBind();
               lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;*/
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad objs = new clsSeguridad();
        objs.comprobarAcceso(Page, Session, Response, 2040);

        if (!IsPostBack)
        {
            if (Request.QueryString["cod"] != null && Request.QueryString["cod"] != string.Empty)
            {
                //calInicio.SelectedDate = DateTime.Now;
                //calFin.SelectedDate = DateTime.Now.AddHours(2);
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                ds.EnforceConstraints = false;
                SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
                SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estados = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                revision.FillBycod_revision_equipos(ds.revision_equipos, int.Parse(Request.QueryString["cod"]));

                if (!ds.revision_equipos[0].Isfecha_programacionNull())
                calInicio.SelectedDate = ds.revision_equipos[0].fecha_programacion;

                if(!ds.revision_equipos[0].Isfecha_fin_programacionNull())
                calFin.SelectedDate = ds.revision_equipos[0].fecha_fin_programacion;
                
                //--
                lblCodigoRevision.Text = ds.revision_equipos[0].cod_revision_equipos.ToString();
                if (!ds.revision_equipos[0].Isid_solicitudNull())
                    txtIdFo.Text = ds.revision_equipos[0].id_solicitud.ToString();

                if (!ds.revision_equipos[0].Isobservaciones_inicialesNull())
                    txtObservacionesiniciales.Text = ds.revision_equipos[0].observaciones_iniciales;
                cmbAsesorRecibe.SelectedValue = ds.revision_equipos[0].asesor_recibe.ToString();

                if (!ds.revision_equipos[0].Isresponsable_revisionNull())
                    cmbAsignadoA.SelectedValue = ds.revision_equipos[0].responsable_revision.ToString();
                cmbIngenieroRecibe.SelectedValue = ds.revision_equipos[0].ingeniero_entrega.ToString();
                if (!ds.revision_equipos[0].Iscod_origen_revision_equiposNull())
                    cmbOrigen.SelectedValue = ds.revision_equipos[0].cod_origen_revision_equipos.ToString();
                rdEquipoNuevo.Checked = ds.revision_equipos[0].equipo_nuevo;
                rdEquipoNoNuevo.Checked = !ds.revision_equipos[0].equipo_nuevo;
                lblFechaCreacion.Text = ds.revision_equipos[0].fecha_creacion.ToShortDateString() + " " + ds.revision_equipos[0].fecha_creacion.ToShortTimeString();
                lblCreadoPor.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario =" + ds.revision_equipos[0].usuario_creacion).ToString();
                List<string> list = new List<string>();
                list.Add(ds.revision_equipos[0].serial);
                string s = ds.revision_equipos[0].serial;
                controlSerial1.asignarCodigos(list);
                //
                estados.FillBycod_estado_revision_equipos(ds.estado_revision_equipos, ds.revision_equipos[0].cod_estado_revision_equipos);
                lblEstado.Text = ds.estado_revision_equipos[0].nombre_estado_revision_equipos;

                //informacion del serial
                string sql = "select rtrim(NombreModelo)+ ' ('+ rtrim(nombreFabricante)+')' from vistaEquipo where serial ='" + s.Trim() + "'";
                lblInformacionSerial.Text = "Modelo: " + bd.ejecutarProcedimiento(sql).ToString();
                sql = "select codOrdenServicio from ordenServicio where serial ='" + s + "' order by codOrdenServicio desc";
                cmbOrdenServicio.DataSource = bd.ejecutarConsulta(sql).Tables[0];
                cmbOrdenServicio.DataValueField = "codOrdenServicio";
                cmbOrdenServicio.DataTextField = "codOrdenServicio";
                cmbOrdenServicio.DataBind();
                if (ds.revision_equipos[0].Iscod_orden_servicioNull())
                {
                    cmbOrdenServicio.Items.Add(new ListItem("Seleccione", ""));
                    cmbOrdenServicio.SelectedValue = "";
                }
                else
                {
                    cmbOrdenServicio.SelectedValue = ds.revision_equipos[0].cod_orden_servicio.ToString();
                }
                //si y tiene cliente local se deja bloqueado para que no lo modifique
                if (!ds.revision_equipos[0].Isnit_clienteNull())
                {
                    sql = "select top 1 rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')' from clientes where nitCliente ='" + ds.revision_equipos[0].nit_cliente + "'";
                    txtCliente.Text = bd.ejecutarProcedimiento(sql).ToString();
                    cargarCliente();
                    cmbSucursal.SelectedValue = ds.revision_equipos[0].cod_sucursal.ToString();
                    txtCliente.ReadOnly = true;
                    cmbSucursal.Enabled = false;
                }
                //si y tiene cliente local se deja bloqueado para que no lo modifique
                if (!ds.revision_equipos[0].Isnit_cliente_nuevoNull())
                {
                    sql = "select top 1 rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')' from clientes where nitCliente ='" + ds.revision_equipos[0].nit_cliente_nuevo + "'";
                    txtClienteFinal.Text = bd.ejecutarProcedimiento(sql).ToString();
                    cargarClienteFinal();
                    cmbSucursalFinal.SelectedValue = ds.revision_equipos[0].cod_sucursal_nuevo.ToString();
                }

                //permite editar el serial si y solo si esta en estado 
                sql="select count(*) from archivo_template_revision_equipo where cod_revision_equipos ="+Request.QueryString["cod"];
                if (bd.ejecutarProcedimiento(sql).ToString().Trim() == "0")
                {
                    controlSerial1.ReadOnly = false;
                    chkEditaSerial.Checked = true;
                }
                else {
                    chkEditaSerial.Checked = false;
                    controlSerial1.ReadOnly = true;
                }
            }
        }
        registrarScriptCliente(txtCliente);
        string handler = ClientScript.GetPostBackEventReference(this.btnCliente, "");
        txtCliente.Attributes.Add("onblur", handler);
        //--
        registrarScriptCliente(txtClienteFinal);
        string handlerfinal = ClientScript.GetPostBackEventReference(this.btnClienteFinal, "");
        txtClienteFinal.Attributes.Add("onblur", handlerfinal);
    }


    private bool validar()
    {

        if (cmbOrigen.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar el origen de la solicitud.";
            return false;
        }
        if (cmbAsignadoA.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar a quien se asigna la revision";
            return false;
        }

        if (!calInicio.SelectedDate.HasValue)
        {
            lblError.Text = "Debe Ingresar la fecha y hora de ejecucion";
            return false;
        }

        if (!calFin.SelectedDate.HasValue)
        {
            lblError.Text = "Debe Ingresar la fecha y hora final de ejecucion";
            return false;
        }

        if (calInicio.SelectedDate > calFin.SelectedDate)
        {
            lblError.Text = "La fecha final de ejecucion no es coherente";
            return false;
        }

        if (txtCliente.Text.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar el Cliente.";
            return false;
        }

        if (cmbSucursal.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar la sucursal.";
            return false;
        }

        string nit = sacarNit(txtCliente.Text);
        if (nit.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar un cliente valido.";
            return false;
        }
        return true;
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (!validar()) return;
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        string nit = sacarNit(txtCliente.Text);
        string nit_cliente_nuevo = sacarNit(txtClienteFinal.Text);
        int? codOrden = null;

        if (cmbOrdenServicio.SelectedValue.Trim() != string.Empty)
        {
            codOrden = int.Parse(cmbOrdenServicio.Text);
        }
        
        revision.Updatetab1(int.Parse(cmbIngenieroRecibe.SelectedValue), int.Parse(cmbAsesorRecibe.SelectedValue),
            rdEquipoNuevo.Checked, txtObservacionesiniciales.Text, int.Parse(cmbAsignadoA.SelectedValue),
            int.Parse(cmbOrigen.SelectedValue), txtIdFo.Text, nit, cmbSucursal.SelectedValue,
            calInicio.SelectedDate, calFin.SelectedDate, codOrden,
            (nit_cliente_nuevo.Trim() == string.Empty) ? null : nit_cliente_nuevo,
            (cmbSucursalFinal.SelectedValue == string.Empty) ? null : cmbSucursalFinal.SelectedValue,
            int.Parse(Request.QueryString["cod"]));
      //actualimos el serial
        if (chkEditaSerial.Checked)
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            List<string> lista = controlSerial1.verCodigos();
            string nitCliente = "";
            string codSucursal = "";
            string codModelo = "";
            string codFabricante = "";
            string sql = @"select 
nitClienteubica,codSucursalUbica,codModelo,codFabricante
 from equipos where serial like '" + lista[0] + "' ";
            System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
            nitCliente = tb.Rows[0]["nitClienteubica"].ToString();
            codSucursal = tb.Rows[0]["codSucursalUbica"].ToString();
            codModelo = tb.Rows[0]["codModelo"].ToString();
            codFabricante = tb.Rows[0]["codFabricante"].ToString();
            int? codTemplate = null;
            sql = @"SELECT cod_template_revison_equipo FROM template_revison_equipo 
where codFabricante ='" + codFabricante.Trim() + "' and codModelo='" + codModelo.Trim() + "' and vigencia_hasta is null";
            System.Data.DataTable tb2 = bd.ejecutarConsulta(sql).Tables[0];
            if (tb2.Rows.Count > 0)
            {
                codTemplate = int.Parse(tb2.Rows[0]["cod_template_revison_equipo"].ToString());
            }
            int? codOrdenServicio = null;
            if (cmbOrdenServicio.SelectedValue.Trim() != string.Empty)
            {
                codOrdenServicio = int.Parse(cmbOrdenServicio.Text);
            }
            revision.UpdateSerial(lista[0], codModelo, nitCliente, codSucursal, codTemplate, codOrdenServicio,
                int.Parse(Request.QueryString["cod"]));
        }
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

}
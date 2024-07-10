using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmDetalleContrato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.QueryString["cod"] == null)
            {
                Response.Redirect("~/default.aspx");
                return;
            }
        
            //--
            SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter cs=new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter ();
            SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter estado = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter();
            SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
            cs.FillByCod_contratos_suministro(ds.contratos_suministro, int.Parse( Request.QueryString["cod"] ));
            //cargamos los datos
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            calCreacion.Date = ds.contratos_suministro[0].fecha_creacion;
            calFechaInicio.Date = ds.contratos_suministro[0].fecha_incio;
            calFechaTerminacion.Date = ds.contratos_suministro[0].fecha_terminacion;
            if (!ds.contratos_suministro[0].Isfecha_otro_siNull())
            calFechaUltimoOtroSi.Date = ds.contratos_suministro[0].fecha_otro_si;
            if (!ds.contratos_suministro[0].Isgenera_multaNull()) chkGeneraMulta.Checked = ds.contratos_suministro[0].genera_multa;
                 
            lblcodigoContrato.Text = Request.QueryString["cod"];
            lblOtroSi.Text = ds.contratos_suministro[0].otrosi;
            lblNumeroContrato.Text = ds.contratos_suministro[0].numero_contrato;
            lblConsecutivoInterno.Text = ds.contratos_suministro[0].consecutivo_interno;
            HyperLink1.NavigateUrl = HyperLink1.NavigateUrl + ds.contratos_suministro[0].nitCliente;
            lblcliente.Text = bd.ejecutarProcedimiento("select rtrim(nombreCliente)+' ('+rtrim(nitCliente)+') Socio de Negocio:'+rtrim(numeroSocio) from clientes where nitCliente ='"+ds.contratos_suministro[0].nitCliente+"'").ToString();
            lblEstado.Text = bd.ejecutarProcedimiento("select rtrim(nombre_estado_contrato_suministro) from estado_contrato_suministro where cod_estado_contrato_suministro ='" + ds.contratos_suministro[0].cod_estado_contrato_suministro + "'").ToString();

            lblSucursal.Text = bd.ejecutarProcedimiento("select nombreSucursal from sucursalCliente where nitCliente ='" + ds.contratos_suministro[0].nitCliente + "' and codSucursal='" + ds.contratos_suministro[0].codSucursal + "'").ToString();
            lblContacto.Text = bd.ejecutarProcedimiento("select rtrim(nombreContacto)+' '+rtrim(apellidosContacto)+' ('+rtrim(isnull(cargo,''))+')'  from contactosClientes where nitCliente='" + ds.contratos_suministro[0].nitCliente + "' and codContacto='"+ds.contratos_suministro[0].codContacto+"'").ToString();
            lblCiudadEnvioContrato.Text = bd.ejecutarProcedimiento(@"select 
rtrim(ciudades.nombreCiudad)+ ' ('+departamentos.NombreDepartamento+')'
 from ciudades 
join departamentos on departamentos.codDepartamento = ciudades.codDepartamento and departamentos.codPais = ciudades.codPais


where departamentos.codPais ='" + ds.contratos_suministro[0].codPais_envio_contrato + "' and departamentos.codDepartamento='" + ds.contratos_suministro[0].codDepartamento_envio_contrato + "' and codCiudad ='" + ds.contratos_suministro[0].codCiudad_envio_contrato + "'").ToString();



            if (!ds.contratos_suministro[0].Isfecha_limite_legalizacionNull()) calLimiteLegalizacion.Date = ds.contratos_suministro[0].fecha_limite_legalizacion;
            lbldireccionEnvio.Text = ds.contratos_suministro[0].direccion_envio_contrato;
            lblContactoJuridico.Text = ds.contratos_suministro[0].contacto_juridico;
            lblCelularContactoJuridico.Text = ds.contratos_suministro[0].numero_celular_contacto_juridico;
            lblValorContrato.Text = string.Format("{0:c}", ds.contratos_suministro[0].valor_contrato);
            chkAplicaEstampilla.Checked = ds.contratos_suministro[0].aplica_estampilla;
            txtObservaciones.Text = ds.contratos_suministro[0].observaciones;
            chkAplicaPolizas.Checked = ds.contratos_suministro[0].aplica_polizas;
            
            lblCreadoPor.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario ="+ds.contratos_suministro[0].cod_usuario_asesor).ToString();
            //
            if (!chkAplicaEstampilla.Checked && !chkAplicaPolizas.Checked)
            {
                RadTabStripFormulario.Tabs[1].Visible = false;
            }
            btnGenerarOtroSi.Visible = false;
           //ahora ocultamos botones de acuerdo a los estados
            estado.FillBycod_estado_contrato_suministro(ds.estado_contrato_suministro, ds.contratos_suministro[0].cod_estado_contrato_suministro);
            if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "7")//anulado
            {
                btnEditar.Visible = false;
                btnAnular.Text = "Ver Informacion Anulacion";

               
                btnGenerarOtroSi.Visible = false;
                btnAprobarDinamico.Visible = false;
                btnAdjuntarDocumento.Visible = false;
                btnAgregarPagoAdicional.Visible = false;
                btnAgregarPoliza.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUploadArchivo.Visible = false;
                cmbTipoArchivo.Visible = false;
            }else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "6")//cerrado
            {
                btnEditar.Visible = false;
                btnGenerarOtroSi.Visible = false;
                btnAprobarDinamico.Visible = false;
                btnAdjuntarDocumento.Visible = false;
                btnAgregarPagoAdicional.Visible = false;
                btnAgregarPoliza.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUploadArchivo.Visible = false;
                cmbTipoArchivo.Visible = false;

                btnReabrir.Visible = true;
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "5")//activo
            {
                btnGenerarOtroSi.Visible = true;
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "4")//aprobacion juridico
            {
                //verificamos si tiene permisos para aprobar cuando esta en aprobacion juridico si no ocultamos el boton
                btnAprobarDinamico.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2056, int.Parse(Session["ss_cod_usuario"].ToString()), Session); 
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "3")//aprobacion cartera
            {
                btnAprobarDinamico.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2057, int.Parse(Session["ss_cod_usuario"].ToString()), Session); 
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "1")//primer aprobacion
            {
                btnGenerarOtroSi.Visible = false;
                btnAdjuntarDocumento.Visible = false;
                btnAprobarDinamico.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2055, int.Parse(Session["ss_cod_usuario"].ToString()), Session); 
            }

            //ahora ocultamos de acuerdo a los permisos
            clsSeguridad seguridad=new clsSeguridad();
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2067, int.Parse(Session["ss_cod_usuario"].ToString()), Session) && btnAnular.Text != "Ver Informacion Anulacion")
            {
                btnAnular.Visible = false;
            }

            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2071, int.Parse(Session["ss_cod_usuario"].ToString()), Session) )
            {
                btnReabrir.Visible = false;
            }

            btnAgregarPoliza.Visible =  SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2069, int.Parse(Session["ss_cod_usuario"].ToString()), Session);
            btnAgregarPagoAdicional.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2068, int.Parse(Session["ss_cod_usuario"].ToString()), Session); 
        }
    }
    protected void btnSubirArchivo_Click(object sender, EventArgs e)
    {
        lblErrorArchivo.Text = "";
        if (!FileUploadArchivo.HasFile)
        {
            lblErrorArchivo.Text = "Seleccione el archivo";
            return;
        }
        SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter t = new SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter();
        t.Insert(int.Parse(Request.QueryString["cod"]),
            int.Parse(cmbTipoArchivo.SelectedValue), System.IO.Path.GetFileName(FileUploadArchivo.FileName),
            FileUploadArchivo.FileBytes, DateTime.Now);
        grdArchivo.DataBind();
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

    protected void btnAgregarPoliza_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmPolizas.aspx?cod="+Request.QueryString["cod"]);
    }

    protected void btnEditarPoliza_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        Response.Redirect("frmPolizas.aspx?cod=" + Request.QueryString["cod"]+"&codc="+b.CommandArgument);
    }

    protected void btnEliminarPoliza_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.polizas_contrato_suministroTableAdapter();

        try {
            p.DeleteQuery(int.Parse(b.CommandArgument));
            grdPoliza.DataBind();
        }catch(Exception){}
    }

    protected void btnAgregarPagoAdicional_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEstampillas.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnEditarEstampilla_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        Response.Redirect("frmEstampillas.aspx?cod=" + Request.QueryString["cod"] + "&codc=" + b.CommandArgument);
    }

    protected void btnEliminarEstampilla_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.estampillas_contrato_sumisnistroTableAdapter();

        try
        {
            p.DeleteQuery(int.Parse(b.CommandArgument));
            grdPagoAdicional.DataBind();
        }
        catch (Exception) { }
    }
    protected void btnEditar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCrearContrato.aspx?cod="+Request.QueryString["cod"]);
    }
    protected void btnExportarExcel_Click(object sender, EventArgs e)
    {
        ASPxGridViewExporterEstados.WriteXlsxToResponse();
    }
    protected void btnAnular_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAnularContrato.aspx?cod="+Request.QueryString["cod"]);
    }
    protected void btnAceptarCambioEstado_Click(object sender, EventArgs e)
    {
        if (txtObservacionesCambioEstado.Text.Trim() == string.Empty)
        {
            lblErrorCambioEstado.Text = "Las observaciones son obligatorias";
            return;
        } 
        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter cs = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
        SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter estado = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter log = new SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter();
        estado.FillBycod_estado_contrato_suministro(ds.estado_contrato_suministro, int.Parse(cmbEstado.SelectedValue));
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        //dependiendo el estado al que va realizamos validaciones
        if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "4" || ds.estado_contrato_suministro[0].cod_manual.Trim() == "5")//en aprobacion cartera
        { 
        //verficamos si es obligatorio las estampillas
            if (chkAplicaEstampilla.Checked && grdPagoAdicional.DetailRows.VisibleCount ==0)
            {
                lblErrorCambioEstado.Text = "Es necesario que ingrese las estampillas o pagos adicionales.";
                return;
            }
        }
        //cambiamos el estado
     
        cs.UpdateEstado(int.Parse(cmbEstado.SelectedValue),int.Parse(Request.QueryString["cod"]));
        //insertamos en el log
        log.FillByCod_contratos_suministroUltimo(ds.log_cambios_estado_contratos_suministro,
            int.Parse(Request.QueryString["cod"]));

        log.Insert(DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()),
            txtObservacionesCambioEstado.Text, int.Parse(cmbEstado.SelectedValue),            int.Parse(Request.QueryString["cod"]),
            ds.log_cambios_estado_contratos_suministro[0].cod_estado_contrato_suministro,
            (int)DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).TotalHours,
            (int)DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).Minutes);

        clsSeguridad cls = new clsSeguridad();
        string asunto = "Contrato de suministro requiere su atención cod:" + lblcodigoContrato.Text+" estado "+ds.estado_contrato_suministro[0].nombre_estado_contrato_suministro;
        string cuerpo = @"Actualizacion de estado para contrato de suministro<br>
Cod Contrato:" + lblcodigoContrato.Text + @"<br>
Estado:"+ds.estado_contrato_suministro[0].nombre_estado_contrato_suministro+@"<br>
Cliente:" + lblcliente.Text + @"<br>
Vigencia desde:" + calFechaInicio.Date.ToLongDateString() + @" <br>
Vigencia hasta:" + calFechaTerminacion.Date.ToLongDateString() + @"<br> 
Observaciones:" + txtObservacionesCambioEstado.Text.Replace("\r\n", "<br>").Replace("\n", "<br>") + @"<br> "+
                   @"<a href='" + cls.verIpSitiio() + @"frm/csuministro/frmDetalleContrato.aspx?cod=" + lblcodigoContrato.Text + "'  >Ver Contrato</a><br>" +
                   "verifique la información para la respectiva aprobación. ";
        List<string> lista = new List<string>();
        //enviamos correos
        string sqlAutor = @"select usuario.correo from contratos_suministro 
join usuario on usuario.cod_usuario =contratos_suministro.cod_usuario_asesor
where cod_contratos_suministro ='"+lblcodigoContrato.Text+"'";
        if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "0")
        { 
        //enviamos correo solo al que lo creo.
            lista.Add(bd.ejecutarProcedimiento(sqlAutor).ToString());
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "1")
        {
            //enviamos correo a quienes realizan la primera aprobacion.
            lista = cls.verCorreos(2055);
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "3")
        {
            //enviamos correo a quienes realizan aprobacion cartera.
            lista = cls.verCorreos(2057);
            //cuando envia a aprobacion cartera tambien envia a quienes emiten polizas
            List<string> listaT = cls.verCorreos(2069);
            for (int k = 0; k < listaT.Count; k++)
            {
                if (!lista.Contains(listaT[k]))
                lista.Add(listaT[k]);
            }
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "4")
        {
            //enviamos correo a quienes realizanaprobacion juridica.
            lista = cls.verCorreos(2056);
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "5"
            || ds.estado_contrato_suministro[0].cod_manual.Trim() == "6"
            || ds.estado_contrato_suministro[0].cod_manual.Trim() == "7")
        {
            //enviamos correo a quien lo creo
            lista.Add(bd.ejecutarProcedimiento(sqlAutor).ToString());
        }

        for (int k = 0; k < lista.Count; k++)
        {
            if(lista[k].Trim() != string.Empty)
            cls.enviarEmail(asunto, cuerpo, lista[k]);
            if (chkGeneraMulta.Checked)
            {
                string asuntoI = "Se requiere de atencion urgente para un contrato de suministro para antes de: " + calLimiteLegalizacion.Date.ToLongDateString();
                cls.enviarCalendario(asuntoI, asuntoI, asuntoI + "<br>" + cuerpo, calLimiteLegalizacion.Date.AddDays(-1), calLimiteLegalizacion.Date, "", lista[k]);
            }
        }

        Panel1_ModalPopupExtender.Hide();
        Response.Redirect("frmDetalleContrato.aspx?cod="+Request.QueryString["cod"]);
    }

    protected void btnCancelarCambioEstado_Click(object sender, EventArgs e)
    {
        Panel1_ModalPopupExtender.Hide();
    }

    protected void btnAprobarDinamico_Click(object sender, EventArgs e)
    {
        string sql = @"SELECT [cod_estado_contrato_suministro], [nombre_estado_contrato_suministro] 
FROM [estado_contrato_suministro] 
WHERE
  cod_manual != 7
and cod_estado_contrato_suministro not in (select cod_estado_contrato_suministro from 
contratos_suministro where cod_contratos_suministro ='"+Request.QueryString["cod"]+@"') ORDER BY [cod_manual]";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        cmbEstado.DataSource= bd.ejecutarConsulta(sql).Tables[0];
        cmbEstado.DataTextField = "nombre_estado_contrato_suministro";
        cmbEstado.DataValueField = "cod_estado_contrato_suministro";
        cmbEstado.DataBind();

//calculamos el estado al cual deberia ir normalmente
        cmbEstado.SelectedValue = bd.ejecutarProcedimiento(@"
select top 1 cod_estado_contrato_suministro from estado_contrato_suministro where cod_manual in (
    SELECT 

case when cast([cod_manual] as int) +1 =2 then 3 else cast([cod_manual] as int) +1 end
FROM [estado_contrato_suministro] WHERE
    cod_estado_contrato_suministro in (select cod_estado_contrato_suministro from contratos_suministro where cod_contratos_suministro ='" + Request.QueryString["cod"] + @"')
)
").ToString();

        Panel1_ModalPopupExtender.Show();
        txtObservacionesCambioEstado.Text = "";
    }

    protected void btnReabrir_Click(object sender, EventArgs e)
    {
        string sql = @"SELECT [cod_estado_contrato_suministro], [nombre_estado_contrato_suministro] 
FROM [estado_contrato_suministro] 
WHERE  cod_manual = 5";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        cmbEstado.DataSource = bd.ejecutarConsulta(sql).Tables[0];
        cmbEstado.DataTextField = "nombre_estado_contrato_suministro";
        cmbEstado.DataValueField = "cod_estado_contrato_suministro";
        cmbEstado.DataBind();

        //calculamos el estado al cual deberia ir normalmente
        cmbEstado.SelectedValue = bd.ejecutarProcedimiento(@"
select top 1 cod_estado_contrato_suministro from estado_contrato_suministro where cod_manual =5").ToString();

        Panel1_ModalPopupExtender.Show();
        txtObservacionesCambioEstado.Text = "";
    }
}
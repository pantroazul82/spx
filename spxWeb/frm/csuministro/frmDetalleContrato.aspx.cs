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
        if (Session["ss_cod_usuario"] == null) Response.Redirect("~/default.aspx");
        btnFileUploadArchivo.Attributes.Add("onclick", "jQuery('#" + FileUploadArchivo.ClientID + "').click();return false;");
        btnFileUploadCambio.Attributes.Add("onclick", "jQuery('#" + FileUploadCambio.ClientID + "').click();return false;");
        
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

            if (!ds.contratos_suministro[0].Isobservaciones_otro_siNull())
                txtObservacionesOtroSi.Text = ds.contratos_suministro[0].observaciones_otro_si;

            if (!ds.contratos_suministro[0].Iscod_tipo_otro_si_suministroNull())
                cmbTipoOtroSi.SelectedValue = ds.contratos_suministro[0].cod_tipo_otro_si_suministro.ToString();


            if (!ds.contratos_suministro[0].Isgenera_multaNull()) chkGeneraMulta.Checked = ds.contratos_suministro[0].genera_multa;
                 
            lblcodigoContrato.Text = Request.QueryString["cod"];
            lblOtroSi.Text = ds.contratos_suministro[0].otrosi;
            if (lblOtroSi.Text.Trim() != string.Empty)
            {
                pnlOtroSi.Visible = true;
            }
            else {
                pnlOtroSi.Visible = false;
            }
            lblNumeroContrato.Text = ds.contratos_suministro[0].numero_contrato;
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
            //miramos la suma del log
            string sql = @"select 
max(fecha_cambio) 'fecha_cambio',
cod_contratos_suministro,
sum(horas) 'horas',sum(minutos) 'minutos' from log_cambios_estado_contratos_suministro
where cod_contratos_suministro =" + lblcodigoContrato.Text + " group by cod_contratos_suministro";
           System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];
           if (tb.Rows.Count > 0)
           {
               lblSumaCambiosEstado.Text = tb.Rows[0][2].ToString() + " horas " + tb.Rows[0][3].ToString() + " minutos";
               int nh, nm;
               calcularHorasHabiles((DateTime)tb.Rows[0][0], DateTime.Now, out nh, out nm);
               nh = nh + int.Parse(tb.Rows[0][2].ToString()) + (int)(nm/60);
               nm = nm + int.Parse(tb.Rows[0][3].ToString());
               nm = nm % 60;
               lblTiempoHastaFechaActual.Text = nh + " horas " + nm.ToString().PadLeft(2,'0') + " minutos ";
           }

           //ahora ocultamos botones de acuerdo a los estados
            estado.FillBycod_estado_contrato_suministro(ds.estado_contrato_suministro, ds.contratos_suministro[0].cod_estado_contrato_suministro);
            if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "11")//anulado
            {
                btnEditar.Visible = false;
                btnAnular.Text = "Ver Informacion Anulacion";

               
                btnGenerarOtroSi.Visible = false;
                btnAprobarDinamico.Visible = false;
                btnAdjuntarDocumento.Visible = false;
                btnAgregarEstampillas.Visible = false;
                btnAgregarPoliza.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUploadArchivo.Visible = false;
                cmbTipoArchivo.Visible = false;
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "12")//legalizado
            {
                btnEditar.Visible = false;
                btnAnular.Text = "Ver Informacion Anulacion";


                btnGenerarOtroSi.Visible = true;
                btnAdjuntarDocumento.Visible = true;
                btnSubirArchivo.Visible = true;
                FileUploadArchivo.Visible = true;
                cmbTipoArchivo.Visible = true;
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "7")//cerrado
            {
                btnEditar.Visible = false;
                btnGenerarOtroSi.Visible = false;
                btnAprobarDinamico.Visible = false;
                btnAdjuntarDocumento.Visible = false;
                btnAgregarEstampillas.Visible = false;
                btnAgregarPoliza.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUploadArchivo.Visible = false;
                cmbTipoArchivo.Visible = false;

                btnReabrir.Visible = true;
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "6")//activo
            {
                btnGenerarOtroSi.Visible = true;
                btnAdjuntarDocumento.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2074, int.Parse(Session["ss_cod_usuario"].ToString()), Session); 
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "5")//activo pendiente estampillas
            {
                btnGenerarOtroSi.Visible = true;
                btnAdjuntarDocumento.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2074, int.Parse(Session["ss_cod_usuario"].ToString()), Session);
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "4")//aprobacion juridico
            {
                //verificamos si tiene permisos para aprobar cuando esta en aprobacion juridico si no ocultamos el boton
                btnAprobarDinamico.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2056, int.Parse(Session["ss_cod_usuario"].ToString()), Session); 
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "3")//administrativo
            {
                btnAprobarDinamico.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2069, int.Parse(Session["ss_cod_usuario"].ToString()), Session);
            }
            else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "2")//aprobacion cartera
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
            btnAgregarEstampillas.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2068, int.Parse(Session["ss_cod_usuario"].ToString()), Session); 
            //btnAgregarPoliza.Visible = false;
            // btnAgregarEstampillas.Visible =false;
            //validamos si esta viendo la informacion de un otro si, de ser asi inhabilitamos todos los botones
             int cnt=int.Parse(bd.ejecutarProcedimiento("select count(*) from contratos_suministro where cod_contratos_suministro>"+Request.QueryString["cod"]+" and consecutivo_interno='"+lblNumeroContrato.Text+"'").ToString());
             if (cnt > 0)
             {
                 btnAnular.Visible = false;
                 btnAprobarDinamico.Visible = false;
                 btnEditar.Visible = false;
                 btnAdjuntarDocumento.Visible = false;
                 btnAgregarPoliza.Visible = false;
                 btnAgregarEstampillas.Visible = false;
                 btnGenerarOtroSi.Visible = false;
                 btnReabrir.Visible = false;
                 btnSubirArchivo.Visible = false;
             }
             actualizarEstatusAdjuntos();
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

        
        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "archivconsumo" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUploadArchivo.FileName);
        FileUploadArchivo.SaveAs(ruta + archivo);
     
        t.Insert(int.Parse(Request.QueryString["cod"]),
            int.Parse(cmbTipoArchivo.SelectedValue), System.IO.Path.GetFileName(FileUploadArchivo.FileName), DateTime.Now, "~/files/" + archivo);
        
        grdArchivo.DataBind();
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
        if (pnlCambioEstadoArchivo.Visible && lnkArchivoCambio.NavigateUrl.Trim()== string.Empty)
        {
            lblErrorCambioEstado.Text = "EL archivo "+cmbTipoArchivoCambio.SelectedItem.Text+" es obligatorio!";
            return;
        }
        //validaciones especiales dependiendo el estado
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        

        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter cs = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
        SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter estado = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter log = new SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter();
        estado.FillBycod_estado_contrato_suministro(ds.estado_contrato_suministro, int.Parse(cmbEstado.SelectedValue));
     
        if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "4")
        {
            string sql = @"SELECT count(*) FROM [polizas_contrato_suministro] WHERE [cod_contratos_suministro] ="+Request.QueryString["cod"]+" and valor_poliza=0 or valor_poliza is null";
            
            if (bd.ejecutarProcedimiento(sql).ToString() != "0")
            {
                lblErrorCambioEstado.Text = "Existen polizas sin valor asignado!";
                return;
            }

            sql = @"SELECT count(*) FROM [polizas_contrato_suministro] WHERE [cod_contratos_suministro] =" + Request.QueryString["cod"] + " and cod_aseguradora_suministro is null";

            if (bd.ejecutarProcedimiento(sql).ToString() != "0")
            {
                lblErrorCambioEstado.Text = "Existen polizas aseguradora asignada!";
                return;
            }
        }
        if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "6")
        {
            string sql = @"SELECT count(*) FROM [estampillas_contrato_sumisnistro] WHERE [cod_contratos_suministro] =" + Request.QueryString["cod"] + " and (url_archivo is null or url_archivo ='')";

            if (bd.ejecutarProcedimiento(sql).ToString() != "0")
            {
                lblErrorCambioEstado.Text = "Existen estampillas sin archivo escaneado!";
                return;
            }
        }

   
        //dependiendo el estado al que va realizamos validaciones
        //if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "4" || ds.estado_contrato_suministro[0].cod_manual.Trim() == "6")//en aprobacion cartera
        //{ 
        ////verficamos si es obligatorio las estampillas
        //    if (chkAplicaEstampilla.Checked && grdPagoAdicional.DetailRows.VisibleCount ==0)
        //    {
        //        lblErrorCambioEstado.Text = "Es necesario que ingrese las estampillas o pagos adicionales.";
        //        return;
        //    }
        //}
        //cambiamos el estado
     
        cs.UpdateEstado(int.Parse(cmbEstado.SelectedValue),int.Parse(Request.QueryString["cod"]));
        //insertamos en el log
        log.FillByCod_contratos_suministroUltimo(ds.log_cambios_estado_contratos_suministro,
            int.Parse(Request.QueryString["cod"]));
        int? codArchivo = null;
        if (pnlCambioEstadoArchivo.Visible)
        {
            SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter archivoTa = new SPControladoraDatos.dsContratosSuministroTableAdapters.archivoxcontratos_suministroTableAdapter();
            if (lnkArchivoCambio.CssClass.Trim() == string.Empty)
            {
                archivoTa.Insert(int.Parse(Request.QueryString["cod"]),
                    int.Parse(cmbTipoArchivoCambio.SelectedValue.ToString()),
                    System.IO.Path.GetFileName(lnkArchivoCambio.NavigateUrl),
                    DateTime.Now, lnkArchivoCambio.NavigateUrl);
                codArchivo = archivoTa.verIdentity(int.Parse(Request.QueryString["cod"])).Value;
            }else{
                codArchivo = int.Parse(lnkArchivoCambio.CssClass);
            }
        }
        int horas = 0;//(int)DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).TotalHours,
        int Minutos = 0;//(int)DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).Minutes
        calcularHorasHabiles(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio, DateTime.Now,
            out horas,out Minutos);
        log.Insert(DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()),
            txtObservacionesCambioEstado.Text, int.Parse(cmbEstado.SelectedValue),            int.Parse(Request.QueryString["cod"]),
            ds.log_cambios_estado_contratos_suministro[0].cod_estado_contrato_suministro,
            horas,
            Minutos,
            codArchivo);

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
        lista = cls.verCorreos(2055);//ponemos que siempre copie al tecnico contraactual que es quien siempre da la primera aprobacion
        if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "0")
        { 
            //enviamos correo solo al que lo creo.
            lista.Add(bd.ejecutarProcedimiento(sqlAutor).ToString());
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "1")
        {
            //enviamos correo a quienes realizan la primera aprobacion.
            //lista = cls.verCorreos(2055);
            //ponermos que siempre copie al tecnico contraactual
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "2")
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
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "3")
        {
            //enviamos correo a quienes realizan aprobacion cartera.
            lista = cls.verCorreos(2069);
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "4")
        {
            //enviamos correo a quienes realizanaprobacion juridica.
            lista = cls.verCorreos(2056);
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "5")
        {
            //enviamos correo a quienes suben las estampillas.
            lista = cls.verCorreos(2068);
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "6"
            //6 es activo y 7 cerrado
            || ds.estado_contrato_suministro[0].cod_manual.Trim() == "7")
        {
            //enviamos correo a quien lo creo
            lista.Add(bd.ejecutarProcedimiento(sqlAutor).ToString());
        }
        else if (ds.estado_contrato_suministro[0].cod_manual.Trim() == "12")
        {
            //enviamos correo a quien lo creo
            lista.Add(bd.ejecutarProcedimiento(sqlAutor).ToString());
        }



        //hacemos esto para eliminar los duplicados
        for (int k = 0; k < lista.Count; k++)
        {
            if (lista.IndexOf(lista[k]) != lista.LastIndexOf(lista[k]))
            {
                lista.RemoveAt(lista.LastIndexOf(lista[k]));
                k--;
            }
        }

        for (int k = 0; k < lista.Count; k++)
        {
            string msg="";
            List<string> adjuntos = new List<string>();
            if (pnlCambioEstadoArchivo.Visible)
            {
                string ruta = Server.MapPath("~/files/");
                adjuntos.Add(ruta+ System.IO.Path.GetFileName( lnkArchivoCambio.NavigateUrl));
            }
            //validamos casos especiales donde hay que adjuntar mas de un archivo.
            if (chkGeneraMulta.Checked)
            {
                string asuntoI = "Se requiere de atencion urgente para un contrato de suministro para antes de: " + calLimiteLegalizacion.Date.ToLongDateString();
                cls.enviarCalendario(asuntoI, asuntoI, asuntoI + "<br>" + cuerpo, calLimiteLegalizacion.Date.AddDays(-1), calLimiteLegalizacion.Date,
                    Server.MapPath("~/temp/"), lista[k]);
            }
            else if(lista[k].Trim() != string.Empty)
            cls.enviarEmail(asunto, cuerpo, lista[k],adjuntos,out msg);
            
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
        //todos los estados pueden 
        string sql = @"SELECT [cod_estado_contrato_suministro], [nombre_estado_contrato_suministro] 
FROM [estado_contrato_suministro] 
WHERE
  cod_manual != '11'
and cod_estado_contrato_suministro not in (select cod_estado_contrato_suministro from 
contratos_suministro where cod_contratos_suministro ='"+Request.QueryString["cod"]+@"') ORDER BY [cod_manual]";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        cmbEstado.DataSource= bd.ejecutarConsulta(sql).Tables[0];
        cmbEstado.DataTextField = "nombre_estado_contrato_suministro";
        cmbEstado.DataValueField = "cod_estado_contrato_suministro";
        cmbEstado.DataBind();

//calculamos el estado al cual deberia ir normalmente
        object tttt=bd.ejecutarProcedimiento(@"
select top 1 cod_estado_contrato_suministro from estado_contrato_suministro where cod_manual in (
    SELECT 

case when cast([cod_manual] as int) +1 =2 then 2 else cast([cod_manual] as int) +1 end
FROM [estado_contrato_suministro] WHERE
    cod_estado_contrato_suministro in (select cod_estado_contrato_suministro from contratos_suministro where cod_contratos_suministro ='" + Request.QueryString["cod"] + @"')
)
");
        if (tttt != null && tttt != System.DBNull.Value)
        {
            cmbEstado.SelectedValue = tttt.ToString();
        }
        //evaluamos si debe hacer un salto en el flujo esto generalmente pasa cuando
        //no debe comprar polizas y cuando no debe pagar estampillas
        string cod = cmbEstado.SelectedValue;
        sql = "select cod_manual from [estado_contrato_suministro] WHERE " +
            "cod_estado_contrato_suministro =" + cod;
        string codM = bd.ejecutarProcedimiento(sql).ToString().Trim();
        if (codM == "3" && !chkAplicaPolizas.Checked ||
            codM == "5" && !chkAplicaEstampilla.Checked
            )
        {
            cmbEstado.SelectedValue = bd.ejecutarProcedimiento(@"
select top 1 cod_estado_contrato_suministro from estado_contrato_suministro where cod_manual in (
    SELECT 
cast([cod_manual] as int) +2 
FROM [estado_contrato_suministro] WHERE
    cod_estado_contrato_suministro in (select cod_estado_contrato_suministro from contratos_suministro where cod_contratos_suministro ='" + Request.QueryString["cod"] + @"')
)
").ToString();
        }

        estadoPanelArchivoCambio();
        Panel1_ModalPopupExtender.Show();
        txtObservacionesCambioEstado.Text = "";
    }

    private void estadoPanelArchivoCambio()
    {
        string cod = cmbEstado.SelectedValue;
        string sql = "select cod_manual from [estado_contrato_suministro] WHERE "+
            "cod_estado_contrato_suministro ="+cod;
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        string codM = bd.ejecutarProcedimiento(sql).ToString().Trim();
        if ( codM=="3"  || codM=="12"  /*||(codM == "4" && chkAplicaPolizas.Checked) ||*/ 
            /*( codM=="6" && chkAplicaEstampilla.Checked)*/
            )
        {
            pnlCambioEstadoArchivo.Visible = true;
            
            lnkArchivoCambio.Visible = false;
            lnkArchivoCambio.NavigateUrl = "";

            if (codM == "2")
            {//aprobacion cartera debe adjuntar el documento escaneado
              //  Session["codmanualcambioestado"] = "4";
            }
            if (codM == "3")
            {//adminsitrativo 
                  Session["codmanualcambioestado"] = "7";
            }
            if (codM == "4")
            {//si es juridico, debe adjuntar las polizas
                //Session["codmanualcambioestado"] = "5";
            }
            if (codM == "6" )
            {//si es activo, debe adjuntar las estampillas
              //  Session["codmanualcambioestado"] = "6";
            }
            if (codM == "12")
            {//si es activo, debe adjuntar las estampillas
                //  Session["codmanualcambioestado"] = "6";
                Session["codmanualcambioestado"] = "66";
            }
            //validamos si ya esta creado el archivo
             sql = @"select top 1 cod_archivoxcontratos_suministro,ruta_archivo from archivoxcontratos_suministro
join tipoarchivoxcontratos_suministro on tipoarchivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro
=archivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro
where cod_contratos_suministro="+Request.QueryString["cod"]+@" and tipoarchivoxcontratos_suministro.cod_manual='" + Session["codmanualcambioestado"] + @"'
order by cod_archivoxcontratos_suministro desc";
            System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
            if (tb.Rows.Count > 0)
            {
                lnkArchivoCambio.Visible = true;
                lnkArchivoCambio.NavigateUrl = tb.Rows[0][1].ToString();
                lnkArchivoCambio.CssClass = tb.Rows[0][0].ToString();
            }
            else {
                lnkArchivoCambio.Visible = false;
                lnkArchivoCambio.NavigateUrl = "";
                lnkArchivoCambio.CssClass = "";
            }
        }else {
            Session["codmanualcambioestado"] = null;
            pnlCambioEstadoArchivo.Visible = false;
            lnkArchivoCambio.Visible = false;
            lnkArchivoCambio.NavigateUrl = "";
        }
    }

    protected void btnReabrir_Click(object sender, EventArgs e)
    {
        string sql = @"SELECT [cod_estado_contrato_suministro], [nombre_estado_contrato_suministro] 
FROM [estado_contrato_suministro] 
WHERE  cod_manual = 6";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        cmbEstado.DataSource = bd.ejecutarConsulta(sql).Tables[0];
        cmbEstado.DataTextField = "nombre_estado_contrato_suministro";
        cmbEstado.DataValueField = "cod_estado_contrato_suministro";
        cmbEstado.DataBind();

        //calculamos el estado al cual deberia ir normalmente
        cmbEstado.SelectedValue = bd.ejecutarProcedimiento(@"
select top 1 cod_estado_contrato_suministro from estado_contrato_suministro where cod_manual =6").ToString();

        Panel1_ModalPopupExtender.Show();
        txtObservacionesCambioEstado.Text = "";
    }
    protected void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
        estadoPanelArchivoCambio();
    }
    protected void btnSubirArchivoCambio_Click(object sender, EventArgs e)
    {
        if (!FileUploadCambio.HasFile)
        {
            lblErrorCambioEstado.Text = "Seleccione el archivo ";
            return;
        }

        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "ce" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUploadCambio.FileName);
        FileUploadCambio.SaveAs(ruta + archivo);

        lnkArchivoCambio.CssClass = "";
        lnkArchivoCambio.NavigateUrl = "~/files/" + archivo;
        lnkArchivoCambio.Visible = true;
        Panel1_ModalPopupExtender.Show();
    }

    protected void btnGenerarOtroSi_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCrearContrato.aspx?cod=" + Request.QueryString["cod"]+"&generaotrosi=activado");
    }

    protected void btnAdjuntarDocumento_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCrearAdjunto.aspx?cod=" + Request.QueryString["cod"] );
    }
 

  
    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        int codOrden = int.Parse(Request.QueryString["cod"]);
    
        //cargamos el reporte
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        dsSpx1.EnforceConstraints = false;
        objDef.Fill(dsSpx1.defaults);

        string ruta = Server.MapPath("../rpt/");
        ruta = ruta + "rpt3.xml";
        C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
        #region seleccionamos el reporte y cargamos los valores que vienen en defaults
        string nombreReporte = "rptContratosSuministro";
        
        rpt.Load(ruta, nombreReporte);
        //if (rpt.Fields.Contains("lblTitulo"))
        //{
        //    if (!dsSpx1.defaults[0].IstituloControlCalidadNull())
        //        rpt.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloControlCalidad.Trim();
        //}
  
        #endregion

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();

        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("'<<cod_contrato>>'", Request.QueryString["cod"].Trim());
        rpt.DataSource.ConnectionString = bd.CadenaConexionReportes;


        if (rpt.Fields.Contains("rptPolizasSuministro"))
        {
            rpt.Fields["rptPolizasSuministro"].Subreport.DataSource.ConnectionString = bd.CadenaConexionReportes;
            rpt.Fields["rptPolizasSuministro"].Subreport.DataSource.RecordSource =
                rpt.Fields["rptPolizasSuministro"].Subreport.DataSource.RecordSource.Replace("<<cod_contrato>>", Request.QueryString["cod"].Trim());
        }
        if (rpt.Fields.Contains("rptEstampillas"))
        {
            rpt.Fields["rptEstampillas"].Subreport.DataSource.ConnectionString = bd.CadenaConexionReportes;
            rpt.Fields["rptEstampillas"].Subreport.DataSource.RecordSource =
                rpt.Fields["rptEstampillas"].Subreport.DataSource.RecordSource.Replace("<<cod_contrato>>", Request.QueryString["cod"].Trim());
        }
        if (rpt.Fields.Contains("rptProducto"))
        {
            rpt.Fields["rptProducto"].Subreport.DataSource.ConnectionString = bd.CadenaConexionReportes;
            rpt.Fields["rptProducto"].Subreport.DataSource.RecordSource =
                rpt.Fields["rptProducto"].Subreport.DataSource.RecordSource.Replace("<<cod_contrato>>", Request.QueryString["cod"].Trim());
        }
        if (rpt.Fields.Contains("rptDivisiones"))
        {
            rpt.Fields["rptDivisiones"].Subreport.DataSource.ConnectionString = bd.CadenaConexionReportes;
            rpt.Fields["rptDivisiones"].Subreport.DataSource.RecordSource =
                rpt.Fields["rptDivisiones"].Subreport.DataSource.RecordSource.Replace("<<cod_contrato>>", Request.QueryString["cod"].Trim());
        }
        if (rpt.Fields.Contains("rptGrupos"))
        {
            rpt.Fields["rptGrupos"].Subreport.DataSource.ConnectionString = bd.CadenaConexionReportes;
            rpt.Fields["rptGrupos"].Subreport.DataSource.RecordSource =
                rpt.Fields["rptGrupos"].Subreport.DataSource.RecordSource.Replace("<<cod_contrato>>", Request.QueryString["cod"].Trim());
        }
        if (rpt.Fields.Contains("rptLog"))
        {
            rpt.Fields["rptLog"].Subreport.DataSource.ConnectionString = bd.CadenaConexionReportes;
            rpt.Fields["rptLog"].Subreport.DataSource.RecordSource =
                rpt.Fields["rptLog"].Subreport.DataSource.RecordSource.Replace("<<cod_contrato>>", Request.QueryString["cod"].Trim());
        }

        if (Session["c1report"] == null)
        {
            Session.Add("c1report", rpt);
        }
        else
        {
            Session["c1report"] = rpt;
        }
        //Session["tituloReporte"] 

        if (Session["tituloReporte"] == null)
        {
            Session.Add("tituloReporte", "contratos de Suministro");
        }
        else
        {
            Session["tituloReporte"] = "contratos de Suministro";
        }

        Session["rutaReporte"] = ruta;
        Session["nombreReporte"] = nombreReporte;
        //    Session["showPdf"]

        Response.Redirect("../impresion/frmImprimir.aspx");
    }
    protected void btnEditarAdjunto_Click1(object sender, EventArgs e)
    {
        Button im = (Button)sender;
        Response.Redirect("frmCrearAdjunto.aspx?cod=" + Request.QueryString["cod"]+"&codc="+im.CommandArgument);
    }

    protected void btnEliminarEstampilla_Click1(object sender, EventArgs e)
    {
        try
        {
            Button im = (Button)sender;
            SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter ad = new SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter();
            ad.DeleteQuery(int.Parse(im.CommandArgument));
            grdDocumentosAnexos.DataBind();
            actualizarEstatusAdjuntos();
        }catch(Exception){}
    }

    protected void btnAprobarAdjunto_Click2(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        var cod = b.CommandArgument;
        lblCodAdjunto.Text = cod;
        //validamos a que estado deberia ir
        SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
        SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter adjuntoT = new SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.estado_adjunto_contrato_suministroTableAdapter estadoT=new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_adjunto_contrato_suministroTableAdapter();
        adjuntoT.FillByCod_adjunto_contrato_suministro(ds.adjunto_contrato_suministro, int.Parse(cod.ToString()));
        estadoT.FillByCod_estado_adjunto_contrato_suministro(ds.estado_adjunto_contrato_suministro,ds.adjunto_contrato_suministro[0].cod_estado_adjunto_contrato_suministro);

        lblCodEstadoAdjuntoIni.Text = ds.estado_adjunto_contrato_suministro[0].cod_estado_adjunto_contrato_suministro.ToString();
        if (ds.estado_adjunto_contrato_suministro[0].cod_manual != 5)
        {
            int codNuevo = ds.estado_adjunto_contrato_suministro[0].cod_manual + 1;
            
            estadoT.FillByCod_manual(ds.estado_adjunto_contrato_suministro, codNuevo);
            if (ds.estado_adjunto_contrato_suministro.Count>0)
            cmbEstadoAdjunto.SelectedValue = ds.estado_adjunto_contrato_suministro[0].cod_estado_adjunto_contrato_suministro.ToString();
        }
        
        lblErrorAdjunto.Text = "";
        txtObservacionesAdjunto.Text = "";
      
        ModalPopupExtenderAdjuntos.Show();
    }

    protected void btnCancelarAdjunto_Click(object sender, EventArgs e)
    {
        lblErrorAdjunto.Text = "";
        txtObservacionesAdjunto.Text = "";
        lblCodAdjunto.Text = "";
        lblCodEstadoAdjuntoIni.Text = "";
        ModalPopupExtenderAdjuntos.Hide();
    }

    protected void btnAceptarAdjunto_Click(object sender, EventArgs e)
    {
  
    }


    protected void btnAprobarAdjunto_Click(object sender, EventArgs e)
    {
        //aca deberiamos cambiar el estado del adjunto
        if (txtObservacionesAdjunto.Text.Trim() == string.Empty)
        {
            lblErrorAdjunto.Text = "Ingrese las observaciones.";
            return;
        }

        SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter adjuntoT = new SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_adjuntos_suministroTableAdapter logT = new SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_adjuntos_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministro ds=new SPControladoraDatos.dsContratosSuministro();
        adjuntoT.UpdateEstado(int.Parse(cmbEstadoAdjunto.SelectedValue), int.Parse(lblCodAdjunto.Text));
        logT.FillByCod_adjunto_contrato_suministroUltimo(ds.log_cambios_estado_adjuntos_suministro, int.Parse(lblCodAdjunto.Text));
        if (ds.log_cambios_estado_adjuntos_suministro.Count > 0)
        {
            logT.Insert(DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()),
                txtObservacionesAdjunto.Text, int.Parse(lblCodAdjunto.Text), int.Parse(lblCodEstadoAdjuntoIni.Text),
                int.Parse(cmbEstadoAdjunto.SelectedValue),
                (int)DateTime.Now.Subtract(ds.log_cambios_estado_adjuntos_suministro[0].fecha_cambio).TotalHours,
                (int)DateTime.Now.Subtract(ds.log_cambios_estado_adjuntos_suministro[0].fecha_cambio).Minutes);
        }else {
            logT.Insert(DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()),
                    txtObservacionesAdjunto.Text, int.Parse(lblCodAdjunto.Text), int.Parse(lblCodEstadoAdjuntoIni.Text),
                    int.Parse(cmbEstadoAdjunto.SelectedValue),
                    0,
                    0);
        }
        //insertamos en el log

        //enviamos email
        SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_adjunto_contrato_suministroTableAdapter tipoT = new SPControladoraDatos.dsContratosSuministroTableAdapters.tipo_adjunto_contrato_suministroTableAdapter();
        SPControladoraDatos.dsContratosSuministroTableAdapters.estado_adjunto_contrato_suministroTableAdapter estadoT = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_adjunto_contrato_suministroTableAdapter();
        estadoT.FillByCod_estado_adjunto_contrato_suministro(ds.estado_adjunto_contrato_suministro,int.Parse(cmbEstadoAdjunto.SelectedValue));
        adjuntoT.FillByCod_adjunto_contrato_suministro(ds.adjunto_contrato_suministro, int.Parse(lblCodAdjunto.Text));
        tipoT.FillByCod_tipo_adjunto_contrato_suministro(ds.tipo_adjunto_contrato_suministro, ds.adjunto_contrato_suministro[0].cod_tipo_adjunto_contrato_suministro);

        clsSeguridad cls = new clsSeguridad();
        string asunto = "Adjunto de Contrato de suministro requiere su atención cod:" + lblcodigoContrato.Text + " estado " +
            cmbEstadoAdjunto.SelectedItem.Text;
        string cuerpo = @"Actualizacion de estado para adjunto contrato de suministro<br>
Cod Contrato:" + lblcodigoContrato.Text + @"<br>
Adjunto: "+ds.tipo_adjunto_contrato_suministro[0].nombre_tipo_adjunto_contrato_suministro+@"<br>
Estado:" + cmbEstadoAdjunto.SelectedItem.Text + @"<br>
Cliente:" + lblcliente.Text + @"<br>
Observaciones:" + txtObservacionesAdjunto.Text.Replace("\r\n", "<br>").Replace("\n", "<br>") + @"<br> " +
                   @"<a href='" + cls.verIpSitiio() + @"frm/csuministro/frmDetalleContrato.aspx?cod=" + lblcodigoContrato.Text + "'  >Ver Contrato</a><br>" +
                   "verifique la información para la respectiva aprobación. ";
        List<string> lista = new List<string>();
        //enviamos correos
        string sqlAutor = @"select usuario.correo from [adjunto_contrato_suministro] 
join usuario on usuario.cod_usuario =[adjunto_contrato_suministro].[cod_usuario_creacion]
where [cod_adjunto_contrato_suministro]='" + lblCodAdjunto.Text + "'";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        if (ds.estado_adjunto_contrato_suministro[0].cod_manual.ToString().Trim() == "1")
        {
            //enviamos correo solo al que lo creo.
            lista.Add(bd.ejecutarProcedimiento(sqlAutor).ToString());
        }
        else if (ds.estado_adjunto_contrato_suministro[0].cod_manual.ToString().Trim() == "2")
        {
            //enviamos correo a quienes realizan aprobacion adminsitrativo.
            lista = cls.verCorreos(2057);
        }
        else if (ds.estado_adjunto_contrato_suministro[0].cod_manual.ToString().Trim() == "3")
        {
            //enviamos correo a quienes realizan aprobacion cartera.
            lista = cls.verCorreos(2069);
        }
        else if (ds.estado_adjunto_contrato_suministro[0].cod_manual.ToString().Trim() == "4")
        {
            //enviamos correo a quienes realizanaprobacion juridica.
            lista = cls.verCorreos(2056);
        }
        
        for (int k = 0; k < lista.Count; k++)
        {
            string msg = "";
            List<string> adjuntos = new List<string>();
            if (lista[k].Trim() != string.Empty)
                cls.enviarEmail(asunto, cuerpo, lista[k], adjuntos, out msg);
        }


        ModalPopupExtenderAdjuntos.Hide();
        lblErrorAdjunto.Text = "";
        txtObservacionesAdjunto.Text = "";
        lblCodEstadoAdjuntoIni.Text = "";
        lblCodAdjunto.Text = "";
        grdDocumentosAnexos.DataBind();
        actualizarEstatusAdjuntos();
        pnlGrillaAdjuntos.Update();
    }

    private void actualizarEstatusAdjuntos() 
    {
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        string sql = @"select count(*) from adjunto_contrato_suministro 
join estado_adjunto_contrato_suministro
on estado_adjunto_contrato_suministro.cod_estado_adjunto_contrato_suministro=adjunto_contrato_suministro.cod_estado_adjunto_contrato_suministro
where cod_contratos_suministro="+Request.QueryString["cod"]+" and cod_manual!= 5";
        var c= bd.ejecutarProcedimiento(sql).ToString().Trim();
        if(c !="0")
        {
        lblEstatusAdjuntos.Text="Existen "+c+" adjunto(s) abierto(s) para el contrato";
        }else{
        lblEstatusAdjuntos.Text="";
        }
        pnlEstatusAdjuntos.Update();
    }

    protected void btnVerLogAdjunto_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        Response.Redirect("frmLogCambiosAdjuntos.aspx?cod="+b.CommandArgument+"&codo="+Request.QueryString["cod"]);
    }

    private int calcularHorasHabiles(
      DateTime fechaIni, DateTime fechaFin,

       out int horas, out int minutos
      )
    {
        horas = 0; minutos = 0;
        
        /*
         * <add key="horaHabilSuministroInicio" value="7:30"/>    
    <add key="horaHabilSuministroFin" value="17:30"/>
    <add key="horaAlmuerzoSuministroInicio" value="12:00"/>
    <add key="horaAlmuerzoSuministroFin" value="13:00"/>
         */
        System.Configuration.AppSettingsReader ar = new System.Configuration.AppSettingsReader();
//primero traemos los valores del webconfig y calculamos los minutos
        string txtInicioJornada = ar.GetValue("horaHabilSuministroInicio", typeof(string)).ToString();
        string txtFinJornada = ar.GetValue("horaHabilSuministroFin", typeof(string)).ToString();
        string txtinicioAlmuerzo = ar.GetValue("horaAlmuerzoSuministroInicio", typeof(string)).ToString();
        string txtFinAlmuerzo = ar.GetValue("horaAlmuerzoSuministroFin", typeof(string)).ToString();
        int minutosInicio = int.Parse(txtInicioJornada.Split(':')[1]);
        int horasInicio = int.Parse(txtInicioJornada.Split(':')[0]);

        int finminutosInicio = int.Parse(txtFinJornada.Split(':')[1]);
        int finhorasInicio = int.Parse(txtFinJornada.Split(':')[0]);


        int almuerzominutosInicio = int.Parse(txtinicioAlmuerzo.Split(':')[1]);
        int almuerzohorasInicio = int.Parse(txtinicioAlmuerzo.Split(':')[0]);

        int finalmuerzominutosInicio = int.Parse(txtFinAlmuerzo.Split(':')[1]);
        int finalmuerzohorasInicio = int.Parse(txtFinAlmuerzo.Split(':')[0]);
        //
        DateTime iniJornada = new DateTime(fechaIni.Year, fechaIni.Month, fechaIni.Day, horasInicio, minutosInicio, 0);
        DateTime finJornada = new DateTime(fechaIni.Year, fechaIni.Month, fechaIni.Day, finhorasInicio, finminutosInicio, 0);
        DateTime iniAlmuerzo = new DateTime(fechaIni.Year, fechaIni.Month, fechaIni.Day, almuerzohorasInicio, almuerzominutosInicio, 0);
        DateTime finAlmuerzo = new DateTime(fechaIni.Year, fechaIni.Month, fechaIni.Day, finalmuerzohorasInicio, finalmuerzominutosInicio, 0);

        DateTime iniJornadaFin = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, horasInicio, minutosInicio, 0);
        DateTime finJornadaFin = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, finhorasInicio, finminutosInicio, 0);
        DateTime iniAlmuerzoFin = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, almuerzohorasInicio, almuerzominutosInicio, 0);
        DateTime finAlmuerzoFin = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day, finalmuerzohorasInicio, finalmuerzominutosInicio, 0);



        return
            calcularHorasHabiles(
                iniJornada, finJornada,
                iniAlmuerzo, finAlmuerzo,
                fechaIni, fechaFin,
                iniJornadaFin, finJornadaFin,
                iniAlmuerzoFin, finAlmuerzoFin
                , out horas, out minutos
                );
    }

    private int calcularHorasHabiles(
            DateTime inicioJornada, DateTime finJornada,
            DateTime inicioalmuerzo, DateTime finAlmuerzo,
            DateTime fechaIni, DateTime fechaFin,
            DateTime inicioJornadaFin, DateTime finJornadaFin,
            DateTime inicioalmuerzoFin, DateTime finAlmuerzoFin
            , out int horas, out int minutos
            )
    {
        horas = 0;
        minutos = 0;
        DateTime fechaUno = fechaIni;
        DateTime fechaDos = fechaFin;
        if (fechaFin < fechaUno) return 0;
        //ajustamos la hora inicial
        if (fechaUno < inicioJornada)
        {
            fechaUno = inicioJornada;
        }
        else
            if (fechaUno > inicioalmuerzo && fechaUno < finAlmuerzo)
            {
                fechaUno = finAlmuerzo;
            }
            else if (fechaUno > finJornada)
            {
                fechaUno = inicioJornada.AddDays(1);
                inicioJornada = inicioJornada.AddDays(1);
                finJornada = finJornada.AddDays(1);
                inicioalmuerzo = inicioalmuerzo.AddDays(1);
                finAlmuerzo = finAlmuerzo.AddDays(1);
            }
        //si empezo un festivo lo movemos hasta el dia habil siguiente
        while (esFestivo(fechaUno))
        {
            inicioJornada = inicioJornada.AddDays(1);
            fechaUno = inicioJornada;
            finJornada = finJornada.AddDays(1);
            inicioalmuerzo = inicioalmuerzo.AddDays(1);
            finAlmuerzo = finAlmuerzo.AddDays(1);
        }

        //ajustamos la hora final
        if (fechaDos < inicioJornadaFin)
        {
            fechaDos = inicioJornadaFin;
        }
        else
            if (fechaDos > inicioalmuerzoFin && fechaDos < finAlmuerzoFin)
            {
                fechaDos = finAlmuerzoFin;
            }
            else if (fechaDos > finJornadaFin)
            {
                fechaDos = inicioJornadaFin.AddDays(1);
                inicioJornadaFin = inicioJornadaFin.AddDays(1);
                finJornadaFin = finJornadaFin.AddDays(1);
                inicioalmuerzoFin = inicioalmuerzoFin.AddDays(1);
                finAlmuerzoFin = finAlmuerzoFin.AddDays(1);
            }
        //si empezo un festivo lo movemos hasta el dia habil siguiente
        while (esFestivo(fechaDos))
        {
            inicioJornadaFin = inicioJornadaFin.AddDays(1);
            fechaDos = inicioJornadaFin;
            finJornadaFin = finJornadaFin.AddDays(1);
            inicioalmuerzoFin = inicioalmuerzoFin.AddDays(1);
            finAlmuerzoFin = finAlmuerzoFin.AddDays(1);
        }


        //calculamos la diferenca entre horas
        int res = 0;
        if (fechaUno.Year == fechaDos.Year &&
            fechaUno.Month == fechaDos.Month &&
            fechaUno.Day == fechaDos.Day)
        {
            #region esto es cuando es el mismo dia
            if (fechaUno <= inicioalmuerzo && fechaDos >= finAlmuerzo)
            {
                horas = (int)fechaDos.Subtract(fechaUno).TotalHours;
                //descontamos la hora del almuerzo
                horas = horas - (int)(finAlmuerzo.Subtract(inicioalmuerzo).TotalHours);

                minutos = (int)fechaDos.Subtract(fechaUno).Minutes;

            }
            else if ((fechaUno <= inicioalmuerzo && fechaDos <= inicioalmuerzo)
                   ||
                   (fechaUno >= finAlmuerzo && fechaDos >= finAlmuerzo))
            {
                horas = (int)fechaDos.Subtract(fechaUno).TotalHours;
                minutos = (int)fechaDos.Subtract(fechaUno).Minutes;
            }
            #endregion
        }
        else
        {
            //minutos del primer dia
            if (fechaUno < inicioalmuerzo)
            {
                minutos = (int)inicioalmuerzo.Subtract(fechaUno).TotalMinutes;
                minutos += (int)finJornada.Subtract(finAlmuerzo).TotalMinutes;
            }
            else

                if (fechaUno >= finAlmuerzo)
                {
                    minutos = (int)finJornada.Subtract(fechaUno).TotalMinutes;
                }
            //minutos del segundo dia
            if (fechaDos < inicioalmuerzoFin)
            {
                minutos += (int)fechaDos.Subtract(inicioJornadaFin).TotalMinutes;
            }
            else if (fechaDos >= finAlmuerzoFin)
            {
                minutos += (int)inicioalmuerzoFin.Subtract(inicioJornadaFin).TotalMinutes;
                minutos += (int)fechaDos.Subtract(finAlmuerzoFin).TotalMinutes;
            }
            horas = (int)(minutos / 60);
            minutos = minutos % 60;

            int horasxdia = (int)finJornada.Subtract(inicioJornada).TotalHours;
            horasxdia = horasxdia - (int)(finAlmuerzoFin.Subtract(inicioalmuerzoFin).TotalHours);
            //calculamos finalmente los dias que debe multiplicar.
            int dias = 0;
            DateTime f = fechaUno.AddDays(1);
            while (f.DayOfYear < fechaDos.DayOfYear)
            {

                if (esFestivo(f))
                {
                    f = f.AddDays(1);
                    continue;
                }
                f = f.AddDays(1);
                dias++;
            }
            //
            horas = horas + (dias * horasxdia);
        }

        return res;
    }

    private bool esFestivo(DateTime fecha)
    {
        if (fecha.DayOfWeek == DayOfWeek.Sunday ||
                    fecha.DayOfWeek == DayOfWeek.Saturday) return true;
        SPControladoraDatos.dsSpxTableAdapters.dias_festivosTableAdapter df = new SPControladoraDatos.dsSpxTableAdapters.dias_festivosTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        df.FillByFechaExacta(ds.dias_festivos, fecha);
        if (ds.dias_festivos.Count > 0) return true;
        return false;
    }

}
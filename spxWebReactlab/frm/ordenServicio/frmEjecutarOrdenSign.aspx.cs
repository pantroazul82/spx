using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_ordenServicio_frmEjecutarOrdenSign : System.Web.UI.Page
{

    protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
    {
        string a = ((ImageButton)sender).ValidationGroup;
        SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter();
        obj.DeleteQuery(int.Parse(Request.QueryString["osx"]),int.Parse(a));
        GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["osx"] == null || Request.Params["osx"].Trim() == string.Empty)
        {
            Response.Redirect(@"~/frm/logica/Default.aspx");
        }
        if (!IsPostBack)
        {
            
            clsSeguridad obS = new clsSeguridad();
            obS.comprobarAcceso(Page, Session, Response, 1054);
            for (int k = 0; k < 60; k++)
            {
                cmbMinutosLlegada.Items.Add(new ListItem(k.ToString().PadLeft(2, '0'), k.ToString().PadLeft(2, '0')));
                cmbMinutosSalida.Items.Add(new ListItem(k.ToString().PadLeft(2, '0'), k.ToString().PadLeft(2, '0')));
            }
            #region informacion general
            lblOrdenServicio.Text = Request.Params["osx"];
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTA = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            ordenServicioTA.FillByCodOrdenServicio(ds.ordenServicio, int.Parse(lblOrdenServicio.Text));

            //cargamos informacion de la orden de servicio
            if (!ds.ordenServicio[0].IsfechaUltimoMantenimientoxUsuarioNull())
            {
                calultimoMantenimientoxUsuario.SelectedDate = ds.ordenServicio[0].fechaUltimoMantenimientoxUsuario;
                calultimoMantenimientoxUsuario.Enabled = false;
            }else{
                calultimoMantenimientoxUsuario.Enabled = true;
            }

            if (!ds.ordenServicio[0].IsmantenimientoSegunIndicacionesNull())
            {
                rdManteimientoIndicadoSi.Checked = ds.ordenServicio[0].mantenimientoSegunIndicaciones;
                rdManteimientoIndicadoNo.Checked = !ds.ordenServicio[0].mantenimientoSegunIndicaciones;
                //--
                rdManteimientoIndicadoSi.Enabled = false;
                rdManteimientoIndicadoNo.Enabled = false;
            }
            else {
                rdManteimientoIndicadoSi.Enabled = true;
                rdManteimientoIndicadoNo.Enabled = true;
            }

            lnkImprimir.NavigateUrl = "frmPrintOrden.aspx?os=" + lblOrdenServicio.Text;
            BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
            BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));
            BOLayer.Usuario0Factory uf = new BOLayer.Usuario0Factory();

            if(os.AsesoresComerciale != null)
            {
             txtAsesorComercial.Text = os.AsesoresComerciale.NombreAsesor;
            }
            if (os.SucursalCliente != null && os.SucursalCliente.NombreSucursal != null)
            {
                txtSucursal.Text = os.SucursalCliente.NombreSucursal;
                txtTelefonoSucursal.Text = (os.SucursalCliente.Telefono1 == null) ? "" : os.SucursalCliente.Telefono1.Trim() + " - "
                    + ((os.SucursalCliente.Telefono2 == null) ? "" : os.SucursalCliente.Telefono2.Trim());
                txtDireccionSucursal.Text = os.SucursalCliente.Direccion;
            }

            if (os.SucursalCliente != null && os.SucursalCliente.ContactosCliente != null)
            {
                txtCelularContacto.Text = os.SucursalCliente.ContactosCliente.Celular;
                txtContactoSucursal.Text = os.SucursalCliente.ContactosCliente.NombreContacto.Trim() + " " + os.SucursalCliente.ContactosCliente.ApellidosContacto;
            }

            if (os.SucursalCliente != null && os.SucursalCliente.Ciudade != null)
                txtCiudadSucursal.Text = os.SucursalCliente.Ciudade.NombreCiudad;

            if (os.SucursalCliente != null && os.SucursalCliente.Cliente != null)
            {
                txtNitCliente.Text = os.SucursalCliente.Cliente.NitCliente + "(" + os.SucursalCliente.Cliente.NumeroSocio + ")";
                txtNombreCliente.Text = os.SucursalCliente.Cliente.NombreCliente;
            }

            txtEstado.Text = os.EstadosOrdenServicio.NombreEstado;

            if (os.Equipo != null && os.Equipo.Modelo != null && os.Equipo.Modelo.Fabricante != null)
                txtFabricante.Text = os.Equipo.Modelo.Fabricante.NombreFabricante;
            if (os.Equipo != null && os.Equipo.Modelo != null)
                txtModelo.Text = os.Equipo.Modelo.NombreModelo;

            if (os.NumEntrada.HasValue)
                txtNumeroEntrada.Text = os.NumEntrada.Value.ToString();

            txtNumeroOrden.Text = os.CodOrdenServicio.ToString();
            txtObservacionesIniciales.Text = os.Observaciones;

            SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter pos = new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();
            txtPrioridad.Text = pos.GetDataBycodPrioridadOS(os.CodPrioridadOS.Value)[0].nombre;
            rdExterna.Checked = !os.EsInterno.Value; rdExterna.Enabled = false;
            rdInterna.Checked = os.EsInterno.Value; rdInterna.Enabled = false;
            txtSerial.Text = os.Serial;
            if (os.TipoServicio != null && os.TipoServicio.NombretipoServicio != null)
                txtTipoServicio.Text = os.TipoServicio.NombretipoServicio;

            if (os.Equipo != null)
            {
                txtFechaProximoMantenimiento.Text = os.Equipo.FechaProximoMante_Date;
                txtFechaUltimoMantenimiento.Text = os.Equipo.FechaUltimoMante_Date;
            }

            if (os.Equipo.ModalidadEquipo != null && os.Equipo.ModalidadEquipo.NombreModalidadEquipo != null)
                txtModalidad.Text = os.Equipo.ModalidadEquipo.NombreModalidadEquipo;
            #endregion
            BOLayer.Usuario0 usu = uf.Get(os.AsignadoA);
            txtIngenieroAsignado.Text = usu.Nombre.Trim() + "(" + os.AsignadoA.Trim() + ")";
            txtFechaTentativainicio.Text = os.FechaProgramacion_Date + " " + os.FechaProgramacion_Time;
            txtFechaTentativaFin.Text = os.FechaFinProgramacion_Date + " " + os.FechaFinProgramacion_Time;
            //actividades realizadas
            txtFallasReportadas.Text = os.FallasReportadas;
            txtDiagnostico.Text = os.Diagnostico;
            txtObservacionesIngeniero.Text = os.ObservacionesIngeniero;
            if (os.CodEstadoOrdenServicio == "ANULA")
            {
                btnEditarActividadesRealizadas.Visible = false;
                btnReabrirOrden.Visible = false;
                btnCerrarOrden.Visible = false;
                btnGuardarRepuestos.Visible = false;
                btnAgregarActividad.Visible = false;
                //btnSubirArchivo.Visible = false;
                //FileUpload1.Visible = false;
                ctlSignature1.Visible = false;
                btnLimpiarFirma.Visible = false;
                btnEditarAceptacion.Visible = false;
            }
            else if (os.CodEstadoOrdenServicio == "CERRA")
            {
                btnEditarActividadesRealizadas.Visible = false;
                btnReabrirOrden.Visible = true;
                btnCerrarOrden.Visible = false;
                btnGuardarRepuestos.Visible = false;
                btnAgregarActividad.Visible = false;
                //btnSubirArchivo.Visible = false;
                //FileUpload1.Visible = false;
                ctlSignature1.Visible = false;
                btnLimpiarFirma.Visible = false;
                btnEditarAceptacion.Visible = false;
            }
            else if (os.CodEstadoOrdenServicio == "APROB")
            {
                btnEditarActividadesRealizadas.Visible = false;
                btnReabrirOrden.Visible = false;
                btnCerrarOrden.Visible = false;
                btnGuardarRepuestos.Visible = false;
                btnAgregarActividad.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUpload1.Visible = false;
                ctlSignature1.Visible = false;
                btnLimpiarFirma.Visible = false;
                btnEditarAceptacion.Visible = false;
            }
            else
            {
                btnReabrirOrden.Visible = false;
                btnCerrarOrden.Visible = true;
                btnGuardarRepuestos.Visible = true;
                btnAgregarActividad.Visible = true;
                //EJECU	                                                                                       
                //ENESP	                                                                               
                //PROGR
            }
            //cargamos los repuestos
            for (int k = 0; k < os.RepuestoxOrdenServicios.Count; k++)
            {
                controlRepuestos1.agregarItem(os.RepuestoxOrdenServicios[k].CodRepuesto,
                    os.RepuestoxOrdenServicios[k].Repuesto.Descripcion, (int)os.RepuestoxOrdenServicios[k].Cantidad);
            }
            //cargamos la informacion de aceptacion

            if (os.NombreUsuarioCliente != null)
            {
                txtUsuarioAceptacion.Text = os.NombreUsuarioCliente.Trim();
                //el FORMATO ES 12:54 PM
                string entrada = os.HoraEntradaControl;
                string salida = os.HoraSalidaControl;
                if (entrada.Trim() != string.Empty)
                {
                    cmbHoraLlegada.Text = int.Parse(entrada.Substring(0, entrada.IndexOf(":"))).ToString();
                    cmbMinutosLlegada.Text = entrada.Substring(entrada.IndexOf(":") + 1, 2);
                    cmbAmPmLlegada.Text = entrada.Substring(entrada.IndexOf(":") + 4, 2);
                }
                else
                {
                    cmbHoraLlegada.SelectedValue = "-1";
                    cmbMinutosLlegada.SelectedValue = "-1";
                    cmbAmPmLlegada.SelectedValue = "-1";
                }

                if (salida.Trim() != string.Empty)
                {
                    cmbHoraSalida.Text = int.Parse(salida.Substring(0, salida.IndexOf(":"))).ToString();
                    cmbMinutosSalida.Text = salida.Substring(salida.IndexOf(":") + 1, 2);
                    cmbAmPmSalida.Text = salida.Substring(salida.IndexOf(":") + 4, 2);
                }
                else
                {
                    cmbHoraSalida.SelectedValue = "-1";
                    cmbMinutosSalida.SelectedValue = "-1";
                    cmbAmPmSalida.SelectedValue = "-1";
                }
                SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter objCom = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
                //SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                objCom.FillByInfAdi(ds.comprobantesAceptacionOrdenservicio, int.Parse(lblOrdenServicio.Text));
                //cargamos la imagen
                if (ds.comprobantesAceptacionOrdenservicio.Count > 0)
                {
                    System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream(ds.comprobantesAceptacionOrdenservicio[0].datos));
                    string ruta = Server.MapPath("../../Temp/");
                    im.Save(ruta + "/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgFirma.ImageUrl = "../../Temp/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png";
                    imgFirma.Visible = true;
                }else{
                    imgFirma.Visible = false;
                }
            }
        }
        if (btnReabrirOrden.Visible)
        {
            string msg = "";
            btnReabrirOrden.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccion(1014
, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        }
    }

    public void verHojaVida(object sender, EventArgs e)
    {
        Response.Redirect("../hojaVida/frmHojaVida.aspx?sx=" + txtSerial.Text);
    }
    protected void btnEditarActividadesRealizadas_Click(object sender, ImageClickEventArgs e)
    {
        btnEditarActividadesRealizadas.Visible = false;
        btnAceptarActividadesREalizadas.Visible = true;
        btnCancelarActividadesRealizadas.Visible = true;
        txtFallasReportadas.ReadOnly = false;
        txtDiagnostico.ReadOnly = false;
        txtObservacionesIngeniero.ReadOnly = false;
    }
    protected void btnCancelarActividadesRealizadas_Click(object sender, ImageClickEventArgs e)
    {
        btnEditarActividadesRealizadas.Visible = true;
        btnAceptarActividadesREalizadas.Visible = false;
        btnCancelarActividadesRealizadas.Visible = false;
        //cargamos la informacion que teniamos por defecto
        BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));

        txtFallasReportadas.Text = os.FallasReportadas;
        txtDiagnostico.Text = os.Diagnostico;
        txtObservacionesIngeniero.Text = os.ObservacionesIngeniero;


        txtFallasReportadas.ReadOnly = true;
        txtDiagnostico.ReadOnly = true;
        txtObservacionesIngeniero.ReadOnly = true;

    }

    protected void btnAceptarActividadesREalizadas_Click(object sender, ImageClickEventArgs e)
    {
        btnEditarActividadesRealizadas.Visible = true;
        btnAceptarActividadesREalizadas.Visible = false;
        btnCancelarActividadesRealizadas.Visible = false;
        //cargamos la informacion que teniamos por defecto
        BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));

        os.FallasReportadas = txtFallasReportadas.Text;
        os.Diagnostico = txtDiagnostico.Text;
        os.ObservacionesIngeniero = txtObservacionesIngeniero.Text;
        if (os.CodEstadoOrdenServicio == "PROGR")
        {
            os.CodEstadoOrdenServicio = "EJECU";
            txtEstado.Text = "Ejecucion";
        }
        osf.Save(os);
        osf.Commit();

        txtFallasReportadas.ReadOnly = true;
        txtDiagnostico.ReadOnly = true;
        txtObservacionesIngeniero.ReadOnly = true;
    }

    protected void btnCerrarOrden_Click(object sender, EventArgs e)
    {

        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter osTa = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
       //guardamos la informacion si es mantenimiento segun lo adecuado
        if(rdManteimientoIndicadoNo.Checked || rdManteimientoIndicadoSi.Checked)
        osTa.UpdateMantenimientoSegunIndicado(rdManteimientoIndicadoSi.Checked,
            calultimoMantenimientoxUsuario.SelectedDate,true, int.Parse(lblOrdenServicio.Text));
        
        osTa.FillByCodOrdenServicio(ds.ordenServicio, int.Parse(lblOrdenServicio.Text));
        if ( ds.ordenServicio[0].IsmantenimientoSegunIndicacionesNull())
        {
            lblError.Text ="Debe especificar si el mantenimiento se realizo segun las indicaciones!";
            return;
        }
        //miramos si tiene informacion de aceptacion de lo conrtatio no permitimos que cierre la orden
        BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));
        if (os.NombreUsuarioCliente == null || os.NombreUsuarioCliente.Trim() == string.Empty)
        {
            lblError.Text = "Para cerrar la orden debe tener informacion de aceptacion";
            return;
        }
        os.CerradaPor = Session["ss_login"].ToString();
        if(os.FechaCierre ==null)
        os.FechaCierre = DateTime.Now;
        os.CodEstadoOrdenServicio = "CERRA";

        osf.Save(os);
        osf.Commit();
        cerrarOrden(lblOrdenServicio.Text);
        btnEditarActividadesRealizadas.Visible = false;
        btnReabrirOrden.Visible = true;
        btnCerrarOrden.Visible = false;
        btnGuardarRepuestos.Visible = false;
        btnAgregarActividad.Visible = false;
        btnSubirArchivo.Visible = false;
        FileUpload1.Visible = false;
       
        btnEditarAceptacion.Visible = false;

        //btnEditarActividadesRealizadas.Visible = true;
        //btnAceptarActividadesREalizadas.Visible = false;
        //btnCancelarActividadesRealizadas.Visible = false;
        ////cargamos la informacion que teniamos por defecto
        //BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        //BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));

        //os.FallasReportadas = txtFallasReportadas.Text;
        //os.Diagnostico = txtDiagnostico.Text;
        //os.ObservacionesIngeniero = txtObservacionesIngeniero.Text;
        //if (os.CodEstadoOrdenServicio == "PROGR")
        //{
        //    os.CodEstadoOrdenServicio = "EJECU";
        //}
        //osf.Save(os);
        //osf.Commit();

        //txtFallasReportadas.ReadOnly = true;
        //txtDiagnostico.ReadOnly = true;
        //txtObservacionesIngeniero.ReadOnly = true;
    }

    protected void btnReabrirOrden_Click(object sender, EventArgs e)
    {
        BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));
        os.CodEstadoOrdenServicio = "PROGR";
        osf.Save(os);
        osf.Commit();
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
        
        
        ordenServicioTableAdapter1.UpdateCerrada(os.FechaCierre, null, "PROGR", int.Parse(lblOrdenServicio.Text));
        btnCerrarOrden.Visible = true;
        btnReabrirOrden.Visible = false;
        btnSubirArchivo.Visible = true;
        FileUpload1.Visible = true;
        btnEditarAceptacion.Visible = true;
    }

    protected void btnAgregarActividad_Click(object sender, EventArgs e)
    {
        Session["osx"] = lblOrdenServicio.Text;
        Response.Redirect("frmAgregarActividad.aspx");
    }

    protected void btnGuardarRepuestos_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.repuestoxOrdenServicioTableAdapter r = new SPControladoraDatos.dsSpxTableAdapters.repuestoxOrdenServicioTableAdapter();
        r.DeleteBycodOrdenServicio(int.Parse(lblOrdenServicio.Text));
        List<string> listaC = controlRepuestos1.verCodigos();
        List<string> listaN = controlRepuestos1.verText();
        for (int k = 0; k < listaC.Count; k++)
        {
            string a = listaN[k].Substring(listaN[k].LastIndexOf('('), listaN[k].Length - listaN[k].LastIndexOf('('));
            int cantidad = int.Parse(a.Replace("(", "").Replace(")", ""));
            r.Insert(int.Parse(lblOrdenServicio.Text), listaC[k], cantidad);
        }
    }

    public void verArchivo(object sender, ImageClickEventArgs e)
    {
        string a = ((ImageButton)sender).ValidationGroup;
        string[] arreglo = a.Split('|');

        SPControladoraDatos.dsSpxTableAdapters.archivosXOrdenServicioTableAdapter archivosXequipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.archivosXOrdenServicioTableAdapter();
        byte[] arr = (byte[])archivosXequipoTableAdapter1.verArchivo(int.Parse(lblOrdenServicio.Text), int.Parse(arreglo[0]));
        System.IO.MemoryStream ms = new System.IO.MemoryStream(arr);
        string ruta = Server.MapPath("../../Temp/");

        System.IO.File.WriteAllBytes(ruta + "" + Session["ss_login"].ToString().Trim() + "_" + arreglo[1].Trim(), arr);
        Response.Redirect("../../temp/" + Session["ss_login"].ToString().Trim() + "_" + arreglo[1].Trim());
    }

    protected void btnSubirArchivo_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        if (FileUpload1.FileName.Trim() == string.Empty)
        {
            lblError.Text = "Seleccione un archivo";
            return;
        }

        byte[] arr = FileUpload1.FileBytes;
        SPControladoraDatos.dsSpxTableAdapters.archivosXOrdenServicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.archivosXOrdenServicioTableAdapter();
        int id = int.Parse(obj.verNextId(int.Parse(lblOrdenServicio.Text)).ToString());

        obj.Insert(int.Parse(lblOrdenServicio.Text), id, FileUpload1.FileName, arr, FileUpload1.FileName + " subido desde web");
        lblError.Text = "Se subio el archivo satisfactoriamente!";
        //cargamos los archivos
        GridView2.DataBind();
    }

    protected void btnEditarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
       Response.Redirect("frmFirma.aspx?osx="+Request.QueryString["osx"]);
        return;
        btnEditarAceptacion.Visible = false;
        btnAceptarAceptacion.Visible = true;
        btnCancelarAceptacion.Visible = true;

        cmbAmPmLlegada.Enabled = true;
        cmbAmPmSalida.Enabled = true;
        cmbHoraLlegada.Enabled = true;
        cmbHoraSalida.Enabled = true;
        cmbMinutosLlegada.Enabled = true;
        cmbMinutosSalida.Enabled = true;
        txtUsuarioAceptacion.ReadOnly = false;
        imgFirma.Visible = false;
        btnLimpiarFirma.Visible = true;
        ctlSignature1.Visible = true;
        //ponemos la hora de salida la hora del sistema
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        string a= obj.ejecutarProcedimiento("select cast(datepart (HH,getdate()) as char(3))+'|'+cast(datepart (minute,getdate())as char(3))").ToString();
        string[] arr = a.Split('|');
        int hora= int.Parse(arr[0]);
        int minuto=int.Parse(arr[1]);

        cmbHoraSalida.SelectedValue = (hora % 12 == 0) ? "12" : (hora % 12).ToString();
        cmbMinutosSalida.SelectedValue = minuto.ToString().PadLeft(2,'0');
        cmbAmPmSalida.SelectedValue = (hora < 12 ) ? "AM" : "PM";
        cmbHoraSalida.Enabled = false;
        cmbMinutosSalida.Enabled = false;
        cmbAmPmSalida.Enabled = false;
    }

    protected void btnCancelarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
        btnEditarAceptacion.Visible = true;
        btnAceptarAceptacion.Visible = false;
        btnCancelarAceptacion.Visible = false;

        cmbAmPmLlegada.Enabled = false;
        cmbAmPmSalida.Enabled = false;
        cmbHoraLlegada.Enabled = false;
        cmbHoraSalida.Enabled = false;
        cmbMinutosLlegada.Enabled = false;
        cmbMinutosSalida.Enabled = false;
        txtUsuarioAceptacion.ReadOnly = true;
        imgFirma.Visible = false;
        btnLimpiarFirma.Visible = false;
        ctlSignature1.Visible = false;
        //--
        BOLayer.OrdenServicioFactory f = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = f.Get(int.Parse(lblOrdenServicio.Text));
        if (os.NombreUsuarioCliente != null)
        {
            txtUsuarioAceptacion.Text = os.NombreUsuarioCliente;
            //el FORMATO ES 12:54 PM
            string entrada = os.HoraEntradaControl;
            string salida = os.HoraSalidaControl;
          
            if (entrada.Trim() != string.Empty)
            {
                cmbHoraLlegada.Text = int.Parse(entrada.Substring(0, entrada.IndexOf(":"))).ToString();
                cmbMinutosLlegada.Text = entrada.Substring(entrada.IndexOf(":") + 1, 2);
                cmbAmPmLlegada.Text = entrada.Substring(entrada.IndexOf(":") + 4, 2);
            }
            else
            {
                cmbHoraLlegada.SelectedValue = null;
                cmbMinutosLlegada.SelectedValue = null;
                cmbAmPmLlegada.SelectedValue = null;
            }

            if (salida.Trim() != string.Empty)
            {
                cmbHoraSalida.Text = int.Parse(salida.Substring(0, salida.IndexOf(":"))).ToString();
                cmbMinutosSalida.Text = salida.Substring(salida.IndexOf(":") + 1, 2);
                cmbAmPmSalida.Text = salida.Substring(salida.IndexOf(":") + 4, 2);
            }
            else
            {
                cmbHoraSalida.SelectedValue = null;
                cmbMinutosSalida.SelectedValue = null;
                cmbAmPmSalida.SelectedValue = null;
            }

            SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter objCom = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            objCom.FillByInfAdi(ds.comprobantesAceptacionOrdenservicio, int.Parse(lblOrdenServicio.Text));
            //cargamos la imagen
            if (ds.comprobantesAceptacionOrdenservicio.Count > 0)
            {
                System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream(ds.comprobantesAceptacionOrdenservicio[0].datos));
                string ruta = Server.MapPath("../../Temp/");
                im.Save(ruta + "/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                imgFirma.ImageUrl = "../../Temp/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png";
                imgFirma.Visible = true;
            }
        }
        else
        {
            imgFirma.Visible = false;
            txtUsuarioAceptacion.Text = "";
            cmbHoraLlegada.SelectedValue = "-1";
            cmbMinutosLlegada.SelectedValue = "-1";
            cmbAmPmLlegada.SelectedValue = "-1";
            cmbHoraSalida.SelectedValue = "-1";
            cmbMinutosSalida.SelectedValue = "-1";
            cmbAmPmSalida.SelectedValue = "-1";
        }
    }

    protected void btnAceptarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
        if (!SubirFirma()) 
        {
            return;
        }
        btnEditarAceptacion.Visible = true;
        btnAceptarAceptacion.Visible = false;
        btnCancelarAceptacion.Visible = false;
        BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));
        os.NombreUsuarioCliente = txtUsuarioAceptacion.Text;
        os.HoraEntradaControl = cmbHoraLlegada.Text + ":" + cmbMinutosLlegada.Text + " " + cmbAmPmLlegada.Text.ToUpper();
        os.HoraSalidaControl = cmbHoraSalida.Text + ":" + cmbMinutosSalida.Text + " " + cmbAmPmSalida.Text.ToUpper();
        os.CerradaPor = Session["ss_login"].ToString();
        os.FechaCierre = DateTime.Now;
        os.CodEstadoOrdenServicio = "CERRA";
        osf.Save(os);
        osf.Commit();
        cerrarOrden(lblOrdenServicio.Text);

        //cerramos la orden
        
//eventos relacionados con el cierre de la orden

        btnEditarActividadesRealizadas.Visible = false;
        btnReabrirOrden.Visible = true;
        btnCerrarOrden.Visible = false;
        btnGuardarRepuestos.Visible = false;
        btnAgregarActividad.Visible = false;
        btnSubirArchivo.Visible = false;
        FileUpload1.Visible = false;
        
        btnEditarAceptacion.Visible = false;
    }

    /// <summary>
    /// si modifica esto tengalo sincronizado entre frmFirma y frmEjecutarOrdenSign
    /// </summary>
    /// <param name="codOrdenServicio"></param>
    public void cerrarOrden(string codOrdenServicio)
    {
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter entradaSalidaEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter();
        ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, int.Parse(codOrdenServicio));

        DateTime f = DateTime.Now;
        if (!dsSpx1.ordenServicio[0].IsfechaCierreNull())
            f = dsSpx1.ordenServicio[0].fechaCierre;
        ordenServicioTableAdapter1.UpdateCerrada(f, Session["ss_login"].ToString(), "CERRA", int.Parse(codOrdenServicio));
        // llenamos la tabla de solicitid de servicios segun el numero de orden 
        solicitudServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudServicio, int.Parse(codOrdenServicio));
        int EstadoSolicitud = 0;

        if (dsSpx1.solicitudServicio.Count > 0)
        {
            // Se trae el codigo de la solicitud de servicio
            EstadoSolicitud = dsSpx1.solicitudServicio[0].codSolicitudServicio;
            // Actualiza el estado segun el codigo de la solicitud de servicio
            solicitudServicioTableAdapter1.UpdatecodEstadoSolicitud(4, EstadoSolicitud);
        }
        #region miramos si la orden viene de una entrada y actualizamos la fecha

        entradaSalidaEquiposTableAdapter1.FillBycodOrdenServicio(dsSpx1.EntradaSalidaEquipos, int.Parse(codOrdenServicio));
        if (dsSpx1.EntradaSalidaEquipos.Count > 0)
        {
            //primero cambia la fecha de terminacion del mantenimiento de la entrada
            entradaSalidaEquiposTableAdapter1.UpdateFechaTerminacionMantenimiento(DateTime.Now, dsSpx1.EntradaSalidaEquipos[0].codEntradaSalidaEquipos);
            #region verificamos si el tipo de servicio me cambia la ubicacion base de datos del equipo
            if (
                !tipoServicioTableAdapter1.GetDataBycodTipoServicio(dsSpx1.ordenServicio[0].codTiposervicio)[0].IsdevuelveTallerNull()
                &&
                tipoServicioTableAdapter1.GetDataBycodTipoServicio(dsSpx1.ordenServicio[0].codTiposervicio)[0].devuelveTaller)
            {
                //traemos el codigo de la ubicacion de destino
                string codUbica = defaultsTableAdapter1.verCodUbicacionTallerxDefecto().Trim();
                string codEstado = defaultsTableAdapter1.verCodEstadoLocalEquipos().Trim();
                //ahora tramemos la ubicacion de origen
                spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                  "local", (codUbica.Trim() == string.Empty) ? null : codUbica, dsSpx1.ordenServicio[0].serial,
                  "Se cambia La ubicacion Al cerrar la orden de Servicio " + codOrdenServicio + "!",
                  false, DateTime.Now, false, "", codEstado);
                //debemos actualizar la salida
                entradaSalidaEquiposTableAdapter1.updateSalidaDevolucion(
                    "local", codUbica, codEstado, dsSpx1.EntradaSalidaEquipos[0].codEntradaSalidaEquipos);
            }
            #endregion

        }
        #endregion

    }

    public bool SubirFirma()
    {
        //localizamos la imagen del viewstate

        //string a=ViewState["ctlSignature1"].ToString();
        if (ctlSignature1.IsValid())
        {
            string finalImg = ctlSignature1.SignatureFile;
            btnLimpiarFirma.Visible = false;
            ctlSignature1.Visible = false;
            imgFirma.ImageUrl ="../../temp/"+ System.IO.Path.GetFileName( finalImg);
            imgFirma.Visible = true;

        SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
        obj.Deleteinfadi(int.Parse(lblOrdenServicio.Text));
        int id = int.Parse(obj.verNextId(int.Parse(lblOrdenServicio.Text)).ToString());
        byte[] arrb = System.IO.File.ReadAllBytes( Server.MapPath( finalImg));
        obj.Insert(id, int.Parse(lblOrdenServicio.Text), "infadi", null, arrb, System.IO.Path.GetFileName("firma os "+lblOrdenServicio.Text+".gif"));
        ////
        //System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream(FileUploadFirma.FileBytes));
        //string ruta = Server.MapPath("../../Temp/");
        //im.Save(ruta + "/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png", System.Drawing.Imaging.ImageFormat.Png);
        //imgFirma.ImageUrl = "../../Temp/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png";
        //imgFirma.Visible = true;

        return true;
        }

        return false;
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPControladoraDatos.dsSpxTableAdapters;

public partial class frm_ordenServicio_frmEjecutarOrden : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Redirect("frmEjecutarOrdenSign.aspx?osx=" + Request.Params["osx"]);
        if (!IsPostBack)
        { clsSeguridad obS = new clsSeguridad();
        obS.comprobarAcceso(Page, Session, Response, 1054);
            for (int k = 0; k < 60; k++)
            {
                cmbMinutosLlegada.Items.Add(new ListItem(k.ToString().PadLeft(2, '0'), k.ToString().PadLeft(2, '0')));
                cmbMinutosSalida.Items.Add(new ListItem(k.ToString().PadLeft(2, '0'), k.ToString().PadLeft(2, '0')));
            }
            #region informacion general
                lblOrdenServicio.Text = Request.Params["osx"];
            BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
            BOLayer.OrdenServicio os= osf.Get(int.Parse(lblOrdenServicio.Text));
            BOLayer.Usuario0Factory uf = new BOLayer.Usuario0Factory();
            

            txtAsesorComercial.Text = os.AsesoresComerciale.NombreAsesor;
            if (os.SucursalCliente != null && os.SucursalCliente.NombreSucursal != null)
            {
                txtSucursal.Text = os.SucursalCliente.NombreSucursal;
                txtTelefonoSucursal.Text = (os.SucursalCliente.Telefono1 == null)?"":os.SucursalCliente.Telefono1.Trim() + " - "
                    + ((os.SucursalCliente.Telefono2 == null)?"":os.SucursalCliente.Telefono2.Trim());
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

            SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter pos=new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();
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
            BOLayer.Usuario0 usu =uf.Get(os.AsignadoA);
            txtIngenieroAsignado.Text = usu.Nombre.Trim() +"("+os.AsignadoA.Trim()+")";
            txtFechaTentativainicio.Text = os.FechaProgramacion_Date + " " + os.FechaProgramacion_Time;
            txtFechaTentativaFin.Text = os.FechaFinProgramacion_Date + " " + os.FechaFinProgramacion_Time;
            //actividades realizadas
            txtFallasReportadas.Text = os.FallasReportadas;
            txtDiagnostico.Text = os.Diagnostico;
            txtObservacionesIngeniero.Text = os.ObservacionesIngeniero;
            if(os.CodEstadoOrdenServicio == "ANULA")
            {
                btnEditarActividadesRealizadas.Visible = false;
                btnReabrirOrden.Visible = false;
                btnCerrarOrden.Visible = false;
                btnGuardarRepuestos.Visible = false;
                btnAgregarActividad.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUpload1.Visible = false;
                FileUploadFirma.Visible = false;
                btnEditarAceptacion.Visible = false;
            }else if (os.CodEstadoOrdenServicio == "CERRA")
            {
                btnEditarActividadesRealizadas.Visible = false;
                btnReabrirOrden.Visible = true;
                btnCerrarOrden.Visible = false;
                btnGuardarRepuestos.Visible = false;
                btnAgregarActividad.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUpload1.Visible = false;
                FileUploadFirma.Visible=false;
                btnEditarAceptacion.Visible = false;
            }else if (os.CodEstadoOrdenServicio == "APROB"){
                btnEditarActividadesRealizadas.Visible = false;
                btnReabrirOrden.Visible = false;
                btnCerrarOrden.Visible = false;
                btnGuardarRepuestos.Visible = false;
                btnAgregarActividad.Visible = false;
                btnSubirArchivo.Visible = false;
                FileUpload1.Visible = false;
                FileUploadFirma.Visible = false;
                btnEditarAceptacion.Visible = false;
            }else{
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
                    cmbMinutosLlegada.Text = entrada.Substring( entrada.IndexOf(":")+1, 2);
                    cmbAmPmLlegada.Text = entrada.Substring(entrada.IndexOf(":") + 4, 2);
                }else{
                    cmbHoraLlegada.SelectedValue = "-1";
                    cmbMinutosLlegada.SelectedValue = "-1";
                    cmbAmPmLlegada.SelectedValue = "-1";
                }

                if (salida.Trim() != string.Empty)
                {
                    cmbHoraSalida.Text = int.Parse(salida.Substring(0, salida.IndexOf(":"))).ToString();
                    cmbMinutosSalida.Text = salida.Substring(salida.IndexOf(":") + 1, 2);
                    cmbAmPmSalida.Text = salida.Substring(salida.IndexOf(":") + 4, 2);
                }else{
                    cmbHoraSalida.SelectedValue = "-1";
                    cmbMinutosSalida.SelectedValue = "-1";
                    cmbAmPmSalida.SelectedValue = "-1";
                }
                SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter objCom = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                ds.EnforceConstraints = false;
                objCom.FillByInfAdi(ds.comprobantesAceptacionOrdenservicio, int.Parse(lblOrdenServicio.Text));
                //cargamos la imagen
                if (ds.comprobantesAceptacionOrdenservicio.Count > 0)
                {
                     System.Drawing.Image im= System.Drawing.Image.FromStream(new System.IO.MemoryStream(ds.comprobantesAceptacionOrdenservicio[0].datos));
                     string ruta = Server.MapPath("../../Temp/"); 
                    im.Save(ruta+"/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgFirma.ImageUrl = "../../Temp/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png";
                    imgFirma.Visible = true;
                    btnSubirFirma.Visible = false;
                    FileUploadFirma.Visible = false;
                    btnCancelarFirma.Visible = false;
                    btnCambiarFoto.Visible = false;
                }else{
                    imgFirma.Visible = false;
                    btnSubirFirma.Visible = true;
                    FileUploadFirma.Visible = true;
                    btnCancelarFirma.Visible = true;
                    btnCambiarFoto.Visible = false;
                }
            }
        }
    }

    public void verHojaVida(object sender,EventArgs e)
    {
        Response.Redirect("../hojaVida/frmHojaVida.aspx?sx="+txtSerial.Text);
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
        BOLayer.OrdenServicio os= osf.Get( int.Parse(lblOrdenServicio.Text) );

        txtFallasReportadas.Text = os.FallasReportadas ;
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

        os.FallasReportadas=txtFallasReportadas.Text;
         os.Diagnostico=txtDiagnostico.Text;
        os.ObservacionesIngeniero=txtObservacionesIngeniero.Text ;
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

    public void cerrarOrden(string codOrdenServicio)
    {
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1=new ordenServicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter1=new solicitudServicioTableAdapter();
        SPControladoraDatos.dsSpx  dsSpx1=new SPControladoraDatos.dsSpx();
        dsSpx1.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1=new defaultsTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1=new TipoServicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modeloT = new ModelosTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1 = new equiposTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter  entradaSalidaEquiposTableAdapter1    =new EntradaSalidaEquiposTableAdapter();
        ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio,int.Parse(codOrdenServicio));
        
        ordenServicioTableAdapter1.UpdateCerrada(DateTime.Now, Session["ss_login"].ToString(), "CERRA", int.Parse(codOrdenServicio));
        SPXdata.BD.DataConector bd=new SPXdata.BD.DataConector();

                // llenamos la tabla de solicitid de servicios segun el numero de orden 
                solicitudServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.solicitudServicio, int.Parse(codOrdenServicio));
                int EstadoSolicitud = 0;
        
        if(dsSpx1.solicitudServicio.Count>0)
        {
                    // Se trae el codigo de la solicitud de servicio
                    EstadoSolicitud =  dsSpx1.solicitudServicio[0].codSolicitudServicio;
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
                                "Se cambia La ubicacion Al cerrar la orden de Servicio "+codOrdenServicio+"!",
                                false, DateTime.Now, false, "", codEstado);
                            //debemos actualizar la salida
                            entradaSalidaEquiposTableAdapter1.updateSalidaDevolucion(
                                "local", codUbica, codEstado, dsSpx1.EntradaSalidaEquipos[0].codEntradaSalidaEquipos);
                        }
                        #endregion
                    
                }
                #endregion
                ////hay un nuevo requerimiento de acuerdo a la paremtrizacion de tipo de equipo y de tipo de servicio puede dar un salto mas y quedar aprobado de una vez.
                tipoServicioTableAdapter1.FillBycodTipoServicio(dsSpx1.TipoServicio,dsSpx1.ordenServicio[0].codTiposervicio.ToString());
                string codTipoEquipo = @"select top 1Modelos.codTipoEquipo from equipos join Modelos on 
                                         Modelos.codFabricante = equipos.codFabricante and Modelos.codModelo = equipos.codModelo
                                         where serial = '"+txtSerial.Text+"'";
                codTipoEquipo = bd.ejecutarProcedimiento(codTipoEquipo).ToString();
                tipoEquipoTableAdapter1.FillBycodTipoEquipo(dsSpx1.tipoEquipo, codTipoEquipo);
                if ((!dsSpx1.tipoEquipo[0].Isomite_aprobacion_osNull() && dsSpx1.tipoEquipo[0].omite_aprobacion_os) || (!dsSpx1.TipoServicio[0].Isomite_aprobacion_osNull() && dsSpx1.TipoServicio[0].omite_aprobacion_os))
                {
                    ////
                    ordenServicioTableAdapter1.UpdateAprobada(DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, "APROB", int.Parse(codOrdenServicio));
                    //cambias la fecha del ultimo mantenimiento en el equipo
                    equiposTableAdapter1.UpdateUltimoMantenimiento(dsSpx1.ordenServicio[0].fechaProgramacion, dsSpx1.ordenServicio[0].codTiposervicio,
                        dsSpx1.ordenServicio[0].observacionesIngeniero, txtSerial.Text);
                }
        }
    

    protected void btnCerrarOrden_Click(object sender, EventArgs e)
    {
        //miramos si tiene informacion de aceptacion de lo conrtatio no permitimos que cierre la orden
        BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));
        if (os.NombreUsuarioCliente == null || os.NombreUsuarioCliente.Trim() == string.Empty)
        {
            lblError.Text = "Para cerrar la orden debe tener informacion de aceptacion";
            return;
        }
        cerrarOrden(lblOrdenServicio.Text);
        //os.CodEstadoOrdenServicio = "CERRA";

        //osf.Save(os);
        //osf.Commit();

        btnEditarActividadesRealizadas.Visible = false;
        btnReabrirOrden.Visible = true;
        btnCerrarOrden.Visible = false;
        btnGuardarRepuestos.Visible = false;
        btnAgregarActividad.Visible = false;
        btnSubirArchivo.Visible = false;
        FileUpload1.Visible = false;
        FileUploadFirma.Visible = false;
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
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new ordenServicioTableAdapter();
        ordenServicioTableAdapter1.UpdateCerrada(null, null, "PROGR", int.Parse(lblOrdenServicio.Text));
        osf.Save(os);
        osf.Commit();

        btnCerrarOrden.Visible = true;
        btnReabrirOrden.Visible = false;
    }
    
    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmPrintOrden.aspx?os="+lblOrdenServicio.Text);
    }
    
    protected void btnAgregarActividad_Click(object sender, EventArgs e)
    {
        Session["osx"]=lblOrdenServicio.Text;
        Response.Redirect("frmAgregarActividad.aspx");
    }
    
    protected void btnGuardarRepuestos_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.repuestoxOrdenServicioTableAdapter r = new SPControladoraDatos.dsSpxTableAdapters.repuestoxOrdenServicioTableAdapter();
        r.DeleteBycodOrdenServicio(int.Parse( lblOrdenServicio.Text ));
        List<string> listaC= controlRepuestos1.verCodigos();
        List<string> listaN= controlRepuestos1.verText();
        for (int k = 0; k < listaC.Count;k++ )
        {
            string a=listaN[k].Substring(listaN[k].LastIndexOf('('),listaN[k].Length- listaN[k].LastIndexOf('('));
            int cantidad = int.Parse( a.Replace("(","").Replace(")",""));
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
        int id= int.Parse(obj.verNextId(int.Parse(lblOrdenServicio.Text)).ToString());

        obj.Insert(int.Parse(lblOrdenServicio.Text), id, FileUpload1.FileName, arr, FileUpload1.FileName + " subido desde web");
        lblError.Text = "Se subio el archivo satisfactoriamente!";
    }

    protected void btnEditarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
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
        if (imgFirma.ImageUrl.Trim() != string.Empty)
        {
            btnCambiarFoto.Visible = true;
            
        }else{
            btnCambiarFoto.Visible = false;
            FileUploadFirma.Visible = true;
            btnSubirFirma.Visible = true;
        }
    }

    protected void btnCancelarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
        btnEditarAceptacion.Visible  = true;
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
        imgFirma.ImageUrl = "";
        btnCambiarFoto.Visible = false;
        FileUploadFirma.Visible = false;
        btnSubirFirma.Visible = false;
        //--
        BOLayer.OrdenServicioFactory f = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os=  f.Get(int.Parse(lblOrdenServicio.Text));
        if (os.NombreUsuarioCliente != null)
        {
            txtUsuarioAceptacion.Text = os.NombreUsuarioCliente;
            //el FORMATO ES 12:54 PM
            string entrada = os.HoraEntradaControl;
            string salida = os.HoraSalidaControl;
            if (entrada.Trim() != string.Empty)
            {
                cmbHoraLlegada.Text = int.Parse(entrada.Substring(0, 2)).ToString();
                cmbMinutosLlegada.Text = entrada.Substring(3, 2);
                cmbAmPmLlegada.Text = entrada.Substring(6, 2);
            }
            if (salida.Trim() != string.Empty)
            {
                cmbHoraSalida.Text = int.Parse(salida.Substring(0, 2)).ToString(); ;
                cmbMinutosSalida.Text = salida.Substring(3, 2);
                cmbAmPmSalida.Text = salida.Substring(6, 2);
            }
            SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter objCom = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
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
        }else{
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
        btnEditarAceptacion.Visible = true;
        btnAceptarAceptacion.Visible = false;
        btnCancelarAceptacion.Visible = false;
        BOLayer.OrdenServicioFactory osf=new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));
        os.NombreUsuarioCliente = txtUsuarioAceptacion.Text;
        os.HoraEntradaControl = cmbHoraLlegada.Text + ":" + cmbMinutosLlegada.Text + " " + cmbAmPmLlegada.Text.ToUpper();
        os.HoraSalidaControl = cmbHoraSalida.Text + ":" + cmbMinutosSalida.Text + " " + cmbAmPmSalida.Text.ToUpper();

        osf.Save(os);
        osf.Commit(); 
        btnSubirFirma.Visible = false;
                    FileUploadFirma.Visible = false;
                    btnCancelarFirma.Visible = false;
                    btnCambiarFoto.Visible = false;
                //cargamos la imagen
                if (imgFirma.ImageUrl.Trim() != string.Empty)
                {
                    imgFirma.Visible = true;
                }else{
                    imgFirma.Visible = false;
                }
    }
        

    

    protected void btnCambiarFoto_Click(object sender, EventArgs e)
    {
        btnCambiarFoto.Visible = false;
        btnSubirFirma.Visible = true;
        btnCancelarFirma.Visible = true;
        FileUploadFirma.Visible = true;
    }

    protected void btnCancelarFirma_Click(object sender, EventArgs e)
    {
        btnCambiarFoto.Visible = true;
        btnSubirFirma.Visible = false;
        btnCancelarFirma.Visible = false;
        FileUploadFirma.Visible = false;
    }
 
    protected void btnSubirFirma_Click(object sender, EventArgs e)
    {
        //guardamos la informacion de la foto
        btnCambiarFoto.Visible = true;
        btnSubirFirma.Visible = false;
        btnCancelarFirma.Visible = false;
        FileUploadFirma.Visible = false;

        SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
        obj.Deleteinfadi(int.Parse( lblOrdenServicio.Text));
        int id = int.Parse( obj.verNextId(int.Parse( lblOrdenServicio.Text )).ToString());
        obj.Insert(id, int.Parse(lblOrdenServicio.Text), "infadi", null, FileUploadFirma.FileBytes, System.IO.Path.GetFileName( FileUploadFirma.FileName) );        
        //
        System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream(FileUploadFirma.FileBytes));
        string ruta = Server.MapPath("../../Temp/");
        im.Save(ruta + "/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png", System.Drawing.Imaging.ImageFormat.Png);
        imgFirma.ImageUrl = "../../Temp/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png";
        imgFirma.Visible = true;
    }
}

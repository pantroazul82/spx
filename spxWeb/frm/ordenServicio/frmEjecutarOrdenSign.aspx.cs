using SPControladoraDatos.dsSpxTableAdapters;
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
        controlSerial1.OnSerialSelected += controlSerial1_OnSerialSelected;
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
            ds.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTA = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            ordenServicioTA.FillByCodOrdenServicio(ds.ordenServicio, int.Parse(lblOrdenServicio.Text));

            //cargamos informacion de la orden de servicio
            if (!ds.ordenServicio[0].IsfechaUltimoMantenimientoxUsuarioNull())
            {
                calultimoMantenimientoxUsuario.SelectedDate = ds.ordenServicio[0].fechaUltimoMantenimientoxUsuario;
               // calultimoMantenimientoxUsuario.Enabled = false;
            }//else{
            //    calultimoMantenimientoxUsuario.Enabled = true;
            //}

            if (!ds.ordenServicio[0].IsmantenimientoSegunIndicacionesNull())
            {
                rdManteimientoIndicadoSi.Checked = ds.ordenServicio[0].mantenimientoSegunIndicaciones;
                rdManteimientoIndicadoNo.Checked = !ds.ordenServicio[0].mantenimientoSegunIndicaciones;
            //    //--
            //    rdManteimientoIndicadoSi.Enabled = false;
            //    rdManteimientoIndicadoNo.Enabled = false;
            }
            //else {
            //    rdManteimientoIndicadoSi.Enabled = true;
            //    rdManteimientoIndicadoNo.Enabled = true;
            //}

            if (!ds.ordenServicio[0].Isequipo_adecuadoNull())
            {
                rdAdecuadoSi.Checked = ds.ordenServicio[0].equipo_adecuado;
                rdAdecuadoNo.Checked = !ds.ordenServicio[0].equipo_adecuado;
            //    //--
            //    rdAdecuadoSi.Enabled = false;
            //    rdAdecuadoNo.Enabled = false;
            }
            //else
            //{
            //    rdAdecuadoSi.Enabled = true;
            //    rdAdecuadoNo.Enabled = true;
            //}

            lnkImprimir.NavigateUrl = "frmPrintOrden.aspx?os=" + lblOrdenServicio.Text;
            BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
            BOLayer.OrdenServicio os = osf.Get(int.Parse(lblOrdenServicio.Text));
            BOLayer.Usuario0Factory uf = new BOLayer.Usuario0Factory();

            if( os != null && os.AsesoresComerciale != null)
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
                btnSubirArchivo.Visible = false;
                FileUpload1.Visible = false;
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
                btnSubirArchivo.Visible = false;
                FileUpload1.Visible = false;
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
                if (ds.comprobantesAceptacionOrdenservicio.Count > 0 && ds.comprobantesAceptacionOrdenservicio[0].datos.Length>0)
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

        calultimoMantenimientoxUsuario.Enabled = true;
        rdAdecuadoNo.Enabled = true;
        rdAdecuadoSi.Enabled = true;
        rdManteimientoIndicadoNo.Enabled = true;
        rdManteimientoIndicadoSi.Enabled = true;
        
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

        calultimoMantenimientoxUsuario.Enabled = false;
        rdAdecuadoNo.Enabled = false;
        rdAdecuadoSi.Enabled = false;
        rdManteimientoIndicadoNo.Enabled = false;
        rdManteimientoIndicadoSi.Enabled = false;
    
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
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ost = new ordenServicioTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ost.FillByCodOrdenServicio(ds.ordenServicio, int.Parse(lblOrdenServicio.Text));
        if (ds.ordenServicio[0].codEstadoOrdenServicio == "PROGR")
        {
            ost.UpdateEstado("EJECU", int.Parse(lblOrdenServicio.Text));
         
            txtEstado.Text = "Ejecucion";
        }

        ost.UpdateObservacionesWeb(txtObservacionesIngeniero.Text, txtFallasReportadas.Text,
            txtDiagnostico.Text, rdManteimientoIndicadoSi.Checked, calultimoMantenimientoxUsuario.SelectedDate,
            rdAdecuadoSi.Checked, int.Parse(lblOrdenServicio.Text));

        txtFallasReportadas.ReadOnly = true;
        txtDiagnostico.ReadOnly = true;
        txtObservacionesIngeniero.ReadOnly = true;
        calultimoMantenimientoxUsuario.Enabled = false;
        rdAdecuadoNo.Enabled = false;
        rdAdecuadoSi.Enabled = false;
        rdManteimientoIndicadoNo.Enabled = false;
        rdManteimientoIndicadoSi.Enabled = false;
    }

    private bool validarVariablesMedicion(bool mostrarDialogo)
    {
        string sql = @" select 
 variables_medicion.nombre_variables_medicion,
 sub_variable_medicion.nombre_subvariable,
 variables_medicionxorden_servicio.resultado_variable,
  variables_medicionxmodelo.rango_inicial,variables_medicionxmodelo.rango_final
  from variables_medicionxorden_servicio 
	
	join(select max(cod_variables_medicionxorden_servicio) id,cod_sub_variable_medicion from variables_medicionxorden_servicio group by cod_sub_variable_medicion ) 
	st on st.id = variables_medicionxorden_servicio.cod_variables_medicionxorden_servicio
	 join ordenServicio on ordenServicio.codOrdenServicio = variables_medicionxorden_servicio.codOrdenServicio
	 join equipos on equipos.serial= ordenServicio.serial
	  join variables_medicionxmodelo on variables_medicionxmodelo.codFabricante = equipos.codFabricante 
	  and variables_medicionxmodelo.codModelo = equipos.codModelo
	    and variables_medicionxmodelo.cod_sub_variables_medicion = variables_medicionxorden_servicio.cod_sub_variable_medicion

		join sub_variable_medicion on variables_medicionxorden_servicio.cod_sub_variable_medicion = sub_variable_medicion.cod_sub_variables_medicion
		  join variables_medicion on sub_variable_medicion.cod_variables_medicion = variables_medicion.cod_variables_medicion
 where variables_medicionxorden_servicio.codOrdenServicio = " + lblOrdenServicio.Text + @"
 and 
 (
 variables_medicionxorden_servicio.resultado_variable < variables_medicionxmodelo.rango_inicial
 or variables_medicionxorden_servicio.resultado_variable > variables_medicionxmodelo.rango_final)";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count == 0) return true;

        if (mostrarDialogo)
        {
            string problemas = "";
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                problemas += "\n" + tb.Rows[0]["nombre_variables_medicion"] + " (" + tb.Rows[0]["nombre_subvariable"].ToString().Trim() + ") valor:" + tb.Rows[0]["resultado_variable"] + " rango esperado ( " +
                    tb.Rows[0]["rango_inicial"] + " - " + tb.Rows[0]["rango_final"] + ")";
            }
           lblError.Text="Las siguientes variables de medicion tiene valores fuera lo esperado " + problemas+ " Variables de medicion fuera del rango.";

        }


        return false;
    }

    protected void btnCerrarOrden_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter osTa = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
       //guardamos la informacion si es mantenimiento segun lo adecuado
        if(rdManteimientoIndicadoNo.Checked || rdManteimientoIndicadoSi.Checked)
        osTa.UpdateMantenimientoSegunIndicado(rdManteimientoIndicadoSi.Checked, calultimoMantenimientoxUsuario.SelectedDate,
            (!rdAdecuadoNo.Checked && !rdAdecuadoSi.Checked)?(bool?)null:rdAdecuadoSi.Checked  
            ,int.Parse(lblOrdenServicio.Text));
        
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
        /*
         */
        /*
               para el mantenimiento preventivo  es importante que diligencia minimo las variables configuradas como obligatorias para poder cerrar la orden.
               */

        if (rdAdecuadoSi.Checked)
        {
            if (!validarVariablesMedicion(true))
            {
                return;
            }
        }

        SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter TipoServicioTableAdapter1 = new TipoServicioTableAdapter();
        TipoServicioTableAdapter1.FillBycodTipoServicio(ds.TipoServicio, ds.ordenServicio[0].codTiposervicio);
        if (!ds.TipoServicio[0].IspreventivoNull() && ds.TipoServicio[0].preventivo)
        {
            string sql = @"select distinct variables_medicion.* from equipos 
 join variables_medicionxmodelo on variables_medicionxmodelo.codFabricante = equipos.codFabricante and variables_medicionxmodelo.codModelo = equipos.codModelo 
and variables_medicionxmodelo.obligatorio_preventivo=1
   join variables_medicion on variables_medicionxmodelo.cod_variables_medicion = variables_medicion.cod_variables_medicion
 where serial ='" + txtSerial.Text + @"'
 and variables_medicion.cod_variables_medicion not in(
     select sub_variable_medicion.cod_variables_medicion   from  
	   variables_medicionxorden_servicio 
	   join sub_variable_medicion on sub_variable_medicion.cod_sub_variables_medicion = variables_medicionxorden_servicio.cod_sub_variable_medicion
	   where variables_medicionxorden_servicio.codOrdenServicio = " + lblOrdenServicio.Text.Trim() + "   )";
            //---
            SPXdata.BD.DataConector dc=new SPXdata.BD.DataConector();
            System.Data.DataTable tb = dc.ejecutarConsulta(sql).Tables[0];
            if (tb.Rows.Count > 0)
            {
                string variables = "";
                for (int k = 0; k < tb.Rows.Count; k++)
                {
                    variables += "\n" + tb.Rows[k]["nombre_variables_medicion"].ToString();
                }
                lblError.Text = "Los mantenimientos preventivos para este modelo debe incluir las siguientes variables de medicion que no estan incluidas:" + variables+ " Variables incompletas";
                return;
                
            }
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
       Response.Redirect("frmFirmaN.aspx?osx="+Request.QueryString["osx"]);
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
        dsSpx1.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modeloT = new ModelosTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1 = new equiposTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter entradaSalidaEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter();
        ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, int.Parse(codOrdenServicio));

        DateTime f = DateTime.Now;
        if (!dsSpx1.ordenServicio[0].IsfechaCierreNull())
            f = dsSpx1.ordenServicio[0].fechaCierre;
        ordenServicioTableAdapter1.UpdateCerrada(f, Session["ss_login"].ToString(), "CERRA", int.Parse(codOrdenServicio));
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
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
        ////hay un nuevo requerimiento de acuerdo a la paremtrizacion de tipo de equipo y de tipo de servicio puede dar un salto mas y quedar aprobado de una vez.
        tipoServicioTableAdapter1.FillBycodTipoServicio(dsSpx1.TipoServicio, dsSpx1.ordenServicio[0].codTiposervicio.ToString());
        string codTipoEquipo = @"select top 1Modelos.codTipoEquipo from equipos join Modelos on 
                                         Modelos.codFabricante = equipos.codFabricante and Modelos.codModelo = equipos.codModelo
                                         where serial = '" + txtSerial.Text + "'";
        codTipoEquipo = bd.ejecutarProcedimiento(codTipoEquipo).ToString();
        tipoEquipoTableAdapter1.FillBycodTipoEquipo(dsSpx1.tipoEquipo, codTipoEquipo);
        if ((!dsSpx1.tipoEquipo[0].Isomite_aprobacion_osNull() && dsSpx1.tipoEquipo[0].omite_aprobacion_os) || (!dsSpx1.TipoServicio[0].Isomite_aprobacion_osNull() && dsSpx1.TipoServicio[0].omite_aprobacion_os))
        {
            ////
            ordenServicioTableAdapter1.UpdateAprobada(DateTime.Now, Session["ss_login"].ToString(), "APROB", int.Parse(codOrdenServicio));
            //cambias la fecha del ultimo mantenimiento en el equipo
            equiposTableAdapter1.UpdateUltimoMantenimiento(dsSpx1.ordenServicio[0].fechaProgramacion, dsSpx1.ordenServicio[0].codTiposervicio,
                dsSpx1.ordenServicio[0].observacionesIngeniero, txtSerial.Text);
        }
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
    protected void btnHojaVidaMedicion_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton btn = (ImageButton)sender;
        if (btn.CommandArgument != null && btn.CommandArgument.Trim() != string.Empty)
        {
            Response.Redirect("../hojaVida/frmHojaVida.aspx?sx=" + btn.CommandArgument);
        }
    }
    protected void btnElimnarVariable_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton btn = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.variables_medicionxorden_servicioTableAdapter ta = new variables_medicionxorden_servicioTableAdapter();
        ta.DeleteQuery(int.Parse(btn.CommandArgument));
        grdVariablesxOrden.DataBind();
    }
    protected void btnEditarVariableMedicion_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btnEditarVariableMedicion_Click1(object sender, ImageClickEventArgs e)
    {
        ImageButton im = (ImageButton)sender;
        lblCodVariable.Text = im.CommandArgument;
        //
        SPControladoraDatos.dsSpxTableAdapters.variables_medicionxorden_servicioTableAdapter variables_medicionxorden_servicioTableAdapter1 = new variables_medicionxorden_servicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.sub_variable_medicionTableAdapter sub_variable_medicionTableAdapter1 = new sub_variable_medicionTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx(); 
        variables_medicionxorden_servicioTableAdapter1.FillByCod_variables_medicionxorden_servicio(dsSpx1.variables_medicionxorden_servicio, int.Parse(lblCodVariable.Text));
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        sub_variable_medicionTableAdapter1.FillByCod_sub_variables_medicion(ds.sub_variable_medicion, dsSpx1.variables_medicionxorden_servicio[0].cod_sub_variable_medicion);
        cmbVariableMedicion.SelectedValue = ds.sub_variable_medicion[0].cod_variables_medicion.ToString();
            cmbVariableMedicion.Enabled = false;
            cmbSubvariable.DataBind();
            cmbSubvariable.SelectedValue = dsSpx1.variables_medicionxorden_servicio[0].cod_sub_variable_medicion.ToString();
            //cmbVariableMedicion.SelectedValue = dsSpx1.variables_medicionxorden_servicio[0].cod_variables_medicion;
            txtValorUnidades.Text = dsSpx1.variables_medicionxorden_servicio[0].resultado_variable.ToString();
            if (!dsSpx1.variables_medicionxorden_servicio[0].Isrelizado_por_equipoNull())
                chkCalculadoPorEquipos.Checked = dsSpx1.variables_medicionxorden_servicio[0].relizado_por_equipo;
        

        cargarUnidades();
        ModalVariables.Show();
    }
    protected void btnElimnarDispositivo_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton btn=(ImageButton)sender;

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        bd.ejecutarComando("delete dispositivosmedicionxordenservicio where cod_dispositivosmedicionxordenservicio='" + btn.CommandArgument + "' ");
        grdDispositivoMedicion.DataBind();

    }
    protected void btnAceptarDispositivos_Click(object sender, EventArgs e)
    {
        lblErrorDispositivos.Text = "validando";
        if ( txtFabricanteExterno.Text  == string.Empty)
        {
            lblErrorDispositivos.Text = "El fabricante es obligatorio ";
            return;
        }

        if ( txtModeloExterno.Text  == string.Empty)
        {
            lblErrorDispositivos.Text = "El Modelo es obligatorio ";
            return;
        }

        if (txtSerialExterno.Text.Trim() == string.Empty)
        {
            lblErrorDispositivos.Text = "El serial externo es obligatorio ";
            return;
        }

        int codOrdenServicio = int.Parse(lblOrdenServicio.Text);
        SPControladoraDatos.dsSpxTableAdapters.dispositivosmedicionxordenservicioTableAdapter dispositivosmedicionxordenservicioTableAdapter1 = new dispositivosmedicionxordenservicioTableAdapter();
        if (lblcoddispositivoExterno.Text == string.Empty)
        {

            dispositivosmedicionxordenservicioTableAdapter1.Insert(null, codOrdenServicio, null,null,txtSerialExterno.Text,txtResponsableExterno.Text,txtFabricanteExterno.Text,txtModeloExterno.Text);
        }else{
            dispositivosmedicionxordenservicioTableAdapter1.UpdateQuery(null,null,txtSerialExterno.Text,txtResponsableExterno.Text,txtFabricanteExterno.Text,txtModeloExterno.Text, int.Parse(lblcoddispositivoExterno.Text));
        }
        txtFabricanteExterno.Text = "";
        txtModeloExterno.Text = "";
        lblErrorDispositivos.Text = "";
        lblErrorDispositivos.Text = "";
        grdDispositivoMedicion.DataBind();
        ModalDispositivos.Hide();
        pnlGrillasMetrologia.Update();
    }

    void controlSerial1_OnSerialSelected(object sender, EventArgs e)
    {
        int codOrdenServicio = int.Parse(lblOrdenServicio.Text);
        SPControladoraDatos.dsSpxTableAdapters.dispositivosmedicionxordenservicioTableAdapter dispositivosmedicionxordenservicioTableAdapter1 = new dispositivosmedicionxordenservicioTableAdapter();
        string serialSeleccionado = controlSerial1.verCodigos()[0];
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter tae = new equiposTableAdapter();
        tae.FillBySerial(ds.equipos, serialSeleccionado);
        if (lblcoddispositivoExterno.Text == string.Empty)
        {
            
            dispositivosmedicionxordenservicioTableAdapter1.Insert(serialSeleccionado, codOrdenServicio, 
                ds.equipos[0].codFabricante, ds.equipos[0].codModelo, "","","","");
        }else{
            dispositivosmedicionxordenservicioTableAdapter1.UpdateQuery(ds.equipos[0].codFabricante,ds.equipos[0].codModelo,"","","","", int.Parse(lblcoddispositivoExterno.Text));
        }
        controlSerial1.limpiarControl();
        lblErrorDispositivos.Text = "";
        lblErrorDispositivos.Text = "";
        grdDispositivoMedicion.DataBind();
        ModalDispositivos.Hide();
        pnlGrillasMetrologia.Update();
    }

    protected void btnCancelarDispositivos_Click(object sender, EventArgs e)
    {
        ModalDispositivos.Hide();
    }
    protected void btnAceptarVariables_Click(object sender, EventArgs e)
    {

        lblErrorVariables.Text = "";
        if (cmbVariableMedicion.SelectedValue == null || cmbVariableMedicion.SelectedValue.Trim() == string.Empty)
        {
            lblErrorVariables.Text = "La variable es obligatoria ";
            return;
        }

        if (cmbSubvariable.SelectedValue == null || cmbSubvariable.SelectedValue.Trim() == string.Empty)
        {
            lblErrorVariables.Text = "La sub variable es obligatoria ";
            return;
        }
        decimal valor = 0;
        if (txtValorUnidades.Text.Trim() == string.Empty)
        {
            lblErrorVariables.Text = "El valor es obligatorio ";
            return;
        }

        if (!decimal.TryParse(txtValorUnidades.Text.Replace(",",".").Replace(".",System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator),out valor))
        {
            lblErrorVariables.Text = "El valor ingresado no es valido ";
            return;
        }
        int codOrdenServicio = int.Parse(lblOrdenServicio.Text);
        SPControladoraDatos.dsSpxTableAdapters.variables_medicionxorden_servicioTableAdapter variables_medicionxorden_servicioTableAdapter1 = new variables_medicionxorden_servicioTableAdapter();
        if (lblCodVariable.Text == string.Empty)
        {
      
                variables_medicionxorden_servicioTableAdapter1.Insert(codOrdenServicio, valor, int.Parse(cmbSubvariable.SelectedValue.ToString()),chkCalculadoPorEquipos.Checked);
            }else{
                variables_medicionxorden_servicioTableAdapter1.UpdateQuery(valor, int.Parse(cmbSubvariable.SelectedValue.ToString()), chkCalculadoPorEquipos.Checked, int.Parse(lblCodVariable.Text));
            }
        lblCodVariable.Text = "";
        lblErrorVariables.Text = "";
        grdVariablesxOrden.DataBind();
        ModalVariables.Hide();
        pnlGrillasMetrologia.Update();
    }

    protected void btnCancelarVariables_Click(object sender, EventArgs e)
    {
        ModalVariables.Hide();
    }
    protected void btnDispostivoExterno_Click(object sender, EventArgs e)
    {
        txtFabricanteExterno.Text = "";
        txtModeloExterno.Text = "";
        txtSerialExterno.Text = "";
        lblErrorDispositivos.Text = "";
        txtResponsableExterno.Text = "";
        lblcoddispositivoExterno.Text = "";
        ModalDispositivos.Show();
    }
    protected void btnAgregarVariable_Click(object sender, EventArgs e)
    {
        lblCodVariable.Text = "";
        cmbVariableMedicion.Enabled = true;
        txtValorUnidades.Text = "";
        txtUnidades.Text = "";
        cmbVariableMedicion.SelectedValue=null;
        cmbSubvariable.SelectedValue = null;
        chkCalculadoPorEquipos.Checked = false;
        ModalVariables.Show();
    }
    
    protected void cmbSubvariable_SelectedIndexChanged(object sender, EventArgs e)
    {
        cargarUnidades();
    }

    private void cargarUnidades()
    {
        if (cmbSubvariable.SelectedValue == null || cmbSubvariable.SelectedValue.Trim() ==string.Empty) return;
        //obtenemos el modelo del serial de la orden de servicio
        string sql = @"select codModelo,codFabricante from ordenServicio 
 join equipos on equipos.serial= ordenServicio.serial
 
 where codOrdenServicio= " + lblOrdenServicio.Text;
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        System.Data.DataTable tbFabricante = bd.ejecutarConsulta(sql).Tables[0];
        //valida si tiene configurado el valor de las unidades para el modelo
        sql = "select unidades,rango_inicial,rango_final from variables_medicionxmodelo where codModelo='" + tbFabricante.Rows[0]["codModelo"].ToString() +
            "' and codFabricante ='" + tbFabricante.Rows[0]["codFabricante"].ToString() + "' and cod_sub_variables_medicion=" + cmbSubvariable.SelectedValue;
        System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {
            txtUnidades.Text = tb.Rows[0][0].ToString();
            lblRangosVariables.Text = tb.Rows[0][1].ToString().Trim() + " - " + tb.Rows[0][2].ToString().Trim() + " " + tb.Rows[0][0].ToString();
        }
        else
        {
            lblRangosVariables.Text = "";
            txtUnidades.Text = bd.ejecutarProcedimiento("select unidades from variables_medicion where cod_variables_medicion=" + cmbVariableMedicion.SelectedValue).ToString();
        }
        //si no entonces toma las unidades de la variable de medicion

    }
    protected void UpdatePanelVariables_Load(object sender, EventArgs e)
    {
        cargarUnidades();
    }

    protected void cmbSubvariable_DataBound(object sender, EventArgs e)
    {
        cargarUnidades();
    }

    protected void pnlGrillasMetrologia_Load(object sender, EventArgs e)
    {
        //controlSerial1.limpiarControl();
    }
}

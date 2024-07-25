using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.hojavida
{
    public partial class frmHojaVida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obS = new clsSeguridad();
            obS.comprobarAcceso(Page, Session, Response, 1115);
            //verficamos seguridad
            if (!IsPostBack)
            {
                string serial = Request.Params["sx"];
                cargarserial(serial);
            }
        }

        private void cargarTiempomantenimiento(float duracionModelo)
        {
            if (duracionModelo != 0)
            {
                txtDuracionMantenimiento.Text = ((int)duracionModelo) + " Horas ";
                if ((duracionModelo - ((int)duracionModelo)) != 0)
                    txtDuracionMantenimiento.Text += ((duracionModelo - ((int)duracionModelo)) * 60) + " Minutos";
            }
        }

        private bool cargarserial(string serial)
        {
            if (serial == null)
            {
                Response.Redirect("frmSeguimiento.aspx");
            }
            SPXdata.BD.DataConector.CadenaConexionAsignada = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["spxConnectionString"].ConnectionString;
            SPXdata.BD.DataConectorSql sql = new SPXdata.BD.DataConectorSql();
            
            txtSerial.Text = serial.Trim();
            #region creamos los table adapter
            //miramos si existe el serial
            SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter vistaEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter modelosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModelosTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.tipoPropiedadTableAdapter tipoPropiedadTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoPropiedadTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.unidadPesoTableAdapter unidadPesoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.unidadPesoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter modalidadEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ModalidadEquipoTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            dsSpx1.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter clientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.clientesTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursalClienteTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter contactosClientesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contactosClientesTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter paisesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter departamentoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter ciudadesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter equipoAuxiliarTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter();
            #endregion
            #region cargamos informacion general
            dsSpx1.EnforceConstraints = false;
            //llenamos el serial

            string sqlD = "SELECT Codadicional, codEstadoLocal, codEstadoLocalReserva, codFabricante, codModadlidadReserva, codModalidadEquipo, codModelo, codSucursalReserva, codSucursalUbica, codSucursalUbicaReal, codTipoPropiedad, codTipoServicio, creado_por, eliminado_por, fechaCambioTipoPropiedad, fechaLlegada, fechaProximaProgramacion, fechaProximoMante, fechaSalida, fechaUltimoMante, fechaUltimoTraslado, fecha_creacion, fecha_eliminacion, fecha_recreado, motivo_eliminacion, nitClienteReserva, nitClienteUbica, nitClienteUbicacionReal, obsequipo, observacionesUltimoMante, recreado_por, serial, ultimo_responsable, usuarioCambio FROM equipos WHERE (serial = '"+ txtSerial.Text + "') AND (fecha_eliminacion IS NULL)";
            dsSpx1.equipos.Merge(
            sql.ejecutarConsulta(sqlD).Tables[0]
            );

            sqlD = "SELECT        nombrefabricante, nombremodelo, nombretipoequipo, nombresubtipo, nombremodalidadequipo, nombreestadolocal, nitCliente, nombreCliente, nombreSucursal, \r\n                         nombrePais, NombreDepartamento, nombreCiudad, serial, fechaLlegada, fechaSalida, fechaProximoMante, fechaUltimoMante, codTipoServicio, \r\n                         observacionesUltimoMante, fechaProximaProgramacion, codSucursalUbica, nitClienteUbicacionReal, clientereal, sucursallocal, ultimo_responsable\r\n\r\n FROM dbo.vistaEquipo\r\nwhere\r\nserial = '"+txtSerial.Text+"'";

            dsSpx1.vistaEquipo.Merge(
                 sql.ejecutarConsulta(sqlD).Tables[0]
                );
            
            if (dsSpx1.vistaEquipo.Rows.Count <= 0)
            {
                return false;
            }

            if (!dsSpx1.equipos[0].IsfechaProximoManteNull()) txtFechaProximoMantemiento.Text = dsSpx1.equipos[0].fechaProximoMante.ToLongDateString();
            if (!dsSpx1.equipos[0].IsfechaUltimoManteNull()) txtFechaUltimoMantenimiento.Text = dsSpx1.equipos[0].fechaUltimoMante.ToLongDateString();
            if (!dsSpx1.equipos[0].IsobsequipoNull()) txtObservacionesEquipo.Text = dsSpx1.equipos[0].obsequipo;
            if (!dsSpx1.equipos[0].IsCodadicionalNull()) txtCodigoAdicional.Text = dsSpx1.equipos[0].Codadicional;
            if (!dsSpx1.equipos[0].IscodTipoPropiedadNull())
            {
                sqlD = @"select codTipoPropiedad,nombreTipoPropiedad,descripcion from tipoPropiedad where codTipoPropiedad='"+dsSpx1.equipos[0].codTipoPropiedad+"'";
                dsSpx1.tipoPropiedad.Merge(
                 sql.ejecutarConsulta(sqlD).Tables[0]
                );
              
                txtTipoPropiedad.Text = dsSpx1.tipoPropiedad[0].nombreTipoPropiedad;
            }
            else { txtTipoPropiedad.Text = "No Asignado"; }

            txtFabricante.Text = dsSpx1.vistaEquipo[0].nombrefabricante;
            #region todo lo que tiene que ver con el modelo
            txtModelo.Text = dsSpx1.vistaEquipo[0].nombremodelo;
            string codModelo = dsSpx1.equipos[0].codModelo;
            string codFabricante = dsSpx1.equipos[0].codFabricante;



            sqlD = "SELECT NombreModelo, amperios, codFabricante, codModelo, codSubTipoEquipo, codTipoEquipo, codUnidadPeso, descripcion, diasxMantenimiento, duracionMantenimiento, "+
                "cast(null as image) 'fotografia', frecuencia,cast(null  as image) 'manual', mesesxMantenimiento, nombreManual, "+
                "pesoEstimado, voltaje, watios FROM Modelos WHERE (codFabricante = '"+ dsSpx1.equipos[0].codFabricante + "') AND (codModelo ='"+ codModelo + "')";

            dsSpx1.Modelos.Merge(
                 sql.ejecutarConsulta(sqlD).Tables[0]
                );
            //cargamos el tiempo de mantenimiento
            string tiempoMan = "";
            if (!dsSpx1.Modelos[0].IsmesesxMantenimientoNull() && dsSpx1.Modelos[0].mesesxMantenimiento > 0)
            {
                tiempoMan = dsSpx1.Modelos[0].mesesxMantenimiento + " Meses ";
            }
            if (!dsSpx1.Modelos[0].IsdiasxMantenimientoNull() && dsSpx1.Modelos[0].diasxMantenimiento > 0)
            {
                tiempoMan += dsSpx1.Modelos[0].diasxMantenimiento + " Dias ";
            }
            txtFrecuenciaManetemiento.Text = tiempoMan;
            float duracionModelo = 0;
            if (!dsSpx1.Modelos[0].IsduracionmantenimientoNull())
            {
                duracionModelo = (float)dsSpx1.Modelos[0].duracionmantenimiento;
            }
            if (!dsSpx1.Modelos[0].IsamperiosNull()) txtAmperios.Text = dsSpx1.Modelos[0].amperios;
            if (!dsSpx1.Modelos[0].IswatiosNull()) txtWatios.Text = dsSpx1.Modelos[0].watios;
            if (!dsSpx1.Modelos[0].IsvoltajeNull()) txtVoltaje.Text = dsSpx1.Modelos[0].voltaje;
            if (!dsSpx1.Modelos[0].IsfrecuenciaNull()) txtFrecuencia.Text = dsSpx1.Modelos[0].frecuencia;
            if (!dsSpx1.Modelos[0].IspesoEstimadoNull()) txtPeso.Text = dsSpx1.Modelos[0].pesoEstimado.ToString();
            if (!dsSpx1.Modelos[0].IscodUnidadPesoNull()) txtPeso.Text = txtPeso.Text + " " + unidadPesoTableAdapter1.verUnidad(dsSpx1.Modelos[0].codUnidadPeso);


            cargarTiempomantenimiento(duracionModelo);
            //
            txtTipoEquipo.Text = dsSpx1.vistaEquipo[0].nombretipoequipo;
            //
            txtSubTipoEquipo.Text = dsSpx1.vistaEquipo[0].nombresubtipo;
            if (!dsSpx1.vistaEquipo[0].IsnombremodalidadequipoNull())
            {
                txtModalidad.Text = dsSpx1.vistaEquipo[0].nombremodalidadequipo;
            }
            #endregion
            //Informacion del Cliente
            sqlD = "SELECT apellidosContacto, celular, codTipoDoc, docContacto, email, esLocal, fax, logotipo, nitCliente, nombreCliente, nombreContactoPrincipal, numeroSocio, telefono1, telefono2, tituloContacto FROM clientes "+
                " WHERE (nitCliente = '"+ dsSpx1.vistaEquipo[0].nitCliente + "')";

            dsSpx1.clientes.Merge(
                 sql.ejecutarConsulta(sqlD).Tables[0]
                );
            txtNitCliente.Text = dsSpx1.vistaEquipo[0].nitCliente;
            txtNombreCliente.Text = dsSpx1.vistaEquipo[0].nombreCliente;



            // txtTelefonoCliente.Text = (dsSpx1.clientes[0].Istelefono1Null()) ? "" : dsSpx1.clientes[0].telefono1;

            //informacion de la ubicacion
            sqlD = "SELECT        nitCliente, codSucursal, nombreSucursal, codPais, codCiudad, Direccion,"+
                " Telefono1, Telefono2, codContacto, codDepartamento, bloqueaSalida,  activaParaTraslados, "+
                "requierePermisoParaTraslados FROM            sucursalCliente "+
                 "WHERE (nitCliente = '"+ txtNitCliente.Text + "') AND (codSucursal = '" +dsSpx1.equipos[0].codSucursalUbica+"')";

            dsSpx1.sucursalCliente.Merge(
                 sql.ejecutarConsulta(sqlD).Tables[0]
                );

            if (!dsSpx1.sucursalCliente[0].IscodPaisNull() && !dsSpx1.sucursalCliente[0].IscodDepartamentoNull()
                && !dsSpx1.sucursalCliente[0].IscodCiudadNull())
            {
                sqlD = "SELECT        nombrePais FROM            paises WHERE        (codPais = '"+ dsSpx1.sucursalCliente[0].codPais + "') ";
                txtUbicacionGeografica.Text = "(" + sql._ejecutarProcedimiento(sqlD,true).ToString();

                sqlD = "SELECT        NombreDepartamento FROM            departamentos WHERE        (codPais = '" + dsSpx1.sucursalCliente[0].codPais + "') AND (codDepartamento = '"+ dsSpx1.sucursalCliente[0].codDepartamento + "') ";
                txtUbicacionGeografica.Text += ") " + sql._ejecutarProcedimiento(sqlD, true).ToString(); 

                sqlD = "SELECT        nombreCiudad FROM            ciudades WHERE        (codPais = '"+ dsSpx1.sucursalCliente[0].codPais + "') AND (codDepartamento = '"+ dsSpx1.sucursalCliente[0].codDepartamento + "') AND (codCiudad = '"+ dsSpx1.sucursalCliente[0].codCiudad + "') ";
                txtUbicacionGeografica.Text += ", " + sql._ejecutarProcedimiento(sqlD, true).ToString();
            }
            txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
            string codSucursal = dsSpx1.sucursalCliente[0].codSucursal;
            txtTelefonoSucursal.Text = (dsSpx1.sucursalCliente[0].IsTelefono1Null()) ? "" : dsSpx1.sucursalCliente[0].Telefono1;
            if (!dsSpx1.sucursalCliente[0].IsTelefono2Null() && dsSpx1.sucursalCliente[0].Telefono2.Trim() != string.Empty)
                txtTelefonoSucursal.Text = txtTelefonoSucursal.Text + " - " + dsSpx1.sucursalCliente[0].Telefono2;

            txtDireccion.Text = (dsSpx1.sucursalCliente[0].IsDireccionNull()) ? "" : dsSpx1.sucursalCliente[0].Direccion;

            #region informacion del contacto general
            txtContactoGeneral.Text = (dsSpx1.clientes[0].IsnombreContactoPrincipalNull()) ? "" : dsSpx1.clientes[0].nombreContactoPrincipal;
            txtemailGeneeral.Text = (dsSpx1.clientes[0].IsemailNull()) ? "" : dsSpx1.clientes[0].email;
            txtCelularGeneral.Text = (dsSpx1.clientes[0].IscelularNull()) ? "" : dsSpx1.clientes[0].celular;
            #endregion
            if (!dsSpx1.sucursalCliente[0].IscodContactoNull())
            {
                dsSpx1.contactosClientes.Clear();
                sqlD = "SELECT        nitCliente, codContacto, nombreContacto, apellidosContacto, docContacto, codTipoDoc, tituloContacto, telefono1, telefono2, celular, email, paginaWeb, cumpleanos, \r\n                         fax, es_activo, cargo\r\n\r\n FROM contactosClientes "+
                    " WHERE (nitCliente = '"+ txtNitCliente.Text + "') AND (codContacto = "+ dsSpx1.sucursalCliente[0].codContacto + ")";
                dsSpx1.contactosClientes.Merge(
              sql.ejecutarConsulta(sqlD).Tables[0]
             );
                if (dsSpx1.contactosClientes.Count > 0)
                {
                    txtContactoGeneral.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim() + " " + dsSpx1.contactosClientes[0].apellidosContacto.Trim();
                    txtEmail.Text = (dsSpx1.contactosClientes[0].IsemailNull()) ? "" : dsSpx1.contactosClientes[0].email.Trim();
                    txtCelular.Text = (dsSpx1.contactosClientes[0].IscelularNull()) ? "" : dsSpx1.contactosClientes[0].celular.Trim();
                    txtTelefono.Text = dsSpx1.contactosClientes[0].telefono1.Trim();
                    if (!dsSpx1.contactosClientes[0].Istelefono2Null() && dsSpx1.contactosClientes[0].telefono2.Trim() != string.Empty)
                        txtTelefono.Text = txtTelefono.Text + "-" + dsSpx1.contactosClientes[0].telefono2.Trim();
                }
            }



            if (!dsSpx1.equipos[0].IsfechaLlegadaNull()) { txtFechaPrimerIngreso.Text = dsSpx1.equipos[0].fechaLlegada.ToLongDateString(); }
            if (!dsSpx1.equipos[0].IsfechaSalidaNull()) { txtFechaUltimoEnvioCliente.Text = dsSpx1.equipos[0].fechaSalida.ToLongDateString(); }
            //vemos las dos ulitmas ordenes de servicio
            sqlD = "SELECT anuladaPor, aprobadaPor, asignadoA, cerradaPor, codAsesor, codEstadoOrdenServicio, codModalidad, codOrdenServicio, codOtroSi, codPrioridadOS, codSucursal, codTiposervicio, consecutivoContrato, creadaPor, diagnostico, equipo_adecuado, esInterno, fallasReportadas, fechaAnulacion, fechaAprobacion, fechaCierre, fechaCreacion, fechaFinProgramacion, fechaProgramacion, fechaUltimoMantenimientoxUsuario, horaEntradaControl, horaSalidaControl, mantenimientoSegunIndicaciones, nitCliente, nombreUsuarioCliente, numEntrada, numeroContrato, observaciones, observacionesIngeniero, porContrato, serial FROM ordenServicio"+
                " WHERE (codEstadoOrdenServicio = 'APROB') AND (serial = '"+txtSerial.Text+"') ORDER BY fechaAprobacion DESC";
            dsSpx1.ordenServicio.Merge(
          sql.ejecutarConsulta(sqlD).Tables[0]
         );
           
            if (dsSpx1.ordenServicio.Rows.Count > 0)
            {
                txtObservacionesUltimoMantenimiento.Text = dsSpx1.ordenServicio[0].observacionesIngeniero;
            }
            #endregion

            sqlD = "SELECT serialEquipo, serialAuxiliar, Observaciones FROM dbo.equipoAuxiliar "+
                " where \r\nserialAuxiliar = '"+txtSerial.Text+"'";
            dsSpx1.equipoAuxiliar.Merge(
          sql.ejecutarConsulta(sqlD).Tables[0]
         );

            if (dsSpx1.equipoAuxiliar.Rows.Count > 0)
            {
                txtSerialAuxiliarde.Text = dsSpx1.equipoAuxiliar[0].serialEquipo;
            }
            else
            {
                txtSerialAuxiliarde.Text = "Ninguno";
            }
            return true;
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void hojaHijo(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmHojaVida.aspx?sx=" + ((ImageButton)sender).ValidationGroup);
        }

        public void verOrdenServicio(object sender, ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;
            Response.Redirect("../ordenservicio/frmEjecutarOrden.aspx?osx="+orden);

        }

        public void ImprimirOrdenServicio(object sender, ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;
            string ruta = Server.MapPath("../rpt/");
            ruta = ruta + "rpt.xml";
            C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
            rpt.Load(ruta, "rptReporteServicio");
            Session["rutaReporte"] = ruta;
            Session["nombreReporte"] = "rptReporteServicio";
            rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codOrdenServicio>>", orden);
            //modificamos todos los subreportes

            for (int k = 0; k < rpt.Fields.Count; k++)
            {
                if (rpt.Fields[k].Subreport != null)
                {
                    rpt.Fields[k].Subreport.DataSource.RecordSource = rpt.Fields[k].Subreport.DataSource.RecordSource.Replace("<<codOrdenServicio>>", orden);
                }
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
                Session.Add("tituloReporte", "Orden de Servicio");
            }
            else
            {
                Session["tituloReporte"] = "Orden de Servicio";
            }
            //    Session["showPdf"]
            Response.Redirect("../impresion/frmImprimir.aspx");
        }

        public void verArchivo(object sender, ImageClickEventArgs e)
        {
            string a = ((ImageButton)sender).ValidationGroup;
            string[] arreglo = a.Split('|');

            SPControladoraDatos.dsSpxTableAdapters.archivosXequipoTableAdapter archivosXequipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.archivosXequipoTableAdapter();
            byte[] arr = (byte[])archivosXequipoTableAdapter1.verArchivo(txtSerial.Text, int.Parse(arreglo[0]));
            System.IO.MemoryStream ms = new System.IO.MemoryStream(arr);
            string ruta = Server.MapPath("../../Temp/");

            System.IO.File.WriteAllBytes(ruta + "" + Session["ss_login"].ToString().Trim() + "_" + arreglo[1].Trim(), arr);
            Response.Redirect("../../temp/" + Session["ss_login"].ToString().Trim() + "_" + arreglo[1].Trim());
        }



        protected void btnVerHojaVidaPadre_Click(object sender, EventArgs e)
        {
            if (txtSerialAuxiliarde.Text.Trim() != "Ninguno")
                Response.Redirect("frmHojaVida.aspx?sx=" + txtSerialAuxiliarde.Text);
        }


        protected void btnVerLLamadaCientifica_Click(object sender, ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;
            string ruta = Server.MapPath("../rpt/");
            ruta = ruta + "rpt.xml";
            C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
            rpt.Load(ruta, "rptCientifica");
            Session["rutaReporte"] = ruta;
            Session["nombreReporte"] = "rptCientifica";
            rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<cod_asesoria>>", orden);
            //modificamos todos los subreportes

            for (int k = 0; k < rpt.Fields.Count; k++)
            {
                if (rpt.Fields[k].Subreport != null)
                {
                    rpt.Fields[k].Subreport.DataSource.RecordSource = rpt.Fields[k].Subreport.DataSource.RecordSource.Replace("<<cod_asesoria>>", orden);
                }
            }

            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter tb = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.parametro_cientificaTableAdapter pr = new SPControladoraDatos.dsSpxTableAdapters.parametro_cientificaTableAdapter();
            pr.Fill(dsSpx1.parametro_cientifica);
            tb.Fill(dsSpx1.defaults);
            if (rpt.Fields.Contains("lblCodigoDocumento"))
            {
                rpt.Fields["lblCodigoDocumento"].Value = dsSpx1.parametro_cientifica[0].codigo_documento_llamada.Trim();
            }
            if (rpt.Fields.Contains("lblImplementacionDocumento"))
            {
                rpt.Fields["lblImplementacionDocumento"].Value = dsSpx1.parametro_cientifica[0].implementacion_documento_llamada.Trim();
            }
            if (rpt.Fields.Contains("lblTipoDocumentoLlamada"))
            {
                rpt.Fields["lblTipoDocumentoLlamada"].Value = dsSpx1.parametro_cientifica[0].tipo_documento_llamada.Trim();
            }
            if (rpt.Fields.Contains("lblVersionFormatoLlamada"))
            {
                rpt.Fields["lblVersionFormatoLlamada"].Value = dsSpx1.parametro_cientifica[0].version_formato_llamada.Trim();
            }

            if (rpt.Fields.Contains("rptAcciones"))
            {

                // rpt.Fields["rptAcciones"].Subreport.DataSource.ConnectionString = objData.CadenaConexionrpts;
                rpt.Fields["rptAcciones"].Subreport.DataSource.RecordSource = rpt.Fields["rptAcciones"].Subreport.DataSource.RecordSource.Replace("<<cod_asesoria>>", orden.ToString());
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
                Session.Add("tituloReporte", "Llamada de Cientifica");
            }
            else
            {
                Session["tituloReporte"] = "Llamada de Cientifica";
            }
            //    Session["showPdf"]
            Response.Redirect("../impresion/frmImprimir.aspx");
        }
        protected void btnVerLLamadaIngenieria_Click(object sender, ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;
            string ruta = Server.MapPath("../rpt/");
            ruta = ruta + "rpt.xml";
            C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
            rpt.Load(ruta, "rptLlamadaSeguimientoCompleta");
            Session["rutaReporte"] = ruta;
            Session["nombreReporte"] = "rptLlamadaSeguimientoCompleta";
            rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codLLamada>>", orden);
            //modificamos todos los subreportes

            for (int k = 0; k < rpt.Fields.Count; k++)
            {
                if (rpt.Fields[k].Subreport != null)
                {
                    rpt.Fields[k].Subreport.DataSource.RecordSource = rpt.Fields[k].Subreport.DataSource.RecordSource.Replace("<<codLLamada>>", orden);
                }
            }

            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter tb = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            tb.Fill(dsSpx1.defaults);
            if (rpt.Fields.Contains("lblTitulo"))
            {
                rpt.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloLlamadas.Trim();
            }
            if (rpt.Fields.Contains("lblVersion"))
            {
                rpt.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionLlamadas.Trim();
            }
            if (rpt.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoLLamadasNull())
                    rpt.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoLLamadas.Trim();
            }
            if (rpt.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaLlamadasNull())
                    rpt.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaLlamadas.ToShortDateString();
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
                Session.Add("tituloReporte", "Llamada de Ingenieria");
            }
            else
            {
                Session["tituloReporte"] = "Llamada de Ingenieria";
            }
            //    Session["showPdf"]
            Response.Redirect("../impresion/frmImprimir.aspx");
        }


        protected void btnVerLLamadaCientifica_Click1(object sender, ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;

            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            dsSpx1.EnforceConstraints = false;
            objDef.Fill(dsSpx1.defaults);

            string ruta = Server.MapPath("../rpt/");
            ruta = ruta + "rpt2.xml";
            C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
            rpt.Load(ruta, "rptActividadCientifica");
            Session["rutaReporte"] = ruta;
            Session["nombreReporte"] = "rptActividadCientifica";
            if (rpt.Fields.Contains("lblTitulo"))
            {
                rpt.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloReporteServicio.Trim();
            }
            if (rpt.Fields.Contains("lblVersion"))
            {
                rpt.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionReporteServicio.Trim();
            }
            if (rpt.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoReporteServicioNull())
                    rpt.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoReporteServicio.Trim();
            }
            if (rpt.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaReporteServicioNull())
                    rpt.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaReporteServicio.ToShortDateString();
            }

            rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codActividad>>", orden);

            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            rpt.DataSource.ConnectionString = obj.CadenaConexionReportes;
            if (rpt.Fields.Contains("subRptReactivos"))
            {
                rpt.Fields["subRptReactivos"].Subreport.DataSource.ConnectionString = obj.CadenaConexionReportes;
                rpt.Fields["subRptReactivos"].Subreport.DataSource.RecordSource = rpt.Fields["subRptReactivos"].Subreport.DataSource.RecordSource.Replace("<<codActividad>>", orden);
            }

            if (rpt.Fields.Contains("subrptPendientes"))
            {
                rpt.Fields["subrptPendientes"].Subreport.DataSource.ConnectionString = obj.CadenaConexionReportes;
                rpt.Fields["subrptPendientes"].Subreport.DataSource.RecordSource = rpt.Fields["subrptPendientes"].Subreport.DataSource.RecordSource.Replace("<<codActividad>>", orden);
            }


            #region remplazamos la imagen de la firma
            //SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter objCom = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();

            //objCom.FillByInfAdi(dsSpx1.comprobantesAceptacionOrdenservicio, int.Parse(Request.Params["os"].Trim()));
            ////cargamos la imagen
            //if (dsSpx1.comprobantesAceptacionOrdenservicio.Count > 0)
            //{
            //    System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream(dsSpx1.comprobantesAceptacionOrdenservicio[0].datos));
            //    System.Drawing.Bitmap b = new System.Drawing.Bitmap(im, 250, 125);


            //    ruta = Server.MapPath("../../Temp/");
            //    string rutaImagen = "" + ruta + "/imgOs" + DateTime.Now.Year + "m"
            //        + DateTime.Now.Month.ToString().PadLeft(2, '0') +
            //        "d" + DateTime.Now.Day.ToString().PadLeft(2, '0') + "h" + DateTime.Now.Hour +
            //        "m" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + "m" +
            //        DateTime.Now.Second.ToString().PadLeft(2, '0') +
            //        dsSpx1.comprobantesAceptacionOrdenservicio[0].codOrdenServicio + "-" + Session["ss_login"].ToString().Trim() + ".Png";

            //    b.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png);
            //    if (rpt.Fields.Contains("picLogo2"))
            //    {
            //        rpt.Fields["picLogo2"].PictureScale = C1.C1Report.PictureScaleEnum.Clip;
            //        rpt.Fields["picLogo2"].Picture = System.Drawing.Image.FromFile(rutaImagen);
            //        rpt.Fields["picLogo2"].Visible = true;
            //    }
            //}else{
            //    if (rpt.Fields.Contains("picLogo2"))
            //    {
            //        rpt.Fields["picLogo2"].Visible = false;
            //    }
            //}
            #endregion

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
                Session.Add("tituloReporte", "Reporte de Actividad");
            }
            else
            {
                Session["tituloReporte"] = "Reporte de Actividad";
            }
            //    Session["showPdf"]
            Response.Redirect("../impresion/frmImprimir.aspx");
        }
    }
}
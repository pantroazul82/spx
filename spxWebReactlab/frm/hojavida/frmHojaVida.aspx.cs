using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_hojavida_frmHojaVida : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obS = new clsSeguridad();
        obS.comprobarAcceso(Page, Session, Response, 1115);
        //verficamos seguridad
        if (!IsPostBack)
        {
            string serial=Request.Params["sx"];
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
        txtSerial.Text = serial;
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
        equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
        vistaEquipoTableAdapter1.FillBySerial(dsSpx1.vistaEquipo, serial);
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
            tipoPropiedadTableAdapter1.FillBycodTipoPropiedad(dsSpx1.tipoPropiedad, dsSpx1.equipos[0].codTipoPropiedad);
            txtTipoPropiedad.Text = dsSpx1.tipoPropiedad[0].nombreTipoPropiedad;
        }
        else { txtTipoPropiedad.Text = "No Asignado"; }

        txtFabricante.Text = dsSpx1.vistaEquipo[0].nombrefabricante;
        #region todo lo que tiene que ver con el modelo
        txtModelo.Text = dsSpx1.vistaEquipo[0].nombremodelo;
        string codModelo = dsSpx1.equipos[0].codModelo;
        string codFabricante = dsSpx1.equipos[0].codFabricante;
        modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx1.Modelos,
            dsSpx1.equipos[0].codFabricante, codModelo);
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
        if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
        {
            txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(dsSpx1.equipos[0].codModalidadEquipo).ToString();
        }
        #endregion
        //Informacion del Cliente
        clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, dsSpx1.equipos[0].nitClienteUbica);

        txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
        txtNombreCliente.Text = dsSpx1.clientes[0].nombreCliente;



        // txtTelefonoCliente.Text = (dsSpx1.clientes[0].Istelefono1Null()) ? "" : dsSpx1.clientes[0].telefono1;

        //informacion de la ubicacion
        sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, dsSpx1.clientes[0].nitCliente, dsSpx1.equipos[0].codSucursalUbica);
        if (!dsSpx1.sucursalCliente[0].IscodPaisNull() && !dsSpx1.sucursalCliente[0].IscodDepartamentoNull()
            && !dsSpx1.sucursalCliente[0].IscodCiudadNull())
        {
            txtUbicacionGeografica.Text = "(" + paisesTableAdapter1.verNombrePais(dsSpx1.sucursalCliente[0].codPais).ToString().Trim();
            txtUbicacionGeografica.Text += ") " + departamentoTableAdapter1.verNombreDepartamento(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento).ToString().Trim();
            txtUbicacionGeografica.Text += ", " + ciudadesTableAdapter1.verNombreCiudad(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento, dsSpx1.sucursalCliente[0].codCiudad).ToString().Trim();
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
            contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, txtNitCliente.Text,
                dsSpx1.sucursalCliente[0].codContacto);
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
        ordenServicioTableAdapter1.FillByDosUltimasAprobadas(dsSpx1.ordenServicio, serial);
        if (dsSpx1.ordenServicio.Rows.Count > 0)
        {
            txtObservacionesUltimoMantenimiento.Text = dsSpx1.ordenServicio[0].observacionesIngeniero;
        }
        #endregion

        equipoAuxiliarTableAdapter1.FillByserialAuxiliar(dsSpx1.equipoAuxiliar, txtSerial.Text);
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
        }else{
            Session["c1report"] = rpt;
        }
        //Session["tituloReporte"] 

        if (Session["tituloReporte"] == null)
        {
            Session.Add("tituloReporte", "Orden de Servicio");
        }else{
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
}

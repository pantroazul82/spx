using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_ordenServicio_frmFirma : System.Web.UI.Page
{
    public bool SubirFirma()
    {
        lblError.Text = "";

        //string a=ViewState["ctlSignature1"].ToString();
        if (ctlSignature1.IsValid())
        {
            string finalImg = ctlSignature1.SignatureFile;
            btnLimpiarFirma.Visible = false;
            ctlSignature1.Visible = false;
            //imgFirma.ImageUrl = "../../temp/" + System.IO.Path.GetFileName(finalImg);
            //imgFirma.Visible = true;

            SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
            obj.Deleteinfadi(int.Parse(Request.Params["osx"]));
            int id = int.Parse(obj.verNextId(int.Parse(Request.Params["osx"])).ToString());
            byte[] arrb = System.IO.File.ReadAllBytes(Server.MapPath(finalImg));
            obj.Insert(id, int.Parse(Request.Params["osx"]), "infadi", null, arrb, System.IO.Path.GetFileName("firma os " + Request.Params["osx"] + ".gif"));
            ////
            //System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream(FileUploadFirma.FileBytes));
            //string ruta = Server.MapPath("../../Temp/");
            //im.Save(ruta + "/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png", System.Drawing.Imaging.ImageFormat.Png);
            //imgFirma.ImageUrl = "../../Temp/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png";
            //imgFirma.Visible = true;

            return true;
        }
        else {
            lblError.Text = "Debe guardar la firma primero";
        }

        return false;

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
        {
            f = dsSpx1.ordenServicio[0].fechaCierre;
        }

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


    protected void Page_Load(object sender, EventArgs e)
    {
        //validamos que la orden no este cerrada
        if (Request.QueryString["osx"] == null)
        {
            
            Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + Request.QueryString["osx"]);
        }
        if (!IsPostBack)
        {
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            obj.FillByCodOrdenServicio(ds.ordenServicio, int.Parse(Request.QueryString["osx"]));
            if (ds.ordenServicio[0].codEstadoOrdenServicio.Trim().ToUpper() == "CERRA" ||
                ds.ordenServicio[0].codEstadoOrdenServicio.Trim().ToUpper() == "APROB" ||
                ds.ordenServicio[0].codEstadoOrdenServicio.Trim().ToUpper() == "ANULA")
            {
                Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + Request.QueryString["osx"]);
            }

            for (int k = 0; k < 60; k++)
            {
                cmbMinutosLlegada.Items.Add(new ListItem(k.ToString().PadLeft(2, '0'), k.ToString().PadLeft(2, '0')));
                cmbMinutosSalida.Items.Add(new ListItem(k.ToString().PadLeft(2, '0'), k.ToString().PadLeft(2, '0')));
            }

            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            string a = objD.ejecutarProcedimiento("select cast(datepart (HH,getdate()) as char(3))+'|'+cast(datepart (minute,getdate())as char(3))").ToString();
            string[] arr = a.Split('|');
            int hora = int.Parse(arr[0]);
            int minuto = int.Parse(arr[1]);

            cmbHoraSalida.SelectedValue = (hora % 12 == 0) ? "12" : (hora % 12).ToString();
            cmbMinutosSalida.SelectedValue = minuto.ToString().PadLeft(2, '0');
            cmbAmPmSalida.SelectedValue = (hora < 12) ? "AM" : "PM";
            cmbHoraSalida.Enabled = false;
            cmbMinutosSalida.Enabled = false;
            cmbAmPmSalida.Enabled = false;
            #region en caso de que ya tenga hora de salida deberia conservar la primera hora de salida
            if (!ds.ordenServicio[0].IsnombreUsuarioClienteNull())
            {
                txtUsuarioAceptacion.Text = ds.ordenServicio[0].nombreUsuarioCliente.Trim();
                //el FORMATO ES 12:54 PM
                string entrada = ds.ordenServicio[0].horaEntradaControl;
                string salida = ds.ordenServicio[0].horaSalidaControl;
                if (entrada.Trim() != string.Empty)
                {
                    cmbHoraLlegada.Text = int.Parse(entrada.Substring(0, entrada.IndexOf(":"))).ToString();
                    cmbMinutosLlegada.Text = entrada.Substring(entrada.IndexOf(":") + 1, 2);
                    cmbAmPmLlegada.Text = entrada.Substring(entrada.IndexOf(":") + 4, 2);
                    cmbHoraLlegada.Enabled = false;
                    cmbMinutosLlegada.Enabled = false;
                    cmbAmPmLlegada.Enabled = false;
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

                    cmbHoraSalida.Enabled = false;
                    cmbMinutosSalida.Enabled = false;
                    cmbAmPmSalida.Enabled = false;
                }
                else
                {
                    cmbHoraSalida.SelectedValue = "-1";
                    cmbMinutosSalida.SelectedValue = "-1";
                    cmbAmPmSalida.SelectedValue = "-1";
                }
                
            }
            #endregion
        }
    }

    protected void btnAceptarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
        lblError.Text = "";
        if (txtUsuarioAceptacion.Text.Trim() == string.Empty)
        {
            lblError.Text = "El nombre del usuario es obligatorio!";
            return;
        }
        if (!SubirFirma())
        {
            return;
        }
      
        BOLayer.OrdenServicioFactory osf = new BOLayer.OrdenServicioFactory();
        BOLayer.OrdenServicio os = osf.Get(int.Parse(Request.QueryString["osx"]));
        os.NombreUsuarioCliente = txtUsuarioAceptacion.Text;
        os.HoraEntradaControl = cmbHoraLlegada.Text + ":" + cmbMinutosLlegada.Text + " " + cmbAmPmLlegada.Text.ToUpper();
        os.HoraSalidaControl = cmbHoraSalida.Text + ":" + cmbMinutosSalida.Text + " " + cmbAmPmSalida.Text.ToUpper();
        os.CerradaPor = Session["ss_login"].ToString();
        os.FechaCierre = DateTime.Now;
        os.CodEstadoOrdenServicio = "CERRA";
        osf.Save(os);
        osf.Commit();

        cerrarOrden(Request.QueryString["osx"]);
        Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + Request.QueryString["osx"]);
    }

    protected void btnCancelarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + Request.QueryString["osx"]);
    }
}
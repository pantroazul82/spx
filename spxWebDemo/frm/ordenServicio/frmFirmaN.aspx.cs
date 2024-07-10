using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPControladoraDatos.dsSpxTableAdapters;
using System.Web.UI.HtmlControls;

public partial class frm_ordenServicio_frmFirmaN : System.Web.UI.Page
{

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
 where variables_medicionxorden_servicio.codOrdenServicio = " + Request.QueryString["osx"] + @"
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
            lblError.Text = "Las siguientes variables de medicion tiene valores fuera lo esperado " + problemas + " Variables de medicion fuera del rango.";

        }


        return false;
    }

    public bool SubirFirma()
    {
        lblError.Text = "";

        //string a=ViewState["ctlSignature1"].ToString();
        if (true /*ctlSignatureN..IsValid()*/)
        {
            string ruta= Server.MapPath("~/temp/");
            string imagen=DateTime.Now.Ticks.ToString()+Request.Params["-osx"]+".png";
            ctlSignatureN.SaveSignature(ruta + imagen);
            string finalImg = ruta + imagen;
            btnLimpiar.Visible = false;
            ctlSignatureN.Visible = false;
            
            SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.comprobantesAceptacionOrdenservicioTableAdapter();
            obj.Deleteinfadi(int.Parse(Request.Params["osx"]));
            int id = int.Parse(obj.verNextId(int.Parse(Request.Params["osx"])).ToString());
            byte[] arrb = System.IO.File.ReadAllBytes(finalImg);
            obj.Insert(id, int.Parse(Request.Params["osx"]), "infadi", null, arrb, System.IO.Path.GetFileName("firma os " + Request.Params["osx"] + ".gif"));
            ////
            //System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream(FileUploadFirma.FileBytes));
            //string ruta = Server.MapPath("../../Temp/");
            //im.Save(ruta + "/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png", System.Drawing.Imaging.ImageFormat.Png);
            //imgFirma.ImageUrl = "../../Temp/imgOs" + lblOrdenServicio.Text.Trim() + "-" + Session["ss_login"].ToString().Trim() + ".png";
            //imgFirma.Visible = true;

            return true;
        }
        else
        {
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
        lblError.Text = "";
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter solicitudServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.solicitudServicioTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        dsSpx1.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter defaultsTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter tipoEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.tipoEquipoTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter entradaSalidaEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();

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
        ////hay un nuevo requerimiento de acuerdo a la paremtrizacion de tipo de equipo y de tipo de servicio puede dar un salto mas y quedar aprobado de una vez.
        tipoServicioTableAdapter1.FillBycodTipoServicio(dsSpx1.TipoServicio, dsSpx1.ordenServicio[0].codTiposervicio.ToString());
        string codTipoEquipo = @"select top 1 Modelos.codTipoEquipo from equipos join Modelos on 
                                         Modelos.codFabricante = equipos.codFabricante and Modelos.codModelo = equipos.codModelo
                                         where serial = '" + dsSpx1.ordenServicio[0].serial + "'";
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        codTipoEquipo = bd.ejecutarProcedimiento(codTipoEquipo).ToString();
        tipoEquipoTableAdapter1.FillBycodTipoEquipo(dsSpx1.tipoEquipo, codTipoEquipo);
        if ((!dsSpx1.tipoEquipo[0].Isomite_aprobacion_osNull() && dsSpx1.tipoEquipo[0].omite_aprobacion_os) || (!dsSpx1.TipoServicio[0].Isomite_aprobacion_osNull() && dsSpx1.TipoServicio[0].omite_aprobacion_os))
        {
            ////
            ordenServicioTableAdapter1.UpdateAprobada(DateTime.Now, Session["ss_login"].ToString(), "APROB", int.Parse(codOrdenServicio));
            //cambias la fecha del ultimo mantenimiento en el equipo
            equiposTableAdapter1.UpdateUltimoMantenimiento(dsSpx1.ordenServicio[0].fechaProgramacion, dsSpx1.ordenServicio[0].codTiposervicio,
                dsSpx1.ordenServicio[0].observacionesIngeniero, dsSpx1.ordenServicio[0].serial);
        }

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ss_login"] == null) Response.Redirect("~/Default.aspx");
        this.ctlSignatureN.SignRequiredPoints = "10";
        HtmlMeta metaTag = new HtmlMeta();
        metaTag.Name = "viewport";
        metaTag.Content = "width=device-width, user-scalable=yes";

        Page.Header.Controls.Add(metaTag);

        //validamos que la orden no este cerrada
        if (Request.QueryString["osx"] == null)
        {

            Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + Request.QueryString["osx"]);
        }
        if (!IsPostBack)
        {
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
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

    protected void btnAceptarAceptacion_Click(object sender, EventArgs e)
    {
        lblError.Text = ""; 
        ctlSignatureN.SaveSignature("");
        ctlSignatureN.LoadSignature(ctlSignatureN.SignData, "1");
        if (txtUsuarioAceptacion.Text.Trim() == string.Empty)
        {
            lblError.Text = "El nombre del usuario es obligatorio!";
       
            return;
        }

        //validaciones
        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        dsSpx1.EnforceConstraints = false;
        SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter tipoServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();

        ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, int.Parse(Request.QueryString["osx"]));

        //validamos las variables de medicion

        if (dsSpx1.ordenServicio[0].Isequipo_adecuadoNull())
        {
            lblError.Text = "antes de cerrar la orden debe indicar si el equipo es indicado o no.";
            return;
        }

        if (!dsSpx1.ordenServicio[0].Isequipo_adecuadoNull() && dsSpx1.ordenServicio[0].equipo_adecuado)
        {
            if (!validarVariablesMedicion(true))
            {
                return;
            }
        }

        SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter TipoServicioTableAdapter1 = new TipoServicioTableAdapter();
        TipoServicioTableAdapter1.FillBycodTipoServicio(dsSpx1.TipoServicio, dsSpx1.ordenServicio[0].codTiposervicio);
        if (!dsSpx1.TipoServicio[0].IspreventivoNull() && dsSpx1.TipoServicio[0].preventivo)
        {
            string sql = @"select distinct variables_medicion.* from equipos 
 join variables_medicionxmodelo on variables_medicionxmodelo.codFabricante = equipos.codFabricante and variables_medicionxmodelo.codModelo = equipos.codModelo 
and variables_medicionxmodelo.obligatorio_preventivo=1
   join variables_medicion on variables_medicionxmodelo.cod_variables_medicion = variables_medicion.cod_variables_medicion
 where serial ='" + dsSpx1.ordenServicio[0].serial + @"'
 and variables_medicion.cod_variables_medicion not in(
     select sub_variable_medicion.cod_variables_medicion   from  
	   variables_medicionxorden_servicio 
	   join sub_variable_medicion on sub_variable_medicion.cod_sub_variables_medicion = variables_medicionxorden_servicio.cod_sub_variable_medicion
	   where variables_medicionxorden_servicio.codOrdenServicio = " + Request.QueryString["osx"].Trim() + "   )";
            //---
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            System.Data.DataTable tb = dc.ejecutarConsulta(sql).Tables[0];
            if (tb.Rows.Count > 0)
            {
                string variables = "";
                for (int k = 0; k < tb.Rows.Count; k++)
                {
                    variables += "\n" + tb.Rows[k]["nombre_variables_medicion"].ToString();
                }
                lblError.Text = "Los mantenimientos preventivos para este modelo debe incluir las siguientes variables de medicion que no estan incluidas:" + variables + " Variables incompletas";
                return;

            }
        }
        if (!SubirFirma())
        {
           
            return;
        }
        //continuamos despues de validar las variables de medicion

        //fin validaciones
        cerrar();
    }
    private void cerrar()
    {

        SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter orden = new ordenServicioTableAdapter();
        
        //orden.UpdateCerrada(DateTime.Now,Session["ss_login"].ToString(),"CERRA",int.Parse(Request.QueryString["osx"]));
        orden.updateAceptacion(cmbHoraLlegada.Text + ":" + cmbMinutosLlegada.Text + " " + cmbAmPmLlegada.Text.ToUpper(),
cmbHoraSalida.Text + ":" + cmbMinutosSalida.Text + " " + cmbAmPmSalida.Text.ToUpper(), txtUsuarioAceptacion.Text, int.Parse(Request.QueryString["osx"]));
        

        cerrarOrden(Request.QueryString["osx"]);
        Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + Request.QueryString["osx"]);
    }

    protected void btnCancelarAceptacion_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frm/ordenServicio/frmEjecutarOrdenSign.aspx?osx=" + Request.QueryString["osx"]);
    }
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        ctlSignatureN.InitSignature();
    }
}
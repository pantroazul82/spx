using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmAnularContrato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ss_cod_usuario"] == null)
        {
            Response.Redirect("~/default.aspx");
        }
        calFechaAnulacion.Date = DateTime.Now;
        cmbAnuladoPor.SelectedValue = Session["ss_cod_usuario"].ToString();
        SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter c = new  SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();
        if (!IsPostBack)
        {
            c.FillByCod_contratos_suministro(ds.contratos_suministro, int.Parse(Request.QueryString["cod"]));

            if (ds.contratos_suministro.Count > 0 && !ds.contratos_suministro[0].Isfecha_anulacionNull())
            {
                cmbAnuladoPor.SelectedValue = ds.contratos_suministro[0].anulada_por.ToString();
                calFechaAnulacion.Date = ds.contratos_suministro[0].fecha_anulacion;
                cmbMotivoAnulacion.SelectedValue = ds.contratos_suministro[0].cod_motivo_anulacion_suministro.ToString();
                txtObservaciones.Text = ds.contratos_suministro[0].observaciones_anulacion;

                cmbMotivoAnulacion.Enabled = false;
                txtObservaciones.ReadOnly = true;

            }
        }

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod="+Request.QueryString["cod"]);
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if(txtObservaciones.Text.Trim() == string.Empty)
        {
            lblError.Text = "Las observaciones de anulacion son obligatorias.";
            return;
        }

        SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter cs = new SPControladoraDatos.dsContratosSuministroTableAdapters.contratos_suministroTableAdapter();

        if (lblCodTipo.Text.Trim() == string.Empty)
        {
            SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
            SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter estado = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_contrato_suministroTableAdapter();
            SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter log = new SPControladoraDatos.dsContratosSuministroTableAdapters.log_cambios_estado_contratos_suministroTableAdapter();
            estado.FillByCod_manual(ds.estado_contrato_suministro, "11");
            cs.UpdateEstado(ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,
                int.Parse(Request.QueryString["cod"]));
            //insertamos en el log
            log.FillByCod_contratos_suministroUltimo(ds.log_cambios_estado_contratos_suministro,
                int.Parse(Request.QueryString["cod"]));
            cs.UpdateAnulacion(int.Parse(cmbMotivoAnulacion.SelectedValue),
                           calFechaAnulacion.Date,
                           int.Parse(cmbAnuladoPor.SelectedValue), txtObservaciones.Text,
                           int.Parse(Request.QueryString["cod"]));
            int horas = 0;//(int)DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).TotalHours,
            int Minutos = 0;//(int)DateTime.Now.Subtract(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio).Minutes
            calcularHorasHabiles(ds.log_cambios_estado_contratos_suministro[0].fecha_cambio, DateTime.Now,
                out horas, out Minutos);

            log.Insert(DateTime.Now, int.Parse(cmbAnuladoPor.SelectedValue),
                txtObservaciones.Text, ds.estado_contrato_suministro[0].cod_estado_contrato_suministro,
                int.Parse(Request.QueryString["cod"]),

                ds.log_cambios_estado_contratos_suministro[0].cod_estado_contrato_suministro,

                horas,Minutos,null);
            //enviamos el email
            clsSeguridad cls = new clsSeguridad();
            SPXdata.BD.DataConector bd=new SPXdata.BD.DataConector();
            string asunto = "Contrato de suministro Anulado";
            string numeroContrato = bd.ejecutarProcedimiento(@"
select numero_contrato from contratos_suministro 
where cod_contratos_suministro ='" + Request.QueryString["cod"] + "'").ToString();

            string cuerpo = @"Se Anulo el contrato de suministro con numero de contrato:"+numeroContrato +@"<br> 
Observaciones de anulacion:" + txtObservaciones.Text.Replace("\r\n", "<br>").Replace("\n", "<br>") + @"<br> " +
                       @"<a href='" + cls.verIpSitiio() + @"frm/csuministro/frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"] + "'  >Ver Informacion adicional del Contrato</a><br>" +
                       "";
            List<string> lista = new List<string>();
            //enviamos correos
            string sqlAutor = @"select usuario.correo from contratos_suministro 
join usuario on usuario.cod_usuario =contratos_suministro.cod_usuario_asesor
where cod_contratos_suministro ='" + Request.QueryString["cod"] + "'";
            
                //enviamos correo solo al que lo creo.
            lista = cls.verCorreos(2055);//ponemos que copie siempre al tecnico contraactual
            lista.Add(bd.ejecutarProcedimiento(sqlAutor).ToString());

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
                string msg = "";
                List<string> adjuntos = new List<string>();
                if (lista[k].Trim() != string.Empty)
                    cls.enviarEmail(asunto, cuerpo, lista[k], adjuntos, out msg);
            }


        }
        else
        {
           
        }
        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
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
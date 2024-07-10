using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using C1.Web.Wijmo.Controls.C1ReportViewer;

public partial class frm_controlcalidad_frmPrintOrden : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //validamos primero que venga el codigo de la orden
        if (Request.QueryString["cod"] == null)
        { 
            Response.Redirect("../../default.aspx"); 
        }
        if (!IsPostBack)
        {
            bool tienePermiso = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2037, int.Parse(Session["ss_cod_usuario"].ToString()), Session);

            if (!tienePermiso)
            {
                int codOrden = int.Parse(Request.QueryString["cod"]);
                string sql = "select isnull(analisis_confidencial,1) from control_calidad where cod_control_calidad =" + codOrden;
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                bool confidencial = (bd.ejecutarProcedimiento(sql).ToString().Trim() == "1");

                if (confidencial)
                {
                    imprimir(false);
                }
            }
        }

    }

    protected void linkBasica_Click(object sender, EventArgs e)
    {
        imprimir(false);
    }
    protected void linkImpresionCompleta_Click(object sender, EventArgs e)
    {
        imprimir(true);
    }

    public string procesarImageneshtml(string html)
    {
        string root = Server.MapPath(@"~");
        root= root.Substring(0,root.LastIndexOf("\\"));
        html = html.Replace("src=\"", "src=\""+root);
        return html;
    }

    private void imprimir(bool completa)
    { 
    //
        int codOrden = int.Parse(Request.QueryString["cod"]);
        string sql = @"select 
informacion_adicional_usuario.cargo 'asignado_cargo',
informacion_adicional_usuario.profesion 'asignado_profesion',
informacion_adicional_usuario.imagen_firma 'asignado_firma',
iaaprobado.cargo 'aprobado_cargo',
iaaprobado.profesion 'aprobado_profesion',
iaaprobado.imagen_firma 'aprobado_firma',
asignado_a,usuario.nombre 'asignado',aprobador.nombre 'aprobador',
reposicion_aprobada_por,
resultados_control_calidad,
conclusiones,
resultados_previos_html,
analisis_posibles_fallas,
antecedentes,
acciones_implementadas
 from control_calidad 
 left join informacion_adicional_usuario on  informacion_adicional_usuario.cod_usuario = control_calidad.asignado_a
 left join informacion_adicional_usuario  iaaprobado on  iaaprobado.cod_usuario = control_calidad.reposicion_aprobada_por
left join usuario on usuario.cod_usuario = control_calidad.asignado_a
left join usuario aprobador on aprobador .cod_usuario = control_calidad.reposicion_aprobada_por
 where cod_control_calidad=" + codOrden;
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
        //cargamos el reporte
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        objDef.Fill(dsSpx1.defaults);

        string ruta = Server.MapPath("../rpt/");
        ruta = ruta + "rpt3.xml";
        C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
        #region seleccionamos el reporte y cargamos los valores que vienen en defaults
        string nombreReporte ="";
        if (completa)
        {
            nombreReporte = "rptQCCompleto";
        }else{
            nombreReporte = "rptQCCompletoReservado";
        }
        rpt.Load(ruta, nombreReporte);
        if (rpt.Fields.Contains("lblTitulo"))
        {
            if (!dsSpx1.defaults[0].IstituloControlCalidadNull())
            rpt.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloControlCalidad.Trim();
        }
        if (rpt.Fields.Contains("lblVersion"))
        {
            if (!dsSpx1.defaults[0].IsversionControlCalidadNull())
            rpt.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionControlCalidad.Trim();
        }
        if (rpt.Fields.Contains("lblTipoDocumento"))
        {
            if (!dsSpx1.defaults[0].IscodigoReporteControlCalidadNull())
                rpt.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoReporteControlCalidad.Trim();
        }
        if (rpt.Fields.Contains("lblVigencia"))
        {
            if (!dsSpx1.defaults[0].IsfechaVigenciaControlCalidadNull())
                rpt.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaControlCalidad;
        }
#endregion
            #region sustituimos los campos html
            if (rpt.Fields.Contains("editorResultadosPrevios"))
            {
                if (tb.Rows[0]["resultados_previos_html"] != null && tb.Rows[0]["resultados_previos_html"] != System.DBNull.Value)
                    rpt.Fields["editorResultadosPrevios"].Value = procesarImageneshtml( tb.Rows[0]["resultados_previos_html"].ToString());
            }

            if (rpt.Fields.Contains("editorResultados"))
            {
                if (tb.Rows[0]["resultados_control_calidad"] != null && tb.Rows[0]["resultados_control_calidad"] != System.DBNull.Value)
                    rpt.Fields["editorResultados"].Value = procesarImageneshtml(tb.Rows[0]["resultados_control_calidad"].ToString());
            }

            if (rpt.Fields.Contains("editorAnalisisFallasDetectadas"))
            {
                if (tb.Rows[0]["analisis_posibles_fallas"] != null && tb.Rows[0]["analisis_posibles_fallas"] != System.DBNull.Value)
                    rpt.Fields["editorAnalisisFallasDetectadas"].Value = procesarImageneshtml(tb.Rows[0]["analisis_posibles_fallas"].ToString());
            }

            if (rpt.Fields.Contains("editorAntecedentes"))
            {
                if (tb.Rows[0]["antecedentes"] != null && tb.Rows[0]["antecedentes"] != System.DBNull.Value)
                    rpt.Fields["editorAntecedentes"].Value = procesarImageneshtml(tb.Rows[0]["antecedentes"].ToString());
            }
            if (rpt.Fields.Contains("editorAccionesImplementadas"))
            {
                if (tb.Rows[0]["acciones_implementadas"] != null && tb.Rows[0]["acciones_implementadas"] != System.DBNull.Value)
                    rpt.Fields["editorAccionesImplementadas"].Value = procesarImageneshtml(tb.Rows[0]["acciones_implementadas"].ToString());
            }
            if (rpt.Fields.Contains("editorConclusiones"))
            {
                if (tb.Rows[0]["conclusiones"] != null && tb.Rows[0]["conclusiones"] != System.DBNull.Value)
                    rpt.Fields["editorConclusiones"].Value = procesarImageneshtml(tb.Rows[0]["conclusiones"].ToString());
            }
            #endregion
            #region susutituimos los campos de aprobacion
            if (rpt.Fields.Contains("lblRealizo"))
            {
                if (tb.Rows[0]["asignado"] != null && tb.Rows[0]["asignado"] != System.DBNull.Value)
                    rpt.Fields["lblRealizo"].Value = tb.Rows[0]["asignado"].ToString();
            }
            if (rpt.Fields.Contains("lblCargoRealizo"))
            {
                if (tb.Rows[0]["asignado_cargo"] != null && tb.Rows[0]["asignado_cargo"] != System.DBNull.Value)
                    rpt.Fields["lblCargoRealizo"].Value = tb.Rows[0]["asignado_cargo"].ToString();
            }
            if (rpt.Fields.Contains("lblProfesionRealizo"))
            {
                if (tb.Rows[0]["asignado_profesion"] != null && tb.Rows[0]["asignado_profesion"] != System.DBNull.Value)
                    rpt.Fields["lblProfesionRealizo"].Value = tb.Rows[0]["asignado_profesion"].ToString();
            }
            if (rpt.Fields.Contains("lblRevizo"))
            {
                if (tb.Rows[0]["aprobador"] != null && tb.Rows[0]["aprobador"] != System.DBNull.Value)
                    rpt.Fields["lblRevizo"].Value = tb.Rows[0]["aprobador"].ToString();
            }
            if (rpt.Fields.Contains("lbCargoRevizo"))
            {
                if (tb.Rows[0]["aprobado_cargo"] != null && tb.Rows[0]["aprobado_cargo"] != System.DBNull.Value)
                    rpt.Fields["lbCargoRevizo"].Value = tb.Rows[0]["aprobado_cargo"].ToString();
            }
            if (rpt.Fields.Contains("lbProfesionRevizo"))
            {
                if (tb.Rows[0]["aprobado_profesion"] != null && tb.Rows[0]["aprobado_profesion"] != System.DBNull.Value)
                    rpt.Fields["lbProfesionRevizo"].Value = tb.Rows[0]["aprobado_profesion"].ToString();
            }

            if (rpt.Fields.Contains("imgReviso"))
            {
                #region remplazamos la imagen de la firma
                if (tb.Rows[0]["aprobado_firma"] != null && tb.Rows[0]["aprobado_firma"] != System.DBNull.Value)
                {
                    System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])tb.Rows[0]["aprobado_firma"]));
                    System.Drawing.Bitmap b = new System.Drawing.Bitmap(im, 250, 125);
                    string rutaImagen = Server.MapPath("../../Temp/");
                    rutaImagen = "" + rutaImagen + "/imgQC" + DateTime.Now.Year + "m"
                        + DateTime.Now.Month.ToString().PadLeft(2, '0') +
                        "d" + DateTime.Now.Day.ToString().PadLeft(2, '0') + "h" + DateTime.Now.Hour +
                        "m" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + "m" +
                        DateTime.Now.Second.ToString().PadLeft(2, '0') +
                        Request.QueryString["cod"] + "-" + Session["ss_login"].ToString().Trim() + ".Png";
                    b.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png);

                    rpt.Fields["imgReviso"].Picture = System.Drawing.Image.FromFile(rutaImagen);
                    rpt.Fields["imgReviso"].Visible = true;
                }
                #endregion
            }
            if (rpt.Fields.Contains("imgRealizo"))
            {
                #region remplazamos la imagen de la firma
                if (tb.Rows[0]["asignado_firma"] != null && tb.Rows[0]["asignado_firma"] != System.DBNull.Value)
                {
                    System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])tb.Rows[0]["asignado_firma"]));
                    System.Drawing.Bitmap b = new System.Drawing.Bitmap(im, 250, 125);
                    string rutaImagen = Server.MapPath("../../Temp/");
                    rutaImagen = "" + rutaImagen + "/imgQCasi" + DateTime.Now.Year + "m"
                        + DateTime.Now.Month.ToString().PadLeft(2, '0') +
                        "d" + DateTime.Now.Day.ToString().PadLeft(2, '0') + "h" + DateTime.Now.Hour +
                        "m" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + "m" +
                        DateTime.Now.Second.ToString().PadLeft(2, '0') +
                        Request.QueryString["cod"] + "-" + Session["ss_login"].ToString().Trim() + ".Png";
                    b.Save(rutaImagen, System.Drawing.Imaging.ImageFormat.Png);

                    rpt.Fields["imgRealizo"].Picture = System.Drawing.Image.FromFile(rutaImagen);
                    rpt.Fields["imgRealizo"].Visible = true;
                }
                #endregion
            }
            //             
            //   
            #endregion
        
        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codControl>>", Request.QueryString["cod"].Trim());
        rpt.DataSource.ConnectionString = bd.CadenaConexionReportes;
        if (rpt.Fields.Contains("rptSeguimiento"))
        {
            rpt.Fields["rptSeguimiento"].Subreport.DataSource.ConnectionString = bd.CadenaConexionReportes;
            rpt.Fields["rptSeguimiento"].Subreport.DataSource.RecordSource = rpt.Fields["rptSeguimiento"].Subreport.DataSource.RecordSource.Replace("<<codControl>>", Request.QueryString["cod"].Trim());
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
            Session.Add("tituloReporte", "Reporte Control de Calidad");
        }
        else
        {
            Session["tituloReporte"] = "Reporte de Actividad";
        }

        Session["rutaReporte"]=ruta;
        Session["nombreReporte"]=nombreReporte;
        //    Session["showPdf"]
      
        Response.Redirect("../impresion/frmImprimir.aspx");
        
    }
}
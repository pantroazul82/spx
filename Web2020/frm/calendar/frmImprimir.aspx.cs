﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.calendar
{
    public partial class frmImprimir : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["os"] == null)
            {
                Response.Redirect("../../Default.aspx");
            }
            clsSeguridad obS = new clsSeguridad();
            obS.comprobarAcceso(Page, Session, Response, 0);

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

            rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codActividad>>", Request.Params["os"].Trim());

            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            rpt.DataSource.ConnectionString = obj.CadenaConexionReportes;
            if (rpt.Fields.Contains("subRptReactivos"))
            {
                rpt.Fields["subRptReactivos"].Subreport.DataSource.ConnectionString = obj.CadenaConexionReportes;
                rpt.Fields["subRptReactivos"].Subreport.DataSource.RecordSource = rpt.Fields["subRptReactivos"].Subreport.DataSource.RecordSource.Replace("<<codActividad>>", Request.Params["os"].Trim());
            }

            if (rpt.Fields.Contains("subrptPendientes"))
            {
                rpt.Fields["subrptPendientes"].Subreport.DataSource.ConnectionString = obj.CadenaConexionReportes;
                rpt.Fields["subrptPendientes"].Subreport.DataSource.RecordSource = rpt.Fields["subrptPendientes"].Subreport.DataSource.RecordSource.Replace("<<codActividad>>", Request.Params["os"].Trim());
            }
            if (rpt.Fields.Contains("notaPie"))
            {
                if (!dsSpx1.defaults[0].IsnotaPieReportesServicoNull())
                    rpt.Fields["notaPie"].Value = dsSpx1.defaults[0].notaPieReportesServico;
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

            if (rpt.Fields.Contains("imgReviso"))
            {
                #region remplazamos la imagen de la firma
                string sql = @"select imagen_firma from informacion_adicional_usuario where cod_usuario in(
                                select cod_usuario from tarea_calendario where cod_tarea_calendario =" + Request.Params["os"] + ")";
                System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
                if (tb.Rows.Count > 0 && tb.Rows[0]["imagen_firma"] != null && tb.Rows[0]["imagen_firma"] != System.DBNull.Value)
                {
                    System.Drawing.Image im = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])tb.Rows[0]["imagen_firma"]));
                    System.Drawing.Bitmap b = new System.Drawing.Bitmap(im, 250, 125);
                    string rutaImagen = Server.MapPath("../../Temp/");
                    rutaImagen = "" + rutaImagen + "/imgTarea" + DateTime.Now.Year + "m"
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
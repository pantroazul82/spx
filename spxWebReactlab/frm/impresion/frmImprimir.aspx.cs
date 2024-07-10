using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using C1.C1Preview;
using C1.C1Report;
using C1.Web.Wijmo.Controls.C1ReportViewer;

public partial class frm_impresion_frmImprimir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            if (Session.Count <= 0)
            {
                Response.Redirect("../../frm/logica/frmLogin.aspx");
            }
            if (Session["c1report"] == null)
            {
                Response.Redirect("../../frm/logica/frmLogin.aspx", true);
            }
            //cargamos la informacion de la session
            if (Session["tituloReporte"] != null)
            {
                lblTitulo.Text = Session["tituloReporte"].ToString();
            }
            else
            {
                lblTitulo.Text = "";
            }

            string rutaReporte=Session["rutaReporte"].ToString();
            string nombreReporte=Session["nombreReporte"].ToString();
            

            /*
            //cargamos el logo
            C1WebReport1.DataBind();

            if (Session["showPdf"] != null && bool.Parse(Session["showPdf"].ToString()))
            {
                Session["showPdf"] = null;
                C1WebReport1.ShowPDF();
            }
             * */
            C1Report report = (C1.C1Report.C1Report)Session["c1report"];


            if (C1ReportViewer.IsDocumentRegistered(nombreReporte))
                C1ReportViewer.UnRegisterDocument(report.ReportName);
            // query is modified based on the country selected by the end user
            //  query = "SELECT DISTINCT [Quarterly Orders].CustomerID, [Quarterly  Orders].CompanyName,[Quarterly Orders].City, [Quarterly Orders].Country  FROM  [Quarterly Orders] WHERE [Quarterly Orders].Country = \"" + ddlCountry.SelectedItem.Text + "\";";
            // rptpath = HttpContext.Current.Server.MapPath("~/ReportLayout/QuarterlyOrdersReport.xml");
            // rptname = "Quarterly Orders Report";

            // registering the new report
            string nr = nombreReporte + "" + DateTime.Now.Ticks.ToString();
            C1ReportViewer.RegisterDocument(nr, MakeDoc);
            C1ReportViewer1.Cache.Enabled = false;
            C1ReportViewer1.Cache.ShareBetweenSessions = false;
            C1ReportViewer1.FileName = nr;
            C1ReportViewer1.ReportName = nr;
        
    }

    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        
        //MakeDoc().PrintDialog();    
    }

    protected void btnEnviarEmail_Click(object sender, EventArgs e)
    {
        C1Report report = MakeDoc() ;
        
        lblError.Text = "";
        if (txtEmail.Text.Trim() == string.Empty)
        {
            lblError.Text = "Ingrese una correo valido";
        }
        clsSeguridad obj = new clsSeguridad();
        try
        {
            string a = Server.MapPath("~") + @"\temp\" + lblTitulo.Text + "-" + Session["ss_login"].ToString() + System.IO.Path.GetRandomFileName().Replace(".", "").Replace(",", "");
            
            report.RenderToFile(a + ".pdf", C1.C1Report.FileFormatEnum.PDFProtected);
            List<string> l = new List<string>();
            l.Add(a + ".pdf");
            obj.enviarEmail(lblTitulo.Text, @"Buen dia,<br>Adjunto encontrara la información sobre el reporte solicitado.<br><br><br>Notificacion Automatica SPX",
                txtEmail.Text, l);
            txtEmail.Text = "";
            lblError.Text = "Se envio el email satisfactoriamente";
        }
        catch (Exception ex)
        {
            lblError.Text = "No Se envio el email satisfactoriamente <br>" + ex.Message;
        }
         
    }


    protected C1Report MakeDoc()
    {
        C1Report report = (C1.C1Report.C1Report)Session["c1report"];
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        
        
        string ruta = Server.MapPath("../../img/app/");

        if (System.IO.File.Exists(ruta + "logo.jpg") && report.Fields.Contains("piclogo"))
        {
            System.Drawing.Image im = System.Drawing.Image.FromFile(ruta + "logo.jpg");
            System.Drawing.Bitmap b = new System.Drawing.Bitmap(im, 110, 60);
            report.Fields["picLogo"].Picture = b;
            report.Fields["picLogo"].PictureScale = C1.C1Report.PictureScaleEnum.Scale;
        }
        
        report.DataSource.ConnectionString = obj.CadenaConexionReportes;

        for (int k = 0; k < report.Fields.Count; k++)
        {
            if (report.Fields[k].Subreport != null)
            {
                report.Fields[k].Subreport.DataSource.ConnectionString = obj.CadenaConexionReportes;
            }
        }


        //report.DataSource.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + ";Persist Security Info=False";
        //report.DataSource.RecordSource = query;
        report.Render();
        return report;
    }

}
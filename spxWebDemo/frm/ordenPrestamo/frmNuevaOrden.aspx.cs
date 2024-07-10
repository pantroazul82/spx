using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_ordenPrestamo_frmNuevaOrden : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Session.Count<= 0)
            {
                Response.Redirect("../logica/frmInicio.aspx",true);
                return;
            }
            SPXSeguridad.data.cls.clsTusuario obj = new SPXSeguridad.data.cls.clsTusuario();
            SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
            ds.EnforceConstraints = false;
            obj.FillByPermiso(ds.usuario, 1079);
           
            cmbIngenieroResponsable.DataSource = ds.usuario;
            cmbIngenieroResponsable.DataValueField = "login";
            cmbIngenieroResponsable.DataTextField = "nombre";
            cmbIngenieroResponsable.DataBind();
            cmbIngenieroResponsable.SelectedValue = Session["ss_login"].ToString().Trim();
            lblFechaCreacion.Text = DateTime.Now.ToShortDateString();
            string msg="";
            //si no tiene el permis--o de asignarsela a otros se bloquea el combo
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(1080, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
            {
                cmbIngenieroResponsable.Enabled = false;
            }
        }
    }
    protected void btnCancelar_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("frmListadoOrdenesPrestamo.aspx");
    }
    protected void linkCrearOtra_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNuevaOrden.aspx");
    }
    protected void linkImprimir_Click(object sender, EventArgs e)
    {
        //cargamos los defaults     
        SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter objOP = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
        SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
        dsSpx1.EnforceConstraints = false;
        objDef.Fill(dsSpx1.defaults);
        objOP.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, int.Parse(lblCodOrden.Text));
          

        string ruta = Server.MapPath("../rpt/");
        ruta = ruta + "/rpt.xml";
        C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
        rpt.Load(ruta, "rptOrdenPrestamo");

        Session["rutaReporte"] = ruta;
        Session["nombreReporte"] = "rptOrdenPrestamo";
        rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codigo>>", lblCodOrden.Text);
        #region aplicamos los defaults
        if (!dsSpx1.defaults[0].IslogotipoNull())
        {
            byte[] arr = (byte[])dsSpx1.defaults[0].logotipo;
            System.IO.Stream stream = new System.IO.MemoryStream(arr);
            System.Drawing.Image im = System.Drawing.Image.FromStream(stream);
            if (rpt.Fields.Contains("picLogo"))
            {
                rpt.Fields["picLogo"].Picture = im;
            }
        }
        if (rpt.Fields.Contains("lblTitulo"))
        {
            rpt.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloOrdenPrestamo.Trim();
        }
        if (rpt.Fields.Contains("lblVersion"))
        {
            rpt.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionOrdenPrestamo.Trim();
        }
        if (rpt.Fields.Contains("lblTipoDocumento"))
        {
            if (!dsSpx1.defaults[0].IscodigoOrdenPrestamoNull())
                rpt.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoOrdenPrestamo.Trim();
        }
        if (rpt.Fields.Contains("lblVigencia"))
        {
            if (!dsSpx1.defaults[0].IsfechaVigenciaOrdenPrestamoNull())
                rpt.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaOrdenPrestamo.ToShortDateString();
        }
#endregion
        SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
        if (rpt.Fields.Contains("subRptObs"))
        {
            rpt.Fields["subRptObs"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
        }
        if (!dsSpx1.OrdenPrestamo[0].IsanuladaNull() && dsSpx1.OrdenPrestamo[0].anulada)
        {
            if (rpt.Fields.Contains("lblAnulo"))
            {
                rpt.Fields["lblAnulo"].Visible = true;
            }
            if (rpt.Fields.Contains("lblNombreAnulo"))
            {
                rpt.Fields["lblNombreAnulo"].Visible = true;
            }
            if (rpt.Fields.Contains("lblAnulada"))
            {
                rpt.Fields["lblAnulada"].Visible = true;
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
            Session.Add("tituloReporte", "Orden de Prestamo");
        }
        else
        {
            Session["tituloReporte"] = "Orden de Prestamo";
        }


        //    Session["showPdf"]
        Response.Redirect("../impresion/frmImprimir.aspx");
    }
    protected void btnAceptar_Click(object sender, ImageClickEventArgs e)
    {
        lblErrror.Text = "";
        //validamos
        if (cmbCiudad.SelectedValue == null || cmbCiudad.SelectedValue.Trim() == string.Empty)
        {
            lblErrror.Text = "Seleccione la Ciudad";
            return;
        }
        if (cmbIngenieroResponsable.SelectedValue == null || cmbIngenieroResponsable.SelectedValue.Trim() == string.Empty)
        {
            lblErrror.Text = "Seleccione un responsable";
            return;
        }
        List<string> lista = controlRepuestos1.verText();
        List<string> listaCodigos = controlRepuestos1.verCodigos();
        if(lista.Count<=0)
        {
            lblErrror.Text = "Seleccione un o mas repuestos";
            return;
        }
        //creamos
        SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter op = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter rop = new SPControladoraDatos.dsSpxTableAdapters.repuestosxOrdenPrestamoTableAdapter();
        int id=op.verNextId().Value;
        op.Insert(id, cmbIngenieroResponsable.SelectedValue.ToString(), Session["ss_login"].ToString(),
            null, null, null, null, DateTime.Now, null, cmbPais.SelectedValue, cmbDepartamento.SelectedValue,
            cmbCiudad.SelectedValue, null, false, txtObsIniciales.Text, "", "", "",1,"","",
            (controlSerial1.verCodigos().Count>0)?controlSerial1.verCodigos()[0]:null,txtObservacionesSerial.Text);
        lblCiudad.Text = cmbCiudad.Text.Trim() + "("+cmbDepartamento.Text.Trim()+")";
        lblCodOrden.Text = id.ToString();
        lblCreadaPor.Text = Session["ss_login"].ToString();
        lblFechaCreacion2.Text = DateTime.Now.ToShortDateString();
        lblIngernieroResponsable.Text = cmbIngenieroResponsable.Text;
        lblObservaciones.Text = txtObsIniciales.Text;
        
        for (int k = 0; k < lista.Count;k++ )
        {
            int cantidad =int.Parse( lista[k].Substring(lista[k].LastIndexOf('(') + 1, lista[k].Length - lista[k].LastIndexOf(')') + 1).Replace(")",""));
            rop.Insert(id, listaCodigos[k], false, false, false, "", null, null, null, cantidad, 0, 0, 0);
            lblRepuestos.Text += lista[k] + ",";
        }

        pnlInicio.Visible = false;
        pnlResumen.Visible = true;

    }
}

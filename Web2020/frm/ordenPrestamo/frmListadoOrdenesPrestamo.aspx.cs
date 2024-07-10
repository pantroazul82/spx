using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOLayer;

namespace Web2020.frm.ordenPrestamo
{
    public partial class frmListadoOrdenesPrestamo : System.Web.UI.Page
    {


        #region --- Class Fields / Objects  ---

        private BOLayer.OrdenPrestamoFactory _ordenPrestamoFactory = new BOLayer.OrdenPrestamoFactory(SessionScope.FactoryScope);
        private BOLayer.OrdenPrestamo _ordenPrestamoBrowse1;

        #endregion





        #region --- Class Methods --- 

        protected void Page_Load(object pSender, EventArgs pEventArgs)
        {

            if (Session["ss_cod_usuario"] == null) Response.Redirect("~");
            if (!IsPostBack)
            {
                clsSeguridad obS = new clsSeguridad();
                obS.comprobarAcceso(Page, Session, Response, 1083);
            }
            else
            {
                buscar();
            }



            // Generate Event Handlers
        }


        private void buscar()
        {

            string sql = @"SELECT " + (chkTop.Checked ? (" top " + cmbtop.SelectedValue + " ") : "")
                + @"codOrdenServicio, estadosOrdenPrestamo.nombreEstadoOP, OrdenPrestamo.codOrdenPrestamo, OrdenPrestamo.loginResponsable,
OrdenPrestamo.CodEstadoOrdenPrestamo,OrdenPrestamo.loginSolicito, OrdenPrestamo.fechaOrden,
serial  FROM OrdenPrestamo INNER JOIN estadosOrdenPrestamo ON OrdenPrestamo.codEstadoOrdenPrestamo = estadosOrdenPrestamo.codEstadoOrdenPrestamo
  ";
            string filtro = "";
            if (chkAnuladas.Checked)
            {
                filtro = "OrdenPrestamo.CodEstadoOrdenPrestamo !=8";
            }
            if (txtFiltro.Text.Trim() != string.Empty)
            {
                if (filtro != string.Empty)
                    filtro = filtro + " and ";
                if (cmbFiltros.SelectedValue.Trim() == "1")
                {
                    int a = 0;
                    int.TryParse(txtFiltro.Text, out a);
                    filtro = filtro + " OrdenPrestamo.CodOrdenPrestamo =" + a;
                }
                else if (cmbFiltros.SelectedValue.Trim() == "2")
                {

                    filtro = filtro + " OrdenPrestamo.loginResponsable ='" + txtFiltro.Text + "'";
                }
                else if (cmbFiltros.SelectedValue.Trim() == "3")
                {
                    filtro = filtro + " estadosOrdenPrestamo.NombreEstadoOP like '" + txtFiltro.Text + "%'";

                }
            }
            if (filtro != string.Empty)
            {
                sql = sql + " where " + filtro + " order by OrdenPrestamo.CodOrdenPrestamo desc";
            }
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource = bd.ejecutarConsulta(sql).Tables[0];
            grdDatos.DataBind();
        }



        public string verREpuestos(object ordenPrestamo)
        {
            string respuesta = "";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            string sql = @"select repuestos.descripcion from repuestosxOrdenPrestamo 
join repuestos on repuestos.codRepuesto = repuestosxOrdenPrestamo.codRepuesto
where codOrdenPrestamo=" + ordenPrestamo;
            System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                respuesta = respuesta + tb.Rows[k][0].ToString();
            }

            return respuesta;
        }




        #endregion


        protected void solicitar_click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("frmNuevaOrden.aspx");
        }

        protected void linkImprimir_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int orden = int.Parse(((ImageButton)sender).ValidationGroup);
            //cargamos los defaults     
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter objOP = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();

            objDef.Fill(dsSpx1.defaults);
            dsSpx1.EnforceConstraints = false;
            objOP.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, orden);


            string ruta = Server.MapPath("../rpt/");
            ruta = ruta + "/rpt.xml";
            C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
            rpt.Load(ruta, "rptOrdenPrestamo");
            Session["rutaReporte"] = ruta;
            Session["nombreReporte"] = "rptOrdenPrestamo";

            rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codigo>>", orden.ToString());
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



        public bool verVisibleAnular(object CodEstadoOrdenPrestamo)
        {
            if (CodEstadoOrdenPrestamo.ToString() == "8")
                return false;
            string msg = "";
            return SPXSeguridad.verificadorPermisos.ejecutarAccion(1010
        , int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        }

        public bool verVisibleAutorizar(object CodEstadoOrdenPrestamo)
        {
            if (CodEstadoOrdenPrestamo.ToString() != "1")
                return false;
            string msg = "";
            return SPXSeguridad.verificadorPermisos.ejecutarAccion(1017
                , int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        }



        public bool verVisibleRecibir(object CodEstadoOrdenPrestamo)
        {
            if (CodEstadoOrdenPrestamo.ToString() != "2")
                return false;

            string msg = "";
            return SPXSeguridad.verificadorPermisos.ejecutarAccion(1002
        , int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        }
        public bool verVisibleREcibirAlmacen(object CodEstadoOrdenPrestamo)
        {
            if (CodEstadoOrdenPrestamo.ToString() != "5")
                return false;

            string msg = "";
            return SPXSeguridad.verificadorPermisos.ejecutarAccion(1104
        , int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
        }

        protected void linkAnular_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int orden = int.Parse(((ImageButton)sender).ValidationGroup);

            BOLayer.OrdenPrestamoFactory f = new OrdenPrestamoFactory();
            BOLayer.OrdenPrestamo op = f.Get(orden);
            op.CodEstadoOrdenPrestamo = 8;
            op.Anulada = true;
            op.LoginAnulo = Session["ss_login"].ToString();
            f.Save(op);
            f.Commit();
        }

        protected void linkRechazar_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int orden = int.Parse(((ImageButton)sender).ValidationGroup);
            Session["op"] = orden;
            Response.Redirect("frmRechazarOp.aspx");
        }

        protected void linkAprobar_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int orden = int.Parse(((ImageButton)sender).ValidationGroup);
            Session["op"] = orden;
            Response.Redirect("frmAprobarOrdenPrestamo.aspx");
        }

        protected void linkRecibir_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int orden = int.Parse(((ImageButton)sender).ValidationGroup);
            Session["op"] = orden;
            Response.Redirect("frmRecibirRepuestos.aspx");
        }

        protected void linkDevolver_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            int orden = int.Parse(((ImageButton)sender).ValidationGroup);
            Session["op"] = orden;
            Response.Redirect("frmEntregarRepuestos.aspx");
        }

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ASPxGridViewExporter1.WriteXlsxToResponse("orden prestamo");
        }
        protected void btnBuscar_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {

        }
        protected void btnHojaVida_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string serial = ((ImageButton)sender).ValidationGroup;
            Response.Redirect("~/frm/hojavida/frmHojaVida.aspx?sx=" + serial);
        }
    }
}
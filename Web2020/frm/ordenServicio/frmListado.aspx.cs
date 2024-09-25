using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate.Criterion;
using NHibernate;
using BOLayer;

namespace Web2020.frm.ordenServicio
{
    public partial class frmListado : System.Web.UI.Page
    {



        #region --- Class Methods ---

        private void generarQuery()
        {
            string sql = @"SELECT 
                        ordenServicio.codOrdenServicio, 
                        ordenServicio.fechaProgramacion, 
                        ordenServicio.asignadoA, 
                        ordenServicio.serial, 
                        estadosOrdenServicio.nombreEstado, 
                        TipoServicio.nombretipoServicio, 
                        Modelos.NombreModelo, 
                        clientes.nitCliente, 
                        clientes.nombreCliente, 
                        sucursalCliente.nombreSucursal, 
                        ModalidadEquipo.nombreModalidadEquipo, 
                        fabricante.nombre_fabricante,
                        estadosOrdenServicio.codEstadoOrdenServicio 
                    FROM 
                        ordenServicio 
                    INNER JOIN 
                        estadosOrdenServicio ON ordenServicio.codEstadoOrdenServicio = estadosOrdenServicio.codEstadoOrdenServicio 
                    INNER JOIN 
                        equipos ON ordenServicio.serial = equipos.serial 
                    INNER JOIN 
                        Modelos ON equipos.codFabricante = Modelos.codFabricante AND equipos.codModelo = Modelos.codModelo 
                    INNER JOIN 
                        clientes ON ordenServicio.nitCliente = clientes.nitCliente 
                    INNER JOIN 
                        sucursalCliente ON ordenServicio.nitCliente = sucursalCliente.nitCliente AND ordenServicio.codSucursal = sucursalCliente.codSucursal 
                    LEFT JOIN 
                        ModalidadEquipo ON ordenServicio.codModalidad = ModalidadEquipo.codModalidadEquipo 
                    INNER JOIN 
                        TipoServicio ON ordenServicio.codTiposervicio = TipoServicio.codTipoServicio 
                    INNER JOIN 
                        fabricante ON equipos.codFabricante = fabricante.codFabricante";

            string filtros = "";
            if (txtFiltro.Text.Trim() != string.Empty)
            {
                switch (cmbFiltros.SelectedValue.Trim())
                {
                    case "1":
                        filtros = " ordenServicio.serial LIKE '" + txtFiltro.Text + "%'";
                        break;
                    case "2":
                        filtros = " clientes.nitCliente LIKE '" + txtFiltro.Text + "%'";
                        break;
                    case "3":
                        filtros = " Modelos.NombreModelo LIKE '" + txtFiltro.Text + "%'";
                        break;
                    case "4":
                        filtros = " fabricante.nombre_fabricante LIKE '" + txtFiltro.Text + "%'";
                        break;
                    case "5":
                        filtros = " ordenServicio.codOrdenServicio LIKE '" + txtFiltro.Text + "%'";
                        break;
                    case "6":
                        filtros = " ordenServicio.asignadoA LIKE '" + txtFiltro.Text + "%'";
                        break;
                }
            }
            if (!chkHistorico.Checked)
            {
                if (filtros.Trim() != string.Empty)
                {
                    filtros = filtros + " and ";
                }

                filtros = filtros + "ordenservicio.CodEstadoOrdenServicio in ('EJECU','ENESP','NUEVA','PROGR')";
            }

            //solicitaron un permiso especial para que los ingneieros vean solo las ordenes que tienen asignadas
            string msg = "";
            if (SPXSeguridad.verificadorPermisos.ejecutarAccion(2052, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
            {
                if (filtros.Trim() != string.Empty)
                {
                    filtros = filtros + " and ";
                }

                filtros = filtros + "  asignadoA = '" + Session["ss_login"] + "'";

            }

            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(1201, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
            {
                if (filtros.Trim() != string.Empty)
                {
                    filtros = filtros + " and ";
                }

                filtros = filtros + "  asignadoA = '" + Session["ss_login"] + "'";
            }

            if (filtros.Trim() != string.Empty)
            {
                filtros = " where " + filtros;
            }
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            ASPxGridView1.DataSource = bd.ejecutarConsulta(sql + filtros + " order by ordenservicio.codordenservicio desc").Tables[0];
            ASPxGridView1.DataBind();


        }

        protected void Page_Load(object pSender, EventArgs pEventArgs)
        {

            clsSeguridad obS = new clsSeguridad();
            obS.comprobarAcceso(Page, Session, Response, 1063);

            if (IsPostBack)
            {
                generarQuery();
            }
            // Generate Event Handlers
        }

        public bool validarVisibilidadEjecutar(object codigoEstado)
        {
            if (codigoEstado == null) return false;
            if (codigoEstado == null) return false;

            string s = codigoEstado.ToString().ToUpper();
            if (s == "EJECU" || s == "ENESP" || s == "NUEVA" || s == "PROGR" || s == "CERRA") return true;
            else return false;

        }

        public bool validarVisibilidadREasignar(object codigoEstado)
        {
            if (codigoEstado == null) return false;
            if (codigoEstado == null) return false;

            string s = codigoEstado.ToString().ToUpper();
            if (s == "EJECU" || s == "ENESP" || s == "NUEVA" || s == "PROGR" ) return true;
            else return false;

        }



        public void reasignarOrdenServicio(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;
            Response.Redirect("frmReasignar.aspx?osx=" + orden);
        }



        public void ejecutarOrdenServicio(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;
            Response.Redirect("frmEjecutarOrden.aspx?osx=" + orden);
        }


        public void verOrdenServicio(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string orden = ((ImageButton)sender).ValidationGroup;
            Response.Redirect("frmPrintOrden.aspx?os=" + orden);
        }


        #endregion


        protected void imgExcel_Click(object sender,EventArgs e)
        {
            ASPxGridViewExporter1.WriteXlsxToResponse();
        }
    }
}
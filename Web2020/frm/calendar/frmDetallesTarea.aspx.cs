using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.calendar
{
    public partial class frmDetallesTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSeguridad obj = new clsSeguridad();
            obj.comprobarAcceso(Page, Session, Response, 0);

            if (Request.QueryString["cod"] != null && !IsPostBack)
            {
                lblCodACtividad.Text = Request.QueryString["cod"];
                #region cargamos la informacion de la tarea selecionada
                SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter tar = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
                SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                ds.EnforceConstraints = false;
                tar.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(Request.QueryString["cod"].Replace("tarea|", "")));
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                //cargamos el estado 
                objEstado.FillByCod_estado_tarea_calendario(ds.estado_tarea_calendario, ds.tarea_calendario[0].cod_estado_tarea_calendario);
                cmbEstado.DataBind();
                cmbEstado.SelectedValue = ds.estado_tarea_calendario[0].cod_estado_tarea_calendario.ToString();
                //tiene pendientes
                if (!ds.tarea_calendario[0].Istiene_pendientesNull())
                    chkPendientes.Checked = ds.tarea_calendario[0].tiene_pendientes;

                rdInterna.Checked = ds.tarea_calendario[0].es_interna;
                rdExterna.Checked = !ds.tarea_calendario[0].es_interna;
                if (!ds.tarea_calendario[0].IsconsecutivoxtipoNull())
                {
                    lblConsecutivo.Text = "Consecutivo x Tipo: " + ds.tarea_calendario[0].consecutivoxtipo.ToString();
                }

                //fecha de ciere
                if (!ds.tarea_calendario[0].Isfecha_cierreNull())
                {
                    calCierre.SelectedDate = ds.tarea_calendario[0].fecha_cierre;
                    calCierre.Visible = true;

                }


                if (!ds.tarea_calendario[0].Iscod_tipo_tarea_calendarioNull())
                {
                    cmbtipoActividad.DataBind();
                    cmbtipoActividad.SelectedValue = ds.tarea_calendario[0].cod_tipo_tarea_calendario.ToString();
                }

                if (!ds.tarea_calendario[0].Iscod_subtipo_tarea_calendarioNull())
                {
                    cmbSubtipoActividad.DataBind();
                    cmbSubtipoActividad.SelectedValue = ds.tarea_calendario[0].cod_subtipo_tarea_calendario.ToString();
                }

                if (cmbResponsable.Visible)
                {

                    //validamos que el valor que le va asignar este en el combo si no lo agregagamos
                    bool contiene = false;
                    cmbResponsable.DataBind();
                    for (int k = 0; k < cmbResponsable.Items.Count; k++)
                    {
                        if (cmbResponsable.Items[k].Value == ds.tarea_calendario[0].cod_usuario.ToString())
                        {
                            contiene = true;
                            break;
                        }
                    }
                    if (!contiene)
                    {
                        string sql = "select nombre from usuario where cod_usuario =" + ds.tarea_calendario[0].cod_usuario.ToString();
                        SPXdata.BD.DataConector objBd = new SPXdata.BD.DataConector();

                        cmbResponsable.Items.Add(new ListItem(objBd.ejecutarProcedimiento(sql).ToString(), ds.tarea_calendario[0].cod_usuario.ToString()));
                    }

                    cmbResponsable.SelectedValue = ds.tarea_calendario[0].cod_usuario.ToString();
                }


                if (!ds.tarea_calendario[0].Isrequiere_aprobacionNull())
                {
                    chkRequiereAprobacion.Checked = ds.tarea_calendario[0].requiere_aprobacion;
                }

                //descripcion

                if (!ds.tarea_calendario[0].IsdescripcionNull())
                    txtDescripcion.Text = ds.tarea_calendario[0].descripcion;



                if (!ds.tarea_calendario[0].Isatado_clienteNull() && !ds.tarea_calendario[0].Isnit_clienteNull())
                {
                    chkAtadaCliente.Checked = ds.tarea_calendario[0].atado_cliente;
                    txtCliente.Text = ds.tarea_calendario[0].nit_cliente.Trim();
                    string sql = "select rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + txtCliente.Text + "'";

                    System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
                    txtCliente.Text = tb.Rows[0][0].ToString();
                    cargarCliente();
                    //--
                    cmbSucursal.SelectedValue = ds.tarea_calendario[0].cod_sucursal;
                    cmbContacto.SelectedValue = ds.tarea_calendario[0].cod_contacto;
                }

                if (!ds.tarea_calendario[0].IsserialNull())
                {
                    txtSerial.Text = ds.tarea_calendario[0].serial.Trim();
                    chkAtadaSerial.Checked = true;
                }

                SPControladoraDatos.dsSpxTableAdapters.modeloxtareaTableAdapter objModelos = new SPControladoraDatos.dsSpxTableAdapters.modeloxtareaTableAdapter();
                objModelos.FillByCod_tarea_calendario(ds.modeloxtarea, int.Parse(lblCodACtividad.Text));
                for (int k = 0; k < ds.modeloxtarea.Count; k++)
                {
                    chkAtadaModelo.Checked = true;
                    string sql = @"select rtrim(nombreModelo) +' ('+rtrim(nombre_Fabricante)+')'
from modelos join fabricante on fabricante.codFabricante = modelos.codFabricante
where 
fabricante.codFabricante ='" + ds.modeloxtarea[k].codFabricante.Trim() + "' and codModelo ='" + ds.modeloxtarea[k].codModelo.Trim() + "'";
                    lblModelos.Text = "<li>" + bd.ejecutarProcedimiento(sql).ToString() + "<br>" + lblModelos.Text;
                }
                SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter objReactivo = new SPControladoraDatos.dsSpxTableAdapters.reactivoxtareaTableAdapter();
                objReactivo.FillByCod_tarea_calendario(ds.reactivoxtarea, int.Parse(lblCodACtividad.Text));
                for (int k = 0; k < ds.reactivoxtarea.Count; k++)
                {
                    chkAtadaReactivo.Checked = true;
                    string sql = @"select 
'('+rtrim(nombre_Fabricante)+') ' + rtrim(nombre_referencia_reactivo)
from 
referencia_reactivo
join fabricante on fabricante.codFabricante = referencia_reactivo.codfabricante
where 
cod_referencia_reactivo='" + ds.reactivoxtarea[k].cod_referencia_reactivo.ToString() + "'";
                    lblReactivo.Text = "<li>" + bd.ejecutarProcedimiento(sql).ToString() + "<br>" + lblReactivo.Text;
                }

                if (!ds.tarea_calendario[0].IsobservacionesNull())
                    txtObservaciones.Text = ds.tarea_calendario[0].observaciones;


                if (!ds.tarea_calendario[0].IsfinNull())
                    calFin.SelectedDate = ds.tarea_calendario[0].fin;

                if (!ds.tarea_calendario[0].IsinicioNull())
                    calInicio.SelectedDate = ds.tarea_calendario[0].inicio;

                if (!ds.tarea_calendario[0].Isinicio_ejecucionNull())
                    calEjecucion.SelectedDate = ds.tarea_calendario[0].inicio_ejecucion;

                if (!ds.tarea_calendario[0].Isfin_ejecucionNull())
                    calFinEjecucion.SelectedDate = ds.tarea_calendario[0].fin_ejecucion;

                if (!ds.tarea_calendario[0].Isfecha_cierreNull())
                    calCierre.SelectedDate = ds.tarea_calendario[0].fecha_cierre;

                if (!ds.tarea_calendario[0].Isfecha_cierre_parcialNull())
                    calCierreParcial.SelectedDate = ds.tarea_calendario[0].fecha_cierre_parcial;


                if (!ds.tarea_calendario[0].IsactivaNull())
                    chkActiva.Checked = ds.tarea_calendario[0].activa;

                else if (!ds.tarea_calendario[0].aceptadaxusuario)
                {
                    lblTittuloAceptacion.Visible = true;
                }


                if (!ds.tarea_calendario[0].Isinicio_ejecucionNull())
                {
                    calFinEjecucion.Visible = true;
                    calEjecucion.Visible = true;
                    lblFechaEjecucion.Visible = true;
                    lblFechaFinEjecucion.Visible = true;
                }

                #region ajustamos visibilidad de los controles segun los check

                if (chkAtadaCliente.Checked)
                {
                    txtCliente.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                    cmbSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                    cmbContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                    lblSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                    lblContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";

                }
                else
                {
                    txtCliente.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                    cmbSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                    cmbContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                    lblSucursal.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                    lblContacto.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                }
                if (chkAtadaSerial.Checked)
                {
                    txtSerial.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                }
                else
                {
                    txtSerial.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                }
                if (chkAtadaModelo.Checked)
                {
                    lblModelos.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                }
                else
                {
                    lblModelos.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                }

                if (chkAtadaReactivo.Checked)
                {
                    lblReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                }
                else
                {
                    lblReactivo.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "hidden";
                }
                #endregion



                if (!ds.tarea_calendario[0].Isnombre_clienteNull())
                    txtContactoCierre.Text = ds.tarea_calendario[0].nombre_cliente;

                if (!ds.tarea_calendario[0].Isobervaciones_aprobacionNull())
                    txtCierreFinal.Text = ds.tarea_calendario[0].obervaciones_aprobacion;

                if (!ds.tarea_calendario[0].IspendientesNull())
                    txtObservacionesCierreParcial.Text = ds.tarea_calendario[0].pendientes;

                if (!ds.tarea_calendario[0].IsobservacionesNull())
                    txtObservaciones.Text = ds.tarea_calendario[0].observaciones;

                if (!ds.tarea_calendario[0].Israzon_solucionadoNull())
                    txtRazon.Text = ds.tarea_calendario[0].razon_solucionado;

                if (!ds.tarea_calendario[0].IssolucionadoNull())
                {
                    rdSi.Checked = ds.tarea_calendario[0].solucionado;
                    rdNo.Checked = !ds.tarea_calendario[0].solucionado;
                }

                #endregion
            }


        }


        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmImprimir.aspx?os=" + lblCodACtividad.Text);
        }

        protected void bajarArchivo(object sender, ImageClickEventArgs e)
        {
            ImageButton im = (ImageButton)sender;
            SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.archivosxtarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            obj.FillByCodarchivosxtarea_calendario(ds.archivosxtarea_calendario, int.Parse(im.ValidationGroup));
            //bajamos el archivo a una carpeta temporal
            string ruta = Server.MapPath(@"~\temp\");

            string nombreArchivo = "" + DateTime.Now.Year + "" + DateTime.Now.Month.ToString().PadLeft(2, '0') + ""
             + DateTime.Now.Day.ToString().PadLeft(2, '0') + "" + DateTime.Now.Hour.ToString().PadLeft(2, '0') + "" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ""
             + DateTime.Now.Second.ToString().PadLeft(3, '0') + "" + DateTime.Now.Millisecond.ToString().PadLeft(3, '0') + ""
             + ds.archivosxtarea_calendario[0].nombreArchivo.Trim();
            ruta = ruta + nombreArchivo;
            System.IO.File.WriteAllBytes(ruta, ds.archivosxtarea_calendario[0].archivo);
            Response.Redirect(@"~\temp\" + nombreArchivo);
        }

        public static string nit = "";
        private void cargarCliente()
        {
            nit = sacarNit(txtCliente.Text);

            string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
            if (tb.Rows.Count > 0)
            {

                sql = @"select codSucursal,nombreSucursal from sucursalCliente
				where nitCliente ='" + nit + "' ";
                cmbSucursal.DataSource = obj.ejecutarConsulta(sql).Tables[0];
                cmbSucursal.DataValueField = "codSucursal";
                cmbSucursal.DataTextField = "nombreSucursal";
                cmbSucursal.DataBind();
                //contactos
                sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
				where nitCliente ='" + nit + "' ";
                txtSerial.Text = nit;
                cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
                cmbContacto.DataValueField = "codContacto";
                cmbContacto.DataTextField = "nombre";
                cmbContacto.DataBind();
            }
            else
            {
                txtSerial.Text = "";
            }

        }

        public string sacarNit(string texto)
        {
            if (texto.LastIndexOf('(') <= 0)
                return "";
            string res = texto.Substring(texto.LastIndexOf('(') + 1);
            res = res.Substring(0, res.Length - 1);
            return res;
        }

        public string verNombreUsuario(object codUser)
        {
            if (codUser == null || codUser == System.DBNull.Value) return "";

            string sql = "select nombre from usuario where cod_usuario =" + codUser;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            return bd.ejecutarProcedimiento(sql).ToString();
        }
    }
}
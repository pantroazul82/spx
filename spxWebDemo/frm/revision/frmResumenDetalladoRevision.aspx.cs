﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmResumenDetalladoRevision : System.Web.UI.Page
{
    public string sacarNit(string texto)
    {
        if (texto.LastIndexOf('(') <= 0)
            return "";
        string res = texto.Substring(texto.LastIndexOf('(') + 1);
        res = res.Substring(0, res.Length - 1);
        return res;
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
            /*   sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
                   where nitCliente ='" + nit + "' ";
               txtSocioNegocio.Text = nit;
               cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
               cmbContacto.DataValueField = "codContacto";
               cmbContacto.DataTextField = "nombre";
               cmbContacto.DataBind();
               lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;*/
        }
    }

    private void cargarClienteFinal()
    {
        nit = sacarNit(txtclienteFinal.Text);

        string sql = "select top 1 nitCliente,numeroSocio from clientes where nitCliente ='" + nit + "'";
        SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
        System.Data.DataTable tb = obj.ejecutarConsulta(sql).Tables[0];
        if (tb.Rows.Count > 0)
        {

            sql = @"select codSucursal,nombreSucursal from sucursalCliente
				where nitCliente ='" + nit + "' ";
            cmbSucursalFinal.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbSucursalFinal.DataValueField = "codSucursal";
            cmbSucursalFinal.DataTextField = "nombreSucursal";
            cmbSucursalFinal.DataBind();
            //contactos
            /*   sql = @"select codContacto,rtrim(nombreContacto) +' '+rtrim(apellidosContacto) 'nombre' from contactosClientes
                   where nitCliente ='" + nit + "' ";
               txtSocioNegocio.Text = nit;
               cmbContacto.DataSource = obj.ejecutarConsulta(sql).Tables[0];
               cmbContacto.DataValueField = "codContacto";
               cmbContacto.DataTextField = "nombre";
               cmbContacto.DataBind();
               lnkNuevoContaco.NavigateUrl = "~/frm/parametrizacion/frmContactos.aspx?nit=" + nit;*/
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad objs = new clsSeguridad();
        objs.comprobarAcceso(Page, Session, Response, 2039);
        if (!IsPostBack)
        {
            if (Request.QueryString["cod"] != null && Request.QueryString["cod"] != string.Empty)
            {
                SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
                ds.EnforceConstraints = false;
                SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
                SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estados = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                revision.FillBycod_revision_equipos(ds.revision_equipos, int.Parse(Request.QueryString["cod"]));
                //--
                lblCodigoRevision.Text = ds.revision_equipos[0].cod_revision_equipos.ToString();
                if (!ds.revision_equipos[0].Isid_solicitudNull())
                    txtIdFo.Text = ds.revision_equipos[0].id_solicitud.ToString();

                if (!ds.revision_equipos[0].Isobservaciones_inicialesNull())
                    txtObservacionesiniciales.Text = ds.revision_equipos[0].observaciones_iniciales;
                cmbAsesorRecibe.SelectedValue = ds.revision_equipos[0].asesor_recibe.ToString();

                if (!ds.revision_equipos[0].Isresponsable_revisionNull())
                    cmbAsignadoA.SelectedValue = ds.revision_equipos[0].responsable_revision.ToString();
                cmbIngenieroRecibe.SelectedValue = ds.revision_equipos[0].ingeniero_entrega.ToString();
                if (!ds.revision_equipos[0].Iscod_origen_revision_equiposNull())
                    cmbOrigen.SelectedValue = ds.revision_equipos[0].cod_origen_revision_equipos.ToString();
                rdEquipoNuevo.Checked = ds.revision_equipos[0].equipo_nuevo;
                rdEquipoNoNuevo.Checked = !ds.revision_equipos[0].equipo_nuevo;
                lblFechaCreacion.Text = ds.revision_equipos[0].fecha_creacion.ToShortDateString() + " " + ds.revision_equipos[0].fecha_creacion.ToShortTimeString();

                if (!ds.revision_equipos[0].Isfecha_programacionNull())
                {
                    calInicio.SelectedDate = ds.revision_equipos[0].fecha_programacion;
                }
                if (!ds.revision_equipos[0].Isfecha_fin_programacionNull())
                {
                    calFin.SelectedDate = ds.revision_equipos[0].fecha_fin_programacion;
                }

                if (!ds.revision_equipos[0].Isfecha_inicio_ejecucionNull())
                {
                    calInicioEjecucion.SelectedDate = ds.revision_equipos[0].fecha_inicio_ejecucion;
                }
                if (!ds.revision_equipos[0].Isfecha_fin_ejecucionNull())
                {
                    calFinEjecucion.SelectedDate = ds.revision_equipos[0].fecha_fin_ejecucion;
                }
                string sql = "";
                if (!ds.revision_equipos[0].Isnit_clienteNull())
                {
                    sql = @"select top 1 rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + ds.revision_equipos[0].nit_cliente + "'";
                    txtCliente.Text = bd.ejecutarProcedimiento(sql).ToString();
                    txtCliente.NavigateUrl = "~/frm/herramientas/frmCliente.aspx?nit=" + ds.revision_equipos[0].nit_cliente;
                    cargarCliente();
                    cmbSucursal.SelectedValue = ds.revision_equipos[0].cod_sucursal;
                }

                if (!ds.revision_equipos[0].Isnit_cliente_nuevoNull())
                {
                    sql = @"select top 1 rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + ds.revision_equipos[0].nit_cliente_nuevo + "'";
                    txtclienteFinal.Text = bd.ejecutarProcedimiento(sql).ToString();
                    txtclienteFinal.NavigateUrl = "~/frm/herramientas/frmCliente.aspx?nit=" + ds.revision_equipos[0].nit_cliente_nuevo;
                    cargarClienteFinal();
                    if (!ds.revision_equipos[0].Iscod_sucursal_nuevoNull())
                    cmbSucursalFinal.SelectedValue = ds.revision_equipos[0].cod_sucursal_nuevo;
                }

                lblCreadoPor.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario =" + ds.revision_equipos[0].usuario_creacion).ToString();
                List<string> list = new List<string>();
                list.Add(ds.revision_equipos[0].serial);
                controlSerial1.asignarCodigos(list);
                string s = ds.revision_equipos[0].serial;
                //informacion del serial
                sql = "select rtrim(NombreModelo)+ ' ('+ rtrim(nombreFabricante)+')' from vistaEquipo where serial ='" + s.Trim() + "'";
                lblInformacionSerial.Text = "Modelo: " + bd.ejecutarProcedimiento(sql).ToString();
                sql = "select codOrdenServicio from ordenServicio where serial ='" + s + "' order by codOrdenServicio desc";
                cmbOrdenServicio.DataSource = bd.ejecutarConsulta(sql).Tables[0];
                cmbOrdenServicio.DataValueField = "codOrdenServicio";
                cmbOrdenServicio.DataTextField = "codOrdenServicio";
                cmbOrdenServicio.DataBind();
                if (ds.revision_equipos[0].Iscod_orden_servicioNull())
                {
                    cmbOrdenServicio.Items.Add(new ListItem("", ""));
                    cmbOrdenServicio.SelectedValue = "";
                }
                else
                {
                    cmbOrdenServicio.SelectedValue = ds.revision_equipos[0].cod_orden_servicio.ToString();
                }
               //
                if (!ds.revision_equipos[0].Iscerrada_porNull())
                lblCerradoPor.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario =" + ds.revision_equipos[0].cerrada_por).ToString();
/* 
                if (!ds.revision_equipos[0].Isresponsable_aprobacionNull())
                    lblResponsableAprobacion.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario =" + ds.revision_equipos[0].responsable_aprobacion).ToString();

                if (!ds.revision_equipos[0].Isfecha_aprobacionNull())
                lblFechaAprobacion.Text = ds.revision_equipos[0].fecha_aprobacion.ToShortDateString();
*/
                if (!ds.revision_equipos[0].Isfecha_cierreNull())
                    lblFechaCierre.Text = ds.revision_equipos[0].fecha_cierre.ToShortDateString();

                txtObservaciones.Text = ds.revision_equipos[0].observaciones;

                if (!ds.revision_equipos[0].IsadecuadoNull())
                {
                    rdAdecuado.Checked = ds.revision_equipos[0].adecuado;
                    rdNoAdecuado.Checked = !ds.revision_equipos[0].adecuado;
                }

 
                estados.FillBycod_estado_revision_equipos(ds.estado_revision_equipos, ds.revision_equipos[0].cod_estado_revision_equipos);
                lblEstado.Text = ds.estado_revision_equipos[0].nombre_estado_revision_equipos;
               
                if (ds.estado_revision_equipos[0].cod_manual == 1)//nueva
                {
                    btnAsignar.Visible = true;
                    btnCerrar.Visible = false;
                    btnReabrir.Visible = false;
                    btnEjecutar.Visible = false;
                }
                else if (ds.estado_revision_equipos[0].cod_manual == 2)//asignada
                {
                    btnAsignar.Visible = false;
                    btnCerrar.Visible = true;
                    btnEjecutar.Visible = true;
                    //VALIDA QUE SOLO LO PUEDA EJECUTAR EL USUSARIO LOGEADO
                    if (Session["ss_cod_usuario"].ToString() == ds.revision_equipos[0].responsable_revision.ToString().Trim())
                        btnEjecutar.Visible = true;
                    else
                        btnEjecutar.Visible = false;
                    btnReabrir.Visible = false;
                }
                else if (ds.estado_revision_equipos[0].cod_manual == 3)//en ejecucion
                {
                    btnAsignar.Visible = false;
                    btnCerrar.Visible = true;
                    //VALIDA QUE SOLO LO PUEDA EJECUTAR EL USUSARIO LOGEADO
                    if (Session["ss_cod_usuario"].ToString() == ds.revision_equipos[0].responsable_revision.ToString().Trim())
                        btnEjecutar.Visible = true;
                    else
                        btnEjecutar.Visible = false;
                    btnReabrir.Visible = false;
                }
                else if (ds.estado_revision_equipos[0].cod_manual == 4)//cerrada
                {
                    btnAsignar.Visible = false;
                    btnCerrar.Visible = false;
                    btnEjecutar.Visible = false;
                    btnReabrir.Visible = true;
                }
                else if (ds.estado_revision_equipos[0].cod_manual == 5)//anulado
                {
                    btnAsignar.Visible = false;
                    btnCerrar.Visible = false;
                    btnAnular.Text = "Informacion Anulacion";
                    btnEjecutar.Visible = false;
                    btnReabrir.Visible = false;
                }
                //ocultamos los botones si no tiene permiso

                if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2049, int.Parse(Session["ss_cod_usuario"].ToString()), Session))
                {
                    btnEditar.Visible = false;
                }

                if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2043, int.Parse(Session["ss_cod_usuario"].ToString()), Session))
                {
                    btnAnular.Visible = false;
                }

                if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2040, int.Parse(Session["ss_cod_usuario"].ToString()), Session))
                {
                    btnEjecutar.Visible = false;
                }

                if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2042, int.Parse(Session["ss_cod_usuario"].ToString()), Session))
                {
                    btnCerrar.Visible = false;
                }

                if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2050, int.Parse(Session["ss_cod_usuario"].ToString()), Session))
                {
                    btnReabrir.Visible = false;
                }
            
            }

        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAnular.aspx?cod="+Request.QueryString["cod"]);
    }
    protected void btnEjecutar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEjecutarRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnAsignar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAsignar.aspx?cod=" + Request.QueryString["cod"]);
    }
    protected void btnAprobar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmAprobar.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnCerrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCerrar.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }


    protected void btnEditar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmEditarRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnImprimir_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter template = new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter archivo = new SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        //validamos si ya hay una plantilla precargada
        archivo.FillBycod_revision_equipos(ds.archivo_template_revision_equipo, int.Parse(Request.QueryString["cod"]));
        string ruta = Server.MapPath("~/temp/");
        string url = "";
        string nombreArchivo = "";
        string extension = "";
        int k = 0;
        revision.FillBycod_revision_equipos(ds.revision_equipos, int.Parse(Request.QueryString["cod"]));
        if (ds.revision_equipos[0].Iscod_template_revison_equipoNull())
        {
            CGWebUtils.utils.misc.messageBox(Page, "Este modelo no tiene asociado Plantilla de trabajo.");
            return;
        }
        template.FillBycod_template_revison_equipo(ds.template_revison_equipo, ds.revision_equipos[0].cod_template_revison_equipo);
        if (ds.template_revison_equipo.Count == 0)
        {
            CGWebUtils.utils.misc.messageBox(Page, "Este modelo no tiene asociado Plantilla de trabajo.");
            return;
        }
        nombreArchivo = DateTime.Now.Ticks + " " + System.IO.Path.GetFileNameWithoutExtension(ds.template_revison_equipo[0].nombre_archivo).Replace(" ", "_");


        extension = System.IO.Path.GetExtension(ds.template_revison_equipo[0].nombre_archivo);

        if (ds.archivo_template_revision_equipo.Count > 0)
        {
            nombreArchivo = DateTime.Now.Ticks + " " + System.IO.Path.GetFileNameWithoutExtension(ds.archivo_template_revision_equipo[0].nombre_archivo);
            extension = System.IO.Path.GetExtension(ds.archivo_template_revision_equipo[0].nombre_archivo);
        }

        string nombreOriginal = nombreArchivo;
        //calculamos el nombre
        while (System.IO.File.Exists(ruta + "/" + nombreArchivo + extension))
        {
            k++;
            nombreArchivo = nombreOriginal + (k);
        }
        if (extension.Trim() == string.Empty)
        {
            extension = ".xlsx";
        }
        nombreArchivo = nombreArchivo + extension;
        
        ruta = ruta + nombreArchivo;
        url = "~/temp/" + nombreArchivo;
        clsUtils cls=new clsUtils();
        
        if (ds.archivo_template_revision_equipo.Count > 0)
        {
            System.IO.File.WriteAllBytes(ruta, ds.archivo_template_revision_equipo[0].archivo);
        }
        else
        {
            System.IO.File.WriteAllBytes(ruta, ds.template_revison_equipo[0].archivo_template);
        }  
            cls.remplazarCampos(ruta, ds.revision_equipos,Page);
        //ahora generamos el nombre del archivo pdf
            string nombreArchivoPDF = System.IO.Path.GetFileNameWithoutExtension(nombreArchivo).Replace(" ", "_");
            extension = ".pdf";
            ruta = Server.MapPath("~/temp/");
            nombreOriginal = nombreArchivoPDF;
            //calculamos el nombre
            while (System.IO.File.Exists(ruta + "/" + nombreArchivoPDF + extension))
            {
                k++;
                nombreArchivoPDF = nombreOriginal + (k);
            }

            nombreArchivoPDF = nombreArchivoPDF + extension;
       if( cls.Convertir(ruta+nombreArchivo,ruta+nombreArchivoPDF,Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF))
          url = "~/temp/" + nombreArchivoPDF;
       else
           url = "~/temp/" + nombreArchivo;
        Response.Redirect(url);
    }

    protected void btnReabrir_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
      
        //cambiamos el estado
        estado.FillBycod_manual(ds.estado_revision_equipos, 3);
        revision.UpdateEstado_revision_equipos(ds.estado_revision_equipos[0].cod_estado_revision_equipos, int.Parse(Request.QueryString["cod"]));
        lblEstado.Text = ds.estado_revision_equipos[0].nombre_estado_revision_equipos;
        btnReabrir.Visible = false;
        if (Session["ss_cod_usuario"].ToString().Trim() == cmbAsignadoA.SelectedValue.Trim())
            btnEjecutar.Visible = true;
        btnCerrar.Visible = true;

        if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2040, int.Parse(Session["ss_cod_usuario"].ToString()), Session))
        {
            btnEjecutar.Visible = false;
        }

        if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2042, int.Parse(Session["ss_cod_usuario"].ToString()), Session))
        {
            btnCerrar.Visible = false;
        }
    }
    protected void btnAgregarArchivo_Click(object sender, EventArgs e)
    {
           Response.Redirect("frmNewArchivoRevision.aspx?cod="+Request.QueryString["cod"]);
    }
    protected void btnVerArchivo(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        int cod = int.Parse(b.CommandArgument);
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsCientificaTableAdapters.archivos_revision_equiposTableAdapter archivos = new SPControladoraDatos.dsCientificaTableAdapters.archivos_revision_equiposTableAdapter();
        archivos.FillBycod_archivos_revision_equipos(ds.archivos_revision_equipos, cod);
        string path = Server.MapPath("~/temp/");
        string extension = System.IO.Path.GetExtension(ds.archivos_revision_equipos[0].nombre);
        string nombre = ds.archivos_revision_equipos[0].nombre.Replace(extension, "");

        int k = 0;
        while (System.IO.File.Exists(path + nombre + extension))
        {
            k++;
            nombre = nombre + k;
        }
        System.IO.File.WriteAllBytes(path + nombre + extension, ds.archivos_revision_equipos[0].archivo);
        Response.Redirect("~/temp/" + nombre + extension);

        //Response.Redirect("frmCerrarControl.aspx?cod=" + Request.QueryString["cod"]);
    }
}
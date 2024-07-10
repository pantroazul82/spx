using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmEjecutarRevision : System.Web.UI.Page
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
        nit = sacarNit(txtClienteFinal.Text);

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
        objs.comprobarAcceso(Page, Session, Response, 2040);
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

                if(!ds.revision_equipos[0].Isobservaciones_inicialesNull())
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
                string sql = "";
                if (!ds.revision_equipos[0].Isnit_clienteNull()) {
                    sql = @"select top 1 rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='"+ds.revision_equipos[0].nit_cliente+"'";
                    txtCliente.Text = bd.ejecutarProcedimiento(sql).ToString();
                    txtCliente.NavigateUrl = "~/frm/herramientas/frmCliente.aspx?nit=" + ds.revision_equipos[0].nit_cliente;
                    cargarCliente();
                    cmbSucursal.SelectedValue = ds.revision_equipos[0].cod_sucursal;
                }

                if (!ds.revision_equipos[0].Isnit_cliente_nuevoNull())
                {
                    sql = @"select top 1 rtrim(nombreCliente)+' ('+(rtrim(nitcliente))+')',numeroSocio from clientes where nitCliente ='" + ds.revision_equipos[0].nit_cliente_nuevo + "'";
                    txtClienteFinal.Text = bd.ejecutarProcedimiento(sql).ToString();
                    txtClienteFinal.NavigateUrl = "~/frm/herramientas/frmCliente.aspx?nit=" + ds.revision_equipos[0].nit_cliente_nuevo;
                    cargarClienteFinal();
                    cmbSucursalFinal.SelectedValue = ds.revision_equipos[0].cod_sucursal_nuevo;
                    cmbSucursalFinal.Enabled = false;
                }

                lblCreadoPor.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario =" + ds.revision_equipos[0].usuario_creacion).ToString();
                List<string> list = new List<string>();
                list.Add(ds.revision_equipos[0].serial);
                controlSerial1.asignarCodigos(list);
                string s = ds.revision_equipos[0].serial;
                //
                estados.FillBycod_estado_revision_equipos(ds.estado_revision_equipos, ds.revision_equipos[0].cod_estado_revision_equipos);
                lblEstado.Text = ds.estado_revision_equipos[0].nombre_estado_revision_equipos;
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
                if (ds.estado_revision_equipos[0].cod_manual == 2)
                {
                    btnAdjuntarPlantila.Visible = false;
                    FileUpload1.Visible = false;
                }else {
                    btnAdjuntarPlantila.Visible = true;
                    FileUpload1.Visible = true;
                }
            }
        }
    }
    
    
    protected void btnDescargarPlantilla_Click1(object sender, EventArgs e)
    {
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter template = new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter archivo = new SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter();
        SPControladoraDatos.dsCientifica ds=new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        //validamos si ya hay una plantilla precargada
        archivo.FillBycod_revision_equipos(ds.archivo_template_revision_equipo,int.Parse(Request.QueryString["cod"]));
        string ruta=Server.MapPath("~/temp/");
        string url = "";
        string nombreArchivo = "";
        string extension ="";
        int k = 0;
        revision.FillBycod_revision_equipos(ds.revision_equipos, int.Parse( Request.QueryString["cod"] ));
        if (!ds.revision_equipos[0].Iscod_template_revison_equipoNull())
        {
            template.FillBycod_template_revison_equipo(ds.template_revison_equipo, ds.revision_equipos[0].cod_template_revison_equipo);
        }
        if (ds.template_revison_equipo.Count == 0)
        {
            CGWebUtils.utils.misc.messageBox(Page, "Este modelo no tiene asociado Plantilla de trabajo.");
            return;
        }

        if (ds.template_revison_equipo[0].Isnombre_archivoNull() || ds.template_revison_equipo[0].nombre_archivo.Trim() == string.Empty)
        {
            CGWebUtils.utils.misc.messageBox(Page, "Este modelo tiene asociada una Plantilla de trabajo, pero la plantilla no tiene adjunto ningun archivo.");
            return;
        }
        nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(ds.template_revison_equipo[0].nombre_archivo);
        extension = System.IO.Path.GetExtension(ds.template_revison_equipo[0].nombre_archivo);
        string nombreOriginal = nombreArchivo;
        //calculamos el nombre
        while(System.IO.File.Exists(ruta+"/"+nombreArchivo+extension))
        {
            k++;
            nombreArchivo = nombreOriginal + (k);
        }
        nombreArchivo = nombreArchivo + extension;
        ruta = ruta + nombreArchivo;
        url = "~/temp/" + nombreArchivo;
        clsUtils utils = new clsUtils();
        if (ds.archivo_template_revision_equipo.Count > 0)
        {
            System.IO.File.WriteAllBytes(ruta, ds.archivo_template_revision_equipo[0].archivo);
           utils.remplazarCampos(ruta, ds.revision_equipos,Page);
            Response.Redirect(url);
        }else {
            System.IO.File.WriteAllBytes(ruta, ds.template_revison_equipo[0].archivo_template);
            //remplazamos los campos
            utils.remplazarCampos(ruta, ds.revision_equipos,Page);

            //actualizamos el estado a en ejecucion
            SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
            estado.FillBycod_manual(ds.estado_revision_equipos, 3);
            revision.UpdateEstado_revision_equipos(ds.estado_revision_equipos[0].cod_estado_revision_equipos, int.Parse(Request.QueryString["cod"]));
            revision.UpdateFecha_inicio_ejecucion(DateTime.Now, int.Parse(Request.QueryString["cod"]));
            btnAdjuntarPlantila.Visible = true;
            Response.Redirect(url);
        }
    }

 
    protected void btnAdjuntarPlantila_Click(object sender, EventArgs e)
    {
        if (!FileUpload1.HasFile)
        {
            lblError.Text = "Debe seleccionar un archivo.";
            return;
        }
        SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter archivo = new SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter();
        SPControladoraDatos.dsCientifica ds=new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        archivo.FillBycod_revision_equipos(ds.archivo_template_revision_equipo, int.Parse(Request.QueryString["cod"]));
        if (ds.archivo_template_revision_equipo.Count == 0)
        {
            archivo.Insert(int.Parse(Request.QueryString["cod"]), FileUpload1.FileBytes, DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()),System.IO.Path.GetFileName(FileUpload1.FileName));
        }else{
            archivo.UpdateQuery(FileUpload1.FileBytes, DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()), System.IO.Path.GetFileName(FileUpload1.FileName), int.Parse(Request.QueryString["cod"]));

        }
        lblError.Text = "Archivo cargado correctamente.";
    }


    private bool validar()
    {

        if (cmbOrigen.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar el origen de la solicitud.";
            return false;
        }
        if (cmbAsignadoA.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar a quien se asigna la revision";
            return false;
        }

        if (!calInicio.SelectedDate.HasValue)
        {
            lblError.Text = "Debe Ingresar la fecha y hora de ejecucion";
            return false;
        }

        if (!calFin.SelectedDate.HasValue)
        {
            lblError.Text = "Debe Ingresar la fecha y hora final de ejecucion";
            return false;
        }

        if (calInicio.SelectedDate > calFin.SelectedDate)
        {
            lblError.Text = "La fecha final de ejecucion no es coherente";
            return false;
        }

        if (txtCliente.Text.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar el Cliente.";
            return false;
        }

        if (cmbSucursal.SelectedValue.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar la sucursal.";
            return false;
        }

        string nit = sacarNit(txtCliente.Text);
        if (nit.Trim() == string.Empty)
        {
            lblError.Text = "Debe ingresar un cliente valido.";
            return false;
        }
        return true;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (!validar()) return;
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        string nit = sacarNit(txtCliente.Text);
        string nitnuevo = sacarNit(txtClienteFinal.Text);
        int? codOrden = null;

        if (cmbOrdenServicio.SelectedValue.Trim() != string.Empty)
        {
            codOrden = int.Parse(cmbOrdenServicio.Text);
        }
        
        revision.Updatetab1(int.Parse(cmbIngenieroRecibe.SelectedValue), int.Parse(cmbAsesorRecibe.SelectedValue),
            rdEquipoNuevo.Checked, txtObservacionesiniciales.Text, int.Parse(cmbAsignadoA.SelectedValue),
            int.Parse(cmbOrigen.SelectedValue), txtIdFo.Text, nit, cmbSucursal.SelectedValue,
            calInicio.SelectedDate, calFin.SelectedDate, codOrden,

                 (nitnuevo.Trim() == string.Empty) ? null : nitnuevo,
            (cmbSucursalFinal.SelectedValue == string.Empty) ? null : cmbSucursalFinal.SelectedValue,

            int.Parse(Request.QueryString["cod"]));
         
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

}
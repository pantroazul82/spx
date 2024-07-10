using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmCerrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad objs = new clsSeguridad();
        objs.comprobarAcceso(Page, Session, Response, 2042);
       

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar()) return;
        //guardamos la informacion
        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado = new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        estado.FillBycod_manual(ds.estado_revision_equipos, 4);
        revision.FillBycod_revision_equipos(ds.revision_equipos,int.Parse(Request.QueryString["cod"]));
        revision.UpdateEstado_revision_equipos(ds.estado_revision_equipos[0].cod_estado_revision_equipos, int.Parse(Request.QueryString["cod"]));
        revision.UpdateObservaciones(txtObservaciones.Text, int.Parse(Request.QueryString["cod"]));
        //revision.UpdateResponsableAprobacion(int.Parse(cmbResponsableAprobacion.SelectedValue),int.Parse(Request.QueryString["cod"]));
        revision.UpdateAdecuado(rdAdecuado.Checked,int.Parse(Request.QueryString["cod"]));
        revision.UpdateFecha_fin_ejecucion(DateTime.Now, int.Parse(Request.QueryString["cod"]));
        revision.UpdateCierre(DateTime.Now,DateTime.Now,
            int.Parse(Session["ss_cod_usuario"].ToString()),int.Parse(Request.QueryString["cod"]));
        //
        if (rdNoAdecuado.Checked && !ds.revision_equipos[0].Iscod_orden_servicioNull())
        { 
            //abrimos la orden de servicio
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter os = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
           // spProcesos.ordenesTrabajo.cls.osController osx = new spProcesos.ordenesTrabajo.cls.osController();
            os.UpdateCerrada(null, null, "PROGR", 0, null, null, ds.revision_equipos[0].cod_orden_servicio);
            //notificamos por correo.
            string sql = "select creadaPor,asignadoA from ordenServicio where codOrdenServicio="+ds.revision_equipos[0].cod_orden_servicio;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
            string creada = bd.ejecutarProcedimiento("select correo from usuario where login ='" + tb.Rows[0]["creadaPor"].ToString()+"'").ToString();
            string asignada = bd.ejecutarProcedimiento("select correo from usuario where login ='" + tb.Rows[0]["asignadoA"].ToString() + "'").ToString();
            clsSeguridad utils = new clsSeguridad();
            string asunto = "Orden de servicio reabierta" ;
            string cuerpo = "La orden de servicio " + ds.revision_equipos[0].cod_orden_servicio + " fue reabierta desde el proceso de revision de equipos <br>"+txtObservaciones.Text;
            try
            {
                utils.enviarEmail(asunto, cuerpo, creada);
            }catch(Exception){}
            try
            {
                utils.enviarEmail(asunto, cuerpo, asignada);
            }catch(Exception){}
  
            
        }
        Response.Redirect("frmResumenDetalladoRevision.aspx?cod=" + Request.QueryString["cod"]);
    }

    private bool validar()
    {
        if (!rdAdecuado.Checked && !rdNoAdecuado.Checked)
        {
            lblError.Text = "Debe seleccionar el concepto cientifico.";
            return false;
        }
        //validamos que halla adjuntado el documento por lo menos una vez
         SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter archivo = new SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter();
        SPControladoraDatos.dsCientifica ds=new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        archivo.FillBycod_revision_equipos(ds.archivo_template_revision_equipo, int.Parse(Request.QueryString["cod"]));
        if (ds.archivo_template_revision_equipo.Count == 0)
        {
            lblError.Text = "Debe adjuntar el documento diligenciado para poder cerrar la orden.";
            return false;
        }
        return true;
    }
}
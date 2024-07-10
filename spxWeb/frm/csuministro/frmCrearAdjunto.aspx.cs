using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_csuministro_frmCrearAdjunto : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ss_nombre_usuario"] == null)
        {
            Response.Redirect("~/default.aspx");
        }
        if (!IsPostBack)
        {

            lblFechaCreacion.Text = DateTime.Now.ToShortDateString();
            lblCreadoPor.Text = Session["ss_nombre_usuario"].ToString();
            if (Request.QueryString["codc"] != null)
            {
                SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter();

                SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
                p.FillByCod_adjunto_contrato_suministro(ds.adjunto_contrato_suministro, int.Parse(Request.QueryString["codc"]));
                //---
                lblFechaCreacion.Text = ds.adjunto_contrato_suministro[0].fecha_creacion.ToShortDateString();
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                lblCreadoPor.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario="+ds.adjunto_contrato_suministro[0].cod_usuario_creacion).ToString();
             
                txtObservaciones.Text = ds.adjunto_contrato_suministro[0].observaciones_inicial;
                cmbTipoAdjunto.SelectedValue = ds.adjunto_contrato_suministro[0].cod_tipo_adjunto_contrato_suministro.ToString();
                cmbEstado.SelectedValue = ds.adjunto_contrato_suministro[0].cod_estado_adjunto_contrato_suministro.ToString();
                if (!ds.adjunto_contrato_suministro[0].Isruta_archivoNull())
                {
                    lnkVerArchivo.Visible = true;
                    lnkVerArchivo.NavigateUrl = ds.adjunto_contrato_suministro[0].ruta_archivo;
                }
            }
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }

    private bool validar()
    {
      

        if (lnkVerArchivo.NavigateUrl.Trim() == string.Empty)
        {
            lblError.Text = "EL archivo es obligatorio";
            return false;
        }


        if (txtObservaciones.Text.Trim() == string.Empty)
        {
            lblError.Text = "Las observaciones iniciales son obligatorias";
            return false;
        }


        if (cmbTipoAdjunto.SelectedValue == null || cmbTipoAdjunto.SelectedValue== string.Empty)
        {
            lblError.Text = "EL tipo de adjunto archivo es obligatorio";
            return false;
        }
        return true;
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar()) { return; }
        SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter p = new SPControladoraDatos.dsContratosSuministroTableAdapters.adjunto_contrato_suministroTableAdapter();

        if (Request.QueryString["codc"] == null)
        {
            int estado=0;
            SPControladoraDatos.dsContratosSuministro ds = new SPControladoraDatos.dsContratosSuministro();
            SPControladoraDatos.dsContratosSuministroTableAdapters.estado_adjunto_contrato_suministroTableAdapter estadoT = new SPControladoraDatos.dsContratosSuministroTableAdapters.estado_adjunto_contrato_suministroTableAdapter();
            estadoT.FillByCod_manual(ds.estado_adjunto_contrato_suministro, 2);
            estado = ds.estado_adjunto_contrato_suministro[0].cod_estado_adjunto_contrato_suministro;
            p.Insert(
                int.Parse(cmbTipoAdjunto.SelectedValue),int.Parse(Request.QueryString["cod"]),
                DateTime.Now,estado,lnkVerArchivo.NavigateUrl,
                txtObservaciones.Text,
                int.Parse(Session["ss_cod_usuario"].ToString())
                );

            clsSeguridad cls = new clsSeguridad();
            string asunto = "Nuevo Adjunto de Contrato de suministro cod:" + 
Request.QueryString["cod"]+" "+cmbTipoAdjunto.SelectedItem.Text;
            string cuerpo = @"Nuevo Adjunto para contrato de suministro<br>
Cod Contrato:" + Request.QueryString["cod"] + @"<br>
Adjunto: " + cmbTipoAdjunto.SelectedItem.Text + @"<br>
Observaciones:" + txtObservaciones.Text.Replace("\r\n", "<br>").Replace("\n", "<br>") + @"<br> " +
                       @"<a href='" + cls.verIpSitiio() + @"frm/csuministro/frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"] + "'  >Ver Contrato</a><br>" +
                       "verifique la información para la respectiva aprobación. ";
            List<string> lista = new List<string>();
            //enviamos correos
              //enviamos correo a quienes realizan aprobacion adminsitrativo.
                lista = cls.verCorreos(2057);
            
                //enviamos correo a quienes realizan aprobacion cartera.
            //lista = cls.verCorreos(2069);
            
                //enviamos correo a quienes realizanaprobacion juridica.
            //    lista = cls.verCorreos(2056);
            

            for (int k = 0; k < lista.Count; k++)
            {
                string msg = "";
                List<string> adjuntos = new List<string>();
                if (lista[k].Trim() != string.Empty)
                    cls.enviarEmail(asunto, cuerpo, lista[k], adjuntos, out msg);
            }

        }
        else
        {
            p.UpdateQuery(  int.Parse(cmbTipoAdjunto.SelectedValue),lnkVerArchivo.NavigateUrl,txtObservaciones.Text,
            int.Parse(Request.QueryString["codc"]));
        }

        Response.Redirect("frmDetalleContrato.aspx?cod=" + Request.QueryString["cod"]);
    }

   

    protected void btnCargarArchivo_Click(object sender, EventArgs e)
    {
        if (!FileUpload1.HasFile)
        {
            lblError.Text = "Seleccione el archivo ";
            return;
        }

        string ruta = Server.MapPath("~");
        ruta = ruta + "/files/";

        string archivo = "estampilla" + DateTime.Now.Ticks + "" + System.IO.Path.GetExtension(FileUpload1.FileName);
        FileUpload1.SaveAs(ruta + archivo);

        lnkVerArchivo.CssClass = "";
        lnkVerArchivo.NavigateUrl = "~/files/" + archivo;
        lnkVerArchivo.Visible = true;
    }
}
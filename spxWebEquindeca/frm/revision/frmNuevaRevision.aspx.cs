using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_revision_frmNuevaRevision : System.Web.UI.Page
{
    

    public void serialSelected(object sender, EventArgs e)
    {
        if (controlSerial1.verCodigos().Count > 0)
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            string s=controlSerial1.verCodigos()[0];
            string sql = "select rtrim(NombreModelo)+ ' ('+ rtrim(nombreFabricante)+')' from vistaEquipo where serial ='" + s.Trim() + "'";
            lblInformacionFabricanteModelo.Text = bd.ejecutarProcedimiento(sql).ToString();
            sql = "select codOrdenServicio from ordenServicio where serial ='"+s+"' order by codOrdenServicio desc";
            cmbOrdenServicio.DataSource = bd.ejecutarConsulta(sql).Tables[0];
            cmbOrdenServicio.DataValueField = "codOrdenServicio";
            cmbOrdenServicio.DataTextField = "codOrdenServicio";
            cmbOrdenServicio.DataBind();
            cmbOrdenServicio.Items.Add(new ListItem("Seleccione", ""));
            cmbOrdenServicio.SelectedValue = "";

            UpdatePanel1.Update();
        }
    
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.controlSerial1.OnSerialSelected += new EventHandler(serialSelected);
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 2038);
        if (!IsPostBack)
        {
            cmbAsesorRecibe.SelectedValue = "";
            cmbIngenieroRecibe.SelectedValue = "";
        }
        
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmListadoRevision.aspx");
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (!validar()) return;

        SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter revision = new SPControladoraDatos.dsCientificaTableAdapters.revision_equiposTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter estado=new SPControladoraDatos.dsCientificaTableAdapters.estado_revision_equiposTableAdapter();
        SPXdata.BD.DataConector bd=new SPXdata.BD.DataConector();
        SPControladoraDatos.dsCientifica ds=new SPControladoraDatos.dsCientifica();
        SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter template=new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
        estado.FillBycod_manual(ds.estado_revision_equipos,1);
        List<string> lista= controlSerial1.verCodigos();
        string nitCliente="";
        string codSucursal="";
        string codModelo = "";
        string codFabricante="";
        string sql=@"select 
nitClienteubica,codSucursalUbica,codModelo,codFabricante
 from equipos where serial like '"+lista[0]+"' ";
        System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];
        nitCliente=tb.Rows[0]["nitClienteubica"].ToString();
        codSucursal=tb.Rows[0]["codSucursalUbica"].ToString();
        codModelo = tb.Rows[0]["codModelo"].ToString();
        codFabricante=tb.Rows[0]["codFabricante"].ToString();
        int? codTemplate=null;
        sql=@"SELECT cod_template_revison_equipo FROM template_revison_equipo 
where codFabricante ='"+codFabricante.Trim()+"' and codModelo='"+codModelo.Trim()+"' and vigencia_hasta is null";
        System.Data.DataTable tb2= bd.ejecutarConsulta(sql).Tables[0];
        if(tb2.Rows.Count>0)
        {
        codTemplate= int.Parse(tb2.Rows[0]["cod_template_revison_equipo"].ToString());
        }
        int? codOrden = null;
        if (cmbOrdenServicio.SelectedValue.Trim() != string.Empty)
        {
            codOrden = int.Parse(cmbOrdenServicio.Text);
        }
        revision.Insert(DateTime.Now, int.Parse(Session["ss_cod_usuario"].ToString()),
            ds.estado_revision_equipos[0].cod_estado_revision_equipos,lista[0],codModelo,            
            int.Parse(cmbIngenieroRecibe.SelectedValue), int.Parse(cmbAsesorRecibe.SelectedValue), rdEquipoNuevo.Checked,
            null, null, txtObservacionesiniciales.Text, "", null, 
            null,
             null, null, null,
            null, null, null, null, codTemplate,null,null,null,null,null,null,null,codOrden);
            
        Response.Redirect("frmListadoRevision.aspx");
    }

    /// <summary>
    /// Valida que los campos esten bien diligenciados
    /// </summary>
    /// <returns></returns>
    private bool validar()
    {
        lblError.Text = "";
      

        if (cmbIngenieroRecibe.SelectedValue == "")
        {
            lblError.Text = "El ingeniero es obligatorio";
            return false;
        }
        if (cmbAsesorRecibe.SelectedValue == "")
        {
            lblError.Text = "El asesor que recibe es obligatorio";
            return false;
        }

      
        if (!rdEquipoNoNuevo.Checked && !rdEquipoNuevo.Checked)
        {
            lblError.Text = "Debe seleccionar si el equipo es nuevo o usado";
            return false;
        }
        
      
        List<string> lista= controlSerial1.verCodigos();
        if ( lista.Count == 0 || lista[0] == string.Empty)
        {
            lblError.Text = "El serial es obligatorio";
            return false;
        }

        return true;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
}
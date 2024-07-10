using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmInscritosClases : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblcodigoSesion.Text = Request.QueryString["cod"];
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objCapacitacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;

        obj.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(lblcodigoSesion.Text));
        objCapacitacion.FillBycod_capacitacion(ds.capacitacion, ds.session_capacitacion[0].cod_capacitacion);
        
            if (ds.capacitacion[0].Isdictada_por_otroNull())
            {
                btnReprogramar.Visible = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2021, int.Parse(Session["ss_cod_usuario"].ToString()), Session);

            }
            else
            {
                btnReprogramar.Visible = (ds.capacitacion[0].dictada_por.ToString().Trim() == Session["ss_cod_usuario"].ToString().Trim());
            }

            if (!IsPostBack)
            {
                if (ds.session_capacitacion[0].IsreprogramdaNull() || !ds.session_capacitacion[0].reprogramda)
                {
                    chkReprogramada.Visible = false;
                    txtRazonReprogra.Visible = false;
                }
                else {
                    chkReprogramada.Visible = true;
                    txtRazonReprogra.Visible = true;
                    txtRazonReprogra.Text = "Razon de reprogramacion " + ds.session_capacitacion[0].observaciones_reprogramacion;
                }
            }

            //verificamos si ya se ingreso informacion de algun participante no puede reporgramar
            string sql = "select count(*) from asistentexsession where cod_session ="+Request.QueryString["cod"]+" and asistio is not null";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            int cnt = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
            if( cnt > 0)
                btnReprogramar.Visible=false;
        
    
            
        lblTexto.Text = " Capacitacion "+ds.capacitacion[0].nombre +" fecha "+ds.session_capacitacion[0].fecha_inicio.ToLongDateString()+" "+ds.session_capacitacion[0].fecha_inicio.ToLongTimeString();
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        obj.FillBycod_sesion_capacitacion(ds.session_capacitacion, int.Parse(lblcodigoSesion.Text));
        Response.Redirect("frmCapacitacion.aspx?cod=" + ds.session_capacitacion[0].cod_capacitacion);
    }

    public bool verBotonEjecutar(object obj) 
    {
        string sql = @"select capacitacion.cod_estado_capacitacion from asistentexsession 
join capacitacion on capacitacion.cod_capacitacion= asistentexsession.cod_capacitacion
where codasistentexsession=" + obj;
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        object ob = bd.ejecutarProcedimiento(sql);
        if (ob.ToString().Trim() == "3") return false;
        bool permiso = SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2021, int.Parse(Session["ss_cod_usuario"].ToString()), Session);

         sql = @"select dictada_por from asistentexsession 
join capacitacion on capacitacion.cod_capacitacion= asistentexsession.cod_capacitacion
where codasistentexsession=" + obj;
        object o = bd.ejecutarProcedimiento(sql);
        string profesor = "";
        if (o != null && o != System.DBNull.Value) profesor = o.ToString();

        if (!permiso && Session["ss_cod_usuario"].ToString() != profesor) return false;

        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter ta = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        ta.FillBycodasistentexsession(ds.asistentexsession, int.Parse(obj.ToString()));
        if (ds.asistentexsession[0].IsasistioNull())
            return true;

        return false;
    }

    public bool verBotonCancelar(object obj)
    {

        bool permiso=SPXSeguridad.verificadorPermisos.ejecutarAccionWeb(2021,int.Parse(Session["ss_cod_usuario"].ToString()),Session);

        string sql = @"select capacitacion.cod_estado_capacitacion from asistentexsession 
join capacitacion on capacitacion.cod_capacitacion= asistentexsession.cod_capacitacion
where codasistentexsession=" + obj;
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        object ob = bd.ejecutarProcedimiento(sql);
        if (ob.ToString().Trim() == "3") return false;
        sql=@"select dictada_por from asistentexsession 
join capacitacion on capacitacion.cod_capacitacion= asistentexsession.cod_capacitacion
where codasistentexsession="+obj;
        
        object o=bd.ejecutarProcedimiento(sql);
        string profesor = "";
        if(o != null && o != System.DBNull.Value)profesor=o.ToString();

        if (!permiso && Session["ss_cod_usuario"].ToString() != profesor) return false;


        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter ta = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
        ta.FillBycodasistentexsession(ds.asistentexsession, int.Parse(obj.ToString()));
        if (ds.asistentexsession[0].IsasistioNull())
            return false;
        return true;
    }

    public void btnGuadarInformacion(object sender, EventArgs e) 
    {

        ImageButton b = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();

        for (int k = 0; k < RadGrid1.Items.Count; k++)
        {
            if (((ImageButton)RadGrid1.Items[k].FindControl("btnGuardarObs")).ValidationGroup.ToString().Trim() == b.ValidationGroup.ToString().Trim())
            {
                obj.UpdateAsistencia(
                    ((RadioButton)RadGrid1.Items[k].FindControl("rdSi")).Checked
                    , ((TextBox)RadGrid1.Items[k].FindControl("txtObservaciones")).Text 
                    , int.Parse(b.ValidationGroup.ToString()));
                break;
            }
        }
        RadGrid1.DataBind();
        btnReprogramar.Visible = false;
    }

    public void btnEliminar(object sender, EventArgs e)
    {

        ImageButton b = (ImageButton)sender;
        SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.asistentexsessionTableAdapter();

        for (int k = 0; k < RadGrid1.Items.Count; k++)
        {
            if (((ImageButton)RadGrid1.Items[k].FindControl("btnGuardarObs")).ValidationGroup.ToString().Trim() == b.ValidationGroup.ToString().Trim())
            {
                obj.UpdateAsistencia(
                    null
                    , ""
                    , int.Parse(b.ValidationGroup.ToString()));
                break;
            }
        }
        RadGrid1.DataBind();
    }

    public void btnReprogramar_click(object sender, EventArgs e)
    {
        Response.Redirect("frmReprogramacion.aspx?cod=" + Request.QueryString["cod"].ToString());
    }
}
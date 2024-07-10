using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_calendar_frmCerrarActividad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSeguridad obj = new clsSeguridad();
        obj.comprobarAcceso(Page, Session, Response, 2007);
        if (Request.QueryString["cod"] == null)
            obj.comprobarAcceso(Page, Session, Response, 11112007);
        lblCodActividad.Text = Request.QueryString["cod"].ToString();
        if (!IsPostBack)
        {
            calFin.SelectedDate = DateTime.Now;
            //miramos el estado si es cerrada con pendientes cargamos cierta info y bloqueamos controles
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter objT = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objes = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
            objT.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(lblCodActividad.Text));
            objes.FillByCod_estado_tarea_calendario(ds.estado_tarea_calendario, ds.tarea_calendario[0].cod_estado_tarea_calendario);
            if (ds.estado_tarea_calendario[0].cod_manual == 4)
            {
                Response.Redirect("frmCerrarPendientes.aspx?cod=" + Request.QueryString["cod"].ToString());
            }
        }

        
    }
   
   
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + lblCodActividad.Text);
    }
    protected void btnCerrar_Click(object sender, EventArgs e)
    {
        if (!calInicio.SelectedDate.HasValue)
        {
            lblErrorFirma.Text = "Debe ingresar la fecha de inicio";
            return;
        }
        if (calInicio.SelectedDate.Value > calFin.SelectedDate.Value)
        {
            lblErrorFirma.Text = "La fecha de inicio no puede ser mayor que la fecha final";
            return;
        }
        if (chkAdjuntarFirma.Checked && !ctlSignature1.IsValid())
        {
            lblErrorFirma.Text = "Debe guardar la firma primero";
            return;
        }
  SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objEstado=new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
        
        int est=3;
        DateTime? fechaCierre= DateTime.Now;
        DateTime? fechaCierreParcial= null;
        string obsCierre=txtObservacionesAprobacion.Text;
        string obsPendientes="";
        if(lstPendientes.Items.Count>0)
        {
         est=4;
            fechaCierre= null;
            fechaCierreParcial = DateTime.Now;
            obsCierre="";
            obsPendientes=txtObservacionesAprobacion.Text;
        }
       
        objEstado.FillByCod_manual(ds.estado_tarea_calendario,est);

        obj.UpdateEstadoAprobacion(ds.estado_tarea_calendario[0].cod_estado_tarea_calendario ,int.Parse(lblCodActividad.Text));
        obj.UpdateTienePendientes(lstPendientes.Items.Count>0 , int.Parse(lblCodActividad.Text));
        


        obj.UpdateNombreCliente(txtContactoCierre.Text,int.Parse(lblCodActividad.Text));

        obj.UpdateCierre(calInicio.SelectedDate, calFin.SelectedDate, fechaCierreParcial, fechaCierre,
            lstPendientes.Items.Count > 0, rdSi.Checked, txtRazon.Text,
            obsCierre, int.Parse(lblCodActividad.Text));

        obj.UpdateFechaCierre(fechaCierre, int.Parse(lblCodActividad.Text));
        obj.UpdateFecha_cierre_parcial(fechaCierreParcial, int.Parse(lblCodActividad.Text));

        obj.UpdatePendientes(obsPendientes, int.Parse(lblCodActividad.Text));
        if(chkAdjuntarFirma.Checked){
            string finalImg = ctlSignature1.SignatureFile;
            btnLimpiarFirma.Visible = false;
            ctlSignature1.Visible = false;
         byte[] arrb = System.IO.File.ReadAllBytes(Server.MapPath(finalImg));
         obj.UpdateFirma(arrb,int.Parse(lblCodActividad.Text));
        }
        //guardamos los pendientes
        SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter objP = new SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter();
        for (int k = 0; k < lstPendientes.Items.Count;k++ )
        {
            objP.Insert(int.Parse(lblCodActividad.Text), lstPendientes.Items[k].Text, null, null);
        }
        //--
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + lblCodActividad.Text);
    }

    protected void btnAgregarPendiente_Click(object sender, EventArgs e)
    {
        if (txtPendiente.Text == string.Empty) return;
        lstPendientes.Items.Add(new Telerik.Web.UI.RadListBoxItem(txtPendiente.Text));
        txtPendiente.Text = "";
    }
}
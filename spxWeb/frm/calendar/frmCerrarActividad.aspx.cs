using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
public partial class frm_calendar_frmCerrarActividad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        this.ctlSignatureN.SignRequiredPoints = "10";
        HtmlMeta metaTag = new HtmlMeta();
        metaTag.Name = "viewport";
        metaTag.Content = "width=device-width, user-scalable=yes";

        Page.Header.Controls.Add(metaTag);

       

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
            ds.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter objT = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter objes = new SPControladoraDatos.dsSpxTableAdapters.estado_tarea_calendarioTableAdapter();
            SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter pendientes = new SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter();
            objT.FillByCod_tarea_calendario(ds.tarea_calendario, int.Parse(lblCodActividad.Text));
            objes.FillByCod_estado_tarea_calendario(ds.estado_tarea_calendario, ds.tarea_calendario[0].cod_estado_tarea_calendario);
            if (ds.estado_tarea_calendario[0].cod_manual == 4)
            {
                Response.Redirect("frmCerrarPendientes.aspx?cod=" + Request.QueryString["cod"].ToString());
            }
            if (!ds.tarea_calendario[0].Isinicio_ejecucionNull())
            calInicio.SelectedDate = ds.tarea_calendario[0].inicio_ejecucion;

            if (!ds.tarea_calendario[0].Isnombre_clienteNull())
                txtContactoCierre.Text = ds.tarea_calendario[0].nombre_cliente;

            if (!ds.tarea_calendario[0].Israzon_solucionadoNull())
                txtRazon.Text = ds.tarea_calendario[0].razon_solucionado;

            if (!ds.tarea_calendario[0].IspendientesNull())
                txtObservacionesAprobacion.Text = ds.tarea_calendario[0].pendientes;

            if (!ds.tarea_calendario[0].Isobervaciones_aprobacionNull() && ds.tarea_calendario[0].obervaciones_aprobacion != string.Empty)
                txtObservacionesAprobacion.Text = ds.tarea_calendario[0].obervaciones_aprobacion;

            if (!ds.tarea_calendario[0].IsfirmaNull())
            {
                string ruta= Server.MapPath("~/temp/");
                string archivo= DateTime.Now.Ticks.ToString()+lblCodActividad.Text+""+".png";
                System.IO.File.WriteAllBytes(ruta+archivo, ds.tarea_calendario[0].firma);
                chkAdjuntarFirma.Checked=true;

                imgFirma.ImageUrl = "~/temp/" + archivo;
                imgFirma.Visible = true;
            }

            if (!ds.tarea_calendario[0].IssolucionadoNull())
            {
                rdSi.Checked = ds.tarea_calendario[0].solucionado;
                rdNo.Checked = !ds.tarea_calendario[0].solucionado;
            }
            SPControladoraDatos.dsCientifica dsCientifica=new SPControladoraDatos.dsCientifica();
            pendientes.FillByCod_tarea_calendario(dsCientifica.pendiente_tarea, int.Parse( lblCodActividad.Text ));

            for (int k = 0; k < dsCientifica.pendiente_tarea.Count; k++)
            {
                lstPendientes.Items.Add(new Telerik.Web.UI.RadListBoxItem(dsCientifica.pendiente_tarea[k].pendiente));
            }

        }

        
    }

    protected void btnIniciarFirma_Click(object sender, EventArgs e)
    {
        lblErrorFirma.Text = "";
        Panel1_ModalPopupExtender.Show();
    }

    protected void btnCancelarFirma_Click(object sender, EventArgs e)
    {
        Panel1_ModalPopupExtender.Hide();
    }

    protected void btnContinuarFirma_Click(object sender, EventArgs e)
    {
        ctlSignatureN.SaveSignature("");
        ctlSignatureN.LoadSignature(ctlSignatureN.SignData, "1");
        //validamos que exista la imagen
        string ruta = Server.MapPath("~/temp/");
        string imagen = DateTime.Now.Ticks.ToString() + lblCodActividad.Text + ".png";
        string img = ruta+imagen;
        ctlSignatureN.SaveSignature(img);
        if (ctlSignatureN.TotalSignPoints <10 || !System.IO.File.Exists(img))
        {
            lblErrorFirma.Text = "No olvide antes de continuar ingresar la firma.<br>";
            return;
        }
        imgFirma.ImageUrl = "~/temp/" + imagen;
        chkAdjuntarFirma.Checked = true;
        pnlImgRef.Update();
        Panel1_ModalPopupExtender.Hide();
    }
   
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmNewTask.aspx?cod=tarea|" + lblCodActividad.Text);
    }
    protected void btnCerrar_Click(object sender, EventArgs e)
    {
        if (!calInicio.SelectedDate.HasValue)
        {
            lblError.Text = "Debe ingresar la fecha de inicio";
            return;
        }
        if (calInicio.SelectedDate.Value > calFin.SelectedDate.Value)
        {
            lblError.Text = "La fecha de inicio no puede ser mayor que la fecha final";
            return;
        }
        if (chkAdjuntarFirma.Checked &&

            (imgFirma.ImageUrl == string.Empty)
            )
        {
            lblError.Text = "Debe guardar la firma primero";
            return;
        }
  SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter obj = new SPControladoraDatos.dsSpxTableAdapters.tarea_calendarioTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        ds.EnforceConstraints = false;
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
            string finalImg = imgFirma.ImageUrl;
            btnLimpiarFirma.Visible = false;
            ctlSignatureN.Visible = false;
         byte[] arrb = System.IO.File.ReadAllBytes(Server.MapPath(finalImg));
         obj.UpdateFirma(arrb,int.Parse(lblCodActividad.Text));
        }
        //guardamos los pendientes
        
        SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter objP = new SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter();
        objP.DeleteByCod_tarea_calendario(int.Parse(lblCodActividad.Text));
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
    protected void btnLimpiarFirma_Click(object sender, EventArgs e)
    {
        ctlSignatureN.InitSignature();
        
    }
}
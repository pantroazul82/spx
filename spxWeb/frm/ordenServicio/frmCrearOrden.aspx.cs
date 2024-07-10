using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_ordenServicio_frmCrearOrden : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //verficamos permiso
        clsSeguridad seg = new clsSeguridad();
        seg.comprobarAcceso(Page, Session, Response, 2014);
        if (!IsPostBack)
        {

            cmbResponsable.DataBind();
                cmbResponsable.SelectedValue = Session["ss_login"].ToString();
                string msg = "";
             if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(2015, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
            {
                
                cmbResponsable.Enabled = false;
            }
            //permiso de denegacion si solo puede ver sus ordenes web, del mismo modo solo puede crear para si mismo
             if (SPXSeguridad.verificadorPermisos.ejecutarAccion(2052, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
             {

                 cmbResponsable.Enabled = false;
             }
        }
    }


    protected void rdExterna_CheckedChanged(object sender, EventArgs e)
    {
        if (rdExterna.Checked)
        {
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            dsSpx1.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter
                prioridadesOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();

            prioridadesOrdenServicioTableAdapter1.FillByExternas(dsSpx1.prioridadesOrdenServicio);
            cmbPrioridad.DataSource = dsSpx1.prioridadesOrdenServicio;
            cmbPrioridad.DataTextField = "nombre";
            cmbPrioridad.DataValueField = "codPrioridadOS";
            cmbPrioridad.DataBind();
            lblEntrada.Visible = false;
            cmbEntradas.Visible = false;
        }
    }

    protected void rdInterna_CheckedChanged(object sender, EventArgs e)
    {
        if (rdInterna.Checked)
        {
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            dsSpx1.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter
                prioridadesOrdenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.prioridadesOrdenServicioTableAdapter();

            prioridadesOrdenServicioTableAdapter1.FillByInternas(dsSpx1.prioridadesOrdenServicio);
            cmbPrioridad.DataSource = dsSpx1.prioridadesOrdenServicio;
            cmbPrioridad.DataTextField = "nombre";
            cmbPrioridad.DataValueField = "codPrioridadOS";
            cmbPrioridad.DataBind();
            //ademas cargamos las entradas que tenga ese serial
            lblEntrada.Visible = true;
            string sql = @"select codEntradaSAlidaEquipos,
'Cod:'+
rtrim(codEntradaSAlidaEquipos) +' Fecha:'+
cast(cast(fechaEntrada as date) as char(20)) 'texto'

 from entradaSalidaEquipos where codOrdenServicio is null
and serial ='"+txtSerial.Text+"'";
            SPXdata.BD.DataConector obj=new SPXdata.BD.DataConector();
            cmbEntradas.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbEntradas.DataTextField = "texto";
            cmbEntradas.DataValueField = "codEntradaSAlidaEquipos";
            cmbEntradas.DataBind();
            cmbEntradas.Visible = true;

        }
    }



    protected void btnPaso2_Click(object sender, EventArgs e)
    {
        lblErrorPAsoUno.Text = "";
        if (controlSerial2.verCodigos().Count <= 0)
        {
            lblErrorPAsoUno.Text = "El serial es indispensable para continuar!";
            return;
        }
        PanelUno.Visible = false;
        pnlDos.Visible = true;
        txtSerial.Text = controlSerial2.verCodigos()[0];
        lnkVerHojaVida.NavigateUrl = "~/frm/hojavida/frmHojaVida.aspx?sx=" + txtSerial.Text;
    }

    protected void btnAtrasPaso_Click(object sender, EventArgs e)
    {
        Response.Redirect("frmCrearOrden.aspx");
    }
    protected void rdPorContrato_CheckedChanged(object sender, EventArgs e)
    {
        if (rdPorContrato.Checked)
        {
            lblNumeroContrato.Visible = true;
            cmbContrato.Visible = true;
            
            SPXdata.BD.DataConector obj=new SPXdata.BD.DataConector();
            DateTime n = obj.fechaServer;
            SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1 = new
            SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            //--
            dsSpx1.EnforceConstraints = false;
            contratosTableAdapter1.FillByContratoActivoEquipo(dsSpx1.contratos, txtSerial.Text, n);
            //--
            cmbContrato.DataSource= dsSpx1.contratos;
            cmbContrato.DataTextField = "numeroContrato";
            cmbContrato.DataValueField = "numeroContrato";
            cmbContrato.DataBind();
        }
    }
    protected void rdPorContratoNo_CheckedChanged(object sender, EventArgs e)
    {
        if (rdPorContratoNo.Checked)
        {
            lblNumeroContrato.Visible = false;
            cmbContrato.Visible = false;
        }
    }

    private bool validar()
    {
        lblError.Text = "";
        if (!rdInterna.Checked && !rdExterna.Checked)
        {
                lblError.Text = "Debe especificar si la orden es interna o externa";
                return false;   
        }

        if (rdInterna.Checked)
        {
            if (cmbEntradas.SelectedValue == null || cmbEntradas.SelectedValue.Trim() == string.Empty)
            {
                lblError.Text = "Las ordenes de servicio internas deben estar asociadas a una entrada!";
                return false;
            }
        }

        if (rdPorContrato.Checked)
        {
            if (cmbContrato.SelectedValue == null || cmbContrato.SelectedValue.Trim() == string.Empty)
            {
                lblError.Text = "Las ordenes de servicio por contrato deben especificar el numero de contrato!";
                return false;
            }
        }

        if (!calinicio.SelectedDate.HasValue)
        {
            lblError.Text = "Debe especificar la fecha y hora de inicio de la actividad!";
            return false;
        }

        if (!calFin.SelectedDate.HasValue)
        {
            lblError.Text = "Debe especificar la fecha y hora de fin de la actividad!";
            return false;
        }

        if (calinicio.SelectedDate.Value> calFin.SelectedDate.Value)
        {
            lblError.Text = "La hora de inicio y fin de la actividad no son logicos!";
            return false;
        }
        return true;
    }

    private void crear() 
    {
            

            Nullable<DateTime> fechaProgramacion = new Nullable<DateTime>();
            Nullable<DateTime> fechaFinProgramacion = new Nullable<DateTime>();
            string asignadoA = "";

            asignadoA = cmbResponsable.SelectedValue;
            fechaProgramacion = calinicio.SelectedDate.Value;
            fechaFinProgramacion = calFin.SelectedDate.Value;
                    
                
            

            //creamos la orden de servicio con el manejador de ordenes de servicio
        spProcesos.ordenesTrabajo.cls.osController objC = new spProcesos.ordenesTrabajo.cls.osController();
            int codAsesor = 0;
            if (cmbAsesoresComerciales.SelectedValue != null && cmbAsesoresComerciales.SelectedValue.ToString().Trim() != string.Empty)
            {
                codAsesor = int.Parse(cmbAsesoresComerciales.SelectedValue.ToString());
            }

            int cod = objC.crearOrdenServicio(txtSerial.Text, ((asignadoA == string.Empty) ? "" : asignadoA),
            fechaProgramacion, fechaFinProgramacion, rdInterna.Checked,
            (rdInterna.Checked) ? int.Parse(cmbEntradas.SelectedValue) : 0, cmbTipoServicio.SelectedValue.ToString()
            , int.Parse(cmbPrioridad.SelectedValue.ToString()), txtObservacionesIniciales.Text, "", "",
            "", codAsesor);
            //si es interna actualizamos la entrada
            if (rdInterna.Checked)
            {
                SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter entradaSalidaEquiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.EntradaSalidaEquiposTableAdapter();
                entradaSalidaEquiposTableAdapter1.UpdateCodOrdenServicio(cod, int.Parse(cmbEntradas.SelectedValue));
            }
            //operaciones de contrato
            
            if (rdPorContrato.Checked && cod != 0)
            {
                objC.vincularOrdenContrato(txtSerial.Text, cod);
            }
        }



    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (!validar()) return;
        crear();
        Response.Redirect("frmListado.aspx");
    }
    protected void btnGuardarYCrearOtra_Click(object sender, EventArgs e)
    {
        if (!validar()) return;
        crear();
        Response.Redirect("frmCrearOrden.aspx");
    }
}

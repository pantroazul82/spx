using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPControladoraDatos.dsSpxTableAdapters;
using System.IO;
using SPControladoraDatos;
using System.Runtime.Remoting.Messaging;

namespace Web2020.frm.ordenServicio
{
    public partial class frmReasignar : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["osx"] == null || Request.Params["osx"].Trim() == string.Empty)
            {
                Response.Redirect(@"~/frm/logica/Default.aspx");
            }
            if (!IsPostBack)
            {

                clsSeguridad obS = new clsSeguridad();
                obS.comprobarAcceso(Page, Session, Response, 1054);//
               
                lblOrdenServicio.Text = Request.Params["osx"];
                BOLayer.Usuario0Factory uf = new BOLayer.Usuario0Factory();
                
                BOLayer.Usuario0 usu = uf.Get(os.AsignadoA.Trim());
                //me extraña will
                if (usu != null) {
                    txtIngenieroAsignado.Text = usu.Nombre.Trim() + "(" + os.AsignadoA.Trim() + ")";
                } else {
                    txtIngenieroAsignado.Text = "No asignado";
                }
               /* SPXSeguridad.data.cls.clsTusuario objU = new SPXSeguridad.data.cls.clsTusuario();
                clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);*/

            }
   
        }


        protected void btnREasginar_Click(object sender, EventArgs e) {
            if (cmbIngenieros.selectedValue == null || cmbIngenieros.selectedValue == "-1")
            {
                lblError.Text = "Debe seleccionar un ingeniero";
                return;
            }
          
            reasignacionOrdenesTrabajoTableAdapter reasignacionOrdenesTrabajoTableAdapter1
            int codR = reasignacionOrdenesTrabajoTableAdapter1.verSiguienteId(int.Parse(codOrdenServicio)).Value;
            reasignacionOrdenesTrabajoTableAdapter1.Insert(int.Parse(codOrdenServicio), codR,
                dsSpx1.ordenServicio[0].asignadoA, frmIng.LoginNuevo, n, frmIng.motivoReasignacion,
                SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
            //actualizamos la orden de servicio
            ordenServicioTableAdapter1.UpdateAsignacion(frmIng.LoginNuevo, int.Parse(codOrdenServicio));
            cmbIngeniero.SelectedValue = frmIng.LoginNuevo;
            reasignacionOrdenesTrabajoTableAdapter1.FillByCodOrdenServicio(dsSpx1.reasignacionOrdenesTrabajo, int.Parse(codOrdenServicio));
            #region zona de notificaciones de email
            //CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
            //mailsender.EjecutarAccion(6, frmIng.LoginNuevo, (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            //mailsender.EjecutarAccion(7, frmIng.LoginActual, (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
            if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
                notificacionTableAdapter1.Insert(cmbIngeniero.SelectedValue.ToString(), "Orden de servicio reasignada.",

        Response.Redirect("frmOs.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmOs.aspx");
        }




       

  
       

        
    }
}
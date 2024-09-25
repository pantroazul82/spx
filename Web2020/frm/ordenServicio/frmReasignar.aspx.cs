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
                string sql = @"select top 1 asignadoA,usuario.nombre from ordenServicio
join usuario on usuario.login = asignadoA where codOrdenServicio="+lblOrdenServicio.Text;
                SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();

                var ds= obj.ejecutarConsulta(sql);

                //me extraña will
                if (ds.Tables[0].Rows.Count >0) {
                    txtLoginIngenieroAsignado.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtIngenieroAsignado.Text = ds.Tables[0].Rows[0][1].ToString() + "(" + lblOrdenServicio.Text + ")";
                } else {
                    txtIngenieroAsignado.Text = "No asignado";
                }
                sql = ""; 
                
                SPXSeguridad.data.cls.clsTusuario objU = new SPXSeguridad.data.cls.clsTusuario();
                var ds2= objU.getDataByPermiso( 1063);
                cmbIngenieros.DataSource = ds2;
                cmbIngenieros.DataValueField = "login";
                cmbIngenieros.DataTextField = "nombre";
                cmbIngenieros.DataBind();
            }
   
        }


        protected void btnREasginar_Click(object sender, EventArgs e) {
            if (cmbIngenieros.SelectedValue == null || cmbIngenieros.SelectedValue == "-1")
            {
                lblError.Text = "Debe seleccionar un ingeniero";
                return;
            }
            string creadoPor = Session["ss_cod_usuario"].ToString();
            string sql = @"SELECT isnull(max(codReasignacion),0) + 1 
 FROM reasignacionOrdenesTrabajo
WHERE 
codOrdenServicio = " + lblOrdenServicio.Text;
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();

            var id = obj.ejecutarProcedimiento(sql);

            sql = @"INSERT INTO [reasignacionOrdenesTrabajo] ([codOrdenServicio], [codReasignacion], [loginOriginal]," +
                 " [loginNuevo], [fechaReAsignacion], [motivoReasignacion], [reasignadoPor]) " +
                 "VALUES (" + lblOrdenServicio.Text + "," + id + " ,'" + txtLoginIngenieroAsignado.Text + "' , '"
                 + cmbIngenieros.SelectedValue + "', getdate(), '" + txtMotivoReasignacion.Text + "', '" + Session["ss_login"].ToString() + "')";

            obj.ejecutarComando(sql);
            //actualizamos la orden de servicio
            sql = @"UPDATE [ordenServicio] 
SET 
 [asignadoA] = '"+cmbIngenieros.SelectedValue+@"'
 WHERE (codOrdenServicio = " + lblOrdenServicio.Text+")";

            obj.ejecutarComando(sql);


        Response.Redirect("frmListado.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmListado.aspx");
        }




       

  
       

        
    }
}
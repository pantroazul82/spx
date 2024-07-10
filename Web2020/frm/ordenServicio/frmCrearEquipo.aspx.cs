using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace Web2020.frm.ordenServicio
{
    public partial class frmCrearEquipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verficamos permiso
            clsSeguridad seg = new clsSeguridad();
            seg.comprobarAcceso(Page, Session, Response, 2014);
       

        }


        protected void btnAtrasPaso_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCrearEquipo.aspx");
        }
     



        private void crearEquipo(string serial, string codFabricante, string codModelo , int codTipoPropiedad,  string observaciones,
            string nitCliente, string codSucursal, string codModalidadEquipo , string creadoPor ,DateTime fecha_creacion)
        {

 
            cls.ds2020TableAdapters.equiposTableAdapter objEquipos = new cls.ds2020TableAdapters.equiposTableAdapter();

            objEquipos.Insert(codFabricante, codModelo, serial, null, null, null, null, nitCliente, codSucursal, null, null, codModalidadEquipo, null, null, null, null,
                observaciones, codTipoPropiedad, null, null, null, null, null, null, nitCliente, codSucursal,Convert.ToInt32(creadoPor), fecha_creacion, null, null, null, null, null, null); 

        }

        private bool crear()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSerial1.Text))
                {
                    SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
                    string consultaSerial = @"select serial from equipos where serial ='" + txtSerial1.Text + "'";
                    DataSet resultadoConsulta = obj.ejecutarConsulta(consultaSerial);

                    if (resultadoConsulta == null || (resultadoConsulta.Tables[0].Rows.Count == 0))
                    {
                        string creadoPor = Session["ss_cod_usuario"].ToString();
                        DateTime fechaCreacion = obj.fechaServer;

                        crearEquipo(txtSerial1.Text, cmbFabricante.SelectedValue, cmbModelo.SelectedValue, Convert.ToInt32(cmbTipoPropiedad.SelectedValue), TextBoxObservaciones.Text,
                            cmbClientes.SelectedValue, cmbSucursal.SelectedValue, cmbModalidad.SelectedValue,creadoPor,fechaCreacion);

                        return true;
                    }
                    else
                    {
                        lblErrorSerial.Text = "El serial que ingreso ya existe";
                        return false;

                    }
                }
                else
                {
                    lblErrorSerial.Text = "El serial es indispensable para continuar";
                    return false; 
                }
            }
            catch
            {
                lblErrores.Text = "Ocurrió un error al crear el equipo. Por favor, intente de nuevo más tarde.";
                return false;

            }


        }


        protected void btnGuardar_Click(object sender, EventArgs e)
            {


            if (crear())
            {
                Response.Redirect("frmListado.aspx");
            }
        }
        protected void btnGuardarYCrearOtra_Click(object sender, EventArgs e)
        {
            if (crear())
            {
                Response.Redirect("frmCrearEquipo.aspx");
            }
        }
    }
}
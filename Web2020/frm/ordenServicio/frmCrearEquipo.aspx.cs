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


        /// <summary>
        /// Retorna true si el formulario esta correcto para guardar
        /// </summary>
        /// <returns></returns>
        private bool validar()
        {
            bool respuesta = true;

            string codFabricante = cmbFabricante.SelectedValue;
            string codModelo = cmbModelo.SelectedValue;
            string tipoPropiedad = cmbTipoPropiedad.SelectedValue;
            string cliente = cmbClientes.SelectedValue;
            string sucursal = cmbSucursal.SelectedValue;
            string modalidad = cmbModalidad.SelectedValue;

            // Limpiar etiquetas de error
            lblErrorFabricante.Text = string.Empty;
            lblErrorModelo.Text = string.Empty;
            lblTipoPropiedad.Text = string.Empty;
            lblErrorCliente.Text = string.Empty;
            lblSucursal.Text = string.Empty;
            lblTipoModalidad.Text = string.Empty;

            if (string.IsNullOrEmpty(codFabricante))
            {
                respuesta = false;
                lblErrorFabricante.Text = "El fabricante es obligatorio, si el fabricante se encuentra en blanco asegúrese de crearlo con anterioridad";
            }
            if (string.IsNullOrEmpty(codModelo))
            {
                respuesta = false;
                lblErrorModelo.Text = "El modelo es obligatorio, si el modelo se encuentra en blanco asegúrese de crearlo con anterioridad";
            }
            if (string.IsNullOrEmpty(tipoPropiedad))
            {
                respuesta = false;
                lblTipoPropiedad.Text = "El tipo de propiedad es obligatorio, asegúrese de que exista";
            }
            if (string.IsNullOrEmpty(cliente))
            {
                respuesta = false;
                lblErrorCliente.Text = "El cliente es obligatorio, si no hay un cliente asegúrese de que exista";
            }
            if (string.IsNullOrEmpty(sucursal))
            {
                respuesta = false;
                lblSucursal.Text = "La sucursal es obligatoria, asegúrese de que exista";
            }
            if (string.IsNullOrEmpty(modalidad))
            {
                respuesta = false;
                lblTipoModalidad.Text = "La modalidad es obligatoria, asegúrese de que exista";
            }

            return respuesta;
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
                        string codFabricante = cmbFabricante.SelectedValue;
                        string codModelo = cmbModelo.SelectedValue;


                        if(validar())
                        {
                            crearEquipo(txtSerial1.Text, codFabricante, codModelo, Convert.ToInt32(cmbTipoPropiedad.SelectedValue), TextBoxObservaciones.Text,
                            cmbClientes.SelectedValue, cmbSucursal.SelectedValue, cmbModalidad.SelectedValue, creadoPor, fechaCreacion);
                            return true;

                        }
                        else
                        {
                            lblErrores.Text = "Ocurrió un error al crear el equipo, falta información necesaria.";

                        }



                        return false;
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
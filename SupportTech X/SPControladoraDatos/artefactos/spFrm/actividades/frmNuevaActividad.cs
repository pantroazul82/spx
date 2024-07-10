using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.actividades
{
    public partial class frmNuevaActividad : Form
    {
        public frmNuevaActividad()
        {
            InitializeComponent();
        }
        public int codActividad { set; get; }

        public bool editable = true;

        private void frmNuevaActividad_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            clsTusuario1.Fill(dsSPXSeguridad1.usuario);
            tipo_actividadTableAdapter1.Fill(dsSpx1.tipo_actividad);
            cmbIngeniero.SelectedValue = "-1";
            cmbTipoActividad.SelectedValue = -1;
            calFechaInicio.fechaValue = n;
            calFechaFin.fechaValue = n;
            dsSpx1.EnforceConstraints = false;
            if (codActividad != 0)
            {
                actividad_adicionalTableAdapter1.FillBycod_actividad_adicional(dsSpx1.actividad_adicional, codActividad);
                cmbIngeniero.Enabled = false;
                cmbIngeniero.SelectedValue = dsSpx1.actividad_adicional[0].login;
                cmbTipoActividad.SelectedValue=dsSpx1.actividad_adicional[0].cod_tipo_actividad;
                txtActividad.Text = dsSpx1.actividad_adicional[0].nombre_actividad;
                txtDescripcion.Text = dsSpx1.actividad_adicional[0].descripcion_actividad;
                txtUbicacion.Text = dsSpx1.actividad_adicional[0].ubicacion;
                calFechaInicio.fechaValue = dsSpx1.actividad_adicional[0].fecha_inicio;
                calFechaFin.fechaValue = dsSpx1.actividad_adicional[0].fecha_fin;
            }
            if (!editable)
            {
                txtActividad.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                txtUbicacion.ReadOnly = true;
                cmbIngeniero.Enabled = false;
                cmbTipoActividad.Enabled = false;
                calFechaFin.Enabled = false;
                calFechaInicio.Enabled = false;
                btnAceptar.Visible = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!validar())return;
            if (codActividad == 0)
            {
                actividad_adicionalTableAdapter1.Insert(calFechaInicio.fechaValue,calFechaFin.fechaValue,
                    txtActividad.Text, txtDescripcion.Text, txtUbicacion.Text, int.Parse(cmbTipoActividad.SelectedValue.ToString()),
                    cmbIngeniero.SelectedValue.ToString());
            }
            else {
                actividad_adicionalTableAdapter1.UpdateQuery(calFechaInicio.fechaValue, calFechaFin.fechaValue,
                        txtActividad.Text, txtDescripcion.Text, txtUbicacion.Text, int.Parse(cmbTipoActividad.SelectedValue.ToString()),
                    codActividad);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool validar() 
        {
            if (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione un ingeniero");
                return false;
            }
            if (cmbTipoActividad.SelectedValue == null || cmbTipoActividad.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione un tipo de actividad");
                return false;
            }

            if (calFechaInicio.fechaValueObject == null || calFechaFin.fechaValueObject == null)
            {
                MessageBox.Show("Seleccione fechas validas");
                return false;
            }
            if (calFechaInicio.fechaValue > calFechaFin.fechaValue)
            {
                MessageBox.Show("La fecha de inicio no puede ser despues que la de fin!!!");
                return false;
            }
            
            return true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

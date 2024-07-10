using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmRepuestoxContrato : Form
    {
        public frmRepuestoxContrato()
        {
            InitializeComponent();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            dtxtRepuesto.CadenaConexion = obj.CadenaConexion;
        }

        private void dataText1_Load(object sender, EventArgs e)
        {

        }

        public int cantidad { get { return (int)nmCantidad.Value;} set{nmCantidad.Value=(decimal)value;}}
        public string codigoRepuesto{set{dtxtRepuesto.Text = value;}get{return dtxtRepuesto.Text;}}
        public string observaciones { set { txtObservaciones.Text = value; } get { return txtObservaciones.Text; } }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmRepuesto_Load(object sender, EventArgs e)
        {
            
        }

        private bool validar() 
        {
            if (nmCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0");
                nmCantidad.Focus();
                return false;
            }
            if (dtxtRepuesto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("el codigo del repuesto es obligatorio");
                dtxtRepuesto.Focus();
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
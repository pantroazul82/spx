using SPControladoraDatos.artefactos;
using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPX2019.artefactos.SPXdata.frm.cnn
{
    public partial class frmConfigurarPostgress : Form
    {
        #region zona de campos y propiedades
        public DataConector.tipoMotor tipo { set; get; }
        public string nombreConexion { set; get; }
        public string login { set; get; }
        public string password { set; get; }
        public string servidor { set; get; }
        public string baseDatos { set; get; }
        public string puerto { set; get; }
        public string sid { set; get; }
        public bool conexionDirecta { set; get; }
        public DataConector.tipoCnnOracle _tipoCnnOracle { set; get; }
        public int time_out { set; get; }
        #endregion
        public frmConfigurarPostgress()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre de la conexion es obligatorio");
                txtName.Focus();
                return;
            }
            if (txtServer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre del servidor es obligatorio");
                txtServer.Focus();
                return;
            }
            if (cmbBaseDeDatos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La base de datos es obligatoria.");
                cmbBaseDeDatos.Focus();
                return;
            }
            //
            this.puerto = txtPuerto.Text;
            password = txtPass.Text;
            nombreConexion = txtName.Text;
            servidor = txtServer.Text;
            login = txtUser.Text;
            baseDatos = cmbBaseDeDatos.Text;
            //
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            #region probando la conexion
           DataConector con = new DataConector();

            string cnn = con.generarCadenaConexion(false,DataConector.tipoMotor.postgress,
                txtUser.Text, txtPass.Text, txtServer.Text, cmbBaseDeDatos.Text.Trim(),
                txtPuerto.Text, cmbBaseDeDatos.Text, false,DataConector.tipoCnnOracle.normal);

            con.CadenaConexion = cnn;


            if (!con.probarConexion())
            {
                MessageBox.Show("Error no se pudo conectar con el servidor.", "Conexion no Valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conexion Satisfactoria.");
            }
            #endregion
        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar > 20 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbBaseDeDatos_Enter(object sender, EventArgs e)
        {
           DataConector con = new DataConector();

            string cnn = con.generarCadenaConexion(false,DataConector.tipoMotor.postgress,
                txtUser.Text, txtPass.Text, txtServer.Text, "",txtPuerto.Text, "", false,DataConector.tipoCnnOracle.normal);

            con.CadenaConexion = cnn;

            if (con.probarConexion())
            {
                System.Data.DataSet ds = new DataSet();
                ds = con.ejecutarConsulta("show databases");
                this.cmbBaseDeDatos.DataSource = ds.Tables[0];
                this.cmbBaseDeDatos.DisplayMember = ds.Tables[0].Columns[0].ColumnName;
                cmbBaseDeDatos.ValueMember = ds.Tables[0].Columns[0].ColumnName;
            }
        }

        private void frmConfigurarPostgress_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);

            txtPuerto.Text = this.puerto;
            txtPass.Text = password;
            txtName.Text = nombreConexion;
            txtServer.Text = servidor;
            txtUser.Text = login;
            cmbBaseDeDatos.Text = baseDatos;
            if (txtPuerto.Text.Trim() == string.Empty)
            {
                txtPuerto.Text = "3306";
            }
        }
    }
}

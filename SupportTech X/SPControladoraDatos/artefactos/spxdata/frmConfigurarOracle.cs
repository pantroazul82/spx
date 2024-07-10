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

namespace SPControladoraDatos.artefactos.SPX2019.artefactos.SPXdata.frm.cnn
{
    public partial class frmConfigurarOracle : Form
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
        public frmConfigurarOracle()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

            sid=txtSid.Text;
            switch (cmbConectarCOmo.Text)
            {
                case "NORMAL": { _tipoCnnOracle =DataConector.tipoCnnOracle.normal; break; }
                case "SYSDBA": {_tipoCnnOracle  =DataConector.tipoCnnOracle.sysdba; break; }
                case "SYSOPER": {_tipoCnnOracle =DataConector.tipoCnnOracle.sysoper; break; }
            }
            
          
            conexionDirecta=chkConexionDirecta.Checked;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            #region probando la conexion
           DataConector con = new DataConector();
           DataConector.tipoCnnOracle t =DataConector.tipoCnnOracle.normal;
            switch (cmbConectarCOmo.Text)
            {
                case "NORMAL": { t =DataConector.tipoCnnOracle.normal; break; }
                case "SYSDBA": { t =DataConector.tipoCnnOracle.sysdba; break; }
                case "SYSOPER": { t =DataConector.tipoCnnOracle.sysoper; break; }
            }
            string cnn = con.generarCadenaConexion(false,DataConector.tipoMotor.oracle,
                txtUser.Text, txtPass.Text, txtServer.Text, cmbBaseDeDatos.Text, txtPuerto.Text, txtSid.Text, chkConexionDirecta.Checked, t);

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
           DataConector.tipoCnnOracle t =DataConector.tipoCnnOracle.normal;
            switch (cmbConectarCOmo.Text)
            {
                case "NORMAL": { t=DataConector.tipoCnnOracle.normal; break; }
                case "SYSDBA": { t =DataConector.tipoCnnOracle.sysdba; break; }
                case "SYSOPER": { t =DataConector.tipoCnnOracle.sysoper; break; }
            }
            string cnn = con.generarCadenaConexion(false,DataConector.tipoMotor.oracle,
                txtUser.Text, txtPass.Text, txtServer.Text, "", txtPuerto.Text, txtSid.Text, chkConexionDirecta.Checked, t);

            con.CadenaConexion = cnn;

            if (con.probarConexion())
            {
                System.Data.DataSet ds = new DataSet();
              //pendiente averiguar la sentencia en oracle
               // ds = con.ejecutarConsulta("select name from master.dbo.[sysdatabases]");
               // this.cmbBaseDeDatos.DataSource = ds.Tables[0];
               // this.cmbBaseDeDatos.DisplayMember = "name";
               // cmbBaseDeDatos.ValueMember = "name";
            }
        }

        private void frmConfigurarOracle_Load(object sender, EventArgs e)
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
            txtSid.Text = sid;
            switch (_tipoCnnOracle)
            {
                case DataConector.tipoCnnOracle.normal: { cmbConectarCOmo.Text = "NORMAL"; break; }
                case DataConector.tipoCnnOracle.sysdba: { cmbConectarCOmo.Text = "SYSDBA"; break; }
                case DataConector.tipoCnnOracle.sysoper: { cmbConectarCOmo.Text = "SYSOPER"; break; }
            }
            chkConexionDirecta.Checked = conexionDirecta;
            if (txtPuerto.Text.Trim() == string.Empty)
            {
                txtPuerto.Text = "1433";
            }
        }
    }
}

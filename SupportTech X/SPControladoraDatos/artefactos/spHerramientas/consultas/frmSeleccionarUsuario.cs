using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spHerramientas.consultas
{
    public partial class frmSeleccionarUsuario : Form
    {
        public frmSeleccionarUsuario()
        {
            InitializeComponent();
        }

        public string login { set; get; }
        //public int codUsuario { set; get; }

        private void frmSeleccionarUsuario_Load(object sender, EventArgs e)
        {
            string sql = "select login,nombre from usuario order by nombre";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            cmbUsuario.DataSource = bd.ejecutarConsulta(sql).Tables[0];
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.ValueMember = "login";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            login = cmbUsuario.SelectedValue.ToString();
            // codUsuario = int.Parse(cmbUsuario.SelectedValue.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

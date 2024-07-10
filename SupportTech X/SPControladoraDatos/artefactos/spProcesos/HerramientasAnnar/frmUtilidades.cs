using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.HerramientasAnnar
{
    public partial class frmUtilidades : Form
    {
        public frmUtilidades()
        {
            InitializeComponent();
        }

        private void frmUtilidades_Load(object sender, EventArgs e)
        {

        }

        private void btnImportarProblemas_Click(object sender, EventArgs e)
        {
            frmImportadorProblemas fr = new frmImportadorProblemas();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
            //
            }
        }

        private void btnSeguimientoEspecial_Click(object sender, EventArgs e)
        {
            frmSeguimientoEspecial fr = new frmSeguimientoEspecial();
            fr.Show();
        }
    }
}

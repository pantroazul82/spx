using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmImpresion : Form
    {
        public frmImpresion()
        {
            InitializeComponent();
        }

        int opcion = 0;
        public int Opcion { set { opcion = value; } get { return opcion; } }
        int codOrdenServicio = 0;
        public int CodOrdenServicio { set { codOrdenServicio = value; } get { return codOrdenServicio; } }

        private void frmImpresion_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int op = 0;
            if (rdReporteServicio.Checked)
            {
                //verificamos que este en un estado donde se pueda imprimir
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                ds.EnforceConstraints = false;
                ordenServicioTableAdapter1.FillByCodOrdenServicio(ds.ordenServicio,codOrdenServicio);


                string a =ds.ordenServicio[0].codEstadoOrdenServicio.Trim().ToUpper();
                
                if (a == "ACEPT" || a == "NUEVA")
                {
                    a = estadosOrdenServicioTableAdapter1.verNombre(a);
                    MessageBox.Show("no se puede imprimir una orden de servicio cuando esta en estado "+a.ToString());
                    return;
                }
                op = 2;
            }
            else if (rdimpOS.Checked) { op = 1; }
            else if (rdCompleta.Checked) { op = 3; }
            opcion =op;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

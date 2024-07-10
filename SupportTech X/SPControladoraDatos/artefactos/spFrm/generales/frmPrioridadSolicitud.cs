using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmPrioridadSolicitud : CgDataFrm.frmModeloDos
    {
        public frmPrioridadSolicitud()
        {
            InitializeComponent();
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodigo.Text = prioridadSolicitudTableAdapter1.verNextId().Value.ToString();
        }

        private void frmPrioridadSolicitud_Load(object sender, EventArgs e)
        {
            prioridadSolicitudTableAdapter1.Fill(dsSpx1.prioridadSolicitud);
            cgDataControler1.TableAdapter = prioridadSolicitudTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "prioridadSolicitud"] as CurrencyManager);
        }
    }
}

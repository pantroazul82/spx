using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmMediosSolicitud : CgDataFrm.frmModeloDos
    {
        public frmMediosSolicitud()
        {
            InitializeComponent();
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodigo.Text = medioSolicitudTableAdapter1.verNextId().Value.ToString();
        }

        private void frmMediosSolicitud_Load(object sender, EventArgs e)
        {
            medioSolicitudTableAdapter1.Fill(dsSpx1.medioSolicitud);
            cgDataControler1.TableAdapter = medioSolicitudTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "medioSolicitud"] as CurrencyManager);
        }
    }
}

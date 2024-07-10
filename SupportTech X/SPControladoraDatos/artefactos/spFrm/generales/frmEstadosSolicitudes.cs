using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmEstadosSolicitudes : CgDataFrm.frmModeloDos
    {
        public frmEstadosSolicitudes()
        {
            InitializeComponent();
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodigo.Text = estadosSolicitudTableAdapter1.verNextId().Value.ToString();
        }

        private void frmEstadosSolicitudes_Load(object sender, EventArgs e)
        {
            estadosSolicitudTableAdapter1.Fill(dsSpx1.estadosSolicitud);
            cgDataControler1.TableAdapter = estadosSolicitudTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "estadosSolicitud"] as CurrencyManager);
        }
    }
}

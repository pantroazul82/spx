using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.terceros
{
    public partial class frmTransportadora : CgDataFrm.frmModelo
    {
        public frmTransportadora()
        {
            InitializeComponent();
        }

        private void frmTransportadora_Load(object sender, EventArgs e)
        {
            cgDataControler1.TableAdapter= transportadoraTableAdapter1;
            transportadoraTableAdapter1.Fill(dsSpx1.transportadora);
            cgDataControler1.cmTabla =( BindingContext[dsSpx1,"transportadora"] as CurrencyManager);
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            txtCodTrans.Text = transportadoraTableAdapter1.verNextId().Value.ToString();
            txtCodTrans.Enabled = false;
        }
    }
}

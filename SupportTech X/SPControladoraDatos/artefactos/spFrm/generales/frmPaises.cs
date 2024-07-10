using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmPaises : CgDataFrm.frmModelo
    {
        public frmPaises()
        {
            InitializeComponent();
        }

        private void frmPaises_Load(object sender, EventArgs e)
        {
            paisesTableAdapter1.Fill(dsSpx1.paises);
            cgDataControler1.TableAdapter = paisesTableAdapter1;

            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "paises"] as CurrencyManager);
        }
    }
}


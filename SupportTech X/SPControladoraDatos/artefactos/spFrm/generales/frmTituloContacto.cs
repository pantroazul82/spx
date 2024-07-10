using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmTituloContacto : CgDataFrm.frmModelo
    {
        public frmTituloContacto()
        {
            InitializeComponent();
        }

        private void frmTituloContacto_Load(object sender, EventArgs e)
        {
            tituloContactoTableAdapter1.Fill(dsSpx1.tituloContacto);
            cgDataControler1.TableAdapter = tituloContactoTableAdapter1;

            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "tituloContacto"] as CurrencyManager);
        }
    }
}


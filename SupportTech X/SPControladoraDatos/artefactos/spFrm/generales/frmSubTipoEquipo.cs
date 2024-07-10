using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmSubTipoEquipo : CgDataFrm.frmModelo
    {
        public frmSubTipoEquipo()
        {
            InitializeComponent();
        }

        private void frmSubTipoEquipo_Load(object sender, EventArgs e)
        {
            tipoEquipoTableAdapter1.Fill(dsSpx1.tipoEquipo);
            subTipoEquipoTableAdapter1.Fill(dsSpx1.subTipoEquipo);
            cgDataControler1.TableAdapter = subTipoEquipoTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "subTipoEquipo"] as CurrencyManager);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmEstadoFisicamente : CgDataFrm.frmModeloDos
    {
        public frmEstadoFisicamente()
        {
            InitializeComponent();
        }

        private void frmEstadoFisicamente_Load(object sender, EventArgs e)
        {

            cgDataControler1.TableAdapter = estadoFisicamenteTableAdapter1;
            estadoFisicamenteTableAdapter1.Fill(dsSpx1.EstadoFisicamente);
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "EstadoFisicamente"] as CurrencyManager);
        }
    }
}


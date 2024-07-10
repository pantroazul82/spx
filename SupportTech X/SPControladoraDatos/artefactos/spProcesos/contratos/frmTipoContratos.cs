using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmTipoContratos : CgDataFrm.frmModelo
    {
        public frmTipoContratos()
        {
            InitializeComponent();
        }

        private void frmTipoContratos_Load(object sender, EventArgs e)
        {
            cgDataControler1.TableAdapter = tipoContratoTableAdapter1;
            tipoContratoTableAdapter1.Fill(dsSpx1.tipoContrato);
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "tipoContrato"] as CurrencyManager);
        }
    }
}


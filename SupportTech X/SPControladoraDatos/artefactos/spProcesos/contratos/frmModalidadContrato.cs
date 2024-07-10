using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos
{
    public partial class frmModalidadContrato : CgDataFrm.frmModeloDos
    {
        public frmModalidadContrato()
        {
            InitializeComponent();
        }

        private void frmModalidadContrato_Load(object sender, EventArgs e)
        {
            tipoContratoTableAdapter1.Fill(dsSpx1.tipoContrato);
            tipoContratoTableAdapter1.Fill(dsSpx2.tipoContrato);
            cgDataControler1.TableAdapter = modalidadContratoTableAdapter1;
             modalidadContratoTableAdapter1.Fill(dsSpx1.modalidadContrato);
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "modalidadContrato"] as CurrencyManager);
        }
    }
}

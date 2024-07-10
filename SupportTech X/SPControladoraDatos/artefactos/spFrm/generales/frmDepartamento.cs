using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmDepartamento : CgDataFrm.frmModelo
    {
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            paisesTableAdapter1.Fill(dsSpx1.paises);
            departamentoTableAdapter1.Fill(dsSpx1.departamento);
            

            cgDataControler1.TableAdapter = departamentoTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "departamento"] as CurrencyManager);
        }
    }
}


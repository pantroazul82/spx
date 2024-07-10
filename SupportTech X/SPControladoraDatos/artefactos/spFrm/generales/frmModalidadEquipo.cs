using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmModalidadEquipo : CgDataFrm.frmModelo
    {
        public frmModalidadEquipo()
        {
            InitializeComponent();
        }

        private void frmModalidadEquipo_Load(object sender, EventArgs e)
        {
            cgDataControler1.TableAdapter = modalidadEquipoTableAdapter1;
            modalidadEquipoTableAdapter1.Fill(dsSpx1.ModalidadEquipo);

            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "ModalidadEquipo"] as CurrencyManager);
        }
    }
}


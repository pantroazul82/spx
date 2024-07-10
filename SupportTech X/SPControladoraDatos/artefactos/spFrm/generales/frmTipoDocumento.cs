using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmTipoDocumento : CgDataFrm.frmModelo
    {
        public frmTipoDocumento()
        {
            InitializeComponent();
        }

        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {
            tipoDocumentoTableAdapter1.Fill(dsSpx1.tipoDocumento);
            cgDataControler1.TableAdapter = tipoDocumentoTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "tipoDocumento"] as CurrencyManager);
        }
    }
}


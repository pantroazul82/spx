using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmTipoPropiedad : CgDataFrm.frmModelo
    {
        public frmTipoPropiedad()
        {
            InitializeComponent();
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            txtCodigo.Text = tipoPropiedadTableAdapter1.verNextId().Value.ToString();
            txtCodigo.ReadOnly = true;
        }

        private void frmTipoPropiedad_Load(object sender, EventArgs e)
        {
            tipoPropiedadTableAdapter1.Fill(dsSpx1.tipoPropiedad);
            cgDataControler1.TableAdapter = tipoPropiedadTableAdapter1;
            cgDataControler1.cmTabla = (BindingContext[dsSpx1,"tipoPropiedad"] as CurrencyManager); 
        }
    }
}

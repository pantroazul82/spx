using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmRazonesNoRenovacion : Form
    {
        public frmRazonesNoRenovacion()
        {
            InitializeComponent();
        }

        public int codRazonNoRenovacion{ set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRazones.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese la razon de no renovacion");
                return;
            }

          
            if (codRazonNoRenovacion == 0)
            {
                razon_no_vigenteTableAdapter1.Insert(txtRazones.Text);
            }
            else {
                razon_no_vigenteTableAdapter1.UpdateQuery(txtRazones.Text, codRazonNoRenovacion);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmConsumibles_Load(object sender, EventArgs e)
        {
            if (codRazonNoRenovacion != 0)
            {
                razon_no_vigenteTableAdapter1.FillBycod_razon_no_vigente(dsContratoConsumo1.razon_no_vigente, codRazonNoRenovacion);
                txtRazones.Text = dsContratoConsumo1.razon_no_vigente[0].nombre_razon_no_vigente.Trim();
              
            }
        }

     
    }
}

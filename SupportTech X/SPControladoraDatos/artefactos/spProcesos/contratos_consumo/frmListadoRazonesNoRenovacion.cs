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
    public partial class frmListadoRazonesNoRenovacion : Form
    {
        public frmListadoRazonesNoRenovacion()
        {
            InitializeComponent();
        }

        private void frmListadoConsumibles_Load(object sender, EventArgs e)
        {
            razon_no_vigenteTableAdapter1.Fill(dsContratoConsumo1.razon_no_vigente);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRazonesNoRenovacion fr = new frmRazonesNoRenovacion();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                razon_no_vigenteTableAdapter1.Fill(dsContratoConsumo1.razon_no_vigente);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_razon_no_vigente"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmRazonesNoRenovacion fr = new frmRazonesNoRenovacion();
            fr.codRazonNoRenovacion = int.Parse(grdDatos.Columns["cod_razon_no_vigente"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                razon_no_vigenteTableAdapter1.Fill(dsContratoConsumo1.razon_no_vigente);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_razon_no_vigente"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    razon_no_vigenteTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_razon_no_vigente"].Text));
                    razon_no_vigenteTableAdapter1.Fill(dsContratoConsumo1.razon_no_vigente);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmActividadesxModelo : CgDataFrm.frmModelo
    {
        public frmActividadesxModelo()
        {
            InitializeComponent();
        }

        private void frmActividadesxModelo_Load(object sender, EventArgs e)
        {
            cargando = true;
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            modelosTableAdapter1.FillByComboBox(dsSpx1.Modelos);
            cgDataControler1.TableAdapter = actividadesxModeloTableAdapter1;

            actividadesxModeloTableAdapter1.Fill(dsSpx1.ActividadesxModelo);
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "ActividadesxModelo"] as CurrencyManager);
            cargando = false;
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            txtCodActividad.Text = "1";
            txtCodActividad.ReadOnly = true;
        }
        bool cargando = false;
        bool guardando = false;
        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            cargarModelos();
        }

        private void cargarModelos()
        {
            if (cmbFabricante.SelectedValue != null && cmbFabricante.SelectedValue.ToString().Trim() != string.Empty)
            {
                if (!guardando)
                {
                    modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx1.Modelos, cmbFabricante.SelectedValue.ToString());
                    if (dsSpx1.Modelos.Rows.Count > 0 && (!txtCodActividad.ReadOnly && txtCodActividad.Enabled))
                        cmbModelo.SelectedIndex = 0;
                    //ahora ponemos el combo segun loq eu exista en los datos
                    if (cgDataControler1.verValor("codModelo") != null)
                        cmbModelo.SelectedValue = cgDataControler1.verValor("codModelo");
                }
            }
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString() == string.Empty) return;
            if (cmbModelo.SelectedValue == null || cmbModelo.SelectedValue.ToString() == string.Empty) return;
            txtCodActividad.Text = actividadesxModeloTableAdapter1.verNextId(cmbFabricante.SelectedValue.ToString(),
                cmbModelo.SelectedValue.ToString()).ToString();
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {

        }
    }
}

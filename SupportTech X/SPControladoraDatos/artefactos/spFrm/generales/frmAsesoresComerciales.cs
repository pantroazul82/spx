using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmAsesoresComerciales : CgDataFrm.frmModelo
    {
        public frmAsesoresComerciales()
        {
            InitializeComponent();
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            txtCodAsesor.Enabled = false;
            txtCodAsesor.Text = asesoresComercialesTableAdapter1.verNextId().Value.ToString();
        }

        private void frmAsesoresComerciales_Load(object sender, EventArgs e)
        {
            asesoresComercialesTableAdapter1.Fill(dsSpx1.asesoresComerciales);
            cgDataControler1.TableAdapter = asesoresComercialesTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "asesoresComerciales"] as CurrencyManager);

        }

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            chkActivo.Enabled = cgDataControler1.EstadoControles;
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            cgDataControler1.asignarValor("activo",chkActivo.Checked);
        }

        private void txtCodAsesor_TextChanged(object sender, EventArgs e)
        {
            if (!txtCodAsesor.ReadOnly || txtCodAsesor.Enabled) return;
            object valor = cgDataControler1.verValor("activo");
            if (valor != null && valor != System.DBNull.Value)
            {
                chkActivo.Checked = (bool)valor;
            }else {
                chkActivo.Checked = false;
            }
        }
    }
}

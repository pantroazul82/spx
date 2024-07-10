using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class FrmCiudades : CgDataFrm.frmModelo
    {
        public FrmCiudades()
        {
            InitializeComponent();
        }

        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            paisesTableAdapter1.Fill(dsSpx1.paises);
            departamentoTableAdapter1.Fill(dsSpx1.departamento);
            cargarDepartamento();
            ciudadesTableAdapter1.Fill(dsSpx1.ciudades);
         
            cgDataControler1.TableAdapter = ciudadesTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "ciudades"] as CurrencyManager);
        }
        private void cargarDepartamento() 
        {
        if (cmbPais.SelectedValue != null && cmbPais.SelectedValue.ToString().Trim() != string.Empty)
            {
                departamentoTableAdapter1.FillByCodigoPais(dsSpx2.departamento, cmbPais.SelectedValue.ToString());
            }
        }
        
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamento();
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            cgDataControler1.asignarValor("codDepartamento", cmbDepartamento.SelectedValue);
        }        
    }
}


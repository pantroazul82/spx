using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmPrioridadesOrdenServicio : CgDataFrm.frmModeloDos
    {
        public frmPrioridadesOrdenServicio()
        {
            InitializeComponent();
        }

        private void frmPrioridadesOrdenServicio_Load(object sender, EventArgs e)
        {
            cgDataControler1.TableAdapter = prioridadesOrdenServicioTableAdapter1;
            prioridadesOrdenServicioTableAdapter1.Fill(dsSpx1.prioridadesOrdenServicio);
            cgDataControler1.cmTabla = (BindingContext[dsSpx1,"prioridadesOrdenServicio"] as CurrencyManager);
        }

        private void cgDataControler1_AntesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
           
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
 txtCodigo.Text = prioridadesOrdenServicioTableAdapter1.verNextId().Value.ToString();
 txtCodigo.ReadOnly = true;
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            cgDataControler1.asignarValor("esOrdenInterna", chkordenInterna.Checked);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly || !txtCodigo.Enabled)
            {
                try
                {
                    if (cgDataControler1.verValor("esOrdenInterna") != null)
                    {
                        chkordenInterna.Checked = bool.Parse(cgDataControler1.verValor("esOrdenInterna").ToString());
                    }
                }catch(Exception){}
            }
        }

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            chkordenInterna.Enabled = cgDataControler1.EstadoControles;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.actividades
{
    public partial class frmTipoACtividad : CgDataFrm.frmModelo
    {
        public frmTipoACtividad()
        {
            InitializeComponent();
        }

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
      
        }

        private void frmTipoACtividad_Load(object sender, EventArgs e)
        {
            tipo_actividadTableAdapter1.Fill(dsSpx1.tipo_actividad);
            cgDataControler1.TableAdapter = tipo_actividadTableAdapter1;
            cgDataControler1.cmTabla= (this.BindingContext[dsSpx1,"tipo_actividad" ] as CurrencyManager);
        }
    }
}

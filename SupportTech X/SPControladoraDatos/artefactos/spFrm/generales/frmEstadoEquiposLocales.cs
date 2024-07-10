using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmEstadoEquiposLocales : CgDataFrm.frmModelo
    {
        public frmEstadoEquiposLocales()
        {
            InitializeComponent();
        }

        private void frmEstadoEquiposLocales_Load(object sender, EventArgs e)
        {
            cgDataControler1.TableAdapter = estadoLocalEquiposTableAdapter1;
            estadoLocalEquiposTableAdapter1.Fill(dsSpx1.estadoLocalEquipos);
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "estadoLocalEquipos"] as CurrencyManager);
        }
    }
}


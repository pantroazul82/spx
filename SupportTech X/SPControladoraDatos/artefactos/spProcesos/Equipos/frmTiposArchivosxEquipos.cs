using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmTiposArchivosxEquipos : CgDataFrm.frmModelo
    {
        public frmTiposArchivosxEquipos()
        {
            InitializeComponent();
        }

        private void frmTiposArchivosxEquipos_Load(object sender, EventArgs e)
        {
            cgDataControler1.TableAdapter = tiposArchivoXequipoTableAdapter1;
            tiposArchivoXequipoTableAdapter1.Fill(dsSpx1.TiposArchivoXequipo);
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "TiposArchivoXequipo"] as CurrencyManager);
        }
    }
}


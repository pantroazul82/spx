using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmTipoEquipo : CgDataFrm.frmModelo
    {
        public frmTipoEquipo()
        {
            InitializeComponent();
        }

        private void frmTipoEquipo_Load(object sender, EventArgs e)
        {
            cgDataControler1.TableAdapter = tipoEquipoTableAdapter1;
            tipoEquipoTableAdapter1.Fill(dsSpx1.tipoEquipo);
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "tipoEquipo"] as CurrencyManager);
        }

        private void txtCodigoTipo_TextChanged(object sender, EventArgs e)
        {
            if (!txtCodigoTipo.ReadOnly && txtCodigoTipo.Enabled) return;

            object dispositivoMedicion = cgDataControler1.verValor("dispositivo_medicion");
            object dispositivoMedible = cgDataControler1.verValor("dispositivo_medible");
            object omite_aprobacion_os = cgDataControler1.verValor("omite_aprobacion_os");

            chkDispositivoMedible.Checked = false;
            chkDispostivioMedicion.Checked = false;
            chkOmiteAprobacion.Checked = false;

            if (dispositivoMedicion != null && dispositivoMedicion != System.DBNull.Value)
            {
                chkDispostivioMedicion.Checked = bool.Parse(dispositivoMedicion.ToString());
            }

            if (dispositivoMedible != null && dispositivoMedible != System.DBNull.Value)
            {
                chkDispositivoMedible.Checked = bool.Parse(dispositivoMedible.ToString());
            }

            if (omite_aprobacion_os != null && omite_aprobacion_os != System.DBNull.Value)
            {
                chkOmiteAprobacion.Checked = bool.Parse(omite_aprobacion_os.ToString());
            }
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            cgDataControler1.asignarValor("dispositivo_medicion",chkDispostivioMedicion.Checked);
            cgDataControler1.asignarValor("dispositivo_medible",chkDispositivoMedible.Checked);
            cgDataControler1.asignarValor("omite_aprobacion_os", chkOmiteAprobacion.Checked);
        }

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            chkDispositivoMedible.Enabled = cgDataControler1.EstadoControles;
            chkDispostivioMedicion.Enabled = cgDataControler1.EstadoControles;
            chkOmiteAprobacion.Enabled = cgDataControler1.EstadoControles;
        }
    }
}


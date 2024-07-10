using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.rptServicios
{
    public partial class frmTipoServicio : CgDataFrm.frmModelo
    {
        public frmTipoServicio()
        {
            InitializeComponent();
        }

        private void frmTipoServicio_Load(object sender, EventArgs e)
        {
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            cgDataControler1.TableAdapter = tipoServicioTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "TipoServicio"] as CurrencyManager);
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            cgDataControler1.asignarValor("devuelveTaller", chkVuelve.Checked ? 1 : 0);
            cgDataControler1.asignarValor("devuelveEntrada", chkDevuelvenEntrada.Checked ? 1 : 0);
            cgDataControler1.asignarValor("validoContrato", chkServicioValidoContrato.Checked ? 1 : 0);
            cgDataControler1.asignarValor("preventivo", chkServicioPreventivo.Checked ? 1 : 0);
            cgDataControler1.asignarValor("correctivo", chkCorrectivo.Checked ? 1 : 0);
            cgDataControler1.asignarValor("omite_aprobacion_os", chkOmiteAprobacion.Checked ? 1 : 0);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly || !txtCodigo.Enabled)
            {
                chkCorrectivo.Checked = false;
                chkServicioPreventivo.Checked = false;
                chkServicioValidoContrato.Checked = false;
                chkVuelve.Checked = false;
                chkDevuelvenEntrada.Checked = false;
                chkOmiteAprobacion.Checked = false;

                if (cgDataControler1.verValor("devuelveEntrada") != null && cgDataControler1.verValor("devuelveEntrada") != System.DBNull.Value)
                {
                    chkDevuelvenEntrada.Checked = bool.Parse(cgDataControler1.verValor("devuelveEntrada").ToString());
                }
                if (cgDataControler1.verValor("devuelveTaller") != null && cgDataControler1.verValor("devuelveTaller") != System.DBNull.Value)
                {
                    chkVuelve.Checked = bool.Parse(cgDataControler1.verValor("devuelveTaller").ToString());
                }
                if (cgDataControler1.verValor("validoContrato") != null && cgDataControler1.verValor("validoContrato") != System.DBNull.Value)
                {
                    chkServicioValidoContrato.Checked = bool.Parse(cgDataControler1.verValor("validoContrato").ToString());
                }
                if (cgDataControler1.verValor("preventivo") != null && cgDataControler1.verValor("preventivo") != System.DBNull.Value)
                {
                    chkServicioPreventivo.Checked = bool.Parse(cgDataControler1.verValor("preventivo").ToString());
                }
                if (cgDataControler1.verValor("correctivo") != null && cgDataControler1.verValor("correctivo") != System.DBNull.Value)
                {
                    chkCorrectivo.Checked = bool.Parse(cgDataControler1.verValor("correctivo").ToString());
                }
                if (cgDataControler1.verValor("omite_aprobacion_os") != null && cgDataControler1.verValor("omite_aprobacion_os") != System.DBNull.Value)
                {
                    chkOmiteAprobacion.Checked = bool.Parse(cgDataControler1.verValor("omite_aprobacion_os").ToString());
                }
            }
        }

        private void chkServicioPreventivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


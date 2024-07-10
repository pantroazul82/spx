using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmAsignarTipoPropiedad : Form
    {
        public frmAsignarTipoPropiedad()
        {
            InitializeComponent();
        }

        public string serial { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            equiposTableAdapter1.UpdateCodTipoPropiedad(int.Parse(cmbTipoPropiedad.SelectedValue.ToString()),
                DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, serial);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
          
            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Para ver la hoja de vida del equipo, debe traer el serial en la Consulta");
                return;
            }
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.Show();
        }

        private void frmAsignarTipoPropiedad_Load(object sender, EventArgs e)
        {
            tipoPropiedadTableAdapter1.Fill(dsSpx1.tipoPropiedad);
            //cargamos la configuracion del equipo
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial.Trim());
            if (dsSpx1.equipos.Count > 0)
            { txtSerial.Text = serial;
                if (!dsSpx1.equipos[0].IscodTipoPropiedadNull())
                {
                   
                    cmbTipoPropiedad.SelectedValue = dsSpx1.equipos[0].codTipoPropiedad;}
                    if (!dsSpx1.equipos[0].IsusuarioCambioNull()) txtUsuarioCambio.Text = dsSpx1.equipos[0].usuarioCambio;
                    if (!dsSpx1.equipos[0].IsfechaCambioTipoPropiedadNull())
                    {
                        calCambio.Value = dsSpx1.equipos[0].fechaCambioTipoPropiedad;
                        lblHora.Text = dsSpx1.equipos[0].fechaCambioTipoPropiedad.ToShortTimeString();
                    }
                
            }
        }
    }
}

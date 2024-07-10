using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmAnularEntradaSalida : Form
    {
        public frmAnularEntradaSalida()
        {
            InitializeComponent();
        }

        public int codEntradaSalidaEquipo { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            entradaSalidaEquiposTableAdapter1.UpdateAnulacion(true, SPXSeguridad.logica.sesion.CodUsuarioAutenticado, 
                obj.fechaServer,
                txtObsAnulacion.Text, codEntradaSalidaEquipo);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmAnularEntradaSalida_Load(object sender, EventArgs e)
        {
            entradaSalidaEquiposTableAdapter1.FillBycodEntradaSalidaEquipos(dsSpx1.EntradaSalidaEquipos, codEntradaSalidaEquipo);
            if (dsSpx1.EntradaSalidaEquipos[0].Isanulada_porNull())
            {
                calAnulacion.Value = DateTime.Now;
                txtAnuladaPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
            }else {
                btnAceptar.Visible = false;
                calAnulacion.Value = dsSpx1.EntradaSalidaEquipos[0].fecha_anulacion;
                txtObsAnulacion.Text = dsSpx1.EntradaSalidaEquipos[0].motivo_anulacion;
                txtObsAnulacion.ReadOnly = true;
                SPXSeguridad.data.cls.clsTusuario objUsuario=new SPXSeguridad.data.cls.clsTusuario();

                txtAnuladaPor.Text = objUsuario.verNombre(dsSpx1.EntradaSalidaEquipos[0].anulada_por);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.proceso
{
    public partial class frmAsesoriaDetalle : Form
    {
        public frmAsesoriaDetalle()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (codTarea == 0)
            {
                tarea_asesoria_cientificaTableAdapter1.Insert(
                    SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, txtDescripcion.Text, codAsesoria, chkRealizada.Checked);
            }else {
                tarea_asesoria_cientificaTableAdapter1.UpdateQuery(
                    dsSpx1.tarea_asesoria_cientifica[0].creada_por, txtDescripcion.Text, codAsesoria, chkRealizada.Checked, codTarea);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        public int codAsesoria { set; get; }
        public int codTarea { set; get; }

        private void frmAsesoriaDetalle_Load(object sender, EventArgs e)
        {
            if (codTarea != 0) {
                tarea_asesoria_cientificaTableAdapter1.FillBycod_tarea_asesoria_cientifica(dsSpx1.tarea_asesoria_cientifica, codTarea);
                txtDescripcion.Text = dsSpx1.tarea_asesoria_cientifica[0].descripcion_tarea;
                chkRealizada.Checked = dsSpx1.tarea_asesoria_cientifica[0].realizada;
            }   
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class Indicaciones : Form
    {
        public Indicaciones()
        {
            InitializeComponent();
        }

        int codIndicacion = 0;
        public int CodIndicacion { set { codIndicacion = value; } get { return codIndicacion; } }

        int codLlamada = 0;
        public int CodLlamada { set { codLlamada = value; } get { return codLlamada; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (calIndicacion.ValueObject == null)
            {
                MessageBox.Show("La fecha de indicacion es obligatoria!");
                return;
            }
            if (codIndicacion != 0)
            {
                indicacionesLLamadasTableAdapter1.UpdateQuery(
                    txtIndicaciones.Text, txtObservaciones.Text,calIndicacion.Value, codIndicacion, codLlamada);
            }else {
                int c = indicacionesLLamadasTableAdapter1.verNextId(codLlamada).Value;
                indicacionesLLamadasTableAdapter1.Insert(codLlamada, c, txtIndicaciones.Text, txtObservaciones.Text,
                    SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,DateTime.Now,calIndicacion.Value);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Indicaciones_Load(object sender, EventArgs e)
        {
            calCreacion.Value = DateTime.Now;
            calIndicacion.Value = DateTime.Now;
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            if (codIndicacion != 0)
            {
                indicacionesLLamadasTableAdapter1.FillByIndicacion(dsSpx1.indicacionesLLamadas,
                    codLlamada, codIndicacion);
                txtObservaciones.Text = dsSpx1.indicacionesLLamadas[0].observaciones;
                txtIndicaciones.Text = dsSpx1.indicacionesLLamadas[0].descripcion;
                if (!dsSpx1.indicacionesLLamadas[0].IsfechaCreacionNull()) calCreacion.Value = dsSpx1.indicacionesLLamadas[0].fechaCreacion;
                if (!dsSpx1.indicacionesLLamadas[0].IsfechaIndicacionNull()) calIndicacion.Value = dsSpx1.indicacionesLLamadas[0].fechaIndicacion;
            }
        }
    }
}

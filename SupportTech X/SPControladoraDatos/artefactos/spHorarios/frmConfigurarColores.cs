using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spHorarios
{
    public partial class frmConfigurarColores : Form
    {
        public frmConfigurarColores()
        {
            InitializeComponent();
        }

        private void frmConfigurarColores_Load(object sender, EventArgs e)
        {
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            picAlta.BackColor = SPControladoraDatos.Properties.Settings.Default.prioridadAlta;
            picEsperaRes.BackColor = SPControladoraDatos.Properties.Settings.Default.esperaRespuesta;
            picNivel1.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel1;
            picNivel2.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel2;
            picNivel3.BackColor = SPControladoraDatos.Properties.Settings.Default.vencidasNivel3;
            //--
            slider1.Value = SPControladoraDatos.Properties.Settings.Default.limiteUno;
            slider2.Value = SPControladoraDatos.Properties.Settings.Default.limiteDos;
            slider3.Value = SPControladoraDatos.Properties.Settings.Default.limiteTres;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            slider1.Text = slider1.Value.ToString();
            if (slider1.Value > slider2.Value)
                slider2.Value = slider1.Value;
            if (slider1.Value > slider2.Value)
                slider3.Value = slider1.Value;
        }

        private void slider2_ValueChanged(object sender, EventArgs e)
        {
            slider2.Text = slider2.Value.ToString();
            if (slider2.Value < slider1.Value)
                slider1.Value = slider2.Value;
            if (slider2.Value > slider3.Value)
                slider3.Value = slider2.Value;
        }

        private void slider3_ValueChanged(object sender, EventArgs e)
        {
            slider3.Text = slider3.Value.ToString();
            if (slider2.Value > slider3.Value)
                slider2.Value = slider3.Value;
            if (slider1.Value > slider3.Value)
                slider1.Value = slider3.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.Properties.Settings.Default.prioridadAlta=picAlta.BackColor;
            SPControladoraDatos.Properties.Settings.Default.esperaRespuesta=picEsperaRes.BackColor;
            SPControladoraDatos.Properties.Settings.Default.vencidasNivel1=picNivel1.BackColor;
            SPControladoraDatos.Properties.Settings.Default.vencidasNivel2=picNivel2.BackColor;
            SPControladoraDatos.Properties.Settings.Default.vencidasNivel3=picNivel3.BackColor;
            //--
            SPControladoraDatos.Properties.Settings.Default.limiteUno=slider1.Value;
            SPControladoraDatos.Properties.Settings.Default.limiteDos=slider2.Value;
            SPControladoraDatos.Properties.Settings.Default.limiteTres=slider3.Value;
            SPControladoraDatos.Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void picAlta_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                picAlta.BackColor = colorDialog1.Color;
        }

        private void picEsperaRes_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                picEsperaRes.BackColor = colorDialog1.Color;
        }

        private void picNivel1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                picNivel1.BackColor = colorDialog1.Color;
        }

        private void picNivel2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                picNivel2.BackColor = colorDialog1.Color;
        }

        private void picNivel3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                picNivel3.BackColor = colorDialog1.Color;
        }
    }
}

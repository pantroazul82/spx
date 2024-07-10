using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Themes
{
    public partial class FrmPersonalizar : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmPersonalizar()
        {
            InitializeComponent();
        }
        int inicio=0;
        Color cIinicio;
        int inicioRestore = 0;
        Color cIinicioRestore;
        public void cargarConfig()
        {
            inicio= SPControladoraDatos.Properties.Settings.Default.theme;
            cIinicio= SPControladoraDatos.Properties.Settings.Default.customTheme;
            inicioRestore = SPControladoraDatos.Properties.Settings.Default.theme;
            cIinicioRestore = SPControladoraDatos.Properties.Settings.Default.customTheme;
            colorPickerButton1.SelectedColor = cIinicio;
            switch (inicio)
            {
                case 0:
                    {
                        rdNegro.Checked = true;
                        break;
                    }
                case 1:
                    {
                        rdAzul.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rdSilver.Checked = true;
                        break;
                    }
                case 3:
                    {
                        rdCustom.Checked = true;
                        colorPickerButton1.SelectedColor = cIinicio;
                        break;
                    }
            }
        }


        public System.Drawing.Color verColor() 
        {
            System.Drawing.Color color = System.Drawing.Color.White;
            inicio = SPControladoraDatos.Properties.Settings.Default.theme;
            cIinicio = SPControladoraDatos.Properties.Settings.Default.customTheme;
            switch (inicio)
            {
                case 0:
                    {
                        color = System.Drawing.Color.DarkGray;
                        break;
                    }
                case 1:
                    {
                        color = System.Drawing.Color.FromArgb(149, 179, 215);
                        break;
                    }
                case 2:
                    {
                        color = System.Drawing.Color.Gray;
                        break;
                    }
                case 3:
                    {
                        color = cIinicio;
                        break;
                    }
            }
            return color;
        }

        private void FrmPersonalizar_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            cargarConfig();
        }

        private void rdAzul_CheckedChanged(object sender, EventArgs e)
        {
            if(rdAzul.Checked)
            {
                inicio = 1;
                ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Blue;
                this.Invalidate();
            }
        }

        private void rdNegro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNegro.Checked)
            {
                inicio = 0;
                ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Black;
                this.Invalidate();
            }
        }

        private void rdSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSilver.Checked)
            {
                inicio = 2;
                ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Silver;
                this.Invalidate();
            }
        }

        private void rdCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCustom.Checked)
            {
                inicio = 3;
                colorPickerButton1.Enabled = true;
                eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, colorPickerButton1.SelectedColor);
                cIinicio = colorPickerButton1.SelectedColor;
                this.Invalidate();
            }          else {
                colorPickerButton1.Enabled = false;
            }
        }

        private void colorPickerButton1_SelectedColorChanged(object sender, EventArgs e)
        {
            eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, colorPickerButton1.SelectedColor);
            cIinicio = colorPickerButton1.SelectedColor;
            this.Invalidate();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.Properties.Settings.Default.customTheme = cIinicio;
            SPControladoraDatos.Properties.Settings.Default.theme = inicio;
            SPControladoraDatos.Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (inicioRestore)
            {
                case 0:
                    {
                        ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Black;
                        
                        break;
                    }
                case 1:
                    {
                        ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Blue;
                        break;
                    }
                case 2:
                    {
                        ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Silver;
                        break;
                    }
                case 3:
                    {
                        eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;
                        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, cIinicioRestore);
                        break;
                    }
            }
            this.Invalidate();
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}


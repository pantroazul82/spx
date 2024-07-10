using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.tool
{
    public partial class frmEfecto : Form
    {
        public frmEfecto()
        {
            InitializeComponent();
        }

        private void frmEfecto_Load(object sender, EventArgs e)
        {
         //   timer1.Enabled = true;
        }
        private bool Activo = true;
        public void animacion()
        {
            while (Activo)
            {
                
                Application.DoEvents();
                System.Threading.Thread.Sleep(120);
            }
            this.Close();
        }

        public void animacionEnd()
        {
            Activo = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.programacion
{
    public partial class frmFecha : Form
    {
        public frmFecha()
        {
            InitializeComponent();
        }

        public string textoTitulo { set { lblText.Text = value; } get { return lblText.Text; } }
        public DateTime fechaElegida { set { calFecha.SelectedDate = value; } get { return calFecha.SelectedDate; } }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void frmFecha_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calFecha.SelectedDate = n;
        }
    }
}
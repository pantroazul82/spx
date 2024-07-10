using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmActividadxModelo : Form
    {
        public frmActividadxModelo()
        {
            InitializeComponent();
        }

        string codModelo = "";
        string codFabricante = "";
        public string CodModelo { set { codModelo = value; } get { return codModelo; } }
        public string CodFabricante { set { codFabricante = value; } get { return codFabricante; } }
        public string actividad { get { return txtFiltro.Text; } }

        private void frmActividadxModelo_Load(object sender, EventArgs e)
        {
            actividadesxModeloTableAdapter1.FillByModelo(dsSpx1.ActividadesxModelo, codFabricante.Trim(), codModelo.Trim());
            txtFiltro.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grdActividades.Columns[0].Text.Trim() == string.Empty)
            {
                return;
            }
            txtFiltro.Text = grdActividades.Columns["descripcion"].Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void buscar()
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            grdActividades.Columns["descripcion"].FilterText = txtFiltro.Text;
        }

        private void btnAgregarAuxiliar_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje frm = new SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje();
            frm.titulo = "Ingresar Actividad";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int id = int.Parse(actividadesxModeloTableAdapter1.verNextId(codFabricante.Trim(), codModelo).ToString());
                actividadesxModeloTableAdapter1.Insert(codFabricante, codModelo, id, frm.mensaje);
                actividadesxModeloTableAdapter1.FillByModelo(dsSpx1.ActividadesxModelo, codFabricante.Trim(), codModelo);
                grdActividades.Columns["descripcion"].FilterText = frm.mensaje;
            }

        }
    }
}

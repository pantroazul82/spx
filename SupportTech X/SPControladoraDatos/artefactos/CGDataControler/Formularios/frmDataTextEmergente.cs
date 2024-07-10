using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CGDataControler
{
    public partial class frmDataTextEmergente : Form
    {
        public frmDataTextEmergente()
        {
            InitializeComponent();
        }

        private DataTable tabla;
        public DataTable Tabla { set { tabla = value; dv = new DataView(tabla); grdDatos.DataSource = dv; } get { return tabla; } }
        private DataView dv;

        private string campoCodigo;
        private string campoNombre;
        public string CampoCodigo { set { campoCodigo = value; } get { return campoCodigo; } }
        public string CampoNombre { set { campoNombre = value; } get { return campoNombre; } }

        private string tituloColumnaCodigo = "Codigo";
        private string tituloColumnaDescripcion = "Descripcion";
        public string TituloColumnaCodigo { set { tituloColumnaCodigo = value; } get { return tituloColumnaCodigo; } }
        public string TituloColumnaDescripcion { set { tituloColumnaDescripcion = value; } get { return tituloColumnaDescripcion; } }
        //--
        private string valorCodigo;
        private string valorNombre;
        public string ValorCodigo { set { valorCodigo = value; } get { return valorCodigo; } }
        public string ValorNombre { set { valorNombre = value; } get { return valorNombre; } }
        public string filtroInicial { set { txtFiltro.Text = value; } get { return txtFiltro.Text; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmDataTextEmergente_Load(object sender, EventArgs e)
        {
            txtFiltro.Focus();
            //
            grdDatos.Columns[0].HeaderText = tituloColumnaCodigo;
            grdDatos.Columns[1].HeaderText = tituloColumnaDescripcion;
            grdDatos.Columns[1].Width = 285;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
           // dv.RowFilter = campoCodigo.Substring(campoCodigo.IndexOf(".")+1) +" like '%"+ txtFiltro.Text+"%' or "+campoNombre.Substring(campoNombre.IndexOf(".")+1) +" like '%"+ txtFiltro.Text+"%'";
            dv.RowFilter = "trim(Convert(Codigo,System.String)) like '%" + txtFiltro.Text + "%' or descripcion like '%" + txtFiltro.Text + "%'";
        }

        private void aceptar() 
        {
            if (grdDatos.FirstDisplayedCell == null)
            {
                return;
            }
            valorCodigo = grdDatos[0,grdDatos.CurrentRow.Index].Value.ToString().Trim();
            ValorNombre = grdDatos[1, grdDatos.CurrentRow.Index].Value.ToString().Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void frmDataTextEmergente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                aceptar();
            }else
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }else
            if (e.KeyCode == Keys.Down)
            {
                grdDatos.Focus();
            }else
            if (e.KeyCode == Keys.Up)
            {
                grdDatos.Focus();
            }
        }

        private void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            aceptar();
        }
    }
}
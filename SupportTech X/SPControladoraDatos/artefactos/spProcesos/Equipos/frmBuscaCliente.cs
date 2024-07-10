using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmBuscaCliente : Form
    {
        public frmBuscaCliente()
        {
            InitializeComponent();
        }

        private void frmBuscaCliente_Load(object sender, EventArgs e)
        {

        }

        private string numeroSocio = "";
        public string NumeroSocio { set { numeroSocio = value; } get { return numeroSocio; } }
        
        private string nitCliente = "";
        public string NitClente { set { nitCliente = value; } get { return nitCliente; } }

        private string nombreCliente = "";
        public string NombreClente { set { nombreCliente = value; } get { return nombreCliente; } }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar() 
        {
            dsSpx1.clientes.Rows.Clear();
            //---
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" select nitCliente, nombreCliente,cast (null as image) logotipo, ");
            sb.Append(" '' nombreContactoPrincipal, '' apellidosContacto, ");
            sb.Append(" '' docContacto, '' codTipoDoc, '' tituloContacto, '' telefono1, '' telefono2, '' fax, ");
            sb.Append(" '' celular, '' email,  numeroSocio");
            sb.Append(" from clientes");
            sb.Append(" where activo= 1  and (nitcliente like '%" + txtFiltro.Text.Trim() + "%' or nombreCliente like '%" + txtFiltro.Text.Trim() + "%')");
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            DataTable tabla = objData.ejecutarConsulta(sb.ToString()).Tables[0];
            dsSpx1.clientes.Merge(tabla);
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void aceptar() 
        {
            if (grdDatos.Columns["nitCliente"].Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe tener por lo menos un cliente para aceptar.");
                return;
            }
            numeroSocio = grdDatos.Columns["numeroSocio"].Text.Trim();
            nitCliente = grdDatos.Columns["nitCliente"].Text.Trim();
            nombreCliente = grdDatos.Columns["nombreCliente"].Text.Trim();
            DialogResult = DialogResult.OK;
            Close();        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                buscar(); 
            }else if(e.KeyCode == Keys.Down)
            {
                SelectNextControl(txtFiltro, true, true, true, true);
            }
        }

        private void grdDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                aceptar();
            }
        }
    }
}
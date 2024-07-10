using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica
{
    public partial class frmBuscarReactivo : Form
    {
        public frmBuscarReactivo()
        {
            InitializeComponent();
        }

     private string codReactivo = "";
     public string CodReactivo { set { codReactivo = value; } get { return codReactivo; } }

     private string codManual= "";
     public string CodManual { set { codManual = value; } get { return codManual; } }

        private string nombreREactivo = "";
        public string NombreREactivo { set { nombreREactivo = value; } get { return nombreREactivo; } }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar() 
        {
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltReactivoCientifica.Rows.Clear();
            //---
            System.Text.StringBuilder sb = new StringBuilder();
          
            sb.Append(" select  ");
             
  sb.Append(" fabricante.nombre_fabricante,referencia_reactivo.cod_referencia_reactivo, ");
  sb.Append(" referencia_reactivo.codigo_manual,referencia_reactivo.nombre_referencia_reactivo ");
   sb.Append(" from referencia_reactivo  ");
   sb.Append(" join fabricante on fabricante.codFabricante = referencia_reactivo.codFabricante ");
   sb.Append(" where referencia_reactivo.codigo_manual like '%" + txtFiltro.Text.Trim() + "%' or referencia_reactivo.nombre_referencia_reactivo like '%" + txtFiltro.Text.Trim() + "%'");
   SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();

            DataTable tabla = objData.ejecutarConsulta(sb.ToString()).Tables[0];
            dsPlantillas1.pltReactivoCientifica.Merge(tabla);
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void aceptar() 
        {
            if (grdDatos.Columns["cod_referencia_reactivo"].Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe tener por lo menos un reactivo para aceptar.");
                return;
            }
            codReactivo = grdDatos.Columns["cod_referencia_reactivo"].Text.Trim();
            nombreREactivo = grdDatos.Columns["nombre_referencia_reactivo"].Text.Trim();
            codManual = grdDatos.Columns["codigo_manual"].Text.Trim();
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
    

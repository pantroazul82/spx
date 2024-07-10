using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmBuscarAccesorio : Form
    {
        public frmBuscarAccesorio()
        {
            InitializeComponent();
        }


        private string fabricante = "";
        private string modelo = "";
        private string codigoAccesorio = "";
        private string nombreAccesorio = "";
        private bool esOtro = false;
        private float cantidad = 1;
        //
        public string CodigoAccesorio { set { codigoAccesorio = value; } get { return codigoAccesorio; } }
        public string NombreAccesorio { set { nombreAccesorio = value; } get { return nombreAccesorio; } }
        public bool EsOtro { set { esOtro = value; } get { return esOtro; } }
        public float Cantidad { set { cantidad = value; } get { return cantidad; } }
        public string Fabricante { set { fabricante = value; } get { return fabricante; } }
        public string Modelo { set { modelo = value; } get { return modelo; } }


        private bool validar()
        {
            float cantidad=0;
            if (chkOtro.Checked && txtOtro.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Debe ingresar la descripcin del accesorio");
                txtOtro.Focus();
                return false;
            }
            if (!float.TryParse(txtCantidad.Text, out cantidad)) 
            {
                MessageBox.Show("Debe ingresar una cantidad valida");
                txtCantidad.Focus();
                return false;
            }

            if (!chkOtro.Checked && grdDatos.Columns[0].Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Debe escoger un accesorio!");
                return false;
            }
            //---Miramos si el Fabricante y el Modelo son diferentes
            if (!chkOtro.Checked )
            {
                if (grdDatos.Columns["codFabricante"].Text.ToUpper().Trim() != fabricante || grdDatos.Columns["codModelo"].Text.ToUpper().Trim() != modelo)
                {
                    if (fabricante.Trim() != string.Empty)
                    {
                        if (DialogResult.Yes != MessageBox.Show("Esta configurando un accesorio que no pertenece al modelo y fabricante\n Desea Continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            return false;
                        }
                    }
                }
            }
            
            //si la validacion es valida cargamos las propiedades
            Cantidad = cantidad;
            EsOtro = chkOtro.Checked;
            
            if (chkOtro.Checked) { 
            CodigoAccesorio = "otro";
            NombreAccesorio = txtOtro.Text.Trim();
            
            } else {
            CodigoAccesorio = grdDatos.Columns["codAccesoriosEquipos"].Text.Trim();
            NombreAccesorio =  grdDatos.Columns["nombreAccesorio"].Text.Trim();
            }
            return true;
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar())return;
            DialogResult=DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string sql = @"select 
codAccesoriosEquipos,
nombreAccesorio,accesoriosEquipo.descripcion,
accesoriosEquipo.codFabricante,accesoriosEquipo.codModelo
nombre_fabricante,NombreModelo
 from accesoriosEquipo
left join fabricante on accesoriosEquipo.codFabricante = fabricante.codFabricante
left join Modelos on accesoriosEquipo.codFabricante = Modelos.codFabricante
and accesoriosEquipo.codModelo = Modelos.codModelo "
                + " where codAccesoriosEquipos like '%" + txtFiltro.Text.Trim() + "%' or "
                + " nombreAccesorio like '%" + txtFiltro.Text.Trim() + "%' ";
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            System.Data.DataTable tb = objData.ejecutarConsulta(sql).Tables[0];
            dsPlantillas1.pltAccesoriosEquipo.Merge(tb);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmBuscarAccesorio_Load(object sender, EventArgs e)
        {
         
        }
    }
}
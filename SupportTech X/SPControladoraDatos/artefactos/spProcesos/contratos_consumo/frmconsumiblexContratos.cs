using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmconsumiblexContratos : Form
    {
        public frmconsumiblexContratos()
        {
            InitializeComponent();
        }

        public int cod { set; get; }
        public int codContrato { set; get; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbConsumible.SelectedValue == null || cmbConsumible.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione el consumible");
                return;
            }
            decimal cantidad = 0;
            
            decimal.TryParse(nmCantidad.Text.Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator),out cantidad);
            if (cod == 0)
            {
                consumiblexcontrato_consumoTableAdapter1.Insert(
                    int.Parse(cmbConsumible.SelectedValue.ToString()),
                   cantidad, codContrato
                    );
            }
            else {
                consumiblexcontrato_consumoTableAdapter1.UpdateQuery(
                       int.Parse(cmbConsumible.SelectedValue.ToString()),
                       cantidad, cod
                       );
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void calcularConsumo() 
        {
        
        
        }

        private void frmconsumiblexContratos_Load(object sender, EventArgs e)
        {
            fabricanteTableAdapter1.Fill(dsSpx1.fabricante);
            if (cod != 0)
            {
                SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
                consumiblexcontrato_consumoTableAdapter1.FillBycod_consumiblexcontrato(dsContratoConsumo1.consumiblexcontrato_consumo, cod);
                consumiblesTableAdapter1.FillByCod_consumible(ds.consumibles,dsContratoConsumo1.consumiblexcontrato_consumo[0].cod_consumible);
                
                grupo_consumibleTableAdapter1.FillByCod_grupo_consumible(ds.grupo_consumible, ds.consumibles[0].cod_grupo_consumible);
                grupo_consumibleTableAdapter1.FillBycod_fabricante(dsContratoConsumo1.grupo_consumible, ds.grupo_consumible[0].cod_fabricante);
                cmbGrupoConsumible.SelectedValue = ds.consumibles[0].cod_grupo_consumible;

                
                cargarConsumible(ds.consumibles[0].cod_grupo_consumible);
                cmbConsumible.SelectedValue = ds.consumibles[0].cod_consumible;
                nmCantidad.Text = dsContratoConsumo1.consumiblexcontrato_consumo[0].cantidad.ToString().Replace(",",".");
            }
        }

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty)
            {
                dsContratoConsumo1.grupo_consumible.Clear();
                dsContratoConsumo1.consumibles.Clear();
            }else{
                grupo_consumibleTableAdapter1.FillBycod_fabricante(dsContratoConsumo1.grupo_consumible,int.Parse(cmbFabricante.SelectedValue.ToString()));
                dsContratoConsumo1.consumibles.Clear();
            }
        }

        private void cmbGrupoConsumible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrupoConsumible.SelectedValue == null || cmbGrupoConsumible.SelectedValue.ToString().Trim() == string.Empty)
            {
                dsContratoConsumo1.consumibles.Clear();
            }
            else
            {
                cargarConsumible(int.Parse(cmbGrupoConsumible.SelectedValue.ToString()));
                
            }

        }

        private void cargarConsumible(int codGrupoConsumible)
        {
            string sql=@"select cod_consumible,consumible,cod_grupo_consumible,referencia,
' ('+rtrim(isnull(referencia,''))+')'+ 
rtrim(isnull(consumible,'')) nombre
 from consumibles
 where cod_grupo_consumible=" + codGrupoConsumible + " order by referencia";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            cmbConsumible.DataSource=             bd.ejecutarConsulta(sql).Tables[0];
            cmbConsumible.DisplayMember = "nombre";
            cmbConsumible.ValueMember = "cod_consumible";

        }

        private void cmbConsumible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < 30)
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar == '0' ||
                e.KeyChar == '1' ||
                e.KeyChar == '2' ||
                e.KeyChar == '3' ||
                e.KeyChar == '4' ||
                e.KeyChar == '5' ||
                e.KeyChar == '6' ||
                e.KeyChar == '7' ||
                e.KeyChar == '8' ||
                e.KeyChar == '9' ||
                e.KeyChar == '0' ||
                e.KeyChar == '.'
                )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

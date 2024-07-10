using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmEscogerVariable : Form
    {
        public frmEscogerVariable()
        {
            InitializeComponent();
        }

        public string CodModelo { set; get; }
        public string CodFabricante { set; get; }
        public int cod_variables_medicionxmodelo { set; get; }

        private void frmEscogerVariable_Load(object sender, EventArgs e)
        {
            variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);
            //validamos si el modelo mide, o es medido
            string sql = @"select tipoEquipo.dispositivo_medible,dispositivo_medicion from Modelos join tipoEquipo on tipoEquipo.codTipoEquipo = Modelos.codTipoEquipo
 where codFabricante='"+CodFabricante.Trim()+"' and codModelo='"+CodModelo.Trim()+"'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable t= bd.ejecutarConsulta(sql).Tables[0];
            if(t.Rows[0]["dispositivo_medible"] != null &&  t.Rows[0]["dispositivo_medible"] != System.DBNull.Value &&
                bool.Parse( t.Rows[0]["dispositivo_medible"].ToString()))
            {
                grpValoresEsperados.Visible=true;
                lblSubVariable.Visible = true;
                cmbSusbvariable.Visible = true;
                
            }else{
                grpValoresEsperados.Visible=false;
                lblSubVariable.Visible = false;
                cmbSusbvariable.Visible = false;
            }

            if (cod_variables_medicionxmodelo != 0)
            {
                variables_medicionxmodeloTableAdapter1.FillByCod_variables_medicionxmodelo(dsSpx1.variables_medicionxmodelo, cod_variables_medicionxmodelo);
                cmbVariable.Enabled = false;
                //cargamos la subavariable
                if (!dsSpx1.variables_medicionxmodelo[0].Iscod_sub_variables_medicionNull())
                {
                    SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                    sub_variable_medicionTableAdapter1.FillByCod_sub_variables_medicion(ds.sub_variable_medicion, dsSpx1.variables_medicionxmodelo[0].cod_sub_variables_medicion);
                    //---
                    sub_variable_medicionTableAdapter1.FillBycod_variables_medicion(dsSpx1.sub_variable_medicion, ds.sub_variable_medicion[0].cod_variables_medicion);
                    cmbVariable.SelectedValue = ds.sub_variable_medicion[0].cod_variables_medicion;
                }else{
                    cmbVariable.SelectedValue = dsSpx1.variables_medicionxmodelo[0].cod_variables_medicion;
                }
                txtUnidades.Text = dsSpx1.variables_medicionxmodelo[0].unidades.Trim();
                nmRangoFinal.Value = dsSpx1.variables_medicionxmodelo[0].rango_final;
                nmRangoInicial.Value = dsSpx1.variables_medicionxmodelo[0].rango_inicial;

                if (!dsSpx1.variables_medicionxmodelo[0].Isobligatorio_preventivoNull())
                chkObligatorio.Checked = dsSpx1.variables_medicionxmodelo[0].obligatorio_preventivo;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cmbVariable.SelectedValue == null || cmbVariable.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La variable es obligatoria.");
                return;
            }

            if (cmbSusbvariable.Visible && cmbSusbvariable.SelectedValue == null || cmbSusbvariable.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La sub variable es obligatoria.");
                return;
            }
        
            if (txtUnidades.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Las unidades son obligatorias.");
                return;
            }


            if (nmRangoFinal.Value < nmRangoInicial.Value)
            {
                MessageBox.Show("Los valores esperados no son coherentes.");
                return;
            }

            int? codVariable=null;
                int? codSubVariable = null;
                    codVariable = int.Parse(cmbVariable.SelectedValue.ToString());

                if(cmbSusbvariable.Visible)
                {
                    codSubVariable= int.Parse( cmbSusbvariable.SelectedValue.ToString());
                }

            if (cod_variables_medicionxmodelo == 0)
            {
                
                variables_medicionxmodeloTableAdapter1.Insert(CodFabricante, CodModelo, nmRangoInicial.Value, nmRangoFinal.Value,
                    txtUnidades.Text.Trim(),chkObligatorio.Checked,codVariable,codSubVariable);
            }else{
                variables_medicionxmodeloTableAdapter1.UpdateQuery(nmRangoInicial.Value, nmRangoFinal.Value,
                    txtUnidades.Text.Trim(), chkObligatorio.Checked,codSubVariable,cod_variables_medicionxmodelo);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmbVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVariable.SelectedValue == null || cmbVariable.SelectedValue.ToString() == string.Empty)
            {
                dsSpx1.sub_variable_medicion.Clear();
                return;
            }
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            variables_medicionTableAdapter1.FillByCod_variables_medicion(ds.variables_medicion, int.Parse( cmbVariable.SelectedValue.ToString() ));
            txtUnidades.Text = ds.variables_medicion[0].unidades;
            sub_variable_medicionTableAdapter1.FillBycod_variables_medicion(dsSpx1.sub_variable_medicion, int.Parse(cmbVariable.SelectedValue.ToString()));
            
        }
    }
}

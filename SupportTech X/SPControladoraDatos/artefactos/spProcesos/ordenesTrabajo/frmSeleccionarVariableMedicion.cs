using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmSeleccionarVariableMedicion : Form
    {
        public frmSeleccionarVariableMedicion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string serial { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbVariableMedicion.SelectedValue == null || cmbVariableMedicion.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La variable es obligatoria.");
                return;
            }
            
            if (codVariablexOrden == 0)
            {
                variables_medicionxorden_servicioTableAdapter1.Insert(codOrdenServicio, nmValor.Value, int.Parse(cmbSubvariableMedicion.SelectedValue.ToString()),chkCalculadaPorEquipo.Checked);
            }else{
                variables_medicionxorden_servicioTableAdapter1.UpdateQuery(nmValor.Value, int.Parse(cmbSubvariableMedicion.SelectedValue.ToString()), chkCalculadaPorEquipo.Checked, codVariablexOrden);
            }
            DialogResult = DialogResult.OK;
        }

        public int codOrdenServicio { set; get; }

        public int codVariablexOrden { set; get; }

        private void frmSeleccionarVariableMedicion_Load(object sender, EventArgs e)
        {
            //variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);
            //evaluamos si el modelo tiene variables configuradas
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            string sql = @"select distinct variables_medicion.* from ordenServicio 
  join equipos on equipos.serial= ordenServicio.serial
 join variables_medicionxmodelo on variables_medicionxmodelo.codFabricante = equipos.codFabricante and variables_medicionxmodelo.codModelo = equipos.codModelo 
 join variables_medicion on variables_medicionxmodelo.cod_variables_medicion = variables_medicion.cod_variables_medicion
 where codOrdenServicio='" + codOrdenServicio + "' order by nombre_variables_medicion ";
            System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
            if (tb.Rows.Count > 0)
            {
                dsSpx1.variables_medicion.Clear();
                dsSpx1.variables_medicion.Merge(tb);
            }
            //else{
             //   variables_medicionTableAdapter1.Fill(dsSpx1.variables_medicion);
            //}

            cargarSubVariable();
            if (codVariablexOrden != 0) 
            {
                variables_medicionxorden_servicioTableAdapter1.FillByCod_variables_medicionxorden_servicio(dsSpx1.variables_medicionxorden_servicio, codVariablexOrden);
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                sub_variable_medicionTableAdapter1.FillByCod_sub_variables_medicion(ds.sub_variable_medicion, dsSpx1.variables_medicionxorden_servicio[0].cod_sub_variable_medicion);
                cmbVariableMedicion.SelectedValue = ds.sub_variable_medicion[0].cod_variables_medicion;
                sub_variable_medicionTableAdapter1.FillBycod_variables_medicion(dsSpx1.sub_variable_medicion, ds.sub_variable_medicion[0].cod_variables_medicion);
                cmbVariableMedicion.Enabled = false;
                cmbSubvariableMedicion.SelectedValue = dsSpx1.variables_medicionxorden_servicio[0].cod_sub_variable_medicion;
                //cmbVariableMedicion.SelectedValue = dsSpx1.variables_medicionxorden_servicio[0].cod_variables_medicion;
                nmValor.Value = dsSpx1.variables_medicionxorden_servicio[0].resultado_variable;
                if (!dsSpx1.variables_medicionxorden_servicio[0].Isrelizado_por_equipoNull())
                chkCalculadaPorEquipo.Checked = dsSpx1.variables_medicionxorden_servicio[0].relizado_por_equipo;
            }

            cargarUnidades();
        }

        private void cargarUnidades() 
        {
            if (cmbSubvariableMedicion.SelectedValue == null)
            {
                lblValoresEsperados.Text = "";
                txtUnidades.Text = "";
                return;
            }
        //obtenemos el modelo del serial de la orden de servicio
            string sql = @"select codModelo,codFabricante from ordenServicio 
 join equipos on equipos.serial= ordenServicio.serial
 
 where codOrdenServicio= " +codOrdenServicio;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tbFabricante = bd.ejecutarConsulta(sql).Tables[0];
            //valida si tiene configurado el valor de las unidades para el modelo
            sql = "select unidades,rango_inicial,rango_final from variables_medicionxmodelo where codModelo='" + tbFabricante.Rows[0]["codModelo"].ToString() + 
                "' and codFabricante ='" + tbFabricante.Rows[0]["codFabricante"].ToString()+"' and cod_sub_variables_medicion="+cmbSubvariableMedicion.SelectedValue;
            System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];
            if (tb.Rows.Count > 0)
            {
                txtUnidades.Text = tb.Rows[0][0].ToString();
                lblValoresEsperados.Text = tb.Rows[0][1].ToString().Trim() + " - " + tb.Rows[0][2].ToString().Trim()+" " + tb.Rows[0][0].ToString();
            }
            else {
                lblValoresEsperados.Text = "";
                txtUnidades.Text = bd.ejecutarProcedimiento("select unidades from variables_medicion where cod_variables_medicion="+cmbVariableMedicion.SelectedValue).ToString();
            }
            //si no entonces toma las unidades de la variable de medicion

        }

        private void cmbVariableMedicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSubVariable();
        }

        private void cargarSubVariable(){
            if (cmbVariableMedicion.SelectedValue == null)
            {
                dsSpx1.sub_variable_medicion.Clear();
                return;
            }
            sub_variable_medicionTableAdapter1.FillByCodVariableMedicionSerial(dsSpx1.sub_variable_medicion, int.Parse(cmbVariableMedicion.SelectedValue.ToString()),serial);
            cargarUnidades();
        }

        private void cmbSubvariableMedicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarUnidades();
        }
    }
}

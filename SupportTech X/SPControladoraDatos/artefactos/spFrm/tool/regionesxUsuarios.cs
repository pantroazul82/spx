using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.tool
{
    public partial class regionesxUsuarios : Form
    {
        public regionesxUsuarios()
        {
            InitializeComponent();
        }

        private void cargarUsuarios() 
        {
            string sql = "select login as Login, nombre as Nombre from usuario";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            grdUsuarios.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            grdUsuarios.Splits[0].DisplayColumns[0].Visible=false;
            grdUsuarios.Splits[0].DisplayColumns[1].Width = 150;
        }

        private void cargarRegionesUsuarios() 
        {
            if (grdUsuarios.Columns["Login"].Value == null || grdUsuarios.Columns["Login"].Value.ToString().Trim() == string.Empty)
                return;
        System.Text.StringBuilder sb= new StringBuilder();
        sb.Append(" select   ");
        sb.Append("paises.codPais,paises.nombrePais as 'Pais', ");
        sb.Append("departamento.codDepartamento,departamento.nombreDepartamento as 'Departamento', ");
        sb.Append("ciudades.codciudad,ciudades.Nombreciudad as 'Ciudad' ");
        sb.Append("from paises ");
        sb.Append("join departamentos departamento on departamento.codPais = paises.codPais   ");
        sb.Append("join ciudades on  ");
        sb.Append("ciudades.codPais = paises.codPais  and ciudades.codDepartamento   = departamento.codDepartamento   ");
        sb.Append("join regionesXusuarios on ");
        sb.Append("ciudades.codPais = regionesXusuarios.codPais  and ciudades.codDepartamento   = regionesXusuarios.codDepartamento  ");
        sb.Append("and ciudades.codCiudad   = regionesXusuarios.codCiudad  ");
        sb.Append("where login ='"+grdUsuarios.Columns["Login"].Value.ToString()+"' ");
        SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
        grdRegionesxUsuario.DataSource = objData.ejecutarConsulta(sb.ToString()).Tables[0];
        //--
        if (grdRegionesxUsuario.Splits[0].DisplayColumns.Count > 0)
        {
            grdRegionesxUsuario.Splits[0].DisplayColumns["codPais"].Visible = false;
            grdRegionesxUsuario.Splits[0].DisplayColumns["codDepartamento"].Visible = false;
            grdRegionesxUsuario.Splits[0].DisplayColumns["codciudad"].Visible = false;
        }

        }

        private void cargarDepartamentos() 
        {
            if (cmbPais.SelectedValue != null && cmbPais.SelectedValue.ToString().Trim() != string.Empty)
            {
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
                cargarCiudades();
            }
        }

        private void cargarCiudades()
        {
            if (cmbDepartamento.SelectedValue != null && cmbDepartamento.SelectedValue.ToString().Trim() != string.Empty)
            {
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(),cmbDepartamento.SelectedValue.ToString());
            }
        }

        private void regionesxUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            paisesTableAdapter1.Fill(dsSpx1.paises);
            cargarDepartamentos();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCiudades();
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void grdUsuarios_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            if (e.LastRow == grdUsuarios.Row) return;
            cargarRegionesUsuarios();
        }

        private void btnAgregarRegion_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.Columns["Login"].Value == null && grdUsuarios.Columns["Login"].Value.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe tener activo un usuario en la grilla de usuarios.");
                return;
            }
            if (cmbPais.SelectedValue == null || cmbPais.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un pais.");
                cmbPais.Focus();
                return;
            }
            if (cmbDepartamento.SelectedValue == null || cmbDepartamento.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un departamento.");
                cmbPais.Focus();
                return;
            }
            if (cmbCiudad.SelectedValue == null || cmbCiudad.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar una ciudad.");
                cmbPais.Focus();
                return;
            }
            //validamos que no exista antes 
            int respuesta = int.Parse(regionesXusuariosTableAdapter1.verificarLlaves(grdUsuarios.Columns["Login"].Value.ToString(), cmbPais.SelectedValue.ToString()
            , cmbDepartamento.SelectedValue.ToString(), cmbCiudad.SelectedValue.ToString()).ToString());

            if (respuesta > 0)
            {
                MessageBox.Show("Ya existe esta relacion entre esta region y este usuario");
            }
            else
            {
                regionesXusuariosTableAdapter1.Insert(grdUsuarios.Columns["Login"].Value.ToString(), cmbPais.SelectedValue.ToString()
                , cmbDepartamento.SelectedValue.ToString(), cmbCiudad.SelectedValue.ToString());
                cargarRegionesUsuarios();
            }
        }

        private void btnQuitarRegion_Click(object sender, EventArgs e)
        {
            regionesXusuariosTableAdapter1.Delete(grdUsuarios.Columns["Login"].Value.ToString(), 
                grdRegionesxUsuario.Columns["codPais"].Value.ToString(),
                grdRegionesxUsuario.Columns["codDepartamento"].Value.ToString(),
                grdRegionesxUsuario.Columns["codciudad"].Value.ToString());
            cargarRegionesUsuarios();
        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.Columns["Login"].Value == null && grdUsuarios.Columns["Login"].Value.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe tener activo un usuario en la grilla de usuarios.");
                return;
            }
            if (cmbPais.SelectedValue == null || cmbPais.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un pais.");
                cmbPais.Focus();
                return;
            }
            if (cmbDepartamento.SelectedValue == null || cmbDepartamento.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un departamento.");
                cmbPais.Focus();
                return;
            }
            SPControladoraDatos.dsSpx d=new SPControladoraDatos.dsSpx();

            ciudadesTableAdapter1.FillByCodPaisCodDepartamento(d.ciudades, cmbPais.SelectedValue.ToString(), cmbDepartamento.SelectedValue.ToString());

            for (int k = 0; k < d.ciudades.Count; k++)
            {
                //validamos que no exista antes 
                int respuesta = int.Parse(regionesXusuariosTableAdapter1.verificarLlaves(grdUsuarios.Columns["Login"].Value.ToString(), cmbPais.SelectedValue.ToString()
                , d.ciudades[k].codDepartamento, d.ciudades[k].codCiudad).ToString());

                if (respuesta > 0)
                {
                    //MessageBox.Show("Ya existe esta relacion entre esta region y este usuario");
                }
                else
                {
                    regionesXusuariosTableAdapter1.Insert(grdUsuarios.Columns["Login"].Value.ToString(), cmbPais.SelectedValue.ToString()
                    , d.ciudades[k].codDepartamento, d.ciudades[k].codCiudad);
                    
                }
            }
            cargarRegionesUsuarios();
        }


    }
}
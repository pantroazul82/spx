using SPXSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spHerramientas.consultas
{
    public partial class frmSeguimiento : Form
    {
        public frmSeguimiento()
        {
            InitializeComponent(); 
            controladorColumnas1.grilla = grdDatos;
        }

        private void frmSeguimiento_Load(object sender, EventArgs e)
        {
            cmbCampo.SelectedIndex = 0;
            cmbAno.Text = DateTime.Now.Year.ToString();
            cmbMeses.SelectedIndex = DateTime.Now.Month - 1;

            if(! verificadorPermisos.ejecutarAccionWindows(2072))
            {
           btnAsignarResponsable.Visible=false; 
            }
        }

        private string sentenciaSQL() 
        {
         System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" select ");
            bool campos = false;
            if (chkTop.Checked)
            {
                sb.Append(" top "+nmTop.Value.ToString());
            }
            if (true)
            {
                campos = true;
                sb.Append (" nombreFabricante as 'Fabricante',");
            }
            if (true)
            {
                campos = true;
                sb.Append(" NombreModelo as 'Modelo', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" nombreTipoEquipo 'Tipo Equipo', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" nombreSubTipo 'Subtipo Equipo', ");
            }

            if (true)
            {
                campos = true;
                sb.Append(" isnull(nombreModalidadEquipo,'Sin Modalidad') as 'Modalidad', ");
            }

            if (true)
            {
                campos = true;
                sb.Append(" isnull(nombreEstadoLocal,'Sin Estado Local') as 'Estado Local', ");
            }

            if (true)
            {
                campos = true;
                sb.Append(" c.nitCliente as 'Nit Cliente', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" c.nombreCliente as 'Cliente', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" nombreSucursal as 'Sucursal', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" nombrePais as 'Pais', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" NombreDepartamento as 'Departamento', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" nombreCiudad as 'Ciudad', ");
            }
            if (true)
            {
                campos = true;
                sb.Append("  vistaEquipo.serial as 'Serial', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.fechaLlegada as 'Llegada',");
            }

            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.fechaSalida as 'Salida', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.fechaUltimoMante as 'Ultimo Mantenimiento', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" c.numeroSocio as 'Socio de Negocio', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.fechaProximoMante as 'Proximo Mantenimiento', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" TipoServicio.nombretipoServicio as 'Tipo Servicio', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" isnull(tipoPropiedad.nombreTipoPropiedad,'No Asignada') as 'Tipo Propiedad', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.observacionesUltimoMante as 'Observaciones', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.nitClienteUbicacionReal as 'Nit Cliente Real', ");
                sb.Append(" vistaEquipo.clienteReal as 'Cliente Real', ");
            }
            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.sucursalLocal as 'Sucursal Real', ");
            }

            if (true)
            {
                campos = true;
                sb.Append(" vistaEquipo.ultimo_responsable as 'Ultimo Responsable', ");
            }


            if (!campos) 
            {
                MessageBox.Show("Tiene configurado que ningun campo se  muestre en la consulta.");
                return "";
            }
            sb=sb.Remove(sb.ToString().LastIndexOf(','), 1);
            
            sb.Append (" from vistaEquipo");
            sb.Append(" join equipos on equipos.serial = vistaEquipo.serial ");
            sb.Append(" left join TipoServicio on TipoServicio.codTipoServicio = vistaEquipo.codTipoServicio ");
            sb.Append(" left join tipoPropiedad on tipoPropiedad.codTipoPropiedad = Equipos.codTipoPropiedad  ");
            sb.Append(" left join clientes c on vistaEquipo.nitCliente = c.nitCliente ");
             
            return sb.ToString();
        }

        private void buscar(bool buscarFechas)
        {
            if (!validarFiltro()) return;
            string sql = sentenciaSQL();
            if (sql == string.Empty) return;
            string filtro = "";
            System.Data.DataTable tb;
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            if (!buscarFechas)
            {
                filtro = " WHERE " + armarFiltros();
                tb = objData.ejecutarConsulta(sql + filtro + verOrden()).Tables[0];
            }else{
            
                filtro = " WHERE ";
                //aca configuramos los filtros
                filtro += " datepart(month,equipos.fechaProximoMante) = " + (cmbMeses.SelectedIndex + 1) + " and " +
                    " datepart(year,equipos.fechaProximoMante) = " + (cmbAno.Text);
                tb = objData.ejecutarConsulta(sql + filtro).Tables[0];
            }
            grdDatos.DataSource = tb;
            txtTotal.Text = tb.Rows.Count.ToString();
            //
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\Layout\" + "spHerramientas.consultas.frmSeguimiento-grdDatos-controladorColumnas1.xs";
            if (System.IO.File.Exists(str))
                grdDatos.LoadLayout(str);
            //COMO HAY UNAS COLUMNAS QUE NO ESTAN VISIBLES LAS DEBEMOS OCULTAR
            if (tieneColumna("Ciudad"))
            grdDatos.Splits[0].DisplayColumns["Ciudad"].Visible = true;
            if (tieneColumna("Cliente"))
            grdDatos.Splits[0].DisplayColumns["Cliente"].Visible = true;
            if (tieneColumna("Departamento"))
            grdDatos.Splits[0].DisplayColumns["Departamento"].Visible = true;
            if (tieneColumna("Estado Local"))
            grdDatos.Splits[0].DisplayColumns["Estado Local"].Visible = true;
            if (tieneColumna("Llegada"))
            grdDatos.Splits[0].DisplayColumns["Llegada"].Visible = true;
            if (tieneColumna("Nit Cliente"))
            grdDatos.Splits[0].DisplayColumns["Nit Cliente"].Visible = true;
            if (tieneColumna("Observaciones"))
            grdDatos.Splits[0].DisplayColumns["Observaciones"].Visible = true;
            if (tieneColumna("Pais"))
            grdDatos.Splits[0].DisplayColumns["Pais"].Visible = true;
            if (tieneColumna("Proximo Mantenimiento"))
            grdDatos.Splits[0].DisplayColumns["Proximo Mantenimiento"].Visible = true;
            if (tieneColumna("Tipo Servicio"))
            grdDatos.Splits[0].DisplayColumns["Tipo Servicio"].Visible = true;
            if (tieneColumna("Ultimo Mantenimiento"))
            grdDatos.Splits[0].DisplayColumns["Ultimo Mantenimiento"].Visible = true;
            if (tieneColumna("Salida"))
            grdDatos.Splits[0].DisplayColumns["Salida"].Visible = true;
            if (tieneColumna("Serial"))
            grdDatos.Splits[0].DisplayColumns["Serial"].Visible = true;
            if (tieneColumna("Subtipo Equipo"))
            grdDatos.Splits[0].DisplayColumns["Subtipo Equipo"].Visible = true;
            if (tieneColumna("Tipo Equipo"))
            grdDatos.Splits[0].DisplayColumns["Tipo Equipo"].Visible =true;
            if (tieneColumna("Fabricante"))
            grdDatos.Splits[0].DisplayColumns["Fabricante"].Visible =true;
            if (tieneColumna("Modelo"))
                grdDatos.Splits[0].DisplayColumns["Modelo"].Visible = true;
            if (tieneColumna("Sucursal"))
            grdDatos.Splits[0].DisplayColumns["Sucursal"].Visible =true;
            if (tieneColumna("Modalidad"))
            grdDatos.Splits[0].DisplayColumns["Modalidad"].Visible = true;
            if (tieneColumna("Socio de Negocio"))
                grdDatos.Splits[0].DisplayColumns["Socio de Negocio"].Visible = true;
            if (tieneColumna("Tipo Propiedad"))
                grdDatos.Splits[0].DisplayColumns["Tipo Propiedad"].Visible = true;
            if (grdDatos.Splits[0].DisplayColumns["Serial"].Visible) 
            {
                grdDatos.Columns["Serial"].Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Count;
                grdDatos.Columns["Serial"].GroupInfo.ColumnVisible = true;
            }
            
        }

        private bool tieneColumna(string nombreColumna)
        {
            for (int k = 0; k < grdDatos.Splits[0].DisplayColumns.Count; k++)
            {
                if (nombreColumna.Trim().ToUpper() == grdDatos.Splits[0].DisplayColumns[k].Name.Trim().ToUpper())
                    return true;
            }
            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar(false);          
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
          
                buscar(false);
  
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = null;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (verificadorPermisos.ejecutarAccionWindows(1118))
            {
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
                obj.exportar(grdDatos, "Seguimiento", false);
            }else{
                MessageBox.Show("No tiene los Suficientes permisos para Realizar esta Accion","Acceso Denegado");
            }
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            if (cmbMeses.Text.Trim() == string.Empty)
            {
                return;
            }
            buscar(true);
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns.Count <= 0) return;
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
            //if (!seguimiento.Default.serial) {
            //    MessageBox.Show("Para ver la hoja de vida del equipo, debe traer el serial en la Consulta");
            //    return;
            //}
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = grdDatos.Columns["serial"].Text;
            frm.ShowDialog();
        }

        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns.Count <= 0) return;
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
            //if (!seguimiento.Default.serial)
            //{
            //    MessageBox.Show("Para ver el equipo, debe traer el serial en la Consulta");
            //    return;
            //}
            if (!verificadorPermisos.ejecutarAccionWindows(1116))
            {
                MessageBox.Show("No tiene permisos para realizar esta accion!");
                return;
            }
            spProcesos.Equipos.frmEquipos frm = new spProcesos.Equipos.frmEquipos();
            frm.SerialEquipo = grdDatos.Columns["serial"].Text;
            frm.Show();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar(false);
            }
        }


     



        private void habilitarFiltro(int filtro)
        {

            if (filtro == 1)
            {
                cmbFiltro2.Visible = false;
                cmbFiltro3.Visible = false;
                cmbFiltro4.Visible = false;
                //-
                txtFiltro2.Visible = false;
                txtFiltro3.Visible = false;
                txtFiltro4.Visible = false;
                //--
                btnAgregarFiltro1.Visible = true;
                btnAgregarFiltro2.Visible = false;                
                btnAgregarFilrto3.Visible = false;
                btnQuitarFiltro2.Visible = false;
                btnQuitarFiltro3.Visible = false;
                btnQuitarFiltro4.Visible = false;
            }
            else if (filtro == 2)
            {
                cmbFiltro2.Visible = true;
                cmbFiltro3.Visible = false;
                cmbFiltro4.Visible = false;
                //-
                txtFiltro2.Visible = true;
                txtFiltro3.Visible = false;
                txtFiltro4.Visible = false;
                //--
                btnAgregarFiltro1.Visible = false;
                btnAgregarFiltro2.Visible = true;
                btnAgregarFilrto3.Visible = false;
                btnQuitarFiltro2.Visible = true;
                btnQuitarFiltro3.Visible = false;
                btnQuitarFiltro4.Visible = false;
            }
            else if (filtro == 3)
            {
                cmbFiltro2.Visible = true;
                cmbFiltro3.Visible = true;
                cmbFiltro4.Visible = false;
                //-
                txtFiltro2.Visible = true;
                txtFiltro3.Visible = true;
                txtFiltro4.Visible = false;
                //--
                btnAgregarFiltro1.Visible = false;
                btnAgregarFiltro2.Visible = false;
                btnAgregarFilrto3.Visible = true;
                btnQuitarFiltro2.Visible = false;
                btnQuitarFiltro3.Visible = true;
                btnQuitarFiltro4.Visible = false;
            }
            else if (filtro == 4)
            {
                cmbFiltro2.Visible = true;
                cmbFiltro3.Visible = true;
                cmbFiltro4.Visible = true;
                //-
                txtFiltro2.Visible = true;
                txtFiltro3.Visible = true;
                txtFiltro4.Visible = true;
                //--
                btnAgregarFiltro1.Visible = false;
                btnAgregarFiltro2.Visible = false;
                btnAgregarFilrto3.Visible = false;
                btnQuitarFiltro2.Visible = false;
                btnQuitarFiltro3.Visible = false;
                btnQuitarFiltro4.Visible = true;
            }
        
        }

        private bool validarFiltro() 
        {
            if (cmbFiltro2.Visible == true && (txtFiltro2.Text.Trim() == string.Empty || cmbFiltro2.Text.Trim() == string.Empty) )
            {
                MessageBox.Show("Ingrese un Valor para el filtro Dos");
                txtFiltro2.Focus();
                return false;
            }
            else if (cmbFiltro3.Visible== true && (txtFiltro3.Text.Trim() == string.Empty || cmbFiltro3.Text.Trim() == string.Empty) )
            {
                MessageBox.Show("Ingrese un Valor para el filtro Tres");
                txtFiltro3.Focus();
                return false;
            }
            else if (cmbFiltro4.Visible == true && (txtFiltro4.Text.Trim() == string.Empty || cmbFiltro4.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Ingrese un Valor para el filtro Cuatro");
                txtFiltro4.Focus();
                return false;
            }
            
            return true;
        }

        private void btnQuitarFiltro4_Click(object sender, EventArgs e)
        {
            habilitarFiltro(3);
        }

        private void btnAgregarFiltro1_Click(object sender, EventArgs e)
        {
            habilitarFiltro(2);
        }

        private void btnAgregarFiltro2_Click(object sender, EventArgs e)
        {
            habilitarFiltro(3);
        }

        private void btnQuitarFiltro2_Click(object sender, EventArgs e)
        {
            habilitarFiltro(1);
        }

        private void btnAgregarFilrto3_Click(object sender, EventArgs e)
        {
            habilitarFiltro(4);
        }

        private void btnQuitarFiltro3_Click(object sender, EventArgs e)
        {
            habilitarFiltro(2);
        }

        private string armarFiltro(string campo, string valor) 
        {
            string filtro = "";
            if (campo.Trim() == "Serial") filtro = " vistaEquipo.serial like '" + valor + "%' ";
            if (campo.Trim() == "Nit Cliente") filtro = " c.nitCliente like '" + valor + "%'";
            if (campo.Trim() == "Nombre Cliente") filtro = " c.nombreCliente like '" + valor + "%'";
            if (campo.Trim() == "Fabricante") filtro = " nombreFabricante like '" + valor + "%'";
            if (campo.Trim() == "Modelo") filtro = " nombreModelo like '" + valor + "%'";
            if (campo.Trim() == "Modalidad") filtro = " nombreModalidadEquipo like '" + valor + "%'";
            if (campo.Trim() == "Tipo de Equipo") filtro = " nombreTipoEquipo like '" + valor + "%'";
            if (campo.Trim() == "Sub Tipo de Equipo") filtro = "nombreSubTipo like '" + valor + "%'";
            if (campo.Trim() == "Socio de Negocio") filtro = "numeroSocio like '" + valor + "%'";
            if (campo.Trim() == "Tipo de Propiedad") filtro = "nombreTipoPropiedad like '" + valor + "%'";
            
            return filtro;
        }

        private string verOrden()
        {
            string filtro = "";
            if (cmbOrden.Text.Trim() == "Serial") filtro = " order by vistaEquipo.serial ";
            if (cmbOrden.Text.Trim() == "Nit Cliente") filtro = " order by  c.nitCliente ";
            if (cmbOrden.Text.Trim() == "Nombre Cliente") filtro = " order by  c.nombreCliente ";
            if (cmbOrden.Text.Trim() == "Fabricante") filtro = " order by  nombreFabricante ";
            if (cmbOrden.Text.Trim() == "Modelo") filtro = " order by  nombreModelo ";
            if (cmbOrden.Text.Trim() == "Modalidad") filtro = " order by  nombreModalidadEquipo ";
            if (cmbOrden.Text.Trim() == "Tipo de Equipo") filtro = " order by  nombreTipoEquipo ";
            if (cmbOrden.Text.Trim() == "Sub Tipo de Equipo") filtro = " order by nombreSubTipo ";
            if (cmbOrden.Text.Trim() == "Socio de Negocio") filtro = " order by c.numeroSocio ";

            
            return filtro;
        }

        private string armarFiltros()
        {
            string filtro = "";
            filtro = armarFiltro(cmbCampo.Text, txtFiltro.Text);
            if (cmbFiltro2.Visible) filtro += " AND " + armarFiltro(cmbFiltro2.Text, txtFiltro2.Text);
            if (cmbFiltro3.Visible) filtro += " AND " + armarFiltro(cmbFiltro3.Text, txtFiltro3.Text);
            if (cmbFiltro4.Visible) filtro += " AND " + armarFiltro(cmbFiltro4.Text, txtFiltro4.Text);
            return filtro;
        }

        private void btnAsignarTipoPropiedad_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns.Count <= 0) return;
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
            if (!verificadorPermisos.ejecutarAccionWindows(1119))
            {
                MessageBox.Show("No tiene permisos para ejecutar esta accion!");
                return;
            }
            //if (!seguimiento.Default.serial)
            //{
            //    MessageBox.Show("Para asignar el tipo de propiedad, debe traer el serial en la Consulta");
            //    return;
            //}

            spProcesos.Equipos.frmAsignarTipoPropiedad fr = new spProcesos.Equipos.frmAsignarTipoPropiedad();
            fr.serial = grdDatos.Columns["serial"].Text;

            if (fr.ShowDialog() == DialogResult.OK)
            {
                buscar(false);
            }
        }

        private void btnAsignarResponsable_Click(object sender, EventArgs e)
        {
              if (grdDatos.Columns.Count <= 0) return;
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
            
            frmSeleccionarUsuario fr = new frmSeleccionarUsuario();
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "update equipos set ultimo_responsable ='"+fr.login.Trim()+"' where serial ='" + grdDatos.Columns["serial"].Text.Trim() + "'";
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                bd.ejecutarComando(sql);
                buscar(false);
            }
        }

    }
}
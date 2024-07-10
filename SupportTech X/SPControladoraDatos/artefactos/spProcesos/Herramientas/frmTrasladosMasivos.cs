using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.Herramientas
{
    public partial class frmTrasladosMasivos : Form
    {
        public frmTrasladosMasivos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            //primero la informacion de origen
            if (cmbClienteOrigen.SelectedValue == null || cmbClienteOrigen.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Ingrese el Cliente de Origen");
                return false;
            }
            string nitOrigen = cmbClienteOrigen.SelectedValue.ToString().Trim();
            if (cmbSucursalOrigen.SelectedValue == null )
            {
                MessageBox.Show("Ingrese la Sucursal del Origen");
                return false;
            }
            if (nitOrigen != "local")
            {
                if (cmbModalidadOrigen.SelectedValue == null || cmbModalidadOrigen.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Ingrese la modalidad del Origen");
                    return false;
                }
            }
            else
            {
                if (cmbEstadoEquipoOrigen.SelectedValue == null || cmbEstadoEquipoOrigen.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Ingrese el Estado del Equipo de Origen");
                    return false;
                }
            }
            //informacion de destino
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Ingrese el Cliente de destino");
                return false;
            }
            string nitDEstio = cmbCliente.SelectedValue.ToString().Trim();
            if (cmbSucursalCliente.SelectedValue == null || cmbSucursalCliente.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Ingrese la Sucursal del destino");
                return false;
            }
            if (nitDEstio != "local")
            {
                if (!chkConservarOrigen.Checked && (cmbModaldad.SelectedValue == null || cmbModaldad.SelectedValue.ToString() == string.Empty))
                {
                    MessageBox.Show("Ingrese la modalidad del destino");
                    return false;
                }
            }else {
                if (!chkConservarOrigen.Checked && (cmbEstadoEquipoLocal.SelectedValue == null || cmbEstadoEquipoLocal.SelectedValue.ToString() == string.Empty))
                {
                    MessageBox.Show("Ingrese el Estado del Equipo");
                    return false;
                }
            }
            if (chkEnvioCliente.Checked && calUltimoEnvio.ValueObject == null)
            {
                MessageBox.Show("Ingrese la Fecha de Envio");
                return false;
            }
            return true;
        }

        private void guardar() 
        {
            string codModalidad = "";
            string estadoLocal = "";
            for (int k = 0; k < dsSpx1.vistaEquipo.Count; k++)
            {
                equiposTableAdapter1.FillBySerial(dsSpx1.equipos, dsSpx1.vistaEquipo[k].serial);
                if (cmbModaldad.Visible)
                {
                    if (!chkConservarOrigen.Checked)
                      codModalidad = cmbModaldad.SelectedValue.ToString();
                    else
                    {
                        if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
                        {
                            codModalidad = dsSpx1.equipos[0].codModalidadEquipo;
                        }
                        else
                        {
                            codModalidad = "";
                        }
                    }
                }
                else {
                    codModalidad = "";
                }

                if (cmbEstadoEquipoLocal.Visible)
                {
                    if (!chkConservarOrigen.Checked)
                        estadoLocal = cmbEstadoEquipoLocal.SelectedValue.ToString();
                    else
                    {
                        if (!dsSpx1.equipos[0].IscodEstadoLocalNull())
                        {
                            estadoLocal = dsSpx1.equipos[0].codEstadoLocal;
                        }
                        else
                        {
                            estadoLocal = "";
                        }
                    }
                }
                else
                {
                    estadoLocal = "";
                }
                    

                
                spProcesos.Herramientas.frmTrasladosDeEquipos.trasladar(
                    cmbCliente.SelectedValue.ToString(),
                cmbSucursalCliente.SelectedValue.ToString(),dsSpx1.equipos[0].serial,txtObservacionesIniciales.Text,
                chkEnvioCliente.Checked,calUltimoEnvio.Value,cmbModaldad.Visible,
                codModalidad,estadoLocal);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dsSpx1.vistaEquipo.Count <= 0)
            {
                MessageBox.Show("Para trasladar los equipos debe tener en la grilla por lo menos un Equipo!!!");
                return;
            }
            if(MessageBox.Show("Esta seguro de trasladar los "+dsSpx1.vistaEquipo.Count+" Equipos???","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)return;

            if (!validar()) return;
            guardar();
            DialogResult = DialogResult.OK;
            Close();
        }

    
        private void frmTrasladosDeEquipos_Load(object sender, EventArgs e)
        {
            dsSpx1.EnforceConstraints = false;
            btnSiguiente.Location = btnAceptar.Location;
            pnlInicio.Location = new Point(0, 0);
            pnlDos.Location = new Point(0, 0);

            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\segLayTraslMasivos.xs";
            if (System.IO.File.Exists(str))
            {
                grdEquipos.LoadLayout(str);
            }


            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            calUltimoEnvio.MonthCalendar.DisplayMonth = DateTime.Now;
            clientesTableAdapter1.FillByActivo(dsSpx2.clientes,true);
            sucursalClienteTableAdapter1.Fill(dsSpx2.sucursalCliente);
            modalidadEquipoTableAdapter1.Fill(dsSpx2.ModalidadEquipo);
            estadoLocalEquiposTableAdapter1.Fill(dsSpx2.estadoLocalEquipos);
            cmbSucursalCliente.SelectedValue = "";
            cmbCliente.SelectedValue = "";
            cmbModaldad.SelectedValue = "";
            //
            clientesTableAdapter1.FillByComboBox(dsSpx1.clientes);
            modalidadEquipoTableAdapter1.Fill(dsSpx1.ModalidadEquipo);
            estadoLocalEquiposTableAdapter1.Fill(dsSpx1.estadoLocalEquipos);
            //agregamos una fila a todas que diga Todas
            DataRow fila=dsSpx1.estadoLocalEquipos.NewRow();
            fila[0] = 0;
            fila[1] = "Todas";
            dsSpx1.estadoLocalEquipos.Rows.InsertAt(fila, 0);

            DataRow fila2 = dsSpx1.ModalidadEquipo.NewRow();
            fila2[0] = 0;
            fila2[1] = "Todas";
            dsSpx1.ModalidadEquipo.Rows.InsertAt(fila2, 0);

       



            cmbSucursalOrigen.SelectedValue = "";
            cmbClienteOrigen.SelectedValue = "";
            cmbModalidadOrigen.SelectedValue = "";
            
        }

        private void cargarSucursal()
        {
            txtDireccion.Text = "";
            txtPais.Text = "";
            txtDepartamento.Text = "";
            txtCiudad.Text = "";

            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedValue.ToString().Trim() != string.Empty)
            {
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx2.sucursalCliente, cmbCliente.SelectedValue.ToString());
            }
        }

        private void mostrarModalidad(bool valor)
        {
            if (valor)
            {
                lblSucursal.Text = "Sucursal";
            }
            else
            {
                lblSucursal.Text = "Bodega o Ubicacion";
            }
            lblEstadoEquipo.Location = lblModalidad.Location;
            cmbEstadoEquipoLocal.Location = cmbModaldad.Location;

            lblModalidad.Visible = valor;
            cmbModaldad.Visible = valor;
            lblEstadoEquipo.Visible = !valor;
            cmbEstadoEquipoLocal.Visible = !valor;
            txtCiudad.Visible = valor;
            txtDepartamento.Visible = valor;
            txtPais.Visible = valor;
            txtDireccion.Visible = valor;
           
            //
            lblCiudad.Visible = valor;
            lblDepartamento.Visible = valor;
            lblPais.Visible = valor;
            lblDireccion.Visible = valor;

        }

        private void cargarSucursalCliente()
        {
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString() == string.Empty)
            {
                mostrarModalidad(true);
                return;
            }

            //miramos si el cliente elegido es el taller local y ocultamos un combo y mostrmos el otro
            if (cmbCliente.SelectedValue.ToString().ToString().Trim() == "local")
            {
                mostrarModalidad(false);
            }
            else
            {
                mostrarModalidad(true);
            }


            if (cmbSucursalCliente.SelectedValue == null || cmbSucursalCliente.SelectedValue.ToString() == string.Empty)
                return;
            //if (cgDataControler1.verValor("codSucursalUbica") != null && (!cmbSucursalCliente.Enabled))
            //    cmbSucursalCliente.SelectedValue = cgDataControler1.verValor("codSucursalUbica");
            if (cmbSucursalCliente.SelectedValue == null) return;
            SPControladoraDatos.dsSpx.sucursalClienteDataTable tab =
            sucursalClienteTableAdapter1.GetDataByCodSucursalNit(cmbCliente.SelectedValue.ToString(), cmbSucursalCliente.SelectedValue.ToString());
            if (tab.Count > 0)
            {
                txtDireccion.Text = tab[0].IsDireccionNull() ? "" : tab[0].Direccion;
                if (!tab[0].IscodPaisNull())
                {
                    txtPais.Text = paisesTableAdapter1.verNombrePais(tab[0].codPais).ToString();

                    if (!tab[0].IscodDepartamentoNull())
                    {
                        txtDepartamento.Text = departamentoTableAdapter1.verNombreDepartamento(tab[0].codPais, tab[0].codDepartamento).ToString();

                        if (!tab[0].IscodCiudadNull())
                            txtCiudad.Text = ciudadesTableAdapter1.verNombreCiudad(tab[0].codPais, tab[0].codDepartamento, tab[0].codCiudad).ToString();
                    }
                }
            }
        }

        private void cargarSucursalOrigen()
        {
            if (cmbClienteOrigen.SelectedValue != null && cmbClienteOrigen.SelectedValue.ToString().Trim() != string.Empty)
            {
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, cmbClienteOrigen.SelectedValue.ToString());
                DataRow fila3 = dsSpx1.sucursalCliente.NewRow();
                fila3[0] = 0;
                fila3[1] = "";
                fila3[2] = "Todas";
                dsSpx1.sucursalCliente.Rows.InsertAt(fila3, 0);
                cmbSucursalOrigen.SelectedValue = "";
            }
        }

        private void mostrarModalidadOigen(bool valor)
        {
            if (valor)
            {
                lblSucursalOrigen.Text = "Sucursal";
            }
            else
            {
                lblSucursalOrigen.Text = "Bodega o Ubicacion";
            }
            lblEstadoEqupoOrigen.Location = label2.Location;
            cmbEstadoEquipoOrigen.Location = cmbModalidadOrigen.Location;

            label2.Visible = valor;
            cmbModalidadOrigen.Visible = valor;
            lblEstadoEqupoOrigen.Visible = !valor;
            cmbEstadoEquipoOrigen.Visible = !valor;
        }

        private void cargarSucursalClienteOrigen()
        {
            if (cmbClienteOrigen.SelectedValue == null || cmbClienteOrigen.SelectedValue.ToString() == string.Empty)
            {
                mostrarModalidadOigen(true);
                return;
            }

            //miramos si el cliente elegido es el taller local y ocultamos un combo y mostrmos el otro
            if (cmbClienteOrigen.SelectedValue.ToString().ToString().Trim() == "local")
            {
                mostrarModalidadOigen(false);
            }
            else
            {
                mostrarModalidadOigen(true);
            }
        }



        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscaCliente fc = new spProcesos.Equipos.frmBuscaCliente();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                cmbCliente.SelectedValue = fc.NitClente;
                cargarSucursal();
                cargarSucursalCliente();
            }
        }

        private void cmbSucursalCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSucursalCliente();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSucursal();
            cargarSucursalCliente();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            cmbCliente.SelectedValue = "";
            cmbSucursalCliente.SelectedValue = "";
            cargarSucursal();
        }

        private void btnBuscarNitorigen_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscaCliente fc = new spProcesos.Equipos.frmBuscaCliente();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                cmbClienteOrigen.SelectedValue = fc.NitClente;
                cargarSucursal();
                cargarSucursalCliente();
            }
        }

        private void cmbClienteOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSucursalOrigen();
            cargarSucursalClienteOrigen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbClienteOrigen.SelectedValue = "";
            cmbSucursalOrigen.SelectedValue = "";
            cargarSucursalOrigen();
        }

        string sqlTraerSentencia() 
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT      fabricante.nombre_fabricante,fabricante.nombre_fabricante nombrefabricante, ISNULL( Modelos.NombreModelo, '') AS NombreModelo, ISNULL( tipoEquipo.nombreTipoEquipo, '') AS nombreTipoEquipo,  ");
                      sb.Append(" ISNULL( subTipoEquipo.nombreSubTipo, '') AS nombreSubTipo, ISNULL( ModalidadEquipo.nombreModalidadEquipo, '') AS nombreModalidadEquipo,  ");
                      sb.Append(" ISNULL( estadoLocalEquipos.nombreEstadoLocal, '') AS nombreEstadoLocal,  clientes.nitCliente,  clientes.nombreCliente,  ");
                      sb.Append("  sucursalCliente.nombreSucursal,  paises.nombrePais,  departamento.NombreDepartamento,  ciudades.nombreCiudad,  equipos.serial,  ");
                      sb.Append("  equipos.fechaLlegada,  equipos.fechaSalida,  equipos.fechaProximoMante,  equipos.fechaUltimoMante,  equipos.codTipoServicio,  ");
                      sb.Append("  equipos.observacionesUltimoMante,  equipos.fechaProximaProgramacion ");
sb.Append(" FROM          equipos INNER JOIN ");
                      sb.Append("  fabricante ON  fabricante.codFabricante =  equipos.codFabricante INNER JOIN ");
                      sb.Append("  Modelos ON  Modelos.codFabricante =  equipos.codFabricante AND  Modelos.codModelo =  equipos.codModelo LEFT OUTER JOIN ");
                      sb.Append("  tipoEquipo ON  tipoEquipo.codTipoEquipo =  Modelos.codTipoEquipo LEFT OUTER JOIN ");
                      sb.Append("  subTipoEquipo ON  subTipoEquipo.codTipoEquipo =  Modelos.codTipoEquipo AND  ");
                      sb.Append("  subTipoEquipo.codSubtipoEquipo =  Modelos.codSubTipoEquipo LEFT OUTER JOIN ");
                      sb.Append("  ModalidadEquipo ON  ModalidadEquipo.codModalidadEquipo =  equipos.codModalidadEquipo LEFT OUTER JOIN ");
                      sb.Append("  estadoLocalEquipos ON  estadoLocalEquipos.codEstadoLocal =  equipos.codEstadoLocal LEFT OUTER JOIN ");
                      sb.Append("  clientes ON  clientes.nitCliente =  equipos.nitClienteUbica INNER JOIN ");
                      sb.Append("  sucursalCliente ON  sucursalCliente.nitCliente =  equipos.nitClienteUbica AND  ");
                      sb.Append("  sucursalCliente.codSucursal =  equipos.codSucursalUbica LEFT OUTER JOIN ");
                      sb.Append("  paises ON  paises.codPais =  sucursalCliente.codPais LEFT OUTER JOIN ");
                      sb.Append(" departamentos departamento ON  departamento.codPais =  sucursalCliente.codPais AND  ");
                      sb.Append("  departamento.codDepartamento =  sucursalCliente.codDepartamento LEFT OUTER JOIN ");
                      sb.Append("  ciudades ON  ciudades.codPais =  sucursalCliente.codPais AND  ciudades.codDepartamento =  sucursalCliente.codDepartamento AND  ");
                      sb.Append("  ciudades.codCiudad =  sucursalCliente.codCiudad ");
            return sb.ToString();
        }

        private void btnTraerEquipos_Click(object sender, EventArgs e)
        {

            if (cmbClienteOrigen.SelectedValue == null || cmbClienteOrigen.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione Un Cliente");
                return;
            }
            string sql = sqlTraerSentencia();
            sql = sql + " WHERE clientes.nitcliente='" + cmbClienteOrigen.SelectedValue.ToString() + "' ";
            if (cmbClienteOrigen.SelectedValue == null || cmbClienteOrigen.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione Una Sucursal.");
                return;
            }
            if (cmbModalidadOrigen.Visible && (cmbModalidadOrigen.SelectedValue == null || cmbModalidadOrigen.SelectedValue.ToString().Trim() == string.Empty))
            {
                MessageBox.Show("Seleccione Una Modalidad.");
                return;
            }
            if (cmbEstadoEquipoOrigen.Visible && (cmbEstadoEquipoOrigen.SelectedValue == null || cmbEstadoEquipoOrigen.SelectedValue.ToString().Trim() == string.Empty))
            {
                MessageBox.Show("Seleccione Un Estado Local");
                return;
            }
            if (cmbSucursalOrigen.Text.ToUpper().Trim() != "TODAS")
            {
                sql = sql + " AND nombreSucursal='" + cmbSucursalOrigen.Text.Trim()+"'";
            }
            if (cmbModalidadOrigen.Visible && cmbModalidadOrigen.Text.ToUpper().Trim() != "TODAS")
            {
                sql = sql + " AND nombreModalidadEquipo='" + cmbModalidadOrigen.Text.Trim() + "'";
            }
            if (cmbEstadoEquipoOrigen.Visible && cmbEstadoEquipoOrigen.Text.ToUpper().Trim() != "TODAS")
            {
                sql = sql + " AND nombreEstadoLocal='" + cmbEstadoEquipoOrigen.Text.Trim() + "'";
            }


            dsSpx1.vistaEquipo.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.vistaEquipo.Merge( objData.ejecutarConsulta(sql).Tables[0]);
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pnlDos.Visible = true;
            pnlInicio.Visible = false;
            btnSiguiente.Visible = false;
            btnAceptar.Visible = true;
            btnAnterior.Visible = true;
            pnlDos.BringToFront();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pnlDos.Visible = false;
            pnlInicio.Visible = true;
            btnSiguiente.Visible = true;
            btnAceptar.Visible = false;
            btnAnterior.Visible = false;
            pnlInicio.BringToFront();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdEquipos, "Listado de Equipos a Trasladar", false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dsSpx1.vistaEquipo.Clear();
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            //guardamos la configuracion de la grilla
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\segLayTraslMasivos.xs";
            grdEquipos.SaveLayout(str);
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\segLayTraslMasivos.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Se reinicio la configuracion de las columnas\nPara ver los cambios reinice el formulario!!!");
          
        }

        private void btnBorrarRegistro_Click(object sender, EventArgs e)
        {
            dsSpx1.vistaEquipo.Rows.Remove(dsSpx1.vistaEquipo.Select("serial = '"+grdEquipos.Columns["serial"].Text+"'")[0]);
        }

    }
}

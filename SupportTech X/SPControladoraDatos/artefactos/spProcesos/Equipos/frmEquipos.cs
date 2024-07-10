using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmEquipos : CgDataFrm.frmModelo
    {
        public frmEquipos()
        {
            InitializeComponent();
            cgDataControler1.ModuloSeguridad = 1116;
        }

        private string serialEquipo = "";
        public string SerialEquipo { set { serialEquipo = value; } get { return serialEquipo; } }

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            cargarModelos();
        }
        private bool eventosEncendidos = true;

        private void cargarFechas()
        {
            object a = cgDataControler1.verValor("fechaLlegada");
            if (a == null || a == System.DBNull.Value)
            {
                calFechaLlegada.ValueObject = null;
            }
            else
            {
                calFechaLlegada.Value = (DateTime)a;
            }
            //ok
            a = cgDataControler1.verValor("fechaSalida");
            if (a == null || a == System.DBNull.Value)
            {
                calFechaSalida.ValueObject = null;
            }
            else
            {
                calFechaSalida.Value = (DateTime)a;
            }
            //ok
            a = cgDataControler1.verValor("fechaUltimoMante");
            if (a == null || a == System.DBNull.Value)
            {
                calFechaUltimoManteni.ValueObject = null;
            }
            else
            {
                calFechaUltimoManteni.Value = (DateTime)a;
            }
            //ok
            a = cgDataControler1.verValor("fechaProximoMante");
            if (a == null || a == System.DBNull.Value)
            {
                calFechaProximoman.ValueObject = null;
            }
            else
            {
                calFechaProximoman.Value = (DateTime)a;
            }
            //ok
            a = cgDataControler1.verValor("fechaUltimoTraslado");
            if (a == null || a == System.DBNull.Value)
            {
                calTraslado.ValueObject = null;
            }
            else
            {
                calTraslado.Value = (DateTime)a;
            }
        }

        private void cargarModelos()
        {
            if (cmbFabricante.SelectedValue != null && cmbFabricante.SelectedValue.ToString().Trim() != string.Empty)
            {
                if (eventosEncendidos)
                {
                    modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx1.Modelos, cmbFabricante.SelectedValue.ToString());
                    if (dsSpx1.Modelos.Rows.Count > 0 && (!txtSerial.ReadOnly && txtSerial.Enabled))
                        cmbModelo.SelectedIndex = 0;
                    //ahora ponemos el combo segun loq eu exista en los datos
                    if (cgDataControler1.verValor("codModelo") != null)
                        cmbModelo.SelectedValue = cgDataControler1.verValor("codModelo");
                }
            }
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            //verficamos los permisos 1116
            tiposArchivoXequipoTableAdapter1.Fill(dsSpx1.TiposArchivoXequipo);
            tipoPropiedadTableAdapter1.Fill(dsSpx1.tipoPropiedad);
            calFechaLlegada.MonthCalendar.DisplayMonth = DateTime.Now;
            calFechaProximoman.MonthCalendar.DisplayMonth = DateTime.Now;
            calFechaSalida.MonthCalendar.DisplayMonth = DateTime.Now;
            calFechaUltimoManteni.MonthCalendar.DisplayMonth = DateTime.Now;
            calTraslado.MonthCalendar.DisplayMonth = DateTime.Now;

            eventosEncendidos = false;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "equipos"] as CurrencyManager);
            cgDataControler1.FiltroObligatorio = "eliminado_por is null";
            modalidadEquipoTableAdapter1.Fill(dsSpx1.ModalidadEquipo);
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            estadoLocalEquiposTableAdapter1.Fill(dsSpx1.estadoLocalEquipos);
            cargarModelos();
            cgDataControler1.TableAdapter = equiposTableAdapter1;
            clientesTableAdapter1.FillByComboBox(dsSpx1.clientes);
            if (serialEquipo.Trim() == string.Empty)
                equiposTableAdapter1.FillByTop100(dsSpx1.equipos);
            else
                equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serialEquipo);
            eventosEncendidos = true;
            cargarFechas();
            cargarModelos();
            cargarSucursal();
            cargarSucursalCliente();
            cargarInformacionEquipo();
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
            txtDireccion.Visible = valor;
            txtTelefono1.Visible = valor;
            txtTelefono2.Visible = valor;
            //
            lblCiudad.Visible = valor;
            lblDireccion.Visible = valor;
            lblTelefono1.Visible = valor;
            lblTelefono2.Visible = valor;
        }

        private void cargarSucursalCliente()
        {
            if (!eventosEncendidos) return;
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
            if (cgDataControler1.verValor("codSucursalUbica") != null && (!cmbSucursalCliente.Enabled))
                cmbSucursalCliente.SelectedValue = cgDataControler1.verValor("codSucursalUbica");
            if (cmbSucursalCliente.SelectedValue == null) return;
            SPControladoraDatos.dsSpx.sucursalClienteDataTable tab =
            sucursalClienteTableAdapter1.GetDataByCodSucursalNit(cmbCliente.SelectedValue.ToString(), cmbSucursalCliente.SelectedValue.ToString());
            if (tab.Count > 0)
            {
                txtDireccion.Text = tab[0].IsDireccionNull() ? "" : tab[0].Direccion;
                txtTelefono1.Text = tab[0].IsTelefono1Null() ? "" : tab[0].Telefono1;
                txtTelefono2.Text = tab[0].IsTelefono2Null() ? "" : tab[0].Telefono2;
                string ciudad = "";
                string pais = "";
                string depar = "";
                if (!tab[0].IscodPaisNull())
                {
                    pais = "(" + paisesTableAdapter1.verNombrePais(tab[0].codPais).ToString() + ")";

                    if (!tab[0].IscodDepartamentoNull())
                    {
                        depar = departamentoTableAdapter1.verNombreDepartamento(tab[0].codPais, tab[0].codDepartamento).ToString();

                        if (!tab[0].IscodCiudadNull())
                            ciudad = ciudadesTableAdapter1.verNombreCiudad(tab[0].codPais, tab[0].codDepartamento, tab[0].codCiudad).ToString();
                    }
                }
                txtCiudad.Text = ciudad + "," + depar + " " + pais;
                // Bogota, Cundinamarca (Colombia)
            }
        }

        private void cargarSucursal()
        {
            if (!eventosEncendidos) return;
            txtDireccion.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtCiudad.Text = "";
            if (cgDataControler1.verValor("nitClienteUbica") != null && cgDataControler1.verValor("nitClienteUbica") != System.DBNull.Value)
            {
                cmbCliente.SelectedValue = cgDataControler1.verValor("nitClienteUbica").ToString();
            }


            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedValue.ToString().Trim() != string.Empty)
            {
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, cmbCliente.SelectedValue.ToString());
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            cargarSucursal();
            cargarSucursalCliente();
        }

        private void cmbSucursalCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            cargarSucursalCliente();
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            if (txtSerial.ReadOnly || !txtSerial.Enabled)
            {
                cargarFechas();
                cargarModelos();
                cargarInformacioncliente();
                cargarSucursal();
                cargarSucursalCliente();
                cargarInformacionEquipo();
            }
        }

        private void cargarInformacioncliente()
        {
            if (cgDataControler1.verValor("nitClienteUbica") == null) return;
            string nit = cgDataControler1.verValor("nitClienteUbica").ToString();
            cmbCliente.SelectedValue = nit;

            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, nit);
            cmbSucursalCliente.SelectedValue = cgDataControler1.verValor("codSucursalUbica").ToString();
        }

        private bool validar()
        {

            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar el codigo del serial");
                txtSerial.Focus();
                return false;
            }
            if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El fabricante es obligatorio");
                cmbFabricante.Focus();
                return false;
            }
            if (cmbModelo.SelectedValue == null || cmbModelo.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El Modelo es obligatorio");
                cmbModelo.Focus();
                return false;
            }
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El Cliente es Obligatorio.");
                cmbCliente.Focus();
                return false;
            }
            if (cmbSucursalCliente.SelectedValue == null || cmbSucursalCliente.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La sucursal donde esta el equipo es Obligatorio.");
                cmbCliente.Focus();
                return false;
            }
            if (cmbCliente.SelectedValue.ToString().ToUpper().Trim() == "LOCAL")
            {
                if (cmbEstadoEquipoLocal.SelectedValue == null || cmbEstadoEquipoLocal.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("El estado Local es obligatorio");
                    cmbEstadoEquipoLocal.Focus();
                    return false;
                }
            }
            else
            {
                //validamos que tenga modalidad obligatoriamente
                if (cmbModaldad.SelectedValue == null || cmbModaldad.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("La modalidad es obligatoria");
                    cmbModaldad.Focus();
                    return false;
                }
            }


            return true;
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            //validamos
            if (!validar())
            {
                e.Cancelar = true;
                return;
            }



            eventosEncendidos = false;
            cgDataControler1.asignarValor("codModelo", cmbModelo.SelectedValue);
            cgDataControler1.asignarValor("nitClienteUbicacionReal", cmbCliente.SelectedValue);
            cgDataControler1.asignarValor("nitClienteUbica", cmbCliente.SelectedValue);
            cgDataControler1.asignarValor("codSucursalUbica", cmbSucursalCliente.SelectedValue);
            cgDataControler1.asignarValor("codSucursalUbicaReal", cmbSucursalCliente.SelectedValue);


            if (calFechaLlegada.ValueObject == null)
            {
                cgDataControler1.asignarValor("fechaLlegada", DBNull.Value);
            }
            else
            {
                cgDataControler1.asignarValor("fechaLlegada", calFechaLlegada.ValueObject);
            }

            if (calFechaSalida.ValueObject == null)
            {
                cgDataControler1.asignarValor("fechaSalida", DBNull.Value);
            }
            else
            {
                cgDataControler1.asignarValor("fechaSalida", calFechaSalida.ValueObject);
            }

            if (calFechaProximoman.ValueObject == null)
            {
                cgDataControler1.asignarValor("fechaProximoMante", DBNull.Value);
            }
            else
            {
                cgDataControler1.asignarValor("fechaProximoMante", calFechaProximoman.ValueObject);
            }

            if (calFechaUltimoManteni.ValueObject == null)
            {
                cgDataControler1.asignarValor("fechaUltimoMante", DBNull.Value);
            }
            else
            {
                cgDataControler1.asignarValor("fechaUltimoMante", calFechaUltimoManteni.ValueObject);
            }
            //le quitamos los espacios al serial para evitar problemas en las busquedas
            cgDataControler1.asignarValor("serial", txtSerial.Text.Trim());
            eventosEncendidos = true;

        }

        private void ribbonControlDataFrm_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (ribbonControlDataFrm.SelectedRibbonTabItem.Text.ToUpper().IndexOf("CONTRATO") >= 0)
            {
                if (txtSerial.ReadOnly == true || txtSerial.Enabled == false)
                {
                    contratosxEquipoTableAdapter1.FillBySerial(dsSpx1.contratosxEquipo, txtSerial.Text);
                }
            }

            if (ribbonControlDataFrm.SelectedRibbonTabItem.Text.ToUpper().IndexOf("LISTADO") >= 0)
            {
                cargarEstadisticas();
            }

            if (ribbonControlDataFrm.SelectedRibbonTabItem.Text.ToUpper().IndexOf("ARCHIVO") >= 0)
            {

                if (txtSerial.ReadOnly == true || txtSerial.Enabled == false)
                {
                    archivosXequipoTableAdapter1.FillBySerial(dsSpx1.archivosXequipo, txtSerial.Text);
                }
            }
        }
        #region zona de archivos
        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null || grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            try
            {
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    grdArchivos.Columns["nombreArchivo"].Value.ToString());

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosXequipoTableAdapter1.verArchivo(txtSerial.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
                writer.Write(arr);
                writer.Close();
                //despues de creado lo abrimos
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = nombreArchivo;
                //p.StartInfo.CreateNoWindow=true;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                p.StartInfo.WorkingDirectory = nombreArchivo.Replace(System.IO.Path.GetFileName(nombreArchivo), "");
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo\n " + ex.Message);
            }
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null || grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            saveFileDialog1.FileName = grdArchivos.Columns["nombreArchivo"].Value.ToString();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string nombreArchivo = saveFileDialog1.FileName;

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])archivosXequipoTableAdapter1.verArchivo(txtSerial.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));

                writer.Write(arr);
                writer.Close();
                MessageBox.Show("Archivo Guardado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo \n" + ex.Message);
            }
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //
            Equipos.frmAgregaArchivoxEquipo frm = new spProcesos.Equipos.frmAgregaArchivoxEquipo();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName
                    , System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);

                byte[] archivo = new byte[fs.Length];
                fs.Read(archivo, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                string nombre = openFileDialog1.FileName.Trim();
                if (nombre.Length >= 150) nombre = nombre.Substring(0, 150);
                string mensaje = frm.observaciones.Trim();
                if (mensaje.Length >= 250) mensaje = mensaje.Substring(0, 250);

                int codArchivo = int.Parse(archivosXequipoTableAdapter1.verSiguienteId(txtSerial.Text).ToString());
                archivosXequipoTableAdapter1.Insert(
                    txtSerial.Text, codArchivo, System.IO.Path.GetFileName(nombre), archivo, mensaje, frm.tipoArchivo);
                //cargaqmos los archivos
                archivosXequipoTableAdapter1.FillBySerial(
                  dsSpx1.archivosXequipo, txtSerial.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null ||
        grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el archivo relacionado al equipo", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;


            archivosXequipoTableAdapter1.DeleteArchivo(txtSerial.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
            //cargamos la grilla
            archivosXequipoTableAdapter1.FillBySerial(
            dsSpx1.archivosXequipo, txtSerial.Text);
        }

        #endregion

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            btnSubirArchivo.Enabled = cgDataControler1.EstadoControles;
            btnSubirArchivo.Enabled = cgDataControler1.EstadoControles;

            cmbCliente.Enabled = cgDataControler1.EstadoControles;
            cmbSucursalCliente.Enabled = cgDataControler1.EstadoControles;

            //
            btnBuscarNit.Enabled = cgDataControler1.EstadoControles;
            btnLimpiarCliente.Enabled = cgDataControler1.EstadoControles;
            //equipos auxiliares
            btnAgregarAuxiliar.Enabled = cgDataControler1.EstadoControles;
            btnModificarAuxiliar.Enabled = cgDataControler1.EstadoControles;
            btnEliminarAuxiliar.Enabled = cgDataControler1.EstadoControles;
            //
            calTraslado.Enabled = false;
            calFechaLlegada.Enabled = cgDataControler1.EstadoControles;
            calFechaSalida.Enabled = cgDataControler1.EstadoControles;
            calFechaUltimoManteni.Enabled = cgDataControler1.EstadoControles;
            calFechaProximoman.Enabled = cgDataControler1.EstadoControles;
            //--
            cmbTipoPropiedad.Enabled = false;
        }

        private void cgDataControler1_AntesDeEliminar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            //
            if (MessageBox.Show("Esta seguro de eliminar el equipo", "Confirmacion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje fr = new SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje();
                fr.titulo = "Confirmacion Eliminacion de equipo";
                fr.pregunta = "Ingrese la razon de eliminacion";
                fr.ShowDialog();
                string msg = fr.mensaje;
                equiposTableAdapter1.UpdateEliminado(SPXSeguridad.logica.sesion.CodUsuarioAutenticado, DateTime.Now, "", txtSerial.Text.Trim());
                eventosEncendidos = false;
                if (serialEquipo.Trim() == string.Empty)
                    equiposTableAdapter1.FillByTop100(dsSpx1.equipos);
                else
                    equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serialEquipo);
                eventosEncendidos = true;
            }
            e.Cancelar = true;

        }

        private void cgDataControler1_DespuesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            clientesTableAdapter1.FillByComboBox(dsSpx1.clientes);
            cmbCliente.SelectedValue = cgDataControler1.verValor("nitClienteUbica");
            eventosEncendidos = true;
            // cargarSucursalCliente();
            cargarSucursal();

            cargarSucursalCliente();
        }

        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            Equipos.frmBuscaCliente fc = new frmBuscaCliente();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                cmbCliente.SelectedValue = fc.NitClente;
                cargarSucursal();
                cargarSucursalCliente();
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            eventosEncendidos = false;
            cmbCliente.SelectedValue = "";
            cmbSucursalCliente.SelectedValue = "";
            eventosEncendidos = true;
            cargarSucursal();
        }

        private void cgDataControler1_AntesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            GC.Collect();
            txtCreadorPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
        }

        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            if (txtSerial.Enabled && !txtSerial.ReadOnly)
            {// entra a este if si el registro que esta aceptando es nuevo
                SPControladoraDatos.dsSpx dsAppTmp = new SPControladoraDatos.dsSpx();
                equiposTableAdapter1.FillBySerial(dsAppTmp.equipos, txtSerial.Text.Trim());
                if (dsAppTmp.equipos.Rows.Count > 0)
                {
                    MessageBox.Show("El serial " + txtSerial.Text.Trim() + " ya existe en la base de datos", "Alerta");
                    e.Cancel = true;
                }
            }
        }

        private void cgDataControler1_AntesDeModificar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            eventosEncendidos = false;
        }

        private void cgDataControler1_DespuesDeModificar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            eventosEncendidos = true;
            //deshabilitamos los combos de ubicacion
            cmbCliente.Enabled = false;
            cmbSucursalCliente.Enabled = false;
            btnLimpiarCliente.Enabled = false;
            btnBuscarNit.Enabled = false;
            cmbSucursalCliente.Enabled = false;
            cmbEstadoEquipoLocal.Enabled = false;
        }

        private void cargarEstadisticas()
        {
            txtTotalEquipos.Text = equiposTableAdapter1.totalEquipos().ToString();
            txtEquiposEnTaller.Text = equiposTableAdapter1.totalEquiposLocales().ToString();
            txtEquiposEnClientes.Text = equiposTableAdapter1.verTotalEquposEnClientes().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbModaldad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            if (txtSerial.Enabled == true && !txtSerial.ReadOnly) return;
            Equipos.frmInformacionEquipo objFr = new frmInformacionEquipo();
            objFr.Serial = txtSerial.Text;
            objFr.ShowDialog();
        }

        private void btnAgregarAuxiliar_Click(object sender, EventArgs e)
        {
            if (!txtSerial.ReadOnly || txtSerial.Enabled == true)
            {
                MessageBox.Show("Guarde pimero el encabezado del equipo luego si configure los equipos auxiliares.");
                return;
            }
            Equipos.frmEquipoAuxiliar frmObj = new frmEquipoAuxiliar();
            frmObj.SerialEquipo = txtSerial.Text;
            if (frmObj.ShowDialog() == DialogResult.OK)
            {
                equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, txtSerial.Text);
            }
        }

        private void btnModificarAuxiliar_Click(object sender, EventArgs e)
        {
            if (grdAuxiliares.Columns["serialAuxiliar"].Text.Trim() == string.Empty) return;
            Equipos.frmEquipoAuxiliar frmObj = new frmEquipoAuxiliar();
            ///serial
            ///serial auxiliar
            frmObj.SerialEquipo = txtSerial.Text;
            frmObj.SerialAuxiliar = grdAuxiliares.Columns["serialAuxiliar"].Text.Trim();
            if (frmObj.ShowDialog() == DialogResult.OK)
            {
                equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, txtSerial.Text);
            }
        }

        private void btnEliminarAuxiliar_Click(object sender, EventArgs e)
        {
            if (grdAuxiliares.Columns["serialAuxiliar"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de eliminar este equipo auxiliar", "Pregunta", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            equipoAuxiliarTableAdapter1.DeleteQuery(txtSerial.Text, grdAuxiliares.Columns["serialAuxiliar"].Text.Trim());
            equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, txtSerial.Text);
        }

        private void btnInformacionAuxiliar_Click(object sender, EventArgs e)
        {
            if (grdAuxiliares.Columns["serialAuxiliar"].Text.Trim() == string.Empty) return;
            Equipos.frmInformacionEquipo objFrm = new frmInformacionEquipo();
            objFrm.Serial = grdAuxiliares.Columns["serialAuxiliar"].Text.Trim();
            objFrm.ShowDialog();
        }

        private void cargarInformacionEquipo()
        {

            if (cgDataControler1.verValor("fecha_creacion") != null && cgDataControler1.verValor("fecha_creacion") != System.DBNull.Value)
            {
                calCreacion.Value = (DateTime)cgDataControler1.verValor("fecha_creacion");
            }

            if (cgDataControler1.verValor("creado_por") != null && cgDataControler1.verValor("creado_por") != System.DBNull.Value)
            {
                string sql = "select nombre from usuario where cod_usuario = " + cgDataControler1.verValor("creado_por");
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                txtCreadorPor.Text = bd.ejecutarProcedimiento(sql).ToString();
            }
            equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, txtSerial.Text);
        }

        private void cgDataControler1_AntesDeBuscar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            eventosEncendidos = false;
        }

        private void cgDataControler1_DespuesDeBuscar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            eventosEncendidos = true;
            if (txtSerial.ReadOnly || !txtSerial.Enabled)
            {
                cargarModelos();
                cargarSucursal();
                cargarSucursalCliente();
                cargarInformacionEquipo();
            }

        }

        private void cgDataControler1_EliminarLlaves(object sender, CGDataControler.dataControlerEventArgs e)
        {
            eventosEncendidos = false;
            //eliminamos los archivos
            archivosXequipoTableAdapter1.DeleteBySerial(txtSerial.Text);
            contratosxEquipoTableAdapter1.DeleteContratosBySerialEquipo(txtSerial.Text);
        }

        private void cgDataControler1_DespuesDeEliminar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            eventosEncendidos = true;
            if (txtSerial.ReadOnly || !txtSerial.Enabled)
            {
                cargarModelos();
                cargarSucursal();
                cargarSucursalCliente();
                cargarInformacionEquipo();
            }
        }

        private void cgDataControler1_DespuesDeCancelar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            clientesTableAdapter1.FillByComboBox(dsSpx1.clientes);
            cmbCliente.SelectedValue = cgDataControler1.verValor("nitClienteUbica");
            cargarInformacionEquipo();
        }

        private void cgDataControler1_DespuesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            clientesTableAdapter1.FillByActivo(dsSpx1.clientes, true);

            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedValue.ToString().Trim() != string.Empty)
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, cmbCliente.SelectedValue.ToString());

            cmbSucursalCliente.SelectedIndex = -1;
            //
            cgDataControler1.asignarValor("creado_por", SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
            cgDataControler1.asignarValor("fecha_creacion", DateTime.Now);
        }
    }
}


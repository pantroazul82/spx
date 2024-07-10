using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmSolicitarPrestamo : Form
    {
        public frmSolicitarPrestamo()
        {
            InitializeComponent();
        }

        public int codOrdenServicio = 0;

        private void frmSolicitarPrestamo_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            calFechaCreacion.MonthCalendar.DisplayMonth = dc.fechaServer;
            eventosEncendidos = false;
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            if (codOrdenServicio != 0)
            {
                txtCodOrdenservicio.Text = codOrdenServicio.ToString();
                #region zona de ciudades
                //ocultamos la localizacion y cargamos la ciudad donde se ejecuta la orden de servicio
                grpUbicacion.Visible = false;
                ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, codOrdenServicio);
                string nitCliente = dsSpx1.ordenServicio[0].nitCliente;
                string codSucursal = dsSpx1.ordenServicio[0].codSucursal;
                sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, nitCliente, codSucursal);
                paisesTableAdapter1.Fill(dsSpx1.paises);
                cmbPais.SelectedValue = dsSpx1.sucursalCliente[0].codPais;
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
                cmbDepartamento.SelectedValue = dsSpx1.sucursalCliente[0].codDepartamento;
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(), cmbDepartamento.SelectedValue.ToString());
                cmbCiudad.SelectedValue = dsSpx1.sucursalCliente[0].codCiudad;
                #endregion

            }
            else { 
               //cargamos la ciudad por defecto
                lblCodOrden.Visible = false;
                txtCodOrdenservicio.Visible = false;
                #region zona de ciudades
                paisesTableAdapter1.Fill(dsSpx1.paises);
                defaultsTableAdapter1.Fill(dsSpx1.defaults);
                cmbPais.SelectedValue = dsSpx1.defaults[0].codPais;
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
                cmbDepartamento.SelectedValue = dsSpx1.defaults[0].codDepartamento;
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(), cmbDepartamento.SelectedValue.ToString());
                cmbCiudad.SelectedValue = dsSpx1.defaults[0].codCiudad;
                #endregion
            }
           // SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            calFechaCreacion.Value = dc.fechaServer;
            txtNumeroOrdenPrestamo.Text = ordenPrestamoTableAdapter1.verNextId().Value.ToString();
            txtElaboradoPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;

            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            cmbResponsable.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
            //si no tiene el permis--o de asignarsela a otros se bloquea el combo
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1080))
            {
                cmbResponsable.Enabled = false;
            }
            eventosEncendidos = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            programacion.frmRepuesto frmTmp = new programacion.frmRepuesto();

            if (frmTmp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                        SPControladoraDatos.dsSpx.pltRepuestosxOrdenPrestamoRow fila =
                        dsSpx1.pltRepuestosxOrdenPrestamo.NewpltRepuestosxOrdenPrestamoRow();
                        //
                        repuestosTableAdapter1.FillBycodRepuesto(dsSpx1.repuestos, frmTmp.codigoRepuesto);
                        fila.codOrdenPrestamo = int.Parse(txtNumeroOrdenPrestamo.Text);
                        fila.cantidadSolicitada = frmTmp.cantidad;
                        fila.codRepuesto = frmTmp.codigoRepuesto;
                        fila.descripcion = (dsSpx1.repuestos[0].IsdescripcionNull()) ? "" : dsSpx1.repuestos[0].descripcion;
                        fila.Observaciones = (dsSpx1.repuestos[0].IsObservacionesNull()) ? "" : dsSpx1.repuestos[0].Observaciones;
                        fila.precio = (dsSpx1.repuestos[0].IsprecioNull()) ? 0 : dsSpx1.repuestos[0].precio;
                        if (dsSpx1.pltRepuestosxOrdenPrestamo.Select("codRepuesto='" + frmTmp.codigoRepuesto + "'").Length <= 0)
                        dsSpx1.pltRepuestosxOrdenPrestamo.AddpltRepuestosxOrdenPrestamoRow(fila);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese de no ingresar dos veces el mismo codigo de repuesto a la orden de prestamo \n" + ex.Message);
                }
            }

        }

        private void btnModificarRepuestos_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty)
                return;

                programacion.frmRepuesto fr = new programacion.frmRepuesto();
                fr.codigoRepuesto = grdRepuestos.Columns["codRepuesto"].Text.Trim();
                fr.cantidad = int.Parse(grdRepuestos.Columns["cantidadSolicitada"].Text.Trim());
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    //primero la quitamos
                    dsSpx1.pltRepuestosxOrdenPrestamo.Rows.Remove
    (dsSpx1.pltRepuestosxOrdenPrestamo.Select("codRepuesto='" + grdRepuestos.Columns["codRepuesto"].Text.Trim() + "'")[0]);
                    //luego agregamos de nuevo la fila
                    SPControladoraDatos.dsSpx.pltRepuestosxOrdenPrestamoRow fila =
                     dsSpx1.pltRepuestosxOrdenPrestamo.NewpltRepuestosxOrdenPrestamoRow();
                    //
                    repuestosTableAdapter1.FillBycodRepuesto(dsSpx1.repuestos, fr.codigoRepuesto);
                    fila.codOrdenPrestamo = int.Parse(txtNumeroOrdenPrestamo.Text);
                    fila.cantidadSolicitada = fr.cantidad;
                    fila.codRepuesto = fr.codigoRepuesto;
                    fila.descripcion = (dsSpx1.repuestos[0].IsdescripcionNull()) ? "" : dsSpx1.repuestos[0].descripcion;
                    fila.Observaciones = (dsSpx1.repuestos[0].IsObservacionesNull()) ? "" : dsSpx1.repuestos[0].Observaciones;
                    fila.precio = (dsSpx1.repuestos[0].IsprecioNull()) ? 0 : dsSpx1.repuestos[0].precio;
                    if (dsSpx1.pltRepuestosxOrdenPrestamo.Select("codRepuesto='" + fr.codigoRepuesto + "'").Length <= 0)
                        dsSpx1.pltRepuestosxOrdenPrestamo.AddpltRepuestosxOrdenPrestamoRow(fila);
                }
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty)
                return;

            if (MessageBox.Show("Esta seguro de eliminar este repuesto de la orden", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }

                dsSpx1.pltRepuestosxOrdenPrestamo.Rows.Remove
                    (dsSpx1.pltRepuestosxOrdenPrestamo.Select("codRepuesto='" + grdRepuestos.Columns["codRepuesto"].Text.Trim() + "'")[0]);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos
            if (codOrdenServicio == 0)
            {
                if (cmbCiudad.SelectedValue == null || cmbCiudad.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la ciudad.");
                    return;
                }
            }
            if (dsSpx1.pltRepuestosxOrdenPrestamo.Count <= 0)
            {
                MessageBox.Show("Por lo menos debe ingresar un repuesto.");
                return;
            }
            //creamos la orden
            Nullable<DateTime> fechaNullo = new Nullable<DateTime>();
            Nullable<int> intNullo = new Nullable<int>();
            int cod=ordenPrestamoTableAdapter1.verNextId().Value;
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            ordenPrestamoTableAdapter1.Insert(cod,
                cmbResponsable.SelectedValue.ToString(), SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, null, null, null, null, dc.fechaServer,
                fechaNullo, cmbPais.SelectedValue.ToString(), cmbDepartamento.SelectedValue.ToString(), cmbCiudad.SelectedValue.ToString(),
                (codOrdenServicio == 0) ? intNullo : codOrdenServicio, false, txtObservaciones.Text, "", "", "",1,"","",
                (txtSerial.Text.Trim() == string.Empty)?null:txtSerial.Text.Trim(),txtObservacionesEquipo.Text);

            for (int k = 0; k < dsSpx1.pltRepuestosxOrdenPrestamo.Count; k++)
            {
                repuestosxOrdenPrestamoTableAdapter1.Insert(cod, dsSpx1.pltRepuestosxOrdenPrestamo[k].codRepuesto,
                    false, false, false, "", fechaNullo, fechaNullo, fechaNullo, dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadSolicitada,
                    0, 0, 0);
            }
            dsSpx1.EnforceConstraints = false;
            ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, cod);
            #region zona de notificacion
          //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
          //  mailsender.EjecutarAccion(301, cmbResponsable.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.OrdenPrestamo[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
            #endregion
            DialogResult = DialogResult.OK;
            Close();
        }

        bool eventosEncendidos = true;
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            eventosEncendidos = false;
            if (cmbPais.SelectedValue != null && cmbPais.SelectedValue.ToString().Trim() != string.Empty)
            {
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
                cmbDepartamento.SelectedValue = "-1";
                dsSpx1.ciudades.Clear();
            }else {
                dsSpx1.departamento.Clear();
                dsSpx1.ciudades.Clear();
            }
            eventosEncendidos = true;
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            if (cmbPais.SelectedValue == null || cmbPais.SelectedValue.ToString().Trim() == string.Empty)
            {
                return;
            }
            eventosEncendidos = false;
            if (cmbDepartamento.SelectedValue != null && cmbDepartamento.SelectedValue.ToString().Trim() != string.Empty)
            {
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(),cmbDepartamento.SelectedValue.ToString());
                cmbCiudad.SelectedValue = "-1";
            }
            else
            {
                dsSpx1.ciudades.Clear();
            }
            eventosEncendidos = true;
        }

        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text);
            }
        }


        private bool cargarserial(string serial)
        {
            //miramos si existe el serial
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
            if (dsSpx1.equipos.Rows.Count <= 0)
            {
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }
            //
            fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx1.fabricante, dsSpx1.equipos[0].codFabricante.Trim());
            txtFabricante.Text = dsSpx1.fabricante[0].nombre_fabricante;
            //
            modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx1.Modelos, dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
            txtModelo.Text = dsSpx1.Modelos[0].NombreModelo;

            //esto es para cargar la modalidad con el cual fue creada la orden de servicio si cambio de modadlidad no trae el actual si no el de ese entonces.
            string codigoModalidad = "";
            if (dsSpx1.ordenServicio.Rows.Count <= 0 || dsSpx1.ordenServicio[0].serial != txtSerial.Text)
            {
                if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
                {
                    codigoModalidad = dsSpx1.equipos[0].codModalidadEquipo;
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codigoModalidad).ToString();
                }
            }
            else
            {
                if (!dsSpx1.ordenServicio[0].IscodModalidadNull())
                {
                    codigoModalidad = dsSpx1.ordenServicio[0].codModalidad;
                    txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codigoModalidad).ToString();
                }
            }


            // calcularHoraFin(); //esto se quito por que este calculo se hace cuando se edita la informacion del calendario uno
            return true;
        }


        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }

        private void txtSerial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text);
            }
        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    txtSerial.Text = fr.Serial;
                    txtSerial.Focus();
                    cargarserial(txtSerial.Text);
                }
            }
        }

        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            e.Cancel = !cargarserial(txtSerial.Text);
            if (e.Cancel) txtSerial.Text = "";
        }
    }
}

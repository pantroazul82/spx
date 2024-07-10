using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmModificarSolicitada : Form
    {
        public frmModificarSolicitada()
        {
            InitializeComponent();
        }

        public int codOrdenPrestamo = 0;
        private int codOrdenServicio = 0;
        private void cargarControles()
        {
            dsSpx1.EnforceConstraints = false;
            ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            if (dsSpx1.OrdenPrestamo.Rows.Count > 0)
            {
                if (!dsSpx1.OrdenPrestamo[0].IscodOrdenServicioNull())
                {
                    codOrdenServicio = dsSpx1.OrdenPrestamo[0].codOrdenServicio;
                    txtCodOrdenservicio.Text = codOrdenServicio.ToString();
                    txtCodOrdenservicio.Visible = true;
                    grpUbicacion.Visible = false;
                }else {
                    txtCodOrdenservicio.Visible = false;
                    lblCodOrden.Visible = false;
                    grpUbicacion.Visible = true;
                }
                paisesTableAdapter1.Fill(dsSpx1.paises);
                cmbPais.SelectedValue= dsSpx1.OrdenPrestamo[0].codPais;
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento,cmbPais.SelectedValue.ToString());
                cmbDepartamento.SelectedValue= dsSpx1.OrdenPrestamo[0].codDepartamento;
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades,cmbPais.SelectedValue.ToString(),cmbDepartamento.SelectedValue.ToString());
                cmbCiudad.SelectedValue = dsSpx1.OrdenPrestamo[0].codCiudad;
                clsTusuario1.FillBylogin(dsSPXSeguridad1.usuario, dsSpx1.OrdenPrestamo[0].loginSolicito);
                if (dsSPXSeguridad1.usuario.Count > 0)
                {
                    txtElaboradoPor.Text = dsSPXSeguridad1.usuario[0].nombre;
                }
                txtNumeroOrdenPrestamo.Text = codOrdenPrestamo.ToString();
                if (!dsSpx1.OrdenPrestamo[0].IsobsInicialesNull()) txtObservaciones.Text = dsSpx1.OrdenPrestamo[0].obsIniciales;
                calFechaCreacion.Value = dsSpx1.OrdenPrestamo[0].fechaOrden;
                clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
                cmbResponsable.SelectedValue = dsSpx1.OrdenPrestamo[0].loginResponsable;
                if (!dsSpx1.OrdenPrestamo[0].IsobsSerialNull())
                {
                    txtObservacionesEquipo.Text = dsSpx1.OrdenPrestamo[0].obsSerial.Trim();
                }

                if (!dsSpx1.OrdenPrestamo[0].IsserialNull())
                {
                    txtSerial.Text = dsSpx1.OrdenPrestamo[0].serial.Trim();
                    cargarserial(txtSerial.Text);
                }
            }
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
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



        private void frmSolicitarPrestamo_Load(object sender, EventArgs e)
        {
            eventosEncendidos = false;
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            cargarControles();

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
                    Nullable<DateTime> fechaN = new Nullable<DateTime>();
                    repuestosxOrdenPrestamoTableAdapter1.Insert(codOrdenPrestamo,frmTmp.codigoRepuesto, false,
     false, false, "", fechaN, fechaN, fechaN, frmTmp.cantidad, 0, 0, 0);
                    pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
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
                repuestosxOrdenPrestamoTableAdapter1.DeleteQuery(codOrdenPrestamo, grdRepuestos.Columns["codRepuesto"].Text);
                //luego agregamos de nuevo la fila
                Nullable<DateTime> fechaN = new Nullable<DateTime>();

                repuestosxOrdenPrestamoTableAdapter1.Insert(codOrdenPrestamo, fr.codigoRepuesto, false,
                    false, false, "", fechaN, fechaN, fechaN, fr.cantidad, 0, 0, 0);
                pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
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
            repuestosxOrdenPrestamoTableAdapter1.DeleteQuery(codOrdenPrestamo, grdRepuestos.Columns["codRepuesto"].Text);
            pltRepuestosxOrdenPrestamoTableAdapter1.FillByCodOrdenPrestamo(dsSpx1.pltRepuestosxOrdenPrestamo, codOrdenPrestamo);
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
        
            ordenPrestamoTableAdapter1.UpdateQuery(
            cmbResponsable.SelectedValue.ToString(),dsSpx1.OrdenPrestamo[0].loginSolicito,null,
            null,null,null,dsSpx1.OrdenPrestamo[0].fechaOrden,fechaNullo,cmbPais.SelectedValue.ToString(),
            cmbDepartamento.SelectedValue.ToString(),cmbCiudad.SelectedValue.ToString(),
            ( dsSpx1.OrdenPrestamo[0].IscodOrdenServicioNull())?intNullo:dsSpx1.OrdenPrestamo[0].codOrdenServicio,
            false,txtObservaciones.Text,"","","",txtSerial.Text,txtObservacionesEquipo.Text,  codOrdenPrestamo);

            repuestosxOrdenPrestamoTableAdapter1.DeleteByCodOrdenPrestamo(codOrdenPrestamo);
            for (int k = 0; k < dsSpx1.pltRepuestosxOrdenPrestamo.Count; k++)
            {
                repuestosxOrdenPrestamoTableAdapter1.Insert(codOrdenPrestamo, dsSpx1.pltRepuestosxOrdenPrestamo[k].codRepuesto,
                    false, false, false, "", fechaNullo, fechaNullo, fechaNullo, dsSpx1.pltRepuestosxOrdenPrestamo[k].cantidadSolicitada,
                    0, 0, 0);
            }
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

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
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

        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            e.Cancel = !cargarserial(txtSerial.Text);
            if (e.Cancel) txtSerial.Text = "";
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

        private void txtSerial_DoubleClick(object sender, EventArgs e)
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
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace spProcesos.contratos
{
    public partial class frmNuevoOtroSi : Form
    {
        public frmNuevoOtroSi()
        {
            InitializeComponent();
        }

        private string numeroContrato="";
        public string NumeroContrato { set { numeroContrato = value; } get { return numeroContrato; } }
        //
        private string codOtroSi = "";
        public string CodOtroSi { set { codOtroSi = value; } get { return codOtroSi; } }

        /// <summary>
        /// Carga lo datos del contrato de la base de datos
        /// </summary>
        private void cargarDatos()
        {
            eventosEncendidos = false;
            if (numeroContrato.Trim() == string.Empty) return;
            #region ventana principal
            int otroS = 0;
            int.TryParse(codOtroSi, out otroS);
            repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, numeroContrato, otroS);
            if (dsSpx1.contratos.Rows.Count > 0)
            {
                cmbCliente.SelectedValue = dsSpx1.contratos[0].nitCliente;
                eventosEncendidos = true;
                cmbTipoContrato.SelectedValue = dsSpx1.contratos[0].codTipoContrato.ToString();

                if (!dsSpx1.contratos[0].IsconsumoMinimoAcordadoNull()) txtConsumoMinimo.Text = dsSpx1.contratos[0].consumoMinimoAcordado.ToString();
                if (!dsSpx1.contratos[0].IsconsumoMinimoTotalLineaNull()) txtConsumoxLinea.Text = dsSpx1.contratos[0].consumoMinimoTotalLinea.ToString();
                if (!dsSpx1.contratos[0].IsmontoContratoNull()) txtMontoContrato.Text = dsSpx1.contratos[0].montoContrato.ToString();

                eventosEncendidos = false;
                Application.DoEvents();
                if (!dsSpx1.contratos[0].IscodModalidadContratoNull()) cmbModalidadContrato.SelectedValue = dsSpx1.contratos[0].codModalidadContrato.ToString();
                else cmbModalidadContrato.SelectedValue = "-1";

                txtObervaciones.Text = dsSpx1.contratos[0].Observaciones;

                chkIncluyeRepuestos.Checked = dsSpx1.contratos[0].incluyeRepuestos;
                chkIncluyeTiquetes.Checked = dsSpx1.contratos[0].incluyeTiquetes;
                chkTienePoliza.Checked = dsSpx1.contratos[0].tienePolizaConsumoMinimo;

                rdconsumoMinimoGeneral.Checked = dsSpx1.contratos[0].consumoMinimoGeneral;
                rdConsumoxLinea.Checked = dsSpx1.contratos[0].consumoMinimoxLinea;

                if (!dsSpx1.contratos[0].IsfechaCreacionNull())
                {
                    calCreacion.Value = dsSpx1.contratos[0].fechaCreacion;
                    lblHora.Text = dsSpx1.contratos[0].fechaCreacion.ToLongTimeString();
                }
                if (!dsSpx1.contratos[0].IsincluyeCorrectivosNull())
                    chkIncluyeCorrectivos.Checked = dsSpx1.contratos[0].incluyeCorrectivos;

                if (!dsSpx1.contratos[0].IstopeNumeroCorrectivosNull())
                    nmTopeCorrectivos.Value = (decimal)dsSpx1.contratos[0].topeNumeroCorrectivos;
                nmDiasHabiles.Value = (decimal)dsSpx1.contratos[0].timeRptaDiasHabiles;
                nmHorasHabiles.Value = (decimal)dsSpx1.contratos[0].timeRptaHorasHabiles;
                nmMantenimientosIncluidos.Value = (decimal)dsSpx1.contratos[0].NumeroMantenimientos;
                nmMesesEntreMantenimientos.Value = (decimal)dsSpx1.contratos[0].mesesxMantenimiento;
                nmPorcentajePrecioTiquetes.Value = (decimal)dsSpx1.contratos[0].porcentajeTiquetes;


                calFinContrato.Value = dsSpx1.contratos[0].fechaFinContrato;
                calInicioContrato.Value = dsSpx1.contratos[0].fechaInicioContrato;
                cmbCliente.Enabled = false; 
                //
            }

            #endregion
            eventosEncendidos = true;
        }


        private void frmNuevoContrato_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            grpConsumo.Enabled = false;
            grpMantenimiento.Enabled = false;
            eventosEncendidos = false;

            clientesTableAdapter1.FillByComboBox(dsSpx1.clientes);
            cmbCliente.SelectedValue = "";
            tipoContratoTableAdapter1.Fill(dsSpx1.tipoContrato);
            cmbTipoContrato.SelectedValue = "";
            calFinContrato.MonthCalendar.DisplayMonth = n;
            calInicioContrato.MonthCalendar.DisplayMonth = n;
            txtOtroSi.ReadOnly = true;
            txtNroContrato.ReadOnly = true;
            //cargams toda la info que viene del contrato primero
            if (numeroContrato.Trim() != string.Empty)
            {
                txtNroContrato.Text = numeroContrato;
                if (codOtroSi.Trim() != string.Empty)
                {
                    contratosTableAdapter1.FillByNumeroContratoCodOtroSI(dsSpx1.contratos, numeroContrato,int.Parse(codOtroSi));
                    txtOtroSi.Text = codOtroSi;
                }
                else { 
                contratosTableAdapter1.FillBynumeroContrato(dsSpx1.contratos, numeroContrato);
                txtOtroSi.Text = contratosTableAdapter1.verNextOtroSi(numeroContrato).Value.ToString() ;
                }

                cargarDatos();
            }
            activarControles();
            eventosEncendidos = true;
        }

        private bool validar() 
        {
            if (cmbTipoContrato.SelectedValue == null || cmbTipoContrato.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("El Tipo de Contrato es obligatorio.");
                return false;
            }
            if (txtNroContrato.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El numero de contrato es obligatorio.");
                return false;
            }

            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("El cliente es obligatorio.");
                return false;
            }
            if (cmbModalidadContrato.SelectedValue == null || cmbModalidadContrato.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("La modalidad del Contrato es obligatorio.");
                return false;
            }
            
            if (calInicioContrato.ValueObject == null || calFinContrato.ValueObject == null)
            {
                MessageBox.Show("Las fechas de inicio y de fin de contrato son obligatorias");
                return false;
            }
            if (calInicioContrato.Value > calFinContrato.Value)
            {
                MessageBox.Show("Las fechas de inicio y de fin no son validas");
                return false;
            }
            decimal a = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtMontoContrato.Text);
            if (a >= decimal.MaxValue)
            {
                MessageBox.Show("El Monto es demasiado Grande!!!");
                return false;
            }
            a = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoxLinea.Text);
            if (a >= decimal.MaxValue)
            {
                MessageBox.Show("El Monto de Consumo por Linea es demasiado Grande!!!");
                return false;
            }
            a = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoMinimo.Text);
            if (a >= decimal.MaxValue)
            {
                MessageBox.Show("El Monto Minimo de Consumo por Linea es demasiado Grande!!!");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void guardar(){

            if (!validar())
                return;
            decimal tmp = 0;
            decimal.TryParse(txtConsumoMinimo.Text, out tmp);

            decimal consumoLinea = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoxLinea.Text);
            decimal consumoMinimo = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoMinimo.Text);
            decimal montoContrato = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtMontoContrato.Text);

            if (codOtroSi.Trim() == string.Empty)
            {
                int otroSi = contratosTableAdapter1.verNextOtroSi(numeroContrato).Value;
                if (codOtroSi.Trim() != string.Empty)
                    otroSi = int.Parse(codOtroSi);
                contratosTableAdapter1.Insert(txtNroContrato.Text,otroSi,cmbCliente.SelectedValue.ToString(),cmbTipoContrato.SelectedValue.ToString(),
                    chkIncluyeRepuestos.Checked,(int)nmMantenimientosIncluidos.Value,chkIncluyeTiquetes.Checked,chkTienePoliza.Checked,
                    rdConsumoxLinea.Checked,rdconsumoMinimoGeneral.Checked,consumoLinea,consumoMinimo,calInicioContrato.Value,(int)nmMesesEntreMantenimientos.Value,
                    txtObervaciones.Text,calFinContrato.Value,    (int)nmDiasHabiles.Value,(int)nmHorasHabiles.Value,(int)nmPorcentajePrecioTiquetes.Value,
                    (cmbModalidadContrato.SelectedValue == null || cmbModalidadContrato.SelectedValue.ToString().Trim() ==string.Empty)?null:cmbModalidadContrato.SelectedValue.ToString(),
                    montoContrato,SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                    pltFechaSistemaTableAdapter1.GetData()[0].fechaISistema,chkIncluyeCorrectivos.Checked,
                    (int)nmTopeCorrectivos.Value);

                contratosTableAdapter1.FillByNumeroContratoCodOtroSI(dsSpx1.contratos, txtNroContrato.Text,otroSi);
                numeroContrato = txtNroContrato.Text;
                codOtroSi = otroSi.ToString();
                activarControles();
                
            
            } else {
                int otroSi = contratosTableAdapter1.verNextOtroSi(numeroContrato).Value;
                if (codOtroSi.Trim() != string.Empty)
                    otroSi = int.Parse(codOtroSi);
                contratosTableAdapter1.UpdateQuery(cmbCliente.SelectedValue.ToString(),cmbTipoContrato.SelectedValue.ToString(),
                    chkIncluyeRepuestos.Checked,(int)nmMantenimientosIncluidos.Value,chkIncluyeTiquetes.Checked,chkTienePoliza.Checked,
                    rdConsumoxLinea.Checked,rdconsumoMinimoGeneral.Checked,consumoLinea,consumoMinimo,calInicioContrato.Value,(int)nmMesesEntreMantenimientos.Value,
                    txtObervaciones.Text,calFinContrato.Value,    (int)nmDiasHabiles.Value,(int)nmHorasHabiles.Value,(int)nmPorcentajePrecioTiquetes.Value,
                    (cmbModalidadContrato.SelectedValue == null || cmbModalidadContrato.SelectedValue.ToString().Trim() ==string.Empty)?null:cmbModalidadContrato.SelectedValue.ToString(),
                    montoContrato,
                    chkIncluyeCorrectivos.Checked,
                    (int)nmTopeCorrectivos.Value,

                    otroSi,txtNroContrato.Text);          
            } 

        }

        private void txtConsumoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator.Trim())
            e.Handled=true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void chkTienePoliza_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkTienePoliza.Checked)
            {
                rdConsumoxLinea.Enabled = false;
                rdConsumoxLinea.Checked = false;

                rdconsumoMinimoGeneral.Enabled = false;
                rdconsumoMinimoGeneral.Checked = false;
                txtConsumoxLinea.Enabled = false;
                txtConsumoMinimo.Enabled = false;
            }
            else
            {

                rdConsumoxLinea.Enabled = true;
                rdConsumoxLinea.Checked = true;
                txtConsumoxLinea.Enabled = true;

                rdconsumoMinimoGeneral.Enabled = true;
                rdconsumoMinimoGeneral.Checked = false;
                txtConsumoMinimo.Enabled = false;
            }
        }
        private void rdconsumoMinimoGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdconsumoMinimoGeneral.Checked)
            {
                txtConsumoMinimo.Text = "";
                txtConsumoMinimo.Enabled = false;
            }
            else
            {
                txtConsumoMinimo.Enabled = true;
            }
        }

        bool mantenimiento = false;

        private void cmbTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoContrato.SelectedValue != null && cmbTipoContrato.SelectedValue.ToString().Trim() != string.Empty)
            {
                modalidadContratoTableAdapter1.FillBycodTipoContrato(dsSpx1.modalidadContrato, cmbTipoContrato.SelectedValue.ToString());
                //miramos el tipo de contrato
                if (tipoContratoTableAdapter1.GetDataBycodTipoContrato(cmbTipoContrato.SelectedValue.ToString())[0].deMantenimiento)
                {
                    grpMantenimiento.Enabled = true;
                    mantenimiento = true;
                   
                }
                else
                {
                    chkIncluyeRepuestos.Checked = false;
                    if (chkIncluyeRepuestos.Checked) return;

                    grpMantenimiento.Enabled = false;
                    mantenimiento = false;
                   }
                //--
                if (tipoContratoTableAdapter1.GetDataBycodTipoContrato(cmbTipoContrato.SelectedValue.ToString())[0].deConsumo)
                {
                    grpConsumo.Enabled = true;
                }
                else
                {
                    grpConsumo.Enabled = false;
                    if (chkTienePoliza.Checked) MessageBox.Show("Al Cambiar el tipo de Contrato perdera la Informacion de los consumos!!!");
                    chkTienePoliza.Checked = false;
                    txtConsumoMinimo.Text = "";
                    txtConsumoxLinea.Text = "";
                    rdconsumoMinimoGeneral.Checked = false;
                    rdConsumoxLinea.Checked = false;
                }
            }
            else
            {
                dsSpx1.modalidadContrato.Clear();
                grpMantenimiento.Enabled = false;
                grpConsumo.Enabled = false;
            }
        }

       
        bool eventosEncendidos = true;
        private void txtMontoContrato_TextChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            eventosEncendidos = false;
            SPXUtilidades.clsFormato.formatoDinero(txtMontoContrato, false);
            eventosEncendidos = true;
        }

        private void calFinContrato_Validating(object sender, CancelEventArgs e)
        {
            if (calFinContrato.ValueObject == null || calInicioContrato.ValueObject == null) return;
            if (calFinContrato.Value < calInicioContrato.Value)
            {
                MessageBox.Show("Ingrese fechas validas para el inicio y fin del contrato!!!");
                e.Cancel = true;
            }
        }

        private void calInicioContrato_Validating(object sender, CancelEventArgs e)
        {
            if (calFinContrato.ValueObject == null || calInicioContrato.ValueObject == null) return;
            if (calFinContrato.Value < calInicioContrato.Value)
            {
                MessageBox.Show("Ingrese fechas validas para el inicio y fin del contrato!!!");
                e.Cancel = true;
            }
        }

        private void txtNroContrato_Validating(object sender, CancelEventArgs e)
        {
            if (dsSpx1.contratos.Rows.Count == 0)
            {
                if (contratosTableAdapter1.validarNumeroContrato(txtNroContrato.Text).Value > 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Ya existe un contrato ingresado con el mismo numero");
                }
            }
        }

        private void btnAgregarRepuestos_Click(object sender, EventArgs e)
        {
            //guardamos el otro si
            if (codOtroSi == string.Empty) guardar();

            spProcesos.contratos.frmRepuestoxContrato fr = new frmRepuestoxContrato();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //validamos que no exista
                if (repuestosxContratosTableAdapter1.GetDataByRepuestoContrato(0, fr.codigoRepuesto, txtNroContrato.Text).Count>0)
                {
                    MessageBox.Show("Ya tiene repuestos con el codigo "+fr.codigoRepuesto.Trim()+" asociados al contrato!!!!");
                    return;
                }
                repuestosxContratosTableAdapter1.Insert(txtNroContrato.Text, int.Parse(txtOtroSi.Text), fr.codigoRepuesto, fr.cantidad, fr.observaciones);
                repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, txtNroContrato.Text, int.Parse(codOtroSi));
            }
        }

        private void btnModificarRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty) return;
            spProcesos.contratos.frmRepuestoxContrato fr = new frmRepuestoxContrato();
            fr.codigoRepuesto = grdRepuestos.Columns["codRepuesto"].Text;
            fr.cantidad =int.Parse( grdRepuestos.Columns["cantidad"].Text);
            fr.observaciones = grdRepuestos.Columns["observaciones"].Text;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                repuestosxContratosTableAdapter1.UpdateQuery(fr.cantidad, fr.observaciones, int.Parse(codOtroSi), fr.codigoRepuesto, txtNroContrato.Text);
                repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, txtNroContrato.Text, int.Parse(codOtroSi));
            }
        }

        private void btnDesvincularRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("esta seguro de desvincular el repuesto seleccionado?\nEste cambio no se puede deshacer!!","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes) return;
            repuestosxContratosTableAdapter1.DeleteQuery(txtNroContrato.Text, int.Parse(codOtroSi), grdRepuestos.Columns["codRepuesto"].Text);
            repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, txtNroContrato.Text, int.Parse(codOtroSi));
        }

        private void chkIncluyeRepuestos_CheckedChanged(object sender, EventArgs e)
        {
            if (dsSpx1.contratos.Rows.Count <= 0) return;
            if (chkIncluyeRepuestos.Checked)
            {
                btnAgregarRepuestos.Enabled = true;
                btnModificarRepuesto.Enabled = true;
                btnDesvincularRepuesto.Enabled = true;
            }
            else
            {
                if (dsSpx1.repuestosxContratos.Rows.Count > 0)
                {
                    if (MessageBox.Show("Esta seguro de deshabilitar esta opcion?\nse desvincularan todos los repuestos, esta Opcion no se puede deshacer ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    {
                        chkIncluyeRepuestos.Checked = true;
                        return;
                    }
                    repuestosxContratosTableAdapter1.DeleteByNumeroContrato(txtNroContrato.Text);
                    repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, numeroContrato, int.Parse(codOtroSi));

                }
                btnAgregarRepuestos.Enabled = false;
                btnModificarRepuesto.Enabled = false;
                btnDesvincularRepuesto.Enabled = false;
            }
        }

        private void txtConsumoxLinea_TextChanged(object sender, EventArgs e)
        {
             if (!eventosEncendidos) return;
            eventosEncendidos = false;
            SPXUtilidades.clsFormato.formatoDinero(txtConsumoxLinea, false);
            eventosEncendidos = true;
        }

        private void txtConsumoMinimo_TextChanged(object sender, EventArgs e)
        {
         if (!eventosEncendidos) return;
            eventosEncendidos = false;
            SPXUtilidades.clsFormato.formatoDinero(txtConsumoMinimo, false);
            eventosEncendidos = true;
        }

        private void activarControles()
        {
            if (codOtroSi.Trim() == string.Empty)
            {
                btnAgregarRepuestos.Enabled = false;
                btnModificarRepuesto.Enabled = false;
                btnDesvincularRepuesto.Enabled = false;
            }else {
                if (chkIncluyeRepuestos.Checked)
                {
                    btnAgregarRepuestos.Enabled = true;
                    btnModificarRepuesto.Enabled = true;
                    btnDesvincularRepuesto.Enabled = true;
                }else{
                    btnAgregarRepuestos.Enabled = false;
                    btnModificarRepuesto.Enabled = false;
                    btnDesvincularRepuesto.Enabled = false;
                }
                 txtNroContrato.ReadOnly = true;
            }
        }

        private void rdConsumoxLinea_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdConsumoxLinea.Checked)
            {
                txtConsumoxLinea.Text = "";
                txtConsumoxLinea.Enabled = false;
            }
            else
            {
                txtConsumoxLinea.Enabled = true;
            }
        }

        private void btnLimpiarModalidad_Click(object sender, EventArgs e)
        {
            cmbModalidadContrato.SelectedValue = "-1";
        }

     
    }
}

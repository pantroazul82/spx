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
    public partial class contratosConsumo : Form
    {
        public contratosConsumo()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdcambios;
        }

        private int cod_contrato_consumo = 0;
        private bool guardado = false;
        
        public string NumeroContrato  { set; get; }
        public string CodEspecial { set; get; }
        public bool   GenerandoOtroSi { set; get; }
        public bool   Editar          { set; get; }
        public bool modoHistorico { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (guardado)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else {

                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void cargarArchivos() 
        {
            if (!GenerandoOtroSi && NumeroContrato != null && NumeroContrato != string.Empty)
            {
                archivoxcontrato_consumoTableAdapter1.FillBynumeroContrato(dsContratoConsumo1.archivoxcontrato_consumo, NumeroContrato);
                pltContratoConsumoTableAdapter1.FillByNumeroContrato(dsContratoHistorico.pltContratoConsumo, NumeroContrato);
            }else{
                archivoxcontrato_consumoTableAdapter1.FillByCod_contrato_consumo(dsContratoConsumo1.archivoxcontrato_consumo, cod_contrato_consumo);
            }
        }

      

        private void cargarTablas() 
        {
            string sql = "select cod_usuario,nombre from usuario order by nombre";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
           cmbAsesor.DataSource= bd.ejecutarConsulta(sql).Tables[0];
           cmbAsesor.DisplayMember = "nombre";
           cmbAsesor.ValueMember = "cod_usuario";
           modalidad_contratoTableAdapter1.Fill(dsContratoConsumo1.modalidad_contrato);
           modalidad_contratoTableAdapter1.Fill(dsContratoConsumo2.modalidad_contrato);
           vigencias_contrato_consumoTableAdapter1.Fill(dsContratoConsumo1.vigencias_contrato_consumo);
           razon_no_vigenteTableAdapter1.Fill(dsContratoConsumo1.razon_no_vigente);
           cmbVigencia.SelectedIndex = -1;
           cmbRazonVigencia.SelectedIndex = -1;
           cmbRazonVigencia.Enabled = false;
        }

        private void cargarInformacionContrato() 
        {
            if (cod_contrato_consumo == 0) return;

            contrato_consumoTableAdapter1.FillBycod_contrato_consumo(dsContratoConsumo1.contrato_consumo, cod_contrato_consumo);
            txtBusquedaCliente1.Value = dsContratoConsumo1.contrato_consumo[0].nitCliente;
            
            txtNumeroContrato.Text = dsContratoConsumo1.contrato_consumo[0].numero_contrato;
            txtNumeroContratoVinculado.Text = dsContratoConsumo1.contrato_consumo[0].numero_contrato_vinculado;
            txtObservaciones.Text = dsContratoConsumo1.contrato_consumo[0].observaciones;
            if(!GenerandoOtroSi)
            txtOtroSi.Text = dsContratoConsumo1.contrato_consumo[0].otro_si;

            calFinContrato.Value = dsContratoConsumo1.contrato_consumo[0].fecha_finalizacion_contrato;
            calInicioContrato.Value = dsContratoConsumo1.contrato_consumo[0].fecha_inicio_contrato;
            if (!dsContratoConsumo1.contrato_consumo[0].Isfecha_otro_siNull())
            calOtroSi.Value = dsContratoConsumo1.contrato_consumo[0].fecha_otro_si;

            chkLegalizado.Checked = dsContratoConsumo1.contrato_consumo[0].contrato_legalizado;
            chkProrogaAutomatica.Checked = dsContratoConsumo1.contrato_consumo[0].proroga_automatica;
            
            cmbAsesor.SelectedValue = dsContratoConsumo1.contrato_consumo[0].cod_asesor;
            cmbVigencia.SelectedValue = dsContratoConsumo1.contrato_consumo[0].cod_vigencias_contrato_consumo;
            if (cmbVigencia.Text.ToLower().IndexOf("no") >= 0)
            {
                cmbRazonVigencia.Enabled = true;
                if (!dsContratoConsumo1.contrato_consumo[0].Iscod_razon_no_vigenteNull())
                {
                    cmbRazonVigencia.SelectedValue = dsContratoConsumo1.contrato_consumo[0].cod_razon_no_vigente;
                }
            }
            else {
                cmbRazonVigencia.Enabled = false;
            }


            sub_modalidad_contratoTableAdapter1.FillBycod_sub_modalidad_contrato(dsContratoConsumo1.sub_modalidad_contrato, dsContratoConsumo1.contrato_consumo[0].cod_sub_modalidad_contrato);
            cmbModalidad.SelectedValue = dsContratoConsumo1.sub_modalidad_contrato[0].cod_modalidad_contrato;
            sub_modalidad_contratoTableAdapter1.FillBycod_modalidad_contrato(dsContratoConsumo1.sub_modalidad_contrato, dsContratoConsumo1.sub_modalidad_contrato[0].cod_modalidad_contrato);
            cmbSubModalidad.SelectedValue = dsContratoConsumo1.contrato_consumo[0].cod_sub_modalidad_contrato;


            sub_modalidad_contratoTableAdapter1.FillBycod_sub_modalidad_contrato(dsContratoConsumo2.sub_modalidad_contrato, dsContratoConsumo1.contrato_consumo[0].cod_sub_modalidad_contrato_vinculado);
            cmbModalidadVinculado.SelectedValue = dsContratoConsumo2.sub_modalidad_contrato[0].cod_modalidad_contrato;
            sub_modalidad_contratoTableAdapter1.FillBycod_modalidad_contrato(dsContratoConsumo2.sub_modalidad_contrato, dsContratoConsumo2.sub_modalidad_contrato[0].cod_modalidad_contrato);
            cmbSubModalidadVinculado.SelectedValue = dsContratoConsumo1.contrato_consumo[0].cod_sub_modalidad_contrato_vinculado;


            dsContratoConsumo1.EnforceConstraints = false;
            pltEquiposxContratoTableAdapter1.FillBycod_contrato_consumo(dsContratoConsumo1.pltEquiposxContrato, cod_contrato_consumo);
            pltConsumiblexContratoConsumoTableAdapter1.Fill(dsContratoConsumo1.pltConsumiblexContratoConsumo, cod_contrato_consumo);
            pltIncrementosLineaConsumoxContratoTableAdapter1.Fill(dsContratoConsumo1.pltIncrementosLineaConsumoxContrato, this.cod_contrato_consumo);            
            pltConsumoxContratoTableAdapter1.FillByCodContratoConsumo(dsContratoConsumo1.pltConsumoxContrato, cod_contrato_consumo);
            pltTipoSoftwarexContratoTableAdapter1.Fill(dsContratoConsumo1.pltTipoSoftwarexContrato, this.cod_contrato_consumo);
            cargarArchivos();
            calculaConsumoTotal();
            if (!dsContratoConsumo1.contrato_consumo[0].Isotro_siNull() && dsContratoConsumo1.contrato_consumo[0].otro_si.Trim() != string.Empty)
                grpOtroSi.Visible = true;
        }

        private void contratosConsumo_Load(object sender, EventArgs e)
        {
            dsContratoConsumo1.EnforceConstraints = false;
            cargarTablas();
            calOtroSi.Value = DateTime.Now;

            
            if (GenerandoOtroSi)
            {
                grpOtroSi.Visible = true;
                contrato_consumoTableAdapter1.FillBynumero_contrato(dsContratoHistorico.contrato_consumo, NumeroContrato);
                cod_contrato_consumo = dsContratoHistorico.contrato_consumo[0].cod_contrato_consumo;
                cargarInformacionContrato();
                cod_contrato_consumo = 0;
                dsContratoHistorico.pltEquiposxContrato.Clear();
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();

                txtOtroSi.Text = bd.ejecutarProcedimiento("select count(*) from contrato_consumo where numero_contrato='"+NumeroContrato.Trim()+"'").ToString(); 
                txtOtroSi.Enabled = false;
                dsContratoConsumo1.pltConsumoxContrato.Clear();
                txtNumeroContrato.Enabled = false;
                txtBusquedaCliente1.Enabled = false;
                //calculamos el numero de otro si
            }

            else if (NumeroContrato != null && NumeroContrato != string.Empty)
            {
                if (CodEspecial != null &&  CodEspecial.Trim() != string.Empty)
                {
                    contrato_consumoTableAdapter1.FillBycod_contrato_consumo(dsContratoHistorico.contrato_consumo, int.Parse( CodEspecial));
                    cod_contrato_consumo = int.Parse( CodEspecial);
                    cargarInformacionContrato();
                    grpRelaciones.Visible = true;
                    btnGenerarOtroSi.Visible = true;
                    tabItem2.Visible = true;
                    grpConsumibles.Visible = true;
                    grpIncrementos.Visible = true;
                    btnExportarConsumiibles.Visible = true;
                    grpSoftwareAsociado.Visible = true;
                }
                else
                {
                    contrato_consumoTableAdapter1.FillBynumero_contrato(dsContratoHistorico.contrato_consumo, NumeroContrato);
                    cod_contrato_consumo = dsContratoHistorico.contrato_consumo[0].cod_contrato_consumo;
                    cargarInformacionContrato();
                    grpRelaciones.Visible = true;
                    btnGenerarOtroSi.Visible = true;
                    tabItem2.Visible = true;
                    grpConsumibles.Visible = true;
                    grpIncrementos.Visible = true;
                    btnExportarConsumiibles.Visible = true;
                    grpSoftwareAsociado.Visible = true;
                }
            }
            if (!GenerandoOtroSi && (NumeroContrato != string.Empty && NumeroContrato != null))
            { 
            //solocuando numero de contrato es diferente de vacio, es decir cuando se esta viendo desde el raiz
             //habilita la pestana de historico
                tabItem2.Visible = true;
                tabItem3.Visible = true;
            }
            if (modoHistorico)
            {
                cargarInformacionContrato();
                txtBusquedaCliente1.Enabled = false;
                
                txtNumeroContrato.ReadOnly = true;
                txtObservaciones.ReadOnly = true;
                txtOtroSi.ReadOnly = true;
                chkLegalizado.Enabled = false;
                cmbAsesor.Enabled = false;
                cmbModalidad.Enabled = false;
                cmbSubModalidad.Enabled = false;
                btnAgregarArchivo.Visible = false;
                btnAgregarConsumo.Visible = false;
                btnAgregarEquipo.Visible = false;
                btnEditarContratoConsumo.Visible = false;
                btnEditarEquipo.Visible = false;
                btnEliminarContratoConsumo.Visible = false;
                btnEliminarEquipo.Visible = false;
                btnGenerarOtroSi.Visible = false;
                btnImportarConsumo.Visible = false;
                btnImportarConsumiblesContrato.Visible = false;
                btnExportarConsumiibles.Visible = false;
                btnImportarEquipos.Visible = false;
                btnQuitarArchivo.Visible = false;
                btnVerDetalleHistorico.Visible = false;
                tabItem2.Visible = false;
                btnAceptar.Visible = false;
                if (txtOtroSi.Text.Trim() != string.Empty) grpOtroSi.Visible = true;
                grpRelaciones.Visible = true;
                grpConsumibles.Visible = true;
                grpIncrementos.Visible = true;
                grpSoftwareAsociado.Visible = true;
               
                tabItem3.Visible = true;
            }
        }

        private bool validar() 
        {

            if (txtNumeroContrato.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Es necesario ingresar el numero de contrato.");
                return false;
            }

            if (cmbRazonVigencia.Enabled)
            {
                if (cmbRazonVigencia.SelectedValue == null || cmbRazonVigencia.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Es necesario ingresar la razon por que no es vigente.");
                    return false;
                }
            }

            //validamos si es nuevo que no exista el numero de contrato
            if (!GenerandoOtroSi && cod_contrato_consumo == 0)
            {
                string sql = " select count(*) from contrato_consumo where numero_contrato='"+txtNumeroContrato.Text.Trim()+"'";
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                if (bd.ejecutarProcedimiento(sql).ToString().Trim() != "0")
                {
                    MessageBox.Show("Este numero de contrato ya esta registrado en el sistema");
                    return false;
                }
            
            }
            if (GenerandoOtroSi)
            {

                if (txtOtroSi.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Es necesario ingresar el codigo de otro si.");
                    return false;
                }
            }
                if (cmbAsesor.SelectedValue == null || cmbAsesor.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Es necesario ingresar el asesor responsable.");
                    return false;
                }

                if (cmbSubModalidad.SelectedValue == null || cmbSubModalidad.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Es necesario ingresar la sub modalidad del contrato.");
                    return false;
                }

                if (cmbVigencia.SelectedValue == null || cmbVigencia.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Es necesario ingresar la vigencia.");
                    return false;
                }

                if (calInicioContrato.ValueObject == null)
                {
                    MessageBox.Show("Es necesario ingresar la fecha de inicio del contrato.");
                    return false;
                }

                if (calFinContrato.ValueObject == null)
                {
                    MessageBox.Show("Es necesario ingresar la fecha de finalizacion del contrato.");
                    return false;
                }
                if (txtBusquedaCliente1.Value == null || txtBusquedaCliente1.Value.Trim() == "0")
                {
                    MessageBox.Show("Es necesario ingresar el cliente.");
                    return false;
                }
                if (cmbSubModalidadVinculado.SelectedValue == null || cmbSubModalidadVinculado.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Es necesario ingresar la sub modalidad, del equipo vinculado, si no tiene contrato vinculado seleccione 'NO APLICA'.");
                    return false;
                }

            
            
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            int? codRazonNoVigente = null;

            if (cmbRazonVigencia.Enabled)
            {
                codRazonNoVigente = int.Parse(cmbRazonVigencia.SelectedValue.ToString());
            }

            if (cod_contrato_consumo!=0)
            {
                contrato_consumoTableAdapter1.UpdateQuery(txtObservaciones.Text, txtNumeroContrato.Text, txtBusquedaCliente1.Value,
                  int.Parse(cmbAsesor.SelectedValue.ToString()),
                  int.Parse(cmbSubModalidad.SelectedValue.ToString()), txtOtroSi.Text,
                  GenerandoOtroSi ? DateTime.Now : (DateTime?)null,
                  chkLegalizado.Checked, calInicioContrato.Value, calFinContrato.Value,
                  int.Parse(cmbVigencia.SelectedValue.ToString()),txtNumeroContratoVinculado.Text,
                  int.Parse(cmbSubModalidadVinculado.SelectedValue.ToString()),chkProrogaAutomatica.Checked,codRazonNoVigente, cod_contrato_consumo);
            }else{
                contrato_consumoTableAdapter1.Insert(txtObservaciones.Text, txtNumeroContrato.Text, txtBusquedaCliente1.Value,
                    int.Parse(cmbAsesor.SelectedValue.ToString()),int.Parse(cmbSubModalidad.SelectedValue.ToString()), txtOtroSi.Text,
                    GenerandoOtroSi ? DateTime.Now : (DateTime?)null,
                    chkLegalizado.Checked, calInicioContrato.Value, calFinContrato.Value,"", SPXSeguridad.logica.sesion.CodUsuarioAutenticado, DateTime.Now,0,
                    int.Parse(cmbVigencia.SelectedValue.ToString()),
                    txtNumeroContratoVinculado.Text,int.Parse(cmbSubModalidadVinculado.SelectedValue.ToString()),chkProrogaAutomatica.Checked,
                    codRazonNoVigente);
                grpRelaciones.Visible = true;
                grpConsumibles.Visible = true;
                grpIncrementos.Visible = true;
                grpSoftwareAsociado.Visible = true;
                

                if (!GenerandoOtroSi && NumeroContrato!= null && NumeroContrato.Trim() != string.Empty)
                {
                    tabItem2.Visible = true;
                }
                tabItem3.Visible = true;
                if (!GenerandoOtroSi)
                {
                    btnGenerarOtroSi.Visible = true;
                }
                else {
                    btnImportarConsumo.Visible = true;
                    btnImportarEquipos.Visible = true;
                    btnImportarConsumiblesContrato.Visible = true;
                    btnImportarIncrementosxLineaConsumo.Visible = true;
                    btnExportarConsumiibles.Visible = true;
                    btnImportarContrato.Visible = true;

                    dsContratoConsumo1.archivoxcontrato_consumo.Clear();
                    dsContratoConsumo1.pltEquiposxContrato.Clear();
                    dsContratoConsumo1.pltConsumoxContrato.Clear();
                    dsContratoConsumo1.pltIncrementosLineaConsumoxContrato.Clear();
                    dsContratoConsumo1.pltTipoSoftwarexContrato.Clear();
                    dsContratoConsumo1.pltConsumiblexContratoConsumo.Clear();
                    calculaConsumoTotal();
                    btnGenerarOtroSi.Visible = false;
                }
                string sql = "select max(cod_contrato_consumo) from contrato_consumo where numero_contrato='"+txtNumeroContrato.Text+"'";
                txtNumeroContrato.ReadOnly = true;
                txtBusquedaCliente1.Enabled = false;
                txtOtroSi.ReadOnly = true;
                
                cod_contrato_consumo= int.Parse( bd.ejecutarProcedimiento(sql).ToString());



            }

            string sq = @"declare @num as money
select @num = sum(valor_exigido) from linea_consumoxcontrato_consumo where cod_contrato_consumo = " + cod_contrato_consumo + @"
update contrato_consumo set consumo_total= @num where cod_contrato_consumo = "+cod_contrato_consumo+"";
            bd.ejecutarComando(sq);
            guardado = true;
            MessageBox.Show("Se guardaron los cambios satisfactoriamente.");
        }

        private void cmbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModalidad.SelectedValue == null || cmbModalidad.SelectedValue.ToString().Trim() == string.Empty) 
            {
                dsContratoConsumo1.sub_modalidad_contrato.Clear();
                return;
            }

            sub_modalidad_contratoTableAdapter1.FillBycod_modalidad_contrato(dsContratoConsumo1.sub_modalidad_contrato,
                int.Parse( cmbModalidad.SelectedValue.ToString() ));
        }

        private void btnGenerarOtroSi_Click(object sender, EventArgs e)
        {
            contratosConsumo fr = new contratosConsumo();
            fr.Editar = false;
            fr.GenerandoOtroSi = true;
            fr.NumeroContrato = txtNumeroContrato.Text;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!GenerandoOtroSi)
                {
                    this.NumeroContrato = txtNumeroContrato.Text;
                    pltContratoConsumoTableAdapter1.FillByNumeroContrato(dsContratoHistorico.pltContratoConsumo, NumeroContrato);
                    contrato_consumoTableAdapter1.FillBynumero_contrato(dsContratoHistorico.contrato_consumo, NumeroContrato);
                    cod_contrato_consumo = dsContratoHistorico.contrato_consumo[0].cod_contrato_consumo;
                    cargarInformacionContrato();
                    tabItem2.Visible = true;
                }
            }
        }

        private void calculaConsumoTotal() 
        {
            decimal res = 0;
            for (int k = 0; k < dsContratoConsumo1.pltConsumoxContrato.Count; k++)
            {
                res += dsContratoConsumo1.pltConsumoxContrato[k].valor_exigido;
            }
            
            txtConsumoTotal.Text = ((int)res).ToString();
            SPXUtilidades.clsFormato.formatoDinero(txtConsumoTotal,false);
        
        }

        private void btnAgregarConsumo_Click(object sender, EventArgs e)
        {
            frmConsumoRequerido fr = new frmConsumoRequerido();
            fr.codContrato = this.cod_contrato_consumo;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltConsumoxContratoTableAdapter1.FillByCodContratoConsumo(dsContratoConsumo1.pltConsumoxContrato, cod_contrato_consumo);

                calculaConsumoTotal(); 
            }
             
        }

        private void btnEditarContratoConsumo_Click(object sender, EventArgs e)
        {
            if (grdConsumo.Columns["cod_linea_consumoxcontrato_consumo"].Text.Trim() == string.Empty) return;
            frmConsumoRequerido fr = new frmConsumoRequerido();
            fr.codContrato = this.cod_contrato_consumo;
            fr.codDetalle = int.Parse(grdConsumo.Columns["cod_linea_consumoxcontrato_consumo"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltConsumoxContratoTableAdapter1.FillByCodContratoConsumo(dsContratoConsumo1.pltConsumoxContrato, cod_contrato_consumo);

                calculaConsumoTotal();
            }
        }

        private void btnEliminarContratoConsumo_Click(object sender, EventArgs e)
        {
            if (grdConsumo.Columns["cod_linea_consumoxcontrato_consumo"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    linea_consumoxcontrato_consumoTableAdapter1.DeleteQuery(int.Parse(grdConsumo.Columns["cod_linea_consumoxcontrato_consumo"].Text));
                    pltConsumoxContratoTableAdapter1.FillByCodContratoConsumo(dsContratoConsumo1.pltConsumoxContrato, cod_contrato_consumo);
                    calculaConsumoTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete+" "+ex.Message);
                }
            }
        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 

                string descripcion="";
                SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje frm = new SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje();
                frm.titulo = "Descripcion Archivo";
                frm.mensaje = "Ingrese la Descripcion del archivo";
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    descripcion = frm.mensaje;
                    string nombre = System.IO.Path.GetFileName(op.FileName);
                    archivoxcontrato_consumoTableAdapter1.Insert(nombre,
                        System.IO.File.ReadAllBytes(op.FileName),
                        cod_contrato_consumo, DateTime.Now, descripcion);
                    cargarArchivos();
                }
            }
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["cod_archivoxcontrato_consumo"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    archivoxcontrato_consumoTableAdapter1.DeleteQuery(int.Parse(grdArchivos.Columns["cod_archivoxcontrato_consumo"].Text));
                    cargarArchivos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }

        private void btnDescargarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["cod_archivoxcontrato_consumo"].Text.Trim() == string.Empty) return;
            
            archivoxcontrato_consumoTableAdapter1.FillByCod_archivoxcontrato_consumo(dsContratoConsumo1.archivoxcontrato_consumo, int.Parse(grdArchivos.Columns["cod_archivoxcontrato_consumo"].Text));
            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = dsContratoConsumo1.archivoxcontrato_consumo[0].nombre_archivo;
            if (sv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllBytes(sv.FileName, dsContratoConsumo1.archivoxcontrato_consumo[0].archivo);

            }
        }

        private void btnVerDetalleHistorico_Click(object sender, EventArgs e)
        {
            if (grdHistorico.Columns["cod_contrato_consumo"].Text.Trim() == string.Empty) return;
            contratosConsumo frm = new contratosConsumo();
            frm.cod_contrato_consumo = int.Parse(grdHistorico.Columns["cod_contrato_consumo"].Text);
            frm.modoHistorico = true;
            frm.Show();

        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
           
            frmNuevoEquipoModelo fr = new frmNuevoEquipoModelo();
            for (int k = 0; k < dsContratoConsumo1.pltEquiposxContrato.Rows.Count; k++)
            {
                if (!dsContratoConsumo1.pltEquiposxContrato[k].IsserialNull() &&
                    dsContratoConsumo1.pltEquiposxContrato[k].serial.Trim() != string.Empty)
                {
                    fr.serialesIngresados.Add(dsContratoConsumo1.pltEquiposxContrato[k].serial.Trim());
                }
            }
            fr.codContratoConsumo = this.cod_contrato_consumo;
            fr.Nitcliente = txtBusquedaCliente1.Value;
         
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltEquiposxContratoTableAdapter1.FillBycod_contrato_consumo(dsContratoConsumo1.pltEquiposxContrato, cod_contrato_consumo);
            }
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["cod_equiposxcontrato_consumo"].Text.Trim() == string.Empty) return;
            frmNuevoEquipoModelo fr = new frmNuevoEquipoModelo();
            fr.codContratoConsumo = this.cod_contrato_consumo;
            fr.Nitcliente = txtBusquedaCliente1.Value;
            fr.codDetalle = int.Parse(grdEquipos.Columns["cod_equiposxcontrato_consumo"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltEquiposxContratoTableAdapter1.FillBycod_contrato_consumo(dsContratoConsumo1.pltEquiposxContrato, cod_contrato_consumo);
            }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["cod_equiposxcontrato_consumo"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    equiposxcontrato_consumoTableAdapter1.DeleteQuery(int.Parse(grdEquipos.Columns["cod_equiposxcontrato_consumo"].Text));
                    pltEquiposxContratoTableAdapter1.FillBycod_contrato_consumo(dsContratoConsumo1.pltEquiposxContrato, cod_contrato_consumo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }

        private void btnImportarEquipos_Click(object sender, EventArgs e)
        {
            //traemos todos los equipos del contrato raiz
            SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
            contrato_consumoTableAdapter1.FillBynumero_contrato(ds.contrato_consumo, NumeroContrato);
            int codC = ds.contrato_consumo[1].cod_contrato_consumo;

            equiposxcontrato_consumoTableAdapter1.FillBycod_contrato_consumo(ds.equiposxcontrato_consumo, codC);
            for (int k = 0; k < ds.equiposxcontrato_consumo.Count; k++)
            {
                equiposxcontrato_consumoTableAdapter1.Insert(cod_contrato_consumo,
                    ds.equiposxcontrato_consumo[k].IscodFabricanteNull() ? null : ds.equiposxcontrato_consumo[k].codFabricante.Trim(),
                    ds.equiposxcontrato_consumo[k].IscodModeloNull() ? null : ds.equiposxcontrato_consumo[k].codModelo.Trim(),
                    ds.equiposxcontrato_consumo[k].IsserialNull() ? null : ds.equiposxcontrato_consumo[k].serial,
                    ds.equiposxcontrato_consumo[k].IscodSucursalClienteNull() ? null : ds.equiposxcontrato_consumo[k].codSucursalCliente,
                    ds.equiposxcontrato_consumo[k].IsnitClienteNull() ? null : ds.equiposxcontrato_consumo[k].nitCliente,
                    ds.equiposxcontrato_consumo[k].Isdescripcion_software_incluidoNull() ? null : ds.equiposxcontrato_consumo[k].descripcion_software_incluido,
                    ds.equiposxcontrato_consumo[k].Ispertenece_annarNull() ? (bool?)null : ds.equiposxcontrato_consumo[k].pertenece_annar,
                    ds.equiposxcontrato_consumo[k].Isconectado_softwareNull() ? (bool?)null : ds.equiposxcontrato_consumo[k].conectado_software
                    );
            }
            pltEquiposxContratoTableAdapter1.FillBycod_contrato_consumo(dsContratoConsumo1.pltEquiposxContrato, cod_contrato_consumo);
        }

        private void btnImportarConsumo_Click(object sender, EventArgs e)
        {
            //traemos todos los equipos del contrato raiz
            SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
            contrato_consumoTableAdapter1.FillBynumero_contrato(ds.contrato_consumo, NumeroContrato);
            int codC = ds.contrato_consumo[1].cod_contrato_consumo;

            linea_consumoxcontrato_consumoTableAdapter1.FillByCod_contrato_consumo(ds.linea_consumoxcontrato_consumo, codC);

            for (int k = 0; k < ds.linea_consumoxcontrato_consumo.Count; k++)
            {
                linea_consumoxcontrato_consumoTableAdapter1.Insert(
                     ds.linea_consumoxcontrato_consumo[k].cod_linea_consumo,
                    
                    cod_contrato_consumo,

                     ds.linea_consumoxcontrato_consumo[k].valor_exigido  );
            }
            pltConsumoxContratoTableAdapter1.FillByCodContratoConsumo(dsContratoConsumo1.pltConsumoxContrato, cod_contrato_consumo);
            calculaConsumoTotal();
         
        }

        private void btnAgregarIncremento_Click(object sender, EventArgs e)
        {
            frmIncrementosxLineas fr = new frmIncrementosxLineas();
            fr.codIgoContrato = this.cod_contrato_consumo;
            if(fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltIncrementosLineaConsumoxContratoTableAdapter1.Fill(dsContratoConsumo1.pltIncrementosLineaConsumoxContrato,this.cod_contrato_consumo);
            }
        }

        private void btnEditarIncremento_Click(object sender, EventArgs e)
        {
            if (grdIncrementosPorLinea.Columns["cod_incrementosxlinea_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmIncrementosxLineas fr = new frmIncrementosxLineas();
            fr.codIgoContrato = this.cod_contrato_consumo;
            fr.codIgo = int.Parse(grdIncrementosPorLinea.Columns["cod_incrementosxlinea_consumo"].Text.Trim());
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltIncrementosLineaConsumoxContratoTableAdapter1.Fill(dsContratoConsumo1.pltIncrementosLineaConsumoxContrato, this.cod_contrato_consumo);
            }
        }

        private void btnEliminarIncremento_Click(object sender, EventArgs e)
        {
            if (grdIncrementosPorLinea.Columns["cod_incrementosxlinea_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    incrementosxlinea_consumoTableAdapter1.DeleteQuery(int.Parse(grdIncrementosPorLinea.Columns["cod_incrementosxlinea_consumo"].Text));
                    pltIncrementosLineaConsumoxContratoTableAdapter1.Fill(dsContratoConsumo1.pltIncrementosLineaConsumoxContrato, this.cod_contrato_consumo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }

        private void btnImportarIncrementosxLineaConsumo_Click(object sender, EventArgs e)
        {
            //traemos todos los equipos del contrato raiz
            SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
            contrato_consumoTableAdapter1.FillBynumero_contrato(ds.contrato_consumo, NumeroContrato);
            int codC = ds.contrato_consumo[1].cod_contrato_consumo;

            incrementosxlinea_consumoTableAdapter1.FillBycod_contrato_consumo(ds.incrementosxlinea_consumo, codC);

            for (int k = 0; k < ds.incrementosxlinea_consumo.Count; k++)
            {
                incrementosxlinea_consumoTableAdapter1.Insert(
                     ds.incrementosxlinea_consumo[k].cod_linea_consumo,
                     ds.incrementosxlinea_consumo[k].incremento,
                    cod_contrato_consumo);
            }
            pltIncrementosLineaConsumoxContratoTableAdapter1.Fill(dsContratoConsumo1.pltIncrementosLineaConsumoxContrato, this.cod_contrato_consumo);
        }

        private void cmbModalidadVinculado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModalidadVinculado.SelectedValue == null || cmbModalidadVinculado.SelectedValue.ToString().Trim() == string.Empty)
            {
                dsContratoConsumo2.sub_modalidad_contrato.Clear();
                return;
            }

            sub_modalidad_contratoTableAdapter1.FillBycod_modalidad_contrato(dsContratoConsumo2.sub_modalidad_contrato,
                int.Parse(cmbModalidadVinculado.SelectedValue.ToString()));
        }

        private void btnAgregarConsumible_Click(object sender, EventArgs e)
        {
            frmconsumiblexContratos fr = new frmconsumiblexContratos();
            
            int codC = this.cod_contrato_consumo;
            fr.codContrato = codC;

            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltConsumiblexContratoConsumoTableAdapter1.Fill(dsContratoConsumo1.pltConsumiblexContratoConsumo,codC);
            }
            
        }

        private void btnEditarConsumible_Click(object sender, EventArgs e)
        {
            if (grdConsumibles.Columns["cod_consumiblexcontrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmconsumiblexContratos fr = new frmconsumiblexContratos();
            
            fr.codContrato = this.cod_contrato_consumo;
            fr.cod = int.Parse(grdConsumibles.Columns["cod_consumiblexcontrato_consumo"].Text);

            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltConsumiblexContratoConsumoTableAdapter1.Fill(dsContratoConsumo1.pltConsumiblexContratoConsumo, this.cod_contrato_consumo);
            }
        }

        private void btnEliminarConsumible_Click(object sender, EventArgs e)
        {
            if (grdConsumibles.Columns["cod_consumiblexcontrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    consumiblexcontrato_consumoTableAdapter1.DeleteQuery( int.Parse( grdConsumibles.Columns["cod_consumiblexcontrato_consumo"].Text));
                    pltConsumiblexContratoConsumoTableAdapter1.Fill(dsContratoConsumo1.pltConsumiblexContratoConsumo, this.cod_contrato_consumo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }

        }

        private void btnImportarConsumiblesContrato_Click(object sender, EventArgs e)
        {
            //traemos todos los equipos del contrato raiz
            SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
            contrato_consumoTableAdapter1.FillBynumero_contrato(ds.contrato_consumo, NumeroContrato);
            int codC = ds.contrato_consumo[1].cod_contrato_consumo;

            consumiblexcontrato_consumoTableAdapter1.FillBycod_contrato_consumo(ds.consumiblexcontrato_consumo, codC);
            for (int k = 0; k < ds.consumiblexcontrato_consumo.Count; k++)
            {
                consumiblexcontrato_consumoTableAdapter1.Insert(
                    ds.consumiblexcontrato_consumo[k].Iscod_consumibleNull() ? ((int?)null) : ds.consumiblexcontrato_consumo[k].cod_consumible,
                    ds.consumiblexcontrato_consumo[k].IscantidadNull() ? ((decimal?)null) : ds.consumiblexcontrato_consumo[k].cantidad,
                    cod_contrato_consumo
                    );
            }
            pltConsumiblexContratoConsumoTableAdapter1.Fill(dsContratoConsumo1.pltConsumiblexContratoConsumo, this.cod_contrato_consumo);
        }

        private void cmbVigencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVigencia.SelectedValue != null && cmbVigencia.SelectedValue.ToString().Trim() != string.Empty)
            {
                if (cmbVigencia.Text.ToLower().IndexOf("no") >= 0)
                {
                    cmbRazonVigencia.Enabled = true;
                }else {
                    cmbRazonVigencia.Enabled = false;
                    cmbRazonVigencia.SelectedIndex=-1;
                }
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmTipoSoftwarexContrato fr = new frmTipoSoftwarexContrato();
            fr.codContrato = this.cod_contrato_consumo;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltTipoSoftwarexContratoTableAdapter1.Fill(dsContratoConsumo1.pltTipoSoftwarexContrato, this.cod_contrato_consumo);
            }
        }

        private void btnEditarSoftware_Click(object sender, EventArgs e)
        {
            if (grdTipoSoftware.Columns["cod_tipo_softwarexcontrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            frmTipoSoftwarexContrato fr = new frmTipoSoftwarexContrato();
            fr.codContrato = this.cod_contrato_consumo;
            fr.codDetalle = int.Parse(grdTipoSoftware.Columns["cod_tipo_softwarexcontrato_consumo"].Text.Trim());
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pltTipoSoftwarexContratoTableAdapter1.Fill(dsContratoConsumo1.pltTipoSoftwarexContrato, this.cod_contrato_consumo);
            }
        }

        private void btnEliminarSoftware_Click(object sender, EventArgs e)
        {
            if (grdTipoSoftware.Columns["cod_tipo_softwarexcontrato_consumo"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    tipo_softwarexcontrato_consumoTableAdapter1.DeleteQuery(int.Parse(grdTipoSoftware.Columns["cod_tipo_softwarexcontrato_consumo"].Text));
                    pltTipoSoftwarexContratoTableAdapter1.Fill(dsContratoConsumo1.pltTipoSoftwarexContrato, this.cod_contrato_consumo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete + " " + ex.Message);
                }
            }
        }

        private void btnImportarContrato_Click(object sender, EventArgs e)
        {
            //traemos todos los equipos del contrato raiz
            SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
            contrato_consumoTableAdapter1.FillBynumero_contrato(ds.contrato_consumo, NumeroContrato);
            int codC = ds.contrato_consumo[1].cod_contrato_consumo;

            tipo_softwarexcontrato_consumoTableAdapter1.FillBycod_contrato_consumo(ds.tipo_softwarexcontrato_consumo, codC);

            for (int k = 0; k < ds.tipo_softwarexcontrato_consumo.Count; k++)
            {
                tipo_softwarexcontrato_consumoTableAdapter1.Insert(

                    ds.tipo_softwarexcontrato_consumo[k].cod_tipo_software_contrato_consumo,

                    cod_contrato_consumo
                    , ds.tipo_softwarexcontrato_consumo[k].observaciones
                    );
            }
            pltTipoSoftwarexContratoTableAdapter1.Fill(dsContratoConsumo1.pltTipoSoftwarexContrato, this.cod_contrato_consumo);
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
        


        }

        private void actualizarEstadisitcas() 
        { 
            //primero traemos los otros si, que no esten generados
            string sql=@"SELECT cod_contrato_consumo from contrato_consumo where numero_contrato='"+txtNumeroContrato.Text.Trim()+@"'
and cod_contrato_consumo not in
(
select cod_contrato_consumo from log_cambio_contratos_consumo
)

order by fecha_creacion asc";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
           System.Data.DataTable tb =  bd.ejecutarConsulta(sql).Tables[0];
           SPControladoraDatos.dsContratoConsumo ds = new SPControladoraDatos.dsContratoConsumo();
           SPControladoraDatos.dsContratoConsumo dsAnterior = new SPControladoraDatos.dsContratoConsumo();
           

           for (int k = 0; k < tb.Rows.Count; k++)
           {
               int codcontrato = int.Parse(tb.Rows[k][0].ToString());
               contrato_consumoTableAdapter1.FillBycod_contrato_consumo(ds.contrato_consumo, codcontrato);
               int codContratoAnterior = 0;
               sql = "select top 1 cod_contrato_consumo from contrato_consumo where numero_contrato='" + txtNumeroContrato.Text + "' and cod_contrato_consumo < " + codcontrato + " order by cod_contrato_consumo desc";
               var v = bd.ejecutarProcedimiento(sql);
               if (v != null && v != System.DBNull.Value)
               {
                   codContratoAnterior = int.Parse(v.ToString());
               }
               //equipos totales

               int equiposAgregados = 0;
               int equiposEliminados = 0;
               int equiposTotales = 0;
               int softwareAgregado = 0;
               int softwareEliminado = 0;
               int softwareTotal = 0;
 

               //cargamos los equipos
               equiposxcontrato_consumoTableAdapter1.FillBycod_contrato_consumo(ds.equiposxcontrato_consumo, codcontrato);
               equiposxcontrato_consumoTableAdapter1.FillBycod_contrato_consumo(dsAnterior.equiposxcontrato_consumo, codContratoAnterior);
               equiposTotales = ds.equiposxcontrato_consumo.Count;
               List<string> modelosProcesados=new List<string>();
               //calculamos los nuevos
               for (int j = 0; j < ds.equiposxcontrato_consumo.Count; j++)
               {
                   if (ds.equiposxcontrato_consumo[j].IsserialNull() || ds.equiposxcontrato_consumo[j].serial.Trim() == string.Empty)
                   {
                       //verificamos los modelos que estan agregados que antes no
                       if (modelosProcesados.Contains(ds.equiposxcontrato_consumo[j].codModelo.Trim().Trim()))
                       {
                           continue;
                       }
                       sql = "select count(*) from equiposxcontrato_consumo where codModelo='" + ds.equiposxcontrato_consumo[j].codModelo.Trim() + "' and cod_contrato_consumo="+codcontrato;
                       int modelosactuales= int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                       sql = "select count(*) from equiposxcontrato_consumo where codModelo='" + ds.equiposxcontrato_consumo[j].codModelo.Trim() + "' and cod_contrato_consumo=" + codContratoAnterior;
                       int modelosanteriores = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                    if(modelosactuales>= modelosanteriores)
                       equiposAgregados += modelosactuales - modelosanteriores;
                       
                       modelosProcesados.Add(ds.equiposxcontrato_consumo[j].codModelo.Trim().Trim());
                   }else { 
                   //miramos si el serial no estaba en el equipo anterior
                       if (ds.equiposxcontrato_consumo[0].serial != null)
                       {
                           if (dsAnterior.equiposxcontrato_consumo.Select("serial ='" + ds.equiposxcontrato_consumo[0].serial + "'").Length == 0)
                               equiposAgregados++;
                       }
                    }
               }

               modelosProcesados = new List<string>();
               //calculamos los eliminados
               for (int j = 0; j < dsAnterior.equiposxcontrato_consumo.Count; j++)
               {
                   if (dsAnterior.equiposxcontrato_consumo[j].IsserialNull() || dsAnterior.equiposxcontrato_consumo[j].serial.Trim() == string.Empty)
                   {
                       //verificamos los modelos que estan agregados que antes no
                       if (modelosProcesados.Contains(dsAnterior.equiposxcontrato_consumo[j].codModelo.Trim().Trim()))
                       {
                           continue;
                       }
                       sql = "select count(*) from equiposxcontrato_consumo where codModelo='" + dsAnterior.equiposxcontrato_consumo[j].codModelo.Trim() + "' and cod_contrato_consumo=" + codcontrato;
                       int modelosactuales = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                       sql = "select count(*) from equiposxcontrato_consumo where codModelo='" + dsAnterior.equiposxcontrato_consumo[j].codModelo.Trim() + "' and cod_contrato_consumo=" + codContratoAnterior;
                       int modelosanteriores = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                    if(modelosactuales<= modelosanteriores)
                       equiposEliminados += modelosanteriores - modelosactuales;
                       modelosProcesados.Add(dsAnterior.equiposxcontrato_consumo[j].codModelo.Trim().Trim());
                   }
                   else
                   {
                       //miramos si el serial no estaba en el equipo anterior
                       if (dsAnterior.equiposxcontrato_consumo[0].serial != null)
                       {
                           if (ds.equiposxcontrato_consumo.Select("serial ='" + dsAnterior.equiposxcontrato_consumo[0].serial + "'").Length == 0)
                               equiposEliminados++;
                       }
                   }
               }

               //ahora vamos con el software
               //cargamos los equipos
               tipo_softwarexcontrato_consumoTableAdapter1.FillBycod_contrato_consumo(ds.tipo_softwarexcontrato_consumo, codcontrato);
               tipo_softwarexcontrato_consumoTableAdapter1.FillBycod_contrato_consumo(dsAnterior.tipo_softwarexcontrato_consumo, codContratoAnterior);
               softwareTotal = ds.tipo_softwarexcontrato_consumo.Count;
               modelosProcesados = new List<string>();
               //calculamos los nuevos
               for (int j = 0; j < ds.tipo_softwarexcontrato_consumo.Count; j++)
               {
                       if (modelosProcesados.Contains(ds.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo.ToString()))
                       {
                           continue;
                       }
                       sql = "select count(*) from tipo_softwarexcontrato_consumo where cod_tipo_software_contrato_consumo='" + ds.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo + "' and cod_contrato_consumo=" + codcontrato;
                       int modelosactuales = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                       sql = "select count(*) from tipo_softwarexcontrato_consumo where cod_tipo_software_contrato_consumo='" + ds.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo + "' and cod_contrato_consumo=" + codContratoAnterior;
                       int modelosanteriores = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                       if (modelosactuales >= modelosanteriores)
                           softwareAgregado += modelosactuales - modelosanteriores;

                       modelosProcesados.Add(ds.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo.ToString());
               }

               modelosProcesados = new List<string>();
               //calculamos los eliminados
               for (int j = 0; j < dsAnterior.tipo_softwarexcontrato_consumo.Count; j++)
               {
                  
                       //verificamos los modelos que estan agregados que antes no
                   if (modelosProcesados.Contains(dsAnterior.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo.ToString()))
                       {
                           continue;
                       }
                   sql = "select count(*) from tipo_softwarexcontrato_consumo where cod_tipo_software_contrato_consumo='" + dsAnterior.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo + "' and cod_contrato_consumo=" + codcontrato;
                       int modelosactuales = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                       sql = "select count(*) from tipo_softwarexcontrato_consumo where cod_tipo_software_contrato_consumo='" + dsAnterior.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo + "' and cod_contrato_consumo=" + codContratoAnterior;
                       int modelosanteriores = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                       if (modelosactuales <= modelosanteriores)
                           softwareEliminado +=   modelosanteriores-modelosactuales;
                       modelosProcesados.Add(dsAnterior.tipo_softwarexcontrato_consumo[j].cod_tipo_software_contrato_consumo.ToString());
               }

    log_cambio_contratos_consumoTableAdapter1.Insert(txtNumeroContrato.Text, equiposAgregados, equiposEliminados, equiposTotales,
                       softwareAgregado, softwareEliminado, softwareTotal,
                       0, ds.contrato_consumo[0].fecha_creacion, codcontrato,ds.contrato_consumo[0].otro_si);

                   sql = @"declare @valor as decimal
select @valor =sum(valor_exigido) from linea_consumoxcontrato_consumo where cod_contrato_consumo ="+codcontrato+@"
update log_cambio_contratos_consumo set consumo_total= @valor where cod_contrato_consumo="+codcontrato;
                   bd.ejecutarComando(sql);
           
           }        
        }

        private void tabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            if (tabControl1.SelectedTab.Text.ToLower().IndexOf("log") >= 0)
            {
                actualizarEstadisitcas();
                log_cambio_contratos_consumoTableAdapter1.FillBynumero_contrato(dsContratoConsumo1.log_cambio_contratos_consumo, txtNumeroContrato.Text);
            }
        }

        private void btnRecaclcular_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            string sql = @"delete log_cambio_contratos_consumo where numero_contrato = '" + txtNumeroContrato.Text.Trim() + "'";
            bd.ejecutarComando(sql);

            actualizarEstadisitcas();
            log_cambio_contratos_consumoTableAdapter1.FillBynumero_contrato(dsContratoConsumo1.log_cambio_contratos_consumo, txtNumeroContrato.Text);

        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["cod_archivoxcontrato_consumo"].Text.Trim() == string.Empty) return;

            archivoxcontrato_consumoTableAdapter1.FillByCod_archivoxcontrato_consumo(dsContratoConsumo1.archivoxcontrato_consumo, int.Parse(grdArchivos.Columns["cod_archivoxcontrato_consumo"].Text));
            
            string archivo = System.IO.Path.GetTempPath()+"\\"+  dsContratoConsumo1.archivoxcontrato_consumo[0].nombre_archivo;
            
                System.IO.File.WriteAllBytes(archivo, dsContratoConsumo1.archivoxcontrato_consumo[0].archivo);
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(archivo);
            
        }

        private void btnExportarConsumiibles_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdConsumibles, "Consumibles "+txtNumeroContrato.Text, false);
        }


      

    }
}

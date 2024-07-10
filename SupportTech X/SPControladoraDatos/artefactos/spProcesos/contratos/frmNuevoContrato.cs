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
    public partial class frmNuevoContrato : Form
    {
        public frmNuevoContrato()
        {
            InitializeComponent();
        }

        private string numeroContrato="";
        public string NumeroContrato { set { numeroContrato = value; } get { return numeroContrato; } }

        /// <summary>
        /// Carga lo datos del contrato de la base de datos
        /// </summary>
        private void cargarDatos() 
        {
            eventosEncendidos = false;
            if (numeroContrato.Trim() == string.Empty) return;
            #region ventana principal
            repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, numeroContrato, 0);
            pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo,0, numeroContrato);
            contratosTableAdapter1.FillBynumeroContrato(dsSpx1.contratos, numeroContrato);
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
                if(!dsSpx1.contratos[0].IscodModalidadContratoNull())cmbModalidadContrato.SelectedValue = dsSpx1.contratos[0].codModalidadContrato.ToString();
                

                txtObervaciones.Text = dsSpx1.contratos[0].Observaciones;
               
                chkIncluyeRepuestos.Checked = dsSpx1.contratos[0].incluyeRepuestos;
                chkIncluyeTiquetes.Checked = dsSpx1.contratos[0].incluyeTiquetes;
                chkTienePoliza.Checked = dsSpx1.contratos[0].tienePolizaConsumoMinimo;
               
                rdconsumoMinimoGeneral.Checked = dsSpx1.contratos[0].consumoMinimoGeneral;
                rdConsumoxLinea.Checked = dsSpx1.contratos[0].consumoMinimoxLinea;
                
                nmDiasHabiles.Value = (decimal)dsSpx1.contratos[0].timeRptaDiasHabiles;
                nmHorasHabiles.Value = (decimal)dsSpx1.contratos[0].timeRptaHorasHabiles;
                nmMantenimientosIncluidos.Value = (decimal)dsSpx1.contratos[0].NumeroMantenimientos;

                if(!dsSpx1.contratos[0].IsincluyeCorrectivosNull())
                chkIncluyeCorrectivos.Checked = dsSpx1.contratos[0].incluyeCorrectivos;

                if (!dsSpx1.contratos[0].IstopeNumeroCorrectivosNull())
                nmTopeCorrectivos.Value = (decimal)dsSpx1.contratos[0].topeNumeroCorrectivos;

                nmMesesEntreMantenimientos.Value = (decimal)dsSpx1.contratos[0].mesesxMantenimiento;
                nmPorcentajePrecioTiquetes.Value = (decimal)dsSpx1.contratos[0].porcentajeTiquetes;
                if (!dsSpx1.contratos[0].IsfechaCreacionNull())
                {
                    calCreacion.Value = dsSpx1.contratos[0].fechaCreacion;
                    lblHora.Text = dsSpx1.contratos[0].fechaCreacion.ToLongTimeString();
                }

             
                calFinContrato.Value = dsSpx1.contratos[0].fechaFinContrato;
                calInicioContrato.Value = dsSpx1.contratos[0].fechaInicioContrato;
                //cargamos las tablas
                contratosxEquipoTableAdapter1.FillByNumeroContrato(dsSpx1.contratosxEquipo, numeroContrato);
                if (dsSpx1.contratosxEquipo.Rows.Count > 0)
                { cmbCliente.Enabled = false; btnBuscarNit.Enabled = false; btnLimpiarCliente.Enabled = false; }
                //
            }

#endregion
            eventosEncendidos = true;
        }

        private void frmNuevoContrato_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calFinContrato.MonthCalendar.DisplayMonth = n;
            calInicioContrato.MonthCalendar.DisplayMonth = n;
            
            grpConsumo.Enabled = false;
            grpMantenimiento.Enabled = false;
            eventosEncendidos = false;

            clientesTableAdapter1.FillByComboBox(dsSpx1.clientes);
            cmbCliente.SelectedValue = "";
            tipoContratoTableAdapter1.Fill(dsSpx1.tipoContrato);
            //estos son para los dropdownlist de las grillas de otros si
            tipoContratoTableAdapter1.Fill(dsOtrosSi.tipoContrato);
            modalidadContratoTableAdapter1.Fill(dsOtrosSi.modalidadContrato);
            //
            cmbTipoContrato.SelectedValue = "";
            calFinContrato.MonthCalendar.DisplayMonth = n;
            calInicioContrato.MonthCalendar.DisplayMonth = n;
            
            activarControles();
            if (numeroContrato.Trim() != string.Empty)
            {
                btnImprimir.Enabled = true;
                txtNroContrato.ReadOnly = true;
                txtNroContrato.Text = numeroContrato;
                cargarDatos();
            }
            eventosEncendidos = true;
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            cmbCliente.SelectedValue = "";
        }

        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscaCliente fc = new spProcesos.Equipos.frmBuscaCliente();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                cmbCliente.SelectedValue = fc.NitClente;
            }
        }

        /// <summary>
        /// Valida antes de guardar la informacion
        /// </summary>
        /// <returns></returns>
        private bool validar() 
        {
            if (cmbTipoContrato.SelectedValue == null || cmbTipoContrato.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("El Tipo de Contrato es obligatorio.");
                return false;
            }
            if (cmbModalidadContrato.SelectedValue == null || cmbModalidadContrato.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("La modalidad del Contrato es obligatorio.");
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
            a  = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoxLinea.Text);
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
            if (!validar())
                return;
            decimal tmp = 0;
            decimal.TryParse(txtConsumoMinimo.Text, out tmp);

            decimal consumoLinea = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoxLinea.Text);
            decimal consumoMinimo = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtConsumoMinimo.Text);
            decimal montoContrato = SPXUtilidades.clsFormato.formatoDineroToDecimal(txtMontoContrato.Text);

            if (numeroContrato.Trim() == string.Empty)
            {
                contratosTableAdapter1.Insert(txtNroContrato.Text, 0, cmbCliente.SelectedValue.ToString(), cmbTipoContrato.SelectedValue.ToString(),
                    chkIncluyeRepuestos.Checked, (int)nmMantenimientosIncluidos.Value, chkIncluyeTiquetes.Checked, chkTienePoliza.Checked,
                    rdConsumoxLinea.Checked, rdconsumoMinimoGeneral.Checked, consumoLinea, consumoMinimo, calInicioContrato.Value, (int)nmMesesEntreMantenimientos.Value,
                    txtObervaciones.Text, calFinContrato.Value, (int)nmDiasHabiles.Value, (int)nmHorasHabiles.Value, (int)nmPorcentajePrecioTiquetes.Value,
                    (cmbModalidadContrato.SelectedValue == null || cmbModalidadContrato.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbModalidadContrato.SelectedValue.ToString(),
                    montoContrato,SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,pltFechaSistemaTableAdapter1.GetData()[0].fechaISistema,
                    chkIncluyeCorrectivos.Checked,(int)nmTopeCorrectivos.Value);

                contratosTableAdapter1.FillByNumeroContratoCodOtroSI(dsSpx1.contratos, txtNroContrato.Text,0);
                numeroContrato = txtNroContrato.Text;
                activarControles();
            }
            else
            {
                contratosTableAdapter1.UpdateQuery(cmbCliente.SelectedValue.ToString(), cmbTipoContrato.SelectedValue.ToString(),
                    chkIncluyeRepuestos.Checked, (int)nmMantenimientosIncluidos.Value, chkIncluyeTiquetes.Checked, chkTienePoliza.Checked,
                    rdConsumoxLinea.Checked, rdconsumoMinimoGeneral.Checked, consumoLinea, consumoMinimo, calInicioContrato.Value, (int)nmMesesEntreMantenimientos.Value,
                    txtObervaciones.Text, calFinContrato.Value, (int)nmDiasHabiles.Value, (int)nmHorasHabiles.Value, (int)nmPorcentajePrecioTiquetes.Value,
                    (cmbModalidadContrato.SelectedValue == null || cmbModalidadContrato.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbModalidadContrato.SelectedValue.ToString(),
                    montoContrato,
                   chkIncluyeCorrectivos.Checked,(int)nmTopeCorrectivos.Value, 0, txtNroContrato.Text);
                contratosTableAdapter1.FillByNumeroContratoCodOtroSI(dsSpx1.contratos, txtNroContrato.Text,0);
                System.Media.SystemSounds.Exclamation.Play();
                activarControles();

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty) return;
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string strReporte = "";
            if (mantenimiento || deConsumo)
            {
                strReporte = "rptContratoMantenimiento";
            }else {
                strReporte = "rptContratoBasico";
            }
            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", strReporte);
            if (!dsSpx1.defaults[0].IslogotipoNull())
            {
                byte[] arr = (byte[])dsSpx1.defaults[0].logotipo;
                System.IO.Stream stream = new System.IO.MemoryStream(arr);
                Image im = Image.FromStream(stream);
                if (reporte.Fields.Contains("picLogo"))
                {
                    reporte.Fields["picLogo"].Picture = im;
                }
            }
            //if (reporte.Fields.Contains("lblTitulo"))
            //{
            //    reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloViajes.Trim();
            //}
            //if (reporte.Fields.Contains("lblVersion"))
            //{
            //    reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionViajes.Trim();
            //}
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<numeroContrato>>", numeroContrato);

            SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;
            frmRpt.ShowDialog();
        }

        #region zona de archivos
        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (c1GrdArchivos.Columns["codArchivo"].Value == null ||
      c1GrdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            try
            {
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    c1GrdArchivos.Columns["nombreArchivo"].Value.ToString());

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                     byte[] arr = archivosxcontratoTableAdapter1.GetDataByArchivo(txtNroContrato.Text,
                    int.Parse(c1GrdArchivos.Columns["codOtroSi"].Value.ToString()),
                    int.Parse(c1GrdArchivos.Columns["codArchivo"].Value.ToString()))[0].archivo;
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
            if (c1GrdArchivos.Columns["codArchivo"].Value == null ||
c1GrdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            saveFileDialog1.FileName = c1GrdArchivos.Columns["nombreArchivo"].Value.ToString();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string nombreArchivo = saveFileDialog1.FileName;

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = archivosxcontratoTableAdapter1.GetDataByArchivo(txtNroContrato.Text,
                    int.Parse(c1GrdArchivos.Columns["codOtroSi"].Value.ToString()),
                    int.Parse(c1GrdArchivos.Columns["codArchivo"].Value.ToString()))[0].archivo;

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
            if (numeroContrato.Trim() == string.Empty) return;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //
            frmMensaje frm = new frmMensaje();
            frm.titulo = "Descripcion del Archivo";
            frm.pregunta = "Ingrese una descripcion del archivo";
            //miramos si tiene ya algun otro si agregado
            if (dsOtrosSi.contratos.Rows.Count > 0)
            {
                frm.codOtroSi =""+( contratosTableAdapter1.verNextOtroSi(txtNroContrato.Text).Value-1);
            }
            frm.mensaje = openFileDialog1.FileName;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName
                    , System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);

                byte[] archivo = new byte[fs.Length];
                fs.Read(archivo, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                string nombre = System.IO.Path.GetFileName(openFileDialog1.FileName).Trim();
                if (nombre.Length >= 150) nombre = nombre.Substring(0, 150);
                string mensaje = frm.mensaje.Trim();
                if (mensaje.Length >= 250) mensaje = mensaje.Substring(0, 250);
                int codOtroSi=0;
                int.TryParse(frm.codOtroSi,out codOtroSi);
                int codArchivo = archivosxcontratoTableAdapter1.verNextId(txtNroContrato.Text,codOtroSi).Value;
                archivosxcontratoTableAdapter1.Insert(
                    txtNroContrato.Text, codOtroSi,codArchivo, nombre, archivo, mensaje);
                //cargaqmos los archivos
                archivosxcontratoTableAdapter1.FillByNumeroContrato(
                dsSpx1.archivosxcontrato, txtNroContrato.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            if (c1GrdArchivos.Columns["codArchivo"].Value == null ||
        c1GrdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el archivo relacionado al Contrato", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;


            archivosxcontratoTableAdapter1.DeleteQuery(txtNroContrato.Text, int.Parse(c1GrdArchivos.Columns["codOtroSi"].Value.ToString()), int.Parse(c1GrdArchivos.Columns["codArchivo"].Value.ToString()));
            //cargamos la grilla
            archivosxcontratoTableAdapter1.FillByNumeroContrato(
            dsSpx1.archivosxcontrato, txtNroContrato.Text);
        }

#endregion


        private void tabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            if (!eventosEncendidos) return;

            eventosEncendidos = false;
            if (e.NewTab.Text.Trim() == "Archivos por Contrato")
            {
                archivosxcontratoTableAdapter1.FillByNumeroContrato(dsSpx1.archivosxcontrato, numeroContrato);
            }else if (e.NewTab.Text.Trim() == "Anexos al Contrato (Otro SI)")
            {
                contratosTableAdapter1.FillByContratoSoloOtroSi(dsOtrosSi.contratos, numeroContrato);
                if (grdOtroSi.Columns["codOtroSi"].Text.Trim() != string.Empty)
                {
                    int a = int.Parse(grdOtroSi.Columns["codOtroSi"].Text);
                    pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillasEquipoOtroSi.pltComtratoxEquipo, a,
                        numeroContrato);
                }
            }else if (e.NewTab.Text.Trim() == "Equipos del Contrato")
            {
                pltComtratoxEquipoTableAdapter1.FillByNumeroContratoSolo(dsPltTotales.pltComtratoxEquipo,numeroContrato);
            }else if (e.NewTab.Text.Trim() == "Repuestos del Contrato")
            {
                repuestosxContratosTableAdapter1.FillByNroContrato(dsTotales.repuestosxContratos, numeroContrato);
            }else if (e.NewTab.Text.Trim() == "Vinculaciones / Desvinculaciones")
            {
                string sql = " select * from logVinculacionesDesvinculacionesContrato where numeroContrato = '" + numeroContrato.Trim()+"'";
                SPXdata.BD.DataConector obj=new SPXdata.BD.DataConector();
                grdVinculaciones.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            }
            eventosEncendidos = true;
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo objfrm = new spProcesos.Equipos.frmInformacionEquipo();
            objfrm.Serial = grdEquipos.Columns["serial"].Text.Trim();
            objfrm.ShowDialog();
        }

        private void btnVerEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmEquipos objfrm = new spProcesos.Equipos.frmEquipos();
            objfrm.SerialEquipo = grdEquipos.Columns["serial"].Text.Trim();
            objfrm.Show();
        }

        private void btnVincularEquipo_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty) 
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }
            
            //primero buscamos el equipo
            spProcesos.Equipos.frmBuscarEquipo objfrm = new spProcesos.Equipos.frmBuscarEquipo();
            objfrm.NitCliente = cmbCliente.SelectedValue.ToString();
            if (objfrm.ShowDialog() == DialogResult.OK)
            {
                contratosxEquipoTableAdapter1.FillBySerialNumContratoOtroSi(dsSpx1.contratosxEquipo, objfrm.Serial,
                    txtNroContrato.Text, 0);
                //verificamos que no este ya vinculado al equipo
                if(dsSpx1.contratosxEquipo.Count > 0)
                {
                    MessageBox.Show("Este contrato ya esta asociado con este equipo.");
                    return;
                }
                //cargamos los detalles de vinculacion
                contratos.frmDetallesVinculacionEquipo objdet = new frmDetallesVinculacionEquipo();
                objdet.mantenimientosIncluidos = (int)nmMantenimientosIncluidos.Value;
                DialogResult dg= DialogResult.OK;
                if (mantenimiento)
                {
                    dg=objdet.ShowDialog();
                }
                if (dg == DialogResult.OK)
                {
                    List<int> ordenes = new List<int>();
                    if (objdet.mantenimientosRealizados > 0)
                    {
                    
                        //obligatoriamente debe indicar cuales son las ordenes de servicio amarradas al servicio de lo contrario
                        //no permite guardarlo.
                        for (int k = 0; k < objdet.mantenimientosRealizados; k++)
                        {
                            frmVincularOrdenExistente frV = new frmVincularOrdenExistente();
                            frV.ordenesElegidas = ordenes;
                            frV.serial = objfrm.Serial;
                            if (frV.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
                        }
                    }
                    //insertamos la vinculacion
                    contratosxEquipoTableAdapter1.Insert(objfrm.Serial,0,txtNroContrato.Text,0,
                        objdet.mantenimientosIncluidos, objdet.esActivo,0,0);
                    //ahora vinculamos las ordenes
                    for (int k = 0; k < ordenes.Count; k++)
                    {
                        spProcesos.ordenesTrabajo.cls.osController os = new ordenesTrabajo.cls.osController();
                        os.vincularOrdenContrato(txtNroContrato.Text, 0, objfrm.Serial, ordenes[k]);
                    }
                    //luego hacemos el fill
                    pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo,0, numeroContrato);
                }
            }
            //
            contratosxEquipoTableAdapter1.FillByNumeroContrato(dsSpx1.contratosxEquipo, numeroContrato);
            if (dsSpx1.contratosxEquipo.Rows.Count > 0)
            { cmbCliente.Enabled = false; btnBuscarNit.Enabled = false; btnLimpiarCliente.Enabled = false; }
            else { cmbCliente.Enabled = true; btnBuscarNit.Enabled = true; btnLimpiarCliente.Enabled = true; }
            activarControles();
        }

        private void btnDesvincularEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;
            //validamos si este contrato x equipo tiene un mantenimiento no se puede desvincular el equipo.

            contratosxEquipoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.contratosxEquipo,
                int.Parse(grdEquipos.Columns["codContratosxEquipo"].Text));

            mantenimientosxContratoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.mantenimientosxContrato, dsSpx1.contratosxEquipo[0].codContratosxEquipo);

            if (dsSpx1.mantenimientosxContrato.Count > 0)
            {
                MessageBox.Show("No puede desvincular un serial que ya tenga mantenimientos asociados!!!");
                return;
            }


            if (MessageBox.Show("Esta seguro de desvincular este equipo al contrato!", "pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                //eliminamos la fila
                contratosxEquipoTableAdapter1.DeleteQuery(dsSpx1.contratosxEquipo[0].codContratosxEquipo );
            }
            pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo,0, numeroContrato);
            if (dsSpx1.contratosxEquipo.Rows.Count > 0)
            { cmbCliente.Enabled = false; btnBuscarNit.Enabled = false; btnLimpiarCliente.Enabled = false; }
            else { cmbCliente.Enabled = true; btnBuscarNit.Enabled = true; btnLimpiarCliente.Enabled = true; }
            activarControles();
        }

        private void btnCambiarContrato_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty)
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }
            if (grdEquipos.Columns["codcontratosxequipo"].Text.Trim() == string.Empty) return;
            int cod = int.Parse(grdEquipos.Columns["codcontratosxequipo"].Text);
            if (MessageBox.Show("Esta seguro de cambiar este equipo por otro para el contrato!", "pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string serial = grdEquipos.Columns["serial"].Text.Trim();
                spProcesos.Equipos.frmBuscarEquipo objfrm = new spProcesos.Equipos.frmBuscarEquipo();
               objfrm.NitCliente = cmbCliente.SelectedValue.ToString();
               if (objfrm.ShowDialog() == DialogResult.OK)
               { 
                       contratosxEquipoTableAdapter1.UpdateSerial(objfrm.Serial , cod);
                       //luego hacemos el fill
                    pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo,0, numeroContrato);
               }
            }
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
            else {

                rdConsumoxLinea.Enabled = true;
                rdConsumoxLinea.Checked = true;
                txtConsumoxLinea.Enabled = true;

                rdconsumoMinimoGeneral.Enabled = true;
                rdconsumoMinimoGeneral.Checked = false;
                txtConsumoMinimo.Enabled = false;
            }
        }

     

        bool mantenimiento = false;
        bool deConsumo = false;

        private void cmbTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoContrato.SelectedValue != null && cmbTipoContrato.SelectedValue.ToString().Trim() != string.Empty){
                mantenimiento = false;
                deConsumo = false;

                modalidadContratoTableAdapter1.FillBycodTipoContrato(dsSpx1.modalidadContrato, cmbTipoContrato.SelectedValue.ToString());
                //miramos el tipo de contrato
                if (tipoContratoTableAdapter1.GetDataBycodTipoContrato(cmbTipoContrato.SelectedValue.ToString())[0].deMantenimiento)
                {
                    grpMantenimiento.Enabled = true;
                    mantenimiento = true;
                    btnEditarInfoEquipo.Visible = true;
                    grdEquipos.Splits[0].DisplayColumns["mantenimientosxContrato"].Visible = true;
                    grdEquipos.Splits[0].DisplayColumns["mantenimientosRealizados"].Visible = true;
                    
                }else {
                    
                    chkIncluyeRepuestos.Checked = false;
                    if (chkIncluyeRepuestos.Checked) return;
                    btnEditarInfoEquipo.Visible = false;
                    grpMantenimiento.Enabled = false;
                    mantenimiento = false;
                    grdEquipos.Splits[0].DisplayColumns["mantenimientosxContrato"].Visible = false;
                    grdEquipos.Splits[0].DisplayColumns["mantenimientosRealizados"].Visible = false;
                }
                //--
                if (tipoContratoTableAdapter1.GetDataBycodTipoContrato(cmbTipoContrato.SelectedValue.ToString())[0].deConsumo)
                {
                    grpConsumo.Enabled = true;
                    deConsumo = true;
                }
                else
                {
                    grpConsumo.Enabled = false;
                    if(chkTienePoliza.Checked) MessageBox.Show("Al Cambiar el tipo de Contrato perdera la Informacion de los consumos!!!");
                    chkTienePoliza.Checked = false;
                    txtConsumoMinimo.Text = "";
                    txtConsumoxLinea.Text = "";
                    rdconsumoMinimoGeneral.Checked = false;
                    rdConsumoxLinea.Checked = false;
                }
            }else{
                dsSpx1.modalidadContrato.Clear();
                grpMantenimiento.Enabled = false;
                grpConsumo.Enabled = false;
            }
        }

       
        bool eventosEncendidos = true;
      

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
            //
            spProcesos.contratos.frmRepuestoxContrato fr = new frmRepuestoxContrato();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //validamos que no exista
                if (repuestosxContratosTableAdapter1.GetDataByRepuestoContrato(0, fr.codigoRepuesto, txtNroContrato.Text).Count>0)
                {
                    MessageBox.Show("Ya tiene repuestos con el codigo "+fr.codigoRepuesto.Trim()+" asociados al contrato!!!!");
                    return;
                }
                repuestosxContratosTableAdapter1.Insert(txtNroContrato.Text, 0, fr.codigoRepuesto, fr.cantidad, fr.observaciones);
                repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, txtNroContrato.Text, 0);
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
                
                repuestosxContratosTableAdapter1.UpdateQuery(fr.cantidad,fr.observaciones,0, fr.codigoRepuesto, txtNroContrato.Text);
                repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, txtNroContrato.Text, 0);
            }
        }

        private void btnDesvincularRepuesto_Click(object sender, EventArgs e)
        {
            if (grdRepuestos.Columns["codRepuesto"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("esta seguro de desvincular el repuesto seleccionado?\nEste cambio no se puede deshacer!!","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes) return;
            repuestosxContratosTableAdapter1.DeleteQuery(txtNroContrato.Text,0, grdRepuestos.Columns["codRepuesto"].Text);
            repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, txtNroContrato.Text, 0);
        }

        private void chkIncluyeRepuestos_CheckedChanged(object sender, EventArgs e)
        {
            if (dsSpx1.contratos.Rows.Count <= 0) return;
            if (chkIncluyeRepuestos.Checked)
            {
                btnAgregarRepuestos.Enabled = true;
                btnModificarRepuesto.Enabled = true;
                btnDesvincularRepuesto.Enabled = true;
            }else {
                if (dsSpx1.repuestosxContratos.Rows.Count > 0)
                {
                    if (MessageBox.Show("Esta seguro de deshabilitar esta opcion?\nse desvincularan todos los repuestos, esta Opcion no se puede deshacer ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    {
                        chkIncluyeRepuestos.Checked = true;
                        return;
                    }
                    repuestosxContratosTableAdapter1.DeleteByNumeroContrato(txtNroContrato.Text);
                    repuestosxContratosTableAdapter1.FillByContratoOtroSi(dsSpx1.repuestosxContratos, numeroContrato,0);

                    
                }
                btnAgregarRepuestos.Enabled = false;
                btnModificarRepuesto.Enabled = false;
                btnDesvincularRepuesto.Enabled = false;
            }
        }


        #region zona de formatos de dinero

        private void txtMontoContrato_TextChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            eventosEncendidos = false;
            SPXUtilidades.clsFormato.formatoDinero(txtMontoContrato, false);
            eventosEncendidos = true;
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
        private void txtMontoContrato_Validating(object sender, CancelEventArgs e)
        {
            if (!eventosEncendidos) return;
            eventosEncendidos = false;
            SPXUtilidades.clsFormato.formatoDinero(txtMontoContrato, true);
            eventosEncendidos = true;
        }

        private void txtConsumoxLinea_Validating(object sender, CancelEventArgs e)
        {
            if (!eventosEncendidos) return;
            eventosEncendidos = false;
            SPXUtilidades.clsFormato.formatoDinero(txtConsumoxLinea, true);
            eventosEncendidos = true;
        }

        private void txtConsumoMinimo_Validating(object sender, CancelEventArgs e)
        {
            if (!eventosEncendidos) return;
            eventosEncendidos = false;
            SPXUtilidades.clsFormato.formatoDinero(txtConsumoMinimo, true);
            eventosEncendidos = true;
        }
        #endregion

        private void activarControles()
        {
            if (numeroContrato.Trim() == string.Empty)
            {
                btnAgregarRepuestos.Enabled = false;
                btnModificarRepuesto.Enabled = false;
                btnDesvincularRepuesto.Enabled = false;
                btnVincularEquipo.Enabled = false;
                btnCambiarContrato.Enabled = false;
                btnDesvincularEquipo.Enabled = false;
                btnImprimir.Enabled = false;
                btnVincularEquipo.Enabled = false;
                btnCambiarContrato.Enabled = false;
                btnDesvincularEquipo.Enabled = false;
                btnBuscarNit.Enabled = true;
                btnEditarInfoEquipo.Enabled = false;
                cmbCliente.Enabled = true;
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
                btnEditarInfoEquipo.Enabled = true;
                txtNroContrato.ReadOnly = true;
               
                btnVincularEquipo.Enabled = true;
                btnCambiarContrato.Enabled = true;
                btnDesvincularEquipo.Enabled = true;
                btnImprimir.Enabled = true;
                btnVincularEquipo.Enabled = true;
                btnCambiarContrato.Enabled = true;
                btnDesvincularEquipo.Enabled = true;
                if (dsSpx1.contratosxEquipo.Rows.Count > 0)
                {
                    btnBuscarNit.Enabled = false;
                    cmbCliente.Enabled = false;
                }else {
                    btnBuscarNit.Enabled = true;
                    cmbCliente.Enabled = true;
                }
            
            }


        }

        private void btnEditarInfoEquipo_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty)
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;
            string serial = lblSerial.Text;
            int cod = int.Parse(grdEquipos.Columns["codContratosxEquipo"].Text.Trim());
            contratosxEquipoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.contratosxEquipo, cod);
            contratos.frmDetallesVinculacionEquipo objdet = new frmDetallesVinculacionEquipo();
            objdet.editableRealizados = false;
            objdet.mantenimientosIncluidos = dsSpx1.contratosxEquipo[0].mantenimientosxContrato;
            objdet.mantenimientosRealizados = dsSpx1.contratosxEquipo[0].mantenimientosRealizados;
            objdet.esActivo = dsSpx1.contratosxEquipo[0].esActivo;

            if (objdet.ShowDialog() == DialogResult.OK)
            {   
                //actualizamos solo los mantenimientos incluidos
                contratosxEquipoTableAdapter1.UpdateMantenimientosxContrato(
                    objdet.mantenimientosIncluidos, objdet.esActivo, int.Parse(grdEquipos.Columns["codContratosxEquipo"].Text));
                  //luego hacemos el fill
                  pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo,0, numeroContrato);
            }
            
        }

        private void tabControl1_SelectedTabChanging(object sender, DevComponents.DotNetBar.TabStripTabChangingEventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty)
            {
                e.Cancel = true;
                return;
            }
        }


        //---------------------------------------------------------------------------------------//
        //bienen las opciones de ottro si

        private void btnAgregarOtroSi_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty) return;
            frmNuevoOtroSi fr = new frmNuevoOtroSi();
            fr.NumeroContrato = numeroContrato;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                contratosTableAdapter1.FillByContratoSoloOtroSi(dsOtrosSi.contratos, numeroContrato);
            }
        }

        private void btnEditOtroSi_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty) return;
            if (grdOtroSi.Columns["codOtroSI"].Text.Trim() == string.Empty) return;
            frmNuevoOtroSi fr = new frmNuevoOtroSi();
            fr.NumeroContrato = numeroContrato;
            fr.CodOtroSi = grdOtroSi.Columns["codOtroSI"].Text;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                contratosTableAdapter1.FillByContratoSoloOtroSi(dsOtrosSi.contratos, numeroContrato);
            }
        }

        private void btnEliminarOtroSi_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty) return;
            if (grdOtroSi.Columns["codOtroSI"].Text.Trim() == string.Empty) return;
            //esta seguro de elimnar 
            if (MessageBox.Show("Esta seguro de elimar el anexo al contrato?\neste cambio no se puede deshacer", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //eliminamos los repuestos
                repuestosxContratosTableAdapter1.DeleteByOtroSi(numeroContrato, int.Parse(grdOtroSi.Columns["codOtroSI"].Text));
                archivosxcontratoTableAdapter1.DeleteByOtroSi(numeroContrato, int.Parse(grdOtroSi.Columns["codOtroSI"].Text));
                contratosTableAdapter1.DeleteQuery(numeroContrato, int.Parse(grdOtroSi.Columns["codOtroSI"].Text));
                contratosxEquipoTableAdapter1.DeleteByContrato(numeroContrato, int.Parse(grdOtroSi.Columns["codOtroSI"].Text));
                contratosTableAdapter1.FillByContratoSoloOtroSi(dsOtrosSi.contratos, numeroContrato);
            }
        }

        private void btnAgregarEquipoOtroSi_Click(object sender, EventArgs e)
        { 



            if (numeroContrato.Trim() == string.Empty)
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }
            if (grdOtroSi.Columns["numeroContrato"].Text.Trim() == string.Empty) return;
            //primero buscamos el equipo
            spProcesos.Equipos.frmBuscarEquipo objfrm = new spProcesos.Equipos.frmBuscarEquipo();
            objfrm.NitCliente = cmbCliente.SelectedValue.ToString();
            int otroSi=0;
            otroSi = int.Parse(grdOtroSi.Columns["codOtroSi"].Text);

            if (objfrm.ShowDialog() == DialogResult.OK)
            { 
                contratosxEquipoTableAdapter1.FillBySerialNumContratoOtroSi(dsSpx1.contratosxEquipo, objfrm.Serial,
                    txtNroContrato.Text, otroSi);
                //verificamos que no este ya vinculado al equipo
                if (dsSpx1.contratosxEquipo.Count > 0)
                {
                    MessageBox.Show("Este contrato ya esta asociado con este equipo.");
                    return;
                }    
      

                //cargamos los detalles de vinculacion
                contratos.frmDetallesVinculacionEquipo objdet = new frmDetallesVinculacionEquipo();
                objdet.mantenimientosIncluidos = (int)nmMantenimientosIncluidos.Value;
                DialogResult dg = DialogResult.OK;
                if (mantenimiento)
                {
                    dg = objdet.ShowDialog();
                }
              
                //cargamos los detalles de vinculacion
                if (dg == DialogResult.OK)
                {    
                    int k=0;
            
#region
                    List<int> ordenes = new List<int>();
                    if (objdet.mantenimientosRealizados > 0)
                    {
                        //obligatoriamente debe indicar cuales son las ordenes de servicio amarradas al servicio de lo contrario
                        //no permite guardarlo.
                        for ( k = 0; k < objdet.mantenimientosRealizados; k++)
                        {
                            frmVincularOrdenExistente frV = new frmVincularOrdenExistente();
                            frV.ordenesElegidas = ordenes;
                            frV.serial = objfrm.Serial;
                            if (frV.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
                        }
                    } 

                    //insertamos la vinculacion
                    contratosxEquipoTableAdapter1.Insert(objfrm.Serial, otroSi, txtNroContrato.Text, 0,
                        objdet.mantenimientosIncluidos, objdet.esActivo, 0, 0);
                    //ahora vinculamos las ordenes
                    for ( k = 0; k < ordenes.Count; k++)
                    {
                        spProcesos.ordenesTrabajo.cls.osController os = new ordenesTrabajo.cls.osController();
                        os.vincularOrdenContrato(txtNroContrato.Text, otroSi, objfrm.Serial, ordenes[k]);
                    }
                    //luego hacemos el fill
                    pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillasEquipoOtroSi.pltComtratoxEquipo, otroSi, numeroContrato);
#endregion
                }
            }
        }

        private void btnCambiarEquipoOtroSi_Click(object sender, EventArgs e)
        {
            if (numeroContrato.Trim() == string.Empty)
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }
            if (grdOtroSi.Columns["numeroContrato"].Text.Trim() == string.Empty) return;

            if (grdEquiposOtroSi.Columns["serial"].Text.Trim() == string.Empty) return;

            int otroSi = 0;
            otroSi = int.Parse(grdOtroSi.Columns["codOtroSi"].Text);

            if (grdEquiposOtroSi.Columns["codcontratosxequipo"].Text.Trim() == string.Empty) return;
            int cod = int.Parse(grdEquiposOtroSi.Columns["codcontratosxequipo"].Text);
            if (MessageBox.Show("Esta seguro de cambiar este equipo por otro para el contrato!", "pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string serial = grdEquiposOtroSi.Columns["serial"].Text.Trim();
                spProcesos.Equipos.frmBuscarEquipo objfrm = new spProcesos.Equipos.frmBuscarEquipo();
                objfrm.NitCliente = cmbCliente.SelectedValue.ToString();
                if (objfrm.ShowDialog() == DialogResult.OK)
                {
                    contratosxEquipoTableAdapter1.UpdateSerial(objfrm.Serial, cod);
                    //luego hacemos el fill
                    pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo, otroSi, numeroContrato);
                }
            }
         
        }

        private void btnEditInfoequipoOtroSi_Click(object sender, EventArgs e)
        {

            if (numeroContrato.Trim() == string.Empty)
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }
            if (grdEquiposOtroSi.Columns["numeroContrato"].Text.Trim() == string.Empty) return;
            if (grdEquiposOtroSi.Columns["serial"].Text.Trim() == string.Empty) return;
            int otroSi = 0;
            otroSi = int.Parse(grdEquiposOtroSi.Columns["codOtroSi"].Text);
            string serial = lblSerialOtroSi.Text.Trim();
            // 
            int cod = int.Parse(grdEquiposOtroSi.Columns["codContratosxEquipo"].Text.Trim());
            contratosxEquipoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.contratosxEquipo, cod);
            contratos.frmDetallesVinculacionEquipo objdet = new frmDetallesVinculacionEquipo();
            objdet.editableRealizados = false;
            objdet.mantenimientosIncluidos = dsSpx1.contratosxEquipo[0].mantenimientosxContrato;
            objdet.mantenimientosRealizados = dsSpx1.contratosxEquipo[0].mantenimientosRealizados;
            objdet.esActivo = dsSpx1.contratosxEquipo[0].esActivo;

            if (objdet.ShowDialog() == DialogResult.OK)
            {
                //actualizamos solo los mantenimientos incluidos
                contratosxEquipoTableAdapter1.UpdateMantenimientosxContrato(
                    objdet.mantenimientosIncluidos, objdet.esActivo, int.Parse(grdEquiposOtroSi.Columns["codContratosxEquipo"].Text));
                //luego hacemos el fill
                pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo, otroSi, numeroContrato);
            }
        }

        private void btnEliminarEquipoOtroSi_Click(object sender, EventArgs e)
        {
         if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;
            //validamos si este contrato x equipo tiene un mantenimiento no se puede desvincular el equipo.

            contratosxEquipoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.contratosxEquipo,
                int.Parse(grdEquipos.Columns["codContratosxEquipo"].Text));

            mantenimientosxContratoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.mantenimientosxContrato, dsSpx1.contratosxEquipo[0].codContratosxEquipo);

            if (grdEquiposOtroSi.Columns["serial"].Text.Trim() == string.Empty) return;
            int otroSi = 0;
            otroSi = int.Parse(grdEquiposOtroSi.Columns["codOtroSi"].Text);
            contratosxEquipoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.contratosxEquipo,
               int.Parse(grdEquiposOtroSi.Columns["codContratosxEquipo"].Text));
            mantenimientosxContratoTableAdapter1.FillBycodContratosxEquipo(dsSpx1.mantenimientosxContrato, dsSpx1.contratosxEquipo[0].codContratosxEquipo);
            if (dsSpx1.mantenimientosxContrato.Count > 0)
            {
                MessageBox.Show("No puede desvincular un serial que ya tenga mantenimientos asociados!!!");
                return;
            }

            if (MessageBox.Show("Esta seguro de desvincular este equipo al contrato!", "pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //eliminamos la fila
                contratosxEquipoTableAdapter1.DeleteQuery(dsSpx1.contratosxEquipo[0].codContratosxEquipo);
            }
            pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillasEquipoOtroSi.pltComtratoxEquipo, otroSi, numeroContrato);
  
        }

        private void btnHojaDeVidaEOtroSi_Click(object sender, EventArgs e)
        {
            if (grdEquiposOtroSi.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo objfrm = new spProcesos.Equipos.frmInformacionEquipo();
            objfrm.Serial = grdEquiposOtroSi.Columns["serial"].Text.Trim();
            objfrm.ShowDialog();
        }

        private void btnExportarEquiposOtro_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdEquiposOtroSi, "Equipos Contrato " + numeroContrato, false);
        }

        private void grdOtroSi_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            if (!eventosEncendidos) return;
            
            if (grdOtroSi.Columns["codOtroSi"].Text.Trim() != string.Empty)
            {
                int a = int.Parse(grdOtroSi.Columns["codOtroSi"].Text);
                pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillasEquipoOtroSi.pltComtratoxEquipo,
                  a,  numeroContrato);
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

        private void btnExportarRepuestos_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdRepuestosTodoContrato, "Equipos Contrato " + numeroContrato, false);
        }

        private void btnExportarEquposTodos_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objX = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objX.exportar(grdtodosequipos, "Repuestos Contrato " + numeroContrato, false);
        }

        private void btnDesvincularOden_Click(object sender, EventArgs e)
        {
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(1107))
            { 
                MessageBox.Show("No tiene permisos para ejecutar esta accion!");
                return;
            }
            
            if (grdEquipos.Columns["codOrdenServicio"].Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar una orden!");
                return;
            }
            if (MessageBox.Show("Esta seguro de desvincular la orden de servicio " + grdEquipos.Columns["codOrdenServicio"].Text + " al contrato!", "pregunta", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
          
            spProcesos.ordenesTrabajo.cls.osController os = new ordenesTrabajo.cls.osController();
            os.desVincularOrdenContrato( int.Parse(grdEquipos.Columns["codOrdenServicio"].Text));

            //luego hacemos el fill
            pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo, 0, numeroContrato);
          
        }

        private void btnVincularOrden_Click(object sender, EventArgs e)
        {
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(1103))
            { 
                MessageBox.Show("No tiene permisos para ejecutar esta accion!");
                return;
            }
            
            if (numeroContrato.Trim() == string.Empty)
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }

            if (lblSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un Serial!!!");
                return;
            }
            string s = lblSerial.Text;
            //primero buscamos la orden
            List<int> ordenes= new List<int>();
            frmVincularOrdenExistente frV = new frmVincularOrdenExistente();
                frV.ordenesElegidas= ordenes;
                frV.serial = s;
            if (frV.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
            
            spProcesos.ordenesTrabajo.cls.osController os = new ordenesTrabajo.cls.osController();
            os.vincularOrdenContrato(txtNroContrato.Text, 0, s, ordenes[0]);       
            //luego hacemos el fill
             pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillas1.pltComtratoxEquipo, 0, numeroContrato);
          
        }

        private void btnVincularOrdenOtroSi_Click(object sender, EventArgs e)
        {
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(1103))
            { 
                MessageBox.Show("No tiene permisos para ejecutar esta accion!");
                return;
            }
            
            if (numeroContrato.Trim() == string.Empty)
            {
                MessageBox.Show("Guarde primero el encabezado antes de vincular equipos al contrato.");
                return;
            }

            if (grdEquiposOtroSi.Columns["serial"].Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un Serial!!!");
                return;
            }
            string s = lblSerialOtroSi.Text;
            int otroSi = 0;
            otroSi = int.Parse(grdEquiposOtroSi.Columns["codOtroSi"].Text);
            //primero buscamos la orden
            List<int> ordenes = new List<int>();
            frmVincularOrdenExistente frV = new frmVincularOrdenExistente();
            frV.ordenesElegidas = ordenes;
            frV.serial = s;
            if (frV.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            spProcesos.ordenesTrabajo.cls.osController os = new ordenesTrabajo.cls.osController();
            os.vincularOrdenContrato(txtNroContrato.Text, otroSi, s, ordenes[0]);

            //luego hacemos el fill
            pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillasEquipoOtroSi.pltComtratoxEquipo, otroSi, numeroContrato);
          
        }

        private void btnDesvincularOrdenOtroSi_Click(object sender, EventArgs e)
        {
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(1107))
            { 
                MessageBox.Show("No tiene permisos para ejecutar esta accion!");
                return;
            }
            if (grdEquiposOtroSi.Columns["codOdenServicio"].Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe seleccionar una orden!");
                return;
            }

            if (MessageBox.Show("Esta seguro de desvincular la orden " + grdEquiposOtroSi.Columns["codOdenServicio"].Text + " al contrato!", "pregunta", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            int otroSi = 0;
            otroSi = int.Parse(grdEquiposOtroSi.Columns["codOtroSi"].Text);
            spProcesos.ordenesTrabajo.cls.osController os = new ordenesTrabajo.cls.osController();
            os.desVincularOrdenContrato(int.Parse(grdEquiposOtroSi.Columns["codOdenServicio"].Text));
            //luego hacemos el fill
            pltComtratoxEquipoTableAdapter1.FillByContrato(dsPlantillasEquipoOtroSi.pltComtratoxEquipo, otroSi, numeroContrato);
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmNuevaOrdenPrestamo : Form
    {
        public frmNuevaOrdenPrestamo()
        {
            InitializeComponent();
        }

        int codOrdenPrestamo = 0;
        int codOrdenServicio = 0;
        //---
        public int CodOrdenPrestamo { set { codOrdenPrestamo = value; } get { return codOrdenPrestamo; } }
        public int CodOrdenServicio { set { codOrdenServicio = value; } get { return codOrdenServicio; } }

        bool solop = false;
        bool solopxotro = false;
        bool autop = false;
        bool acepop = false;
        bool recibop = false;
        bool anuop = false;
        bool listaop = false;

        /// <summary>
        /// Carga los permisos del usuario logeado
        /// </summary>
        private void cargarPermisos()
        {
            solop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1079);
            solopxotro = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1080);
            autop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1017);
            acepop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1002);
            recibop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1104);
            anuop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1010);
            listaop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1083);
        }

        /// <summary>
        /// Carga las tablas para llenar los ComboBox
        /// </summary>
        private void cargarTablas() 
        {
            clsTusuario1.Fill(dsSPXSeguridad1.usuario); 
            clsTusuario1.Fill(dsSPXSeguridad2.usuario);
            estadosOrdenPrestamoTableAdapter1.Fill(dsSpx1.estadosOrdenPrestamo);
            estadosOrdenServicioTableAdapter1.Fill(dsSpx1.estadosOrdenServicio);
        }

        /// <summary>
        /// Carga la informacion que esta en la base de datos, en los controles
        /// </summary>
        private void cargarControles()
        {
            dsSpx1.EnforceConstraints = false;
            ordenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codOrdenPrestamo);
            if (dsSpx1.OrdenPrestamo.Count > 0)
            {
                cmbPais.SelectedValue= dsSpx1.OrdenPrestamo[0].codPais;
                
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento,cmbPais.SelectedValue.ToString());
                cmbDepartamento.SelectedValue = dsSpx1.OrdenPrestamo[0].codDepartamento;
                
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades,cmbPais.SelectedValue.ToString(),
                    cmbDepartamento.SelectedValue.ToString());
                cmbCiudad.SelectedValue= dsSpx1.OrdenPrestamo[0].codCiudad;
             
                cmbEstadoOrdenPrestamo.SelectedValue = dsSpx1.OrdenPrestamo[0].codEstadoOrdenPrestamo;
                txtNumeroOrdenPrestamo.Text = dsSpx1.OrdenPrestamo[0].codOrdenPrestamo.ToString();
                if (!dsSpx1.OrdenPrestamo[0].IscodOrdenServicioNull())
                {
                    txtNumeroOdenServicio.Text = dsSpx1.OrdenPrestamo[0].codOrdenServicio.ToString();
                    ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, dsSpx1.OrdenPrestamo[0].codOrdenServicio);
                    cmbEstadoOrdenServicio.SelectedValue = dsSpx1.ordenServicio[0].codEstadoOrdenServicio;
                }else {
                    txtNumeroOdenServicio.Visible = false;
                    cmbEstadoOrdenServicio.Visible = false;
                    lblNumeroOrdenServicio.Visible = false;
                    lblEstadoOs.Visible = false;
                }
                
                if(!dsSpx1.OrdenPrestamo[0].IsfechaDevolucionNull())calFechaRecibido.Value= dsSpx1.OrdenPrestamo[0].fechaDevolucion;
                if(!dsSpx1.OrdenPrestamo[0].IsfechaOrdenNull())calFechaCreacion.Value= dsSpx1.OrdenPrestamo[0].fechaOrden;
               
             SPXSeguridad.data.dsSPXSeguridad ds=new SPXSeguridad.data.dsSPXSeguridad();
                if(!dsSpx1.OrdenPrestamo[0].IsloginAceptadoNull()){
                    clsTusuario1.FillBylogin(ds.usuario, dsSpx1.OrdenPrestamo[0].loginAceptado);
                    txtAceptadorPor.Text = ds.usuario[0].nombre ;
                }
                if(!dsSpx1.OrdenPrestamo[0].IsloginAnuloNull()){
                    clsTusuario1.FillBylogin(ds.usuario, dsSpx1.OrdenPrestamo[0].loginAnulo);
                    txtAnuladoPor.Text = ds.usuario[0].nombre; 
                }

                if (!dsSpx1.OrdenPrestamo[0].IsserialNull())
                {
                    txtSerial.Text = dsSpx1.OrdenPrestamo[0].serial;
                    cargarserial(txtSerial.Text);
                    txtObservacionesEquipo.Text = dsSpx1.OrdenPrestamo[0].obsSerial;
                }

                if(!dsSpx1.OrdenPrestamo[0].IsloginAutorizoNull())
                {
                    clsTusuario1.FillBylogin(ds.usuario, dsSpx1.OrdenPrestamo[0].loginAutorizo);
                    txtAutorizadoPor.Text = ds.usuario[0].nombre;
                }
                if(!dsSpx1.OrdenPrestamo[0].IsloginRecibidoNull()){
                    clsTusuario1.FillBylogin(ds.usuario, dsSpx1.OrdenPrestamo[0].loginRecibido);
                    txtRecibidosPor.Text = ds.usuario[0].nombre; 
                }
                if(!dsSpx1.OrdenPrestamo[0].IsloginResponsableNull()){
                    cmbResponsable.SelectedValue =dsSpx1.OrdenPrestamo[0].loginResponsable;
                }
                if (!dsSpx1.OrdenPrestamo[0].IsloginSolicitoNull())
                {
                    clsTusuario1.FillBylogin(ds.usuario, dsSpx1.OrdenPrestamo[0].loginSolicito);
                    txtElaboradoPor.Text = ds.usuario[0].nombre;
                }

                if (!dsSpx1.OrdenPrestamo[0].IsobsAprobacionNull()) txtObservacionesAprobacion.Text = dsSpx1.OrdenPrestamo[0].obsAprobacion;
                if (!dsSpx1.OrdenPrestamo[0].IsobsDevolucionNull()) txtObsDevolucion.Text = dsSpx1.OrdenPrestamo[0].obsDevolucion;
                if (!dsSpx1.OrdenPrestamo[0].IsobsEntregaNull()) txtObsEntrega.Text = dsSpx1.OrdenPrestamo[0].obsEntrega;
                if (!dsSpx1.OrdenPrestamo[0].IsobsInicialesNull()) txtObsIniciales.Text = dsSpx1.OrdenPrestamo[0].obsIniciales;

                if (!dsSpx1.OrdenPrestamo[0].IsnumeroFacturaNull()) txtNumeroFactura.Text = dsSpx1.OrdenPrestamo[0].numeroFactura;
                if (!dsSpx1.OrdenPrestamo[0].IsnumeroNotaSalidaNull()) txtNotaSalida.Text = dsSpx1.OrdenPrestamo[0].numeroNotaSalida;
            }
            pltRepuestoxOrdenPrestamoCompletaTableAdapter1.FillBycodOrdenPrestamo(dsPlantillas1.pltRepuestoxOrdenPrestamoCompleta, codOrdenPrestamo);
            observacionesxOrdenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.ObservacionesxOrdenPrestamo, codOrdenPrestamo);
            ajustarEstado();
        }

        private void frmNuevaOrdenPrestamo_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calFechaCreacion.MonthCalendar.DisplayMonth = n;
            calFechaRecibido.MonthCalendar.DisplayMonth = n;
            //llenamos las tablas
            #region zona de ciudades
            paisesTableAdapter1.Fill(dsSpx1.paises);
            defaultsTableAdapter1.Fill(dsSpx1.defaults);
            cmbPais.SelectedValue = dsSpx1.defaults[0].codPais;
#endregion
            //carga todos los que pueden solicitar orden de prestamo
            cargarTablas();
            cargarPermisos();
            cargarControles();
        }


        /// <summary>
        /// Esta funcion ajusta los controles dependiendo el estado en el cual esta la orden de prestamo
        /// </summary>
        /// <param name="estado">
        /// 1 Pendiente Por Autorzacion
        /// 2 autorizada (pendiente por entrega los repuestos)
        /// 3 rechazada
        /// 4 Repuestos Entregados al Ingeniero Parcial         
        /// 5 Repuestos entregados al Ingeniero
        /// 6 Repuestos Devueltos a Almacen Parcial
        /// 7 Repuestos Devueltos a Almacen
        /// 8 Anulada
        /// </param>
        private void ajustarEstado() 
        {
            int estado = 0;
            int.TryParse(cmbEstadoOrdenPrestamo.SelectedValue.ToString(), out estado);


            btnRecibir.Enabled = false;
            btnAprobar.Enabled = false;
            btnEditar.Enabled = false;
            btnRechazar.Enabled = false;
            btnEntregar.Enabled = false;
            btnAnular.Enabled = false;

            switch(estado)
            {
                case 1:
                {
                    if (solop && dsSpx1.OrdenPrestamo[0].loginSolicito.Trim() == SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim()
                        && dsSpx1.OrdenPrestamo[0].loginResponsable.Trim() == SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim())
                    {
                        btnEditar.Enabled = true;
                    }else if (solopxotro && dsSpx1.OrdenPrestamo[0].loginSolicito.Trim() == SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim())
                    {
                        btnEditar.Enabled = true;
                    }else if (solopxotro && dsSpx1.OrdenPrestamo[0].loginSolicito.Trim() == SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim())
                    {
                        btnEditar.Enabled = true;
                    }
                    if (autop)
                    {
                        btnAprobar.Enabled = true;
                        btnRechazar.Enabled = true;
                    }
                    break;
                }
            case 2:
                {//autorizada
                    if (autop)
                    {
                        btnEditar.Enabled = true;
                    }
                    if (acepop)
                    {
                        btnEntregar.Enabled = true;
                    }
                    break;
                }
            case 3:
                {  //rechazada
                    if (autop)
                    {
                        btnEditar.Enabled = true;
                    }
                    break;
                }
            case 4:/// 4 Repuestos Entregados al Ingeniero Parcial       
                {
                    if (acepop)
                    {
                        btnEditar.Enabled = true;
                        btnEntregar.Enabled = true;
                    }
                    break;
                }
            case 5:
                {   /// 5 Repuestos entregados al Ingeniero
                    /// como ya se entregaron todos los respuestos, ahora solo pueden devolverlos
                    if (recibop)
                    {
                        btnEditar.Enabled = true;
                        btnRecibir.Enabled = true;
                    }                                       
                    break;
                }

            case 6:
                { /// 6 Repuestos Devueltos a Almacen Parcial
                    if (recibop)
                    {
                        btnEditar.Enabled = true;
                        btnRecibir.Enabled = true;
                    }    
                    break;
                }
            case 7:
                {   /// 7 Repuestos Devueltos a Almacen
                    //aca ya se termino el procesos no puede hacer ninguna accion
                    break;
                }
            case 8:
                {  /// 8 Anulada
                    //como esta anulada no puede reactivarla
                    break;
                }
            
            }

            if (!anuop) btnAnular.Enabled = false;
            else btnAnular.Enabled = true;
            //si ya esta anulada no puede anularla de nuevo
            if (int.Parse( cmbEstadoOrdenPrestamo.SelectedValue.ToString()) == 8) btnAnular.Enabled = false;
            if (!autop) btnAprobar.Enabled = false;
            if (!acepop) btnEntregar.Enabled = false;
            if (!recibop) btnRecibir.Enabled = false;
        }


        #region zona de observaciones
        private void button3_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            //Agregar
            ordenPrestamo.frmObservacionesxOrdenPrestamo frmTmp = new frmObservacionesxOrdenPrestamo();
            if (frmTmp.ShowDialog() == DialogResult.OK)
            {
                int id=int.Parse(observacionesxOrdenPrestamoTableAdapter1.verNextId(codOrdenPrestamo).ToString());
                    observacionesxOrdenPrestamoTableAdapter1.Insert(codOrdenPrestamo, id, n,
                        SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, frmTmp.observacion);
                    observacionesxOrdenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.ObservacionesxOrdenPrestamo, codOrdenPrestamo);
            }
        }

        private void btnModificarObservaciones_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if (grdObservaciones.Columns["idObservacion"].Text.Trim() == string.Empty)
                return;

                if (grdObservaciones.Columns["loginAutor"].Text.Trim() == SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim())
                {
                    ordenPrestamo.frmObservacionesxOrdenPrestamo fr = new frmObservacionesxOrdenPrestamo();
                    fr.observacion = grdObservaciones.Columns["observacion"].Text;
                    if (fr.ShowDialog() == DialogResult.OK)
                    {
                        observacionesxOrdenPrestamoTableAdapter1.UpdateQuery(n, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                            fr.observacion, codOrdenPrestamo, int.Parse(grdObservaciones.Columns["idObservacion"].Text));
                        observacionesxOrdenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.ObservacionesxOrdenPrestamo, codOrdenPrestamo);
                    }

                }else{
                MessageBox.Show("Solo puede modificar sus propias observaciones");
                }        
            
        }

        private void btnEliminarObservaciones_Click(object sender, EventArgs e)
        {
            if (grdObservaciones.Columns["idObservacion"].Text.Trim() == string.Empty)
                return;
            if (grdObservaciones.Columns["loginAutor"].Text.Trim() != SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim())
            {
                MessageBox.Show("Solo puede eliminar sus propias observaciones");
                return;
            }
            if (MessageBox.Show("Esta seguro de eliminar esta observacion", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }

            
                observacionesxOrdenPrestamoTableAdapter1.DeleteQuery(codOrdenPrestamo, int.Parse(grdObservaciones.Columns["idObservacion"].Text));
                observacionesxOrdenPrestamoTableAdapter1.FillBycodOrdenPrestamo(dsSpx1.ObservacionesxOrdenPrestamo,codOrdenPrestamo);

        }
#endregion

        /// <summary>
        /// Imprime la orden de prestam es importante esta accion ya que este reporte tiene subreportes
        /// y debe configurarse su cadena de conexion
        /// </summary>
        /// <param name="codigoOrdenPrestamo"></param>
        public static void imprimirOrdenPrestamo(int codigoOrdenPrestamo) 
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter objOP = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            
            objDef.Fill(dsSpx1.defaults);
            dsSpx1.EnforceConstraints = false;
            objOP.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, codigoOrdenPrestamo);
            if (dsSpx1.OrdenPrestamo.Rows.Count <= 0)
            {
                MessageBox.Show("No existe una orden de prestamo en la base dedatos con el codigo que desea imprimir");
                return;
            }


            C1.C1Report.C1Report reporte = new C1.C1Report.C1Report();
            reporte.Load(ruta + @"\rpt\rpt.xml", "rptOrdenPrestamo");
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
            if (reporte.Fields.Contains("lblTitulo"))
            {
                reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloOrdenPrestamo.Trim();
            }
            if (reporte.Fields.Contains("lblVersion"))
            {
                reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionOrdenPrestamo.Trim();
            }
            if (reporte.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoOrdenPrestamoNull())
                    reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoOrdenPrestamo.Trim();
            }
            if (reporte.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaOrdenPrestamoNull())
                    reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaOrdenPrestamo.ToShortDateString();
            }
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codigo>>", codigoOrdenPrestamo.ToString());
            if(reporte.Fields.Contains("subRptObs")){
            reporte.Fields["subRptObs"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
            }
            if (!dsSpx1.OrdenPrestamo[0].IsanuladaNull() && dsSpx1.OrdenPrestamo[0].anulada)
            {
                if (reporte.Fields.Contains("lblAnulo"))
                {
                    reporte.Fields["lblAnulo"].Visible = true;
                }
                if (reporte.Fields.Contains("lblNombreAnulo"))
                {
                    reporte.Fields["lblNombreAnulo"].Visible = true;
                }
                if (reporte.Fields.Contains("lblAnulada"))
                {
                    reporte.Fields["lblAnulada"].Visible = true;
                }
            }

            var frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //validamos que la orden ya este aprobada
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            ordenPrestamoTableAdapter1.FillByCodOrdenServicio(ds.OrdenPrestamo, codOrdenPrestamo);

            int es=dsSpx1.OrdenPrestamo[0].codEstadoOrdenPrestamo;
            if (es <= 1)
            {
                MessageBox.Show("Solo puede imprimir la orden de prestamo despues de aprobada");
                return;
            }
            imprimirOrdenPrestamo(codOrdenPrestamo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int estado = 0;
            int.TryParse(cmbEstadoOrdenPrestamo.SelectedValue.ToString(), out estado);


            switch (estado)
            {
                case 1:
                    {///por aprobar
                        frmModificarSolicitada fr = new frmModificarSolicitada();
                        fr.codOrdenPrestamo = codOrdenPrestamo;
                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            cargarControles();
                        }
                        break;
                    }
                case 2:
                    {//autorizada
                        frmAprobar fr = new frmAprobar();
                        fr.codOrdenPrestamo = codOrdenPrestamo;
                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            cargarControles();
                        }
                        break;
                    }
                case 3:
                    {  //rechazada
                        frmAprobar fr = new frmAprobar();
                        fr.codOrdenPrestamo = codOrdenPrestamo;
                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            cargarControles();
                        }

                        break;
                    }
                case 4:/// 4 Repuestos Entregados al Ingeniero Parcial       
                    {
                        frmEntregarRepuestosIng fr = new frmEntregarRepuestosIng();
                        fr.codOrdenPrestamo = codOrdenPrestamo;
                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            cargarControles();
                        }
                        break;
                    }
                case 5:
                    {  //se entrego todo
                        frmEntregarRepuestosIng fr = new frmEntregarRepuestosIng();
                        fr.codOrdenPrestamo = codOrdenPrestamo;
                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            cargarControles();
                        }
                        break;
                    }

                case 6:
                    {   /// 6 Repuestos Devueltos a Almacen Parcial
                        frmRecibirRepuestosIng fr = new frmRecibirRepuestosIng();
                        fr.codOrdenPrestamo = codOrdenPrestamo;

                        if (fr.ShowDialog() == DialogResult.OK)
                        {
                            cargarControles();
                        }
                        break;
                    }
                case 7:
                    {   /// 7 Repuestos Devueltos a Almacen
                        MessageBox.Show("Una orden de Prestamo no se puede Modificar una ves Devueltos los repuestos a Almacen.");
                        break;
                    }
                case 8:
                    {  /// 8 Anulada

                        MessageBox.Show("Una orden Anulada no se puede Modificar");
                        break;
                    }

            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            frmAprobar fr = new frmAprobar();
            fr.codOrdenPrestamo = codOrdenPrestamo;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarControles();
                #region zona de notificacion
              //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
              //  mailsender.EjecutarAccion(302, cmbResponsable.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.OrdenPrestamo[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            frmRechazar fr = new frmRechazar();
            fr.codOrdenPrestamo = codOrdenPrestamo;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarControles();
                #region zona de notificacion
              //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
               // mailsender.EjecutarAccion(303, cmbResponsable.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.OrdenPrestamo[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            frmEntregarRepuestosIng fr = new frmEntregarRepuestosIng();
            fr.codOrdenPrestamo = codOrdenPrestamo;

            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarControles();
            }
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            frmRecibirRepuestosIng fr = new frmRecibirRepuestosIng();
            fr.codOrdenPrestamo = codOrdenPrestamo;

            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarControles();
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de anular esta orden de prestamo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                ordenPrestamoTableAdapter1.UpdateAnular(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, true, codOrdenPrestamo);
                ordenPrestamoTableAdapter1.UpdateEstado(8, codOrdenPrestamo);
                cargarControles();
                #region zona de notificacion
               // CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
               // mailsender.EjecutarAccion(308, cmbResponsable.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.OrdenPrestamo[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion
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
    }
}
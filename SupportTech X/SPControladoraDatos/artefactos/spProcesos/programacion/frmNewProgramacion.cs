using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.programacion
{
    public partial class frmNewProgramacion : Form
    {
        public frmNewProgramacion()
        {
            InitializeComponent();
        }

        private string codProgramaion = "";
        public string CodProgramacion { set { codProgramaion = value; } get { return codProgramaion; } }
        #region buscar equipos
        private void controlesProgramada() 
        {
          cmbIngeniero.Enabled=false;
btnSugerir.Enabled=false;
calSalida.Enabled=false;
cmbhoraVueloSalida.Enabled=false;
cmbMinutoSalida.Enabled=false;
cmbAmSalida.Enabled=false;
calRegreso.Enabled=false;
cmbhoraLLegada.Enabled=false;
cmbMinutoLlegada.Enabled=false;
cmbAmpLlegada.Enabled=false;


btnConfirmarTodos.Visible = false;
btnDesconfirmarTodos.Visible = false;
btnModificar.Visible = false;
btnAgregar.Visible = false;
btnAgregarTodos.Visible = false;
btnInfEquipo.Visible = false;
btnQuitarDetalle.Visible = false;
btnQuitarTodosDetalles.Visible = false;
btnGuardar.Visible = false;
btnProgramar.Visible = false;
cmbPaisDEstino.Enabled = false;
cmbDepartamentoDestino.Enabled = false;
cmbCiudadDestino.Enabled = false;
txtObservaciones.ReadOnly = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            System.Media.SystemSounds.Beep.Play();
        }

        private void buscar()
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" set dateformat dmy ");
            sb.Append(" declare @fechaInicio datetime ");
            sb.Append(" declare @fechaFin datetime ");
            #region primero miramos el filtro de fechas
            if (rdMes.Checked)
            {
                if (cmbMeses.SelectedIndex < 0) 
                {
                    MessageBox.Show("Seleccione Un Mes!!!");
                    return;
                }
                int diasEnMes = DateTime.DaysInMonth(n.Year, cmbMeses.SelectedIndex + 1);
                sb.Append(" set @fechaInicio ='" + 1 + "-" + (cmbMeses.SelectedIndex + 1) + "-" + n.Year + "' ");
                sb.Append(" set @fechaFin ='" + diasEnMes + "-" + (cmbMeses.SelectedIndex + 1) + "-" + n.Year + "' ");
            }

            else if (rdPeriodo.Checked)
            {
                if (calInicioPeriodo.ValueObject == null)
                {
                    MessageBox.Show("Si el filtro es de periodo debe ingresar la fecha de inicio.");
                }
                if (calFinPeriodo.ValueObject == null)
                {
                    MessageBox.Show("Si el filtro es de periodo debe ingresar la fecha de fin.");
                }
                sb.Append(" set @fechaInicio ='" + calInicioPeriodo.Value.Day + "-" + calInicioPeriodo.Value.Month + "-" + calInicioPeriodo.Value.Year + "' ");
                sb.Append(" set @fechaFin ='" + calFinPeriodo.Value.Day + "-" + calFinPeriodo.Value.Month + "-" + calFinPeriodo.Value.Year + "' ");
            }
            #endregion
            #region zona de campos de sentencia select
            sb.Append(" select");
            sb.Append(" equipos.serial,");
            sb.Append(" fabricante.nombre_fabricante");
            sb.Append(" ,modelos.nombreModelo,");
            sb.Append(" tipoEquipo.nombretipoEquipo,subTipoEquipo.nombreSubTipo,");
            sb.Append(" clientes.nitcliente,clientes.Nombrecliente,sucursalCliente.nombreSucursal");
            sb.Append(" ,nombrepais,nombredepartamento,nombreCiudad");
            sb.Append(" ,ModalidadEquipo.nombreModalidadEquipo,");
            sb.Append(" equipos.FechaUltimoMante,equipos.fechaProximoMante,");
            sb.Append(" equipos.fechaLlegada,equipos.FechaSalida,");
            sb.Append(" equipos.FechaProximaProgramacion,equipos.ObservacionesUltimoMante");
            sb.Append(" from equipos");
            #endregion
            #region zona de joins
            sb.Append(" join fabricante on fabricante.codFabricante = equipos.codFabricante");
            sb.Append(" join Modelos on Modelos.codFabricante = equipos.codFabricante and Modelos.codModelo = equipos.codModelo");
            sb.Append(" join tipoEquipo on tipoEquipo.codTipoEquipo = modelos.codTipoEquipo");
            sb.Append(" join subTipoEquipo on subTipoEquipo.codTipoEquipo = modelos.codTipoEquipo and subTipoEquipo.codSubTipoEquipo = modelos.codSubTipoEquipo");
            sb.Append(" left join ModalidadEquipo on equipos.codModalidadEquipo = ModalidadEquipo.codModalidadEquipo");
            sb.Append(" join clientes on clientes.nitcliente = equipos.nitclienteubica");
            sb.Append(" join sucursalcliente on sucursalCliente.codSucursal = equipos.codSucursalUbica and sucursalCliente.nitCliente = equipos.nitclienteubica");
            sb.Append(" left join paises on paises.codPais = sucursalcliente.codPais");
            sb.Append(" left join departamentos departamento on departamento.codPais = sucursalcliente.codPais and departamento.coddepartamento = sucursalcliente.coddepartamento");
            sb.Append(" left join ciudades on ciudades.codPais = sucursalcliente.codPais and ciudades.coddepartamento = sucursalcliente.coddepartamento and ciudades.codciudad = sucursalcliente.codciudad");
            #endregion

             sb.Append(" WHERE  ");

            //Con filtro de sin programacion
            if (rdMostrarSinProgramacion.Checked)
            {
                sb.Append(" fechaProximaProgramacion is null ");
            }
            else {
                sb.Append(" equipos.fechaProximoMante between @fechaInicio and @fechaFin ");
            }
            #region ahora el filtro de localizacion
            if (rdCiudad.Checked)
            {
                if (cmbPais.SelectedValue == null || cmbPais.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Seleccione Un pais.");
                    return;
                }
                if (cmbDepartamentos.SelectedValue == null || cmbDepartamentos.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Seleccione Un Departamento.");
                    return;
                }
                if (cmbCiudad.SelectedValue == null || cmbCiudad.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Seleccione Una Ciudad.");
                    return;
                }
                sb.Append(" and paises.codPais= '" + cmbPais.SelectedValue.ToString().Trim() + "' and departamento.codDepartamento = '" + cmbDepartamentos.SelectedValue.ToString().Trim() + "' and ciudades.codCiudad ='" + cmbCiudad.SelectedValue.ToString().Trim() + "' ");
            }
            else if (rdDepartamento.Checked)
            {
                if (cmbPais.SelectedValue == null || cmbPais.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Seleccione Un pais.");
                    return;
                }
                if (cmbDepartamentos.SelectedValue == null || cmbDepartamentos.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Seleccione Un Departamento.");
                    return;
                }
                sb.Append(" and paises.codPais= '" + cmbPais.SelectedValue.ToString().Trim() + "' and departamento.codDepartamento = '" + cmbDepartamentos.SelectedValue.ToString().Trim() + "' ");
            }
            else if (rdPais.Checked)
            {
                if (cmbPais.SelectedValue == null || cmbPais.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Seleccione Un pais.");
                    return;
                }
                sb.Append(" and paises.codPais= '" + cmbPais.SelectedValue.ToString().Trim() + "' ");
            }
#endregion

            SPXdata.BD.DataConector objdata = new SPXdata.BD.DataConector();
            dsPlantillas1.pltEquiposProgramacionViajes.Clear();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltEquiposProgramacionViajes.Merge(objdata.ejecutarConsulta(sb.ToString()).Tables[0]);
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
            cmbDepartamentos.SelectedValue = dsSpx1.defaults[0].codDepartamento;
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(), cmbDepartamentos.SelectedValue.ToString());
            cmbCiudad.SelectedValue = dsSpx1.defaults[0].codCiudad;
        }

        #endregion
        #region mix grilla izq

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns[0].Text.Trim() == string.Empty) return;
            //--//--
            spProcesos.Equipos.frmInformacionEquipo objFrm = new spProcesos.Equipos.frmInformacionEquipo();
            objFrm.Serial = grdEquipos.Columns[0].Text;
            objFrm.ShowDialog();
        }
        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\lstProgramacionALayt.xs";
            grdEquipos.SaveLayout(str);
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\lstProgramacionALayt.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Debe cargar de nuevo el formulario para visulizar los cambios!!");
        }

        #endregion
        #region mis grilla derecha

        private void buttonX3_Click(object sender, EventArgs e)
        {//esto es para ver la informacion resumida del equipo
            if (grdDetalleProgramacion.Columns["serial"].Text.Trim() == string.Empty) return;
            //--//--
            spProcesos.Equipos.frmInformacionEquipo objFrm = new spProcesos.Equipos.frmInformacionEquipo();
            objFrm.Serial = grdDetalleProgramacion.Columns["serial"].Text;
            objFrm.ShowDialog();
        }

        private void btnVerOrdenServicio_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text.Trim() == "Pendiente") return;
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo frmTmp = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            frmTmp.CodOrdenServicio = grdDetalleProgramacion.Columns["codOrdenServicio"].Text;
            frmTmp.Show();
        }

        private void btnGuardarListaProgramacion_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\lstProgramacionBLayt.xs";
            grdDetalleProgramacion.SaveLayout(str);
        }

        private void btnRestaurarListaProgramacion_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\lstProgramacionBLayt.xs";
            MessageBox.Show("Debe cargar de nuevo el formulario para visulizar los cambios!!");
        }

        private void btnExportarExcelProgramacion_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objF= new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objF.exportar(grdDetalleProgramacion, "Listado de Programacion.", false);
        }

        #endregion
        #region combos de ciudad y misc globales 
        private void btnSugerir_Click(object sender, EventArgs e)
        {
            //Primero miramos que ingenieros tienen el pais
            SPControladoraDatos.dsSpxTableAdapters.regionesXusuariosTableAdapter objReg = new SPControladoraDatos.dsSpxTableAdapters.regionesXusuariosTableAdapter();
            objReg.FillByCiudad(dsSpx1.regionesXusuarios, cmbPaisDEstino.SelectedValue.ToString(), (cmbDepartamentoDestino.SelectedValue==null)?"":cmbDepartamentoDestino.SelectedValue.ToString(), (cmbCiudadDestino.SelectedValue == null) ? "" : cmbCiudadDestino.SelectedValue.ToString());
            if (dsSpx1.regionesXusuarios.Rows.Count > 0)
            {
                cmbIngeniero.SelectedValue = dsSpx1.regionesXusuarios[0].login;
                System.Media.SystemSounds.Beep.Play();
            }else{
                objReg.FillByDepartamento(dsSpx1.regionesXusuarios,cmbPaisDEstino.SelectedValue.ToString(),cmbDepartamentoDestino.SelectedValue.ToString());
                if (dsSpx1.regionesXusuarios.Rows.Count > 0)
                {
                    cmbIngeniero.SelectedValue = dsSpx1.regionesXusuarios[0].login;
                    System.Media.SystemSounds.Beep.Play();
                    
                }else { 
                        MessageBox.Show("No hay Ingeniero asignado para esta ciudad o departamento");
                }
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (codProgramaion.Trim() == string.Empty) return;
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
            objDef.Fill(dsSpx1.defaults);
            string strReporte = "rptProgramacionViajes"; 
            
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
            if (reporte.Fields.Contains("lblTitulo"))
            {
                reporte.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloViajes.Trim();
            }
            if (reporte.Fields.Contains("lblVersion"))
            {
                reporte.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionViajes.Trim();
           }
            if (reporte.Fields.Contains("lblTipoDocumento"))
            {
                if (!dsSpx1.defaults[0].IscodigoViajesNull())
                    reporte.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoViajes.Trim();
            }
            if (reporte.Fields.Contains("lblVigencia"))
            {
                if (!dsSpx1.defaults[0].IsfechaVigenciaViajesNull())
                    reporte.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaViajes.ToShortDateString();
            }
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            reporte.DataSource.ConnectionString = objData.CadenaConexionReportes;
            reporte.DataSource.RecordSource = reporte.DataSource.RecordSource.Replace("<<codPro>>", codProgramaion);

            var  frmRpt = new SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmReporte (reporte);
            frmRpt.Icon = this.Icon;
            frmRpt.ShowDialog();
        }       
        private void btnLimpiarDepartamento_Click(object sender, EventArgs e)
        {
            cmbCiudadDestino.SelectedValue = "";
            cmbDepartamentoDestino.SelectedValue = "";
        }
        private void btnLimpiarCiudad_Click(object sender, EventArgs e)
        {
            cmbCiudadDestino.SelectedValue = "";
        }
        private void cmbPaisDEstino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaisDEstino.SelectedValue != null && cmbPaisDEstino.SelectedValue.ToString() != string.Empty){
            departamentoTableAdapter1.FillByCodigoPais(dsSpx2.departamento, cmbPaisDEstino.SelectedValue.ToString());
            cmbDepartamentoDestino.SelectedValue = dsSpx1.defaults[0].codDepartamento;
            }
        }
        private void cmbDepartamentoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartamentoDestino.SelectedValue != null && cmbDepartamentoDestino.SelectedValue.ToString() != string.Empty)
            {
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx2.ciudades, cmbPaisDEstino.SelectedValue.ToString(), cmbDepartamentoDestino.SelectedValue.ToString());
                cmbCiudadDestino.SelectedValue = dsSpx1.defaults[0].codCiudad;
            }
            else {
                cmbCiudadDestino.SelectedValue = "";
            
            }
        }
        #endregion
        #region misc generales
        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }       

        private void btnDesconfirmarTodos_Click(object sender, EventArgs e)
        {
            ConfirmarDesconfirmar(false);
        }

        private void btnConfirmarTodos_Click_1(object sender, EventArgs e)
        {
            ConfirmarDesconfirmar(true);

        }

        private void ConfirmarDesconfirmar(bool valor) 
        {
            for (int k = 0; k < dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count; k++)
            {
                dsPlantillas1.pltDetalleProgramacionViajes[k].confirmado = valor;
            }
        }
        #endregion

        private void btnAgregarTodos_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns[0].Text.Trim() == string.Empty) return;
            frmDetallesProgramacion fr = new frmDetallesProgramacion();
            if (fr.ShowDialog() != DialogResult.OK) return;
            int codProg = 0;
            if (codProgramaion.Trim() != string.Empty)
                codProg = int.Parse(codProgramaion);

            for (int k = 0; k<dsPlantillas1.pltEquiposProgramacionViajes.Rows.Count; k++)
            {
                string serial = dsPlantillas1.pltEquiposProgramacionViajes[k].serial;
                if (dsPlantillas1.pltDetalleProgramacionViajes.Select("serial = '" + serial + "'").Length > 0)
                    continue;
                //esto es para no incluir dos veces el mismo equipo en la programacion
                SPControladoraDatos.dsPlantillas.pltDetalleProgramacionViajesRow fila =
                dsPlantillas1.pltDetalleProgramacionViajes.NewpltDetalleProgramacionViajesRow();
                fila.serial = serial;
                fila.fechaInicio = fr.horaInico;
                fila.fechaFin = fr.horaFin;
                fila.codTipoServicio = fr.tipoServicio;
                fila.codDetalleProgramacionViajes = dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count + 1;
                fila.codOrdenServicio = 0;
                fila.codProgramacionViajes = codProg;
                fila.confirmado = fr.confirmado;
                fila.codprioridadOS = int.Parse(fr.prioridad);
                fila.observaciones = fr.Descripcion;
                fila.nombretipoServicio = fr.nombretipoServicio;
                fila.prioridad = fr.nombreprioridad;
                fila.nitCliente = dsPlantillas1.pltEquiposProgramacionViajes[k].nitcliente;
                fila.nombreCliente = dsPlantillas1.pltEquiposProgramacionViajes[k].Nombrecliente;
                fila.nombreCiudad = dsPlantillas1.pltEquiposProgramacionViajes[k].nombreCiudad;
                fila.NombreModelo = dsPlantillas1.pltEquiposProgramacionViajes[k].nombreModelo;
                dsPlantillas1.pltDetalleProgramacionViajes.AddpltDetalleProgramacionViajesRow(fila);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //primero verificamos que tenga seleccionado un serial
            if (grdEquipos.Columns[0].Text.Trim() == string.Empty) return;
            string serial = grdEquipos.Columns[0].Text.Trim();
            //ahroa verificamos que el serial no este en la otra grila
            if (dsPlantillas1.pltDetalleProgramacionViajes.Select("serial = '" + serial + "'").Length > 0)
            {
                if (MessageBox.Show("El equipo con serial " + serial + " ya esta incluido en la programacion.\nDesea Agregarlo de Nuevo", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                   != DialogResult.Yes)
                {
                    return;
                }
            }

            frmDetallesProgramacion fr = new frmDetallesProgramacion();
            int codProg = 0;
            if (codProgramaion.Trim() != string.Empty)
                codProg = int.Parse(codProgramaion);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                SPControladoraDatos.dsPlantillas.pltDetalleProgramacionViajesRow fila =
                dsPlantillas1.pltDetalleProgramacionViajes.NewpltDetalleProgramacionViajesRow();
                fila.serial = grdEquipos.Columns[0].Text;
                fila.codDetalleProgramacionViajes = dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count + 1;
                fila.fechaInicio = fr.horaInico;
                fila.fechaFin = fr.horaFin;
                fila.codTipoServicio = fr.tipoServicio;
                fila.nombretipoServicio = fr.nombretipoServicio; 
                fila.codOrdenServicio = 0;
                fila.codProgramacionViajes = codProg;
                fila.confirmado = fr.confirmado;
                fila.observaciones = fr.Descripcion;
                fila.codprioridadOS = int.Parse(fr.prioridad);
                fila.prioridad = fr.nombreprioridad;
                fila.nombreCliente = grdEquipos.Columns["Nombrecliente"].Text;
                fila.NombreModelo = grdEquipos.Columns["nombremodelo"].Text;
                fila.nitCliente = grdEquipos.Columns["nitcliente"].Text;
                fila.nombreCiudad = grdEquipos.Columns["nombreciudad"].Text;
                dsPlantillas1.pltDetalleProgramacionViajes.AddpltDetalleProgramacionViajesRow(fila);
            }
        }        
        private void btnQuitarTodosDetalles_Click(object sender, EventArgs e)
        {
            dsPlantillas1.pltDetalleProgramacionViajes.Clear();
        }   
        private void btnQuitarDetalle_Click(object sender, EventArgs e)
        {
            if (grdDetalleProgramacion.Columns["serial"].Text.Trim() == string.Empty) return;
            string s=grdDetalleProgramacion.Columns["serial"].Text;
            int fila = grdDetalleProgramacion.RowBookmark(grdDetalleProgramacion.Row);
            dsPlantillas1.pltDetalleProgramacionViajes.Rows.Remove(
                dsPlantillas1.pltDetalleProgramacionViajes.Select("serial='"+s+"'")[0]);
        }     


        private void frmNewProgramacion_Load(object sender, EventArgs e)
        {
            dsSpx1.EnforceConstraints = false;
            #region cargamos la informacion guardadas de la configuracion de cada grilla
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\lstProgramacionALayt.xs";
            if (System.IO.File.Exists(str))
            {
                grdEquipos.LoadLayout(str);
            }
            str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\lstProgramacionBLayt.xs";
            if (System.IO.File.Exists(str))
            {
                grdDetalleProgramacion.LoadLayout(str);
            }
            
            #endregion

            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            //
            asesoresComercialesTableAdapter1.Fill(dsSpx1.asesoresComerciales);
            prioridadesOrdenServicioTableAdapter1.Fill(dsSpx1.prioridadesOrdenServicio);
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            cmbMeses.SelectedIndex = n.Month - 1;
            paisesTableAdapter1.Fill(dsSpx1.paises);
            defaultsTableAdapter1.Fill(dsSpx1.defaults);
            cmbPais.SelectedValue = dsSpx1.defaults[0].codPais;

            paisesTableAdapter1.Fill(dsSpx2.paises);
            cmbPaisDEstino.SelectedValue = dsSpx1.defaults[0].codPais;
            //
            calInicioPeriodo.Value = new DateTime(n.Year, n.Month, 1);
            calFinPeriodo.Value = n;


            calSalida.MonthCalendar.DisplayMonth = n;
            calRegreso.MonthCalendar.DisplayMonth = n;

            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1063);
            
            cmbIngeniero.SelectedValue = "";
            //miramos si esta cargando una programacion que ya esta creada en el disco duro
            if (codProgramaion.Trim() != string.Empty)
            {
                txtCodigo.Text = codProgramaion;
                programacionViajesTableAdapter1.FillBycodProgramacionViajes(dsSpx1.programacionViajes, int.Parse(codProgramaion));
                if (dsSpx1.programacionViajes[0].programada)
                {
                    txtEstado.Text = "Programada";
                    controlesProgramada();
                }
                if (!dsSpx1.programacionViajes[0].IsingenieroAsignadoNull())
                cmbIngeniero.SelectedValue = dsSpx1.programacionViajes[0].ingenieroAsignado;
                calSalida.Value = dsSpx1.programacionViajes[0].fechaViaje;
                calRegreso.Value = dsSpx1.programacionViajes[0].fechaRegreso;
                if (dsSpx1.programacionViajes[0].IscodPaisNull())
                {
                    cmbPaisDEstino.SelectedValue = "";
                }else {
                    cmbPaisDEstino.SelectedValue = dsSpx1.programacionViajes[0].codPais;
                }
                Application.DoEvents();
                if (dsSpx1.programacionViajes[0].IscodDepartamentoNull())
                {
                    cmbDepartamentoDestino.SelectedValue = "";
                }
                else
                {
                    cmbDepartamentoDestino.SelectedValue = dsSpx1.programacionViajes[0].codDepartamento;
                }
                Application.DoEvents();
                if (dsSpx1.programacionViajes[0].IscodCiudadNull())
                {
                    cmbCiudadDestino.SelectedValue = "";
                }
                else
                {
                    cmbCiudadDestino.SelectedValue = dsSpx1.programacionViajes[0].codCiudad;
                }
                //asesor comercial
                if (dsSpx1.programacionViajes[0].IscodAsesorNull())
                {
                    cmbAsesorComercial.SelectedValue = 0;
                }
                else
                {
                    cmbAsesorComercial.SelectedValue = dsSpx1.programacionViajes[0].codAsesor;
                }

                if (!dsSpx1.programacionViajes[0].IsobservacionesNull())
                txtObservaciones.Text = dsSpx1.programacionViajes[0].observaciones;
                Application.DoEvents();
                #region cargamos las horas primero salida
                int hora = 0;
                hora = calRegreso.Value.Hour;
                hora %= 12;
                if (hora == 0) hora = 12;

                cmbhoraLLegada.Text = hora.ToString();
                cmbMinutoLlegada.Text = calRegreso.Value.Minute.ToString().PadLeft(2, '0');
                cmbAmpLlegada.Text = "AM";
                if (calRegreso.Value.Hour > 11)
                {
                    cmbAmpLlegada.Text = "PM";
                }
                //
                hora = 0; 
                hora = calSalida.Value.Hour;
                hora %= 12;
                if (hora == 0) hora = 12;

                cmbhoraVueloSalida.Text = hora.ToString();
                cmbMinutoSalida.Text = calSalida.Value.Minute.ToString().PadLeft(2, '0');
                cmbAmSalida.Text = "AM";
                if (calSalida.Value.Hour > 11)
                {
                    cmbAmSalida.Text = "PM";
                }
                #endregion
                //cargamos el detalle
                pltDetalleProgramacionViajesTableAdapter1.FillBycodProgramacionViajes(dsPlantillas1.pltDetalleProgramacionViajes, int.Parse(codProgramaion));
            }
            else {
                txtCodigo.Text = programacionViajesTableAdapter1.verNextId().Value.ToString();
            }

        }
        
        private bool validarProgramar()
        {
            if (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El Ingeniero es Obligatorio");
                cmbIngeniero.Focus();
                return false;
            }

            if (calSalida.ValueObject == null || calRegreso.ValueObject == null)
            {
                MessageBox.Show("Las fechas son Obligatorias");
                calRegreso.Focus();
                return false;
            }

            if (cmbhoraVueloSalida.Text.Trim() == string.Empty || cmbhoraLLegada.Text.Trim() == string.Empty ||
                cmbMinutoSalida.Text.Trim() == string.Empty || cmbMinutoLlegada.Text.Trim() == string.Empty ||
                    cmbAmSalida.Text.Trim() == string.Empty || cmbAmpLlegada.Text.Trim() == string.Empty
                )
            {
                MessageBox.Show("Las Horas de Salida y de Llegada son obligatorias");
                return false;
            }
            if (calRegreso.Value < calSalida.Value)
            {
                MessageBox.Show("las fecha de fin del viaje no puede ser menor que la fecha de salida");
                return false;
            }
            if (dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count <= 0)
            {
                MessageBox.Show("Debe Incluir por lo menos un equipo para crear la programacion");
                return false;
            }
            return true;
        }

        private bool validarGuardar() 
        {


            if (calSalida.ValueObject == null || calRegreso.ValueObject == null)
            {
                MessageBox.Show("Las fechas son Obligatorias");
                calRegreso.Focus();
                return false;
            }

            return true;
        }
           
        //se encarga de validar que todas las fechas de los mantenimientos esten detro de las fechas del viaje
        private bool validarFechas()
        {
            DateTime fechaSalida, fechaLlegada;
            #region cargamos las fechas de llegada y de salida
            
            fechaSalida = calSalida.Value;
            fechaSalida = fechaSalida.AddHours(fechaSalida.Hour*-1);
            fechaSalida = fechaSalida.AddMinutes(fechaSalida.Minute * -1);

            int hora = 0; int minuto = 0;
            int.TryParse(cmbhoraVueloSalida.Text, out hora);
            hora = hora % 12;
            if (cmbAmSalida.Text.Trim().ToUpper() == "PM")
                hora += 12;
            int.TryParse(cmbMinutoSalida.Text, out minuto);
            fechaSalida = fechaSalida.AddHours(hora);
            fechaSalida = fechaSalida.AddMinutes(minuto);
            //ahora la fecha de llegada
            fechaLlegada = calRegreso.Value;
            fechaLlegada = fechaLlegada.AddHours(fechaLlegada.Hour * -1);
            fechaLlegada = fechaLlegada.AddMinutes(fechaLlegada.Minute * -1);

            hora = 0; minuto = 0;
            int.TryParse(cmbhoraLLegada.Text, out hora);
            hora = hora % 12;
            if (cmbAmpLlegada.Text.Trim().ToUpper() == "PM")
                hora += 12;
            int.TryParse(cmbMinutoLlegada.Text, out minuto);
            fechaLlegada = fechaLlegada.AddHours(hora);
            fechaLlegada = fechaLlegada.AddMinutes(minuto);
            #endregion
            //
            for (int k = 0; k < dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count; k++)
            {
                if (dsPlantillas1.pltDetalleProgramacionViajes[k].fechaInicio < fechaSalida || dsPlantillas1.pltDetalleProgramacionViajes[k].fechaFin > fechaLlegada)
                {
                    MessageBox.Show("hay programadas tareas fuera de las fechas de viaje","Fechas Invalidas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            //codDetalleProgramacionViajes
            if (grdDetalleProgramacion.Columns["serial"].Text.Trim() == string.Empty) return;
            int fila = buscarSerial(grdDetalleProgramacion.Columns["serial"].Text, int.Parse(grdDetalleProgramacion.Columns["codDetalleProgramacionViajes"].Text));
            //tomamos la informacion del detalle
            frmDetallesProgramacion objFrm = new frmDetallesProgramacion();
            objFrm.tipoServicio = dsPlantillas1.pltDetalleProgramacionViajes[fila].codTipoServicio;
            objFrm.horaInico    = dsPlantillas1.pltDetalleProgramacionViajes[fila].fechaInicio;
            objFrm.horaFin      = dsPlantillas1.pltDetalleProgramacionViajes[fila].fechaFin;
            objFrm.confirmado   = dsPlantillas1.pltDetalleProgramacionViajes[fila].confirmado;
            objFrm.prioridad    = dsPlantillas1.pltDetalleProgramacionViajes[fila].codprioridadOS.ToString();
            objFrm.Descripcion  = dsPlantillas1.pltDetalleProgramacionViajes[fila].observaciones;
            
            if (objFrm.ShowDialog() == DialogResult.OK)
            { 
                dsPlantillas1.pltDetalleProgramacionViajes[fila].codTipoServicio = objFrm.tipoServicio;
                dsPlantillas1.pltDetalleProgramacionViajes[fila].nombretipoServicio = objFrm.nombretipoServicio;
                dsPlantillas1.pltDetalleProgramacionViajes[fila].fechaInicio = objFrm.horaInico;
                dsPlantillas1.pltDetalleProgramacionViajes[fila].fechaFin = objFrm.horaFin;
                dsPlantillas1.pltDetalleProgramacionViajes[fila].confirmado = objFrm.confirmado;
                dsPlantillas1.pltDetalleProgramacionViajes[fila].codprioridadOS = int.Parse(objFrm.prioridad);
                dsPlantillas1.pltDetalleProgramacionViajes[fila].prioridad = objFrm.nombreprioridad;
                dsPlantillas1.pltDetalleProgramacionViajes[fila].observaciones = objFrm.Descripcion;
            }
        }

        /// <summary>
        /// Busca un serial en la lista de equipos agregados y retorna la posicion en el dataset
        /// </summary>
        /// <param name="serial"></param>
        /// <returns></returns>
        private int buscarSerial(string serial, int codDetalleProgramacionViajes) 
        {
            for (int k = 0; k < dsPlantillas1.pltDetalleProgramacionViajes.Count; k++)
            {
                if (dsPlantillas1.pltDetalleProgramacionViajes[k].serial.Trim().ToUpper() == serial.Trim().ToUpper() &&
                    dsPlantillas1.pltDetalleProgramacionViajes[k].codDetalleProgramacionViajes == codDetalleProgramacionViajes)
                {
                    return k;
                }
            }
                return 0;
        }

        private bool guardar() 
        {
             if (!validarGuardar()) return false;
            if (!validarFechas()) return false;
            DateTime fechaSalida, fechaLlegada;
            #region cargamos las fechas de llegada y de salida

            fechaSalida = calSalida.Value;
            fechaSalida = fechaSalida.AddHours(fechaSalida.Hour * -1);
            fechaSalida = fechaSalida.AddMinutes(fechaSalida.Minute * -1);

            int hora = 0; int minuto = 0;
            int.TryParse(cmbhoraVueloSalida.Text, out hora);
            hora = hora % 12;
            if (cmbAmSalida.Text.Trim().ToUpper() == "PM")
                hora += 12;
            int.TryParse(cmbMinutoSalida.Text, out minuto);
            fechaSalida = fechaSalida.AddHours(hora);
            fechaSalida = fechaSalida.AddMinutes(minuto);
            //ahora la fecha de llegada
            fechaLlegada = calRegreso.Value;
            fechaLlegada = fechaLlegada.AddHours(fechaLlegada.Hour * -1);
            fechaLlegada = fechaLlegada.AddMinutes(fechaLlegada.Minute * -1);

            hora = 0; minuto = 0;
            int.TryParse(cmbhoraLLegada.Text, out hora);
            hora = hora % 12;
            if (cmbAmpLlegada.Text.Trim().ToUpper() == "PM")
                hora += 12;
            int.TryParse(cmbMinutoLlegada.Text, out minuto);
            fechaLlegada = fechaLlegada.AddHours(hora);
            fechaLlegada = fechaLlegada.AddMinutes(minuto);
            #endregion
            Nullable<int> enteroNullo= new Nullable<int>();
            if (codProgramaion.Trim() == string.Empty)//si es nueva
            {
                int codigo = programacionViajesTableAdapter1.verNextId().Value;
 
                //primero guardamos el encabezado
                string lg = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
                SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
                DateTime n = dc.fechaServer;
                programacionViajesTableAdapter1.Insert(codigo, n, lg,
                    fechaSalida, 
                    (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString()==string.Empty)?null:cmbIngeniero.SelectedValue.ToString()
                    , fechaLlegada, false,                    
                    (cmbPaisDEstino.SelectedValue==null || cmbPaisDEstino.SelectedValue.ToString() == string.Empty)?null:cmbPaisDEstino.SelectedValue.ToString() ,
                    (cmbDepartamentoDestino.SelectedValue == null || cmbDepartamentoDestino.SelectedValue.ToString() == string.Empty) ? null : cmbDepartamentoDestino.SelectedValue.ToString(),
                    (cmbCiudadDestino.SelectedValue == null || cmbCiudadDestino.SelectedValue.ToString() == string.Empty) ? null : cmbCiudadDestino.SelectedValue.ToString(),
                    txtObservaciones.Text,
                      (cmbAsesorComercial.SelectedValue == null || cmbAsesorComercial.SelectedValue.ToString() == string.Empty) ? enteroNullo : int.Parse(cmbAsesorComercial.SelectedValue.ToString()));
                
                //ahora vamos con el detalle
                for (int k = 0; k < dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count; k++)
                { 
                    detalleProgramacionViajesTableAdapter1.Insert(codigo,k+1,enteroNullo,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].confirmado, dsPlantillas1.pltDetalleProgramacionViajes[k].serial,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].fechaInicio, dsPlantillas1.pltDetalleProgramacionViajes[k].fechaFin,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].codTipoServicio, dsPlantillas1.pltDetalleProgramacionViajes[k].codprioridadOS,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].observaciones);
                }
                codProgramaion = codigo.ToString();
            }
            else { //si es antigua
                //actualizamos el encabezado
                programacionViajesTableAdapter1.UpdateQuery(fechaSalida, fechaLlegada,
                    (cmbIngeniero.SelectedValue == null || cmbIngeniero.SelectedValue.ToString() == string.Empty) ? null : cmbIngeniero.SelectedValue.ToString(),
                    (cmbPaisDEstino.SelectedValue==null || cmbPaisDEstino.SelectedValue.ToString() == string.Empty)?null:cmbPaisDEstino.SelectedValue.ToString() ,
                    (cmbDepartamentoDestino.SelectedValue == null || cmbDepartamentoDestino.SelectedValue.ToString() == string.Empty) ? null : cmbDepartamentoDestino.SelectedValue.ToString(),
                    (cmbCiudadDestino.SelectedValue == null || cmbCiudadDestino.SelectedValue.ToString() == string.Empty) ? null : cmbCiudadDestino.SelectedValue.ToString(),
                    txtObservaciones.Text,
                     (cmbAsesorComercial.SelectedValue == null || cmbAsesorComercial.SelectedValue.ToString() == string.Empty) ? enteroNullo : int.Parse(cmbAsesorComercial.SelectedValue.ToString())
                     ,int.Parse(codProgramaion));
                
                //actualizamos el detalle
                //ahora vamos con el detalle
                detalleProgramacionViajesTableAdapter1.DeleteCodProgramacionViajes(int.Parse(codProgramaion));
                for (int k = 0; k < dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count; k++)
                {
                    detalleProgramacionViajesTableAdapter1.Insert(int.Parse(codProgramaion), k + 1,
                        (dsPlantillas1.pltDetalleProgramacionViajes[k].IscodOrdenServicioNull() || dsPlantillas1.pltDetalleProgramacionViajes[k].codOrdenServicio == 0) ? enteroNullo : dsPlantillas1.pltDetalleProgramacionViajes[k].codOrdenServicio,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].confirmado, dsPlantillas1.pltDetalleProgramacionViajes[k].serial,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].fechaInicio, dsPlantillas1.pltDetalleProgramacionViajes[k].fechaFin,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].codTipoServicio, dsPlantillas1.pltDetalleProgramacionViajes[k].codprioridadOS,
                        dsPlantillas1.pltDetalleProgramacionViajes[k].observaciones);
                }
            }
            System.Media.SystemSounds.Exclamation.Play();
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
     
        private void btnProgramar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de programar las actividades para este viaje?\nUna vez programadas no se puede modificar la programacion!","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (!validarProgramar()) return;
            if(! guardar())return;
            txtEstado.Text = "Programada";
            controlesProgramada();
            //creamos ordenes de servicio para cada programacion
            spProcesos.ordenesTrabajo.cls.osController objC = new spProcesos.ordenesTrabajo.cls.osController();
            for (int k = 0; k < dsPlantillas1.pltDetalleProgramacionViajes.Rows.Count; k++)
            {
                //primero creamos la orden de servicio
                int cod=objC.crearOrdenServicio(
                    dsPlantillas1.pltDetalleProgramacionViajes[k].serial, cmbIngeniero.SelectedValue.ToString(),
                    dsPlantillas1.pltDetalleProgramacionViajes[k].fechaInicio, dsPlantillas1.pltDetalleProgramacionViajes[k].fechaFin,
                    false, 0, dsPlantillas1.pltDetalleProgramacionViajes[k].codTipoServicio,
                    dsPlantillas1.pltDetalleProgramacionViajes[k].codprioridadOS,
                    txtObservaciones.Text+" \r\n"+dsPlantillas1.pltDetalleProgramacionViajes[k].observaciones, "",
                    "", "",
                     (cmbAsesorComercial.SelectedValue == null || cmbAsesorComercial.SelectedValue.ToString() == string.Empty) ? 0 : int.Parse(cmbAsesorComercial.SelectedValue.ToString())
                    );
                //actualizamos la fila
                dsPlantillas1.pltDetalleProgramacionViajes[k].codOrdenServicio = cod;
        tipoServicioTableAdapter1.FillBycodTipoServicio(dsSpx2.TipoServicio, dsPlantillas1.pltDetalleProgramacionViajes[k].codTipoServicio);

                #region realizamos operaciones de acuerdo al contrato
                if (!dsSpx2.TipoServicio[0].IsvalidoContratoNull() && dsSpx2.TipoServicio[0].validoContrato)
                {
                    objC.vincularOrdenContrato(dsPlantillas1.pltDetalleProgramacionViajes[k].serial, cod);
                }
#endregion            
                if (cmbIngeniero.SelectedValue != null && cmbIngeniero.SelectedValue.ToString().Trim() != string.Empty)
                    notificacionTableAdapter1.Insert(cmbIngeniero.SelectedValue.ToString(), "Nueva orden de servicio generada",
                        "La orden de servicio " + cod + " se le asigno recientemente, " + dsPlantillas1.pltDetalleProgramacionViajes[k].nombretipoServicio + " " + dsPlantillas1.pltDetalleProgramacionViajes[k].NombreModelo);
           
                #region zona de notificaciones de email
                ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, cod);
             //   CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
             //   mailsender.EjecutarAccion(1, cmbIngeniero.SelectedValue.ToString(), (System.Data.DataRow)dsSpx1.ordenServicio[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media, "", "");
                #endregion


                
            }
            guardar();
            programacionViajesTableAdapter1.Updateprogramada(true, int.Parse(codProgramaion));
            MessageBox.Show("Programacion Generada Satisfactoriamente");
        }

    }
}
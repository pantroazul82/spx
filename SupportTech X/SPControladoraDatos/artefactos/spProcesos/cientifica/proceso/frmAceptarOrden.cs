using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.proceso
{
    public partial class frmAceptarOrden : Form
    {
        public frmAceptarOrden()
        {
            InitializeComponent();
        }

        public bool _editarOrden = false;
        /// <summary>
        /// me indica si la orden esta en edicion, en el aceptar solo guarda cambios 
        /// no cambia de estado.
        /// </summary>
        public bool editarOrden { set { _editarOrden = value; } get { return _editarOrden; } }

        public int codAsesoria { set; get; }

        private void cargarDatos()
        {
            clsTusuario1.Fill(dsSPXSeguridad1.usuario);
            clsTusuario1.Fill(dsSPXSeguridad2.usuario);
            prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);
            prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx2.prioridad_callcenter_cientifica);
            fabricanteTableAdapter1.FillByComboBox(dsSpx2.fabricante);

            string sql = "select cod_usuario,login,nombre from usuario order by nombre asc ";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            cmbUsuarioInterno.DataSource = obj.ejecutarConsulta(sql).Tables[0];
            cmbUsuarioInterno.DisplayMember = "nombre";
            cmbUsuarioInterno.ValueMember = "cod_usuario";
            cmbUsuarioInterno.SelectedValue = -1;
        }

        string nitCliente = "";
        string codContacto = "";
        string codUbicacion = "";

        private void frmAceptarOrden_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calVencimiento.MonthCalendar.DisplayMonth = n;
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1001))
            {
                MessageBox.Show("No tiene permisos para aceptar la asesoria Cientifica!");
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            SPXdata.BD.DataConector ob=new SPXdata.BD.DataConector();
            calRespuestaInicial.fechaValue = ob.fechaServer;
            cargarDatos();
            if (codAsesoria != 0)
            {
                cmbFabricanteEquipo.SelectedValue = -1;
                cmbModeloEquipo.SelectedValue=-1;
                cmbAsesorResponsable.SelectedValue = SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
                cmbAsesorResponsable.Enabled = false;
                asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);
                nitCliente = dsSpx1.asesoria_cientifica[0].nitCliente;
                codContacto = dsSpx1.asesoria_cientifica[0].codContacto;
                codUbicacion = dsSpx1.asesoria_cientifica[0].codSucursal;
                txtNumeroAsesoria.Text = codAsesoria.ToString();
                txtRegistadaPor.Text = dsSpx1.asesoria_cientifica[0].usuario_creacion;
                txtMotivoConsulta.Text = dsSpx1.asesoria_cientifica[0].motivo_consulta;
                if(!dsSpx1.asesoria_cientifica[0].Isfecha_sugeridaNull())
                calSugerida.fechaValue = dsSpx1.asesoria_cientifica[0].fecha_sugerida;
                if (!dsSpx1.asesoria_cientifica[0].Isind_internaNull())
                {
                    chkInterna.Checked = dsSpx1.asesoria_cientifica[0].ind_interna;
                    if (!dsSpx1.asesoria_cientifica[0].Isusuario_internaNull())
                    cmbUsuarioInterno.SelectedValue = dsSpx1.asesoria_cientifica[0].usuario_interna;
                }
                if (!dsSpx1.asesoria_cientifica[0].Isind_noequipo_noreactivoNull())
                    chkIndicaNoEquipo.Checked = dsSpx1.asesoria_cientifica[0].ind_noequipo_noreactivo;
                if (!dsSpx1.asesoria_cientifica[0].Isusuario_internaNull())
                cmbUsuarioInterno.SelectedValue = dsSpx1.asesoria_cientifica[0].usuario_interna;

                txtInfAdiContacto.Text = dsSpx1.asesoria_cientifica[0].infAdicionalContacto;
                cmbPrioridad.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_prioridad_sugerida;
                calFechaSolicitud.Value = dsSpx1.asesoria_cientifica[0].fecha_solicitud;
                //cargamos la informacion del cliente
                clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
                txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente.Trim() + " (" + dsSpx1.clientes[0].nitCliente.Trim() + ")";
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, nitCliente);
                cmbSucursal.SelectedValue = codUbicacion;
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, nitCliente, codContacto);
                txtNombreContacto.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim() + " " + dsSpx1.contactosClientes[0].apellidosContacto;
                txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1;
                if (!dsSpx1.contactosClientes[0].IscelularNull()) txtCelularContacto.Text = dsSpx1.contactosClientes[0].celular;

                if (!dsSpx1.asesoria_cientifica[0].Iscod_prioridad_callcenter_cientificaNull())
                cmbPrioridadAsignada.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_prioridad_callcenter_cientifica;

                if (!dsSpx1.asesoria_cientifica[0].Isind_noequipo_noreactivoNull())
                chkIndicaNoEquipo.Checked = dsSpx1.asesoria_cientifica[0].ind_noequipo_noreactivo;

                if (!dsSpx1.asesoria_cientifica[0].Iscod_referencia_reactivoNull())
                {
                    SPControladoraDatos.dsSpx d = new SPControladoraDatos.dsSpx();

                    referencia_reactivoTableAdapter1.FillBycod_referencia_reactivo(d.referencia_reactivo,
                        dsSpx1.asesoria_cientifica[0].cod_referencia_reactivo);

                    codigoReactivo = d.referencia_reactivo[0].cod_referencia_reactivo.ToString();
                    txtReactivo.Text = d.referencia_reactivo[0].nombre_referencia_reactivo.Trim() + "("+d.referencia_reactivo[0].codigo_manual.Trim()+")";
                    
                    if(d.referencia_reactivo.Count>0){
                        fabricanteTableAdapter1.FillBycodFabricante(d.fabricante, d.referencia_reactivo[0].codFabricante.Trim());
                        if (d.fabricante.Count > 0)
                        {
                            txtFabricanteReactivo.Text = d.fabricante[0].nombre_fabricante;
                        }
                    
                    }
                }
                
                if (!dsSpx1.asesoria_cientifica[0].Islote_reactivoNull())
                txtNumeroLote.Text = dsSpx1.asesoria_cientifica[0].lote_reactivo;

                if (!dsSpx1.asesoria_cientifica[0].Isvencimiento_reactivoNull())
                calVencimiento.Value = dsSpx1.asesoria_cientifica[0].vencimiento_reactivo;

                if (!dsSpx1.asesoria_cientifica[0].IsserialNull())
                {
                    txtSerial.Text = dsSpx1.asesoria_cientifica[0].serial;
                    //
                    if (!dsSpx1.asesoria_cientifica[0].IscodFabricanteNull())
                    {
                        cmbFabricanteEquipo.SelectedValue = dsSpx1.asesoria_cientifica[0].codFabricante.Trim();
                        modelosTableAdapter1.FillBycodFabricante(dsSpx1.Modelos, dsSpx1.asesoria_cientifica[0].codFabricante.Trim());
                        if (!dsSpx1.asesoria_cientifica[0].IscodModeloNull())
                        {
                            cmbModeloEquipo.SelectedValue = dsSpx1.asesoria_cientifica[0].codModelo.Trim();
                        }
                    }
                }
                if (!dsSpx1.asesoria_cientifica[0].Isllamada_recibida_disponibilidadNull())
                {
                    rdDisponibilidad.Checked = dsSpx1.asesoria_cientifica[0].llamada_recibida_disponibilidad;
                    rdNoDisponibilidad.Checked = !dsSpx1.asesoria_cientifica[0].llamada_recibida_disponibilidad;
                }

                if (!dsSpx1.asesoria_cientifica[0].Isrespuesta_inicialNull())
                txtRespuestaInicial.Text = dsSpx1.asesoria_cientifica[0].respuesta_inicial;

                if (!dsSpx1.asesoria_cientifica[0].IsinformacionSuministradaInicialNull())
                txtInformacionSuministradaInicial.Text = dsSpx1.asesoria_cientifica[0].informacionSuministradaInicial;

                if (!dsSpx1.asesoria_cientifica[0].Isind_internaNull())
                chkInterna.Checked = dsSpx1.asesoria_cientifica[0].ind_interna;

                if (!dsSpx1.asesoria_cientifica[0].Isusuario_internaNull())
                cmbUsuarioInterno.SelectedValue = dsSpx1.asesoria_cientifica[0].usuario_interna;
                //cargamos al acciones a seguir
                accion_seguirxasesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.accion_seguirxasesoria_cientifica, codAsesoria);

                for (int k = 0; k < dsSpx1.accion_seguirxasesoria_cientifica.Count; k++)
                {
                    dsSpx1.accion_seguir_cientifica.Merge(
                        accion_seguir_cientificaTableAdapter1.GetDataBycod_accion_seguir_cientifica(
                        dsSpx1.accion_seguirxasesoria_cientifica[k].cod_accion_seguir_cientifica
                        )
                        );
                }
                if (!dsSpx1.asesoria_cientifica[0].Isllamada_recibida_disponibilidadNull() &&
                    dsSpx1.asesoria_cientifica[0].llamada_recibida_disponibilidad)
                {
                    rdDisponibilidad.Checked = true;
                  
                    if(!dsSpx1.asesoria_cientifica[0].Isfecha_respuesta_inicialNull())
                    {
                        calRespuestaInicial.fechaValue = dsSpx1.asesoria_cientifica[0].fecha_respuesta_inicial;
                    }
                    calRespuestaInicial.Enabled = false;
                } 
                    rdDisponibilidad.Enabled = false;
                    rdNoDisponibilidad.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            if(chkInterna.Checked && (cmbUsuarioInterno.SelectedValue== null || cmbUsuarioInterno.SelectedValue.ToString().Trim() == string.Empty))
            {
                MessageBox.Show("Si la llamada es interna debe especificar el usuario!","Validacion");
                return false;
            }

            if (!chkIndicaNoEquipo.Checked && txtSerial.Text.Trim() == string.Empty  && (codigoReactivo == null || codigoReactivo == string.Empty ) )
            {
                MessageBox.Show("El reactivo o el serial del equipo es obligatorio","Validacion");
                return false;
            }
            if (dsSpx1.accion_seguir_cientifica.Count<=0)
            {
                MessageBox.Show("Debe ingresar por lo menos una accion a seguir", "Validacion");
                return false;
            }

            if (cmbAsesorResponsable.SelectedValue == null || cmbAsesorResponsable.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("El Asesor responsable es obligatorio!", "Validacion");
                return false;
            }
            if (cmbPrioridadAsignada.SelectedValue == null || cmbPrioridadAsignada.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La Prioridad es obligatoria!", "Validacion");
                return false;
            }
            if (txtRespuestaInicial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La respuesta Inicial es obligatoria!", "Validacion");
                return false;
            }
            //if (!chkIndicaNoEquipo.Checked && (txtNumeroLote.Text.Trim() == string.Empty))
            //{
            //    MessageBox.Show("El Numero de Lote es obligatorio!", "Validacion");
            //    return false;
            //}
            //if (!chkIndicaNoEquipo.Checked && (calVencimiento.ValueObject == null))
            //{
            //    MessageBox.Show("La fecha de Vencimiento del reactivo es obligatorio!", "Validacion");
            //    return false;
            //}
            if (!rdDisponibilidad.Checked && !rdNoDisponibilidad.Checked)
            {
                MessageBox.Show("Seleccione si la llamada fue recibida o no en disponibilidad!", "Validacion");
                return false;
               
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            
            asesoria_cientificaTableAdapter1.UpdateResponsable(cmbAsesorResponsable.SelectedValue.ToString(), codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateCod_prioridad_callcenter_cientifica(int.Parse(cmbPrioridadAsignada.SelectedValue.ToString()), codAsesoria);
            if (codigoReactivo != string.Empty)
            {
                asesoria_cientificaTableAdapter1.UpdateCod_referencia_reactivo(int.Parse(codigoReactivo), codAsesoria);
            }
            asesoria_cientificaTableAdapter1.UpdateLote_reactivo(txtNumeroLote.Text, codAsesoria);
            if (chkIndicaNoEquipo.Checked)
            {
                asesoria_cientificaTableAdapter1.UpdateVencimientoReactivo(null, codAsesoria);
            }else{
                if (calVencimiento.ValueObject != null)
                {
                    asesoria_cientificaTableAdapter1.UpdateVencimientoReactivo(calVencimiento.Value, codAsesoria);
                }
                else
                {
                    asesoria_cientificaTableAdapter1.UpdateVencimientoReactivo(null, codAsesoria);
                }
            }
            asesoria_cientificaTableAdapter1.UpdateSerial(txtSerial.Text, codAsesoria);
            asesoria_cientificaTableAdapter1.Updateind_noequipo_noreactivo(chkIndicaNoEquipo.Checked, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateInfoInterna(chkInterna.Checked,
                ( (cmbUsuarioInterno.SelectedValue == null || cmbUsuarioInterno.SelectedValue.ToString().Trim() == string.Empty)?null:cmbUsuarioInterno.SelectedValue.ToString()), codAsesoria);

            if (cmbFabricanteEquipo.SelectedValue != null && cmbFabricanteEquipo.SelectedValue.ToString().Trim() != string.Empty)
                asesoria_cientificaTableAdapter1.UpdateCodFabricante(cmbFabricanteEquipo.SelectedValue.ToString(), codAsesoria);
            else
                asesoria_cientificaTableAdapter1.UpdateCodFabricante(null, codAsesoria);

            if (cmbModeloEquipo.SelectedValue != null && cmbModeloEquipo.SelectedValue.ToString().Trim() != string.Empty)
                asesoria_cientificaTableAdapter1.UpdateCodModelo(cmbModeloEquipo.SelectedValue.ToString(), codAsesoria);
            else
                asesoria_cientificaTableAdapter1.UpdateCodModelo(null, codAsesoria);

            asesoria_cientificaTableAdapter1.UpdateFechaRespuestaInicial(calRespuestaInicial.fechaValue, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateRespuesta_inicial(txtRespuestaInicial.Text, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateInformacionSuministradaInicial(txtInformacionSuministradaInicial.Text, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateLlamada_recibida_disponibilidad(rdDisponibilidad.Checked, codAsesoria);
            accion_seguirxasesoria_cientificaTableAdapter1.DeleteBycod_asesoria_cientifica(codAsesoria);
            for (int k = 0; k < dsSpx1.accion_seguir_cientifica.Count; k++)
            {
                accion_seguirxasesoria_cientificaTableAdapter1.Insert(dsSpx1.accion_seguir_cientifica[k].cod_accion_seguir_cientifica, codAsesoria);
            }
            
            //cambiamos el estado
            if (!editarOrden)
            {
                estado_asesoria_cientificaTableAdapter1.FillByCod_manual(dsSpx1.estado_asesoria_cientifica, "2");

                int est = dsSpx1.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
                asesoria_cientificaTableAdapter1.UpdateCod_estado_asesoria_cientifica(est, codAsesoria);
            }

            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfCliente fr = new SpFrm.terceros.frmInfCliente();
            fr.nitCliente = nitCliente;
            fr.Show();
        }

        private void btnInfSucursal_Click(object sender, EventArgs e)
        {
            if (codUbicacion == string.Empty)
            {
                MessageBox.Show("Seleccione una Sucursal", "Confirmacion");
                return;
            }
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfSucursal fr = new SpFrm.terceros.frmInfSucursal();
            fr.NitCliente = nitCliente;
            fr.CodSucursal = codUbicacion;
            fr.Show();
        }

        private void btnInfoContacto_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfContactoSucursal fr = new SpFrm.terceros.frmInfContactoSucursal();
            fr.NitCliente = nitCliente;
            fr.CodContacto = codContacto;
            fr.Show();
        }

        

        private void cmbFabricanteEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFabricanteEquipo.SelectedValue != null && cmbFabricanteEquipo.SelectedValue.ToString().Trim() != string.Empty)
            {
                modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx2.Modelos, cmbFabricanteEquipo.SelectedValue.ToString());
            }
            else {
                dsSpx2.Modelos.Clear();
            }
        }

        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            fr.NitCliente = nitCliente;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                //cargamos el fabricante y el modelo del equipo
                equiposTableAdapter1.FillBySerial(dsSpx2.equipos, txtSerial.Text);
                fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx2.fabricante,dsSpx2.equipos[0].codFabricante.Trim());
                modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx2.Modelos,
                    dsSpx2.equipos[0].codFabricante.Trim(),dsSpx2.equipos[0].codModelo.Trim());
                cmbFabricanteEquipo.Enabled = false;
                cmbModeloEquipo.Enabled = false;
               // cargarserial(txtSerial.Text);
            }
        }

        private void txtSerial_Validated(object sender, EventArgs e)
        {
            object a = cmbFabricanteEquipo.SelectedValue;
            object b = cmbModeloEquipo.SelectedValue;
            equiposTableAdapter1.FillBySerial(dsSpx2.equipos, txtSerial.Text);
            if (dsSpx2.equipos.Count > 0 && dsSpx2.equipos[0].nitClienteUbica != nitCliente)
            {
                MessageBox.Show("Segun la base de datos de Ingenieria este serial esta en otro Cliente");
                fabricanteTableAdapter1.FillByComboBox(dsSpx2.fabricante);
                cmbFabricanteEquipo.SelectedIndex = 0;
                if (a != null && a.ToString().Trim() != string.Empty)
                {
                    cmbFabricanteEquipo.SelectedValue = a;
                }
                modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx2.Modelos,
                   cmbFabricanteEquipo.SelectedValue.ToString());
                if (b != null && b.ToString().Trim() != string.Empty)
                {
                    cmbFabricanteEquipo.SelectedValue = a;
                }
                cmbFabricanteEquipo.Enabled = true;
                cmbModeloEquipo.Enabled = true;
                return;
            }
            else
            {
                if (dsSpx2.equipos.Count > 0)
                {
                    fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx2.fabricante, dsSpx2.equipos[0].codFabricante.Trim());
                    modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx2.Modelos,
                        dsSpx2.equipos[0].codFabricante.Trim(), dsSpx2.equipos[0].codModelo.Trim());
                    cmbFabricanteEquipo.Enabled = false;
                    cmbModeloEquipo.Enabled = false;
                }
                else
                {
                    fabricanteTableAdapter1.FillByComboBox(dsSpx2.fabricante);
                    cmbFabricanteEquipo.SelectedIndex = 0;
                    if (a != null && a.ToString().Trim() != string.Empty)
                    {
                        cmbFabricanteEquipo.SelectedValue = a;
                    }
                    modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx2.Modelos,
                       cmbFabricanteEquipo.SelectedValue.ToString());
                    if (b != null && b.ToString().Trim() != string.Empty)
                    {
                        cmbFabricanteEquipo.SelectedValue = b;
                    }
                    cmbFabricanteEquipo.Enabled = true;
                    cmbModeloEquipo.Enabled = true;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSeleccioneAccionASeguir fr = new frmSeleccioneAccionASeguir();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                if (dsSpx1.accion_seguir_cientifica.Select("cod_accion_seguir_cientifica="+fr.codAccionElegida).Length <= 0)
                {
                    dsSpx1.accion_seguir_cientifica.Merge(
                        accion_seguir_cientificaTableAdapter1.GetDataBycod_accion_seguir_cientifica(fr.codAccionElegida)
                        );
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdAccionesSeguir.Columns["cod_accion_seguir_cientifica"].Text.Trim() == string.Empty)
                return;

            if(MessageBox.Show("Esta seguro de quitar la accion a seguir","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes){
            dsSpx1.accion_seguir_cientifica.Rows.Remove(
                dsSpx1.accion_seguir_cientifica.Select("cod_accion_seguir_cientifica=" +
                grdAccionesSeguir.Columns["cod_accion_seguir_cientifica"].Text )[0]
                );
            }
        }

        private void chkIndicaNoEquipo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndicaNoEquipo.Checked)
            {
                txtReactivo.Enabled = false;                
                txtReactivo.Text = "";
                codigoReactivo = "";
                txtFabricanteReactivo.Text = "";
                txtSerial.Text="";
                cmbFabricanteEquipo.SelectedValue = -1;
                cmbModeloEquipo.SelectedValue=-1;
                cmbFabricanteEquipo.Enabled = false;
                cmbModeloEquipo.Enabled = false;
                txtNumeroLote.Enabled = false;
                txtNumeroLote.Text = "";
                calVencimiento.Enabled = false;
                calVencimiento.ValueObject = null;
            }else{
                cmbFabricanteEquipo.Enabled = true;
                cmbModeloEquipo.Enabled = true;
                txtReactivo.Enabled = true;
                txtNumeroLote.Enabled = true;
                calVencimiento.Enabled = true;

            }
        }

        private void chkInterna_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkInterna.Checked)
            //{
            //    cmbUsuarioInterno.Enabled = true;
            //}
            //else {
            //    cmbUsuarioInterno.Enabled = false;
            //    cmbUsuarioInterno.SelectedValue = -1;
            //}
        }

        private void rdDisponibilidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDisponibilidad.Checked)
            {
                calRespuestaInicial.Enabled = true;
            }
            else {
                SPXdata.BD.DataConector obj=new SPXdata.BD.DataConector();
                calRespuestaInicial.fechaValue = obj.fechaServer;
                calRespuestaInicial.Enabled = false;
            }
        }

        private void btnEditarAsesorResponsable_Click(object sender, EventArgs e)
        {
            //verificamos el permiso
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1021))
            {
                MessageBox.Show("No tiene permisos para realizar esta accion!");
                return;
            }
                cmbAsesorResponsable.Enabled = true;
        }

        string codigoReactivo = "";
        private void btnBuscarReactivo_Click(object sender, EventArgs e)
        {
            spProcesos.cientifica.frmBuscarReactivo fr = new frmBuscarReactivo();
            
            if (fr.ShowDialog() == DialogResult.OK)
            {
                codigoReactivo = fr.CodReactivo;
                txtReactivo.Text = fr.NombreREactivo.Trim()+" ("+fr.CodManual.Trim()+")";
                txtReactivo.Focus();
                
            }
        }

        private void txtReactivo_Validated_1(object sender, EventArgs e)
        {

            //miramos si selecicino algun reactivo
            if (txtReactivo.Text != null && txtReactivo.Text.Trim() != string.Empty && codigoReactivo.Trim() != string.Empty)
            {
                referencia_reactivoTableAdapter1.FillBycod_referencia_reactivo(dsSpx1.referencia_reactivo, int.Parse(codigoReactivo));

                fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx1.fabricante,
                dsSpx1.referencia_reactivo[0].codFabricante.Trim());
                txtFabricanteReactivo.Text = dsSpx1.fabricante[0].nombre_fabricante;
            }
            else
            {
                txtFabricanteReactivo.Text = "";
            }
        }
    }
}

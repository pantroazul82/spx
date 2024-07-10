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
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }
        string nitCliente = "";
        string codContacto = "";
        string codUbicacion = "";

        public bool editable = true;
        public int codAsesoria { set; get; }
        private void cargarDatos()
        {
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            clsTusuario1.Fill(dsSPXSeguridad1.usuario);
            inconveniente_presentado_cientificaTableAdapter1.Fill(dsSpx1.inconveniente_presentado_cientifica);
            prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);
            prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx2.prioridad_callcenter_cientifica);
            estado_asesoria_cientificaTableAdapter1.Fill(dsSpx1.estado_asesoria_cientifica);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmEnseguimiento_Load(object sender, EventArgs e)
        {
            cargarDatos();
           
            if (codAsesoria != 0)
            {
             
                asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);
                estado_asesoria_cientificaTableAdapter1.FillBycod_estado_asesoria_cientifica(dsSpx1.estado_asesoria_cientifica, dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica);

                if (!dsSpx1.asesoria_cientifica[0].Isind_internaNull())
                {
                    chkInterna.Checked = dsSpx1.asesoria_cientifica[0].ind_interna;
                    if (!dsSpx1.asesoria_cientifica[0].Isusuario_internaNull())
                        cmbUsuarioInterno.SelectedValue = dsSpx1.asesoria_cientifica[0].usuario_interna;
                }else{
                    chkInterna.Checked = false;
                    cmbUsuarioInterno.SelectedIndex = -1;
                }
                if (!dsSpx1.asesoria_cientifica[0].Isllamada_recibida_disponibilidadNull())
                {
                    rdDisponibilidad.Checked = dsSpx1.asesoria_cientifica[0].llamada_recibida_disponibilidad;
                    rdNoDisponibilidad.Checked = !dsSpx1.asesoria_cientifica[0].llamada_recibida_disponibilidad;
                }
                if (!dsSpx1.asesoria_cientifica[0].IsconformeNull())
                {
                rdNoConforme.Checked = !dsSpx1.asesoria_cientifica[0].conforme;
                rdSiConforme.Checked = dsSpx1.asesoria_cientifica[0].conforme;
                }
                if (!dsSpx1.asesoria_cientifica[0].IssolucionadoNull())
                {
                    rdNoSolucionado.Checked = !dsSpx1.asesoria_cientifica[0].solucionado;
                    rdSiSolucionado.Checked = !dsSpx1.asesoria_cientifica[0].solucionado;
                }
                


                if (!dsSpx1.asesoria_cientifica[0].Isind_noequipo_noreactivoNull())
                    chkIndicaNoEquipo.Checked = dsSpx1.asesoria_cientifica[0].ind_noequipo_noreactivo;
                

                if (!dsSpx1.asesoria_cientifica[0].IsidLlamadaSoporteNull())
                    txtCodLlamada.Text = dsSpx1.asesoria_cientifica[0].idLlamadaSoporte.ToString();

                nitCliente = dsSpx1.asesoria_cientifica[0].nitCliente;
                codContacto = dsSpx1.asesoria_cientifica[0].codContacto;
                codUbicacion = dsSpx1.asesoria_cientifica[0].codSucursal;
                txtNumeroAsesoria.Text = codAsesoria.ToString();
                txtRegistadaPor.Text = dsSpx1.asesoria_cientifica[0].usuario_creacion;
                txtMotivoConsulta.Text = dsSpx1.asesoria_cientifica[0].motivo_consulta;

                if (!dsSpx1.asesoria_cientifica[0].IsinformacionSuministradaInicialNull())
                txtInformacionSuministradaInicial.Text = dsSpx1.asesoria_cientifica[0].informacionSuministradaInicial;

                if(! dsSpx1.asesoria_cientifica[0].Isrespuesta_inicialNull())
                txtRespuestaInicial.Text = dsSpx1.asesoria_cientifica[0].respuesta_inicial;

                if(!dsSpx1.asesoria_cientifica[0].Iscod_inconveniente_presentado_cientificaNull())
                cmbInconvenientePor.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_inconveniente_presentado_cientifica;
                if (!dsSpx1.asesoria_cientifica[0].Isnumero_reporte_qcNull())
                txtReporteCalidad.Text = dsSpx1.asesoria_cientifica[0].numero_reporte_qc;
                cmbEstado.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica;
                txtInfAdiContacto.Text = dsSpx1.asesoria_cientifica[0].infAdicionalContacto;
                cmbPrioridad.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_prioridad_sugerida;
                cmbPrioridadAsignada.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_prioridad_callcenter_cientifica;

                if (!dsSpx1.asesoria_cientifica[0].Isno_conforme_porqueNull())
                txtPorqueNoConforme.Text = dsSpx1.asesoria_cientifica[0].no_conforme_porque;

                if (!dsSpx1.asesoria_cientifica[0].Isno_porqueNull())
                txtPorqueNoSolucionado.Text = dsSpx1.asesoria_cientifica[0].no_porque;
                
                if(!dsSpx1.asesoria_cientifica[0].Isdias_solucionNull())
                numDiasSolcuonar.Value = dsSpx1.asesoria_cientifica[0].dias_solucion;


                calFechaSolicitud.Value = dsSpx1.asesoria_cientifica[0].fecha_solicitud;
                calSugerida.fechaValue = dsSpx1.asesoria_cientifica[0].fecha_sugerida;
                calRespuestaInicial.fechaValue = dsSpx1.asesoria_cientifica[0].fecha_respuesta_inicial;
                if(!dsSpx1.asesoria_cientifica[0].Isfecha_visitaNull())
                calVisita.Value = dsSpx1.asesoria_cientifica[0].fecha_visita;
                if(!dsSpx1.asesoria_cientifica[0].Isfecha_cierreNull())
                calCierre.Value = dsSpx1.asesoria_cientifica[0].fecha_cierre;
                if(!dsSpx1.asesoria_cientifica[0].Isvencimiento_reactivoNull())
                calVencimiento.Value = dsSpx1.asesoria_cientifica[0].vencimiento_reactivo;
                //cargamos la informacion del cliente
                clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
                txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente.Trim() + " (" + dsSpx1.clientes[0].nitCliente.Trim() + ")";
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, nitCliente);
                cmbSucursal.SelectedValue = codUbicacion;
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, nitCliente, codContacto);
                txtNombreContacto.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim() + " " + dsSpx1.contactosClientes[0].apellidosContacto;
                txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1;
                if (!dsSpx1.contactosClientes[0].IscelularNull()) txtCelularContacto.Text = dsSpx1.contactosClientes[0].celular;
               //vamos con la infromacion de aceptacion
                clsTusuario1.FillBylogin(dsSPXSeguridad1.usuario, dsSpx1.asesoria_cientifica[0].responsable);
                if (dsSPXSeguridad1.usuario.Count > 0)
                {
                    txtAsesorResponsable.Text = dsSPXSeguridad1.usuario[0].nombre;
                }
                if (!dsSpx1.asesoria_cientifica[0].Iscod_referencia_reactivoNull())
                {
                    txtReactivo.Value = dsSpx1.asesoria_cientifica[0].cod_referencia_reactivo.ToString();
                    referencia_reactivoTableAdapter1.FillBycod_referencia_reactivo(dsSpx1.referencia_reactivo, dsSpx1.asesoria_cientifica[0].cod_referencia_reactivo);
                }
                if (dsSpx1.referencia_reactivo.Count > 0)
                {
                    fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx1.fabricante, dsSpx1.referencia_reactivo[0].codFabricante.Trim());
                    txtFabricanteReactivo.Text = dsSpx1.fabricante[0].nombre_fabricante;
                    txtNumeroLote.Text = dsSpx1.asesoria_cientifica[0].lote_reactivo;
                    if (!dsSpx1.asesoria_cientifica[0].Isvencimiento_reactivoNull())
                    calVencimiento.Value = dsSpx1.asesoria_cientifica[0].vencimiento_reactivo;
                }
                txtSerial.Text = dsSpx1.asesoria_cientifica[0].serial;
                if (!dsSpx1.asesoria_cientifica[0].IscodFabricanteNull())
                {
                    fabricanteTableAdapter1.FillByCodfabricanteComboBox(dsSpx1.fabricante, dsSpx1.asesoria_cientifica[0].codFabricante.Trim());
                    if(!dsSpx1.asesoria_cientifica[0].IscodModeloNull())
                    modelosTableAdapter1.FillByFabricanteModeloComboBox(dsSpx1.Modelos, dsSpx1.asesoria_cientifica[0].codFabricante.Trim(), dsSpx1.asesoria_cientifica[0].codModelo.Trim());
                }
                //cargamos los seguiminetos
                seguimiento_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.seguimiento_asesoria_cientifica, codAsesoria);
                //cargamos las acciones a seguir
                accion_seguirxasesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.accion_seguirxasesoria_cientifica, codAsesoria);
                for (int k = 0; k < dsSpx1.accion_seguirxasesoria_cientifica.Count; k++)
                {
                    dsSpx1.accion_seguir_cientifica.Merge(
                        accion_seguir_cientificaTableAdapter1.GetDataBycod_accion_seguir_cientifica(dsSpx1.accion_seguirxasesoria_cientifica[k].cod_accion_seguir_cientifica)
                        );
                }

            }
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfCliente fr = new SpFrm.terceros.frmInfCliente();
            fr.nitCliente = nitCliente;
            fr.Show();
        }

        //ok
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

        //ok
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfContactoSucursal fr = new SpFrm.terceros.frmInfContactoSucursal();
            fr.NitCliente = nitCliente;
            fr.CodContacto = codContacto;
            fr.Show();
        }

        //ok
        private void btnVerSeguimiento_Click(object sender, EventArgs e)
        {
            if (grdSeguimentos.Columns["cod_seguimiento_asesoria_cientifica"].Text.Trim() == string.Empty) return;
            frmSeguimientoCientifica fr = new frmSeguimientoCientifica();
            fr.codAsesoria = codAsesoria;
            fr.codSeguimiento = int.Parse(grdSeguimentos.Columns["cod_seguimiento_asesoria_cientifica"].Text);
            fr.Show();
        }

        //ok
        private void btnExportarSeguimientos_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdSeguimentos, "Seguimientos", false);
        }

        //ok
        private void btnTareasProgramadas_Click(object sender, EventArgs e)
        {
            cientifica.proceso.frmTareasAsesorias fr = new frmTareasAsesorias();
            fr.codAsesoria = codAsesoria;
            fr.Show();
        }

    
       
    }
}

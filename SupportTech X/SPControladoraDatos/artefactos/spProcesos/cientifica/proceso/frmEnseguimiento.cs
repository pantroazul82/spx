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
    public partial class frmEnseguimiento : Form
    {
        public frmEnseguimiento()
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
            
            prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);
            estado_asesoria_cientificaTableAdapter1.Fill(dsSpx1.estado_asesoria_cientifica);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


        private void cargarASesoria()
        {

            asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);
            estado_asesoria_cientificaTableAdapter1.FillBycod_estado_asesoria_cientifica(dsSpx1.estado_asesoria_cientifica, dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica);
            if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "4")
            {
                btnReabrir.Visible = true;
                btnCerrarAsesoria.Visible = false;
                btnAgregarSeguimiento.Visible = false;
                btnCambiardeEstado.Visible = false;
                btnCerrarEnSeguimiento.Visible = false;
                btnSolicitudServicioIngenieria.Visible = false;
                btnCambiarCliente.Visible = false;
            }
            else if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "32")
            {
                btnReabrir.Visible = false;
                btnCerrarAsesoria.Visible = true;
                btnAgregarSeguimiento.Visible = true;
                btnCambiardeEstado.Visible = false;
                btnSolicitudServicioIngenieria.Visible = true;
                btnCerrarEnSeguimiento.Visible = false;
                btnCambiarCliente.Visible = true;
            }
            else if (dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "3" || dsSpx1.estado_asesoria_cientifica[0].cod_manual.Trim() == "31")
            {
                btnReabrir.Visible = false;
                btnCerrarAsesoria.Visible = true;
                btnCambiarCliente.Visible = true;
                btnAgregarSeguimiento.Visible = true;
                btnCambiardeEstado.Visible = true;
                btnSolicitudServicioIngenieria.Visible = true;
                btnCerrarEnSeguimiento.Visible = true;
            }


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

            if (!dsSpx1.asesoria_cientifica[0].IsidLlamadaSoporteNull())
                txtCodLlamada.Text = dsSpx1.asesoria_cientifica[0].idLlamadaSoporte.ToString();

            nitCliente = dsSpx1.asesoria_cientifica[0].nitCliente;
            codContacto = dsSpx1.asesoria_cientifica[0].codContacto;
            codUbicacion = dsSpx1.asesoria_cientifica[0].codSucursal;
            txtNumeroAsesoria.Text = codAsesoria.ToString();
            txtRegistadaPor.Text = dsSpx1.asesoria_cientifica[0].usuario_creacion;
            txtMotivoConsulta.Text = dsSpx1.asesoria_cientifica[0].motivo_consulta;
            cmbEstado.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica;
            txtInfAdiContacto.Text = dsSpx1.asesoria_cientifica[0].infAdicionalContacto;
            cmbPrioridad.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_prioridad_callcenter_cientifica;
            calFechaSolicitud.Value = dsSpx1.asesoria_cientifica[0].fecha_solicitud;
            if (!dsSpx1.asesoria_cientifica[0].Isnumero_reporte_qcNull())
            txtCodigoQc.Text = dsSpx1.asesoria_cientifica[0].numero_reporte_qc.Trim();
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
                if (!dsSpx1.asesoria_cientifica[0].IscodModeloNull())
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


        private void frmEnseguimiento_Load(object sender, EventArgs e)
        {
            cargarDatos();
            if (!editable)
            {
                btnAgregarSeguimiento.Visible = false;
                btnCambiardeEstado.Visible = false;
                btnCerrarAsesoria.Visible = false;
                btnSolicitudServicioIngenieria.Visible = false;
                btnTareasProgramadas.Visible = false;
            }
            if (codAsesoria != 0)
            {
                cargarASesoria();
             

            }
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfContactoSucursal fr = new SpFrm.terceros.frmInfContactoSucursal();
            fr.NitCliente = nitCliente;
            fr.CodContacto = codContacto;
            fr.Show();
        }

        private void btnAgregarSeguimiento_Click(object sender, EventArgs e)
        {
            frmSeguimientoCientifica fr = new frmSeguimientoCientifica();
            fr.codAsesoria = codAsesoria;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                seguimiento_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.seguimiento_asesoria_cientifica, codAsesoria);
                SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
                estado_asesoria_cientificaTableAdapter1.FillByCod_manual(ds.estado_asesoria_cientifica, "2");
                int est = ds.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
                if (est == dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica)
                {
                    estado_asesoria_cientificaTableAdapter1.FillByCod_manual(ds.estado_asesoria_cientifica, "3");
                    est = ds.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
                    asesoria_cientificaTableAdapter1.UpdateCod_estado_asesoria_cientifica(est, codAsesoria);
                    cmbEstado.SelectedValue = est;
                }
            }
        }

        private void btnVerSeguimiento_Click(object sender, EventArgs e)
        {
            if (grdSeguimentos.Columns["cod_seguimiento_asesoria_cientifica"].Text.Trim() == string.Empty) return;
            frmSeguimientoCientifica fr = new frmSeguimientoCientifica();
            fr.codAsesoria = codAsesoria;
            fr.codSeguimiento = int.Parse(grdSeguimentos.Columns["cod_seguimiento_asesoria_cientifica"].Text);
            fr.Show();
        }

        private void btnExportarSeguimientos_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdSeguimentos, "Seguimientos", false);
        }

        private void btnCambiardeEstado_Click(object sender, EventArgs e)
        {
            int estFinal = 0;
            
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            estado_asesoria_cientificaTableAdapter1.FillBycod_estado_asesoria_cientifica(ds.estado_asesoria_cientifica,
dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica);
            int estActual = int.Parse( ds.estado_asesoria_cientifica[0].cod_manual);
            string pregunta = "";
            if (estActual == 31) {
                pregunta = "Esta seguro de cambiar de estado la asesoria en estado 'En espera de respuesta' por el estado 'en seguimiento'";
                estado_asesoria_cientificaTableAdapter1.FillByCod_manual(ds.estado_asesoria_cientifica, "3");
                estFinal = ds.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
            } else {
                pregunta = "Esta seguro de cambiar de estado la asesoria en estado 'en seguimiento' por el estado  'En espera de respuesta' ";
                estado_asesoria_cientificaTableAdapter1.FillByCod_manual(ds.estado_asesoria_cientifica, "31");
                if (ds.estado_asesoria_cientifica.Count > 0)
                {
                    estFinal = ds.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
                }else {
                    MessageBox.Show("No esta configurado el estado en espera de respuesta!");
                }
            }

            if (MessageBox.Show(pregunta,"Confirmar Cambiar de Estado",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                asesoria_cientificaTableAdapter1.UpdateCod_estado_asesoria_cientifica(estFinal, codAsesoria);
                cmbEstado.SelectedValue = estFinal;
            }
        }

        private void btnCerrarAsesoria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar la asesoria cientifica?","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                cerrarAsesoria();
            }
        }

        private void cerrarAsesoria() 
        {
            frmCerrarOrden fr = new frmCerrarOrden();
            fr.codAsesoria = codAsesoria;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void reabrirAsesoria()
        {
            //actualiza el estado

            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            estado_asesoria_cientificaTableAdapter1.FillByCod_manual(ds.estado_asesoria_cientifica, "3");
            int estActual = ds.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
            asesoria_cientificaTableAdapter1.UpdateCod_estado_asesoria_cientifica(estActual, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateReabierta(true, codAsesoria);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cerrarAsesoriaSeguimiento()
        {
            //actualiza el estado
          
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            estado_asesoria_cientificaTableAdapter1.FillByCod_manual(ds.estado_asesoria_cientifica, "32");
            int estActual = ds.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
            asesoria_cientificaTableAdapter1.UpdateCod_estado_asesoria_cientifica(estActual, codAsesoria);
            
           // asesoria_cientificaTableAdapter1.UpdateCerrada_por(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, codAsesoria);
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            asesoria_cientificaTableAdapter1.UpdateFecha_cerrada_seguimiento(obj.fechaServer , codAsesoria);
    asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(ds.asesoria_cientifica, codAsesoria);
            
           //vamos con los indicadores
            if (!ds.asesoria_cientifica[0].Isfecha_primer_seguimientoNull())
            {
                DateTime f = ds.asesoria_cientifica[0].fecha_primer_seguimiento;
                DateTime f2 = obj.fechaServer;
                int t = (int)f2.Subtract(f).TotalDays;
           asesoria_cientificaTableAdapter1.UpdateIndicador_tres(t, codAsesoria);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool generarAsesoriaIngenieria()
        {
            //validamos si ya tiene solicitudes esta asesoria
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            
            asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(ds.asesoria_cientifica, codAsesoria);

            if (!ds.asesoria_cientifica[0].IsidLlamadaSoportePreNull())
            {
                MessageBox.Show("Esta asesoria cientifica ya tiene una llamada de ingenieria abierta con codigo "
                    + ds.asesoria_cientifica[0].idLlamadaSoportePre +
                    "\n", "Confirmacion", MessageBoxButtons.OK) ;
                    return false;
            }

            //

            cientifica.proceso.frmSolicitudIngenieria frm = new frmSolicitudIngenieria();
            frm.codAsesoria = codAsesoria;
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodLlamada.Text = frm.codLlamada.ToString() ;
                return true;
            }
            return false;
        }

        private void btnSolicitudServicioIngenieria_Click(object sender, EventArgs e)
        {
            //validamos que el serial sea de annar si no lo es no continua
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, txtSerial.Text);
            if (dsSpx1.equipos.Count <= 0)
            {
                MessageBox.Show("El serial que tiene la asesoria no existe en la base de datos de equipos!","Confirmacion");
                return;
            }
            if (dsSpx1.equipos[0].nitClienteUbica != nitCliente)
            {
                MessageBox.Show("El serial que tiene la asesoria existe en la base de datos de equipos, pero esta vinculado a otro cliente!", "Confirmacion");
                return;
            }
            generarAsesoriaIngenieria();

        }

        private void btnTareasProgramadas_Click(object sender, EventArgs e)
        {
            cientifica.proceso.frmTareasAsesorias fr = new frmTareasAsesorias();
            fr.codAsesoria = codAsesoria;
            fr.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           


            //validamos que no este cerrada no en seguimineto
            SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            objEstado.FillBycod_estado_asesoria_cientifica(ds.estado_asesoria_cientifica, dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica);
            if (ds.estado_asesoria_cientifica[0].cod_manual.Trim() == "32")
            {
                MessageBox.Show("Esta orden ya esta cerrada en seguimiento!","Error");
                return;
            }

            if (MessageBox.Show("Esta seguro de cerrar la asesoria cientifica y dejarla en seguimiento?", "Confirmacion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            { 
                frmCerrarOrdenEnSeguimiento fr = new frmCerrarOrdenEnSeguimiento();
                fr.codAsesoria = codAsesoria;
                if (fr.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                cerrarAsesoriaSeguimiento();
            }
        }

        private void btnReabrir_Click(object sender, EventArgs e)
        {

            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1022))
            {
                MessageBox.Show("No tiene permisos para realizar esta accion","Acceso Denegado");
                return;
            }
            //validamos que no este cerrada no en seguimineto
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_asesoria_cientificaTableAdapter();
            objEstado.FillBycod_estado_asesoria_cientifica(ds.estado_asesoria_cientifica, dsSpx1.asesoria_cientifica[0].cod_estado_asesoria_cientifica);
            if (ds.estado_asesoria_cientifica[0].cod_manual.Trim() != "4")
            {
                MessageBox.Show("Esta orden no esta cerrada!", "Error");
                return;
            }

            if (MessageBox.Show("Esta seguro de reabrir la asesoria cientifica y dejarla en seguimiento?", "Confirmacion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                reabrirAsesoria();
            }
        }

        private void btnCambiarCliente_Click(object sender, EventArgs e)
        {
            spProcesos.cientifica.frmCambiarCliente fr = new frmCambiarCliente();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                asesoria_cientificaTableAdapter1.UpdateCliente(fr.nitCliente, fr.codSucursal, fr.codContacto, codAsesoria);
                cargarASesoria();
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spHerramientas.frm
{
    public partial class frmCambiarSeriales : Form
    {
        public frmCambiarSeriales()
        {
            InitializeComponent();
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo fr = new spProcesos.Equipos.frmInformacionEquipo();
            fr.Serial = txtSerial.Text;
            fr.Show();
        }

        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                cargarSerial();
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cambiar el serial?\nEste cambio no se puede deshacer", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                equiposTableAdapter1.FillBySerial(dsSpx1.equipos, txtSerial.Text);
                Nullable<DateTime> fechaN = new Nullable<DateTime>();
                Nullable<int> enteroN = new Nullable<int>();
                SPControladoraDatos.dsSpx dsTmp = new SPControladoraDatos.dsSpx();
                dsTmp.EnforceConstraints = false;
                equiposTableAdapter1.FillBySerialExtricto(dsTmp.equipos, txtSerialNuevo.Text);
                //validamos si ya existe el serial nuevo esto en caso de que se halla intentado cambiar anteriormente y halla quedado inconcluso
                if (dsTmp.equipos.Count != 0)
                {
                    if(MessageBox.Show("El serial nuevo ya existe en la base de datos desea continuar?","confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No){
                    return;
                    }
                }else{
                    equiposTableAdapter1.Insert(
                        dsSpx1.equipos[0].codFabricante,
                        dsSpx1.equipos[0].codModelo,
                        txtSerialNuevo.Text,
                        (dsSpx1.equipos[0].IsfechaLlegadaNull()) ? fechaN : dsSpx1.equipos[0].fechaLlegada,
                        (dsSpx1.equipos[0].IsfechaSalidaNull()) ? fechaN : dsSpx1.equipos[0].fechaSalida,
                        (dsSpx1.equipos[0].IsfechaProximoManteNull()) ? fechaN : dsSpx1.equipos[0].fechaProximoMante,
                        (dsSpx1.equipos[0].IsfechaUltimoManteNull()) ? fechaN : dsSpx1.equipos[0].fechaUltimoMante,
                        (dsSpx1.equipos[0].IsnitClienteUbicaNull()) ? null : dsSpx1.equipos[0].nitClienteUbica.Trim(),
                        (dsSpx1.equipos[0].IscodSucursalUbicaNull()) ? null : dsSpx1.equipos[0].codSucursalUbica.Trim(),
                        (dsSpx1.equipos[0].IscodTipoServicioNull()) ? null : dsSpx1.equipos[0].codTipoServicio,
                        (dsSpx1.equipos[0].IsobservacionesUltimoManteNull()) ? "" : dsSpx1.equipos[0].observacionesUltimoMante,
                        (dsSpx1.equipos[0].IscodModalidadEquipoNull()) ? null : dsSpx1.equipos[0].codModalidadEquipo,
                        (dsSpx1.equipos[0].IscodEstadoLocalNull()) ? null : dsSpx1.equipos[0].codEstadoLocal,
                        (dsSpx1.equipos[0].IsfechaProximaProgramacionNull()) ? fechaN : dsSpx1.equipos[0].fechaProximaProgramacion,
                        (dsSpx1.equipos[0].IsfechaUltimoTrasladoNull()) ? fechaN : dsSpx1.equipos[0].fechaUltimoTraslado,
                        (dsSpx1.equipos[0].IsCodadicionalNull()) ? null : dsSpx1.equipos[0].Codadicional,
                        (dsSpx1.equipos[0].IsobservacionesUltimoManteNull()) ? "" : dsSpx1.equipos[0].observacionesUltimoMante,
                        ((dsSpx1.equipos[0].IscodTipoPropiedadNull()) ? enteroN : dsSpx1.equipos[0].codTipoPropiedad)
                        , ((dsSpx1.equipos[0].IsfechaCambioTipoPropiedadNull()) ? fechaN : dsSpx1.equipos[0].fechaCambioTipoPropiedad)
                        , ((dsSpx1.equipos[0].IsusuarioCambioNull()) ? "" : dsSpx1.equipos[0].usuarioCambio)
                        , ((dsSpx1.equipos[0].IsnitClienteReservaNull()) ? null : dsSpx1.equipos[0].nitClienteReserva)
                        , ((dsSpx1.equipos[0].IscodSucursalReservaNull()) ? null : dsSpx1.equipos[0].codSucursalReserva)
                        , ((dsSpx1.equipos[0].IscodModadlidadReservaNull()) ? null : dsSpx1.equipos[0].codModadlidadReserva)
                        , ((dsSpx1.equipos[0].IscodEstadoLocalReservaNull()) ? null : dsSpx1.equipos[0].codEstadoLocalReserva)
                        ,
                        (dsSpx1.equipos[0].IsnitClienteUbicacionRealNull()) ? null : dsSpx1.equipos[0].nitClienteUbicacionReal.Trim(),
                        (dsSpx1.equipos[0].IscodSucursalUbicaRealNull()) ? null : dsSpx1.equipos[0].codSucursalUbicaReal.Trim(),

                        ((dsSpx1.equipos[0].Iscreado_porNull()) ? ((int?)null) : dsSpx1.equipos[0].creado_por),
                        ((dsSpx1.equipos[0].Isfecha_creacionNull()) ? ((DateTime?)null) : dsSpx1.equipos[0].fecha_creacion),

                        ((dsSpx1.equipos[0].Iseliminado_porNull()) ? ((int?)null) : dsSpx1.equipos[0].eliminado_por),
                        ((dsSpx1.equipos[0].Isfecha_eliminacionNull()) ? ((DateTime?)null) : dsSpx1.equipos[0].fecha_eliminacion),

                         ((dsSpx1.equipos[0].Isrecreado_porNull()) ? ((int?)null) : dsSpx1.equipos[0].recreado_por),
                         ((dsSpx1.equipos[0].Isfecha_recreadoNull()) ? ((DateTime?)null) : dsSpx1.equipos[0].fecha_recreado),
                         ((dsSpx1.equipos[0].Ismotivo_eliminacionNull()) ? (null) : dsSpx1.equipos[0].motivo_eliminacion),
                         ((dsSpx1.equipos[0].Isultimo_responsableNull()) ? (null) : dsSpx1.equipos[0].ultimo_responsable)
                        );
                }
                SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
                //ahora pasamos todo al nuevo serial
                try
                {
                    string sql = "update contratosxEquipo set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update archivosXequipo set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update detalleProgramacionViajes set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update EntradaSalidaEquipos set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update equipoAuxiliar set serialEquipo ='" + txtSerialNuevo.Text + "' where serialEquipo ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update equipoAuxiliar set serialAuxiliar ='" + txtSerialNuevo.Text + "' where serialAuxiliar ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update LlamadaSoporte set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update logCambioUbicaciones set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update mantenimientosxContrato set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update seguimiento set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update solicitudServicio set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update ordenServicio set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update recoleccion set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    //cientifica
                    sql = "update asesoria_cientifica set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    //revision eneero 2015
                    sql = "update detalle_movimiento set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update dispositivosmedicionxordenservicio set serial_herramienta ='" + txtSerialNuevo.Text + "' where serial_herramienta ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update equipos_solicitud set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update equiposAuxiliaresxEntrada set serialAuxiliar ='" + txtSerialNuevo.Text + "' where serialAuxiliar ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update equiposxcontrato_consumo set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update existencia set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update LlamadaSoportePre set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update logVinculacionesDesvinculacionesContrato set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update OrdenPrestamo set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update revision_equipos set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);
                    sql = "update tarea_calendario set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    objData.ejecutarComando(sql);

                    sql = "update equipos set  fecha_eliminacion = null,eliminado_por=null where serial ='" + txtSerialNuevo.Text.Trim() + "'";
                    objData.ejecutarComando(sql);

                    //sql = "update recoleccion set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    //objData.ejecutarComando(sql);
                    //sql = "update recoleccion set serial ='" + txtSerialNuevo.Text + "' where serial ='" + txtSerial.Text.Trim() + "'";
                    //objData.ejecutarComando(sql);

                    sql = "delete equipos where serial ='" + txtSerial.Text + "'";
                    objData.ejecutarComando(sql);
                }catch(Exception ex){
                    MessageBox.Show("Error al cambiar el serial, informacion tecnica"+ex.Message);
                }


                MessageBox.Show("Se cambio el equipo de Serial satisfactoriamente!!!!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            //miramos que el serial lo tenga algun equipo
            SPControladoraDatos.dsSpx dsTmp = new SPControladoraDatos.dsSpx();
            dsTmp.EnforceConstraints = false;
            equiposTableAdapter1.FillBySerial(dsTmp.equipos, txtSerial.Text);
            if (dsTmp.equipos.Rows.Count ==0)
            {
                MessageBox.Show("El serial actual no existe en la base de datos.");
                e.Cancel = true;
                return;
            }
            cargarSerial();
        }

        private void cargarSerial() 
        {
            vistaEquipoTableAdapter1.FillBySerial(dsSpx1.vistaEquipo, txtSerial.Text);
            if (dsSpx1.vistaEquipo.Rows.Count > 0)
            {
                txtFabricante.Text = dsSpx1.vistaEquipo[0].nombrefabricante;
                txtModelo.Text = dsSpx1.vistaEquipo[0].nombremodelo;
            }
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            ////miramos que el serial nuevo no lo tenga ningun equipo
            //if (equiposTableAdapter1.GetDataBySerial(txtSerialNuevo.Text).Count > 0)
            //{
            //    MessageBox.Show("El serial por el cual desea cambiarlo ya lo tiene otro equipo.\nEl serial nuevo no debe existir en la base de datos.");
            //    e.Cancel = true;
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

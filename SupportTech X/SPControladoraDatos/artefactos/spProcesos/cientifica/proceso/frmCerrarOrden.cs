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
    public partial class frmCerrarOrden : Form
    {
        public frmCerrarOrden()
        {
            InitializeComponent();
        }
        public int codAsesoria { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            if (cmbInconvenientePor.SelectedValue == null || cmbInconvenientePor.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("La causa del inconveniente es obligatoria");
                return false;
            }
            //validamos se debe validar visita
            bool validaVisita = false;
            bool validaQC = false;
            seguimiento_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.seguimiento_asesoria_cientifica, codAsesoria);

            for (int k = 0; k < dsSpx1.seguimiento_asesoria_cientifica.Count; k++)
            { 
                accion_seguirxseguimiento_cientificaTableAdapter1.FillBycod_seguimiento_asesoria_cientifica(
                    dsSpx1.accion_seguirxseguimiento_cientifica,
                 dsSpx1.seguimiento_asesoria_cientifica[k].cod_seguimiento_asesoria_cientifica);
                if (dsSpx1.accion_seguirxseguimiento_cientifica.Count == 0) continue;

                for (int j = 0; j < dsSpx1.accion_seguirxseguimiento_cientifica.Count; j++)
                {

                    accion_seguir_cientificaTableAdapter1.FillBycod_accion_seguir_cientifica(
                        dsSpx1.accion_seguir_cientifica,
                        dsSpx1.accion_seguirxseguimiento_cientifica[j].cod_accion_seguir_cientifica);

                    if (!dsSpx1.accion_seguir_cientifica[0].Isind_qcNull())
                    {
                        if (dsSpx1.accion_seguir_cientifica[0].ind_qc)
                        {
                            validaQC = dsSpx1.accion_seguir_cientifica[0].ind_qc;
                        }
                    }

                    if (!dsSpx1.accion_seguir_cientifica[0].Isind_visitaNull())
                    {
                        if (dsSpx1.accion_seguir_cientifica[0].ind_visita)
                        {
                            validaVisita = dsSpx1.accion_seguir_cientifica[0].ind_visita;
                        }
                    }
                }

            }

            //if (validaVisita && calVisita.ValueObject == null)
            //{
            //    MessageBox.Show("La fecha de visita es obligatoria");
            //    return false;
            //}
            //if (validaQC && txtReporteCalidad.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("EL numero de reporte de calidad es obligatorio");
            //    return false;
            //}
            if (!rdNoConforme.Checked && !rdSiConforme.Checked)
            {
                MessageBox.Show("Debe ingresar la conformidad de la asesoria!");
                return false;
            }

            if (!rdNoControlCalidad.Checked && !rdSiControlCalidad.Checked)
            {
                MessageBox.Show("Debe ingresar si requiere control de calidad o no!");
                return false;
            }

            if (rdNoConforme.Checked && txtPorqueNoConforme.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar la causa de la no conformidad de la asesoria!");
                return false;
            }
            if (!rdNoSolucionado.Checked && !rdSiSolucionado.Checked)
            {
                MessageBox.Show("Debe ingresar si se soluciono o no la asesoria!");
                return false;
            }
            if (rdNoSolucionado.Checked && txtPorqueNoSolucionado.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar la causa de la no solucion de la asesoria!");
                return false;
            }

            if (rdNoConforme.Checked && txtPorqueNoConforme.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar observaciones de Conformidad Obligatoriamente!");
                return false;
            }

            if (txtPorqueNoSolucionado.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar observaciones de la Solucion Obligatoriamente!");
                return false;
            }
            //validamos que tenga por lo menos un seguimiento
            seguimiento_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.seguimiento_asesoria_cientifica, codAsesoria);
            if (dsSpx1.seguimiento_asesoria_cientifica.Count <= 0)
            {
                MessageBox.Show("Debe ingresar por lo menos un seguimiento antes de cerrar la Asesoria!");
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //actualiza el estado
            if (!validar()) return;
            //si el fallo es de equipo deberia seleccionar el serial
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            inconveniente_presentado_cientificaTableAdapter1.FillBycod_inconveniente_presentado_cientifica
                (ds.inconveniente_presentado_cientifica,
                int.Parse(cmbInconvenientePor.SelectedValue.ToString()));
            if (!ds.inconveniente_presentado_cientifica[0].Isind_equipoNull() && ds.inconveniente_presentado_cientifica[0].ind_equipo)
            {
                if (dsSpx1.asesoria_cientifica[0].IsserialNull() || dsSpx1.asesoria_cientifica[0].serial.Trim() == string.Empty)
                {
                    spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
                    fr.NitCliente = dsSpx1.asesoria_cientifica[0].nitCliente;
                    if (fr.ShowDialog() != DialogResult.OK) return;
                    equiposTableAdapter1.FillBySerial(dsSpx1.equipos,fr.Serial);
                    asesoria_cientificaTableAdapter1.UpdateEquipo(dsSpx1.equipos[0].codFabricante.Trim(),
                        dsSpx1.equipos[0].codModelo.Trim(), fr.Serial, codAsesoria);
                }       
            }//si el fallo es de reactivo debe ingresar obligado el reactivo y el lote del reactivo
            if (!ds.inconveniente_presentado_cientifica[0].Isind_reactivoNull() && ds.inconveniente_presentado_cientifica[0].ind_reactivo)
            {
                if (dsSpx1.asesoria_cientifica[0].Iscod_referencia_reactivoNull())
                {
                    frmAsociarReactivo fr = new frmAsociarReactivo();
                    if (fr.ShowDialog() != DialogResult.OK) return;
                    asesoria_cientificaTableAdapter1.UpdateReactivo(int.Parse(fr.CodReactivo),
                        fr.lote,fr.fechaVencimiento, codAsesoria);
                }

            }

            estado_asesoria_cientificaTableAdapter1.FillByCod_manual(ds.estado_asesoria_cientifica, "4");
            asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(ds.asesoria_cientifica, codAsesoria);
            int estActual = ds.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
            asesoria_cientificaTableAdapter1.UpdateCod_estado_asesoria_cientifica(estActual, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateCerrada_por(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, codAsesoria);
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            asesoria_cientificaTableAdapter1.UpdateFechaCierre(calCierre.Value, codAsesoria);
            ///si la orden fue cerrada en seguimiento debe tomar la fecha de cierre en seguimiento compo fecha
            if (!ds.asesoria_cientifica[0].Isfecha_cerrada_seguimientoNull())
            {
                asesoria_cientificaTableAdapter1.UpdateFechaCierre(ds.asesoria_cientifica[0].fecha_cerrada_seguimiento, codAsesoria);
            }
            if (calVisita.ValueObject != null)
            {
                asesoria_cientificaTableAdapter1.UpdateFecha_visita(calVisita.Value, codAsesoria);
            }else {
                asesoria_cientificaTableAdapter1.UpdateFecha_visita(null, codAsesoria);
            }
            asesoria_cientificaTableAdapter1.UpdateNumero_reporte_qc(txtReporteCalidad.Text, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateSolucionado(rdSiSolucionado.Checked, codAsesoria);
          //  if(rdNoSolucionado.Checked)
            {
                asesoria_cientificaTableAdapter1.UpdateNo_porque(txtPorqueNoSolucionado.Text, codAsesoria);

            }
            asesoria_cientificaTableAdapter1.UpdateConforme(rdSiConforme.Checked,"", codAsesoria);
          //  if (rdNoConforme.Checked)
            //{
            asesoria_cientificaTableAdapter1.UpdateRequiere_control_calidad(rdSiControlCalidad.Checked, codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateNo_conforme_porque(txtPorqueNoConforme.Text, codAsesoria);

            //}

            asesoria_cientificaTableAdapter1.UpdateCod_inconveniente_presentado_cientifica(int.Parse(cmbInconvenientePor.SelectedValue.ToString()), codAsesoria);
            asesoria_cientificaTableAdapter1.UpdateDias_solucion((int)numDiasSolcuonar.Value, codAsesoria);

            //vamos con los indicadores
            asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(ds.asesoria_cientifica, codAsesoria);
            if (!ds.asesoria_cientifica[0].Isfecha_primer_seguimientoNull())
            {
                DateTime f = ds.asesoria_cientifica[0].fecha_primer_seguimiento;
                DateTime f2 = obj.fechaServer;
                int t = (int)f2.Subtract(f).TotalDays;
                asesoria_cientificaTableAdapter1.UpdateIndicador_dos(t, codAsesoria);
            }
            if (!ds.asesoria_cientifica[0].Isfecha_cerrada_seguimientoNull())
            {
                DateTime f2 = obj.fechaServer;
                DateTime f = ds.asesoria_cientifica[0].fecha_cerrada_seguimiento;
                int t = (int)f2.Subtract(f).TotalDays;
                asesoria_cientificaTableAdapter1.UpdateIndicador_cuatro(t, codAsesoria);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        

        private void frmCerrarOrden_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            DateTime f= obj.fechaServer;
            calCierre.Value = f;
            calCierre.Enabled = false;
            calVisita.MonthCalendar.DisplayMonth = f;
            inconveniente_presentado_cientificaTableAdapter1.FillByActivo(dsSpx1.inconveniente_presentado_cientifica,true);
            asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);

            if (!dsSpx1.asesoria_cientifica[0].Isrequiere_control_calidadNull())
            {
                rdSiControlCalidad.Checked = dsSpx1.asesoria_cientifica[0].requiere_control_calidad;
                rdNoControlCalidad.Checked = !dsSpx1.asesoria_cientifica[0].requiere_control_calidad;
            }

            if (!dsSpx1.asesoria_cientifica[0].Isnumero_reporte_qcNull())
            {
                txtReporteCalidad.Text = dsSpx1.asesoria_cientifica[0].numero_reporte_qc;
            }


            txtAsesoriaNumero.Text = dsSpx1.asesoria_cientifica[0].cod_asesoria_cientifica.ToString();
            cmbInconvenientePor.SelectedValue = -1;
            decimal a=(decimal)calCierre.Value.Subtract(dsSpx1.asesoria_cientifica[0].fecha_respuesta_inicial).TotalDays;
            numDiasSolcuonar.Value = (a>0)?a:0;
            
        }

        private void rdNoSolucionado_CheckedChanged(object sender, EventArgs e)
        {
            //txtPorqueNoSolucionado.ReadOnly = !rdNoSolucionado.Checked;
            if (rdNoSolucionado.Checked)
            {
                cmbRazon.Visible = true;
                lblRazon.Visible = true;
            }
            else {
                cmbRazon.Visible = false;
                lblRazon.Visible = false;
            }
        }

        private void rdNoConforme_CheckedChanged(object sender, EventArgs e)
        {
            //txtPorqueNoConforme.ReadOnly = !rdNoConforme.Checked;
            if (rdNoSolucionado.Checked)
            {
                cmbRazon.Visible = true;
                lblRazon.Visible = true;
            }
            else
            {
                cmbRazon.Visible = false;
                lblRazon.Visible = false;
            }
        }

        private void calVisita_Validated(object sender, EventArgs e)
        {
                  }

        private void rdSiSolucionado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calCierre_Validated(object sender, EventArgs e)
        {
            if (calCierre.Value < dsSpx1.asesoria_cientifica[0].fecha_respuesta_inicial)
            {
                MessageBox.Show("La fecha de visita no puede ser menor que la fecha de respuesta inicial");
                return;
            }
            numDiasSolcuonar.Value = (decimal)calCierre.Value.Subtract(dsSpx1.asesoria_cientifica[0].fecha_respuesta_inicial).TotalDays;
 
        }

   
    }
}

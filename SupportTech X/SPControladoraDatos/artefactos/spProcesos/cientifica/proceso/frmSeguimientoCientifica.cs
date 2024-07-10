using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXdata.BD;

namespace spProcesos.cientifica.proceso
{
    public partial class frmSeguimientoCientifica : Form
    {
        public frmSeguimientoCientifica()
        {
            InitializeComponent();
        }

        public int codSeguimiento { set; get; }
        public int codAsesoria { set;get;}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (codSeguimiento == 0)
            {
                if (txtRich1.Text == string.Empty && txtObservaciones.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la descripcion del seguimiento!");
                    return;
                }
                seguimiento_asesoria_cientificaTableAdapter1.Insert(calFechaSeguimineto.fechaValue,
                    SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,txtObservaciones.Text ,  codAsesoria,txtRich1.Text);
                codSeguimiento = int.Parse(seguimiento_asesoria_cientificaTableAdapter1.verIdentity(SPXSeguridad.logica.sesion.LoginUsuarioAutenticado).ToString());
               if(lblPrimerSeguimiento.Visible)
               {
                   SPXdata.BD.DataConector obj = new DataConector();
                   DateTime f= obj.fechaServer;
                   asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica,codAsesoria);
                   int dias = (int)dsSpx1.asesoria_cientifica[0].fecha_sugerida.Subtract(f).TotalDays;
                   //calculamos los dias entre la primera fecha y el primer seguimiento
                   asesoria_cientificaTableAdapter1.UpdateIndicador_uno(dias, codAsesoria);
                   asesoria_cientificaTableAdapter1.UpdateFecha_primer_seguimiento(f, codAsesoria);
               }
            }
            //insertamos las acciones a seguir
            accion_seguirxseguimiento_cientificaTableAdapter1.DeleteBycod_seguimiento_asesoria_cientifica(codSeguimiento);
            for(int k=0;k<dsSpx1.accion_seguir_cientifica.Count;k++)
            {
                accion_seguirxseguimiento_cientificaTableAdapter1.Insert(codSeguimiento, dsSpx1.accion_seguir_cientifica[k].cod_accion_seguir_cientifica);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public bool editable = true;

        private void frmSeguimientoCientifica_Load(object sender, EventArgs e)
        {
            //verificamos que sea el primer seguimiento o no
            seguimiento_asesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(
                dsSpx1.seguimiento_asesoria_cientifica, codAsesoria);
            if (dsSpx1.seguimiento_asesoria_cientifica.Count <= 0)
            {
                lblPrimerSeguimiento.Visible = true;
            }else {
                lblPrimerSeguimiento.Visible = false;
            }

            if (!editable)
            {
                txtRegistadaPor.ReadOnly = true;
                txtRich1.Enabled = false;
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
            }
            
            txtRegistadaPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            calFechaSeguimineto.fechaValue = obj.fechaServer;
            if (codSeguimiento == 0)
            { 
                //cargamos por defecto las acciones a seguir por defecto en la llamada
                accion_seguirxasesoria_cientificaTableAdapter1.FillBycod_asesoria_cientifica(dsSpx1.accion_seguirxasesoria_cientifica, codAsesoria);
                for (int k = 0; k < dsSpx1.accion_seguirxasesoria_cientifica.Count; k++)
                {
                    dsSpx1.accion_seguir_cientifica.Merge(
                        accion_seguir_cientificaTableAdapter1.GetDataBycod_accion_seguir_cientifica(dsSpx1.accion_seguirxasesoria_cientifica[k].cod_accion_seguir_cientifica  )
                    );
                }
                //miramos si la llamada es en disponibilidad deberia permitir editar la fecha
                asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);
                if (dsSpx1.asesoria_cientifica.Count > 0)
                {
                    if (!dsSpx1.asesoria_cientifica[0].Isllamada_recibida_disponibilidadNull() && dsSpx1.asesoria_cientifica[0].llamada_recibida_disponibilidad)
                    {
                        calFechaSeguimineto.Enabled = true;
                    }
                }
                txtObservaciones.ReadOnly = false;
            }else
            if (codSeguimiento != 0)
            {
                //solo deberia ser visible un segimiento no se puede editar
                txtRegistadaPor.ReadOnly = true;
               // txtRich1.Enabled = false;
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                txtRich1.Enabled = false;
                //
                seguimiento_asesoria_cientificaTableAdapter1.FillBycod_seguimiento_asesoria_cientifica(dsSpx1.seguimiento_asesoria_cientifica,
                    codSeguimiento);
                txtObservaciones.Text = dsSpx1.seguimiento_asesoria_cientifica[0].observaciones;
                if (!dsSpx1.seguimiento_asesoria_cientifica[0].Isobservaciones_tablaNull())
                txtRich1.Text = dsSpx1.seguimiento_asesoria_cientifica[0].observaciones_tabla.Trim();

                calFechaSeguimineto.fechaValue = dsSpx1.seguimiento_asesoria_cientifica[0].fecha_seguimiento;
                clsTusuario1.FillBylogin(dsSPXSeguridad1.usuario, dsSpx1.seguimiento_asesoria_cientifica[0].realizado_por);

                if(dsSPXSeguridad1.usuario.Count > 0){
                    txtRegistadaPor.Text = dsSPXSeguridad1.usuario[0].nombre;
                }
                    txtObservaciones.ReadOnly = true;
                //--
                accion_seguirxseguimiento_cientificaTableAdapter1.FillBycod_seguimiento_asesoria_cientifica(dsSpx1.accion_seguirxseguimiento_cientifica, codSeguimiento);
                for (int k = 0; k < dsSpx1.accion_seguirxseguimiento_cientifica.Count; k++)
                {

                    dsSpx1.accion_seguir_cientifica.Merge(
                      accion_seguir_cientificaTableAdapter1.GetDataBycod_accion_seguir_cientifica(dsSpx1.accion_seguirxseguimiento_cientifica[k].cod_accion_seguir_cientifica)
                      );
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSeleccioneAccionASeguir fr = new frmSeleccioneAccionASeguir();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                if (dsSpx1.accion_seguir_cientifica.Select("cod_accion_seguir_cientifica=" + fr.codAccionElegida).Length <= 0)
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

            if (MessageBox.Show("Esta seguro de quitar la accion a seguir", "Confirmacion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                dsSpx1.accion_seguir_cientifica.Rows.Remove(
                    dsSpx1.accion_seguir_cientifica.Select("cod_accion_seguir_cientifica=" +
                    grdAccionesSeguir.Columns["cod_accion_seguir_cientifica"].Text)[0]
                    );
            }
        }

  
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmProgramarSeguimiento : Form
    {
        public frmProgramarSeguimiento()
        {
            InitializeComponent();
        }

        private int codSeguimiento = 0;
        private int codLlamada = 0;
        private string nitCliente = "";
        private string codContacto= "";


        public int CodSeguimiento { set { codSeguimiento = value; } get { return codSeguimiento; } }
        public int CodLlamada { set { codLlamada = value; } get { return codLlamada; } }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (calSugerida.fechaValueObject == null)
            {
                MessageBox.Show("Ingrese La fecha Sugerida!!!","Alerta");
                return;
            }
            int id = seguimientoTableAdapter1.verNextId().Value;

            
            Nullable<DateTime> fechaN= new Nullable<DateTime>();
            if (codLlamada != 0)
            {
                seguimientoTableAdapter1.Insert(
                    id, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, false, null, calSugerida.fechaValue,
                    fechaN, txtObservacionesIniciales.Text, "", codLlamada, 
                    dsSpx1.LlamadaSoporte[0].nitCliente
                    ,
                    (dsSpx1.LlamadaSoporte[0].IscodContactoNull()) ? null : dsSpx1.LlamadaSoporte[0].codContacto, txtSerial.Text);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmProgramarSeguimiento_Load(object sender, EventArgs e)
        {
            calSugerida.fechaValue = DateTime.Now;
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            if (codLlamada != 0)
            {
                dsSpx1.EnforceConstraints = false;
                //carga la informacion de la llamada
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
                txtCreadoPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
                if (dsSpx1.LlamadaSoporte.Rows.Count > 0)
                {
                
                    txtSerial.Text = dsSpx1.LlamadaSoporte[0].serial;
                  
                }
            }
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text;
            frm.ShowDialog();
        }
    }
}

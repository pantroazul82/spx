using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.programacion
{
    public partial class frmDetallesProgramacion : Form
    {
        public frmDetallesProgramacion()
        {
            InitializeComponent();
        }

        private string serial="";
        public String Serial { set { serial = value; } get { return serial; } }

        private double duracionMantenimiento = 0;

        string strTipoServicio = "";
        string strPrioridad = "";

        public string Descripcion { set { txtObservaciones.Text = value; } get { return txtObservaciones.Text; } }
        public bool confirmado { set { chkConfirmado.Checked = value; } get { return chkConfirmado.Checked; } }
        public string prioridad { set { strPrioridad = value; } get { return cmbPrioridad.SelectedValue.ToString(); } }
        public string tipoServicio { set { strTipoServicio = value; } get { return cmbTipoServicio.SelectedValue.ToString(); } }

        public string nombreprioridad {  get { return cmbPrioridad.Text; } }
        public string nombretipoServicio {  get { return cmbTipoServicio.Text; } }
        public DateTime horaInico { 
            set {
                dateTimePicker1.Value = value;
                cmbhoraLLegada.Text ="" +( value.Hour%12);
                cmbMinutoLlegada.Text = "" + value.Minute.ToString().PadLeft(2, '0');
                if (value.Hour > 11)
                    cmbAmpLlegada.Text = "PM";
                else
                    cmbAmpLlegada.Text = "AM";
            } 
            get {
                
                int hora = 0; int minuto = 0;
                int.TryParse(cmbhoraLLegada.Text, out hora);
                hora = hora % 12;
                if (cmbAmpLlegada.Text.Trim().ToUpper() == "PM")
                    hora += 12;
                int.TryParse(cmbMinutoLlegada.Text, out minuto);
                DateTime res = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, hora, minuto, 0);
                return res;
            } 
        }
        public DateTime horaFin
        {
            set
            {
                dateTimePicker1.Value = value;
                cmbHoraFin.Text = "" + (value.Hour % 12);
                cmbMinutoFin.Text = "" + value.Minute.ToString().PadLeft(2,'0');
                if (value.Hour > 11)
                    cmbAmPmFin.Text = "PM";
                else
                    cmbAmPmFin.Text = "AM";

            }
            get
            {

                int hora = 0; int minuto = 0;
                int.TryParse(cmbHoraFin.Text, out hora);
                hora = hora % 12;
                if (cmbAmPmFin.Text.Trim().ToUpper() == "PM")
                    hora += 12;
                int.TryParse(cmbMinutoFin.Text, out minuto);

                DateTime res = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, hora, minuto, 0);
                return res;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
//if (chkConfirmado.Checked) 
          //  {
                if (cmbAmpLlegada.Text.Trim() == string.Empty || cmbMinutoLlegada.Text.Trim() == string.Empty || cmbhoraLLegada.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Si va a confirmar debe ingresar la hora");
                    return;
                }
                if (cmbAmPmFin.Text.Trim() == string.Empty || cmbMinutoFin.Text.Trim() == string.Empty || cmbHoraFin.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Si va a confirmar debe ingresar la hora esperada de fin");
                    return;
                }
                if (horaFin < horaInico) 
                {
                    MessageBox.Show("La hora de fin no puede ser menor que la hora de inicio");
                    return;
                }
          //  } 
            DialogResult = DialogResult.OK;
        }

        private void frmDetallesProgramacion_Load(object sender, EventArgs e)
        {
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            tipoServicioTableAdapter1.Fill(dsSpx1.TipoServicio);
            prioridadesOrdenServicioTableAdapter1.FillByExternas(dsSpx1.prioridadesOrdenServicio);
            #region CARGAMOS LA INFORMACION DEL MODELO DEL EQUIPO

            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
            if (dsSpx1.equipos.Rows.Count > 0)
            {
                modelosTableAdapter1.FillByFabricanteModelo(dsSpx1.Modelos,
                    dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
                if (dsSpx1.Modelos.Rows.Count > 0)
                {
                    if (!dsSpx1.Modelos[0].IsduracionmantenimientoNull()) 
                    {
                        duracionMantenimiento = dsSpx1.Modelos[0].duracionmantenimiento;
                    }
                }
            }
#endregion
            cmbTipoServicio.SelectedValue = strTipoServicio;
            if (strPrioridad.Trim() == string.Empty)
            {
                cmbPrioridad.SelectedValue = -1;
            }
            else {
                cmbPrioridad.SelectedValue = strPrioridad;
            
            }
        }

        private void cmbhoraLLegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularHoraFin();
        }

        private void cmbMinutoLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularHoraFin();
        }

        private void cmbAmpLlegada_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularHoraFin();
        }

        private void calcularHoraFin()
        {
            //primero almacenamos la hora de inicio
            int hi = 0, mi = 0;
            int.TryParse(cmbhoraLLegada.Text, out hi);
            int.TryParse(cmbMinutoLlegada.Text, out mi);
            hi %= 12;
            if (cmbAmpLlegada.Text.Trim().ToUpper() == "PM")
            {
                hi += 12;
            }
            int.TryParse(cmbMinutoLlegada.Text, out mi);
            DateTime fecha = new DateTime(2008, 12, 24, hi, mi, 0);
            fecha = fecha.AddHours(duracionMantenimiento);
            //fecha.AddMinutes((duracionModelo-(int)duracionModelo)*60);
            if (fecha.Hour > 11)
            {
                cmbAmPmFin.Text = "PM";
                hi = fecha.Hour - 12;
                if (hi == 0) hi = 12;
            }
            else
            {
                hi = fecha.Hour;
                cmbAmPmFin.Text = "AM";
            }
            cmbHoraFin.Text = hi.ToString();
            cmbMinutoFin.Text = fecha.Minute.ToString().PadLeft(2, '0');
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Controles
{
    public partial class calFecha : UserControl
    {
        public calFecha()
        {
            InitializeComponent();
            fechaValueObject = null;
            calendario.MonthCalendar.DisplayMonth = DateTime.Now;
        }

        public DevComponents.Editors.DateTimeAdv.MonthCalendarItem MonthCalendar
        {
            get {return calendario.MonthCalendar;}
        }

        public object fechaValueObject
        {
            set
            {
                if (value == null)
                {
                    calendario.ValueObject = null;
                    cmbAmPm.Text = "";
                    cmbHoras.Text = "";
                    cmbMinutos.Text = "";
                    return;
                }

                calendario.Value =DateTime.Parse( value.ToString());
                if (calendario.Value.Hour >= 12) cmbAmPm.Text = "PM";
                else cmbAmPm.Text = "AM";
                cmbMinutos.Text = calendario.Value.Minute.ToString().PadLeft(2, '0');
                if (calendario.Value.Hour == 0 || calendario.Value.Hour == 12)
                    cmbHoras.Text = "12";
                else
                    cmbHoras.Text = "" + (calendario.Value.Hour % 12);
            }
            get
            {
                if (calendario.ValueObject == null)
                    return null;
                if (cmbAmPm.Text.Trim() == string.Empty || cmbHoras.Text.Trim() == string.Empty || cmbMinutos.Text.Trim() == string.Empty)
                    return null;
                DateTime fecha = calendario.Value;
                fecha = fecha.AddHours(fecha.Hour * (-1));
                fecha = fecha.AddMinutes(fecha.Minute * (-1));
                fecha = fecha.AddSeconds(fecha.Second * (-1));
                fecha = fecha.AddMilliseconds(fecha.Millisecond * (-1));
                int tmp = 0;
                int.TryParse(cmbHoras.Text, out tmp);
                tmp %= 12;
                if (cmbAmPm.Text == "PM") tmp += 12;
                fecha = fecha.AddHours((double)tmp);
                int.TryParse(cmbMinutos.Text, out tmp);
                fecha = fecha.AddMinutes((double)tmp);
                return fecha;
            }
        }


        public DateTime fechaValue
        {
            set
            {
               
                calendario.Value = value;
                if (value.Hour >= 12) cmbAmPm.Text = "PM";
                else cmbAmPm.Text = "AM";
                cmbMinutos.Text =value.Minute.ToString().PadLeft(2,'0');
                if (value.Hour == 0 || value.Hour ==12)
                    cmbHoras.Text = "12";
                else
                    cmbHoras.Text = ""+(value.Hour % 12);
            }
            get
            {
                DateTime fecha = calendario.Value;
                fecha = fecha.AddHours(fecha.Hour * (-1));
                fecha = fecha.AddMinutes(fecha.Minute * (-1));
                fecha = fecha.AddSeconds(fecha.Second * (-1));
                fecha = fecha.AddMilliseconds(fecha.Millisecond * (-1));
                int tmp = 0;
                int.TryParse(cmbHoras.Text, out tmp);
                tmp %= 12;
                if (cmbAmPm.Text == "PM") tmp += 12;
                fecha = fecha.AddHours((double)tmp);
                int.TryParse(cmbMinutos.Text, out tmp);
                fecha = fecha.AddMinutes((double)tmp);
                return fecha;
            }
        }

        private void calFecha_Load(object sender, EventArgs e)
        {
 
        }

        private void calendario_ValueObjectChanged(object sender, EventArgs e)
        {
            if (calendario.ValueObject == null) 
            {
                cmbMinutos.SelectedIndex = -1;
                cmbAmPm.SelectedIndex = -1;
                cmbHoras.SelectedIndex = -1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spHorarios
{
    public partial class frmResumen : Form
    {
        public frmResumen()
        {
            InitializeComponent();
        }

        public int codOrdenServicio;
        public string cuerpo { set { txtCuerpo.Text = value.Replace("@i@", "\r\n"); } }
        public string asunto { set { txtAsunto.Text = value; } }
        public string ubicacion { set { txtUbicacion.Text = value; } }
        DateTime inicio, fin;
public DateTime fechaInicio{set{inicio=value;}get{return inicio;}}
    public DateTime fechaFin{set{fin=value;}get{return fin;}}


        private void frmResumen_Load(object sender, EventArgs e)
        {
            calInicio.fechaValue = inicio;
            calFin.fechaValue = fin;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnVerOrden_Click(object sender, EventArgs e)
        {
            //verificamos si es orden de servicio
            
            if (txtCuerpo.Text.IndexOf("actividad:") == 0 && txtAsunto.Text.IndexOf("actividad:") == 0)
            {
                SpFrm.actividades.frmNuevaActividad fr = new SpFrm.actividades.frmNuevaActividad();
                fr.codActividad = codOrdenServicio;
                fr.ShowDialog();
            }else { 
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = codOrdenServicio.ToString();
            fr.Show();
            }
        }
    }
}

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
    public partial class frmSolicitudIngenieria : Form
    {
        public frmSolicitudIngenieria()
        {
            InitializeComponent();
        }
        public int codLlamada { set; get; }
        public int codAsesoria { set; get; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);

            int cd=int.Parse(llamadaSoportePreTableAdapter1.verNextId().ToString());
            SPXdata.BD.DataConector obj=new SPXdata.BD.DataConector();
            DateTime fecha=obj.fechaServer;
            llamadaSoportePreTableAdapter1.Insert(cd, "NUEVA", fecha, true,
                dsSpx1.asesoria_cientifica[0].nitCliente,
                dsSpx1.asesoria_cientifica[0].codSucursal,
                dsSpx1.asesoria_cientifica[0].codContacto,
                dsSpx1.asesoria_cientifica[0].infAdicionalContacto,
                dsSpx1.asesoria_cientifica[0].serial, null,SPXSeguridad.logica.sesion.LoginUsuarioAutenticado  ,null, null, null,
                txtFallasReportadas.Text, txtObjetoServicio.Text, null, "", null, null, null, null, null,null,null);




             //   dsSpx1.asesoria_cientifica[0].codSucursal, null, null, 1, null, txtObjetoServicio.Text,
             //   txtFallasReportadas.Text, "", null, null, null,codAsesoria);


            codLlamada = cd;
            asesoria_cientificaTableAdapter1.UpdateIdLlamadaSoportePre(codLlamada, codAsesoria);
            MessageBox.Show("Se genero la nueva llamada con codigo "+cd.ToString()+"!","Solicitud Generada");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

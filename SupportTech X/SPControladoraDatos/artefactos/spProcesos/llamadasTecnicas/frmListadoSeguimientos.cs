using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmListadoSeguimientos : Form
    {
        public frmListadoSeguimientos()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }
        int busq = 0;

        private void frmListadoSeguimientos_Load(object sender, EventArgs e)
        {

            cmbCampo.SelectedIndex = 0;
            //cargamos todos los Seguimientos no realizados o por hacer ordenados por fecha
            string sql = "select * from seguimiento where realizado is null or realizado = 0 order by fechaSugerida";
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.EnforceConstraints = false;
            dsSpx1.seguimiento.Merge(objData.ejecutarConsulta(sql).Tables[0]);
            notificar();
        }

        private void buscar() 
        {
            busq = 1;
            string sql = "select * from seguimiento where";
            switch(cmbCampo.Text.Trim())
            {
                case "Cod Seguimiento": { sql += " idSeguimiento like '" + txtFiltro.Text + "%'"; break; }
                case "Serial": { sql += " serial like '"+txtFiltro.Text+"%'"; break; }
                case "Nit Cliente": { sql += " nitCliente like '" + txtFiltro.Text + "%'"; break; }
                
            }
            dsSpx1.seguimiento.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.seguimiento.Merge(objData.ejecutarConsulta(sql).Tables[0]);
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void btnVerLlamada_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["idSeguimiento"].Text.Trim() == string.Empty) return;
            spProcesos.llamadasTecnicas.frmAgregarSeguimiento frm = new frmAgregarSeguimiento();
            frm.IdSeguimiento = int.Parse(grdDatos.Columns["idSeguimiento"].Text.Trim());
            frm.CodLlamada = int.Parse(grdDatos.Columns["idLlamadaSoporte"].Text.Trim());
            if (frm.ShowDialog() == DialogResult.OK) 
            {
                if (busq == 0) {
                    string sql = "select * from seguimiento where realizado is null or realizado = 0 order by fechaSugerida";
                    dsSpx1.seguimiento.Clear();
                    SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
                    dsSpx1.seguimiento.Merge(objData.ejecutarConsulta(sql).Tables[0]);
                } else if (busq == 1) {
                    buscar();
                }
                else if (busq == 2) 
                {
                    seguimientoTableAdapter1.FillByFecha(dsSpx1.seguimiento, calFecha.Value);
                } 
                
            }
        }

        private void calFecha_ValueChanged(object sender, EventArgs e)
        {
            if(calFecha.ValueObject != null)
            seguimientoTableAdapter1.FillByFecha(dsSpx1.seguimiento, calFecha.Value);
            busq = 2;
        }

        List<string> notificados = new List<string>();



        private void timer1_Tick(object sender, EventArgs e)
        {
            notificar();
        }

        private void notificar(){
            if (!chkNotificacionesACtivas.Checked) return;
            string sql = @"select idSeguimiento,obsIniciales,idLLamadaSoporte from seguimiento where realizado =0
                           and abs(datediff(minute,fechaSugerida,getdate())) <5";
            if (notificados.Count > 0)
            {
                string a = "";
                for (int k = 0; k < notificados.Count; k++)
                {
                    a += (notificados[k] + ",");
                }
                sql = sql + " and idSeguimiento not in ("+a.Substring(0,a.Length-1)+")";
            }
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            System.Data.DataTable tb= obj.ejecutarConsulta(sql).Tables[0];

            for (int k = 0; k < tb.Rows.Count; k++)
            {
                notificados.Add(tb.Rows[k]["idSeguimiento"].ToString());
                alertControl1.Show(this, "Seguimiento Programado", "La llamada "
                    + tb.Rows[k]["idLLamadaSoporte"].ToString() +" tiene un seguimiento programado que no se ha realizado."
                    + tb.Rows[k]["obsIniciales"].ToString());
            }

        }
    }
}

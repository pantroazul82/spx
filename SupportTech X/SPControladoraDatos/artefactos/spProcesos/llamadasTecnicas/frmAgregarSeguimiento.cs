using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmAgregarSeguimiento : Form
    {
        public frmAgregarSeguimiento()
        {
            InitializeComponent();
        }

        int idSeguimiento = 0;
        public int IdSeguimiento { set { idSeguimiento = value; } get { return idSeguimiento; } }
        private int codLlamada = 0;
        private string nitCliente = "";
        private string codContacto = "";
        private string serial = "";

        public int CodLlamada { set { codLlamada = value; } get { return codLlamada; } }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarSeguimiento_Load(object sender, EventArgs e)
        {
            calRealizado.fechaValue = DateTime.Now;
            calSugerida.fechaValue = DateTime.Now;
            
            dsSpx1.EnforceConstraints = false;
            clsTusuario1.FillByPermiso(dsSPXSeguridad1.usuario, 1064);
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            txtCreadoPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
            
            if (codLlamada != 0)
            {
#region carga la informacion que viene de la llamada
                llamadaSoporteTableAdapter1.FillByidLlamadaSoporte(dsSpx1.LlamadaSoporte, codLlamada);
               

           
#endregion
                if(idSeguimiento !=0)
                {
                    seguimientoTableAdapter1.FillByidSeguimiento(dsSpx1.seguimiento, idSeguimiento);
                    if (dsSpx1.seguimiento.Rows.Count > 0)
                    {
                        txtCreadoPor.Text = dsSpx1.seguimiento[0].creadoPor;
                        txtSerial.Text = dsSpx1.seguimiento[0].serial;
                       
                        if(!dsSpx1.seguimiento[0].IsfechaSugeridaNull())calSugerida.fechaValue = dsSpx1.seguimiento[0].fechaSugerida;
                        txtObsFinales.Text=  dsSpx1.seguimiento[0].obsFinales;
                        txtObservacionesIniciales.Text = dsSpx1.seguimiento[0].obsIniciales;
                        calRealizado.Enabled = false;
                        if (dsSpx1.seguimiento[0].realizado)
                        {
                            rdPendiente.Checked = false;
                            rdRealizado.Checked = true;

                            rdPendiente.Enabled = false;
                            rdRealizado.Enabled = true;
                            cmbRealizadoPor.Enabled = false;
                            btnlimpiaPor.Enabled = false;
                            calRealizado.Enabled = false;
                            if(!dsSpx1.seguimiento[0].IsfechaRealizadoNull())calRealizado.fechaValue = dsSpx1.seguimiento[0].fechaRealizado;
                        }else{
                            rdRealizado.Checked = false;
                            rdPendiente.Checked = true;
                            calRealizado.fechaValueObject = null;
                        }
                        if(!dsSpx1.seguimiento[0].IsrealizadoPorNull())
                        cmbRealizadoPor.SelectedValue = dsSpx1.seguimiento[0].realizadoPor;
                    
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnlimpiaPor_Click(object sender, EventArgs e)
        {
            cmbRealizadoPor.SelectedValue = "";
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (calSugerida.fechaValueObject == null)
            {
                MessageBox.Show("Debe sugerir una fecha para el seguimiento!");
                return;
            }
            if (rdRealizado.Checked) 
            {

                if (cmbRealizadoPor.SelectedValue == null || cmbRealizadoPor.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Debe ingresar quien realizo el seguimiento.");
                    return;
                }
              
            }

            if (idSeguimiento == 0)
            {
                idSeguimiento = seguimientoTableAdapter1.verNextId().Value;
               
                seguimientoTableAdapter1.Insert(idSeguimiento, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, rdRealizado.Checked,
                    (cmbRealizadoPor.SelectedValue == null || cmbRealizadoPor.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbRealizadoPor.SelectedValue.ToString(),
                    calSugerida.fechaValue,
                    rdRealizado.Checked?DateTime.Now:(DateTime?)null,
                    txtObservacionesIniciales.Text, txtObsFinales.Text, codLlamada, 
                    dsSpx1.LlamadaSoporte[0].nitCliente, dsSpx1.LlamadaSoporte[0].codContacto, txtSerial.Text);
            }else{
                //miramos si ya fue creado anteriormente preguntamos si desea marcarlo como realizado
                bool rea = rdRealizado.Checked;
                if (!rea)
                {
                    if (MessageBox.Show("Desea marcar este seguimiento como realizado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        rea = true;
                    }
                }

                seguimientoTableAdapter1.UpdateQuery(dsSpx1.seguimiento[0].creadoPor, rea,
                      (cmbRealizadoPor.SelectedValue == null || cmbRealizadoPor.SelectedValue.ToString().Trim() == string.Empty) ? null : cmbRealizadoPor.SelectedValue.ToString(),
                        calSugerida.fechaValue,
                        rea?DateTime.Now:(DateTime?)null
                        , txtObservacionesIniciales.Text, txtObsFinales.Text, codLlamada, dsSpx1.LlamadaSoporte[0].nitCliente, dsSpx1.LlamadaSoporte[0].codContacto, txtSerial.Text, idSeguimiento);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text;
            frm.ShowDialog();
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmAceptacionCliente : Form
    {
        public frmAceptacionCliente()
        {
            InitializeComponent();
        }

        private DateTime fechaInicio=new DateTime();
        private DateTime fechaFin=new DateTime();
        public DateTime FechaInicio { get { return fechaInicio; } }
        public DateTime FechaFin { get { return fechaFin; } }
        //---------------------//-------------------------------//--------------------------------//
        public string hotaInicio   { set { cmbHoraLlegadaCliente.Text = value; } }
        public string hotaFin      { set { cmbHoraSalidaCliente.Text = value; } }
        public string minutoInicio { set { cmbMinutosLlegadaCliente.Text = value; } }
        public string minutoFin    { set { cmbMinSalidaCliente.Text = value; } }
        public string ampmInicio   { set { cmbAmPmLlegadaCliente.Text = value; } }
        public string ampmFin      { set { cmbAmPMSalidaCliente.Text = value; } }

        private bool comprobanteAceptacionNuevo=true;
        public bool ComprobanteAceptacionNuevo { set { comprobanteAceptacionNuevo = value; } get { return comprobanteAceptacionNuevo; } }

        //
        private int codOrdenServicio = 0;
        public int CodOrdenservicio { set { codOrdenServicio = value; } get { return codOrdenServicio; } }
        public string nombreUsuario { get { return txtUsuarioCliente.Text; } set { txtUsuarioCliente.Text = value; } }

        private byte[] comprobanteArchivo =null;

        public byte[] ComprobanteArchivo { get { return comprobanteArchivo; } }
        private string nombreArchivo = "";
        public string NombreArchivo { get { return nombreArchivo; } }


        private string codTipoComprobante = "";
        public string CodTipoComprobante { get { return codTipoComprobante; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            if (txtUsuarioCliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre  del usuario que firmo la orden de aceptacion es obligatoria");
                return false;
            }
            if (cmbAmPmLlegadaCliente.Text.Trim() == string.Empty || cmbAmPMSalidaCliente.Text.Trim() == string.Empty ||
                cmbHoraLlegadaCliente.Text.Trim() == string.Empty || cmbHoraSalidaCliente.Text.Trim() == string.Empty ||
                cmbMinutosLlegadaCliente.Text.Trim() == string.Empty || cmbMinSalidaCliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Las Horas de entrada y salida son obligatorias");
                return false;
            }
            //validamos que la hora de salida no se amenor que la hora de entrada
            return true;
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            int hora = 0;
            int minuto = 0;
            
            minuto   = int.Parse(cmbMinutosLlegadaCliente.Text);
            hora = int.Parse(cmbHoraLlegadaCliente.Text);
            hora %= 12;
            if (cmbAmPmLlegadaCliente.Text.Trim().ToUpper() == "PM")
            {
                hora += 12;
            }
            fechaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, minuto, 0);
            
            minuto = int.Parse(cmbMinSalidaCliente.Text);
            hora = int.Parse(cmbHoraSalidaCliente.Text);
            hora %= 12;
            
            if (cmbAmPMSalidaCliente.Text.Trim().ToUpper() == "PM")
            {
                hora += 12;
            }
            fechaFin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hora, minuto, 0);
            if (fechaFin < fechaInicio) 
            {
                MessageBox.Show("La fecha de Inicio no puede ser mayor que la fecha de fin!!!!");
                return;
            }
            if (groupBox1.Visible)
            {
                nombreArchivo = "";
                comprobanteArchivo = null;
            }

            //--
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void frmAceptacionCliente_Load(object sender, EventArgs e)
        {
            groupBox1.Location = groupBox2.Location;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            //aca miramos si tiene un comprobante digital y  lo mostramos

            comprobantesAceptacionOrdenservicioTableAdapter1.FillByInfAdi(
                dsSpx1.comprobantesAceptacionOrdenservicio ,codOrdenServicio  );
            if (dsSpx1.comprobantesAceptacionOrdenservicio.Rows.Count > 0)
            {
                try
                {
                    comprobanteArchivo = (byte[])dsSpx1.comprobantesAceptacionOrdenservicio[0].datos;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(comprobanteArchivo);
                    pictureBox1.Image = Image.FromStream(ms);
                    codTipoComprobante = dsSpx1.comprobantesAceptacionOrdenservicio[0].codTipoComprobante;
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;

                    txtTipoComprobante.Text = tipoComprobanteTableAdapter1.verNombre(
                        dsSpx1.comprobantesAceptacionOrdenservicio[0].codTipoComprobante);
                    comprobanteAceptacionNuevo = false;
                }catch(Exception){}
                
            }
        }

        private void btnComprobantesAceptacion_Click(object sender, EventArgs e)
        {
            frm.frmAgregarFirma fr = new spProcesos.ordenesTrabajo.frm.frmAgregarFirma();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                frmTipoComprobante frmTipo = new frmTipoComprobante();
                if (frmTipo.ShowDialog() != DialogResult.OK) return;

                try{
                    comprobanteAceptacionNuevo = true;
                    nombreArchivo = "Firma:" + codOrdenServicio+" "+DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Month;
                    if (nombreArchivo.Length > 150) nombreArchivo = nombreArchivo.Substring(150);
                
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    fr.firma.Save(ms,System.Drawing.Imaging.ImageFormat.Png );
                    comprobanteArchivo =  ms.ToArray();
                    //lo insertamos en la base de datos
                    int cod = int.Parse(comprobantesAceptacionOrdenservicioTableAdapter1.verNextId(codOrdenServicio).ToString());
                    comprobantesAceptacionOrdenservicioTableAdapter1.Insert
                        (cod, codOrdenServicio, "infadi", frmTipo.codTipoComprobante, comprobanteArchivo,nombreArchivo);
                    
                    codTipoComprobante = frmTipo.codTipoComprobante;
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    txtTipoComprobante.Text = frmTipo.NombreTipoComprobante;
                    pictureBox1.Image = fr.firma;

                }catch(Exception ){
                
                }

            }
        }

        private void btnQuitarComprobante_Click(object sender, EventArgs e)
        {
            nombreArchivo = "";
            comprobanteArchivo = null;
            pictureBox1.Image = null;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            comprobantesAceptacionOrdenservicioTableAdapter1.Deleteinfadi(codOrdenServicio);
            comprobanteAceptacionNuevo = true;
            txtTipoComprobante.Text = "";
            pictureBox1.Image = null;
            //lo eliminamos de la base de datos

        }

        private void cmbHoraLlegadaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHoraSalidaCliente.Text.Trim() == string.Empty)
            cmbHoraSalidaCliente.Text = cmbHoraLlegadaCliente.Text;
        }

        private void cmbMinutosLlegadaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMinSalidaCliente.Text.Trim() == string.Empty)
            cmbMinSalidaCliente.Text = cmbMinutosLlegadaCliente.Text;
        }

        private void cmbAmPmLlegadaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAmPMSalidaCliente.Text.Trim() == string.Empty)
            cmbAmPMSalidaCliente.Text=cmbAmPmLlegadaCliente.Text ;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}

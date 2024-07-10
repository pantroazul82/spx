using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SPXFrmAnimacion
{
    public partial class frmEfectoProgreso : Form
    {
        public frmEfectoProgreso()
        {
            InitializeComponent();
        }

        private DateTime fechaUltimoAumentoAutomatico = DateTime.Now;
        public bool aumentoAutomatico = false;
        public int total =0;
        public int progeso = 0;
        /// <summary>
        /// entre mas pequeno mas rapido
        /// </summary>
        public int velocidadAumentoAutomatico = 500;
        /// <summary>
        /// 
        /// </summary>
        public int incremento_automatico = 3;
        public string texto = "Cargando...";
        public bool Activo = true;


        private void frmEfecto_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);
            //   timer1.Enabled = true;
        }

        public void animacion()
        {
            while (Activo)
            {
                try{
                this.Activate();
                progressBarX1.Maximum = total;
                //reflectionLabel1.Text = texto;
                label1.Text = texto;
                progressBarX1.Value = progeso;
                if (aumentoAutomatico) 
                {
                    if (DateTime.Now.Subtract(fechaUltimoAumentoAutomatico).TotalMilliseconds > velocidadAumentoAutomatico)
                    {

                        progeso+=incremento_automatico;
                        
                        fechaUltimoAumentoAutomatico = DateTime.Now;
                        if(progeso>total)
                            progeso=total;
                    }
                }

                    Application.DoEvents();
                }catch(Exception){
                    this.Close();
                }
                System.Threading.Thread.Sleep(120);
            }
            this.Close();
        }

        public void animacionEnd()
        {
            Activo = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Activo = false;
        }
    }
}
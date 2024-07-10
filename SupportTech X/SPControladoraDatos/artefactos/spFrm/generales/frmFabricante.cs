using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace SpFrm.generales
{
    public partial class frmFabricante : CgDataFrm.frmModelo
    {
        public frmFabricante()
        {
            InitializeComponent();
        }

        private void btnSbrLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image im = new Bitmap(openFileDialog1.FileName);
                    picLogo.Image = im;
                    picLogo.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void btnGuardarLogo_Click(object sender, EventArgs e)
        {
            if (cgDataControler1.verValor("logo") != null && picLogo.Image != null)
            {
                saveFileDialog1.FileName = "*.jpg";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] arr = (byte[])cgDataControler1.verValor("logo");
                        FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                        BinaryWriter writer = new BinaryWriter(stream);
                        writer.Write(arr);
                        writer.Close();
                        MessageBox.Show("Se guardo el Archivo Satisfactoriamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo " + ex.Message);
                    }
                }
            }
        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {
            fabricanteTableAdapter1.Fill(dsSpx1.fabricante);
            cgDataControler1.TableAdapter = fabricanteTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "fabricante"] as CurrencyManager);
        }

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            btnSbrLogo.Enabled = cgDataControler1.EstadoControles;
        }
    }
}


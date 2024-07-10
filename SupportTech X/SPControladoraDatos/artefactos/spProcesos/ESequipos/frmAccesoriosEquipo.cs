using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmAccesoriosEquipo : CgDataFrm.frmModelo
    {
        public frmAccesoriosEquipo()
        {
            InitializeComponent();
        }

        bool eventosEncendidos = true;

        private void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            eventosEncendidos = false;
            if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty)
            {
                dsSpx1.Modelos.Clear();
            }else {
                modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx1.Modelos, cmbFabricante.SelectedValue.ToString());
                cmbModelo.SelectedValue = "-1";
            }
            eventosEncendidos = true;
        }

        private void btnLimpiarfabricante_Click(object sender, EventArgs e)
        {
            cmbFabricante.SelectedValue = "";
        }

        private void btnLimpiarModelo_Click(object sender, EventArgs e)
        {
            cmbModelo.SelectedValue = "";
        }

        private void frmAccesoriosEquipo_Load(object sender, EventArgs e)
        {
            eventosEncendidos = false;
            accesoriosEquipoTableAdapter1.Fill(dsSpx1.accesoriosEquipo);
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            cgDataControler1.TableAdapter = accesoriosEquipoTableAdapter1;
            cgDataControler1.cmTabla = (BindingContext[dsSpx1,"accesoriosEquipo"] as CurrencyManager);

            eventosEncendidos = true;
            
            //cargarDatos();
        }

        private void cargarDatos() 
        {
            eventosEncendidos = false;
            object objFabricante = cgDataControler1.verValor("codFabricante");
            object objModelo = cgDataControler1.verValor("codModelo");
            cmbFabricante.SelectedValue = -1;
            cmbModelo.SelectedValue = -1;



            if (objFabricante == null || objFabricante == System.DBNull.Value) { eventosEncendidos = true; return; }
            //cargamos las zonas del pais
            cmbFabricante.SelectedValue = objFabricante.ToString();
            modelosTableAdapter1.FillByCodFabricanteComboBox(dsSpx1.Modelos, objFabricante.ToString());
            if (objModelo == null || objModelo == System.DBNull.Value) { eventosEncendidos = true; return; }
            cmbModelo.SelectedValue = objModelo.ToString();
            eventosEncendidos = true;
        }

        private void guardarDatos()
        {
            if (cmbFabricante.SelectedValue != null && cmbFabricante.SelectedValue.ToString().Trim() != string.Empty)
            {
                cgDataControler1.asignarValor("codFabricante", cmbFabricante.SelectedValue);
                if (cmbModelo.SelectedValue != null && cmbModelo.SelectedValue.ToString().Trim() != string.Empty)
            {
                cgDataControler1.asignarValor("codModelo", cmbModelo.SelectedValue);
            }
            else
            {
                cgDataControler1.asignarValor("codModelo", DBNull.Value);
            }
            }
            else
            {
                cgDataControler1.asignarValor("codFabricante", DBNull.Value);
                cgDataControler1.asignarValor("codModelo", DBNull.Value);
            }
            
        }


        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.ReadOnly || !txtCodigo.Enabled)
            cargarFoto();
            cargarDatos();
        }

        #region zona  de fotografia
        bool cambioFoto = false;
        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image im = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                picFoto.Image = im;
                picFoto.Tag = openFileDialog1.FileName;
                cambioFoto = true;
            }
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {
            if (picFoto.Image == null) return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image.Save(saveFileDialog1.FileName);
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void btnAbrirFoto_Click(object sender, EventArgs e)
        {
            if (picFoto.Image == null) return;
            string ruta = "";
            ruta = System.IO.Path.GetTempFileName();
            ruta = System.IO.Path.GetFileNameWithoutExtension(ruta) + ".png";
            picFoto.Image.Save(ruta);

            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(ruta);
            System.Media.SystemSounds.Exclamation.Play();

        }


        /// <summary>
        /// Carga la foto de accesorios desde la tabla de fotografias
        /// </summary>
        private void cargarFoto()
        {
            cambioFoto = false;
            if (cgDataControler1.verValor("codFoto") == System.DBNull.Value
                || cgDataControler1.verValor("codFoto") == null
                || long.Parse(cgDataControler1.verValor("codFoto").ToString()) == 0)
            {
                picFoto.Image = null;
                return;
            }

            int codFoto = int.Parse(cgDataControler1.verValor("codFoto").ToString());

            fotografiaTableAdapter1.FillByCodFotografia(dsSpx1.fotografia, codFoto);
            if (dsSpx1.fotografia.Rows.Count > 0)
            {
                byte[] arr = (byte[])dsSpx1.fotografia[0].archivo;
                System.IO.Stream stream = new System.IO.MemoryStream(arr);
                Image im = Image.FromStream(stream);
                picFoto.Image = im;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void guardarFoto()
        {
            if (picFoto.Image == null) return;//no tiene ninguna imagen
            // En este if miramos si no tenia codigo de fotografia si no tenia codigo de fotografia
            // significa que la fotografia es nueva y la inserta
            if (cgDataControler1.verValor("codFoto") == System.DBNull.Value
                || cgDataControler1.verValor("codFoto") == null
                || long.Parse(cgDataControler1.verValor("codFoto").ToString()) == 0)
            {
                //aca debemos guardar la foto por si la cambiaron

                int id = fotografiaTableAdapter1.verNextId().Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                fotografiaTableAdapter1.Insert(id, picFoto.Tag.ToString(), ms.ToArray());
                cgDataControler1.asignarValor("codFoto", id);
            }
            else
            {
                //en este if ya tenia fotogafia ahora miramos si cambio eliminamos la anterior y guardamos la nueva
                //para saber si cambio que hacemos
                if (cambioFoto)
                {
                    int id = int.Parse(cgDataControler1.verValor("codFoto").ToString());
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    fotografiaTableAdapter1.UpdateQuery(picFoto.Tag.ToString(), ms.ToArray(),
                         id);
                }
            }
        }

        #endregion

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            btnSubirFoto.Enabled = cgDataControler1.EstadoControles;
            btnLimpiarfabricante.Enabled = cgDataControler1.EstadoControles;
            btnLimpiarModelo.Enabled = cgDataControler1.EstadoControles;
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            guardarFoto();
            guardarDatos();
        }
    }
}

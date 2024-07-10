using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.generales
{
    public partial class frmRepuestos : CgDataFrm.frmModelo
    {
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            repuestosTableAdapter1.Fill(dsSpx1.repuestos);
            cgDataControler1.TableAdapter = repuestosTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "repuestos"] as CurrencyManager);
        }

        #region archivos asociados
        private void ribbonControlDataFrm_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (ribbonControlDataFrm.SelectedRibbonTabItem.Text.ToUpper().IndexOf("ARCHIVO") >= 0)
            {

                if (txtCodigo.ReadOnly == true || txtCodigo.Enabled == false)
                {
                    string sql = "SELECT codRepuesto, codArchivo, nombreArchivo, "+
                                 " cast('76534567890' as image) archivo, descripcion FROM dbo.archivosxRepuesto where codRepuesto='"+txtCodigo.Text+"'";
                    SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
                    dsSpx1.archivosxRepuesto.Merge(
                    obj.ejecutarConsulta(sql).Tables[0]
                    );
                    
                }
            }
        }
        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null ||
       grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            try
            {
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    grdArchivos.Columns["nombreArchivo"].Value.ToString());

                System.IO.FileStream stream = new System.IO.FileStream(nombreArchivo, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosxRepuestoTableAdapter1.verArchivo(int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
                writer.Write(arr);
                writer.Close();
                //despues de creado lo abrimos
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = nombreArchivo;
                //p.StartInfo.CreateNoWindow=true;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                p.StartInfo.WorkingDirectory = nombreArchivo.Replace(System.IO.Path.GetFileName(nombreArchivo), "");
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo\n " + ex.Message);
            }
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null ||
   grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            saveFileDialog1.FileName = grdArchivos.Columns["nombreArchivo"].Value.ToString();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string nombreArchivo = saveFileDialog1.FileName;

                System.IO.FileStream stream = new System.IO.FileStream(nombreArchivo, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosxRepuestoTableAdapter1.verArchivo(int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));

                writer.Write(arr);
                writer.Close();
                MessageBox.Show("Archivo Guardado satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo \n" + ex.Message);
            }

        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //
            SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje frm = new SPControladoraDatos.artefactos.SPXUtilidades.frmMensaje();
            frm.titulo = "Descripcion del Archivo";
            frm.pregunta = "Ingrese una descripcion del archivo";
            frm.mensaje = openFileDialog1.FileName;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName
                    , System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);

                byte[] archivo = new byte[fs.Length];
                fs.Read(archivo, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                string nombre = openFileDialog1.FileName.Trim();
                if (nombre.Length >= 150) nombre = nombre.Substring(0, 150);
                string mensaje = frm.mensaje.Trim();
                if (mensaje.Length >= 250) mensaje = mensaje.Substring(0, 250);

                archivosxRepuestoTableAdapter1.Insert(txtCodigo.Text, nombre,archivo, mensaje);
                //cargaqmos los archivos
                archivosxRepuestoTableAdapter1.FillBycodRepuesto(dsSpx1.archivosxRepuesto,  txtCodigo.Text);
            }catch (Exception ex){
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null || grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el archivo relacionado al modelo", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;


            archivosxRepuestoTableAdapter1.DeleteQuery( int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
            //cargamos la grilla
            archivosxRepuestoTableAdapter1.FillBycodRepuesto(dsSpx1.archivosxRepuesto,  txtCodigo.Text);
        }
        #endregion

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            btnQuitarArchivo.Enabled = cgDataControler1.EstadoControles;
            btnSubirArchivo.Enabled = cgDataControler1.EstadoControles;
            if (txtCodigo.ReadOnly == false && txtCodigo.Enabled == true)
            {

                btnQuitarArchivo.Enabled = false;
                btnSubirArchivo.Enabled = false;
            }
        }

    }
}


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
    public partial class frmModelos : CgDataFrm.frmModelo
    {
        public frmModelos()
        {
            InitializeComponent();
        }
        
        private void llenarTablas()
        {
            fabricanteTableAdapter1.FillByComboBox(dsSpx1.fabricante);
            tipoEquipoTableAdapter1.Fill(dsSpx1.tipoEquipo);
            subTipoEquipoTableAdapter1.Fill(dsSpx1.subTipoEquipo);
            string sql = @"SELECT NombreModelo, amperios, codFabricante, codModelo, codSubTipoEquipo, codTipoEquipo, codUnidadPeso, descripcion, diasxMantenimiento, duracionMantenimiento,
frecuencia, mesesxMantenimiento, nombreManual, pesoEstimado, voltaje, watios,cod_manual_modelo,
cast(null as image) as fotografia,cast(null as image) as manual

FROM Modelos";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            dsSpx1.Modelos.Merge(bd.ejecutarConsulta(sql).Tables[0]);
           // modelosTableAdapter1.FillBySinArchivos();
            unidadPesoTableAdapter1.Fill(dsSpx1.unidadPeso);
        }

        private void frmModelos_Load(object sender, EventArgs e)
        {
            llenarTablas();
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "Modelos"] as CurrencyManager);
            cgDataControler1.TableAdapter = modelosTableAdapter1;
        }

        #region manual y fotografias


        private void btnSubirF_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image im = new Bitmap(openFileDialog1.FileName);
                    picFotografia.Image = im;
                    picFotografia.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {
            if (cgDataControler1.verValor("fotografia") != null && picFotografia.Image != null &&
               cgDataControler1.verValor("fotografia") != System.DBNull.Value)
            {
                saveFileDialog1.FileName = "*.jpg";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] arr = (byte[])cgDataControler1.verValor("fotografia");
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

        private void btnVerFoto_Click(object sender, EventArgs e)
        {
            if (cgDataControler1.verValor("fotografia") != null && picFotografia.Image != null &&
              cgDataControler1.verValor("fotografia") != System.DBNull.Value)
            {
                string ruta = System.IO.Path.GetTempFileName();
                ruta = System.IO.Path.GetFileNameWithoutExtension(ruta) + ".png";
                picFotografia.Image.Save(ruta);
                SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(ruta);
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void btnSubirManual_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            //
            try
            {
                string nombre = System.IO.Path.GetFileName(openFileDialog1.FileName.Trim());
                if (nombre.Length >= 150) nombre = nombre.Substring(nombre.Length - 150, 150);
                cgDataControler1.asignarValor("nombreManual", nombre);
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName
                    , System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
                byte[] archivo = new byte[fs.Length];
                fs.Read(archivo, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                cgDataControler1.asignarValor("manual", archivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }

        private void verManual()
        {
           
            try
            {
                if (cgDataControler1.verValor("nombreManual").ToString().Trim() == string.Empty) return;
                string path = System.IO.Path.GetTempPath();
                string nombreArchivo = path + @"\" + System.IO.Path.GetFileName(
                    cgDataControler1.verValor("nombreManual").ToString());

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);

                Application.DoEvents();
                if (!txtCodigoModelo.ReadOnly && txtCodigoModelo.Enabled) { picFotografia.Image = null; return; }
                if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty) { picFotografia.Image = null; return; }

                string str = "select manual from modelos where codFabricante = '" + cmbFabricante.SelectedValue.ToString().Trim()
                    + "' and codModelo ='" + txtCodigoModelo.Text.Trim() + "'";
                SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
                object ob = objData.ejecutarProcedimiento(str);
                if (ob == null || ob == System.DBNull.Value) { return; }
                byte[] arr = (byte[])ob;
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
                MessageBox.Show("Error al abrir el manual\n " + ex.Message);
            }
        }

        private void btnVerManual_Click(object sender, EventArgs e)
        {
            verManual();
        }

        private void btnDescargarManual_Click(object sender, EventArgs e)
        {
            if (cgDataControler1.verValor("nombreManual").ToString().Trim() == string.Empty) return;
            saveFileDialog1.FileName = cgDataControler1.verValor("nombreManual").ToString();

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);

                Application.DoEvents();
                if (!txtCodigoModelo.ReadOnly && txtCodigoModelo.Enabled) { picFotografia.Image = null; return; }
                if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty) { picFotografia.Image = null; return; }

                string str = "select manual from modelos where codFabricante = '" + cmbFabricante.SelectedValue.ToString().Trim()
                    + "' and codModelo ='" + txtCodigoModelo.Text.Trim() + "'";
                SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
                object ob = objData.ejecutarProcedimiento(str);
                if (ob == null || ob == System.DBNull.Value) { return; }
                byte[] arr = (byte[])ob;

                writer.Write(arr);
                writer.Close();
                //despues de creado lo abrimos
                MessageBox.Show("Manual Guardado Satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el manual\n " + ex.Message);
            }

        }

        private void picManual_Click(object sender, EventArgs e)
        {
            verManual();
        }
        #endregion

        #region archivos asociados
        private void ribbonControlDataFrm_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (ribbonControlDataFrm.SelectedRibbonTabItem.Text.ToUpper().IndexOf("ARCHIVO") >= 0)
            {

                if (txtCodigoModelo.ReadOnly == true || txtCodigoModelo.Enabled == false)
                {
                    if (cmbFabricante.SelectedValue != null)
                    {
                        archivosxModeloTableAdapter1.FillBycodFabricantecodModelo(
                            dsSpx1.archivosxModelo, cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
                    }
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

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosxModeloTableAdapter1.verArchivo(cmbFabricante.SelectedValue.ToString(),
                    txtCodigoModelo.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
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

                FileStream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);
                byte[] arr = (byte[])
                    archivosxModeloTableAdapter1.verArchivo(cmbFabricante.SelectedValue.ToString(),
                    txtCodigoModelo.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));

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

                int codArchivo = int.Parse(archivosxModeloTableAdapter1.verSiguienteId(cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text).ToString());
                archivosxModeloTableAdapter1.Insert(
                    cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text, codArchivo, nombre,
                    archivo, mensaje);
                //cargaqmos los archivos
                archivosxModeloTableAdapter1.FillBycodFabricantecodModelo(
                dsSpx1.archivosxModelo, cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el archivo\n" + ex.Message);
            }
        }

        private void btnQuitarArchivo_Click(object sender, EventArgs e)
        {
            if (grdArchivos.Columns["codArchivo"].Value == null ||
          grdArchivos.Columns["codArchivo"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }

            if (MessageBox.Show("Esta seguro de eliminar el archivo relacionado al modelo", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;


            archivosxModeloTableAdapter1.DeleteArchivo(cmbFabricante.SelectedValue.ToString(),
                    txtCodigoModelo.Text, int.Parse(grdArchivos.Columns["codArchivo"].Value.ToString()));
            //cargamos la grilla
            archivosxModeloTableAdapter1.FillBycodFabricantecodModelo(
            dsSpx1.archivosxModelo, cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
        }
        #endregion
        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            nmMinutosDuracion.Enabled = cgDataControler1.EstadoControles;
            nmHorasDuracion.Enabled = cgDataControler1.EstadoControles;
            btnSubirF.Enabled = cgDataControler1.EstadoControles;
            btnSubirManual.Enabled = cgDataControler1.EstadoControles;
            btnQuitarArchivo.Enabled = cgDataControler1.EstadoControles;
            btnSubirArchivo.Enabled = cgDataControler1.EstadoControles;
            if (txtCodigoModelo.ReadOnly == false && txtCodigoModelo.Enabled == true)
            {

                btnQuitarArchivo.Enabled = false;
                btnSubirArchivo.Enabled = false;
                //
                btnAgregarVariableMedicion.Enabled = false;
                btnEditVariableMedicion.Enabled = false;
                btnDelVariable.Enabled = false;
            }
            else {
            //analizamos si el modelo es medible o para medir
                if (cgDataControler1.EstadoControles)
                { 
                //
                    string sql = @"select tipoEquipo.dispositivo_medible,dispositivo_medicion from Modelos join tipoEquipo on tipoEquipo.codTipoEquipo = Modelos.codTipoEquipo
 where codFabricante='" + cmbFabricante.SelectedValue + "' and codModelo='" + txtCodigoModelo.Text + "'";
                    SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                    System.Data.DataTable t = bd.ejecutarConsulta(sql).Tables[0];
                    if (
                        (t.Rows[0]["dispositivo_medible"] != null && t.Rows[0]["dispositivo_medible"] != System.DBNull.Value &&
                        bool.Parse(t.Rows[0]["dispositivo_medible"].ToString()))
                        ||
                        (t.Rows[0]["dispositivo_medicion"] != null && t.Rows[0]["dispositivo_medicion"] != System.DBNull.Value &&
                        bool.Parse(t.Rows[0]["dispositivo_medicion"].ToString()))
                        )
                    {
                        btnAgregarVariableMedicion.Enabled = true;
                        btnEditVariableMedicion.Enabled = true;
                        btnDelVariable.Enabled = true;
                    }else
                    {
                        btnAgregarVariableMedicion.Enabled = false;
                        btnEditVariableMedicion.Enabled = false;
                        btnDelVariable.Enabled = false;
                    }
                }

            }
        }

        private void txtCodigoModelo_TextChanged(object sender, EventArgs e)
        {
            cargarModelo();
        }
        public void cargarModelo(){
            if (txtCodigoModelo.ReadOnly == true || txtCodigoModelo.Enabled == false)
            {
                // cargarFoto();
                //cargamos la informacion de variables de medicion


                cargarFoto();
                if (cmbFabricante.SelectedValue != null && cmbFabricante.SelectedValue.ToString().Trim() != string.Empty)
                {
                    pltVariablesMedicionxModeloTableAdapter1.FillByModelo(dsPlantillas1.pltVariablesMedicionxModelo, txtCodigoModelo.Text,
                           cmbFabricante.SelectedValue.ToString());
                }
                else
                {
                    dsPlantillas1.pltVariablesMedicionxModelo.Clear();
                }

                if (txtCodigoModelo.Text.Trim() != string.Empty)
                {
                    //cargamos la informacion de la duracion del tiempo del mantenimiento
                    if (cgDataControler1.verValor("duracionMantenimiento") != null &&
                        cgDataControler1.verValor("duracionMantenimiento") != DBNull.Value && cgDataControler1.verValor("duracionMantenimiento").ToString() != string.Empty)
                    {
                        float a = float.Parse(cgDataControler1.verValor("duracionMantenimiento").ToString());
                        nmHorasDuracion.Value = (decimal)((int)a);
                        nmMinutosDuracion.Value = (decimal)(a - (int)a) * 60;
                    }
                    else
                    {
                        nmHorasDuracion.Value = 0;
                        nmMinutosDuracion.Value = 0;
                    }
                    if (cgDataControler1.verValor("diasxMantenimiento") != null &&
                        cgDataControler1.verValor("diasxMantenimiento") != DBNull.Value && cgDataControler1.verValor("diasxMantenimiento").ToString() != string.Empty)
                    {
                        int b = int.Parse(cgDataControler1.verValor("diasxMantenimiento").ToString());
                        numFrecuenciaMantenimiento.Value = (decimal)b;
                    }
                    else
                    {
                        numFrecuenciaMantenimiento.Value = 0;
                    }
                    if (cgDataControler1.verValor("mesesxMantenimiento") != null &&
                        cgDataControler1.verValor("mesesxMantenimiento") != DBNull.Value && cgDataControler1.verValor("mesesxMantenimiento").ToString() != string.Empty)
                    {
                        int b = int.Parse(cgDataControler1.verValor("mesesxMantenimiento").ToString());
                        nmMesesFrecuencia.Value = (decimal)b;
                    }
                    else
                    {
                        nmMesesFrecuencia.Value = 0;
                    }

                    if (cmbFabricante.SelectedValue != null)
                    {
                        pltVariablesMedicionxModeloTableAdapter1.FillByModelo(dsPlantillas1.pltVariablesMedicionxModelo,
                       cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
                    }
                }
                else
                {
                    nmHorasDuracion.Value = 0;
                    nmMinutosDuracion.Value = 0;
                    numFrecuenciaMantenimiento.Value = 0;
                    nmMesesFrecuencia.Value = 0;
                }
            }
        }

        private void cmbFabricante_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarModelo();
        }

        private void c1CmbFabricante_Click(object sender, EventArgs e)
        {

        }

        private void cgDataControler1_AntesDeEliminar(object sender, CGDataControler.dataControlerEventArgs e)
        {
              archivosxModeloTableAdapter1.DeletebyModelo(cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            if (txtNombreModelo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del modelo");
                e.Cancelar = true;
            }
            if (txtCodigoModeloManual.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe ingresar el codigo manual");
                e.Cancelar = true;
            }
            decimal duracion = nmHorasDuracion.Value + (nmMinutosDuracion.Value / 60);            
           // duracion = decimal.Round(duracion, 2);
            cgDataControler1.asignarValor("duracionMantenimiento", duracion);
            cgDataControler1.asignarValor("diasxMantenimiento", (int)numFrecuenciaMantenimiento.Value);
            cgDataControler1.asignarValor("mesesxMantenimiento", (int)nmMesesFrecuencia.Value);
        }

        private void cargarFoto() 
        {
            Application.DoEvents();
            if (!txtCodigoModelo.ReadOnly && txtCodigoModelo.Enabled) { picFotografia.Image = null; return; }
            if (cmbFabricante.SelectedValue == null || cmbFabricante.SelectedValue.ToString().Trim() == string.Empty) { picFotografia.Image = null; return; }

            string str = "select fotografia from modelos where codFabricante = '"+cmbFabricante.SelectedValue.ToString().Trim()
                +"' and codModelo ='"+txtCodigoModelo.Text.Trim()+"'";
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            object ob = objData.ejecutarProcedimiento(str);
            if (ob == null || ob == System.DBNull.Value) { picFotografia.Image = null; return; }
            byte[] arr = (byte[])ob;
                System.IO.Stream stream = new System.IO.MemoryStream(arr);
                Image im = Image.FromStream(stream);
                picFotografia.Image = im;
        }

        private void btnAgregarVariableMedicion_Click(object sender, EventArgs e)
        {
            frmEscogerVariable fr = new frmEscogerVariable();
            fr.CodFabricante = cmbFabricante.SelectedValue.ToString();
            fr.CodModelo = txtCodigoModelo.Text;
            //--
            if (fr.ShowDialog() == DialogResult.OK)
            {
                pltVariablesMedicionxModeloTableAdapter1.FillByModelo(dsPlantillas1.pltVariablesMedicionxModelo,
                    cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
            }
        }

        private void btnEditVariableMedicion_Click(object sender, EventArgs e)
        {
            if (grdVariablesMedicion.Columns["cod_variables_medicionxmodelo"].Text.Trim() == string.Empty) return;

            frmEscogerVariable fr = new frmEscogerVariable();
            fr.CodFabricante = cmbFabricante.SelectedValue.ToString();
            fr.CodModelo = txtCodigoModelo.Text;
            fr.cod_variables_medicionxmodelo = int.Parse(grdVariablesMedicion.Columns["cod_variables_medicionxmodelo"].Text.Trim());
            //--
            if (fr.ShowDialog() == DialogResult.OK)
            {
                pltVariablesMedicionxModeloTableAdapter1.FillByModelo(dsPlantillas1.pltVariablesMedicionxModelo,
                    cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
            }
        }

        private void btnDelVariable_Click(object sender, EventArgs e)
        {
            if (grdVariablesMedicion.Columns["cod_variables_medicionxmodelo"].Text.Trim() == string.Empty) return;

            //
            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    variables_medicionxmodeloTableAdapter1.DeleteQuery(int.Parse(grdVariablesMedicion.Columns["cod_variables_medicionxmodelo"].Text));
                    //---
                    pltVariablesMedicionxModeloTableAdapter1.FillByModelo(dsPlantillas1.pltVariablesMedicionxModelo,
                    cmbFabricante.SelectedValue.ToString(), txtCodigoModelo.Text);
                }catch(Exception ex){
                    MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete+" "+ex.Message);
                }
            }
        }

    }
}


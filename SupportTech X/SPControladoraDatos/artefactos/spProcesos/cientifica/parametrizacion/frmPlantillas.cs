using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.parametrizacion
{
    public partial class frmPlantillas : Form
    {
        public frmPlantillas()
        {
            InitializeComponent();
        }

        public string cod_template_revison_equipo { set; get; }
        public string CodFabricante { set; get; }
        public string CodModelo { set; get; }


        private void frmPlantillas_Load(object sender, EventArgs e)
        {
            if (cod_template_revison_equipo == null) cod_template_revison_equipo = "";
            if(cod_template_revison_equipo.Trim() != string.Empty)
            {
                SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter tr = new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
                SPControladoraDatos.dsCientifica ds=new SPControladoraDatos.dsCientifica();
                tr.FillBycod_template_revison_equipo(ds.template_revison_equipo, int.Parse(cod_template_revison_equipo));
                txtArchivo.Text = ds.template_revison_equipo[0].nombre_archivo;
                txtVersionTemplate.Text = ds.template_revison_equipo[0].version_template_revison_equipo;
                SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                txtCreadoPor.Text = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario="+ ds.template_revison_equipo[0].creado_por).ToString();
                calCreacion.Value = ds.template_revison_equipo[0].fecha_creacion;
                calVigenciaDesde.Value = ds.template_revison_equipo[0].vigencia_desde;
                if (!ds.template_revison_equipo[0].Isvigencia_hastaNull())
                calVigenciaHasta.Value = ds.template_revison_equipo[0].vigencia_hasta;

                txtObservaciones.Text = ds.template_revison_equipo[0].observaciones_ajustes;
                cargarCampos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cod_template_revison_equipo.Trim() != string.Empty && System.IO.Path.GetExtension(txtArchivo.Text) == "")
            {
                MessageBox.Show("El archivo debe tener la extension");
                return;
            }
            SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter tr = new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
 
            if (cod_template_revison_equipo.Trim() == string.Empty)
            {
                tr.UpdateVigenciaHasta(DateTime.Now, CodFabricante, CodModelo);
                tr.Insert(txtVersionTemplate.Text, CodFabricante, CodModelo, DateTime.Now,
                    null, DateTime.Now, SPXSeguridad.logica.sesion.CodUsuarioAutenticado, txtObservaciones.Text,
                    null, "");
                //cuando se inserta uno se debe buscar cual es y modificar la fecha vigente
            }
            else {
                tr.UpdateQuery(txtVersionTemplate.Text, txtObservaciones.Text, int.Parse(cod_template_revison_equipo));

            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCambiarArchivo_Click(object sender, EventArgs e)
        {
            if(cod_template_revison_equipo.Trim() == string.Empty)
            {
            MessageBox.Show("Debe guardar primero el encabezado.");
                return;
            }
            OpenFileDialog pf=new OpenFileDialog();
            if(pf.ShowDialog() != System.Windows.Forms.DialogResult.OK)return;

            
           SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter tr = new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
 
            txtArchivo.Text = System.IO.Path.GetFileName(pf.FileName);
            tr.UpdateArchivo(System.IO.File.ReadAllBytes(pf.FileName), txtArchivo.Text, int.Parse(cod_template_revison_equipo));
            
        }

        private void btnDescargarArchivo_Click(object sender, EventArgs e)
        {
            if (cod_template_revison_equipo.Trim() == string.Empty)
            {
                MessageBox.Show("Debe guardar primero el encabezado.");
                return;
            }

           SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter tr = new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
           byte[] arr = tr.verArchivo(int.Parse(cod_template_revison_equipo));
            if (arr == null)
            {
                MessageBox.Show("EL template no tiene un archivo asociado");
            }
            else
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.FileName = txtArchivo.Text;
                if (sv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.FileStream fs = System.IO.File.Create(sv.FileName, arr.Length);
                    fs.Write(arr, 0, arr.Length);
                    fs.Close();
                }

            }
        }

        private void cargarCampos() 
        {
            string sql = @" select 
 cod_campos_template_revision, cod_template_revison_equipo, campo, fila, columna
  from campos_template_revision where cod_template_revison_equipo="+cod_template_revison_equipo;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdCampos.DataSource= bd.ejecutarConsulta(sql).Tables[0];

            grdCampos.Columns["cod_campos_template_revision"].Caption = "Codigo";
            grdCampos.Splits[0].DisplayColumns["cod_template_revison_equipo"].Visible=false;
            grdCampos.Columns["campo"].Caption = "Campo";

        }

        private void btnAgregarCAmpo_Click(object sender, EventArgs e)
        {
            if (cod_template_revison_equipo.Trim() == string.Empty)
            {
                MessageBox.Show("Debe guardar primero el encabezado.");
                return;
            }
            frmCampos frm = new frmCampos();
            frm.codigoTemplate = this.cod_template_revison_equipo;
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarCampos();
            }
        }

        private void btnEditarCampo_Click(object sender, EventArgs e)
        {
            if (cod_template_revison_equipo.Trim() == string.Empty)
            {
                MessageBox.Show("Debe guardar primero el encabezado.");
                return;
            }
            if (grdCampos.Columns["cod_campos_template_revision"].Text.Trim() == string.Empty) return;
            frmCampos frm = new frmCampos();
            frm.codigoTemplate = this.cod_template_revison_equipo;
            frm.codigoCampo = grdCampos.Columns["cod_campos_template_revision"].Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarCampos();
            }
        }

        private void btnEliminarCampo_Click(object sender, EventArgs e)
        {
            if (cod_template_revison_equipo.Trim() == string.Empty)
            {
                MessageBox.Show("Debe guardar primero el encabezado.");
                return;
            }
            if (grdCampos.Columns["cod_campos_template_revision"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete, SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter campos = new SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter();
                campos.DeleteQuery(int.Parse(grdCampos.Columns["cod_campos_template_revision"].Text.Trim()));
                cargarCampos();
            }
        }
    }
}

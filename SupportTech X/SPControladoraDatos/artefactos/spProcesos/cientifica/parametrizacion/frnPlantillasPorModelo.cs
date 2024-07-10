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
    public partial class frnPlantillasPorModelo : Form
    {
        public frnPlantillasPorModelo()
        {
            InitializeComponent();
        }

        public string CodFabricante { set; get; }
        public string CodModelo { set; get; }

        private void frnPlantillasPorModelo_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos(){
            string sql = @"select 
cod_template_revison_equipo, version_template_revison_equipo, vigencia_desde, vigencia_hasta, fecha_creacion,nombre_archivo
 from template_revison_equipo
 where codFabricante ='" + CodFabricante + "' and codModelo='" + CodModelo + "' order by vigencia_desde desc";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource = bd.ejecutarConsulta(sql).Tables[0];
            sql = @"select 
 rtrim(nombre_fabricante)+' ('+rtrim(NombreModelo)+')'
 from modelos
join fabricante on fabricante.codfabricante= modelos.codFabricante
where fabricante.codFabricante ='"+CodFabricante+"' and codModelo='"+CodModelo+"' ";
            lblModeloFabricante.Text = bd.ejecutarProcedimiento(sql).ToString(); ;
            grdDatos.Columns["cod_template_revison_equipo"].Caption = "Codigo";
            grdDatos.Columns["vigencia_desde"].Caption = "Vigencia desde";
            grdDatos.Columns["vigencia_hasta"].Caption = "Vigencia hasta";
            grdDatos.Columns["version_template_revison_equipo"].Caption = "Version";
            grdDatos.Columns["fecha_creacion"].Caption = "Fecha creacion";
            grdDatos.Columns["nombre_archivo"].Caption = "Archivo";

        }

        private void btnEditarPlantilla_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_template_revison_equipo"].Text.Trim() == string.Empty) return;
            parametrizacion.frmPlantillas frm = new frmPlantillas();
            frm.cod_template_revison_equipo = grdDatos.Columns["cod_template_revison_equipo"].Text;
            frm.CodFabricante = CodFabricante;
            frm.CodModelo = CodModelo;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarDatos();
            }
        }

        private void btnNuevaPlantilla_Click(object sender, EventArgs e)
        {
        
            parametrizacion.frmPlantillas frm = new frmPlantillas();
            frm.CodFabricante = CodFabricante;
            frm.CodModelo = CodModelo;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cargarDatos();
            }
        }

        private void btnDescargarPlantilla_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_template_revison_equipo"].Text.Trim() == string.Empty) return;
            SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter tr = new SPControladoraDatos.dsCientificaTableAdapters.template_revison_equipoTableAdapter();
            byte[] arr= tr.verArchivo(int.Parse(grdDatos.Columns["cod_template_revison_equipo"].Text));
            if (arr == null)
            {
                MessageBox.Show("EL template no tiene un archivo asociado");
            }else {
                SaveFileDialog sv = new SaveFileDialog();
                sv.FileName = grdDatos.Columns["nombre_archivo"].Text;
                if (sv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.FileStream fs = System.IO.File.Create(sv.FileName, arr.Length);
                    fs.Write(arr, 0, arr.Length);
                    fs.Close();
                }

            }
        }
    }
}

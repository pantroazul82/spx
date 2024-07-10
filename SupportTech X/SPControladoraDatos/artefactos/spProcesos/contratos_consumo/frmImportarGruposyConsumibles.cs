using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmImportarGruposyConsumibles : Form
    {
        public frmImportarGruposyConsumibles()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargue_Click(object sender, EventArgs e)
        {
            OpenFileDialog pf = new OpenFileDialog();
            if(pf.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                txtArchivo.Text = pf.FileName;
            }
        }

        private void btnSubirDatos_Click(object sender, EventArgs e)
        {
            C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
            libro.Load(txtArchivo.Text);
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            SPControladoraDatos.dsContratoConsumoTableAdapters.grupo_consumibleTableAdapter gr=new SPControladoraDatos.dsContratoConsumoTableAdapters.grupo_consumibleTableAdapter();
            SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter consumible = new SPControladoraDatos.dsContratoConsumoTableAdapters.consumiblesTableAdapter();
            for (int k = 1; k < libro.Sheets[0].Rows.Count; k++)
            {
                if (libro.Sheets[0][k, 0].Value == null || libro.Sheets[0][k, 0].Value.ToString().Trim() == string.Empty) continue;

                //validamos el grupo
                string sql = @"
                select cod_grupo_consumible from grupo_consumible
where grupo_consumible like '%"+libro.Sheets[0][k,2].Value.ToString().Trim()+"%'";
                System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];
                if (tb.Rows.Count <= 0)
                {
                    //buscamos el codigo del fabricante
                    int codFabricante=0;
                    sql = @"
                select cod_fabricante from fabricante where nombre_fabricante 
like '%" + libro.Sheets[0][k, 3].Value.ToString().Trim() +"%' or nombre_fabricante like '%" + libro.Sheets[0][k, 4].Value.ToString().Trim() +"%'";

                    codFabricante = int.Parse(bd.ejecutarProcedimiento(sql).ToString());
                    gr.Insert(codFabricante, libro.Sheets[0][k, 2].Value.ToString().Trim());
                
                //cargamos de nuevo el grupo
                sql = @"
                select cod_grupo_consumible from grupo_consumible
where grupo_consumible like '%" + libro.Sheets[0][k, 2].Value.ToString().Trim() + "%'";
                tb = bd.ejecutarConsulta(sql).Tables[0];
                }
                int codGrupo = int.Parse(tb.Rows[0][0].ToString());
                //
                consumible.Insert(libro.Sheets[0][k, 1].Value.ToString().Trim(), codGrupo, libro.Sheets[0][k, 0].Value.ToString().Trim());
            }
        }
    }
}

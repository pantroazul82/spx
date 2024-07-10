using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.HerramientasAnnar
{
    public partial class frmImportadorProblemas : Form
    {
        public frmImportadorProblemas()
        {
            InitializeComponent();
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtArchivo.Text = op.FileName;
            }
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if(txtArchivo.Text.Trim() == string.Empty)
            {
                return;
            }
            //-
            C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
            libro.Load(txtArchivo.Text);
            string sql = "";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            

            for (int k = 0; k < libro.Sheets[0].Rows.Count; k++)
            { 
            //localizamos el fabricante
                string fabricante = libro.Sheets[0][k, 0].Text;
                sql = "select codFabricante from fabricante where nombre_fabricante ='"+fabricante.Trim()+"'";
                System.Data.DataTable tb = bd.ejecutarConsulta(sql).Tables[0];
                if (tb.Rows.Count == 0)
                {
                    sql = "select codFabricante from fabricante where nombre_fabricante like '%" + fabricante.Trim() + "%'";
                    tb = bd.ejecutarConsulta(sql).Tables[0];
                }
                if (tb.Rows.Count == 0)
                {
                    sql = "select codFabricante from fabricante where '"+fabricante.Trim()+"' like '%'+rtrim(nombre_fabricante)+'%'";
                    tb = bd.ejecutarConsulta(sql).Tables[0];
                }

                if (tb.Rows.Count == 0)
                {
                    txtLogArchivos.Text += ("\r\n"+"La fila "+(k+1)+" tiene un fabricante no valido");
                    continue;
                }

                fabricante= tb.Rows[0][0].ToString().Trim();

                string modelo = libro.Sheets[0][k, 1].Text;
                sql = "select codModelo from Modelos where NombreModelo='"+modelo+"' and codFabricante ='"+fabricante+"'";
                tb = bd.ejecutarConsulta(sql).Tables[0];
                if (tb.Rows.Count == 0)
                {
                    sql = "select codModelo from Modelos where NombreModelo like '%" + modelo + "%' and codFabricante ='" + fabricante + "'";
                    tb = bd.ejecutarConsulta(sql).Tables[0];
                }
                if (tb.Rows.Count == 0)
                {
                    sql = "select codModelo from Modelos where '" + modelo + "' like '%'+rtrim(NombreModelo)+'%' and codFabricante ='" + fabricante + "'";
                    tb = bd.ejecutarConsulta(sql).Tables[0];
                }

                if (tb.Rows.Count == 0)
                {
                    txtLogArchivos.Text += ("\r\n"+"La fila " + (k + 1) + " tiene un modelo no valido");
                    continue;
                }
                modelo = tb.Rows[0][0].ToString().Trim();
                string cod_Manual = libro.Sheets[0][k, 2].Text;
                string descripcion = libro.Sheets[0][k, 3].Text;
                string nombre = libro.Sheets[0][k, 4].Text;

                problemas_frecuentesTableAdapter1.Insert(fabricante,modelo,cod_Manual ,nombre,descripcion);
                problemas_frecuentesTableAdapter1.FillByVerId(dsSpx1.problemas_frecuentes, fabricante, modelo, cod_Manual);
                int codigo= dsSpx1.problemas_frecuentes[0].cod_problema_frecuente;
                //algoritmo para crear las soluciones
                int columna=0;
                while(libro.Sheets[0][k, 5+columna].Text != null &&  libro.Sheets[0][k, 5+columna].Text != string.Empty)
                {
                    string codManual= cod_Manual+"-"+(columna+1).ToString().PadLeft(3,'0');
                    string solucion =libro.Sheets[0][k, 5+columna].Text;
                     soluciones_problemasTableAdapter1.Insert(codigo,codManual,solucion);
                     columna++;
                }
             
           
            
            }
            txtLogArchivos.Text = "Se Proceso el Archivo Satisfactoriamente."+ "\r\n"+txtLogArchivos.Text;
        }
    }
}

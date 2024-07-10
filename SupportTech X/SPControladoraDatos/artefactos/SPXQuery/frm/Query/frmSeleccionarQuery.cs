using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmSeleccionarQuery : Form
    {
        public frmSeleccionarQuery()
        {
            InitializeComponent();
        }
        data.cls.clsTcgq_query cgq_queryTableAdapter1 = new data.cls.clsTcgq_query();
        data.cls.clsTcgq_parametrosquery cgq_parametrosquery1 = new data.cls.clsTcgq_parametrosquery(); 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmSeleccionarQuery_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            cgq_queryTableAdapter1.FillByxUsuario(dsSPXQuery1.cgq_query,SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguiente();
        }
        
        private void siguiente(){
            if (grdDatos.Columns["cod_query"].Text.Trim() == string.Empty) return;
            cgq_queryTableAdapter1.FillByCod_query(dsSPXQuery2.cgq_query, int.Parse(grdDatos.Columns["cod_query"].Text));
            cgq_parametrosquery1.FillByCod_query(dsSPXQuery2.cgq_parametrosquery, int.Parse(grdDatos.Columns["cod_query"].Text));
            //miramos si tiene filtros obligatorios
            string sql = dsSPXQuery2.cgq_query[0].sentencia_sql;
            #region parametros obligatorios
            frmParametrosObligatorios frmP = new frmParametrosObligatorios();
            for (int k = 0; k < dsSPXQuery2.cgq_parametrosquery.Count; k++)
            {
                if (sql.IndexOf("@" + dsSPXQuery2.cgq_parametrosquery[k].campo.Trim()) >= 0)
                {
                    frmParametrosObligatorios.parametro p = new frmParametrosObligatorios.parametro();
                    p.codParametro = dsSPXQuery2.cgq_parametrosquery[k].cod_parametros_query;
                    p.codQuery = int.Parse(grdDatos.Columns["cod_query"].Text);
                    frmP.lista.Add(p);
                }
            }
            if (frmP.lista.Count > 0)
            {
                if (frmP.ShowDialog() == DialogResult.OK)
                {
                    for (int j = 0; j < frmP.lista.Count; j++)
                    {
                        sql = sql.Replace("@" + frmP.lista[j].campo, frmP.lista[j].respuesta);
                    }
                }
                else {
                    return;
                }
            }
#endregion


            //if (!dsSPXQuery2.cgq_query[0].Ises_pivoteNull() && dsSPXQuery2.cgq_query[0].es_pivote)
            //{ 
            //    Query.fmEjecutarQueryPivote fr = new fmEjecutarQueryPivote();
            //    fr.sql = sql;
            //    fr.Text = "Query: " + dsSPXQuery2.cgq_query[0].nombre_query.Trim();
            //    fr.Icon = this.Icon;
            //    fr.codQuery = int.Parse(grdDatos.Columns["cod_query"].Text);
            //    fr.MdiParent = this.MdiParent;
            //    fr.Show();
               
            //}else{
                Query.frmEjecutarQuery fr = new frmEjecutarQuery();
                fr.cargarParametros(dsSPXQuery2.cgq_parametrosquery);
                fr.sql = sql;
                fr.Text = "Query: "+dsSPXQuery2.cgq_query[0].nombre_query.Trim();
                fr.Icon = this.Icon;
                fr.codQuery = int.Parse(grdDatos.Columns["cod_query"].Text);
                fr.MdiParent = this.MdiParent;
                fr.Show();
            //}
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cgq_queryTableAdapter1.FillByxUsuario(dsSPXQuery1.cgq_query, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
        }

        private void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            siguiente();
        }
    }
}

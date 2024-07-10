using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;


namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmListadoQuery : frm.plantillas.frmListado
    {
        
        public frmListadoQuery()
        {
            cod_modulo = 60;
            InitializeComponent();
        }
        
        data.cls.clsTcgq_queryxusuario cgq_queryxusuario1 = new data.cls.clsTcgq_queryxusuario();
        data.cls.clsTcgq_queryxgrupo_usuario cgq_queryxgrupousuario1 = new data.cls.clsTcgq_queryxgrupo_usuario();
        data.cls.clsTcgq_query cgq_queryTableAdapter1 = new data.cls.clsTcgq_query();
        data.cls.clsTcgq_parametrosquery cgq_parametrosqueryTableAdapter1 = new data.cls.clsTcgq_parametrosquery();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           // if (!permiteAgregar) return;
            frmEditarQuery fr = new frmEditarQuery();
            fr.Icon = this.Icon;
            fr.ShowDialog();
            cgq_queryTableAdapter1.Fill(dsSPXQuery1.cgq_query);
        }

        private void frmListadoQuery_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            cgq_queryTableAdapter1.Fill(dsSPXQuery1.cgq_query);
        }

        private void btnEditarQuery_Click(object sender, EventArgs e)
        {
            //if (!permiteModificar) return;
            if (grdDatos.Columns["cod_query"].Text.Trim() == string.Empty) return;

            frmEditarQuery fr = new frmEditarQuery();
            fr.codQuery = int.Parse(grdDatos.Columns["cod_query"].Text);

            int colTmp = grdDatos.Row;
            fr.ShowDialog();

            cgq_queryTableAdapter1.Fill(dsSPXQuery1.cgq_query);
            grdDatos.Row = colTmp;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!permiteEliminar) return;
            if (grdDatos.Columns["cod_query"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de eliminar este Query?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cgq_queryxusuario1.DeleteByCodQuery(int.Parse(grdDatos.Columns["cod_query"].Text));
                    cgq_parametrosqueryTableAdapter1.DeleteByCodQuery(int.Parse(grdDatos.Columns["cod_query"].Text));
                  
                    cgq_queryxgrupousuario1.DeleteByCod_query(int.Parse(grdDatos.Columns["cod_query"].Text));
                    cgq_queryTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_query"].Text));
                    cgq_queryTableAdapter1.Fill(dsSPXQuery1.cgq_query);
                }catch(Exception ex){
                    MessageBox.Show("Error al Eliminar el registro\r\n"+ex.Message);
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Querys", false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cgq_queryTableAdapter1.Fill(dsSPXQuery1.cgq_query);
        }

        private void btnEditarQueryxUsuario_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_query"].Text.Trim() == string.Empty) return;
            frm.Query.frmQueryxUsuario fr = new Query.frmQueryxUsuario();
            fr.ShowDialog();
        }
    }
}

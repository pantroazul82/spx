using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.problemas_frecuentes
{
    public partial class frmSeleccionarProblema : Form
    {
        public frmSeleccionarProblema()
        {
            InitializeComponent();
        }

        public string codFabricante { set; get; }
        public string codModelo { set; get; }

        public int codProblemaSeleccionado { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grdProblema.Columns["cod_problema_frecuente"].Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe Seleccionar un problema comun!!!");
                return;
            }
            codProblemaSeleccionado = int.Parse(grdProblema.Columns["cod_problema_frecuente"].Text.Trim());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmSeleccionarProblema_Load(object sender, EventArgs e)
        {
            string sql = "select nombre_fabricante from fabricante where codFabricante like '"+codFabricante+"'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            string fabricante =  bd.ejecutarProcedimiento(sql).ToString();
            sql = "select NombreModelo from Modelos  where codFabricante like '"+codFabricante+"' and codModelo like '"+codModelo+"'";
            
            string modelo = bd.ejecutarProcedimiento(sql).ToString();
            lblModeloFabricante.Text = fabricante.Trim() + " - " + modelo.Trim();
            problemas_frecuentesTableAdapter1.FillByFabricanteModelo(dsSpx1.problemas_frecuentes, codFabricante, codModelo);

        }

        private void btnAgregarProblema_Click(object sender, EventArgs e)
        {
            frmParametrizacionProblemas fr = new frmParametrizacionProblemas();
            fr.codFabricante = codFabricante;
            fr.codModelo = codModelo;
            fr.ShowDialog() ;
            problemas_frecuentesTableAdapter1.FillByFabricanteModelo(dsSpx1.problemas_frecuentes, codFabricante, codModelo);
        }
    }
}

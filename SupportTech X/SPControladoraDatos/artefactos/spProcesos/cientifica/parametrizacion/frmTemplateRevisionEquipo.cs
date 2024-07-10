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
    public partial class frmTemplateRevisionEquipo : Form
    {
        public frmTemplateRevisionEquipo()
        {
            InitializeComponent();
        }
        private string GenerarSql()
        {
            string sql = @"select modelos.codFabricante,
max(nombre_fabricante) nombre_fabricante,max(NombreModelo) NombreModelo,modelos.codModelo,
count(template_revison_equipo.cod_template_revison_equipo) Templates
 from modelos
join fabricante on fabricante.codfabricante= modelos.codFabricante
left join template_revison_equipo on template_revison_equipo.codFabricante = fabricante.codfabricante and template_revison_equipo.codModelo= modelos.codModelo
group by modelos.codFabricante,modelos.codModelo
order by nombre_fabricante, NombreModelo";
            return sql;
        }

        private void frmTemplateRevisionEquipo_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource = bd.ejecutarConsulta(GenerarSql()).Tables[0];
            grdDatos.Columns["codFabricante"].Caption = "cod Fabricante";
            grdDatos.Splits[0].DisplayColumns["codFabricante"].Visible = false;

            grdDatos.Columns["nombre_fabricante"].Caption = "Fabricante";

            grdDatos.Columns["NombreModelo"].Caption = "Modelo";

            grdDatos.Columns["codModelo"].Caption = "Cod Modelo";

        }

        private void btnVerPlantillas_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codFabricante"].Text.Trim() == string.Empty) return;
            parametrizacion.frnPlantillasPorModelo frm = new frnPlantillasPorModelo();
            frm.CodFabricante = grdDatos.Columns["codFabricante"].Text;
            frm.CodModelo = grdDatos.Columns["codModelo"].Text;
            frm.ShowDialog();
        }
    }
}

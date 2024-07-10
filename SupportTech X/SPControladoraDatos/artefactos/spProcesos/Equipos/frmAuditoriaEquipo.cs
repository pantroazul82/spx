using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmAuditoriaEquipo : Form
    {
        public frmAuditoriaEquipo()
        {
            InitializeComponent();
        }

        private void frmAuditoriaEquipo_Load(object sender, EventArgs e)
        {
 calfechaInicio.Value = DateTime.Now.AddDays(-10);
            calFechaFin.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime ff = calFechaFin.Value.AddDays(1);
   string sql = @"set dateformat ymd

select * from auditoria
where fecha_modificacion between 
'" + calfechaInicio.Value.Year + @"/" + calfechaInicio.Value.Month.ToString().PadLeft(2, '0') + "/" + calfechaInicio.Value.Day.ToString().PadLeft(2, '0') + @"' and 
'" + ff.Year + @"/" + ff.Month.ToString().PadLeft(2, '0') + "/" + ff.Day.ToString().PadLeft(2, '0') + @"' and 
observaciones like '%" + txtfiltro.Text + "%'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
           grdDAtos.DataSource = bd.ejecutarConsulta(sql).Tables[0];
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
string serial = grdDAtos.Columns["observaciones"].Text;
            serial = serial.Replace("Equipo:","");
            
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = serial.Trim();
            frm.ShowDialog();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
 SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportarRapido(grdDAtos, "Auditoria", false);
        }
    }
}

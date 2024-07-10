using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Herramientas
{
    public partial class frmConteoCorrectivos : Form
    {
        public frmConteoCorrectivos()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            switch (cmbTipoReporte.Text.Trim())
            {
                case "Correctivos por Serial": { ejecutarSentencia("ordenServicio.serial", "max(modelos.nombreModelo) 'Nombre Modelo'"); break; }
                case "Correctivos por Fabricante": { ejecutarSentencia("fabricante.nombre_fabricante", ""); break; }
                case "Correctivos por Modelo": { ejecutarSentencia("modelos.nombreModelo", ""); break; }
                case "Correctivos por Nit Cliente": { ejecutarSentencia("clientes.nitCliente", "max(nombreCliente) 'Nombre Cliente'"); break; }
                case "Correctivos por Ciudad": { ejecutarSentencia("ciudades.nombreCiudad", ""); break; }
                case "Correctivos por Responsable": { ejecutarSentencia("usuario.nombre", ""); break; }
            }
        }

        private string generarSentencia(string agrupador,string camposAdicionales)
        {
            string fechaRelativa = "fechafinProgramacion";
            if (rdCreacion.Checked) fechaRelativa = "fechaCreacion";
            else if (rdProgramacion.Checked) fechaRelativa = "fechaProgramacion";
            else if (rdFechaCierre.Checked) fechaRelativa = "fechafinProgramacion";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("  set dateformat dmy ");

sb.Append(" select top "+numRegistros.Value+" "+agrupador+",count(*) 'cantidad' ");
            if(camposAdicionales != string.Empty)
                sb.Append(" , "+camposAdicionales);
sb.Append(" from ordenServicio ");
sb.Append(" join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio ");
sb.Append(" join usuario usuarios on usuarios.login = ordenServicio.asignadoA ");
sb.Append(" join Clientes on clientes.nitCliente = ordenServicio.nitCliente ");
sb.Append(" join sucursalCliente on sucursalCliente.nitCliente = ordenServicio.nitCliente and sucursalCliente.codSucursal = ordenServicio.codSucursal  ");
sb.Append(" join ciudades on ciudades.codCiudad = sucursalCliente.codCiudad and ciudades.codDepartamento = sucursalCliente.codDepartamento and ciudades.codPais = sucursalCliente.codPais ");
sb.Append(" join equipos on equipos.serial = ordenServicio.serial ");
sb.Append(" join fabricante on equipos.codFabricante = fabricante.codFabricante ");
sb.Append(" join modelos on modelos.codFabricante = equipos.codFabricante and modelos.codModelo = equipos.codModelo ");

sb.Append(" where (tipoServicio.correctivo=1 and tipoServicio.correctivo is not null) ");
sb.Append(" and "+fechaRelativa+" >= '" 
    + calInicio.Value.Day.ToString().PadLeft(2, '0') + "-" 
    + calInicio.Value.Month.ToString().PadLeft(2, '0') + "-"
    + calInicio.Value.Year+
     "' and " + fechaRelativa + " <= '" + calFin.Value.Day.ToString().PadLeft(2, '0') + "-"
    + calFin.Value.Month.ToString().PadLeft(2, '0') + "-"
    + calFin.Value.Year + "' ");
sb.Append(" group by  " + agrupador + " order by count(*) desc");
            return sb.ToString();
        }

        private void ejecutarSentencia(string agrupador, string camposAdicionales) 
        {
            string sql = generarSentencia(agrupador, camposAdicionales);
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            c1TrueDBGrid1.DataSource = objData.ejecutarConsulta( sql ).Tables[0];
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void frmConteoCorrectivos_Load(object sender, EventArgs e)
        {
            calInicio.Value = DateTime.Now.AddMonths(-1);
            calFin.Value = DateTime.Now.AddDays(1);
            rdFechaCierre.Checked = true;
            cmbTipoReporte.SelectedIndex = 0;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel ob = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            ob.exportar(c1TrueDBGrid1,cmbTipoReporte.Text,false );
        } 
    }
}
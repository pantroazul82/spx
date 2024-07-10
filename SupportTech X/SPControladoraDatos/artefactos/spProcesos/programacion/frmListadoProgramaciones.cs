using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.programacion
{
    public partial class frmListadoProgramaciones : Form
    {
        public frmListadoProgramaciones()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string retornarSentecia() 
        {
            string sql = "  SELECT   " +
" codProgramacionViajes, fechaCreacion,u1.nombre creadoPor, fechaViaje, fechaRegreso,u2.nombre ingenieroAsignado, programada,  " +
" paises.nombrePais,departamento.nombreDepartamento,ciudades.nombreCiudad, observaciones " +
" FROM  " +
" programacionViajes " +
" join usuario u1 on u1.login = programacionViajes.creadoPor " +
" join usuario u2 on u2.login = programacionViajes.ingenieroAsignado " +
" join paises on paises.codPais = programacionViajes.codPais " +
" join departamentos departamento on departamento.codPais = programacionViajes.codPais and departamento.coddepartamento = programacionViajes.coddepartamento " +
" left join ciudades on  " +
" ciudades.codPais = programacionViajes.codPais and ciudades.coddepartamento = programacionViajes.coddepartamento " +
" and ciudades.codCiudad = programacionViajes.codciudad";
            return sql;
        }

        private void btnFiltrarxEstado_Click(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            if (cmbMeses.Text.Trim() == string.Empty) return;
            int mes = cmbMeses.SelectedIndex + 1;
            int year = n.Year;
            string sql = retornarSentecia()+
                
                " where "+
"(datepart(month,fechaViaje) = " + mes + " and datepart(year,fechaViaje) =" + year + ")" +
" or "+
"(datepart(month,fechaRegreso) = " + mes + " and datepart(year,fechaRegreso) =" + year + ")";
            dsPlantillas1.pltListaProgramaciones.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListaProgramaciones.Merge(
                objData.ejecutarConsulta(sql).Tables[0]
                );
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar() 
        {
            string filtro = cmbFiltro.Text.Trim();
            if (filtro == string.Empty) return;
            string sql = "set dateformat ymd "+retornarSentecia();

            if (filtro == "Codigo Programacion")
            {
                sql += " WHERE programacionViajes.codProgramacionViajes like '" + txtFiltro.Text + "%'";
            }
            else if (filtro == "Ingeniero Asignado")
            {
                sql += " WHERE programacionViajes.ingenieroASignado like '" + txtFiltro.Text + "%'";
            }
            else if (filtro == "Codigo Orden Servicio")
            { 
               sql += " WHERE codProgramacionViajes in (select codProgramacionViajes from detalleProgramacionViajes " +
                                                        "where codOrdenServicio like '"+txtFiltro.Text+"%' )";
            }
            else if (filtro == "Serial")
            {
                sql += " WHERE codProgramacionViajes in (select codProgramacionViajes from detalleProgramacionViajes " +
                                                   "where serial like '" + txtFiltro.Text + "%' )";
            }
            if (chkEntreFechas.Checked)
            { 
                //agregamos el filtro de fechas
                sql += " AND "+
                " ( " +
                " (fechaViaje between '" + calfechaInicio.Value.Year + "-" + calfechaInicio.Value.Month + "-" + calfechaInicio.Value.Day + "' and '" + calFechaFin.Value.Year + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Day + "')" +
                " or"+
                " (fechaRegreso between '" + calfechaInicio.Value.Year + "-" + calfechaInicio.Value.Month + "-" + calfechaInicio.Value.Day + "' and '" + calFechaFin.Value.Year + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Day + "')" +
                " ) ";
            }
            sql = sql + "order by codProgramacionViajes desc ";
            dsPlantillas1.pltListaProgramaciones.Clear();
            SPXdata.BD.DataConector obj=new SPXdata.BD.DataConector();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltListaProgramaciones.Merge(
                obj.ejecutarConsulta(sql).Tables[0]
                );
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void frmListadoProgramaciones_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calFechaFin.MonthCalendar.DisplayMonth = n;
            calfechaInicio.MonthCalendar.DisplayMonth = n;

            cmbFiltro.SelectedIndex = 0;
            cmbMeses.SelectedIndex = 0;
        }

        private void btnVerProgramacion_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codProgramacionViajes"].Text.Trim() == string.Empty) return;
            programacion.frmNewProgramacion objFrm = new frmNewProgramacion();
            objFrm.CodProgramacion = grdDatos.Columns["codProgramacionViajes"].Text;
            objFrm.Show();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }
    }
}

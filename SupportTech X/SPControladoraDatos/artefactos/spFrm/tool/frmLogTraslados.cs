using SPXSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.tool
{
    public partial class frmLogTraslados : Form
    {
        public frmLogTraslados()
        {
            InitializeComponent();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grddatos, "Log Traslado de Equipos", false);
            
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.expandirGrilla(grddatos);
            buscar();
        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.contraerGrilla(grddatos);
            buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void frmLogTraslados_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calFin.MonthCalendar.DisplayMonth = n;
            calInicio.MonthCalendar.DisplayMonth = n;
            calFinEnvio.MonthCalendar.DisplayMonth = n;
            calInicioEnvio.MonthCalendar.DisplayMonth = n;
            cmbFiltros.SelectedIndex = 0;
            //
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\listLogCambioUb.xs";
            if (System.IO.File.Exists(str))
                grddatos.LoadLayout(str);
        }

        private void buscar() 
        {
            System.Text.StringBuilder sb = new StringBuilder();
            //sacamos la sentencia del table adapter
            string sql ="set dateformat dmy "+ SPXdata.BD.DataConector.verSentenciaCommandCollection(pltLogTrasladosTableAdapter1, 0);

            string filtro = " WHERE ";
            sql = sql.Replace("\r\n", " ");
            switch (cmbFiltros.Text.Trim())
            {
                case "Serial":
                {
                    filtro += "logCambioUbicaciones.serial like '%" + txtBuscar.Text.Trim() + "%'";
                    break;
                }
            case "Nit Cliente":
                {
                    filtro += "destino.nitCliente like '%" + txtBuscar.Text.Trim() 
                        + "%' OR origen.nitCliente like '%"+txtBuscar.Text.Trim()+"%'";
                    break;
                }
            case "Nombre Cliente":
                {
                    filtro += "destino.nombreCliente like '%" + txtBuscar.Text.Trim() 
                        + "%' OR origen.nombreCliente  like '%" + txtBuscar.Text.Trim() + "%'";
                    break;
                }
            case "Usuario":
                {
                    filtro += "usuarios.login like '%" + txtBuscar.Text.Trim() 
                        + "%' OR usuarios.nombre like '%" + txtBuscar.Text.Trim() + "%'";
                    break;
                }
            }
            if (chkFiltarxFechas.Checked) 
            {
                if (calInicio.ValueObject == null || calFin.ValueObject == null)
                {
                    MessageBox.Show("Ingrese las fechas para el rango de Cambio");
                    return;
                }
                filtro += " and fechaCambio between '" + calInicio.Value.Day + "-" + calInicio.Value.Month + "-" + calInicio.Value.Year + "' and '" + calFin.Value.Day + "-" + calFin.Value.Month + "-" + calFin.Value.Year + "'";
            }

            if (chkEnvio.Checked)
            {
                if (calInicioEnvio.ValueObject == null || calFinEnvio.ValueObject == null)
                {
                    MessageBox.Show("Ingrese las fechas para el rango de Envio");
                    return;
                }
                filtro += " and fechaEnvio between '" + calInicioEnvio.Value.Day + "-" + calInicioEnvio.Value.Month + "-" + calInicioEnvio.Value.Year + "' and '" + calFinEnvio.Value.Day + "-" + calFinEnvio.Value.Month + "-" + calFinEnvio.Value.Year + "'";
            }
            sql = sql + filtro;
            dsSpx1.pltLogTraslados.Clear();
            dsSpx1.EnforceConstraints = false;
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            dsSpx1.pltLogTraslados.Merge(obj.ejecutarConsulta(sql).Tables[0]);
            if (dsSpx1.pltLogTraslados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dsSpx1.pltLogTraslados.Clear();
        }

        private void grddatos_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(grddatos.Columns["codLog"].Text.Trim() == string.Empty)return;
            if (!verificadorPermisos.ejecutarAccionWindows(1032))
            {
                MessageBox.Show("No tiene permisos para ejecutar esta Accion!!!");
                return;
            }
            if(MessageBox.Show("Esta seguro de quitar este historial de traslado?","Confirmacion!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes )return;

            SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter lc = new SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter();
           
            lc.DeleteQuery(int.Parse(grddatos.Columns["codLog"].Text));
            buscar();
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listLogCambioUb.xs";
            grddatos.SaveLayout(str);
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listLogCambioUb.xs";
            System.IO.File.Delete(str);
            MessageBox.Show("Los cambios se veran reflejados cuando carge la ventana de nuevo");
        }
    }
}
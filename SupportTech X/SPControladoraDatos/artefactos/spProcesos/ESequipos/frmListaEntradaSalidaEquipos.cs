using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.ESequipos
{
    public partial class frmListaEntradaSalidaEquipos : Form
    {
        public frmListaEntradaSalidaEquipos()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }


        private void frmListaEntradaSalidaEquipos_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            chkEntreFechas.Checked = true;
            calFechaFin.Value = n.AddDays(1);
            calfechaInicio.Value =new DateTime( n.AddMonths(-2).Year,n.AddMonths(-2).Month,1);
            //--                   --//                                 --//
            calFinSalida.MonthCalendar.DisplayMonth = n;
            calInicioSalida.MonthCalendar.DisplayMonth = n;
            calFinSeg.MonthCalendar.DisplayMonth = n;
            calInicioSeg.MonthCalendar.DisplayMonth = n;
            
            
            cmbCampo.SelectedIndex = 0;
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            str += @"\layout\spProcesos.ESequipos.frmListaEntradaSalidaEquipos-grdDatos-controladorColumnas1.xs";
            if (System.IO.File.Exists(str))
                grdDatos.LoadLayout(str);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCampo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escoga una opcion de filtro");
                return;
            }
            buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dsPlantillas1.pltListadoESequipos.Clear();
        }

        private void btnVerOrdenServicio_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codEntradaSalidaEquipos"].Text.Trim() == string.Empty) return;
            ESequipos.frmEntradaSalidaEquipos frm = new frmEntradaSalidaEquipos();
            frm.CodEntradaSalidaEquipos = grdDatos.Columns["codEntradaSalidaEquipos"].Text.Trim();
            frm.Show();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objEx = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objEx.exportar(grdDatos, "Entrada y Salida de Equipos", false);
        }

        private string sentenciaPLantilla() 
        {
            System.Text.StringBuilder sb= new StringBuilder();
            sb.Append(" set dateformat dmy  ");
            sb.Append(" select op,factura,fechaEntradaSistema, ");
            sb.Append(" codEntradaSalidaEquipos, fechaEntrada, EntradaSalidaEquipos.fechaSalida,  ");
            sb.Append(" v2.serial,v2.nombreFabricante,v2.NombreModelo,v2.nombreTipoEquipo,v2.nombreSubTipo ");
            sb.Append(" ,tipoServicio.nombretipoServicio,estadoFisicamente.nombreEstadoFisicamente estadoFisicamente,modalidadEquipo.nombreModalidadEquipo, ");
            sb.Append(" clientes.nitCliente, clientes.nombreCliente, ");
            sb.Append(" v.nombreSucursal,v.NombreDepartamento,v.nombreCiudad, ");
            sb.Append(" cliens.nitCliente 'nitClienteSalida', cliens.nombreCliente 'clienteSalida', ");
            sb.Append(" sucus.nombreSucursal 'sucursalSalida',sucus.NombreDepartamento 'departamentoSalida',sucus.nombreCiudad 'ciudadSalida', ");
            sb.Append(" mod2.nombreModalidadEquipo 'modalidadSalida', ");
            sb.Append(" codOrdenServicio,obsEntrada ");
            sb.Append(" , obsSalida, fechaTerminacionMovto, nombre 'creadoPor' ");
            sb.Append(" , EntradaSalidaEquipos.fechaIngresoSeguimiento ,EntradaSalidaEquipos.fechaSeguimiento, EntradaSalidaEquipos.usuarioSeguimiento  ");
            sb.Append(" , EntradaSalidaEquipos.funcionaBien ,EntradaSalidaEquipos.observaciones 'ObseSeguimiento', ");
            sb.Append("entradaSalidaEquipos.anula,entradaSalidaEquipos.anulada_por, ");
            sb.Append("entradaSalidaEquipos.fecha_anulacion,entradaSalidaEquipos.motivo_anulacion ");
            sb.Append(" from dbo.EntradaSalidaEquipos ");
            sb.Append(" join usuario usuarios on usuarios.login = EntradaSalidaEquipos.creadoPor ");
            sb.Append(" join tipoServicio on tipoServicio.codTiposervicio = EntradaSalidaEquipos.codTiposervicio ");
            sb.Append(" join estadoFisicamente on estadoFisicamente.codEstadoFisicamente = EntradaSalidaEquipos.codEstadoFisicamente ");
            sb.Append(" join clientes on clientes.nitCliente  =EntradaSalidaEquipos.nitCliente ");
            sb.Append(" join dbo.vistaSucursal v on v.nitCliente = clientes.nitCliente and v.codSucursal = entradasalidaequipos.codSucursal ");
            sb.Append(" join dbo.vistaEquipo v2 on v2.serial =  entradasalidaequipos.serial ");
            sb.Append(" left join modalidadEquipo on modalidadEquipo.codModalidadEquipo = entradaSalidaEquipos.codModalidad ");
            sb.Append(" left join modalidadEquipo mod2 on mod2.codModalidadEquipo = entradaSalidaEquipos.codModalidadsalida ");
            sb.Append(" left join clientes clienS on cliens.nitCliente  =EntradaSalidaEquipos.nitClienteSalida ");
            sb.Append(" left join dbo.vistaSucursal sucuS on sucuS.nitCliente = cliens.nitCliente  ");
            sb.Append(" and sucuS.codSucursal = entradasalidaequipos.codSucursalSalida ");
        
return sb.ToString();
        }

        private void buscar() 
        {
            string sql = sentenciaPLantilla() + " WHERE ";
            
            switch (cmbCampo.Text.Trim())
            {
                case "Codigo Entrada/Salida": { sql += " codEntradaSalidaEquipos like '" + txtCampo.Text + "%' "; break; }
                case "Codigo Orden de Servicio": { sql += " codOrdenServicio like '" + txtCampo.Text + "%' "; break; }
                case "Serial": { sql += " EntradaSalidaEquipos.serial like '" + txtCampo.Text + "%' "; break; }
                case "Nit Cliente": { sql += " EntradaSalidaEquipos.nitCliente like '" + txtCampo.Text + "%' "; break; }
                case "Cliente": { sql += "  clientes.nombreCliente like '" + txtCampo.Text + "%' "; break; }
                case "Numero Socio": { sql += " clientes.numeroSocio like '" + txtCampo.Text + "%' "; break; }
                case "Modelo": { sql += " nombreModelo like '" + txtCampo.Text + "%' "; break; }
                case "Ciudad": { sql += " v.nombreciudad like '" + txtCampo.Text + "%' "; break; }
                case "Departamento": { sql += " v.nombreDepartamento like '" + txtCampo.Text + "%' "; break; }
                case "Ciudad Salida": { sql += " Sucus.nombreciudad like '" + txtCampo.Text + "%' "; break; }
                case "Departamento Salida": { sql += " Sucus.nombreDepartamento like '" + txtCampo.Text + "%' "; break; }
           
            }

            if (chkEntreFechas.Checked)
            {
                if (calfechaInicio.ValueObject == null || calFechaFin.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " and (EntradaSalidaEquipos.fechaEntrada between  '" +
                    calfechaInicio.Value.Day + "-" + calfechaInicio.Value.Month + "-" + calfechaInicio.Value.Year + "' and '" +
                    calFechaFin.Value.Day + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Year + "' )";
            }

            if (chkBuscarSalida.Checked)
            {
                if (calInicioSalida.ValueObject == null || calFinSalida.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " AND (EntradaSalidaEquipos.fechaSalida between  '" +
                    calInicioSalida.Value.Day + "-" + calInicioSalida.Value.Month + "-" + calInicioSalida.Value.Year + "' and '" +
                    calFinSalida.Value.Day + "-" + calFinSalida.Value.Month + "-" + calFinSalida.Value.Year + "' )";
            }

            if (chkBuscarSeguimiento.Checked)
            {
                if (calInicioSeg.ValueObject == null || calFinSeg.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " AND (EntradaSalidaEquipos.fechaSeguimiento between  '" +
                    calInicioSeg.Value.Day + "-" + calInicioSeg.Value.Month + "-" + calInicioSeg.Value.Year + "' and '" +
                    calFinSeg.Value.Day + "-" + calFinSeg.Value.Month + "-" + calFinSeg.Value.Year + "' )";
            }

            if (rdTraerSalida.Checked)
            {
                sql += " and EntradaSalidaEquipos.fechaSalida is null ";
            }else if(rdPendientesxSeguimiento.Checked)
            {
                sql += " and EntradaSalidaEquipos.fechaSalida is not null AND EntradaSalidaEquipos.fechaSeguimiento is null ";
            }

            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector(); 
            dsPlantillas1.pltListadoESequipos.Clear();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltListadoESequipos.Merge(objD.ejecutarConsulta(sql + " order by EntradaSalidaEquipos.codEntradaSalidaEquipos desc").Tables[0]);

            if (dsPlantillas1.pltListadoESequipos.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron resultados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbCampo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga una opcion de filtro");
                    return;
                }
                buscar();
            }
        }

        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {

            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESLayt.xs";
            grdDatos.SaveLayout(str);
        }

        private void btnReinicciargrilla_Click(object sender, EventArgs e)
        {
            string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // 
            str += @"\listESLayt.xs";
            System.IO.File.Delete(str);
        }

        private void btnNuevaEntrada_Click(object sender, EventArgs e)
        {
            frmEntradaSalidaEquipos fr = new frmEntradaSalidaEquipos();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                buscar();
            }
        }
    }
}
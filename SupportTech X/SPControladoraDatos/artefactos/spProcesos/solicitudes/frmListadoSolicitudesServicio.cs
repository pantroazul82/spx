using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.solicitudes
{
    public partial class frmListadoSolicitudesServicio : Form
    {
        public frmListadoSolicitudesServicio()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private string generarSql() 
        {
            System.Text.StringBuilder sb= new StringBuilder();
            sb.Append("set dateformat dmy  select ");
sb.Append(" codSolicitudServicio,solicitudservicio.fechaCreacion,solicitudservicio.fechaSugerida,solicitudservicio.fechaAceptacion,usuarios.nombre 'creadaPor',");
sb.Append(" us2.nombre 'aceptadaPor',");
sb.Append(" dbo.vistaEquipo.serial,");
sb.Append(" dbo.vistaEquipo.nombreTipoEquipo,");
sb.Append(" dbo.vistaEquipo.nombreFabricante,");
sb.Append(" dbo.vistaEquipo.NombreModelo,");
sb.Append(" dbo.vistaEquipo.nombreSubTipo");
sb.Append(" ,clientes.nitCliente,clientes.numeroSocio,clientes.nombrecliente,");
sb.Append(" vistaSucursal.nombresucursal,vistaSucursal.nombreCiudad,vistaSucursal.nombreDepartamento,vistaSucursal.nombrepais,");
sb.Append(" modalidadequipo.nombremodalidadequipo,tipoServicio.nombretipoServicio,");
sb.Append(" estadosSolicitud.descripcionSolicitud,prioridadSolicitud.descripcionPrioridad,solicitudservicio.objetoServicio,solicitudservicio.fallasReportadas,solicitudservicio.observaciones,");
sb.Append(" asesoresComerciales.NombreAsesor,medioSolicitud.descripcionMedio,ordenServicio.codOrdenServicio,nombreEstado 'estadoOrdenServicio'");
sb.Append(" ,*");
 sb.Append(" from solicitudservicio");
 sb.Append(" join usuario usuarios on usuarios.login = solicitudservicio.creadaPor");
sb.Append(" left join usuario us2 on us2.login = solicitudservicio.aceptadaPor");
sb.Append(" join clientes on clientes.nitCliente = solicitudservicio.nitcliente");
sb.Append(" join dbo.vistaSucursal on vistaSucursal.nitCliente = solicitudservicio.nitcliente and vistaSucursal.codSucursal = solicitudservicio.codSucursal");
sb.Append(" left join modalidadequipo on modalidadequipo.codModalidadEquipo = solicitudServicio.codModalidad");
sb.Append(" left join tipoServicio on tiposervicio.codTiposervicio = solicitudServicio.codtipoServicio");
sb.Append(" left join estadosSolicitud on estadosSolicitud.codEstadoSolicitud = solicitudServicio.codEstadoSolicitud");
sb.Append(" left join prioridadSolicitud on prioridadSolicitud.codPrioridadSolicitud = solicitudServicio.codPrioridadSolicitud ");
sb.Append(" left join asesoresComerciales on asesoresComerciales.codAsesor= solicitudServicio.codAsesor");
sb.Append(" left join medioSolicitud on medioSolicitud.codmedioSolicitud = solicitudServicio.codMedioSolicitud");
sb.Append(" left join ordenservicio on ordenServicio.codOrdenServicio = solicitudServicio.codOrdenServicio");
sb.Append(" left join estadosOrdenServicio on estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio");
sb.Append(" join dbo.vistaEquipo on vistaEquipo.serial = solicitudServicio.serial");
return sb.ToString();
        }
       
        private void buscar()
        {
            string sql = generarSql()+" WHERE ";

            //agregamos los filtros dependiendo lo escogido en el combo
            switch (cmbFiltro.Text.Trim())
            {
                case "Codigo Solicitud de Servicio": { sql += " codSolicitudServicio like '" + txtFiltro.Text + "%' "; break; }
                case "Serial": { sql += " solicitudservicio.serial like '" + txtFiltro.Text + "%' "; break; }
                case "Nit Cliente": { sql += " solicitudservicio.nitCliente like '" + txtFiltro.Text + "%' "; break; }
            }


            if (chkEntreFechas.Checked)
            {
                if (calfechaInicio.ValueObject == null || calFechaFin.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " and solicitudservicio.fechaCreacion between  '" +
                    calfechaInicio.Value.Day + "-" + calfechaInicio.Value.Month + "-" + calfechaInicio.Value.Year + "' and '" +
                    calFechaFin.Value.Day + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Year + "' ";
            }
            sql = sql + " order by solicitudservicio.fechaCreacion desc ";
            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoSolicitudServicio.Clear();
            dsPlantillas1.pltListadoSolicitudServicio.Merge(objD.ejecutarConsulta(sql).Tables[0]);
            if (dsPlantillas1.pltListadoSolicitudServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron resultados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmListadoOrdenesServicio_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 0;
    
            //cargamos las ultimas 100 solicitudes por fecha que no esten en el siguiente estado
            //3 RECHAZADA 4 CERRADA
            string sql = generarSql() + " WHERE estadosSolicitud.codEstadoSolicitud != 3 AND estadosSolicitud.codEstadoSolicitud != 4 " + " order by solicitudservicio.fechaCreacion desc ";
            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltListadoSolicitudServicio.Merge(objD.ejecutarConsulta(sql).Tables[0]);

            cmbEstados.DataSource=
                objD.ejecutarConsulta(
            sql = @"select cod_estado_solicitud_general,
nombre_estado_solicitud from estado_solicitud_general order by nombre_estado_solicitud ").Tables[0];

            cmbEstados.DisplayMember = "nombre_estado_solicitud";
            cmbEstados.ValueMember = "cod_estado_solicitud_general";

        }

        private void btnFiltrarxEstado_Click(object sender, EventArgs e)
        {
            if (cmbEstados.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Escoga un estado!!!!","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            string sql = generarSql() + " where estadosSolicitud.codEstadoSolicitud='" + cmbEstados.SelectedValue.ToString() + "'";
            if (chkEntreFechas.Checked) 
            {
                if (calfechaInicio.ValueObject == null || calFechaFin.ValueObject == null) 
                {
                    MessageBox.Show("Seleccione un periodo valido","Error de fechas",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                sql += " and estadosSolicitud.fechaCreacion between  '" +
                    calfechaInicio.Value.Day + "-" + calfechaInicio.Value.Month + "-" + calfechaInicio.Value.Year + "' and '" +
                    calFechaFin.Value.Day + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Year + "' ";
            }
            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoSolicitudServicio.Clear();
            dsPlantillas1.pltListadoSolicitudServicio.Merge(objD.ejecutarConsulta(sql).Tables[0]);
            if (dsPlantillas1.pltListadoSolicitudServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron resultados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerOrdenServicio_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codSolicitudServicio"].Text != string.Empty) 
            {
                //aca se deberian verificar permisos
                solicitudes.frmSolicitudServicio frmObj = new frmSolicitudServicio();
                frmObj.CodSolicitud = int.Parse( grdDatos.Columns["codSolicitudServicio"].Text);
                frmObj.Show();
            } 
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buscar();
            }
        }
    }
}

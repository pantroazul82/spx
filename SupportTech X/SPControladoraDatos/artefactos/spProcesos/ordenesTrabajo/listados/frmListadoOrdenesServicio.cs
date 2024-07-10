using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo
{
    public partial class frmListadoOrdenesServicio : Form
    {
        public frmListadoOrdenesServicio()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private bool per_programaOrden = false;
        private bool per_reasignaOrden = false;
        private bool per_cierraOrden = false;
        private bool per_apruebaOrden = false;
        private bool per_anulaOrden = false;
        private bool per_realizaOrden = false;
        private bool per_modificaOrden = false;//este permite modificar la orden en cualquier estado de la misma

        private void cargarPermisos()
        {
            per_programaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1060);
            per_reasignaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1063);
            per_cierraOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1023);
            per_apruebaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1014);
            per_anulaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1011);
            per_realizaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1063);
            per_modificaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1052);
        }
        
        public string generaFiltrosxPermiso() 
        {
            string filtro = "";
            //Configuramos los filtros de acuerdo a los permisos
            if (per_anulaOrden || per_modificaOrden) return "";
            //si puede anular o modificar orden puede ver todas las 
            if (  per_apruebaOrden || per_cierraOrden || per_modificaOrden
                || per_programaOrden || per_reasignaOrden) return "";
            //en el momento habilitamos que quienes tengan mas permisos puedan verlas todas mas adelante se pueden filtrar
            //por su estado

            //el que solamente tiene el permiso realiza orden de trabajo solo puede ver las 
            if (per_realizaOrden)
            {
                if (filtro.Length > 0) filtro += " OR ";
                filtro += " asignadoA = '" + SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() + "'";
            }

           

            //realiza orden solo puede ver las asignadas a el
            return " AND ("+filtro+")";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
       
        private void buscar()
        {
            #region va la cadena de la plantilla
            string sql = "   set dateformat dmy             select " +
" codOrdenServicio, fechaCreacion, fechaProgramacion, fechaFinProgramacion, " +
" fechaCierre, fechaAprobacion, fechaAnulacion, " +
" us1.nombre 'creadaPor',us4.nombre 'asignadoA' " +
" ,us5.nombre 'cerradaPor',us6.nombre 'aprobadaPor', " +
 " us7.nombre 'anuladaPor', esInterno,  " +
" v.nombreFabricante,v.NombreModelo,v.nombreTipoEquipo, " +
" v.nombreSubTipo,v.serial 'serial', " +
" clientes.nombreCliente,clientes.nitCliente, " +
" v2.nombreSucursal,v2.NombreDepartamento,v2.nombreCiudad, " +
" tipoServicio.nombretipoServicio, modalidadequipo.nombreModalidadEquipo, " +
" estadosOrdenServicio.nombreEstado, " +
 " prioridadesOrdenServicio.nombre 'prioridad', " +
" observaciones, observacionesIngeniero, fallasReportadas, diagnostico, numEntrada, horaEntradaControl, " +
 " horaSalidaControl, nombreUsuarioCliente, asesoresComerciales.NombreAsesor,mantenimientoSegunIndicaciones,fechaUltimoMantenimientoxUsuario " +
 " from ordenServicio  " +
" left join usuario  us1 on us1.login = ordenServicio.creadaPor " +
" left join usuario  us4 on us4.login = ordenServicio.asignadoA " +
" left join usuario  us5 on us5.login = ordenServicio.cerradaPor " +
" left join usuario  us6 on us6.login = ordenServicio.aprobadaPor " +
" left join usuario  us7 on us7.login = ordenServicio.anuladaPor " +
"  " +
" left join modalidadEquipo on modalidadEquipo.codModalidadEquipo = ordenServicio.codModalidad " +
" left join asesoresComerciales on asesoresComerciales.codAsesor = ordenServicio.codAsesor " +
" join dbo.vistaEquipo v on v.serial = ordenServicio.serial " +
" join clientes on clientes.nitCliente = ordenServicio.nitcliente " +
" join dbo.VistaSucursal  v2 on v2.nitCliente = ordenServicio.nitCliente and v2.codSucursal = ordenServicio.codSucursal " +
" left join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio " +
" join estadosOrdenServicio on estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio " +
" left join prioridadesOrdenServicio on prioridadesOrdenServicio.codPrioridadOS = ordenServicio.codPrioridadOS ";

            #endregion

 sql+=" WHERE ";

            //agregamos los filtros dependiendo lo escogido en el combo
            switch (cmbFiltro.Text)
            {
                case "Codigo Orden de Servicio": { sql += " ordenServicio.codOrdenservicio like '" + txtFiltro.Text + "%' "; break; }
                case "Numero de Entrada": { sql += " ordenServicio.numentrada like '" + txtFiltro.Text + "%' "; break; }
                case "Serial": { sql += " ordenServicio.serial like '" + txtFiltro.Text + "%' "; break; }
                case "Nit Cliente": { sql += " ordenServicio.nitCliente like '" + txtFiltro.Text + "%' "; break; }
                case "Cliente": { sql += "  clientes.nombreCliente like '" + txtFiltro.Text + "%' "; break; }
                case "Numero Socio": { sql += " clientes.numeroSocio like '" + txtFiltro.Text + "%' "; break; }
                case "Modelo": { sql += " nombreModelo like '" + txtFiltro.Text + "%' "; break; }
                case "Ciudad": { sql += " v2.nombreciudad like '" + txtFiltro.Text + "%' "; break; }
                case "Departamento": { sql += " v2.nombreDepartamento like '" + txtFiltro.Text + "%' "; break; }
            }


            if (chkEntreFechas.Checked)
            {
                if (calfechaInicio.ValueObject == null || calFechaFin.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " and ordenServicio.fechaCreacion between  '" +
                    calfechaInicio.Value.Day + "-" + calfechaInicio.Value.Month + "-" + calfechaInicio.Value.Year + "' and '" +
                    calFechaFin.Value.Day + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Year + "' ";
            }

            if (chkProgramadas.Checked)
            {
                if (calInicioProgramadas.ValueObject == null || calFinProgramadas.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido, en el rango de programacion!", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += "  and (ordenServicio.fechaProgramacion is not null and ordenServicio.fechaProgramacion between  '" +
                    calInicioProgramadas.Value.Day + "-" + calInicioProgramadas.Value.Month + "-" + calInicioProgramadas.Value.Year + "' and '" +
                    calFinProgramadas.Value.Day + "-" + calFinProgramadas.Value.Month + "-" + calFinProgramadas.Value.Year + "') ";
            }

            if (chkFechasCerradas.Checked)
            {
                if (calInicioCerrada.ValueObject == null || calFinCerrada.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido para las fechas de ciere.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += "  and ( ordenServicio.fechaCierre is not null and ordenServicio.fechaCierre between  '" +
                    calInicioCerrada.Value.Day + "-" + calInicioCerrada.Value.Month + "-" + calInicioCerrada.Value.Year + "' and '" +
                    calFinCerrada.Value.Day + "-" + calFinCerrada.Value.Month + "-" + calFinCerrada.Value.Year + "' )";
            }

            if (chkAprobadas.Checked)
            {
                if (calInicioAprobadas.ValueObject == null || calFinAprobada.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido, para las fechas de aprobacion.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " and (ordenServicio.fechaAprobacion is not null and ordenServicio.fechaAprobacion between  '" +
                    calInicioAprobadas.Value.Day + "-" + calInicioAprobadas.Value.Month + "-" + calInicioAprobadas.Value.Year + "' and '" +
                    calFinAprobada.Value.Day + "-" + calFinAprobada.Value.Month + "-" + calFinAprobada.Value.Year + "') ";
            }
            sql += generaFiltrosxPermiso();
            //solicitaron un permiso especial para que los ingneieros vean solo las ordenes que tienen asignadas
            if (SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(2052))
            {
                
                    sql = sql+ " AND asignadoA = '" + SPXSeguridad.logica.sesion.LoginUsuarioAutenticado.Trim() + "'";
                
            }

            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoOrdenServicio.Clear();
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltListadoOrdenServicio.Merge(objD.ejecutarConsulta(sql + " order by ordenServicio.codOrdenservicio desc").Tables[0]);
            if (dsPlantillas1.pltListadoOrdenServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron resultados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmListadoOrdenesServicio_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            chkEntreFechas.Checked = true;
            calFinProgramadas.Value = n.AddDays(1);
            calInicioProgramadas.Value = new DateTime(n.AddMonths(-2).Year, n.AddMonths(-2).Month, 1);

            
            calFechaFin.Value = n.AddDays(1);
            calfechaInicio.Value = new DateTime(n.AddMonths(-2).Year, n.AddMonths(-2).Month, 1);

            calFinAprobada.Value =n.AddDays(1);
            calInicioAprobadas.Value = new DateTime(n.AddMonths(-2).Year, n.AddMonths(-2).Month, 1);

            calFinCerrada.Value = n.AddDays(1);
            calInicioCerrada.Value = new DateTime(n.AddMonths(-2).Year, n.AddMonths(-2).Month, 1);
            

             cmbFiltro.SelectedIndex = 0;
            estadosOrdenServicioTableAdapter1.Fill(dsSpx1.estadosOrdenServicio);
            cargarPermisos();
        }

        private void btnFiltrarxEstado_Click(object sender, EventArgs e)
        {
            if (cmbEstados.Text.Trim() == string.Empty) 
            {
                MessageBox.Show("Escoga un estado!!!!","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            #region va la cadena de la plantilla
            string sql = "    set dateformat dmy            select " +
" codOrdenServicio, fechaCreacion, fechaProgramacion, fechaFinProgramacion, " +
" fechaCierre, fechaAprobacion, fechaAnulacion, " +
" us1.nombre 'creadaPor',us4.nombre 'asignadoA' " +
" ,us5.nombre 'cerradaPor',us6.nombre 'aprobadaPor', " +
 " us7.nombre 'anuladaPor', esInterno,  " +
" v.nombreFabricante,v.NombreModelo,v.nombreTipoEquipo, " +
" v.nombreSubTipo,v.serial 'serial', " +
" clientes.nombreCliente,clientes.nitCliente, " +
" v2.nombreSucursal,v2.NombreDepartamento,v2.nombreCiudad, " +
" tipoServicio.nombretipoServicio, modalidadequipo.nombreModalidadEquipo, " +
" estadosOrdenServicio.nombreEstado, " +
 " prioridadesOrdenServicio.nombre 'prioridad', " +
" observaciones, observacionesIngeniero, fallasReportadas, diagnostico, numEntrada, horaEntradaControl, " +
 " horaSalidaControl, nombreUsuarioCliente, asesoresComerciales.NombreAsesor, " +
 "mantenimientoSegunIndicaciones,fechaUltimoMantenimientoxUsuario" +
 " from ordenServicio  " +
" left join usuario  us1 on us1.login = ordenServicio.creadaPor " +
" left join usuario  us4 on us4.login = ordenServicio.asignadoA " +
" left join usuario  us5 on us5.login = ordenServicio.cerradaPor " +
" left join usuario  us6 on us6.login = ordenServicio.aprobadaPor " +
" left join usuario  us7 on us7.login = ordenServicio.anuladaPor " +
"  " +
" left join modalidadEquipo on modalidadEquipo.codModalidadEquipo = ordenServicio.codModalidad " +
" left join asesoresComerciales on asesoresComerciales.codAsesor = ordenServicio.codAsesor " +
" join dbo.vistaEquipo v on v.serial = ordenServicio.serial " +
" join clientes on clientes.nitCliente = ordenServicio.nitcliente " +
" join dbo.VistaSucursal  v2 on v2.nitCliente = ordenServicio.nitCliente and v2.codSucursal = ordenServicio.codSucursal " +
" join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio " +
" join estadosOrdenServicio on estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio " +
" join prioridadesOrdenServicio on prioridadesOrdenServicio.codPrioridadOS = ordenServicio.codPrioridadOS ";

            #endregion
            sql+=" where ordenServicio.codEstadoOrdenservicio='" + cmbEstados.SelectedValue.ToString() + "'";
            if (chkEntreFechas.Checked) 
            {
                if (calfechaInicio.ValueObject == null || calFechaFin.ValueObject == null) 
                {
                    MessageBox.Show("Seleccione un periodo valido para las fechas de Ordenes de servicio.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " and ordenServicio.fechaCreacion between  '" +
                    calfechaInicio.Value.Day + "-" + calfechaInicio.Value.Month + "-" + calfechaInicio.Value.Year + "' and '" +
                    calFechaFin.Value.Day + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Year + "' ";
            }

            if (chkFechasCerradas.Checked)
            {
                if (calInicioCerrada.ValueObject == null || calFinCerrada.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido para las fechas de ciere.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += "  and ( ordenServicio.fechaCierre is not null and ordenServicio.fechaCierre between  '" +
                    calInicioCerrada.Value.Day + "-" + calInicioCerrada.Value.Month + "-" + calInicioCerrada.Value.Year + "' and '" +
                    calFinCerrada.Value.Day + "-" + calFinCerrada.Value.Month + "-" + calFinCerrada.Value.Year + "' )";
            }

            if (chkAprobadas.Checked)
            {
                if (calInicioAprobadas.ValueObject == null || calFinAprobada.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo valido, para las fechas de aprobacion.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sql += " and (ordenServicio.fechaAprobacion is not null and ordenServicio.fechaAprobacion between  '" +
                    calInicioAprobadas.Value.Day + "-" + calInicioAprobadas.Value.Month + "-" + calInicioAprobadas.Value.Year + "' and '" +
                    calFinAprobada.Value.Day + "-" + calFinAprobada.Value.Month + "-" + calFinAprobada.Value.Year + "') ";
            }
            SPXdata.BD.DataConector objD = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoOrdenServicio.Clear();
            dsPlantillas1.pltListadoOrdenServicio.Merge(objD.ejecutarConsulta(sql).Tables[0]);
            if (dsPlantillas1.pltListadoOrdenServicio.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron resultados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerOrdenServicio_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codOrdenServicio"].Text != string.Empty) 
            {
                //aca se deberian verificar permisos
                ordenesTrabajo.frmNuevaOrdenTrabajo frmObj = new frmNuevaOrdenTrabajo();
                frmObj.CodOrdenServicio = grdDatos.Columns["codOrdenServicio"].Text;
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

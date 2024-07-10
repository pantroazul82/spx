using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.recolecciones
{
    public partial class frmListadoRecolecciones : Form
    {
        public frmListadoRecolecciones()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string generarSql() 
        {
        System.Text.StringBuilder sb= new StringBuilder();
        sb.Append(" select datediff(day,fechaSolicitud,fechaRecoleccion) - dbo.d_festivos(fechaSolicitud,fechaRecoleccion) 'dias',nombreModalidadEquipo,");
sb.Append(" codRecoleccion, fechaSolicitud,  ");
sb.Append(" us1.nombre 'solicitadoPor', nombreEstadoRecoleccion, ");
sb.Append(" observacionesSolicitud, motivoRecoleccion, fechaTentativaLlegada,  ");
sb.Append(" us2.nombre 'responsableRecoleccion', ");
sb.Append(" nombreTransportadora, codRecoleccionTransportadora, nroGuia, obsIniciales, confirmada,  ");
sb.Append(" us3.nombre 'confirmadaPor', fechaConfirmacion, obsConfirmacion, fechaRecoleccion, codEntradaSalidaEquipos, ");

sb.Append(" clientes.nitCliente,clientes.nombreCliente, ");
sb.Append(" paises.nombrePais,departamento.NombreDepartamento,ciudades.nombreCiudad, ");
sb.Append(" tipoEquipo.nombreTipoEquipo, subTipoEquipo.nombreSubTipo,Modelos.NombreModelo,fabricante.nombre_fabricante, ");
sb.Append(" equipos.serial ");
sb.Append(" ,sucursalCliente.nombreSucursal,retiro_definitivo ");
sb.Append(" from recoleccion  ");
sb.Append(" left join estadoRecoleccion on estadoRecoleccion.codEstadoRecoleccion = recoleccion.codEstadoRecoleccion ");
sb.Append(" left join transportadora on transportadora.codTransportadora = recoleccion.codTransportadora ");
sb.Append(" left join clientes on clientes.nitCliente = recoleccion.nitCliente ");
sb.Append(" left join sucursalCliente on sucursalCliente.nitCliente = recoleccion.nitCliente and sucursalCliente.codSucursal = recoleccion.codSucursal  ");
sb.Append(" left join paises on paises.codPais = sucursalCliente.codPais ");
sb.Append(" left join departamentos departamento on departamento.codPais = sucursalCliente.codPais and departamento.codDepartamento = sucursalCliente.codDepartamento ");
sb.Append(" left join ciudades on ciudades.codPais = sucursalCliente.codPais and ciudades.codDepartamento = sucursalCliente.codDepartamento and ciudades.codCiudad = sucursalCliente.codCiudad ");
sb.Append(" left join equipos on equipos.serial = recoleccion.serial ");
sb.Append(" left join ModalidadEquipo on equipos.codModalidadEquipo = ModalidadEquipo.codModalidadEquipo ");
sb.Append(" left join fabricante on fabricante.codFabricante = equipos.codFabricante ");
            sb.Append(" left join Modelos on Modelos.codFabricante = fabricante.codFabricante and Modelos.codModelo = equipos.codModelo ");
            sb.Append(" left join tipoEquipo on tipoEquipo.codTipoEquipo = Modelos.codTipoEquipo ");
            sb.Append(" left join subTipoEquipo on subTipoEquipo.codTipoEquipo = Modelos.codTipoEquipo and subTipoEquipo.codSubtipoEquipo = Modelos.codSubTipoEquipo ");
sb.Append(" left join usuario us1 on us1.login = recoleccion.solicitadoPor ");
sb.Append(" left join usuario us2 on us2.login = recoleccion.responsableRecoleccion ");
sb.Append(" left join usuario us3 on us3.login = recoleccion.confirmadaPor ");
    return sb.ToString();
        }

        private void frmListadoRecolecciones_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            dsPlantillas1.EnforceConstraints = false;
            cmbFiltro.SelectedIndex = 0;
            calFechaFin.MonthCalendar.DisplayMonth =n;
            calfechaInicio.MonthCalendar.DisplayMonth = n;
            //buscamos los que estan en los siguientes estados
            //por asignar transportadora 2
            //en confirmacion 3
            buscarPendientes();
        }

        private void btnVerRecoleccion_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["codRecoleccion"].Text.Trim() == string.Empty) return;
            recolecciones.frmNuevaRecoleccion fr = new frmNuevaRecoleccion();
            fr.CodRecoleccion = int.Parse(grdDatos.Columns["codRecoleccion"].Text);
            fr.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        
        private void buscar()
        {
            string sql = generarSql();
            //generamos el filtro
            sql = sql + " " + verFiltro();
            if(chkEntreFechas.Checked && (calFechaFin.ValueObject==null || calfechaInicio.ValueObject==null))
                return;
            dsPlantillas1.pltListadoRecoleccion.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoRecoleccion.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }

        private void buscarPendientes()
        {
            string sql = generarSql();
            //generamos el filtro
            sql = sql + " WHERE estadoRecoleccion.codEstadoRecoleccion <= 3";
            dsPlantillas1.pltListadoRecoleccion.Clear();
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsPlantillas1.pltListadoRecoleccion.Merge(objData.ejecutarConsulta(sql).Tables[0]);
        }

        private string verFiltro() 
        {
            string filtro=cmbFiltro.Text.Trim();
            if(filtro == "Codigo Recoleccion"){
                filtro = " codRecoleccion like '"+txtFiltro.Text+"%'";
            }
            else if (filtro == "Estado")
            {
                filtro = " estadoRecoleccion.nombreEstadoRecoleccion like '" + txtFiltro.Text + "%'";
            }
            else if (filtro == "Numero de Entrada")
            {
                filtro = " codEntradaSalidaEquipos like '" + txtFiltro.Text + "%'";
            }
            else if (filtro == "Serial")
            {
                filtro = " recoleccion.serial  like '" + txtFiltro.Text + "%'";
            }
            else if (filtro == "Nit Cliente")
            {
                filtro = " recoleccion.nitCliente like '" + txtFiltro.Text + "%'";
            }
            else if (filtro == "Cliente")
            {
                filtro = " nombreCliente like '" + txtFiltro.Text + "%'";
            }
            if (chkEntreFechas.Checked)
            {
                if (calFechaFin.ValueObject == null || calfechaInicio.ValueObject == null)
                {
                    MessageBox.Show("Seleccione un periodo de fecha Valido!");
                    return "";
                }
                filtro = filtro +" and fechaTentativaLlegada between"+
                    " '" + calfechaInicio.Value.Year + "/" + calfechaInicio.Value.Month.ToString().PadLeft(2, '0') + "/" + calfechaInicio.Value.Day.ToString().PadLeft(2, '0') + "' and " +
                    " '" + calFechaFin.Value.Year + "/" + calFechaFin.Value.Month.ToString().PadLeft(2, '0') + "/" + calFechaFin.Value.Day.ToString().PadLeft(2, '0') + "'";

    
            }
            return " WHERE "+filtro;
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscar();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            spProcesos.recolecciones.frmNuevaRecoleccion objfrm = new spProcesos.recolecciones.frmNuevaRecoleccion();
            if (SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1031))
            {
                objfrm.Show();
            }
            else {
                MessageBox.Show("No tiene permisos para crear recolecciones");
            }
            
        }
    }
}

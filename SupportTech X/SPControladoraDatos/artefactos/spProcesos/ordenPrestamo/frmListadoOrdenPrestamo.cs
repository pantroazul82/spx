using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenPrestamo
{
    public partial class frmListadoOrdenPrestamo : Form
    {
        public frmListadoOrdenPrestamo()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdOrdenPrestamo;
        }

        bool solop = false;
        bool solopxotro = false;
        bool autop = false;
        bool acepop = false;
        bool recibop = false;
        bool anuop = false;
        bool listaop = false;
         
        private void cargarPermisos()
        {

            solop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1079);
            solopxotro = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1080);
            autop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1017);
            acepop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1002);
            recibop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1104);
            anuop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1010);
            listaop = SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1083);        
        }

        private string generarSQL() 
        {
        System.Text.StringBuilder sb= new StringBuilder();
        sb.Append(" set dateformat dmy select  numeroFactura,numeroNotaSalida,");
        sb.Append(" codOrdenPrestamo,nombreestadoOp,codOrdenServicio ");
        sb.Append(" ,u1.nombre as 'responsable', loginResponsable,u2.nombre as 'SolicitadoPor' ,loginSolicito,obsIniciales ");
sb.Append(" ,u3.nombre as 'AutorizadoPor',loginAutorizo,obsAprobacion ");
sb.Append(" ,u4.nombre as 'AceptadoPor',loginAceptado ,obsEntrega, ");
sb.Append(" u5.nombre as 'recibido', loginRecibido,obsDevolucion ");
sb.Append(" ,u6.nombre as 'AnuladoPor' ,loginAnulo, ");
sb.Append(" fechaOrden, ");
sb.Append(" fechaDevolucion,paises.nombrePais,departamento.NombreDepartamento, ");
sb.Append(" ciudades.nombreCiudad,anulada ");
sb.Append(" from ordenPrestamo ");
sb.Append(" left join estadosOrdenPrestamo on estadosOrdenPrestamo.codestadoOrdenPrestamo= ordenPrestamo.codEstadoOrdenPrestamo ");
sb.Append(" left join usuario u1 on  ");
sb.Append(" u1.login = ordenPrestamo.loginResponsable ");
sb.Append(" left join usuario u2 on  ");
sb.Append(" u2.login = ordenPrestamo.loginSolicito ");
sb.Append(" left join usuario u3 on  ");
sb.Append(" u3.login = ordenPrestamo.loginAutorizo ");
sb.Append(" left join usuario u4 on  ");
sb.Append(" u4.login = ordenPrestamo.loginAceptado ");
sb.Append(" left join usuario u5 on  ");
sb.Append(" u5.login = ordenPrestamo.loginRecibido ");
sb.Append(" left join usuario u6 on  ");
sb.Append(" u6.login = ordenPrestamo.loginAnulo ");
sb.Append(" join paises on  ");
sb.Append(" paises.codPais = ordenPrestamo.codPais ");
sb.Append(" join departamentos departamento on  ");
sb.Append(" departamento.codPais = ordenPrestamo.codPais and departamento.codDepartamento = ordenPrestamo.codDepartamento  ");
sb.Append(" join ciudades on  ");
sb.Append(" ciudades.codPais = ordenPrestamo.codPais and ciudades.codDepartamento = ordenPrestamo.codDepartamento  ");
sb.Append(" and ciudades.codCiudad = ordenPrestamo.codCiudad ");
return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string generarFiltros() 
        {
            System.Text.StringBuilder sb = new StringBuilder();
            
            
            //primero filtros del combo
            if (cmbFiltro.Text.Trim() == "Codigo Orden de Servicio")
            {
                sb.Append(" codOrdenServicio like '" + txtFiltro.Text.Trim() + "%' ");
            }else
            if (cmbFiltro.Text.Trim() == "Codigo Orden de Prestamo")
            {
                sb.Append(" codOrdenPrestamo like '" + txtFiltro.Text.Trim() + "%' ");
            }else if (cmbFiltro.Text.Trim() == "Estado Orden Prestamo")
            {
                sb.Append(" estadosOrdenPrestamo.nombreEstadoOP like '" + txtFiltro.Text.Trim() + "%' ");
            }
            else if (cmbFiltro.Text.Trim() == "Solicitado Por")
            {
                sb.Append(" u2.nombre like '" + txtFiltro.Text.Trim() + "%' ");
            }
            
            if (chkEntreFechas.Checked)
            {
                sb.Append(" AND (fechaOrden between '"+calfechaInicio.Value.Day +"-"+calfechaInicio.Value.Month+"-"+calfechaInicio.Value.Year+"' ");
                sb.Append(" and '" + calFechaFin.Value.Day + "-" + calFechaFin.Value.Month + "-" + calFechaFin.Value.Year + "' )");
            }

           //filtros x estado 
           if (!chkPendientesxAutorizacion.Checked)sb.Append(" AND estadosOrdenPrestamo.codEstadoOrdenPrestamo != 1");
           if (!chkautorizadas.Checked)sb.Append(" AND estadosOrdenPrestamo.codEstadoOrdenPrestamo !=2 ");
           if (!chkRechazadas.Checked)sb.Append(" AND estadosOrdenPrestamo.codEstadoOrdenPrestamo !=3 ");
           if (!chkEntregadosIng.Checked)sb.Append(" AND estadosOrdenPrestamo.codEstadoOrdenPrestamo != 4 AND estadosOrdenPrestamo.codEstadoOrdenPrestamo != 5 ");
           if (!chkDevueltos.Checked)sb.Append(" AND estadosOrdenPrestamo.codEstadoOrdenPrestamo !=6  AND estadosOrdenPrestamo.codEstadoOrdenPrestamo !=7");
           if(!chkAnuladas.Checked)sb.Append(" AND estadosOrdenPrestamo.codEstadoOrdenPrestamo != 8");            
           //filtros por permiso
           //pendiente los filtros de acuerdo a los permisos de la orden de prestamo


            return sb.ToString();
        }

        private void buscar() 
        {
            dsPlantillas1.pltOrdenPrestamo.Clear();
            string sql = generarSQL()+" WHERE "+generarFiltros()+" order by codOrdenPrestamo desc";
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            //configuramos los filtros
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltOrdenPrestamo.Merge( objData.ejecutarConsulta(sql).Tables[0] );
            //ahora ajustamos la grilla estadisitca de estados
            estadosOrdenPrestamoTableAdapter1.Fill(dsSpx1.estadosOrdenPrestamo);
            dsSpx1.estadosOrdenPrestamo.descripcionEstadoOPColumn.ReadOnly = false;
            for (int k = 0; k < dsSpx1.estadosOrdenPrestamo.Count; k++)
            {
                dsSpx1.estadosOrdenPrestamo[k].descripcionEstadoOP =
                    dsPlantillas1.pltOrdenPrestamo.Select("nombreestadoOp ='" + dsSpx1.estadosOrdenPrestamo[k].nombreEstadoOP +"'").Length.ToString();
            }
        }

        private void frmListadoOrdenPrestamo_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            chkEntreFechas.Checked = true;
            calFechaFin.Value = n.AddDays(1);
            calfechaInicio.Value = new DateTime(n.AddMonths(-2).Year, n.AddMonths(-2).Month, 1);
            cmbFiltro.SelectedIndex = 0;
            cargarPermisos();
        }

        private void btnVerOrdenServicio_Click(object sender, EventArgs e)
        {
            if (grdOrdenPrestamo.Columns["codOrdenPrestamo"].Text.Trim() == string.Empty) return;
            ordenPrestamo.frmNuevaOrdenPrestamo fr = new ordenPrestamo.frmNuevaOrdenPrestamo();
            fr.CodOrdenPrestamo = int.Parse(grdOrdenPrestamo.Columns["codOrdenPrestamo"].Text);
            fr.Icon = this.Icon;
            fr.Show();
        }

        private void btnVerOrdenServicio2_Click(object sender, EventArgs e)
        {
            if (grdOrdenPrestamo.Columns["codOrdenServicio"].Text.Trim() == string.Empty) return;
            spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo fr = new spProcesos.ordenesTrabajo.frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdOrdenPrestamo.Columns["codOrdenServicio"].Text;
            fr.Icon = this.Icon;
            fr.Show();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}

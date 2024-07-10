using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spHerramientas.consultas
{
    public partial class frmIndMantProgxReal : Form
    {
        public frmIndMantProgxReal()
        {
            InitializeComponent();
        }

        private void dateTimeInput1_Click(object sender, EventArgs e)
        {

        }

        private void frmIndMantProgxReal_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calDesde.Value = new DateTime(n.Year, n.Month, 1);
            calHasta.Value = n;
        }

        private string generarSql() 
        {
            System.Text.StringBuilder sb= new StringBuilder();
            
        sb.Append(" select  ");

sb.Append(" codOrdenServicio, fechaCreacion, fechaProgramacion, fechaFinProgramacion, ");
sb.Append(" fechaCierre, fechaAprobacion, fechaAnulacion, ");
sb.Append(" us1.nombre 'creadaPor',us4.nombre 'asignadoA' ");
sb.Append(" ,us5.nombre 'cerradaPor',us6.nombre 'aprobadaPor', ");
 sb.Append(" us7.nombre 'anuladaPor', esInterno,  ");
sb.Append(" v.nombreFabricante,v.NombreModelo,v.nombreTipoEquipo, ");
sb.Append(" v.nombreSubTipo,v.serial 'serial', ");
sb.Append(" clientes.nombreCliente,clientes.nitCliente, ");
sb.Append(" v2.nombreSucursal,v2.NombreDepartamento,v2.nombreCiudad, ");
sb.Append(" tipoServicio.nombretipoServicio, modalidadequipo.nombreModalidadEquipo, ");
sb.Append(" estadosOrdenServicio.nombreEstado, ");
 sb.Append(" prioridadesOrdenServicio.nombre 'prioridad', ");
sb.Append(" observaciones, observacionesIngeniero, fallasReportadas, diagnostico, numEntrada, horaEntradaControl, ");
 sb.Append(" horaSalidaControl, nombreUsuarioCliente, asesoresComerciales.NombreAsesor ");

sb.Append("  from ordenServicio  ");

sb.Append(" left join usuario  us1 on us1.login = ordenServicio.creadaPor ");

sb.Append(" left join usuario  us4 on us4.login = ordenServicio.asignadoA ");
sb.Append(" left join usuario  us5 on us5.login = ordenServicio.cerradaPor ");
sb.Append(" left join usuario  us6 on us6.login = ordenServicio.aprobadaPor ");
sb.Append(" left join usuario  us7 on us7.login = ordenServicio.anuladaPor ");
sb.Append("  ");
sb.Append(" left join modalidadEquipo on modalidadEquipo.codModalidadEquipo = ordenServicio.codModalidad ");
sb.Append(" left join asesoresComerciales on asesoresComerciales.codAsesor = ordenServicio.codAsesor ");
sb.Append(" join dbo.vistaEquipo v on v.serial = ordenServicio.serial ");
sb.Append(" join clientes on clientes.nitCliente = ordenServicio.nitcliente ");


sb.Append(" join dbo.VistaSucursal  v2 on v2.nitCliente = ordenServicio.nitCliente and v2.codSucursal = ordenServicio.codSucursal ");
sb.Append(" join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio ");

sb.Append(" join estadosOrdenServicio on estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio ");
sb.Append(" join prioridadesOrdenServicio on prioridadesOrdenServicio.codPrioridadOS = ordenServicio.codPrioridadOS ");
return  sb.ToString();
        }

        #region zona de filtros
        private void habilitarFiltro(int filtro)
        {

            if (filtro == 1)
            {
                cmbFiltro2.Visible = false;
                cmbFiltro3.Visible = false;
                cmbFiltro4.Visible = false;
                //-
                txtFiltro2.Visible = false;
                txtFiltro3.Visible = false;
                txtFiltro4.Visible = false;
                //--
                btnAgregarFiltro1.Visible = true;
                btnAgregarFiltro2.Visible = false;
                btnAgregarFilrto3.Visible = false;
                btnQuitarFiltro2.Visible = false;
                btnQuitarFiltro3.Visible = false;
                btnQuitarFiltro4.Visible = false;
            }
            else if (filtro == 2)
            {
                cmbFiltro2.Visible = true;
                cmbFiltro3.Visible = false;
                cmbFiltro4.Visible = false;
                //-
                txtFiltro2.Visible = true;
                txtFiltro3.Visible = false;
                txtFiltro4.Visible = false;
                //--
                btnAgregarFiltro1.Visible = false;
                btnAgregarFiltro2.Visible = true;
                btnAgregarFilrto3.Visible = false;
                btnQuitarFiltro2.Visible = true;
                btnQuitarFiltro3.Visible = false;
                btnQuitarFiltro4.Visible = false;
            }
            else if (filtro == 3)
            {
                cmbFiltro2.Visible = true;
                cmbFiltro3.Visible = true;
                cmbFiltro4.Visible = false;
                //-
                txtFiltro2.Visible = true;
                txtFiltro3.Visible = true;
                txtFiltro4.Visible = false;
                //--
                btnAgregarFiltro1.Visible = false;
                btnAgregarFiltro2.Visible = false;
                btnAgregarFilrto3.Visible = true;
                btnQuitarFiltro2.Visible = false;
                btnQuitarFiltro3.Visible = true;
                btnQuitarFiltro4.Visible = false;
            }
            else if (filtro == 4)
            {
                cmbFiltro2.Visible = true;
                cmbFiltro3.Visible = true;
                cmbFiltro4.Visible = true;
                //-
                txtFiltro2.Visible = true;
                txtFiltro3.Visible = true;
                txtFiltro4.Visible = true;
                //--
                btnAgregarFiltro1.Visible = false;
                btnAgregarFiltro2.Visible = false;
                btnAgregarFilrto3.Visible = false;
                btnQuitarFiltro2.Visible = false;
                btnQuitarFiltro3.Visible = false;
                btnQuitarFiltro4.Visible = true;
            }

        }

        private bool validarFiltro()
        {
            if (cmbFiltro2.Visible == true && (txtFiltro2.Text.Trim() == string.Empty || cmbFiltro2.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Ingrese un Valor para el filtro Dos");
                txtFiltro2.Focus();
                return false;
            }
            else if (cmbFiltro3.Visible == true && (txtFiltro3.Text.Trim() == string.Empty || cmbFiltro3.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Ingrese un Valor para el filtro Tres");
                txtFiltro3.Focus();
                return false;
            }
            else if (cmbFiltro4.Visible == true && (txtFiltro4.Text.Trim() == string.Empty || cmbFiltro4.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Ingrese un Valor para el filtro Cuatro");
                txtFiltro4.Focus();
                return false;
            }

            return true;
        }

        private void btnQuitarFiltro4_Click(object sender, EventArgs e)
        {
            habilitarFiltro(3);
        }

        private void btnAgregarFiltro1_Click(object sender, EventArgs e)
        {
            habilitarFiltro(2);
        }

        private void btnAgregarFiltro2_Click(object sender, EventArgs e)
        {
            habilitarFiltro(3);
        }

        private void btnQuitarFiltro2_Click(object sender, EventArgs e)
        {
            habilitarFiltro(1);
        }

        private void btnAgregarFilrto3_Click(object sender, EventArgs e)
        {
            habilitarFiltro(4);
        }

        private void btnQuitarFiltro3_Click(object sender, EventArgs e)
        {
            habilitarFiltro(2);
        }

        private string armarFiltro(string campo, string valor)
        {
            string filtro = "";

            if (campo.Trim() == "Tipo de Servicio") filtro = " tipoServicio.nombretipoServicio like '" + valor + "%' ";
            if (campo.Trim() == "Prioridad") filtro = " prioridadesOrdenServicio.nombre like '" + valor + "%' ";
            if (campo.Trim() == "Ingeniero Asignado") filtro = " us4.nombre like '" + valor + "%' ";
            if (campo.Trim() == "Serial") filtro = " ordenServicio.serial  like '" + valor + "%' ";
            if (campo.Trim() == "Nit Cliente") filtro = " clientes.nitcliente  like '" + valor + "%' ";
            if (campo.Trim() == "Nombre Cliente") filtro = "  clientes.nombrecliente like '" + valor + "%' ";
            if (campo.Trim() == "Fabricante") filtro = " nombreFabricante  like '" + valor + "%' ";
            if (campo.Trim() == "Modelo") filtro = "  nombreModelo like '" + valor + "%' ";
            return filtro;
        }

        private string armarFiltros()
        {
            string filtro = "";
            filtro = armarFiltro(cmbCampo.Text, txtFiltro.Text);
            if (cmbFiltro2.Visible) filtro += " AND " + armarFiltro(cmbFiltro2.Text, txtFiltro2.Text);
            if (cmbFiltro3.Visible) filtro += " AND " + armarFiltro(cmbFiltro3.Text, txtFiltro3.Text);
            if (cmbFiltro4.Visible) filtro += " AND " + armarFiltro(cmbFiltro4.Text, txtFiltro4.Text);
            return filtro;
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!validarFiltro())return;
           dsPlantillas1.pltListadoOrdenServicio.Clear();
           string desdefecha = calDesde.Value.Year.ToString() + calDesde.Value.Month.ToString().PadLeft(2, char.Parse("0")) + calDesde.Value.Day.ToString().PadLeft(2, char.Parse("0"));
           string hastafecha = calHasta.Value.Year.ToString() + calHasta.Value.Month.ToString().PadLeft(2, char.Parse("0")) + calHasta.Value.Day.ToString().PadLeft(2, char.Parse("0"));  
            
           string filtro = armarFiltros();
            if(filtro.Trim() == string.Empty)
                filtro = " WHERE " + filtro + "ordenServicio.fechaProgramacion is not null and ordenServicio.asignadoA is not null and ordenServicio.fechaProgramacion between '" + desdefecha + "' and '" + hastafecha + "' ";
            else filtro = " WHERE " + filtro + " AND ordenServicio.fechaProgramacion is not null and ordenServicio.asignadoA is not null and ordenServicio.fechaProgramacion between'" + desdefecha+ "' and '" + hastafecha + "' ";

            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            string sql = generarSql() + filtro;
            dsPlantillas1.EnforceConstraints = false;
            dsPlantillas1.pltListadoOrdenServicio.Merge( objData.ejecutarConsulta(sql).Tables[0]);
            //calculamos el indicador
            txtMantenimientosProgramdos.Text = dsPlantillas1.pltListadoOrdenServicio.Count.ToString();
            txtMantRealizados.Text = dsPlantillas1.pltListadoOrdenServicio.Select(" fechaCierre is not null ").Length.ToString();
            try
            {
                txtIndicador.Text = "" + ((int.Parse(txtMantRealizados.Text) * 100) / int.Parse(txtMantenimientosProgramdos.Text)) + "%";
            }
            catch
            {
                MessageBox.Show("No existen Mantenimientos Programados para este periodo...");
                return;
            }
            //modificamos el grafico circular

            float[] flDatosX = new float[1];
            float[] flDatosY = new float[1];
            float[] flDatosX2 = new float[1];
            float[] flDatosY2 = new float[1];
            flDatosX[0] = 1;
            flDatosX2[0] = 2;
            flDatosY[0] = float.Parse(txtMantenimientosProgramdos.Text) - float.Parse(txtMantRealizados.Text);
            flDatosY2[0] = float.Parse(txtMantRealizados.Text);


            C1.Win.C1Chart.ChartDataSeries cds1 = c1Chart1.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList[0];
            C1.Win.C1Chart.ChartDataSeries cds2 = c1Chart1.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList[1];
            cds1.X.CopyDataIn(flDatosX);
            cds1.Y.CopyDataIn(flDatosY);
            //cds1.Y.CopyDataIn(int.Parse(txtMantenimientosProgramdos.Text));

            cds2.X.CopyDataIn(flDatosX2);
            cds2.Y.CopyDataIn(flDatosY2);
           // cds1.Y.CopyDataIn(int.Parse(txtMantenimientosProgramdos.Text));
            
        }
    }
}

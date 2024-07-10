using spProcesos.ordenesTrabajo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spHerramientas.consultas
{
    public partial class frmIndPreventivoGenCorrectivo : Form
    {
        public frmIndPreventivoGenCorrectivo()
        {
            InitializeComponent();
        }

        private void frmIndPreventivoGenCorrectivo_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calDesde.Value = new DateTime(n.Year, n.Month, n.Day);
            calHasta.Value = n;
        }

        private string generarSql()
        { 
        System.Text.StringBuilder sb= new StringBuilder();
        string campoFecha = "";
        if (rdFechaAprobacion.Checked) campoFecha = "fechaAprobacion ";
        else if (rdFechaCierre.Checked) campoFecha = "fechaCierre ";
        else if (rdProgramacion.Checked) campoFecha = "fechaProgramacion ";
sb.Append(" set dateformat dmy ");
sb.Append(" declare @fechaIni as datetime ");
sb.Append(" declare @fechaFin as datetime ");
sb.Append(" set @fechaIni = '"+calDesde.Value.Day+"-"+calDesde.Value.Month+"-"+calDesde.Value.Year+ "' ");
sb.Append(" set @fechaFin = '" + calHasta.Value.Day + "-" + calHasta.Value.Month + "-" + calHasta.Value.Year + "' ");
sb.Append(" select  ");
sb.Append(" ordenservicio.serial,v.NombreModelo,v.nombreTipoEquipo,v.nombreSubTipo,v.nitCliente,v.nombreCliente,v.nombreFabricante, ");
sb.Append(" datediff(day,st.@@,ordenServicio.@@) 'dias',st.@@ 'fechaPreventivo',ordenServicio.@@ 'fechaCorrectivo', ");
sb.Append(" ordenServicio.codOrdenServicio 'codCorrectivo',ordenServicio.asignadoA 'ingenieroCorrectivo', ");
sb.Append(" ordenServicio.observacionesingeniero 'observacionesCorrectivo', ");
sb.Append(" st.codOrdenServicio 'codPreventivo',st.asignadoA 'ingenieroPreventivo', ");
sb.Append(" st.observacionesingeniero 'observacionesPreventivo' ");
sb.Append("  from ordenServicio ");
sb.Append(" join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio ");
sb.Append(" join  ");
sb.Append(" ( ");
sb.Append(" select serial,@@,codOrdenServicio,asignadoA,observacionesingeniero from ordenServicio ");
sb.Append(" join tipoServicio  ");
sb.Append(" on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio ");
sb.Append(" where tipoServicio.preventivo = 1 and @@ between @fechaIni and @fechaFin  ");
sb.Append(" ) st on st.serial = ordenServicio.serial and st.@@ < ordenServicio.@@ ");
sb.Append(" and datediff(day,st.@@,ordenServicio.@@) <60 ");
sb.Append(" join dbo.vistaEquipo v on v.serial = ordenServicio.serial  ");
sb.Append(" where tipoServicio.correctivo = 1 ");
return sb.ToString().Replace("@@", campoFecha);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!validarFiltro()) return;
            string sql = generarSql();
            sql += armarFiltros();
            //agregamos los filtros
            dsGeneral.pltIndicadorPostPreventivo.Clear();
            ds10.pltIndicadorPostPreventivo.Clear();
            ds20.pltIndicadorPostPreventivo.Clear();
            ds30.pltIndicadorPostPreventivo.Clear();
            ds60.pltIndicadorPostPreventivo.Clear();

            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsGeneral.pltIndicadorPostPreventivo.Merge(objData.ejecutarConsulta(sql).Tables[0]);
            string filtro = "datediff(day,st.@@,ordenServicio.@@)  between ";
            string campoFecha = "";
            if (rdFechaAprobacion.Checked) campoFecha = "fechaAprobacion ";
            else if (rdFechaCierre.Checked) campoFecha = "fechaCierre ";
            else if (rdProgramacion.Checked) campoFecha = "fechaProgramacion ";
            filtro=filtro.Replace("@@", campoFecha);

            ds10.pltIndicadorPostPreventivo.Merge(objData.ejecutarConsulta(sql + " and " + filtro + " 0 and 10 ").Tables[0]);
            ds20.pltIndicadorPostPreventivo.Merge(objData.ejecutarConsulta(sql + " and " + filtro + " 11 and 20 ").Tables[0]);
            ds30.pltIndicadorPostPreventivo.Merge(objData.ejecutarConsulta(sql + " and " + filtro + " 21 and 30 ").Tables[0]);
            ds60.pltIndicadorPostPreventivo.Merge(objData.ejecutarConsulta(sql + " and " + filtro + " 31 and 60 ").Tables[0]);


            //cargamos los cuadros de texto
            txtGeneral.Text = dsGeneral.pltIndicadorPostPreventivo.Count.ToString();
            txt10.Text = dsGeneral.pltIndicadorPostPreventivo.Select(" dias > 0 and dias < 10").Length.ToString();
            txt20.Text = dsGeneral.pltIndicadorPostPreventivo.Select(" dias > 11 and dias < 20").Length.ToString();
            txt30.Text = dsGeneral.pltIndicadorPostPreventivo.Select(" dias > 21 and dias < 30").Length.ToString();
            txt60.Text = dsGeneral.pltIndicadorPostPreventivo.Select(" dias > 31 and dias < 60").Length.ToString();
            //ahora las graficas
            float[] flDatosX = new float[1];
            float[] flDatosY = new float[1];
            float[] flDatosY2 = new float[1];
            float[] flDatosY3 = new float[1];
            float[] flDatosY4 = new float[1];
            flDatosX[0] = 1;
            flDatosY[0] = float.Parse(txt10.Text);
            flDatosY2[0] = float.Parse(txt20.Text);
            flDatosY3[0] = float.Parse(txt30.Text);
            flDatosY4[0] = float.Parse(txt60.Text);


            C1.Win.C1Chart.ChartDataSeries cds1 = c1Chart1.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList[0];
            C1.Win.C1Chart.ChartDataSeries cds2 = c1Chart1.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList[1];
            C1.Win.C1Chart.ChartDataSeries cds3 = c1Chart1.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList[2];
            C1.Win.C1Chart.ChartDataSeries cds4 = c1Chart1.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList[3];
            
            cds1.X.CopyDataIn(flDatosX);
            cds1.Y.CopyDataIn(flDatosY);
            //
            cds2.X.CopyDataIn(flDatosX);
            cds2.Y.CopyDataIn(flDatosY2);
            //
            cds3.X.CopyDataIn(flDatosX);
            cds3.Y.CopyDataIn(flDatosY3);
            //
            cds4.X.CopyDataIn(flDatosX);
            cds4.Y.CopyDataIn(flDatosY4);

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



        private string armarFiltros()
        {
            string filtro = "";
            filtro = armarFiltro(cmbCampo.Text, txtFiltro.Text);
            if (filtro.Trim() != string.Empty) filtro = " AND " + filtro;
            if (cmbFiltro2.Visible) filtro += " AND " + armarFiltro(cmbFiltro2.Text, txtFiltro2.Text);
            if (cmbFiltro3.Visible) filtro += " AND " + armarFiltro(cmbFiltro3.Text, txtFiltro3.Text);
            if (cmbFiltro4.Visible) filtro += " AND " + armarFiltro(cmbFiltro4.Text, txtFiltro4.Text);
            return filtro;
        }
        private string armarFiltro(string campo, string valor)
        {
            string filtro = "";
            //if (campo.Trim() == "Ingeniero Asignado") filtro = "  (ordenServicio.asignadoA  like '" + valor + "%' OR  st.asignadoA  like '" + valor + "%' )";
            if (campo.Trim() == "Ingeniero Asignado") filtro = "  ( st.asignadoA  like '" + valor + "%' )";
            if (campo.Trim() == "Serial") filtro = " ordenServicio.serial  like '" + valor + "%' ";
            if (campo.Trim() == "Nit Cliente") filtro = "  v.nitcliente  like '" + valor + "%' ";
            if (campo.Trim() == "Nombre Cliente") filtro = "   v.nombrecliente like '" + valor + "%' ";
            if (campo.Trim() == "Fabricante") filtro = "  v.nombreFabricante  like '" + valor + "%' ";
            if (campo.Trim() == "Modelo") filtro = "  v.nombreModelo like '" + valor + "%' ";
            return filtro;
        }
        #endregion

        private void btnExcelGeneral_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Correctivos Post Preventivos", false);
        }

        private void btnVerCorrectiva_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
            frmNuevaOrdenTrabajo fr = new frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdDatos.Columns["codCorrectivo"].Text;
            fr.Show();
        }

        private void btnPreventiva_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
            frmNuevaOrdenTrabajo fr = new frmNuevaOrdenTrabajo();
            fr.CodOrdenServicio = grdDatos.Columns["codPreventivo"].Text;
            fr.Show();
        }

        private void btnHojaVidaEquipo_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo fr = new spProcesos.Equipos.frmInformacionEquipo();
            fr.Serial = grdDatos.Columns["serial"].Value.ToString();
            fr.Show();
        }

    }
}

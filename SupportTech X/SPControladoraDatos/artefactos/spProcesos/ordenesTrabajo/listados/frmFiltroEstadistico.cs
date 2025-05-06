using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.ordenesTrabajo.listados
{
    public partial class frmFiltroEstadistico : Form
    {
        public frmFiltroEstadistico()
        {
            InitializeComponent();
        }

        private void frmFiltroEstadistico_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            DateTime fecha=n.AddMonths(-1);
            calInicio.Value = new DateTime( fecha.Year ,fecha.Month , 1);
            calFin.Value = n;

            pltEstadisticasOrdenSErvicioTableAdapter1.FillByEstados(dsEstados.pltEstadisticasOrdenSErvicio,calInicio.Value,calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByVencimiento(dsCantidad.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByPrioridadesInternas(dsPrioiridadesInternas.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByPrioridadesExternas(dsPrioridadesExternas.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByTipoServicio(dsTiposServicio.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
        }

        /// <summary>
        /// esta me ayuda a detectar si le cieron click en la lupa o no
        /// </summary>
        /// <param name="grilla">grila donde le dieron el click</param>
        /// <param name="x">posicion x</param>
        /// <param name="y">posicion y</param>
        /// <param name="filtro">Me indica si es por estados o por tipos de servicio</param>
        /// <param name="codFiltro">Me indica el codigo del estado o del coidgo de servicio</param>
        private void localizarClick(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla, int x, int y, string filtro)
        {
            int fila = -1;
            int tmp = 0;
            #region calculamos a que fila le dio
            for (int k = 0; k < grilla.RowCount - 1; k++)
            {
                tmp = grilla.RowTop(k);
                int b3 = grilla.RowTop(k + 1);
                if (y < tmp) break;//si es menor que la fila no continue nada
                if (y >= tmp && y <= b3) { fila = k; break; }
            }
            //probamos si depronto le dio click en ultimo
            if (fila == -1)
            {
                tmp = c1CmbEstados.RowTop(grilla.RowCount - 1);
                if (y >= tmp && y <= tmp + grilla.RowHeight) { fila = grilla.RowCount - 1; }
            }
            if (fila == -1)
            {
                fila = grilla.RowCount-1;
            }

                #endregion
                if (fila == -1) return;
            //verificamos si esa fila tiene mas de 0 si no no continuas
            string a = grilla[fila, 1].ToString().Trim();
            if (a == "0") return;
            //aca ya tenemos cual es la fila ahora verificamos la columna
            int col1 = grilla.Splits[0].DisplayColumns[0].Width;
            int col2 = grilla.Splits[0].DisplayColumns[1].Width;
            int col3 = grilla.Splits[0].DisplayColumns[2].Width;
            col1 = col1 + col2 + 18;
            col2 = col1 + col3 - 1;
            //comprobamos si le dio click en la lupa

            if (x > col1 && x < col2)
            {
                listados.frmListadoEstadisticosGrilla objFrm = new frmListadoEstadisticosGrilla();
                objFrm.filtro = filtro;
                objFrm.codFiltro = grilla[fila, 0].ToString().Trim();
                objFrm.objTmp = this;
                objFrm.fechaInicio = calInicio.Value;
                objFrm.fechaFin = calFin.Value;
                objFrm.ShowDialog();
           

            }

        }

        private void c1CmbEstados_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.MouseEventArgs el = (System.Windows.Forms.MouseEventArgs)e;
                if (el.Button != MouseButtons.Left) return;
                localizarClick(c1CmbEstados, el.X, el.Y, "ESTADOS");
            }
            catch (Exception)
            {
                return;
            }
        }

        private void c1CmbTiposServicio_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.MouseEventArgs el = (System.Windows.Forms.MouseEventArgs)e;
                if (el.Button != MouseButtons.Left) return;
                localizarClick(c1CmbTiposServicio, el.X, el.Y, "TIPOSSERVICIO");
            }
            catch (Exception)
            {
                return;
            }
        }

        private void c1GrdPrioridadesInternas_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.MouseEventArgs el = (System.Windows.Forms.MouseEventArgs)e;
                if (el.Button != MouseButtons.Left) return;
                localizarClick(c1GrdPrioridadesInternas, el.X, el.Y, "PINTERNAS");
            }
            catch (Exception)
            {
                return;
            }
        }

        private void c1CmbPrioridadesExternas_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.MouseEventArgs el = (System.Windows.Forms.MouseEventArgs)e;
                if (el.Button != MouseButtons.Left) return;
                localizarClick(c1CmbPrioridadesExternas, el.X, el.Y, "PEXTERNAS");
            }
            catch (Exception)
            {
                return;
            }
        }

        private void c1CmbCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.MouseEventArgs el = (System.Windows.Forms.MouseEventArgs)e;
                if (el.Button != MouseButtons.Left) return;
                localizarClick(c1CmbCantidad, el.X, el.Y, "CANTIDAD");
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByEstados(dsEstados.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByVencimiento(dsCantidad.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByPrioridadesInternas(dsPrioiridadesInternas.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByPrioridadesExternas(dsPrioridadesExternas.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
            pltEstadisticasOrdenSErvicioTableAdapter1.FillByTipoServicio(dsTiposServicio.pltEstadisticasOrdenSErvicio, calInicio.Value, calFin.Value);
        }
    }
}

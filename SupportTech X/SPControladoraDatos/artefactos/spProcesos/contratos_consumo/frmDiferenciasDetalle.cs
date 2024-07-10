using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmDiferenciasDetalle : Form
    {
        public frmDiferenciasDetalle()
        {
            InitializeComponent();
        }

        public int codContratoConsumo { set; get; }
        public string  nit{ set; get; } 

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        C1.Win.C1TrueDBGrid.Style resaltado = new C1.Win.C1TrueDBGrid.Style();
        C1.Win.C1TrueDBGrid.Style normal = new C1.Win.C1TrueDBGrid.Style();
        private void frmDiferenciasDetalle_Load(object sender, EventArgs e)
        {

            normal = new C1.Win.C1TrueDBGrid.Style();
            normal.BackColor = System.Drawing.Color.White;
            normal.Locked = true;

            resaltado = new C1.Win.C1TrueDBGrid.Style();
            resaltado.BackColor = System.Drawing.Color.Salmon;
            resaltado.Locked = true;

            pltEquiposxContratoTableAdapter1.FillBycod_contrato_consumo(dsContratoConsumo1.pltEquiposxContrato,codContratoConsumo);

            for (int j = 0; j < dsContratoConsumo1.pltEquiposxContrato.Count; j++)
            {
                if (dsContratoConsumo1.pltEquiposxContrato[j].IsNombreModeloNull())
                {
                    dsContratoConsumo1.pltEquiposxContrato.Rows.RemoveAt(j);
                    j--;
                }
            }
            Application.DoEvents();
            string sql = "select * from dbo.VistaEquipo where nitCliente ='" + nit.Trim() + "'";
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            dsSpx1.EnforceConstraints = false;
            dsSpx1.vistaEquipo.Merge( bd.ejecutarConsulta(sql).Tables[0]);
            
            //actualizarColores();

            contratosMarcados = new List<int>();

            equiposMarcados = new List<int>();
            
        }

    
        private void grdDatos_Sort(object sender, C1.Win.C1TrueDBGrid.FilterEventArgs e)
        {
            //actualizarColores();
            contratosMarcados = new List<int>();
        }

        private void c1TrueDBGrid1_Sort(object sender, C1.Win.C1TrueDBGrid.FilterEventArgs e)
        {
            //actualizarColores();
            equiposMarcados = new List<int>();
        }

        private void grdDatos_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {

            if (grdDatos[e.Row, "nombreModalidadEquipo"].ToString().ToUpper().Trim() == "VENTA" || grdDatos[e.Row, "nombreModalidadEquipo"].ToString().ToUpper().Trim() == "Representacion de la marca".ToUpper())
            {
                    e.CellStyle.BackColor= Color.White;
                    return;
            }

                if (ExisteEnContrato(grdDatos[e.Row, "serial"].ToString(), grdDatos[e.Row, "NombreModelo"].ToString(), grdDatos[e.Row, "nombrefabricante"].ToString(),e.Row))
                {
                    e.CellStyle.BackColor= Color.Salmon;
                }
                else {
                    e.CellStyle.BackColor= Color.White;
                }
            
            
        }

        private bool ExisteEnContrato(string serial,string nombreModelo,string nombreFabricante,int fila)
        {
            //
            for (int k = 0; k < grdContratos.Splits[0].Rows.Count; k++)
            {
                //validamos que exista el serial primero
                if (grdContratos[k, "serial"].ToString().Trim() == serial.Trim())
                {
                    return true;
                }
            }
           // if (serial.Trim() == string.Empty) return false;
            //se modifico para que se coloree solo los que coninciden el serial exacto, mas adelante se puede contemplar si se hace el ajuste para los que no tienen serial pero el
            //algoritmo es mas complejo y esta fuera del alcance
            return false;
            for (int k = 0; k < grdContratos.Splits[0].Rows.Count; k++)
            {
                //ahora validamos el modelo y el fabricante
                if (grdContratos[k, "NombreModelo"].ToString().Trim() == nombreModelo && grdContratos[k, "nombre_fabricante"].ToString().Trim() == nombreFabricante)
                {
                    if (!contratosMarcados.Contains(k))
                    {
                        contratosMarcados.Add(k);
                        return true;
                    }
                }
            }

                return false;
        }

        private bool ExisteEquipo(string serial, string nombreModelo, string nombreFabricante)
        {
            //
            for (int k = 0; k < grdDatos.Splits[0].Rows.Count; k++)
            {
                if (grdDatos[k, "nombreModalidadEquipo"].ToString().ToUpper().Trim() == "VENTA" || grdDatos[k, "nombreModalidadEquipo"].ToString().ToUpper().Trim() == "Representacion de la marca".ToUpper())
                {
                    continue;
                }

                //validamos que exista el serial primero
                if (grdDatos[k, "serial"].ToString().Trim() == serial.Trim())
                {
                    return true;
                }
            }
            //se modifico para que se coloree solo los que coninciden el serial exacto, mas adelante se puede contemplar si se hace el ajuste para los que no tienen serial pero el
            //algoritmo es mas complejo y esta fuera del alcance
            return false;
            for (int k = 0; k < grdDatos.Splits[0].Rows.Count; k++)
            {
                if (grdDatos[k, "nombreModalidadEquipo"].ToString().ToUpper().Trim() == "VENTA" || grdDatos[k, "nombreModalidadEquipo"].ToString().ToUpper().Trim() == "Representacion de la marca".ToUpper())
                {
                    continue;
                }
                //ahora validamos el modelo y el fabricante
                if (grdDatos[k, "NombreModelo"].ToString().Trim() == nombreModelo && grdDatos[k, "nombreFabricante"].ToString().Trim() == nombreFabricante)
                {
                    if (!equiposMarcados.Contains(k))
                    {
                        equiposMarcados.Add(k);
                        return true;
                    }
                }
            }

            return false;
        }

        List<int> contratosMarcados = new List<int>();
        List<int> equiposMarcados = new List<int>();



        private void grdContratos_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
           
            if (ExisteEquipo(grdContratos[e.Row, "serial"].ToString(), grdContratos[e.Row, "NombreModelo"].ToString(), grdContratos[e.Row, "nombre_fabricante"].ToString()))
            {
                e.CellStyle.BackColor = Color.LightSeaGreen;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }

        }
    }
}

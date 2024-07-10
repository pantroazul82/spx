using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.tool
{
    public partial class frmInformacionLocal : Form
    {
        public frmInformacionLocal()
        {
            InitializeComponent();
        }

        private void frmInformacionLocal_Load(object sender, EventArgs e)
        {
            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            estadoLocalEquiposTableAdapter1.Fill(dsSpx1.estadoLocalEquipos);
            estadoLocalEquiposTableAdapter1.Fill(dsSpx2.estadoLocalEquipos);
            clientesTableAdapter1.FillByLocal(dsSpx1.clientes);
            if (dsSpx1.clientes.Rows.Count <= 0)
            { 
            //si no existe un cliente local insertamos uno 
                clientesTableAdapter1.Insert("local", "Informacion Local", "", "", "", null, null, "", "", "", "", "", null, "", true,true);
                clientesTableAdapter1.FillByLocal(dsSpx1.clientes);
            }
            //cargamos la informacion local
            txtNombreEmpresa.Text = dsSpx1.clientes[0].nombreCliente;


            if (defaultsTableAdapter1.vercambiosEstadoAutomaticosEntradas().HasValue)
                chkEstadoAutomaticosAlRelizarEntrada.Checked = defaultsTableAdapter1.vercambiosEstadoAutomaticosEntradas().Value;


            if (defaultsTableAdapter1.VerTrasladosAutomaticosCierreSalida().HasValue )
                chkTrasladosAutomaticosAlCerrarLaorden.Checked = defaultsTableAdapter1.VerTrasladosAutomaticosCierreSalida().Value;

            if (defaultsTableAdapter1.VerTrasladosAutomaticosEntradas().HasValue)
                chkTrasladosAutomaticosAlRelizarEntrada.Checked = defaultsTableAdapter1.VerTrasladosAutomaticosEntradas().Value;


            //ahora cargamos las ubicaciones de este cliente local
            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, "local");
            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx2.sucursalCliente, "local");
            cmbUbicacionPredeterminada.SelectedValue = defaultsTableAdapter1.verCodUbicacionTallerxDefecto();
            if (defaultsTableAdapter1.verCodUbicacionTrasladoEntradas() != null)
                cmbUbicacionEntrada.SelectedValue = defaultsTableAdapter1.verCodUbicacionTrasladoEntradas();
            else
                cmbUbicacionEntrada.SelectedValue = "";

            if (defaultsTableAdapter1.verCodEstadoLocalEquipos() != null)
            cmbEstadoPredetermindo.SelectedValue = defaultsTableAdapter1.verCodEstadoLocalEquipos();
            else
                cmbEstadoPredetermindo.SelectedValue = "";

            if (defaultsTableAdapter1.verCodEstadoLocalTrasladoEntradas() != null)
            cmbEstadoEntrada.SelectedValue = defaultsTableAdapter1.verCodEstadoLocalTrasladoEntradas();
            else
                cmbEstadoEntrada.SelectedValue = "";
            defaultsTableAdapter1.Fill(dsSpx1.defaults);
            //el cliente local debe tener un pais una ciudad y un departamento miramos si la tiene si no se la creamos
            if (dsSpx1.sucursalCliente.Rows.Count > 0 && dsSpx1.defaults.Rows.Count>0)
            {
                for (int k = 0; k < dsSpx1.sucursalCliente.Rows.Count; k++)
                {
                    if (dsSpx1.sucursalCliente[k].IscodPaisNull())
                    {
                        sucursalClienteTableAdapter1.UpdateSucursal(
                            dsSpx1.sucursalCliente[k].IsnombreSucursalNull()?null: dsSpx1.sucursalCliente[k].nombreSucursal,
                            dsSpx1.defaults[0].IscodPaisNull()?null:dsSpx1.defaults[0].codPais,
                            dsSpx1.defaults[0].IscodDepartamentoNull() ? null : dsSpx1.defaults[0].codDepartamento,
                            dsSpx1.defaults[0].IscodCiudadNull() ? null : dsSpx1.defaults[0].codCiudad,
                            dsSpx1.sucursalCliente[k].IsDireccionNull() ? null : dsSpx1.sucursalCliente[k].Direccion,
                            dsSpx1.sucursalCliente[k].IsTelefono1Null() ? null : dsSpx1.sucursalCliente[k].Telefono1,
                            dsSpx1.sucursalCliente[k].IsTelefono2Null() ? null : dsSpx1.sucursalCliente[k].Telefono2,
                            dsSpx1.sucursalCliente[k].nitCliente,
                            dsSpx1.sucursalCliente[k].codSucursal);
                    }
                }
            }
            else { 
            //si no tiene ninguna sucursal se la creamos
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmBodegasLocales fr = new frmBodegasLocales();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, "local");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdBodegas.Columns["codSucursal"].Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            frmBodegasLocales fr = new frmBodegasLocales();
            fr.CodBodega = grdBodegas.Columns["codSucursal"].Value.ToString().Trim();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, "local");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdBodegas.Columns["codSucursal"].Value.ToString().Trim() != string.Empty)
            {
                if (MessageBox.Show("Esta seguro de eliminar esta ubicacion o bodega", "Pregunta", MessageBoxButtons.YesNo)
                    != DialogResult.Yes) return;
                try
                {
                    sucursalClienteTableAdapter1.deleteSucursal("local", grdBodegas.Columns["codSucursal"].Value.ToString().Trim());
                    sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, "local");
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al eliminar la sucursal "+ ex.Message);
                }
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //----
            defaultsTableAdapter1.UpdateTrasladosAutomaticosCierreSalida(chkTrasladosAutomaticosAlCerrarLaorden.Checked);
            defaultsTableAdapter1.UpdateTrasladosAutomaticosEntradas(chkTrasladosAutomaticosAlRelizarEntrada.Checked);

            defaultsTableAdapter1.UpdatecambiosEstadoAutomaticosEntradas(chkEstadoAutomaticosAlRelizarEntrada.Checked); 
            
            defaultsTableAdapter1.UpdateCodEstadoLocalEquipos(cmbEstadoPredetermindo.SelectedValue.ToString());
            defaultsTableAdapter1.updateCodUbicacionTallerxDefecto((cmbUbicacionPredeterminada.SelectedValue == null)?"":cmbUbicacionPredeterminada.SelectedValue .ToString());
            clientesTableAdapter1.UpdateClienteLocal(txtNombreEmpresa.Text, "local");

            defaultsTableAdapter1.UpdateCodEstadoLocalTrasladoEntradas(cmbEstadoEntrada.SelectedValue.ToString());
            defaultsTableAdapter1.UpdateCodUbicacionTrasladoEntradas((cmbUbicacionEntrada.SelectedValue == null) ? "" : cmbUbicacionEntrada.SelectedValue.ToString());
        //--------
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool guardar() 
        {
            clientesTableAdapter1.UpdateClienteLocal(txtNombreEmpresa.Text,"local");
            return true;
        }

        private void cmbUbicacionPredeterminada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
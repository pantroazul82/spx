using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SpFrm.generales
{
    public partial class frmClientes : CgDataFrm.frmModelo
    {
        public frmClientes()
        {
            InitializeComponent();
            cgDataControler1.ModuloSeguridad = 0;
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {
            if (validando) return;
        }
        private bool validando = false;

        private void llenarTablasCliente() 
        {
            if (validando == false) return;
            if (txtNit.ReadOnly == true || txtNit.Enabled == false)
            {
                //eliminamos la fila que contiene el taller local 
                System.Data.DataRow[] tabla = dsSpx1.clientes.Select("nitCliente = 'local'");
                if (tabla.Length > 0)
                {
                   dsSpx1.clientes.RemoveclientesRow((SPControladoraDatos.dsSpx.clientesRow)tabla[0]);
                }
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtNit.Text);
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, txtNit.Text);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            validando = false;
            tipoDocumentoTableAdapter1.Fill(dsSpx1.tipoDocumento);
            tituloContactoTableAdapter1.Fill(dsSpx1.tituloContacto);
            clientesTableAdapter1.Fill(dsSpx1.clientes);
            cgDataControler1.TableAdapter = clientesTableAdapter1;
            cgDataControler1.cmTabla = (this.BindingContext[dsSpx1, "clientes"] as CurrencyManager);
            validando = true;
            llenarTablasCliente();
            Refresh();
            Update();
        }


        private void btnSubirLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image im = new Bitmap(openFileDialog1.FileName);
                    picLogo.Image = im;
                    picLogo.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void btnDescargarLogo_Click(object sender, EventArgs e)
        {
            if (cgDataControler1.verValor("logoTipo") != null && picLogo.Image != null)
            {
                saveFileDialog1.FileName = "*.jpg";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] arr = (byte[])cgDataControler1.verValor("logoTipo");
                        FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                        BinaryWriter writer = new BinaryWriter(stream);
                        writer.Write(arr);
                        writer.Close();
                        MessageBox.Show("Se guardo el Archivo Satisfactoriamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo " + ex.Message);
                    }
                }
            }
        }

        private void cgDataControler1_estadoControlesChanged(object sender, CGDataControler.dataControlerEventArgs e)
        {
            btnSubirLogo.Enabled = cgDataControler1.EstadoControles;
            btnAgergarContacto.Enabled = cgDataControler1.EstadoControles;
            btnAgregarSucursal.Enabled = cgDataControler1.EstadoControles;
            btnEiliminiarSucu.Enabled = cgDataControler1.EstadoControles;
            btnEliminarContacto.Enabled = cgDataControler1.EstadoControles;
            btnModificarContacto.Enabled = cgDataControler1.EstadoControles;
            btnModificarSucursal.Enabled = cgDataControler1.EstadoControles;
            chkActivo.Enabled = cgDataControler1.EstadoControles;
        }

        private void cgDataControler1_AntesDeNuevo(object sender, CGDataControler.dataControlerEventArgs e)
        {
            contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, "");
            sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, "");
            chkActivo.Checked = true;
        }

        #region zona de contactos

        private void btnAgergarContacto_Click(object sender, EventArgs e)
        {
            if (!txtNit.ReadOnly)
            {
                MessageBox.Show("Para crear un contacto debe grabar primero el cliente");
                return;
            }
            frmContactos frm = new frmContactos();
            frm.NitCliente = txtNit.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtNit.Text);
            }
        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            if (grdContactos.FirstDisplayedCell == null) return;

            frmContactos frm = new frmContactos();
            frm.NitCliente = txtNit.Text;
            frm.CodContacto = grdContactos["codContactoDataGridViewTextBoxColumn", grdContactos.CurrentCell.RowIndex].Value.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtNit.Text);
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (grdContactos.FirstDisplayedCell == null) return;

            if (MessageBox.Show("Esta seguro de eliminar este contacto", "Pregunta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                contactosClientesTableAdapter1.deleteContacto
                    (txtNit.Text,
                    grdContactos["codContactoDataGridViewTextBoxColumn", grdContactos.CurrentCell.RowIndex].Value.ToString());
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtNit.Text);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (grdContactos.FirstDisplayedCell == null) return;

            frmContactos frm = new frmContactos();
            frm.NitCliente = txtNit.Text;
            frm.Consultando = true;
            frm.CodContacto = grdContactos["codContactoDataGridViewTextBoxColumn", grdContactos.CurrentCell.RowIndex].Value.ToString();
            frm.ShowDialog();
        }

        private void grdContactos_DoubleClick(object sender, EventArgs e)
        {
            if (grdContactos.FirstDisplayedCell == null) return;

            frmContactos frm = new frmContactos();
            frm.NitCliente = txtNit.Text;
            frm.Consultando = true;
            frm.CodContacto = grdContactos["codContactoDataGridViewTextBoxColumn", grdContactos.CurrentCell.RowIndex].Value.ToString();
            frm.ShowDialog();
        }
        #endregion

        #region zona de sucursales

        
        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            if (!txtNit.ReadOnly)
            {
                MessageBox.Show("Para crear una sucursal debe grabar primero el cliente");
                return;
            }
            frmSucursales frm = new frmSucursales();
            frm.NitCliente = txtNit.Text;
            frm.Creando = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente,
                    txtNit.Text);

            }
            contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtNit.Text);
        }

        private void btnModificarSucursal_Click(object sender, EventArgs e)
        {
            if (grdSucursalesC1.VisibleRows >0 )
            {
                frmSucursales frm = new frmSucursales();
                frm.NitCliente = txtNit.Text;
                frm.CodigoSucursal = grdSucursalesC1.Columns["codSucursal"].Value.ToString();
                frm.Modificando = true;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente,
                        txtNit.Text);
                }
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtNit.Text);
            }
        }

        private void btnEiliminiarSucu_Click(object sender, EventArgs e)
        {
            if (grdSucursalesC1.VisibleRows <= 0) return;

            if (MessageBox.Show("Esta seguro de eliminar esta Sucursal?\nel sistema podria dejar de funcionar correctamente", "Pregunta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string codSucursal = grdSucursalesC1.Columns["codSucursal"].Value.ToString();
                sucursalClienteTableAdapter1.deleteSucursal(txtNit.Text,codSucursal);
                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, txtNit.Text);
            }
        }


        private void btnConsultarSucursal_Click(object sender, EventArgs e)
        {
            if (grdSucursalesC1.VisibleRows > 0)
            {
                frmSucursales frm = new frmSucursales();
                frm.NitCliente = txtNit.Text;
                frm.CodigoSucursal = grdSucursalesC1.Columns["codSucursal"].Value.ToString();
                frm.Consultando = true;
                frm.ShowDialog();
            }
        }
   
        private void grdSucursalesC1_DoubleClick(object sender, EventArgs e)
        {
            if (grdSucursalesC1.VisibleRows > 0)
            {
                frmSucursales frm = new frmSucursales();
                frm.NitCliente = txtNit.Text;
                frm.CodigoSucursal = grdSucursalesC1.Columns["codSucursal"].Value.ToString();
                frm.Consultando = true;
                frm.ShowDialog();
            }
        }    
        #endregion

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
            llenarTablasCliente();
        }

        private void cgDataControler1_AntesDeEliminar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            //verificamos que no tenga nigun equipo si tiene algun equipo asignado retorna un mensaje de aviso
            SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter objEquipos = 
                new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            int valor= int.Parse(objEquipos.verCantidadEquiposxcliente(txtNit.Text.Trim()).ToString());
            if (valor > 0)
            {
                MessageBox.Show("No puede eliminar este cliente debido a que tiene "+valor+" Equipo(s) ","Alerta");
                e.Cancelar = true;
                return;
            }

        }

        private void grdSucursalesC1_Click(object sender, EventArgs e)
        {

        }

        private bool validar() 
        {
            if (txtNit.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nit del cliente es obligatorio");
                return false;
            }
            if (txtNombreCliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Nombre de Cliente es obligatorio");
                return false;
            }

            return true;
        }

        private void cgDataControler1_AntesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            if (!validar())
            {
                e.Cancelar = true;
                return;
            }
        }

        private void cgDataControler1_DespuesDeAceptar(object sender, CGDataControler.dataControlerEventArgs e)
        {
            //Recordamos que la sucursal es importante para que el cliente quede bien configurado
            if (dsSpx1.sucursalCliente.Rows.Count == 0)
            {
                if(MessageBox.Show("Este Cliente no tiene sucursales configuradas\nPara asignarle equipos al cliente este por\n"+
                    "Lo menos debe tener una sucursal\n\n\nDesea Crear la Sucursal Ahora Mismo?","Desea Crear Sucursales?",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1)
                    != DialogResult.Yes)
                return;
                frmSucursales frm = new frmSucursales();
                frm.NitCliente = txtNit.Text;
                frm.Creando = true;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente,
                        txtNit.Text);

                }
                contactosClientesTableAdapter1.FillBynitCliente(dsSpx1.contactosClientes, txtNit.Text);
            }            
        }

        private void cgDataControler1_EliminarLlaves(object sender, CGDataControler.dataControlerEventArgs e)
        {
            string sql = "delete logCambioUbicaciones where nitClienteOrigen ='" + txtNit.Text + "' or nitClienteDestino ='" + txtNit.Text + "'";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            obj.ejecutarComando(sql);
            sucursalClienteTableAdapter1.DeletebynitCliente(txtNit.Text);
            contactosClientesTableAdapter1.DeletebyNitCliente(txtNit.Text);
        }


    }
}


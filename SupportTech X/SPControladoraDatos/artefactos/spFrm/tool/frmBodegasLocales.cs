using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.tool
{
    public partial class frmBodegasLocales : Form
    {
        public frmBodegasLocales()
        {
            InitializeComponent();
        }
        string codBodega = "";
        public string CodBodega { set { codBodega = value; } get { return codBodega; } }


        private void frmBodegasLocales_Load(object sender, EventArgs e)
        {
            //miramos si es nuevo o no
            if (codBodega.Trim() != string.Empty)
            {
                sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, "local",codBodega);
                if (dsSpx1.sucursalCliente.Rows.Count > 0)
                {
                    txtCodigo.Text = codBodega.Trim();
                    txtCodigo.Enabled = false;
                    txtNombre.Text = dsSpx1.sucursalCliente[0].nombreSucursal.Trim();
                    if (!dsSpx1.sucursalCliente[0].IsbloqueaSalidaNull())
                    {
                        chkBloqueaSalidaAcliente.Checked = dsSpx1.sucursalCliente[0].bloqueaSalida;
                    }
                    if (!dsSpx1.sucursalCliente[0].IsactivaParaTrasladosNull())
                    {
                        chkActivaParaTraslado.Checked = dsSpx1.sucursalCliente[0].activaParaTraslados;
                    }
                    if (!dsSpx1.sucursalCliente[0].IsrequierePermisoParaTrasladosNull())
                    {
                        chkRequierePermiso.Checked = dsSpx1.sucursalCliente[0].requierePermisoParaTraslados;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool guardar() 
        {
            if (txtCodigo.Text.Trim() == string.Empty || txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El codigo y el nombre son obligatorios");
                txtCodigo.Focus();
                return false;
            }
            //miramos si es nuevo o no
            if (codBodega.Trim() == string.Empty)
            {
                sucursalClienteTableAdapter1.Insert("local", txtCodigo.Text, txtNombre.Text, null, null, null, null, null, null, null,
                    chkBloqueaSalidaAcliente.Checked,chkActivaParaTraslado.Checked,chkRequierePermiso.Checked);
            }else {
                sucursalClienteTableAdapter1.UpdateSucursal(txtNombre.Text, null, null, null, null, null, null, "local", codBodega);
                sucursalClienteTableAdapter1.UpdateBloqueaSalida(chkBloqueaSalidaAcliente.Checked, "local", codBodega);
                sucursalClienteTableAdapter1.UpdateActivaParaTraslados(chkActivaParaTraslado.Checked, chkRequierePermiso.Checked, "local", codBodega);
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (guardar())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
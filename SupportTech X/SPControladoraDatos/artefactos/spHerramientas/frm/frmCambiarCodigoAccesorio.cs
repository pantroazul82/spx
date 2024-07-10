using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spHerramientas.frm
{
    public partial class frmCambiarCodigoAccesorio : Form
    {
        public frmCambiarCodigoAccesorio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text == string.Empty)
            {
                MessageBox.Show("El codigo nuevo es obligatorio");
                return;
            }
            if (txtBusqueda1.Text == string.Empty)
            {
                MessageBox.Show("El codigo anterior es obligatorio");
                return;
            }
            //validamos que el nuevo no exista ya
            string sql = "select count(*) from dbo.accesoriosEquipo where codAccesoriosEquipos= '"+txtCodigoNuevo.Text+"'";
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            int cnt= int.Parse(objData.ejecutarProcedimiento(sql).ToString());
            if (cnt > 0)
            {
                MessageBox.Show("El codigo nuevo ya esta asociado a otro accesorio!");
                return;
            }
            //------------------//
            
sql ="alter table accesoriosEquipo NOCHECK constraint ALL "+
" alter table AccesoriosxEntradaSalidaEquipos NOCHECK constraint ALL "+

" update accesoriosEquipo set codAccesoriosEquipos='" + txtCodigoNuevo.Text + "' where codAccesoriosEquipos= '" + txtBusqueda1.Value.Trim() + "' " +
" update AccesoriosxEntradaSalidaEquipos set codAccesoriosEquipos='" + txtCodigoNuevo.Text + "' where codAccesoriosEquipos= '" 
+ txtBusqueda1.Value.Trim() + "'  " +

" alter table accesoriosEquipo with check check constraint all  "+
" alter table AccesoriosxEntradaSalidaEquipos with check check constraint all  ";
            try
            {
                objData.ejecutarComando(sql);
            }catch(Exception ex){
                MessageBox.Show("No se pudo ejecutar los cambios "+ex.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmCambiarCodigoAccesorio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

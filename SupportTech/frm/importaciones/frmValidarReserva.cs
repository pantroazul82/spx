using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportTech.frm.importaciones
{
    public partial class frmValidarReserva : Form
    {
        public frmValidarReserva()
        {
            InitializeComponent();
        }

        private void frmValidarReserva_Load(object sender, EventArgs e)
        {
            string sql = @"select sum(cantidad) from detalle_movimiento where cod_movimiento = 1 and 
cantidad_acumulada is null";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            object o = obj.ejecutarProcedimiento(sql);
            if (o == null || o == System.DBNull.Value || o.ToString() =="0")
            {
                DialogResult = DialogResult.OK;
                Close();
            }else {
                MessageBox.Show("No puede cambiar de estado hasta ","Alerta");
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad;
using SPXSeguridad.data;

namespace SPXSeguridad.frm
{
    public partial class frmFuncionalidades : Form
    {
 
        public frmFuncionalidades()
        {
            InitializeComponent();
          

        }

        private void frmFuncionalidades_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            //logica.clsInicializador obj = new logica.clsInicializador();
            SPXSeguridad.logica.clsInicializador obj = new SPXSeguridad.logica.clsInicializador();
            obj.cargarTablaModulos();
            obj.cargarTablaFuncionalidades();
            obj.tablaModulos(dsSPXSeguridad1.modulo_seguridad);
            obj.tablaFuncionalidades(dsSPXSeguridad1.funcionalidad);
            grdFuncionalidades.Rebind(true);
        }

        private void btnACeptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

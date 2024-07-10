using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPXSeguridad.frm
{
    public partial class frmSeleccionarGrupoUsuario : Form
    {
        /// <summary>
        /// este frmulario no debe permitir ordenar la grilla ni tampoco filtrar ya que la seleccion multiple se perderia.
        /// </summary>
        public frmSeleccionarGrupoUsuario()
        {
            InitializeComponent();
        }

        public List<int> listaSeleccionada = new List<int>();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (listaSeleccionada.Count== 0 && grdGrupo.SelectedRows.Count <= 0) {
                MessageBox.Show("Seleccione por lo menos un grupo!");
                return; }
            listaSeleccionada.Clear();
            for (int k = 0; k < grdGrupo.SelectedRows.Count; k++)
            {
                listaSeleccionada.Add((int)grdGrupo[grdGrupo.SelectedRows[k], "cod_grupo_usuario"]);
            }

            
            DialogResult = DialogResult.OK;
            Close();
        }

        SPXSeguridad.data.cls.clsTgrupo_usuario grupo_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupo_usuario();
        SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1 = new SPXSeguridad.data.dsSPXSeguridad();
        private void frmSeleccionarGrupoUsuario_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            grdGrupo.DataSource = dsSPXSeguridad1.grupo_usuario;
            grupo_usuarioTableAdapter1.Fill(dsSPXSeguridad1.grupo_usuario);
            grdGrupo.Splits[0].DisplayColumns[0].Visible = false;
            grdGrupo.Splits[0].DisplayColumns[1].Width = 300;
            grdGrupo.Columns[1].Caption = "Grupo";
            //seleccionamos los que tiene el usuario
            for (int k = 0; k < dsSPXSeguridad1.grupo_usuario.Count; k++)
            {
                if(listaSeleccionada.Contains(dsSPXSeguridad1.grupo_usuario[k].cod_grupo_usuario))
                    grdGrupo.SelectedRows.Add(k);
            }
        }

       

       	private void grdGrupo_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// get the row the cursor is on
			int row = this.grdGrupo.RowContaining(e.Y);
			if( row != -1 )
			{
				// if the row is in the SelectedRows collection then remove it (deselect)
				// if it isn't then add it (select)
				int index = this.grdGrupo.SelectedRows.IndexOf(row);
                if (index != -1)
                {
                    this.grdGrupo.SelectedRows.RemoveAt(index);
                }else{
                    this.grdGrupo.SelectedRows.Add(row);
                }
			}
		}

		private void grdGrupo_SelChange(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
		{
			// this event is fired when the selection is about to change (usually in response to a row or column change)
			// setting e.Cancel prevents the collection from being cleared
			e.Cancel = true;
		}

        /// <summary>
        /// este evento no sirve de nada ya que toco deshabilitar la opcion de ordenar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdGrupo_AfterSort(object sender, C1.Win.C1TrueDBGrid.FilterEventArgs e)
        {
            grdGrupo.SelectedRows.Clear();
            for (int k = 0; k < dsSPXSeguridad1.grupo_usuario.Count; k++)
            {
                if (listaSeleccionada.Contains( (int)grdGrupo[k, "cod_grupo_usuario"]))
                    grdGrupo.SelectedRows.Add(k);
            }
        }
	
    }
}

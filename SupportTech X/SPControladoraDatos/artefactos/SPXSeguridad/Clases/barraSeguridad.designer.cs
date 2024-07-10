namespace SPXSeguridad.Clases
{
    partial class barraSeguridad
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barraSeguridad));
            this.contenedorSeguridad = new DevComponents.DotNetBar.RibbonBar();
            this.btnCambiarPass = new DevComponents.DotNetBar.ButtonItem();
            this.btnFunciones = new DevComponents.DotNetBar.ButtonItem();
            this.btnGrupos = new DevComponents.DotNetBar.ButtonItem();
            this.btnUsuarios = new DevComponents.DotNetBar.ButtonItem();
            this.btnPermisos = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // contenedorSeguridad
            // 
            this.contenedorSeguridad.AutoOverflowEnabled = true;
            this.contenedorSeguridad.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCambiarPass,
            this.btnFunciones,
            this.btnGrupos,
            this.btnUsuarios,
            this.btnPermisos});
            this.contenedorSeguridad.Location = new System.Drawing.Point(3, 3);
            this.contenedorSeguridad.Name = "contenedorSeguridad";
            this.contenedorSeguridad.Size = new System.Drawing.Size(352, 96);
            this.contenedorSeguridad.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.contenedorSeguridad.TabIndex = 0;
            this.contenedorSeguridad.Text = "Configuracion de Seguridad del Aplicativo";
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.Image = global::SPControladoraDatos.Properties.Resources.candado;
            this.btnCambiarPass.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnCambiarPass.ImagePaddingHorizontal = 8;
            this.btnCambiarPass.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.SubItemsExpandWidth = 14;
            this.btnCambiarPass.Text = "Cambiar Password";
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // btnFunciones
            // 
            this.btnFunciones.Image = ((System.Drawing.Image)(resources.GetObject("btnFunciones.Image")));
            this.btnFunciones.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnFunciones.ImagePaddingHorizontal = 8;
            this.btnFunciones.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.SubItemsExpandWidth = 14;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupos.Image")));
            this.btnGrupos.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnGrupos.ImagePaddingHorizontal = 8;
            this.btnGrupos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.SubItemsExpandWidth = 14;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnUsuarios.ImagePaddingHorizontal = 8;
            this.btnUsuarios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.SubItemsExpandWidth = 14;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Image = ((System.Drawing.Image)(resources.GetObject("btnPermisos.Image")));
            this.btnPermisos.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnPermisos.ImagePaddingHorizontal = 8;
            this.btnPermisos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.SubItemsExpandWidth = 14;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // barraSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.contenedorSeguridad);
            this.Name = "barraSeguridad";
            this.Size = new System.Drawing.Size(295, 108);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnCambiarPass;
        private DevComponents.DotNetBar.ButtonItem btnFunciones;
        private DevComponents.DotNetBar.ButtonItem btnGrupos;
        private DevComponents.DotNetBar.ButtonItem btnUsuarios;
        private DevComponents.DotNetBar.ButtonItem btnPermisos;
        protected DevComponents.DotNetBar.RibbonBar contenedorSeguridad;
    }
}

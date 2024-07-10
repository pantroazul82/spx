namespace SPXSeguridad.Clases
{
    partial class barraLinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barraLinea));
            this.contenedorSeguridad = new DevComponents.DotNetBar.RibbonBar();
            this.btnLineas = new DevComponents.DotNetBar.ButtonItem();
            this.btnLineasxUsuario = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // contenedorSeguridad
            // 
            this.contenedorSeguridad.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.contenedorSeguridad.BackgroundMouseOverStyle.Class = "";
            this.contenedorSeguridad.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.contenedorSeguridad.BackgroundStyle.Class = "";
            this.contenedorSeguridad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contenedorSeguridad.ContainerControlProcessDialogKey = true;
            this.contenedorSeguridad.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLineas,
            this.btnLineasxUsuario});
            this.contenedorSeguridad.Location = new System.Drawing.Point(3, 3);
            this.contenedorSeguridad.Name = "contenedorSeguridad";
            this.contenedorSeguridad.Size = new System.Drawing.Size(234, 96);
            this.contenedorSeguridad.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.contenedorSeguridad.TabIndex = 0;
            this.contenedorSeguridad.Text = "Lineas x Usuario";
            // 
            // 
            // 
            this.contenedorSeguridad.TitleStyle.Class = "";
            this.contenedorSeguridad.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.contenedorSeguridad.TitleStyleMouseOver.Class = "";
            this.contenedorSeguridad.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnLineas
            // 
            this.btnLineas.Image = global::SPControladoraDatos.Properties.Resources.cerrada;
            this.btnLineas.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnLineas.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLineas.Name = "btnLineas";
            this.btnLineas.SubItemsExpandWidth = 14;
            this.btnLineas.Text = "Lineas";
            this.btnLineas.Click += new System.EventHandler(this.btnLineas_Click);
            // 
            // btnLineasxUsuario
            // 
            this.btnLineasxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnLineasxUsuario.Image")));
            this.btnLineasxUsuario.ImageFixedSize = new System.Drawing.Size(44, 44);
            this.btnLineasxUsuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLineasxUsuario.Name = "btnLineasxUsuario";
            this.btnLineasxUsuario.SubItemsExpandWidth = 14;
            this.btnLineasxUsuario.Text = "Lineas x Usuario";
            this.btnLineasxUsuario.Click += new System.EventHandler(this.btnLineasxUsuario_Click);
            // 
            // barraLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.contenedorSeguridad);
            this.Name = "barraLinea";
            this.Size = new System.Drawing.Size(295, 108);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnLineas;
        private DevComponents.DotNetBar.ButtonItem btnLineasxUsuario;
        protected DevComponents.DotNetBar.RibbonBar contenedorSeguridad;
    }
}

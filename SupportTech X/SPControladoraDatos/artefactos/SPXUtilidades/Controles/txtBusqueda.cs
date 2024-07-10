using SPXdata.BD;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Controles
{
    public partial class txtBusqueda : UserControl
    {
        public txtBusqueda()
        {
            InitializeComponent();
        }

        public string linkPadre { set; get; }
        public txtBusqueda txtPadre { set; get; }

        /// <summary>
        /// me indica si el control tiene algun filtro adicional
        /// </summary>
        [DefaultValue("")]
        public string filtroAdicional { set; get; }

        /// <summary>
        /// cuando no se necesita que el componente construya el query, si no que le asignamos un query
        /// que puede tener join con otras tablas.
        /// </summary>
        public string sentenciaFromObligatoria { set; get; }

        /// <summary>
        /// se modifico de int a string, pero este control no soporta llaves multiples
        /// </summary>
        private string codigo_seleccionado { set; get; }

        /// <summary>
        /// es cuando asigna el codigo desde el control
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="codigo"></param>
        private void asignarDesdeControl(string texto, string codigo) 
        {
            validar = false;
            tb.Rows.Clear();
            txtField.Text = texto; 
            codigo_seleccionado = codigo;
            validar = true;
            txtField.Focus();
            FindForm().SelectNextControl(this, true, true, true, true);
        }

        /// <summary>
        /// Asigna automaticamente el codigo
        /// </summary>
        /// <param name="codigo"></param>
        public void asignarCodigo(string codigo)
        {
            if (codigo == null || codigo == "0" || codigo == string.Empty)
            {
                validar = false;
                codigo_seleccionado = "0";
                txtField.Text = "";            
                if (tb != null)
                    tb.Rows.Clear();
                pintarItems();
                validar = true;
                return;
            }
            validar = false;
           DataConector obj = new DataConector();
            tb = obj.ejecutarConsulta(crearSentenciaxCodigo(codigo.ToString())).Tables[0];
            if (tb.Rows.Count > 0)
            {
                string texto = "";
                if (strDescripcion2 == null || strDescripcion2.ToString().Trim() == string.Empty)
                {
                    texto = tb.Rows[0][strDescripcion.Trim()].ToString();
                }else
                {
                    texto = tb.Rows[0][strDescripcion.Trim()].ToString().Trim() + " (" + tb.Rows[0][strDescripcion2.Trim()].ToString() + ")";
                }
                txtField.Text = texto;
                codigo_seleccionado = codigo;
            }
            validar = true;
        }

        #region propiedades para configurarlo desde el disenador
        private Object source;

        /// <summary>
        /// Origen de datos.
        /// </summary>
        [TypeConverter("System.Windows.Forms.Design.DataSourceConverter")]
        [Category("Data")]
        public Object DataSource { get { return source; } set { source = value; } }

        private DataTable tabla = null;
        /// <summary>
        /// La tabla en la cual se verifican los datos.
        /// </summary>
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(DataTable))]
        public DataTable DataMember
        {
            set
            {
                tabla = value;
            }
            get
            {
                return tabla;
            }
        }

        private int limiteY = 125;
        /// <summary>
        /// me indica el valor de altura limite para mostrar el scrol bar
        /// </summary>
        public int LimiteY { set { limiteY = value; } get { return limiteY; } }

        private int tamanoPopUp = 5;
        /// <summary>
        /// me indica el tamano de la lista desplegable
        /// </summary>
        public int TamanoPopUp
        {
            set
            {
                tamanoPopUp = value;
            }
            get
            {
                return tamanoPopUp;
            }

        }

        /// <summary>
        /// LA tabla en la cual se verifican los datos.
        /// </summary>
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(DataTable))]
        public DataTable Tabla
        {
            set
            {
                tabla = value;
                //hay que asignar la strtabla
                if (value != null)
                {
                    strTabla = value.ToString();
                }
            }
            get
            {
                return tabla;
            }
        }
        /// <summary>
        /// Este campo me indica el campo que tiene la llave discriminativa.
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string codigo
        {
            set
            {
                if (value == null) return;
                if (value.LastIndexOf('.') > -1)
                    strCodigo = value.Substring(value.LastIndexOf('.') + 1, value.Length - (value.LastIndexOf('.') + 1));
                else
                    strCodigo = value;
            }

            get
            {
                return strCodigo;
            }
        }

        /// <summary>
        /// Este campo me indica el campo que tiene la llave discriminativa.
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]

        public string descripcion1
        {
            set
            {
                if (value == null) { strDescripcion = ""; return; }
                if (value.LastIndexOf('.') > -1)

                    strDescripcion = value.Substring(value.LastIndexOf('.') + 1, value.Length - (value.LastIndexOf('.') + 1));
                else

                    strDescripcion = value;

            }
            get
            {
                return strDescripcion;
            }
        }

        /// <summary>
        /// Este campo me indica el campo que tiene la llave discriminativa.
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string descripcion2
        {
            set
            {
                if (value == null) { strDescripcion2 = ""; return; }
                if (value.LastIndexOf('.') > -1)
                    strDescripcion2 = value.Substring(value.LastIndexOf('.') + 1, value.Length - (value.LastIndexOf('.') + 1));

                else
                    strDescripcion2 = value;
            }
            get
            {
                return strDescripcion2;
            }
        }
        public string strTabla = "";
        private string strCodigo = "";
        private string strDescripcion = "";
        private string strDescripcion2 = "";
        #endregion

        /// <summary>
        /// Crea la sentencia para el texto que se digita desde el control
        /// </summary>
        /// <param name="textoDigitado"></param>
        /// <returns></returns>
        private string crearSentencia(string textoDigitado)
        {
            
            string sentenciaBase = "select top "+tamanoPopUp +" "+ codigo + "," + descripcion1;

            if (sentenciaFromObligatoria != null && sentenciaFromObligatoria.Trim() != string.Empty)
            {
                sentenciaBase = sentenciaFromObligatoria + " where ";
            }
            else
            {


                if (strDescripcion2.Trim() != string.Empty)
                {
                    sentenciaBase = sentenciaBase + "," + strDescripcion2.Trim();
                }
                sentenciaBase = sentenciaBase + " from " + strTabla.Trim() + " where ";
            }

            if (strDescripcion2.Trim() != string.Empty)
            {
                sentenciaBase = sentenciaBase + "(" + strDescripcion + " like '" + txtField.Text.Trim() + "%' or " + strDescripcion2.Trim() + " like '" + txtField.Text.Trim() 
                    + "%' or "+strDescripcion +"+' '+"+strDescripcion2.Trim() +""+" like '"+txtField.Text.Trim()+"%' )";
            }
            else
            {
                sentenciaBase = sentenciaBase + "(" + strDescripcion + " like '" + txtField.Text.Trim() + "%' )";
            }

            if (filtroAdicional != null && filtroAdicional.Trim() != string.Empty)
            {
                sentenciaBase = sentenciaBase + " and " + filtroAdicional;
            }
            if (txtPadre != null && linkPadre != null)
            {
                if (txtPadre.Value != null )
                {
                    sentenciaBase = sentenciaBase + " and " + linkPadre + "='" + txtPadre.Value + "'";
                }
                else
                {
                    sentenciaBase = sentenciaBase + " and " + linkPadre + " is null ";
                }
            }
            return sentenciaBase;
        }

        /// <summary>
        /// Crea la sentencia para un codigo especificamente.
        /// </summary>
        /// <param name="codigoTabla"></param>
        /// <returns></returns>
        private string crearSentenciaxCodigo(string codigoTabla)
        {
            string sentenciaBase = "select top 1 " + codigo + "," + descripcion1;

            if (sentenciaFromObligatoria != null &&  sentenciaFromObligatoria != string.Empty)
            {
                sentenciaBase = sentenciaFromObligatoria + " where " +
                    strCodigo + " = " + codigoTabla;
            }
            else
            {

                if (strDescripcion2.Trim() != string.Empty)
                {
                    sentenciaBase = sentenciaBase + "," + strDescripcion2;
                }
                sentenciaBase = sentenciaBase + " from " + strTabla + " where " +
                    strCodigo + " = '" + codigoTabla+"'";
            }
         
            if (filtroAdicional != null && filtroAdicional.Trim() != string.Empty)
            {
                sentenciaBase = sentenciaBase + " and " + filtroAdicional;
            }
            sentenciaBase = sentenciaBase + " ";
            return sentenciaBase;
        }

        bool validar = true;

        private System.Data.DataTable tb;
        private void txtField_TextChanged(object sender, EventArgs e)
        {
            if (!validar) return;
            if (strCodigo == null || strCodigo.Trim() == string.Empty) return;
            codigo_seleccionado = "0";
            if (txtField.Text.Trim() == string.Empty)
            {
                tb.Rows.Clear();
            }else{
                string sql = crearSentencia(txtField.Text);
               DataConector obj = new DataConector();
                tb =obj.ejecutarConsulta(sql).Tables[0];
            }
            pintarItems();
        }

        private void pintarItems()
        {
            if (this.Parent != null && this.Parent.Parent != null)
            {
                itemPanel1.Size = new System.Drawing.Size(0, 0);
               // itemPanel1.Dispose();
                DevComponents.DotNetBar.ItemPanel it = new DevComponents.DotNetBar.ItemPanel();
                if (this.Parent.Parent.GetType().FullName != "System.Windows.Forms.MdiClient")
                {
                    this.Parent.Parent.Controls.Add(it);
                }else{
                    this.Parent.Controls.Add(it);
                }
                it.BringToFront();
                int ym = 0;
                int xm = 0;
                if (this.Parent.GetType().FullName.IndexOf("Dev")>=0)
                {
                    ym = 17;
                    xm = 3;
                }
                it.Location = new System.Drawing.Point(xm+this.Location.X + this.Parent.Location.X,
                   ym+3+ this.Location.Y + this.Parent.Location.Y+txtField.Height);
                it.Size = new System.Drawing.Size(this.Width, 0);
                it.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
                it.AutoScroll = true;
                it.BackgroundStyle.BackColor = System.Drawing.Color.White;
                it.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
                it.BackgroundStyle.BorderBottomWidth = 1;
                it.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
                it.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
                it.BackgroundStyle.BorderLeftWidth = 1;
                it.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
                it.BackgroundStyle.BorderRightWidth = 1;
                it.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
                it.BackgroundStyle.BorderTopWidth = 1;
                it.BackgroundStyle.Class = "";
                it.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                it.BackgroundStyle.PaddingBottom = 1;
                it.BackgroundStyle.PaddingLeft = 1;
                it.BackgroundStyle.PaddingRight = 1;
                it.BackgroundStyle.PaddingTop = 1;
                it.ContainerControlProcessDialogKey = true;
                it.DispatchShortcuts = true;
                it.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
                //this.itemPanel1.Location = new System.Drawing.Point(0, 23);
                //this.itemPanel1.Name = "itemPanel1";
                //this.itemPanel1.Size = new System.Drawing.Size(291, 0);
                //this.itemPanel1.TabIndex = 0;
                //this.itemPanel1.Text = "itemPanel1";
                this.itemPanel1.Resize += new System.EventHandler(this.itemPanel1_Resize);




                itemPanel1 = it;
            }
            itemPanel1.Items.Clear();
            itemPanel1.Refresh();
            //agregamos los componentes
            string texto = "";
            if (codigo_seleccionado != "0")
            {
                itemPanel1.Size = new System.Drawing.Size(itemPanel1.Width, 0);
                return;
            }else if (tb == null || tb.Rows.Count == 0)
            {
                 itemPanel1.Size = new System.Drawing.Size(itemPanel1.Width,0);
                 return;
            }

            for (int k = 0; tb != null && codigo_seleccionado == "0" && k < tb.Rows.Count; k++)
            {
                if (strDescripcion2 == null || strDescripcion2.ToString().Trim() == string.Empty)
                {
                    texto = tb.Rows[k][strDescripcion.Trim()].ToString().Trim();
                }
                else
                {
                    texto = tb.Rows[k][strDescripcion.Trim()].ToString().Trim() + " (" + tb.Rows[k][strDescripcion2.Trim()].ToString().Trim() + ")";
                }

                DevComponents.DotNetBar.ButtonItem b = new DevComponents.DotNetBar.ButtonItem
                (tb.Rows[k][strCodigo.Trim()].ToString(), texto);

                b.Tag = tb.Rows[k][strCodigo.Trim()].ToString();
                b.Click += new EventHandler(btnAccion_Click);
                b.GotFocus += new EventHandler(b_GotFocus);
                b.LostFocus += new EventHandler(b_LostFocus);
                b.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
                itemPanel1.Items.Add(b);

            }
            if (itemPanel1.Items.Count * 26 < limiteY)
            {
                itemPanel1.Size = new System.Drawing.Size
                (itemPanel1.Width, itemPanel1.Items.Count * 26);
            }
            else
            {
                itemPanel1.Size = new System.Drawing.Size
                 (itemPanel1.Width, limiteY);
                itemPanel1.AutoScrollMinSize =
                    new System.Drawing.Size
                 (itemPanel1.Width, limiteY);
            }

            this.BringToFront();
            itemPanel1.Refresh();
            itemPanel1.Update();
            
        }

        void b_LostFocus(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem b = (DevComponents.DotNetBar.ButtonItem)sender;
            b.ForeColor = System.Drawing.Color.Black;
            b.FontBold = false;
            b.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
        }

        void b_GotFocus(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem b = (DevComponents.DotNetBar.ButtonItem)sender;
            b.ForeColor = System.Drawing.Color.DarkBlue;
            b.FontBold = true;
            b.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
        }

        private void txtBusquedaLinea_Load(object sender, EventArgs e)
        {
          
        }

        int posicion_lista = 0;
        private void txtField_KeyDown(object sender, KeyEventArgs e)
        {
         if (txtField.Text == "" )return;
         if (codigo_seleccionado != "0") return;

            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                posicion_lista++;
                if (posicion_lista >= itemPanel1.Items.Count)
                {
                    posicion_lista = 0;
                }

                itemPanel1.Items[posicion_lista].Focus();

            }
            else if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                posicion_lista--;
                if (posicion_lista < 0)
                {
                    posicion_lista = itemPanel1.Items.Count - 1;
                }
                itemPanel1.Items[posicion_lista].Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            { 
                e.Handled = true;
                if (itemPanel1.Items.Count > 0)
                {
                    asignarDesdeControl(itemPanel1.Items[posicion_lista].Text, itemPanel1.Items[posicion_lista].Tag.ToString());
                } 
                posicion_lista = 0;
                pintarItems();
            }
            else {
                posicion_lista = 0;
            }

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem b = (DevComponents.DotNetBar.ButtonItem)sender;
            asignarDesdeControl(b.Text,b.Tag.ToString());
            pintarItems();
        }

         private void txtBusquedaLinea_Validating(object sender, CancelEventArgs e)
        {
          //  return;
            //if (tb.Rows.Count>0 codigo_seleccionado == "0")
              if (codigo_seleccionado=="0" && tb != null && tb.Rows.Count > 0 )
            {
                validar = false;
                if (tb != null)
                    tb.Rows.Clear();
                txtField.Text = "";
                pintarItems();
                validar = true;
            }
             //miramos si digitaron algo loco
              if (Text != string.Empty && tb.Rows.Count == 0 && codigo_seleccionado=="0")
              {
                  asignarCodigo("0");
              }
        }

         private void txtBusquedaLinea_Enter(object sender, EventArgs e)
         {
             txtField.Focus();
             //ponemos el cursor al final del cuadro de texto
             txtField.SelectionStart = 0;
             txtField.SelectionLength = txtField.Text.Trim().Length;
             txtField.Focus();

         }

         private void itemPanel1_Resize(object sender, EventArgs e)
         {
             this.Size = new System.Drawing.Size(this.Width, itemPanel1.Height + txtField.Height);
         }
        
         /// <summary>
         /// Texto que esta en el cuadro de texto, generalmente la descripcion
         /// </summary>
         [Bindable(true)]
         [DefaultValue("")]
         public override string Text { get {return txtField.Text; } }

        /// <summary>
        /// codigo seleccionado desde el cuadro de texto
        /// </summary>
         [Bindable(true)]
         [DefaultValue("")]
         public string Value { get { return codigo_seleccionado; } set { asignarCodigo(value); } }

         private void txtField_DoubleClick(object sender, EventArgs e)
         {

         }

         private void txtField_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             if (txtField.Text.Trim() == string.Empty)
             {
                 txtField.Text = "%";
             }
         }
    }
}

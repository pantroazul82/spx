using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;


namespace CGDataControler
{
    /// <summary>
    /// Especifica que tipo de datos se va a leer en el control
    /// </summary>
    public enum tipoDatos 
    {
        /// <summary>
        /// Indica que el valor a ingresar es un numero natural
        /// </summary>
        numeroNatural,
        /// <summary>
        /// Indica que el valor a ingresar es una cadena
        /// </summary>
        texto,
        /// <summary>
        /// Indica que el valor a ingresar es un numero con puntos decimal
        /// la validacion se realiza de acuerdo a la configuracion regional del equipo
        /// </summary>
        flotante
    }

    /// <summary>
    /// Control de usuario que me permite configurar facilmente un cuadro de texto asociado a datos.
    /// </summary>
    public partial class dataText : UserControl 
    {
        private string filtroAdicional = "";
        public string FiltroAdicional { set { filtroAdicional = value; } get { return filtroAdicional; } }

        /// <summary>
        /// se ejecuta cuando se cambia el texto.
        /// </summary>
        public event EventHandler textChanged;

        /// <summary>
        /// Constructor
        /// </summary>
        public dataText()
        {
            InitializeComponent();            
        }
        private string tituloColumnaCodigo = "Codigo";
        private string tituloColumnaDescripcion = "Descripcion";
        private bool buscarxDescripcion = false;

        public string TituloColumnaCodigo { set { tituloColumnaCodigo = value; } get { return tituloColumnaCodigo; } }
        public string TituloColumnaDescripcion { set { tituloColumnaDescripcion = value; } get { return tituloColumnaDescripcion; } }

        #region Creamos las propiedades
        private tipoDatos tipo_datos = tipoDatos.texto;
        private string mensaje = "";
        /// <summary>
        /// Especifica que tipo de datos se va a leer en el control.
        /// </summary>
        public tipoDatos Tipo_datos { set { tipo_datos = value; } get { return tipo_datos; } }
        /// <summary>
        /// Si esta habilitado muestra la descripcion debajo del cuadro de texto.
        /// </summary>
        public bool MostrarMensaje { set { mostrarMensaje = value; lblInfo.Visible = value; } get { return mostrarMensaje; } }
        public bool BuscarxDescripcion { set { buscarxDescripcion = value; } get { return buscarxDescripcion; } }

        private int cantidadmensaje = 5000;
        /// <summary>
        /// Me indica que cantidad de registros es el limite para delimitar la busqueda.
        /// </summary>
        public int CantidadMensaje { set { cantidadmensaje = value; } get { return cantidadmensaje; } }

        private bool mostrarMensaje = true;      
        private bool mostrarAnuncios = false;
        /// <summary>
        /// Indica si muestra ventanas emergentes cuando encuentra problemas
        /// </summary>
        public bool MostrarAnuncios { set { mostrarAnuncios = value; } get { return mostrarAnuncios; } }
        private string cadenaConexion="";
        /// <summary>
        /// Especifica la cadena de conexion con la cual verifica los datos.
        /// </summary>
        public string CadenaConexion { set { cadenaConexion = value; } get { return cadenaConexion; } }

        /// <summary>
        /// Texto que se muestra en el cuadro de texto
        /// </summary>
        [Bindable(true)]
        [DefaultValue("")]
        public override string Text { set { txtData.Text = value; } get { return txtData.Text; } }

        /// <summary>
        /// Texto que se muestra en el cuadro de texto
        /// </summary>
        [Bindable(true)]
        [DefaultValue("")]
        public string Descripcion { set { lblInfo.Text = value; } get { return lblInfo.Text; } }



        private Object source;
        /// <summary>
        /// Origen de datos.
        /// </summary>
        [TypeConverter("System.Windows.Forms.Design.DataSourceConverter")]
        [Category("Data")]
        public Object DataSource { get { return source; } set { source = value; } }
        private DataTable tabla = null;
        /// <summary>
        /// LA tabla en la cual se verifican los datos.
        /// </summary>
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(DataTable))]
        public DataTable DataMember { set { 
            tabla = value;} get { return tabla; } }
        private string campoValor = "";
        private string campoNombre = "";
        private string campoNombreComplemento = "";
        private string campoLlave1 = "";
        private string campoLlave2 = "";
        private string campoLlave3 = "";
        private string campoLlave4 = "";
        private string campoLlave5 = "";
        private string campoLlave1Foranea = "";
        private string campoLlave2Foranea = "";
        private string campoLlave3Foranea = "";
        private string campoLlave4Foranea = "";
        private string campoLlave5Foranea = "";
     
        /// <summary>
        /// Este campo me indica el campo que tiene la llave discriminativa.
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoValor { 
            set{
                campoValor = value;
            }            get { return campoValor; }
        }
   
        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public  string CampoNombre
        {
            set
            {   campoNombre = value;
            }
            get { return campoNombre; }
        }

        /// <summary>
        /// Este me indica el campo que tiene un complemmento a la descripcion de la tabla, muy util cuando hay que mostrar nombre y apelllido y estan en diferentes columnas
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoNombreComplementario
        {
            set
            {
                campoNombreComplemento = value;
            }
            get { return campoNombreComplemento; }
        }

        //-
        /// <summary>
        /// Este me indica el campo que tiene la llave 1
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave1
        { set {campoLlave1 = value; } get { return campoLlave1; } }
        
        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave2 { set {campoLlave2 = value; } get { return campoLlave2; } }
        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave3
        { set {campoLlave3 = value; } get { return campoLlave3; } }

        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave4
        { set {campoLlave4 = value; } get { return campoLlave4; } }

        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave5
        { set {campoLlave5 = value; } get { return campoLlave5; } }
 
        //Foraneas
        /// <summary>
        /// Este me indica el campo que tiene la llave 1
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave1Foranea
        { set { campoLlave1Foranea = value; } get { return campoLlave1Foranea; } }

        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave2Foranea { set { campoLlave2Foranea = value; } get { return campoLlave2Foranea; } }
        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave3Foranea
        { set { campoLlave3Foranea = value; } get { return campoLlave3Foranea; } }

        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave4Foranea
        { set { campoLlave4Foranea = value; } get { return campoLlave4Foranea; } }

        /// <summary>
        /// Este me indica el campo que tiene la desccripcion de la tabla
        /// </summary>
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string CampoLlave5Foranea
        { set { campoLlave5Foranea = value; } get { return campoLlave5Foranea; } }
#endregion

        private void dataText_Load(object sender, EventArgs e)
        {
            lblInfo.Text = mensaje;
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipo_datos == tipoDatos.texto) return;
            char a = e.KeyChar;
            if (tipo_datos == tipoDatos.flotante)
            {
              e.Handled = (!(char.IsDigit(a) ||  ((int)a < 25) || (a.ToString() == System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)));
            }

            if (tipo_datos == tipoDatos.numeroNatural)
            {
                e.Handled = (!(char.IsDigit(a) || (int)a < 25 ));
            }
        }

        #region arma los filtros
        /// <summary>
        /// Arma el filtro con cada llaves
        /// </summary>
        /// <returns></returns>
        private string armarFiltro(string llave,string llaveForanea) 
        {
            string tmp = "";
            string tablat = "", campo = "", valor = "";
            if (llave == null || llaveForanea == null)return "";
            if (llave.Trim() == string.Empty  || llaveForanea.Trim() == string.Empty )return "";
            if (llave.IndexOf(".") < 0 || llaveForanea.IndexOf(".") < 0)return "";

            tablat = llaveForanea.Substring(0, llaveForanea.IndexOf("."));
            campo = llaveForanea.Substring(llaveForanea.IndexOf(".") + 1);
                if (this.FindForm().BindingContext[DataSource, tablat].Count > 0)
                {
                    valor = (this.FindForm().BindingContext[DataSource, tablat].Current as DataRowView)[campo].ToString();
                    tmp = llave + " like '" + valor.Trim() + "' and ";
                }
            
            return tmp;
        }

        /// <summary>
        /// Arma el filtro con las llaves
        /// </summary>
        /// <returns></returns>
        private string armarFiltro() 
        {
            //(barraDatos1.cmTabla.Current as System.Data.DataRowView)["cod_cliente"] = LdLogica.clsIngreso.strCliente; 
            string tmp = "";
            tmp = tmp + armarFiltro(campoLlave1,campoLlave1Foranea);
            tmp = tmp + armarFiltro(campoLlave2,campoLlave2Foranea);
            tmp = tmp + armarFiltro(campoLlave3,campoLlave3Foranea);
            tmp = tmp + armarFiltro(campoLlave4,campoLlave4Foranea);
            tmp = tmp + armarFiltro(campoLlave5,campoLlave5Foranea);
            return tmp;
        }
        #endregion
        
        private bool validar(bool omiteFiltroBlanco) 
        {
            #region validamos
            if (!omiteFiltroBlanco  && txtData.Text.Trim() == string.Empty)
            {
                mensaje = "";
                lblInfo.Text = mensaje;
                return false;
            }
            if (tabla == null)
            {
                MessageBox.Show("Debe Configurar la tabla.");
                return false;
            }
            if (cadenaConexion.Trim() == string.Empty)
            {
                MessageBox.Show("Debe Configurar la cadena de conexion.");
                return false ;
            }
            if (campoNombre.Trim() == string.Empty)
            {
                MessageBox.Show("Debe Configurar el campo de descripcion.");
                return false;
            }
            if (campoValor.Trim() == string.Empty)
            {
                MessageBox.Show("Debe Configurar el campo de valor.");
                return false;
            }
            #endregion
            return true;
        }
        
        private void txtData_Validating(object sender, CancelEventArgs e)
        {
            if (valoresCorrectos || !validar(false)) return; 
              //primero hacemos el count 
            e.Cancel=!cargarVentana();    
        }
        private bool valoresCorrectos = false;
        /// <summary>
        /// Me indica si en el cuadro de texto hay valores correctos o no.
        /// </summary>
        public bool ValoresCorrectos { set { valoresCorrectos = value; } get { return valoresCorrectos; } }
       
        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F3)
            {
                if (!validar(true)) return;
                //primero hacemos el count 
                if (cargarVentana())
                {
                    this.FindForm().SelectNextControl(this, true, true, true, true);
                }
            }
        }

        /// <summary>
        /// Lanza la busqueda para el respectivo control
        /// </summary>
        public void lanzarBusqueda() 
        {
            if (!validar(true)) return;
            cargarVentana();  
        }

        private bool cargarVentana() 
        {
            string filtro = armarFiltro() + campoValor + " like '%" + txtData.Text.Trim() + "%' ";
            if (buscarxDescripcion)
            {
                filtro = filtro + " OR "+campoNombre+ " like '%"+txtData.Text.Trim()+"%'";
                filtro = filtro + " OR " + campoNombreComplemento + " like '%" + txtData.Text.Trim() + "%'";
            }
            
            if (filtroAdicional.Trim() != string.Empty)
            {
                filtro = filtro + "AND "+filtroAdicional;
            }

            string sentencia = "select count (*) from " + tabla.TableName.ToString().Trim() + " where " +
             filtro;
            System.Data.SqlClient.SqlCommand cmm = new System.Data.SqlClient.SqlCommand(sentencia);
            System.Data.SqlClient.SqlConnection cnn = new System.Data.SqlClient.SqlConnection(cadenaConexion);
            cnn.Open();
            cmm.Connection = cnn;
            object obj = cmm.ExecuteScalar();
            cnn.Close();
            #region si no coincide ninguno
            if (obj == DBNull.Value ||  int.Parse(obj.ToString()) == 0)
            {
                
                if (mostrarAnuncios) 
                {
                    MessageBox.Show("Valor no existe");                    
                }
                mensaje = "Valor no existe";
                lblInfo.Text = mensaje;
                txtData.Focus();
                txtData.SelectionStart = 0;
                txtData.SelectionLength = txtData.Text.Length;
                return false ;
            }
            #endregion

            if (int.Parse(obj.ToString()) > 1)
            {
                //si hay mas de 1000 debe ser mas explicito si no se relantiza la app
                if (int.Parse(obj.ToString()) > cantidadmensaje)
                {
                    if (MessageBox.Show("Se encontraron " + obj.ToString() + " registros que coinciden con el criterio de busqueda '" + txtData.Text.Trim()
                         + "'\nElija un filtro mas especifico.\nDesea continuar de todos modos ?.", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                        != DialogResult.OK)
                    {
                        txtData.Focus();
                        return false;
                    }else
                    {
                        #region cargamos ventana de busqueda
                        if(campoNombreComplemento.Trim() == string.Empty)
                        sentencia = "select " + campoValor + " as Codigo,rtrim(" + campoNombre +") as Descripcion"
                            + " from " + tabla.TableName.ToString().Trim() + " where " + filtro;
                        else
                            sentencia = "select " + campoValor + " as Codigo,rtrim(" + campoNombre + ")+' '+rtrim(" + campoNombreComplemento + ") as Descripcion"
                                                      + " from " + tabla.TableName.ToString().Trim() + " where " + filtro;
                      
                        System.Data.SqlClient.SqlDataAdapter adap = new System.Data.SqlClient.SqlDataAdapter(sentencia, cadenaConexion);
                        System.Data.DataSet ds = new DataSet();
                        adap.Fill(ds);
                        frmDataTextEmergente frm = new frmDataTextEmergente();
                        frm.Tabla = ds.Tables[0];
                        frm.CampoCodigo = CampoValor;
                        frm.CampoNombre = CampoNombre;
                        frm.filtroInicial = txtData.Text;
                        frm.TituloColumnaCodigo = tituloColumnaCodigo;
                        frm.TituloColumnaDescripcion = tituloColumnaDescripcion;

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            lblInfo.Text = frm.ValorNombre.Trim();
                            txtData.Text = frm.ValorCodigo.Trim();
                            valoresCorrectos = true;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        #endregion
                    }
                } else {
                    #region cargamos ventana de busqueda

                    if(campoNombreComplemento.Trim() == string.Empty)
                        sentencia = "select " + campoValor + " as Codigo,rtrim(" + campoNombre + ") as Descripcion"
                        + " from " + tabla.TableName.ToString().Trim() + " where " + filtro;
                    else
                        sentencia = "select " + campoValor + " as Codigo,rtrim(" + campoNombre + ")+' '+rtrim(" + campoNombreComplemento + ") as Descripcion"
                       + " from " + tabla.TableName.ToString().Trim() + " where " + filtro;


                    System.Data.SqlClient.SqlDataAdapter adap = new System.Data.SqlClient.SqlDataAdapter(sentencia, cadenaConexion);
                    System.Data.DataSet ds = new DataSet();
                    adap.Fill(ds);
                    frmDataTextEmergente frm = new frmDataTextEmergente();
                    frm.Tabla = ds.Tables[0];
                    frm.CampoCodigo = CampoValor;
                    frm.CampoNombre = CampoNombre;
                    frm.filtroInicial = txtData.Text;
                    frm.TituloColumnaCodigo = tituloColumnaCodigo;
                    frm.TituloColumnaDescripcion = tituloColumnaDescripcion;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        lblInfo.Text = frm.ValorNombre.Trim();
                        txtData.Text = frm.ValorCodigo.Trim();
                        valoresCorrectos = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    #endregion
                }
            }else{
                #region zona cuando es cuando solo es uno
                if (campoNombreComplemento.Trim() == string.Empty)
                    sentencia = "select " + campoValor + "," + campoNombre + " from " + tabla.TableName.ToString().Trim() + " where " +
                    filtro;
                else
                    sentencia = "select " + campoValor + ",rtrim(" + campoNombre + ")+' '+rtrim(" + campoNombreComplemento + ") as " + campoNombre.Replace(tabla.TableName + ".", "") + " from " + tabla.TableName.ToString().Trim() + " where " +
                    filtro;
                System.Data.SqlClient.SqlDataAdapter adap = new System.Data.SqlClient.SqlDataAdapter(sentencia, cadenaConexion);
                System.Data.DataSet ds = new DataSet();
                adap.Fill(ds);
                mensaje = ds.Tables[0].Rows[0][CampoNombre.Replace(tabla.TableName + ".", "")].ToString().Trim();
                lblInfo.Text = mensaje.Trim();
                txtData.Text = ds.Tables[0].Rows[0][campoValor.Replace(tabla.TableName + ".", "")].ToString().Trim();
                valoresCorrectos = true;
#endregion
                return true;
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            valoresCorrectos = false;
            if (textChanged != null)
                textChanged(sender, e);
            if (txtData.Enabled == false || txtData.ReadOnly)
            {
                validar(true);
            }
        }

        private void txtData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!validar(true)) return;
            //primero hacemos el count 
            if (cargarVentana())
            {
                this.FindForm().SelectNextControl(this, true, true, true, true);
            }
        }
    }
}

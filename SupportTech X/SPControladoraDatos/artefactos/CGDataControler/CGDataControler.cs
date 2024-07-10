using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad;

namespace CGDataControler
{
    public partial class CGDataControler : UserControl
    {
        public CGDataControler()
        {
            //System.Reflection.Assembly ensamblado = System.Reflection.Assembly.GetEntryAssembly();
            //string a = ensamblado.FullName;
            //if (a.IndexOf("SPX") < 0)
            //{
            //    throw (new Exception(@"No se Cargaron algunos ensamblados Primarios, \n Mas Informacion http://helpcentral.componentone.com/CS/forums/"));
            //}
            InitializeComponent();
        }

        private bool eventosEncendidos = false;
        public bool EventosEncendidos { set { eventosEncendidos = value; } get { return eventosEncendidos; } }

    
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (this.FindForm() != null)
            {
                this.FindForm().Paint += new PaintEventHandler(CGDataControler_Paint);
            }
        }

        void CGDataControler_Paint(object sender, PaintEventArgs e)
        {
            if (!eventosEncendidos) return;
            this.Refresh();
        }

        /// <summary>
        /// Ajusta el estado de los check box para asegurarse de que grave el valor del check.
        /// </summary>
        private void AjustarCheckBox()
        {
            if (!eventosEncendidos) return;
            if (cmTabla == null) return;

            System.Type tipo;

            for (int k = 0; k < cmTabla.Bindings.Count; k++)
            {
                object obj = cmTabla.Bindings[k].Control;
                tipo = obj.GetType();
                string nombre = cmTabla.Bindings[k].BindingMemberInfo.BindingField.ToString().Trim();
                int valor = 0;
                if (tipo.GetProperty("Checked") != null && tipo.Name.ToUpper().IndexOf("CHECKBOX") >= 0)
                {
                    valor = (bool.Parse(tipo.GetProperty("Checked").GetValue(obj, null).ToString().Trim())) ? 1 : 0;
                    (cmTabla.Current as System.Data.DataRowView)[nombre] = valor;
                }
            }
        }

        bool editaLlaves = false;
        /// <summary>
        /// Esta propiedad me indica que cuando le da la opcion de modificar si puede editar
        /// las llaves de la primaria o no
        /// </summary>
        public bool EditaLlaves { set { editaLlaves = value; } get { return editaLlaves; } }
        /// <summary>
        /// Ajusta el estado de edicion de cada uno de los controles asociados al
        /// binding context.
        /// </summary>
        /// <param name="estado">estado de edicion de los controles, true deja editar
        /// false no.</param>
        private void AjustarControles(bool estado)
        {
            if (!eventosEncendidos) return;
            if (!EditaControles) return;
            if (cmTabla == null) return;

            System.Type tipo;

            for (int k = 0; k < cmTabla.Bindings.Count; k++)
            {
                object obj = cmTabla.Bindings[k].Control;
                tipo = obj.GetType();
                //esto es para verificar si elcampo es llave primaria
                bool esLlave=false;
                int limite=dtTabla.PrimaryKey.Length;
                string nombre = cmTabla.Bindings[k].BindingMemberInfo.BindingField.ToString().Trim();

                
                for(int contador=0;contador<limite && (EstadoDatos== EstadosDatos.Edicion && !editaLlaves)  ;contador++){

                    if (dtTabla.PrimaryKey[contador].ColumnName.Trim() == nombre.Trim())
                        esLlave = true;
                }

                if (tipo.GetProperty("ReadOnly") != null)
                {
                    object[] objArr ={ !estado || esLlave};
                    tipo.InvokeMember("ReadOnly", System.Reflection.BindingFlags.SetProperty, null, obj, objArr);
                    cmTabla.Bindings[k].Control.Enabled = estado && !esLlave;
                }else{
                    cmTabla.Bindings[k].Control.Enabled = estado && !esLlave;
                }

                if (tipo.GetProperty("Text") != null)
                {
                    if (tipo.FullName.IndexOf("DateTimeAdv") >= 0)
                    {
                      //  object[] objArr = { tipo.GetProperty("Value").GetValue(obj, null).ToString().Trim() };
                      //  tipo.InvokeMember("Value", System.Reflection.BindingFlags.SetProperty, null, obj, objArr);
                    }
                    else
                    {
                        object[] objArr = { tipo.GetProperty("Text").GetValue(obj, null).ToString().Trim() };
                        tipo.InvokeMember("Text", System.Reflection.BindingFlags.SetProperty, null, obj, objArr);
                    }
                }
            }
            estadoControles = estado;
            if (estadoControlesChanged != null)
            {
                dataControlerEventArgs e_aux = new dataControlerEventArgs();
                e_aux.TipoAccion = TiposAcciones.Indeterminada;
                estadoControlesChanged(this, e_aux);
            }
        }

        /// <summary>
        /// Habilita o deshabilita el estado de los botones de acuerdo a la accion que se este ejecutando
        /// </summary>
        /// <param name="estado"></param>
        private void habilitarBotones(bool estado)
        {
            if (!eventosEncendidos) return;
            btnSiguiente.Enabled = estado && conBotonSiguiente;
            btnAnterior.Enabled = estado && conBotonAnterior;
            btnEliminar.Enabled = estado && conBotonEliminar;
            btnModificar.Enabled = estado && conBotonEditar;
            btnNuevo.Enabled = estado && conBotonAdicionar;
            btnPrimero.Enabled = estado && conBotonPrimero;
            btnUltimo.Enabled = estado && ConBotonUltimo;
            btnGuardar.Enabled = !estado && conBotonAceptar;
            btnCancelar.Enabled = !estado && conBotonDescartar;
            btnBuscar.Enabled = estado;
            btnBusquedaAvanzada.Enabled = estado;
            AjustarControles(!estado);
        }

        #region zona de declaracion de variables de datos
        private EstadosDatos _EstadoDatos;

        private bool _GuardarEnBaseDeDatos = true;
        /// <summary>
        /// Indica si los cambios efectuados en la tabla se guardan en la base de datos o no.
        /// </summary>
        public bool GuardarEnBaseDeDatos
        {
            get { return _GuardarEnBaseDeDatos; }
            set { _GuardarEnBaseDeDatos = value; }
        }
        private string mensajeAntesDeEliminar = "¿Esta seguro de querer eliminar este registro?";
        /// <summary>
        /// Mensaje que se muestra en el cuadro emergente antes de eliminar un registro
        /// </summary>
        public string MensajeAntesDeEliminar { set { mensajeAntesDeEliminar = value; } get { return mensajeAntesDeEliminar; } }
        private string mensajeAntesDeEliminarTitulo = "Confirmar Eliminación";
        /// <summary>
        /// Titulo del cuadro de dialogo que confirma la eliminacion de un registro.
        /// </summary>
        public string MensajeAntesDeEliminarTitulo { set { mensajeAntesDeEliminarTitulo = value; } get { return mensajeAntesDeEliminarTitulo; } }
        private bool editaControles = true;
        /// <summary>
        /// Si esta propiedad esta habilitada los controles no podran modificarse en estados 
        /// diferentes a modificar y a ingresar uno nuevo.
        /// </summary>
        public bool EditaControles { set { editaControles = value; } get { return editaControles; } }

        private CurrencyManager CmTabla = null;
        /// <summary>
        /// tabla donde se efectuan las operaciones
        /// un ejempo de asignacion es
        /// cmTabla= BindingContext[dataset,"dataMemeber"] as currencyManager;
        /// </summary>
        public CurrencyManager cmTabla
        {
            set
            {
                CmTabla = value;
                if (!eventosEncendidos) return;
                if (cambiarPosicion != null)
                {
                    if (CmTabla != null)
                        cmTabla.PositionChanged += new EventHandler(cambiarPosicion);
                }
                habilitarBotones(true);
                ajustarLongitudTexto();
            }
            get { return CmTabla; }
        }

        private object tableAdapter;
        /// <summary>
        /// Tableadapter que controla la table configurada
        /// </summary>
        public object TableAdapter { set { tableAdapter = value; } get { return tableAdapter; } }

        private DataTable dtTabla = null;
        /// <summary>
        /// Tabla en la cual se efectuan las operaciones
        /// </summary>
        public DataTable dataTabla { set { dtTabla = value;
        if (value != null) cargarCmTabla();
       
        } 
            
            
            get { return dtTabla; } }


        private bool esMdi = false;
        /// <summary>
        /// Inidica si el currency es o no del formulario que contiene el control si no de
        /// otro formulario que puede ser mdi
        /// </summary>
        public bool Esmdi { set { esMdi = value; } get { return esMdi; } }
        private void cargarCmTabla() 
        {
            if (this.FindForm() != null)
            {
                if (!eventosEncendidos) return;
                if(this.FindForm().BindingContext != null && dtTabla!= null)

                    if (!esMdi)
                    {
                        CmTabla = this.FindForm().BindingContext[dtTabla.DataSet, dtTabla.TableName] as CurrencyManager;
                    }
                AjustarControles(false);
                ajustarLongitudTexto();
            }
        }
        
        private bool estadoControles = true;
        /// <summary>
        /// Esta propiedad me indica si los controles asociados al
        /// binding context, si es verdadera indica que los controles se pueden editar
        /// </summary>
        public bool EstadoControles { get { return estadoControles; } set { estadoControles = value; } }

        /// <summary>
        /// Estado de los datos en el cual se encuentra la barra datos actualmente
        /// </summary>
        public EstadosDatos EstadoDatos
        { set { _EstadoDatos = value; } get { return _EstadoDatos; } }

        #endregion

        #region zona de declaracion de eventos
        /// <summary>
        /// Codigo que se ejecuta cuabdo cambio el estado de los controles
        /// </summary>
        public event dataControlerEventHandler estadoControlesChanged;
        /// <summary>
        /// se ejecuta cuando se cambia la poscicion.
        /// </summary>
        public event EventHandler cambiarPosicion;
        /// <summary>
        /// Codigo que se ejecuta al inicio de todos los eventos
        /// </summary>
        public event dataControlerEventHandler AntesDeAccion;
        /// <summary>
        /// Codigo que se ejecuta justo antes de eliminar la fila, despues del mensaje de confirmacion
        /// </summary>
        public event dataControlerEventHandler EliminarLlaves;

        /// <summary>
        /// Codigo que se ejecuta al final de todos lo eventos
        /// </summary>
        public event dataControlerEventHandler DespuesDeAccion;
        /// <summary>
        /// Codigo que se ejecuta cuando ocurre un error
        /// </summary>
        public event dataControlerEventHandler EnError;
        /// <summary>
        /// Codigo que se ejecuta al inicio de oprimir nuevo
        /// </summary>
        public event dataControlerEventHandler AntesDeNuevo;
        /// <summary>
        /// Codigo que se ejecuta al finalizar el evento de oprimir nuevo
        /// </summary>
        public event dataControlerEventHandler DespuesDeNuevo;
        /// <summary>
        /// Codigo que se ejecuta al inicio de oprimir modificar
        /// </summary>
        public event dataControlerEventHandler AntesDeModificar;
        /// <summary>
        /// Codigo que se ejecuta al final del evento de modificar
        /// </summary>
        public event dataControlerEventHandler DespuesDeModificar;
        /// <summary>
        /// Codigo que se ejecuta al inicio de eliminar
        /// </summary>
        public event dataControlerEventHandler AntesDeEliminar;
        /// <summary>
        /// Codigo que se ejecuta despues de eliminar
        /// </summary>
        public event dataControlerEventHandler DespuesDeEliminar;
        /// <summary>
        /// Codigo que se ejecuta al inicio del evento aceptar cambios
        /// </summary>
        public event dataControlerEventHandler AntesDeAceptar;
        /// <summary>
        /// Codigo quese ejecuta al final del evento aceptar cambios
        /// </summary>
        public event dataControlerEventHandler DespuesDeAceptar;
        /// <summary>
        /// Codigo que se ejecuta al inicio de cancelar cambios
        /// </summary>
        public event dataControlerEventHandler AntesDeCancelar;
        /// <summary>
        /// Codigo que se ejecuta al final de cancelar cambios
        /// </summary>
        public event dataControlerEventHandler DespuesDeCancelar;
        /// <summary>
        /// Codigo que se ejecuta antes de ir al primero
        /// </summary>
        public event dataControlerEventHandler AntesDePrimero;
        /// <summary>
        /// Codigo que se ejecuta despues de ir al primero
        /// </summary>
        public event dataControlerEventHandler DespuesDePrimero;
        /// <summary>
        /// Antes de oprimir el boton ir al ultimo
        /// </summary>
        public event dataControlerEventHandler AntesDeUltimo;
        /// <summary>
        /// despues de oprimir el boton ultimo
        /// </summary>
        public event dataControlerEventHandler DespuesDeUltimo;
        /// <summary>
        /// Antes de oprimir el boton siguiente
        /// </summary>
        public event dataControlerEventHandler AntesDeSiguiente;
        /// <summary>
        /// Despues de oprimir el boton siguiente
        /// </summary>
        public event dataControlerEventHandler DespuesDeSiguiente;
        /// <summary>
        /// Antes de oprimir el boton anterior
        /// </summary>
        public event dataControlerEventHandler AntesDeAnterior;
        /// <summary>
        /// Despues de oprimir el boton anterior
        /// </summary>
        public event dataControlerEventHandler DespuesDeAnterior;

        /// <summary>
        /// Antes de oprimir el boton anterior
        /// </summary>
        public event dataControlerEventHandler AntesDeBuscar;
        /// <summary>
        /// Despues de oprimir el boton anterior
        /// </summary>
        public event dataControlerEventHandler DespuesDeBuscar;


        #endregion

        #region zona de propiedades varias
        private int tamanoImagenesX = 38;
        /// <summary>
        /// Entero que define el ancho de las imagenes del control
        /// </summary>
        public int TamanoImagenesX { set { tamanoImagenesX = value; } get { return tamanoImagenesX; } }

        private int tamanoImagenesY = 38;
        /// <summary>
        /// Entero que define el Largo de las imagenes del control
        /// </summary>
        public int TamanoImagenesY { set { tamanoImagenesY = value; } get { return tamanoImagenesY; } }

        private int tamanoImagenesXMax = 44;
  
        /// <summary>
        /// Entero que define el Largo de las imagenes del control
        /// </summary>
        public int TamanoImagenesXMax { set { tamanoImagenesXMax = value; } get { return tamanoImagenesXMax; } }

        private int tamanoImagenesYMax = 44;
        /// <summary>
        /// Entero que define el Largo de las imagenes del control
        /// </summary>
        public int TamanoImagenesYMax { set { tamanoImagenesYMax = value; } get { return tamanoImagenesYMax; } }

        private int numeroTomas = 4;
        private bool usarEfectos = false;
        /// <summary>
        /// Indica si utiliza los efectos de magnificacion de los iconos
        /// </summary>
        public bool UsarEfectos { set { usarEfectos = value; } get { return usarEfectos; } }

        private bool mostrarConsulta = true;
        /// <summary>
        /// Indica si se debe mostrar el panel de consultas o no
        /// </summary>
        public bool MostrarConsulta { set { mostrarConsulta = value; } get { return mostrarConsulta; } }
        private bool mostrarControlDatos = true;
        /// <summary>
        /// Indica si se debe mostrar el panel de Administracion de datos o no
        /// </summary>
        public bool MostrarControlDatos { set { mostrarControlDatos = value; } get { return mostrarControlDatos; } }

        private bool panelConsultaVisible = true;
        public bool PanelConsultaVisible { set { panelConsultaVisible = value; inicalizarPanelConsulta(); } get { return panelConsultaVisible; } } 
        private List<Image> imgs;
#endregion
    
        #region zona de efectos y graficos
        /// <summary>
        /// Evento que se ejecuta cuando el mouse esta encima, la imagen se agranda
        /// </summary>
        /// <param name="sender">boton</param>
        /// <param name="e"></param>
        private void ingresarImagen(object sender, EventArgs e)
        {
            if (!usarEfectos) return;
            ToolStripButton boton = (ToolStripButton)sender;
            if (boton == btnOcultar) return;
            int x = (tamanoImagenesXMax - tamanoImagenesX) / numeroTomas;
            int y = (tamanoImagenesYMax - tamanoImagenesY) / numeroTomas;
            Bitmap img;
            int j=contenedor.Items.IndexOf(boton);
            for (int k = 0; k < (numeroTomas-1); k++)
            {
                img = new Bitmap(imgs[j], new Size(tamanoImagenesX + ((k + 1) * x), tamanoImagenesY + ((k + 1) * y)));
                boton.Image = img;
                
                //cambiamos el de la izquierda
                if (j != 0 && imgs[j - 1] != null)
                {
                    img = new Bitmap(imgs[j-1], new Size(tamanoImagenesX +( ((k + 1) * x))/2, tamanoImagenesY + (((k + 1) * y))/2 ));
                    contenedor.Items[j-1].Image = img;
                }
                //cambiamos el de la derecha
                if (j != contenedor.Items.Count - 1 && imgs[j + 1] != null)
                {
                    img = new Bitmap(imgs[j+1], new Size(tamanoImagenesX +( ((k + 1) * x))/2, tamanoImagenesY + (((k + 1) * y))/2 ));
                    contenedor.Items[j+1].Image = img;
                }
                contenedor.Refresh();
            }//fin del for
            //cambiamos el de la izquierda
            if (j != 0 && imgs[j - 1] != null)
            {
                img = new Bitmap(imgs[j - 1], new Size(tamanoImagenesX + (((numeroTomas) * x)) / 2, tamanoImagenesY + (((numeroTomas + 1) * y)) / 2));
                contenedor.Items[j - 1].Image = img;
            }
            //cambiamos el de la derecha
            if (j != contenedor.Items.Count - 1 && imgs[j + 1] != null)
            {
                img = new Bitmap(imgs[j + 1], new Size(tamanoImagenesX + (((numeroTomas + 1) * x)) / 2, tamanoImagenesY + (((numeroTomas + 1) * y)) / 2));
                contenedor.Items[j + 1].Image = img;
            }
                
            img = new Bitmap(imgs[j], new Size(tamanoImagenesXMax, tamanoImagenesYMax));
            boton.Image = img;
        }
        
        /// <summary>
        /// Evento que se ejecuta cuando el mouse sale, la imagen se ajusta a su tamano normal
        /// </summary>
        /// <param name="sender">boton</param>
        /// <param name="e"></param>
        private void abandonarImagen(object sender, EventArgs e)
        {
            if (!usarEfectos) return;
            ToolStripButton boton = (ToolStripButton)sender;
            if (boton == btnOcultar) return;
            int x = (tamanoImagenesXMax - tamanoImagenesX) / numeroTomas;
            int y = (tamanoImagenesYMax - tamanoImagenesY) / numeroTomas;
            Bitmap img;
            int j = contenedor.Items.IndexOf(boton);


            for (int k = 0; k < (numeroTomas - 1); k++)
            {
                img = new Bitmap(imgs[j], new Size(tamanoImagenesXMax - ((k + 1) * x), tamanoImagenesYMax - ((k + 1) * y)));
                boton.Image = img;
                //cambiamos el de la izquierda
                if (j != 0 && imgs[j - 1] != null)
                {
                    img = new Bitmap(imgs[j - 1], new Size((tamanoImagenesXMax - (x * numeroTomas)) - (((k + 1) * x)) / 2, (tamanoImagenesYMax - (y * numeroTomas)) - (((k + 1) * y)) / 2));
                    contenedor.Items[j - 1].Image = img;
                }
                //cambiamos el de la derecha
                if (j != contenedor.Items.Count - 1 && imgs[j + 1] != null)
                {
                    img = new Bitmap(imgs[j + 1], new Size((tamanoImagenesXMax - (x * numeroTomas)) - (((k + 1) * x)) / 2, (tamanoImagenesYMax - (y * numeroTomas)) - (((k + 1) * y)) / 2));
                    contenedor.Items[j + 1].Image = img;
                }
                contenedor.Refresh();
                System.Threading.Thread.Sleep(20);
            }
            //cambiamos el de la izquierda
            if (j != 0 && imgs[j - 1] != null)
            {
                img = new Bitmap(imgs[j - 1], new Size(tamanoImagenesX , tamanoImagenesY ));
                contenedor.Items[j - 1].Image = img;
            }
            //cambiamos el de la derecha
            if (j != contenedor.Items.Count - 1 && imgs[j + 1] != null)
            {
                img = new Bitmap(imgs[j + 1], new Size(tamanoImagenesX , tamanoImagenesY ));
                contenedor.Items[j + 1].Image = img;
            }
            img = new Bitmap(imgs[j], new Size(tamanoImagenesX, tamanoImagenesY));
            boton.Image = img;
        }
        
        /// <summary>
        /// Inicializa las imagenes ajustando el tamano,el modo de escala que maneja cada imagen y los asocia al evento de animacion
        /// </summary>
        private void inicializarImagenes()
        {
            imgs = new List<Image>();
            for (int k = 0; k < contenedor.Items.Count; k++)
            {
                Type tipo=contenedor.Items[k].GetType();
                imgs.Add(contenedor.Items[k].Image);//esto se hace para no perder calidad cuando se redimensiona
                if (tipo.FullName.ToUpper() == "System.Windows.Forms.ToolStripButton".ToUpper() && contenedor.Items[k].Image != null)
                {            
                    Bitmap img = new Bitmap(contenedor.Items[k].Image, new Size(tamanoImagenesX, tamanoImagenesY));
                    contenedor.Items[k].Image = img;
                    contenedor.Items[k].ImageScaling = ToolStripItemImageScaling.None;
                    //agregamos el evento
                    contenedor.Items[k].MouseLeave += new EventHandler(abandonarImagen);
                    contenedor.Items[k].MouseHover += new EventHandler(ingresarImagen);
                } 
            }
            
        }

        /// <summary>
        /// inicializa el estado visual del panel de consulta
        /// </summary>
        private void inicalizarPanelConsulta() 
        {
            if (mostrarControlDatos == false) 
            {
                btnAnterior.Visible = false;
                btnCancelar.Visible = false;
                btnEliminar.Visible = false;
                btnGuardar.Visible = false;
                btnModificar.Visible = false;
                btnNuevo.Visible = false;
                btnPrimero.Visible = false;
                btnSiguiente.Visible = false;
                btnUltimo.Visible = false;
                toolStripSeparator1.Visible = false;
                toolStripSeparator2.Visible = false;
                toolStripSeparator3.Visible = false;
            
            }
            if (mostrarConsulta == false) 
            {
                btnOcultar.Visible = false;
                btnBuscar.Visible = false;
                btnBusquedaAvanzada.Visible = false;
                txtBusqueda.Visible = false;
                cmbCampos.Visible = false;
            }
            btnBuscar.Visible = panelConsultaVisible;
            btnBusquedaAvanzada.Visible = panelConsultaVisible;
            cmbCampos.Visible = panelConsultaVisible;
            txtBusqueda.Visible = panelConsultaVisible;
            if (panelConsultaVisible == false)
            {
                btnOcultar.ToolTipText = "Mostrar";
                btnOcultar.Text = ">>";
            }else{
                btnOcultar.ToolTipText = "Ocultar";
                btnOcultar.Text = "<<";
            }
        }
        #endregion

        #region propiedades de botones
        private bool conBotonAdicionar = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton nuevo
        /// </summary>
        public bool ConBotonAdicionar
        {
            get { return conBotonAdicionar; }
            set { conBotonAdicionar = value; btnNuevo.Enabled = value; }
        }
        private bool conBotonEditar = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton edicion
        /// </summary>
        public bool ConBotonEditar
        {
            get { return conBotonEditar; }
            set { conBotonEditar = value; btnModificar.Enabled = value; }
        }

        private bool conBotonEliminar = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de eliminar
        /// </summary>
        public bool ConBotonEliminar
        {
            get { return conBotonEliminar; }
            set { conBotonEliminar = value; btnEliminar.Enabled = value; }
        }
        private bool conBotonAceptar = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de aceptar
        /// </summary>
        public bool ConBotonAceptar
        {
            get { return conBotonAceptar; }
            set { conBotonAceptar = value; btnGuardar.Enabled = value; }
        }
        private bool conBotonDescartar = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de descartar
        /// </summary>
        public bool ConBotonDescartar
        {
            get { return conBotonDescartar; }
            set { conBotonDescartar = value; btnCancelar.Enabled = value; }
        }
        private bool conBotonPrimero = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de primero
        /// </summary>
        public bool ConBotonPrimero
        {
            get { return conBotonPrimero; }
            set { conBotonPrimero = value; btnPrimero.Enabled = value; }
        }
        private bool conBotonAnterior = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de anterior
        /// </summary>
        public bool ConBotonAnterior
        {
            get { return conBotonAnterior; }
            set { conBotonAnterior = value; btnAnterior.Enabled = value; }
        }
        private bool conBotonSiguiente = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de siguiente
        /// </summary>
        public bool ConBotonSiguiente
        {
            get { return conBotonSiguiente; }
            set { conBotonSiguiente = value; btnSiguiente.Enabled = value; }
        }
        private bool conBotonUltimo = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de ir a Ultimo
        /// </summary>
        public bool ConBotonUltimo
        {
            get { return conBotonUltimo; }
            set { conBotonUltimo = value; btnUltimo.Enabled = value; }
        }
        private bool conBotonSalir = true;
        /// <summary>
        /// Indica si el control tiene habilitado el boton de salir
        /// </summary>
        public bool ConBotonSalir
        {
            get { return conBotonSalir; }
            set { conBotonSalir = value; btnSalir.Enabled = value; }
        }
        #endregion

        private bool verificarCondiciones()
        {
            if (CmTabla == null)
            {
                MessageBox.Show("No esta configurado el currency manager.");
                return false;
            }
            if (dataTabla == null) { MessageBox.Show("No esta configurado el datatable."); return false; }
            if (tableAdapter == null) { MessageBox.Show("No esta configurado el tableAdapter."); return false; }
            return true;
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            panelConsultaVisible = !panelConsultaVisible;
            btnBuscar.Visible = panelConsultaVisible;
            btnBusquedaAvanzada.Visible = panelConsultaVisible;
            cmbCampos.Visible = panelConsultaVisible;
            txtBusqueda.Visible = panelConsultaVisible;
            if (panelConsultaVisible == false)
            {
                btnOcultar.ToolTipText = "Mostrar";
                btnOcultar.Text = ">>";
            } else {
                btnOcultar.ToolTipText = "Ocultar";
                btnOcultar.Text = "<<";
            }
            this.Width = contenedor.Width;
            Refresh();
        }

        private void ajustarLongitudTexto() 
        {
            if (!eventosEncendidos) return;
            if (dtTabla == null || cmTabla == null || cmTabla.Bindings == null || this.FindForm() ==null) return;

            System.Type tipo;

            for (int k = 0; k < cmTabla.Bindings.Count; k++)
            {
                object obj = cmTabla.Bindings[k].Control;
                tipo = obj.GetType();
                //esto es para verificar si campo es llave primaria
                int max = 0;
                int limite = dtTabla.Columns.Count;
                string nombre = cmTabla.Bindings[k].BindingMemberInfo.BindingField.ToString().Trim();
                
                for (int contador = 0; contador < limite ; contador++)
                {
                    if (dtTabla.Columns[contador].ColumnName.Trim() == nombre.Trim())
                    {
                        max = dtTabla.Columns[contador].MaxLength;
                            break;
                    }
                }

                if (tipo.GetProperty("MaxLength") != null)
                {
                    if (max > 0)
                    {
                        object[] objArr ={ max };
                        tipo.InvokeMember("MaxLength", System.Reflection.BindingFlags.SetProperty, null, obj, objArr);
                    }
                }    
            }
        
        }

        /// <summary>
        /// inicializa Seguridad, mira si el usuario puede modificar o editar o consultar y habilita los usuarios respectivos.
        /// </summary>
        private bool inicializarSeguridad()
        { 
            if(modulo== 0 && ModuloSeguridad ==0)return true;
        //CgSeguridadCrisma.Login.UsuarioLogeado
            verificadorPermisos objV = new verificadorPermisos();
            objV.codModulo = modulo;
            objV.codUsuario = SPXSeguridad.logica.sesion.CodUsuarioAutenticado;
            objV.solicitarAutorizacion();
            conBotonAceptar = true;
            conBotonAdicionar= objV.Adicionar;
            conBotonAnterior = objV.Consultar;
            conBotonDescartar = true;
            conBotonEditar = objV.Modificar;
            conBotonEliminar = objV.Borrar;
            conBotonPrimero = objV.Consultar;
            conBotonSalir = objV.Consultar;
            conBotonSiguiente = objV.Consultar;
            conBotonUltimo = objV.Consultar;
            mostrarConsulta = objV.Consultar;
            return true;
        }

        private int modulo =0;

        /// <summary>
        /// Me dice que modulo de seguridad me controla el acceso a la aplicacion.
        /// </summary>
        public int ModuloSeguridad { set { modulo = value; Enabled= inicializarSeguridad(); } get { return modulo; } }

        private void CGDataControler_Load_1(object sender, EventArgs e)
        {
            inicializarImagenes();
            inicalizarPanelConsulta();

            if (!inicializarSeguridad()){
                MessageBox.Show("No tiene permisos para ejecutar esta ventana!!!!","Acceso Denegado",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                Application.DoEvents();
                Enabled = false;
            }
            cargarCmTabla();
            habilitarBotones(true);
            //se ejecuta un metodo el cual limita los campos de texto al limite que se tiene desde la base de datos
            ajustarLongitudTexto();
            //
            if (cambiarPosicion != null)
            {
                if (CmTabla != null)
                    cmTabla.PositionChanged += new EventHandler(posicionCambio);
            }
            this.Width = contenedor.Width-2;
            this.Height = contenedor.Height-2;
            Refresh();
        }

        private void posicionCambio(object sender, EventArgs e)
        {
            if (cambiarPosicion != null)
            {
                cambiarPosicion(this, e);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Adicionar;
            if (!antesEvento(e_aux.TipoAccion)) return;

            cmTabla.EndCurrentEdit();
            cmTabla.AddNew();            
            this.EstadoDatos = EstadosDatos.Adicion;
            habilitarBotones(false);
            despuesEvento(e_aux.TipoAccion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Editar;
            if (!antesEvento(e_aux.TipoAccion)) return;

            if (cmTabla.Count <= 0) return;
            this.EstadoDatos = EstadosDatos.Edicion;
            habilitarBotones(false);
            
            despuesEvento(e_aux.TipoAccion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Eliminar;
            try
            {

                if (!antesEvento(e_aux.TipoAccion)) return;

                if (cmTabla.Count <= 0) return;
                if (MensajeAntesDeEliminar != "")
                {
                    if (MessageBox.Show(this.FindForm(), MensajeAntesDeEliminar,
                        MensajeAntesDeEliminarTitulo, MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        return;
                }

                if (EliminarLlaves != null)
                    EliminarLlaves(this, e_aux);
                cmTabla.RemoveAt(cmTabla.Position);
                GuardarDatos();
                this.EstadoDatos = EstadosDatos.Consulta;
                despuesEvento(e_aux.TipoAccion);
            }
            catch (Exception ex)
            {
                dtTabla.RejectChanges();
                if (EnError != null)
                {
                    e_aux.ex = ex;
                    EnError(this, e_aux);
                }
                else
                {
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show(ex.InnerException.Message);
                    }
                    else {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        /// <summary>
        /// Ejecuta el codigo cuando se pulsa el boton guardar
        /// </summary>
        public void guardar()
        {
            if (!verificarCondiciones()) return;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Aceptar;
            try
            {

                if (!antesEvento(e_aux.TipoAccion)) return;

                CmTabla.EndCurrentEdit();
                GuardarDatos();
                this.EstadoDatos = EstadosDatos.Aceptado;
                habilitarBotones(true);                
                despuesEvento(e_aux.TipoAccion);
            }
            catch (Exception ex)
            {
                dtTabla.RejectChanges();
                if (EnError != null)
                {
                    e_aux.ex = ex.InnerException;
                    EnError(this, e_aux);
                }
                else
                {
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show(ex.InnerException.Message);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar(e);
        }
        /// <summary>
        /// Ejecuta el codigo cuando se pulsa el boton cancelar
        /// </summary>
        public void cancelar(EventArgs e)
        {
            if (!verificarCondiciones()) return;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            bool b = false;
            b = (this.EstadoDatos == EstadosDatos.Adicion);

            e_aux.TipoAccion = TiposAcciones.Descartar;
            if (!antesEvento(e_aux.TipoAccion)) return;

            cmTabla.CancelCurrentEdit();
            this.EstadoDatos = EstadosDatos.Descartado;
            habilitarBotones(true);
            if (b && cambiarPosicion != null) cambiarPosicion(this, e);
            
            despuesEvento(e_aux.TipoAccion);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Primero;
            if (!antesEvento(e_aux.TipoAccion)) return;

            if (cmTabla.Count > 0)
                cmTabla.Position = 0;

            this.EstadoDatos = EstadosDatos.Consulta;
            despuesEvento(e_aux.TipoAccion);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anterior();
        }

        public bool anterior() 
        {
            bool res = false;
            if (!verificarCondiciones()) return false;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Anterior;
            if (!antesEvento(e_aux.TipoAccion)) return false;

            if (cmTabla.Position > 0)
            {
                cmTabla.Position--;
                res = true;
            }
            this.EstadoDatos = EstadosDatos.Consulta;
            despuesEvento(e_aux.TipoAccion);

            return res;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            siguiente();
        }

        public bool siguiente()
        {
            bool res = false;
                    if (!verificarCondiciones()) return false;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Siguiente;
            if (!antesEvento(e_aux.TipoAccion)) return false;

            if (cmTabla.Position < cmTabla.Count - 1 && cmTabla.Count > 0)
            {
                cmTabla.Position++;
                res = true;
            }
            this.EstadoDatos = EstadosDatos.Consulta;
            despuesEvento(e_aux.TipoAccion);
            return res;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = TiposAcciones.Ultimo;
            if (!antesEvento(e_aux.TipoAccion)) return;

            cmTabla.Position = cmTabla.Count - 1;
            this.EstadoDatos = EstadosDatos.Consulta;
            despuesEvento(e_aux.TipoAccion);
        }

        private bool antesEvento(TiposAcciones tipoAccion)
        {
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            
            e_aux.TipoAccion = tipoAccion;
            ///La siguiente linea es para corregir el bug del focus del binding context
            this.FindForm().SelectNextControl(this.FindForm(), true, true, true, true);
            if (AntesDeAccion != null)
            {
                AntesDeAccion(this, e_aux);
                if (e_aux.Cancelar)
                    return false;
            }
            #region opciones del switch
            switch (tipoAccion)
            {
                case TiposAcciones.Aceptar:
                    {

                        //hacemos un ajuste para los campos de tip checkBox
                        AjustarCheckBox();
                        if (AntesDeAceptar != null)
                            AntesDeAceptar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Adicionar:
                    {
                        if (AntesDeNuevo != null)
                            AntesDeNuevo(this, e_aux);
                        break;
                    }
                case TiposAcciones.Anterior:
                    {
                        if (AntesDeAnterior != null)
                            AntesDeAnterior(this, e_aux);
                        break;
                    }
                case TiposAcciones.Descartar:
                    {
                        if (AntesDeCancelar != null)
                            AntesDeCancelar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Editar:
                    {
                        if (AntesDeModificar != null)
                            AntesDeModificar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Eliminar:
                    {
                        if (AntesDeEliminar != null)
                            AntesDeEliminar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Primero:
                    {
                        if (AntesDePrimero != null)
                            AntesDePrimero(this, e_aux);
                        break;
                    }
                case TiposAcciones.Siguiente:
                    {
                        if (AntesDeSiguiente != null)
                            AntesDeSiguiente(this, e_aux);
                        break;
                    }
                case TiposAcciones.Ultimo:
                    {
                        if (AntesDeUltimo != null)
                            AntesDeUltimo(this, e_aux);
                        break;
                    }
                case TiposAcciones.Buscar:
                    {
                        if (AntesDeBuscar != null)
                            AntesDeBuscar(this, e_aux);
                        break;
                    }
                case TiposAcciones.BusquedaAvanzada:
                    {
                        if (AntesDeBuscar != null)
                            AntesDeBuscar(this, e_aux);
                        break;
                    }
            }
            #endregion
            if (e_aux.Cancelar)
                return false;

            return true;
        }

        private void despuesEvento(TiposAcciones tipoAccion)
        {
            dataControlerEventArgs e_aux = new dataControlerEventArgs();
            e_aux.TipoAccion = tipoAccion;
            #region opciones del switch
            switch (tipoAccion)
            {
                case TiposAcciones.Aceptar:
                    {
                        if (DespuesDeAceptar != null)
                            DespuesDeAceptar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Adicionar:
                    {
                        if (DespuesDeNuevo != null)
                            DespuesDeNuevo(this, e_aux);
                        break;
                    }
                case TiposAcciones.Anterior:
                    {
                        if (DespuesDeAnterior != null)
                            DespuesDeAnterior(this, e_aux);
                        break;
                    }
                case TiposAcciones.Descartar:
                    {
                        if (DespuesDeCancelar != null)
                            DespuesDeCancelar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Editar:
                    {
                        if (DespuesDeModificar != null)
                            DespuesDeModificar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Eliminar:
                    {
                        if (DespuesDeEliminar != null)
                            DespuesDeEliminar(this, e_aux);
                        break;
                    }
                case TiposAcciones.Primero:
                    {
                        if (DespuesDePrimero != null)
                            DespuesDePrimero(this, e_aux);
                        break;
                    }
                case TiposAcciones.Siguiente:
                    {
                        if (DespuesDeSiguiente != null)
                            DespuesDeSiguiente(this, e_aux);
                        break;
                    }
                case TiposAcciones.Ultimo:
                    {
                        if (DespuesDeUltimo != null)
                            DespuesDeUltimo(this, e_aux);
                        break;
                    }
                case TiposAcciones.Buscar:
                    {
                        if (DespuesDeBuscar != null)
                            DespuesDeBuscar(this, e_aux);
                        if ( cambiarPosicion != null)
                            cambiarPosicion(this, e_aux);
                        break;
                    }
                case TiposAcciones.BusquedaAvanzada:
                    {
                        if (DespuesDeBuscar != null)
                            DespuesDeBuscar(this, e_aux);
                        if (cambiarPosicion != null)
                            cambiarPosicion(this, e_aux);
                        break;
                    }
            }
            #endregion
            if (DespuesDeAccion != null)
                DespuesDeAccion(this, e_aux);
        }
        
        private void GuardarDatos()
        {

            if (GuardarEnBaseDeDatos)
            {
                dataControlerEventArgs e_aux = new dataControlerEventArgs();
                e_aux.TipoAccion = TiposAcciones.Aceptar;

                if (tableAdapter == null)
                {
                    throw (new Exception("No se configuro correctamente el TableAdapter."));
                }
                System.Type[] tipo ={ dtTabla.GetType() };
                System.Type tipoObjeto = tableAdapter.GetType();
                System.Reflection.MethodInfo metodo = tipoObjeto.GetMethod("Update", tipo);

                if (metodo != null)
                {
                    object[] parametros ={ dtTabla };
                    metodo.Invoke(tableAdapter, parametros);
                }

                dtTabla.AcceptChanges();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        
        private void buscar()
        {

            if (!verificarCondiciones()) return;
            if (cmbCampos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe especificar un criterio para el filtro.");
                txtBusqueda.Focus();
                return;
            }
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(iniciarAnimacion));
            hilo.Start();
            try
            {
                dataControlerEventArgs e_aux = new dataControlerEventArgs();
                e_aux.TipoAccion = TiposAcciones.Buscar;
                if (!antesEvento(e_aux.TipoAccion)) return;
                this.EstadoDatos = EstadosDatos.Consulta;
                string nuevoFiltro = "";
                string valor = txtBusqueda.Text.Trim()+"%";
                if (cmbCampos.ComboBox.SelectedValue.ToString().Trim().IndexOf('.')==(-1))
                {
                  nuevoFiltro = dtTabla.TableName.Trim()+"."+cmbCampos.ComboBox.SelectedValue.ToString().Trim() + " like '" + valor + "'";
                }else{
                  nuevoFiltro = cmbCampos.ComboBox.SelectedValue.ToString().Trim() + " like '" +valor  + "'";                
                }
                buscar(nuevoFiltro);
                despuesEvento(e_aux.TipoAccion);
                System.Threading.Thread.Sleep(400);
                frmAnimacion.Activo = false;
            }
            catch (NullReferenceException)
            {
                if (frmAnimacion != null && !frmAnimacion.IsDisposed)
                {
                    frmAnimacion.Activo = false;
                }
            }
            catch (Exception ex)
            {
                if (!frmAnimacion.IsDisposed)
                {
                    frmAnimacion.Activo = false;
                }

                MessageBox.Show("Error al ejecutar la busqueda "+ex.Message);
            }
            finally {
                if (frmAnimacion != null && !frmAnimacion.IsDisposed)
                {
                    frmAnimacion.Activo = false;
                }
            }

        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
                      
            try
            {
                dataControlerEventArgs e_aux = new dataControlerEventArgs();
                e_aux.TipoAccion = TiposAcciones.Buscar;
                if (!antesEvento(e_aux.TipoAccion)) return;
                this.EstadoDatos = EstadosDatos.Consulta;
                Formularios.frmBusquedaAvanzada frm = new Formularios.frmBusquedaAvanzada();
                #region Agregamos los campos
                for(int k=0;k<dtTabla.Columns.Count;k++)
                {
                    Formularios.tiposDatos tipo = Formularios.tiposDatos.texto;
                    if (dtTabla.Columns[k].DataType.Name.ToUpper() == "DATETIME")
                    {
                        tipo = Formularios.tiposDatos.fecha;
                    }else if (dtTabla.Columns[k].DataType.Name.ToUpper() == "STRING")
                    {
                        tipo = Formularios.tiposDatos.texto;
                    }
                    else if (dtTabla.Columns[k].DataType.Name.ToUpper().IndexOf("INT")>-1)
                    {
                        tipo = Formularios.tiposDatos.numerica;
                    }
                    else if (dtTabla.Columns[k].DataType.Name.ToUpper() == "DECIMAL"
                    || dtTabla.Columns[k].DataType.Name.ToUpper() == "SINGLE"
                    || dtTabla.Columns[k].DataType.Name.ToUpper() == "DOUBLE"
                        )
                    {
                        tipo = Formularios.tiposDatos.flotante;
                    }

                   string nombre=dtTabla.Columns[k].ColumnName.Trim();
                   for (int kj = 0; kj < cmbCampos.ComboBox.Items.Count; kj++)
                   {
                       cmbCampos.ComboBox.SelectedIndex = kj;
                       if (nombre == cmbCampos.ComboBox.SelectedValue.ToString().Trim())
                       {
                           nombre = cmbCampos.ComboBox.Text.Trim();
                           break;
                       }
                   }
                       frm.anexarCampos(nombre,dtTabla.Columns[k].ColumnName.Trim(), tipo);
                }
                cmbCampos.ComboBox.SelectedIndex = 0;
                #endregion
                if (frm.ShowDialog() == DialogResult.Cancel) {
                    return;
                }
                System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(iniciarAnimacion));
                hilo.Start();
                buscar(frm.Filtro);
                despuesEvento(e_aux.TipoAccion);
                System.Threading.Thread.Sleep(400);
                frmAnimacion.Activo = false;
            }catch (NullReferenceException){
                if (frmAnimacion != null && !frmAnimacion.IsDisposed)
                {
                    frmAnimacion.Activo = false;
                }
            }
            catch (Exception ex)
            {
                if (!frmAnimacion.IsDisposed)
                {
                    frmAnimacion.Activo = false;
                }
                MessageBox.Show("Error al ejecutar la busqueda " + ex.Message);
            }
            finally
            {
                if (frmAnimacion != null && !frmAnimacion.IsDisposed)
                {
                    frmAnimacion.Activo = false;
                }
            }
        }

        private void buscar(string filtroAdicional) 
        {
            Type tableAdapterType = tableAdapter.GetType();
            System.Data.Common.DbDataAdapter adapter =(System.Data.Common.DbDataAdapter) tableAdapterType.GetProperty("Adapter", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(tableAdapter, null);
            string sentencia = "";

            if (adapter.SelectCommand != null)
            {
                sentencia = adapter.SelectCommand.CommandText;
            }else{
                return;
            }
             
            if(filtroObligatorio.Trim() == string.Empty )
                adapter.SelectCommand.CommandText = adicionaCondiciones(sentencia, filtroAdicional);
           else
                adapter.SelectCommand.CommandText = adicionaCondiciones(sentencia, filtroObligatorio + " AND ( " + filtroAdicional + ")  ");
            dataTabla.Clear();
            adapter.FillLoadOption = LoadOption.OverwriteChanges;
            dataTabla.Rows.Clear();
            adapter.Fill(dataTabla);
            adapter.SelectCommand.CommandText = sentencia;
        }


        private string joinObligatorio = "";
        /// <summary>
        /// Cadena de Join Que Aplica alos filtros 
        /// </summary>
        public string JoinObligatorio { set { joinObligatorio = value; } get { return joinObligatorio; } }

        private string groupByObligatorio = "";

        public string GroupByObligatorio { set { groupByObligatorio = value; } get { return groupByObligatorio; } }
        
        private string orderByObligatorio = "";

        public string OrderByObligatorio {set{orderByObligatorio = value;} 
            get { return orderByObligatorio;}}
        
        /// <summary>
        /// Adiciona condiciones a una sentencia sql dependiendo de las condiciones where,order by y group by
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="filtro"></param>
        /// <returns></returns>
        private string adicionaCondiciones(string strSql,string filtro)
        {
            string campos="";
            string sql = "";
           
            for (int k = 0; k < dtTabla.Columns.Count; k++) 
            {
                campos += dtTabla.TableName.Trim() + "." + dtTabla.Columns[k].ColumnName.Trim();
                if (k != dtTabla.Columns.Count -1) campos += ",";
            }

            sql = "SELECT " + campos + " FROM " + dtTabla.TableName.Trim()+" "+ joinObligatorio
            + " WHERE " + filtro;

            return sql + " " + GroupByObligatorio + " " + orderByObligatorio;
        }
    
        private CgFormulariosAnimacion.FormBuscar frmAnimacion = null;
        private string filtroObligatorio = "";
        /// <summary>
        /// Indica una condicion obligatoria para el momento de hacer la busqueda y la busqueda avanzada
        /// </summary>
        public string FiltroObligatorio { set { filtroObligatorio = value.Trim(); } get { return filtroObligatorio; } }

        private string strCampos="";
        /// <summary>
        /// Esta son los campos que deberia incluir en el combo
        /// cada campo esta separado con coma de los demas, y ademas
        /// cada campo esta compuesto por nombre y por valor
        /// nombre|valor,nombre2|valor2
        /// esta configuracion indica dos campos.
        /// </summary>
        public string campos
        {
            get { return strCampos; }
            set
            {
                strCampos = value;
                if (strCampos != string.Empty)
                {
                    System.Data.DataTable tab = new System.Data.DataTable();
                    tab.Columns.Add("codigo");
                    tab.Columns.Add("texto");

                    string[] arrCampos;
                    arrCampos = strCampos.Split(',');
                    foreach (string strCmp in arrCampos)
                    {
                        string[] arrCmp;
                        arrCmp = strCmp.Split('|');
                        //--
                        System.Data.DataRow dr = tab.NewRow();
                        dr["codigo"] = arrCmp[1];
                        dr["texto"] = arrCmp[0];
                        tab.Rows.Add(dr);
                    }
                    
                    cmbCampos.ComboBox.DataSource = tab;
                    cmbCampos.ComboBox.DisplayMember = "texto";
                    cmbCampos.ComboBox.ValueMember = "codigo";

                    if (cmbCampos.Items.Count > 0)
                        cmbCampos.SelectedIndex = 0;

                }
            }
        }

        /// <summary>
        /// Inicial la ventana de animacion para las busquedas
        /// </summary>
        private void iniciarAnimacion()
        {
            frmAnimacion = new CgFormulariosAnimacion.FormBuscar();
            frmAnimacion.Show();
            frmAnimacion.moverGrafico();
        }

        /// <summary>
        /// Practico para asignar valores antes de guardar la tabla
        /// </summary>
        /// <param name="nombreCampo">columna de la base de datos</param>
        /// <param name="valor">Valor</param>
        public void asignarValor(string nombreCampo, object valor) 
        {
            if (CmTabla.Count > 0)
            {
                (CmTabla.Current as System.Data.DataRowView)[nombreCampo] = valor;
            }
        }

        public object verValor(string nombreCampo)
        {
            if (CmTabla == null) return null;
            if (CmTabla.Count > 0)
            {
                return (CmTabla.Current as System.Data.DataRowView)[nombreCampo];
            }
            return null;
        }

        private void contenedor_Resize(object sender, EventArgs e)
        {
           // if (this.Width != contenedor.Width)
           //{
           //    this.Width = contenedor.Width;
           //    Refresh();
           //}
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
            if (e.KeyCode == Keys.PageUp)
                anterior();
            if (e.KeyCode == Keys.PageDown)
                siguiente();
        }

        private void CGDataControler_KeyDown(object sender, KeyEventArgs e)
        {
            if(ActiveControl != null && ActiveControl.Name.Trim() == txtBusqueda.Name.Trim()) return;
            
            if (e.KeyCode == Keys.Left)
                anterior();
            if (e.KeyCode == Keys.Right)
                siguiente();
            if (e.KeyCode == Keys.PageUp)
                anterior();
            if (e.KeyCode == Keys.PageDown)
                siguiente();
        }
    }
}

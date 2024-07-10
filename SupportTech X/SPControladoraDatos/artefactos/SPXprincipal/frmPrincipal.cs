using SPControladoraDatos.artefactos;
using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad.data;
using SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface;

namespace SPControladoraDatos.artefactos.SPXprincipal
{
    public partial class frmPrincipal : Form
    {
        private SPXSeguridad.data.dsSPXSeguridad dsSPXSeguridad1;
        public frmPrincipal()
        {
            InitializeComponent();
            this.dsSPXSeguridad1 = new dsSPXSeguridad();
        }

        public class quicks 
        {
            public string frm { set; get; }
            public Image imagen { set; get; }
            public string toolTip { set; get; }
            public int permiso { set; get; }
        }

        public List<quicks> accesos = new List<quicks>();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SPXFrmAnimacion.frmEfectoProgreso frmAnimacion = new SPXFrmAnimacion.frmEfectoProgreso();

        /// <summary>
        /// Inicia la animacion al exportar a excel.
        /// </summary>
        public void iniciarAnimacion()
        {
            frmAnimacion = new SPXFrmAnimacion.frmEfectoProgreso();
            frmAnimacion.Show();
            frmAnimacion.animacion();
            
        }

        public bool inicializado = false;
        public void inicializar()
        {
            inicializarSoftware();
            cambiarTexto(this, this.Text + "        - User:" + SPXSeguridad.logica.sesion.NombreUsuarioAutenticado.Trim() + " BD:" +DataConector.BaseDatos.Trim() + "  Server:" +DataConector.Servidor.Trim() + "   ----");

            //Application.DoEvents();
           
            cambiarBool(this, true );
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;
            int Height = screen.Bounds.Height;
            int Width = screen.Bounds.Width;
            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);

            cmbLinea.DataSource = new BindingSource( dsSPXSeguridad1.linea,null);
            cmbLinea.DisplayMember = "linea.nombre_linea";
            cmbLinea.ValueMember = "linea.cod_linea";
            expandablePanel1.Visible = false;
            WindowState = FormWindowState.Maximized;
             Application.DoEvents();
            SuspendLayout();
            SPXprincipal.logica.clsInicializador.moduloSeguridad = true;
            SPXprincipal.logica.clsInicializador.moduloReportes = true;
            #region iniciamos el hilo de la animacion
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(iniciarAnimacion));
            hilo.Start();
            frmAnimacion.texto = "Iniciando "+SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware;
            frmAnimacion.total = 100;
            frmAnimacion.progeso = 5;
            #endregion           
            //es importante no poner inicializaCmponentes en un hilo debido  que no carga todos los permisos
            inicializarComponentes();
            if (accesos.Count >0 &&  (accesos[0].permiso ==0 || SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(accesos[0].permiso) ) )
            {
                btnQuick1.Visible = true;
                btnQuick1.Tooltip = accesos[0].toolTip;
                btnQuick1.Image = accesos[0].imagen;
                btnQuick1.Tag = accesos[0].frm;
            }
            if (accesos.Count > 1 && (accesos[1].permiso == 0 || SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(accesos[1].permiso)))
            {
                btnQuick2.Visible = true;
                btnQuick2.Tooltip = accesos[1].toolTip;
                btnQuick2.Image = accesos[1].imagen;
                btnQuick2.Tag = accesos[1].frm;
            }
            System.Threading.Thread hiloInicializar = new System.Threading.Thread(new System.Threading.ThreadStart( inicializar ));
            hiloInicializar.Start();
            
            //aca deberia cargar solo las lineas que tiene permiso el usuario.
            lineaTableAdapter1.FillByLineasPorPermisoUsuarioSinLogo( dsSPXSeguridad1.linea,SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
            if (dsSPXSeguridad1.linea.Count <= 0)
            {
                MessageBox.Show("No tiene lineas configuradas para el usuario que entro al sistema", "No lineas configuradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //esta funcion debe estar al final del load por que cierra la animacion.
             cargarOpcionesLinea();  //
            
 
            expandablePanel1.Visible = true;

           
            lanzarFormulario("spHerramientas.consultas.frmSeguimiento", false, false);



            #region finalizamos la animacion
            frmAnimacion.texto = "Finalizado";
            frmAnimacion.total = 100;
            frmAnimacion.progeso = 100;
            frmAnimacion.animacionEnd();
            #endregion
            while (!inicializado)
            {
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
            navigationPane1.Items[0].RaiseClick();
            try
            {
                frmAnimacion.animacionEnd();
                
            }catch(Exception ){
                frmAnimacion.Hide();
            }
            ResumeLayout(true);
        }

        private void lanzarFormulario(string nameSpace,bool filtralinea,bool logicaxlinea)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsUtilidadesReflection obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsUtilidadesReflection();
            bool esDialogo = false;
            bool esMdi = true;
            bool maximizar = true;
            //miramos si ya hay algun formulario creado del tipo que quiere mostrar
            for (int k = 0; k < this.MdiChildren.Length; k++)
            {
                if (this.MdiChildren[k].GetType().FullName == nameSpace)
                //hay que pensar algo para el tema de los listados de estado ya que el nameSpace es el mismo
                {
                    this.MdiChildren[k].Activate();
                    return;
                }
            }
            string info = ""+((filtralinea)?1:0)+"|"+((logicaxlinea)?1:0);
            object res = null;
            obj.showFormulario(nameSpace, esDialogo, null, null, out res, ((esMdi) ? this : null), this.Icon, maximizar,info);
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region delegados
        delegate void cambiarBoolCallBack(frmPrincipal f, bool valor);
        private void cambiarBool(frmPrincipal f, bool valor)
        {
            if (f.InvokeRequired)
            {
                cambiarBoolCallBack d = new cambiarBoolCallBack(cambiarBool);
                this.Invoke(d, new object[] { f, valor });
            }
            else
            {
                f.inicializado = valor;
            }
        }

        delegate void cambiarTextoCallBack(Form f, string valor);
        private void cambiarTexto(Form f, string valor)
        {
            if (f.InvokeRequired)
            {
                cambiarTextoCallBack d = new cambiarTextoCallBack(cambiarTexto);
                this.Invoke(d, new object[] { f, valor });
            }else{
                f.Text = valor;
            }
        }

       

        delegate void cambiarIconCallBack(Form f, Icon valor);
        private void cambiarIcon(Form f, Icon valor)
        {
            if (f.InvokeRequired)
            {
                cambiarIconCallBack d = new cambiarIconCallBack(cambiarIcon);
                this.Invoke(d, new object[] { f, valor });
            }
            else
            {
                f.Icon = valor;
            }
        }
        #endregion
        public void inicializarSoftware()
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar fr = new SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar();            
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.inicializar();
            #region cargamos el logotipo del soft
            if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware.Trim() != string.Empty)
            {
                cambiarTexto(this,SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware);
            }

            if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.logotipoSoftware != null)
            {
            }
            if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.iconoSoftware != null)
            {
                cambiarIcon(this, SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.iconoSoftware);
            }
            #endregion
        }
        
        public void inicializarComponentes()
        {
           DataConector objdata = new DataConector();
            //carguamos las conexiones
            //carga los permisos
           
            if (SPXprincipal.logica.clsInicializador.moduloSeguridad.HasValue && SPXprincipal.logica.clsInicializador.moduloSeguridad.Value)
            {
                SPXSeguridad.cnn.cargarPermisos();
                SPXSeguridad.cnn.cargarConexion(objdata.CadenaConexion);
            }

            if (SPXprincipal.logica.clsInicializador.moduloReportes.HasValue && SPXprincipal.logica.clsInicializador.moduloReportes.Value)
            {
                SPXQuery.cnn.cargarPermisos();
                SPXQuery.cnn.cargarConexion(objdata.CadenaConexion);
            }


        }

        public void cargarBotones() 
        {
            frmAnimacion.texto = "Limpiando Controles";
            frmAnimacion.progeso = 35;
            Application.DoEvents();
            limpiarControlesxlinea(navigationPane1.Controls, null);
            
            //carga los botones
            string modulo = "";
            List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface> lista = new List<SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.Interface>();
           
            frmAnimacion.texto = "Cargando Principal";
            frmAnimacion.progeso = 35;
            Application.DoEvents();
            lista = SPXprincipal.cnn.cargarOpcionesWindows(out modulo);
            crearBotones(lista, modulo);
            

                frmAnimacion.texto = "Cargando Seguridad";
                frmAnimacion.progeso = 45;
            Application.DoEvents();
            lista = SPXSeguridad.cnn.cargarOpcionesWindows(out modulo);
                crearBotones(lista, modulo);
            

                frmAnimacion.texto = "Cargando reportes";
                frmAnimacion.progeso = 55;
            Application.DoEvents();
            lista = SPXQuery.cnn.cargarOpcionesWindows(out modulo);
                crearBotones(lista, modulo);
            

            frmAnimacion.texto = "Cargando SPX 1/3";
            frmAnimacion.progeso = 65;
            Application.DoEvents();
            var l = logica.clsInicializador.botonesAdicionales.GetRange(0, 30);
            crearBotones(l, "");

            l = logica.clsInicializador.botonesAdicionales.GetRange(30, 40);
            frmAnimacion.texto = "Cargando SPX 2/3";
            frmAnimacion.progeso = 75;
            Application.DoEvents();
            crearBotones(l, "");


            frmAnimacion.texto = "Cargando SPX 3/3";
            frmAnimacion.progeso = 85;
            Application.DoEvents();
            l = logica.clsInicializador.botonesAdicionales.GetRange(70, logica.clsInicializador.botonesAdicionales.Count - 70);
            crearBotones(l, "");

            frmAnimacion.texto = "Finalizando";
            frmAnimacion.progeso = 95;
            Application.DoEvents();
            configuracionFinalBotones();
            
        }

        #region construccion del menu y de los botones
        public void configurarDimensionesPanel(DevComponents.DotNetBar.ItemPanel itemPanel,DevComponents.AdvTree.AdvTree contenedorNodos,int botones,int nodosRaiz) 
        {
            int x = 5, y = 15;
            int largoPanel = 0; 
            //si no tiene botones debe ocultar cada uno que no tenga nada
            if (itemPanel != null && botones > 0)
            {
                largoPanel = (botones) * 30;
                itemPanel.Size = new System.Drawing.Size(220, largoPanel);
                itemPanel.Location = new Point(x, y);
                y = largoPanel + 20;
                itemPanel.Visible = true;
            }else{
                itemPanel.Visible = false;
            }

            if (contenedorNodos != null && nodosRaiz > 0)
            {
                int nodos =  0;
                for (int k = 0; k < contenedorNodos.Nodes.Count; k++)
                {
                    if (contenedorNodos.Nodes[k].Nodes.Count > nodos)
                        nodos = contenedorNodos.Nodes[k].Nodes.Count;
                }
                nodos = nodosRaiz+nodos;
                contenedorNodos.Location = new Point(x, y);
                int largo = (nodos) * 30;
                int altoPanelBotones = (((botones) * 30) + 20);
                if (largo < 120)
                {
                    largo = 120;
                }
                else if ((largo + largoPanel + 20) > (navigationPane1.Size.Height - altoPanelBotones))
                {
                    largo = (navigationPane1.Size.Height) - (largoPanel + 40 + altoPanelBotones);
                }
                contenedorNodos.Size = new System.Drawing.Size(220, largo);
            }
            else {
                contenedorNodos.Visible = false;
            }
        }

        /// <summary>
        /// funcion empleada para localizar el nodo raiz
        /// </summary>
        /// <param name="textoNodo"></param>
        /// <param name="contenedorNodos"></param>
        /// <returns></returns>
        public DevComponents.AdvTree.Node localizarNodoRaiz(string textoNodo,DevComponents.AdvTree.AdvTree contenedorNodos) 
        {
            for (int k = 0; k < contenedorNodos.Nodes.Count; k++)
            {
                if (contenedorNodos.Nodes[k].Text.Trim() == textoNodo.Trim())
                {
                    return contenedorNodos.Nodes[k];
                }
             }
            return null;
        }

        /// <summary>
        /// ayuda a localizar el item panel donde pertenece un boton
        /// </summary>
        /// <param name="modulo"></param>
        /// <returns></returns>
        public DevComponents.DotNetBar.ItemPanel localizarItemPanel(string modulo)
        {
            #region localizamos el Item Panel del modulo existente

            //for (int j = 0; j < navigationPane1.Controls.Count; j++)
            //{
            //    if (navigationPane1.Controls[j].Name == "navigationPane" + modulo)
            //    {
            //        DevComponents.DotNetBar.NavigationPanePanel panelExistente = (DevComponents.DotNetBar.NavigationPanePanel)navigationPane1.Controls[j];

            //        for (int h = 0; h < panelExistente.Controls.Count; h++)
            //        {
            //            #region localiza el itempanel y localiza el advTree del panel principal que ya existe
            //            if (panelExistente.Controls[h].Name == "itemPanel" +modulo)
            //            {
            //                return (DevComponents.DotNetBar.ItemPanel)panelExistente.Controls[h];
            //            }
            //            #endregion
            //        }
            //        break;
            //    }
            //}

            Control[]  c = navigationPane1.Controls.Find("itemPanel" + modulo, true);
            if(c.Length>0)
                return (DevComponents.DotNetBar.ItemPanel)c[0];

            return null;
            #endregion
        }

        /// <summary>
        /// ayuda a localizar el item panel donde perntenece un nodo
        /// </summary>
        /// <param name="modulo"></param>
        /// <returns></returns>
        public DevComponents.AdvTree.AdvTree localizarContenedorNodos(string modulo)
        {
            #region localizamos el Item Panel del modulo existente

            //for (int j = 0; j < navigationPane1.Controls.Count; j++)
            //{
            //    if (navigationPane1.Controls[j].Name == "navigationPane" + modulo)
            //    {
            //        DevComponents.DotNetBar.NavigationPanePanel panelExistente = (DevComponents.DotNetBar.NavigationPanePanel)navigationPane1.Controls[j];
                    
            //        for (int h = 0; h < panelExistente.Controls.Count; h++)
            //        {
            //            #region localiza el itempanel y localiza el advTree del panel principal que ya existe
            //            if (panelExistente.Controls[h].Name == "advTree" + modulo)
            //            {
            //                return (DevComponents.AdvTree.AdvTree)panelExistente.Controls[h];
            //            }
            //            #endregion
            //        }
            //        break;
            //    }
            //}


            Control[] c = navigationPane1.Controls.Find("advTree" + modulo, true);
            if (c.Length > 0)
                return (DevComponents.AdvTree.AdvTree)c[0];

            return null;
            #endregion
        }


        public void crearBotones(List<Interface> lista, string nombreModulo)
        {
            if (lista.Count <= 0) return;
            
                int k = 0;
                for ( k = 0; k < lista.Count; k++)
                {
                    string moduloBuscar = nombreModulo;
                    if (lista[k].moduloExistente.Trim() != string.Empty && lista[k].moduloExistente != nombreModulo)
                    {
                        moduloBuscar = lista[k].moduloExistente;
                    }
                    #region verificamos permisos para el boton, miramos si ya fue agregado previamente y creamos el panel extensor.
                    //verificamos si esta en la lista de omitidos
                   
                     //verificamos si tiene permisos para el boton si no tiene permisos, 
                    if (lista[k].codFuncionalidad !=0 && 
                    !SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(lista[k].codFuncionalidad))
                   // continue;
                  
                  
                    //evaluamos si el boton ya fue agregado previamente
                    if (buscarControl(lista[k].codFuncionalidad, lista[k].codModulo,lista[k].textoBoton,moduloBuscar,lista[k].tag, navigationPane1.Controls,null)) continue;
                    lista[k].namespace_formulario = SPXprincipal.logica.clsInicializador.sustituirBoton(moduloBuscar, lista[k].funcionalidadExistente, lista[k].textoBoton, lista[k].namespace_formulario);
                    crearPanelExtensor(moduloBuscar);
#endregion
                    #region  configuramos el boton o el nodo dependiendo si tiene funcionalidad existente.
                    DevComponents.DotNetBar.ButtonItem btn = null;
                    DevComponents.AdvTree.Node nodo = null;
                    DevComponents.AdvTree.Node nodoRaiz = null;
                    bool categoria= (lista[k].funcionalidadExistente != null && lista[k].funcionalidadExistente.Trim() != string.Empty);
                   if(!categoria)//se dejo todo sin categoria
                   {
                             #region si no maneja categoria configuramos un boton
                    btn = new DevComponents.DotNetBar.ButtonItem();
                    btn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.TextOnlyAlways;
                    btn.Image = lista[k].imagenBoton;
                    btn.Tag = lista[k].tag + "@" + lista[k].codFuncionalidad
                        + "@" + lista[k].codModulo
                        + "@" + lista[k].namespace_formulario
                        + "@" + ((lista[k].EsDialogo)?"1":"0")
                        + "@" + ((lista[k].EsMdi) ? "1" : "0")
                        + "@" + ((lista[k].maximizar) ? "1" : "0")
                        + "@" + ((lista[k].filtraxlinea) ? "1" : "0")
                        + "@" + ((lista[k].logicaxlinea) ? "1" : "0");
                    
                    btn.ImageFixedSize = new System.Drawing.Size(22, 22);
                    btn.Name = "btnF" + lista[k].codFuncionalidad + "M" + lista[k].codModulo + "N" + lista[k].textoBoton.Replace(" ", "") + "MD" + moduloBuscar.Replace(" ", "");
                    btn.Text = lista[k].textoBoton;
                    
                    btn.Click += new EventHandler(btn_Click);
#endregion
                             localizarItemPanel(moduloBuscar).Items.Add(btn);
                   }else{
                        #region si maneja categoria configuramos el nodo
                    nodo=new DevComponents.AdvTree.Node(lista[k].textoBoton);
                    nodo.Text = lista[k].textoBoton;
             
                    nodo.Tag = lista[k].tag + "@" + lista[k].codFuncionalidad
                        + "@" + lista[k].codModulo
                        + "@" + lista[k].namespace_formulario
                        + "@" + ((lista[k].EsDialogo)?"1":"0")
                        + "@" + ((lista[k].EsMdi) ? "1" : "0")
                        + "@" + ((lista[k].maximizar) ? "1" : "0")
                        + "@" + ((lista[k].filtraxlinea) ? "1" : "0")
                        + "@" + ((lista[k].logicaxlinea) ? "1" : "0");

                    nodo.Style = new DevComponents.DotNetBar.ElementStyle();
                    nodo.Style.TextColor = Color.Black; 
                    if (lista[k].imagenBoton != null)
                       nodo.Image= new System.Drawing.Bitmap( lista[k].imagenBoton,new Size(20,20));
                       

                   nodo.Name = "nodoF" + lista[k].codFuncionalidad + "M" + lista[k].codModulo + "N" + lista[k].textoBoton.Replace(" ", "") + "MD" + moduloBuscar.Replace(" ", "");
                   nodo.NodeClick+=new EventHandler(btn_Click);
#endregion
                        #region agregamos el nodo a la categoria y funcionalidad que pertenece
                      DevComponents.AdvTree.AdvTree adE= localizarContenedorNodos(moduloBuscar);
                    adE.NodeStyle = new DevComponents.DotNetBar.ElementStyle();
                    adE.NodeStyle.TextColor = Color.Black;
                      nodoRaiz = localizarNodoRaiz(lista[k].funcionalidadExistente, adE);
                      if (nodoRaiz == null)//creamos el nodo raiz
                      {
                          nodoRaiz = new DevComponents.AdvTree.Node(lista[k].funcionalidadExistente);
                          nodoRaiz.Name = "nodoR" + lista[k].funcionalidadExistente + "m" + lista[k].moduloExistente;
                        nodoRaiz.Text = lista[k].funcionalidadExistente;
                          adE.Nodes.Add(nodoRaiz);
                      }
                    nodoRaiz.Style = new DevComponents.DotNetBar.ElementStyle();
                    nodoRaiz.Style.TextColor = Color.Black;
     
                      nodoRaiz.NodesIndent = -10;
                      nodoRaiz.Nodes.Add(nodo);
                    
#endregion
                   }
                    #endregion
                }
            
        }

        private void crearPanelExtensor(string nombreModulo)
        {
            if (navigationPane1.Controls.Find("navigationPane" + nombreModulo, false).Length <= 0)
            {
                #region creamos el itempanel
                DevComponents.DotNetBar.ItemPanel itemPanel = new DevComponents.DotNetBar.ItemPanel();
                itemPanel.BackgroundStyle.Class = "ItemPanel";
                itemPanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                itemPanel.ContainerControlProcessDialogKey = true;
                itemPanel.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
                itemPanel.Location = new System.Drawing.Point(19, 15);
                itemPanel.Name = "itemPanel" + nombreModulo;
                itemPanel.TabIndex = 0;
                itemPanel.Text = nombreModulo;
                #endregion
                #region creamos el contenedor de nodos
                DevComponents.AdvTree.NodeConnector nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
                nodeConnector1.ConnectorType = DevComponents.AdvTree.eNodeConnectorType.Line;
                nodeConnector1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                nodeConnector1.LineWidth = 1;

                DevComponents.DotNetBar.ElementStyle elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
                elementStyle1.Class = "";
                elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                elementStyle1.Name = "elementStyle1";
                elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;

                DevComponents.AdvTree.AdvTree ad = new DevComponents.AdvTree.AdvTree();
                ad.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
                ad.AllowDrop = false;
                ad.BackColor = System.Drawing.SystemColors.Window;
                ad.BackgroundStyle.Class = "TreeBorderKey";
                ad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                ad.Name = "advTree" + nombreModulo;
                ad.NodeStyle = elementStyle1;
                ad.NodesConnector = nodeConnector1;
                ad.ExpandWidth = 13;
                ad.NodeSpacing = 2;
                ad.PathSeparator = ";";
                ad.Styles.Add(elementStyle1);
                #endregion
                #region creamos el boton que lanza el panel
                DevComponents.DotNetBar.ButtonItem btnModulo = new DevComponents.DotNetBar.ButtonItem();
                btnModulo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
                btnModulo.Checked = true;
                btnModulo.Name = "btnModulo" + nombreModulo;
                btnModulo.OptionGroup = "navBar";
                btnModulo.Text = nombreModulo;
                #endregion
                #region creamos el navigation pane
                DevComponents.DotNetBar.NavigationPanePanel paneModulo = new DevComponents.DotNetBar.NavigationPanePanel();
                paneModulo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                paneModulo.Controls.Add(itemPanel);
                paneModulo.Controls.Add(ad);
                paneModulo.Dock = System.Windows.Forms.DockStyle.Fill;
                paneModulo.Name = "navigationPane" + nombreModulo;
                paneModulo.ParentItem = btnModulo;
                paneModulo.Style.Alignment = System.Drawing.StringAlignment.Center;
                paneModulo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
                paneModulo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
                paneModulo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
                paneModulo.Style.GradientAngle = 90;
                #endregion
                this.navigationPane1.Controls.Add(paneModulo);
                navigationPane1.Items.Add(btnModulo);
            }
        }

        /// <summary>
        /// Borra los botones que dependen del cambio de linea.
        /// </summary>
        /// <param name="codFuncionalidad"></param>
        /// <param name="codModulo"></param>
        /// <param name="textoBoton"></param>
        /// <param name="controlesArray"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool limpiarControlesxlinea(Control.ControlCollection controlesArray, DevComponents.DotNetBar.SubItemsCollection items)
        {
            for (int k = 0; controlesArray != null && k < controlesArray.Count; k++)
            {
                if (controlesArray[k].Tag != null)
                {
                    string[] str = controlesArray[k].Tag.ToString().Split('@');
                    //validamos si filtra por linea 
                    if (str.Length >= 8 && str[7] == "1")
                    {
                        controlesArray[k].Visible = false;
                        continue ;
                    }
                }
                //si el control es contenedoor de controles lo busca 
                if (controlesArray[k].Controls != null && controlesArray[k].Controls.Count > 0)
                {
                    bool b = limpiarControlesxlinea( controlesArray[k].Controls, null);
                    if (b) continue;
                }
                //si el control es contenedoor de items lo busca 
                if (controlesArray[k].GetType().FullName.IndexOf("ItemPanel") > 0)
                {
                    bool b = limpiarControlesxlinea( null, ((DevComponents.DotNetBar.ItemPanel)controlesArray[k]).Items);
                    if (b) continue;
                }

                if (controlesArray[k].GetType().FullName.IndexOf("AdvTree") > 0)
                {
                    for (int i = 0; i < ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes.Count; i++)
                    {
                        //si es nodo tree.
                        if (((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Tag != null)
                        {
                            string[] str = ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Tag.ToString().Split('@');
                            //validamos si filtra por linea 
                            if (str.Length >= 8 && str[7] == "1")
                            {
                                ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Visible = false;
                                continue;
                            }
                        }
                        for (int j = 0; j < ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Nodes.Count; j++)
                        {
                            //si es nodo tree.
                            if (((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Tag != null)
                            {
                                string[] str = ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Nodes[j].Tag.ToString().Split('@');
                                //validamos si filtra por linea 
                                if (str.Length >= 8 && str[7] == "1")
                                {
                                    ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Nodes[j].Visible = false;
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            //miramos en el caso de que es item.
            for (int k = 0; items != null && k < items.Count; k++)
            {
                if (items[k].Tag != null)
                {
                    string[] str = items[k].Tag.ToString().Split('@');
                    //validamos si filtra por linea 
                    if (str.Length >= 8 && str[7] == "1")
                    {
                        items[k].Visible = false;
                    }
                }
            }
            return false;
        }


        public bool buscarControl(int codFuncionalidad,int codModulo,string textoBoton,string modulo,object tag,Control.ControlCollection controlesArray,DevComponents.DotNetBar.SubItemsCollection items ) 
        {
            string cmpBtn = "btnF" + codFuncionalidad + "M" + codModulo + "N" + textoBoton.Replace(" ", "") + "MD" + modulo.Replace(" ", "");
            string cmpNodo = "nodoF" + codFuncionalidad + "M" + codModulo + "N" + textoBoton.Replace(" ", "") + "MD" + modulo.Replace(" ", "");
        

            for (int k = 0;controlesArray!= null && k < controlesArray.Count; k++)
            {
                if (controlesArray[k].Name.Trim() == cmpBtn ||
                 controlesArray[k].Name.Trim() == cmpNodo)
                {
                    controlesArray[k].Visible = true;
                    controlesArray[k].Tag = tag;       
//"nodoF" + lista[k].codFuncionalidad + "M" + lista[k].codModulo + "N" + lista[k].textoBoton.Replace(" ", "") + "MD" + moduloBuscar
                    return true;
                }
                //si el control es contenedoor de controles lo busca 
                if (controlesArray[k].Controls != null && controlesArray[k].Controls.Count > 0)
                {
                     bool b=    buscarControl(codFuncionalidad, codModulo,textoBoton,modulo,tag, controlesArray[k].Controls,null);
                     if (b) return b;
                }
                //si el control es contenedoor de items lo busca 
                if (controlesArray[k].GetType().FullName.IndexOf("ItemPanel")>0 )
                {
                    bool b = buscarControl(codFuncionalidad, codModulo,textoBoton,modulo,tag, null, ((DevComponents.DotNetBar.ItemPanel)controlesArray[k]).Items);
                    if (b) return b;
                }
                //si el control es contenedoor de nodos lo busca 
                if (controlesArray[k].GetType().FullName.IndexOf("AdvTree") > 0)
                {
                    for (int i = 0; i < ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes.Count; i++) 
                    {
                        if (((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Name.Trim() == cmpNodo)
                        {
                            ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Visible = true;
                            return true;
                        }
                        for (int j = 0; j < ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Nodes.Count;j++ )
                        {
                            if (((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Nodes[j].Name.Trim() == cmpNodo)
                            {
                                ((DevComponents.AdvTree.AdvTree)controlesArray[k]).Nodes[i].Nodes[j].Visible = true;
                                return true;
                            }
                        }
                    }
                }
            }

            for (int k = 0; items != null && k < items.Count; k++)
            {

                if (items[k].Name.Trim() == cmpBtn ||
                 items[k].Name.Trim() == cmpNodo)
                {
                   // items[k].Tag = tag;
                   string[] a= items[k].Tag.ToString().Split('@');
                   if (a.Length > 0)
                   {
                       items[k].Tag = "";
                       for (int h = 0; h < a.Length; h++)
                       {
                           //if (a[h].Trim() == string.Empty) continue;
                           if (h == 0)
                           {
                               items[k].Tag +=  ""+((tag == null)?"":tag.ToString());
                           }else{
                               items[k].Tag += "@" + a[h];
                           }
                       }
                   }
                    items[k].Visible = true;
                    return true;
                }
            }
            return false;
        }

        public void configuracionFinalBotones() 
        {
            #region localizamos el Item Panel del modulo existente
            navigationPane1.SuspendLayout();
            //primero miramos cuales debemos borrar
            List<string> modulosxBorrar=new List<string>();
            for (int j = 0; j < navigationPane1.Controls.Count; j++)
            {
                if (navigationPane1.Controls[j].GetType().FullName.IndexOf("NavigationPanePanel") < 0) continue;
                DevComponents.DotNetBar.NavigationPanePanel panelExistente = (DevComponents.DotNetBar.NavigationPanePanel)navigationPane1.Controls[j];
                DevComponents.DotNetBar.ItemPanel itemPanelExistente = null;
                DevComponents.AdvTree.AdvTree adE = null;

                for (int h = 0; h < panelExistente.Controls.Count; h++)
                {
                    #region localiza el itempanel y localiza el advTree del panel principal que ya existe
                    if (panelExistente.Controls[h].Name.IndexOf("itemPanel") >= 0)
                    {
                        itemPanelExistente = (DevComponents.DotNetBar.ItemPanel)panelExistente.Controls[h];
                        ordenarBotones(itemPanelExistente);
                    }
                    else if (panelExistente.Controls[h].Name.IndexOf("advTree") >= 0)
                    {
                        adE = (DevComponents.AdvTree.AdvTree)panelExistente.Controls[h];
                    }
                    #endregion
                }
                //evaluamos si debe no tiene opciones en el panel
                int botones = 0, nodos = 0;
                if (itemPanelExistente != null)
                {
                    for (int i = 0; i < itemPanelExistente.Items.Count; i++)
                    {
                        if (itemPanelExistente.Items[i].Visible)
                            botones++;
                    }
                }
                if (adE != null)
                {
                    for (int i = 0; i < adE.Nodes.Count; i++)
                    {
                        if (adE.Nodes[i].Visible)
                            nodos++;
                    }
                }
                //deshabilitamos el boton 
                if (nodos <= 0 && botones <= 0)
                {
                    modulosxBorrar.Add(panelExistente.Name.Replace("navigationPane", ""));
                }
                configurarDimensionesPanel(itemPanelExistente, adE, botones, nodos);
            }
            //luego borramos los que debemos borrar

            for(int k=0;k<modulosxBorrar.Count;k++)
            {
                ///borramos el boton que lanza el panel
                navigationPane1.Items.Remove("btnModulo"+modulosxBorrar[k]);
                //borramos el panel
                navigationPane1.Controls.RemoveByKey("navigationPane" + modulosxBorrar[k]);
            }
          //  navigationPane1.Items[0].RaiseClick();
            //proceso para organizar alfabticamente los botones
                        
            navigationPane1.NavigationBarHeight = ((navigationPane1.Items.Count + 1) * 35) + 32;
            navigationPane1.ResumeLayout();
            navigationPane1.TabIndex = 2;
            #endregion
        }

        private void ordenarBotones(DevComponents.DotNetBar.ItemPanel item) 
        {
            string[] nombres=new string[item.Items.Count];
            //asignamos el texto de los botones para ordenarlos
            for (int k = 0; k < nombres.Length; k++)
            {
                nombres[k] = item.Items[k].Text.Trim();
            }
            Array.Sort(nombres);

            for(int k = 0; k < nombres.Length; k++)
            {
                //comparamos si el nombre esta en el mismo orden que el boton ya esta al pelo
                if (nombres[k].Trim() == item.Items[k].Text.Trim()) continue;
                //si no esta ordenado debe buscar la posicion del boton que es
                int pos=k;
                for (int j = pos; j < item.Items.Count; j++)
                {
                    if (item.Items[j].Text.Trim() == nombres[k])
                    {
                        pos = j;
                        break;
                    }
                }
                //ahora tenemos que cambia el item k por el item j
                DevComponents.DotNetBar.BaseItem b=
                    item.Items[pos].Copy();
                item.Items.Remove(item.Items[pos]);
                item.Items.Insert(k, b);
                

            }

        }


        void btn_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsUtilidadesReflection obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsUtilidadesReflection();
              object btn = null;
            if (sender.GetType().FullName.IndexOf("AdvTree.Node") > 0)
            {
                btn = ((DevComponents.AdvTree.Node)sender).Tag;
            }
            else
            {
                btn = ((DevComponents.DotNetBar.ButtonItem)sender).Tag;
              
            }
            string[] a=btn.ToString().Split('@');

            string tag_boton = a[0];
            string nameSpace = a[3];
            bool esDialogo = (a[4].Trim() == "1");
            bool esMdi = (a[5].Trim() == "1");
            bool maximizar = (a[6].Trim() == "1");
            string tag = a[7] + "|" + a[8]+"|"+tag_boton;
            //miramos si ya hay algun formulario creado del tipo que quiere mostrar
            for(int k=0;k<this.MdiChildren.Length;k++)
            {
                if (this.MdiChildren[k].GetType().FullName == nameSpace && MdiChildren[k].Tag.ToString().Trim() == tag.Trim())
                    //hay que pensar algo para el tema de los listados de estado ya que el nameSpace es el mismo
                {
                    this.MdiChildren[k].Activate();
                    if (!esDialogo)
                    {
                        this.MdiChildren[k].WindowState = FormWindowState.Maximized;
                    }
                    return;
                }
            }
            
            string[] parametros = tag_boton.Split('@');
            object[] arr = new object[parametros.Length];
            string[] strArr = new string[parametros.Length];
        
            for (int k = 0; k < parametros.Length; k++)
            {
                if (parametros[k].Trim() == string.Empty) continue;
                string[] tmp = parametros[k].Split('|');
                arr[k] = tmp[1];
                strArr[k] = tmp[0];
            }

            object res=null;
            if (!esDialogo)
            {
            //probamos algo de efectos
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(iniciarAnimacion));
            hilo.Start();
            System.Threading.Thread.Sleep(20);
            frmAnimacion.texto = "Iniciando Formulario";
            frmAnimacion.total = 100;
            frmAnimacion.aumentoAutomatico = true;
            frmAnimacion.velocidadAumentoAutomatico = 300;
            frmAnimacion.incremento_automatico = 3;
            frmAnimacion.progeso = 35;
            }
           //si hay problema con el icono hay que configurar un icono con tamano pequeno
           bool resF = obj.showFormulario(nameSpace, esDialogo, arr, strArr,out res,((esMdi)?this:null),this.Icon,maximizar,tag);
            if(!resF || !esDialogo){
                frmAnimacion.texto = "Finalizado";
                frmAnimacion.total = 100;
                frmAnimacion.progeso = 100;
                frmAnimacion.animacionEnd();
            }
            
        }
#endregion

        private void cerrarFormulariosActivosLinea()
        {
            if (!eventosEncendidos) return;

                // Evaluamos si puede cambiar de linea, para esto deberia no tener ningun formulario que la logica
                for (int k = 0; k < MdiChildren.Length; k++)
                {
                    if (MdiChildren[k].Tag == null) continue;
                    string a = MdiChildren[k].Tag.ToString();
                    string[] tag = a.Split('|');
                    if (tag[0].Trim() == "1" || tag[1].Trim() == "1")
                    {
                        eventosEncendidos = false;
                        MdiChildren[k].Close();
                        Application.DoEvents();
                    }
                }
                eventosEncendidos = true;
        }

        bool eventosEncendidos = true;
        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;

            if (dsSPXSeguridad1.linea.Count > 1)
            {
                if (cmbLinea.SelectedValue.ToString().Trim() == SPXSeguridad.logica.linea.cod_linea_seleccionada.ToString())
                    return;
                // Evaluamos si puede cambiar de linea, para esto deberia no tener ningun formulario que la logica
                for (int k = 0; k < MdiChildren.Length; k++)
                {
                    if(MdiChildren[k].Tag == null) continue;
                    string a=MdiChildren[k].Tag.ToString();
                    string[] tag = a.Split('|');
                    if (tag[0].Trim() == "1" || tag[1].Trim() == "1")
                    {
                        if (MessageBox.Show("Hay uno o mas formularios que dependen de la linea activa, debe cerrar estos formularios para cambiar de linea\n\nDesea cerrarlos de forma automatica?", "Formularios de Linea Abiertos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            cerrarFormulariosActivosLinea();
                        }
                        else
                        {
                            MdiChildren[k].Activate();
                            eventosEncendidos = false;
                            cmbLinea.SelectedValue = SPXSeguridad.logica.linea.cod_linea_seleccionada;
                            Application.DoEvents();
                            eventosEncendidos = true;
                            return;
                        }
                    }
                }
            }
            cargarOpcionesLinea();
        }



        private void cargarOpcionesLinea() 
        {
            if (cmbLinea.SelectedValue == null || cmbLinea.SelectedValue.ToString().Trim() == string.Empty)
            {
                return;
            }

            #region iniciamos el hilo de la animacion
            if (frmAnimacion == null || frmAnimacion.IsDisposed || frmAnimacion.total == 100)
            {
                System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(iniciarAnimacion));
                hilo.Start();
                System.Threading.Thread.Sleep(30);
                frmAnimacion.texto = "Cargando Permisos de Linea";
                frmAnimacion.total = 100;
                frmAnimacion.progeso = 20;
                frmAnimacion.aumentoAutomatico = true;
                frmAnimacion.incremento_automatico = 6;
                frmAnimacion.velocidadAumentoAutomatico = 200;
            }else {
                frmAnimacion.texto = "Cargando Permisos de Linea";
                frmAnimacion.total = 100;
                frmAnimacion.progeso = 25;
                frmAnimacion.aumentoAutomatico = true;
                frmAnimacion.incremento_automatico = 6;
                frmAnimacion.velocidadAumentoAutomatico = 200;
            }
            #endregion
            SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
         
             picLinea.Image = SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.logotipoSoftware;
            
             SPXSeguridad.logica.linea.cod_linea_seleccionada = int.Parse(cmbLinea.SelectedValue.ToString());
             SPXSeguridad.logica.linea.nombre_linea_seleccionada = ((SPXSeguridad.data.dsSPXSeguridad.lineaRow)((System.Data.DataRowView)cmbLinea.SelectedItem).Row).nombre_linea;
             
             cargarBotones();
           
 
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            string frmInicio = "SPXPrincipal.frm.inicio";

            if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.formularioWinInicio == 1)
            {
                
                frmInicio = "SPXprincipal.frm.inicio.frmModeloAnuncios";
            }else if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.formularioWinInicio == 2)
            {
                frmInicio = "SPXprincipal.frm.inicio.frmModeloCalendario";
            }else if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.formularioWinInicio == 0)
            {
                if (SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.formularioWinInicioCustom != null && SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.formularioWinInicioCustom.Trim() != string.Empty)
                    frmInicio = SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.formularioWinInicioCustom;
            }
            lanzarFormulario(frmInicio,false,false);
        }

        private void btnActualizarBotones_Click(object sender, EventArgs e)
        {
            cargarOpcionesLinea();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            SPXFrmAnimacion.frmConfirmacionSalir fr = new SPXFrmAnimacion.frmConfirmacionSalir();
            fr.mensaje="Esta seguro de salir de "+SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware+"?";

            if (fr.ShowDialog() != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnQuick1_Click(object sender, EventArgs e)
        {
             lanzarFormulario(btnQuick1.Tag.ToString() , false, false);
            ////lanzarFormulario("spHorarios.Form1", false, false);
        }

        private void btnQuick2_Click(object sender, EventArgs e)
        {
            lanzarFormulario(btnQuick2.Tag.ToString(), false, false);
        }
    }
}

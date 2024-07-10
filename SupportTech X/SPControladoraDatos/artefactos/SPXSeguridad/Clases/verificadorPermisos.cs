using System;
using System.Data;
using System.Data.SqlClient;
using SPXSeguridad.data;


namespace SPXSeguridad
{
	/// <summary>
	/// Descripción breve de verificadorPermisos.
	/// esta clase es la controlada de verificar los permisos que tiene un usuario para determinado
	/// programa del aplicativo.
	/// </summary>
	public class verificadorPermisos
	{
		#region definicion de campos y propiedades
        public int codUsuario { set; get; }
        public int codModulo { set; get; }
        public string mensaje { set; get; }
		private bool IndControlTotal=false;
		private bool IndModificar=false;
		private bool IndEliminar=false;
		private bool IndImprimir=false;
		private bool IndEscribir=false;
		private bool IndLecturaEjecucion=false;		
		private bool IndDenegar=false;

		/// <summary>
		/// Indica si el usuario tiene denegado el acceso al Modulo
		/// </summary>
		public bool Denegar{get{return IndDenegar;}set{IndDenegar=value;}}
		/// <summary>
		/// Indica si tiene control total
		/// </summary>
		public bool ControlTotal{get{return IndControlTotal;}set{IndControlTotal=value;}}
		/// <summary>
		/// Indica si el usuario tiene permisos para modificar la informacion.
		/// </summary>
		public bool Modificar{get { return procesarPermiso(IndModificar);}set{IndModificar=value;} }
		/// <summary>
		/// Inidica si el usuario tiene permisos para borrar informacion. 
		/// </summary>
		public bool Borrar{get{ return procesarPermiso(IndEliminar);} set{IndEliminar=value;}}
		/// <summary>
		/// Indica si el usuario tiene permisos para imprimir informacion.
		/// </summary>
		public bool Imprimir{get{return procesarPermiso(IndImprimir);}set{IndImprimir=value;}}
		/// <summary>
		/// Indica si el usuario puede adicionar informacion
		/// </summary>
		public bool Adicionar{get{return procesarPermiso (IndEscribir);}set{IndEscribir=value;}}
		/// <summary>
		/// Indica si el usuario puede Leer o ejecutar
		/// </summary>
		public bool Consultar{get{return procesarPermiso(IndLecturaEjecucion);}set{IndLecturaEjecucion=value;}}
		/// <summary>
		/// Indica si el usuario tiene permisos de ejecucion para el moduloo comando.
		/// </summary>
		public bool Ejecutar{get{return procesarPermiso(IndLecturaEjecucion);}set{IndLecturaEjecucion=value;}}
		#endregion

		/// <summary>
		/// Si tiene denegado el acceso no puede hacer nada,
		/// si tiene control total hereda el permiso
		/// </summary>
		/// <param name="valor">valor a evaluar</param>
		/// <returns>respuesta</returns>
		private bool procesarPermiso(bool valor)
		{
			//Si tiene denegado el acceso no puede hacer nada
			// si tiene control total hereda el permiso
			return ( (valor || IndControlTotal) && !IndDenegar);
		}

        /// <summary>
        /// Carga el objeto de acuerdo al valro recibido como parametro
        /// </summary>
        /// <param name="valor"></param>
        private void cargarValores(bool valor)
        {
            IndControlTotal = valor;
            IndDenegar = !valor;
            IndEliminar = valor;
            IndEscribir = valor;
            IndImprimir = valor;
            IndLecturaEjecucion = valor;
            IndModificar = valor;
        }



            SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
            SPXSeguridad.data.cls.clsTgrupousuario_usuario grupousuario_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTgrupousuario_usuario();
            SPXSeguridad.data.cls.clsTmoduloseguridad_grupousuario ModulosxgrupousuariosTableAdapter1 = new SPXSeguridad.data.cls.clsTmoduloseguridad_grupousuario();
            SPXSeguridad.data.cls.clsTmoduloseguridad_usuario ModulosxUsuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTmoduloseguridad_usuario();
            SPXSeguridad.data.cls.clsTfuncionalidad_grupousuario funcionalidad_grupousuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTfuncionalidad_grupousuario();
            SPXSeguridad.data.cls.clsTfuncionalidad_usuario funcionalidadxUsuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTfuncionalidad_usuario();
       
            SPXSeguridad.logica.clsInicializador obj = new SPXSeguridad.logica.clsInicializador();
        bool cargadoPrimeraVEz = false;

        /// <summary>
        /// cuando se ejecuta esta funcion, quedan cargadas las propiedades con los permisos
        /// indicados para el usuario y el comando cargados en las propiedades.
        /// </summary>
        public void solicitarAutorizacion()
        {
            IndDenegar = false;
            mensaje = "";
            if (codUsuario == 0 || codModulo == 0)
            {
                cargarValores(false);
                mensaje = "No configuro el usuario y la funcion antes de verificar los permisos";
                return;
            }     //cargamos los grupos del usuario

            if (cargadoPrimeraVEz == false)
            {
                grupousuario_usuarioTableAdapter1.FillBycod_usuario(ds.grupousuario_usuario, codUsuario);
            }
            //ahora validamos los permisos de los grupos modulos
            obj.cargarTablaFuncionalidadesEspecial();
            obj.tablaFuncionalidadesEspecial(ds.funcionalidad);
            if(ds.funcionalidad.Count<=0)
            {
                mensaje = "No ha inicializado ningun cnn de seguridad";
                return;
            }
            int codGrupo = 0;
            if (ds.funcionalidad.Select("cod_funcionalidad=" + codModulo).Length > 0)
            {
                codGrupo = (int)ds.funcionalidad.Select("cod_funcionalidad=" + codModulo)[0]["cod_modulo_seguridad"];
            }
            //cargamos 
           // cargarValores(false);
            #region permisos de usuario a funcionalidad
            if (cargadoPrimeraVEz == false)
            {
                funcionalidadxUsuarioTableAdapter1.fillByCod_usuario(ds.funcionalidad_usuario, codUsuario);
            }
            var arrC = ds.funcionalidad_usuario.Select("cod_funcionalidad =" + codModulo);
            if (arrC.Length > 0)
            {
                if (arrC[0]["denegar"] != null &&
                    arrC[0]["denegar"] != System.DBNull.Value  &&
                     (bool)arrC[0]["denegar"])
                {
                    mensaje = "Acceso Denegado";
                    cargarValores(false);
                    return;
                }else{
                    if (arrC[0]["control_total"] != null && arrC[0]["control_total"] != System.DBNull.Value )
                        IndControlTotal =  procesarPermiso((bool)arrC[0]["control_total"]);
                    if (arrC[0]["eliminar"] != null && arrC[0]["eliminar"] != System.DBNull.Value)
                        IndEliminar =  procesarPermiso((bool)arrC[0]["eliminar"]);
                    if (arrC[0]["escribir"] != null && arrC[0]["escribir"] != System.DBNull.Value)
                        IndEscribir =  procesarPermiso((bool)arrC[0]["escribir"]);
                    if (arrC[0]["imprimir"] != null && arrC[0]["imprimir"] != System.DBNull.Value)
                        IndImprimir =  procesarPermiso((bool)arrC[0]["imprimir"]);
                    if (arrC[0]["lectura_ejecucion"] != null && arrC[0]["lectura_ejecucion"] != System.DBNull.Value)
                        IndLecturaEjecucion =  procesarPermiso((bool)arrC[0]["lectura_ejecucion"]);
                    if (arrC[0]["modificar"] != null && arrC[0]["modificar"] != System.DBNull.Value)
                        IndModificar =  procesarPermiso((bool)arrC[0]["modificar"]);
                    if (arrC[0]["denegar"] != null && arrC[0]["denegar"] != System.DBNull.Value)
                        IndDenegar = procesarPermiso((bool)arrC[0]["denegar"]);
                }
            }


            #endregion

            #region permisos de grupos de usuario a funcion
            //verificamos grupo a grupo
            if (cargadoPrimeraVEz == false)
            {
                funcionalidad_grupousuarioTableAdapter1.FillByUsuario(ds.funcionalidad_grupousuario,
                    codUsuario);
            }

            for (int k = 0; k < ds.grupousuario_usuario.Count; k++)
            {
                var arrGU = ds.funcionalidad_grupousuario.Select("cod_grupo_usuario="+ ds.grupousuario_usuario[k].cod_grupo_usuario 
                    + " and cod_funcionalidad=" + codModulo);

                if (arrGU.Length > 0)
                {
                    if (arrGU[0]["denegar"] != null &&
                    arrGU[0]["denegar"] != System.DBNull.Value &&
                     (bool)arrGU[0]["denegar"])
                    {
                        mensaje = "Acceso Denegado";
                        cargarValores(false);
                        return;
                    }
                    else
                    {
                        if (arrGU[0]["control_total"] != null && arrGU[0]["control_total"] != System.DBNull.Value)
                            IndControlTotal = IndControlTotal || procesarPermiso((bool)arrGU[0]["control_total"]);
                        if (arrGU[0]["eliminar"] != null && arrGU[0]["eliminar"] != System.DBNull.Value)
                            IndEliminar = IndEliminar || procesarPermiso((bool)arrGU[0]["eliminar"]);
                        if (arrGU[0]["escribir"] != null && arrGU[0]["escribir"] != System.DBNull.Value)
                            IndEscribir = IndEscribir ||  procesarPermiso((bool)arrGU[0]["escribir"]);
                        if (arrGU[0]["imprimir"] != null && arrGU[0]["imprimir"] != System.DBNull.Value)
                            IndImprimir = IndImprimir || procesarPermiso((bool)arrGU[0]["imprimir"]);
                        if (arrGU[0]["lectura_ejecucion"] != null && arrGU[0]["lectura_ejecucion"] != System.DBNull.Value)
                            IndLecturaEjecucion = IndLecturaEjecucion || procesarPermiso((bool)arrGU[0]["lectura_ejecucion"]);
                        if (arrGU[0]["modificar"] != null && arrGU[0]["modificar"] != System.DBNull.Value)
                            IndModificar = IndModificar || procesarPermiso((bool)arrGU[0]["modificar"]);
                        if (arrGU[0]["denegar"] != null && arrGU[0]["denegar"] != System.DBNull.Value)
                            IndDenegar = IndDenegar || (bool)arrGU[0]["denegar"];//aca no debemos llamar procesar permiso por que tiene en cuenta el control total
                    }
                }
            }

            #endregion

            #region permisos de usuario a grupo modulo
            if (cargadoPrimeraVEz == false)
            {
                ModulosxUsuarioTableAdapter1.FillBycod_usuario(ds.moduloseguridad_usuario, codUsuario);
            }
            var arrCM = ds.moduloseguridad_usuario.Select("cod_modulo_seguridad=" + codModulo);
            if (arrCM.Length > 0)
            {
                if (arrCM[0]["denegar"] != null &&
                    arrCM[0]["denegar"] != System.DBNull.Value &&
                     (bool)arrCM[0]["denegar"])
                {
                    mensaje = "Acceso Denegado";
                    cargarValores(false);
                    return;
                }else{
                    if (arrCM[0]["control_total"] != null && arrCM[0]["control_total"] != System.DBNull.Value)
                        IndControlTotal = IndControlTotal || procesarPermiso((bool)arrCM[0]["control_total"]);
                    if (arrCM[0]["eliminar"] != null && arrCM[0]["eliminar"] != System.DBNull.Value)
                        IndEliminar = IndEliminar || procesarPermiso((bool)arrCM[0]["eliminar"]);
                    if (arrCM[0]["escribir"] != null && arrCM[0]["escribir"] != System.DBNull.Value)
                        IndEscribir = IndEscribir || procesarPermiso((bool)arrCM[0]["escribir"]);
                    if (arrCM[0]["imprimir"] != null && arrCM[0]["imprimir"] != System.DBNull.Value)
                        IndImprimir = IndImprimir || procesarPermiso((bool)arrCM[0]["imprimir"]);
                    if (arrCM[0]["lectura_ejecucion"] != null && arrCM[0]["lectura_ejecucion"] != System.DBNull.Value)
                        IndLecturaEjecucion = IndLecturaEjecucion || procesarPermiso((bool)arrCM[0]["lectura_ejecucion"]);
                    if (arrCM[0]["modificar"] != null && arrCM[0]["modificar"] != System.DBNull.Value)
                        IndModificar = IndModificar|| procesarPermiso((bool)arrCM[0]["modificar"]);
                    if (arrCM[0]["denegar"] != null && arrCM[0]["denegar"] != System.DBNull.Value)
                        IndDenegar = IndDenegar || (bool)arrCM[0]["denegar"];//aca no debemos llamar procesar permiso por que tiene en cuenta el control total
                }
            }

            #endregion

            #region permisos de grupos de usuario a grupos modulo
            if (cargadoPrimeraVEz == false)
            {
                ModulosxgrupousuariosTableAdapter1.FillByUsuario(ds.moduloseguridad_grupousuario, codUsuario);
            }
            for (int k = 0; k < ds.grupousuario_usuario.Count; k++)
            {
                if (codGrupo == 0) break;
                var arrmod = ds.moduloseguridad_grupousuario.Select("cod_modulo_seguridad=" + codGrupo+ " and cod_grupo_usuario=" +   ds.grupousuario_usuario[k].cod_grupo_usuario);
                if (arrmod.Length > 0)
                {
                    if (arrmod[0]["denegar"] != null &&
                   arrmod[0]["denegar"] != System.DBNull.Value &&
                    (bool)arrmod[0]["denegar"])
                    {
                        mensaje = "Acceso Denegado";
                        cargarValores(false);
                        return;
                    }
                    else
                    {
                        if (arrmod[0]["control_total"] != null && arrmod[0]["control_total"] != System.DBNull.Value)
                            IndControlTotal = IndControlTotal || procesarPermiso((bool)arrmod[0]["control_total"]);
                        if (arrmod[0]["eliminar"] != null && arrmod[0]["eliminar"] != System.DBNull.Value)
                            IndEliminar = IndEliminar ||procesarPermiso((bool)arrmod[0]["eliminar"]);
                        if (arrmod[0]["escribir"] != null && arrmod[0]["escribir"] != System.DBNull.Value)
                            IndEscribir = IndEscribir ||procesarPermiso((bool)arrmod[0]["escribir"]);
                        if (arrmod[0]["imprimir"] != null && arrmod[0]["imprimir"] != System.DBNull.Value)
                            IndImprimir = IndImprimir || procesarPermiso((bool)arrmod[0]["imprimir"]);
                        if (arrmod[0]["lectura_ejecucion"] != null && arrmod[0]["lectura_ejecucion"] != System.DBNull.Value)
                            IndLecturaEjecucion = IndLecturaEjecucion || procesarPermiso((bool)arrmod[0]["lectura_ejecucion"]);
                        if (arrmod[0]["modificar"] != null && arrmod[0]["modificar"] != System.DBNull.Value)
                            IndModificar = IndModificar || procesarPermiso((bool)arrmod[0]["modificar"]);
                        if (arrmod[0]["denegar"] != null && arrmod[0]["denegar"] != System.DBNull.Value)
                            IndDenegar= IndDenegar || (bool)arrmod[0]["denegar"];//aca no debemos llamar procesar permiso por que tiene en cuenta el control total
                    }
                    
                }
            }

            #endregion

            cargadoPrimeraVEz = true;
        }

		/// <summary>
		/// Constructor
		/// </summary>
		public verificadorPermisos()
		{
			
		}
        public static verificadorPermisos ob = new verificadorPermisos();

        /// <summary>
        /// Me indica si el usuario con el login especificotiene permiso para ejecutar la funcionalidad especifia.
        /// este permiso solo esta dado por el parametro lectura y ejecucion
        /// </summary>
        /// <param name="funcionalidad">funcionalidad del sistema</param>
        /// <param name="login">login del usuario a comprobar</param>
        /// <returns></returns>
        public static bool ejecutarAccion(int funcion,int cod_usuario,ref string mensaje)
        {
            ob.codModulo = funcion;
            ob.codUsuario = cod_usuario;
            ob.solicitarAutorizacion();
            return (ob.Ejecutar || ob.ControlTotal);
        }

        /// <summary>
        /// Me indica si el usuario que esta logeado en el momento tiene permiso para ejecutar la funcionalidad especifia
        /// </summary>
        /// <param name="funcionalidad">funcionalidad del sistema</param>
        /// <returns></returns>
        public static bool ejecutarAccion(int funcionalidad)
        {
            string msg = "";
            return ejecutarAccion(funcionalidad, SPXSeguridad.logica.sesion.CodUsuarioAutenticado, ref msg);
        }

        static System.Collections.Generic.List<int> historial;
        
        public static bool ejecutarAccionWindows(int funcionalidad)
        {
            string msg = "";
            if (historial == null) historial = new System.Collections.Generic.List<int>();
            if (historial.Contains(funcionalidad)) return true;

            bool r=ejecutarAccion(funcionalidad, SPXSeguridad.logica.sesion.CodUsuarioAutenticado, ref msg);
            if (r) {
                historial.Add(funcionalidad);
            }
            return r;
        }

        public static bool ejecutarAccionWeb(int funcionalidad,int codUsuario,System.Web.SessionState.HttpSessionState session)
        {
            if (session == null || session.Count <= 0) return false;
            //miramos el historial
            if (session["wcg_seg_hist"] != null && session["wcg_seg_hist"].ToString() != string.Empty)
            {
                string[] arr = session["wcg_seg_hist"].ToString().Split(';');
                for (int k = 0; k < arr.Length; k++)
                {
                    if(arr[k].Trim() == string.Empty)continue;
                    if (int.Parse(arr[k]) == funcionalidad) return true;
                }
            }
            string msg = "";
            bool r = ejecutarAccion(funcionalidad, codUsuario, ref msg);
            if (r)
            {
                session["wcg_seg_hist"] = session["wcg_seg_hist"] + ";" + funcionalidad + ";";
            }
            return r;
        }

        /// <summary>
        /// Me retorna un datatable con los usuarios que tengan determinado permiso
        /// </summary>
        /// <param name="funcionalidad"></param>
        /// <returns></returns>
        public static void mergeUsuariosPermiso(int funcionalidad, SPXSeguridad.data.dsSPXSeguridad.usuarioDataTable tb)
        {
            SPXSeguridad.data.cls.clsTusuario obj = new SPXSeguridad.data.cls.clsTusuario();
            SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
            obj.Fill(ds.usuario);

            int j = ds.usuario.Rows.Count;
            int fila = 0;
            string msf="";
            for (int k = 0; k < j; k++)
            {
                
                bool remover = false;
                remover = !ejecutarAccion(funcionalidad, ds.usuario[fila].cod_usuario, ref msf);
                if (remover)
                {
                    ds.usuario.Rows.RemoveAt(fila);
                    fila--;
                }
                fila++;
            }
            tb.Merge(ds.usuario);
        }

    }
}
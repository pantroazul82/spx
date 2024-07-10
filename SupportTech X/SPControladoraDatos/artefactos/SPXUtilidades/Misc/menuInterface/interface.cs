using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPControladoraDatos.artefactos;
using SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface
//namespace SPControladoraDatos.artefactos.SPXUtilidades
{
    public class Interface
    {

        public System.Drawing.Image imagenBoton{set;get;}

        public string textoBoton { set; get; }
        public int codModulo { set; get; }
        public int codFuncionalidad { set; get; }
        /// <summary>
        /// parametros del formulario separados por $
        /// por ejemplo cod_proceso=12$cod_linea=1$Text=Hola Mundo
        /// </summary>
        public object tag { set; get; }
        public string direccion_url { set; get; }
        public string namespace_formulario { set; get; }
        public bool EsMdi { set; get; }
        public bool EsDialogo { set; get; }
        public bool maximizar { set; get; }

        /// <summary>
        /// este campo indica si la funcionalidad se agrega a un tab existente.
        /// </summary>
        public string moduloExistente  { set; get; }

        /// <summary>
        /// Este campo indica si el boton se agrega a una funcionalidad ya existente y lo agrega como treeview
        /// </summary>
        public string funcionalidadExistente { set; get; }
        
        /// <summary>
        /// Este campo me indica si el permiso de ver o no ver el boton depende de la linea, por ejemplo los procesos como 
        /// entradas, salidas etc.
        /// </summary>
        public bool filtraxlinea { set; get; }

        /// <summary>
        ///Este campo me indica si la ventana carga el contenido dependiendo de la linea seleccionada.
        ///por ejemplo la ventana de referencias (partes), cuando carga solo me carga las partes de la linea
        /// </summary>
        public bool logicaxlinea { set; get; }
        
        public Interface() 
        {
        
        }


        public void asignar(string _textoBoton ,int _codModulo , int _codFuncionalidad ,
            string  _direccion_url ,string _namespace_formulario,System.Drawing.Image img ,object  _tag,
            bool mdi,bool esDialogo,bool _maximizar,string _moduloExistente,string _funcionalidadExistente,bool _filtraxlinea, bool _logicaxlinea)
        {
            textoBoton=_textoBoton; 
            codModulo =_codModulo;
            codFuncionalidad =_codFuncionalidad ;
            tag =_tag ;
            direccion_url=_direccion_url;
            namespace_formulario = _namespace_formulario;
            imagenBoton = img;
            EsMdi = mdi;
            EsDialogo = esDialogo;
            maximizar = _maximizar;
            moduloExistente = _moduloExistente;
            funcionalidadExistente = _funcionalidadExistente;
            filtraxlinea = _filtraxlinea;
            logicaxlinea = _logicaxlinea;
        }

    }
}

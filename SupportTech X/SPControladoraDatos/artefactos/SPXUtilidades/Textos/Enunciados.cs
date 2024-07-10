using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Textos
{
    public class Enunciados
    {
        public static string errorDelete{ get{return "Error al eliminar el registro asegurese que el registro no este vinculado con otros registros!";}}
        public static string confirmacionDelete { get { return "Esta seguro de eliminar el registro?\neste cambio no se puede deshacer!"; } }
        public static string tituloConfirmacionDelete { get { return "Confirmacion"; } }
        public static string tituloErrorValidacion { get { return "Falta Informacion en el Formulario"; } }
        
    }
}

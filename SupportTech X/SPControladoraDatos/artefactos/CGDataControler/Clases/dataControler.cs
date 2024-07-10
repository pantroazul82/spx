using System;
using System.Collections.Generic;
using System.Text;

namespace CGDataControler
{
   
        public enum EstadosDatos
        {
            /// <summary>
            /// Indica que el estado de los datos es consulta
            /// </summary>
            Consulta,
            /// <summary>
            /// Indica que el estado de los datos es adicion
            /// </summary>
            Adicion,
            /// <summary>
            /// Indica que el estado de los datos es edicion
            /// </summary>
            Edicion,
            /// <summary>
            /// Indica que el estado de los datos es aceptado
            /// </summary>
            Aceptado,
            /// <summary>
            /// Indica que el estado de los datos es descartado
            /// </summary>
            Descartado
        }

        public enum TiposAcciones
        {
            /// <summary>
            /// Adiciona un Registro
            /// </summary>
            Adicionar, 
            /// <summary>
            /// Edita un Registro
            /// </summary>
            Editar, 
            /// <summary>
            /// Eliminar Registro
            /// </summary>
            Eliminar, 
            /// <summary>
            /// Aceptar los cambios
            /// </summary>
            Aceptar, 
            /// <summary>
            /// Cambios descartado
            /// </summary>
            Descartar,
            /// <summary>
            /// Buscar o Filtrar en los datos
            /// </summary>
            Buscar,
            /// <summary>
            /// Busqueda Avanzada
            /// </summary>
            BusquedaAvanzada,
            /// <summary>
            /// Ir al primer Registro
            /// </summary>            
            Primero, 
            /// <summary>
            /// Ir al registro anterior
            /// </summary>
            Anterior, 
            /// <summary>
            /// Ir al siguiente registro
            /// </summary>
            Siguiente, 
            /// <summary>
            /// Ultimo Registro
            /// </summary>
            Ultimo,
            /// <summary>
            /// Salir de la ventana contenedora
            /// </summary>
            Salir, 
            /// <summary>
            /// Evento no conciderado
            /// </summary>
            Indeterminada
        }

        public class dataControlerEventArgs : System.EventArgs
        {
            public TiposAcciones TipoAccion;
            public bool Cancelar = false;
            public Exception ex = null;
        }

        public delegate void dataControlerEventHandler(object sender, dataControlerEventArgs e);

    public partial class dataControler 
    {
    
    
    
    }
   
}

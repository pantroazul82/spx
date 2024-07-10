using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTmodulo_seguridad : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.modulo_seguridadDataTable tabla;

        public clsTmodulo_seguridad()
        {
            tabla = new dsSPXSeguridad.modulo_seguridadDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_modulo_seguridad";
            nombreTabla = "modulo_seguridad";
            cargarCamposSelect();
        }

        #endregion

    }
}
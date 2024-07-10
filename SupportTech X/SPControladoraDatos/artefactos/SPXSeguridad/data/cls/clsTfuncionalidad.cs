using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXSeguridad.data.cls
{

    public class clsTfuncionalidad : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public SPXSeguridad.data.dsSPXSeguridad.funcionalidadDataTable tabla;

        public clsTfuncionalidad()
        {
            tabla = new SPXSeguridad.data.dsSPXSeguridad.funcionalidadDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_funcionalidad";
            nombreTabla = "funcionalidad";
            cargarCamposSelect();
        }

        #endregion

    }
}

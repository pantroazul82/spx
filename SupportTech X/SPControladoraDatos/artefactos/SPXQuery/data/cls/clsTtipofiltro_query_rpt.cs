using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.data.cls
{
    class clsTtipofiltro_query_rpt : SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.tipofiltro_query_rptDataTable tabla;

        public clsTtipofiltro_query_rpt()
        {
            tabla = new dsSPXQuery.tipofiltro_query_rptDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "";
            nombreTabla = "";
        }

        public override void Fill(System.Data.DataTable dt )
        {
            
            dsSPXQuery.tipofiltro_query_rptDataTable tabla = (dsSPXQuery.tipofiltro_query_rptDataTable)dt;
            tabla.Clear();
            dsSPXQuery.tipofiltro_query_rptRow f= tabla.Newtipofiltro_query_rptRow();
            f.cod_tipo_filtro = 1;
            f.descripcion="INT";
            tabla.Addtipofiltro_query_rptRow(f);
            //--
            dsSPXQuery.tipofiltro_query_rptRow f2 = tabla.Newtipofiltro_query_rptRow();
            f2.cod_tipo_filtro = 2;
            f2.descripcion = "FLOAT";
            tabla.Addtipofiltro_query_rptRow(f2);
            //--
            dsSPXQuery.tipofiltro_query_rptRow f3 = tabla.Newtipofiltro_query_rptRow();
            f3.cod_tipo_filtro = 3;
            f3.descripcion = "STRING";
            tabla.Addtipofiltro_query_rptRow(f3);
            //-
            dsSPXQuery.tipofiltro_query_rptRow f4 = tabla.Newtipofiltro_query_rptRow();
            f4.cod_tipo_filtro = 4;
            f4.descripcion = "DATETIME";
            tabla.Addtipofiltro_query_rptRow(f4);
            //-
            dsSPXQuery.tipofiltro_query_rptRow f5 = tabla.Newtipofiltro_query_rptRow();
            f5.cod_tipo_filtro = 5;
            f5.descripcion = "BOOL";
            tabla.Addtipofiltro_query_rptRow(f5);

        }

        #endregion
    }
}

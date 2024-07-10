using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXQuery.data.cls
{
    class cgq_layout_pivote: SPXdata.BD.clsAdaptador
    {
        #region copiar y pegar en todas las tablas
        public dsSPXQuery.cgq_layout_pivoteDataTable tabla;

        public cgq_layout_pivote()
        {
            tabla = new dsSPXQuery.cgq_layout_pivoteDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;
            nombreLlave = "cod_cgq_layout_pivote";
            nombreTabla = "cgq_layout_pivote";
            cargarCamposSelect();
        }

        #endregion


        public long Insert(int cod_query, int cod_usuario, byte[] layout1, byte[] layout2, byte[] layout3, byte[] layout4, byte[] layout5)
        {
            string sql = @"INSERT INTO cgq_layout_pivote 
                           (cod_query, cod_usuario, layout1, layout2, layout3, layout4, layout5) VALUES 
                           (@cod_query, @cod_usuario, @layout1, @layout2, @layout3, @layout4, @layout5) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");

            arr.Add(layout1);
            name.Add("@layout1|System.Byte[]");
            arr.Add(layout2);
            name.Add("@layout2|System.Byte[]");

            arr.Add(layout3);
            name.Add("@layout3|System.Byte[]");    
 
                 arr.Add(layout4);
                 name.Add("@layout4|System.Byte[]");

             arr.Add(layout5);
             name.Add("@layout5|System.Byte[]");
            #endregion
           DataConector obj = new DataConector();
            obj.iniciarTransaccion();
            obj.ejecutarComando(sql, arr, name);//ejecuta el insert 
            sql = "SELECT @@identity";
            object a = obj.ejecutarProcedimiento(sql, null, null);
            obj.commitTransaccion();
            long res = 0;
            if (a != null && a != System.DBNull.Value)
                res = long.Parse(a.ToString());
            ultimo_id_insertado = res;
            return res;
        }

        public int DeleteByCod_Query(int cod_query)
        {
            string sql = @"delete from cgq_layout_pivote 
                            where cod_query=@cod_query";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateLayout1(byte[] layout1, int cod_query, int cod_usuario)
        {
            string sql = @"UPDATE cgq_layout_pivote SET 
                                layout1 =@layout1
                            where cod_query=@cod_query and cod_usuario=@cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            arr.Add(layout1);
            name.Add("@layout1|System.Byte[]");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateLayout2(byte[] layout2, int cod_query, int cod_usuario)
        {
            string sql = @"UPDATE cgq_layout_pivote SET 
                                layout2 =@layout2
                            where cod_query=@cod_query and cod_usuario=@cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            arr.Add(layout2);
            name.Add("@layout2|System.Byte[]");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateLayout3(byte[] layout3, int cod_query, int cod_usuario)
        {
            string sql = @"UPDATE cgq_layout_pivote SET 
                                layout3 =@layout3
                            where cod_query=@cod_query and cod_usuario=@cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            arr.Add(layout3);
            name.Add("@layout3|System.Byte[]");
            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateLayout4(byte[] layout4, int cod_query, int cod_usuario)
        {
            string sql = @"UPDATE cgq_layout_pivote SET 
                                layout4 =@layout4
                            where cod_query=@cod_query and cod_usuario=@cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            arr.Add(layout4);
            name.Add("@layout4|System.Byte[]");
            #endregion
            DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public int UpdateLayout5(byte[] layout5, int cod_query, int cod_usuario)
        {
            string sql = @"UPDATE cgq_layout_pivote SET 
                                layout5 =@layout5
                            where cod_query=@cod_query and cod_usuario=@cod_usuario";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");
            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            arr.Add(layout5);
            name.Add("@layout5|System.Byte[]");
            #endregion
            DataConector obj = new DataConector();
            return obj.ejecutarComando(sql, arr, name);
        }

        public void FillBycod_cgq_layout_pivote(dsSPXQuery.cgq_layout_pivoteDataTable tabla,
       int cod_cgq_layout_pivote)
        {
            string sql = sentenciaBase + @"  WHERE (cod_cgq_layout_pivote = @cod_cgq_layout_pivote) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_cgq_layout_pivote);
            name.Add("@cod_cgq_layout_pivote");
            #endregion
            DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }

        public void FillBycod_query(dsSPXQuery.cgq_layout_pivoteDataTable tabla, int cod_query,int cod_usuario)
        {
            string sql = sentenciaBase + @"  WHERE (cod_query = @cod_query and cod_usuario=@cod_usuario) ";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();
            arr.Add(cod_query);
            name.Add("@cod_query");

            arr.Add(cod_usuario);
            name.Add("@cod_usuario");
            #endregion
            DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, tabla, false, arr, name);
        }



    }
}

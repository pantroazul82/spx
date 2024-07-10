using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SPXSeguridad.data.cls
{

    public class clsTsysusersobjects : SPXdata.BD.clsAdaptador
    {
            #region copiar y pegar en todas las tablas
        public dsSPXSeguridad.sysusersobjectsDataTable tabla;

        public clsTsysusersobjects()
        {
            
            tabla = new dsSPXSeguridad.sysusersobjectsDataTable();
            tablaMaestra = (System.Data.DataTable)tabla;            
            nombreLlave = "idSysuserObjects";
            nombreTabla = "sysusersobjects";
            cargarCamposSelect();  
        }

        #endregion

        //vamos con el insert
        public int insert(string nameA,DateTime? date,string user_,string object_,string file_,string file_size,string file_date,
            string file_time,string pointer,int id_user) 
        {
          
            string sql = @"INSERT INTO sysusersobjects
                         (name, DATE, user_, object_, file_, file_size, file_date, file_time, pointer, id_user)
                VALUES (@name, @date, @user_, @object_, @file_, @file_size, @file_date, @file_time, @pointer, @id_user)";
            #region parametros
            List<object> arr = new List<object>();
            List<string> name = new List<string>();

            arr.Add(nameA);
            name.Add("@name");

            arr.Add(date);
            name.Add("@date");

            arr.Add(user_);
            name.Add("@user_");

            arr.Add(object_);
            name.Add("@object_");

            arr.Add(file_);
            name.Add("@file_");

            arr.Add(file_size);
            name.Add("@file_size");

            arr.Add(file_date);
            name.Add("@file_date");

            arr.Add(file_time);
            name.Add("@file_time");

              arr.Add(pointer);
            name.Add("@pointer");

              arr.Add(id_user);
            name.Add("@id_user");
            





            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql,arr,name);
        }

        public int updateQuery(string name, DateTime? date, string user_, string object_, string file_, string file_size, string file_date,
            string file_time, string pointer, int id_user, int idSysuserObjects)
        {
            #region sentencia sql
            string sql = @"UPDATE sysusersobjects
    SET name = @name, DATE = @date, user_ = @user_, object_ = @object_, file_ = @file_, file_size = @file_size, file_date = @file_date, file_time = @file_time, 
                         pointer = @pointer, id_user = @id_user
    WHERE  idSysuserObjects = @idSysuserObjects ";
            #endregion
            #region parametros
            List<object> arr = new List<object>();
            List<string> nameA = new List<string>();

            arr.Add(idSysuserObjects);
            nameA.Add("@idSysuserObjects");

            arr.Add(name);
            nameA.Add("@name");

            arr.Add(date);
            nameA.Add("@date");

            arr.Add(user_);
            nameA.Add("@user_");

            arr.Add(object_);
            nameA.Add("@object_");

            arr.Add(file_);
            nameA.Add("@file_");

            arr.Add(file_size);
            nameA.Add("@file_size");

            arr.Add(file_date);
            nameA.Add("@file_date");

            arr.Add(file_time);
            nameA.Add("@file_time");

            arr.Add(pointer);
            nameA.Add("@pointer");

            arr.Add(id_user);
            nameA.Add("@id_user");

            #endregion
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql,arr,nameA);
        }
    }
}

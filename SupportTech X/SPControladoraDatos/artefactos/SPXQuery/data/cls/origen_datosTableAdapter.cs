using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXQuery.data
{
class origen_datosTableAdapter : SPXdata.BD.clsAdaptador
{
#region copiar y pegar en todas las tablas
public dsSPXQuery.origen_datosDataTable tabla;

public origen_datosTableAdapter()
{
    tabla = new dsSPXQuery.origen_datosDataTable();
  tablaMaestra = (System.Data.DataTable)tabla;
  nombreLlave = "cod_origen_datos";
  nombreTabla = "origen_datos";
  cargarCamposSelect();
}

#endregion


public long Insert( 
string tipo_cnn,string nombre_conexion,string login,string password,string servidor,string base_datos,int puerto,string sid,bool? conexion_directa,string tipo_cnn_oracle,int time_out){
 string sql = @"INSERT INTO origen_datos (
tipo_cnn,nombre_conexion,login,password,servidor,base_datos,puerto,sid,conexion_directa,tipo_cnn_oracle,time_out) VALUES (
@tipo_cnn,@nombre_conexion,@login,@password,@servidor,@base_datos,@puerto,@sid,@conexion_directa,@tipo_cnn_oracle,@time_out)";
#region parametros
List<object> arr = new List<object>();
List<string> name = new List<string>();
arr.Add(tipo_cnn);
name.Add("@tipo_cnn");
arr.Add(nombre_conexion);
name.Add("@nombre_conexion");
arr.Add(login);
name.Add("@login");
arr.Add(password);
name.Add("@password");
arr.Add(servidor);
name.Add("@servidor");
arr.Add(base_datos);
name.Add("@base_datos");
arr.Add(puerto);
name.Add("@puerto");
arr.Add(sid);
name.Add("@sid");
arr.Add(conexion_directa);
name.Add("@conexion_directa");
arr.Add(tipo_cnn_oracle);
name.Add("@tipo_cnn_oracle");
arr.Add(time_out);
name.Add("@time_out");
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


public int UpdateQuery( 
string tipo_cnn,string nombre_conexion,string login,string password,string servidor,string base_datos,int puerto,string sid,bool? conexion_directa,string tipo_cnn_oracle,int time_out,int cod_origen_datos){
 string sql = @"UPDATE origen_datos SET 
tipo_cnn =@tipo_cnn,nombre_conexion =@nombre_conexion,login =@login,password =@password,servidor =@servidor,base_datos =@base_datos,puerto =@puerto,sid =@sid,conexion_directa =@conexion_directa,tipo_cnn_oracle =@tipo_cnn_oracle,time_out =@time_out where cod_origen_datos=@cod_origen_datos";
#region parametros
List<object> arr = new List<object>();
List<string> name = new List<string>();
arr.Add(tipo_cnn);
name.Add("@tipo_cnn");
arr.Add(nombre_conexion);
name.Add("@nombre_conexion");
arr.Add(login);
name.Add("@login");
arr.Add(password);
name.Add("@password");
arr.Add(servidor);
name.Add("@servidor");
arr.Add(base_datos);
name.Add("@base_datos");
arr.Add(puerto);
name.Add("@puerto");
arr.Add(sid);
name.Add("@sid");
arr.Add(conexion_directa);
name.Add("@conexion_directa");
arr.Add(tipo_cnn_oracle);
name.Add("@tipo_cnn_oracle");
arr.Add(time_out);
name.Add("@time_out");
arr.Add(cod_origen_datos);
name.Add("@cod_origen_datos");
#endregion
DataConector obj = new DataConector();
return obj.ejecutarComando(sql, arr, name);
}

public  int  DeleteQuery( int cod_origen_datos){
 string sql = @"DELETE from origen_datos 
 where cod_origen_datos=@cod_origen_datos";
#region parametros
List<object> arr = new List<object>();
List<string> name = new List<string>();
arr.Add(cod_origen_datos);
name.Add("@cod_origen_datos");
#endregion
DataConector obj = new DataConector();
return obj.ejecutarComando(sql, arr, name);
}


  public void FillBycod_origen_datos(dsSPXQuery.origen_datosDataTable tabla,
 int cod_origen_datos)
{ 
 string sql = sentenciaBase + @"  WHERE (cod_origen_datos = @cod_origen_datos) ";
  #region parametros
  List<object> arr = new List<object>();
  List<string> name = new List<string>();
  arr.Add(cod_origen_datos);
  name.Add("@cod_origen_datos");
  #endregion 
     DataConector obj = new DataConector();
      obj.ejecutarConsulta(sql, tabla, false, arr, name);
 }


}
}

using System;
using System.Net.Sockets;
using SPX2019.artefactos.SPXdata;


namespace SPXdata.BD
{  

    /// <summary>
    /// para resolver el problema de la cadena de conexion estatica se creo la siguiente logica.
    /// si la aplicacion funciona con solo una cadena de conexion, se deberian asignar las propiedades 
    /// estaticas y el motor automaticamente genera la cadena de conexion con la cual va a trabajar.
    /// 
    /// si se le va a asignar la cadena de conexion se le debe asignar, la propiedad cadenaConexionAsignada
    /// y ninguna propiedad ya que esta tiene prelacion, si lo que tiene son las propiedades para asignarselas al objeto
    /// debe utilizar el metodo generarCadenaConexion para pasarle el parametro.
    /// 
    /// dudas pantroazul@msn.com
    /// </summary>
    public class DataConector
    {
        public enum tipoCnnOracle { normal, sysdba, sysoper }
        public enum tipoMotor { SQLserver, mysql, oracle, postgress }

        /// <summary>
        /// Retorna la fecha del sistema del servidor.
        /// </summary>
        public System.DateTime fechaServer {
            get {
                System.DateTime res = System.DateTime.Now;
                
                
                    string sql = "select  DATEPART(yyyy,GETDATE()),DATEPART(MM,GETDATE()),DATEPART(DD,GETDATE()),DATEPART(HH,GETDATE()),DATEPART(N,GETDATE())";
                    System.Data.DataSet ds = ejecutarConsulta(sql);
                    int ano = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    int mes = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                    int day = int.Parse(ds.Tables[0].Rows[0][2].ToString());
                    int hour = int.Parse(ds.Tables[0].Rows[0][3].ToString());
                    int minute = int.Parse(ds.Tables[0].Rows[0][4].ToString());
                    //---//---//
                    res = new DateTime(ano, mes, day, hour, minute, 0);
                
                return res;
            
            }
        
        }


        /// <summary>
        /// genera una cadena de conexion, de acuerdo a los parametros 
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="servidor"></param>
        /// <param name="baseDatos"></param>
        /// <param name="puerto"></param>
        /// <param name="sid">aplica a oracle</param>
        /// <param name="conexionDirecta">aplica a oracle</param>
        /// <param name="_tipoCnnOracle">aplica a oracle</param>
        /// <returns></returns>
        public string generarCadenaConexion(bool incluirBaseDatos, tipoMotor tipo, string login, string password, string servidor, string baseDatos, string puerto,
            string sid, bool conexionDirecta, tipoCnnOracle _tipoCnnOracle)
        {
            string cnn = "";
            string str_password = "";
            if (servidor == null) return "";
            if (password != null && password.Trim() != string.Empty)
            {
                str_password = "password=" + password + ";";
            }

             if (tipo == tipoMotor.SQLserver)
            {
                cnn = "Data Source=" + servidor + ((puerto == null || puerto == string.Empty || puerto.Trim() == "0") ? "" : ("," + puerto)) + ""
                    + ((!incluirBaseDatos) ? "" : ";Initial Catalog=" + baseDatos + "")
                    + ";" + str_password + "User ID=" + login + ";Persist Security Info=True;TrustServerCertificate=True";
            }
            else if (tipo == tipoMotor.oracle)
            {
                string tipoCnn = "";
                if (_tipoCnnOracle == tipoCnnOracle.normal)
                    tipoCnn = "Default";
                else if (_tipoCnnOracle == tipoCnnOracle.sysdba)
                    tipoCnn = "SysDba";
                else if (_tipoCnnOracle == tipoCnnOracle.sysoper)
                    tipoCnn = "SysOper";

                cnn = "provider=Oracle;user id=" + login + "login;" + str_password + "server=" + servidor
                    + ((!incluirBaseDatos) ? "" : ";database=" + baseDatos + "")
                    + ";connect mode=" + tipoCnn + ";direct=" + ((conexionDirecta) ? "True" : "False") + ";port=" + puerto + ";sid=" + sid + ";persist security info=True;";
            }else if (tipo == tipoMotor.postgress)
            {
                cnn = "provider=SQL Server;Data Source=" + servidor + ((puerto == string.Empty) ? "" : ("," + puerto)) + ""
                    + ((!incluirBaseDatos) ? "" : ";Initial Catalog=" + baseDatos + "")
                    + ";" + str_password + "Persist Security Info=True;User ID=" + login + ";";
            }

            return cnn;
        }

        #region informacion de la conexion
        private static tipoMotor tipo;
        private static string login;
        private static string password;
        private static string servidor;
        private static string baseDatos;
        private static string puerto;
        private static string sid;
        private static bool conexionDirecta;
        private static tipoCnnOracle _tipoCnnOracle;
        private static string cadenaConexionAsignada = "";
        private string obj_cadenaConexionAsignada = "";
        private static int time_out = 0;

        public static tipoMotor Tipo { set { tipo = value; } get { return tipo; } }
        public static string Login { set { login = value; } get { return login; } }
        public static string Password { set { password = value; } get { return password; } }
        public static string Servidor { set { servidor = value; } get { return servidor; } }
        public static string BaseDatos { set { baseDatos = value; } get { return baseDatos; } }
        public static string Puerto { set { puerto = value; } get { return puerto; } }
        public static string Sid { set { sid = value; } get { return sid; } }
        public static bool ConexionDirecta { set { conexionDirecta = value; } get { return conexionDirecta; } }
        public static tipoCnnOracle _TipoCnnOracle { set { _tipoCnnOracle = value; } get { return _tipoCnnOracle; } }
        public static string CadenaConexionAsignada { set { cadenaConexionAsignada = value; } get { return cadenaConexionAsignada; } }
        public string Obj_CadenaConexionAsignada { set { obj_cadenaConexionAsignada = value; } get { return obj_cadenaConexionAsignada; } }
        public static int Time_out { set { time_out = value; } get { return time_out; } }
        #endregion
        
        #region operaciones miselaneas para manipular table adapter
        

        /// <summary>
        /// Esta propiedad obtiene el adaptador de datos de un tableAdapter
        /// </summary>
        /// <param name="tableAdapter">TableAdapter que contiene un adaptador</param>
        /// <returns>retorna el dataadapter del tableAdapter</returns>
        public static object GetAdapter(object tableAdapter)
        {
            Type tableAdapterType = tableAdapter.GetType();
            return tableAdapterType.GetProperty("Adapter", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(tableAdapter, null);
        }

        /// <summary>
        /// Esta Propiedad me retorna la conexion con la cual trabaja un respectivo tableAdapter
        /// </summary>
        /// <param name="tableAdapter">TableAdapter</param>
        /// <returns>retorna la conexion con la que trabaja todos los command</returns>
        public static object GetConnection(object tableAdapter)
        {
            Type tableAdapterType = tableAdapter.GetType();
            return tableAdapterType.GetProperty("Connection", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(tableAdapter, null);
        }

        /// <summary>
        /// Establece la conexion para un tableAdpater
        /// </summary>
        /// <param name="tableAdapter">tableAdpater </param>
        /// <param name="con">Conexion Activa</param>
        public static void SetConnection(object tableAdapter, object conexion)
        {
            Type tableAdapterType = tableAdapter.GetType();
            tableAdapterType.GetProperty("Connection", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableAdapter, conexion, null);
        }

        /// <summary>
        /// Configura un table adapter para que pueda trabajar en una transaccion activa
        /// </summary>
        /// <param name="tableAdapter">tableAdpater</param>
        /// <param name="tran">Transaccion ACtiva</param>
        public static void setTransaccion(object tableAdapter, object transaccion)
        {
            Type tableAdapterType = tableAdapter.GetType();

            //InitCommandCollection
            tableAdapterType.InvokeMember("InitCommandCollection", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.InvokeMethod, null, tableAdapter, null);
            System.Reflection.PropertyInfo prop = tableAdapterType.GetProperty("CommandCollection", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);//, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

           
                System.Data.SqlClient.SqlCommand[] vect = (System.Data.SqlClient.SqlCommand[])prop.GetValue(tableAdapter, null);

                for (int k = 0; k < vect.Length; k++)
                {
                    vect[k].Transaction = (System.Data.SqlClient.SqlTransaction)transaccion;
                }
        }

        public static void inicializarTableAdapter(object tableAdapter)
        {
            Type tableAdapterType = tableAdapter.GetType();
            tableAdapterType.InvokeMember("InitCommandCollection", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.InvokeMethod, null, tableAdapter, null);
            tableAdapterType.InvokeMember("InitAdapter", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.InvokeMethod, null, tableAdapter, null);
        }

        /// <summary>
        /// Me retorna la sentencia sql de un sqlcommand contenido en el commancollection de un table adapter
        /// </summary>
        /// <param name="tableAdapter">tableAdpater</param>
        /// <param name="posicion">index</param>
        public static string verSentenciaCommandCollection(object tableAdapter, int posicion)
        {
            Type tableAdapterType = tableAdapter.GetType();

            //InitCommandCollection
            tableAdapterType.InvokeMember("InitCommandCollection", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.InvokeMethod, null, tableAdapter, null);
            System.Reflection.PropertyInfo prop = tableAdapterType.GetProperty("CommandCollection", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);//, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            object[] vect = (object[])prop.GetValue(tableAdapter, null);
            if (vect.Length > posicion)
            {
                Type t = vect[posicion].GetType();
                System.Reflection.PropertyInfo prop3 = t.GetProperty("CommandText");
                return prop3.GetValue(vect[posicion], null).ToString();
            }
            return "";
        }
        #endregion

    
       DataConectorSql objSqlServer;

        /// <summary>
        /// El constructor de esta clase inicializa las variables
        /// </summary>
        public DataConector()
        {
            if (Tipo == tipoMotor.SQLserver){
                objSqlServer = new DataConectorSql();
                objSqlServer.Time_out = time_out;
            }
            obj_cadenaConexionAsignada = "";
        }

        public void forzarCadenaConexion(string cnn)
        {
          
                objSqlServer._CadenaConexion = cnn;
          
        }


        /// <summary>
        /// Retorna la cadena de conexion activa, esta antes era estatica pero por cuestiones de modelado
        /// ahora nunca debe ser estatica esta variable para que permita manejar multiples conexiones.
        /// </summary>
        public string CadenaConexion
        {
            get
            {
                if (obj_cadenaConexionAsignada != string.Empty) return obj_cadenaConexionAsignada;
                //si se asigno la cadena de conexion esta tiene prioridad de las variables.
                
                if (cadenaConexionAsignada != string.Empty)
                {
                    if(baseDatos != null && baseDatos.Trim() != string.Empty && cadenaConexionAsignada.IndexOf(baseDatos)<0 )
                    {
                        cadenaConexionAsignada=generarCadenaConexion(true, Tipo, login, password, servidor, baseDatos,
                        puerto, sid, conexionDirecta, _tipoCnnOracle);
                        return cadenaConexionAsignada;
                    }else{
                        return cadenaConexionAsignada;
                    }
                }else{
                    cadenaConexionAsignada = generarCadenaConexion(true, Tipo, login, password, servidor, baseDatos,
                        puerto, sid, conexionDirecta, _tipoCnnOracle);
                    return cadenaConexionAsignada;
                }
            }
            set
            {
                cadenaConexionAsignada = value;
            }
        }

        public string CadenaConexionSinBase
        {
            get
            {
                return  generarCadenaConexion(false, Tipo, login, password, servidor, baseDatos,
                        puerto, sid, conexionDirecta, _tipoCnnOracle);
            }
        }

        /// <summary>
        /// Retorna la cadena de conexion para los reportes
        /// </summary>
        public string CadenaConexionReportes
        {
            get
            {
                if (tipo == tipoMotor.SQLserver)
                {
                    return "Provider=SQLOLEDB.1;" + CadenaConexion;
                }
                else if (tipo == tipoMotor.mysql)
                {
                    return "Provider=MSDataShape.1;Driver={MySQL ODBC 5.1 Driver};" + CadenaConexion.Replace("host=", "server=").Replace("host =", "server =");
                }
                else if (tipo == tipoMotor.oracle)
                {
                    return "Provider=SQLOLEDB.1;" + CadenaConexion;
                }
                return "sin motor configurado";
            }
        }

        #region abrir y cerrar conexion


        public bool probarConexion()
        {
               DataConectorSql obj = new DataConectorSql();
                return obj.probarConexion();
            
        }

        #endregion

        #region operaciones de consultas comandos y reader
        /// <summary>
        /// Ejecuta una sentencia sql de consulta en la base de datos configurada
        /// </summary>
        /// <param name="SQL">sentencia sql de consulta</param>
        /// <returns></returns>
        public System.Data.DataSet ejecutarConsulta(string SQL)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable tb = new System.Data.DataTable();
            ds.Tables.Add(tb);
            ejecutarConsulta(SQL, tb) ;
            return ds;
        }

        public void ejecutarConsulta(string SQL, System.Data.DataTable datatable)
        {
            ejecutarConsulta(SQL, datatable, false);
        }

        public void ejecutarConsulta(string SQL, System.Data.DataTable datatable, bool omiteConversion)
        {
            ejecutarConsulta(SQL, datatable, omiteConversion, null, null);
        }

        public void ejecutarConsulta(string SQL, System.Data.DataTable datatable,bool omiteConversion,System.Collections.Generic.List<object> arr,
            System.Collections.Generic.List<string> nombre)
        {
            if (datatable.DataSet != null)
            datatable.DataSet.EnforceConstraints = false;
            
                if (obj_cadenaConexionAsignada.Trim() != string.Empty) objSqlServer._CadenaConexion = Obj_CadenaConexionAsignada;
                objSqlServer.ejecutarConsulta(SQL,datatable,omiteConversion,arr,nombre);
            
        }


        /// <summary>
        /// esta funcion ejecuta un comando sql en la base de datos a configurar.
        /// </summary>
        /// <param name="SQL">sentencia sql a ejecutar.</param>
        public int ejecutarComando(string SQL)
        {
            return ejecutarComando(SQL, null,null);
        }

        public int ejecutarComando(string SQL, System.Collections.Generic.List<object> ArrObj, System.Collections.Generic.List<string> ArrNames) 
        {
               if (obj_cadenaConexionAsignada.Trim() != string.Empty) objSqlServer._CadenaConexion = Obj_CadenaConexionAsignada;
                return objSqlServer.ejecutarComando(SQL, ArrObj, ArrNames);
            
        }


        /// <summary>
        /// Esta funcion se utiliza para realizar consultas y retornar el resultado
        /// en un datareader. la conexion queda abierta y debe cerrarse despues de utilizar
        /// el datareader.
        /// </summary>
        /// <param name="SQL">sentencia SQL del tipo "SELECT * from users"</param>
        /// <returns>retorna un datareader con el resultado de la busqueda.</returns>
        public object ejecutarReader(string SQL)
        {
                objSqlServer = new DataConectorSql();
                if (obj_cadenaConexionAsignada.Trim() != string.Empty) objSqlServer._CadenaConexion = Obj_CadenaConexionAsignada;
                return objSqlServer._ejecutarReader(SQL);
            
        }
        #endregion

        public object ejecutarProcedimiento(string SQL)
        {
            return ejecutarProcedimiento(SQL, null, null);
        }

        #region zona de ejecuciones de procedimiento
        /// <summary>
        /// ESta funcion sirve para ejecutar procedimientos almacenados,
        /// la execute excalar del sql command o sentencias que retornan solo
        /// un valor como por ejemplo select count(*) from tabla
        /// </summary>
        /// <param name="SQL">procedimiento almacenado</param>
        /// <returns>objeto resultado del procedimiento</returns>
        public object ejecutarProcedimiento(string SQL, System.Collections.Generic.List<object> arrObj, System.Collections.Generic.List<string> arrNombres)
        {
        
                if (obj_cadenaConexionAsignada.Trim() != string.Empty) objSqlServer._CadenaConexion = Obj_CadenaConexionAsignada;
                 return objSqlServer._ejecutarProcedimiento(SQL,  arrObj,  arrNombres);
            
        }

        /// <summary>
        /// ESta sobrecarga sirve para ejecutar este metodo desde un wbeservice y no retornar
        /// nulos
        /// </summary>
        /// <param name="SQL">procedimiento almacenado</param>
        /// <returns>objeto resultado del procedimiento y "" si es un DBnull</returns>
        public object ejecutarProcedimiento(string SQL, bool bSinNulos)
        {
                if (obj_cadenaConexionAsignada.Trim() != string.Empty) objSqlServer._CadenaConexion = Obj_CadenaConexionAsignada;
                return objSqlServer._ejecutarProcedimiento(SQL,bSinNulos);
            
        }
        #endregion

        public static string convierteSintaxisSql(string strSql)
        {
                strSql = strSql.ToUpper().Replace( "NOW()","GETDATE()");
                if (strSql.IndexOf("LIMIT ") > -1)
                {
                    //si tiene top buscamos el numero
                    string str = strSql.Substring(strSql.IndexOf("LIMIT ") + 6);
                    strSql = strSql.Replace("LIMIT " + str, "") ;
                    strSql = strSql.Replace("SELECT","SELECT TOP " + str);
                }
                strSql = strSql.Replace( "IFNULL(","ISNULL(");
                strSql = strSql.Replace("DECIMAL(","NUMERIC(");

            
            return strSql.ToLower();
        }

        public void iniciarTransaccion() 
        {
            
                if (obj_cadenaConexionAsignada.Trim() != string.Empty) objSqlServer._CadenaConexion = Obj_CadenaConexionAsignada;
                objSqlServer._iniciarTransaccion();
            
        }

        public void rollbackTransaccion()
        {                
                objSqlServer._deshacerTransaccion();
            
        }

        public void commitTransaccion()
        {
                objSqlServer._confirmarTransaccion();
            
        }

        public object iniciarGetTransaccion()
        {
                    objSqlServer._iniciarTransaccion();
                    return objSqlServer._Transaccion;
            
        }

        public void rollbackTransaccion(object transaccion)
        {
            ((System.Data.SqlClient.SqlTransaction)transaccion).Rollback();     
        }

        public void commitTransaccion(object transaccion)
        {
          
                    ((System.Data.SqlClient.SqlTransaction)transaccion).Commit();      
        }
    }
}
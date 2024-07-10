using System;
using System.Net.Sockets;
using System.Data;
using System.Data.SqlClient;

namespace SPXdata.BD
{
    public sealed class DataConectorSql
    {
        #region definicion de campos y de propiedades

        #region campos no estaticos

        private SqlCommand _comandoSQL;
        private SqlConnection _conexion;
        private SqlDataAdapter _adaptador;
        private SqlTransaction _transaccion;
        private bool _transaccionActiva = false;

        #endregion
        //Propiedades
        #region propiedades no estaticos
        public int Time_out { set; get; }
        public SqlCommand _ComandoSQL { set { _comandoSQL = value; } get { return _comandoSQL; } }
        public SqlConnection _Conexion { set { _conexion = value; } get { return _conexion; } }
        public SqlDataAdapter _Adaptador { set { _adaptador = value; } get { return _adaptador; } }
        public SqlTransaction _Transaccion { set { _transaccion = value; } get { return _transaccion; } }
        public bool _TransaccionActiva { set { _transaccionActiva = value; } get { return _transaccionActiva; } }
        #endregion
        #endregion
        public string _CadenaConexion = "";

        public static object killConexiones(string baseDatos)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(" DECLARE ");
            sb.Append(" @p_SPID int,  ");
            sb.Append(" @p_SQL nvarchar(2000), ");
            sb.Append(" @dbName nvarchar(100) ");

            sb.Append(" SET @dbName = '" + baseDatos.Trim() + "' ");

            sb.Append(" DECLARE #cur_Processes CURSOR FOR  ");

            sb.Append(" SELECT  ");
            sb.Append(" p.SPID  ");
            sb.Append(" FROM  ");
            sb.Append(" master.dbo.sysprocesses AS p  ");
            sb.Append(" JOIN master.dbo.sysdatabases AS d ON( d.dbid = p.dbid )  ");
            sb.Append(" WHERE  ");
            sb.Append(" d.Name = @dbName AND p.SPID > 50   ");//-- AND spid >= 51 (because spids of 50 or less are reserved for internal use.)
            sb.Append(" OPEN #cur_Processes  ");
            sb.Append(" FETCH NEXT FROM #cur_Processes INTO @p_SPID  ");
            sb.Append(" WHILE @@FETCH_STATUS = 0  ");

            sb.Append(" BEGIN  ");
            sb.Append(" SET @p_SQL = 'KILL ' + CONVERT( nvarchar(30), @p_SPID )  ");
            sb.Append(" PRINT @p_SQL  ");
            sb.Append(" EXECUTE( @p_SQL )  ");
            sb.Append(" FETCH NEXT FROM #cur_Processes INTO @p_SPID  ");
            sb.Append(" END  ");
            sb.Append(" CLOSE #cur_Processes  ");
            sb.Append(" DEALLOCATE #cur_Processes  ");
           DataConector obj = new DataConector();
            obj.Obj_CadenaConexionAsignada = obj.CadenaConexionSinBase;
            return obj.ejecutarProcedimiento(sb.ToString());
        }

        /// <summary>
        /// El constructor de esta clase inicializa las variables
        /// </summary>
        public DataConectorSql()
        {
            _CadenaConexion =DataConector.CadenaConexionAsignada;
        }

        /// <summary>
        /// Establece una conexion con la base de datos
        /// </summary>
        public void _abrirConexion()
        {
            if (_Conexion == null)
            {
                _Conexion = new SqlConnection();
                _Conexion.ConnectionString = _CadenaConexion;
                _conexion.Open();
            }
            else
            {
                if (_TransaccionActiva)
                {
                    if (_Conexion.State != System.Data.ConnectionState.Open)
                    {
                        _conexion.Open();
                    }
                }
                else
                {
                    if (_Conexion.State != System.Data.ConnectionState.Open)
                    {
                        _Conexion.Close();
                        _Conexion = new SqlConnection();
                        _Conexion.ConnectionString = _CadenaConexion;
                        _conexion.Open();
                    }
                }
            }
        }

        public bool probarConexion()
        {
            try
            {
               DataConector obj = new DataConector();
                SqlConnection cnn = new SqlConnection(obj.CadenaConexion);
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Cierra la conexion activa
        /// </summary>
        public void _cerrarConexion()
        {
            if (_Conexion != null && !_TransaccionActiva)
            {
                _conexion.Close();
                _conexion.Dispose();
            }
        }

        /// <summary>
        /// Ejecuta una sentencia sql de consulta en la base de datos configurada
        /// </summary>
        /// <param name="SQL">sentencia sql de consulta</param>
        /// <returns></returns>
        public DataSet ejecutarConsulta(string SQL)
        {
            System.Data.DataSet ds = new DataSet();
            System.Data.DataTable tb = new DataTable();
            ds.Tables.Add(tb);
            ejecutarConsulta(SQL, tb);
            return ds;
        }

        /// <summary>
        /// Ejecuta una sentencia sql de consulta en la base de datos configurada
        /// </summary>
        /// <param name="SQL">sentencia sql de consulta</param>
        /// <param name="tabla">Tabla que se va a llenar.</param>
        /// <returns></returns>
        public void ejecutarConsulta(string SQL, DataTable tabla)
        {
            ejecutarConsulta(SQL, tabla, false);
        }

        /// <summary>
        /// Ejecuta una consulta en el motor de base de datos. si se encuentra en una
        /// transaccion activa maneja la conexion como  viene.
        /// </summary>
        /// <param name="SQL">sentencia sql.</param>
        /// <param name="nombreDataSet">nombre del dataset.</param>
        /// <returns>retorna el conjunto de datos.</returns>
        public void ejecutarConsulta(string SQL, System.Data.DataTable tb, bool omiteConversion)
        {
            ejecutarConsulta(SQL, tb, omiteConversion, null, null);
        }

        /// <summary>
        /// ejecuta consulta con parametros
        /// </summary>
        /// <param name="SQL"></param>
        /// <param name="tb"></param>
        /// <param name="omiteConversion"></param>
        /// <param name="arr"></param>
        /// <param name="nombre"></param>
        public void ejecutarConsulta(string SQL, System.Data.DataTable tb, bool omiteConversion, System.Collections.Generic.List<object> arr,
                System.Collections.Generic.List<string> nombre)
        {
            if (!omiteConversion)
            {
                SQL =DataConector.convierteSintaxisSql(SQL);
                if (DataConector.Tipo ==DataConector.tipoMotor.SQLserver)
                {
                    if (SQL.ToLower().IndexOf("dateformat") < 0)
                 SQL=   " set dateformat ymd "+ SQL;
                }
            }

            SqlDataAdapter adaptadorSQL;
            if (_transaccionActiva)
            {
                _abrirConexion();
                adaptadorSQL = new SqlDataAdapter(SQL, (_conexion as SqlConnection));

                _cerrarConexion();
            }
            else
            {
                adaptadorSQL = new SqlDataAdapter(SQL, _CadenaConexion);
            }
            adaptadorSQL.SelectCommand.CommandTimeout = Time_out;
            sustituirParametros(adaptadorSQL.SelectCommand.Parameters, arr, nombre);
            tb.Clear();
            adaptadorSQL.Fill(tb);
        }


        public void sustituirParametros(SqlParameterCollection parametros, System.Collections.Generic.List<object> valoresParametros, System.Collections.Generic.List<string> nombreParametros)
        {
            if (valoresParametros == null) return;
            for (int k = 0; k < nombreParametros.Count; k++)
            {
                SqlParameter parametro = new SqlParameter();

                if (valoresParametros[k] == null || valoresParametros[k] == System.DBNull.Value)
                {
                    parametro.IsNullable = true;
                    parametro.Value = System.DBNull.Value;
                }
                else
                {
                    parametro.IsNullable = false;
                    parametro.Value = valoresParametros[k];
                }

                parametro.ParameterName = "@" + nombreParametros[k].Replace("@", "");


                Type tipo = typeof(string);

                if (valoresParametros[k] != null)
                {
                    tipo = valoresParametros[k].GetType();
                }
                //miramos si el tipo viene impuesto en el nombre
                if (nombreParametros[k].IndexOf("|") >= 0)
                {
                    string[] arr = nombreParametros[k].Split('|');
                    tipo = System.Type.GetType(arr[1]);
                    parametro.ParameterName = "@" + arr[0].Replace("@", "");
                }

                if (tipo.FullName == "System.Byte")
                {
                    parametro.DbType = DbType.Byte;
                    parametro.SqlDbType = SqlDbType.Image;
                }
                else if (tipo.FullName == "System.Byte[]")
                {
                    parametro.DbType = DbType.Byte;
                    parametro.SqlDbType = SqlDbType.Image;
                }
                else if (tipo.FullName == "System.String")
                {
                    parametro.DbType = DbType.String;
                    parametro.SqlDbType = SqlDbType.Char;
                }
                else if (tipo.FullName == "System.Boolean")
                {
                    parametro.DbType = DbType.Boolean;
                    parametro.SqlDbType = SqlDbType.Bit;
                }
                else if (tipo.FullName == "System.Int64")
                {
                    parametro.DbType = DbType.Int64;
                    parametro.SqlDbType = SqlDbType.BigInt;
                }
                else if (tipo.FullName == "System.Int32")
                {
                    parametro.DbType = DbType.Int32;
                    parametro.SqlDbType = SqlDbType.Int;
                }
                else if (tipo.FullName == "System.Char")
                {
                    parametro.DbType = DbType.String;
                    parametro.SqlDbType = SqlDbType.Char;
                }
                else if (tipo.FullName == "System.DateTime")
                {
                    parametro.DbType = DbType.DateTime;
                    parametro.SqlDbType = SqlDbType.DateTime;
                }
                else if (tipo.FullName == "System.Double")
                {
                    parametro.DbType = DbType.Double;
                    parametro.SqlDbType = SqlDbType.Decimal;
                }
                else if (tipo.FullName == "System.Numeric")
                {
                    parametro.DbType = DbType.Decimal;
                    parametro.SqlDbType = SqlDbType.Decimal;
                }
                else if (tipo.FullName == "System.Decimal")
                {
                    parametro.DbType = DbType.Decimal;
                    parametro.SqlDbType = SqlDbType.Decimal;
                }
                else
                {
                    parametro.DbType = DbType.String;
                    parametro.SqlDbType = SqlDbType.VarChar;
                }
                /*
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Binary", "global::MySql.Data.MySqlClient.MySqlDbType.Binary");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Bit", "global::MySql.Data.MySqlClient.MySqlDbType.Bit");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Blob", "global::MySql.Data.MySqlClient.MySqlDbType.Blob");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Byte", "global::MySql.Data.MySqlClient.MySqlDbType.Byte");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Char", "global::MySql.Data.MySqlClient.MySqlDbType.VarChar");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Clob", "global::MySql.Data.MySqlClient.MySqlDbType.Text");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Currency", "global::MySql.Data.MySqlClient.MySqlDbType.Double");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Date", "global::MySql.Data.MySqlClient.MySqlDbType.Date");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Decimal", "global::MySql.Data.MySqlClient.MySqlDbType.Decimal");
                res = res.Replace("global::Devart.Data.Universal.UniDbType.Double", "global::MySql.Data.MySqlClient.MySqlDbType.Double");
                
                 * */
                parametros.Add(parametro);
            }
        }

        public int ejecutarComando(string SQL)
        {
            return ejecutarComando(SQL, null, null);
        }

        /// <summary>
        /// esta funcion ejecuta un comando sql en la base de datos a configurar.
        /// </summary>
        /// <param name="SQL">sentencia sql a ejecutar.</param>
        public int ejecutarComando(string SQL, System.Collections.Generic.List<object> arrObj, System.Collections.Generic.List<string> arrNombres)
        {
            int res = 0;
            try
            {
                _abrirConexion();
                if (!_TransaccionActiva)
                {
                    _comandoSQL = new SqlCommand();
                    _comandoSQL.Connection = (_conexion as SqlConnection);
                }
                SQL =DataConector.convierteSintaxisSql(SQL);
                _comandoSQL.CommandText = SQL;
                _comandoSQL.CommandTimeout = Time_out;
                sustituirParametros(_comandoSQL.Parameters, arrObj, arrNombres);
                res = _comandoSQL.ExecuteNonQuery();
            }
            finally
            {
                _cerrarConexion();
            }
            return res;
        }

        /// <summary>
        /// Esta funcion se utiliza para realizar consultas y retornar el resultado
        /// en un datareader. la conexion queda abierta y debe cerrarse despues de utilizar
        /// el datareader.
        /// </summary>
        /// <param name="SQL">sentencia SQL del tipo "SELECT * from users"</param>
        /// <returns>retorna un datareader con el resultado de la busqueda.</returns>
        public SqlDataReader _ejecutarReader(string SQL)
        {
            SqlDataReader dr;
            _abrirConexion();
            _comandoSQL = new SqlCommand();
            _comandoSQL.CommandText = SQL;
            _comandoSQL.Connection = _conexion;
            _comandoSQL.CommandTimeout = Time_out;
            dr = _comandoSQL.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// ESta funcion sirve para ejecutar procedimientos almacenados,
        /// la execute excalar del sql command o sentencias que retornan solo
        /// un valor como por ejemplo select count(*) from tabla
        /// </summary>
        /// <param name="SQL">procedimiento almacenado</param>
        /// <returns>objeto resultado del procedimiento</returns>
        public object _ejecutarProcedimiento(string SQL, System.Collections.Generic.List<object> arrObj, System.Collections.Generic.List<string> arrNombres)
        {
            object objeto;
            try
            {
                _abrirConexion();
                if (!_transaccionActiva)
                {
                    _comandoSQL = new SqlCommand();
                    _comandoSQL.Connection = _conexion;
                    _comandoSQL.CommandTimeout = Time_out;
                }
                
                _comandoSQL.CommandText =DataConector.convierteSintaxisSql(SQL);
                if (arrObj != null && arrObj.Count > 0)
                {
                    sustituirParametros(_comandoSQL.Parameters, arrObj, arrNombres);
                }
                objeto = _comandoSQL.ExecuteScalar();
            }
            finally
            {
                _cerrarConexion();
            }
            return objeto;
        }


        /// <summary>
        /// ESta sobrecarga sirve para ejecutar este metodo desde un wbeservice y no retornar
        /// nulos
        /// </summary>
        /// <param name="SQL">procedimiento almacenado</param>
        /// <returns>objeto resultado del procedimiento y "" si es un DBnull</returns>
        public object _ejecutarProcedimiento(string SQL, bool bSinNulos)
        {
            object objAux = _ejecutarProcedimiento(SQL, null, null);
            if (bSinNulos && objAux is DBNull)
                return "";
            else
                return objAux;
        }

        public void _iniciarTransaccion()
        {
            _TransaccionActiva = true;
            _comandoSQL = new SqlCommand();

            _abrirConexion();
            _Transaccion = _conexion.BeginTransaction(IsolationLevel.ReadCommitted);
            _comandoSQL.Connection = _conexion;
            _comandoSQL.Transaction = _Transaccion;
        }

        public void _confirmarTransaccion()
        {
            if (_TransaccionActiva)
            {
                if (_Transaccion != null)
                    _Transaccion.Commit();
                _cerrarConexion();
                _Transaccion = null;
                _comandoSQL = null;
                _TransaccionActiva = false;
            }
            else
            {
                Exception ex = new Exception("Error la transaccion no fue iniciada por lo tanto no se puede confirmar.");
                throw ex;
            }
        }

        public void _deshacerTransaccion()
        {
            if (_TransaccionActiva)
            {
                if (_Transaccion != null)
                    _Transaccion.Rollback();
                _TransaccionActiva = false;
                _cerrarConexion();
                _Transaccion = null;
                _comandoSQL = null;
                _TransaccionActiva = false;
            }
            else
            {
                Exception ex = new Exception("Error la transaccion no fue iniciada por lo tanto no se puede cancelar.");
                throw ex;
            }
        }
    }
}
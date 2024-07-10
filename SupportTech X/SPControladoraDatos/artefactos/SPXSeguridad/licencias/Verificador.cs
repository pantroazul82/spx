using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace SPXSeguridad.licencias
{
    public class Verificador
    {
        private static string aplicativo = "";
        private static string version = "";
        /// <summary>
        /// Nombre del Aplicativo
        /// </summary>
        public static string Aplicativo {set{aplicativo = value;}get{return aplicativo;}}
        /// <summary>
        /// Version del Aplicativo
        /// </summary>
        public static string VersionApp { set { version = value; } get { return version; } }

        public Verificador() 
        {

        }

        [DllImport("kernel32.dll")]
		private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, UInt32 VolumeNameSize, ref UInt32 VolumeSerialNumber, ref UInt32 MaximumComponentLength, ref UInt32 FileSystemFlags, StringBuilder FileSystemNameBuffer, UInt32 FileSystemNameSize);

        /// <summary>
        /// Esta funcion sirve para traer el serial del disco duro
        /// </summary>
        /// <param name="strDriveLetter">recibe el volumen del cual se quiere traer el serial.</param>
        /// <returns>retorna el serial del disco duro del volumen elejido</returns>
        public static string verSerialDiscoDuro(string strDriveLetter)
        {
            uint serNum = 0;
            uint maxCompLen = 0;
            StringBuilder VolLabel = new StringBuilder(256); // Label
            UInt32 VolFlags = new UInt32();
            StringBuilder FSName = new StringBuilder(256); // File System Name
            strDriveLetter += ":\\"; // fix up the passed-in drive letter for the API call
            long Ret = GetVolumeInformation(strDriveLetter, VolLabel, (UInt32)VolLabel.Capacity, ref serNum, ref maxCompLen, ref VolFlags, FSName, (UInt32)FSName.Capacity);
            return Convert.ToString(serNum);
        }

        public string verHardwareId() 
        {
            long tmp = long.Parse(verSerialDiscoDuro("C"));   
            long tmp2 = (long)(tmp*System.Math.PI);//remplazarlo por otro valor propio del equipo como la mac o serial del procesador.
            string uni=""+tmp.ToString()+ tmp2.ToString();
            Cryptografia.CryptoSha1 objR = new Cryptografia.CryptoSha1();
            uni = objR.encriptar(uni+VersionApp+Aplicativo);
            return uni;
        }

        /// <summary>
        /// Este es el hardware ID convertido en serial
        /// </summary>
        /// <returns></returns>
        public string ghid() 
        {
            char[] tmp = verHardwareId().ToCharArray();
            string res="";
            string tmp2 = "";
            for(int k=0;k<tmp.Length;k++)
            {
                tmp2=""+(((int)tmp[k])% 89);
                res= res+ tmp2.PadLeft(2,'0');
            }
            ///nos aseguramos que tenga por lo menos 25
            if (res.Length < 35)
            {
                res += res;
            }
            
            string[] vec = new string[6];
       
            vec[0]=res.Substring(0, 6);
            vec[1]=res.Substring(6, 6);
            vec[2]=res.Substring(12, 6);
            vec[3]=res.Substring(18, 6);
            vec[4]=res.Substring(24, 6);
            vec[5] = res.Substring(30, 6);
            res = vec[0] + "-" + vec[1] + "-" + vec[2] + "-" + vec[3] + "-" + vec[4] + "-" + vec[5];
            return res;
        }

        public string generarSerial(string ghid) 
        {
            if (ghid.Trim() == string.Empty || ghid.Trim().Length != 41 || ghid.Trim().Split('-').Length != 6)
            { 
                throw(new Exception("El Hardware Id no es valido") );
            }

            Cryptografia.CryptoRijndael obj = new Cryptografia.CryptoRijndael();
            string tmp = obj.Encriptar(ghid, version+aplicativo );

            char[] vector = tmp.ToCharArray();
            tmp = "";
            char a='A';
            int t = 0;
            for (int k = 0; k < vector.Length; k++)
            {
                t=(int)vector[k] % 36;
                if (t > 25)
                {
                    a = (char)(((int)'0') + (t - 26));
                } else { 
                    a=(char)((int)'A'+t);
                }    
                tmp = tmp+""+a.ToString();
            }
            ///----Ultima generacion
            int r=0;
            long l = 0;
            do
            {
                l = long.Parse(DateTime.Now.Ticks.ToString().Substring(DateTime.Now.Ticks.ToString().Length - 10, 10)) % 997013;
                r = (int)l;
            } while (r < 99999);
            string[] arr = new string[7];
            arr[0] = r.ToString().Substring(0,2)+tmp.Substring(r%tmp.Length,2)+r.ToString().Substring(4,2);
            arr[1] = tmp.Substring(0, 6);
            arr[2] = tmp.Substring(6, 6);
            arr[3] = tmp.Substring(12, 6);
            arr[4] = tmp.Substring(18, 6);
            arr[5] = tmp.Substring(24, 6);
            arr[6] = tmp.Substring(30, 6);
            //hacemos un random
            string str = "";
            Random rand = new Random();
            tmp = "";
            while (str.Length < 7) 
            {
                r=rand.Next(0, 7);
                if (str.IndexOf(r.ToString()) < 0)
                {
                    if (r < 7)
                    {
                        str += r.ToString();
                        tmp += arr[r] + "-";
                    }
                }
            
            }
            tmp = tmp.Substring(0, tmp.Length - 1);
            return tmp;
        }

        public bool comprobarSerial(string ghid, string serial) 
        {
            string[] a= generarSerial(ghid).Split('-');
            string[] b=serial.Split('-');
            int contador = 0;
            for (int k = 0; k < a.Length; k++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[k] == b[j])
                    {
                        contador++;
                    }
                }
            }
            return (contador == 6);
        }

        public void guardarSerial(string serial)
        {
            try
            {
                RegistryKey regVersion = Registry.CurrentUser.OpenSubKey ("SOFTWARE\\CGSF\\" + aplicativo.Trim() + "\\" + version.Trim(), true);
                if (regVersion == null)
                {
                    regVersion = Registry.CurrentUser.CreateSubKey("SOFTWARE\\CGSF\\" + aplicativo.Trim() + "\\" + version.Trim());
                }
                Cryptografia.CryptoRijndael objR = new Cryptografia.CryptoRijndael();
                string valorTxt = objR.Encriptar(serial, ghid());
                if (regVersion != null)
                {
                    regVersion.SetValue("llave seguridad", valorTxt);
                    regVersion.Close();
                }
            }catch(System.UnauthorizedAccessException)
            {
                    throw(new Exception("\nNo se puede registrar el producto. asegurese de tener permisos de administrador.") ); 
            }
        }

        public bool verificarSerial()
        {
            bool resp = false;
            try
            {
                RegistryKey regVersion = Registry.CurrentUser.OpenSubKey("SOFTWARE\\CGSF\\" + aplicativo.Trim() + "\\" + version.Trim(), true);
                if (regVersion == null)
                {
                    return false;
                }

                SPXSeguridad.Cryptografia.CryptoRijndael objR = new SPXSeguridad.Cryptografia.CryptoRijndael();
                string valorRegistro = regVersion.GetValue("llave seguridad").ToString();
                valorRegistro = objR.DesEncriptar(valorRegistro, ghid());
                if (comprobarSerial(ghid(), valorRegistro))
                {

                    resp = true;
                    regVersion.Close();

                }
            }
            catch
            {
                resp = false;
            }
            return resp;
        }

        public string cargarSerialRegistro()
        {
            try
            {
                RegistryKey regVersion = Registry.CurrentUser.OpenSubKey("SOFTWARE\\CGSF\\" + aplicativo.Trim() + "\\" + version.Trim(), true);
                if (regVersion == null)
                {
                    return "";
                }

                Cryptografia.CryptoRijndael objR = new Cryptografia.CryptoRijndael();
                string valorRegistro = regVersion.GetValue("llave seguridad").ToString();
                valorRegistro = objR.DesEncriptar(valorRegistro, ghid());
                if (comprobarSerial(ghid(), valorRegistro))
                {

                    return valorRegistro;

                }
                return "";
            }
            catch
            {
                return "";
            }
        }
    }
}

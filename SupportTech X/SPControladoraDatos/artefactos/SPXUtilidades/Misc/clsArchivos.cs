using System;
using System.Collections.Generic;
using System.Text;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc
{
    public class clsArchivos
    {
        public static void abrirArchivo(string nombreArchivo)
        {
            if(!System.IO.File.Exists(nombreArchivo))
            {
                throw (new Exception("el archivo " + nombreArchivo + " no existe"));
            }
            //despues de creado lo abrimos
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = nombreArchivo;
            //p.StartInfo.CreateNoWindow=true;
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            p.StartInfo.WorkingDirectory = nombreArchivo.Replace(System.IO.Path.GetFileName(nombreArchivo), "");
            p.Start();
        }
    }
}

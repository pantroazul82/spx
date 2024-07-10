using System;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;
using System.IO;
namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc
{

    public class ZipUtil
    {
        /// <summary>
        /// Comprime toda una carpeta
        /// </summary>
        /// <param name="carpeta">Carpetaa comprimir</param>
        /// <param name="zipFic">nombre del archivo comprimido</param>
        /// <param name="recursivo">Indica si es recursivo</param>
        public void ComprimirCarpeta(string carpeta, string zipFic,bool recursivo)
        {
            FastZip f = new FastZip();
            f.CreateZip(zipFic, carpeta, recursivo, "");
        }

        /// <summary>
        /// Comprime toda una carpeta
        /// </summary>
        /// <param name="carpeta">Carpetaa comprimir</param>
        /// <param name="zipFic">nombre del archivo comprimido</param>
        /// <param name="recursivo">Indica si es recursivo</param>
        public void ComprimirArchivo(string archivo, string zipFic, bool recursivo)
        {
            FastZip f = new FastZip();
            string str = System.IO.Path.GetDirectoryName(archivo);
            f.CreateZip(zipFic, str, recursivo, archivo);
        }

        /// <summary>
        /// Decomprime un archivo ZIP
        /// </summary>
        /// <param name="directorio"></param>
        /// <param name="zipFic"></param>
        /// <param name="eliminar"></param>
        /// <param name="renombrar"></param>
        public void Descomprimir(string directorio, string zipFic, bool eliminar, bool renombrar)
        {
            FastZip f = new FastZip();
            f.ExtractZip(zipFic, directorio, "");
        }
        //
        public ZipEntry[] Contenido(string zipFic)
        {
            // devuelve el contenido del zip indicado
            ZipInputStream strmZipInputStream = new ZipInputStream(File.OpenRead(zipFic));
            ZipEntry objEntry;
            ZipEntry[] files = new ZipEntry[1];
            int n = -1;
            //
            while ((objEntry = strmZipInputStream.GetNextEntry()) != null)
            {
                n = n + 1;
                // hacer una copia de files
                // para añadir el nuevo elemento
                // ¡con lo fácil que es usar ReDim Preserve!
                if (n > 0)
                {
                    ZipEntry[] files2 = new ZipEntry[n + 1];
                    Array.Copy(files, files2, n);
                    files2[n] = objEntry;
                    files = new ZipEntry[n + 1];
                    Array.Copy(files2, files, n + 1);
                    files2 = null;
                }
                else
                {
                    files[0] = objEntry;
                }
            }
            strmZipInputStream.Close();
            //
            return files;
        }
    }
}
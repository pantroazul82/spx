using System;
using System.Text;
using System.Runtime.InteropServices;//ese es para EL DllImport


namespace SPControladoraDatos.artefactos.SPXUtilidades
{
	/// <summary>
	/// Esta clase es util para identificar atributos de la maquina donde se esta trabajando.
	/// como por ejemplo el volumne del disco y ese tipo de cosas.
	/// </summary>
	public class IdentificacionMaquinas
	{
		public IdentificacionMaquinas()
		{
			
		}

		[DllImport("kernel32.dll")]
		private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, UInt32 VolumeNameSize, ref UInt32 VolumeSerialNumber, ref UInt32 MaximumComponentLength, ref UInt32 FileSystemFlags, StringBuilder FileSystemNameBuffer, UInt32 FileSystemNameSize);

/// <summary>
/// Esta funcion sirve para traer el serial del disco duro
/// </summary>
/// <param name="strDriveLetter">recibe el volumen del cual se quiere traer el serial.</param>
/// <returns>retorna el serial del disco duro del volumen elejido</returns>
		public static string GetVolumeSerial(string strDriveLetter)
		{
			uint serNum = 0;
			uint maxCompLen = 0;
			StringBuilder VolLabel = new StringBuilder(256); // Label
			UInt32 VolFlags = new UInt32();
			StringBuilder FSName = new StringBuilder(256); // File System Name
			strDriveLetter+=":\\"; // fix up the passed-in drive letter for the API call
			long Ret = GetVolumeInformation(strDriveLetter, VolLabel, (UInt32)VolLabel.Capacity, ref serNum, ref maxCompLen, ref VolFlags, FSName, (UInt32)FSName.Capacity);
			return Convert.ToString(serNum);
		}

        
	}
}

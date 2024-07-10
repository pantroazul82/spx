using System;

namespace SPXUtilidades
{
	/// <summary>
	/// Descripción breve de digitoVerificacion.
	/// </summary>
	public sealed class digitoVerificacion
	{
	
		private static int[] matrizDPA=new int[15];
	
        /// <summary>
		/// El constructor de esta clase no recibe ningun parametro
		/// inicializa la matriz con los valores definidos.
		/// </summary>
		public digitoVerificacion()
		{
			matrizDPA[0]=71;
			matrizDPA[1]=67;
			matrizDPA[2]=59;
			matrizDPA[3]=53;
			matrizDPA[4]=47;
			matrizDPA[5]=43;
			matrizDPA[6]=41;
			matrizDPA[7]=37;
			matrizDPA[8]=29;
			matrizDPA[9]=23;
			matrizDPA[10]=19;
			matrizDPA[11]=17;
			matrizDPA[12]=13;
			matrizDPA[13]=7;
			matrizDPA[14]=3;
		}
		/// <summary>
		/// Esta funcion es la que se encarga de calcular el digito de verificacion
		/// como prerequisito la propiedad nit debe tener algun valor. 
		/// </summary>
		/// <returns>el digito de verificacion</returns>
		public static int calcularDigito(string nit)
		{
			int respuesta=0,suma=0;
            int tmp = 0;
            bool b = int.TryParse(nit,out tmp);
            if (!b) return 0;
			matrizDPA[0]=71;
			matrizDPA[1]=67;
			matrizDPA[2]=59;
			matrizDPA[3]=53;
			matrizDPA[4]=47;
			matrizDPA[5]=43;
			matrizDPA[6]=41;
			matrizDPA[7]=37;
			matrizDPA[8]=29;
			matrizDPA[9]=23;
			matrizDPA[10]=19;
			matrizDPA[11]=17;
			matrizDPA[12]=13;
			matrizDPA[13]=7;
			matrizDPA[14]=3;
			try
			{
				
				nit="000000000000000"+nit.Trim();//añadimos 15 espacios ala izquierda del nit
				nit=nit.Substring(nit.Length-15,15);
				for(int k=0;k<15;k++)
				{
					suma+=int.Parse(nit.Substring(k,1))*matrizDPA[k];
				}	
				suma%=11;
				if(suma==0 || suma ==1)
				{
					respuesta=suma;
				}
				else
				{
					respuesta=11-suma;
				}
			}
			catch(System.Exception ex)
			{
				throw(ex);
			}
			return respuesta;
		}
	}
}
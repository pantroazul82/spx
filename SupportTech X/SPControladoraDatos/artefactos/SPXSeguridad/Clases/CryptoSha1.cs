using System;
using System.Security.Cryptography;

namespace SPXSeguridad.Cryptografia
{
	/// <summary>
	/// Esta clase se encarga de encriptar texto con el algoritmo sha1, esta clase posee dos 
	/// metodos.
	///               Encriptar     
	///               encriptar     
	/// ambos realizan exactamente lo mismo la diferencia es que uno es estatico y no necesita 
	/// que se instancie un objeto de la clase para llamar la funcion.
	/// </summary>
	public class CryptoSha1 
	{

		/// <summary>
		/// Esta funcion encripta un texto que recibe como parametro
		/// con el algoritmo de encripcion SHA1, no se implementa la funcion descriptar
		/// ya que la gracia de este algoritmo es encriptar el texto a comparar y observar 
		/// si encriptado dan el mismo texto resultado, el texto que se encripta con el 
		/// algoritmo sha 1 no se  puede desencriptar, para verificar que dos textos son
		/// iguales se encriptan y se comparan los valores encriptados esta funcion es estatica
		/// por lo cual podemos llamarla sin tener una instancia del tipo de la clase.
		/// </summary>
		/// <param name="textoPlano">el texto sin encriptar</param>
		/// <returns>el texto encriptado</returns>
		public string encriptar(string textoPlano)
		{
			Byte[] bufferByte=new Byte[textoPlano.Length];
			Byte[] bufferResultadoByte;
			int contador=0;
			string textoEncriptado="";
			//creamos un objeto de la clase de proveedores de encripcion de .net
            
			SHA1CryptoServiceProvider sha=new SHA1CryptoServiceProvider();
			try
			{
				//primero pasa todo a bits
				while(contador<textoPlano.Length)
				{
					bufferByte[contador]=(Byte)char.Parse((textoPlano.Substring(contador,1)));
					contador++;
				}
				//
				bufferResultadoByte=sha.ComputeHash(bufferByte);
				contador=0;
				//luego realizamosla funcion hash de encripcion
				while(contador<bufferResultadoByte.Length)
				{
					textoEncriptado+=(char)bufferResultadoByte[contador];
					contador++;
				}
				//se le quitan las comilas sencillas para
				//que no haya problema con un query de la base de datos
				textoEncriptado=textoEncriptado.Replace("'","");
			}
			catch
			{
				textoEncriptado="ERROR";
			}
			return textoEncriptado;
		}		

	}
}

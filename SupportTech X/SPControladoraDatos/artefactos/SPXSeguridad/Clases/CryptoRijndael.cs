using System;
using System.IO; 
using System.Security.Cryptography;

namespace SPXSeguridad.Cryptografia
{
	/// <summary>
	/// Descripción breve de CryptoRijndael esta clase encripta y desencripta informacion
	/// con el algoritmo de  Rijndael el cual necesita una clave de encripcion.
	/// </summary>
	public class CryptoRijndael
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public CryptoRijndael()
		{
			
		}
		
		// Encriptar un arreglo de byte usamdo una llave y IV 
		public byte[] Encriptar(byte[] clearData, byte[] Key, byte[] IV) 
		{ 
			// Creatmos un MemoryStream para aceptar los bytes encriptados.
			MemoryStream ms = new MemoryStream(); 
			// vamos a usar Rijndael por que es un algorimo fuerte y funciona en todas las
			// plataformas
			// Se pueden usar otros algoritmos solo sustituyendo la siguiente linea 
			// por ejemplo con:
			//      TripleDES alg = TripleDES.Create(); 
			Rijndael alg = Rijndael.Create(); 
			// Now set the key and the IV. 
			// We need the IV (Initialization Vector) because
			// the algorithm is operating in its default 
			// mode called CBC (Cipher Block Chaining).
			// The IV is XORed with the first block (8 byte) 
			// of the data before it is Encriptared, and then each
			// Encriptared block is XORed with the 
			// following block of plaintext.
			// This is done to make Encriptarion more secure. 

			// There is also a mode called ECB which does not need an IV,
			// but it is much less secure. 
			alg.Key = Key; 
			alg.IV = IV; 
			// Create a CryptoStream through which we are going to be
			// pumping our data. 
			// CryptoStreamMode.Write means that we are going to be
			// writing data to the stream and the output will be written
			// in the MemoryStream we have provided. 
			CryptoStream cs = new CryptoStream(ms, 
				alg.CreateEncryptor(), CryptoStreamMode.Write); 

			// Write the data and make it do the Encriptarion 
			cs.Write(clearData, 0, clearData.Length); 

			// Close the crypto stream (or do FlushFinalBlock). 
			// This will tell it that we have done our Encriptarion and
			// there is no more data coming in, 
			// and it is now a good time to apply the padding and
			// finalize the Encriptarion process. 
			cs.Close(); 

			// Now get the Encriptared data from the MemoryStream.
			// Some people make a mistake of using GetBuffer() here,
			// which is not the right way. 
			byte[] EncriptaredData = ms.ToArray();

			return EncriptaredData; 
		} 

		// Encripta string into a string using a password 
		//    Uses Encriptar(byte[], byte[], byte[]) 
/// <summary>
/// Encripta una cadena recibiendo la clave.
/// </summary>
/// <param name="TextoPlano">texto a encriptar</param>
/// <param name="Password">llave de encripcion</param>
/// <returns>retorna el texto encriptado</returns>
		public string Encriptar(string TextoPlano, string Password) 
		{ 
			//Primero convertimos el string a un arreglo de bytes. 
			byte[] BytesPlano =	System.Text.Encoding.Unicode.GetBytes(TextoPlano); 
			// Luego, luego insertamos el password en una llave/IV 
			// tratando de adivinar todas las posibiliades para el password
			PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 

			// Ahora tomamos la llave/IV y encriptamos con la funcion que acepta
			//arreglos de bytes usando una llave de 32 bytes como clave
			// (por defecto la longitud de una llave Rijndael es 256bit = 32bytes)
			// y entonces de 16 bytes para IV. 
			// IV puede algunas siempre trabajar con los bloque spor defecto.
			// 16 bytes (128 bit) para Rijndael. 
			// Si tu estas usando DES/TripleDES/RC2 el tamñao el bloque es 8 bytes y tambien se puede usar
			//para IV 
			byte[] textoEncriptado = Encriptar(BytesPlano,pdb.GetBytes(32), pdb.GetBytes(16)); 

			// Ahora necesitamos retornar el tezto encriptado como un string
			// un error comun es usar una clase encoding paa esto.
			//no funciona por que no todos los valores de bytes pueden ser reprensentados por caracteres.
			// Usaremos Base64 encoding que fue diseñado exavtamente para lo que queremos hacer.
			return Convert.ToBase64String(textoEncriptado); 

		}
    
		/// <summary>
/// Encripta una arreglo de bytes.
/// </summary>
/// <param name="clearData">exo plano en forma de bytes</param>
/// <param name="Password">llave de encripcion</param>
/// <returns>retorna el texto encriptado como una arreglo de bytes</returns>
		public byte[] Encriptar(byte[] clearData, string Password) 
		{ 
			PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 
			return Encriptar(clearData, pdb.GetBytes(32), pdb.GetBytes(16)); 
		}

		/// <summary>
		/// Encripta un archivo en otro archivo usando clave
		/// </summary>
		/// <param name="fileIn">Archivo Plano</param>
		/// <param name="fileOut">nombre de archivo resultante</param>
		/// <param name="Password">llave de encripcion</param>
		public void Encriptar(string fileIn,string fileOut, string Password) 
		{ 

			// Primero abrimos los archivos.
			FileStream fsIn = new FileStream(fileIn, 
			FileMode.Open, FileAccess.Read); 
			FileStream fsOut = new FileStream(fileOut, 
			FileMode.OpenOrCreate, FileAccess.Write); 

			//generamos la clave de IV
			PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 

			Rijndael alg = Rijndael.Create(); 
			alg.Key = pdb.GetBytes(32); 
			alg.IV = pdb.GetBytes(16); 

			// Ahora creamos un stream con el cual vamos a encriptar.
			// nuestro archivo de salida. 
			CryptoStream cs = new CryptoStream(fsOut, 
				alg.CreateEncryptor(), CryptoStreamMode.Write); 

			// Now podremos inicializar el bufer y continuar procesando
			// el archivo de entrada en bloques. 
			int bufferLen = 4096; 
			byte[] buffer = new byte[bufferLen]; 
			int bytesRead; 

			do 
			{ 
				// Leemos un bloque de datos del archivo de inicio
				bytesRead = fsIn.Read(buffer, 0, bufferLen); 
				// lo encriptamos 
				cs.Write(buffer, 0, bytesRead); 
				//lo esribimos
			} while(bytesRead != 0); 

			// Cerramos todo
			cs.Close(); 
			fsIn.Close();     
		} 

		// Encriptar a byte array into a byte array using a key and an IV 
		public byte[] DesEncriptar(byte[] cipherData,byte[] Key, byte[] IV) 
		{ 
			// Create a MemoryStream that is going to accept the
			// decrypted bytes 
			MemoryStream ms = new MemoryStream(); 

			// Create a symmetric algorithm. 
			// We are going to use Rijndael because it is strong and
			// available on all platforms. 
			// You can use other algorithms, to do so substitute the next
			// line with something like 
			//     TripleDES alg = TripleDES.Create(); 
			Rijndael alg = Rijndael.Create(); 

			// Now set the key and the IV. 
			// We need the IV (Initialization Vector) because the algorithm
			// is operating in its default 
			// mode called CBC (Cipher Block Chaining). The IV is XORed with
			// the first block (8 byte) 
			// of the data after it is decrypted, and then each decrypted
			// block is XORed with the previous 
			// cipher block. This is done to make encryption more secure. 
			// There is also a mode called ECB which does not need an IV,
			// but it is much less secure. 
			alg.Key = Key; 
			alg.IV = IV; 

			// Create a CryptoStream through which we are going to be
			// pumping our data. 
			// CryptoStreamMode.Write means that we are going to be
			// writing data to the stream 
			// and the output will be written in the MemoryStream
			// we have provided. 
			CryptoStream cs = new CryptoStream(ms, 
				alg.CreateDecryptor(), CryptoStreamMode.Write); 

			// Write the data and make it do the decryption 
			cs.Write(cipherData, 0, cipherData.Length); 

			// Close the crypto stream (or do FlushFinalBlock). 
			// This will tell it that we have done our decryption
			// and there is no more data coming in, 
			// and it is now a good time to remove the padding
			// and finalize the decryption process. 
			cs.Close(); 

			// Now get the decrypted data from the MemoryStream. 
			// Some people make a mistake of using GetBuffer() here,
			// which is not the right way. 
			byte[] decryptedData = ms.ToArray(); 

			return decryptedData; 
		}

		// Decrypt a string into a string using a password 
		//    Uses Decrypt(byte[], byte[], byte[]) 

		public string DesEncriptar(string cipherText, string Password) 
		{ 
			// First we need to turn the input string into a byte array. 
			// We presume that Base64 encoding was used 
			byte[] cipherBytes = Convert.FromBase64String(cipherText); 

			// Then, we need to turn the password into Key and IV 
			// We are using salt to make it harder to guess our key
			// using a dictionary attack - 
			// trying to guess a password by enumerating all possible words. 
			PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
							   0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 

			// Now get the key/IV and do the decryption using
			// the function that accepts byte arrays. 
			// Using PasswordDeriveBytes object we are first
			// getting 32 bytes for the Key 
			// (the default Rijndael key length is 256bit = 32bytes)
			// and then 16 bytes for the IV. 
			// IV should always be the block size, which is by
			// default 16 bytes (128 bit) for Rijndael. 
			// If you are using DES/TripleDES/RC2 the block size is
			// 8 bytes and so should be the IV size. 
			// You can also read KeySize/BlockSize properties off
			// the algorithm to find out the sizes. 
			byte[] decryptedData = DesEncriptar(cipherBytes, 
				pdb.GetBytes(32), pdb.GetBytes(16)); 

			// Now we need to turn the resulting byte array into a string. 
			// A common mistake would be to use an Encoding class for that.
			// It does not work 
			// because not all byte values can be represented by characters. 
			// We are going to be using Base64 encoding that is 
			// designed exactly for what we are trying to do. 
			return System.Text.Encoding.Unicode.GetString(decryptedData); 
		}

/// <summary>
/// Desencripta bytes usando un assword
/// </summary>
/// <param name="cipherData"></param>
/// <param name="Password"></param>
/// <returns></returns>
		public  byte[] DesEncriptar(byte[] cipherData, string Password) 
		{ 
			// We need to turn the password into Key and IV. 
			// We are using salt to make it harder to guess our key
			// using a dictionary attack - 
			// trying to guess a password by enumerating all possible words. 
			PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 

			// Now get the key/IV and do the Decryption using the 
			//function that accepts byte arrays. 
			// Using PasswordDeriveBytes object we are first getting
			// 32 bytes for the Key 
			// (the default Rijndael key length is 256bit = 32bytes)
			// and then 16 bytes for the IV. 
			// IV should always be the block size, which is by default
			// 16 bytes (128 bit) for Rijndael. 
			// If you are using DES/TripleDES/RC2 the block size is
			// 8 bytes and so should be the IV size. 

			// You can also read KeySize/BlockSize properties off the
			// algorithm to find out the sizes. 
			return DesEncriptar(cipherData, pdb.GetBytes(32), pdb.GetBytes(16)); 
		}


		/// <summary>
		///Decrypt a file into another file using a password  
		/// </summary>
		/// <param name="fileIn"></param>
		/// <param name="fileOut"></param>
		/// <param name="Password"></param>
		public  void DesEncriptar(string fileIn,string fileOut, string Password) 
		{ 

			// First we are going to open the file streams 
			FileStream fsIn = new FileStream(fileIn,
				FileMode.Open, FileAccess.Read); 
			FileStream fsOut = new FileStream(fileOut,
				FileMode.OpenOrCreate, FileAccess.Write); 

			// Then we are going to derive a Key and an IV from
			// the Password and create an algorithm 
			PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 
			Rijndael alg = Rijndael.Create(); 

			alg.Key = pdb.GetBytes(32); 
			alg.IV = pdb.GetBytes(16); 

			// Now create a crypto stream through which we are going
			// to be pumping data. 
			// Our fileOut is going to be receiving the Decrypted bytes. 
			CryptoStream cs = new CryptoStream(fsOut, 
				alg.CreateDecryptor(), CryptoStreamMode.Write); 

			// Now will will initialize a buffer and will be 
			// processing the input file in chunks. 
			// This is done to avoid reading the whole file (which can be
			// huge) into memory. 
			int bufferLen = 4096; 
			byte[] buffer = new byte[bufferLen]; 
			int bytesRead; 

			do 
			{ 
				// read a chunk of data from the input file 
				bytesRead = fsIn.Read(buffer, 0, bufferLen); 

				// Decrypt it 
				cs.Write(buffer, 0, bytesRead); 

			} while(bytesRead != 0); 

			// close everything 
			cs.Close(); // this will also close the unrelying fsOut stream 
			fsIn.Close();     
		}	
	}

}

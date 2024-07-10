
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace SPXSeguridad.Cryptografia
{
public class RijndaelSimple
{
    public string Encryptar(string textoPlano)
    {

        string passwordCifrado = "Pas5pr@se";        // puede ser cualquier string
        string saltValue = "s@1tValue";        // puede ser cualquier string
        string hashAlgorithm = "SHA1";             // puede ser "MD5"
        int passwordIteraciones = 2;                  // Numero de Iteraciones
        string vectorInicial = "@1B2c3D4e5F6g7H8"; // debe ser de 16 bytes
        int keySize = 256;                // tambien puede set 192 o 128


        string cifrado = RijndaelSimple.Encryptar(textoPlano,
                                                    passwordCifrado,
                                                    saltValue,
                                                    hashAlgorithm,
                                                    passwordIteraciones,
                                                    vectorInicial,
                                                    keySize);
        return cifrado;
    }

    public string desEncriptar(string textoCifrado)
    {

        string passwordCifrado = "Pas5pr@se";        // puede ser cualquier string
        string saltValue = "s@1tValue";        // puede ser cualquier string
        string hashAlgorithm = "SHA1";             // puede ser "MD5"
        int passwordIteraciones = 2;                  // Numero de Iteraciones
        string vectorInicial = "@1B2c3D4e5F6g7H8"; // debe ser de 16 bytes
        int keySize = 256;                // tambien puede set 192 o 128


        string descifrado = RijndaelSimple.Desencriptar(textoCifrado,
                                                    passwordCifrado,
                                                    saltValue,
                                                    hashAlgorithm,
                                                    passwordIteraciones,
                                                    vectorInicial,
                                                    keySize);
        return descifrado;
    }

    public static string Encryptar(string textoPlano,
                                 string passwordCifrado,
                                 string saltValue,
                                 string hashAlgorithm,
                                 int passwordIteraciones,
                                 string vectorInicial,
                                 int keySize)
    {
        // Convert strings into byte arrays.
        // Let us assume that strings only contain ASCII codes.
        // If strings include Unicode characters, use Unicode, UTF7, or UTF8 
        // encoding.
        byte[] vectorInicialBytes = Encoding.ASCII.GetBytes(vectorInicial);
        byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

        // Convert our textoPlano into a byte array.
        // Let us assume that textoPlano contains UTF8-encoded characters.
        byte[] textoPlanoBytes = Encoding.UTF8.GetBytes(textoPlano);

        // First, we must create a password, from which the key will be derived.
        // This password will be generated from the specified passwordCifrado and 
        // salt value. The password will be created using the specified hash 
        // algorithm. Password creation can be done in several iterations.
        PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                        passwordCifrado,
                                                        saltValueBytes,
                                                        hashAlgorithm,
                                                        passwordIteraciones);

        // Use the password to generate pseudo-random bytes for the encryption
        // key. Specify the size of the key in bytes (instead of bits).
        byte[] keyBytes = password.GetBytes(keySize / 8);

        // Create uninitialized Rijndael encryption object.
        RijndaelManaged symmetricKey = new RijndaelManaged();

        // It is reasonable to set encryption mode to Cipher Block Chaining
        // (CBC). Use default options for other symmetric key parameters.
        symmetricKey.Mode = CipherMode.CBC;

        // Generate encryptor from the existing key bytes and initialization 
        // vector. Key size will be defined based on the number of the key 
        // bytes.
        ICryptoTransform encryptor = symmetricKey.CreateEncryptor(
                                                         keyBytes,
                                                         vectorInicialBytes);

        // Define memory stream which will be used to hold encrypted data.
        MemoryStream memoryStream = new MemoryStream();

        // Define cryptographic stream (always use Write mode for encryption).
        CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                     encryptor,
                                                     CryptoStreamMode.Write);
        // Start encrypting.
        cryptoStream.Write(textoPlanoBytes, 0, textoPlanoBytes.Length);

        // Finish encrypting.
        cryptoStream.FlushFinalBlock();

        // Convert our encrypted data from a memory stream into a byte array.
        byte[] textoCifradoBytes = memoryStream.ToArray();

        // Close both streams.
        memoryStream.Close();
        cryptoStream.Close();

        // Convert encrypted data into a base64-encoded string.
        string textoCifrado = Convert.ToBase64String(textoCifradoBytes);

        // Return encrypted string.
        return textoCifrado;
    }



    public static string Desencriptar(string textoCifrado,
                                 string passwordCifrado,
                                 string saltValue,
                                 string hashAlgorithm,
                                 int passwordIteraciones,
                                 string vectorInicial,
                                 int keySize)
    {
        // Convert strings defining encryption key characteristics into byte
        // arrays. Let us assume that strings only contain ASCII codes.
        // If strings include Unicode characters, use Unicode, UTF7, or UTF8
        // encoding.
        byte[] vectorInicialBytes = Encoding.ASCII.GetBytes(vectorInicial);
        byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

        // Convert our textoCifrado into a byte array.
        byte[] textoCifradoBytes = Convert.FromBase64String(textoCifrado);

        // First, we must create a password, from which the key will be 
        // derived. This password will be generated from the specified 
        // passwordCifrado and salt value. The password will be created using
        // the specified hash algorithm. Password creation can be done in
        // several iterations.
        PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                        passwordCifrado,
                                                        saltValueBytes,
                                                        hashAlgorithm,
                                                        passwordIteraciones);

        // Use the password to generate pseudo-random bytes for the encryption
        // key. Specify the size of the key in bytes (instead of bits).
        byte[] keyBytes = password.GetBytes(keySize / 8);

        // Create uninitialized Rijndael encryption object.
        RijndaelManaged symmetricKey = new RijndaelManaged();

        // It is reasonable to set encryption mode to Cipher Block Chaining
        // (CBC). Use default options for other symmetric key parameters.
        symmetricKey.Mode = CipherMode.CBC;

        // Generate decryptor from the existing key bytes and initialization 
        // vector. Key size will be defined based on the number of the key 
        // bytes.
        ICryptoTransform decryptor = symmetricKey.CreateDecryptor(
                                                         keyBytes,
                                                         vectorInicialBytes);

        // Define memory stream which will be used to hold encrypted data.
        MemoryStream memoryStream = new MemoryStream(textoCifradoBytes);

        // Define cryptographic stream (always use Read mode for encryption).
        CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                      decryptor,
                                                      CryptoStreamMode.Read);

        // Since at this point we don't know what the size of decrypted data
        // will be, allocate the buffer long enough to hold textoCifrado;
        // textoPlano is never longer than textoCifrado.
        byte[] textoPlanoBytes = new byte[textoCifradoBytes.Length];

        // Start decrypting.
        int decryptedByteCount = cryptoStream.Read(textoPlanoBytes,
                                                   0,
                                                   textoPlanoBytes.Length);

        // Close both streams.
        memoryStream.Close();
        cryptoStream.Close();

        // Convert decrypted data into a string. 
        // Let us assume that the original textoPlano string was UTF8-encoded.
        string textoPlano = Encoding.UTF8.GetString(textoPlanoBytes,
                                                   0,
                                                   decryptedByteCount);

        // Return decrypted string.   
        return textoPlano;
    }
}

}
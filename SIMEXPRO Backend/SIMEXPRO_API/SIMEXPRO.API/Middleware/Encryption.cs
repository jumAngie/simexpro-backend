using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace SIMEXPRO.API.Extensions
{
    public class Encryption
    {
        public static byte[] Encrypt(string simpletext, byte[] key)
        {
            byte[] iv = Encoding.ASCII.GetBytes("H4OKcUvUfkXV5OZ4");

            //using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            //{
            //    rng.GetBytes(iv);
            //}

            byte[] cipheredtext;
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform encryptor = aes.CreateEncryptor(key, iv);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(simpletext);
                        }

                        cipheredtext = memoryStream.ToArray();
                    }
                }
            }
            return cipheredtext;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayerBook
{
    public class clsUtility
    {
        public static string Encrypt(string plainText, int shift=3)
        {
            char[] buffer = plainText.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char ch = buffer[i];

                // إذا كان حرفًا أو رقمًا، نقوم بتحريكه
                if (char.IsLetterOrDigit(ch))
                {
                    buffer[i] = (char)(ch + shift);

                    // التأكد من عدم الخروج عن حدود ASCII
                    if (char.IsUpper(ch) && buffer[i] > 'Z') buffer[i] -= (char)26;
                    if (char.IsLower(ch) && buffer[i] > 'z') buffer[i] -= (char)26;
                    if (char.IsDigit(ch) && buffer[i] > '9') buffer[i] -= (char)10;
                }
            }
            return new string(buffer);
        }

        public static string Decrypt(string cipherText, int shift=3)
        {
            char[] buffer = cipherText.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char ch = buffer[i];

                // إذا كان حرفًا أو رقمًا، نقوم بتحريكه عكسيًا
                if (char.IsLetterOrDigit(ch))
                {
                    buffer[i] = (char)(ch - shift);

                    // التأكد من عدم الخروج عن حدود ASCII
                    if (char.IsUpper(ch) && buffer[i] < 'A') buffer[i] += (char)26;
                    if (char.IsLower(ch) && buffer[i] < 'a') buffer[i] += (char)26;
                    if (char.IsDigit(ch) && buffer[i] < '0') buffer[i] += (char)10;
                }
            }
            return new string(buffer);
        }
        static public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
   

  
    }

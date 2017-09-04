using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace LibFTPServ
{
    internal static class HelperFunctions
    {
        public static string FixPath(string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("/");
            string[] p = path.Split('/');
            for (int i = 0; i < p.Length; i++)
            {
                if (!string.IsNullOrEmpty(p[i]))
                {
                    sb.Append(p[i]);
                    if (i != p.Length - 1) sb.Append("/");
                }
            }
            return sb.ToString();

        }

        public static string SHA1Hash(string source)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] data = Encoding.UTF8.GetBytes(source);
            byte[] hash = sha1.ComputeHash(data);
            StringBuilder sb = new StringBuilder(50);
            for (int i = 0; i < hash.Length; i++) sb.Append(hash[i].ToString("x2").ToLower());
            return sb.ToString(); ;
        }

        public static string GenerateUniqueFileName()
        {
            RNGCryptoServiceProvider rgn = new RNGCryptoServiceProvider();
            byte[] data = new byte[16];
            rgn.GetBytes(data);
            Guid name = new Guid(data);
            return name.ToString();
        }
    }
}

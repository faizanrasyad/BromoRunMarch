using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlineDesktop.Utils
{
    public class Enkripsi
    {
        public static string encrypt (string pass)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding ();
                byte[] data = md5.ComputeHash(uTF8.GetBytes(pass));
                return Convert.ToBase64String(data);
            }
        }
    }
}

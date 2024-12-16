using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlineDesktop.Utils
{
    public class GeneratorID
    {
        public static string generateRandom(int len) 
        {
            string temp = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
            string result = "";
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = rand.Next(temp.Length);
                result += temp[index];
            }
            return result;
        }

        public static string generateId(string template)
        {
            return template + "-" + generateRandom(4);
        }

        public static string generateKodePenerbangan(string template)
        {
            string temp = "1234567890";
            var resultTemp = "";
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(temp.Length);
                resultTemp += temp[index];
            }
            return template + "-" + resultTemp;
        }
    }
}

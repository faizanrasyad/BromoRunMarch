using BromoAirlineDesktop.Model;
using BromoAirlineDesktop.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlineDesktop.Data
{
    public class Repo
    {
        public static BromoAirlineEntities entity = new BromoAirlineEntities();
        public static Akun logged = null;

        public static void login(string username, string pass)
        {
            var pazz = Enkripsi.encrypt(pass);
            Debug.Print(pazz);
            logged = entity.Akuns.Where(r => r.username.Equals(username) && r.password.Equals(pass)).FirstOrDefault();
        }

        public static void logout()
        {
            logged = null;
        }
    }
}

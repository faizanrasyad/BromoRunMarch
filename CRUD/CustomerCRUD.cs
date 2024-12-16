using BromoAirlineDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlineDesktop.CRUD
{
    public class CustomerCRUD
    {
        public static Bandara bandaraAsal = null;
        public static Bandara bandaraTujuan = null;
        public static Maskapai maskapai = null; 
        public static DateTime tanggalLiburan = DateTime.Now;
        public static int jumlahPenumpang = -1;
        public static JadwalPenerbangan jadwalPenerbangan = null;   

    }
}

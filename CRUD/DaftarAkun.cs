using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Model;
using BromoAirlineDesktop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlineDesktop.CRUD
{
    public class DaftarAkun
    {
        public static void add(string username, string nama, string pass, DateTime tanggalLahir, string telp)
        {
            var model = new Akun
            {
                username = username,
                password = Enkripsi.encrypt(pass),
                tanggalLahir = tanggalLahir,
                nomorTelepon = telp,
                nama = nama
            };

            if (Konfirmasi.confirm())
            {
                Repo.entity.Akuns.Add(model);
                Repo.entity.SaveChanges();
            }
        }
    }
}

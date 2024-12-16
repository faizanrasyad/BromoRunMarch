using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Model;
using BromoAirlineDesktop.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlineDesktop.CRUD
{
    public class MaskapaiCRUD
    {
        public static Maskapai selMaskapai = null;

        public static void add(string nama, string perusahaan, int jumlahKru, string deskripsi)
        {
            var model = new Maskapai
            {
                nama = nama,
                perusahaan = perusahaan,
                jumlahKru = jumlahKru,  
                deskripsi = deskripsi
            };
            if (Konfirmasi.confirm())
            {
                Repo.entity.Maskapais.Add(model);
                Repo.entity.SaveChanges();
            }
        }

        public static void edit(Maskapai newModel)
        {
            Maskapai model = Repo.entity.Maskapais.Find(newModel.id);

            model.id = newModel.id;
            model.nama = newModel.nama;
            model.perusahaan = newModel.perusahaan;
            model.jumlahKru = newModel.jumlahKru;
            model.deskripsi = newModel.deskripsi;   

            if (Konfirmasi.confirm())
            {
                Repo.entity.SaveChanges();
            }
        }

        public static void delete()
        {
            var model = Repo.entity.Maskapais.Find(selMaskapai.id);

            if (Konfirmasi.confirm())
            {
                Repo.entity.Maskapais.Remove(model);
                Repo.entity.SaveChanges();
            }
        }

        public static void ekspor(DataTable dt)
        {
            Export.ekspor("Maskapai", dt);
        }
    }
}

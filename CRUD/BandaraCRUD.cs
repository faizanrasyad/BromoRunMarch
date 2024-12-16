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
    public class BandaraCRUD
    {
        public static Bandara selBandara = null;

        public static void add(string nama, string kodeIATA, string kota, int negara, int jumlahTerminal, string alamat)
        {
            var model = new Bandara
            {
                nama = nama,
                kodeIATA = kodeIATA,
                kota = kota,
                alamat = alamat,
                jumlahTerminal = jumlahTerminal,
                negaraID = negara,
            };
            if (Konfirmasi.confirm())
            {
                Repo.entity.Bandaras.Add(model);
                Repo.entity.SaveChanges();
            }
        }

        public static void edit(Bandara newModel)
        {
            Bandara model = Repo.entity.Bandaras.Find(newModel.id);

            model.id = newModel.id;
            model.nama = newModel.nama;
            model.kota = newModel.kota;
            model.kodeIATA = newModel.kodeIATA;
            model.alamat = newModel.alamat; 
            model.jumlahTerminal = newModel.jumlahTerminal; 
            model.negaraID = newModel.negaraID;

            if (Konfirmasi.confirm())
            {
                Repo.entity.SaveChanges();
            }
        }

        public static void delete()
        {
            var model = Repo.entity.Bandaras.Find(selBandara.id);

            if (Konfirmasi.confirm())
            {
                Repo.entity.Bandaras.Remove(model);
                Repo.entity.SaveChanges();  
            }
        }

        public static void ekspor(DataTable dt)
        {
            Export.ekspor("Bandara", dt);
        }
    }
}

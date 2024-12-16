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
    public class PromoCRUD
    {
        public static KodePromo selPromo = null;

        public static void add(string kode, float presentaseDiskon, float maksimumDiskon, DateTime berlakuSampai, string deskripsi)
        {
            var model = new KodePromo
            {
                kode = kode.ToUpper(),
                presentaseDiskon = presentaseDiskon,
                maksimumDiskon = maksimumDiskon,
                berlakuSampai = berlakuSampai,
                deskripsi = deskripsi
            };
            if (Konfirmasi.confirm())
            {
                Repo.entity.KodePromoes.Add(model);
                Repo.entity.SaveChanges();
            }
        }

        public static void edit(KodePromo newModel)
        {
            KodePromo model = Repo.entity.KodePromoes.Find(newModel.id);

            model.id = newModel.id;
            model.kode = newModel.kode.ToUpper();
            model.presentaseDiskon = newModel.presentaseDiskon; 
            model.maksimumDiskon=newModel.maksimumDiskon;
            model.berlakuSampai = newModel.berlakuSampai;
            model.deskripsi = newModel.deskripsi;

            if (Konfirmasi.confirm())
            {
                Repo.entity.SaveChanges();
            }
        }

        public static void delete()
        {
            var model = Repo.entity.KodePromoes.Find(selPromo.id);

            if (Konfirmasi.confirm())
            {
                Repo.entity.KodePromoes.Remove(model);
                Repo.entity.SaveChanges();
            }
        }

        public static void ekspor(DataTable dt)
        {
            Export.ekspor("Kode Promo", dt);
        }
    }
}

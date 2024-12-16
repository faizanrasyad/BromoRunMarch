using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Model;
using BromoAirlineDesktop.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlineDesktop.CRUD
{
    public class JadwalPenerbanganCRUD
    {
        public static JadwalPenerbangan selJadwal = null;

        public static void add(string kodePenerbangan, int bandaraKeberangkatan, int bandaraTujuan, int maskapai, DateTime waktuKeberangkatan, string waktu, int durasi, float harga)
        {
            var resultWaktu = waktuKeberangkatan.ToString("yyyy-MM-dd");
            Debug.Print("Result Waktu 1st Checkpoint " + resultWaktu);
            resultWaktu += " " + waktu + ":00";
            Debug.Print("Result Waktu 2nd Checkpoint " + resultWaktu);
            Debug.Print("Result Waktu 3rd Checkpoint " + Convert.ToDateTime(resultWaktu));

            var model = new JadwalPenerbangan
            {
                kodePenerbangan = kodePenerbangan,
                bandaraKeberangkatanID = bandaraKeberangkatan,
                bandaraTujuanID = bandaraTujuan,
                maskapaiID = maskapai,
                tanggalWaktuKeberangkatan = Convert.ToDateTime(resultWaktu),
                durasiPenerbangan = durasi,
                hargaPerTiket = harga,
            };

            if (Konfirmasi.confirm())
            {
                Repo.entity.JadwalPenerbangans.Add(model);
                Repo.entity.SaveChanges();
            }

            var modelStatus = new PerubahanStatusJadwalPenerbangan
            {
                jadwalPenerbanganID = model.id,
                statusPenerbanganID = 1,
                waktuPerubahanTerjadi = DateTime.Now,
            };

            Repo.entity.PerubahanStatusJadwalPenerbangans.Add(modelStatus);
            Repo.entity.SaveChanges();
        }

        public static void edit(JadwalPenerbangan newModel, string waktu)
        {
            var resultWaktu = newModel.tanggalWaktuKeberangkatan.ToString("yyyy-MM-dd");
            resultWaktu += " " + waktu + ":00";

            JadwalPenerbangan model = Repo.entity.JadwalPenerbangans.Find(newModel.id);

            model.id = newModel.id;
            model.kodePenerbangan = newModel.kodePenerbangan;
            model.bandaraKeberangkatanID = newModel.bandaraKeberangkatanID;
            model.bandaraTujuanID = newModel.bandaraTujuanID;
            model.maskapaiID = newModel.maskapaiID;
            model.tanggalWaktuKeberangkatan = Convert.ToDateTime(resultWaktu);
            model.durasiPenerbangan = newModel.durasiPenerbangan;
            model.hargaPerTiket = newModel.hargaPerTiket;

            if (Konfirmasi.confirm())
            {
                Repo.entity.SaveChanges();
            }
        }

        public static void delete()
        {
            var model = Repo.entity.JadwalPenerbangans.Find(selJadwal.id);

            if (Konfirmasi.confirm())
            {
                Repo.entity.JadwalPenerbangans.Remove(model);
                Repo.entity.SaveChanges();
            }
        }

        public static void ekspor(DataTable dt)
        {
            Export.ekspor("Jadwal Penerbangan", dt);
        }
    }
}

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
    public class StatusPenerbanganCRUD
    {
        public static PerubahanStatusJadwalPenerbangan selRubahStatus = null;

        public static void updateStatus(PerubahanStatusJadwalPenerbangan newModel)
        {
            Debug.Print("ID Perubahan Status Selected : " + selRubahStatus.statusPenerbanganID.ToString());
            PerubahanStatusJadwalPenerbangan model = Repo.entity.PerubahanStatusJadwalPenerbangans.Find(selRubahStatus.id);
            Debug.Print("Status Penerbangan : " + model.statusPenerbanganID.ToString());
            model.statusPenerbanganID = newModel.statusPenerbanganID;
            model.perkiraanDurasiDelay = newModel.perkiraanDurasiDelay;

            if (Konfirmasi.confirm())
            {
                Repo.entity.SaveChanges();
            }
        }
    }
}

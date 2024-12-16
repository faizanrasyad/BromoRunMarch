using BromoAirlineDesktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlineDesktop
{
    public partial class TiketSayaForm : Form
    {
        public TiketSayaForm()
        {
            InitializeComponent();
        }

        private void TiketSayaForm_Load(object sender, EventArgs e)
        {

        }

        void fillDGV()
        {
            this.jadwalPenerbanganTableAdapter.Fill(this.bromoAirlineDataSet.JadwalPenerbangan);
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var modelBandaraAsal = Repo.entity.Bandaras.Find(row.Cells["bandaraKeberangkatanID"].Value);
                var modelBandaraTujuan = Repo.entity.Bandaras.Find(row.Cells["bandaraTujuanID"].Value);
                var modelMaskapai = Repo.entity.Maskapais.Find(row.Cells["maskapaiID"].Value);
                var modelStatus = Repo.entity.StatusPenerbangans.ToList();
                var modelPerubahan = Repo.entity.PerubahanStatusJadwalPenerbangans.ToList();
                cm.SuspendBinding();
                row.Cells["bandaraAsal"].Value = modelBandaraAsal.nama;
                row.Cells["bandaraTujuan"].Value = modelBandaraTujuan.nama;
                row.Cells["maskapai"].Value = modelMaskapai.nama;
                row.Cells["statusTerakhir"].Value = modelStatus.Where(status => status.id.Equals(modelPerubahan.Where(r => r.jadwalPenerbanganID.Equals(row.Cells["id"].Value)).FirstOrDefault().statusPenerbanganID)).FirstOrDefault().nama;
                cm.ResumeBinding();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainFormCustomer cust = new MainFormCustomer();
            this.Close();
            cust.Show();
        }
    }
}

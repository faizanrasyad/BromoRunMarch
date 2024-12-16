using BromoAirlineDesktop.CRUD;
using BromoAirlineDesktop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlineDesktop
{
    public partial class PenerbanganForm : Form
    {
        public PenerbanganForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainFormCustomer cust = new MainFormCustomer();
            this.Close();
            cust.Show();
        }

        void setupAwal()
        {
            lbBandaraAsal.Text = CustomerCRUD.bandaraAsal.nama + " ("+CustomerCRUD.bandaraAsal.kodeIATA + ")";
            lbBandaraTujuan.Text = CustomerCRUD.bandaraTujuan.nama + " ("+CustomerCRUD.bandaraTujuan.kodeIATA + ")";
            lbPenumpang.Text = CustomerCRUD.jumlahPenumpang + " Penumpang";
            var hari = CustomerCRUD.tanggalLiburan.DayOfWeek;
            var tanggal = CustomerCRUD.tanggalLiburan.Day;
            var bulan = CustomerCRUD.tanggalLiburan.ToString("MMM");
            var tahun = CustomerCRUD.tanggalLiburan.Year;
            lbTanggal.Text = hari + ", " + tanggal + " " + bulan + " " + tahun;

            fillDGV();
        }

        private void PenerbanganForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoAirlineDataSet.JadwalPenerbangan' table. You can move, or remove it, as needed.
            
            setupAwal();
        }

        void fillDGV()
        {
            this.jadwalPenerbanganTableAdapter.Fill(this.bromoAirlineDataSet.JadwalPenerbangan);
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                var bandaraAsal = row.Cells["bandaraKeberangkatanID"].Value;
                var bandaraTujuan = row.Cells["bandaraTujuanID"].Value;
                var tanggal = row.Cells["tanggalWaktuKeberangkatan"].Value;
                Debug.Print("Bandara Asal Model : " + bandaraAsal);
                Debug.Print("Bandara Asal CustomerCRUD : " + CustomerCRUD.bandaraAsal.id);
                cm.SuspendBinding();
                if (
                    Convert.ToInt32(bandaraAsal) != CustomerCRUD.bandaraAsal.id &&
                    Convert.ToInt32(bandaraTujuan) != CustomerCRUD.bandaraTujuan.id &&
                    Convert.ToDateTime(tanggal) != CustomerCRUD.tanggalLiburan)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }

                var modelBandaraAsal = Repo.entity.Bandaras.Find(row.Cells["bandaraKeberangkatanID"].Value);
                var modelBandaraTujuan = Repo.entity.Bandaras.Find(row.Cells["bandaraTujuanID"].Value);
                var modelMaskapai = Repo.entity.Maskapais.Find(row.Cells["maskapaiID"].Value);
                var tanggalPenerbangan = Convert.ToDateTime( row.Cells["tanggalWaktuKeberangkatan"].Value );
                var durasiPenerbangan = row.Cells["durasiPenerbangan"].Value;
                var waktuPenerbangan = tanggalPenerbangan.ToString("HH:mm");

                row.Cells["bandaraAsal"].Value = modelBandaraAsal.nama;
                row.Cells["bandaraTujuan"].Value = modelBandaraTujuan.nama;
                row.Cells["maskapai"].Value = modelMaskapai.nama;
                row.Cells["tanggalPenerbangan"].Value = tanggalPenerbangan.ToString("dd-MM-yyyy");
                row.Cells["waktuPenerbangan"].Value = waktuPenerbangan + " - " + durasiPenerbangan + " menit";
                cm.ResumeBinding();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "beliTiket")
            {
                var maskapaiID = dataGridView1.Rows[e.RowIndex].Cells["maskapaiID"].Value;
                var idJadwal = dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Debug.Print("Maskapai ID : " + maskapaiID);
                Debug.Print("Tipe Maskapai ID : " + maskapaiID.GetType());
                Debug.Print("ID Jadwal : " + idJadwal);
                Debug.Print("Tipe ID Jadwal : " + idJadwal.GetType());
                CustomerCRUD.maskapai = Repo.entity.Maskapais.Find(maskapaiID);
                CustomerCRUD.jadwalPenerbangan = Repo.entity.JadwalPenerbangans.Find(idJadwal);

                BeliTiketForm beli = new BeliTiketForm();
                this.Hide();
                beli.Show();
            }
        }

        #region filter & sort
        //Button Terapkan Filter
        private void button1_Click(object sender, EventArgs e)
        {
            if(cbUrutkan.Text == "Harga Terendah")
            {
                dataGridView1.Sort(dataGridView1.Columns["hargaPerTiket"], ListSortDirection.Ascending);
            }

            if(cbUrutkan.Text == "Durasi Tercepat")
            {
                dataGridView1.Sort(dataGridView1.Columns["durasiPenerbangan"], ListSortDirection.Ascending);
            }

            if(cbUrutkan.Text == "Keberangkatan Paling Awal")
            {
                dataGridView1.Sort(dataGridView1.Columns["tanggalWaktuKeberangkatan"], ListSortDirection.Ascending);
            }

            if (cbUrutkan.Text == "Keberangkatan Paling Akhir")
            {
                dataGridView1.Sort(dataGridView1.Columns["tanggalWaktuKeberangkatan"], ListSortDirection.Descending);
            }

            fillDGV();

            #region checkBox
            if (check1.Checked == true)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cm.SuspendBinding();
                    var tanggal = DateTime.Parse(Convert.ToDateTime(row.Cells["tanggalWaktuKeberangkatan"].Value).ToString("HH:mm"));
                    if (tanggal < DateTime.Parse("00:00:00") && tanggal > DateTime.Parse("00:06:00"))
                    {
                        row.Visible = false;
                    }
                }
            }

            if(check2.Checked == true)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cm.SuspendBinding();
                    var tanggal = DateTime.Parse(Convert.ToDateTime(row.Cells["tanggalWaktuKeberangkatan"].Value).ToString("HH:mm"));
                    if (tanggal < DateTime.Parse("00:06:00") && tanggal > DateTime.Parse("00:12:00"))
                    {
                        row.Visible = false;
                    }
                }
            }

            if (check3.Checked == true)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cm.SuspendBinding();
                    var tanggal = DateTime.Parse(Convert.ToDateTime(row.Cells["tanggalWaktuKeberangkatan"].Value).ToString("HH:mm"));
                    if (tanggal < DateTime.Parse("00:12:00") && tanggal > DateTime.Parse("00:18:00"))
                    {
                        row.Visible = false;
                    }
                }
            }

            if (check4.Checked == true)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cm.SuspendBinding();
                    var tanggal = DateTime.Parse(Convert.ToDateTime(row.Cells["tanggalWaktuKeberangkatan"].Value).ToString("HH:mm"));
                    if (tanggal < DateTime.Parse("00:18:00") && tanggal > DateTime.Parse("00:24:00"))
                    {
                        row.Visible = false;
                    }
                }
            }
            fillDGV();
            #endregion
        }
        #endregion
    }
}

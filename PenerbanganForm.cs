using BromoRunMarch.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoRunMarch
{
    public partial class ListPenerbanganForm : Form
    {
        public ListPenerbanganForm()
        {
            InitializeComponent();
        }

        private void ListPenerbanganForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoRunMarchDataSet.JadwalPenerbangan' table. You can move, or remove it, as needed.
            setupView();

        }

        void setupView()
        {
            fillDGV();
            lbBandaraAsal.Text = repoListPenerbangan.bandaraAsal.nama + " (" + repoListPenerbangan.bandaraAsal.kodeIATA + ")";
            lbBandaraTujuan.Text = repoListPenerbangan.bandaraTujuan.nama + " (" + repoListPenerbangan.bandaraTujuan.kodeIATA + ")";
            var tanggal = repoListPenerbangan.tanggal;
            lbTanggal.Text = tanggal.DayOfWeek.ToString().Substring(0, 3) + ", " + tanggal.Day + " " + tanggal.ToString("MMMM") + " " + tanggal.Year;
            lbJumlahPenumpang.Text = repoListPenerbangan.jumlahPenumpang.ToString() + " Penumpang";
        }

        #region filtering
        private void cbUrutkan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            setupFilter();
        }

        private void setupFilter()
        {
            fillDGV();

            #region urutkan
            if (cbUrutkan.Text == "Harga terendah")
            {
                dataGridView1.Sort(dataGridView1.Columns["hargaPerTiket"], ListSortDirection.Ascending);
            }

            if (cbUrutkan.Text == "Keberangkatan paling awal") 
            {
                dataGridView1.Sort(dataGridView1.Columns["tanggalWaktuKeberangkatan"], ListSortDirection.Ascending);
            }

            if (cbUrutkan.Text == "Keberangkatan paling akhir")
            {
                dataGridView1.Sort(dataGridView1.Columns["tanggalWaktuKeberangkatan"], ListSortDirection.Descending);
            }

            if(cbUrutkan.Text == "Kedatangan paling awal")
            {
                dataGridView1.Sort(dataGridView1.Columns["waktuSampai"] , ListSortDirection.Ascending);
            }

            if (cbUrutkan.Text == "Kedatangan paling akhir")
            {
                dataGridView1.Sort(dataGridView1.Columns["waktuSampai"], ListSortDirection.Descending);
            }

            if (cbUrutkan.Text == "Durasi tercepat")
            {
                dataGridView1.Sort(dataGridView1.Columns["durasiPenerbangan"], ListSortDirection.Ascending);
            }
            #endregion

            #region checkBoxes
            if (
                checkBox1.Checked == true ||
                checkBox2.Checked == true ||
                checkBox3.Checked == true ||
                checkBox4.Checked == true)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                cm.SuspendBinding();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = false;
                    var tanggal = DateTime.Parse(Convert.ToDateTime(row.Cells["tanggalWaktuKeberangkatan"].Value).ToString("HH:mm"));

                    if (checkBox1.Checked == true)
                    {
                        if (tanggal > DateTime.Parse("00:00:00") && tanggal < DateTime.Parse("06:00:00"))
                        {
                            row.Visible = true;
                        }
                    }

                    if (checkBox2.Checked == true)
                    {
                        if (tanggal > DateTime.Parse("06:00:00") && tanggal < DateTime.Parse("12:00:00"))
                        {
                            row.Visible = true;
                        }
                    }

                    if (checkBox3.Checked == true)
                    {
                        if (tanggal > DateTime.Parse("12:00:00") && tanggal < DateTime.Parse("18:00:00"))
                        {
                            row.Visible = true;
                        }
                    }

                    if (checkBox4.Checked == true)
                    {
                        if (tanggal > DateTime.Parse("18:00:00") && tanggal < DateTime.Parse("24:00:00"))
                        {
                            row.Visible = true;
                        }
                    }
                }

                cm.ResumeBinding();
            }
            #endregion

        }
        #endregion

        #region utils

        void fillDGV()
        {
            this.jadwalPenerbanganTableAdapter.Fill(this.bromoRunMarchDataSet.JadwalPenerbangan);
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            cm.SuspendBinding();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;

                var bandaraAsalID = repoListPenerbangan.bandaraAsal.id;
                var bandaraTujuanID = repoListPenerbangan.bandaraTujuan.id;
                var tanggal = Convert.ToDateTime( repoListPenerbangan.tanggal );

                var rowBandaraAsal = row.Cells["bandaraKeberangkatanID"].Value;
                var rowBandaraTujuan = row.Cells["bandaraTujuanID"].Value;
                var rowTanggal = Convert.ToDateTime( row.Cells["tanggalWaktuKeberangkatan"].Value );

                if (
                    rowBandaraAsal.ToString() != bandaraAsalID.ToString() || 
                    rowBandaraTujuan.ToString() != bandaraTujuanID.ToString() ||
                    tanggal.ToString("dd-MM-yyyy") != rowTanggal.ToString("dd-MM-yyyy"))
                {
                    row.Visible = false;
                }

                var rowMaskapai = row.Cells["maskapaiID"].Value;
                int durasi = Convert.ToInt32( row.Cells["durasiPenerbangan"].Value );

                var maskapai = Repo.entities.Maskapais.Find(rowMaskapai).nama;
                var bandaraAsal = Repo.entities.Bandaras.Find(rowBandaraAsal).nama;
                var bandaraTujuan = Repo.entities.Bandaras.Find(rowBandaraTujuan).nama;

                int jam = 0;
                while (durasi - 60 > 0)
                {
                    jam++;
                    durasi -= 60;
                }
                var waktuSampai = rowTanggal.AddHours(jam).AddMinutes(durasi);

                row.Cells["maskapai"].Value = maskapai;
                row.Cells["bandaraAsal"].Value = bandaraAsal;
                row.Cells["bandaraTujuan"].Value = bandaraTujuan;
                row.Cells["tanggalKeberangkatan"].Value = rowTanggal.ToString("dd-MM-yyyy");
                row.Cells["waktuKeberangkatan"].Value = rowTanggal.ToString("HH:mm") + " - " + waktuSampai.ToString("HH:mm");
                row.Cells["waktuSampai"].Value = waktuSampai;
            }

            cm.ResumeBinding();
        }

        void toBeliTiket()
        {
            BeliTiketForm beli = new BeliTiketForm();
            this.Hide();
            beli.Show();
        }
        #endregion

        #region buttons
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainFormCust cust = new MainFormCust();
            cust.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var row = dataGridView1.Rows[rowIndex];
            var id = row.Cells["id"].Value;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "beliTiket")
            {
                var model = Repo.entities.JadwalPenerbangans.Find(id);
                repoBeliTiket.jadwalPenerbangan = model;
                toBeliTiket();
            }
        }
        #endregion

        private void ListPenerbanganForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}

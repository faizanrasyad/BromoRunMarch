using BromoAirlineDesktop.CRUD;
using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Model;
using BromoAirlineDesktop.Utils;
using DocumentFormat.OpenXml.Math;
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

namespace BromoAirlineDesktop.Fragments
{
    public partial class JadwalPenerbanganFrag : UserControl
    {
        public JadwalPenerbanganFrag()
        {
            InitializeComponent();
        }

        #region utils
        void fillCbBandara()
        {
            cbAsal.DataSource = Repo.entity.Bandaras.ToList();
            cbTujuan.DataSource = Repo.entity.Bandaras.ToList();

            cbAsal.ValueMember = "id";
            cbAsal.DisplayMember= "nama";

            cbTujuan.ValueMember = "id";
            cbTujuan.DisplayMember = "nama";
        }

        void fillCbMaskapai()
        {
            cbMaskapai.DataSource = Repo.entity.Maskapais.ToList();
            cbMaskapai.ValueMember = "id";
            cbMaskapai.DisplayMember = "nama";
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbKode.Text))
            {
                MessageBox.Show("Kode Penerbangan tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(cbAsal.SelectedValue.ToString()))
            {
                MessageBox.Show("Bandara Asal tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(cbTujuan.SelectedValue.ToString()))
            {
                MessageBox.Show("Bandara Tujuan tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(cbMaskapai.SelectedValue.ToString()))
            {
                MessageBox.Show("Maskapai tidak boleh kosong");
                return false;
            }

            if (dateKeberangkatan.Value < DateTime.Now)
            {
                MessageBox.Show("Tanggal Keberangkatan tidak valid");
                return false;
            }

            if (String.IsNullOrEmpty(tbWaktuKeberangkatan.Text))
            {
                MessageBox.Show("Waktu Penerbangan tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbDurasiPenerbangan.Text))
            {
                MessageBox.Show("Durasi Penerbangan tidak boleh kosong");
                return false;
            }

            if (numHarga.Value < 1000)
            {
                MessageBox.Show("Harga minimal 1000");
                return false;
            }
            return true;
        }

        void clear()
        {
            tbKode.Text = string.Empty;
            tbDurasiPenerbangan.Text = string.Empty;
            tbWaktuKeberangkatan.Text = string.Empty;
            cbAsal.Text = string.Empty;
            cbTujuan.Text = string.Empty;
            cbMaskapai.Text = string.Empty;
            dateKeberangkatan.Value = DateTime.Now;
            numHarga.Value = 1000;
            JadwalPenerbanganCRUD.selJadwal = null;
        }

        void populate(JadwalPenerbangan model)
        {
            tbKode.Text = model.kodePenerbangan;
            tbDurasiPenerbangan.Text = model.durasiPenerbangan.ToString();
            tbWaktuKeberangkatan.Text = model.tanggalWaktuKeberangkatan.ToString("HH:mm");
            cbAsal.SelectedValue = model.bandaraKeberangkatanID;
            cbTujuan.SelectedValue = model.bandaraTujuanID;
            cbMaskapai.SelectedValue = model.maskapaiID;
            dateKeberangkatan.Value = model.tanggalWaktuKeberangkatan;
            numHarga.Value = Convert.ToInt32(model.hargaPerTiket);
        }

        void fillDGV()
        {
            this.jadwalPenerbanganTableAdapter.Fill(this.bromoAirlineDataSet.JadwalPenerbangan);
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                var modelBandaraAsal = Repo.entity.Bandaras.Find(row.Cells["bandaraKeberangkatanID"].Value);
                var modelBandaraTujuan = Repo.entity.Bandaras.Find(row.Cells["bandaraTujuanID"].Value);
                var modelMaskapai = Repo.entity.Maskapais.Find(row.Cells["maskapaiID"].Value);
                cm.SuspendBinding();
                row.Cells["bandaraAsal"].Value = modelBandaraAsal.nama;
                row.Cells["bandaraTujuan"].Value = modelBandaraTujuan.nama;
                row.Cells["maskapai"].Value = modelMaskapai.nama;
                cm.ResumeBinding();
            }
        }

        void reset()
        {
            fillCbBandara();
            fillCbMaskapai();
            fillDGV();
            clear();
        }

        #endregion

        private void JadwalPenerbanganFrag_Load(object sender, EventArgs e)
        {

        }

        private void JadwalPenerbanganFrag_VisibleChanged(object sender, EventArgs e)
        {
            reset();
        }

        #region buttons
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var model = JadwalPenerbanganCRUD.selJadwal = new Model.JadwalPenerbangan();
            var row = dataGridView1.Rows[e.RowIndex];
            model.id = Convert.ToInt32(row.Cells["id"].Value);
            model.kodePenerbangan = row.Cells["kodePenerbangan"].Value.ToString();
            model.bandaraKeberangkatanID = Convert.ToInt32(row.Cells["bandaraKeberangkatanID"].Value);
            model.bandaraTujuanID = Convert.ToInt32(row.Cells["bandaraTujuanID"].Value);
            model.maskapaiID = Convert.ToInt32(row.Cells["maskapaiID"].Value);
            model.tanggalWaktuKeberangkatan = Convert.ToDateTime(row.Cells["tanggalWaktuKeberangkatan"].Value);
            model.durasiPenerbangan = Convert.ToInt32(row.Cells["durasiPenerbangan"].Value);
            model.hargaPerTiket = Convert.ToInt32(row.Cells["hargaPerTiket"].Value);
            Debug.Print("Maskapai ID : " + model.maskapaiID);
            JadwalPenerbanganCRUD.selJadwal = model;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "ubah")
            {
                populate(model);
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "hapus")
            {
                JadwalPenerbanganCRUD.delete();
                reset();
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if(JadwalPenerbanganCRUD.selJadwal == null)
                {
                    JadwalPenerbanganCRUD.add(
                        tbKode.Text,
                        Convert.ToInt32(cbAsal.SelectedValue),
                        Convert.ToInt32(cbTujuan.SelectedValue),
                        Convert.ToInt32(cbMaskapai.SelectedValue), 
                        dateKeberangkatan.Value,
                        tbWaktuKeberangkatan.Text,
                        Convert.ToInt32(tbDurasiPenerbangan.Text), 
                        Convert.ToInt32(numHarga.Value));
                    reset();
                }
                else
                {
                    JadwalPenerbanganCRUD.selJadwal.kodePenerbangan = tbKode.Text;
                    JadwalPenerbanganCRUD.selJadwal.bandaraKeberangkatanID = Convert.ToInt32(cbAsal.SelectedValue);
                    JadwalPenerbanganCRUD.selJadwal.bandaraTujuanID = Convert.ToInt32(cbTujuan.SelectedValue);
                    JadwalPenerbanganCRUD.selJadwal.maskapaiID = Convert.ToInt32(cbMaskapai.SelectedValue);
                    JadwalPenerbanganCRUD.selJadwal.tanggalWaktuKeberangkatan = dateKeberangkatan.Value;
                    JadwalPenerbanganCRUD.selJadwal.durasiPenerbangan = Convert.ToInt32(tbDurasiPenerbangan.Text);
                    JadwalPenerbanganCRUD.selJadwal.hargaPerTiket = Convert.ToInt32(numHarga.Value);

                    JadwalPenerbanganCRUD.edit(JadwalPenerbanganCRUD.selJadwal, tbWaktuKeberangkatan.Text);
                    reset();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
        #endregion
    }
}

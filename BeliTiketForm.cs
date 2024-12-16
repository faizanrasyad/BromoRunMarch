using BromoAirlineDesktop.CRUD;
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
    public partial class BeliTiketForm : Form
    {
        public BeliTiketForm()
        {
            InitializeComponent();
        }

        void setupAwal()
        {
            lbBandaraAsal.Text = CustomerCRUD.bandaraAsal.nama + " ("+ CustomerCRUD.bandaraAsal.kodeIATA + ")";
            lbBandaraTujuan.Text = CustomerCRUD.bandaraTujuan.nama + " ("+ CustomerCRUD.bandaraTujuan.kodeIATA + ")";
            lbMaskapai.Text = CustomerCRUD.maskapai.nama;
            var hari = CustomerCRUD.tanggalLiburan.DayOfWeek;
            var tanggal = CustomerCRUD.tanggalLiburan.Day;
            var bulan = CustomerCRUD.tanggalLiburan.ToString("MMM");
            var tahun = CustomerCRUD.tanggalLiburan.Year;
            lbTanggal.Text = hari + ", " + tanggal + " " + bulan + " " + tahun;
            var tanggalPenerbangan = CustomerCRUD.jadwalPenerbangan.tanggalWaktuKeberangkatan;
            var durasiPenerbangan = CustomerCRUD.jadwalPenerbangan.durasiPenerbangan;
            var waktuPenerbangan = tanggalPenerbangan.ToString("HH:mm");
            lbWaktu.Text = waktuPenerbangan + " - " + durasiPenerbangan + " menit";
            lbPenumpang.Text = CustomerCRUD.jumlahPenumpang + " penumpang";
            lbHarga.Text = "IDR " + (CustomerCRUD.jadwalPenerbangan.hargaPerTiket * CustomerCRUD.jumlahPenumpang).ToString();
        }

        private void BeliTiketForm_Load(object sender, EventArgs e)
        {
            setupAwal();
        }
    }
}

using BromoRunMarch.CRUD;
using BromoRunMarch.Data;
using BromoRunMarch.Fragments;
using BromoRunMarch.Model;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoRunMarch
{
    public partial class BeliTiketForm : Form
    {
        public BeliTiketForm()
        {
            InitializeComponent();
        }

        private void BeliTiketForm_Load(object sender, EventArgs e)
        {
            setupView();
        }
        List<TransaksiDetail> transaksiDetailList = new List<TransaksiDetail>();
        void setupView()
        {
            var jadwalPenerbangan = repoBeliTiket.jadwalPenerbangan;
            var bandaraAsal = Repo.entities.Bandaras.Find(jadwalPenerbangan.bandaraKeberangkatanID);
            var bandaraTujuan = Repo.entities.Bandaras.Find(jadwalPenerbangan.bandaraTujuanID);
            var maskapai = Repo.entities.Maskapais.Find(jadwalPenerbangan.maskapaiID).nama;
            var tanggal = Convert.ToDateTime(jadwalPenerbangan.tanggalWaktuKeberangkatan);
            var durasi = jadwalPenerbangan.durasiPenerbangan;
            var penumpang = repoListPenerbangan.jumlahPenumpang;

            lbBandaraAsal.Text = bandaraAsal.nama + " (" + bandaraAsal.kodeIATA + ")";
            lbBandaraTujuan.Text = bandaraTujuan.nama + " (" + bandaraTujuan.kodeIATA + ")";
            lbMaskapai.Text = maskapai;
            lbPenumpang.Text = penumpang + " Penumpang";
            lbTanggal.Text = tanggal.DayOfWeek.ToString().Substring(0, 3) + ", " + tanggal.Day + " " + tanggal.ToString("MMMM") + " " + tanggal.Year;

            var jam = 0;
            while (durasi - 60 > 0)
            {
                jam++;
                durasi -= 60;
            }
            var waktuSampai = tanggal.AddHours(jam).AddMinutes(durasi);
            lbWaktu.Text = tanggal.ToString("HH:mm") + " - " + waktuSampai.ToString("HH:mm");

            int totalHarga = (int)jadwalPenerbangan.hargaPerTiket * repoListPenerbangan.jumlahPenumpang;
            repoBeliTiket.totalHarga = totalHarga;

            var titik = new System.Globalization.CultureInfo("nl-BE");
            titik.NumberFormat.CurrencyGroupSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = titik;
            lbHarga.Text = "IDR " + $"{totalHarga:n0}";

            masukkanFragment();
        }

        #region utils
        void masukkanFragment()
        {
            for(int i = 1; i <= repoListPenerbangan.jumlahPenumpang; i++)
            {
                fragmentContainer.Controls.Add(new PenumpangFrag(i));
            }
        }

        void kumpulkanPenumpang()
        {
            foreach(UserControl frag in fragmentContainer.Controls)
            {
                if(frag is PenumpangFrag)
                {
                    transaksiDetailList.Add((frag as PenumpangFrag).transaksiDetail);
                }
            }
        }

        void reset()
        {
            transaksiDetailList = null;
            repoBeliTiket.jadwalPenerbangan = null;
            repoBeliTiket.totalHarga = 0;
            repoBeliTiket.kodePromo = null;
            repoListPenerbangan.jumlahPenumpang = 0;
            repoListPenerbangan.bandaraTujuan = null;
            repoListPenerbangan.bandaraAsal = null;
            repoListPenerbangan.tanggal = DateTime.Now;

        }

        void toTiketSaya()
        {
            TiketSayaForm tiketSayaForm = new TiketSayaForm();
            tiketSayaForm.Show();
            this.Hide();
        }

        #endregion

        #region buttons
        private void btnPakaiPromo_Click(object sender, EventArgs e)
        {
            if(tbKodePromo.Text != "")
            {
                var listKodePromo = Repo.entities.KodePromoes.Select(r=> r.kode);
                if (listKodePromo.Contains(tbKodePromo.Text))
                {
                    var kodePromo = Repo.entities.KodePromoes.Where(r => r.kode.Equals(tbKodePromo.Text)).FirstOrDefault();
                    repoBeliTiket.kodePromo = kodePromo;
                    var harga = repoBeliTiket.totalHarga;
                    Debug.Print("HARGA BEFORE PROMO : " + harga);
                    var selisih = harga * (kodePromo.presentaseDiskon / 100);
                    harga -= (int)selisih;
                    Debug.Print("HARGA AFTER PROMO : " + harga);

                    var titik = new System.Globalization.CultureInfo("nl-BE");
                    titik.NumberFormat.CurrencyGroupSeparator = ".";
                    System.Threading.Thread.CurrentThread.CurrentCulture = titik;
                    lbHarga.Text = "IDR " + $"{harga:n0}";
                    repoBeliTiket.totalHarga = harga;
                }
                else
                {
                    MessageBox.Show("Kode Promo tidak ditemukan!");
                    tbKodePromo.Clear();
                }
            }
            else
            {
                MessageBox.Show("Kode Promo kosong!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TransaksiCRUD.add(
                Repo.logged.id, 
                repoBeliTiket.jadwalPenerbangan.id, 
                repoListPenerbangan.jumlahPenumpang, 
                repoBeliTiket.totalHarga, 
                repoBeliTiket.kodePromo.id,
                transaksiDetailList);
            reset();
            toTiketSaya();
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            ListPenerbanganForm form = new ListPenerbanganForm();
            this.Hide();
            form.Show();
        }
    }
}

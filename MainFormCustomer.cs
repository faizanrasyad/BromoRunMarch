using BromoAirlineDesktop.CRUD;
using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Utils;
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
    public partial class MainFormCustomer : Form
    {
        public MainFormCustomer()
        {
            InitializeComponent();
        }

        private void MainFormCustomer_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Mau terbang kemana hari ini, " + Repo.logged.nama + "?";
            fillTbBandara();
        }

        #region utils
        void fillTbBandara()
        {
            var model = Repo.entity.Bandaras.ToList();
            var source = new AutoCompleteStringCollection();

            foreach(var item in model)
            {
                source.Add(item.nama /*+ ", " +item.kota + " (" + item.kodeIATA + ")"*/);
            }

            tbAsal.AutoCompleteCustomSource = source;
            tbTujuan.AutoCompleteCustomSource = source;
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbAsal.Text))
            {
                MessageBox.Show("Bandara Asal tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbTujuan.Text))
            {
                MessageBox.Show("Bandara Tujuan tidak boleh kosong");
                return false;
            }

            if (numPenumpang.Value < 1)
            {
                MessageBox.Show("Jumlah Penumpang minimal 1");
                return false;
            }

            if (dateBerangkat.Value < DateTime.Now)
            {
                MessageBox.Show("Tanggal Keberangkatan tidak valid");
                return false;
            }

            if(tbAsal.Text == tbTujuan.Text)
            {
                MessageBox.Show("Bandara Asal dan Bandara Tujuan tidak boleh sama");
                return false;
            }
            return true;    
        }

        void toTiketSaya()
        {
            TiketSayaForm tiket = new TiketSayaForm();
            this.Hide();
            tiket.Show();
        }
        #endregion

        #region buttons
        private void btnTiket_Click(object sender, EventArgs e)
        {
            toTiketSaya();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Konfirmasi.confirm())
            {
                Repo.logout();
                B login = new B();
                this.Close();
                login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                CustomerCRUD.jumlahPenumpang = Convert.ToInt32(numPenumpang.Value);
                CustomerCRUD.tanggalLiburan = dateBerangkat.Value;
                CustomerCRUD.bandaraAsal = Repo.entity.Bandaras.Where(r => r.nama.Contains(tbAsal.Text)).FirstOrDefault();
                CustomerCRUD.bandaraTujuan = Repo.entity.Bandaras.Where(r => r.nama.Contains(tbTujuan.Text)).FirstOrDefault();
                
                PenerbanganForm pen = new PenerbanganForm();
                this.Hide();
                pen.Show();
            }
        }
        #endregion

        private void MainFormCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

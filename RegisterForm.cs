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
    public partial class RegisterForm : Form
    {
        bool gantian = false;

        public RegisterForm()
        {
            InitializeComponent();
        }
        void toLogin()
        {
            B login = new B();
            this.Close();
            login.Show();
        }

        void toMainCust()
        {
            MainFormCustomer cust = new MainFormCustomer(); 
            this.Close();
            cust.Show();
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbTelp.Text))
            {
                MessageBox.Show("Nomor Telepon tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Password tidak boleh kosong");
                return false;
            }

            if (tbPass.Text.Length < 8)
            {
                MessageBox.Show("Password tidak valid");
                return false;
            }

            if (tbTelp.Text.Length < 10 || !tbTelp.Text.Contains("08"))
            {
                MessageBox.Show("Nomor Telepon tidak valid");
                return false;
            }
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toLogin();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            if (gantian == false)
            {
                tbPass.UseSystemPasswordChar = gantian;
                btnLihat.Text = "Sembunyikan";
            }
            else
            {
                tbPass.UseSystemPasswordChar = gantian;
                btnLihat.Text = "Lihat";
            }
            gantian = !gantian;
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                try
                {
                    DaftarAkun.add(tbUsername.Text, tbNama.Text, tbPass.Text, dateTanggalLahir.Value, tbTelp.Text);
                    toMainCust();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }


}

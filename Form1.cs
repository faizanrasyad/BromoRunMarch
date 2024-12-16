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
    public partial class B : Form
    {
        bool gantian = false;
        public B()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                Repo.login(tbUsername.Text, tbPass.Text);
                if(Repo.logged != null)
                {
                    if(Repo.logged.merupakanAdmin == true)
                    {
                        toMain();
                    }
                    else
                    {
                        toMainCust();
                    }
                }
                else
                {
                    MessageBox.Show("Akun tidak ditemukan");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toRegister();
        }

        void toRegister() {
            RegisterForm reg = new RegisterForm();
            this.Hide();
            reg.Show();
        }

        void toMain()
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }

        void toMainCust()
        {
            MainFormCustomer cust = new MainFormCustomer();
            this.Hide();
            cust.Show();    
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Password tidak boleh kosong");
                return false;
            }
            return true;
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            if(gantian == false)
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

        private void B_Load(object sender, EventArgs e)
        {

        }

        private void B_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

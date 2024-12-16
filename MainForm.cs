using BromoAirlineDesktop.CRUD;
using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Properties;
using BromoAirlineDesktop.Utils;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class MainForm : Form
    {
        bool gantian = false;
        static Size sizePanelNavExpanded = new Size(305, 658);
        static Size sizePanelNavMinimized = new Size(48, 658);
        public MainForm()
        {
            InitializeComponent();
        }

        void hideAllFragment()
        {
            foreach(UserControl fragment in flowLayoutPanel1.Controls)
            {
                fragment.Visible = false;
            }
        }

        void showFragment(UserControl fragment)
        {
            hideAllFragment();
            fragment.Visible = true;
        }

        private void pbDashboard_Click(object sender, EventArgs e)
        {
            if(gantian == false)
            {
                panel2.Size = sizePanelNavMinimized;
            }
            else
            {
                panel2.Size = sizePanelNavExpanded;
            }
            gantian = !gantian;
        }

        #region buttons
        private void pbBandara_Click(object sender, EventArgs e)
        {
            pbBandara.Image = Resources.map_selected_72;
            pbMaskapai.Image = Resources.plane_take_off_unselected_72;
            pbJadwal.Image = Resources.calendar_unselected_72;
            pbPromo.Image = Resources.purchase_tag_alt_unselected_72;
            pbStatus.Image = Resources.notepad_unselected_72;
            lbBandara.ForeColor = System.Drawing.Color.Black;
            lbMaskapai.ForeColor = System.Drawing.Color.Gray;
            lbJadwal.ForeColor = System.Drawing.Color.Gray;
            lbPromo.ForeColor = System.Drawing.Color.Gray;
            lbStatus.ForeColor = System.Drawing.Color.Gray;

            showFragment(bandaraFrag1);
        }

        private void pbMaskapai_Click(object sender, EventArgs e)
        {
            pbBandara.Image = Resources.map_unselected_72;
            pbMaskapai.Image = Resources.plane_take_off_selected_72;
            pbJadwal.Image = Resources.calendar_unselected_72;
            pbPromo.Image = Resources.purchase_tag_alt_unselected_72;
            pbStatus.Image = Resources.notepad_unselected_72;
            lbBandara.ForeColor = System.Drawing.Color.Gray;
            lbMaskapai.ForeColor = System.Drawing.Color.Black;
            lbJadwal.ForeColor = System.Drawing.Color.Gray;
            lbPromo.ForeColor = System.Drawing.Color.Gray;
            lbStatus.ForeColor = System.Drawing.Color.Gray;

            showFragment(maskapaiFrag1);
        }

        private void pbJadwal_Click(object sender, EventArgs e)
        {
            pbBandara.Image = Resources.map_unselected_72;
            pbMaskapai.Image = Resources.plane_take_off_unselected_72;
            pbJadwal.Image = Resources.calendar_selected_72;
            pbPromo.Image = Resources.purchase_tag_alt_unselected_72;
            pbStatus.Image = Resources.notepad_unselected_72;
            lbBandara.ForeColor = System.Drawing.Color.Gray;
            lbMaskapai.ForeColor = System.Drawing.Color.Gray;
            lbJadwal.ForeColor = System.Drawing.Color.Black;
            lbPromo.ForeColor = System.Drawing.Color.Gray;
            lbStatus.ForeColor = System.Drawing.Color.Gray;

            showFragment(jadwalPenerbanganFrag1);
        }

        private void pbPromo_Click(object sender, EventArgs e)
        {
            pbBandara.Image = Resources.map_unselected_72;
            pbMaskapai.Image = Resources.plane_take_off_unselected_72;
            pbJadwal.Image = Resources.calendar_unselected_72;
            pbPromo.Image = Resources.purchase_tag_alt_selected_72;
            pbStatus.Image = Resources.notepad_unselected_72;
            lbBandara.ForeColor = System.Drawing.Color.Gray;
            lbMaskapai.ForeColor = System.Drawing.Color.Gray;
            lbJadwal.ForeColor = System.Drawing.Color.Gray;
            lbPromo.ForeColor = System.Drawing.Color.Black;
            lbStatus.ForeColor = System.Drawing.Color.Gray;

            showFragment(promoFrag1);
        }

        private void pbStatus_Click(object sender, EventArgs e)
        {
            pbBandara.Image = Resources.map_unselected_72;
            pbMaskapai.Image = Resources.plane_take_off_unselected_72;
            pbJadwal.Image = Resources.calendar_unselected_72;
            pbPromo.Image = Resources.purchase_tag_alt_unselected_72;
            pbStatus.Image = Resources.notepad_selected_72;
            lbBandara.ForeColor = System.Drawing.Color.Gray;
            lbMaskapai.ForeColor = System.Drawing.Color.Gray;
            lbJadwal.ForeColor = System.Drawing.Color.Gray;
            lbPromo.ForeColor = System.Drawing.Color.Gray;
            lbStatus.ForeColor = System.Drawing.Color.Black;

            showFragment(statusPenerbanganFrag1);
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            if (Konfirmasi.confirm())
            {
                Repo.logout();
                B login = new B();
                login.Show();
                this.Hide();
            }
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            hideAllFragment();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

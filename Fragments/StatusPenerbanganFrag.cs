using BromoAirlineDesktop.CRUD;
using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlineDesktop.Fragments
{
    public partial class StatusPenerbanganFrag : UserControl
    {
        public StatusPenerbanganFrag()
        {
            InitializeComponent();
        }

        #region utils 
        void fillCbStatus()
        {
            cbStatus.DataSource = Repo.entity.StatusPenerbangans.ToList();
            cbStatus.ValueMember = "id";
            cbStatus.DisplayMember = "nama";
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(cbStatus.SelectedValue.ToString()))
            {
                MessageBox.Show("Status tidak boleh kosong");
                return false;
            }

            if(Convert.ToInt32(cbStatus.SelectedValue) == 2)
            {
                if (String.IsNullOrEmpty(tbDelay.Text))
                {
                    MessageBox.Show("Prakiraan delay tidak boleh kosong");
                    return false;
                }
            }

            return true;
        }

        void clear()
        {
            cbStatus.Text = string.Empty;   
            tbDelay.Text = string.Empty;

            cbStatus.Visible = false;
            lbStatus.Visible = false;
            btnBatal.Visible = false;
            btnSimpan.Visible = false;
        }

        void populate(PerubahanStatusJadwalPenerbangan model)
        {
            lbStatus.Visible = true;
            cbStatus.Visible = true;
            btnBatal.Visible = true;
            btnSimpan.Visible=true;

            cbStatus.SelectedValue = model.statusPenerbanganID;
            tbDelay.Text = model.perkiraanDurasiDelay.ToString();
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
                row.Cells["terakhirDiubah"].Value = modelPerubahan.Where(r => r.jadwalPenerbanganID.Equals(row.Cells["id"].Value)).FirstOrDefault().waktuPerubahanTerjadi;
                if (modelPerubahan.Where(r => r.jadwalPenerbanganID.Equals(row.Cells["id"].Value)).FirstOrDefault().perkiraanDurasiDelay == null)
                {
                    row.Cells["delay"].Value = "-";
                }
                else
                {
                    row.Cells["delay"].Value = modelPerubahan.Where(r => r.jadwalPenerbanganID.Equals(row.Cells["id"].Value)).FirstOrDefault().perkiraanDurasiDelay;
                }
                cm.ResumeBinding();
            }
        }

        void reset()
        {
            clear();
            fillCbStatus();
            fillDGV();
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var model = StatusPenerbanganCRUD.selRubahStatus = new Model.PerubahanStatusJadwalPenerbangan();
            var row = dataGridView1.Rows[e.RowIndex];
            var idJadwalPenerbangan = Convert.ToInt32(row.Cells["id"].Value);
            var modelPerubahanStatus = Repo.entity.PerubahanStatusJadwalPenerbangans.Where(r => r.jadwalPenerbanganID.Equals(idJadwalPenerbangan)).FirstOrDefault();
            var modelStatus = Repo.entity.StatusPenerbangans.Find(modelPerubahanStatus.statusPenerbanganID);

            model.id = modelPerubahanStatus.id;
            model.waktuPerubahanTerjadi = modelPerubahanStatus.waktuPerubahanTerjadi;
            model.statusPenerbanganID = modelStatus.id;
            model.jadwalPenerbanganID = Convert.ToInt32(row.Cells["id"].Value);
            model.perkiraanDurasiDelay = modelPerubahanStatus.perkiraanDurasiDelay;
            StatusPenerbanganCRUD.selRubahStatus = model;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "ubah")
            {
                populate(model);
            }
        }

        private void StatusPenerbanganFrag_VisibleChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                StatusPenerbanganCRUD.selRubahStatus.statusPenerbanganID = Convert.ToInt32(cbStatus.SelectedValue);
                StatusPenerbanganCRUD.selRubahStatus.perkiraanDurasiDelay = Convert.ToInt32(tbDelay.Text);

                StatusPenerbanganCRUD.updateStatus(StatusPenerbanganCRUD.selRubahStatus);
                reset();    
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            var selValue = cbStatus.SelectedValue;
            if(selValue.ToString() == "1")
            {
                lbDelay.Visible = false;
                tbDelay.Visible = false;
                lbMenit.Visible = false;
            }
            else
            {
                lbDelay.Visible = true;
                tbDelay.Visible = true;
                lbMenit.Visible = true;
            }
        }
    }
}

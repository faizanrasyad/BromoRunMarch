using BromoAirlineDesktop.CRUD;
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
    public partial class PromoFrag : UserControl
    {
        public PromoFrag()
        {
            InitializeComponent();
        }

        private void PromoFrag_Load(object sender, EventArgs e)
        {

        }

        private void PromoFrag_VisibleChanged(object sender, EventArgs e)
        {
            dateBerlaku.Value = DateTime.Now.AddDays(1);
            reset();
        }

        #region utils
        void fillDGV()
        {
            this.kodePromoTableAdapter.Fill(this.bromoAirlineDataSet.KodePromo);
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbKodePromo.Text))
            {
                MessageBox.Show("Kode Promo tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbDeskripsi.Text))
            {
                MessageBox.Show("Deskripsi tidak boleh kosong");
                return false;
            }

            if(dateBerlaku.Value < DateTime.Now)
            {
                MessageBox.Show("Tanggal berlaku tidak valid");
                return false;
            }

            if(numMaksimum.Value < 1)
            {
                MessageBox.Show("Maksimum diskon tidak boleh kosong");
                return false;
            }

            if(numPersentase.Value < 1)
            {
                MessageBox.Show("Persentase diskon tidak boleh kosong");
                return false;
            }

            if(numPersentase.Value > numMaksimum.Value)
            {
                MessageBox.Show("Persentase diskon tidak boleh lebih dari maksimum diskon");
                return false;
            }
            return true;
        }

        void clear()
        {
            tbDeskripsi.Text = string.Empty;
            tbKodePromo.Text = string.Empty;
            dateBerlaku.Value = DateTime.Now.AddDays(1);
            numMaksimum.Value = 1;
            numPersentase.Value = 1;
            PromoCRUD.selPromo = null;
        }

        void populate(KodePromo model)
        {
            tbDeskripsi.Text = model.deskripsi;
            tbKodePromo.Text = model.kode;
            dateBerlaku.Value = model.berlakuSampai;
            numMaksimum.Value = Convert.ToInt32(model.maksimumDiskon);
            numPersentase.Value = Convert.ToInt32(model.presentaseDiskon);
        }

        void reset()
        {
            fillDGV();
            clear();
        }
        #endregion

        #region buttons
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if(PromoCRUD.selPromo == null)
                {
                    PromoCRUD.add(tbKodePromo.Text, Convert.ToInt32(numPersentase.Value), Convert.ToInt32(numMaksimum.Value), dateBerlaku.Value, tbDeskripsi.Text);
                    reset();
                }
                else
                {
                    PromoCRUD.selPromo.kode = tbKodePromo.Text;
                    PromoCRUD.selPromo.deskripsi = tbDeskripsi.Text;
                    PromoCRUD.selPromo.berlakuSampai = dateBerlaku.Value;
                    PromoCRUD.selPromo.maksimumDiskon = Convert.ToInt32(numMaksimum.Value);
                    PromoCRUD.selPromo.presentaseDiskon = Convert.ToInt32(numPersentase.Value);

                    PromoCRUD.edit(PromoCRUD.selPromo);
                    reset();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var model = PromoCRUD.selPromo = new Model.KodePromo();
            var row = dataGridView1.Rows[e.RowIndex];
            model.id = Convert.ToInt32(row.Cells["id"].Value);
            model.kode = row.Cells["kode"].Value.ToString();
            model.deskripsi = row.Cells["deskripsi"].Value.ToString();
            model.berlakuSampai = Convert.ToDateTime(row.Cells["berlakuSampai"].Value);
            model.presentaseDiskon = Convert.ToInt32(row.Cells["presentaseDiskon"].Value);
            model.maksimumDiskon = Convert.ToInt32(row.Cells["maksimumDiskon"].Value);
            PromoCRUD.selPromo = model;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "ubah")
            {
                populate(model);
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "hapus")
            {
                PromoCRUD.delete();
                reset();
            }
        }
        #endregion
    }
}

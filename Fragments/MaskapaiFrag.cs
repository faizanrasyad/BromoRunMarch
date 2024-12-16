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
    public partial class MaskapaiFrag : UserControl
    {
        public MaskapaiFrag()
        {
            InitializeComponent();
        }

        #region utils
        void fillDGV()
        {
            this.maskapaiTableAdapter.Fill(this.bromoAirlineDataSet.Maskapai);
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbDeskripsi.Text))
            {
                MessageBox.Show("Deskripsi tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbPerusahaan.Text))
            {
                MessageBox.Show("Perusahaan tidak boleh kosong");
                return false;
            }

            if (numJumlahKru.Value < 1)
            {
                MessageBox.Show("Jumlah Kru tidak boleh kosong");
                return false;
            }
            return true;
        }

        void clear()
        {
            tbPerusahaan.Text = string.Empty;
            tbDeskripsi.Text = string.Empty;
            tbNama.Text = string.Empty;
            numJumlahKru.Value = 1;
            MaskapaiCRUD.selMaskapai = null;
        }

        void populate(Maskapai model)
        {
            tbPerusahaan.Text = model.perusahaan;
            tbDeskripsi.Text = model.deskripsi;
            tbNama.Text = model.nama;
            numJumlahKru.Value = model.jumlahKru;
        }

        void reset()
        {
            fillDGV();
            clear();
        }
        #endregion

        private void MaskapaiFrag_VisibleChanged(object sender, EventArgs e)
        {
            reset();
        }

        #region buttons
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if(MaskapaiCRUD.selMaskapai == null)
                {
                    MaskapaiCRUD.add(tbNama.Text, tbPerusahaan.Text, Convert.ToInt32(numJumlahKru.Value), tbDeskripsi.Text);
                    reset();
                }
                else
                {
                    MaskapaiCRUD.selMaskapai.nama = tbNama.Text;
                    MaskapaiCRUD.selMaskapai.deskripsi = tbDeskripsi.Text;
                    MaskapaiCRUD.selMaskapai.perusahaan = tbPerusahaan.Text;
                    MaskapaiCRUD.selMaskapai.jumlahKru = Convert.ToInt32(numJumlahKru.Value);

                    MaskapaiCRUD.edit(MaskapaiCRUD.selMaskapai);
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
            var model = MaskapaiCRUD.selMaskapai = new Model.Maskapai();
            var row = dataGridView1.Rows[e.RowIndex];
            model.id = Convert.ToInt32(row.Cells["id"].Value);
            model.nama = row.Cells["nama"].Value.ToString();
            model.perusahaan= row.Cells["perusahaan"].Value.ToString();
            model.deskripsi= row.Cells["deskripsi"].Value.ToString();
            model.jumlahKru = Convert.ToInt32(row.Cells["jumlahKru"].Value);
            MaskapaiCRUD.selMaskapai = model;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "ubah")
            {
                populate(model);
            }
            
            if(dataGridView1.Columns[e.ColumnIndex].Name == "hapus")
            {
                MaskapaiCRUD.delete();
                reset();
            }
        }
        #endregion
    }
}

using BromoAirlineDesktop.CRUD;
using BromoAirlineDesktop.Data;
using BromoAirlineDesktop.Model;
using BromoAirlineDesktop.Utils;
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
    public partial class BandaraFrag : UserControl
    {
        public BandaraFrag()
        {
            InitializeComponent();
        }

        private void BandaraFrag_Load(object sender, EventArgs e)
        {
            reset();
        }

        #region utils
        void fillCbNegara()
        {
            cbNegara.DataSource = Repo.entity.Negaras.ToList();
            cbNegara.ValueMember = "id";
            cbNegara.DisplayMember = "nama";
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbKota.Text))
            {
                MessageBox.Show("Kota tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbKodeIATA.Text))
            {
                MessageBox.Show("Kode IATA tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbAlamat.Text))
            {
                MessageBox.Show("Alamat tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(cbNegara.SelectedValue.ToString()))
            {
                MessageBox.Show("Negara tidak boleh kosong");
                return false;
            }

            if (numTerminal.Value < 1)
            {
                MessageBox.Show("Jumlah Terminal tidak boleh kosong");
                return false;
            }
            return true;
        }

        void clear()
        {
            tbAlamat.Text = string.Empty;
            tbKodeIATA.Text = string.Empty;
            tbNama.Text = string.Empty;
            tbKota.Text = string.Empty;
            cbNegara.Text = string.Empty;
            numTerminal.Value = 1;
            BandaraCRUD.selBandara = null;
        }

        void populate(Bandara model)
        {
            tbAlamat.Text = model.alamat;
            tbKodeIATA.Text = model.kodeIATA;
            tbNama.Text = model.nama;
            tbKota.Text = model.kota;
            cbNegara.SelectedValue = model.negaraID;
            numTerminal.Value = model.jumlahTerminal;
        }
        
        void fillDGV()
        {
            this.bandaraTableAdapter.Fill(this.bromoAirlineDataSet.Bandara);
            CurrencyManager cm  = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                var model = Repo.entity.Negaras.Find(row.Cells["negaraID"].Value);
                cm.SuspendBinding();
                row.Cells["negara"].Value = model.nama;
                cm.ResumeBinding();
            }

        }

        void reset()
        {
            clear();
            fillCbNegara();
            fillDGV();
        }

        
        #endregion

        #region buttons
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if (BandaraCRUD.selBandara == null)
                {
                    BandaraCRUD.add(tbNama.Text, tbKodeIATA.Text, tbKota.Text, Convert.ToInt32(cbNegara.SelectedValue), Convert.ToInt32(numTerminal.Value), tbAlamat.Text);
                    reset();
                }
                else
                {
                    Debug.Print(BandaraCRUD.selBandara.id.ToString());
                    BandaraCRUD.selBandara.nama = tbNama.Text;
                    BandaraCRUD.selBandara.kodeIATA = tbKodeIATA.Text;
                    BandaraCRUD.selBandara.kota = tbKota.Text;
                    BandaraCRUD.selBandara.alamat = tbAlamat.Text;
                    BandaraCRUD.selBandara.jumlahTerminal = Convert.ToInt32(numTerminal.Value);
                    BandaraCRUD.selBandara.negaraID = Convert.ToInt32(cbNegara.SelectedValue);

                    BandaraCRUD.edit(BandaraCRUD.selBandara);
                    reset();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var model = BandaraCRUD.selBandara = new Model.Bandara();
                model.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                model.nama = dataGridView1.Rows[e.RowIndex].Cells["nama"].Value.ToString();
                model.kodeIATA = dataGridView1.Rows[e.RowIndex].Cells["kodeIATA"].Value.ToString();
                model.kota = dataGridView1.Rows[e.RowIndex].Cells["kota"].Value.ToString();
                model.negaraID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["negaraID"].Value);
                model.jumlahTerminal = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["jumlahTerminal"].Value);
                model.alamat = dataGridView1.Rows[e.RowIndex].Cells["alamat"].Value.ToString();
            BandaraCRUD.selBandara = model;
            Debug.Print("Checkpoint set Data for selBandara : " + BandaraCRUD.selBandara.id.ToString());

            if (dataGridView1.Columns[e.ColumnIndex].Name == "hapus")
            {
                    BandaraCRUD.delete();

                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    dataGridView1.Refresh();
                    
                    reset();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name  == "ubah")
            {
                Debug.Print("Checkpoint get ready for populate : " + model.id);
                populate(model);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            BandaraCRUD.ekspor(this.bromoAirlineDataSet.Bandara);
        }
        #endregion

        private void BandaraFrag_VisibleChanged(object sender, EventArgs e)
        {
            reset();
        }
    }
}

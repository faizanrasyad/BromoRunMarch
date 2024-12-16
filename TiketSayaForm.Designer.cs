namespace BromoAirlineDesktop
{
    partial class TiketSayaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiketSayaForm));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlineDataSet = new BromoAirlineDesktop.BromoAirlineDataSet();
            this.jadwalPenerbanganTableAdapter = new BromoAirlineDesktop.BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraKeberangkatanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraTujuanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskapaiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalWaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasiPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(62, 86);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(249, 16);
            this.lbWelcome.TabIndex = 25;
            this.lbWelcome.Text = "Semua tiket yang aktif akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tiket Saya";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::BromoAirlineDesktop.Properties.Resources.chevron_left_solid_72;
            this.btnBack.Location = new System.Drawing.Point(20, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 33);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 26;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kodePenerbangan,
            this.bandaraAsal,
            this.bandaraTujuan,
            this.maskapai,
            this.bandaraKeberangkatanID,
            this.bandaraTujuanID,
            this.maskapaiID,
            this.tanggalWaktuKeberangkatan,
            this.durasiPenerbangan,
            this.hargaPerTiket,
            this.statusTerakhir});
            this.dataGridView1.DataSource = this.jadwalPenerbanganBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 373);
            this.dataGridView1.TabIndex = 27;
            // 
            // jadwalPenerbanganBindingSource
            // 
            this.jadwalPenerbanganBindingSource.DataMember = "JadwalPenerbangan";
            this.jadwalPenerbanganBindingSource.DataSource = this.bromoAirlineDataSet;
            // 
            // bromoAirlineDataSet
            // 
            this.bromoAirlineDataSet.DataSetName = "BromoAirlineDataSet";
            this.bromoAirlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalPenerbanganTableAdapter
            // 
            this.jadwalPenerbanganTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // kodePenerbangan
            // 
            this.kodePenerbangan.DataPropertyName = "kodePenerbangan";
            this.kodePenerbangan.HeaderText = "Kode Penerbangan";
            this.kodePenerbangan.MinimumWidth = 6;
            this.kodePenerbangan.Name = "kodePenerbangan";
            this.kodePenerbangan.Width = 125;
            // 
            // bandaraAsal
            // 
            this.bandaraAsal.HeaderText = "Bandara Keberangkatan";
            this.bandaraAsal.MinimumWidth = 6;
            this.bandaraAsal.Name = "bandaraAsal";
            this.bandaraAsal.ReadOnly = true;
            this.bandaraAsal.Width = 125;
            // 
            // bandaraTujuan
            // 
            this.bandaraTujuan.HeaderText = "Bandara Tujuan";
            this.bandaraTujuan.MinimumWidth = 6;
            this.bandaraTujuan.Name = "bandaraTujuan";
            this.bandaraTujuan.ReadOnly = true;
            this.bandaraTujuan.Width = 125;
            // 
            // maskapai
            // 
            this.maskapai.HeaderText = "Maskapai";
            this.maskapai.MinimumWidth = 6;
            this.maskapai.Name = "maskapai";
            this.maskapai.ReadOnly = true;
            this.maskapai.Width = 125;
            // 
            // bandaraKeberangkatanID
            // 
            this.bandaraKeberangkatanID.DataPropertyName = "bandaraKeberangkatanID";
            this.bandaraKeberangkatanID.HeaderText = "Bandara Keberangkatan";
            this.bandaraKeberangkatanID.MinimumWidth = 6;
            this.bandaraKeberangkatanID.Name = "bandaraKeberangkatanID";
            this.bandaraKeberangkatanID.Visible = false;
            this.bandaraKeberangkatanID.Width = 125;
            // 
            // bandaraTujuanID
            // 
            this.bandaraTujuanID.DataPropertyName = "bandaraTujuanID";
            this.bandaraTujuanID.HeaderText = "Bandara Tujuan";
            this.bandaraTujuanID.MinimumWidth = 6;
            this.bandaraTujuanID.Name = "bandaraTujuanID";
            this.bandaraTujuanID.Visible = false;
            this.bandaraTujuanID.Width = 125;
            // 
            // maskapaiID
            // 
            this.maskapaiID.DataPropertyName = "maskapaiID";
            this.maskapaiID.HeaderText = "Maskapai";
            this.maskapaiID.MinimumWidth = 6;
            this.maskapaiID.Name = "maskapaiID";
            this.maskapaiID.Visible = false;
            this.maskapaiID.Width = 125;
            // 
            // tanggalWaktuKeberangkatan
            // 
            this.tanggalWaktuKeberangkatan.DataPropertyName = "tanggalWaktuKeberangkatan";
            this.tanggalWaktuKeberangkatan.HeaderText = "Tanggal Keberangkatan";
            this.tanggalWaktuKeberangkatan.MinimumWidth = 6;
            this.tanggalWaktuKeberangkatan.Name = "tanggalWaktuKeberangkatan";
            this.tanggalWaktuKeberangkatan.Width = 125;
            // 
            // durasiPenerbangan
            // 
            this.durasiPenerbangan.DataPropertyName = "durasiPenerbangan";
            this.durasiPenerbangan.HeaderText = "Durasi Penerbangan";
            this.durasiPenerbangan.MinimumWidth = 6;
            this.durasiPenerbangan.Name = "durasiPenerbangan";
            this.durasiPenerbangan.Width = 125;
            // 
            // hargaPerTiket
            // 
            this.hargaPerTiket.DataPropertyName = "hargaPerTiket";
            this.hargaPerTiket.HeaderText = "hargaPerTiket";
            this.hargaPerTiket.MinimumWidth = 6;
            this.hargaPerTiket.Name = "hargaPerTiket";
            this.hargaPerTiket.Visible = false;
            this.hargaPerTiket.Width = 125;
            // 
            // statusTerakhir
            // 
            this.statusTerakhir.HeaderText = "Status Terakhir";
            this.statusTerakhir.MinimumWidth = 6;
            this.statusTerakhir.Name = "statusTerakhir";
            this.statusTerakhir.ReadOnly = true;
            this.statusTerakhir.Width = 125;
            // 
            // TiketSayaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TiketSayaForm";
            this.Text = "Bromo Airlines - Tiket Saya";
            this.Load += new System.EventHandler(this.TiketSayaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BromoAirlineDataSet bromoAirlineDataSet;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter jadwalPenerbanganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraKeberangkatanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraTujuanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskapaiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalWaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasiPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTerakhir;
    }
}
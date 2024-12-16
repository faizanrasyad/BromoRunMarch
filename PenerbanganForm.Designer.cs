namespace BromoAirlineDesktop
{
    partial class PenerbanganForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenerbanganForm));
            this.lbBandaraAsal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbBandaraTujuan = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbPenumpang = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bromoAirlineDataSet = new BromoAirlineDesktop.BromoAirlineDataSet();
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalPenerbanganTableAdapter = new BromoAirlineDesktop.BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraKeberangkatanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraTujuanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskapaiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalWaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasiPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beliTiket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUrutkan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBandaraAsal
            // 
            this.lbBandaraAsal.AutoSize = true;
            this.lbBandaraAsal.Location = new System.Drawing.Point(3, 0);
            this.lbBandaraAsal.Name = "lbBandaraAsal";
            this.lbBandaraAsal.Size = new System.Drawing.Size(89, 16);
            this.lbBandaraAsal.TabIndex = 28;
            this.lbBandaraAsal.Text = "Bandara Asal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "List Penerbangan";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbBandaraAsal);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.lbBandaraTujuan);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.lbTanggal);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.lbPenumpang);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(65, 80);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(994, 16);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BromoAirlineDesktop.Properties.Resources.right_arrow_regular_72;
            this.pictureBox1.Location = new System.Drawing.Point(98, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // lbBandaraTujuan
            // 
            this.lbBandaraTujuan.AutoSize = true;
            this.lbBandaraTujuan.Location = new System.Drawing.Point(119, 0);
            this.lbBandaraTujuan.Name = "lbBandaraTujuan";
            this.lbBandaraTujuan.Size = new System.Drawing.Size(103, 16);
            this.lbBandaraTujuan.TabIndex = 29;
            this.lbBandaraTujuan.Text = "Bandara Tujuan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BromoAirlineDesktop.Properties.Resources.circle_solid_72;
            this.pictureBox2.Location = new System.Drawing.Point(228, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Location = new System.Drawing.Point(249, 0);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(143, 16);
            this.lbTanggal.TabIndex = 33;
            this.lbTanggal.Text = "Tanggal Penerbangan";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BromoAirlineDesktop.Properties.Resources.circle_solid_72;
            this.pictureBox3.Location = new System.Drawing.Point(398, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // lbPenumpang
            // 
            this.lbPenumpang.AutoSize = true;
            this.lbPenumpang.Location = new System.Drawing.Point(419, 0);
            this.lbPenumpang.Name = "lbPenumpang";
            this.lbPenumpang.Size = new System.Drawing.Size(126, 16);
            this.lbPenumpang.TabIndex = 35;
            this.lbPenumpang.Text = "Jumlah Penumpang";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::BromoAirlineDesktop.Properties.Resources.chevron_left_solid_72;
            this.btnBack.Location = new System.Drawing.Point(20, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 33);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 29;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbUrutkan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.check2);
            this.groupBox1.Controls.Add(this.check3);
            this.groupBox1.Controls.Add(this.check4);
            this.groupBox1.Controls.Add(this.check1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 159);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
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
            this.maskapai,
            this.bandaraAsal,
            this.bandaraTujuan,
            this.bandaraKeberangkatanID,
            this.bandaraTujuanID,
            this.maskapaiID,
            this.hargaPerTiket,
            this.tanggalPenerbangan,
            this.waktuPenerbangan,
            this.tanggalWaktuKeberangkatan,
            this.durasiPenerbangan,
            this.beliTiket});
            this.dataGridView1.DataSource = this.jadwalPenerbanganBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 388);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bromoAirlineDataSet
            // 
            this.bromoAirlineDataSet.DataSetName = "BromoAirlineDataSet";
            this.bromoAirlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalPenerbanganBindingSource
            // 
            this.jadwalPenerbanganBindingSource.DataMember = "JadwalPenerbangan";
            this.jadwalPenerbanganBindingSource.DataSource = this.bromoAirlineDataSet;
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
            // maskapai
            // 
            this.maskapai.HeaderText = "Maskapai";
            this.maskapai.MinimumWidth = 6;
            this.maskapai.Name = "maskapai";
            this.maskapai.ReadOnly = true;
            this.maskapai.Width = 125;
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
            // bandaraKeberangkatanID
            // 
            this.bandaraKeberangkatanID.DataPropertyName = "bandaraKeberangkatanID";
            this.bandaraKeberangkatanID.HeaderText = "bandaraKeberangkatanID";
            this.bandaraKeberangkatanID.MinimumWidth = 6;
            this.bandaraKeberangkatanID.Name = "bandaraKeberangkatanID";
            this.bandaraKeberangkatanID.Visible = false;
            this.bandaraKeberangkatanID.Width = 125;
            // 
            // bandaraTujuanID
            // 
            this.bandaraTujuanID.DataPropertyName = "bandaraTujuanID";
            this.bandaraTujuanID.HeaderText = "bandaraTujuanID";
            this.bandaraTujuanID.MinimumWidth = 6;
            this.bandaraTujuanID.Name = "bandaraTujuanID";
            this.bandaraTujuanID.Visible = false;
            this.bandaraTujuanID.Width = 125;
            // 
            // maskapaiID
            // 
            this.maskapaiID.DataPropertyName = "maskapaiID";
            this.maskapaiID.HeaderText = "maskapaiID";
            this.maskapaiID.MinimumWidth = 6;
            this.maskapaiID.Name = "maskapaiID";
            this.maskapaiID.Visible = false;
            this.maskapaiID.Width = 125;
            // 
            // hargaPerTiket
            // 
            this.hargaPerTiket.DataPropertyName = "hargaPerTiket";
            this.hargaPerTiket.HeaderText = "Harga Per Tiket";
            this.hargaPerTiket.MinimumWidth = 6;
            this.hargaPerTiket.Name = "hargaPerTiket";
            this.hargaPerTiket.Width = 125;
            // 
            // tanggalPenerbangan
            // 
            this.tanggalPenerbangan.HeaderText = "Tanggal Keberangkatan";
            this.tanggalPenerbangan.MinimumWidth = 6;
            this.tanggalPenerbangan.Name = "tanggalPenerbangan";
            this.tanggalPenerbangan.ReadOnly = true;
            this.tanggalPenerbangan.Width = 125;
            // 
            // waktuPenerbangan
            // 
            this.waktuPenerbangan.HeaderText = "Waktu Penerbangan";
            this.waktuPenerbangan.MinimumWidth = 6;
            this.waktuPenerbangan.Name = "waktuPenerbangan";
            this.waktuPenerbangan.ReadOnly = true;
            this.waktuPenerbangan.Width = 125;
            // 
            // tanggalWaktuKeberangkatan
            // 
            this.tanggalWaktuKeberangkatan.DataPropertyName = "tanggalWaktuKeberangkatan";
            this.tanggalWaktuKeberangkatan.HeaderText = "Tanggal Keberangkatan";
            this.tanggalWaktuKeberangkatan.MinimumWidth = 6;
            this.tanggalWaktuKeberangkatan.Name = "tanggalWaktuKeberangkatan";
            this.tanggalWaktuKeberangkatan.Visible = false;
            this.tanggalWaktuKeberangkatan.Width = 125;
            // 
            // durasiPenerbangan
            // 
            this.durasiPenerbangan.DataPropertyName = "durasiPenerbangan";
            this.durasiPenerbangan.HeaderText = "Durasi Penerbangan";
            this.durasiPenerbangan.MinimumWidth = 6;
            this.durasiPenerbangan.Name = "durasiPenerbangan";
            this.durasiPenerbangan.Visible = false;
            this.durasiPenerbangan.Width = 125;
            // 
            // beliTiket
            // 
            this.beliTiket.HeaderText = "";
            this.beliTiket.MinimumWidth = 6;
            this.beliTiket.Name = "beliTiket";
            this.beliTiket.ReadOnly = true;
            this.beliTiket.Text = "Beli Tiket";
            this.beliTiket.UseColumnTextForButtonValue = true;
            this.beliTiket.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Waktu Keberangkatan";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(25, 51);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(101, 20);
            this.check1.TabIndex = 30;
            this.check1.Text = "00:00 - 06:00";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(383, 51);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(101, 20);
            this.check4.TabIndex = 31;
            this.check4.Text = "18:00 - 24:00";
            this.check4.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(261, 51);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(101, 20);
            this.check3.TabIndex = 32;
            this.check3.Text = "12:00 - 18:00";
            this.check3.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(143, 51);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(101, 20);
            this.check2.TabIndex = 33;
            this.check2.Text = "06:00 - 12:00";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Urutkan Berdasarkan";
            // 
            // cbUrutkan
            // 
            this.cbUrutkan.BackColor = System.Drawing.Color.Silver;
            this.cbUrutkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUrutkan.FormattingEnabled = true;
            this.cbUrutkan.Items.AddRange(new object[] {
            "Harga Terendah",
            "Keberangkatan Paling Awal",
            "Keberangkatan Paling Akhir",
            "Kedatangan Paling Awal",
            "Kedatangan Paling Akhir",
            "Durasi Tercepat"});
            this.cbUrutkan.Location = new System.Drawing.Point(25, 115);
            this.cbUrutkan.Name = "cbUrutkan";
            this.cbUrutkan.Size = new System.Drawing.Size(219, 24);
            this.cbUrutkan.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(843, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = " Terapkan Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PenerbanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 727);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PenerbanganForm";
            this.Text = "Bromo Airlines - Cari Penerbangan";
            this.Load += new System.EventHandler(this.PenerbanganForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lbBandaraAsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbBandaraTujuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbPenumpang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BromoAirlineDataSet bromoAirlineDataSet;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter jadwalPenerbanganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraKeberangkatanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraTujuanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskapaiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalWaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasiPenerbangan;
        private System.Windows.Forms.DataGridViewButtonColumn beliTiket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUrutkan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.Button button1;
    }
}
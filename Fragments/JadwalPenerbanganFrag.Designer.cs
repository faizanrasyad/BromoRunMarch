namespace BromoAirlineDesktop.Fragments
{
    partial class JadwalPenerbanganFrag
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaskapai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlineDataSet = new BromoAirlineDesktop.BromoAirlineDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jadwalPenerbanganTableAdapter = new BromoAirlineDesktop.BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter();
            this.dateKeberangkatan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAsal = new System.Windows.Forms.ComboBox();
            this.cbTujuan = new System.Windows.Forms.ComboBox();
            this.tbWaktuKeberangkatan = new System.Windows.Forms.TextBox();
            this.tbDurasiPenerbangan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(485, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 58;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.Silver;
            this.btnDaftar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.ForeColor = System.Drawing.Color.Black;
            this.btnDaftar.Location = new System.Drawing.Point(629, 589);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(129, 35);
            this.btnDaftar.TabIndex = 57;
            this.btnDaftar.Text = "Simpan";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tanggal";
            // 
            // cbMaskapai
            // 
            this.cbMaskapai.FormattingEnabled = true;
            this.cbMaskapai.Location = new System.Drawing.Point(178, 534);
            this.cbMaskapai.Name = "cbMaskapai";
            this.cbMaskapai.Size = new System.Drawing.Size(214, 24);
            this.cbMaskapai.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Maskapai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Bandara Tujuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Bandara Asal";
            // 
            // tbKode
            // 
            this.tbKode.Location = new System.Drawing.Point(178, 400);
            this.tbKode.MaxLength = 10;
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(214, 22);
            this.tbKode.TabIndex = 46;
            this.tbKode.Text = "__-____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Kode Penerbangan";
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
            this.ubah,
            this.hapus});
            this.dataGridView1.DataSource = this.jadwalPenerbanganBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 239);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.tanggalWaktuKeberangkatan.HeaderText = "Waktu Keberangkatan";
            this.tanggalWaktuKeberangkatan.MinimumWidth = 6;
            this.tanggalWaktuKeberangkatan.Name = "tanggalWaktuKeberangkatan";
            this.tanggalWaktuKeberangkatan.Width = 125;
            // 
            // durasiPenerbangan
            // 
            this.durasiPenerbangan.DataPropertyName = "durasiPenerbangan";
            this.durasiPenerbangan.HeaderText = "Durasi Penerbangan (Menit)";
            this.durasiPenerbangan.MinimumWidth = 6;
            this.durasiPenerbangan.Name = "durasiPenerbangan";
            this.durasiPenerbangan.Width = 125;
            // 
            // hargaPerTiket
            // 
            this.hargaPerTiket.DataPropertyName = "hargaPerTiket";
            this.hargaPerTiket.HeaderText = "Harga Per Tiket";
            this.hargaPerTiket.MinimumWidth = 6;
            this.hargaPerTiket.Name = "hargaPerTiket";
            this.hargaPerTiket.Width = 125;
            // 
            // ubah
            // 
            this.ubah.DataPropertyName = "id";
            this.ubah.HeaderText = "";
            this.ubah.MinimumWidth = 6;
            this.ubah.Name = "ubah";
            this.ubah.ReadOnly = true;
            this.ubah.Text = "Ubah";
            this.ubah.UseColumnTextForButtonValue = true;
            this.ubah.Width = 125;
            // 
            // hapus
            // 
            this.hapus.DataPropertyName = "id";
            this.hapus.HeaderText = "";
            this.hapus.MinimumWidth = 6;
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            this.hapus.Width = 125;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Semua jadwal penerbangan yang terdaftar akan muncul disini\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Master Jadwal Penerbangan";
            // 
            // jadwalPenerbanganTableAdapter
            // 
            this.jadwalPenerbanganTableAdapter.ClearBeforeFill = true;
            // 
            // dateKeberangkatan
            // 
            this.dateKeberangkatan.Location = new System.Drawing.Point(577, 398);
            this.dateKeberangkatan.Name = "dateKeberangkatan";
            this.dateKeberangkatan.Size = new System.Drawing.Size(221, 22);
            this.dateKeberangkatan.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Waktu Keberangkatan";
            // 
            // cbAsal
            // 
            this.cbAsal.FormattingEnabled = true;
            this.cbAsal.Location = new System.Drawing.Point(178, 443);
            this.cbAsal.Name = "cbAsal";
            this.cbAsal.Size = new System.Drawing.Size(214, 24);
            this.cbAsal.TabIndex = 62;
            // 
            // cbTujuan
            // 
            this.cbTujuan.FormattingEnabled = true;
            this.cbTujuan.Location = new System.Drawing.Point(178, 491);
            this.cbTujuan.Name = "cbTujuan";
            this.cbTujuan.Size = new System.Drawing.Size(214, 24);
            this.cbTujuan.TabIndex = 63;
            // 
            // tbWaktuKeberangkatan
            // 
            this.tbWaktuKeberangkatan.Location = new System.Drawing.Point(577, 443);
            this.tbWaktuKeberangkatan.Name = "tbWaktuKeberangkatan";
            this.tbWaktuKeberangkatan.Size = new System.Drawing.Size(221, 22);
            this.tbWaktuKeberangkatan.TabIndex = 64;
            // 
            // tbDurasiPenerbangan
            // 
            this.tbDurasiPenerbangan.Location = new System.Drawing.Point(577, 491);
            this.tbDurasiPenerbangan.Name = "tbDurasiPenerbangan";
            this.tbDurasiPenerbangan.Size = new System.Drawing.Size(221, 22);
            this.tbDurasiPenerbangan.TabIndex = 66;
            this.tbDurasiPenerbangan.Text = "__ jam __ menit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Harga Per Tiket";
            // 
            // numHarga
            // 
            this.numHarga.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHarga.Location = new System.Drawing.Point(577, 531);
            this.numHarga.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numHarga.Name = "numHarga";
            this.numHarga.Size = new System.Drawing.Size(221, 22);
            this.numHarga.TabIndex = 68;
            this.numHarga.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(804, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "(Menit)";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Silver;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(781, 74);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 35);
            this.btnExport.TabIndex = 71;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // JadwalPenerbanganFrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numHarga);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDurasiPenerbangan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbWaktuKeberangkatan);
            this.Controls.Add(this.cbTujuan);
            this.Controls.Add(this.cbAsal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateKeberangkatan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbMaskapai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JadwalPenerbanganFrag";
            this.Size = new System.Drawing.Size(945, 658);
            this.Load += new System.EventHandler(this.JadwalPenerbanganFrag_Load);
            this.VisibleChanged += new System.EventHandler(this.JadwalPenerbanganFrag_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaskapai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private BromoAirlineDataSet bromoAirlineDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter jadwalPenerbanganTableAdapter;
        private System.Windows.Forms.DateTimePicker dateKeberangkatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAsal;
        private System.Windows.Forms.ComboBox cbTujuan;
        private System.Windows.Forms.TextBox tbWaktuKeberangkatan;
        private System.Windows.Forms.TextBox tbDurasiPenerbangan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numHarga;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.Button btnExport;
    }
}

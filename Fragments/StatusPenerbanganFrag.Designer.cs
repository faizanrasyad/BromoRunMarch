namespace BromoAirlineDesktop.Fragments
{
    partial class StatusPenerbanganFrag
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
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.lbDelay = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
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
            this.hargaPerTiketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terakhirDiubah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlineDataSet = new BromoAirlineDesktop.BromoAirlineDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.jadwalPenerbanganTableAdapter = new BromoAirlineDesktop.BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter();
            this.lbMenit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Silver;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.ForeColor = System.Drawing.Color.Black;
            this.btnBatal.Location = new System.Drawing.Point(637, 589);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(129, 35);
            this.btnBatal.TabIndex = 73;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Visible = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Silver;
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.Black;
            this.btnSimpan.Location = new System.Drawing.Point(781, 589);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(129, 35);
            this.btnSimpan.TabIndex = 72;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Visible = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // lbDelay
            // 
            this.lbDelay.AutoSize = true;
            this.lbDelay.Location = new System.Drawing.Point(358, 543);
            this.lbDelay.Name = "lbDelay";
            this.lbDelay.Size = new System.Drawing.Size(146, 16);
            this.lbDelay.TabIndex = 70;
            this.lbDelay.Text = "Perkiraan Durasi Delay";
            this.lbDelay.Visible = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(42, 543);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(44, 16);
            this.lbStatus.TabIndex = 69;
            this.lbStatus.Text = "Status";
            this.lbStatus.Visible = false;
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
            this.hargaPerTiketDataGridViewTextBoxColumn,
            this.statusTerakhir,
            this.terakhirDiubah,
            this.delay,
            this.ubah});
            this.dataGridView1.DataSource = this.jadwalPenerbanganBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 402);
            this.dataGridView1.TabIndex = 64;
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
            this.tanggalWaktuKeberangkatan.HeaderText = "Tanggal Waktu Keberangkatan";
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
            // hargaPerTiketDataGridViewTextBoxColumn
            // 
            this.hargaPerTiketDataGridViewTextBoxColumn.DataPropertyName = "hargaPerTiket";
            this.hargaPerTiketDataGridViewTextBoxColumn.HeaderText = "hargaPerTiket";
            this.hargaPerTiketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaPerTiketDataGridViewTextBoxColumn.Name = "hargaPerTiketDataGridViewTextBoxColumn";
            this.hargaPerTiketDataGridViewTextBoxColumn.Visible = false;
            this.hargaPerTiketDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusTerakhir
            // 
            this.statusTerakhir.HeaderText = "Status Terakhir";
            this.statusTerakhir.MinimumWidth = 6;
            this.statusTerakhir.Name = "statusTerakhir";
            this.statusTerakhir.ReadOnly = true;
            this.statusTerakhir.Width = 125;
            // 
            // terakhirDiubah
            // 
            this.terakhirDiubah.HeaderText = "Terakhir Diubah";
            this.terakhirDiubah.MinimumWidth = 6;
            this.terakhirDiubah.Name = "terakhirDiubah";
            this.terakhirDiubah.ReadOnly = true;
            this.terakhirDiubah.Width = 125;
            // 
            // delay
            // 
            this.delay.HeaderText = "Prakiraan Delay";
            this.delay.MinimumWidth = 6;
            this.delay.Name = "delay";
            this.delay.ReadOnly = true;
            this.delay.Width = 125;
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
            this.label2.Size = new System.Drawing.Size(333, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Anda bisa mengubah status jadwal penerbangan disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "Master Status Penerbangan";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(107, 540);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(186, 24);
            this.cbStatus.TabIndex = 77;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(531, 540);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(186, 22);
            this.tbDelay.TabIndex = 78;
            this.tbDelay.Visible = false;
            // 
            // jadwalPenerbanganTableAdapter
            // 
            this.jadwalPenerbanganTableAdapter.ClearBeforeFill = true;
            // 
            // lbMenit
            // 
            this.lbMenit.AutoSize = true;
            this.lbMenit.ForeColor = System.Drawing.Color.Red;
            this.lbMenit.Location = new System.Drawing.Point(723, 543);
            this.lbMenit.Name = "lbMenit";
            this.lbMenit.Size = new System.Drawing.Size(47, 16);
            this.lbMenit.TabIndex = 79;
            this.lbMenit.Text = "(Menit)";
            // 
            // StatusPenerbanganFrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMenit);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lbDelay);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatusPenerbanganFrag";
            this.Size = new System.Drawing.Size(945, 658);
            this.VisibleChanged += new System.EventHandler(this.StatusPenerbanganFrag_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label lbDelay;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private BromoAirlineDataSet bromoAirlineDataSet;
        private System.Windows.Forms.TextBox tbDelay;
        private BromoAirlineDataSetTableAdapters.JadwalPenerbanganTableAdapter jadwalPenerbanganTableAdapter;
        private System.Windows.Forms.Label lbMenit;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaPerTiketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTerakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn terakhirDiubah;
        private System.Windows.Forms.DataGridViewTextBoxColumn delay;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
    }
}

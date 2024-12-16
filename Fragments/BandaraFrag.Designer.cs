namespace BromoAirlineDesktop.Fragments
{
    partial class BandaraFrag
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlineDataSet = new BromoAirlineDesktop.BromoAirlineDataSet();
            this.bandaraTableAdapter = new BromoAirlineDesktop.BromoAirlineDataSetTableAdapters.BandaraTableAdapter();
            this.tbKodeIATA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNegara = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numTerminal = new System.Windows.Forms.NumericUpDown();
            this.tbAlamat = new System.Windows.Forms.RichTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeIATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negaraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Semua bandara yang terdaftar akan muncul disini\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Master Bandara";
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
            this.nama,
            this.kodeIATA,
            this.kota,
            this.negara,
            this.negaraID,
            this.jumlahTerminal,
            this.alamat,
            this.ubah,
            this.hapus});
            this.dataGridView1.DataSource = this.bandaraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 239);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataMember = "Bandara";
            this.bandaraBindingSource.DataSource = this.bromoAirlineDataSet;
            // 
            // bromoAirlineDataSet
            // 
            this.bromoAirlineDataSet.DataSetName = "BromoAirlineDataSet";
            this.bromoAirlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandaraTableAdapter
            // 
            this.bandaraTableAdapter.ClearBeforeFill = true;
            // 
            // tbKodeIATA
            // 
            this.tbKodeIATA.Location = new System.Drawing.Point(141, 453);
            this.tbKodeIATA.MaxLength = 3;
            this.tbKodeIATA.Name = "tbKodeIATA";
            this.tbKodeIATA.Size = new System.Drawing.Size(214, 22);
            this.tbKodeIATA.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kode IATA";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(141, 410);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(214, 22);
            this.tbNama.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Negara";
            // 
            // tbKota
            // 
            this.tbKota.Location = new System.Drawing.Point(141, 501);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(214, 22);
            this.tbKota.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kota";
            // 
            // cbNegara
            // 
            this.cbNegara.FormattingEnabled = true;
            this.cbNegara.Location = new System.Drawing.Point(141, 544);
            this.cbNegara.Name = "cbNegara";
            this.cbNegara.Size = new System.Drawing.Size(214, 24);
            this.cbNegara.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Jumlah Terminal";
            // 
            // numTerminal
            // 
            this.numTerminal.Location = new System.Drawing.Point(536, 411);
            this.numTerminal.Name = "numTerminal";
            this.numTerminal.Size = new System.Drawing.Size(214, 22);
            this.numTerminal.TabIndex = 38;
            this.numTerminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(536, 453);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(214, 110);
            this.tbAlamat.TabIndex = 39;
            this.tbAlamat.Text = "";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Silver;
            this.btnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.Black;
            this.btnSimpan.Location = new System.Drawing.Point(621, 599);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(129, 35);
            this.btnSimpan.TabIndex = 40;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Silver;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.ForeColor = System.Drawing.Color.Black;
            this.btnBatal.Location = new System.Drawing.Point(477, 599);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(129, 35);
            this.btnBatal.TabIndex = 41;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Silver;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(773, 85);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 35);
            this.btnExport.TabIndex = 42;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 125;
            // 
            // kodeIATA
            // 
            this.kodeIATA.DataPropertyName = "kodeIATA";
            this.kodeIATA.HeaderText = "Kode IATA";
            this.kodeIATA.MinimumWidth = 6;
            this.kodeIATA.Name = "kodeIATA";
            this.kodeIATA.Width = 125;
            // 
            // kota
            // 
            this.kota.DataPropertyName = "kota";
            this.kota.HeaderText = "Kota";
            this.kota.MinimumWidth = 6;
            this.kota.Name = "kota";
            this.kota.Width = 125;
            // 
            // negara
            // 
            this.negara.HeaderText = "Negara";
            this.negara.MinimumWidth = 6;
            this.negara.Name = "negara";
            this.negara.ReadOnly = true;
            this.negara.Width = 125;
            // 
            // negaraID
            // 
            this.negaraID.DataPropertyName = "negaraID";
            this.negaraID.HeaderText = "Negara";
            this.negaraID.MinimumWidth = 6;
            this.negaraID.Name = "negaraID";
            this.negaraID.Visible = false;
            this.negaraID.Width = 125;
            // 
            // jumlahTerminal
            // 
            this.jumlahTerminal.DataPropertyName = "jumlahTerminal";
            this.jumlahTerminal.HeaderText = "Jumlah Terminal";
            this.jumlahTerminal.MinimumWidth = 6;
            this.jumlahTerminal.Name = "jumlahTerminal";
            this.jumlahTerminal.Width = 125;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 6;
            this.alamat.Name = "alamat";
            this.alamat.Width = 125;
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
            // BandaraFrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.numTerminal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbNegara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKodeIATA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BandaraFrag";
            this.Size = new System.Drawing.Size(945, 658);
            this.Load += new System.EventHandler(this.BandaraFrag_Load);
            this.VisibleChanged += new System.EventHandler(this.BandaraFrag_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private BromoAirlineDataSet bromoAirlineDataSet;
        private BromoAirlineDataSetTableAdapters.BandaraTableAdapter bandaraTableAdapter;
        private System.Windows.Forms.TextBox tbKodeIATA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNegara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numTerminal;
        private System.Windows.Forms.RichTextBox tbAlamat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeIATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn negara;
        private System.Windows.Forms.DataGridViewTextBoxColumn negaraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
    }
}

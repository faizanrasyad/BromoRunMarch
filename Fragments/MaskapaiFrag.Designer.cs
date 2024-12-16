namespace BromoAirlineDesktop.Fragments
{
    partial class MaskapaiFrag
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
            this.tbDeskripsi = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPerusahaan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahKru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maskapaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlineDataSet = new BromoAirlineDesktop.BromoAirlineDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskapaiTableAdapter = new BromoAirlineDesktop.BromoAirlineDataSetTableAdapters.MaskapaiTableAdapter();
            this.numJumlahKru = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahKru)).BeginInit();
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
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(510, 400);
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(214, 110);
            this.tbDeskripsi.TabIndex = 56;
            this.tbDeskripsi.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Deskripsi";
            // 
            // tbPerusahaan
            // 
            this.tbPerusahaan.Location = new System.Drawing.Point(149, 443);
            this.tbPerusahaan.Name = "tbPerusahaan";
            this.tbPerusahaan.Size = new System.Drawing.Size(214, 22);
            this.tbPerusahaan.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Perusahaan";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(149, 400);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(214, 22);
            this.tbNama.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nama";
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
            this.perusahaan,
            this.jumlahKru,
            this.deskripsi,
            this.ubah,
            this.hapus});
            this.dataGridView1.DataSource = this.maskapaiBindingSource;
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
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 125;
            // 
            // perusahaan
            // 
            this.perusahaan.DataPropertyName = "perusahaan";
            this.perusahaan.HeaderText = "Perusahaan";
            this.perusahaan.MinimumWidth = 6;
            this.perusahaan.Name = "perusahaan";
            this.perusahaan.Width = 125;
            // 
            // jumlahKru
            // 
            this.jumlahKru.DataPropertyName = "jumlahKru";
            this.jumlahKru.HeaderText = "Jumlah Kru";
            this.jumlahKru.MinimumWidth = 6;
            this.jumlahKru.Name = "jumlahKru";
            this.jumlahKru.Width = 125;
            // 
            // deskripsi
            // 
            this.deskripsi.DataPropertyName = "deskripsi";
            this.deskripsi.HeaderText = "Deskripsi";
            this.deskripsi.MinimumWidth = 6;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Width = 125;
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
            // maskapaiBindingSource
            // 
            this.maskapaiBindingSource.DataMember = "Maskapai";
            this.maskapaiBindingSource.DataSource = this.bromoAirlineDataSet;
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
            this.label2.Size = new System.Drawing.Size(310, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Semua maskapai yang terdaftar akan muncul disini\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Master Maskapai";
            // 
            // maskapaiTableAdapter
            // 
            this.maskapaiTableAdapter.ClearBeforeFill = true;
            // 
            // numJumlahKru
            // 
            this.numJumlahKru.Location = new System.Drawing.Point(149, 488);
            this.numJumlahKru.Name = "numJumlahKru";
            this.numJumlahKru.Size = new System.Drawing.Size(214, 22);
            this.numJumlahKru.TabIndex = 60;
            this.numJumlahKru.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Jumlah Kru";
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
            this.btnExport.TabIndex = 61;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // MaskapaiFrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.numJumlahKru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPerusahaan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MaskapaiFrag";
            this.Size = new System.Drawing.Size(945, 658);
            this.VisibleChanged += new System.EventHandler(this.MaskapaiFrag_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahKru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.RichTextBox tbDeskripsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPerusahaan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn perusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahKru;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.BindingSource maskapaiBindingSource;
        private BromoAirlineDataSet bromoAirlineDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BromoAirlineDataSetTableAdapters.MaskapaiTableAdapter maskapaiTableAdapter;
        private System.Windows.Forms.NumericUpDown numJumlahKru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExport;
    }
}

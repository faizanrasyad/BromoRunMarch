namespace BromoAirlineDesktop.Fragments
{
    partial class PromoFrag
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKodePromo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentaseDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksimumDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.berlakuSampai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kodePromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlineDataSet = new BromoAirlineDesktop.BromoAirlineDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kodePromoTableAdapter = new BromoAirlineDesktop.BromoAirlineDataSetTableAdapters.KodePromoTableAdapter();
            this.dateBerlaku = new System.Windows.Forms.DateTimePicker();
            this.numPersentase = new System.Windows.Forms.NumericUpDown();
            this.numMaksimum = new System.Windows.Forms.NumericUpDown();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersentase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimum)).BeginInit();
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
            this.tbDeskripsi.Location = new System.Drawing.Point(504, 400);
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(254, 110);
            this.tbDeskripsi.TabIndex = 56;
            this.tbDeskripsi.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Deskripsi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Maksimum Disc.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Persentase Disc.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Berlaku Sampai";
            // 
            // tbKodePromo
            // 
            this.tbKodePromo.Location = new System.Drawing.Point(156, 400);
            this.tbKodePromo.Name = "tbKodePromo";
            this.tbKodePromo.Size = new System.Drawing.Size(214, 22);
            this.tbKodePromo.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Kode Promo";
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
            this.kode,
            this.presentaseDiskon,
            this.maksimumDiskon,
            this.berlakuSampai,
            this.deskripsi,
            this.ubah,
            this.hapus});
            this.dataGridView1.DataSource = this.kodePromoBindingSource;
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
            // kode
            // 
            this.kode.DataPropertyName = "kode";
            this.kode.HeaderText = "Kode Promo";
            this.kode.MinimumWidth = 6;
            this.kode.Name = "kode";
            this.kode.Width = 125;
            // 
            // presentaseDiskon
            // 
            this.presentaseDiskon.DataPropertyName = "presentaseDiskon";
            this.presentaseDiskon.HeaderText = "Presentase Diskon";
            this.presentaseDiskon.MinimumWidth = 6;
            this.presentaseDiskon.Name = "presentaseDiskon";
            this.presentaseDiskon.Width = 125;
            // 
            // maksimumDiskon
            // 
            this.maksimumDiskon.DataPropertyName = "maksimumDiskon";
            this.maksimumDiskon.HeaderText = "Maksimum Diskon";
            this.maksimumDiskon.MinimumWidth = 6;
            this.maksimumDiskon.Name = "maksimumDiskon";
            this.maksimumDiskon.Width = 125;
            // 
            // berlakuSampai
            // 
            this.berlakuSampai.DataPropertyName = "berlakuSampai";
            this.berlakuSampai.HeaderText = "Berlaku Sampai";
            this.berlakuSampai.MinimumWidth = 6;
            this.berlakuSampai.Name = "berlakuSampai";
            this.berlakuSampai.Width = 125;
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
            // kodePromoBindingSource
            // 
            this.kodePromoBindingSource.DataMember = "KodePromo";
            this.kodePromoBindingSource.DataSource = this.bromoAirlineDataSet;
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
            this.label2.Size = new System.Drawing.Size(289, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Semua promo yang terdaftar akan muncul disini\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Master Promo";
            // 
            // kodePromoTableAdapter
            // 
            this.kodePromoTableAdapter.ClearBeforeFill = true;
            // 
            // dateBerlaku
            // 
            this.dateBerlaku.Location = new System.Drawing.Point(156, 446);
            this.dateBerlaku.Name = "dateBerlaku";
            this.dateBerlaku.Size = new System.Drawing.Size(214, 22);
            this.dateBerlaku.TabIndex = 59;
            // 
            // numPersentase
            // 
            this.numPersentase.Location = new System.Drawing.Point(156, 492);
            this.numPersentase.Name = "numPersentase";
            this.numPersentase.Size = new System.Drawing.Size(214, 22);
            this.numPersentase.TabIndex = 60;
            this.numPersentase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMaksimum
            // 
            this.numMaksimum.Location = new System.Drawing.Point(157, 535);
            this.numMaksimum.Name = "numMaksimum";
            this.numMaksimum.Size = new System.Drawing.Size(214, 22);
            this.numMaksimum.TabIndex = 61;
            this.numMaksimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.btnExport.TabIndex = 62;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // PromoFrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.numMaksimum);
            this.Controls.Add(this.numPersentase);
            this.Controls.Add(this.dateBerlaku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKodePromo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PromoFrag";
            this.Size = new System.Drawing.Size(945, 658);
            this.Load += new System.EventHandler(this.PromoFrag_Load);
            this.VisibleChanged += new System.EventHandler(this.PromoFrag_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersentase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.RichTextBox tbDeskripsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKodePromo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentaseDiskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksimumDiskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn berlakuSampai;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private System.Windows.Forms.BindingSource kodePromoBindingSource;
        private BromoAirlineDataSet bromoAirlineDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BromoAirlineDataSetTableAdapters.KodePromoTableAdapter kodePromoTableAdapter;
        private System.Windows.Forms.DateTimePicker dateBerlaku;
        private System.Windows.Forms.NumericUpDown numPersentase;
        private System.Windows.Forms.NumericUpDown numMaksimum;
        private System.Windows.Forms.Button btnExport;
    }
}

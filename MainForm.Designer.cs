namespace BromoAirlineDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLogout = new System.Windows.Forms.Label();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lbPromo = new System.Windows.Forms.Label();
            this.pbPromo = new System.Windows.Forms.PictureBox();
            this.lbJadwal = new System.Windows.Forms.Label();
            this.pbJadwal = new System.Windows.Forms.PictureBox();
            this.lbMaskapai = new System.Windows.Forms.Label();
            this.pbMaskapai = new System.Windows.Forms.PictureBox();
            this.lbBandara = new System.Windows.Forms.Label();
            this.pbBandara = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bandaraFrag1 = new BromoAirlineDesktop.Fragments.BandaraFrag();
            this.jadwalPenerbanganFrag1 = new BromoAirlineDesktop.Fragments.JadwalPenerbanganFrag();
            this.maskapaiFrag1 = new BromoAirlineDesktop.Fragments.MaskapaiFrag();
            this.promoFrag1 = new BromoAirlineDesktop.Fragments.PromoFrag();
            this.statusPenerbanganFrag1 = new BromoAirlineDesktop.Fragments.StatusPenerbanganFrag();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandara)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.fragmentContainer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 80);
            this.panel1.TabIndex = 0;
            // 
            // fragmentContainer
            // 
            this.fragmentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fragmentContainer.Location = new System.Drawing.Point(233, 80);
            this.fragmentContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fragmentContainer.Name = "fragmentContainer";
            this.fragmentContainer.Size = new System.Drawing.Size(200, 171);
            this.fragmentContainer.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dashboard";
            // 
            // pbDashboard
            // 
            this.pbDashboard.Image = global::BromoAirlineDesktop.Properties.Resources.menu_alt_72;
            this.pbDashboard.Location = new System.Drawing.Point(9, 26);
            this.pbDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(29, 31);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDashboard.TabIndex = 0;
            this.pbDashboard.TabStop = false;
            this.pbDashboard.Click += new System.EventHandler(this.pbDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbLogout);
            this.panel2.Controls.Add(this.pbLogout);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.pbStatus);
            this.panel2.Controls.Add(this.lbPromo);
            this.panel2.Controls.Add(this.pbPromo);
            this.panel2.Controls.Add(this.lbJadwal);
            this.panel2.Controls.Add(this.pbJadwal);
            this.panel2.Controls.Add(this.lbMaskapai);
            this.panel2.Controls.Add(this.pbMaskapai);
            this.panel2.Controls.Add(this.lbBandara);
            this.panel2.Controls.Add(this.pbBandara);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 534);
            this.panel2.TabIndex = 23;
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.Red;
            this.lbLogout.Location = new System.Drawing.Point(44, 490);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(52, 17);
            this.lbLogout.TabIndex = 32;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::BromoAirlineDesktop.Properties.Resources.log_out_unselected_72;
            this.pbLogout.Location = new System.Drawing.Point(10, 482);
            this.pbLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(29, 31);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 31;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lbStatus.Location = new System.Drawing.Point(43, 199);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(176, 17);
            this.lbStatus.TabIndex = 30;
            this.lbStatus.Text = "Ubah Status Penerbangan";
            this.lbStatus.Click += new System.EventHandler(this.pbStatus_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::BromoAirlineDesktop.Properties.Resources.notepad_unselected_72;
            this.pbStatus.Location = new System.Drawing.Point(9, 191);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(29, 31);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStatus.TabIndex = 29;
            this.pbStatus.TabStop = false;
            this.pbStatus.Click += new System.EventHandler(this.pbStatus_Click);
            // 
            // lbPromo
            // 
            this.lbPromo.AutoSize = true;
            this.lbPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromo.ForeColor = System.Drawing.Color.Gray;
            this.lbPromo.Location = new System.Drawing.Point(43, 157);
            this.lbPromo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPromo.Name = "lbPromo";
            this.lbPromo.Size = new System.Drawing.Size(133, 17);
            this.lbPromo.TabIndex = 28;
            this.lbPromo.Text = "Master Kode Promo";
            this.lbPromo.Click += new System.EventHandler(this.pbPromo_Click);
            // 
            // pbPromo
            // 
            this.pbPromo.Image = global::BromoAirlineDesktop.Properties.Resources.purchase_tag_alt_unselected_72;
            this.pbPromo.Location = new System.Drawing.Point(9, 149);
            this.pbPromo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPromo.Name = "pbPromo";
            this.pbPromo.Size = new System.Drawing.Size(29, 31);
            this.pbPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPromo.TabIndex = 27;
            this.pbPromo.TabStop = false;
            this.pbPromo.Click += new System.EventHandler(this.pbPromo_Click);
            // 
            // lbJadwal
            // 
            this.lbJadwal.AutoSize = true;
            this.lbJadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJadwal.ForeColor = System.Drawing.Color.Gray;
            this.lbJadwal.Location = new System.Drawing.Point(43, 116);
            this.lbJadwal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbJadwal.Name = "lbJadwal";
            this.lbJadwal.Size = new System.Drawing.Size(188, 17);
            this.lbJadwal.TabIndex = 26;
            this.lbJadwal.Text = "Master Jadwal Penerbangan";
            this.lbJadwal.Click += new System.EventHandler(this.pbJadwal_Click);
            // 
            // pbJadwal
            // 
            this.pbJadwal.Image = global::BromoAirlineDesktop.Properties.Resources.calendar_unselected_72;
            this.pbJadwal.Location = new System.Drawing.Point(9, 108);
            this.pbJadwal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbJadwal.Name = "pbJadwal";
            this.pbJadwal.Size = new System.Drawing.Size(29, 31);
            this.pbJadwal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJadwal.TabIndex = 25;
            this.pbJadwal.TabStop = false;
            this.pbJadwal.Click += new System.EventHandler(this.pbJadwal_Click);
            // 
            // lbMaskapai
            // 
            this.lbMaskapai.AutoSize = true;
            this.lbMaskapai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaskapai.ForeColor = System.Drawing.Color.Gray;
            this.lbMaskapai.Location = new System.Drawing.Point(43, 75);
            this.lbMaskapai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaskapai.Name = "lbMaskapai";
            this.lbMaskapai.Size = new System.Drawing.Size(115, 17);
            this.lbMaskapai.TabIndex = 24;
            this.lbMaskapai.Text = "Master Maskapai";
            this.lbMaskapai.Click += new System.EventHandler(this.pbMaskapai_Click);
            // 
            // pbMaskapai
            // 
            this.pbMaskapai.Image = global::BromoAirlineDesktop.Properties.Resources.plane_take_off_unselected_72;
            this.pbMaskapai.Location = new System.Drawing.Point(9, 67);
            this.pbMaskapai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMaskapai.Name = "pbMaskapai";
            this.pbMaskapai.Size = new System.Drawing.Size(29, 31);
            this.pbMaskapai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaskapai.TabIndex = 23;
            this.pbMaskapai.TabStop = false;
            this.pbMaskapai.Click += new System.EventHandler(this.pbMaskapai_Click);
            // 
            // lbBandara
            // 
            this.lbBandara.AutoSize = true;
            this.lbBandara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBandara.ForeColor = System.Drawing.Color.Gray;
            this.lbBandara.Location = new System.Drawing.Point(43, 34);
            this.lbBandara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBandara.Name = "lbBandara";
            this.lbBandara.Size = new System.Drawing.Size(109, 17);
            this.lbBandara.TabIndex = 22;
            this.lbBandara.Text = "Master Bandara";
            this.lbBandara.Click += new System.EventHandler(this.pbBandara_Click);
            // 
            // pbBandara
            // 
            this.pbBandara.Image = global::BromoAirlineDesktop.Properties.Resources.map_unselected_72;
            this.pbBandara.Location = new System.Drawing.Point(9, 26);
            this.pbBandara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBandara.Name = "pbBandara";
            this.pbBandara.Size = new System.Drawing.Size(29, 31);
            this.pbBandara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBandara.TabIndex = 0;
            this.pbBandara.TabStop = false;
            this.pbBandara.Click += new System.EventHandler(this.pbBandara_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.bandaraFrag1);
            this.flowLayoutPanel1.Controls.Add(this.jadwalPenerbanganFrag1);
            this.flowLayoutPanel1.Controls.Add(this.maskapaiFrag1);
            this.flowLayoutPanel1.Controls.Add(this.promoFrag1);
            this.flowLayoutPanel1.Controls.Add(this.statusPenerbanganFrag1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(229, 80);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(709, 535);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // bandaraFrag1
            // 
            this.bandaraFrag1.Location = new System.Drawing.Point(2, 2);
            this.bandaraFrag1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bandaraFrag1.Name = "bandaraFrag1";
            this.bandaraFrag1.Size = new System.Drawing.Size(709, 535);
            this.bandaraFrag1.TabIndex = 4;
            // 
            // jadwalPenerbanganFrag1
            // 
            this.jadwalPenerbanganFrag1.Location = new System.Drawing.Point(2, 541);
            this.jadwalPenerbanganFrag1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jadwalPenerbanganFrag1.Name = "jadwalPenerbanganFrag1";
            this.jadwalPenerbanganFrag1.Size = new System.Drawing.Size(709, 535);
            this.jadwalPenerbanganFrag1.TabIndex = 3;
            // 
            // maskapaiFrag1
            // 
            this.maskapaiFrag1.Location = new System.Drawing.Point(2, 1080);
            this.maskapaiFrag1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskapaiFrag1.Name = "maskapaiFrag1";
            this.maskapaiFrag1.Size = new System.Drawing.Size(709, 535);
            this.maskapaiFrag1.TabIndex = 2;
            // 
            // promoFrag1
            // 
            this.promoFrag1.Location = new System.Drawing.Point(2, 1619);
            this.promoFrag1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.promoFrag1.Name = "promoFrag1";
            this.promoFrag1.Size = new System.Drawing.Size(709, 535);
            this.promoFrag1.TabIndex = 1;
            // 
            // statusPenerbanganFrag1
            // 
            this.statusPenerbanganFrag1.Location = new System.Drawing.Point(2, 2158);
            this.statusPenerbanganFrag1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusPenerbanganFrag1.Name = "statusPenerbanganFrag1";
            this.statusPenerbanganFrag1.Size = new System.Drawing.Size(709, 535);
            this.statusPenerbanganFrag1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 614);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Bromo Airlines - Admin Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandara)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbBandara;
        private System.Windows.Forms.PictureBox pbBandara;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lbPromo;
        private System.Windows.Forms.PictureBox pbPromo;
        private System.Windows.Forms.Label lbJadwal;
        private System.Windows.Forms.PictureBox pbJadwal;
        private System.Windows.Forms.Label lbMaskapai;
        private System.Windows.Forms.PictureBox pbMaskapai;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.FlowLayoutPanel fragmentContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Fragments.StatusPenerbanganFrag statusPenerbanganFrag1;
        private Fragments.BandaraFrag bandaraFrag1;
        private Fragments.JadwalPenerbanganFrag jadwalPenerbanganFrag1;
        private Fragments.MaskapaiFrag maskapaiFrag1;
        private Fragments.PromoFrag promoFrag1;
    }
}
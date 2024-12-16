namespace BromoAirlineDesktop
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnLihat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLihat
            // 
            this.btnLihat.BackColor = System.Drawing.Color.Silver;
            this.btnLihat.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLihat.ForeColor = System.Drawing.Color.Black;
            this.btnLihat.Location = new System.Drawing.Point(144, 353);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(120, 26);
            this.btnLihat.TabIndex = 36;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.UseVisualStyleBackColor = false;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BromoAirlineDesktop.Properties.Resources.Logo_Rect___Without_Tagline___Without_Padding;
            this.pictureBox1.Location = new System.Drawing.Point(450, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(165, 503);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 16);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Sudah punya akun?";
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.Silver;
            this.btnDaftar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.ForeColor = System.Drawing.Color.Black;
            this.btnDaftar.Location = new System.Drawing.Point(229, 410);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(129, 35);
            this.btnDaftar.TabIndex = 32;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(144, 325);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(214, 22);
            this.tbPass.TabIndex = 31;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Password";
            // 
            // tbTelp
            // 
            this.tbTelp.Location = new System.Drawing.Point(144, 281);
            this.tbTelp.MaxLength = 12;
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(214, 22);
            this.tbTelp.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nomor Telepon";
            // 
            // dateTanggalLahir
            // 
            this.dateTanggalLahir.Location = new System.Drawing.Point(144, 237);
            this.dateTanggalLahir.Name = "dateTanggalLahir";
            this.dateTanggalLahir.Size = new System.Drawing.Size(214, 22);
            this.dateTanggalLahir.TabIndex = 27;
            this.dateTanggalLahir.Value = new System.DateTime(2024, 2, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tanggal Lahir";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(144, 192);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(214, 22);
            this.tbNama.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nama";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(144, 149);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(214, 22);
            this.tbUsername.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Daftarkan diri anda untuk menggunakan Bromo Airlines!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Daftar Akun";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 545);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTelp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTanggalLahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Bromo Airlines - Daftar Akun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTanggalLahir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
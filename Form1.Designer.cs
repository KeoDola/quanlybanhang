
namespace quản_lý_bán_hàng
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonNV = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new quản_lý_bán_hàng.customButton();
            this.textBoxUsername = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxPassword = new quản_lý_bán_hàng.textBoxCustom();
            this.radioButtonKH = new System.Windows.Forms.RadioButton();
            this.linkLabelDki = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::quản_lý_bán_hàng.Properties.Resources.Stop;
            this.pictureBox1.Location = new System.Drawing.Point(447, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::quản_lý_bán_hàng.Properties.Resources.tải_xuống__1_;
            this.pictureBox2.Location = new System.Drawing.Point(41, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.ForeColor = System.Drawing.Color.Black;
            this.radioButtonAdmin.Location = new System.Drawing.Point(146, 321);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(68, 20);
            this.radioButtonAdmin.TabIndex = 6;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = false;
            // 
            // radioButtonNV
            // 
            this.radioButtonNV.AutoSize = true;
            this.radioButtonNV.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNV.ForeColor = System.Drawing.Color.Black;
            this.radioButtonNV.Location = new System.Drawing.Point(242, 321);
            this.radioButtonNV.Name = "radioButtonNV";
            this.radioButtonNV.Size = new System.Drawing.Size(92, 20);
            this.radioButtonNV.TabIndex = 6;
            this.radioButtonNV.TabStop = true;
            this.radioButtonNV.Text = "Nhân viên";
            this.radioButtonNV.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::quản_lý_bán_hàng.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(169, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::quản_lý_bán_hàng.Properties.Resources.key;
            this.pictureBox4.Location = new System.Drawing.Point(171, 257);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BoderRadius = 40;
            this.buttonLogin.BoderSize = 0;
            this.buttonLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.Maroon;
            this.buttonLogin.Location = new System.Drawing.Point(211, 356);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.ReadOnly = false;
            this.buttonLogin.Size = new System.Drawing.Size(211, 41);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextColor = System.Drawing.Color.Maroon;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUsername.BorderColor = System.Drawing.Color.Gray;
            this.textBoxUsername.BorderSize = 1;
            this.textBoxUsername.Br = System.Drawing.Color.Silver;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(211, 192);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.ReadOnly = false;
            this.textBoxUsername.Size = new System.Drawing.Size(211, 33);
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.textboxRadius = 12;
            this.textBoxUsername.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPassword.BorderColor = System.Drawing.Color.Gray;
            this.textBoxPassword.BorderSize = 1;
            this.textBoxPassword.Br = System.Drawing.Color.Silver;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(211, 257);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.Size = new System.Drawing.Size(211, 33);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.textboxRadius = 12;
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // radioButtonKH
            // 
            this.radioButtonKH.AutoSize = true;
            this.radioButtonKH.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonKH.ForeColor = System.Drawing.Color.Black;
            this.radioButtonKH.Location = new System.Drawing.Point(344, 321);
            this.radioButtonKH.Name = "radioButtonKH";
            this.radioButtonKH.Size = new System.Drawing.Size(105, 20);
            this.radioButtonKH.TabIndex = 12;
            this.radioButtonKH.TabStop = true;
            this.radioButtonKH.Text = "Khách hàng";
            this.radioButtonKH.UseVisualStyleBackColor = false;
            // 
            // linkLabelDki
            // 
            this.linkLabelDki.AutoSize = true;
            this.linkLabelDki.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelDki.LinkColor = System.Drawing.Color.Black;
            this.linkLabelDki.Location = new System.Drawing.Point(208, 409);
            this.linkLabelDki.Name = "linkLabelDki";
            this.linkLabelDki.Size = new System.Drawing.Size(214, 16);
            this.linkLabelDki.TabIndex = 13;
            this.linkLabelDki.TabStop = true;
            this.linkLabelDki.Text = "Bạn chưa có tài khoản? Đăng ký";
            this.linkLabelDki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDki_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(222, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::quản_lý_bán_hàng.Properties.Resources.papers_co_sm07_pink_blue_soft_pastel_blur_gradation_31_wallpaper;
            this.ClientSize = new System.Drawing.Size(475, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelDki);
            this.Controls.Add(this.radioButtonKH);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.radioButtonNV);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.RadioButton radioButtonNV;
        public System.Windows.Forms.RadioButton radioButtonAdmin;
        public textBoxCustom textBoxPassword;
        public textBoxCustom textBoxUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public customButton buttonLogin;
        public System.Windows.Forms.RadioButton radioButtonKH;
        public System.Windows.Forms.LinkLabel linkLabelDki;
        private System.Windows.Forms.Label label1;
    }
}


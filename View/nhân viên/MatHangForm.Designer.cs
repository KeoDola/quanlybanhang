
namespace quản_lý_bán_hàng
{
    partial class MatHangForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMaHang = new quản_lý_bán_hàng.textBoxCustom();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSL = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxGia = new quản_lý_bán_hàng.textBoxCustom();
            this.textBoxTenMH = new quản_lý_bán_hàng.textBoxCustom();
            this.comboBoxLoaiHang = new System.Windows.Forms.ComboBox();
            this.buttonSua = new quản_lý_bán_hàng.customButton();
            this.buttonXoa = new quản_lý_bán_hàng.customButton();
            this.buttonReset = new quản_lý_bán_hàng.customButton();
            this.buttonNhap = new quản_lý_bán_hàng.customButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelThongTinKho = new System.Windows.Forms.Label();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new quản_lý_bán_hàng.customButton();
            this.textBoxTimKiem = new quản_lý_bán_hàng.textBoxCustom();
            this.radioButtonTenMH = new System.Windows.Forms.RadioButton();
            this.radioButtonMaMH = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(962, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 750);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxMaHang);
            this.panel1.Controls.Add(this.pictureBoxNhanVien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxSL);
            this.panel1.Controls.Add(this.textBoxGia);
            this.panel1.Controls.Add(this.textBoxTenMH);
            this.panel1.Controls.Add(this.comboBoxLoaiHang);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 729);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "VNĐ";
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaHang.BorderColor = System.Drawing.Color.Gray;
            this.textBoxMaHang.BorderSize = 1;
            this.textBoxMaHang.Br = System.Drawing.Color.White;
            this.textBoxMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxMaHang.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaHang.Location = new System.Drawing.Point(125, 15);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.PasswordChar = '\0';
            this.textBoxMaHang.ReadOnly = false;
            this.textBoxMaHang.Size = new System.Drawing.Size(158, 29);
            this.textBoxMaHang.TabIndex = 10;
            this.textBoxMaHang.textboxRadius = 12;
            this.textBoxMaHang.UseSystemPasswordChar = false;
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.BackColor = System.Drawing.Color.White;
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(207, 609);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(116, 120);
            this.pictureBoxNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNhanVien.TabIndex = 8;
            this.pictureBoxNhanVien.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // textBoxSL
            // 
            this.textBoxSL.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSL.BorderColor = System.Drawing.Color.Gray;
            this.textBoxSL.BorderSize = 1;
            this.textBoxSL.Br = System.Drawing.Color.White;
            this.textBoxSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxSL.ForeColor = System.Drawing.Color.Black;
            this.textBoxSL.Location = new System.Drawing.Point(125, 440);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.PasswordChar = '\0';
            this.textBoxSL.ReadOnly = false;
            this.textBoxSL.Size = new System.Drawing.Size(158, 29);
            this.textBoxSL.TabIndex = 4;
            this.textBoxSL.textboxRadius = 12;
            this.textBoxSL.UseSystemPasswordChar = false;
            // 
            // textBoxGia
            // 
            this.textBoxGia.BackColor = System.Drawing.Color.Transparent;
            this.textBoxGia.BorderColor = System.Drawing.Color.Gray;
            this.textBoxGia.BorderSize = 1;
            this.textBoxGia.Br = System.Drawing.Color.White;
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxGia.ForeColor = System.Drawing.Color.Black;
            this.textBoxGia.Location = new System.Drawing.Point(125, 219);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.PasswordChar = '\0';
            this.textBoxGia.ReadOnly = false;
            this.textBoxGia.Size = new System.Drawing.Size(132, 29);
            this.textBoxGia.TabIndex = 4;
            this.textBoxGia.textboxRadius = 12;
            this.textBoxGia.UseSystemPasswordChar = false;
            // 
            // textBoxTenMH
            // 
            this.textBoxTenMH.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTenMH.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTenMH.BorderSize = 1;
            this.textBoxTenMH.Br = System.Drawing.Color.White;
            this.textBoxTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTenMH.ForeColor = System.Drawing.Color.Black;
            this.textBoxTenMH.Location = new System.Drawing.Point(125, 130);
            this.textBoxTenMH.Name = "textBoxTenMH";
            this.textBoxTenMH.PasswordChar = '\0';
            this.textBoxTenMH.ReadOnly = false;
            this.textBoxTenMH.Size = new System.Drawing.Size(158, 29);
            this.textBoxTenMH.TabIndex = 4;
            this.textBoxTenMH.textboxRadius = 12;
            this.textBoxTenMH.UseSystemPasswordChar = false;
            this.textBoxTenMH.Click += new System.EventHandler(this.textBoxCustom1_Click);
            // 
            // comboBoxLoaiHang
            // 
            this.comboBoxLoaiHang.FormattingEnabled = true;
            this.comboBoxLoaiHang.Items.AddRange(new object[] {
            "Khô",
            "Đông lạnh",
            "Gia dụng",
            "Hóa phẩm",
            "Mỹ phẩm",
            "Quần áo"});
            this.comboBoxLoaiHang.Location = new System.Drawing.Point(125, 71);
            this.comboBoxLoaiHang.Name = "comboBoxLoaiHang";
            this.comboBoxLoaiHang.Size = new System.Drawing.Size(158, 24);
            this.comboBoxLoaiHang.TabIndex = 3;
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSua.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonSua.BoderRadius = 40;
            this.buttonSua.BoderSize = 0;
            this.buttonSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(178, 493);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.ReadOnly = false;
            this.buttonSua.Size = new System.Drawing.Size(119, 40);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Điều chỉnh";
            this.buttonSua.TextColor = System.Drawing.Color.White;
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonXoa.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonXoa.BoderRadius = 40;
            this.buttonXoa.BoderSize = 0;
            this.buttonXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(24, 548);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.ReadOnly = false;
            this.buttonXoa.Size = new System.Drawing.Size(116, 40);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Hủy Hàng";
            this.buttonXoa.TextColor = System.Drawing.Color.White;
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReset.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonReset.BoderRadius = 40;
            this.buttonReset.BoderSize = 0;
            this.buttonReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(181, 548);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.ReadOnly = false;
            this.buttonReset.Size = new System.Drawing.Size(116, 40);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.TextColor = System.Drawing.Color.White;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonNhap
            // 
            this.buttonNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonNhap.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonNhap.BoderRadius = 40;
            this.buttonNhap.BoderSize = 0;
            this.buttonNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonNhap.FlatAppearance.BorderSize = 0;
            this.buttonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhap.ForeColor = System.Drawing.Color.White;
            this.buttonNhap.Location = new System.Drawing.Point(24, 493);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.ReadOnly = false;
            this.buttonNhap.Size = new System.Drawing.Size(116, 40);
            this.buttonNhap.TabIndex = 2;
            this.buttonNhap.Text = "Nhập vào kho";
            this.buttonNhap.TextColor = System.Drawing.Color.White;
            this.buttonNhap.UseVisualStyleBackColor = false;
            this.buttonNhap.Click += new System.EventHandler(this.buttonNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá/sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mặt hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.labelNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 608);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 121);
            this.panel3.TabIndex = 11;
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNhanVien.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhanVien.Location = new System.Drawing.Point(5, 1);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Size = new System.Drawing.Size(197, 83);
            this.labelNhanVien.TabIndex = 9;
            this.labelNhanVien.Text = "Nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelThongTinKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 55);
            this.panel2.TabIndex = 2;
            // 
            // labelThongTinKho
            // 
            this.labelThongTinKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelThongTinKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelThongTinKho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongTinKho.Location = new System.Drawing.Point(52, 16);
            this.labelThongTinKho.Name = "labelThongTinKho";
            this.labelThongTinKho.Size = new System.Drawing.Size(267, 24);
            this.labelThongTinKho.TabIndex = 0;
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Location = new System.Drawing.Point(3, 117);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 24;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(957, 574);
            this.dataGridViewMatHang.TabIndex = 1;
            this.dataGridViewMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellClick);
            this.dataGridViewMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.Controls.Add(this.buttonTimKiem);
            this.panel4.Controls.Add(this.textBoxTimKiem);
            this.panel4.Controls.Add(this.radioButtonTenMH);
            this.panel4.Controls.Add(this.radioButtonMaMH);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 111);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTimKiem.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonTimKiem.BoderRadius = 40;
            this.buttonTimKiem.BoderSize = 0;
            this.buttonTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonTimKiem.FlatAppearance.BorderSize = 0;
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.buttonTimKiem.ForeColor = System.Drawing.Color.White;
            this.buttonTimKiem.Location = new System.Drawing.Point(574, 51);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.ReadOnly = false;
            this.buttonTimKiem.Size = new System.Drawing.Size(131, 40);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.TextColor = System.Drawing.Color.White;
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTimKiem.BorderColor = System.Drawing.Color.Gray;
            this.textBoxTimKiem.BorderSize = 1;
            this.textBoxTimKiem.Br = System.Drawing.Color.White;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.Black;
            this.textBoxTimKiem.Location = new System.Drawing.Point(347, 61);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.PasswordChar = '\0';
            this.textBoxTimKiem.ReadOnly = false;
            this.textBoxTimKiem.Size = new System.Drawing.Size(211, 30);
            this.textBoxTimKiem.TabIndex = 7;
            this.textBoxTimKiem.textboxRadius = 12;
            this.textBoxTimKiem.UseSystemPasswordChar = false;
            // 
            // radioButtonTenMH
            // 
            this.radioButtonTenMH.AutoSize = true;
            this.radioButtonTenMH.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.radioButtonTenMH.Location = new System.Drawing.Point(456, 33);
            this.radioButtonTenMH.Name = "radioButtonTenMH";
            this.radioButtonTenMH.Size = new System.Drawing.Size(117, 20);
            this.radioButtonTenMH.TabIndex = 6;
            this.radioButtonTenMH.TabStop = true;
            this.radioButtonTenMH.Text = "Tên mặt hàng";
            this.radioButtonTenMH.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaMH
            // 
            this.radioButtonMaMH.AutoSize = true;
            this.radioButtonMaMH.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic);
            this.radioButtonMaMH.Location = new System.Drawing.Point(347, 33);
            this.radioButtonMaMH.Name = "radioButtonMaMH";
            this.radioButtonMaMH.Size = new System.Drawing.Size(112, 20);
            this.radioButtonMaMH.TabIndex = 5;
            this.radioButtonMaMH.TabStop = true;
            this.radioButtonMaMH.Text = "Mã mặt hàng";
            this.radioButtonMaMH.UseVisualStyleBackColor = true;
            // 
            // MatHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "MatHangForm";
            this.Size = new System.Drawing.Size(1291, 750);
            this.Load += new System.EventHandler(this.MatHangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelThongTinKho;
        public System.Windows.Forms.DataGridView dataGridViewMatHang;
        public System.Windows.Forms.Label label5;
        public textBoxCustom textBoxSL;
        public textBoxCustom textBoxGia;
        public textBoxCustom textBoxTenMH;
        public System.Windows.Forms.ComboBox comboBoxLoaiHang;
        public customButton buttonSua;
        public customButton buttonXoa;
        public customButton buttonReset;
        public customButton buttonNhap;
        public System.Windows.Forms.Label labelNhanVien;
        public System.Windows.Forms.PictureBox pictureBoxNhanVien;
        public textBoxCustom textBoxMaHang;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        public customButton buttonTimKiem;
        public textBoxCustom textBoxTimKiem;
        public System.Windows.Forms.RadioButton radioButtonTenMH;
        public System.Windows.Forms.RadioButton radioButtonMaMH;
    }
}

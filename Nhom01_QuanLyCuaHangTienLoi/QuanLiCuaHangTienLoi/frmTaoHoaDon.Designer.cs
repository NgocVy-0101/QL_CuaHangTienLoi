namespace QuanLiCuaHangTienLoi
{
    partial class frmTaoHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dateNhap = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupChiTiet = new System.Windows.Forms.GroupBox();
            this.ckbGiamGia = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.lblNV = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThanhT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.dateNhap);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.cboKH);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hóa đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(899, 115);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(210, 32);
            this.txtMaKH.TabIndex = 29;
            // 
            // dateNhap
            // 
            this.dateNhap.Enabled = false;
            this.dateNhap.Location = new System.Drawing.Point(166, 109);
            this.dateNhap.Name = "dateNhap";
            this.dateNhap.Size = new System.Drawing.Size(196, 30);
            this.dateNhap.TabIndex = 25;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightCoral;
            this.btnLuu.Location = new System.Drawing.Point(260, 159);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 44);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(785, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tên khách";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTao.Location = new System.Drawing.Point(34, 159);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(180, 44);
            this.btnTao.TabIndex = 23;
            this.btnTao.Text = "Tạo hóa đơn";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboKH
            // 
            this.cboKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(899, 46);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(210, 34);
            this.cboKH.TabIndex = 26;
            this.cboKH.SelectedIndexChanged += new System.EventHandler(this.cboKH_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(557, 115);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(193, 32);
            this.txtThanhTien.TabIndex = 22;
            this.txtThanhTien.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(785, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Mã khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(166, 46);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(196, 32);
            this.txtMa.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập";
            // 
            // cboNCC
            // 
            this.cboNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(557, 46);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(193, 34);
            this.cboNCC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 35);
            this.label1.TabIndex = 54;
            this.label1.Text = "Quản Lý Hóa Đơn";
            // 
            // groupChiTiet
            // 
            this.groupChiTiet.BackColor = System.Drawing.Color.AliceBlue;
            this.groupChiTiet.Controls.Add(this.txtThanhT);
            this.groupChiTiet.Controls.Add(this.label13);
            this.groupChiTiet.Controls.Add(this.label10);
            this.groupChiTiet.Controls.Add(this.ckbGiamGia);
            this.groupChiTiet.Controls.Add(this.txtGiamGia);
            this.groupChiTiet.Controls.Add(this.btnXoa);
            this.groupChiTiet.Controls.Add(this.txtMaSP);
            this.groupChiTiet.Controls.Add(this.btnThem);
            this.groupChiTiet.Controls.Add(this.btnIn);
            this.groupChiTiet.Controls.Add(this.txtSL);
            this.groupChiTiet.Controls.Add(this.label6);
            this.groupChiTiet.Controls.Add(this.label7);
            this.groupChiTiet.Controls.Add(this.txtTenSP);
            this.groupChiTiet.Controls.Add(this.txtDonGia);
            this.groupChiTiet.Controls.Add(this.label8);
            this.groupChiTiet.Controls.Add(this.label9);
            this.groupChiTiet.Enabled = false;
            this.groupChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupChiTiet.Location = new System.Drawing.Point(32, 278);
            this.groupChiTiet.Name = "groupChiTiet";
            this.groupChiTiet.Size = new System.Drawing.Size(1142, 213);
            this.groupChiTiet.TabIndex = 55;
            this.groupChiTiet.TabStop = false;
            this.groupChiTiet.Text = "Chi tiết hóa đơn";
            // 
            // ckbGiamGia
            // 
            this.ckbGiamGia.AutoSize = true;
            this.ckbGiamGia.Location = new System.Drawing.Point(955, 54);
            this.ckbGiamGia.Name = "ckbGiamGia";
            this.ckbGiamGia.Size = new System.Drawing.Size(18, 17);
            this.ckbGiamGia.TabIndex = 30;
            this.ckbGiamGia.UseVisualStyleBackColor = true;
            this.ckbGiamGia.CheckedChanged += new System.EventHandler(this.ckbGiamGia_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Plum;
            this.btnXoa.Location = new System.Drawing.Point(299, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 44);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(604, 45);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(205, 32);
            this.txtMaSP.TabIndex = 26;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Thistle;
            this.btnThem.Location = new System.Drawing.Point(49, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 44);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Violet;
            this.btnIn.Location = new System.Drawing.Point(557, 163);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(180, 44);
            this.btnIn.TabIndex = 24;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(604, 108);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(205, 32);
            this.txtSL.TabIndex = 22;
            this.txtSL.Text = "1";
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(177, 46);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(240, 32);
            this.txtTenSP.TabIndex = 17;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(177, 108);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(240, 32);
            this.txtDonGia.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Đơn giá";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(589, 497);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(585, 206);
            this.dgvChiTiet.TabIndex = 56;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(32, 497);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(499, 206);
            this.dgvSanPham.TabIndex = 57;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(35, 9);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(80, 17);
            this.lblNV.TabIndex = 58;
            this.lblNV.Text = "Nhân viên: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(848, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Giảm giá";
            // 
            // txtThanhT
            // 
            this.txtThanhT.Enabled = false;
            this.txtThanhT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhT.Location = new System.Drawing.Point(979, 108);
            this.txtThanhT.Name = "txtThanhT";
            this.txtThanhT.Size = new System.Drawing.Size(142, 32);
            this.txtThanhT.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(848, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Thành tiền";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(979, 45);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(142, 32);
            this.txtGiamGia.TabIndex = 29;
            this.txtGiamGia.Text = "0";
            // 
            // frmTaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiCuaHangTienLoi.Properties.Resources.hinh2;
            this.ClientSize = new System.Drawing.Size(1186, 713);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.groupChiTiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTaoHoaDon";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.frmTaoHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupChiTiet.ResumeLayout(false);
            this.groupChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupChiTiet;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DateTimePicker dateNhap;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ckbGiamGia;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.TextBox txtThanhT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiamGia;
    }
}
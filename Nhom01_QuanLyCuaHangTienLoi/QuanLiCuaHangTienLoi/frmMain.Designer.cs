﻿namespace QuanLiCuaHangTienLoi
{
    partial class frmMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTop10 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnKhach = new System.Windows.Forms.Button();
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.dgvTop10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(657, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(748, 459);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top sản phẩm bán chạy";
            // 
            // dgvTop10
            // 
            this.dgvTop10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop10.Location = new System.Drawing.Point(6, 27);
            this.dgvTop10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTop10.Name = "dgvTop10";
            this.dgvTop10.RowHeadersWidth = 51;
            this.dgvTop10.RowTemplate.Height = 24;
            this.dgvTop10.Size = new System.Drawing.Size(736, 428);
            this.dgvTop10.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnNCC);
            this.panel1.Controls.Add(this.btnKhach);
            this.panel1.Controls.Add(this.btnLoaiSP);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 727);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Goldenrod;
            this.btnThongKe.Location = new System.Drawing.Point(20, 646);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(187, 46);
            this.btnThongKe.TabIndex = 38;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.Color.Gold;
            this.btnNCC.Location = new System.Drawing.Point(20, 567);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(187, 46);
            this.btnNCC.TabIndex = 37;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnKhach
            // 
            this.btnKhach.BackColor = System.Drawing.Color.LightYellow;
            this.btnKhach.Location = new System.Drawing.Point(20, 251);
            this.btnKhach.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.Size = new System.Drawing.Size(187, 46);
            this.btnKhach.TabIndex = 36;
            this.btnKhach.Text = "Khách hàng";
            this.btnKhach.UseVisualStyleBackColor = false;
            this.btnKhach.Click += new System.EventHandler(this.btnKhach_Click);
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLoaiSP.Location = new System.Drawing.Point(20, 409);
            this.btnLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Size = new System.Drawing.Size(187, 46);
            this.btnLoaiSP.TabIndex = 35;
            this.btnLoaiSP.Text = "Loại sản phẩm";
            this.btnLoaiSP.UseVisualStyleBackColor = false;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSanPham.Location = new System.Drawing.Point(20, 330);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(187, 46);
            this.btnSanPham.TabIndex = 34;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Khaki;
            this.btnNhanVien.Location = new System.Drawing.Point(20, 488);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(187, 46);
            this.btnNhanVien.TabIndex = 33;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Ivory;
            this.btnHoaDon.Location = new System.Drawing.Point(20, 172);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(187, 46);
            this.btnHoaDon.TabIndex = 32;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Trang chủ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.txtKH);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.txtSP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(239, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 384);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // txtKH
            // 
            this.txtKH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.Location = new System.Drawing.Point(224, 281);
            this.txtKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(145, 41);
            this.txtKH.TabIndex = 30;
            this.txtKH.Text = "0";
            // 
            // txtDT
            // 
            this.txtDT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(224, 185);
            this.txtDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(145, 41);
            this.txtDT.TabIndex = 29;
            this.txtDT.Text = "0";
            // 
            // txtSP
            // 
            this.txtSP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP.Location = new System.Drawing.Point(224, 89);
            this.txtSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(145, 41);
            this.txtSP.TabIndex = 28;
            this.txtSP.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 27);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tổng khách hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 27);
            this.label12.TabIndex = 20;
            this.label12.Text = "Sản phẩm đã bán";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 27);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tổng doanh thu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(489, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(384, 34);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cửa Hàng Tiện Lợi NHÓM 1";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(1279, 655);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 50);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::QuanLiCuaHangTienLoi.Properties.Resources.hinh2;
            this.ClientSize = new System.Drawing.Size(1425, 727);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTop10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKhach;
        private System.Windows.Forms.Button btnLoaiSP;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLogout;
    }
}
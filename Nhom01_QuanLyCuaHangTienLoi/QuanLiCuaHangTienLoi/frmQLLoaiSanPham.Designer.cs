namespace QuanLiCuaHangTienLoi
{
    partial class frmQLLoaiSanPham
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
            this.txt_MaLoaiSanPham = new System.Windows.Forms.TextBox();
            this.grp_ThongTinLoaiSanPham = new System.Windows.Forms.GroupBox();
            this.txt_TenLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.grp_ThongTinLoaiSanPham2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ViewwData = new System.Windows.Forms.Button();
            this.btnTaoMa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Addnew = new System.Windows.Forms.Button();
            this.grp_ThongTinLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.grp_ThongTinLoaiSanPham2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MaLoaiSanPham
            // 
            this.txt_MaLoaiSanPham.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_MaLoaiSanPham.Enabled = false;
            this.txt_MaLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoaiSanPham.Location = new System.Drawing.Point(308, 78);
            this.txt_MaLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaLoaiSanPham.Name = "txt_MaLoaiSanPham";
            this.txt_MaLoaiSanPham.Size = new System.Drawing.Size(276, 49);
            this.txt_MaLoaiSanPham.TabIndex = 1;
            // 
            // grp_ThongTinLoaiSanPham
            // 
            this.grp_ThongTinLoaiSanPham.BackColor = System.Drawing.Color.LightBlue;
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.txt_TenLoaiSanPham);
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.label3);
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.label2);
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.txt_MaLoaiSanPham);
            this.grp_ThongTinLoaiSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinLoaiSanPham.Location = new System.Drawing.Point(56, 142);
            this.grp_ThongTinLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_ThongTinLoaiSanPham.Name = "grp_ThongTinLoaiSanPham";
            this.grp_ThongTinLoaiSanPham.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_ThongTinLoaiSanPham.Size = new System.Drawing.Size(652, 352);
            this.grp_ThongTinLoaiSanPham.TabIndex = 2;
            this.grp_ThongTinLoaiSanPham.TabStop = false;
            this.grp_ThongTinLoaiSanPham.Text = "Thông tin loại sản phẩm";
            // 
            // txt_TenLoaiSanPham
            // 
            this.txt_TenLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoaiSanPham.Location = new System.Drawing.Point(308, 222);
            this.txt_TenLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TenLoaiSanPham.Name = "txt_TenLoaiSanPham";
            this.txt_TenLoaiSanPham.Size = new System.Drawing.Size(276, 49);
            this.txt_TenLoaiSanPham.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Location = new System.Drawing.Point(8, 53);
            this.dgvLoaiSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.RowHeadersWidth = 51;
            this.dgvLoaiSP.RowTemplate.Height = 24;
            this.dgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSP.Size = new System.Drawing.Size(778, 283);
            this.dgvLoaiSP.TabIndex = 4;
            this.dgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSP_CellClick);
            this.dgvLoaiSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grp_ThongTinLoaiSanPham2
            // 
            this.grp_ThongTinLoaiSanPham2.BackColor = System.Drawing.Color.LightBlue;
            this.grp_ThongTinLoaiSanPham2.Controls.Add(this.dgvLoaiSP);
            this.grp_ThongTinLoaiSanPham2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinLoaiSanPham2.Location = new System.Drawing.Point(758, 142);
            this.grp_ThongTinLoaiSanPham2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_ThongTinLoaiSanPham2.Name = "grp_ThongTinLoaiSanPham2";
            this.grp_ThongTinLoaiSanPham2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grp_ThongTinLoaiSanPham2.Size = new System.Drawing.Size(812, 352);
            this.grp_ThongTinLoaiSanPham2.TabIndex = 7;
            this.grp_ThongTinLoaiSanPham2.TabStop = false;
            this.grp_ThongTinLoaiSanPham2.Text = "Thông tin loại sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.btn_ViewwData);
            this.groupBox3.Controls.Add(this.btnTaoMa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btn_Delete);
            this.groupBox3.Controls.Add(this.btn_Addnew);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(104, 544);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1412, 172);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_ViewwData
            // 
            this.btn_ViewwData.BackColor = System.Drawing.Color.Red;
            this.btn_ViewwData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewwData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ViewwData.Location = new System.Drawing.Point(1173, 72);
            this.btn_ViewwData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ViewwData.Name = "btn_ViewwData";
            this.btn_ViewwData.Size = new System.Drawing.Size(192, 52);
            this.btn_ViewwData.TabIndex = 27;
            this.btn_ViewwData.Text = "Reset";
            this.btn_ViewwData.UseVisualStyleBackColor = false;
            // 
            // btnTaoMa
            // 
            this.btnTaoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMa.Location = new System.Drawing.Point(51, 72);
            this.btnTaoMa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTaoMa.Name = "btnTaoMa";
            this.btnTaoMa.Size = new System.Drawing.Size(192, 52);
            this.btnTaoMa.TabIndex = 26;
            this.btnTaoMa.Text = "Tạo mã";
            this.btnTaoMa.UseVisualStyleBackColor = true;
            this.btnTaoMa.Click += new System.EventHandler(this.btnTaoMa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(612, 72);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(192, 52);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(892, 72);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(192, 52);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Addnew
            // 
            this.btn_Addnew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addnew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Addnew.Location = new System.Drawing.Point(332, 72);
            this.btn_Addnew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Addnew.Name = "btn_Addnew";
            this.btn_Addnew.Size = new System.Drawing.Size(192, 52);
            this.btn_Addnew.TabIndex = 23;
            this.btn_Addnew.Text = "Thêm";
            this.btn_Addnew.UseVisualStyleBackColor = false;
            this.btn_Addnew.Click += new System.EventHandler(this.btn_Addnew_Click);
            // 
            // frmQLLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::QuanLiCuaHangTienLoi.Properties.Resources.hinh2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1652, 747);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_ThongTinLoaiSanPham2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_ThongTinLoaiSanPham);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLLoaiSanPham";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmQLLoaiSanPham_Load);
            this.grp_ThongTinLoaiSanPham.ResumeLayout(false);
            this.grp_ThongTinLoaiSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            this.grp_ThongTinLoaiSanPham2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_MaLoaiSanPham;
        private System.Windows.Forms.GroupBox grp_ThongTinLoaiSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenLoaiSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_ThongTinLoaiSanPham2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ViewwData;
        private System.Windows.Forms.Button btnTaoMa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Addnew;
    }
}
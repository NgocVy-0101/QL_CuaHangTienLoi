namespace QuanLiCuaHangTienLoi
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_MaLoaiSanPham = new System.Windows.Forms.TextBox();
            this.grp_ThongTinLoaiSanPham = new System.Windows.Forms.GroupBox();
            this.txt_TenLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_ViewData = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.grp_ThongTinLoaiSanPham2 = new System.Windows.Forms.GroupBox();
            this.grp_ThongTinLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grp_ThongTinLoaiSanPham2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_MaLoaiSanPham
            // 
            this.txt_MaLoaiSanPham.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_MaLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoaiSanPham.Location = new System.Drawing.Point(206, 51);
            this.txt_MaLoaiSanPham.Name = "txt_MaLoaiSanPham";
            this.txt_MaLoaiSanPham.Size = new System.Drawing.Size(186, 34);
            this.txt_MaLoaiSanPham.TabIndex = 1;
            // 
            // grp_ThongTinLoaiSanPham
            // 
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.txt_TenLoaiSanPham);
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.label3);
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.label2);
            this.grp_ThongTinLoaiSanPham.Controls.Add(this.txt_MaLoaiSanPham);
            this.grp_ThongTinLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinLoaiSanPham.Location = new System.Drawing.Point(37, 91);
            this.grp_ThongTinLoaiSanPham.Name = "grp_ThongTinLoaiSanPham";
            this.grp_ThongTinLoaiSanPham.Size = new System.Drawing.Size(435, 225);
            this.grp_ThongTinLoaiSanPham.TabIndex = 2;
            this.grp_ThongTinLoaiSanPham.TabStop = false;
            this.grp_ThongTinLoaiSanPham.Text = "Thông tin loại sản phẩm";
            // 
            // txt_TenLoaiSanPham
            // 
            this.txt_TenLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoaiSanPham.Location = new System.Drawing.Point(206, 141);
            this.txt_TenLoaiSanPham.Name = "txt_TenLoaiSanPham";
            this.txt_TenLoaiSanPham.Size = new System.Drawing.Size(186, 34);
            this.txt_TenLoaiSanPham.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(519, 181);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Refresh);
            this.groupBox2.Controls.Add(this.btn_ViewData);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_AddNew);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(842, 47);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(104, 44);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_ViewData
            // 
            this.btn_ViewData.Location = new System.Drawing.Point(683, 47);
            this.btn_ViewData.Name = "btn_ViewData";
            this.btn_ViewData.Size = new System.Drawing.Size(116, 44);
            this.btn_ViewData.TabIndex = 9;
            this.btn_ViewData.Text = "View data";
            this.btn_ViewData.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(524, 47);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(104, 44);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(365, 47);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(104, 44);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(206, 47);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 44);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(47, 47);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(104, 44);
            this.btn_AddNew.TabIndex = 5;
            this.btn_AddNew.Text = "Add new";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            // 
            // grp_ThongTinLoaiSanPham2
            // 
            this.grp_ThongTinLoaiSanPham2.Controls.Add(this.dataGridView1);
            this.grp_ThongTinLoaiSanPham2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinLoaiSanPham2.Location = new System.Drawing.Point(505, 91);
            this.grp_ThongTinLoaiSanPham2.Name = "grp_ThongTinLoaiSanPham2";
            this.grp_ThongTinLoaiSanPham2.Size = new System.Drawing.Size(541, 225);
            this.grp_ThongTinLoaiSanPham2.TabIndex = 7;
            this.grp_ThongTinLoaiSanPham2.TabStop = false;
            this.grp_ThongTinLoaiSanPham2.Text = "Thông tin loại sản phẩm";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 524);
            this.Controls.Add(this.grp_ThongTinLoaiSanPham2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_ThongTinLoaiSanPham);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grp_ThongTinLoaiSanPham.ResumeLayout(false);
            this.grp_ThongTinLoaiSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grp_ThongTinLoaiSanPham2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_MaLoaiSanPham;
        private System.Windows.Forms.GroupBox grp_ThongTinLoaiSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_ViewData;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_TenLoaiSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_ThongTinLoaiSanPham2;
    }
}
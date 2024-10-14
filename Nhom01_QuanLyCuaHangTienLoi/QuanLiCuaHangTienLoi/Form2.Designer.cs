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
            this.txt_MaLoaiSanPham = new System.Windows.Forms.TextBox();
            this.grp_ThongTinLoaiSanPham = new System.Windows.Forms.GroupBox();
            this.txt_TenLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_ThongTinLoaiSanPham2 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_ViewwData = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Addnew = new System.Windows.Forms.Button();
            this.grp_ThongTinLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_ThongTinLoaiSanPham2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.grp_ThongTinLoaiSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(519, 181);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grp_ThongTinLoaiSanPham2
            // 
            this.grp_ThongTinLoaiSanPham2.Controls.Add(this.dataGridView1);
            this.grp_ThongTinLoaiSanPham2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinLoaiSanPham2.Location = new System.Drawing.Point(505, 91);
            this.grp_ThongTinLoaiSanPham2.Name = "grp_ThongTinLoaiSanPham2";
            this.grp_ThongTinLoaiSanPham2.Size = new System.Drawing.Size(541, 225);
            this.grp_ThongTinLoaiSanPham2.TabIndex = 7;
            this.grp_ThongTinLoaiSanPham2.TabStop = false;
            this.grp_ThongTinLoaiSanPham2.Text = "Thông tin loại sản phẩm";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã loại sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên loại sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.btn_ViewwData);
            this.groupBox3.Controls.Add(this.btn_Update);
            this.groupBox3.Controls.Add(this.btn_Save);
            this.groupBox3.Controls.Add(this.btn_Delete);
            this.groupBox3.Controls.Add(this.btn_Addnew);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(70, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Aqua;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(778, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 33);
            this.button7.TabIndex = 28;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_ViewwData
            // 
            this.btn_ViewwData.BackColor = System.Drawing.Color.Red;
            this.btn_ViewwData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewwData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ViewwData.Location = new System.Drawing.Point(628, 46);
            this.btn_ViewwData.Name = "btn_ViewwData";
            this.btn_ViewwData.Size = new System.Drawing.Size(128, 33);
            this.btn_ViewwData.TabIndex = 27;
            this.btn_ViewwData.Text = "Update";
            this.btn_ViewwData.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(478, 46);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(128, 33);
            this.btn_Update.TabIndex = 26;
            this.btn_Update.Text = "View Data";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(178, 46);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 33);
            this.btn_Save.TabIndex = 25;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(328, 46);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 33);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.Text = "Detele";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Addnew
            // 
            this.btn_Addnew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addnew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Addnew.Location = new System.Drawing.Point(28, 46);
            this.btn_Addnew.Name = "btn_Addnew";
            this.btn_Addnew.Size = new System.Drawing.Size(128, 33);
            this.btn_Addnew.TabIndex = 23;
            this.btn_Addnew.Text = "Add new";
            this.btn_Addnew.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1102, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_ThongTinLoaiSanPham2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_ThongTinLoaiSanPham);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grp_ThongTinLoaiSanPham.ResumeLayout(false);
            this.grp_ThongTinLoaiSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_ThongTinLoaiSanPham2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_MaLoaiSanPham;
        private System.Windows.Forms.GroupBox grp_ThongTinLoaiSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenLoaiSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_ThongTinLoaiSanPham2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_ViewwData;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Addnew;
    }
}
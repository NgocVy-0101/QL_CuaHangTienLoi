
namespace QuanLiCuaHangTienLoi
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CharKhachHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CharKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // CharKhachHang
            // 
            chartArea4.Name = "ChartArea1";
            this.CharKhachHang.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.CharKhachHang.Legends.Add(legend4);
            this.CharKhachHang.Location = new System.Drawing.Point(49, 40);
            this.CharKhachHang.Name = "CharKhachHang";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.CharKhachHang.Series.Add(series4);
            this.CharKhachHang.Size = new System.Drawing.Size(309, 381);
            this.CharKhachHang.TabIndex = 0;
            this.CharKhachHang.Text = "chart1";
            // 
            // ChartDoanhThu
            // 
            chartArea5.Name = "ChartArea1";
            this.ChartDoanhThu.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ChartDoanhThu.Legends.Add(legend5);
            this.ChartDoanhThu.Location = new System.Drawing.Point(394, 40);
            this.ChartDoanhThu.Name = "ChartDoanhThu";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ChartDoanhThu.Series.Add(series5);
            this.ChartDoanhThu.Size = new System.Drawing.Size(802, 381);
            this.ChartDoanhThu.TabIndex = 1;
            this.ChartDoanhThu.Text = "chart2";
            // 
            // ChartSanPham
            // 
            chartArea6.Name = "ChartArea1";
            this.ChartSanPham.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ChartSanPham.Legends.Add(legend6);
            this.ChartSanPham.Location = new System.Drawing.Point(49, 450);
            this.ChartSanPham.Name = "ChartSanPham";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ChartSanPham.Series.Add(series6);
            this.ChartSanPham.Size = new System.Drawing.Size(1147, 276);
            this.ChartSanPham.TabIndex = 2;
            this.ChartSanPham.Text = "chart3";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiCuaHangTienLoi.Properties.Resources.mo_hinh_cua_hang_tien_loi_2;
            this.ClientSize = new System.Drawing.Size(1233, 738);
            this.Controls.Add(this.ChartSanPham);
            this.Controls.Add(this.ChartDoanhThu);
            this.Controls.Add(this.CharKhachHang);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CharKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CharKhachHang;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSanPham;
    }
}
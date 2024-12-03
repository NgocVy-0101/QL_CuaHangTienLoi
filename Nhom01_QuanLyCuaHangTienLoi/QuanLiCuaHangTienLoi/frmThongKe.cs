using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLiCuaHangTienLoi
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        
        private string connectionString = @"Data Source=LAPTOP-SF87IO3T\VU957;Initial Catalog=QLCHTL;User ID=sa;Password=123";

        private void LoadThongKe()
        {
            // Cập nhật Biểu đồ tròn - Số lượng khách trong 7 ngày
            BieuDoKhachHang();

            // Cập nhật Biểu đồ cột - Doanh thu theo tháng
            BieuDoDoanhThu();

            // Cập nhật Biểu đồ cột - Sản phẩm bán chạy nhất
            BieuDoSanPham();
        }

        private void BieuDoKhachHang()
        {
            string query = @"SELECT 
            CASE
                WHEN DATEPART(WEEKDAY, NgayBan) = 2 THEN N'Thứ Hai'
                WHEN DATEPART(WEEKDAY, NgayBan) = 3 THEN N'Thứ Ba'
                WHEN DATEPART(WEEKDAY, NgayBan) = 4 THEN N'Thứ Tư'
                WHEN DATEPART(WEEKDAY, NgayBan) = 5 THEN N'Thứ Năm'
                WHEN DATEPART(WEEKDAY, NgayBan) = 6 THEN N'Thứ Sáu'
                WHEN DATEPART(WEEKDAY, NgayBan) = 7 THEN N'Thứ Bảy'
                WHEN DATEPART(WEEKDAY, NgayBan) = 1 THEN N'Chủ Nhật'
            END AS NgayTrongTuan, --Tên ngày trong tuần bằng tiếng Việt
            COUNT(DISTINCT MaKhach) AS SoLuongKhachHang --Số lượng khách hàng duy nhất trong ngày
            FROM HoaDon
            GROUP BY
            CASE
                WHEN DATEPART(WEEKDAY, NgayBan) = 2 THEN N'Thứ Hai'
                WHEN DATEPART(WEEKDAY, NgayBan) = 3 THEN N'Thứ Ba'
                WHEN DATEPART(WEEKDAY, NgayBan) = 4 THEN N'Thứ Tư'
                WHEN DATEPART(WEEKDAY, NgayBan) = 5 THEN N'Thứ Năm'
                WHEN DATEPART(WEEKDAY, NgayBan) = 6 THEN N'Thứ Sáu'
                WHEN DATEPART(WEEKDAY, NgayBan) = 7 THEN N'Thứ Bảy'
                WHEN DATEPART(WEEKDAY, NgayBan) = 1 THEN N'Chủ Nhật'
            END;";

            // Kết nối tới cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Clear biểu đồ trước khi vẽ lại
                CharKhachHang.Series.Clear();
                CharKhachHang.ChartAreas.Clear();
                CharKhachHang.Legends.Clear();

                // Thêm chart area cho biểu đồ
                ChartArea chartArea = new ChartArea();
                CharKhachHang.ChartAreas.Add(chartArea);

                // Thêm legend (chú thích)
                Legend legend = new Legend
                {
                    Name = "CustomerLegend",
                    Docking = Docking.Bottom,
                    Title = "Ngày trong tuần",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold)
                };
                CharKhachHang.Legends.Add(legend);

                // Thêm series vào biểu đồ (biểu đồ tròn)
                Series series = new Series
                {
                    Name = "SoLuongKhachHang",
                    IsVisibleInLegend = true,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                };
                CharKhachHang.Series.Add(series);


                // Duyệt qua dữ liệu và thêm vào biểu đồ
                foreach (DataRow row in dataTable.Rows)
                {
                    string ngayTrongTuan = row["NgayTrongTuan"].ToString();
                    int soLuongKhachHang = Convert.ToInt32(row["SoLuongKhachHang"]);

                    // Thêm điểm dữ liệu vào biểu đồ tròn
                    DataPoint point = new DataPoint
                    {
                        AxisLabel = "",
                        YValues = new double[] { soLuongKhachHang },
                        LegendText = $"{ngayTrongTuan} ({soLuongKhachHang} khách)"
                    };
                    series.Points.Add(point);
                }

                // Tùy chỉnh tiêu đề biểu đồ
                CharKhachHang.Titles.Clear();
                CharKhachHang.Titles.Add("Số lượng khách hàng trong tuần");
                CharKhachHang.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
            }
        }

        private void BieuDoDoanhThu()
        {
            string query = @"
            SELECT MONTH(NgayBan) AS Thang, SUM(TongTien) AS DoanhThu
            FROM HoaDon
            GROUP BY MONTH(NgayBan)
            ORDER BY Thang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ChartDoanhThu.Series.Clear();
                ChartDoanhThu.ChartAreas.Clear();
                ChartDoanhThu.Legends.Clear();

                // Thêm ChartArea
                ChartArea chartArea = new ChartArea();
                ChartDoanhThu.ChartAreas.Add(chartArea);

                // Thêm Legend (chú thích)
                Legend legend = new Legend
                {
                    Name = "RevenueLegend",
                    Docking = Docking.Top,
                    Title = "Tháng",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold)
                };
                ChartDoanhThu.Legends.Add(legend);

                // Thêm series cho biểu đồ cột
                Series series = new Series("DoanhThu")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                foreach (DataRow row in dt.Rows)
                {
                    int month = Convert.ToInt32(row["Thang"]);
                    decimal revenue = Convert.ToDecimal(row["DoanhThu"]);
                    series.Points.AddXY(month, revenue);
                }

                ChartDoanhThu.Series.Add(series);

                // Thêm tiêu đề
                ChartDoanhThu.Titles.Clear();
                ChartDoanhThu.Titles.Add("Doanh thu theo tháng");
                ChartDoanhThu.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
            }
        }

        private void BieuDoSanPham()
        {
            string query = @"
        SELECT TOP 5 TenSanPham, SUM(SoLuong) AS TotalSold
        FROM ChiTietHoaDon
        JOIN SanPham ON ChiTietHoaDon.MaSanPham = SanPham.MaSanPham
        GROUP BY TenSanPham
        ORDER BY TotalSold DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ChartSanPham.Series.Clear();
                ChartSanPham.ChartAreas.Clear();
                ChartSanPham.Legends.Clear();

                // Thêm ChartArea
                ChartArea chartArea = new ChartArea();
                ChartSanPham.ChartAreas.Add(chartArea);

                // Thêm Legend (chú thích)
                Legend legend = new Legend
                {
                    Name = "TopSellingLegend",
                    Docking = Docking.Right,
                    Title = "Sản phẩm",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold)
                };
                ChartSanPham.Legends.Add(legend);

                // Thêm series cho biểu đồ cột
                Series series = new Series("SanPham")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                foreach (DataRow row in dt.Rows)
                {
                    string productName = row["TenSanPham"].ToString();
                    int totalSold = Convert.ToInt32(row["TotalSold"]);
                    series.Points.AddXY(productName, totalSold);
                }

                ChartSanPham.Series.Add(series);

                // Thêm tiêu đề
                ChartSanPham.Titles.Clear();
                ChartSanPham.Titles.Add("Sản phẩm bán chạy nhất");
                ChartSanPham.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
            }
        }


        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLiCuaHangTienLoi
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        public void LoadReport(string reportPath, DataTable data)
        {
            try
            {
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(reportPath);
                reportDocument.SetDataSource(data);

                // Thiết lập thông tin đăng nhập cho cơ sở dữ liệu (nếu cần)
                reportDocument.SetDatabaseLogon("sa", "010104");

                crystalReportViewer1.ReportSource = reportDocument;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải báo cáo: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // Không làm gì ở đây, vì chúng ta sẽ gọi LoadReport từ form khác.
        }
    }
}

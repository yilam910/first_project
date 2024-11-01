using BusinessLogicLayer;
using Microsoft.Reporting.WinForms;
using QLBHPhongVu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHPhongVu.Forms
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {


            try
            {
                // Lấy dữ liệu từ Business Logic Layer (BLL)
                DataSet ds = HoaDonBL.GetInstance.InHoaDon(ucBanSanPham.SOHD_Report);

                // Kiểm tra nếu DataSet là null hoặc không có bảng nào trong DataSet
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Tạo nguồn dữ liệu báo cáo (Report DataSource)
                    ReportDataSource dataSource = new ReportDataSource("DataSet_Report", ds.Tables[0]);

                    // Xóa các nguồn dữ liệu cũ và thêm nguồn dữ liệu mới
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(dataSource);

                    // Cập nhật và làm mới báo cáo
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    // Thông báo khi không có dữ liệu trong DataSet
                    MessageBox.Show("Không tìm thấy dữ liệu cho báo cáo. Vui lòng kiểm tra mã số hóa đơn: " + ucBanSanPham.SOHD_Report, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataSet ds = HoaDonBL.GetInstance.InHoaDon(ucBanSanPham.SOHD_Report);
            ReportDataSource dataSource = new ReportDataSource("DataSet_Report", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

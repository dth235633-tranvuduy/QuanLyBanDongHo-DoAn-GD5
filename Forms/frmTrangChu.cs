using System;
using System.Windows.Forms;

namespace LTQL_QLBHDongHo.Forms
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            this.Load += FrmTrangChu_Load;

            // wire quick-access buttons (names come from Designer)
            btnTaoHoaDon.Click += BtnTaoHoaDon_Click;
            btnQuanLyKho.Click += BtnQuanLyKho_Click;
            btnKhachHang.Click += BtnKhachHang_Click;
            btnBaoCao.Click += BtnBaoCao_Click;
        }

        private void FrmTrangChu_Load(object? sender, EventArgs e)
        {
            // update date label if exists
            try
            {
                lblOverviewDate.Text = "Hoạt động kinh doanh ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch
            {
                // ignore if label not present
            }
        }

        private void BtnTaoHoaDon_Click(object? sender, EventArgs e)
        {
            // Tạo hóa đơn: chưa có Form cụ thể trong project -> show placeholder
            MessageBox.Show("Chức năng Tạo Hóa Đơn chưa được triển khai trong phiên bản này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnQuanLyKho_Click(object? sender, EventArgs e)
        {
            // Open product management (using frmSanPham)
            try
            {
                using var f = new frmSanPham();
                f.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở form Quản lý Kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKhachHang_Click(object? sender, EventArgs e)
        {
            // Open customer management
            try
            {
                using var f = new frmKhanhHang();
                f.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở form Khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBaoCao_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Báo cáo chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // no-op or can be used for logging
        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Hãng sản xuất chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Nhân viên chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

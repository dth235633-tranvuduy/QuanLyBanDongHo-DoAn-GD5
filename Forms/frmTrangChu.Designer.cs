namespace LTQL_QLBHDongHo.Forms
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOverviewTitle;
        private System.Windows.Forms.Label lblOverviewDate;
        private System.Windows.Forms.FlowLayoutPanel flpSummary;
        private System.Windows.Forms.Panel cardDoanhThu;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Panel cardDonHang;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel cardSanPham;
        private System.Windows.Forms.Label lblCard3Value;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Panel cardKhachHang;
        private System.Windows.Forms.Label lblCard4Value;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblQuickAccess;
        private System.Windows.Forms.FlowLayoutPanel flpQuickAccess;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Button btnQuanLyKho;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBaoCao;

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
            lblOverviewTitle = new Label();
            lblOverviewDate = new Label();
            flpSummary = new FlowLayoutPanel();
            cardDoanhThu = new Panel();
            lblCard1Value = new Label();
            lblCard1Title = new Label();
            cardDonHang = new Panel();
            lblCard2Value = new Label();
            lblCard2Title = new Label();
            cardSanPham = new Panel();
            lblCard3Value = new Label();
            lblCard3Title = new Label();
            cardKhachHang = new Panel();
            lblCard4Value = new Label();
            lblCard4Title = new Label();
            lblQuickAccess = new Label();
            flpQuickAccess = new FlowLayoutPanel();
            btnTaoHoaDon = new Button();
            btnQuanLyKho = new Button();
            btnKhachHang = new Button();
            btnBaoCao = new Button();
            lblAppName = new Label();
            lblLienKet = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            groupBox1 = new GroupBox();
            cardDoanhThu.SuspendLayout();
            cardDonHang.SuspendLayout();
            cardSanPham.SuspendLayout();
            cardKhachHang.SuspendLayout();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOverviewTitle
            // 
            lblOverviewTitle.AutoSize = true;
            lblOverviewTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblOverviewTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblOverviewTitle.Location = new Point(30, 20);
            lblOverviewTitle.Name = "lblOverviewTitle";
            lblOverviewTitle.Size = new Size(100, 23);
            lblOverviewTitle.TabIndex = 0;
            lblOverviewTitle.Text = "Tổng quan hệ thống";
            // 
            // lblOverviewDate
            // 
            lblOverviewDate.AutoSize = true;
            lblOverviewDate.Font = new Font("Segoe UI", 9F);
            lblOverviewDate.ForeColor = Color.Gray;
            lblOverviewDate.Location = new Point(30, 50);
            lblOverviewDate.Name = "lblOverviewDate";
            lblOverviewDate.Size = new Size(100, 23);
            lblOverviewDate.TabIndex = 0;
            lblOverviewDate.Text = "Hoạt động kinh doanh ngày 23/03/2026";
            // 
            // flpSummary
            // 
            flpSummary.Location = new Point(30, 86);
            flpSummary.Name = "flpSummary";
            flpSummary.Size = new Size(920, 120);
            flpSummary.TabIndex = 0;
            flpSummary.WrapContents = false;
            // 
            // cardDoanhThu
            // 
            cardDoanhThu.BackColor = Color.White;
            cardDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            cardDoanhThu.Controls.Add(lblCard1Value);
            cardDoanhThu.Controls.Add(lblCard1Title);
            cardDoanhThu.Location = new Point(0, 0);
            cardDoanhThu.Margin = new Padding(6);
            cardDoanhThu.Name = "cardDoanhThu";
            cardDoanhThu.Padding = new Padding(12);
            cardDoanhThu.Size = new Size(220, 100);
            cardDoanhThu.TabIndex = 0;
            // 
            // lblCard1Value
            // 
            lblCard1Value.AutoSize = true;
            lblCard1Value.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCard1Value.ForeColor = Color.FromArgb(15, 76, 129);
            lblCard1Value.Location = new Point(12, 40);
            lblCard1Value.Name = "lblCard1Value";
            lblCard1Value.Size = new Size(195, 38);
            lblCard1Value.TabIndex = 0;
            lblCard1Value.Text = "578.000.000đ";
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = true;
            lblCard1Title.Font = new Font("Segoe UI", 9F);
            lblCard1Title.ForeColor = Color.DimGray;
            lblCard1Title.Location = new Point(12, 12);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(203, 25);
            lblCard1Title.TabIndex = 1;
            lblCard1Title.Text = "DOANH THU HÔM NAY";
            // 
            // cardDonHang
            // 
            cardDonHang.BackColor = Color.White;
            cardDonHang.BorderStyle = BorderStyle.FixedSingle;
            cardDonHang.Controls.Add(lblCard2Value);
            cardDonHang.Controls.Add(lblCard2Title);
            cardDonHang.Location = new Point(0, 0);
            cardDonHang.Margin = new Padding(6);
            cardDonHang.Name = "cardDonHang";
            cardDonHang.Padding = new Padding(12);
            cardDonHang.Size = new Size(220, 100);
            cardDonHang.TabIndex = 0;
            // 
            // lblCard2Value
            // 
            lblCard2Value.AutoSize = true;
            lblCard2Value.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCard2Value.ForeColor = Color.FromArgb(22, 160, 133);
            lblCard2Value.Location = new Point(12, 40);
            lblCard2Value.Name = "lblCard2Value";
            lblCard2Value.Size = new Size(49, 38);
            lblCard2Value.TabIndex = 0;
            lblCard2Value.Text = "24";
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = true;
            lblCard2Title.Font = new Font("Segoe UI", 9F);
            lblCard2Title.ForeColor = Color.DimGray;
            lblCard2Title.Location = new Point(12, 12);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(147, 25);
            lblCard2Title.TabIndex = 1;
            lblCard2Title.Text = "ĐƠN HÀNG MỚI";
            // 
            // cardSanPham
            // 
            cardSanPham.BackColor = Color.White;
            cardSanPham.BorderStyle = BorderStyle.FixedSingle;
            cardSanPham.Controls.Add(lblCard3Value);
            cardSanPham.Controls.Add(lblCard3Title);
            cardSanPham.Location = new Point(0, 0);
            cardSanPham.Margin = new Padding(6);
            cardSanPham.Name = "cardSanPham";
            cardSanPham.Padding = new Padding(12);
            cardSanPham.Size = new Size(220, 100);
            cardSanPham.TabIndex = 0;
            // 
            // lblCard3Value
            // 
            lblCard3Value.AutoSize = true;
            lblCard3Value.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCard3Value.ForeColor = Color.FromArgb(243, 156, 18);
            lblCard3Value.Location = new Point(12, 40);
            lblCard3Value.Name = "lblCard3Value";
            lblCard3Value.Size = new Size(33, 38);
            lblCard3Value.TabIndex = 0;
            lblCard3Value.Text = "5";
            // 
            // lblCard3Title
            // 
            lblCard3Title.AutoSize = true;
            lblCard3Title.Font = new Font("Segoe UI", 9F);
            lblCard3Title.ForeColor = Color.DimGray;
            lblCard3Title.Location = new Point(12, 12);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(176, 25);
            lblCard3Title.TabIndex = 1;
            lblCard3Title.Text = "SẢN PHẨM SẮP HẾT";
            // 
            // cardKhachHang
            // 
            cardKhachHang.BackColor = Color.White;
            cardKhachHang.BorderStyle = BorderStyle.FixedSingle;
            cardKhachHang.Controls.Add(lblCard4Value);
            cardKhachHang.Controls.Add(lblCard4Title);
            cardKhachHang.Location = new Point(0, 0);
            cardKhachHang.Margin = new Padding(6);
            cardKhachHang.Name = "cardKhachHang";
            cardKhachHang.Padding = new Padding(12);
            cardKhachHang.Size = new Size(220, 100);
            cardKhachHang.TabIndex = 0;
            // 
            // lblCard4Value
            // 
            lblCard4Value.AutoSize = true;
            lblCard4Value.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCard4Value.ForeColor = Color.FromArgb(142, 68, 173);
            lblCard4Value.Location = new Point(12, 40);
            lblCard4Value.Name = "lblCard4Value";
            lblCard4Value.Size = new Size(49, 38);
            lblCard4Value.TabIndex = 0;
            lblCard4Value.Text = "12";
            // 
            // lblCard4Title
            // 
            lblCard4Title.AutoSize = true;
            lblCard4Title.Font = new Font("Segoe UI", 9F);
            lblCard4Title.ForeColor = Color.DimGray;
            lblCard4Title.Location = new Point(12, 12);
            lblCard4Title.Name = "lblCard4Title";
            lblCard4Title.Size = new Size(166, 25);
            lblCard4Title.TabIndex = 1;
            lblCard4Title.Text = "KHÁCH HÀNG MỚI";
            // 
            // lblQuickAccess
            // 
            lblQuickAccess.AutoSize = true;
            lblQuickAccess.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuickAccess.ForeColor = Color.FromArgb(33, 37, 41);
            lblQuickAccess.Location = new Point(30, 230);
            lblQuickAccess.Name = "lblQuickAccess";
            lblQuickAccess.Size = new Size(100, 23);
            lblQuickAccess.TabIndex = 0;
            lblQuickAccess.Text = "Truy cập nhanh";
            // 
            // flpQuickAccess
            // 
            flpQuickAccess.Location = new Point(30, 260);
            flpQuickAccess.Name = "flpQuickAccess";
            flpQuickAccess.Size = new Size(920, 140);
            flpQuickAccess.TabIndex = 0;
            flpQuickAccess.WrapContents = false;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.BackColor = Color.FromArgb(34, 103, 238);
            btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            btnTaoHoaDon.FlatStyle = FlatStyle.Flat;
            btnTaoHoaDon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTaoHoaDon.ForeColor = Color.White;
            btnTaoHoaDon.Location = new Point(0, 0);
            btnTaoHoaDon.Margin = new Padding(6);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(220, 110);
            btnTaoHoaDon.TabIndex = 0;
            btnTaoHoaDon.Text = "+\nTạo Hóa Đơn";
            btnTaoHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnTaoHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyKho
            // 
            btnQuanLyKho.BackColor = Color.White;
            btnQuanLyKho.FlatStyle = FlatStyle.Flat;
            btnQuanLyKho.Font = new Font("Segoe UI", 10F);
            btnQuanLyKho.ForeColor = Color.FromArgb(80, 80, 80);
            btnQuanLyKho.Location = new Point(0, 0);
            btnQuanLyKho.Margin = new Padding(6);
            btnQuanLyKho.Name = "btnQuanLyKho";
            btnQuanLyKho.Size = new Size(220, 110);
            btnQuanLyKho.TabIndex = 0;
            btnQuanLyKho.Text = "Quản lý Kho hàng";
            btnQuanLyKho.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.White;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 10F);
            btnKhachHang.ForeColor = Color.FromArgb(80, 80, 80);
            btnKhachHang.Location = new Point(0, 0);
            btnKhachHang.Margin = new Padding(6);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(220, 110);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.White;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Segoe UI", 10F);
            btnBaoCao.ForeColor = Color.FromArgb(80, 80, 80);
            btnBaoCao.Location = new Point(0, 0);
            btnBaoCao.Margin = new Padding(6);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(220, 110);
            btnBaoCao.TabIndex = 0;
            btnBaoCao.Text = "Báo cáo Cuối ngày";
            btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(68, 29);
            lblAppName.Margin = new Padding(2, 0, 2, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(252, 54);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SEVEN TIME";
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(101, 25);
            lblLienKet.Text = "© 2024 FIT";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.LinkColor = Color.Blue;
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(196, 51);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // statusStrip
            // 
            statusStrip.AutoSize = false;
            statusStrip.BackColor = Color.FromArgb(59, 130, 246);
            statusStrip.Dock = DockStyle.None;
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip.Location = new Point(0, 584);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1103, 58);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(793, 25);
            toolStripStatusLabel1.Spring = true;
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(346, 34);
            mnuThongTinPhanMem.Text = "&Thông tin phần mềm";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(346, 34);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(136, 60);
            mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(292, 34);
            mnuThongKeDoanhThu.Text = "Thống kê &doanh thu ...";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(292, 34);
            mnuThongKeSanPham.Text = "Thống kê &sản phẩm ...";
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(149, 60);
            mnuBaoCaoThongKe.Text = "&Thống kê";
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(328, 46);
            mnuHoaDon.Text = "&Hóa đơn ";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(328, 46);
            mnuNhanVien.Text = "&Nhân viên ";
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(328, 46);
            mnuSanPham.Text = "&Sản phẩm ";
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(328, 46);
            mnuHangSanXuat.Text = "&Thương Hiệu";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Image = Properties.Resources._110001191546306;
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(381, 46);
            mnuLoaiSanPham.Text = "&Loại sản phẩm ...";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuHangSanXuat, mnuSanPham, mnuKhachHang, mnuNhanVien, mnuHoaDon });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(122, 60);
            mnuQuanLy.Text = "&Quản lí";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(328, 46);
            mnuKhachHang.Text = "&Khách hàng ";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(238, 34);
            mnuThoat.Text = "Thoát";
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(238, 34);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu ...";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(238, 34);
            mnuDangXuat.Text = "Đăng &xuất";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(238, 34);
            mnuDangNhap.Text = "Đăng &nhập ...";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(103, 29);
            mnuHeThong.Text = "&Hệ thống";
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = Color.FromArgb(59, 130, 246);
            menuStrip.Dock = DockStyle.None;
            menuStrip.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip.Location = new Point(389, 19);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(563, 64);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(59, 130, 246);
            groupBox1.Controls.Add(lblAppName);
            groupBox1.Controls.Add(menuStrip);
            groupBox1.Location = new Point(0, -15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1103, 642);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip);
            Margin = new Padding(2);
            Name = "frmTrangChu";
            Text = "Trang chủ";
          
            cardDoanhThu.ResumeLayout(false);
            cardDoanhThu.PerformLayout();
            cardDonHang.ResumeLayout(false);
            cardDonHang.PerformLayout();
            cardSanPham.ResumeLayout(false);
            cardSanPham.PerformLayout();
            cardKhachHang.ResumeLayout(false);
            cardKhachHang.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Label lblAppName;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripStatusLabel lblTrangThai;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuHeThong;
        private MenuStrip menuStrip;
        private GroupBox groupBox1;
    }
}
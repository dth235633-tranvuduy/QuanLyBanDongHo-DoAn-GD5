using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore;

namespace LTQL_QLBHDongHo.Forms
{
    public partial class frmKhanhHang : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;
        public frmKhanhHang()
        {
            InitializeComponent();
            this.Load += frmKhanhHang_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLuu.Click += btnLuu_Click;
            btnHuyBo.Click += btnHuyBo_Click;
            btnThoat.Click += btnThoat_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnNhap.Click += btnNhap_Click;
            btnXuat.Click += btnXuat_Click;
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void frmKhanhHang_Load(object? sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }
        private void LoadData()
        {
            var list = context.KhachHang.AsNoTracking().ToList();
            var binding = new BindingSource();
            binding.DataSource = list;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", binding, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", binding, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", binding, "DiaChi", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = binding;
        }
        private void btnThem_Click(object? sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtHoVaTen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHoVaTen.Focus();
        }
        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            txtHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            var binding = dataGridView.DataSource as BindingSource;
            if (binding != null)
            {
                txtHoVaTen.DataBindings.Add("Text", binding, "HoVaTen", false, DataSourceUpdateMode.OnPropertyChanged);
                txtDienThoai.DataBindings.Add("Text", binding, "DienThoai", false, DataSourceUpdateMode.OnPropertyChanged);
                txtDiaChi.DataBindings.Add("Text", binding, "DiaChi", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            var kh = context.KhachHang.Find(id);
            if (kh != null)
            {
                try
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xuLyThem)
            {
                var kh = new KhachHang { HoVaTen = txtHoVaTen.Text.Trim(), DienThoai = txtDienThoai.Text.Trim(), DiaChi = txtDiaChi.Text.Trim() };
                context.KhachHang.Add(kh);
                context.SaveChanges();
            }
            else
            {
                var kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    kh.HoVaTen = txtHoVaTen.Text.Trim();
                    kh.DienThoai = txtDienThoai.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text.Trim();
                    context.KhachHang.Update(kh);
                    context.SaveChanges();
                }
            }
            BatTatChucNang(false);
            xuLyThem = false;
            LoadData();
        }
        private void btnHuyBo_Click(object? sender, EventArgs e)
        {
            BatTatChucNang(false);
            xuLyThem = false;
            LoadData();
        }
        private void btnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            var q = txtHoVaTen.Text?.Trim();
            if (string.IsNullOrWhiteSpace(q)) { LoadData(); return; }
            var list = context.KhachHang.AsNoTracking().Where(k => k.HoVaTen.Contains(q) || (k.DienThoai ?? "").Contains(q)).ToList();
            var binding = new BindingSource();
            binding.DataSource = list;
            dataGridView.DataSource = binding;
        }
        private void btnNhap_Click(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Title = "Nhập dữ liệu Khách hàng từ Excel";
            ofd.Filter = "Tập tin Excel|*.xls;*.xlsx";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                using var wb = new XLWorkbook(ofd.FileName);
                var ws = wb.Worksheet(1);
                var firstRow = true;
                var cols = new List<string>();
                foreach (var row in ws.RowsUsed())
                {
                    if (firstRow)
                    {
                        foreach (var cell in row.Cells()) cols.Add(cell.GetString());
                        firstRow = false;
                        continue;
                    }
                    var kh = new KhachHang();
                    // map columns if exist
                    for (int i =0; i < Math.Min(cols.Count, row.CellCount()); i++)
                    {
                        var colName = cols[i];
                        var val = row.Cell(i +1).GetString();
                        if (string.Equals(colName, "HoVaTen", StringComparison.OrdinalIgnoreCase)) kh.HoVaTen = val;
                        else if (string.Equals(colName, "DienThoai", StringComparison.OrdinalIgnoreCase)) kh.DienThoai = val;
                        else if (string.Equals(colName, "DiaChi", StringComparison.OrdinalIgnoreCase)) kh.DiaChi = val;
                    }
                    if (!string.IsNullOrWhiteSpace(kh.HoVaTen)) context.KhachHang.Add(kh);
                }
                context.SaveChanges();
                MessageBox.Show("Nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXuat_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Title = "Xuất dữ liệu Khách hàng ra Excel";
            sfd.Filter = "Tập tin Excel|*.xlsx";
            sfd.FileName = "KhachHang_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                var list = context.KhachHang.AsNoTracking().ToList();
                var dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("ID", typeof(int)), new DataColumn("HoVaTen"), new DataColumn("DienThoai"), new DataColumn("DiaChi") });
                foreach (var kh in list) dt.Rows.Add(kh.ID, kh.HoVaTen, kh.DienThoai ?? string.Empty, kh.DiaChi ?? string.Empty);
                using var wb = new XLWorkbook();
                wb.Worksheets.Add(dt, "KhachHang");
                wb.SaveAs(sfd.FileName);
                MessageBox.Show("Xuất dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

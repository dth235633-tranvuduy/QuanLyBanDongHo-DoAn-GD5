using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore;

namespace LTQL_QLBHDongHo.Forms
{
    public partial class frmThuongHieu : Form
    {
        // EF DbContext
        private QLBHDbContext context = new QLBHDbContext();
        private BindingSource binding = new BindingSource();
        private bool xuLyThem = false; // adding?
        private int id; // selected ID for edit/delete

        public frmThuongHieu()
        {
            InitializeComponent();

            // setup events
            this.Load += FrmThuongHieu_Load;

            dgvThuongHieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThuongHieu.MultiSelect = false;
            dgvThuongHieu.AllowUserToAddRows = false;

            // bind columns if exist - use names from designer (colId, colTen, colQuocGia)
            if (dgvThuongHieu.Columns.Contains("colId")) dgvThuongHieu.Columns["colId"].DataPropertyName = "ID";
            if (dgvThuongHieu.Columns.Contains("colTen")) dgvThuongHieu.Columns["colTen"].DataPropertyName = "TenHangSanXuat";
            // colQuocGia has no matching property in model; leave it blank or show an empty value

            dgvThuongHieu.DataSource = binding;

            // wire search button
            btnTim.Click += BtnTim_Click;
        }

        private void FrmThuongHieu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", binding, "TenHangSanXuat", false, DataSourceUpdateMode.Never);
        }

        private void LoadData()
        {
            LoadData(null);
        }

        private void LoadData(string q)
        {
            var query = context.HangSanXuat.AsNoTracking().AsQueryable();
            if (!string.IsNullOrWhiteSpace(q))
            {
                query = query.Where(h => h.TenHangSanXuat.Contains(q));
            }
            var list = query.ToList();
            binding.DataSource = list;
            binding.ResetBindings(false);
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri; // designer uses btnHuy
            txtTen.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTen.DataBindings.Clear();
            txtTen.Text = string.Empty;
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (binding.Current == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
            var cur = binding.Current as HangSanXuat;
            if (cur != null) id = cur.ID;

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", binding, "TenHangSanXuat", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var name = txtTen.Text?.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên thương hiệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return;
            }

            if (xuLyThem)
            {
                var hsx = new HangSanXuat { TenHangSanXuat = name };
                context.HangSanXuat.Add(hsx);
                context.SaveChanges();
            }
            else
            {
                var hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    hsx.TenHangSanXuat = name;
                    context.HangSanXuat.Update(hsx);
                    context.SaveChanges();
                }
            }

            // reload bindings
            LoadData();
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", binding, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            BatTatChucNang(false);
            xuLyThem = false;
            id = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Lấy đối tượng hiện tại và ép kiểu về HangSanXuat
            var cur = binding.Current as HangSanXuat;
            if (cur == null) return;

            // 2. Hiện thông báo có tên thương hiệu cụ thể để người dùng dễ nhận biết
            string message = $"Bạn có chắc chắn muốn xóa thương hiệu '{cur.TenHangSanXuat}' không?";
            if (MessageBox.Show(message, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                // 3. Tìm trong database và thực hiện xóa
                var hsx = context.HangSanXuat.Find(cur.ID);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
                    context.SaveChanges();

                    // Thông báo thành công (tùy chọn, nếu không thích hiện nhiều thì bỏ qua)
                    MessageBox.Show("Đã xóa xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Load lại dữ liệu để cập nhật Grid
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                // 5. Xử lý lỗi khóa ngoại (Foreign Key) 
                // Nếu thương hiệu này đã được dùng cho một sản phẩm nào đó, SQL sẽ không cho xóa.
                MessageBox.Show("Không thể xóa thương hiệu này vì đã có Sản phẩm thuộc về nó!\nHãy xóa sản phẩm trước khi xóa thương hiệu.",
                                "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            // show a simple input dialog to ask for search term
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên thương hiệu để tìm:", "Tìm thương hiệu", "");
            if (!string.IsNullOrWhiteSpace(input))
            {
                LoadData(input.Trim());
            }
            else
            {
                // if empty, reload all
                LoadData(null);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", binding, "TenHangSanXuat", false, DataSourceUpdateMode.Never);
            BatTatChucNang(false);
            xuLyThem = false;
            id = 0;
            LoadData();
        }
    }
}

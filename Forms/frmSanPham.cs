using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore;

namespace LTQL_QLBHDongHo.Forms
{
    public partial class frmSanPham : Form
    {
        // single DbContext for the form
        private QLBHDbContext context = new QLBHDbContext();
        private bool xuLyThem = false;
        private int? editingID = null;
        private string imagesFolder;

        // DTO for display
        private class DanhSachSanPham
        {
            public int ID { get; set; }
            public string TenSanPham { get; set; }
            public int DonGia { get; set; }
            public int SoLuong { get; set; }
            public string HinhAnh { get; set; }
            public int HangSanXuatID { get; set; }
            public string TenHang { get; set; }
            public int LoaiDongHoID { get; set; }
            public string TenLoai { get; set; }
            public string MoTa { get; set; }
        }

        public frmSanPham()
        {
            InitializeComponent();

            // images folder relative to startup
            var baseDir = Application.StartupPath;
            if (baseDir.Contains("bin\\Debug\\net8.0-windows"))
                imagesFolder = baseDir.Replace("bin\\Debug\\net8.0-windows", "Images");
            else if (baseDir.Contains("bin\\Debug\\net5.0-windows"))
                imagesFolder = baseDir.Replace("bin\\Debug\\net5.0-windows", "Images");
            else
                imagesFolder = Path.Combine(baseDir, "Images");
            Directory.CreateDirectory(imagesFolder);

            this.Load += frmSanPham_Load;
            dgvSanPham.CellFormatting += DgvSanPham_CellFormatting;

            // wire search placeholder handlers
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;

            // reload manufacturers when user opens the combo so it reflects changes from frmThuongHieu
            cboHang.DropDown += CboHang_DropDown;

            // ensure full-row selection and visible selection color
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvSanPham.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;

            // populate STT after data binding
            dgvSanPham.DataBindingComplete += DgvSanPham_DataBindingComplete;
        }

        private void DgvSanPham_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (!dgvSanPham.Columns.Contains("cStt")) return;
                for (int i = 0; i < dgvSanPham.Rows.Count; i++)
                {
                    var row = dgvSanPham.Rows[i];
                    row.Cells["cStt"].Value = (i + 1).ToString();
                }
            }
            catch { }
        }

        private void CboHang_DropDown(object sender, EventArgs e)
        {
            RefreshManufacturersPreserveSelection();
        }

        private void RefreshManufacturersPreserveSelection()
        {
            // remember current selection value (HangSanXuatID)
            object sel = cboHang.SelectedValue;
            var list = context.HangSanXuat.AsNoTracking().ToList();
            cboHang.DataSource = null;
            cboHang.DisplayMember = "TenHangSanXuat";
            cboHang.ValueMember = "ID";
            cboHang.DataSource = list;
            // try to restore selection
            if (sel != null)
            {
                foreach (var item in list)
                {
                    var prop = item.GetType().GetProperty("ID");
                    if (prop != null && prop.GetValue(item)?.ToString() == sel.ToString())
                    {
                        cboHang.SelectedValue = sel;
                        break;
                    }
                }
            }
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            cboHang.Enabled = giaTri;
            cboCoChe.Enabled = giaTri;
            txtTen.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            txtGia.Enabled = giaTri;
            txtChatLieu.Enabled = giaTri;
            pbImage.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnChonAnh.Enabled = giaTri; // allow choosing image while editing
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void LayLookups()
        {
            // HangSanXuat -> cboHang
            var hsx = context.HangSanXuat.AsNoTracking().ToList();
            cboHang.DisplayMember = "TenHangSanXuat";
            cboHang.ValueMember = "ID";
            cboHang.DataSource = hsx;

            // LoaiDongHo -> cboCoChe
            var loai = context.LoaiDongHo.AsNoTracking().ToList();
            cboCoChe.DisplayMember = "TenLoai";
            cboCoChe.ValueMember = "ID";
            cboCoChe.DataSource = loai;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLookups();
            LoadData(null);
        }

        private void LoadData(string q)
        {
            dgvSanPham.AutoGenerateColumns = false;

            var query = context.SanPham
                .Include(s => s.HangSanXuat)
                .Include(s => s.LoaiDongHo)
                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(q))
            {
                query = query.Where(s => s.TenSanPham.Contains(q) || s.ID.ToString().Contains(q));
            }

            var list = query.Select(s => new DanhSachSanPham
            {
                ID = s.ID,
                TenSanPham = s.TenSanPham,
                DonGia = s.DonGia,
                SoLuong = s.SoLuong,
                HinhAnh = s.HinhAnh,
                HangSanXuatID = s.HangSanXuatID,
                TenHang = s.HangSanXuat != null ? s.HangSanXuat.TenHangSanXuat : string.Empty,
                LoaiDongHoID = s.LoaiDongHoID,
                TenLoai = s.LoaiDongHo != null ? s.LoaiDongHo.TenLoai : string.Empty,
                MoTa = s.MoTa ?? string.Empty
            }).ToList();

            var binding = new BindingSource();
            binding.DataSource = list;

            // bind controls
            cboCoChe.DataBindings.Clear();
            cboCoChe.DataBindings.Add("SelectedValue", binding, "LoaiDongHoID", false, DataSourceUpdateMode.Never);

            cboHang.DataBindings.Clear();
            cboHang.DataBindings.Add("SelectedValue", binding, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", binding, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", binding, "SoLuong", false, DataSourceUpdateMode.Never);

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", binding, "DonGia", false, DataSourceUpdateMode.Never);

            txtChatLieu.DataBindings.Clear();
            txtChatLieu.DataBindings.Add("Text", binding, "MoTa", false, DataSourceUpdateMode.Never);

            pbImage.DataBindings.Clear();
            var imageBinding = new Binding("ImageLocation", binding, "HinhAnh");
            imageBinding.Format += (s, ev) =>
            {
                if (ev.Value == null) { ev.Value = null; return; }
                var filename = ev.Value.ToString();
                if (string.IsNullOrEmpty(filename)) { ev.Value = null; return; }
                var full = Path.Combine(imagesFolder, filename);
                ev.Value = full;
            };
            pbImage.DataBindings.Add(imageBinding);

            dgvSanPham.DataSource = binding;
        }

        private void DgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var col = dgvSanPham.Columns[e.ColumnIndex];
            if (col.Name == "cGia")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out var d))
                {
                    e.Value = d.ToString("N0");
                    e.FormattingApplied = true;
                }
            }

            if (col.Name == "cHinhAnh")
            {
                // if column contains filename, convert to small image
                try
                {
                    if (e.Value != null)
                    {
                        var full = Path.Combine(imagesFolder, e.Value.ToString());
                        if (File.Exists(full))
                        {
                            Image image = Image.FromFile(full);
                            image = new Bitmap(image,24,24);
                            e.Value = image;
                            e.FormattingApplied = true;
                        }
                    }
                }
                catch { }
            }
        }

        private string GenerateNewMaSP()
        {
            // generate next numeric id as string
            // Use nullable Max so EF can translate; if no rows, use0
            var max = context.SanPham.AsNoTracking()
                .Select(s => (int?)s.ID)
                .Max() ??0;
            return (max +1).ToString();
        }

        // Buttons
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMa.Text = GenerateNewMaSP();
            txtTen.Text = string.Empty;
            txtGia.Text = "0";
            cboHang.SelectedIndex = -1;
            cboCoChe.SelectedIndex = -1;
            txtChatLieu.Text = string.Empty;
            numSoLuong.Value =1;
            pbImage.Image = null;
            pbImage.ImageLocation = null;
            editingID = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
            var maObj = dgvSanPham.CurrentRow.Cells["cMa"].Value;
            if (maObj != null && int.TryParse(maObj.ToString(), out var id))
                editingID = id;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtGia.Text, out var gia)) gia =0;

            if (xuLyThem)
            {
                var sp = new SanPham
                {
                    TenSanPham = txtTen.Text.Trim(),
                    DonGia = gia,
                    SoLuong = (int)numSoLuong.Value,
                    HinhAnh = pbImage.ImageLocation != null ? Path.GetFileName(pbImage.ImageLocation) : null,
                    HangSanXuatID = cboHang.SelectedValue != null ? Convert.ToInt32(cboHang.SelectedValue) :0,
                    LoaiDongHoID = cboCoChe.SelectedValue != null ? Convert.ToInt32(cboCoChe.SelectedValue) :0,
                    MoTa = txtChatLieu.Text.Trim()
                };
                try
                {
                    context.SanPham.Add(sp);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    ShowDbError(ex);
                    return;
                }
            }
            else
            {
                if (!editingID.HasValue) return;
                var sp = context.SanPham.Find(editingID.Value);
                if (sp != null)
                {
                    sp.TenSanPham = txtTen.Text.Trim();
                    sp.DonGia = gia;
                    sp.SoLuong = (int)numSoLuong.Value;
                    sp.HinhAnh = pbImage.ImageLocation != null ? Path.GetFileName(pbImage.ImageLocation) : sp.HinhAnh;
                    sp.HangSanXuatID = cboHang.SelectedValue != null ? Convert.ToInt32(cboHang.SelectedValue) : sp.HangSanXuatID;
                    sp.LoaiDongHoID = cboCoChe.SelectedValue != null ? Convert.ToInt32(cboCoChe.SelectedValue) : sp.LoaiDongHoID;
                    sp.MoTa = txtChatLieu.Text.Trim();
                    try
                    {
                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ShowDbError(ex);
                        return;
                    }
                }
            }

            // reload
            frmSanPham_Load(null, null);
            BatTatChucNang(false);
            xuLyThem = false;
            editingID = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;
            var maObj = dgvSanPham.CurrentRow.Cells["cMa"].Value;
            if (maObj == null) return;
            if (!int.TryParse(maObj.ToString(), out var ma)) return;
            if (MessageBox.Show($"Xác nhận xóa sản phẩm {ma}?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var sp = context.SanPham.Find(ma);
            if (sp != null)
            {
                context.SanPham.Remove(sp);
                context.SaveChanges();
            }
            frmSanPham_Load(null, null);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            xuLyThem = false;
            editingID = null;
            frmSanPham_Load(null, null);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            var fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
            var ext = Path.GetExtension(ofd.FileName);
            var slug = GenerateSlug(fileName);
            var dest = Path.Combine(imagesFolder, slug + ext);
            File.Copy(ofd.FileName, dest, true);
            pbImage.ImageLocation = dest;

            // if editing existing product and not adding, update DB immediately
            if (!xuLyThem && dgvSanPham.CurrentRow != null)
            {
                var maObj = dgvSanPham.CurrentRow.Cells["cMa"].Value;
                if (maObj != null && int.TryParse(maObj.ToString(), out var ma))
                {
                    var sp = context.SanPham.Find(ma);
                    if (sp != null)
                    {
                        sp.HinhAnh = Path.GetFileName(dest);
                        context.SanPham.Update(sp);
                        context.SaveChanges();
                        frmSanPham_Load(null, null);
                    }
                }
            }
        }

        private static string GenerateSlug(string text)
        {
            var s = text.ToLowerInvariant();
            var invalid = Path.GetInvalidFileNameChars();
            foreach (var c in invalid) s = s.Replace(c, '-');
            s = s.Replace(' ', '-');
            return s;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm đồng hồ...")
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Tìm kiếm đồng hồ...";
                txtSearch.ForeColor = Color.Gray;
                LoadData(null);
            }
            else
            {
                LoadData(txtSearch.Text.Trim());
            }
        }

        private void ShowDbError(Exception ex)
        {
            var msg = ex.Message;
            if (ex is DbUpdateException dbEx && dbEx.InnerException != null)
                msg += "\n" + dbEx.InnerException.Message;
            else if (ex.InnerException != null)
                msg += "\n" + ex.InnerException.Message;
            MessageBox.Show(msg, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

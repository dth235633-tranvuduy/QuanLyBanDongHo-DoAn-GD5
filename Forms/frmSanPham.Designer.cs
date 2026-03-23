namespace LTQL_QLBHDongHo.Forms
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Controls
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.ComboBox cboHang;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblCoChe;
        private System.Windows.Forms.ComboBox cboCoChe;
        private System.Windows.Forms.Label lblChatLieu;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panelListTop;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSearch;
        #endregion

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
            groupInfo = new GroupBox();
            lblMa = new Label();
            txtMa = new TextBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblGia = new Label();
            txtGia = new TextBox();
            lblHang = new Label();
            cboHang = new ComboBox();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblCoChe = new Label();
            cboCoChe = new ComboBox();
            lblChatLieu = new Label();
            txtChatLieu = new TextBox();
            lblSoLuong = new Label();
            numSoLuong = new NumericUpDown();
            pbImage = new PictureBox();
            btnChonAnh = new Button();
            flowButtons = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            panelListTop = new Panel();
            lblListTitle = new Label();
            dgvSanPham = new DataGridView();
            cStt = new DataGridViewTextBoxColumn();
            cMa = new DataGridViewTextBoxColumn();
            cTen = new DataGridViewTextBoxColumn();
            cHang = new DataGridViewTextBoxColumn();
            cGia = new DataGridViewTextBoxColumn();
            cSoLuong = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            flowButtons.SuspendLayout();
            panelListTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupInfo
            // 
            groupInfo.Controls.Add(lblMa);
            groupInfo.Controls.Add(txtMa);
            groupInfo.Controls.Add(lblTen);
            groupInfo.Controls.Add(txtTen);
            groupInfo.Controls.Add(lblGia);
            groupInfo.Controls.Add(txtGia);
            groupInfo.Controls.Add(lblHang);
            groupInfo.Controls.Add(cboHang);
            groupInfo.Controls.Add(lblGioiTinh);
            groupInfo.Controls.Add(cboGioiTinh);
            groupInfo.Controls.Add(lblCoChe);
            groupInfo.Controls.Add(cboCoChe);
            groupInfo.Controls.Add(lblChatLieu);
            groupInfo.Controls.Add(txtChatLieu);
            groupInfo.Controls.Add(lblSoLuong);
            groupInfo.Controls.Add(numSoLuong);
            groupInfo.Controls.Add(pbImage);
            groupInfo.Controls.Add(btnChonAnh);
            groupInfo.Controls.Add(flowButtons);
            groupInfo.Dock = DockStyle.Top;
            groupInfo.Location = new Point(0, 0);
            groupInfo.Name = "groupInfo";
            groupInfo.Padding = new Padding(12);
            groupInfo.Size = new Size(978, 335);
            groupInfo.TabIndex = 2;
            groupInfo.TabStop = false;
            groupInfo.Text = " Thông tin sản phẩm";
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(27, 26);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(85, 25);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã SP (*)";
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 9F);
            txtMa.Location = new Point(27, 54);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(85, 31);
            txtMa.TabIndex = 1;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(149, 26);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(144, 25);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên sản phẩm (*)";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F);
            txtTen.Location = new Point(145, 54);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(240, 31);
            txtTen.TabIndex = 3;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(18, 96);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(72, 25);
            lblGia.TabIndex = 4;
            lblGia.Text = "Giá bán";
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI", 9F);
            txtGia.Location = new Point(18, 124);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(140, 31);
            txtGia.TabIndex = 5;
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.Location = new Point(191, 95);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(125, 25);
            lblHang.TabIndex = 6;
            lblHang.Text = "Hãng sản xuất";
            // 
            // cboHang
            // 
            cboHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHang.Location = new Point(193, 123);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(200, 33);
            cboHang.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(428, 96);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(78, 25);
            lblGioiTinh.TabIndex = 8;
            lblGioiTinh.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ ", "Unisex" });
            cboGioiTinh.Location = new Point(428, 124);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(120, 33);
            cboGioiTinh.TabIndex = 9;
            // 
            // lblCoChe
            // 
            lblCoChe.AutoSize = true;
            lblCoChe.Location = new Point(18, 168);
            lblCoChe.Name = "lblCoChe";
            lblCoChe.Size = new Size(83, 25);
            lblCoChe.TabIndex = 10;
            lblCoChe.Text = "Loại máy\r\n";
            // 
            // cboCoChe
            // 
            cboCoChe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCoChe.Location = new Point(18, 194);
            cboCoChe.Name = "cboCoChe";
            cboCoChe.Size = new Size(200, 33);
            cboCoChe.TabIndex = 11;
            // 
            // lblChatLieu
            // 
            lblChatLieu.AutoSize = true;
            lblChatLieu.Location = new Point(247, 167);
            lblChatLieu.Name = "lblChatLieu";
            lblChatLieu.Size = new Size(146, 25);
            lblChatLieu.TabIndex = 12;
            lblChatLieu.Text = "Chất liệu của dây";
            // 
            // txtChatLieu
            // 
            txtChatLieu.Location = new Point(247, 195);
            txtChatLieu.Name = "txtChatLieu";
            txtChatLieu.Size = new Size(200, 31);
            txtChatLieu.TabIndex = 13;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(486, 168);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(85, 25);
            lblSoLuong.TabIndex = 14;
            lblSoLuong.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(491, 196);
            numSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(80, 31);
            numSoLuong.TabIndex = 15;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(671, 26);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(253, 201);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 16;
            pbImage.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(718, 258);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(160, 34);
            btnChonAnh.TabIndex = 17;
            btnChonAnh.Text = "Chọn tệp ảnh";
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnThem);
            flowButtons.Controls.Add(btnSua);
            flowButtons.Controls.Add(btnXoa);
            flowButtons.Controls.Add(btnLuu);
            flowButtons.Controls.Add(btnHuy);
            flowButtons.Location = new Point(18, 250);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(588, 42);
            flowButtons.TabIndex = 18;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = " Thêm mới";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(119, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = " Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(235, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = " Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(351, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 34);
            btnLuu.TabIndex = 3;
            btnLuu.Text = " Lưu lại";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(467, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 34);
            btnHuy.TabIndex = 4;
            btnHuy.Text = " Hủy bỏ";
            btnHuy.Click += btnHuy_Click;
            // 
            // panelListTop
            // 
            panelListTop.Controls.Add(lblListTitle);
            panelListTop.Controls.Add(txtSearch);
            panelListTop.Dock = DockStyle.Top;
            panelListTop.Location = new Point(0, 335);
            panelListTop.Name = "panelListTop";
            panelListTop.Padding = new Padding(12);
            panelListTop.Size = new Size(978, 48);
            panelListTop.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(436, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(360, 31);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Tìm kiếm đồng hồ...";
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblListTitle.Location = new Point(12, 14);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(255, 25);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Danh sách mặt hàng hiện tại";
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.BorderStyle = BorderStyle.None;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { cStt, cMa, cTen, cHang, cGia, cSoLuong });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 383);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.RowTemplate.Height = 24;
            dgvSanPham.Size = new Size(978, 361);
            dgvSanPham.TabIndex = 0;
            // 
            // cStt
            // 
            cStt.FillWeight = 5F;
            cStt.HeaderText = "STT";
            cStt.MinimumWidth = 8;
            cStt.Name = "cStt";
            cStt.ReadOnly = true;
            // 
            // cMa
            // 
            cMa.DataPropertyName = "ID";
            cMa.FillWeight = 12F;
            cMa.HeaderText = "MÃ SP";
            cMa.MinimumWidth = 8;
            cMa.Name = "cMa";
            cMa.ReadOnly = true;
            // 
            // cTen
            // 
            cTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cTen.DataPropertyName = "TenSanPham";
            cTen.FillWeight = 50F;
            cTen.HeaderText = "TÊN ĐỒNG HỒ";
            cTen.MinimumWidth = 8;
            cTen.Name = "cTen";
            cTen.ReadOnly = true;
            // 
            // cHang
            // 
            cHang.DataPropertyName = "HangSanXuatID";
            cHang.FillWeight = 12F;
            cHang.HeaderText = "HÃNG";
            cHang.MinimumWidth = 8;
            cHang.Name = "cHang";
            cHang.ReadOnly = true;
            // 
            // cGia
            // 
            cGia.DataPropertyName = "DonGia";
            cGia.FillWeight = 15F;
            cGia.HeaderText = "GIÁ BÁN";
            cGia.MinimumWidth = 8;
            cGia.Name = "cGia";
            cGia.ReadOnly = true;
            // 
            // cSoLuong
            // 
            cSoLuong.DataPropertyName = "SoLuong";
            cSoLuong.FillWeight = 6F;
            cSoLuong.HeaderText = "SL";
            cSoLuong.MinimumWidth = 8;
            cSoLuong.Name = "cSoLuong";
            cSoLuong.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(dgvSanPham);
            Controls.Add(panelListTop);
            Controls.Add(groupInfo);
            Name = "frmSanPham";
            Text = "Quản lý sản phẩm";
            groupInfo.ResumeLayout(false);
            groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            flowButtons.ResumeLayout(false);
            panelListTop.ResumeLayout(false);
            panelListTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn cStt;
        private DataGridViewTextBoxColumn cMa;
        private DataGridViewTextBoxColumn cTen;
        private DataGridViewTextBoxColumn cHang;
        private DataGridViewTextBoxColumn cGia;
        private DataGridViewTextBoxColumn cSoLuong;
    }
}
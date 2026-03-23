namespace LTQL_QLBHDongHo.Forms
{
    partial class frmThuongHieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Controls
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panelListTop;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvThuongHieu;
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
            lblTen = new Label();
            txtTen = new TextBox();
            flowButtons = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnTim = new Button();
            panelListTop = new Panel();
            lblListTitle = new Label();
            dgvThuongHieu = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            groupInfo.SuspendLayout();
            flowButtons.SuspendLayout();
            panelListTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).BeginInit();
            SuspendLayout();
            // 
            // groupInfo
            // 
            groupInfo.Controls.Add(lblTen);
            groupInfo.Controls.Add(txtTen);
            groupInfo.Controls.Add(flowButtons);
            groupInfo.Dock = DockStyle.Top;
            groupInfo.Location = new Point(0, 0);
            groupInfo.Name = "groupInfo";
            groupInfo.Padding = new Padding(12);
            groupInfo.Size = new Size(899, 170);
            groupInfo.TabIndex = 2;
            groupInfo.TabStop = false;
            groupInfo.Text = "Thông tin thương hiệu";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 9F);
            lblTen.Location = new Point(18, 26);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(163, 25);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên thương hiệu (*)";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F);
            txtTen.ForeColor = Color.Gray;
            txtTen.Location = new Point(18, 50);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(698, 31);
            txtTen.TabIndex = 1;
            txtTen.Text = "Nhập tên thương hiệu (ví dụ: Seiko, Casio...)";
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnThem);
            flowButtons.Controls.Add(btnSua);
            flowButtons.Controls.Add(btnXoa);
            flowButtons.Controls.Add(btnLuu);
            flowButtons.Controls.Add(btnHuy);
            flowButtons.Controls.Add(btnTim);
            flowButtons.Location = new Point(18, 100);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(698, 41);
            flowButtons.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatStyle = FlatStyle.System;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = " Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Location = new Point(119, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = " Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.ForeColor = Color.DarkRed;
            btnXoa.Location = new Point(235, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = " Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.Location = new Point(351, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 34);
            btnLuu.TabIndex = 3;
            btnLuu.Text = " Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Location = new Point(467, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 34);
            btnHuy.TabIndex = 4;
            btnHuy.Text = " Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.Font = new Font("Segoe UI", 9F);
            btnTim.Location = new Point(583, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(110, 34);
            btnTim.TabIndex = 1;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // panelListTop
            // 
            panelListTop.Controls.Add(lblListTitle);
            panelListTop.Dock = DockStyle.Top;
            panelListTop.Location = new Point(0, 170);
            panelListTop.Name = "panelListTop";
            panelListTop.Padding = new Padding(12);
            panelListTop.Size = new Size(899, 48);
            panelListTop.TabIndex = 1;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblListTitle.Location = new Point(12, 14);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(210, 25);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Danh sách thương hiệu";
            // 
            // dgvThuongHieu
            // 
            dgvThuongHieu.BackgroundColor = Color.White;
            dgvThuongHieu.BorderStyle = BorderStyle.None;
            dgvThuongHieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuongHieu.Columns.AddRange(new DataGridViewColumn[] { colId, colTen });
            dgvThuongHieu.Dock = DockStyle.Fill;
            dgvThuongHieu.Location = new Point(0, 218);
            dgvThuongHieu.Name = "dgvThuongHieu";
            dgvThuongHieu.ReadOnly = true;
            dgvThuongHieu.RowHeadersWidth = 62;
            dgvThuongHieu.RowTemplate.Height = 24;
            dgvThuongHieu.Size = new Size(899, 281);
            dgvThuongHieu.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 120;
            // 
            // colTen
            // 
            colTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTen.HeaderText = "TÊN THƯƠNG HIỆU";
            colTen.MinimumWidth = 8;
            colTen.Name = "colTen";
            colTen.ReadOnly = true;
            // 
            // frmThuongHieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 499);
            Controls.Add(dgvThuongHieu);
            Controls.Add(panelListTop);
            Controls.Add(groupInfo);
            Name = "frmThuongHieu";
            Text = "ThuongHieu";
            groupInfo.ResumeLayout(false);
            groupInfo.PerformLayout();
            flowButtons.ResumeLayout(false);
            panelListTop.ResumeLayout(false);
            panelListTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTen;
    }
}
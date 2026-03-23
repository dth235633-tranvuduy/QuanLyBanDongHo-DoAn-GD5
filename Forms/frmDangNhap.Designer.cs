namespace LTQL_QLBHDongHo.Forms
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            pnlCard = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            chkRemember = new CheckBox();
            btnLogin = new Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(lblPass);
            pnlCard.Controls.Add(txtPass);
            pnlCard.Controls.Add(chkRemember);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Location = new Point(1, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(807, 600);
            pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(188, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "CỬA HÀNG ĐỒNG HỒ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(292, 145);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(232, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Hệ thống Quản lý Bán hàng";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(164, 200);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(129, 25);
            lblUser.TabIndex = 3;
            lblUser.Text = "Tên đăng nhập";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.Location = new Point(164, 230);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Nhập tài khoản";
            txtUser.Size = new Size(480, 34);
            txtUser.TabIndex = 4;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F);
            lblPass.ForeColor = Color.Black;
            lblPass.Location = new Point(164, 280);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(86, 25);
            lblPass.TabIndex = 5;
            lblPass.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10F);
            txtPass.Location = new Point(164, 310);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Nhập mật khẩu ";
            txtPass.Size = new Size(480, 34);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(164, 360);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(153, 29);
            chkRemember.TabIndex = 7;
            chkRemember.Text = "Xem mật khẩu\r\n";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(59, 130, 246);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(164, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(480, 48);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(800, 600);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnLogin;
    }
}
namespace GUI.ucHeThong
{
    partial class ucDangNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mPanelDangNhap = new MetroFramework.Controls.MetroPanel();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.txtTaiKhoan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.mPanelDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mPanelDangNhap, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1308, 605);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mPanelDangNhap
            // 
            this.mPanelDangNhap.Controls.Add(this.btnDangNhap);
            this.mPanelDangNhap.Controls.Add(this.txtMatKhau);
            this.mPanelDangNhap.Controls.Add(this.txtTaiKhoan);
            this.mPanelDangNhap.Controls.Add(this.metroLabel2);
            this.mPanelDangNhap.Controls.Add(this.metroLabel1);
            this.mPanelDangNhap.HorizontalScrollbarBarColor = true;
            this.mPanelDangNhap.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelDangNhap.HorizontalScrollbarSize = 10;
            this.mPanelDangNhap.Location = new System.Drawing.Point(364, 174);
            this.mPanelDangNhap.Name = "mPanelDangNhap";
            this.mPanelDangNhap.Size = new System.Drawing.Size(579, 257);
            this.mPanelDangNhap.TabIndex = 0;
            this.mPanelDangNhap.VerticalScrollbarBarColor = true;
            this.mPanelDangNhap.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelDangNhap.VerticalScrollbarSize = 10;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMatKhau.Location = new System.Drawing.Point(207, 104);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(211, 23);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTaiKhoan.Location = new System.Drawing.Point(207, 42);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(211, 23);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(67, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Mật Khẩu";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(67, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tài Khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Location = new System.Drawing.Point(207, 163);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(123, 35);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ucDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucDangNhap";
            this.Size = new System.Drawing.Size(1308, 605);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mPanelDangNhap.ResumeLayout(false);
            this.mPanelDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel mPanelDangNhap;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroTextBox txtTaiKhoan;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}

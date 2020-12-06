namespace GUI.ucTienNghi
{
    partial class TienNghi
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
            this.layoutNhanVien = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTroVe = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mPanelMenu = new MetroFramework.Controls.MetroPanel();
            this.btnQLTienNghi = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mpanelQlTnContent = new MetroFramework.Controls.MetroPanel();
            this.layoutNhanVien.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.mPanelMenu.SuspendLayout();
            this.btnQLTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutNhanVien
            // 
            this.layoutNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.layoutNhanVien.ColumnCount = 3;
            this.layoutNhanVien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutNhanVien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.layoutNhanVien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutNhanVien.Controls.Add(this.metroPanel1, 0, 0);
            this.layoutNhanVien.Controls.Add(this.btnTroVe, 2, 0);
            this.layoutNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutNhanVien.Location = new System.Drawing.Point(0, 0);
            this.layoutNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.layoutNhanVien.Name = "layoutNhanVien";
            this.layoutNhanVien.RowCount = 1;
            this.layoutNhanVien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutNhanVien.Size = new System.Drawing.Size(973, 50);
            this.layoutNhanVien.TabIndex = 4;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(285, 44);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(74, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Tiện Nghi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tiennghi;
            this.pictureBox1.InitialImage = global::GUI.Properties.Resources.nhanvien;
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTroVe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTroVe.Image = global::GUI.Properties.Resources.thoat1;
            this.btnTroVe.InitialImage = global::GUI.Properties.Resources.nhanvien;
            this.btnTroVe.Location = new System.Drawing.Point(897, 3);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(73, 44);
            this.btnTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.TabStop = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.mPanelMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mpanelQlTnContent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 533);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // mPanelMenu
            // 
            this.mPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.mPanelMenu.Controls.Add(this.btnQLTienNghi);
            this.mPanelMenu.CustomBackground = true;
            this.mPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelMenu.HorizontalScrollbarBarColor = true;
            this.mPanelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelMenu.HorizontalScrollbarSize = 10;
            this.mPanelMenu.Location = new System.Drawing.Point(0, 3);
            this.mPanelMenu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.mPanelMenu.Name = "mPanelMenu";
            this.mPanelMenu.Size = new System.Drawing.Size(191, 527);
            this.mPanelMenu.TabIndex = 2;
            this.mPanelMenu.VerticalScrollbarBarColor = true;
            this.mPanelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelMenu.VerticalScrollbarSize = 10;
            // 
            // btnQLTienNghi
            // 
            this.btnQLTienNghi.AccessibleName = "QuanLyTienNghi";
            this.btnQLTienNghi.Controls.Add(this.metroLabel2);
            this.btnQLTienNghi.Controls.Add(this.pictureBox2);
            this.btnQLTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTienNghi.CustomBackground = true;
            this.btnQLTienNghi.HorizontalScrollbar = true;
            this.btnQLTienNghi.HorizontalScrollbarBarColor = true;
            this.btnQLTienNghi.HorizontalScrollbarHighlightOnWheel = false;
            this.btnQLTienNghi.HorizontalScrollbarSize = 10;
            this.btnQLTienNghi.Location = new System.Drawing.Point(0, 58);
            this.btnQLTienNghi.Name = "btnQLTienNghi";
            this.btnQLTienNghi.Size = new System.Drawing.Size(309, 50);
            this.btnQLTienNghi.TabIndex = 2;
            this.btnQLTienNghi.Tag = "0";
            this.btnQLTienNghi.VerticalScrollbar = true;
            this.btnQLTienNghi.VerticalScrollbarBarColor = true;
            this.btnQLTienNghi.VerticalScrollbarHighlightOnWheel = false;
            this.btnQLTienNghi.VerticalScrollbarSize = 10;
            this.btnQLTienNghi.Click += new System.EventHandler(this.btnQLTienNghi_Click);
            this.btnQLTienNghi.MouseLeave += new System.EventHandler(this.btnQLTienNghi_MouseLeave);
            this.btnQLTienNghi.MouseHover += new System.EventHandler(this.btnQLTienNghi_MouseHover);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(71, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(159, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Quản Lý Tiện Nghi";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            this.metroLabel2.MouseLeave += new System.EventHandler(this.metroLabel2_MouseLeave);
            this.metroLabel2.MouseHover += new System.EventHandler(this.metroLabel2_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.tiennghi;
            this.pictureBox2.Location = new System.Drawing.Point(10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // mpanelQlTnContent
            // 
            this.mpanelQlTnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpanelQlTnContent.HorizontalScrollbarBarColor = true;
            this.mpanelQlTnContent.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanelQlTnContent.HorizontalScrollbarSize = 10;
            this.mpanelQlTnContent.Location = new System.Drawing.Point(197, 3);
            this.mpanelQlTnContent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.mpanelQlTnContent.Name = "mpanelQlTnContent";
            this.mpanelQlTnContent.Size = new System.Drawing.Size(776, 527);
            this.mpanelQlTnContent.TabIndex = 3;
            this.mpanelQlTnContent.VerticalScrollbarBarColor = true;
            this.mpanelQlTnContent.VerticalScrollbarHighlightOnWheel = false;
            this.mpanelQlTnContent.VerticalScrollbarSize = 10;
            // 
            // TienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.layoutNhanVien);
            this.Name = "TienNghi";
            this.Size = new System.Drawing.Size(973, 583);
            this.Tag = "TienNghi";
            this.layoutNhanVien.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mPanelMenu.ResumeLayout(false);
            this.btnQLTienNghi.ResumeLayout(false);
            this.btnQLTienNghi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutNhanVien;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnTroVe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel mPanelMenu;
        private MetroFramework.Controls.MetroPanel btnQLTienNghi;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel mpanelQlTnContent;
    }
}

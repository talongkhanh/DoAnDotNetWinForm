﻿namespace GUI.ucHoaDon
{
    partial class HoaDon
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
            this.mpanelHoaDon = new MetroFramework.Controls.MetroPanel();
            this.mPanelMenu = new MetroFramework.Controls.MetroPanel();
            this.btnQLLoaiPhong = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.layoutNhanVien.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.mPanelMenu.SuspendLayout();
            this.btnQLLoaiPhong.SuspendLayout();
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
            this.layoutNhanVien.Name = "layoutNhanVien";
            this.layoutNhanVien.RowCount = 1;
            this.layoutNhanVien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutNhanVien.Size = new System.Drawing.Size(1051, 50);
            this.layoutNhanVien.TabIndex = 4;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(273, 44);
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
            this.metroLabel1.Location = new System.Drawing.Point(74, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Hóa Đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.hoadon;
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
            this.btnTroVe.Location = new System.Drawing.Point(998, 3);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(50, 44);
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
            this.tableLayoutPanel1.Controls.Add(this.mpanelHoaDon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mPanelMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 596);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // mpanelHoaDon
            // 
            this.mpanelHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpanelHoaDon.HorizontalScrollbarBarColor = true;
            this.mpanelHoaDon.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanelHoaDon.HorizontalScrollbarSize = 10;
            this.mpanelHoaDon.Location = new System.Drawing.Point(213, 3);
            this.mpanelHoaDon.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.mpanelHoaDon.Name = "mpanelHoaDon";
            this.mpanelHoaDon.Size = new System.Drawing.Size(838, 590);
            this.mpanelHoaDon.TabIndex = 5;
            this.mpanelHoaDon.VerticalScrollbarBarColor = true;
            this.mpanelHoaDon.VerticalScrollbarHighlightOnWheel = false;
            this.mpanelHoaDon.VerticalScrollbarSize = 10;
            // 
            // mPanelMenu
            // 
            this.mPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.mPanelMenu.Controls.Add(this.btnQLLoaiPhong);
            this.mPanelMenu.CustomBackground = true;
            this.mPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelMenu.HorizontalScrollbarBarColor = true;
            this.mPanelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelMenu.HorizontalScrollbarSize = 10;
            this.mPanelMenu.Location = new System.Drawing.Point(0, 3);
            this.mPanelMenu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.mPanelMenu.Name = "mPanelMenu";
            this.mPanelMenu.Size = new System.Drawing.Size(207, 590);
            this.mPanelMenu.TabIndex = 4;
            this.mPanelMenu.VerticalScrollbarBarColor = true;
            this.mPanelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelMenu.VerticalScrollbarSize = 10;
            // 
            // btnQLLoaiPhong
            // 
            this.btnQLLoaiPhong.AccessibleName = "DanhSachHoaDon";
            this.btnQLLoaiPhong.Controls.Add(this.metroLabel2);
            this.btnQLLoaiPhong.Controls.Add(this.pictureBox2);
            this.btnQLLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLLoaiPhong.CustomBackground = true;
            this.btnQLLoaiPhong.HorizontalScrollbar = true;
            this.btnQLLoaiPhong.HorizontalScrollbarBarColor = true;
            this.btnQLLoaiPhong.HorizontalScrollbarHighlightOnWheel = false;
            this.btnQLLoaiPhong.HorizontalScrollbarSize = 10;
            this.btnQLLoaiPhong.Location = new System.Drawing.Point(0, 58);
            this.btnQLLoaiPhong.Name = "btnQLLoaiPhong";
            this.btnQLLoaiPhong.Size = new System.Drawing.Size(378, 50);
            this.btnQLLoaiPhong.TabIndex = 2;
            this.btnQLLoaiPhong.Tag = "0";
            this.btnQLLoaiPhong.VerticalScrollbar = true;
            this.btnQLLoaiPhong.VerticalScrollbarBarColor = true;
            this.btnQLLoaiPhong.VerticalScrollbarHighlightOnWheel = false;
            this.btnQLLoaiPhong.VerticalScrollbarSize = 10;
            this.btnQLLoaiPhong.Click += new System.EventHandler(this.btn_Click);
            this.btnQLLoaiPhong.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnQLLoaiPhong.MouseHover += new System.EventHandler(this.btn_MouseHover);
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
            this.metroLabel2.Size = new System.Drawing.Size(172, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Danh Sách Hóa Đơn";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel_Click);
            this.metroLabel2.MouseLeave += new System.EventHandler(this.metroLabel_MouseLeave);
            this.metroLabel2.MouseHover += new System.EventHandler(this.metroLabel_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.hoadon;
            this.pictureBox2.Location = new System.Drawing.Point(10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.layoutNhanVien);
            this.Name = "HoaDon";
            this.Size = new System.Drawing.Size(1051, 646);
            this.Tag = "HoaDon";
            this.layoutNhanVien.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mPanelMenu.ResumeLayout(false);
            this.btnQLLoaiPhong.ResumeLayout(false);
            this.btnQLLoaiPhong.PerformLayout();
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
        private MetroFramework.Controls.MetroPanel btnQLLoaiPhong;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel mpanelHoaDon;
    }
}

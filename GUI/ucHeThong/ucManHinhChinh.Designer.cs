﻿namespace GUI.ucHeThong
{
    partial class ucManHinhChinh
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mPanelContainer = new MetroFramework.Controls.MetroPanel();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnHeThong = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 788);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mPanelContainer);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(179, 91);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1008, 606);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mPanelContainer
            // 
            this.mPanelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.mPanelContainer.Controls.Add(this.metroTile8);
            this.mPanelContainer.Controls.Add(this.metroTile7);
            this.mPanelContainer.Controls.Add(this.metroTile6);
            this.mPanelContainer.Controls.Add(this.metroTile5);
            this.mPanelContainer.Controls.Add(this.metroTile4);
            this.mPanelContainer.Controls.Add(this.metroTile3);
            this.mPanelContainer.Controls.Add(this.metroTile2);
            this.mPanelContainer.Controls.Add(this.metroTile1);
            this.mPanelContainer.Controls.Add(this.btnHeThong);
            this.mPanelContainer.HorizontalScrollbarBarColor = true;
            this.mPanelContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelContainer.HorizontalScrollbarSize = 10;
            this.mPanelContainer.Location = new System.Drawing.Point(158, 59);
            this.mPanelContainer.Name = "mPanelContainer";
            this.mPanelContainer.Size = new System.Drawing.Size(688, 493);
            this.mPanelContainer.TabIndex = 2;
            this.mPanelContainer.VerticalScrollbarBarColor = true;
            this.mPanelContainer.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelContainer.VerticalScrollbarSize = 10;
            // 
            // metroTile8
            // 
            this.metroTile8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.metroTile8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile8.CustomBackground = true;
            this.metroTile8.Location = new System.Drawing.Point(517, 318);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(130, 130);
            this.metroTile8.TabIndex = 10;
            this.metroTile8.Tag = "Thoat";
            this.metroTile8.Text = "Thoát";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile8.TileImage = global::GUI.Properties.Resources.thoat1;
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.metroTile7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile7.CustomBackground = true;
            this.metroTile7.Location = new System.Drawing.Point(381, 318);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(130, 130);
            this.metroTile7.TabIndex = 9;
            this.metroTile7.Tag = "HoaDon";
            this.metroTile7.Text = "Hóa Đơn";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile7.TileImage = global::GUI.Properties.Resources.hoadon;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile6.CustomBackground = true;
            this.metroTile6.Location = new System.Drawing.Point(517, 46);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(130, 266);
            this.metroTile6.TabIndex = 8;
            this.metroTile6.Tag = "TraPhong";
            this.metroTile6.Text = "Trả Phòng";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile6.TileImage = global::GUI.Properties.Resources.thue;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.metroTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile5.CustomBackground = true;
            this.metroTile5.Location = new System.Drawing.Point(52, 318);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(266, 130);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Tag = "DichVu";
            this.metroTile5.Text = "Dịch Vụ";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile5.TileImage = global::GUI.Properties.Resources.dichvu;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.metroTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile4.CustomBackground = true;
            this.metroTile4.Location = new System.Drawing.Point(381, 46);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(130, 266);
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Tag = "ThuePhong";
            this.metroTile4.Text = "Thuê Phòng";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile4.TileImage = global::GUI.Properties.Resources.traphong;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.CustomBackground = true;
            this.metroTile3.Location = new System.Drawing.Point(188, 182);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(130, 130);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Tag = "TienNghi";
            this.metroTile3.Text = "Tiện Nghi";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile3.TileImage = global::GUI.Properties.Resources.tiennghi;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.CustomBackground = true;
            this.metroTile2.Location = new System.Drawing.Point(188, 46);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(130, 130);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Tag = "NhanVien";
            this.metroTile2.Text = "Nhân Viên";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile2.TileImage = global::GUI.Properties.Resources.nhanvien;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(52, 182);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(130, 130);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Tag = "Phong";
            this.metroTile1.Text = "Phòng";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile1.TileImage = global::GUI.Properties.Resources.thuephong;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeThong.CustomBackground = true;
            this.btnHeThong.Location = new System.Drawing.Point(52, 46);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(130, 130);
            this.btnHeThong.TabIndex = 2;
            this.btnHeThong.Tag = "HeThong";
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHeThong.TileImage = global::GUI.Properties.Resources.setting;
            this.btnHeThong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeThong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnHeThong.UseTileImage = true;
            this.btnHeThong.Click += new System.EventHandler(this.metroTile_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucManHinhChinh";
            this.Size = new System.Drawing.Size(1366, 788);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.mPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel mPanelContainer;
        private MetroFramework.Controls.MetroTile btnHeThong;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTile metroTile8;
    }
}

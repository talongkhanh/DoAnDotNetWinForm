﻿namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mPanelChinh = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mPanelChinh
            // 
            this.mPanelChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelChinh.HorizontalScrollbarBarColor = true;
            this.mPanelChinh.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelChinh.HorizontalScrollbarSize = 8;
            this.mPanelChinh.Location = new System.Drawing.Point(0, 90);
            this.mPanelChinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mPanelChinh.Name = "mPanelChinh";
            this.mPanelChinh.Size = new System.Drawing.Size(1942, 1012);
            this.mPanelChinh.TabIndex = 0;
            this.mPanelChinh.VerticalScrollbarBarColor = true;
            this.mPanelChinh.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelChinh.VerticalScrollbarSize = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.mPanelChinh);
            this.Font = new System.Drawing.Font("Lato", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lý Khách Sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanelChinh;
    }
}


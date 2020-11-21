using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.ucHeThong;
using MetroFramework.Controls;

namespace GUI.ucNhanVien
{
    public partial class templateNhanVien : UserControl
    {
        public templateNhanVien()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ucManHinhChinh ucManHinhChinh = new ucManHinhChinh();
            ucManHinhChinh.Dock = DockStyle.Fill;

            frmMain.frmMain_.MetroContainer.Controls.Add(ucManHinhChinh);
            frmMain.frmMain_.MetroContainer.Controls["ucManHinhChinh"].BringToFront();

            foreach (var item in frmMain.frmMain_.MetroContainer.Controls.OfType<templateNhanVien>())
            {
                frmMain.frmMain_.MetroContainer.Controls.Remove(item);
            }
        }

        private void btnQlNhanVien_MouseHover(object sender, EventArgs e)
        {
            MetroPanel pnl = (MetroPanel)sender;
            pnl.CustomBackground = true;
            pnl.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void btnQlNhanVien_MouseLeave(object sender, EventArgs e)
        {
            MetroPanel pnl = (MetroPanel)sender;
            pnl.CustomBackground = true;
            
            // keep background color active button
            if (pnl.Tag.ToString() == "1")
            {
                pnl.BackColor = Color.FromArgb(52, 73, 94);
            }
            else
            {
                pnl.BackColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void metroLabel_MouseHover(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            btnQlNhanVien_MouseHover((MetroPanel)mlb.Parent, e);
        }

        private void metroLabel_MouseLeave(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            MetroPanel pnl = (MetroPanel)mlb.Parent;
            btnQlNhanVien_MouseLeave(pnl, e);
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            btnQlNhanVien_MouseHover((MetroPanel)ptb.Parent, e);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            btnQlNhanVien_MouseLeave((MetroPanel)ptb.Parent, e);
        }
        
        void HienThiNoiDung(string name)
        {
            // Delete content
            
            foreach (var item in mpanelQlNvContent.Controls.OfType<UserControl>())
            {
                mpanelQlNvContent.Controls.Remove(item);
            }

            // Add new content 

            switch (name)
            {
                case "QuanLyNhanVien":
                    {
                        QuanLyNhanVien QuanLyNhanVien = new QuanLyNhanVien();
                        QuanLyNhanVien.Dock = DockStyle.Fill;
                        mpanelQlNvContent.Controls.Add(QuanLyNhanVien);
                        mpanelQlNvContent.Controls["QuanLyNhanVien"].BringToFront();

                    }
                    break;
                case "QuanLyChucVu":
                    {
                        QuanLyChucVu QuanLyChucVu = new QuanLyChucVu();
                        QuanLyChucVu.Dock = DockStyle.Fill;
                        mpanelQlNvContent.Controls.Add(QuanLyChucVu);
                        mpanelQlNvContent.Controls["QuanLyChucVu"].BringToFront();

                    }
                    break;
                case "QuanLyPhongBan":
                    {
                        QuanLyPhongBan QuanLyPhongBan = new QuanLyPhongBan();
                        QuanLyPhongBan.Dock = DockStyle.Fill;
                        mpanelQlNvContent.Controls.Add(QuanLyPhongBan);
                        mpanelQlNvContent.Controls["QuanLyPhongBan"].BringToFront();

                    }
                    break;
            }
        }

        private void btnQl_Click(object sender, EventArgs e)
        {
            MetroPanel pnl = (MetroPanel)sender;
            HienThiNoiDung(pnl.AccessibleName.ToString());
            // remove all btn color
            foreach (MetroPanel item in mPanelMenu.Controls.OfType<MetroPanel>())
            {
                item.Tag = "0";
                item.BackColor = Color.FromArgb(44, 62, 80);
            }
            // click active button
            pnl.Tag = "1";
            pnl.CustomBackground = true;
            pnl.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void metroLabel_Click(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            MetroPanel pnl = (MetroPanel)mlb.Parent;
            btnQl_Click(pnl, e);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            MetroPanel pnl = (MetroPanel)ptb.Parent;
            btnQl_Click(pnl, e);
        }

    }
}

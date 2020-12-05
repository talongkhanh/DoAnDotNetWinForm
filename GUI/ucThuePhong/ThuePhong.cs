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

namespace GUI.ucThuePhong
{
    public partial class ThuePhong : UserControl
    {
        public ThuePhong()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
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

        private void btn_MouseHover(object sender, EventArgs e)
        {
            MetroPanel pnl = (MetroPanel)sender;
            pnl.CustomBackground = true;
            pnl.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
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

        private void metroLabel_Click(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            MetroPanel pnl = (MetroPanel)mlb.Parent;
            btn_Click(pnl, e);
        }

        private void metroLabel_MouseHover(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            btn_MouseHover((MetroPanel)mlb.Parent, e);
        }

        private void metroLabel_MouseLeave(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            MetroPanel pnl = (MetroPanel)mlb.Parent;
            btn_MouseLeave(pnl, e);
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            MetroPanel pnl = (MetroPanel)ptb.Parent;
            btn_Click(pnl, e);
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            btn_MouseHover((MetroPanel)ptb.Parent, e);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            btn_MouseLeave((MetroPanel)ptb.Parent, e);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            ucManHinhChinh ucManHinhChinh = new ucManHinhChinh();
            ucManHinhChinh.Dock = DockStyle.Fill;

            frmMain.frmMain_.MetroContainer.Controls.Add(ucManHinhChinh);
            frmMain.frmMain_.MetroContainer.Controls["ucManHinhChinh"].BringToFront();

            foreach (var item in frmMain.frmMain_.MetroContainer.Controls.OfType<ThuePhong>())
            {
                frmMain.frmMain_.MetroContainer.Controls.Remove(item);
            }
        }
        void HienThiNoiDung(string name)
        {
            // Delete content

            foreach (var item in mpanenThuePhong.Controls.OfType<UserControl>())
            {
                mpanenThuePhong.Controls.Remove(item);
            }

            // Add new content 

            switch (name)
            {
                case "KhachHang":
                    {
                        KhachHang KhachHang = new KhachHang();
                        KhachHang.Dock = DockStyle.Fill;
                        mpanenThuePhong.Controls.Add(KhachHang);
                        mpanenThuePhong.Controls["KhachHang"].BringToFront();

                    }
                    break;
                case "KhachHangThuePhong":
                    {
                        KhachHangThuePhong KhachHangThuePhong = new KhachHangThuePhong();
                        KhachHangThuePhong.Dock = DockStyle.Fill;
                        mpanenThuePhong.Controls.Add(KhachHangThuePhong);
                        mpanenThuePhong.Controls["KhachHangThuePhong"].BringToFront();

                    }
                    break;
            }
        }

        private void mpanenThuePhong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

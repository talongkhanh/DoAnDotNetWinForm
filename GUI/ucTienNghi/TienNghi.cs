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

namespace GUI.ucTienNghi
{
    public partial class TienNghi : UserControl
    {
        public TienNghi()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            ucManHinhChinh ucManHinhChinh = new ucManHinhChinh();
            ucManHinhChinh.Dock = DockStyle.Fill;

            frmMain.frmMain_.MetroContainer.Controls.Add(ucManHinhChinh);
            frmMain.frmMain_.MetroContainer.Controls["ucManHinhChinh"].BringToFront();

            foreach (var item in frmMain.frmMain_.MetroContainer.Controls.OfType<TienNghi>())
            {
                frmMain.frmMain_.MetroContainer.Controls.Remove(item);
            }
        }

        private void btnQLTienNghi_MouseHover(object sender, EventArgs e)
        {
            MetroPanel pnl = (MetroPanel)sender;
            pnl.CustomBackground = true;
            pnl.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void btnQLTienNghi_MouseLeave(object sender, EventArgs e)
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

        private void btnQLTienNghi_Click(object sender, EventArgs e)
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

        private void metroLabel2_MouseHover(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            btnQLTienNghi_MouseHover((MetroPanel)mlb.Parent, e);
        }

        private void metroLabel2_MouseLeave(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            MetroPanel pnl = (MetroPanel)mlb.Parent;
            btnQLTienNghi_MouseLeave(pnl, e);
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            MetroLabel mlb = (MetroLabel)sender;
            MetroPanel pnl = (MetroPanel)mlb.Parent;
            btnQLTienNghi_Click(pnl, e);
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            MetroPanel pnl = (MetroPanel)ptb.Parent;
            btnQLTienNghi_Click(pnl, e);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            btnQLTienNghi_MouseHover((MetroPanel)ptb.Parent, e);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            btnQLTienNghi_MouseHover((MetroPanel)ptb.Parent, e);
        }
        void HienThiNoiDung(string name)
        {
            // Delete content

            foreach (var item in mpanelQlTnContent.Controls.OfType<UserControl>())
            {
                mpanelQlTnContent.Controls.Remove(item);
            }

            //Add new content

            switch (name)
            {
                case "QuanLyTienNghi":
                    {
                        QuanLyTienNghi QuanLyTienNghi = new QuanLyTienNghi();
                        QuanLyTienNghi.Dock = DockStyle.Fill;
                        mpanelQlTnContent.Controls.Add(QuanLyTienNghi);
                        mpanelQlTnContent.Controls["QuanLyTienNghi"].BringToFront();

                    }
                    break;
            }
        }
    }
}

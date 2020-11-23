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
using GUI.ucDichVu;
using MetroFramework.Controls;

namespace GUI.ucDichVu
{
    public partial class DichVu : UserControl
    {
        public DichVu()
        {
            InitializeComponent();
        }

        private void mpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            ucManHinhChinh ucManHinhChinh = new ucManHinhChinh();
            ucManHinhChinh.Dock = DockStyle.Fill;

            frmMain.frmMain_.MetroContainer.Controls.Add(ucManHinhChinh);
            frmMain.frmMain_.MetroContainer.Controls["ucManHinhChinh"].BringToFront();

            foreach (var item in frmMain.frmMain_.MetroContainer.Controls.OfType<DichVu>())
            {
                frmMain.frmMain_.MetroContainer.Controls.Remove(item);
            }
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
        void HienThiNoiDung(string name)
        {
            // Delete content

            foreach (var item in mpanelQlDvContent.Controls.OfType<UserControl>())
            {
                mpanelQlDvContent.Controls.Remove(item);
            }

            // Add new content 

            switch (name)
            {
                case "QuanLyDichVu":
                    {
                        QuanLyDichVu QuanLyDichVu = new QuanLyDichVu();
                        QuanLyDichVu.Dock = DockStyle.Fill;
                        mpanelQlDvContent.Controls.Add(QuanLyDichVu);
                        mpanelQlDvContent.Controls["QuanLyDichVu"].BringToFront();

                    }
                    break;
                case "SuDungDichVu":
                    {
                        SuDungDichVu SuDungDichVu = new SuDungDichVu();
                        SuDungDichVu.Dock = DockStyle.Fill;
                        mpanelQlDvContent.Controls.Add(SuDungDichVu);
                        mpanelQlDvContent.Controls["SuDungDichVu"].BringToFront();

                    }
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.ucNhanVien;
using GUI.ucHeThong;
using GUI.ucPhong;
using GUI.ucDichVu;
using GUI.ucThuePhong;
using GUI.ucTraPhong;
using GUI.ucHoaDon;
using GUI.ucTienNghi;

using MetroFramework.Controls;

namespace GUI.ucHeThong
{
    public partial class ucManHinhChinh : UserControl
    {
        int poinChange = 0;
        string btnName = "";
        public ucManHinhChinh()
        {
            InitializeComponent();
        }

        private void metroTile_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MetroTile btn = (MetroTile)sender;
            btnName = btn.Tag.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(btnName)
            {
                case "NhanVien":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        templateNhanVien templateNhanVien = new templateNhanVien();
                        templateNhanVien.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(templateNhanVien);
                        frmMain.frmMain_.MetroContainer.Controls["templateNhanVien"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
                case "HeThong":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        HeThong HeThong = new HeThong();
                        HeThong.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(HeThong);
                        frmMain.frmMain_.MetroContainer.Controls["HeThong"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
                case "Phong":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        Phong Phong = new Phong();
                        Phong.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(Phong);
                        frmMain.frmMain_.MetroContainer.Controls["Phong"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
                case "TienNghi":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        TienNghi TienNghi = new TienNghi();
                        TienNghi.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(TienNghi);
                        frmMain.frmMain_.MetroContainer.Controls["TienNghi"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
                case "DichVu":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        DichVu DichVu = new DichVu();
                        DichVu.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(DichVu);
                        frmMain.frmMain_.MetroContainer.Controls["DichVu"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
                case "ThuePhong":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        ThuePhong ThuePhong = new ThuePhong();
                        ThuePhong.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(ThuePhong);
                        frmMain.frmMain_.MetroContainer.Controls["ThuePhong"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
                case "TraPhong":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        TraPhong TraPhong = new TraPhong();
                        TraPhong.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(TraPhong);
                        frmMain.frmMain_.MetroContainer.Controls["TraPhong"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
                case "HoaDon":
                    if (poinChange >= mPanelContainer.Size.Width)
                    {
                        timer1.Stop();
                        HoaDon HoaDon = new HoaDon();
                        HoaDon.Dock = DockStyle.Fill;
                        frmMain.frmMain_.MetroContainer.Controls.Add(HoaDon);
                        frmMain.frmMain_.MetroContainer.Controls["HoaDon"].BringToFront();

                        foreach (ucManHinhChinh item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucManHinhChinh>())
                        {
                            frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                        }
                    }
                    else
                    {
                        poinChange += 80;
                        mPanelContainer.Location = new Point(poinChange, 0);
                    }
                    break;
            }
            
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

            DialogResult ok = new DialogResult();
            ok = MessageBox.Show("Bạn chắc chắn muốn thoát!", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ok == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

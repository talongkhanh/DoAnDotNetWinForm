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
            }
            
        }
    }
}

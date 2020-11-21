using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ucHeThong
{
    public partial class ucDangNhap : UserControl
    {
        public ucDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                ucManHinhChinh ucManHinhChinh = new ucManHinhChinh();
                ucManHinhChinh.Dock = DockStyle.Fill;

                frmMain.frmMain_.MetroContainer.Controls.Add(ucManHinhChinh);
                frmMain.frmMain_.MetroContainer.Controls["ucManHinhChinh"].BringToFront();

                foreach (var item in frmMain.frmMain_.MetroContainer.Controls.OfType<ucDangNhap>())
                {
                    frmMain.frmMain_.MetroContainer.Controls.Remove(item);
                }
            }
        }
    }
}

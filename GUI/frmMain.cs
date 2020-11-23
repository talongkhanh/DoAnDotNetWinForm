using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using GUI.ucHeThong;

namespace GUI
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private static frmMain _frmMain;
        public static frmMain frmMain_
        {
            get
            {
                if (_frmMain == null)
                {
                    _frmMain = new frmMain();
                }
                return _frmMain;
            }
        }

        public MetroPanel MetroContainer
        {
            get
            {
                return this.mPanelChinh;
            }
            set
            {
                this.mPanelChinh = value;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _frmMain = this;
            ucDangNhap ucDN = new ucDangNhap();
            ucDN.Dock = DockStyle.Fill;
            _frmMain.MetroContainer.Controls.Add(ucDN);
            _frmMain.MetroContainer.Controls["ucDangNhap"].BringToFront();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;

namespace GUI.ucNhanVien
{
    public partial class QuanLyNhanVien : UserControl
    {
        BUS_QuanLyNhanVien bus = new BUS_QuanLyNhanVien();

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LayDgv();
            LayCbo();
        }

        void LayDgv()
        {
            DataTable dt = new DataTable();
            dt = bus.ShowNhanVien();
            dataGridView1.DataSource = dt;
        }

        void LayCbo()
        {
            DataTable dt = new DataTable();
            dt = bus.ShowCbo();
            metroComboBox1.DataSource = dt;
            metroComboBox1.DisplayMember = "TenChucVu";
            metroComboBox1.ValueMember = "MaChucVu";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text == "" || txtQueQuan.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                them();
                LayDgv();
            }

        }
        void them()
        {
            try
            {
                string gt = "Nam";
                if (radNu.Checked == true)
                {
                    gt = "Nữ";
                }
                bus.ThemNhanVien(txtTenNhanVien.Text, gt, dtNgaySinh.Value.ToShortDateString(), 
                    txtQueQuan.Text, metroComboBox1.SelectedValue.ToString());
            }
            catch
            {
                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void xoa()
        {
            try
            {
                int row = bus.XoaNhanVien(txtMaNhanVien.Text);
                if(row == 0)
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
            LayDgv();
        }
    }
}

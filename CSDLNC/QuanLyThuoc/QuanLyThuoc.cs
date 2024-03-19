using CSDLNC.ThongKe;
using DoAnHEQUANTRI;
using NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyThuoc
{
    public partial class QuanLyThuocHT : Form
    {
        public QuanLyThuocHT()
        {
            InitializeComponent();
        }


        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {

        }

        private void DanhSachThuoc_Click_1(object sender, EventArgs e)
        {
            SuspendLayout();
            DanhSachThuoc danhsachthuoc = new DanhSachThuoc();
            danhsachthuoc.ShowDialog();
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

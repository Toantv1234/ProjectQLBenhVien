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
    public partial class DanhSachThuoc : Form
    {
        string _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";

        public DanhSachThuoc()
        {
            InitializeComponent();
        }

        private void ThemThuoc_Click(object sender, EventArgs e)
        {
            ThemThuoc tt = new ThemThuoc();
            tt.ShowDialog();
        }

        private void setGridViewEditable(bool b)
        {
            ListThuoc.AllowUserToAddRows = b;
            ListThuoc.ReadOnly = !b;
            ListThuoc.AllowUserToDeleteRows = b;
        }

        private void updateOrDeleteThuoc_Click(object sender, EventArgs e)
        {
            CapNhatHoacXoaThuoc dialog = new CapNhatHoacXoaThuoc();
            dialog.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachThuoc_Load_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            setGridViewEditable(false);
            DataTable thuoc = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Thuoc", connection);
            adapter.Fill(thuoc);
            ListThuoc.DataSource = thuoc;
        }
    }
}

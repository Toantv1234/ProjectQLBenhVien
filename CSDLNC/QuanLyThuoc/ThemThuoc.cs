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
    public partial class ThemThuoc : Form
    {
        string _connectionStr = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";

        public ThemThuoc()
        {
            InitializeComponent();
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection(_connectionStr);
            _connection.Open();

            // xây dựng câu lệnh sql thêm thuốc
            string procname = "ThemThuoc";

            // tạo đối tượng thực thi câu lệnh sql
            SqlCommand _command = new SqlCommand(procname);

            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;

            // truyền tham số vào stored procedure
            _command.Parameters.Add("@p_TenThuoc", SqlDbType.NVarChar);
            _command.Parameters.Add("@p_MaThuoc", SqlDbType.Char);

            // truyền giá trị cho tham số
            _command.Parameters["@p_TenThuoc"].Value = textboxTT.Text;
            _command.Parameters["@p_MaThuoc"].Value = textboxMT.Text;

            
            // thực thi lệnh SQL và lấy kết quả trả về
            int n = _command.ExecuteNonQuery();

            if (n > 0)
            {
                MessageBox.Show("Add successfully !!!");
                string mathuoc = (string)_command.Parameters["@p_MaThuoc"].Value;
                MessageBox.Show("Mã phòng mới thêm: " + mathuoc);
                this.Close();
            }
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }

        private void ThemThuoc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

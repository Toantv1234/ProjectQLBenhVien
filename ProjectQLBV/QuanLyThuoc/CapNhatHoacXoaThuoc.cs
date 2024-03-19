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
    public partial class CapNhatHoacXoaThuoc : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        string _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";

        public CapNhatHoacXoaThuoc()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // tạo đối tượng kết nối CSDL và mở kết nối
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            // xây dựng câu lệnh sql tìm thuốc
            string procname = "TimThuoc";

            // tạo đối tượng thực thi câu lệnh sql
            _command = new SqlCommand(procname);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;

            // truyền tham số vào stored procedure
            _command.Parameters.Add("@p_MaThuoc", SqlDbType.Char);

            // truyền giá trị cho tham số
            _command.Parameters["@p_MaThuoc"].Value = textboxMT.Text;

            // thực thi lệnh SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                textboxTT.Text = (string)reader["TenThuoc"];
            }
            else
            {
                MessageBox.Show("Not found !!!");
            }

            _connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            string procname = "XoaThuoc";
            _command = new SqlCommand(procname);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;

            _command.Parameters.Add("@p_MaThuoc", SqlDbType.Char);

            _command.Parameters["@p_MaThuoc"].Value = textboxMT.Text;

            int n = _command.ExecuteNonQuery();

            MessageBox.Show("Delete " + n.ToString() + " rows");
            textboxMT.Text = "";
            textboxTT.Text = "";

            _connection.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            string procname = "CapNhatThuoc";
            _command = new SqlCommand(procname);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;

            _command.Parameters.Add("@p_TenThuoc", SqlDbType.NVarChar);
            _command.Parameters.Add("@p_MaThuoc", SqlDbType.Char);

            _command.Parameters["@p_TenThuoc"].Value = textboxTT.Text;
            _command.Parameters["@p_MaThuoc"].Value = textboxMT.Text;

            int n = _command.ExecuteNonQuery();
            MessageBox.Show("Update " + n.ToString() + " rows");
            textboxTT.Text = "";
            textboxMT.Text = "";

            _connection.Close();
        }

        private void CapNhatHoacXoaThuoc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

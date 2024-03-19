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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NhanVien.Quantrivien
{
    public partial class NVthemnhanvien : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public NVthemnhanvien()
        {
            InitializeComponent();
            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var myForm = new NVthemvacapnhatnhanvien();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String procname = "ThemNhanVien";
            //Bước 3: Tạo đối tượng thực thi câu lệnh SQL
            _command = new SqlCommand(procname);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;
            //Truyền tham số vào stored procedure
            _command.Parameters.Add("@MaNV", SqlDbType.Char);
            _command.Parameters.Add("@Hoten", SqlDbType.NVarChar);
            _command.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;
            // truyền giá trị cho tham số
            _command.Parameters["@MaNV"].Value = textBox1.Text;
            _command.Parameters["@Hoten"].Value = textBox2.Text;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            _command.ExecuteNonQuery();
            int n = (int)_command.Parameters["@check"].Value;
            if (n == 0)
            {
                MessageBox.Show("Nhân viên đã được thêm:"); //+
            }
            else
                MessageBox.Show("Nhân viên đã tồn tại!!!");
            //Bước 6
            _connection.Close();
        }

        private void NVthemnhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}

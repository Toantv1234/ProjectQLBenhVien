using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace NhanVien.Quantrivien
{
    public partial class NSthemnhasi : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public NSthemnhasi()
        {
            InitializeComponent();
            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String procname = "ThemNhaSi";
            //Bước 3: Tạo đối tượng thực thi câu lệnh SQL
            _command = new SqlCommand(procname);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;
            //Truyền tham số vào stored procedure
            _command.Parameters.Add("@MaNS", SqlDbType.Char);
            _command.Parameters.Add("@Hoten", SqlDbType.NVarChar);
            _command.Parameters.Add("@Tuan", SqlDbType.NVarChar);
            _command.Parameters.Add("@Thang", SqlDbType.NVarChar);
            _command.Parameters.Add("@NgayAuto", SqlDbType.Date);
            _command.Parameters.Add("@newid", SqlDbType.Int).Direction = ParameterDirection.Output;
            // truyền giá trị cho tham số
            _command.Parameters["@MaNS"].Value = textBox1.Text;
            _command.Parameters["@Hoten"].Value = textBox2.Text;
            _command.Parameters["@Tuan"].Value = textBox3.Text;
            _command.Parameters["@Thang"].Value = textBox4.Text;
            _command.Parameters["@NgayAuto"].Value = dateTimePicker1.Text;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            _command.ExecuteNonQuery();
            int n = (int)_command.Parameters["@newid"].Value;
            if (n == 0)
            {
                MessageBox.Show("Nha sĩ đã được thêm:"); //+
            }
            else
                MessageBox.Show("Nha sĩ đã tồn tại!!!");
            //Bước 6
            _connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var myForm = new NSthemvacapnhatnhasi();
            myForm.Show();
        }

        private void NSthemnhasi_Load(object sender, EventArgs e)
        {

        }
    }
}

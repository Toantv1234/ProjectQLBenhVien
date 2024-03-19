using CSDLNC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnHEQUANTRI
{
    public partial class TaoHoSoMoi : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        String NAME;
        String mabn;
        public TaoHoSoMoi(string name)
        {
            InitializeComponent();
            _connectionString = @"Data Source=SPUTNIK-I;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";
            NAME  = name;
        }
        public string ReturnMaBN()
        {
            return mabn;
        }
        private void DangKyKH_Load(object sender, EventArgs e)
        {
            textBox2.Text = NAME;
        }

        private void dangky_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Không để trống những thông tin cần thiết");
                }
                else
                {
                    _connection = new SqlConnection(_connectionString);
                    _connection.Open();
                    String procname = "p_TaoHSMoi";
                    _command = new SqlCommand(procname);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Connection = _connection;
                    _command.Parameters.Add("@MABN", SqlDbType.VarChar,10);
                    _command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 255);
                    _command.Parameters.Add("@NgaySinh", SqlDbType.Date);
                    _command.Parameters.Add("@DiaChi", SqlDbType.NVarChar,255);
                    _command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar,20);
                    _command.Parameters.Add("@Email", SqlDbType.NVarChar,255);

                    _command.Parameters["@MABN"].Value = textBox5.Text;
                    _command.Parameters["@HoTen"].Value = textBox2.Text;
                    _command.Parameters["@NgaySinh"].Value = NgaySinh.Value;
 
                    _command.Parameters["@DiaChi"].Value = textBox3.Text;
                    _command.Parameters["@SoDienThoai"].Value = textBox4.Text;
                    _command.Parameters["@Email"].Value = textBox1.Text;
                    _command.ExecuteNonQuery();
                    mabn = textBox5.Text.ToString();
                    MessageBox.Show("Đăng ký thành công");
                    
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

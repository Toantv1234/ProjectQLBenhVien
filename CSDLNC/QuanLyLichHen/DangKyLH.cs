using CSDLNC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnHEQUANTRI
{
    
    public partial class DangKyLichHen : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        string ten;
        string ngay;
        string type;
        public DangKyLichHen()
        {
            InitializeComponent();
            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";

        }

        private void DangKyKH_Load(object sender, EventArgs e)
        {
           
        }

        private void dangky_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Không để trống những thông tin cần thiết");
                }
                else
                {
                    try 
                    
                    {
                        _connection = new SqlConnection(_connectionString);
                        _connection.Open();
                        string proc = "p_insertCuocHen";
                        _command = new SqlCommand(proc);
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Connection = _connection;
                        _command.Parameters.Add("@ThoiGian", SqlDbType.DateTime).Value = ThoiGian.Value;
                        _command.Parameters.Add("@MABN", SqlDbType.Char,10).Value = textBox1.Text;
                        _command.Parameters.Add("@MaNhaSi", SqlDbType.Char, 10).Value = textBox6.Text;
                        _command.Parameters.Add("@MaTroKham", SqlDbType.Char, 10).Value = textBox3.Text;
                        _command.Parameters.Add("@Phong", SqlDbType.NVarChar,255).Value = numericUpDown1.Value.ToString();
                        _command.Parameters.Add("@LoaiCuocHen", SqlDbType.Char, 10).Value = type;
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        MessageBox.Show("Đăng ký thành công");
                        this.Close();


                    }

                    catch(SqlException ex) 
                    
                    { MessageBox.Show(ex.ToString()); }
                   
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox6.Text = "";
            XemYeuCauLH YC = new XemYeuCauLH();
            YC.ShowDialog();
            YC.ReturnTenNgay(ref ten,ref ngay);
            if(string.IsNullOrWhiteSpace(ngay))
            {
                ngay = DateTime.Now.ToString();
            }
            textBox2.Text = ten;
            ThoiGian.Value = DateTime.Parse(ngay);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string proc = "p_checkHOSO";
            bool check;
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
            _command = new SqlCommand(proc);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;
            _command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = textBox2.Text;
            _command.Parameters.Add("@OK", SqlDbType.Bit).Direction = ParameterDirection.Output;
            _command.ExecuteNonQuery();
            check = (bool)_command.Parameters["@OK"].Value;
            _connection.Close();
            if( check == false ) 
            {
                MessageBox.Show("Bệnh nhân chưa có hồ sơ");
                type = "Cuộc hẹn mới";
                TaoHoSoMoi HS = new TaoHoSoMoi(textBox2.Text);
                HS.ShowDialog();
                string mabn = HS.ReturnMaBN();
                textBox1.Text = mabn;

            }
            else 
            {   
                MessageBox.Show("Bệnh nhân đã khám rồi");
                proc = "p_LaythongtincuochenCuochen";
                type = "Tái khám";
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                _command = new SqlCommand(proc);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
                _command.Parameters.Clear();
                _command.Parameters.Add("@TEN", SqlDbType.NVarChar,255).Value = textBox2.Text.ToString();
                _command.Parameters.Add("@MABN", SqlDbType.NVarChar,255).Direction = ParameterDirection.Output;
                _command.Parameters.Add("@MANS", SqlDbType.NVarChar, 255).Direction = ParameterDirection.Output;
                _command.ExecuteNonQuery();
                textBox1.Text = (_command.Parameters["@MABN"].Value).ToString();
                textBox6.Text = (_command.Parameters["@MANS"].Value).ToString();
                _connection.Close();
            }
        }
    }
}

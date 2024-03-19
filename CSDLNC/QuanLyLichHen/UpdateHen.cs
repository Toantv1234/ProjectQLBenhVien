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

namespace CSDLNC
{
    public partial class UpdateHen : Form
    {
        public string Time,Mabn;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public UpdateHen(string time,string mabn)
        {
            InitializeComponent();

            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";
            Time = time;
            Mabn = mabn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateHen_Load(object sender, EventArgs e)
        {
            textBox1.Text = Time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string proc = "p_updateCuocHen";
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                _command = new SqlCommand(proc);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
                _command.Parameters.Add("@ThoiGian", SqlDbType.Date).Value = dateTimePicker1.Value;
                _command.Parameters.Add("@MaBN", SqlDbType.Char, 10).Value = Mabn;
                _command.ExecuteNonQuery();
                _connection.Close();
                MessageBox.Show("Cập nhật thành công");
                this.Close();

            }
            catch(SqlException ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}

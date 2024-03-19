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
using System.Xml.Linq;
using CSDLNC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnHEQUANTRI
{
    public partial class Login : Form
    {
        public static Login instance;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public Login()
        {
            InitializeComponent();
            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";
        }
        private void LoginKH_Load(object sender, EventArgs e)
        {

        }
        private void Dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                String procname = "p_KtraTKNS";
                _command = new SqlCommand(procname);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
                _command.Parameters.Add("@MANS", SqlDbType.NVarChar);
                _command.Parameters.Add("@OK", SqlDbType.Bit).Direction = ParameterDirection.Output;
                _command.Parameters["@MANS"].Value = textBox1.Text;
                _command.ExecuteNonQuery();
                bool ok = (bool)_command.Parameters["@OK"].Value;
                if (ok == true) 
                { 
                    ChonHethongNS test1 = new ChonHethongNS(textBox1.Text);
                    this.Hide();
                    test1.ShowDialog(this);
                    textBox1.Text = "";
                }
                else 
                {
                    MessageBox.Show("Dang nhap that bai");
                
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myParent = (Home)this.Owner;
            myParent.Show();
            this.Close();
        }
    }
}

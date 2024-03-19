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



namespace NhanVien
{
    public partial class NSxemdsnhasi : Form
    {
        //SqlConnection _connection = null;
        //SqlCommand _command = null;
        //String _connectionString = "";
        public NSxemdsnhasi()
        {
            InitializeComponent();
            /*_connectionString = @"Data Source=DESKTOP-OB2NBQU;Initial Catalog=QuanLyPhongKhamNhaKhoaCSDL;Integrated 
Security=True";

            String procname = "XemDSNhaSi";
            //Bước 3: Tạo đối tượng thực thi câu lệnh SQL
            _command = new SqlCommand(procname);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;
            DataTable table = new DataTable();
            table = _command.ExecuteReader();*/

            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("XemDSNhaSi", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            
            myConn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataBind();
            Hide();
            var myForm = new menuQuanTri();
            myForm.Show();
        }
    }
}

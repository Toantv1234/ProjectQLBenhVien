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

namespace NhanVien.Quantrivien
{
    public partial class NSxemlichlamviecNS : Form
    {
        public NSxemlichlamviecNS()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("XemLichLamViecNhaSi", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            myConn.Close();
            //dataGridView1.DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Hide();
            var myForm = new menuQuanTri();
            myForm.Show();
        }

        private void NSxemlichlamviecNS_Load(object sender, EventArgs e)
        {

        }
    }
}

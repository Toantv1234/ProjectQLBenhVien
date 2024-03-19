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

namespace NhanVien
{
    public partial class NSxemdsnhasiNV : Form
    {
        public NSxemdsnhasiNV()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataBind();
            Hide();
            var myForm = new menuNV();
            myForm.Show();
        }

        private void NSxemdsnhasiNV_Load(object sender, EventArgs e)
        {

        }
    }
}

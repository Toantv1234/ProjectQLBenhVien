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
using DoAnHEQUANTRI;

namespace CSDLNC
{
    public partial class QLCuocHenNS : Form
    {
        public static QLCuocHenNS instance;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        String MANS;
        public QLCuocHenNS(string mans)
        {
            InitializeComponent();
            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";
            MANS = mans;
        }
     
       
        private void Form1_Load(object sender, EventArgs e)
        {

            //  DataTable tablebomon = new DataTable();
            //   adapter.Fill(tablebomon);
            //  CBBBOMON.ValueMember = "MABM";
            //  CBBBOMON.DisplayMember = "MABM";
            // CBBBOMON.DataSource = tablebomon;
            // CBBBOMON.SelectedIndex = -1;
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            string proc = "p_viewCuocHen";
            _connection = new SqlConnection(_connectionString);
            SqlDataAdapter da = new SqlDataAdapter(proc, _connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            _connection.Close();
        }
    

        


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
           
        }

        /*private void CBBBOMON_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBBBOMON.SelectedValue != null) 
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                string sql = string.Format("select * from GIAOVIEN where GIAOVIEN.MABM like '{0}' ", CBBBOMON.SelectedValue);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, _connectionString);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                _connection.Close();

            }

        }*/
      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MaBN;
            NhapBenhNhan bn = new NhapBenhNhan();
            bn.ShowDialog();
            MaBN = bn.ReturnBN();
            string proc = "p_viewCuocHenBN";
            _connection = new SqlConnection(_connectionString);
            SqlDataAdapter da = new SqlDataAdapter(proc, _connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@MABN", SqlDbType.NVarChar).Value = MaBN;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            _connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MaPK;
            LocPhongKham pk = new LocPhongKham();
            pk.ShowDialog();
            MaPK = pk.ReturnPK();
            string proc = "p_viewCuocHenPK";
            _connection = new SqlConnection(_connectionString);
            SqlDataAdapter da = new SqlDataAdapter(proc, _connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@MAPK", SqlDbType.NVarChar).Value = MaPK;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            _connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MaNS;
            NhapNhaSi ns = new NhapNhaSi();
            ns.ShowDialog();
            MaNS = ns.ReturnNS();
            string proc = "p_viewCuocHenNS";
            _connection = new SqlConnection(_connectionString);
            SqlDataAdapter da = new SqlDataAdapter(proc, _connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@MANS", SqlDbType.NVarChar).Value = MaNS;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            _connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            string proc = "p_viewCuocHenNS";
            _connection = new SqlConnection(_connectionString);
            SqlDataAdapter da = new SqlDataAdapter(proc, _connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@MANS", SqlDbType.NVarChar).Value = MANS;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            _connection.Close();
        }
    }
}

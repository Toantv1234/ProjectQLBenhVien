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

namespace CSDLNC.ThongKe
{
    
    public partial class ThongKeCuocHen : Form
    {
        public static QLCuocHenNS instance;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public ThongKeCuocHen()
        {
            InitializeComponent();
            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";

        }

        private void ThongKeCuocHen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string proc = "p_ViewCuocHenTimeRange";
                _connection = new SqlConnection(_connectionString);
                SqlDataAdapter da = new SqlDataAdapter(proc, _connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@TIME1", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                da.SelectCommand.Parameters.Add("@TIME2", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                da.SelectCommand.Parameters.Add("@MANS", SqlDbType.VarChar, 10).Value = textBox1.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                _connection.Close();
            }
            catch(SqlException ex) { MessageBox.Show(ex.ToString()); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

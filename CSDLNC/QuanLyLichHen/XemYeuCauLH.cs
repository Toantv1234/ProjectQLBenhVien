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

namespace CSDLNC
{
    public partial class XemYeuCauLH : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        string name;
        string day;
        public XemYeuCauLH()
        {
            InitializeComponent();
            _connectionString = @"Data Source=sputnik-i;Initial Catalog=QuanLyPhongKhamNhaKhoa;Integrated Security=True;Encrypt=False";
        }
        public void ReturnTenNgay(ref string ten, ref string ngay)
        {
            ten = name;
            ngay = day;
        }
        private void XemYeuCauLH_Load(object sender, EventArgs e)
        {
            string proc = "p_ViewYeuCauCuocHen";
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex == -1)
           {
                return;
           }
           else
           {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                name = row.Cells[0].Value.ToString();
                day = row.Cells[1].Value.ToString();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                
                DataGridViewRow table = dataGridView1.Rows[row];
                string proc = "p_RemoveCuocHen";
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                _command = new SqlCommand(proc);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;
                _command.Parameters.Add("@NGAY", SqlDbType.Date).Value = DateTime.Parse( table.Cells[1].Value.ToString());
                _command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = table.Cells[0].Value.ToString();
                _command.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(row);
                _connection.Close();

            } 
            
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

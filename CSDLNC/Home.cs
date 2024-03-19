using DoAnHEQUANTRI;
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

namespace CSDLNC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog(this);
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChonHeThongNV HT = new ChonHeThongNV();
            this.Hide();
            HT.ShowDialog(this);    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChonHeThongQTV HT = new ChonHeThongQTV();
            this.Hide();
            HT.ShowDialog(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC.ThongKe
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeDieuTri thongKeDieuTri = new ThongKeDieuTri();
            thongKeDieuTri.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongKeCuocHen thongKeCuocHen = new ThongKeCuocHen();
            thongKeCuocHen.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

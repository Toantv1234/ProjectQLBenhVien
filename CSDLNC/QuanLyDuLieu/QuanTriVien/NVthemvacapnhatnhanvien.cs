using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanVien.Quantrivien
{
    public partial class NVthemvacapnhatnhanvien : Form
    {
        public NVthemvacapnhatnhanvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new NVthemnhanvien();
            myForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new NVcapnhatnhanvien();
            myForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            var myForm = new menuQuanTri();
            myForm.Show();
        }

        private void NVthemvacapnhatnhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}

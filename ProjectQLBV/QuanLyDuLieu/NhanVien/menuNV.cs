using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanVien
{
    public partial class menuNV : Form
    {
        public menuNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xem danh sach nha si
            var myForm = new NSxemdsnhasiNV();
            myForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xem danh sach nhan vien
            var myForm = new NVxemdanhsachnhanvienNV();
            myForm.Show();
            Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Xem lich lam viec cua nha si
            var myForm = new NSxemlichlamviecNSNV();
            myForm.Show();
            Hide();
        }
    }
}

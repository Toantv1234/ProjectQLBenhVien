using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaSi
{
    public partial class menuNhaSi : Form
    {
        public menuNhaSi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xem danh sach nha si
            var myForm = new NSxemdsnhasi();
            myForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Xem danh sach nhan vien
            var myForm = new NVxemdanhsachnhanvien();
            myForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Xem lich lam viec cua nha si
            var myForm = new NSxemlichlamviecNS();
            myForm.Show();
            Hide();
        }

        private void menuNhaSi_Load(object sender, EventArgs e)
        {

        }
    }
}

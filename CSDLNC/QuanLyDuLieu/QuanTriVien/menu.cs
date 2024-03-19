using NhanVien.Quantrivien;
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
    public partial class menuQuanTri : Form
    {
        public menuQuanTri()
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
            //Them va cap nhat nha si
            var myForm = new NSthemvacapnhatnhasi();
            myForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Xem danh sach nhan vien
            var myForm = new NVxemdanhsachnhanvien();
            myForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Them va cap nhat nhan vien
            var myForm = new NVthemvacapnhatnhanvien();
            myForm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Xem lich lam viec cua nha si
            var myForm = new NSxemlichlamviecNSNV();
            myForm.Show();
            Hide();
        }

        private void menuQuanTri_Load(object sender, EventArgs e)
        {

        }
    }
}

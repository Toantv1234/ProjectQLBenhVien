using CSDLNC.ThongKe;
using DoAnHEQUANTRI;
using NhanVien;
using QuanLyThuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC
{
    public partial class ChonHeThongQTV : Form
    {
     
        public ChonHeThongQTV()
        {
            InitializeComponent();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myParent = (Home)this.Owner;
            myParent.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLCH CH = new QLCH();
            CH.ShowDialog();
     
            
         
        }

        private void ChonHeThongNS_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thongke thongke = new Thongke();    
            thongke.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuQuanTri menuQuanTri = new menuQuanTri();
            menuQuanTri.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyThuocHT Thuoc = new QuanLyThuocHT();
            Thuoc.ShowDialog();
        }
    }
}

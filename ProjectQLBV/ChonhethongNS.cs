using DoAnHEQUANTRI;
using NhaSi;
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
    public partial class ChonHethongNS : Form
    {
        string Mans;
        public ChonHethongNS(string MANS)
        {
            InitializeComponent();
            Mans = MANS;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myParent = (Login)this.Owner;
            myParent.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            QLCuocHenNS QL = new QLCuocHenNS(Mans);
            QL.ShowDialog(this);
        }

        private void ChonHeThongNS_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuNhaSi menu = new menuNhaSi();
            menu.ShowDialog();
        }
    }
}

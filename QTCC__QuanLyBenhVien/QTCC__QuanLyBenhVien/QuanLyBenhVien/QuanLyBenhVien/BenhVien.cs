using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class BenhVien : Form
    {
        public BenhVien()
        {
            InitializeComponent();
        }

        private void abtnChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTiet ct = new ChiTiet();
            ct.ShowDialog();
            this.Close();

        }
    }
}

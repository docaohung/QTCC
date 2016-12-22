using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void abtnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail d = new Detail();
            d.ShowDialog();
            this.Close();
        }
    }
}

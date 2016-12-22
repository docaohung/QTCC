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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void abtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPassword.Text == "admin") {
                this.Hide();
                Hospital h = new Hospital();
                h.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show(this, "Incorrect username or password");
            }
        }
    }
}

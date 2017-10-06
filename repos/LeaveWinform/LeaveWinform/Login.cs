using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveWinform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textusername.Text == String.Empty)
            {
                MessageBox.Show("username cant be empty");
            }
            else if (textusername.Text == "balaji" && textPassword.Text == "balaji123")
            {
                MessageBox.Show("Login Successful");
                Form mf = new MainForm();
                mf.Show();
            }

           

        }

        private void textusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >='A' && e.KeyChar <='Z')
            {
                e.Handled = true;
            }
        }
    }
}

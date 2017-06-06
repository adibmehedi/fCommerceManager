using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FComManager
{
    public partial class AdminLoginForm : MetroFramework.Forms.MetroForm
    {
        UserClass userobj = new UserClass();
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();

            if (userobj.isValidUser(username, password))
            {
                Form homeform = new HomeForm(this);
                this.Visible = false;
                homeform.Visible = true;
            }
            else {
                MessageBox.Show("Incorrect Username Or Password");
            }
        }
    }
}

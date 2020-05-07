using System;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //DbAccess DbAccess = new DbAccess();
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            LoginMethod();
        }
        private void LoginMethod()
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            //if login true
            //if login ==admin open admin page
            this.Hide();
            Form1 f = new Form1();
            f.Show();
            //else message.box
        }


        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginMethod();
            }
        }
    }
}

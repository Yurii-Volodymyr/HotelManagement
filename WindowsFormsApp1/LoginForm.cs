﻿using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;
using WindowsFormsApp1.Model;

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
        public static string loginedRole;
        public static int roomId;
        private void LoginMethod()
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            if (login == "" && password == "")
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
                loginedRole = "Guest";
            }
            else
            {
                using (var db = new HotelWinFormsDbContext())
                {
                    var t = db.Users.ToList();
                    var userLogin = db.Users.Where(x => x.Login == login).Where(x => x.Password == password).FirstOrDefault();
                    if (userLogin == null)
                    {
                        MessageBox.Show("Provide correct username and password");
                    }
                    else
                    {

                        loginedRole = userLogin.UserRole.UserRoleName;
                        roomId = userLogin.RoomUserId.RoomId;
                        this.Hide();
                        Form1 f = new Form1();
                        f.Show();
                    }
                }
            }

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

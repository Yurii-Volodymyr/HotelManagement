using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Hotel.Domain;
using Hotel.Domain.Model;

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
        public static string LoginedRole { get; set; }
        public static int RoomId { get; set; } = 0;
        private async void LoginMethod()
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            if (login == "" && password == "")
            {
                this.Hide();                
                MainForm f = new MainForm("Guest");
                f.Show();
            }
            else
            {
                using (var db = new HotelWinFormsDbContext())
                {
                    var t = await db.Users.ToListAsync();
                    var userLogin = db.Users.Where(x => x.Login == login).Where(x => x.Password == password).FirstOrDefault();
                    if (userLogin == null)
                    {
                        MessageBox.Show("Provide correct username and password");
                    }
                    else
                    {
                        LoginedRole = userLogin.UserRole.UserRoleName;
                        if (LoginedRole.ToLower() == "employee"|| LoginedRole.ToLower()=="admin")
                        {

                        }
                        else
                        {
                            RoomId = userLogin.RoomUser.RoomId;
                        }
                        this.Hide();
                        MainForm f = new MainForm(LoginedRole);
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

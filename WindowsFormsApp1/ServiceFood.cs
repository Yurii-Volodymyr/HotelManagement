using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class ServiceFood : Form
    {
        public ServiceFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            if (LoginForm.roomId != 0)
            {
                if (cbBurger.Text != "" || cbCake.Text != "" || cbPizza.Text != "")
                {
                    using (var db = new HotelWinFormsDbContext())
                    {
                        ServFoodOrder servFood = new ServFoodOrder();
                        servFood.Burger = cbBurger.Text;
                        servFood.Cake = cbCake.Text;
                        servFood.Pizza = cbPizza.Text;
                        servFood.RoomId = LoginForm.roomId;

                        Form1 form = new Form1();
                        form.openChildForm(new ResultTrue());

                        db.ServiceFood.Add(servFood);
                        await db.SaveChangesAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Choose something", "Order cannot be null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You loginned as guest");
            }
        }
    }
}

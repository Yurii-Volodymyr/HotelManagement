using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Domain;
using Hotel.Domain.Model;

namespace WindowsFormsApp1
{
    public partial class ServiceRoom : Form
    {
        public ServiceRoom()
        {
            InitializeComponent();
        }

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            if (LoginForm.roomId != 1)
            {
                if (cbTowels.Text != "" || cbCleening.Checked != false)
                {
                    using (var db = new HotelWinFormsDbContext())
                    {
                        ServRoomOrder servRoom = new ServRoomOrder();
                        servRoom.Cleening = cbCleening.Checked;
                        servRoom.Towels = cbTowels.Text;
                        servRoom.RoomId = LoginForm.roomId;
                        this.Close();
                        Form1 form = new Form1();
                        form.openChildForm(new ResultTrue());

                        db.ServiceRoom.Add(servRoom);
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

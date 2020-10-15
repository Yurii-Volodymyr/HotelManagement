using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Hotel.Domain;
using Hotel.Domain.Model;

namespace WindowsFormsApp1
{
    public partial class A_OrderForm : Form
    {
        public A_OrderForm()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void A_OrderForm_Load(object sender, EventArgs e)
        {
            using (var db = new HotelWinFormsDbContext())
            {
                cbRoomNumber.DataSource = await (db.Rooms.Where(x => x.IsAvailable == "Available").ToListAsync());
            }
            dateDepartureDate.MinDate = DateTime.Today.AddDays(1);
            dateDepartureDate.MaxDate = DateTime.Today.AddMonths(13);
            dateEntryDate.MinDate = DateTime.Today;
            dateEntryDate.MaxDate = DateTime.Today.AddMonths(5);
            dateBDay.MinDate = DateTime.Today.AddYears(-150);
            dateBDay.MaxDate = DateTime.Today.AddYears(-16);
            
        }

        /// <summary>
        /// creating data to pass result to another form
        /// </summary>
        #region static fData

        public static string fName;
        public static string fEmail;
        public static string fPhone;
        public static string fPassport;
        public static string fGender;
        public static string fRoomNumber;
        public static string fTotalCosting;

        public static string fentryDate;
        public static string fdepartureDate;
        public static string fBirthDay;
        #endregion
        public void BindGridView()
        {
            using (var db = new HotelWinFormsDbContext())
            {
                try
                {
                    Order order = new Order();
                    var daysCount = dateDepartureDate.Value - dateEntryDate.Value;
                    order.ClientName = txtName.Text;
                    order.EntryDate = dateEntryDate.Value;
                    order.DepartureDate = dateDepartureDate.Value;
                    order.BirthDay = dateBDay.Value;
                    order.Email = txtEmail.Text;
                    order.Passport = txtPassport.Text;
                    if (radioMale.Checked)
                    {
                        order.Gender = radioMale.Text;
                    }
                    if (radioFemale.Checked)
                    {
                        order.Gender = radioFemale.Text;
                    }
                    order.Phone = Convert.ToInt32(txtPhone.Text);
                    order.RoomNumber = cbRoomNumber.Text;
                    db.Rooms.Where(x=>x.RoomNumber== cbRoomNumber.Text).FirstOrDefault().IsAvailable="Ordered";
                    double price = (from p in db.Rooms where p.RoomNumber.ToLower().Replace(" ", string.Empty) == cbRoomNumber.Text select p.PricePerWeek).FirstOrDefault();
                    price = price * daysCount.Days / 7;
                    order.TotalCosting = (price);
                    fTotalCosting = price.ToString();

                    db.Orders.Add(order);
                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Order created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fields cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            #region Passing data to view result
            fName = txtName.Text;
            fEmail = txtEmail.Text;
            fPassport = txtPassport.Text;
            fPhone = txtPhone.Text;
            fRoomNumber = cbRoomNumber.Text;

            fentryDate = dateEntryDate.Value.ToLongDateString().ToString();
            fdepartureDate = dateDepartureDate.Value.ToLongDateString().ToString();
            fBirthDay = dateBDay.Value.ToLongDateString().ToString();

            if (radioMale.Checked)
            {
                fGender = radioMale.Text;
            }
            if (radioFemale.Checked)
            {
                fGender = radioFemale.Text;
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGridView();
            FormTotallyOrderAndClient totally = new FormTotallyOrderAndClient();
            totally.Show();
            this.Hide();
        }
    }
}

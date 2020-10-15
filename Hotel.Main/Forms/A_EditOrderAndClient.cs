using Hotel.Domain.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Hotel.Domain;

namespace WindowsFormsApp1
{
    public partial class A_EditOrderAndClient : Form
    {
        public A_EditOrderAndClient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// return to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm(LoginForm.LoginedRole);
            this.Close();
            form1.Show();
        }
        //ID variable used in Updating and Deleting Record

        private void A_EditOrderAndClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.ordersDataSet.Orders);

        }
        int indexRow;
        /// <summary>
        /// updating order and client data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">selected row</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0 && indexRow <= dataGridView1.Rows.Count)
            {
                using (var db = new HotelWinFormsDbContext())
                {
                    var ordersList = db.Orders.ToList();
                    Order order = new Order();
                    //id is not changing
                    order.OrderId = ordersList[indexRow].OrderId;
                    order.ClientName = txtName.Text;
                    order.BirthDay = dataBDay.Value;
                    order.Phone = Convert.ToInt32(txtPhone.Text);
                    order.Email = txtEmail.Text;
                    if (radioMale.Checked == true)
                    {
                        order.Gender = "Male";
                    }
                    if (radioFemale.Checked == true)
                    {
                        order.Gender = "Female";

                    }
                    order.Passport = txtPassport.Text;
                    order.EntryDate = dateEntryDate.Value;
                    order.DepartureDate = dateDepartureDate.Value;
                    order.RoomNumber = txtRoomNumber.Text;
                    order.TotalCosting = Convert.ToDouble(txtTotalCost.Text);
                    db.Orders.AddOrUpdate(order);

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        //this.ordersTableAdapter.Fill(this.ordersDataSet.Orders);

                        MessageBox.Show("Order updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
            }

        }
        /// <summary>
        ///display data from selected grid row to textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Like row index</param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow <= dataGridView1.Rows.Count && indexRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                txtName.Text = row.Cells[clientNameDataGridViewTextBoxColumn.Index].Value.ToString();
                dataBDay.Value = Convert.ToDateTime(row.Cells[birthDayDataGridViewTextBoxColumn.Index].Value);
                txtEmail.Text = row.Cells[emailDataGridViewTextBoxColumn.Index].Value.ToString();
                txtPhone.Text = row.Cells[phoneDataGridViewTextBoxColumn.Index].Value.ToString();
                if (row.Cells[genderDataGridViewTextBoxColumn.Index].Value.ToString().ToLower() == "male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
                txtPassport.Text = row.Cells[passportDataGridViewTextBoxColumn.Index].Value.ToString();
                dateEntryDate.Value = Convert.ToDateTime(row.Cells[entryDateDataGridViewTextBoxColumn.Index].Value);
                dateDepartureDate.Value = Convert.ToDateTime(row.Cells[departureDateDataGridViewTextBoxColumn.Index].Value);
                txtRoomNumber.Text = row.Cells[roomNumberDataGridViewTextBoxColumn.Index].Value.ToString();
                txtTotalCost.Text = row.Cells[totalCostingDataGridViewTextBoxColumn.Index].Value.ToString();
            }
        }


    }
}

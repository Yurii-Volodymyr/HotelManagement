using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class A_EditOrderAndClient : Form
    {
        public A_EditOrderAndClient()
        {
            InitializeComponent();
        }
        //back
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
        //ID variable used in Updating and Deleting Record
        int ID = 0;

        private void A_EditOrderAndClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderClientDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.orderClientDataSet.Orders);
            // TODO: This line of code loads data into the 'hotelManagerDBDataSet1.Orders' table. You can move, or remove it, as needed.

        }
        int indexRow;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (indexRow < dataGridView1.Rows.Count && indexRow > 0)
            {


                DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                newDataRow.Cells[1].Value = txtName.Text;
                newDataRow.Cells[2].Value = dataBDay.Value;
                newDataRow.Cells[3].Value = txtPhone.Text;
                newDataRow.Cells[4].Value = txtEmail.Text;
                if (radioMale.Checked == true)
                {
                    newDataRow.Cells[5].Value = "Male";
                }
                else
                {
                    newDataRow.Cells[5].Value = "Female";
                }
                newDataRow.Cells[6].Value = txtPassport.Text;
                newDataRow.Cells[7].Value = dateEntryDate.Value;
                newDataRow.Cells[8].Value = dateDepartureDate.Value;
                newDataRow.Cells[9].Value = txtRoomNum.Text;
                newDataRow.Cells[10].Value = txtTotalCost.Text;

                using (var db = new HotelWinFormsDbContext())
                {
                    Order order = new Order();
                    order.OrderId = indexRow;
                    order.ClientName = txtName.Text;
                    order.BirthDay = dataBDay.Value;
                    order.Phone = Convert.ToInt32(txtPhone.Text);
                    order.Email = txtEmail.Text;
                    if (radioMale.Checked == true)
                    {
                        order.Gender = "Male";
                    }
                    else
                    {
                        order.Gender = "Female";
                    }
                    order.Passport = txtPassport.Text;
                    order.EntryDate = dateEntryDate.Value;
                    order.DepartureDate = dateDepartureDate.Value;
                    order.RoomNumber = txtRoomNum.Text;
                    order.TotalCosting = Convert.ToDouble(txtTotalCost.Text);
                    db.Orders.AddOrUpdate(order);

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
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
            if (indexRow < dataGridView1.Rows.Count && indexRow > 0)
            {

                DataGridViewRow row = dataGridView1.Rows[indexRow];

                txtName.Text = row.Cells[1].Value.ToString();
                dataBDay.Value = Convert.ToDateTime(row.Cells[2].Value);
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString().ToLower() == "male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
                txtPassport.Text = row.Cells[6].Value.ToString();
                dateEntryDate.Value = Convert.ToDateTime(row.Cells[7].Value);
                dateDepartureDate.Value = Convert.ToDateTime(row.Cells[8].Value);
                txtRoomNum.Text = row.Cells[9].Value.ToString();
                txtTotalCost.Text = row.Cells[10].Value.ToString();
            }


        }

        private void btnPerformOperation_Click(object sender, EventArgs e)
        {
            using (var db = new HotelWinFormsDbContext())
            {

                var orders = db.Orders;
                //int changes = 
            }
        }
        private bool sortAscending = false;

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var db = new HotelWinFormsDbContext();
            var orders = db.Orders;

            var selectedol = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            if (sortAscending)
                dataGridView1.DataSource = this.orderClientDataSet.Orders.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).ToList();
            else
                dataGridView1.DataSource = list.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            sortAscending = !sortAscending;
        }
    }
}

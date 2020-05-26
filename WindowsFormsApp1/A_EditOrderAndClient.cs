﻿using System;
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
        /// <summary>
        /// return to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
        //ID variable used in Updating and Deleting Record

        private void A_EditOrderAndClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderClientDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.orderClientDataSet.Orders);
            // TODO: This line of code loads data into the 'hotelManagerDBDataSet1.Orders' table. You can move, or remove it, as needed.

        }
        int indexRow;
        /// <summary>
        /// updating data
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
                    order.RoomNumber = txtRoomNum.Text;
                    order.TotalCosting = Convert.ToDouble(txtTotalCost.Text);
                    db.Orders.AddOrUpdate(order);

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        this.ordersTableAdapter.Fill(this.orderClientDataSet.Orders);

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
                dataBDay.Value = Convert.ToDateTime(row.Cells[dataGridViewTextBoxColumn2.Index].Value);
                txtEmail.Text = row.Cells[dataGridViewTextBoxColumn3.Index].Value.ToString();
                txtPhone.Text = row.Cells[dataGridViewTextBoxColumn4.Index].Value.ToString();
                if (row.Cells[dataGridViewTextBoxColumn5.Index].Value.ToString().ToLower() == "male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
                txtPassport.Text = row.Cells[dataGridViewTextBoxColumn6.Index].Value.ToString();
                dateEntryDate.Value = Convert.ToDateTime(row.Cells[dataGridViewTextBoxColumn7.Index].Value);
                dateDepartureDate.Value = Convert.ToDateTime(row.Cells[dataGridViewTextBoxColumn8.Index].Value);
                txtRoomNum.Text = row.Cells[roomNumberDataGridViewTextBoxColumn.Index].Value.ToString();
                txtTotalCost.Text = row.Cells[dataGridViewTextBoxColumn9.Index].Value.ToString();
            }
        }
    }
}

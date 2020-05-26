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
    public partial class A_EditRoomData : Form
    {
        int indexRow;

        public A_EditRoomData()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (var db = new HotelWinFormsDbContext())
            {
                Room room = new Room();
                room.Description = richTextBox1.Text;
                room.PricePerWeek = Convert.ToDouble(txtPricePerWeek.Text);
                room.RoomImage = (txtImgSource.Text);

                if (db.Rooms.Any(x => x.RoomNumber.Replace(" ", string.Empty).ToUpper() != txtRoomNumb.Text.Replace(" ", string.Empty).ToUpper()))
                {
                    room.RoomNumber = (txtRoomNumb.Text.Replace(" ", string.Empty).ToUpper());
                    db.Rooms.Add(room);
                    int result = db.SaveChanges();
                    // this.roomsTableAdapter.Fill(this.roomsDataSet.Rooms);
                    if (result > 0)
                    {
                        MessageBox.Show("Room created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Room with same number already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }

        private void A_EditRoomData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsHotelDbContextDataSet.Rooms' table. You can move, or remove it, as needed.


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new HotelWinFormsDbContext())
            {
                List<Room> roomId = db.Rooms.ToList();
                var isd = roomId[indexRow].RoomId;
                var vp = db.Rooms.Where(o => o.RoomId == isd).SingleOrDefault();
                db.Rooms.Remove(vp);

                int result = db.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Room deleted", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (indexRow >= 0 && indexRow <= dataGridView1.Rows.Count)
            {
                using (var db = new HotelWinFormsDbContext())
                {
                    List<Room> roomId = db.Rooms.ToList();
                    Room room = new Room();
                    room.RoomId = roomId[indexRow].RoomId;
                    room.Description = richTextBox1.Text;
                    room.PricePerWeek = Convert.ToDouble(txtPricePerWeek.Text);
                    room.RoomImage = txtImgSource.Text;
                    room.RoomNumber = txtRoomNumb.Text;

                    db.Rooms.AddOrUpdate(room);
                    int result = db.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("Room updated", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow <= dataGridView1.Rows.Count && indexRow >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[indexRow];

                txtRoomNumb.Text = row.Cells[dataGridViewTextBoxColumn2.Index].Value.ToString();
                richTextBox1.Text = (row.Cells[dataGridViewTextBoxColumn3.Index].Value).ToString();
                txtImgSource.Text = row.Cells[dataGridViewTextBoxColumn4.Index].Value.ToString();
                txtPricePerWeek.Text = row.Cells[dataGridViewTextBoxColumn5.Index].Value.ToString();

            }
        }
    }
}

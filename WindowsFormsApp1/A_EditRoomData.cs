using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
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
        //HotelWinFormsDbContext db;
        public A_EditRoomData()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(RoomTypes)))
            {
                cbRoomType.Items.Add(item);
            }
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
                try
                {
                    if (db.Rooms.All(x => x.RoomNumber != txtRoomNumb.Text.Replace(" ", string.Empty).ToUpper()))
                    {
                        Room room = new Room();

                        room.Description = richTextBox1.Text;
                        room.PricePerWeek = Convert.ToDouble(txtPricePerWeek.Text);
                        room.RoomImage = (txtImgSource.Text);
                        if (radioAvailable.Checked == true)
                        {
                            room.IsAvailable = "Available";
                        }
                        if (radioOrdered.Checked == true)
                        {
                            room.IsAvailable = "Ordered";
                        }

                        room.RoomType = cbRoomType.Text;
                        room.RoomNumber = (txtRoomNumb.Text.Replace(" ", string.Empty).ToUpper());
                        db.Rooms.Add(room);
                        int result = db.SaveChanges();
                        if (result > 0)
                        {
                            dataGridView1.Update();
                            dataGridView1.Refresh();

                            //this.roomsTableAdapter.Fill(this.roomsDataSet.Rooms);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Fields can`t be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void A_EditRoomData_Load(object sender, EventArgs e)
        {
            using (var db = new HotelWinFormsDbContext())
            {
                roomBindingSource.DataSource = db.Rooms.ToList();
            }
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
                    dataGridView1.Update();
                    dataGridView1.Refresh();                    //this.roomsTableAdapter.Fill(this.roomsDataSet.Rooms);
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
                    if (radioAvailable.Checked == true)
                    {
                        room.IsAvailable = "Available";
                    }
                    if (radioOrdered.Checked == true)
                    {
                        room.IsAvailable = "Ordered";
                    }
                    room.RoomType = cbRoomType.Text;
                    db.Rooms.AddOrUpdate(room);
                    int result = db.SaveChanges();

                    if (result > 0)
                    {
                        //dataGridView1.Update();
                        //dataGridView1.Refresh();
                        roomBindingSource.DataSource = db.Rooms.ToList();
                        MessageBox.Show("Room updated", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow <= dataGridView1.Rows.Count && indexRow >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[indexRow];


                txtRoomNumb.Text = row.Cells[roomNumberDataGridViewTextBoxColumn.Index].Value.ToString();
                richTextBox1.Text = (row.Cells[descriptionDataGridViewTextBoxColumn.Index].Value).ToString();
                txtImgSource.Text = row.Cells[roomImageDataGridViewTextBoxColumn.Index].Value.ToString();
                txtPricePerWeek.Text = row.Cells[pricePerWeekDataGridViewTextBoxColumn.Index].Value.ToString();
                if (row.Cells[isAvailableDataGridViewTextBoxColumn.Index].Value != null && row.Cells[isAvailableDataGridViewTextBoxColumn.Index].Value.ToString() == "Available")
                {
                    radioAvailable.Checked = true;
                }
                if (row.Cells[isAvailableDataGridViewTextBoxColumn.Index].Value != null && row.Cells[isAvailableDataGridViewTextBoxColumn.Index].Value.ToString() == "Ordered")
                {
                    radioOrdered.Checked = true;

                }
                cbRoomType.SelectedItem = row.Cells[roomTypeDataGridViewTextBoxColumn.Index].Value.ToString();


            }
        }

        private void txtImgSource_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Title = "Browse Img File",
                Multiselect = false,
            };
            using (dialog)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtImgSource.Text = dialog.FileName;
                }
            }
        }
    }
}

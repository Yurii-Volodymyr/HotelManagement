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
    public partial class A_EditRoomData : Form
    {
        public A_EditRoomData()
        {
            InitializeComponent();
        }
        private DataTable dtRooms = new DataTable();
        private DataTable dtRoomsToEdit = new DataTable();
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
              
       
        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void A_EditRoomData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.roomsDataSet.Rooms);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

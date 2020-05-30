using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;

namespace WindowsFormsApp1
{
    public partial class RoomList : Form
    {
        public RoomList()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomList_Load(object sender, EventArgs e)
        {
            using (var db = new HotelWinFormsDbContext())
            {
                roomBindingSource.DataSource = db.Rooms.ToList();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

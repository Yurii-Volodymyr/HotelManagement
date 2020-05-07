using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        //customize left menu bar
        #region SubMenuCustomizing
        private void customizeDesign()
        {
            panelEmployeeSubmenu.Visible = false;
            panelRoomsSubmenu.Visible = false;
            panelServiceSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelEmployeeSubmenu.Visible == true)
            {
                panelEmployeeSubmenu.Visible = false;
            }
            if (panelRoomsSubmenu.Visible == true)
            {
                panelRoomsSubmenu.Visible = false;
            }
            if (panelServiceSubmenu.Visible == true)
            {
                panelServiceSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = true;
            }
        }




        #endregion

        #region SubMenuButtons 

        private void btnFood_Click(object sender, EventArgs e)
        {
            openChildForm(new ServiceFood());
            hideSubMenu();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            //show form
            hideSubMenu();
        }

        private void btnRoomList_Click(object sender, EventArgs e)
        {
            openChildForm(new RoomList());
            hideSubMenu();
        }

        private void btnRoomCategories_Click(object sender, EventArgs e)
        {
            //show form
            hideSubMenu();
        }

        private void btnOrderRoom_Click(object sender, EventArgs e)
        {
            openChildForm(new A_OrderForm());
            hideSubMenu();
        }

        private void btnEditOrderAndClient_Click(object sender, EventArgs e)
        {
            A_EditOrderAndClient a_Edit = new A_EditOrderAndClient();
            a_Edit.Show();
            this.Hide();
            hideSubMenu();
        }

        private void btnEditDataRoom_Click(object sender, EventArgs e)
        {
            A_EditRoomData ferd = new A_EditRoomData();
            ferd.Show();
            this.Hide();
            hideSubMenu();
        }
        #endregion

        #region MenuButtons

        private void btnService_Click(object sender, EventArgs e)
        {
            showSubMenu(panelServiceSubmenu);
        }
        private void btnRooms_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoomsSubmenu);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

            showSubMenu(panelEmployeeSubmenu);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //show form
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childFrom)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            //to panelChildForm add new form
            panelChildForm.Controls.Add(childFrom);
            panelChildForm.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();

        }

        //current time
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        //current date
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //currentChildForm.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}

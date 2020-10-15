using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Domain.Model;

namespace WindowsFormsApp1
{
    public partial class FormTotallyOrderAndClient : Form
    {
        /// <summary>
        /// Inicjalizacja ostatniej formy dla sprawdzania poprawnisci wpisanych danych
        /// </summary>
        public FormTotallyOrderAndClient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przyjmuje "static" dane od "OrderForm" dla wyswetlania rezultatu a pozniej wyjsica z programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTotallyOrderAndClient_Load(object sender, EventArgs e)
        {
            Order order = new Order();

            lblName.Text = A_OrderForm.fName;
            lblEmail.Text = A_OrderForm.fEmail;
            lblPhone.Text = A_OrderForm.fPhone;
            lblPassport.Text = A_OrderForm.fPassport;
            lblGender.Text = A_OrderForm.fGender;
            lblRoomNumber.Text = A_OrderForm.fRoomNumber;
            lblTotalCosting.Text = A_OrderForm.fTotalCosting;

            lblEntryDate.Text = A_OrderForm.fentryDate;
            lblDepartureDate.Text = A_OrderForm.fdepartureDate;
            lblBday.Text = A_OrderForm.fBirthDay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

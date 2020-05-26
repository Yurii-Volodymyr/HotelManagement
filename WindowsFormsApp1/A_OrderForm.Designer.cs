using System;

namespace WindowsFormsApp1
{
    partial class A_OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        DateTime today = DateTime.Today;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateBDay = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.dateEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.roomsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 48;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 22);
            this.txtEmail.TabIndex = 36;
            // 
            // dateBDay
            // 
            this.dateBDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBDay.Location = new System.Drawing.Point(58, 156);
            this.dateBDay.MaxDate = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            this.dateBDay.MinDate = new System.DateTime(1900, 2, 3, 0, 0, 0, 0);
            this.dateBDay.Name = "dateBDay";
            this.dateBDay.Size = new System.Drawing.Size(156, 22);
            this.dateBDay.TabIndex = 35;
            this.dateBDay.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(58, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 22);
            this.txtName.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(55, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(55, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(55, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Gender";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(58, 260);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 22);
            this.txtPhone.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(55, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(297, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Departure Date";
            // 
            // dateDepartureDate
            // 
            this.dateDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDepartureDate.Location = new System.Drawing.Point(300, 156);
            this.dateDepartureDate.MaxDate = new System.DateTime(2021, 2, 2, 0, 0, 0, 0);
            this.dateDepartureDate.MinDate = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            this.dateDepartureDate.Name = "dateDepartureDate";
            this.dateDepartureDate.Size = new System.Drawing.Size(200, 22);
            this.dateDepartureDate.TabIndex = 42;
            this.dateDepartureDate.Value = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(297, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Entry Date";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(58, 381);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(156, 22);
            this.txtPassport.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(55, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Passoprt";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioFemale.Location = new System.Drawing.Point(139, 322);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(75, 21);
            this.radioFemale.TabIndex = 39;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioMale.Location = new System.Drawing.Point(60, 322);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(59, 21);
            this.radioMale.TabIndex = 38;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // dateEntryDate
            // 
            this.dateEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEntryDate.Location = new System.Drawing.Point(300, 102);
            this.dateEntryDate.MaxDate = new System.DateTime(2021, 2, 2, 0, 0, 0, 0);
            this.dateEntryDate.MinDate = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            this.dateEntryDate.Name = "dateEntryDate";
            this.dateEntryDate.Size = new System.Drawing.Size(200, 22);
            this.dateEntryDate.TabIndex = 41;
            this.dateEntryDate.Value = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(297, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Room Number";
            // 
            // roomsDataSet
            // 
             this.roomsDataSetBindingSource.Position = 0;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.roomsDataSetBindingSource;
            // 
            // roomsTableAdapter
            // 
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(300, 209);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(200, 22);
            this.txtRoomNumber.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "RoomId", true));
            this.comboBox1.DataSource = this.roomsBindingSource;
            this.comboBox1.DisplayMember = "RoomNumber";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.ValueMember = "RoomId";
            // 
            // A_OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(531, 420);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dateBDay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateDepartureDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateEntryDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.A_OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dateBDay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateDepartureDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.DateTimePicker dateEntryDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource roomsDataSetBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
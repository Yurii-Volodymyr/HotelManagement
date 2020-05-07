namespace WindowsFormsApp1
{
    partial class Form1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelEmployeeSubmenu = new System.Windows.Forms.Panel();
            this.btnEditDataRoom = new System.Windows.Forms.Button();
            this.btnEditOrderAndClient = new System.Windows.Forms.Button();
            this.btnOrderRoom = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelRoomsSubmenu = new System.Windows.Forms.Panel();
            this.btnRoomCategories = new System.Windows.Forms.Button();
            this.btnRoomList = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.panelServiceSubmenu = new System.Windows.Forms.Panel();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdditional = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelEmployeeSubmenu.SuspendLayout();
            this.panelRoomsSubmenu.SuspendLayout();
            this.panelServiceSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelAdditional.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnAbout);
            this.panelSideMenu.Controls.Add(this.panelEmployeeSubmenu);
            this.panelSideMenu.Controls.Add(this.btnEmployee);
            this.panelSideMenu.Controls.Add(this.panelRoomsSubmenu);
            this.panelSideMenu.Controls.Add(this.btnRooms);
            this.panelSideMenu.Controls.Add(this.panelServiceSubmenu);
            this.panelSideMenu.Controls.Add(this.btnService);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 4;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.Location = new System.Drawing.Point(0, 518);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(229, 45);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panelEmployeeSubmenu
            // 
            this.panelEmployeeSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelEmployeeSubmenu.Controls.Add(this.btnEditDataRoom);
            this.panelEmployeeSubmenu.Controls.Add(this.btnEditOrderAndClient);
            this.panelEmployeeSubmenu.Controls.Add(this.btnOrderRoom);
            this.panelEmployeeSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeeSubmenu.Location = new System.Drawing.Point(0, 392);
            this.panelEmployeeSubmenu.Name = "panelEmployeeSubmenu";
            this.panelEmployeeSubmenu.Size = new System.Drawing.Size(229, 126);
            this.panelEmployeeSubmenu.TabIndex = 6;
            // 
            // btnEditDataRoom
            // 
            this.btnEditDataRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditDataRoom.FlatAppearance.BorderSize = 0;
            this.btnEditDataRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDataRoom.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditDataRoom.Location = new System.Drawing.Point(0, 80);
            this.btnEditDataRoom.Name = "btnEditDataRoom";
            this.btnEditDataRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditDataRoom.Size = new System.Drawing.Size(229, 40);
            this.btnEditDataRoom.TabIndex = 2;
            this.btnEditDataRoom.Text = "Edit Room Data";
            this.btnEditDataRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDataRoom.UseVisualStyleBackColor = true;
            this.btnEditDataRoom.Click += new System.EventHandler(this.btnEditDataRoom_Click);
            // 
            // btnEditOrderAndClient
            // 
            this.btnEditOrderAndClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditOrderAndClient.FlatAppearance.BorderSize = 0;
            this.btnEditOrderAndClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrderAndClient.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditOrderAndClient.Location = new System.Drawing.Point(0, 40);
            this.btnEditOrderAndClient.Name = "btnEditOrderAndClient";
            this.btnEditOrderAndClient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEditOrderAndClient.Size = new System.Drawing.Size(229, 40);
            this.btnEditOrderAndClient.TabIndex = 1;
            this.btnEditOrderAndClient.Text = "Edit Order and Client";
            this.btnEditOrderAndClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditOrderAndClient.UseVisualStyleBackColor = true;
            this.btnEditOrderAndClient.Click += new System.EventHandler(this.btnEditOrderAndClient_Click);
            // 
            // btnOrderRoom
            // 
            this.btnOrderRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderRoom.FlatAppearance.BorderSize = 0;
            this.btnOrderRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderRoom.ForeColor = System.Drawing.Color.LightGray;
            this.btnOrderRoom.Location = new System.Drawing.Point(0, 0);
            this.btnOrderRoom.Name = "btnOrderRoom";
            this.btnOrderRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOrderRoom.Size = new System.Drawing.Size(229, 40);
            this.btnOrderRoom.TabIndex = 0;
            this.btnOrderRoom.Text = "Order Room";
            this.btnOrderRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderRoom.UseVisualStyleBackColor = true;
            this.btnOrderRoom.Click += new System.EventHandler(this.btnOrderRoom_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.Location = new System.Drawing.Point(0, 347);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(229, 45);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelRoomsSubmenu
            // 
            this.panelRoomsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelRoomsSubmenu.Controls.Add(this.btnRoomCategories);
            this.panelRoomsSubmenu.Controls.Add(this.btnRoomList);
            this.panelRoomsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomsSubmenu.Location = new System.Drawing.Point(0, 260);
            this.panelRoomsSubmenu.Name = "panelRoomsSubmenu";
            this.panelRoomsSubmenu.Size = new System.Drawing.Size(229, 87);
            this.panelRoomsSubmenu.TabIndex = 4;
            // 
            // btnRoomCategories
            // 
            this.btnRoomCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomCategories.FlatAppearance.BorderSize = 0;
            this.btnRoomCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomCategories.ForeColor = System.Drawing.Color.LightGray;
            this.btnRoomCategories.Location = new System.Drawing.Point(0, 40);
            this.btnRoomCategories.Name = "btnRoomCategories";
            this.btnRoomCategories.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRoomCategories.Size = new System.Drawing.Size(229, 40);
            this.btnRoomCategories.TabIndex = 1;
            this.btnRoomCategories.Text = "Room Categories";
            this.btnRoomCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomCategories.UseVisualStyleBackColor = true;
            this.btnRoomCategories.Click += new System.EventHandler(this.btnRoomCategories_Click);
            // 
            // btnRoomList
            // 
            this.btnRoomList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomList.FlatAppearance.BorderSize = 0;
            this.btnRoomList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomList.ForeColor = System.Drawing.Color.LightGray;
            this.btnRoomList.Location = new System.Drawing.Point(0, 0);
            this.btnRoomList.Name = "btnRoomList";
            this.btnRoomList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRoomList.Size = new System.Drawing.Size(229, 40);
            this.btnRoomList.TabIndex = 0;
            this.btnRoomList.Text = "Room List";
            this.btnRoomList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomList.UseVisualStyleBackColor = true;
            this.btnRoomList.Click += new System.EventHandler(this.btnRoomList_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRooms.Location = new System.Drawing.Point(0, 215);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRooms.Size = new System.Drawing.Size(229, 45);
            this.btnRooms.TabIndex = 3;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // panelServiceSubmenu
            // 
            this.panelServiceSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelServiceSubmenu.Controls.Add(this.btnRoom);
            this.panelServiceSubmenu.Controls.Add(this.btnFood);
            this.panelServiceSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServiceSubmenu.Location = new System.Drawing.Point(0, 128);
            this.panelServiceSubmenu.Name = "panelServiceSubmenu";
            this.panelServiceSubmenu.Size = new System.Drawing.Size(229, 87);
            this.panelServiceSubmenu.TabIndex = 2;
            // 
            // btnRoom
            // 
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.ForeColor = System.Drawing.Color.LightGray;
            this.btnRoom.Location = new System.Drawing.Point(0, 40);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRoom.Size = new System.Drawing.Size(229, 40);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "Room";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.Color.LightGray;
            this.btnFood.Location = new System.Drawing.Point(0, 0);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFood.Size = new System.Drawing.Size(229, 40);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "Food";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnService.Location = new System.Drawing.Point(0, 83);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnService.Size = new System.Drawing.Size(229, 45);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Service";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 83);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL ROYAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelAdditional
            // 
            this.panelAdditional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelAdditional.Controls.Add(this.lblTime);
            this.panelAdditional.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdditional.Location = new System.Drawing.Point(250, 518);
            this.panelAdditional.Name = "panelAdditional";
            this.panelAdditional.Size = new System.Drawing.Size(682, 35);
            this.panelAdditional.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(4, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(103, 29);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.button1);
            this.panelChildForm.Controls.Add(this.lblDate);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 518);
            this.panelChildForm.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(3, 481);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(259, 31);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Monday Month 2000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(192, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(635, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelAdditional);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelEmployeeSubmenu.ResumeLayout(false);
            this.panelRoomsSubmenu.ResumeLayout(false);
            this.panelServiceSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelAdditional.ResumeLayout(false);
            this.panelAdditional.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelServiceSubmenu;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelEmployeeSubmenu;
        private System.Windows.Forms.Button btnEditDataRoom;
        private System.Windows.Forms.Button btnEditOrderAndClient;
        private System.Windows.Forms.Button btnOrderRoom;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panelRoomsSubmenu;
        private System.Windows.Forms.Button btnRoomCategories;
        private System.Windows.Forms.Button btnRoomList;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelAdditional;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}


namespace WindowsFormsApp1
{
    partial class A_EditRoomData
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtRoomNumb = new System.Windows.Forms.TextBox();
            this.txtImgSource = new System.Windows.Forms.TextBox();
            this.txtPricePerWeek = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOrdered = new System.Windows.Forms.RadioButton();
            this.radioAvailable = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsDataSet = new WindowsFormsApp1.RoomsDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.roomsTableAdapter = new WindowsFormsApp1.HotelDbContextDataSetTableAdapters.RoomsTableAdapter();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(800, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(800, 124);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 32);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Add new";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(800, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(800, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(71, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(304, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Image Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(558, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price per Week";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(62, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(714, 160);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // txtRoomNumb
            // 
            this.txtRoomNumb.Location = new System.Drawing.Point(180, 59);
            this.txtRoomNumb.Name = "txtRoomNumb";
            this.txtRoomNumb.Size = new System.Drawing.Size(100, 22);
            this.txtRoomNumb.TabIndex = 1;
            // 
            // txtImgSource
            // 
            this.txtImgSource.Location = new System.Drawing.Point(419, 59);
            this.txtImgSource.Name = "txtImgSource";
            this.txtImgSource.Size = new System.Drawing.Size(121, 22);
            this.txtImgSource.TabIndex = 2;
            this.txtImgSource.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtImgSource_MouseDoubleClick);
            // 
            // txtPricePerWeek
            // 
            this.txtPricePerWeek.Location = new System.Drawing.Point(673, 59);
            this.txtPricePerWeek.Name = "txtPricePerWeek";
            this.txtPricePerWeek.Size = new System.Drawing.Size(100, 22);
            this.txtPricePerWeek.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PeachPuff;
            this.label9.Location = new System.Drawing.Point(351, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 36);
            this.label9.TabIndex = 66;
            this.label9.Text = "HOTEL ROYAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOrdered);
            this.groupBox1.Controls.Add(this.radioAvailable);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(561, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 37);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // radioOrdered
            // 
            this.radioOrdered.AutoSize = true;
            this.radioOrdered.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioOrdered.Location = new System.Drawing.Point(6, 12);
            this.radioOrdered.Name = "radioOrdered";
            this.radioOrdered.Size = new System.Drawing.Size(82, 21);
            this.radioOrdered.TabIndex = 4;
            this.radioOrdered.TabStop = true;
            this.radioOrdered.Text = "Ordered";
            this.radioOrdered.UseVisualStyleBackColor = true;
            // 
            // radioAvailable
            // 
            this.radioAvailable.AutoSize = true;
            this.radioAvailable.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioAvailable.Location = new System.Drawing.Point(119, 12);
            this.radioAvailable.Name = "radioAvailable";
            this.radioAvailable.Size = new System.Drawing.Size(86, 21);
            this.radioAvailable.TabIndex = 5;
            this.radioAvailable.TabStop = true;
            this.radioAvailable.Text = "Available";
            this.radioAvailable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.roomImageDataGridViewTextBoxColumn,
            this.pricePerWeekDataGridViewTextBoxColumn,
            this.isAvailableDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 233);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.roomsDataSet;
            // 
            // roomsDataSet
            // 
            this.roomsDataSet.DataSetName = "HotelDbContextDataSet";
            this.roomsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(304, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Room Type";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(419, 91);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 24);
            this.cbRoomType.TabIndex = 74;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomIdDataGridViewTextBoxColumn.Visible = false;
            this.roomIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomImageDataGridViewTextBoxColumn
            // 
            this.roomImageDataGridViewTextBoxColumn.DataPropertyName = "RoomImage";
            this.roomImageDataGridViewTextBoxColumn.HeaderText = "RoomImage";
            this.roomImageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomImageDataGridViewTextBoxColumn.Name = "roomImageDataGridViewTextBoxColumn";
            this.roomImageDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerWeekDataGridViewTextBoxColumn
            // 
            this.pricePerWeekDataGridViewTextBoxColumn.DataPropertyName = "PricePerWeek";
            this.pricePerWeekDataGridViewTextBoxColumn.HeaderText = "PricePerWeek";
            this.pricePerWeekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePerWeekDataGridViewTextBoxColumn.Name = "pricePerWeekDataGridViewTextBoxColumn";
            this.pricePerWeekDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAvailableDataGridViewTextBoxColumn
            // 
            this.isAvailableDataGridViewTextBoxColumn.DataPropertyName = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.HeaderText = "IsAvailable";
            this.isAvailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isAvailableDataGridViewTextBoxColumn.Name = "isAvailableDataGridViewTextBoxColumn";
            this.isAvailableDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // A_EditRoomData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPricePerWeek);
            this.Controls.Add(this.txtImgSource);
            this.Controls.Add(this.txtRoomNumb);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.Name = "A_EditRoomData";
            this.Text = "Edit Room Data";
            this.Load += new System.EventHandler(this.A_EditRoomData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtRoomNumb;
        private System.Windows.Forms.TextBox txtImgSource;
        private System.Windows.Forms.TextBox txtPricePerWeek;
   
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOrdered;
        private System.Windows.Forms.RadioButton radioAvailable;
        private System.Windows.Forms.DataGridView dataGridView1;


        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRoomType;
        private RoomsDataSet roomsDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelDbContextDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
    }
}
namespace Tracking_Soft_v2
{
    partial class TimesheetManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridSheet = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSearchSheetLoginId = new System.Windows.Forms.TextBox();
            this.searchDate = new System.Windows.Forms.DateTimePicker();
            this.sheetDate = new System.Windows.Forms.DateTimePicker();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbWorkHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoginId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchSheetId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtons = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSheet
            // 
            this.dataGridSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSheet.Location = new System.Drawing.Point(0, 11);
            this.dataGridSheet.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSheet.Name = "dataGridSheet";
            this.dataGridSheet.RowHeadersWidth = 51;
            this.dataGridSheet.RowTemplate.Height = 24;
            this.dataGridSheet.Size = new System.Drawing.Size(953, 245);
            this.dataGridSheet.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(816, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Enter LoginId";
            // 
            // tbSearchSheetLoginId
            // 
            this.tbSearchSheetLoginId.Location = new System.Drawing.Point(784, 453);
            this.tbSearchSheetLoginId.Name = "tbSearchSheetLoginId";
            this.tbSearchSheetLoginId.Size = new System.Drawing.Size(144, 20);
            this.tbSearchSheetLoginId.TabIndex = 69;
            this.tbSearchSheetLoginId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchLoginId_KeyPress_Number);
            // 
            // searchDate
            // 
            this.searchDate.Location = new System.Drawing.Point(784, 368);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(144, 20);
            this.searchDate.TabIndex = 68;
            // 
            // sheetDate
            // 
            this.sheetDate.Location = new System.Drawing.Point(404, 463);
            this.sheetDate.Name = "sheetDate";
            this.sheetDate.Size = new System.Drawing.Size(137, 20);
            this.sheetDate.TabIndex = 67;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Mechanic",
            "Driver"});
            this.cbRole.Location = new System.Drawing.Point(404, 419);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(137, 21);
            this.cbRole.TabIndex = 66;
            // 
            // tbWorkHour
            // 
            this.tbWorkHour.Location = new System.Drawing.Point(404, 498);
            this.tbWorkHour.Margin = new System.Windows.Forms.Padding(2);
            this.tbWorkHour.Name = "tbWorkHour";
            this.tbWorkHour.Size = new System.Drawing.Size(137, 20);
            this.tbWorkHour.TabIndex = 65;
            this.tbWorkHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWorkHours_KeyPress_Number);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Work Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Role";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(404, 378);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(137, 20);
            this.tbSurname.TabIndex = 61;
            this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress_Text_WhiteSpace);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Surname";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(404, 337);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(137, 20);
            this.tbName.TabIndex = 59;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_keyPress_Text_White);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Name";
            // 
            // tbLoginId
            // 
            this.tbLoginId.Location = new System.Drawing.Point(404, 303);
            this.tbLoginId.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginId.Name = "tbLoginId";
            this.tbLoginId.Size = new System.Drawing.Size(137, 20);
            this.tbLoginId.TabIndex = 57;
            this.tbLoginId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogunId_keyPress_Number);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Login ID";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(82, 472);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 32);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(827, 484);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 28);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(804, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Select TimeSheet";
            // 
            // tbSearchSheetId
            // 
            this.tbSearchSheetId.Location = new System.Drawing.Point(295, 549);
            this.tbSearchSheetId.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchSheetId.Name = "tbSearchSheetId";
            this.tbSearchSheetId.Size = new System.Drawing.Size(137, 20);
            this.tbSearchSheetId.TabIndex = 52;
            this.tbSearchSheetId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(82, 382);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 32);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(190, 523);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 46);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(82, 306);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 32);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(753, 250);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 335);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxButtons
            // 
            this.pictureBoxButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBoxButtons.Location = new System.Drawing.Point(0, 250);
            this.pictureBoxButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxButtons.Name = "pictureBoxButtons";
            this.pictureBoxButtons.Size = new System.Drawing.Size(186, 335);
            this.pictureBoxButtons.TabIndex = 47;
            this.pictureBoxButtons.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBox5.Image = global::Tracking_Soft_v2.Properties.Resources.logout;
            this.pictureBox5.Location = new System.Drawing.Point(33, 476);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 121;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBox4.Image = global::Tracking_Soft_v2.Properties.Resources.delete_button;
            this.pictureBox4.Location = new System.Drawing.Point(33, 386);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 120;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = global::Tracking_Soft_v2.Properties.Resources.add_square_button;
            this.pictureBox2.Location = new System.Drawing.Point(33, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 119;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(82, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 2);
            this.panel2.TabIndex = 122;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Location = new System.Drawing.Point(0, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 2);
            this.panel3.TabIndex = 110;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(82, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 2);
            this.panel1.TabIndex = 123;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 2);
            this.panel4.TabIndex = 110;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(82, 502);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 2);
            this.panel5.TabIndex = 123;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel6.Location = new System.Drawing.Point(0, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(187, 2);
            this.panel6.TabIndex = 110;
            // 
            // TimesheetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSearchSheetLoginId);
            this.Controls.Add(this.searchDate);
            this.Controls.Add(this.sheetDate);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbWorkHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLoginId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchSheetId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridSheet);
            this.Controls.Add(this.pictureBoxButtons);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimesheetManager";
            this.Size = new System.Drawing.Size(953, 576);
            this.Load += new System.EventHandler(this.TimesheetManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridSheet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSearchSheetLoginId;
        private System.Windows.Forms.DateTimePicker searchDate;
        private System.Windows.Forms.DateTimePicker sheetDate;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbWorkHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLoginId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchSheetId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBoxButtons;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        // private Tracking_Soft_v2.UCAdmin ucAdmin1;
    }
}

namespace Tracking_Soft_v2
{
    partial class Administrater
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_Lastname = new System.Windows.Forms.TextBox();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Firstname = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dGride = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGride)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 287);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(461, 289);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tb_Lastname
            // 
            this.tb_Lastname.Location = new System.Drawing.Point(653, 411);
            this.tb_Lastname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Lastname.Name = "tb_Lastname";
            this.tb_Lastname.Size = new System.Drawing.Size(208, 20);
            this.tb_Lastname.TabIndex = 103;
            this.tb_Lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress_Text);
            // 
            // cb_Role
            // 
            this.cb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Items.AddRange(new object[] {
            "Administrator",
            "Vehicle Info Manager",
            "Trip Manager",
            "Service Manager",
            "Timesheet Manager",
            "Driver",
            "Mechanic"});
            this.cb_Role.Location = new System.Drawing.Point(653, 434);
            this.cb_Role.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(208, 21);
            this.cb_Role.TabIndex = 102;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(653, 365);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(208, 20);
            this.tb_Password.TabIndex = 101;
            // 
            // tb_Firstname
            // 
            this.tb_Firstname.Location = new System.Drawing.Point(653, 388);
            this.tb_Firstname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Firstname.Name = "tb_Firstname";
            this.tb_Firstname.Size = new System.Drawing.Size(208, 20);
            this.tb_Firstname.TabIndex = 100;
            this.tb_Firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress_Text);
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(653, 342);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(208, 20);
            this.tb_Username.TabIndex = 99;
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Gray;
            this.bt_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Add.Location = new System.Drawing.Point(720, 457);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(82, 37);
            this.bt_Add.TabIndex = 98;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 442);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Lastname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Password:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(55, 369);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 37);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.Text = "Fill Fields";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Location = new System.Drawing.Point(393, 508);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(142, 37);
            this.btn_Exit.TabIndex = 105;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.BackColor = System.Drawing.Color.Gray;
            this.bt_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Update.Location = new System.Drawing.Point(55, 447);
            this.bt_Update.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(82, 37);
            this.bt_Update.TabIndex = 104;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = false;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(289, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Then";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(266, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 111;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.BackColor = System.Drawing.Color.Gray;
            this.Bt_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Delete.Location = new System.Drawing.Point(266, 447);
            this.Bt_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(82, 37);
            this.Bt_Delete.TabIndex = 108;
            this.Bt_Delete.Text = "Delete";
            this.Bt_Delete.UseVisualStyleBackColor = false;
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(152, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 110;
            this.label1.Text = "Find a user ID:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(140, 335);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(129, 20);
            this.tbSearch.TabIndex = 109;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserId_KeyPress_Number);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(75, 416);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Then";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(728, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 114;
            this.label9.Text = "Fields:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(72, 349);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 116;
            this.label11.Text = "Option 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(282, 349);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 117;
            this.label12.Text = "Option 2";
            // 
            // dGride
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGride.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGride.Location = new System.Drawing.Point(0, 0);
            this.dGride.Margin = new System.Windows.Forms.Padding(2);
            this.dGride.Name = "dGride";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGride.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGride.RowHeadersWidth = 51;
            this.dGride.RowTemplate.Height = 24;
            this.dGride.Size = new System.Drawing.Size(951, 294);
            this.dGride.TabIndex = 0;
            // 
            // Administrater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.tb_Lastname);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Firstname);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGride);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Administrater";
            this.Size = new System.Drawing.Size(953, 576);
            this.Load += new System.EventHandler(this.Administrater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGride)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_Lastname;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Firstname;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dGride;
    }
}

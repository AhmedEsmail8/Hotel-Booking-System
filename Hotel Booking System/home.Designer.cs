
namespace Hotel_Booking_System
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.check_in_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.check_out_button = new System.Windows.Forms.Label();
            this.check_out_date = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.max_price_txt = new System.Windows.Forms.TextBox();
            this.min_price_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.room_view_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.no_of_beds_label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Account_info = new System.Windows.Forms.Button();
            this.Search_sideBar = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 336);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1664, 697);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // check_in_date
            // 
            this.check_in_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_in_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_in_date.Location = new System.Drawing.Point(0, 46);
            this.check_in_date.Name = "check_in_date";
            this.check_in_date.Size = new System.Drawing.Size(494, 41);
            this.check_in_date.TabIndex = 3;
            this.check_in_date.ValueChanged += new System.EventHandler(this.check_in_date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Check-In";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.check_in_date);
            this.panel1.Location = new System.Drawing.Point(102, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 88);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.check_out_button);
            this.panel2.Controls.Add(this.check_out_date);
            this.panel2.Location = new System.Drawing.Point(639, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 88);
            this.panel2.TabIndex = 6;
            // 
            // check_out_button
            // 
            this.check_out_button.AutoSize = true;
            this.check_out_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_button.ForeColor = System.Drawing.Color.White;
            this.check_out_button.Location = new System.Drawing.Point(3, 4);
            this.check_out_button.Name = "check_out_button";
            this.check_out_button.Size = new System.Drawing.Size(156, 36);
            this.check_out_button.TabIndex = 4;
            this.check_out_button.Text = "Check-Out";
            // 
            // check_out_date
            // 
            this.check_out_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_date.CustomFormat = "";
            this.check_out_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out_date.Location = new System.Drawing.Point(0, 46);
            this.check_out_date.Name = "check_out_date";
            this.check_out_date.Size = new System.Drawing.Size(494, 41);
            this.check_out_date.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.max_price_txt);
            this.panel3.Controls.Add(this.min_price_txt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1206, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 88);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max";
            // 
            // max_price_txt
            // 
            this.max_price_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.max_price_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_price_txt.Location = new System.Drawing.Point(331, 50);
            this.max_price_txt.MaxLength = 7;
            this.max_price_txt.Name = "max_price_txt";
            this.max_price_txt.Size = new System.Drawing.Size(119, 32);
            this.max_price_txt.TabIndex = 9;
            // 
            // min_price_txt
            // 
            this.min_price_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min_price_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_price_txt.Location = new System.Drawing.Point(64, 51);
            this.min_price_txt.MaxLength = 7;
            this.min_price_txt.Name = "min_price_txt";
            this.min_price_txt.Size = new System.Drawing.Size(116, 32);
            this.min_price_txt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price Range per night";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Min";
            // 
            // room_view_label
            // 
            this.room_view_label.AutoSize = true;
            this.room_view_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_view_label.ForeColor = System.Drawing.Color.White;
            this.room_view_label.Location = new System.Drawing.Point(105, 156);
            this.room_view_label.Name = "room_view_label";
            this.room_view_label.Size = new System.Drawing.Size(168, 36);
            this.room_view_label.TabIndex = 8;
            this.room_view_label.Text = "Room View";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 34);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // no_of_beds_label
            // 
            this.no_of_beds_label.AutoSize = true;
            this.no_of_beds_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_beds_label.ForeColor = System.Drawing.Color.White;
            this.no_of_beds_label.Location = new System.Drawing.Point(642, 154);
            this.no_of_beds_label.Name = "no_of_beds_label";
            this.no_of_beds_label.Size = new System.Drawing.Size(226, 36);
            this.no_of_beds_label.TabIndex = 10;
            this.no_of_beds_label.Text = "Number of beds";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(877, 158);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 32);
            this.textBox3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(110, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pictureBox1.Size = new System.Drawing.Size(1664, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Almaza Hotel";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(299, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(360, 3);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // Account_info
            // 
            this.Account_info.BackColor = System.Drawing.Color.Transparent;
            this.Account_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Account_info.FlatAppearance.BorderSize = 0;
            this.Account_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Account_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Account_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_info.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_info.ForeColor = System.Drawing.Color.White;
            this.Account_info.Location = new System.Drawing.Point(16, 224);
            this.Account_info.Name = "Account_info";
            this.Account_info.Padding = new System.Windows.Forms.Padding(13, 5, 0, 0);
            this.Account_info.Size = new System.Drawing.Size(265, 53);
            this.Account_info.TabIndex = 3;
            this.Account_info.Text = "Account Info";
            this.Account_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account_info.UseVisualStyleBackColor = false;
            this.Account_info.Click += new System.EventHandler(this.Account_info_Click);
            // 
            // Search_sideBar
            // 
            this.Search_sideBar.BackColor = System.Drawing.Color.Transparent;
            this.Search_sideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_sideBar.FlatAppearance.BorderSize = 0;
            this.Search_sideBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Search_sideBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Search_sideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_sideBar.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_sideBar.ForeColor = System.Drawing.Color.DarkOrange;
            this.Search_sideBar.Location = new System.Drawing.Point(16, 359);
            this.Search_sideBar.Name = "Search_sideBar";
            this.Search_sideBar.Padding = new System.Windows.Forms.Padding(13, 5, 0, 0);
            this.Search_sideBar.Size = new System.Drawing.Size(265, 53);
            this.Search_sideBar.TabIndex = 4;
            this.Search_sideBar.Text = "Find Room";
            this.Search_sideBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_sideBar.UseVisualStyleBackColor = false;
            this.Search_sideBar.Click += new System.EventHandler(this.Search_sideBar_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(16, 655);
            this.Logout.Name = "Logout";
            this.Logout.Padding = new System.Windows.Forms.Padding(13, 5, 0, 0);
            this.Logout.Size = new System.Drawing.Size(265, 53);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(16, 503);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(13, 5, 0, 0);
            this.button2.Size = new System.Drawing.Size(299, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show Reservations";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Navy;
            this.sideBar.Controls.Add(this.button2);
            this.sideBar.Controls.Add(this.Logout);
            this.sideBar.Controls.Add(this.Search_sideBar);
            this.sideBar.Controls.Add(this.Account_info);
            this.sideBar.Controls.Add(this.flowLayoutPanel2);
            this.sideBar.Controls.Add(this.pictureBox3);
            this.sideBar.Controls.Add(this.label5);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(368, 1041);
            this.sideBar.TabIndex = 15;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1033);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.no_of_beds_label);
            this.Controls.Add(this.room_view_label);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.home_FormClosed);
            this.Load += new System.EventHandler(this.home_Load);
            this.Shown += new System.EventHandler(this.home_Shown);
            this.VisibleChanged += new System.EventHandler(this.home_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.DateTimePicker check_in_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label check_out_button;
        public System.Windows.Forms.DateTimePicker check_out_date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox min_price_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox max_price_txt;
        private System.Windows.Forms.Label room_view_label;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label no_of_beds_label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Account_info;
        private System.Windows.Forms.Button Search_sideBar;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel sideBar;
    }
}
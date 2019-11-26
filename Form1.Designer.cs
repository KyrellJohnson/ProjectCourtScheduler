namespace DesktopApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.NewReservation = new System.Windows.Forms.TabPage();
            this.dateTimePicker_reservetime = new System.Windows.Forms.DateTimePicker();
            this.label_reservetime = new System.Windows.Forms.Label();
            this.label_reservedate = new System.Windows.Forms.Label();
            this.dateTimePicker_reservedate = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_courtnumber = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_memberNo = new System.Windows.Forms.Label();
            this.button_addreservation = new System.Windows.Forms.Button();
            this.label_addreservation = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.Lookup = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.penaltyPointLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.NewReservation.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.Confirm.SuspendLayout();
            this.Cancel.SuspendLayout();
            this.Lookup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(134)))), ((int)(((byte)(136)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 491);
            this.panel1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::DesktopApp1.Properties.Resources.icons8_home_32;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-1, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 54);
            this.button6.TabIndex = 8;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Home_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::DesktopApp1.Properties.Resources.icons8_person_32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-1, 339);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 54);
            this.button5.TabIndex = 7;
            this.button5.Text = "Member \r\nLookup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Lookup_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::DesktopApp1.Properties.Resources.icons8_checkmark_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm \r\nReservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::DesktopApp1.Properties.Resources.icons8_cancel_32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-1, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 54);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cancel \r\nReservation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::DesktopApp1.Properties.Resources.icons8_calendar_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "View \r\nSchedule";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::DesktopApp1.Properties.Resources.icons8_calendar_plus_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-1, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "New \r\nReservation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Reservation_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.NewReservation);
            this.tabControl1.Controls.Add(this.Schedule);
            this.tabControl1.Controls.Add(this.Confirm);
            this.tabControl1.Controls.Add(this.Cancel);
            this.tabControl1.Controls.Add(this.Lookup);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(68, 18);
            this.tabControl1.Location = new System.Drawing.Point(153, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 491);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Silver;
            this.Home.Controls.Add(this.label_time);
            this.Home.Controls.Add(this.label_date);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(520, 465);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(23, 62);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(41, 16);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "label1";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(21, 21);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(72, 25);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "Home";
            // 
            // NewReservation
            // 
            this.NewReservation.BackColor = System.Drawing.Color.Silver;
            this.NewReservation.Controls.Add(this.dateTimePicker_reservetime);
            this.NewReservation.Controls.Add(this.label_reservetime);
            this.NewReservation.Controls.Add(this.label_reservedate);
            this.NewReservation.Controls.Add(this.dateTimePicker_reservedate);
            this.NewReservation.Controls.Add(this.textBox3);
            this.NewReservation.Controls.Add(this.label_courtnumber);
            this.NewReservation.Controls.Add(this.textBox2);
            this.NewReservation.Controls.Add(this.label_memberNo);
            this.NewReservation.Controls.Add(this.button_addreservation);
            this.NewReservation.Controls.Add(this.label_addreservation);
            this.NewReservation.Location = new System.Drawing.Point(4, 22);
            this.NewReservation.Name = "NewReservation";
            this.NewReservation.Padding = new System.Windows.Forms.Padding(3);
            this.NewReservation.Size = new System.Drawing.Size(520, 465);
            this.NewReservation.TabIndex = 1;
            this.NewReservation.Text = "NewReservation";
            // 
            // dateTimePicker_reservetime
            // 
            this.dateTimePicker_reservetime.CustomFormat = "hh:mm tt";
            this.dateTimePicker_reservetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_reservetime.Location = new System.Drawing.Point(148, 217);
            this.dateTimePicker_reservetime.Name = "dateTimePicker_reservetime";
            this.dateTimePicker_reservetime.ShowUpDown = true;
            this.dateTimePicker_reservetime.Size = new System.Drawing.Size(91, 21);
            this.dateTimePicker_reservetime.TabIndex = 9;
            // 
            // label_reservetime
            // 
            this.label_reservetime.AutoSize = true;
            this.label_reservetime.Location = new System.Drawing.Point(35, 222);
            this.label_reservetime.Name = "label_reservetime";
            this.label_reservetime.Size = new System.Drawing.Size(81, 16);
            this.label_reservetime.TabIndex = 8;
            this.label_reservetime.Text = "Reserve Time:";
            // 
            // label_reservedate
            // 
            this.label_reservedate.AutoSize = true;
            this.label_reservedate.Location = new System.Drawing.Point(35, 259);
            this.label_reservedate.Name = "label_reservedate";
            this.label_reservedate.Size = new System.Drawing.Size(84, 16);
            this.label_reservedate.TabIndex = 7;
            this.label_reservedate.Text = "Reserve Date:";
            // 
            // dateTimePicker_reservedate
            // 
            this.dateTimePicker_reservedate.Location = new System.Drawing.Point(148, 259);
            this.dateTimePicker_reservedate.Name = "dateTimePicker_reservedate";
            this.dateTimePicker_reservedate.Size = new System.Drawing.Size(210, 21);
            this.dateTimePicker_reservedate.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 21);
            this.textBox3.TabIndex = 5;
            // 
            // label_courtnumber
            // 
            this.label_courtnumber.AutoSize = true;
            this.label_courtnumber.Location = new System.Drawing.Point(35, 179);
            this.label_courtnumber.Name = "label_courtnumber";
            this.label_courtnumber.Size = new System.Drawing.Size(87, 16);
            this.label_courtnumber.TabIndex = 4;
            this.label_courtnumber.Text = "Court Number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label_memberNo
            // 
            this.label_memberNo.AutoSize = true;
            this.label_memberNo.Location = new System.Drawing.Point(35, 119);
            this.label_memberNo.Name = "label_memberNo";
            this.label_memberNo.Size = new System.Drawing.Size(106, 16);
            this.label_memberNo.TabIndex = 2;
            this.label_memberNo.Text = "Member Number: ";
            // 
            // button_addreservation
            // 
            this.button_addreservation.Location = new System.Drawing.Point(148, 385);
            this.button_addreservation.Name = "button_addreservation";
            this.button_addreservation.Size = new System.Drawing.Size(169, 23);
            this.button_addreservation.TabIndex = 1;
            this.button_addreservation.Text = "Add Reservation";
            this.button_addreservation.UseVisualStyleBackColor = true;
            this.button_addreservation.Click += new System.EventHandler(this.button_addreservation_Click);
            // 
            // label_addreservation
            // 
            this.label_addreservation.AutoSize = true;
            this.label_addreservation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addreservation.Location = new System.Drawing.Point(129, 35);
            this.label_addreservation.Name = "label_addreservation";
            this.label_addreservation.Size = new System.Drawing.Size(229, 25);
            this.label_addreservation.TabIndex = 0;
            this.label_addreservation.Text = "Reservation Manager";
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.Silver;
            this.Schedule.Controls.Add(this.label6);
            this.Schedule.Location = new System.Drawing.Point(4, 22);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(520, 465);
            this.Schedule.TabIndex = 2;
            this.Schedule.Text = "Schedule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current Schedule";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Silver;
            this.Confirm.Controls.Add(this.label7);
            this.Confirm.Location = new System.Drawing.Point(4, 22);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(520, 465);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "Confirm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Confrim Reservation";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Silver;
            this.Cancel.Controls.Add(this.flowLayoutPanel1);
            this.Cancel.Controls.Add(this.label8);
            this.Cancel.Location = new System.Drawing.Point(4, 22);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(520, 465);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(283, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cancel Reservation";
            // 
            // Lookup
            // 
            this.Lookup.Controls.Add(this.panel3);
            this.Lookup.Controls.Add(this.panel2);
            this.Lookup.Location = new System.Drawing.Point(4, 22);
            this.Lookup.Name = "Lookup";
            this.Lookup.Size = new System.Drawing.Size(520, 465);
            this.Lookup.TabIndex = 5;
            this.Lookup.Text = "Lookup";
            this.Lookup.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.penaltyPointLabel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 429);
            this.panel3.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(40, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 39);
            this.button7.TabIndex = 4;
            this.button7.Text = "Lookup";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // penaltyPointLabel
            // 
            this.penaltyPointLabel.AutoSize = true;
            this.penaltyPointLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyPointLabel.Location = new System.Drawing.Point(250, 94);
            this.penaltyPointLabel.Name = "penaltyPointLabel";
            this.penaltyPointLabel.Size = new System.Drawing.Size(21, 22);
            this.penaltyPointLabel.TabIndex = 3;
            this.penaltyPointLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current Penalty Points:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Member ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 75);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(137, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Member Lookup";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(678, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Court Scheduler";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.NewReservation.ResumeLayout(false);
            this.NewReservation.PerformLayout();
            this.Schedule.ResumeLayout(false);
            this.Schedule.PerformLayout();
            this.Confirm.ResumeLayout(false);
            this.Confirm.PerformLayout();
            this.Cancel.ResumeLayout(false);
            this.Cancel.PerformLayout();
            this.Lookup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage NewReservation;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_addreservation;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TabPage Confirm;
        private System.Windows.Forms.TabPage Cancel;
        private System.Windows.Forms.TabPage Lookup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label penaltyPointLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_reservedate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reservedate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_courtnumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_memberNo;
        private System.Windows.Forms.Button button_addreservation;
        private System.Windows.Forms.Label label_reservetime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reservetime;
    }
}


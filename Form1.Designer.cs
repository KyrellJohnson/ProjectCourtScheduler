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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_HOME = new System.Windows.Forms.Button();
            this.button_MemberLookup = new System.Windows.Forms.Button();
            this.button_confirmReservation = new System.Windows.Forms.Button();
            this.button_cancelReservation = new System.Windows.Forms.Button();
            this.button_ViewSchedule = new System.Windows.Forms.Button();
            this.button_NewReservation = new System.Windows.Forms.Button();
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
            this.textBox_CourtNum = new System.Windows.Forms.TextBox();
            this.label_courtnumber = new System.Windows.Forms.Label();
            this.textBox_MemID = new System.Windows.Forms.TextBox();
            this.label_memberNo = new System.Windows.Forms.Label();
            this.button_addreservation = new System.Windows.Forms.Button();
            this.label_addreservation = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_currentschedule = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.TabPage();
            this.btn_confirm_reservation = new System.Windows.Forms.Button();
            this.lbl_confirm_date_output = new System.Windows.Forms.Label();
            this.lbl_confirm_time_output = new System.Windows.Forms.Label();
            this.lbl_confirm_court_output = new System.Windows.Forms.Label();
            this.textBox_confirm_memid = new System.Windows.Forms.TextBox();
            this.lbl_confirm_date = new System.Windows.Forms.Label();
            this.lbl_confirm_time = new System.Windows.Forms.Label();
            this.lbl_confirm_courtNo = new System.Windows.Forms.Label();
            this.lbl_confirm_memID = new System.Windows.Forms.Label();
            this.label_confirmschedule = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_cancelreservation = new System.Windows.Forms.Label();
            this.Lookup = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_lookupMember = new System.Windows.Forms.Button();
            this.penaltyPointLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_memLookup = new System.Windows.Forms.TextBox();
            this.label_memID_memLookup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_memberLookup = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.NewReservation.SuspendLayout();
            this.Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Controls.Add(this.button_HOME);
            this.panel1.Controls.Add(this.button_MemberLookup);
            this.panel1.Controls.Add(this.button_confirmReservation);
            this.panel1.Controls.Add(this.button_cancelReservation);
            this.panel1.Controls.Add(this.button_ViewSchedule);
            this.panel1.Controls.Add(this.button_NewReservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 491);
            this.panel1.TabIndex = 5;
            // 
            // button_HOME
            // 
            this.button_HOME.FlatAppearance.BorderSize = 0;
            this.button_HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HOME.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HOME.ForeColor = System.Drawing.Color.Black;
            this.button_HOME.Image = global::DesktopApp1.Properties.Resources.icons8_home_32;
            this.button_HOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HOME.Location = new System.Drawing.Point(-1, 42);
            this.button_HOME.Name = "button_HOME";
            this.button_HOME.Size = new System.Drawing.Size(186, 54);
            this.button_HOME.TabIndex = 8;
            this.button_HOME.Text = "Home";
            this.button_HOME.UseVisualStyleBackColor = true;
            this.button_HOME.Click += new System.EventHandler(this.Home_Click);
            // 
            // button_MemberLookup
            // 
            this.button_MemberLookup.FlatAppearance.BorderSize = 0;
            this.button_MemberLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MemberLookup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MemberLookup.ForeColor = System.Drawing.Color.Black;
            this.button_MemberLookup.Image = global::DesktopApp1.Properties.Resources.icons8_person_32;
            this.button_MemberLookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_MemberLookup.Location = new System.Drawing.Point(-1, 339);
            this.button_MemberLookup.Margin = new System.Windows.Forms.Padding(2);
            this.button_MemberLookup.Name = "button_MemberLookup";
            this.button_MemberLookup.Size = new System.Drawing.Size(186, 54);
            this.button_MemberLookup.TabIndex = 7;
            this.button_MemberLookup.Text = "Member \r\nLookup";
            this.button_MemberLookup.UseVisualStyleBackColor = true;
            this.button_MemberLookup.Click += new System.EventHandler(this.Lookup_Click);
            // 
            // button_confirmReservation
            // 
            this.button_confirmReservation.FlatAppearance.BorderSize = 0;
            this.button_confirmReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirmReservation.ForeColor = System.Drawing.Color.Black;
            this.button_confirmReservation.Image = global::DesktopApp1.Properties.Resources.icons8_checkmark_32;
            this.button_confirmReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_confirmReservation.Location = new System.Drawing.Point(-1, 221);
            this.button_confirmReservation.Margin = new System.Windows.Forms.Padding(2);
            this.button_confirmReservation.Name = "button_confirmReservation";
            this.button_confirmReservation.Size = new System.Drawing.Size(186, 54);
            this.button_confirmReservation.TabIndex = 2;
            this.button_confirmReservation.Text = "Confirm \r\nReservation";
            this.button_confirmReservation.UseVisualStyleBackColor = true;
            this.button_confirmReservation.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // button_cancelReservation
            // 
            this.button_cancelReservation.FlatAppearance.BorderSize = 0;
            this.button_cancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelReservation.ForeColor = System.Drawing.Color.Black;
            this.button_cancelReservation.Image = global::DesktopApp1.Properties.Resources.icons8_cancel_32;
            this.button_cancelReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelReservation.Location = new System.Drawing.Point(-1, 280);
            this.button_cancelReservation.Name = "button_cancelReservation";
            this.button_cancelReservation.Size = new System.Drawing.Size(186, 54);
            this.button_cancelReservation.TabIndex = 6;
            this.button_cancelReservation.Text = "Cancel \r\nReservation";
            this.button_cancelReservation.UseVisualStyleBackColor = true;
            this.button_cancelReservation.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button_ViewSchedule
            // 
            this.button_ViewSchedule.FlatAppearance.BorderSize = 0;
            this.button_ViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ViewSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewSchedule.ForeColor = System.Drawing.Color.Black;
            this.button_ViewSchedule.Image = global::DesktopApp1.Properties.Resources.icons8_calendar_32;
            this.button_ViewSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ViewSchedule.Location = new System.Drawing.Point(0, 162);
            this.button_ViewSchedule.Name = "button_ViewSchedule";
            this.button_ViewSchedule.Size = new System.Drawing.Size(185, 54);
            this.button_ViewSchedule.TabIndex = 5;
            this.button_ViewSchedule.Text = "View \r\nSchedule";
            this.button_ViewSchedule.UseVisualStyleBackColor = true;
            this.button_ViewSchedule.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // button_NewReservation
            // 
            this.button_NewReservation.FlatAppearance.BorderSize = 0;
            this.button_NewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewReservation.ForeColor = System.Drawing.Color.Black;
            this.button_NewReservation.Image = global::DesktopApp1.Properties.Resources.icons8_calendar_plus_32;
            this.button_NewReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_NewReservation.Location = new System.Drawing.Point(-1, 102);
            this.button_NewReservation.Name = "button_NewReservation";
            this.button_NewReservation.Size = new System.Drawing.Size(186, 54);
            this.button_NewReservation.TabIndex = 4;
            this.button_NewReservation.Text = "New \r\nReservation";
            this.button_NewReservation.UseVisualStyleBackColor = true;
            this.button_NewReservation.Click += new System.EventHandler(this.Reservation_Click);
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
            this.NewReservation.Controls.Add(this.textBox_CourtNum);
            this.NewReservation.Controls.Add(this.label_courtnumber);
            this.NewReservation.Controls.Add(this.textBox_MemID);
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
            this.dateTimePicker_reservetime.CustomFormat = "HH:mm";
            this.dateTimePicker_reservetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_reservetime.Location = new System.Drawing.Point(148, 217);
            this.dateTimePicker_reservetime.Name = "dateTimePicker_reservetime";
            this.dateTimePicker_reservetime.ShowUpDown = true;
            this.dateTimePicker_reservetime.Size = new System.Drawing.Size(53, 21);
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
            // textBox_CourtNum
            // 
            this.textBox_CourtNum.Location = new System.Drawing.Point(148, 174);
            this.textBox_CourtNum.Name = "textBox_CourtNum";
            this.textBox_CourtNum.Size = new System.Drawing.Size(175, 21);
            this.textBox_CourtNum.TabIndex = 5;
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
            // textBox_MemID
            // 
            this.textBox_MemID.Location = new System.Drawing.Point(148, 119);
            this.textBox_MemID.Name = "textBox_MemID";
            this.textBox_MemID.Size = new System.Drawing.Size(175, 21);
            this.textBox_MemID.TabIndex = 3;
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
            this.Schedule.Controls.Add(this.dataGridView1);
            this.Schedule.Controls.Add(this.label_currentschedule);
            this.Schedule.Location = new System.Drawing.Point(4, 22);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(520, 465);
            this.Schedule.TabIndex = 2;
            this.Schedule.Text = "Schedule";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(23, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(466, 382);
            this.dataGridView1.TabIndex = 1;
            // 
            // label_currentschedule
            // 
            this.label_currentschedule.AutoSize = true;
            this.label_currentschedule.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentschedule.Location = new System.Drawing.Point(151, 21);
            this.label_currentschedule.Name = "label_currentschedule";
            this.label_currentschedule.Size = new System.Drawing.Size(188, 25);
            this.label_currentschedule.TabIndex = 0;
            this.label_currentschedule.Text = "Current Schedule";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Silver;
            this.Confirm.Controls.Add(this.btn_confirm_reservation);
            this.Confirm.Controls.Add(this.lbl_confirm_date_output);
            this.Confirm.Controls.Add(this.lbl_confirm_time_output);
            this.Confirm.Controls.Add(this.lbl_confirm_court_output);
            this.Confirm.Controls.Add(this.textBox_confirm_memid);
            this.Confirm.Controls.Add(this.lbl_confirm_date);
            this.Confirm.Controls.Add(this.lbl_confirm_time);
            this.Confirm.Controls.Add(this.lbl_confirm_courtNo);
            this.Confirm.Controls.Add(this.lbl_confirm_memID);
            this.Confirm.Controls.Add(this.label_confirmschedule);
            this.Confirm.Location = new System.Drawing.Point(4, 22);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(520, 465);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "Confirm";
            // 
            // btn_confirm_reservation
            // 
            this.btn_confirm_reservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_reservation.Location = new System.Drawing.Point(168, 337);
            this.btn_confirm_reservation.Name = "btn_confirm_reservation";
            this.btn_confirm_reservation.Size = new System.Drawing.Size(158, 35);
            this.btn_confirm_reservation.TabIndex = 9;
            this.btn_confirm_reservation.Text = "Confirm";
            this.btn_confirm_reservation.UseVisualStyleBackColor = true;
            this.btn_confirm_reservation.Click += new System.EventHandler(this.btn_confirm_reservation_Click);
            // 
            // lbl_confirm_date_output
            // 
            this.lbl_confirm_date_output.AutoSize = true;
            this.lbl_confirm_date_output.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_date_output.Location = new System.Drawing.Point(220, 245);
            this.lbl_confirm_date_output.Name = "lbl_confirm_date_output";
            this.lbl_confirm_date_output.Size = new System.Drawing.Size(25, 21);
            this.lbl_confirm_date_output.TabIndex = 8;
            this.lbl_confirm_date_output.Text = "---";
            // 
            // lbl_confirm_time_output
            // 
            this.lbl_confirm_time_output.AutoSize = true;
            this.lbl_confirm_time_output.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_time_output.Location = new System.Drawing.Point(220, 200);
            this.lbl_confirm_time_output.Name = "lbl_confirm_time_output";
            this.lbl_confirm_time_output.Size = new System.Drawing.Size(25, 21);
            this.lbl_confirm_time_output.TabIndex = 7;
            this.lbl_confirm_time_output.Text = "---";
            // 
            // lbl_confirm_court_output
            // 
            this.lbl_confirm_court_output.AutoSize = true;
            this.lbl_confirm_court_output.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_court_output.Location = new System.Drawing.Point(220, 158);
            this.lbl_confirm_court_output.Name = "lbl_confirm_court_output";
            this.lbl_confirm_court_output.Size = new System.Drawing.Size(25, 21);
            this.lbl_confirm_court_output.TabIndex = 6;
            this.lbl_confirm_court_output.Text = "---";
            // 
            // textBox_confirm_memid
            // 
            this.textBox_confirm_memid.Location = new System.Drawing.Point(168, 105);
            this.textBox_confirm_memid.Name = "textBox_confirm_memid";
            this.textBox_confirm_memid.Size = new System.Drawing.Size(168, 21);
            this.textBox_confirm_memid.TabIndex = 5;
            // 
            // lbl_confirm_date
            // 
            this.lbl_confirm_date.AutoSize = true;
            this.lbl_confirm_date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_date.Location = new System.Drawing.Point(156, 245);
            this.lbl_confirm_date.Name = "lbl_confirm_date";
            this.lbl_confirm_date.Size = new System.Drawing.Size(58, 21);
            this.lbl_confirm_date.TabIndex = 4;
            this.lbl_confirm_date.Text = "Date: ";
            // 
            // lbl_confirm_time
            // 
            this.lbl_confirm_time.AutoSize = true;
            this.lbl_confirm_time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_time.Location = new System.Drawing.Point(154, 200);
            this.lbl_confirm_time.Name = "lbl_confirm_time";
            this.lbl_confirm_time.Size = new System.Drawing.Size(54, 21);
            this.lbl_confirm_time.TabIndex = 3;
            this.lbl_confirm_time.Text = "Time: ";
            // 
            // lbl_confirm_courtNo
            // 
            this.lbl_confirm_courtNo.AutoSize = true;
            this.lbl_confirm_courtNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_courtNo.Location = new System.Drawing.Point(84, 158);
            this.lbl_confirm_courtNo.Name = "lbl_confirm_courtNo";
            this.lbl_confirm_courtNo.Size = new System.Drawing.Size(130, 21);
            this.lbl_confirm_courtNo.TabIndex = 2;
            this.lbl_confirm_courtNo.Text = "Court Number: ";
            // 
            // lbl_confirm_memID
            // 
            this.lbl_confirm_memID.AutoSize = true;
            this.lbl_confirm_memID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_memID.Location = new System.Drawing.Point(57, 103);
            this.lbl_confirm_memID.Name = "lbl_confirm_memID";
            this.lbl_confirm_memID.Size = new System.Drawing.Size(105, 21);
            this.lbl_confirm_memID.TabIndex = 1;
            this.lbl_confirm_memID.Text = "Member ID: ";
            // 
            // label_confirmschedule
            // 
            this.label_confirmschedule.AutoSize = true;
            this.label_confirmschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirmschedule.Location = new System.Drawing.Point(141, 21);
            this.label_confirmschedule.Name = "label_confirmschedule";
            this.label_confirmschedule.Size = new System.Drawing.Size(226, 25);
            this.label_confirmschedule.TabIndex = 0;
            this.label_confirmschedule.Text = "Confirm Reservation";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Silver;
            this.Cancel.Controls.Add(this.flowLayoutPanel1);
            this.Cancel.Controls.Add(this.label_cancelreservation);
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
            // label_cancelreservation
            // 
            this.label_cancelreservation.AutoSize = true;
            this.label_cancelreservation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancelreservation.Location = new System.Drawing.Point(163, 179);
            this.label_cancelreservation.Name = "label_cancelreservation";
            this.label_cancelreservation.Size = new System.Drawing.Size(209, 25);
            this.label_cancelreservation.TabIndex = 0;
            this.label_cancelreservation.Text = "Cancel Reservation";
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
            this.panel3.Controls.Add(this.button_lookupMember);
            this.panel3.Controls.Add(this.penaltyPointLabel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox_memLookup);
            this.panel3.Controls.Add(this.label_memID_memLookup);
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 429);
            this.panel3.TabIndex = 1;
            // 
            // button_lookupMember
            // 
            this.button_lookupMember.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lookupMember.Location = new System.Drawing.Point(40, 153);
            this.button_lookupMember.Name = "button_lookupMember";
            this.button_lookupMember.Size = new System.Drawing.Size(147, 39);
            this.button_lookupMember.TabIndex = 4;
            this.button_lookupMember.Text = "Lookup";
            this.button_lookupMember.UseVisualStyleBackColor = true;
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
            // textBox_memLookup
            // 
            this.textBox_memLookup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_memLookup.Location = new System.Drawing.Point(158, 46);
            this.textBox_memLookup.Name = "textBox_memLookup";
            this.textBox_memLookup.Size = new System.Drawing.Size(127, 31);
            this.textBox_memLookup.TabIndex = 1;
            // 
            // label_memID_memLookup
            // 
            this.label_memID_memLookup.AutoSize = true;
            this.label_memID_memLookup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memID_memLookup.Location = new System.Drawing.Point(36, 49);
            this.label_memID_memLookup.Name = "label_memID_memLookup";
            this.label_memID_memLookup.Size = new System.Drawing.Size(116, 22);
            this.label_memID_memLookup.TabIndex = 0;
            this.label_memID_memLookup.Text = "Member ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label_memberLookup);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 75);
            this.panel2.TabIndex = 0;
            // 
            // label_memberLookup
            // 
            this.label_memberLookup.AutoSize = true;
            this.label_memberLookup.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberLookup.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_memberLookup.Location = new System.Drawing.Point(137, 11);
            this.label_memberLookup.Name = "label_memberLookup";
            this.label_memberLookup.Size = new System.Drawing.Size(231, 33);
            this.label_memberLookup.TabIndex = 0;
            this.label_memberLookup.Text = "Member Lookup";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button_confirmReservation;
        private System.Windows.Forms.Button button_NewReservation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ViewSchedule;
        private System.Windows.Forms.Button button_cancelReservation;
        private System.Windows.Forms.Button button_MemberLookup;
        private System.Windows.Forms.Button button_HOME;
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
        private System.Windows.Forms.Label label_memberLookup;
        private System.Windows.Forms.TextBox textBox_memLookup;
        private System.Windows.Forms.Label label_memID_memLookup;
        private System.Windows.Forms.Button button_lookupMember;
        private System.Windows.Forms.Label penaltyPointLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_currentschedule;
        private System.Windows.Forms.Label label_confirmschedule;
        private System.Windows.Forms.Label label_cancelreservation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_reservedate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reservedate;
        private System.Windows.Forms.TextBox textBox_CourtNum;
        private System.Windows.Forms.Label label_courtnumber;
        private System.Windows.Forms.TextBox textBox_MemID;
        private System.Windows.Forms.Label label_memberNo;
        private System.Windows.Forms.Button button_addreservation;
        private System.Windows.Forms.Label label_reservetime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reservetime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_confirm_memID;
        private System.Windows.Forms.Label lbl_confirm_date;
        private System.Windows.Forms.Label lbl_confirm_time;
        private System.Windows.Forms.Label lbl_confirm_courtNo;
        private System.Windows.Forms.Label lbl_confirm_date_output;
        private System.Windows.Forms.Label lbl_confirm_time_output;
        private System.Windows.Forms.Label lbl_confirm_court_output;
        private System.Windows.Forms.TextBox textBox_confirm_memid;
        private System.Windows.Forms.Button btn_confirm_reservation;
    }
}


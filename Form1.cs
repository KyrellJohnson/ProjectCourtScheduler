using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        /**************
         * 
         * Tab Control
         * 
         *************/

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("Confirm");
        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("Schedule");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("Cancel");
        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("NewReservation");
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("Home");
        }

        private void Lookup_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("Lookup");

        }

        /*******
         * 
         *New Reservation
         *
         ******/

        private void button_addreservation_Click(object sender, EventArgs e)
        {
            /***
             *   variables to keep track of data entered for user
             ***/
            int memberNo = 0;
            String courtNo;

            String date_dayofmonth;
            String date_dayoftheweek;
            String date_month;
            String date_year; 

            String time_reservation;


            //Get Date Information (1, 1, Wednesday, 2018) = Jan 1 2018
            date_dayofmonth     = dateTimePicker_reservedate.Value.Day.ToString();
            date_dayoftheweek   = dateTimePicker_reservedate.Value.DayOfWeek.ToString();
            date_month          = dateTimePicker_reservedate.Value.Month.ToString();
            date_year           = dateTimePicker_reservedate.Value.Year.ToString();

            //Get Time Information
            time_reservation = dateTimePicker_reservetime.Value.TimeOfDay.ToString();


           

        }
    }
}

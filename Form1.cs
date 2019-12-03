using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
            String memberNo;
            String courtNo;

            String date_dayofmonth;
            String date_dayoftheweek;
            String date_month;
            String date_year; 

            String time_reservation;


            //Get Date Information (1, 1, Wednesday, 2018) = Jan 1 2018
            date_dayofmonth     = dateTimePicker_reservedate.Value.Day.ToString();
           // date_dayoftheweek   = dateTimePicker_reservedate.Value.DayOfWeek.ToString();
            date_month          = dateTimePicker_reservedate.Value.Month.ToString();
            date_year           = dateTimePicker_reservedate.Value.Year.ToString();

            //Get Time Information
            time_reservation = dateTimePicker_reservetime.Value.TimeOfDay.ToString();

            //get MemberID
            memberNo            = (textBox_MemID.Text);

            //get courtNo
            courtNo             = (textBox_CourtNum.Text);

            //Debugging, get input within fields
            Debug.WriteLine("Member ID: " + memberNo);
            Debug.WriteLine("Court Np: " + courtNo);
            Debug.WriteLine("Court Number: " + courtNo);
            Debug.WriteLine("Day of Month: " + date_dayofmonth);
            Debug.WriteLine("Date Month: " + date_month);
            Debug.WriteLine("Date Year: " + date_year);
            Debug.WriteLine("Time: " + time_reservation);
//--------------------------------------------------------------------------------------//
            Reservations reservation = new Reservations();
            /*
                        if (!File.Exists("Test.xml"))
                        {
                            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                            xmlWriterSettings.Indent = true;
                            xmlWriterSettings.NewLineOnAttributes = true;
                            using (XmlWriter xmlWriter = XmlWriter.Create("Test.xml", xmlWriterSettings))
                            {
                                xmlWriter.WriteStartDocument();
                                xmlWriter.WriteStartElement("CurrentReservations");

                                xmlWriter.WriteStartElement("Reservation");
                                xmlWriter.WriteElementString("memID", memberNo);
                                xmlWriter.WriteElementString("Court", courtNo);
                                xmlWriter.WriteEndElement();

                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndDocument();
                                xmlWriter.Flush();
                                xmlWriter.Close();
                            }
                        }
                        else
                        {
                            XDocument xDocument = XDocument.Load("Test.xml");
                            XElement root = xDocument.Element("CurrentReservations");
                            IEnumerable<XElement> rows = root.Descendants("Reservation");
                            XElement firstRow = rows.First();
                            firstRow.AddBeforeSelf(
                               new XElement("Reservation",
                               new XElement("memID", memberNo),
                               new XElement("Court", courtNo)));
                            xDocument.Save("Test.xml");
                        }
            */

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Test.xml");
                dataGridView1.DataSource = ds.Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}

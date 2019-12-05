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
            if (File.Exists("data.xml"))
            {
                if (new FileInfo("data.xml").Length != 0)
                {
                    showTable();
                    dataGridView1.Columns[0].Width = 55;
                    dataGridView1.Columns[4].Width = 75;
                }
                else
                {
                    File.Delete("data.xml");
                }
            }
            
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
            String date_month;
            String date_year; 

            String time_reservation_short;
            String didConfirm = "--";


            //Get Date Information (1, 1, Wednesday, 2018) = Jan 1 2018
            date_dayofmonth     = dateTimePicker_reservedate.Value.Day.ToString();
           // date_dayoftheweek   = dateTimePicker_reservedate.Value.DayOfWeek.ToString();
            date_month          = dateTimePicker_reservedate.Value.Month.ToString();
            date_year           = dateTimePicker_reservedate.Value.Year.ToString();

            //Get Time Information
            time_reservation_short = dateTimePicker_reservetime.Value.ToShortTimeString();
        

            //get MemberID
            memberNo            = (textBox_MemID.Text);

            //get courtNo
            courtNo             = (textBox_CourtNum.Text);


            //methods to check if there is valid numerical input
            memberNo = GetCorrectInput(memberNo);
            courtNo = GetCorrectInput(courtNo);

            //method to check if file is empty, if empty delete file
            fileEmpty();

            //Write the filled information to an XML file
            if (memberNo != ""  && courtNo != "")
            {
                if (!File.Exists("data.xml"))
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create("data.xml", xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("CurrentReservations");

                        xmlWriter.WriteStartElement("Reservation");
                        xmlWriter.WriteElementString("ID", memberNo);
                        xmlWriter.WriteElementString("Court", courtNo);
                        xmlWriter.WriteElementString("Day", date_month + "/" + date_dayofmonth + "/" + date_year);
                        xmlWriter.WriteElementString("Time", time_reservation_short);
                        xmlWriter.WriteElementString("Confirmed", didConfirm);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Flush();
                        xmlWriter.Close();
                    }
                }
                else
                {
                    XDocument xDocument = XDocument.Load("data.xml");
                    XElement root = xDocument.Element("CurrentReservations");
                    IEnumerable<XElement> rows = root.Descendants("Reservation");
                    XElement firstRow = rows.First();
                    
                    firstRow.AddBeforeSelf(
                       new XElement("Reservation",
                       new XElement("ID", memberNo),
                       new XElement("Court", courtNo),
                       new XElement("Day", date_month + "/" + date_dayofmonth + "/" + date_year),
                       new XElement("Time", time_reservation_short),
                       new XElement("Confirmed", didConfirm)));
                    xDocument.Save("data.xml");
                }

                showTable();


                MessageBox.Show("Member added. Schedule updated.");
            }
            else
            {
                MessageBox.Show("Invalid input. Please fill out all fields correctly.");
            }
          
        }

        /**
         * 
         * Confirm Reservation
         * 
         * */

        private void btn_confirm_reservation_Click(object sender, EventArgs e)
        {
            string xmlDoc;
            string memID;

            memID = textBox_confirm_memid.Text;

            //check for numerical input
            memID = GetCorrectInput(memID);

            //get the member ID from field
            if (memID != "")
            {
                //set string for the XML Doc
                xmlDoc = xmlAsString();

                //load in the string
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(xmlDoc);
                XmlNode node = xml.SelectSingleNode("/CurrentReservations/Reservation/Confirmed");


                //check all nodes under reservation section
                XmlNodeList xnlist = xml.SelectNodes("/CurrentReservations/Reservation");

                foreach(XmlNode xn in xnlist)
                {
                    if(xn["ID"].InnerText == memID && node != null)
                    {
                        lbl_confirm_court_output.Text = xn["Court"].InnerText;
                        lbl_confirm_time_output.Text = xn["Time"].InnerText;
                        lbl_confirm_date_output.Text = xn["Day"].InnerText;
                        xn["Confirmed"].InnerText = "\u2713";
                        //node.InnerText = "no";
                        xml.Save("data.xml");
                        showTable();
                    }
                }

                MessageBox.Show("Reservation Confirmed.");
                
            }
            else
            {
                MessageBox.Show("Incorrect input in text field.");
            }

            



        }

        private void showTable()
        {
            if(new FileInfo("data.xml").Length > 0)
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.Clear();
                    ds.ReadXml("data.xml");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void fileEmpty()
        {
            if (File.Exists("data.xml"))
            {
                if (new FileInfo("data.xml").Length == 0)
                {
                    File.Delete("data.xml");
                }
            }
        }
        

        private string GetCorrectInput(string input)
        {
            //makes sure the two fields are numerical
            int output;

            int.TryParse(input, out output);

            if(output == 0)
            {
                input = "";
                return input;
            }else if (output > 0)
            {
                return input;
            }
            else
            {
                input = "";
                return input;
            }
            
        }

        private string xmlAsString()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data.xml");

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);

            xmlDoc.WriteTo(tx);

            string str = sw.ToString();
            return str;
        }
        
    }
}

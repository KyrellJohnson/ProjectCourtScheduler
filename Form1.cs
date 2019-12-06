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
using System.Xml.XPath;

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
                    try
                    {
                        dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No Data");
                    }
                    
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
            Boolean matchfound = false;
            Boolean correctDate = false;
            Boolean correctTime = false;

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

            correctDate = TestInvalidDate(dateTimePicker_reservedate);
            correctTime = TestTime(dateTimePicker_reservetime);

            //Write the filled information to an XML file
            if (memberNo != ""  && courtNo != "" && correctDate == true && correctTime == true)
            {
                ifNoLongerExists:
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
                    MessageBox.Show("Reservation added.");
                }
                else
                {
                    string xmlDoc;
                    xmlDoc = xmlAsString();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(xmlDoc);
                    XmlNode node = xml.SelectSingleNode("/CurrentReservations/Reservation/Confirmed");


                    //check all nodes under reservation section
                    XmlNodeList xnlist = xml.SelectNodes("/CurrentReservations/Reservation");


                    foreach (XmlNode xn in xnlist)
                    {
                        if (xn["ID"].InnerText == memberNo)
                        {
                            matchfound = true;
                        }
                    }
                    if(matchfound == true)
                    {
                        try
                        {
                            MessageBox.Show("Member already has a reservation.");
                        }
                        catch (Exception)
                        {
                            File.Delete("data.xml");
                            goto ifNoLongerExists;
                        }
                    }
                    else if(matchfound == false)
                    {
                        XDocument xDocument = XDocument.Load("data.xml");
                        XElement root = xDocument.Element("CurrentReservations");
                        IEnumerable<XElement> rows = root.Descendants("Reservation");
                        try
                        {
                            XElement firstRow = rows.First();

                            firstRow.AddBeforeSelf(
                               new XElement("Reservation",
                               new XElement("ID", memberNo),
                               new XElement("Court", courtNo),
                               new XElement("Day", date_month + "/" + date_dayofmonth + "/" + date_year),
                               new XElement("Time", time_reservation_short),
                               new XElement("Confirmed", didConfirm)));
                            xDocument.Save("data.xml");
                            MessageBox.Show("Member added. Schedule updated.");
                        }
                        catch (Exception)
                        {
                            File.Delete("data.xml");
                            goto ifNoLongerExists;
                        }
                    }

                }

                showTable();
    
            }
            else
            {
                if(correctDate == false || correctTime == false)
                {
                    MessageBox.Show("Invalid Date/Time Entered");
                }
                else
                {
                    MessageBox.Show("Invalid input. Please fill out all fields correctly.");
                }
                
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

                Boolean matchfound = false;

                foreach (XmlNode xn in xnlist)
                {
                    if (xn["ID"].InnerText == memID && node != null)
                    {
                        matchfound = true;
                    }
                }

                if(matchfound == true)
                {
                    foreach (XmlNode xn in xnlist)
                    {
                        if (xn["ID"].InnerText == memID && node != null)
                        {
                            lbl_confirm_court_output.Text = xn["Court"].InnerText;
                            lbl_confirm_time_output.Text = xn["Time"].InnerText;
                            lbl_confirm_date_output.Text = xn["Day"].InnerText;
                            xn["Confirmed"].InnerText = "\u2713";
                            //node.InnerText = "no";
                            xml.Save("data.xml");
                            showTable();
                            MessageBox.Show("Reservation Confirmed.");
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Reservation could not be confirmed");
                }
                

                
                
            }
            else
            {
                lbl_confirm_court_output.Text = "--";
                lbl_confirm_time_output.Text = "--";
                lbl_confirm_date_output.Text = "--";
                MessageBox.Show("Incorrect input in text field.");
            }

            



        }

        /***
         * 
         * Cancel Reservation
         * 
         * */
        private void btn_cancel_reservation_Click(object sender, EventArgs e)
        {
            string xmlDoc;
            string memID;
            memID = textBox_cancel_reservation.Text;
            memID = GetCorrectInput(memID);


            //set string for the XML Doc
            xmlDoc = xmlAsString();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlDoc);

            //check all nodes under reservation section
            XmlNodeList xnlist = xml.SelectNodes("/CurrentReservations/Reservation");


            if (memID != "")
            {
                XElement objElement = XElement.Load(@"data.xml");
                XElement delNode = objElement.Descendants("Reservation").Where(a =>
                            a.Element("ID").Value == memID).FirstOrDefault();
                if(delNode != null)
                {
                    foreach (XmlNode xn in xnlist)
                    {
                        if (xn["ID"].InnerText == memID)
                        {
                            lbl_cancel_courtNo_output.Text = xn["Court"].InnerText;
                            lbl_cancel_time_output.Text = xn["Time"].InnerText;
                            lbl_cancel_date_output.Text = xn["Day"].InnerText;
                            
                            //node.InnerText = "no";
                            xml.Save("data.xml");
                            
                        }
                    }

                    delNode.Remove();
                    objElement.Save(@"data.xml");
                    showTable();
                    MessageBox.Show("Reservation Cancelled");
                }
                else
                {
                    lbl_cancel_courtNo_output.Text = "--";
                    lbl_cancel_time_output.Text = "--";
                    lbl_cancel_date_output.Text = "--";
                    MessageBox.Show("This Member ID is not assosiated with a current reservation.");
                }
            }
            else
            {
                MessageBox.Show("Member ID is not in correct format.");
            }
            
            

        }



        private void showTable()
        {
            if(new FileInfo("data.xml").Length > 0)
            {
                try
                {
                    DataSet ds = new DataSet();
                    dataGridView1.Visible = true;
                    ds.Clear();
                    ds.ReadXml("data.xml");
                    try
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    catch (Exception)
                    {
                        dataGridView1.Visible = false;
                    }
                    
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

        private Boolean TestInvalidDate(DateTimePicker input)
        {
            DateTime dt1 = DateTime.Now.Date;
            DateTime dt2 = Convert.ToDateTime(input.Text.Trim()).Date;

            if(dt1 >= dt2)
            {
                //if date is in past
                return false;
            }
            else
            {
                //if date is in future
                if ((dt1 - dt2).TotalDays >= -7)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }

            
        }

        private Boolean TestTime(DateTimePicker input)
        {
            
            int timeSec = Convert.ToDateTime(input.Text.Trim()).Minute;
            if(timeSec == 00)
            {
                return true;
            }

            return false;
        }

        private string xmlAsString()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (File.Exists("data.xml")){
                xmlDoc.Load("data.xml");
            }
            

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);

            xmlDoc.WriteTo(tx);

            string str = sw.ToString();
            return str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
            
        }
    }
}

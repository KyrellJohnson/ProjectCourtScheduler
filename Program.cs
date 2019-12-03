using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DesktopApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            

            

        }
    }

    public class Reservations
    {
        public int MemID { get; set; }
        public string ResTIme { get; set; }
        public string ResDateMonth { get; set; }
        public string ResDateDay { get; set; }
        public string ResDateYear { get; set; }
        public int ResCourtNo { get; set; }

    }

}

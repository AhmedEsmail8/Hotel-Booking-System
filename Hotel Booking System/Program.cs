using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Booking_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form1 sign_in;
        public static User user;
        public static OracleConnection conn;
        [STAThread]
        
        static void Main()
        {
            conn = new OracleConnection("Data source=orcl;User Id=scott; Password = tiger;");
            conn.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sign_in = new Form1();
            Application.Run(sign_in);
        }
    }
}

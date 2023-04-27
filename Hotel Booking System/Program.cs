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
        public static Reservation reservation;
        public static home home;
        public static Payment payment;
        public static EditUserInfo editUserInfo;
        [STAThread]
        
        static void Main()
        {
            conn = new OracleConnection("Data source=orcl;User Id=scott; Password = tiger;");
            user = new User(conn);
            conn.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            reservation = new Reservation();
            sign_in = new Form1();
            home = new home();
            payment = new Payment();
            editUserInfo = new EditUserInfo();
            Application.Run(sign_in);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using WindowsFormsApp1;

namespace Hotel_Booking_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Login sign_in;

        //client
        public static User user;
        public static OracleConnection conn;
        public static Reservation reservation;
        public static home home;
        public static Payment payment;
        public static EditUserInfo editUserInfo;
        public static reservationsList reservationslist;

        //admin
        public static receptionAddRooms addrooms;
        public static receptionEditRooms editrooms;
        public static receptionistHome receptionisthome;
        public static reservationItem reservationitem;
        public static Reservations receptionistreservations;
        //public static Form1 report1;
        public static Form2 report2;
        public static Form3 report3;

        [STAThread]
        
        static void Main()
        {
            conn = new OracleConnection("Data source=orcl;User Id=scott; Password = tiger;");
            user = new User(conn);
            conn.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sign_in = new Login();
            
            //client
            reservation = new Reservation();
            home = new home();
            payment = new Payment();
            editUserInfo = new EditUserInfo();
            reservationslist = new reservationsList();

            //admin
            addrooms = new receptionAddRooms();
            editrooms = new receptionEditRooms();
            receptionisthome = new receptionistHome();
            reservationitem = new reservationItem();
            receptionistreservations = new Reservations();
            //report1 = new Form1();
            report2 = new Form2();
            report3 = new Form3();

            Application.Run(sign_in);
        }
    }
}

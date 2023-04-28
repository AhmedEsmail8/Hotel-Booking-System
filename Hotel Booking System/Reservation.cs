using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Booking_System
{
    public class Reservation
    {
        public string res_id, start_date, end_date, payment_method, room_no;
        public User guest;
        public Room room;
        public Reservation()
        {
            OracleCommand cmd = new OracleCommand("SELECT MAX(res_id) FROM reservations", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString().Length == 0)
                    res_id = "1";
                else
                    res_id = (Int16.Parse(dr[0].ToString()) + 1).ToString();
            }
            guest = Program.user;
        }

        public Reservation(string res_id)
        {
            OracleCommand cmd = new OracleCommand("SELECT * FROM reservations WHERE res_id = :res", Program.conn);
            cmd.Parameters.Add("res", res_id);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.res_id = res_id;
                DateTime start = dr.GetDateTime(1), end = dr.GetDateTime(2);
                string x = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(start.Month).ToUpper(),
                    y = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(end.Month).ToUpper();
                start_date = start.Day.ToString() + "-" + x + "-" + start.Year.ToString();
                end_date = end.Day.ToString() + "-" + y + "-" + end.Year.ToString();
                payment_method = dr[3].ToString();
                room_no = dr[4].ToString();
                guest = new User(dr[5].ToString());
                room = new Room(room_no);
            }
        }
        
        public void save()
        {
            OracleCommand cmd = new OracleCommand("INSERT INTO reservations VALUES(:res_id, :start_date, :end_date, :payment_method, :room_no, :guest_id)", Program.conn);
            cmd.Parameters.Add("res_id", res_id);
            cmd.Parameters.Add("start_date", start_date);
            cmd.Parameters.Add("end_date", end_date);
            cmd.Parameters.Add("method", payment_method);
            cmd.Parameters.Add("room", room_no);
            cmd.Parameters.Add("guest_id", guest.ssn);
            cmd.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand("INSERT INTO pending_reservations VALUES(:id, :res)", Program.conn);
            cmd2.Parameters.Add("id", guest.ssn);
            cmd2.Parameters.Add("res", res_id);
            cmd2.ExecuteNonQuery();
        }

        public bool update(string start_date, string end_date)
        {
            try
            {
                OracleCommand cmd = new OracleCommand("UPDATE reservations SET start_date = :st, end_date = :end WHERE res_id = :id", Program.conn);
                cmd.Parameters.Add("st", start_date);
                cmd.Parameters.Add("end", end_date);
                cmd.Parameters.Add("id", res_id);
                int r = cmd.ExecuteNonQuery();
                if (r == -1)
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            this.start_date = start_date;
            this.end_date = end_date;
            return true;
        }

        public void delete()
        {
            OracleCommand cmd = new OracleCommand("DELETE FROM credit_cards WHERE res_id = :id", Program.conn);
            OracleCommand cmd2 = new OracleCommand("DELETE FROM pending_reservations WHERE reservation_id = :id", Program.conn);
            OracleCommand cmd3 = new OracleCommand("DELETE FROM reservations WHERE res_id = :id", Program.conn);
            cmd.Parameters.Add("id", res_id);
            cmd2.Parameters.Add("id", res_id);
            cmd3.Parameters.Add("id", res_id);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
        }
    }
}

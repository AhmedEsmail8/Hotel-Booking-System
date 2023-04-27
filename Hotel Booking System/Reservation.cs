using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Booking_System
{
    class Reservation
    {
        public string res_id, start_date, end_date, payment_method, room_no;
        public User guest;
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
                
        }

        public Reservation(string res_id)
        {
            OracleCommand cmd = new OracleCommand("SELECT * FROM reservations WHERE res_id = :res", Program.conn);
            cmd.Parameters.Add("res", res_id);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.res_id = res_id;
                start_date = dr[1].ToString();
                end_date = dr[2].ToString();
                payment_method = dr[3].ToString();
                room_no = dr[4].ToString();
                guest = new User(dr[5].ToString());
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
        }
    }
}

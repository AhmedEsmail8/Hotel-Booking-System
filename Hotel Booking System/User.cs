using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Booking_System
{
    struct credit_card
    {
        string card_no, name, guest_id;
        int ccv;
    }
    public class User
    {
        public string f_name, l_name, ssn, email, phone_number, password;
        OracleConnection conn;
        List<credit_card> credit_cards = new List<credit_card>();

        // false--> guest
        // true--> Admin
        public bool type;
        public User(OracleConnection conn)
        {
            this.conn = conn;
        }

        public bool login(string email, string password)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string txt;
                if (email.Substring(email.Length - 10, 10) == "@Admin.com")
                {
                    type = true;
                    txt = "SELECT * FROM receptionists WHERE email = :e AND password = :p";
                }
                else
                {
                    type = false;
                    txt = "SELECT * FROM guests WHERE email = :e AND password = :p";
                }
                cmd.CommandText = txt;
                cmd.Parameters.Add("e", email);
                cmd.Parameters.Add("p", password);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    f_name = dr[1].ToString();
                    l_name = dr[2].ToString();
                    ssn = dr[0].ToString();
                    this.email = email;
                    this.password = password;
                    phone_number = dr[4].ToString();
                    return true;
                }
                else                    
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool register(string f_name, string l_name, string ssn, string email, string password)
        {
            try
            {
                if (login(email, password))
                    return false;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string txt;
                if (email.Substring(email.Length - 10, 10) == "@Admin.com")
                {
                    type = true;
                    txt = "INSERT INTO receptionists VALUES(:a, :b, :c, :d, :e, :f)";
                    cmd.CommandText = txt;
                    cmd.Parameters.Add("a", ssn);
                    cmd.Parameters.Add("b", f_name);
                    cmd.Parameters.Add("c", l_name);
                    cmd.Parameters.Add("d", email);
                    cmd.Parameters.Add("f", password);
                    cmd.Parameters.Add("e", "0");
                }
                else
                {
                    type = false;
                    txt = "INSERT INTO guests VALUES(:a, :b, :c, :d, :e, :f)";
                    cmd.CommandText = txt;
                    cmd.Parameters.Add("a", ssn);
                    cmd.Parameters.Add("b", f_name);
                    cmd.Parameters.Add("c", l_name);
                    cmd.Parameters.Add("d", email);
                    cmd.Parameters.Add("e", "0");
                    cmd.Parameters.Add("f", password);
                }
                int r = cmd.ExecuteNonQuery();
                if (r == -1)
                    return false;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}

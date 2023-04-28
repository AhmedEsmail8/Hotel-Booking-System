using System;
using System.IO;
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
    public  class User
    {
        public string f_name, l_name, ssn, email, phone_number, password, photo;
        OracleConnection conn;
        List<credit_card> credit_cards = new List<credit_card>();

        // false--> guest
        // true--> receptionist
        public bool type;
        public User(OracleConnection conn)
        {
            this.conn = conn;
        }

        public User(string ssn)
        {
            OracleCommand cmd = new OracleCommand("SELECT * FROM guests WHERE ssn = :ssn", Program.conn);
            cmd.Parameters.Add("ssn", ssn);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                f_name = dr[1].ToString();
                l_name = dr[2].ToString();
                this.ssn = dr[0].ToString();
                email = dr[3].ToString();
                password = dr[5].ToString();
                phone_number = dr[4].ToString();
                photo = dr[6].ToString().Replace('\\', '/');

                if (photo.Length == 0)
                {
                    string workingDirectory = Environment.CurrentDirectory;
                    string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                    photo = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "profile_deafult.jpeg";
                }
            }
        }

        public bool login(string email, string password)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string txt;
                if (email.Length >= 10 && email.Substring(email.Length - 10, 10) == "@admin.com")
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
                    photo = dr[6].ToString().Replace('\\', '/');
                    
                    if (photo.Length == 0)
                    {
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        photo = projectDirectory.Replace('\\', '/')+ "/Hotel Booking System/" + "profile_deafult.jpeg";
                    }
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
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                if (email.Length>=10 && email.Substring(email.Length - 10, 10) == "@admin.com")
                {
                    type = true;
                    txt = "INSERT INTO receptionists VALUES(:a, :b, :c, :d, :e, :f, :g)";
                    cmd.CommandText = txt;
                    cmd.Parameters.Add("a", ssn);
                    cmd.Parameters.Add("b", f_name);
                    cmd.Parameters.Add("c", l_name);
                    cmd.Parameters.Add("d", email);
                    cmd.Parameters.Add("f", password);
                    cmd.Parameters.Add("e", "0");
                    cmd.Parameters.Add("g", projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "profile_deafult.jpeg");
                }
                else
                {
                    type = false;
                    txt = "INSERT INTO guests VALUES(:a, :b, :c, :d, :e, :f, :g)";
                    cmd.CommandText = txt;
                    cmd.Parameters.Add("a", ssn);
                    cmd.Parameters.Add("b", f_name);
                    cmd.Parameters.Add("c", l_name);
                    cmd.Parameters.Add("d", email);
                    cmd.Parameters.Add("e", "0");
                    cmd.Parameters.Add("f", password);
                    cmd.Parameters.Add("g", projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "profile_deafult.jpeg");
                }
                int r = cmd.ExecuteNonQuery();
                if (r == -1)
                    return false;
                photo = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "profile_deafult.jpeg";
                this.password = password;
                phone_number = "0";
                this.f_name = f_name;
                this.l_name = l_name;
                this.ssn = ssn;
                this.email = email;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool update(string f_name, string l_name, string phone, string email, string password, string photo)
        {
            string cmdstr;
            if (!type)
                cmdstr = "UPDATE guests SET f_name = :a, l_name = :b, phone_number = :c, email = :d, password = :pass, photo = :ph WHERE ssn = :ssn";
            else
                cmdstr = "UPDATE receptionists SET f_name = :a, l_name = :b, phone_number = :c, email = :d, password = :pass, photo = :ph WHERE ssn = :ssn";
            OracleCommand cmd = new OracleCommand(cmdstr, Program.conn);
            cmd.Parameters.Add("a", f_name);
            cmd.Parameters.Add("b", l_name);
            cmd.Parameters.Add("c", phone);
            cmd.Parameters.Add("d", email);
            cmd.Parameters.Add("pass", password);
            cmd.Parameters.Add("ph", photo.Replace("\\", "/"));
            cmd.Parameters.Add("ssn", ssn);
            int r = cmd.ExecuteNonQuery();
            if (r == -1)
                return false;
            this.f_name = f_name;
            this.l_name = l_name;
            phone_number = phone;
            this.email = email;
            this.password = password;
            this.photo = photo.Replace("\\", "/");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Booking_System
{
    class Room
    {
        public int room_no, no_of_beds, price;
        public string description, view, available, photo;
        public Room()
        {

        }

        public static List<Room> getRooms()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM rooms", Program.conn);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Room room = new Room();
                    room.room_no = Int16.Parse(dr["room_no"].ToString());
                    room.description = dr["description"].ToString();
                    room.no_of_beds = Int16.Parse(dr["no_of_beds"].ToString());
                    room.view = dr["room_view"].ToString();
                    room.price = Int16.Parse(dr["price_per_night"].ToString());
                    room.available = dr["available"].ToString();
                    room.photo = dr["photo"].ToString();
                    rooms.Add(room);
                    Console.WriteLine("YES");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return rooms;
        }
    }
}

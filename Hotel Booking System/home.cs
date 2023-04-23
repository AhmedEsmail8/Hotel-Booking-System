using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Booking_System
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private void home_Load(object sender, EventArgs e)
        {
            roomsItems();
        }

        private void roomsItems()
        {
            List<Room> rooms = Room.getRooms();
            foreach (Room room in rooms)
            {
                if (room.available == "yes")
                {
                    roomsList obj = new roomsList();
                    obj.Title = room.room_no.ToString();
                    obj.Description = room.description;
                    obj.Photo = Image.FromFile(room.photo.Replace('\\', '/'));
                    flowLayoutPanel1.Controls.Add(obj);
                }
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

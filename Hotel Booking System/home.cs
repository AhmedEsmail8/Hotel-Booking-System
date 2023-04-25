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
            this.ShowInTaskbar = false;

            sideBar.Hide();
            roomsItems();            

            panel3.Parent = pictureBox1;
            panel3.BackColor = Color.Transparent;
            
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;

            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;

            no_of_beds_label.Parent = pictureBox1;
            no_of_beds_label.BackColor = Color.Transparent;

            room_view_label.Parent = pictureBox1;
            room_view_label.BackColor = Color.Transparent;

            check_in_date.MinDate = DateTime.Today;
            check_out_date.MinDate = check_in_date.Value.AddDays(1.0);
        }

        private void roomsItems()
        {
            List<Room> rooms = Room.getRooms();
            foreach (Room room in rooms)
            {
                if (room.available == "yes")
                {
                    roomsList obj = new roomsList();
                    obj.View = room.view.ToString();
                    obj.Description = room.description;
                    try
                    {
                        obj.Photo = Image.FromFile(room.photo.Replace('\\', '/'));
                    }
                    catch(Exception error)
                    {
                        obj.Photo = Image.FromFile("D:/SW_project/Hotel-Booking-System/Hotel Booking System/deafult_image.png");
                    }
                    
                    flowLayoutPanel1.Controls.Add(obj);
                }
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void check_in_date_ValueChanged(object sender, EventArgs e)
        {
            check_out_date.MinDate = check_in_date.Value.AddDays(1.0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            sideBar.Show();
            //sideBarIsHidden = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sideBar.Hide();
            //pictureBox3.Hide();
            pictureBox2.Show();
            //sideBarIsHidden = true;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Account_info_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditUserInfo obj = new EditUserInfo();
            obj.Show();
        }

        private void register_label_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Reservations : Form
    {
       
        public Reservations()
        {
            InitializeComponent();
        }
        
        private void Reservations_Load(object sender, EventArgs e)
        {

            menubar.Hide();
            addroompagebutton.Parent = menubar;
            addroompagebutton.BackColor = Color.Transparent;
            this.ShowInTaskbar = false;


            for (int i = 0; i < 6; i++)
              {                
                   
                    reservationItem obj = new reservationItem();
                    flowLayoutPanel2.Controls.Add(obj);
                             
              }          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menubutton.Hide();
            menubar.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menubar.Hide();
            menubutton.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receptionEditRooms obj = new receptionEditRooms();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            receptionAddRooms obj = new receptionAddRooms();
            obj.Show();
            this.Hide();
        }

        private void reservationspagebutton_Click(object sender, EventArgs e)
        {
        
        }

        private void editadminpagebutton_Click(object sender, EventArgs e)
        {
            receptionistHome obj = new receptionistHome();
            obj.Show();
            this.Hide();
        }

        private void Reservations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }
    }
}

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
            Fill();
        }

        public void Fill()
        {
            flowLayoutPanel2.Controls.Clear();
            OracleCommand cmd = new OracleCommand("SELECT reservation_id FROM pending_reservations", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Reservation res = new Reservation(dr[0].ToString());
                reservationItem obj = new reservationItem();
                obj.reservationid.Text = res.res_id;
                obj.gestid.Text = res.guest.ssn;
                obj.roomnumber.Text = res.room.room_no.ToString();
                obj.startDate.Text = res.start_date;
                obj.endDate.Text = res.end_date;
                obj.paymethod.Text = res.payment_method;
                obj.reservation = res;
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

        private void Reservations_VisibleChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void Reservations_Shown(object sender, EventArgs e)
        {
            Fill();
        }
    }
}

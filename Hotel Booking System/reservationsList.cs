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
    public partial class reservationsList : Form
    {
        public reservationsList()
        {
            InitializeComponent();
        }

        private void reservationsList_Load(object sender, EventArgs e)
        {
            sideBar.Hide();
            edit_panel.Hide();

            //edit_panel.Parent = this;
            //edit_panel.BackColor = Color.FromArgb(100, Color.Black);

            Fill();
        }

        public void Fill()
        {
            OracleCommand cmd = new OracleCommand("SELECT r.res_id FROM pending_reservations p, reservations r WHERE p.reservation_id = r.res_id", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                notification obj = new notification();
                obj.reservation = new Reservation(dr[0].ToString());
                obj.start_date_txt.Text = obj.reservation.start_date;
                obj.end_date_txt.Text = obj.reservation.end_date;
                obj.num_of_beds_txt.Text = obj.reservation.room.no_of_beds.ToString();
                OracleCommand cmd2 = new OracleCommand("calculate_price", Program.conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("room_no", obj.reservation.room.room_no.ToString());
                cmd2.Parameters.Add("start_date", obj.reservation.start_date);
                cmd2.Parameters.Add("end_date", obj.reservation.end_date);
                Console.WriteLine(obj.reservation.start_date+"   "+ obj.reservation.end_date);
                cmd2.Parameters.Add("price", OracleDbType.Int16, ParameterDirection.Output);
                cmd2.ExecuteNonQuery();
                obj.total_price.Text = cmd2.Parameters["price"].Value.ToString();

            }



            
            
        }

        private void reservationsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sideBar.Show();
            show_menu.Hide();
        }

        private void hide_menu_Click(object sender, EventArgs e)
        {
            show_menu.Show();
            sideBar.Hide();
        }

        private void Account_info_Click(object sender, EventArgs e)
        {
            Hide();
            Program.editUserInfo.Show();
            sideBar.Hide();
        }

        private void Search_sideBar_Click(object sender, EventArgs e)
        {
            Hide();
            Program.home.Show();
            sideBar.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Hide();
            Program.sign_in.Show();
            sideBar.Hide();
        }

        private void last_name_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

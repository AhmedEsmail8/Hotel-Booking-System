using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public Reservation selectedReservation;
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
            Program.reservationslist.flowLayoutPanel1.Controls.Clear();
            OracleCommand cmd = new OracleCommand("SELECT res_id FROM reservations", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                notification obj = new notification();
                obj.reservation = new Reservation(dr[0].ToString());
                obj.start_date_txt.Text = obj.reservation.start_date;
                obj.end_date_txt.Text = obj.reservation.end_date;
                obj.num_of_beds_txt.Text = obj.reservation.room.no_of_beds.ToString();
                obj.Description = obj.reservation.room.description;
                obj.View = obj.reservation.room.view;
                obj.Photo = Image.FromFile(obj.reservation.room.photo);
                OracleCommand cmd2 = new OracleCommand("calculate_price", Program.conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("room_no", obj.reservation.room.room_no.ToString());
                cmd2.Parameters.Add("start_date", obj.reservation.start_date);
                cmd2.Parameters.Add("end_date", obj.reservation.end_date);
                cmd2.Parameters.Add("price", OracleDbType.Int16, ParameterDirection.Output);
                cmd2.ExecuteNonQuery();
                obj.total_price.Text = cmd2.Parameters["price"].Value.ToString();
                OracleCommand cmd3 = new OracleCommand("SELECT accepted FROM actions WHERE guest_id = :guest AND reservation_id = :res", Program.conn);
                cmd3.Parameters.Add("id", Program.user.ssn);
                cmd3.Parameters.Add("res", obj.reservation.res_id);
                OracleDataReader dr2 = cmd3.ExecuteReader();
                if (dr2.Read())
                {
                    if (dr2[0].ToString() == "yes")
                        obj.response.Text = "Accepted";
                    else
                        obj.response.Text = "Rejected";
                }
                else
                    obj.response.Text = "no response yet";
                Program.reservationslist.flowLayoutPanel1.Controls.Add(obj);
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
            show_menu.Show();
        }

        private void Search_sideBar_Click(object sender, EventArgs e)
        {
            Hide();
            Program.home.Show();
            sideBar.Hide();
            show_menu.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Hide();
            Program.sign_in.Show();
            sideBar.Hide();
            show_menu.Show();
        }

        private void last_name_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.reservationslist.edit_panel.Hide();
            Fill();
        }

        private void signup_submit_Click(object sender, EventArgs e)
        {
            string start_date, end_date;
            string x = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(Program.reservationslist.dateTimePicker1.Value.Month).ToUpper(),
                    y = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(Program.reservationslist.dateTimePicker2.Value.Month).ToUpper();
            start_date = Program.reservationslist.dateTimePicker1.Value.Day.ToString() + "-" + x + "-" + Program.reservationslist.dateTimePicker1.Value.Year.ToString();
            end_date = Program.reservationslist.dateTimePicker2.Value.Day.ToString() + "-" + y + "-" + Program.reservationslist.dateTimePicker2.Value.Year.ToString();
            
            if(selectedReservation.update(start_date, end_date))
            {
                MessageBox.Show("Your reservation updated seccessfully");
                edit_panel.Hide();
                Program.reservationslist.Fill();
            }
            else
            {
                MessageBox.Show("Please, try again");
            }
        }

        private void reservationsList_Shown(object sender, EventArgs e)
        {
            Fill();
        }

        private void reservationsList_VisibleChanged(object sender, EventArgs e)
        {
            Fill();
        }
    }
}

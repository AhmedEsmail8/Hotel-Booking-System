using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            for (int i = 0; i < 5; i++)
            {
                notification obj = new notification();
                flowLayoutPanel1.Controls.Add(obj);
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
    }
}

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
        User user;
        OracleConnection conn;
        public home(User user, OracleConnection conn)
        {
            this.user = user;
            this.conn = conn;
            InitializeComponent();
        }
        private void home_Load(object sender, EventArgs e)
        {
            roomsItems();
        }

        private void roomsItems()
        {
            roomsList[] listItems = new roomsList[20];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new roomsList();
                listItems[i].Title = "room" + i + "title";
                listItems[i].Description = "room" + i + "description";
                                
                flowLayoutPanel1.Controls.Add(listItems[i]);
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

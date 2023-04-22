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
            
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }
    }
}

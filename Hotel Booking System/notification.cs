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
    public partial class notification : UserControl
    {
        public Reservation reservation;
        public notification()
        {
            InitializeComponent();
        }

        #region properties

        private string _view;
        private string _decription;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _num_of_beds;
        private int _total_price;
        private string _response;
        private Image _photo;

        [Category("Custom Props")]
        public string View
        {
            get { return _view; }
            set { _view = value; view.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _decription; }
            set { _decription = value; description.Text = value; }
        }

        [Category("Custom Props")]
        public DateTime StartDate
        {
            get { return _startDate; }            
            set { _startDate = value; start_date_txt.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; end_date_txt.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public int Num_of_beds
        {
            get { return _num_of_beds; }
            set { _num_of_beds = value; num_of_beds_txt.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public int Total_Price
        {
            get { return _total_price; }
            set { _total_price = value; total_price.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string Response
        {
            get { return _response; }
            set { _response = value; response.Text = value; }
        }

        [Category("Custom Props")]
        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; pictureBox1.Image = value; }
        }

        #endregion

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void cancel_reservation_Click(object sender, EventArgs e)
        {
            reservation.delete();
            Program.reservationslist.Fill();
        }

        private void notification_Load(object sender, EventArgs e)
        {

        }

        private void edit_reservation_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("SELECT * FROM actions WHERE reservation_id = :id", Program.conn);
            cmd.Parameters.Add("id", reservation.res_id);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("You can't update this reservation because it's reviewed");
                return;
            }
            Program.reservationslist.flowLayoutPanel1.Controls.Clear();
            Program.reservationslist.edit_panel.Show();
            Program.reservationslist.selectedReservation = this.reservation;
        }
    }
}

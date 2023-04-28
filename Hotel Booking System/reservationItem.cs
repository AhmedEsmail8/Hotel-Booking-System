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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Booking_System
{
    public partial class reservationItem : UserControl
    {
        OracleDataAdapter adapter;
        public DataSet ds;
        public int rowCount;
       
        public reservationItem()
        {
            InitializeComponent();
        }
     


        
        
        private string _res_id;
        private string _startDate;
        private string _endDate;
        private string _payment;
        private string _guest_id;
        private string _roomnumber;

        public reservationItem(string res , string sd , string ed , string pay , string gid , string room)
        {
            this._res_id = res;
            this._startDate = sd;
            this._endDate = ed;
            this._payment = pay;
            this._guest_id = gid;
            this._roomnumber = room;
        }

        [Category("Custom Props")]
        public string Reservationid
        {
            get { return _res_id; }
            set { _res_id = value; reservationid.Text = value; }
        }

        [Category("Custom Props")]
        public string RoomNumber
        {
            get { return _roomnumber; }
            set { _roomnumber = value; roomnumber.Text = value; }
        }

        [Category("Custom Props")]
        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; startDate.Text = value; }
        }

        [Category("Custom Props")]
        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; endDate.Text = value; }
        }

        [Category("Custom Props")]
        public string Payment
        {
            get { return _payment; }
            set { _payment = value; paymethod.Text = value; }
        }

        [Category("Custom Props")]
        public string Guestid
        {
            get { return _guest_id; }
            set { _guest_id = value; gestid.Text = value; }
        }

        public static implicit operator reservationItem(List<reservationItem> v)
        {
            throw new NotImplementedException();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            

        }

        private void decline_Click(object sender, EventArgs e)
        {

        }

        private void reservationItem_Load(object sender, EventArgs e)
        {
           
        }

        private void roomnumber_Click(object sender, EventArgs e)
        {

        }

        private void endDate_Click(object sender, EventArgs e)
        {

        }

        private void gestid_Click(object sender, EventArgs e)
        {

        }
    }
}

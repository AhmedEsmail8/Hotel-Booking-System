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
    public partial class roomsList : UserControl
    {
        public roomsList()
        {
            InitializeComponent();
        }

        #region properties
        private string _view;
        private string _decription;
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
        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; pictureBox1.Image = value; }
        }

        #endregion

        private void roomsList_Load(object sender, EventArgs e)
        {
            
        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            Payment p = new Payment();
            p.Show();
        }
    }
}

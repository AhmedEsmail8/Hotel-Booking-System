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
    public partial class Payment : Form
    {
        int length;

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            length = 1;

            //monthCalendar1.MaxSelectionCount = 2;
            //monthCalendar1.SelectionRange.Start = ;
            monthCalendar1.SetSelectionRange(DateTime.Now, DateTime.Now.AddDays(3));
            //monthCalendar1.SetDate(DateTime.Now);
            //monthCalendar1.SetDate(DateTime.Now.AddDays(2));
            //monthCalendar1.SelectionRange.End = ;

            view_label.Parent = pictureBox1;
            view_label.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            checkin_date.Text = DateTime.Now.ToShortDateString();
            checkin_date.Parent = pictureBox1;
            checkin_date.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            checout_date_txt.Text = DateTime.Now.AddDays(1).ToShortDateString();
            checout_date_txt.Parent = pictureBox1;
            checout_date_txt.BackColor = Color.Transparent;

            DateTime start = new DateTime();
            DateTime end = new DateTime();
            TimeSpan days = new TimeSpan();
            start = Convert.ToDateTime(checkin_date.Text);
            end = Convert.ToDateTime(checout_date_txt.Text);
            days = end - start;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            StringBuilder sb = new StringBuilder();
            sb.Append("2000");
            sb.Append(" EGP / ");
            sb.Append(days.Days.ToString());
            sb.Append(" day(s)");
            price.Text = sb.ToString();
            price.Parent = pictureBox1;
            price.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (length == 4 && textBox1.TextLength < 16)
            {
                //Console.WriteLine(textBox1.TextLength);
                length = -1;
                textBox1.AppendText("-");
                
            }
            length++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home obj = new home();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home obj = new home();
            obj.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

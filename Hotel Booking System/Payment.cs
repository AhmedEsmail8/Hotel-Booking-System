using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Hotel_Booking_System
{
    public partial class Payment : Form
    {

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        public void handle()
        {
            checout_date_txt.Text = Program.home.check_out_date.Value.ToShortDateString();
            checout_date_txt.Parent = pictureBox1;
            checout_date_txt.BackColor = Color.Transparent;

            checkin_date.Text = Program.home.check_in_date.Value.ToShortDateString();
            checkin_date.Parent = pictureBox1;
            checkin_date.BackColor = Color.Transparent;

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            pictureBox1.ImageLocation = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "sidePay.jpg";
            //DateTime h = (DateTime)(Program.home.check_out_date.Value.ToShortDateString());

            TimeSpan days = Program.home.check_out_date.Value.Date.Subtract(Program.home.check_in_date.Value.Date);
            Console.WriteLine("days = "+ Program.home.check_out_date.Value.Date.Subtract(Program.home.check_in_date.Value.Date));

            monthCalendar1.SetSelectionRange(Program.home.check_in_date.Value, Program.home.check_out_date.Value);

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            StringBuilder sb = new StringBuilder();
            OracleCommand cmd = new OracleCommand("calculate_price", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("room_no", Program.reservation.room_no);
            cmd.Parameters.Add("start_date", Program.reservation.start_date);
            cmd.Parameters.Add("end_date", Program.reservation.end_date);
            cmd.Parameters.Add("price", OracleDbType.Int16, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            sb.Append(cmd.Parameters["price"].Value.ToString());
            sb.Append(" EGP / ");
            sb.Append(days.Days.ToString());
            sb.Append(" night(s)");
            price.Text = sb.ToString();
            price.Parent = pictureBox1;
            price.BackColor = Color.Transparent;
            
            view_label.Text = Program.home.comboBox1.SelectedItem.ToString();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            view_label.Parent = pictureBox1;
            view_label.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;

            //handle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if((textBox1.Text.Length - textBox1.Text.Count(f => f=='-')) %4==0)
            //{
            //    textBox1.AppendText("-");
            //    return;
            //}
            //Console.WriteLine("text = " + textBox1.Text.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Please, enter valid data.");
                        return;
                    }
                    Program.reservation.payment_method = "card";
                    Program.reservation.save();
                    OracleCommand cmd = new OracleCommand("INSERT INTO credit_cards VALUES(:num, :res, :cvv, :guest)", Program.conn);
                    cmd.Parameters.Add("num", textBox1.Text.ToString());
                    cmd.Parameters.Add("cvv", textBox2.Text.ToString());
                    cmd.Parameters.Add("guest_id", Program.user.ssn);
                    cmd.Parameters.Add("res", Program.reservation.res_id);                  
                    //Console.WriteLine("card_no = "+ textBox1.Text.ToString()+" res_id = "+ Program.reservation.res_id+" cvv = "+ textBox2.Text.ToString()+" ssn = "+ Program.user.ssn);
                    int r = cmd.ExecuteNonQuery();
                    
                    if (r == -1)
                        MessageBox.Show("There is a problem, please try again");
                    else
                    {
                        Hide();
                        Program.home.Show();
                    }
                }
                else if (radioButton2.Checked)
                {
                    Program.reservation.payment_method = "cash";
                    Program.reservation.save();
                    Hide();
                    Program.home.Show();
                }
                Program.reservationslist.Fill();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is a problem, please try again   "+ex.Message);
            }
            //Program.reservation.save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.home.Show();
            Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            label5.Hide();
            label6.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            label5.Show();
            label6.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.SetSelectionRange(Program.home.check_in_date.Value, Program.home.check_out_date.Value);
        }

        private void monthCalendar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetSelectionRange(Program.home.check_in_date.Value, Program.home.check_out_date.Value);
        }
    }
}

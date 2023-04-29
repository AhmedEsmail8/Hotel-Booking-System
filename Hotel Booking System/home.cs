using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        public home()
        {
            InitializeComponent();
        }
        private void home_Load(object sender, EventArgs e)
        {
            sideBar.Hide();

            roomsItems();

            OracleCommand cmd = new OracleCommand("SELECT DISTINCT room_view FROM rooms", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr[0].ToString());

            panel3.Parent = pictureBox1;
            panel3.BackColor = Color.Transparent;
            
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;

            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;

            no_of_beds_label.Parent = pictureBox1;
            no_of_beds_label.BackColor = Color.Transparent;

            room_view_label.Parent = pictureBox1;
            room_view_label.BackColor = Color.Transparent;

            check_in_date.MinDate = DateTime.Today;
            check_out_date.MinDate = check_in_date.Value.AddDays(1.0);
        }

        private void roomsItems()
        {
            //List<Room> rooms = Room.getRooms();
            //foreach (Room room in rooms)
            //{
            //    if (room.available == "yes")
            //    {
            //        roomsList obj = new roomsList();
            //        obj.View = room.view.ToString();
            //        obj.Description = room.description;
            //        try
            //        {
            //            obj.Photo = Image.FromFile(room.photo.Replace('\\', '/'));
            //        }
            //        catch(Exception error)
            //        {
            //            string workingDirectory = Environment.CurrentDirectory;
            //            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            //            obj.Photo = Image.FromFile(projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "deafult_image.png");
            //        }
            //        obj.label2.Text = room.no_of_beds.ToString();
            //        obj.label4.Text = room.price.ToString();
            //        obj.room_no = room.room_no.ToString();
            //        flowLayoutPanel1.Controls.Add(obj);
            //    }
            //}
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void check_in_date_ValueChanged(object sender, EventArgs e)
        {
            check_out_date.MinDate = check_in_date.Value.AddDays(1.0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            sideBar.Show();
            //sideBarIsHidden = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sideBar.Hide();
            //pictureBox3.Hide();
            pictureBox2.Show();
            //sideBarIsHidden = true;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Hide();
            Program.sign_in.Show();
            sideBar.Hide();
            pictureBox2.Show();
        }

        private void Account_info_Click(object sender, EventArgs e)
        {
            Hide();
            Program.editUserInfo.Show();
            sideBar.Hide();
            pictureBox2.Show();
        }

        private void register_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(check_in_date.Value.Month).ToUpper(), y = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(check_out_date.Value.Month).ToUpper();
                string start_date = check_in_date.Value.Day.ToString() + "-" + x + "-" + check_in_date.Value.Year.ToString();
                string end_date = check_out_date.Value.Day.ToString() + "-" + y + "-" + check_out_date.Value.Year.ToString();
                if (Int32.Parse(min_price_txt.Text)<0 || Int32.Parse(max_price_txt.Text)<0 || comboBox1.SelectedItem == null || min_price_txt.Text.Length == 0 || max_price_txt.Text.Length == 0 || textBox3.Text.Length == 0 || int.Parse(min_price_txt.Text) > int.Parse(max_price_txt.Text))
                {
                    MessageBox.Show("Please, enter valid data.");
                    return;
                }
                //Console.WriteLine(min_price_txt.Text + "   " + max_price_txt.Text);
                //Console.WriteLine(start_date + "   " + end_date);
                //Console.WriteLine(textBox3.Text + "   " + comboBox1.SelectedItem.ToString());
                List<Room> rooms = Room.search(Int32.Parse(min_price_txt.Text).ToString(), Int32.Parse(max_price_txt.Text).ToString(), start_date, end_date, textBox3.Text, comboBox1.SelectedItem.ToString());
                if (rooms == null)
                {
                    MessageBox.Show("Please, enter valid data.");
                    return;
                }
                flowLayoutPanel1.Controls.Clear();
                foreach (Room room in rooms)
                {
                    roomsList obj = new roomsList();
                    obj.View = room.view.ToString();
                    obj.Description = room.description;
                    try
                    {
                        obj.Photo = Image.FromFile(room.photo.Replace('\\', '/'));
                    }
                    catch (Exception ex)
                    {
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        obj.Photo = Image.FromFile(projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "deafult_image.png");
                    }
                    obj.label2.Text = room.no_of_beds.ToString();
                    obj.label4.Text = room.price.ToString();
                    obj.room_no = room.room_no.ToString();
                    flowLayoutPanel1.Controls.Add(obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, enter valid data.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Program.reservationslist.Show();
            sideBar.Hide();
            pictureBox2.Show();
        }

        private void Search_sideBar_Click(object sender, EventArgs e)
        {

        }

        private void home_VisibleChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            OracleCommand cmd = new OracleCommand("SELECT DISTINCT room_view FROM rooms", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr[0].ToString());
            flowLayoutPanel1.Controls.Clear();
            min_price_txt.Text = "";
            max_price_txt.Text = "";
            textBox3.Text = "";
        }

        private void home_Shown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            OracleCommand cmd = new OracleCommand("SELECT DISTINCT room_view FROM rooms", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr[0].ToString());
        }
    }
}

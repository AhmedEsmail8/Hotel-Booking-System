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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Hotel_Booking_System
{
    public partial class receptionAddRooms : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public receptionAddRooms()
        {
            InitializeComponent();
        }

        private void receptionRooms_Load(object sender, EventArgs e)
        {
            sideBar.Hide();
            addroompagebuttin.Parent = sideBar;
            addroompagebuttin.BackColor = Color.Transparent;
            this.ShowInTaskbar = false;
            OracleCommand cmd = new OracleCommand("SELECT DISTINCT room_view FROM rooms", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
                comboBox1.Items.Add(dr[0].ToString());
            desctextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sideBar.Hide();
            menubutton.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menubutton.Hide();
            sideBar.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reservationspagebutton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.receptionistreservations.Show();
            sideBar.Hide();
            menubutton.Show();
        }

        private void editadminpagebutton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.receptionisthome.Show();
            sideBar.Hide();
            menubutton.Show();
        }

        private void addroompagebuttin_Click(object sender, EventArgs e)
        {

        }

        private void editRoompagebutton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.editrooms.Show();
            sideBar.Hide();
            menubutton.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imageLocation = dialog.FileName;
                    pictureBox2.ImageLocation = imageLocation;
                    //MessageBox.Show(imageLocation);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured while uploading your image" + error.Message);
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            pictureBox2.ImageLocation = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/deafult_image.png";
        }

        private void price_Click(object sender, EventArgs e)
        {

        }
            
        private void addroom_Click(object sender, EventArgs e)
        {

            try
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM rooms WHERE room_no = :n", Program.conn);
                cmd.Parameters.Add("n", roomnumbertextBox.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Room already exist!!");
                    return;
                }
                string conn = "Data Source=orcl;User Id=scott;Password=tiger";
                string comstr = "INSERT INTO ROOMS (ROOM_NO , DESCRIPTION , NO_OF_BEDS , ROOM_VIEW , PRICE_PER_NIGHT , AVAILABLE , PHOTO) VALUES (:room_no ,:description , :no_of_beds , :room_view , :price_per_night , :available , :photo)";
                adapter = new OracleDataAdapter(comstr, conn);
                adapter.SelectCommand.Parameters.Add("room_no", roomnumbertextBox.Text);
                adapter.SelectCommand.Parameters.Add("description", desctextBox.Text);
                adapter.SelectCommand.Parameters.Add("no_of_beds", bedstextBox.Text);
                adapter.SelectCommand.Parameters.Add("room_view", comboBox1.Text.ToString());
                adapter.SelectCommand.Parameters.Add("price_per_night", pricetextBox.Text);

                if (radioButton1.Checked)
                {
                    adapter.SelectCommand.Parameters.Add("available", "yes");
                }
                else if (radioButton2.Checked)
                {
                    adapter.SelectCommand.Parameters.Add("available", "no");
                }
                adapter.SelectCommand.Parameters.Add("photo", pictureBox2.ImageLocation);
                ds = new DataSet();
                adapter.Fill(ds);

                MessageBox.Show("Room has been added successfully");

                roomnumbertextBox.Text = "";
                desctextBox.Text = "";
                bedstextBox.Text = "";
                comboBox1.SelectedItem = "";
                pricetextBox.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                pictureBox2.ImageLocation = "";
                if (!comboBox1.Items.Contains(comboBox1.Text))
                    comboBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Something wrong ,please try again !");
            }

        }

        private void receptionAddRooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Program.sign_in.Show();
            sideBar.Hide();
            menubutton.Show();
        }

        private void offers_report_Click(object sender, EventArgs e)
        {
            Hide();
            Program.report2.Show();
            sideBar.Hide();
            menubutton.Show();
        }

        private void reservations_report_Click(object sender, EventArgs e)
        {
            Hide();
            Program.report3.Show();
            sideBar.Hide();
            menubutton.Show();
        }
    }
}

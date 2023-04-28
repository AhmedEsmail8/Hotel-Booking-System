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
    public partial class receptionistHome : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public receptionistHome()
        {
            InitializeComponent();
        }

        private void receptionists_info()
        {
            try
            {
                string connStr = "Data Source=orcl;User Id=scott;Password=tiger";
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    string cmdstr = "SELECT SSN, F_NAME, L_NAME, EMAIL, PASSWORD, PHONE_NUMBER ,PHOTO FROM RECEPTIONISTS WHERE SSN=:SSN";
                    OracleCommand cmd = new OracleCommand(cmdstr, conn);
                    cmd.Parameters.Add("SSN", Program.user.ssn);
                    adapter = new OracleDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    ssnlabel.Text = ds.Tables[0].Rows[0]["SSN"].ToString();
                    emaillabel.Text = ds.Tables[0].Rows[0]["EMAIL"].ToString();
                    textBox1.Text = ds.Tables[0].Rows[0]["F_NAME"].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0]["L_NAME"].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0]["PASSWORD"].ToString();
                    textBox4.Text = ds.Tables[0].Rows[0]["PHONE_NUMBER"].ToString();
                    pictureBox1.ImageLocation = ds.Tables[0].Rows[0]["photo"].ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        private void receptionistHome_Load(object sender, EventArgs e)
        {
            receptionists_info();
            this.ShowInTaskbar = false;
            sideBar.Hide();
            addroompagebutton.Parent = sideBar;
            addroompagebutton.BackColor = Color.Transparent;

        }

      
        private void reservationspagebutton_Click(object sender, EventArgs e)
        {
            Reservations obj = new Reservations();
            obj.Show();
            this.Hide();
        }

        private void addroompagebuttin_Click(object sender, EventArgs e)
        {
            receptionAddRooms obj = new receptionAddRooms();
            obj.Show();
            this.Hide();
        }

      

        private void menubutton_Click(object sender, EventArgs e)
        {
            menubutton.Hide();
            sideBar.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            sideBar.Hide();
            menubutton.Show();
        }

        private void reservationspagebutton_Click_1(object sender, EventArgs e)
        {
            Reservations obj = new Reservations();
            obj.Show();
            this.Hide();
        }

        private void addroompagebutton_Click(object sender, EventArgs e)
        {
            receptionAddRooms obj = new receptionAddRooms();
            obj.Show();
            this.Hide();
        }

        private void editRoompagebutton_Click(object sender, EventArgs e)
        {
            receptionEditRooms obj = new receptionEditRooms();
            obj.Show();
            this.Hide();
        }            

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.user.update(textBox1.Text, textBox2.Text, textBox4.Text, Program.user.email, textBox3.Text, pictureBox1.ImageLocation))
                    MessageBox.Show("Successfully updated your personal information");
                else
                    MessageBox.Show("Something went wrong , please try again!");
            }
            catch
            {
                MessageBox.Show("Something went wrong , please try again!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            pictureBox1.ImageLocation = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "profile_deafult.jpeg";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured while uploading your photo" + error.Message);
            }
        }

        private void receptionistHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Program.sign_in.Show();
            sideBar.Hide();
            menubutton.Show();
        }
    }
}

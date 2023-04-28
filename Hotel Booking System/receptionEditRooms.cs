using Oracle.DataAccess.Client;
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
using System.IO;

namespace Hotel_Booking_System
{
    public partial class receptionEditRooms : Form
    {
        OracleDataAdapter adapter;
        DataSet ds; 
        public receptionEditRooms()
        {
            InitializeComponent();
        }

        private void receptionEditRooms_Load(object sender, EventArgs e)
        {
            sideBar.Hide();
            addroompagebuttin.Parent = sideBar;
            addroompagebuttin.BackColor = Color.Transparent;
            this.ShowInTaskbar = false;

          
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

        private void editRoompagebutton_Click(object sender, EventArgs e)
        {

        }

        private void editadminpagebutton_Click(object sender, EventArgs e)
        {
            receptionistHome obj = new receptionistHome();
            obj.Show();
            this.Hide();
        }

        private void import_Click(object sender, EventArgs e)
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
                MessageBox.Show("An error occured while uploading your image <3" + error.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            pictureBox2.ImageLocation = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/deafult_image.png";
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
                    pictureBox2.ImageLocation = imageLocation;
                    //MessageBox.Show(imageLocation);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured while uploading your image <3" + error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bedstextBox.Enabled = true;
            desctextBox.Enabled = true;
            pricetextBox.Enabled = true;
            comboBox1.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            editroom.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            string conn = "Data Source=orcl;User Id=scott;Password=tiger";
            string comstr = "SELECT * FROM ROOMS WHERE ROOM_NO=:room_no";
            adapter = new OracleDataAdapter(comstr, conn);
            adapter.SelectCommand.Parameters.Add("room_no", roomnumbertextBox.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            desctextBox.Text = ds.Tables[0].Rows[0]["description"].ToString();
            bedstextBox.Text = ds.Tables[0].Rows[0]["no_of_beds"].ToString();
            pricetextBox.Text = ds.Tables[0].Rows[0]["price_per_night"].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0]["room_view"].ToString();

            OracleCommand cmd = new OracleCommand("SELECT DISTINCT room_view FROM rooms", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
                comboBox1.Items.Add(dr[0].ToString());

            string availablity = ds.Tables[0].Rows[0]["available"].ToString().Replace("\\", "/");
            if (availablity == "yes")
            {
                radioButton1.Checked = true;

            }
            else if (availablity == "no")
            {
                radioButton2.Checked = true;
            }
            string x = ds.Tables[0].Rows[0]["photo"].ToString();
            Console.WriteLine(x);
            Console.WriteLine(x.Length);
            if (x.Length == 0)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                x = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/deafult_image.png";
            }
            pictureBox2.ImageLocation = x;
        }

        private void editroom_Click(object sender, EventArgs e)
        {
            try
            {
                //OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                //string conn = "Data Source=orcl;User Id=scott;Password=tiger";
                //string comstr = "UPDATE ROOMS SET DESCRIPTION=:description , NO_OF_BEDS=:no_of_beds , PRICE_PER_NIGHT=:price_per_night , ROOM_VIEW=:room_view , AVAILABLE=:available ,PHOTO=:photo WHERE ROOM_NO=:room_no ";
                //adapter = new OracleDataAdapter(comstr, conn);
                //adapter.SelectCommand.Parameters.Add("description", desctextBox.Text);
                //adapter.SelectCommand.Parameters.Add("no_of_beds", bedstextBox.Text);
                //adapter.SelectCommand.Parameters.Add("price_per_night", pricetextBox.Text);
                //adapter.SelectCommand.Parameters.Add("room_view", comboBox1.SelectedItem.ToString());
                //if (radioButton1.Checked)
                //{
                //    adapter.SelectCommand.Parameters.Add("available", "yes");
                //}
                //else if (radioButton2.Checked)
                //{
                //    adapter.SelectCommand.Parameters.Add("available", "no");
                //}
                //adapter.SelectCommand.Parameters.Add("photo", pictureBox2.ImageLocation);
                //adapter.SelectCommand.Parameters.Add("room_no", roomnumbertextBox.Text);
                //ds = new DataSet();
                //adapter.Fill(ds);
                ds.Tables[0].Rows[0]["description"] = desctextBox.Text;
                ds.Tables[0].Rows[0]["no_of_beds"] = bedstextBox.Text;
                ds.Tables[0].Rows[0]["price_per_night"] = pricetextBox.Text;
                ds.Tables[0].Rows[0]["room_view"] = comboBox1.Text;
                if (radioButton1.Checked)
                    ds.Tables[0].Rows[0]["available"] = "yes";
                else
                    ds.Tables[0].Rows[0]["available"] = "no";
                ds.Tables[0].Rows[0]["photo"] = pictureBox2.ImageLocation;
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds);
                //DataTable table = ds.Tables["ROOMS"];
                //table.Columns["ROOM_NO"].Unique = true;
                //adapter.Update(ds);

                MessageBox.Show("The room has been modified");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong , please try again!"+ex.Message);
            }
        }

        private void receptionEditRooms_FormClosed(object sender, FormClosedEventArgs e)
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

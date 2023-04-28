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

        private void fill_search()
        {
            try
            {
                string connStr = "Data Source=orcl;User Id=scott;Password=tiger";
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    string cmdStr = "Select * from rooms where room_no=:room_no";
                    OracleCommand cmd = new OracleCommand(cmdStr, conn);
                    cmd.Parameters.Add("room_no", roomnumbertextBox.Text);
                    adapter = new OracleDataAdapter(cmd);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    desctextBox.Text = ds.Tables[0].Rows[0]["description"].ToString();
                    bedstextBox.Text = ds.Tables[0].Rows[0]["no_of_beds"].ToString();
                    pricetextBox.Text = ds.Tables[0].Rows[0]["price_per_night"].ToString();
                    comboBox1.Text = ds.Tables[0].Rows[0]["room_view"].ToString();
                    string availablity = ds.Tables[0].Rows[0]["available"].ToString().Replace("\\", "/");
                    if (availablity == "yes")
                    {
                        radioButton1.Checked = true;

                    }
                    else if (availablity == "no")
                    {
                        radioButton2.Checked = true;
                    }
                    pictureBox2.ImageLocation = ds.Tables[0].Rows[0]["photo"].ToString();

                }
            }
            catch
            {
                MessageBox.Show("Error this room not found");
            }

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
            pictureBox2.ImageLocation = "C:/Users/ahmed/Downloads/add9c1dd-79ad-43cd-838c-dc2886010708.jpg";
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
            string comstr = "SELECT description , no_of_beds , price_per_night , room_view , AVAILABLE , PHOTO FROM ROOMS WHERE ROOM_NO=:room_no";
            adapter = new OracleDataAdapter(comstr, conn);
            adapter.SelectCommand.Parameters.Add("room_no", roomnumbertextBox.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            fill_search();
        }

        private void editroom_Click(object sender, EventArgs e)
        {
            try
            {
                //OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                string conn = "Data Source=orcl;User Id=scott;Password=tiger";
                string comstr = "UPDATE ROOMS SET DESCRIPTION=:description , NO_OF_BEDS=:no_of_beds , PRICE_PER_NIGHT=:price_per_night , ROOM_VIEW=:room_view , AVAILABLE=:available ,PHOTO=:photo WHERE ROOM_NO=:room_no ";
                adapter = new OracleDataAdapter(comstr, conn);
                adapter.SelectCommand.Parameters.Add("description", desctextBox.Text);
                adapter.SelectCommand.Parameters.Add("no_of_beds", bedstextBox.Text);
                adapter.SelectCommand.Parameters.Add("price_per_night", pricetextBox.Text);
                adapter.SelectCommand.Parameters.Add("room_view", comboBox1.SelectedItem.ToString());
                if (radioButton1.Checked)
                {
                    adapter.SelectCommand.Parameters.Add("available", "yes");
                }
                else if (radioButton2.Checked)
                {
                    adapter.SelectCommand.Parameters.Add("available", "no");
                }
                adapter.SelectCommand.Parameters.Add("photo", pictureBox2.ImageLocation);
                adapter.SelectCommand.Parameters.Add("room_no", roomnumbertextBox.Text);
                ds = new DataSet();
                adapter.Fill(ds);

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

using System;
using System.IO;
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
    public partial class EditUserInfo : Form
    {

        bool isPass;

        public EditUserInfo()
        {
            InitializeComponent();
        }

        private void EditUserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EditUserInfo_Load(object sender, EventArgs e)
        {
            isPass = true;
            sideBar.Hide();
            SSN_txt.Text = Program.user.ssn;
            f_name_txt.Text = Program.user.f_name;
            l_name_txt.Text = Program.user.l_name;
            email_txt.Text = Program.user.email;
            phone_number_txt.Text = Program.user.phone_number;
            password_txt.Text = Program.user.password;
            roundedPictureBox1.ImageLocation = Program.user.photo.Replace('\\', '/');
            password_txt.UseSystemPasswordChar = true;
        }

        private void L_name_label_Click(object sender, EventArgs e)
        {

        }

        private void roundedPictureBox3_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            roundedPictureBox1.ImageLocation = projectDirectory.Replace('\\', '/') + "/Hotel Booking System/" + "profile_deafult.jpeg";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            isPass = !isPass;
            if (isPass)
                password_txt.UseSystemPasswordChar = true;
            else
                password_txt.UseSystemPasswordChar = false;
        }

        private void roundedPictureBox2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imageLocation = dialog.FileName;
                    roundedPictureBox1.ImageLocation = imageLocation;
                    //MessageBox.Show(imageLocation);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong while uploading your photo, please try again");
            }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void phone_number_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_number_label_Click(object sender, EventArgs e)
        {

        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void l_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            menu_btn.Show();
            sideBar.Hide();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            sideBar.Show();
            menu_btn.Hide();
        }

        private void Search_sideBar_Click(object sender, EventArgs e)
        {
            Hide();
            Program.home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Program.user.update(f_name_txt.Text, l_name_txt.Text, phone_number_txt.Text, email_txt.Text, password_txt.Text, roundedPictureBox1.ImageLocation))
                MessageBox.Show("You Changes Saved Succefully");
            else
                MessageBox.Show("Something Went Wrong While Saving Your Changes, Please Try Again");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Hide();
            Program.sign_in.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Program.reservationslist.Show();
        }
    }
}

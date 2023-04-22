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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            head1.Parent = pictureBox1;
            head1.BackColor = Color.Transparent;
            head2.Parent = pictureBox1;
            head2.BackColor = Color.Transparent;
            //button2.UseVisualStyleBackColor = true;
            login_btn.Parent = pictureBox1;
            login_btn.BackColor = Color.FromArgb(125, Color.White);
            signup_btn.Parent = pictureBox1;
            signup_btn.BackColor = Color.FromArgb(125, Color.White);
            login_panel.Hide();
            register_panel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_panel.Hide();
            register_panel.Parent = pictureBox1;
            head1.Hide();
            head2.Hide();
            register_panel.BackColor = Color.FromArgb(125, Color.Black);
            register_panel.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            register_panel.Hide();
            login_panel.Parent = pictureBox1;
            head1.Hide();
            head2.Hide();
            login_panel.BackColor = Color.FromArgb(125, Color.Black);            
            login_panel.Show();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //register_panel.Height = this.Height - 130;
        }

        private void register_label_Click(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }
    }
}

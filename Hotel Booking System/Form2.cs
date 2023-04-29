using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Hotel_Booking_System;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        CrystalReport4 cr;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport4();
            //foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
            //    comboBox1.Items.Add(v.Value);
            OracleCommand cmd = new OracleCommand("SELECT DISTINCT no_of_beds FROM rooms", Program.conn);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int16.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("Please, enter valid data");
                return;
            }
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";
            cr.SetParameterValue(0, comboBox1.Text);
            FormulaFieldDefinitions formulaFields = cr.DataDefinition.FormulaFields;
            FormulaFieldDefinition myFormulaField = formulaFields["offer"];
            myFormulaField.Text = "{ROOMS.PRICE_PER_NIGHT} - {ROOMS.PRICE_PER_NIGHT}*" + Int16.Parse(textBox1.Text).ToString()+"/100";
            crystalReportViewer1.ReportSource = cr;
            textBox1.Text = Int16.Parse(textBox1.Text).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.sign_in.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Program.receptionisthome.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Hotel_Booking_System;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        CrystalReport1 crys;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            crys = new CrystalReport1();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTimePicker1.Value.Month).ToUpper(), y = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTimePicker2.Value.Month).ToUpper();
            string start_date = dateTimePicker1.Value.Day.ToString() + "-" + x + "-" + dateTimePicker1.Value.Year.ToString();
            string end_date = dateTimePicker2.Value.Day.ToString() + "-" + y + "-" + dateTimePicker2.Value.Year.ToString();
            crys.SetParameterValue(0, Convert.ToDateTime(start_date));
            crys.SetParameterValue(1, Convert.ToDateTime(end_date));
            crystalReportViewer1.ReportSource = crys;
        }
    }
}

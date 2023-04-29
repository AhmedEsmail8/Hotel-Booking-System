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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        CrystalReport3 crys;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            crys = new CrystalReport3();
            foreach (ParameterDiscreteValue v in crys.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crys.SetParameterValue(0, comboBox1.Text);
            crys.SetParameterValue(1, Convert.ToDateTime ( textBox1.Text));
            crys.SetParameterValue(2, Convert.ToDateTime ( textBox2.Text));

            crystalReportViewer1.ReportSource = crys;
        }
    }
}

﻿using System;
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
    public partial class Form1 : Form
    {
        CrystalReport1 cr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            cr.SetParameterValue(1, Convert.ToDateTime(textBox1.Text));
            cr.SetParameterValue(2, Convert.ToDateTime(textBox2.Text));
            crystalReportViewer1.ReportSource = cr;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

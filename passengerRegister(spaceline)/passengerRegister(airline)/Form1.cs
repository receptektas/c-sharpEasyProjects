﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passengerRegister_airline_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Travel Route : " + comboBox1.Text + " to " + comboBox2.Text+" on "+dateTimePicker1.Text+"  at  "+maskedTextBox2.Text);
            listBox1.Items.Add("Name Surname : " + textBox1.Text);
            listBox1.Items.Add("Citizen Number : " + maskedTextBox3.Text);
            listBox1.Items.Add("Phone Number : " + maskedTextBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fromWhere = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = fromWhere;
        }
    }
}

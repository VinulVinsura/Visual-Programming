﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <=40){
                textBox2.Text = "100 LKR per hours";
            }
            else{
                textBox2.Text = "150 LKR per hours";

            }
           
                
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

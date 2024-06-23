using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="win" && textBox2.Text=="win") {
                textBox3.Text = "Champion";
            }else if(textBox1.Text == "win" || textBox2.Text == "win")
            {
                textBox3.Text = "Attacker";
            }
            else
            {
                textBox3.Text = "Sportsman";
            }
        }
    }
}

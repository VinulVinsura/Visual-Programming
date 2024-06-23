using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String letter="";
            letter=textBox1.Text;
            switch (letter.ToLower())
            {
                case ("a") :
                    MessageBox.Show("The letter A is Vowal");
                    break;
                case ("e"):
                    MessageBox.Show("The letter E is Vowal");
                    break;
                case ("i"):
                    MessageBox.Show("The letter I is Vowal");
                    break;
                case ("o"):
                    MessageBox.Show("The letter O is Vowal");
                    break;
                case ("u"):
                    MessageBox.Show("The letter U is Vowal");
                    break;
                default:
                    MessageBox.Show("The letter is not a Vowal");
                    break;


            }
        }
    }
}

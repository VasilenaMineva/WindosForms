using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0")
            //{
            //    label3.Text = "null";
            //}
            //else if (textBox1.Text == "1")
            //{
            //    label3.Text = "one";
            //}
            //else if (textBox1.Text == "3")
            //{
            //    label3.Text = "three";
            //}
            //else if (textBox1.Text == "4")
            //{
            //    label3.Text = "four";
            //}
            //else if (textBox1.Text == "5")
            //{
            //    label3.Text = "five";
            //}
            //else if (textBox1.Text == "6")
            //{
            //    label3.Text = "six";
            //}
            //else if (textBox1.Text == "7")
            //{
            //    label3.Text = "seven";
            //}
            //else if (textBox1.Text == "8")
            //{
            //    label3.Text = "eight";
            //}
            //else if (textBox1.Text == "9")
            //{
            //    label3.Text = "nine";
            //}
            //else if (textBox1.Text == "10")
            //{
            //    label3.Text = "ten";
            //}
            //else
            //{
            //    textBox1.Text = label3.Text = "Error!";
            //    MessageBox.Show("Wrong-Enter wright number from 0-10", "Error",
            //             MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            switch (textBox1.Text)
            {
                case "0":
                    label3.Text = "null";
                    break;
                case "1":
                    label3.Text = "one";
                    break;
                case "2":
                    label3.Text = "two";
                    break;
                case "3":
                    label3.Text = "three";
                    break;
                case "4":
                    label3.Text = "four";
                    break;
                case "5":
                    label3.Text = "five";
                    break;
                case "6":
                    label3.Text = "six";
                    break;
                case "7":
                    label3.Text = "seven";
                    break;
                case "8":
                    label3.Text = "eight";
                    break;
                case "9":
                    label3.Text = "nine";
                    break;
                case "10":
                    label3.Text = "ten";
                    break;

                default:
                    label3.Text = "You entered something else!";
                    MessageBox.Show("Wrong-Enter wright number from 0-10", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

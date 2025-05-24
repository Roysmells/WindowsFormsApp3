using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1: Form
    {
        static int Score = 0;
        static int Question = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Text = "Selected";
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            label2.Text = Question + "/3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button9.Text = "Selected";
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button9.Text = "Selected";
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Question == 1)
            {
                richTextBox5.Text = "Incorrect, C# is an Object-Oriented Programming language";
                label2.Text = Question + 1 + "/3";
                richTextBox3.Text = "Variables are used to repeat sections of code multiple times";
                Question = 2;
            }
            else if (Question == 2)
            {
                Score += 1;
                label2.Text = Question + 1 + "/3";
                richTextBox5.Text = "Correct, variables are containers used to store data.";
                richTextBox3.Text = "If else statements are used to make sections of code run only under specific circumstances. ";
                Question = 3;
                label1.Text = Score + "";
            }
            else if (Question == 3)
            {
                Score += 1;
                label2.Text = Question + "/3";
                richTextBox5.Text = "Incorrect, if else statements are used to make sections of code run only under specific circumstances.";
                richTextBox3.Text = "You scored " + label1.Text + "/3";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Question == 1)
            {
                Score += 1;
                richTextBox5.Text = "Correct, C# is an Object-Oriented Programming language";
                label2.Text = Question + 1 + "/3";
                richTextBox3.Text = "Variables are used to repeat sections of code multiple times";
                label1.Text = Score + "";
                Question = 2;
            }
            else if (Question == 2)
            {
                richTextBox5.Text = "Incorrect, variables are containers used to store data.";
                label2.Text = Question + 1 + "/3";
                richTextBox3.Text = "If else statements are used to make sections of code run only under specific circumstances. ";
                Question = 3;
            }
            else if (Question == 3)
            {
                label2.Text = Question + "/3";
                richTextBox5.Text = "Correct, if else statements are used to make sections of code run only under specific circumstances.";
                label1.Text = Score + "";
                richTextBox3.Text = "You scored " + label1.Text + "/3";
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel4.Visible = false;
            panel3.Visible = false;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            panel1.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Incorrect";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Incorrect";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Correct";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Incorrect";
        }
    }
}

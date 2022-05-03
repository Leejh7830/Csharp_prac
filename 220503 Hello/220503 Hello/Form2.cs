using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220503_Hello
{
    public partial class Form2 : Form
    {
        public List<string> list { get; set; }
        public Form2()
        {
            InitializeComponent();
            list = new List<string>();
            label_numbers.Text = "";
            Random rand = new Random();
            button1.Text = rand.Next(1,100).ToString();
            button2.Text = rand.Next(1,100).ToString();
            button3.Text = rand.Next(1,100).ToString();
            button4.Text = rand.Next(1,100).ToString();
            button5.Text = button1.Text;
            button6.Text = button1.Text;
            button7.Text = button1.Text;
            button8.Text = button1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button5.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button6.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Remove(button7.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Remove(button8.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }
    }
}

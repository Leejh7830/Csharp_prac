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
    public partial class Form1 : Form
    {
        List<String> list = new List<String>();

        public Form1()
        {
            InitializeComponent();
            
            Random r = new Random();
            button1.Text = r.Next(1, 100).ToString();
            button5.Text = button1.Text;
            button2.Text = r.Next(1, 100).ToString();
            button6.Text = button2.Text;
            button3.Text = r.Next(1, 100).ToString();
            button7.Text = button3.Text;
            button4.Text = r.Next(1, 100).ToString();
            button8.Text = button4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            label_numbers.Text = "";
            foreach (String i in list)
            {
                label_numbers.Text = label_numbers.Text + " " + i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            label_numbers.Text = "";
            foreach (String i in list)
            {
                label_numbers.Text = label_numbers.Text + " " + i;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            label_numbers.Text = "";
            foreach (String i in list)
            {
                label_numbers.Text = label_numbers.Text + " " + i;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            label_numbers.Text = "";
            foreach (String i in list)
            {
                label_numbers.Text = label_numbers.Text + " " + i;
            }
        }
    }
}

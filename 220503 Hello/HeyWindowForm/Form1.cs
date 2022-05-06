using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyWindowForm
{
    public partial class Form1 : Form
    {
        public void sayHello()
        {
            MessageBox.Show("Hello!!");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void sayHello(object sender, EventArgs e)
        {
            sayHello();
        }
    }
}

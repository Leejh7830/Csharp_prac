using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");

            label_allBookCount.Text = DataManager.Books.Count.ToString(); // Load 호출
            label_allUserCount.Text = DataManager.Users.Count.ToString(); // static은 한번만 호출하기때문에 여기서는 Load호출안함
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageBook().ShowDialog();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUser().ShowDialog();
        }
    }
}

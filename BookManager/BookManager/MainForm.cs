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
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
            refreshScreen();
        }

        private void refreshScreen()
        {
            label_allBookCount.Text = DataManager.Books.Count.ToString(); // Load 호출
            label_allUserCount.Text = DataManager.Users.Count.ToString(); // static은 한번만 호출하기때문에 여기서는 Load호출안함
            
            // 대여된 책 수
            // label_allBorrowedBook.Text = DataManager.Books.Where(x => x.isBorrowed).Count().ToString();
            label_allBorrowedBook.Text =
                DataManager.Books.Where(delegate (Book x) { return x.isBorrowed; }).Count().ToString();

            // 연체된 책 수
            label_allDelayedBook.Text =
                DataManager.Books.Where(x => x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).Count().ToString();

            dataGridView_bookManager.DataSource = null;
            dataGridView_userManager.DataSource = null;
            if (DataManager.Books.Count > 0)
                dataGridView_bookManager.DataSource = DataManager.Books;
            if (DataManager.Users.Count > 0)
                dataGridView_userManager.DataSource = DataManager.Users;
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");

        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show 창만띄우고 순서대로 다음코드실행, 다른창 클릭가능
            // showDialog 창닫으면 다음코드실행, 다른창 클릭불가
            new ManageBook().ShowDialog();
            refreshScreen();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUser().ShowDialog();
        }
    }
}

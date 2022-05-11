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

            dataGridView_bookManager.CellClick += delegate (object s, DataGridViewCellEventArgs e)
            {
                Book book = dataGridView_bookManager.CurrentRow.DataBoundItem as Book;
                textBox_isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;
            };

            dataGridView_userManager.CellClick += (s, e) =>
            {
                User user = dataGridView_userManager.CurrentRow.DataBoundItem as User;
                textBox_id.Text = user.Id.ToString();
            };

            // 대여
            button_borrow.Click += Button_borrow_Click;

            // 반납
            button_return.Click += Button_return_Click;

            refreshScreen();
        }

        private void Button_return_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (textBox_isbn.Text.Trim() == "") // Trim : 양 옆 공백제거
                MessageBox.Show("isbn 입력");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single(x => x.Isbn == textBox_isbn.Text);
                    if (book.isBorrowed)
                    {
                        DateTime oldDay = book.BorrowedAt; // 연체여부체크
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        DataManager.Save();
                        refreshScreen();

                        // 연체체크
                        TimeSpan timeDiff = DateTime.Now - oldDay;
                        if (timeDiff.Days > 7)
                            MessageBox.Show(book.Name+"은 연체 상태로 반납");
                        else
                            MessageBox.Show(book.Name+"은 정상 반납");
                    } 
                    else 
                    {
                        MessageBox.Show("대여 상태아닙니다.");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("없는 책입니다.");
                }
            }
        }

        private void Button_borrow_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (textBox_isbn.Text.Trim() == "") // Trim : 양 옆 공백제거
                MessageBox.Show("isbn 입력");
            else if (textBox_id.Text.Trim() == "")
                MessageBox.Show("id 입력");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single(x => x.Isbn == textBox_isbn.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("이미 빌림!!");
                        return;
                    }
                    //
                    User user = DataManager.Users.Single(x=>x.Id.ToString() == textBox_id.Text);
                    book.UserId = user.Id;
                    book.UserName = user.Name;
                    book.isBorrowed = true;
                    book.BorrowedAt = DateTime.Now;
                    DataManager.Save();

                    refreshScreen();
                    MessageBox.Show($"{book.Name}은 {user.Name}님께 대여됨");
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서나 사용자");
                }
            }
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
            refreshScreen();
        }
    }
}

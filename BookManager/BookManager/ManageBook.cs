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
    public partial class ManageBook : Form
    {
        public ManageBook()
        {
            InitializeComponent();
            if (DataManager.Books.Count > 0)
                dataGridView_books.DataSource = DataManager.Books;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Isbn 겹치지 않게
            // 1. foreach 문 사용
            bool isExist = false;
            foreach (var item in DataManager.Books)
            {
                if (item.Isbn == textBox_isbn.Text)
                {
                    isExist = true;
                    break;
                }
            }
            if (isExist) // true 이면, => 같은 책이 있다면
            {
                MessageBox.Show("해당 ISBN은 이미 존재합니다.");
                return;
            }
            // 2. single 메소드 사용가능

            Book book = new Book();
            book.Isbn = textBox_isbn.Text;
            book.Name = textBox_bookName.Text;
            book.Publisher = textBox_publisher.Text;
            book.Page = int.Parse(textBox_page.Text);
            DataManager.Books.Add(book);

            dataGridView_books.DataSource = null;
            dataGridView_books.DataSource = DataManager.Books;
            DataManager.Save();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            Book book = null;
            for (int i=0; i<DataManager.Books.Count; i++)
            {
                if (DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    book = DataManager.Books[i];
                    book.Name = textBox_bookName.Text;
                    book.Publisher= textBox_publisher.Text;
                    book.Page= int.Parse(textBox_page.Text);

                    dataGridView_books.DataSource = null;
                    dataGridView_books.DataSource = DataManager.Books;
                    DataManager.Save();
                    break;
                }
                    
            }
            if (book == null)
                MessageBox.Show("존재하지 않는 도서입니다.(수정불가능)");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            for (int i=0; i<DataManager.Books.Count;i++)
            {
                if (DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    DataManager.Books.RemoveAt(i);
                    isExist = true;
                    break;
                }
            }
            if(isExist == false)
                MessageBox.Show("없는 책입니다.");
            else
            {
                dataGridView_books = null;
                if (DataManager.Books.Count > 0)
                {
                    dataGridView_books.DataSource = DataManager.Books;
                }
                DataManager.Save();
            }

        }

        private void dataGridView_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 뷰에있는정보 텍스트박스로 가져오기
            Book book = dataGridView_books.CurrentRow.DataBoundItem as Book; // Book타입으로 변환
            textBox_isbn.Text = book.Isbn;
            textBox_bookName.Text = book.Name;
            textBox_publisher.Text = book.Publisher;
            textBox_page.Text = book.Page.ToString();
        }
    }
}

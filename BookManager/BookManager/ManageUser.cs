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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
            if (DataManager.Users.Count > 0)
                dataGridView_Users.DataSource = DataManager.Users;

            dataGridView_Users.CellClick += DataGridView_Users_CellClick;
        }

        private void DataGridView_Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User click_user = dataGridView_Users.CurrentRow.DataBoundItem as User;
            textBox_id.Text = click_user.Id.ToString();
            textBox_name.Text = click_user.Name;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox_id.Text) == 0)
            {
                MessageBox.Show("잘못된 ID (zero)");
                return;
            }

            // 해당 id존재하는지 체크(Exists)
            if (DataManager.Users.Exists(x => x.Id == int.Parse(textBox_id.Text)))
            {
                MessageBox.Show("해당 ID 이미 존재");
            } else
            {
                User add_user = new User() {  Id= int.Parse(textBox_id.Text),Name=textBox_name.Text };
                DataManager.Users.Add(add_user);
                dataGridView_Users.DataSource = null;
                dataGridView_Users.DataSource = DataManager.Users;
                DataManager.Save();
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            // Single사용(List에서 조건을 만족하는 인스턴스 하나를 가리킴)
            // 조건만족하는게 List안에 없으면 catch로 빠짐
            try
            {
                User mod_user = DataManager.Users.Single(x => x.Id == int.Parse(textBox_id.Text));
                mod_user.Name = textBox_name.Text;
                // 만약에 해당 유저가 책을 빌렸다면, Books의 userName도 바꿔야함
                try
                {
                    Book mod_book = DataManager.Books.Single(x => x.UserId == int.Parse(textBox_id.Text));
                    mod_book.UserName = textBox_name.Text;
                }
                catch (Exception) // 안빌린경우
                {
                }
                dataGridView_Users.DataSource = null;
                dataGridView_Users.DataSource = DataManager.Users;
                DataManager.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("이 아이디는 없는 유저입니다.");
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                User del_user = DataManager.Users.Single(x => x.Id == int.Parse(textBox_id.Text));
                // 없으면 catch로 이동
                // 있으면 진행
                DataManager.Users.Remove(del_user);
                dataGridView_Users.DataSource = null;
                if (DataManager.Users.Count > 0)
                    dataGridView_Users.DataSource = DataManager.Users;
                DataManager.Save();

            }
            catch (Exception)
            {
                MessageBox.Show("해당 사용자 없음");
            }
        }
    }
}

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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name="일일일", grade=1 });
            students.Add(new Student() { name="이이이", grade=2 });
            students.Add(new Student() { name="삼삼삼", grade=3 });
            students.Add(new Student() { name="사사사", grade=4 });
            students.Add(new Student() { name="일학년", grade=1 });
            students.Add(new Student() { name="이학년", grade=2 });
            students.Add(new Student() { name="삼학년", grade=2 });

            for(int i=0; i<students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년, {students[i].name} 학생";
                label.AutoSize = true;
                label.Location = new Point(13, 13 + (23 + 3)  * i);
                Controls.Add(label);
            }

            for(int i=students.Count-1; i>=0; i--)
            {
                if (students[i].grade > 1) // 1학년만
                {
                    students.RemoveAt(i); // i번째 제거
                    // Remove(i)는 i와 같은 값 제거
                }
            }

            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년, {students[i].name} 학생";
                label.AutoSize = true;
                label.Location = new Point(130, 13 + (23 + 3) * i);
                Controls.Add(label);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SortedSet => 중복제거,정렬
            List<int> numbers = new List<int>();
            for(int i=0; i<7; i++)
            {
                Random r = new Random();
                int num = r.Next(1, 46);
                if(numbers.Contains(num))
                {
                    i--;
                } else
                {
                    numbers.Add(num);
                }
            }
            numbers.Sort();
            label1.Text = " ";
            foreach (var item in numbers)
            {
                label1.Text += item + " ";
            }
        }
    }
}

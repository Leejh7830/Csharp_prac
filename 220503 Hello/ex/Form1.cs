using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class Form1 : Form
    {
        enum 가위바위보
        {
            가위,바위,보
        }
        int num;
        public Form1()
        {
            InitializeComponent();
            num = new Random().Next(1, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(textbox_num1.Text);
            if(answer == num)
            {
                MessageBox.Show("정답!");
                num = new Random().Next(1, 10); // 1 ~ 9
                Console.WriteLine("정답:" + num);
            } else
            {
                MessageBox.Show("정답은 " + num + "입니다.");
            }
        }

        private void button_gawi_Click(object sender, EventArgs e)
        {
            // 0=가위, 1=바위, 2=보
            int computer = new Random().Next(3); // 0 1 2
            Console.WriteLine(computer);

            switch (computer)
            {
                case 0:
                    MessageBox.Show("비김");
                    break;
                case 1:
                    MessageBox.Show("짐");
                    break;
                case 2:
                    MessageBox.Show("이김");
                    break;
                default:
                    break;
            }
        }

        private void button_bawi_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);
            string[] rsp = new string[] { "가위", "바위", "보" };
            string computerResult = rsp[computer];
            switch (computerResult)
            {
                case "가위":
                    MessageBox.Show("이김");
                    break;
                case "바위":
                    MessageBox.Show("비김");
                    break;
                case "보":
                    MessageBox.Show("짐");
                    break;
                default:
                    break;
            }
        }

        private void button_bo_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);
            switch (computer)
            {
                case (int)가위바위보.가위:
                    MessageBox.Show("짐");
                    break;
                case (int)가위바위보.바위:
                    MessageBox.Show("이김");
                    break;
                case (int)가위바위보.보:
                    MessageBox.Show("비김");
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sentense = new string[] {"안녕","하이","잘가","굿나잇","고마워","미안해"};
            List<string> sentenseList = new List<string>();
            sentenseList.Add("좋은 아침");
            sentenseList.Add("좋은 점심");
            sentenseList.Add("좋은 저녁");

            string s = sentense[new Random().Next(sentense.Length)];
            string s2 = sentenseList[new Random().Next(sentenseList.Count)];

            label_num3.Text = s + Environment.NewLine + s2;
            // Environment = \n 개행
        }
    }
}

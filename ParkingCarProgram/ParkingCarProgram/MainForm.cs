using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCarProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                //프로그램을 시작하면 가장 첫번째 주차공간에 있는 정보를 적음
                textBox_parkinSpot.Text = DataManager.Cars[0].ParkingSpot.ToString(); // 여기서 static DataManager 호출
                textBox_carNumber.Text = DataManager.Cars[0].CarNumber;
                textBox_driverName.Text = DataManager.Cars[0].DriverName;
                textBox_phoneNumber.Text = DataManager.Cars[0].PhoneNumber;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            // dataGridView의 DataSource 변경
            if (DataManager.Cars.Count > 0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;

            // 아래쪽 현재 시간 표시
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH mm분 ss초");


            // 주차공간 추가
            button_add.Click += delegate (object s, EventArgs e)
            {

                if (int.TryParse(textBox_spotNumber.Text, out int parkingSpot)==false)
                {
                    MessageBox.Show("주차공간번호는 숫자여야 합니다.");
                    return;
                }
                if (parkingSpot <= 0)
                {
                    MessageBox.Show("주차공간번호는 1이상이어야 합니다.");
                    return;
                }
                string contents = string.Empty;
                if (DataManager.Save("insert",parkingSpot, out contents))
                    button_refresh.PerformClick();
                WriteLog(contents);
            };

            // 주차공간 삭제
            button_remove.Click += (s, e) =>
            {
                int parkingSpot=0;
                if (int.TryParse(textBox_spotNumber.Text, out parkingSpot) == false)
                {
                    MessageBox.Show("주차공간번호는 숫자여야 합니다.");
                    return;
                }
                if (parkingSpot <= 0)
                {
                    MessageBox.Show("주차공간번호는 1이상이어야 합니다.");
                    return;
                }
                string contents = string.Empty;
                if (DataManager.Save("delete", parkingSpot, out contents))
                    button_refresh.PerformClick();
                WriteLog(contents);
            };
        }




        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH mm분 ss초");
        }

        private void WriteLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")}]{contents}";
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPrint.Items.Insert(0, logContents); // 최신내용이 위로 올라감, 0 안적으면 반대
            
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            if (DataManager.Cars.Count > 0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;
        }
    }
}

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
                textBox_parkingSpot.Text = DataManager.Cars[0].ParkingSpot.ToString(); // 여기서 static DataManager 호출
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
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")}] {contents}";
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
        
        private void dataGridView_parkingManager_CellClick(object sender, DataGridViewCellEventArgs e)
            //그리드뷰 정보 가져오기
        {
            ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;
            textBox_parkingSpot.Text = car.ParkingSpot.ToString();
            textBox_carNumber.Text = car.CarNumber;
            textBox_driverName.Text = car.DriverName;
            textBox_phoneNumber.Text = car.PhoneNumber;
        }

        private void button_parking_Click(object sender, EventArgs e)
        {
            if (textBox_parkingSpot.Text.Trim()=="")
                MessageBox.Show("주차공간번호 입력하세요");
            else if (textBox_carNumber.Text.Trim()=="")
                MessageBox.Show("차량번호 입력하세요");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single(x => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);
                    if (car.CarNumber.Trim()!="")
                        MessageBox.Show("이미 해당 공간에 차가 있음");
                    else
                    {
                        car.CarNumber = textBox_carNumber.Text;
                        car.DriverName = textBox_driverName.Text;
                        car.PhoneNumber = textBox_phoneNumber.Text;
                        car.ParkingTime = DateTime.Now;

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.Save(car.ParkingSpot, car.CarNumber, car.DriverName, car.PhoneNumber); //주차
                        string contents = $"주차공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text}차를 주차했습니다.";
                        WriteLog(contents); 
                    }
                }
                catch (Exception)
                {
                    string contents = $"주차공간 {textBox_parkingSpot.Text}은/는 없습니다.";
                    WriteLog(contents);
                }
            }
        }

        private void button_parkExit_Click(object sender, EventArgs e)
        {
            if (textBox_parkingSpot.Text.Trim() == "")
                MessageBox.Show("주차공간번호 입력하세요");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single(x => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);
                    if (car.CarNumber=="")
                    {
                        WriteLog(car.ParkingSpot + "에 이미 차가 없습니다.");
                        return;
                    }

                    string oldCar = car.CarNumber; // 주차되었던 차
                    car.CarNumber = "";
                    car.DriverName = "";
                    car.PhoneNumber = "";
                    car.ParkingTime = new DateTime();

                    dataGridView_parkingManager.DataSource = null;
                    dataGridView_parkingManager.DataSource = DataManager.Cars;

                    DataManager.Save(car.ParkingSpot, car.CarNumber, car.DriverName, car.PhoneNumber,true); // 출차
                    string contents = $"주차공간 {textBox_parkingSpot.Text}에 {oldCar}차를 출차했습니다.";
                    WriteLog(contents);
                }
                catch (Exception)
                {
                    string contents = $"주차공간 {textBox_parkingSpot.Text}은/는 없습니다.";
                    WriteLog(contents);
                }
            }
        }
        private void button_find_Click(object sender, EventArgs e)
        {
            try
            {
                int parkingSpot = int.Parse(textBox_spotNumber.Text);
                string ParkingCar = findParkingCar(parkingSpot);
                string contents;
                if (ParkingCar == "해당 주차공간 없음!")
                {
                    contents = $"해당 주차공간은 존재하지 않습니다. ({parkingSpot})";
                }
                else if (ParkingCar != "")
                {
                    contents = $"해당 주차공간 {parkingSpot}에 주차된 차는 {ParkingCar}입니다.";
                }
                else
                {
                    contents = $"주차공간 {parkingSpot}에는 주차된 차가 없습니다.";
                }
                WriteLog(contents);
            }
            catch (Exception)
            {

            }
            
        }

        private string findParkingCar(int parkingSpot)
        {
            foreach (var item in DataManager.Cars)
            {
                if (item.ParkingSpot == parkingSpot)
                    return item.CarNumber;
            }
            return "해당주차공간 없음";
        }


    }
}

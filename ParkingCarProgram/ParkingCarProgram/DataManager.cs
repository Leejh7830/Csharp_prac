using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarProgram
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();
        }

        public static void PrintLog(String contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory"); // 폴더명
            if (!di.Exists)
            {
                di.Create(); // 해당 폴더가 없으면 생성
            }
            // using : 구문이 끝나면 Dispose함. 메모리를 destroy(삭제), 1회용
            // 끝의 true : append를 true로 설정. 덮어쓰지않고 뒤에 추가
            // false이거나 생략될경우 txt에 새로 들어온 내용만 있고 나머진 지워짐(덮어씌워짐)
            using(StreamWriter wirter = new StreamWriter(@"ParkingHistory\ParkingHistory.txt",true))
            {
                wirter.WriteLine(contents);
            }
        }

        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear(); // 기존 내용 지우기
                foreach (DataRow item in DBHelper.dt.Rows)
                {
                    ParkingCar temp = new ParkingCar();
                    temp.ParkingSpot = int.Parse(item["ParkingSpot"].ToString());
                    temp.CarNumber = item["CarNumber"].ToString();
                    temp.DriverName = item["DriverName"].ToString();
                    temp.PhoneNumber = item["PhoneNumber"].ToString();
                    // ParkingTime이 null일 경우 ToString하면 ""이 나옴
                    // 그러면 new DateTime() -0001년도.. 이런값을 넣어주고(기본값)
                    // 그게 아니면 현재 날짜를 집어넣음 (삼항연산자)
                    temp.ParkingTime = item["ParkingTime"].ToString() == "" 
                        ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());
                    Cars.Add(temp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        // update(주차,출차용) save
        public static void Save(int parkingSpot, string carNumber, string driverName, string phoneNumber, bool isRemove=false)
        {
            try
            {
                DBHelper.updateQuery(parkingSpot, carNumber, driverName, phoneNumber, isRemove);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                PrintLog(ex.StackTrace); // 오류 내용을 ParkingHistory.txt에 작성
            }
        }
        // 주차공간 추가/삭제용 save
        public static bool Save(string keyword, int parkingSpot, out string contents)
        {
            DBHelper.selectQuery(parkingSpot); // 특정 공간 조회
            contents = "";
            if (keyword == "insert")
                return DBInsert(parkingSpot, ref contents);
            else
                return DBDelete(parkingSpot, ref contents);
        }

        private static bool DBDelete(int parkingSpot, ref string contents)
        {
            if (DBHelper.dt.Rows.Count!=0) // 주차공간이 존재할 경우
            {
                DBHelper.deleteQuery(parkingSpot);
                contents = $"주차공간 {parkingSpot}이/가 삭제 되었습니다.";
                return true; // 삭제성공
            }
            else // 해당 공간이 없는 경우
            {
                contents = $"{parkingSpot} 번호 아직 없음";
                    return false;
            }
        }

        private static bool DBInsert(int parkingSpot, ref string contents)
        {
            if (DBHelper.dt.Rows.Count==0) // 빈자리있음
            {
                DBHelper.insertQuery(parkingSpot);
                contents = $"주차공간 {parkingSpot}이/가 추가 되었습니다.";
                return true; // 추가성공
            }
            else
            {
                contents = $"{parkingSpot} 주차공간 이미 존재함";
                return false;
            }
        }
    }
}

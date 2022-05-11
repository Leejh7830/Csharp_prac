using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarProgram
{
    // DB연결
    public class DBHelper
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        private static void ConnectDB()
        {
            conn.ConnectionString
                = "Data Source=(local); initial Catalog=MyCarManagerDB; " +
                "integrated Security=SSPI;" +
                "Timeout=3";
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }
        // 메소드를 2가지 방식으로 호출하기
        // selectQuery() > 매개변수 없이 호출하면 parkingSpot에 -1이 들어간다.
        // selectQuery(num) 숫자넣으면 parkingSpot에 num이 들어간다.
        public static void selectQuery(int parkingSpot=-1)
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                if (parkingSpot == -1)
                    cmd.CommandText = "select * from ParkingCar";
                else
                    cmd.CommandText = "select * from ParkingCar where ParkingSpot=" + parkingSpot;

                da = new SqlDataAdapter(cmd); // SqlDataAdapter를 통해서 결과를 구함
                ds = new DataSet();
                da.Fill(ds, "ParkingCar"); // SqlDataAdapter를 통해 DataSet에 결과저장
                dt = ds.Tables[0]; // DataTable에 결과 중 하나를 저장
                // 지금은 select문이 하나라서 Tables에도 하나의 결과만 저장
                // 여러개를 ds에 저장할 수도 있음. 그 경우에는 Tables의 길이가 늘어남
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("select 오류");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Close(); // ★DB는 반드시 닫아야 한다.
            }
        }

        // 주차 공간 추가
        public static void insertQuery(int parkingSpot)
        {
            try
            {
                ConnectDB();
                string sqlcommand = "insert into ParkingCar (parkingSpot) values(@p1)";
                // SQL injection(sql문 공격) 방지하기 위해 @p1 파라메터 사용
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", parkingSpot);
                cmd.CommandText=sqlcommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("insert 오류");
            }
            finally 
            { 
                conn.Close ();
            }
        }

        // 주차 공간 삭제
        public static void deleteQuery(int parkingSpot)
        {
            try
            {
                ConnectDB();
                string sqlcommand = "delete from ParkingCar where ParkingSpot=@p1";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", parkingSpot);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("delete 오류");
            }
            finally
            {
                conn.Close();
            }
        }

        public static void updateQuery(int parkingSpot, string carNumber,
            string driverName, string phoneNumber, bool isRemove=false)
        {
            try
            {
                ConnectDB();
                string sqlcommand;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                if (isRemove) // 출차
                {
                    sqlcommand = "update ParkingCar set carNumber='',driverName='',phoneNumber=''," +
                        " Parkingtime=null where ParkingSpot=@p1";
                    cmd.Parameters.AddWithValue("@p1", parkingSpot);
                }
                else // 주차
                {
                    sqlcommand = "update ParkingCar set carNumber=@p1, driverName=@p2, phoneNumber=@p3," +
                        " Parkingtime=@p4 where ParkingSpot=@p5";
                    cmd.Parameters.AddWithValue("@p1", carNumber);
                    cmd.Parameters.AddWithValue("@p2", driverName);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now.ToString("yyyy-MM-DataSetDateTime HH:MissingMappingAction:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSpot);
                }
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("update 오류");
            }
        }
    }
}

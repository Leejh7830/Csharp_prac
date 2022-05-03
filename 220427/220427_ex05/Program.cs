using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220427_ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 태어난 연도 입력 -> 띠 출력
            Console.WriteLine("태어난 연도를 입력하세요");
            int year = int.Parse(Console.ReadLine());
            switch (year)
            {
                case 1990:case 2002:
                    Console.WriteLine("말 입니다.");
                    break;
                case 1991:case 2003:
                    Console.WriteLine("양 입니다.");
                    break;
                case 1992:case 1980:
                    Console.WriteLine("원숭이 입니다.");
                    break;
                case 1993:case 1981:
                    Console.WriteLine("닭 입니다.");
                    break;
                case 1994:case 1982:
                    Console.WriteLine("개 입니다.");
                    break;
                case 1995:case 1983:
                    Console.WriteLine("돼지 입니다.");
                    break;
                case 1996:case 1984:
                    Console.WriteLine("쥐 입니다.");
                    break;
                case 1997:case 1985:
                    Console.WriteLine("소 입니다.");
                    break;
                case 1998:case 1986:
                    Console.WriteLine("호랑이 입니다.");
                    break;
                case 1999:case 1987:
                    Console.WriteLine("토끼 입니다.");
                    break;
                case 2000:case 1988:
                    Console.WriteLine("용 입니다.");
                    break;
                case 2001:case 1989:
                    Console.WriteLine("뱀 입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
            Console.WriteLine("-------------------------------");
            // 2. 월 입력 -> 계절 출력
            Console.WriteLine("월(月) 입력하세요");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12: case 1: case 2:
                    Console.WriteLine("겨울 입니다.");
                    break;
                case 3: case 4: case 5:
                    Console.WriteLine("봄 입니다.");
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine("여름 입니다.");
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine("가을 입니다.");
                    break;
                default :
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
            Console.WriteLine("-------------------------------");
            // 3. 나이 입력 -> 결과 출력
            Console.WriteLine("나이를 입력하세요");
            int age = int.Parse(Console.ReadLine());
            int count = 0;
            if(age>=0 && age<20)
            {
                count = 1;
            } else if (age>21 && age < 40)
            {
                count = 2;
            } else if (age>39 && age < 60)
            {
                count = 3;
            } else if (age>59 && age <150)
            {
                count = 4;
            } else if (age>149)
            {
                count = 5;
            } else {
                Console.WriteLine("잘못된 입력입니다.(if)");
            }
            switch (count)
            {
                case 1:
                    Console.WriteLine("아이 입니다.");
                    break;
                case 2:
                    Console.WriteLine("젊은이 입니다.");
                    break;
                case 3:
                    Console.WriteLine("중년 입니다.");
                    break;
                case 4:
                    Console.WriteLine("노인 입니다.");
                    break;
                case 5:
                    Console.WriteLine("외계인 입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.(switch)");
                    break;
            }
        }
    }
}

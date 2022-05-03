using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220427_ex05_정답
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //내가 태어난 연도를 입력하고 그에 따른 띠를 출력
            Console.WriteLine("몇년도에 태어나셨나요?");
            int thee = int.Parse(Console.ReadLine());

            //띠는 12개가 무한반복함
            //쥐 소 호랑이 토끼 / 용 뱀 말 양 /원숭이 닭 개 돼지
            //1989%12 => 9 => 뱀
            //서기 1년 -> 닭띠
            //12로 나눴을 때 0인 경우 : 원숭이
            switch (thee % 12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;
                case 4:
                    Console.WriteLine("쥐");
                    break;
                case 5:
                    Console.WriteLine("소");
                    break;
                case 6:
                    Console.WriteLine("호랑이");
                    break;
                case 7:
                    Console.WriteLine("토끼");
                    break;
                case 8:
                    Console.WriteLine("용");
                    break;
                case 9:
                    Console.WriteLine("뱀");
                    break;
                case 10:
                    Console.WriteLine("말");
                    break;
                case 11:
                    Console.WriteLine("양");
                    break;
                default:
                    Console.WriteLine(thee); //혹시 몰라서 넣어둠... 이리로 올 일 없음
                    break;
            }

        }

    }
}
}

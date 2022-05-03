using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("나이를 입력하세요");
            int age = int.Parse(Console.ReadLine())-1;
            int myYear = DateTime.Now.Year - age;
            Console.WriteLine("당신이 태어난 연도 : " + myYear);
            string[] thees = new string[] { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };
            Console.WriteLine(thees[myYear%12]);
            */
            Console.WriteLine("---------------------------");

            int sum = 0;
            for (int i =1; i<=100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.WriteLine("---------------------------");

            for(char c='가'; c<='힣'; c++)
            {
                Console.Write(c);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220427_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("변환하려는 inch를 입력하세요.");
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine("변환 : " + cm + " cm");
            Console.WriteLine("----------------------------");
            Console.WriteLine("변환하려는 kg을 입력하세요.");
            double kg = double.Parse(Console.ReadLine());
            double pound = kg * 2.20462262;
            Console.WriteLine("변환 : " + pound + " pound");
            Console.WriteLine($"{kg}kg = {kg*2.20462262} pound");
            Console.WriteLine("----------------------------");
            Console.WriteLine("반지름(r)을 입력하세요.");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("입력된 반지름(r) = " + r);
            const double PI = 3.14;
            double 둘레 = 2 * PI * r;
            double 넓이 = PI * r * r;
            Console.WriteLine("둘레 = " + 둘레);
            Console.WriteLine("넓이 = " + 넓이);

            Console.WriteLine("----------------------------");

            Console.WriteLine("첫번째 숫자 입력하세요.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자 입력하세요.");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 * (num2%10)); // 첫번째 x 두번째 일의자리
            Console.WriteLine(num1 * ((num2/10)%10)); // 첫번째 x 두번째 십의자리
            Console.WriteLine(num1*(num2/100)); // 첫번째 x 두번째 백의자리
            Console.WriteLine(num1*num2); // 첫번째 x 두번째

            Console.WriteLine("----------------------------");

            string num2Str = num2 + "";
            Console.WriteLine(num1 * (num2Str[2]-'0'));
            Console.WriteLine((num1 * (Char.GetNumericValue(num2Str[1]))));
            Console.WriteLine((num1 * (Char.GetNumericValue(num2Str[0]))));
            Console.WriteLine(num1 * int.Parse(num2Str));
            
        }
    }
}

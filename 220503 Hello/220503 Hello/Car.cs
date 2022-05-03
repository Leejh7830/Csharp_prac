using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220503_Hello
{
    internal class Car
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }

        public Car()
        {
            Console.WriteLine("자동차 만들기...");
        }


    }
}

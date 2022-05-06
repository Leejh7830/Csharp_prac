using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Student
    {
        public Student() { }
        public Student(string Name, int Age, string Hakbeon)
        {
            this.Name = Name;
            this.Age = Age;
            this.Hakbeon = Hakbeon;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hakbeon { get; set; }
        
        public void introduce()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("나이 : " + Age);
            Console.WriteLine("학번 : " + Hakbeon);
        }

        public void Study()
        {
            Console.WriteLine("공부를 열심히 하자!");
        }
    }
}

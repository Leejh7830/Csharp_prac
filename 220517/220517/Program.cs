using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220517
{
    public class FactoryRobot : Robot
    {
        
        public override void eStop()
        {
            Console.WriteLine("윙윙.. 동작 정지");
        }
    }
}

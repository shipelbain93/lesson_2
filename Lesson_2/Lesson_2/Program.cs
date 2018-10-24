using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Hourly_pay>
            {
                new Hourly_pay("Misha",10000,1.5m),
                new Hourly_pay("Alisha",2000,2.5m),
                new Hourly_pay("Peter",3000,3.5m)
            };
            foreach(Hourly_pay h in list)
            {
                Console.WriteLine(h);
            }
            Hourly_pay s = new Hourly_pay("Sasha",15000,1.5m);

            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Fixed_fee : Worker//Фиксированная оплата
    {
        public Fixed_fee(string name, decimal salary, decimal baserate) : base(name, salary, baserate)
        {

        }
        public override void Calculate()
        {
            Averge_Salary *= BaseRate;
        }
    }
}
 
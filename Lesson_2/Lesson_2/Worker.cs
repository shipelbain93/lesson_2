using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
   abstract class Worker
    {
        public string Name{get; set;}
        public decimal Averge_Salary { get; set; }
        public decimal BaseRate{ get; set; }

        public Worker(string name,decimal averge_salary,decimal baserate)
        {
            Name = name;//Имя
            Averge_Salary = averge_salary;//среднемесячная зарплата
            BaseRate = baserate;//начальная ставка
        }
        public abstract void Calculate();//Счет зарплаты

        public override string ToString()
        {
            return string.Format("Name{0},Salary{1},BaseRate{2}", Name, Averge_Salary, BaseRate);
        }
        
       
        

    }
}

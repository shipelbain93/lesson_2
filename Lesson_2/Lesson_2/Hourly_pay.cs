using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Hourly_pay:Worker//Почасовая оплата
    {
        public Hourly_pay(string name,decimal salary,decimal baserate):base (name,salary,baserate)
        {
            Calculate();
        }
        public override void Calculate()
        {
            Averge_Salary *= BaseRate;
        }
        #region
        public override void mas(string[] sotrud)
        {
            string[] sa = new string[20];
            Console.WriteLine("Введите имена сотрудников");
            for (int i = 0; i < sa.Length; i++)
            {
                string consol=Console.ReadLine();
                sa[i] = consol;
                
            }
            
        }
        #endregion //заполнение массива

    }
}

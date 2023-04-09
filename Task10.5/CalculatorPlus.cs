using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._5
{
    internal class CalculatorPlus:ICalc
    {
        IHelper helper { get; }
        public CalculatorPlus(Helper helper)
        {
            this.helper = helper;
            helper.HelpMessage("введите число1");
            try
            {
                helper.ReadConsoleNum1();
            }
            catch (Exception)
            {

                Console.WriteLine(new MyExeption("нужно вводть число"));
            }
            helper.HelpMessage("введите число 2");
            try
            {
                helper.ReadConsoleNum2();
            }
            catch (Exception)
            {

                Console.WriteLine(new MyExeption("нужно вводть число"));
            }
        }

        public void Calc()
        {
            //double result = num1 + num2;
            //Console.WriteLine(result);
        }
    }
}

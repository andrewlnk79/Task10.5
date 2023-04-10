using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._5
{
    internal class CalculatorPlus : ICalc
    {
        int num1 { get; set; }
        int num2 { get; set; }
        
        IHelper Helper { get; }
        public CalculatorPlus(IHelper helper)
        {
           Helper = helper;


        }



        public void Calc()
        {
            Helper.HelpMessage("введите число1");
           
                Helper.ReadConsoleNum1();



            Helper.HelpMessage("введите число2");

            Helper.ReadConsoleNum2();
           
            
            Helper.Operation(num1, num2);
                
               
            }
    }
}

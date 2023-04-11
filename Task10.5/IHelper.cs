using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._5
{
    public interface IHelper
    {
        int num1 { get; set; }
        int num2 { get; set; }
        void HelpMessage(string message);

        int ReadConsoleNum1();
        int ReadConsoleNum2();
        void Operation();



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._5
{
    internal class Helper : IHelper
    {
        public Helper()
        {
        }

        public void HelpMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ReadConsoleNum1()
        {
            double num1 = double.Parse(Console.ReadLine());
        }
    }
}

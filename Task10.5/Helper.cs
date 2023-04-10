using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task10._5
{
    internal class Helper : IHelper
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public Helper()
        {
        }

        public void HelpMessage(string message)
        {
            Console.WriteLine(message);
        }


        public int ReadConsoleNum1()
        {
            try
            {
                int num1 = int.Parse( Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new MyExeption("нужно вводить целое число"));
            }
            return num1;
        }
        public int ReadConsoleNum2()
        {
            try
            {
                int num2 = int.Parse( Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new MyExeption("нужно вводить целое число"));
            }
            return num2;
        }
        public int Operation(int num1, int num2)
        {
            int result = num1 + num2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("результат=" + result);
            return result;
        }




    }
}

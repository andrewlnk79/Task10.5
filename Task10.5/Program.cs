
using Task10._5;
class Program
{
    public static IHelper? Helper { get; set; }
    static void Main()
    {
        Helper = new Helper();
        var calculator = new CalculatorPlus(Helper);
        calculator.Calc();
       Console.ReadKey();
    }
}
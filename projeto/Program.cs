using System.Reflection.Metadata;
using projeto.Services;
class Program
{
    public static void Main(string[] args)
    {
        CalculatorImplementation calc = new CalculatorImplementation();
        int a = 10;
        int b = 21;
        System.Console.WriteLine($"{a} + {b} = {calc.Somar(a,b)}");
        System.Console.WriteLine($"{a} - {b} = {calc.subtrair(a,b)}");
        System.Console.WriteLine($"{a} / {b} = {calc.dividir(a,b)}");
        System.Console.WriteLine($"{a} x {b} = {calc.multiplicar(a,b)}");
    }
}

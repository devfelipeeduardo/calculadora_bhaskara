// Fórmula de Bhaskara em C#endregion
using System;
 
namespace KaibaNameSpace                                     
{
    public class CalculadoraDeBhaskara                               
    {

        static void Main(string[] args)
        {

            double a;
            double b;
            double c;

            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|Calculadora de Fórmula de Bhaskara|");
            Console.WriteLine("|  Digite os números: ax, b² e c:  |");
            Console.WriteLine("|----------------------------------|");

            Console.WriteLine("Valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Pow(b, 2.0)-(4*a*c);

            double x1 = (-b + Math.Sqrt(delta))/2*a;

            double x2 = (-b - Math.Sqrt(delta))/2*a;

            Console.WriteLine($"O valor de X1 é: {x1} e o valor de x2 é: {x2}");
            

            // delta = b*b - 4*a*c


        }

    }
}
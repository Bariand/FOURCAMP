using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaAeB
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Para somar A + B, primeiro escreva A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora, escreva B: ");
            b = double.Parse(Console.ReadLine());

            double valorFinal = a + b;

            Console.WriteLine("Soma de " + a + " + " + b + " = " + valorFinal);
            Console.ReadLine();
        }
    }
}

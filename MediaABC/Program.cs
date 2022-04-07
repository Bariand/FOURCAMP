using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaABC
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Para tirar a média dos números A, B e C, primeiro informe A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora informe B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora informe C: ");
            c = double.Parse(Console.ReadLine());

            double media = (a + b + c) / 3;

            Console.WriteLine("A média de " + a + " + " + b + " + " + c + " = " + media);
            Console.ReadLine();
        }
    }
}

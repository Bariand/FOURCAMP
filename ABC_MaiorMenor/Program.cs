using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia três valores (A, B e C). Informe se A+B é maior do que C.

            Console.WriteLine("Informe o valor de A, um número inteiro:");
            int valorA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B, um número inteiro:");
            int valorB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C, um número inteiro:");
            int valorC = Int32.Parse(Console.ReadLine());

            if (valorA + valorB > valorC)
            {
                Console.WriteLine("O valor de A+B é maior do que de C.");
            }

            else if (valorA + valorB < valorC)
            {
                Console.WriteLine("O valor de A+B é menor do que de C.");
            }

            else
            {
                Console.WriteLine("O valor de A+B é igual ao de C.");
            }

            Console.ReadLine();
        }
    }
}

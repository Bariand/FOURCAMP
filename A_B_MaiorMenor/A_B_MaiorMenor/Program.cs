using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_B_MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia dois valores (A e B) e informe qual é o maior valor.

            Console.WriteLine("Escreva o valor de A, um número inteiro: ");
            int valorA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de B, um número inteiro: ");
            int valorB = Int32.Parse(Console.ReadLine());

            if (valorA > valorB)
            {
                Console.WriteLine("Valor de A é maior que o valor de B.");
            }

            else if (valorA < valorB)
            {
                Console.WriteLine("Valor de B é maior que o valor de A.");
            }

            else
            {
                Console.WriteLine("Ambos os valores são iguais.");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine(" ");
            Console.ReadLine();

            Console.WriteLine("...........................................................");
            Console.WriteLine(" ");
            Console.WriteLine("Qual o seu peso? ");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura? ");
            float altura = float.Parse(Console.ReadLine());

            double valorIMC = (peso / Math.Pow(altura, 2));

            Console.WriteLine("Seu IMC é: " + valorIMC);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo que peça a altura e o peso de uma
            //pessoa. Calcule o IMC e informe se ele está dentro
            //do intervalo de 18,5 e 25. Considere a fórmula:
            //IMC = peso / (altura)²

            Console.WriteLine("Qual o seu peso?");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura?");
            float altura = float.Parse(Console.ReadLine());

            float valorIMC = (float)(peso / Math.Pow(altura, 2));

            Console.WriteLine("O seu IMC é " + valorIMC);

            if (valorIMC < 18.5)
            {
                Console.WriteLine("Ele está abaixo de 18,5. Isso significa que você deveria ganhar peso.");
            }

            else if (valorIMC > 25)
            {
                Console.WriteLine("Ele está acima de 25. Isso significa que você deveria perder peso.");
            }

            else
            {
                Console.WriteLine("Ele está entre 18,5 e 25. Isso é bom! Continue assim! :)");
            }

            Console.ReadLine();
        }
    }
}

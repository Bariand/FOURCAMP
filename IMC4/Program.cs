using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo que peça a altura e o peso de uma
            //pessoa. Calcule o IMC e informe se ele está dentro
            //do intervalo de 18,5 e 25. Considere a fórmula:
            //IMC = peso / (altura)²
            //CLASSIFICAÇÃO                        IMC
            //Abaixo do Peso                   Abaixo 18,5
            //Peso Normal                      18,5 - 24,9
            //Sobrepeso                        25 - 29,9
            //Obesidade Grau I                 30 - 34,9
            //Obesidade Grau II                35 - 39,9
            //Obesidade Grau III ou Mórbida    Maior ou Igual 40

            Console.WriteLine("Qual o seu peso, em quilogramas?");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura, em metros?");
            float altura = float.Parse(Console.ReadLine());

            float valorIMC = (float)(peso / Math.Pow(altura, 2));

            Console.WriteLine("O seu IMC é " + valorIMC);

            if (valorIMC < 18.5)
            {
                Console.WriteLine("Seu IMC está abaixo de 18,5. Você está abaixo do peso ideal.");
            }

            else if (valorIMC >= 18.5 && valorIMC <= 24.9)
            {
                Console.WriteLine("Seu IMC está entre 18,5 e 24,9. Você está no peso ideal!");
            }

            else if (valorIMC >= 25 && valorIMC <= 29.9)
            {
                Console.WriteLine("Seu IMC está entre 25 e 29,9. Você está com sobrepeso.");
            }

            else if (valorIMC >= 30 && valorIMC <= 34.9)
            {
                Console.WriteLine("Seu IMC está entre 30 e 34,9. Você está com Obesidade Grau I.");
            }

            else if (valorIMC >= 35 && valorIMC <= 39.9)
            {
                Console.WriteLine("Seu IMC está entre 35 e 39,9. Você está com Obesidade Grau II.");
            }

            else if (valorIMC >= 40)
            {
                Console.WriteLine("Seu IMC está acima de 40, o que configura Obesidade Grau III, ou obesidade mórbida. Você precisa perder peso com urgência!");
            }

            else
            {
                Console.WriteLine("Algo está errado. Contate o suporte e diga que ele é burrão.");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMC2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tendo como dados de entrada a altura e o sexo de
            //uma pessoa, construa um algoritmo que calcule seu
            //peso ideal, utilizando as seguintes fórmulas:
            //● para homens: (72.7 * h) – 58;
            //● para mulheres: (62.1 * h) – 44.7.

            Console.WriteLine("Qual a sua altura?");
            float altura = float.Parse(Console.ReadLine());

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("Você é um homem ou uma mulher?");
                string sexo = Console.ReadLine();
                sexo = sexo.ToLower();

                if (sexo == "homem" || sexo == "um homem")
                {
                    i = 1;
                    float pesoIdeal = 72.7f * altura - 58f;
                    Console.WriteLine("Seu peso ideal é " + pesoIdeal + "Kg.");
                }

                else if (sexo == "mulher" || sexo == "uma mulher")
                {
                    i = 1;
                    float pesoIdeal = 62.1f * altura - 44.7f;
                    Console.WriteLine("Seu peso ideal é " + pesoIdeal + "Kg.");
                }

                else
                {
                    Console.WriteLine("Sexo descrito não existente.");
                }

                Console.ReadLine();
            }
        }
    }
}

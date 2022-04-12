using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetições
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mostre o seu nome 7 vezes na tela.

            Console.WriteLine("Qual o seu nome? Vou escrevê-lo sete vezes!");
            string nome = Console.ReadLine();
            Console.WriteLine(".................................................");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();

            //Conte de 1 até 20.

            Console.WriteLine("Eu vou contar de um até vinte. Porque eu posso.");
            Console.ReadLine();
            Console.WriteLine(".................................................");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            //Leia o nome da pessoa e imprima ele 15 vezes na tela.

            Console.WriteLine("Qual o seu nome, outra vez? Quero escrevê-lo quinze vezes!");
            string nome2 = Console.ReadLine();
            Console.WriteLine(".................................................");

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(nome2);
            }

            Console.ReadLine();

            //Leia um número, depois calcule e mostre a tabuada.

            Console.WriteLine("Diga um número, e te mostrarei a tabuada dele!");
            int numeroTabuada = int.Parse(Console.ReadLine());
            Console.WriteLine(".................................................");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numeroTabuada + " x " + i + " = " + (numeroTabuada * i));
            }

            Console.ReadLine();

            //Leia dois números, calcule e informe a soma. Pergunte se deseja calcular novamente.

            int j = 0;

            while (j == 0)
            {
                Console.WriteLine("Vamos somar dois valores. Escreva o primeiro valor:");
                int valorSoma1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora escreva o segundo valor:");
                int valorSoma2 = int.Parse(Console.ReadLine());

                Console.WriteLine("A sua soma resultou em " + (valorSoma1 + valorSoma2) + "\n" +
                                  "Você quer somar outros valores?\n" +
                                  "(S)im     (N)ão");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (input == "n")
                {
                    j = 1;
                }

                else if (input == "s")
                {

                }

                else
                {
                    Console.WriteLine("O que você digitou? Era pra ser s ou n! Não é difícil, caramba! Vamos voltar ao começo...");
                    Console.ReadLine();
                }
            }

            //Leia o nome da pessoa.Caso ela deixe em branco solicite para digitar novamente.

            int k = 0;

            while (k == 0)
            {
                Console.WriteLine("Digite seu nome mais uma vez, por favor.");
                string nome3 = Console.ReadLine();

                if (nome3 == null)
                {
                    Console.WriteLine("Ei! Pelo menos escreva alguma coisa! Vamos tentar novamente.");
                }

                else
                {
                    Console.WriteLine("Seu nome é mesmo " + nome3 + "? Que nome bem feio.");
                    k = 1;
                }
                Console.ReadLine();
            }

            //Leia um número, calcule o fatorial deste número e mostre o resultado

            int numeroFatorial;

            Console.WriteLine("Digite um número. Vou calcular o fatorial dele!");
            numeroFatorial = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int l = 2; l <= numeroFatorial; l++)
            {
                fatorial = fatorial * l;
            }

            Console.WriteLine("O resultado desta bagaça é " + fatorial + ". Confia.");
            Console.ReadLine();
        }
    }
}

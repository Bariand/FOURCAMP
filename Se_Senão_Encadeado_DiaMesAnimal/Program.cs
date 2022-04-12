using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se_Senão_Encadeado_DiaMesAnimal
{
    class Program
    {
        //Solicite um número de 1 a 12 e informe o mês escolhido por extenso.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Diga o número de um mês e ele será escrito por extenso: ");
            double numero1 = double.Parse(Console.ReadLine());

            switch (numero1)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("São doze meses no ano, pelo menos no planeta terra...");
                    break;
            }

            Console.ReadLine();

            //Solicite um número de 1 a 7 e informe o dia da semana por extenso.

            Console.WriteLine("Diga o número de um dia da semana e ele será escrito por extenso: ");
            double numero2 = double.Parse(Console.ReadLine());

            switch (numero2)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Há sete dias na semana; nem mais nem menos. Você está tentando quebrar o programa?");
                    break;
            }

            Console.ReadLine();

            //Solicite um animal e mostre em inglês. (Ex.: gato, cachorro, etc..)

            Console.WriteLine("Diga o nome de um animal e ele será descrito em inglês: ");
            string animal = Console.ReadLine();
            animal = animal.ToLower();

            switch (animal)
            {
                case "gato":
                    Console.WriteLine("cat");
                    break;
                case "cachorro":
                    Console.WriteLine("dog");
                    break;
                case "cão":
                    Console.WriteLine("dog");
                    break;
                case "tigre":
                    Console.WriteLine("tiger");
                    break;
                case "onça":
                    Console.WriteLine("Leopard");
                    break;
                case "tartaruga":
                    Console.WriteLine("turtle");
                    break;
                case "pássaro":
                    Console.WriteLine("bird");
                    break;
                case "passarinho":
                    Console.WriteLine("bird");
                    break;
                case "coruja":
                    Console.WriteLine("owl");
                    break;
                case "falcão":
                    Console.WriteLine("falcon");
                    break;
                case "tucano":
                    Console.WriteLine("tucano");
                    break;
                default:
                    Console.WriteLine("Esse aí eu não sei. Ei, a culpa é do preguiçoso do Lucas. Ele ficou com preguiça de adicionar mais!");
                    break;
            }

            Console.ReadLine();
        }
    }
}

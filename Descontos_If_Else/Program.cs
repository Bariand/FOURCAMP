using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descontos_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pergunte qual o valor da compra e a forma de pagamento;
            //se for a vista dê 10 % de desconto, caso contrário dê 5 %.

            Console.WriteLine("Qual o valor da compra?");
            float valorCompra = float.Parse(Console.ReadLine());

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("O pagamento será feito à vista ou à prazo?");
                string modoCompra = Console.ReadLine();
                modoCompra = modoCompra.ToLower();

                if (modoCompra == "vista" || modoCompra == "à vista")
                {
                    i = 1;
                    valorCompra -= valorCompra * 10 / 100;
                    Console.WriteLine("O valor da sua compra é de R$" + valorCompra);
                }

                else if (modoCompra == "prazo" || modoCompra == "à prazo")
                {
                    i = 1;
                    valorCompra -= valorCompra * 5 / 100;
                    Console.WriteLine("O valor da sua compra é de R$" + valorCompra);
                }

                else
                {
                    Console.WriteLine("Forma de pagamento inválida.");
                }

                Console.ReadLine();
            }
        }
    }
}

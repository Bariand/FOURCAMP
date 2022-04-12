using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_JurosDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um algoritmo que calcule o que deve ser pago por um produto, considerando o preço normal de etiqueta e a
            //escolha da condição de pagamento. Utilize os códigos da tabela a seguir para ler qual a condição de pagamento
            //escolhida e efetuar o cálculo adequado. Código - Condição de pagamento -Desconto / Juros:
            //● 1 - À vista em dinheiro ou cheque - 15 % de desconto
            //● 2 - À vista no cartão de crédito - 5 % de desconto
            //● 3 - Em duas vezes -sem desconto / juros
            //● 4 - Em seis vezes -juros de 10 %

            float valorFinal;

            Console.WriteLine("Qual o valor do produto?");
            float valorProduto = float.Parse(Console.ReadLine());

            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Qual a forma de pagamento?\n" +
                             "(A) À vista, em dinheiro ou cheque: 15% de desconto;\n" +
                             "(B) À vista, no cartão de crédito: 5% de desconto;\n" +
                             "(C) À prazo em duas vezes: sem desconto\n" +
                             "(D) À prazo em até seis vezes: 10% de juros");
                string formaDePagamento = Console.ReadLine();
                formaDePagamento = formaDePagamento.ToLower();

                switch (formaDePagamento)
                {
                    case "a":
                        valorFinal = valorProduto - valorProduto * 15 / 100;
                        Console.WriteLine("O valor final da compra é de R$" + valorFinal);
                        i = 1;
                        break;
                    case "b":
                        valorFinal = valorProduto - valorProduto * 5 / 100;
                        Console.WriteLine("O valor final da compra é de R$" + valorFinal);
                        i = 1;
                        break;
                    case "c":
                        valorFinal = valorProduto;
                        Console.WriteLine("O valor final da compra é de R$" + valorFinal);
                        i = 1;
                        break;
                    case "d":
                        valorFinal = valorProduto + valorProduto * 10 / 100;
                        Console.WriteLine("O valor final da compra é de R$" + valorFinal);
                        i = 1;
                        break;
                    default:
                        Console.WriteLine("É para digitar A, B, C ou D. Você está tentando quebrar o programa?");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}

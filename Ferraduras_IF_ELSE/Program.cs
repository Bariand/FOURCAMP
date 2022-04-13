using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferraduras_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            float preçoFerradura = 9.90f;

            //quantos cavalos precisam de ferraduas?
            Console.WriteLine("Cada ferradura custa R$9,90. Quantos cavalos o senhor precisa ferrar?");
            int numeroCavalos = Int32.Parse(Console.ReadLine());

            //Se o custo total for maior que 100,00 aplique um desconto de 10 %.Depois informe o valor final.
            float preçoTotal = 4 * preçoFerradura * numeroCavalos;

            if (preçoTotal > 100)
            {
                preçoTotal -= preçoTotal * 10 / 100;

                Console.WriteLine("O valor total é de " + preçoTotal);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("O valor total é de " + preçoTotal);
                Console.ReadLine();
            }
        }
    }
}

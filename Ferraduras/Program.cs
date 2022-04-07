using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferraduras
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCavalos;
            float preçoFerradura = 0.99f;
            int ferradurasPorCavalo = 4;

            Console.WriteLine("Quantas cavalos você quer ferrar?");
            numCavalos = Int32.Parse(Console.ReadLine());
            float orçamento = preçoFerradura * ferradurasPorCavalo * numCavalos;
            Console.WriteLine("O orçamento ficará em R$" + orçamento + ".");
            Console.ReadLine();
        }
    }
}

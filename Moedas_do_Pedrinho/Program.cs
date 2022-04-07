using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moedas_do_Pedrinho
{
    class Program
    {
        static void Main(string[] args)
        {

            float moeda100;
            float moeda050;
            float moeda025;
            float moeda015;
            float moeda010;
            float moeda005;
            float moeda001;

            Console.WriteLine("MOEDAS DO PEDRINHO");
            Console.WriteLine(" ");
            Console.ReadLine();

            Console.WriteLine("...............................................................");
            Console.WriteLine(" ");

            Console.WriteLine("Quantas moedas de R$ 1,00?");
            moeda100 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas moedas de R$ 0,50?");
            moeda050 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas moedas de R$ 0,25?");
            moeda025 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas moedas de R$ 0,15?");
            moeda015 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas moedas de R$ 0,10?");
            moeda010 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas moedas de R$ 0,05?");
            moeda005 = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas moedas de R$ 0,01?");
            moeda001 = float.Parse(Console.ReadLine());

            Console.WriteLine("Você tem:\n" +
                moeda100 + " moedas de R$ 1,00\n" +
                moeda050 + " moedas de R$ 0,50\n" +
                moeda025 + " moedas de R$ 0,25\n" +
                moeda015 + " moedas de R$ 0,15\n" +
                moeda010 + " moedas de R$ 0,10\n" +
                moeda005 + " moedas de R$ 0,05\n" +
                moeda001 + " moedas de R$ 0,01");

            float moedaTotal = moeda100*1.00f + moeda050*0.50f + moeda025*0.25f + moeda015*0.15f + moeda010*0.10f + moeda005*0.05f + moeda001*0.01f;

            Console.WriteLine("Totalizando R$" + moedaTotal);
            Console.ReadLine();
        }
    }
}

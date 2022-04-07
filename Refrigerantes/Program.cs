using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes
{
    class Program
    {
        static void Main(string[] args)
        {
            float coke2l = 2;
            float coke600ml = 0.600f;
            float coke350ml = 0.350f;

            Console.WriteLine("LISTA DE Cocapsi");
            Console.WriteLine(".....................................................");
            Console.WriteLine("Quantas garrafas de 2L você comprou? ");
            float numberCoke2l = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas garrafas de 600mL você comprou? ");
            float numberCoke600ml = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantas garrafas de 350mL você comprou? ");
            float numberCoke350ml = float.Parse(Console.ReadLine());

            float litrosTotal = numberCoke2l * coke2l + numberCoke600ml * coke600ml + numberCoke350ml * coke350ml;

            Console.WriteLine("Você comprou um total de " + litrosTotal + "l de Cocapsi,\n" +
                "o Refrigerante que não é Coca nem Pespi!");
            Console.ReadLine();
        }
    }
}

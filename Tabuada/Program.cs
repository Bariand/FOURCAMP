using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class ProgramTabuada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUPER TABUADA 3000X 9.1 MEGA CONSOLE EDITION Z");
            Console.ReadLine();
            Console.WriteLine("................................................................");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha um número para que sua tabuada seja demonstrada: ");
            int numeroTabuada = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            int tabuada1 = numeroTabuada * 1;
            int tabuada2 = numeroTabuada * 2;
            int tabuada3 = numeroTabuada * 3;
            int tabuada4 = numeroTabuada * 4;
            int tabuada5 = numeroTabuada * 5;
            int tabuada6 = numeroTabuada * 6;
            int tabuada7 = numeroTabuada * 7;
            int tabuada8 = numeroTabuada * 8;
            int tabuada9 = numeroTabuada * 9;
            int tabuada10 = numeroTabuada * 10;

            Console.WriteLine(numeroTabuada + " * 1  = " + tabuada1 + "\n" +
                              numeroTabuada + " * 2  = " + tabuada2 + "\n" +
                              numeroTabuada + " * 3  = " + tabuada3 + "\n" +
                              numeroTabuada + " * 4  = " + tabuada4 + "\n" +
                              numeroTabuada + " * 5  = " + tabuada5 + "\n" +
                              numeroTabuada + " * 6  = " + tabuada6 + "\n" +
                              numeroTabuada + " * 7  = " + tabuada7 + "\n" +
                              numeroTabuada + " * 8  = " + tabuada8 + "\n" +
                              numeroTabuada + " * 9  = " + tabuada9 + "\n" +
                              numeroTabuada + " * 10 = " + tabuada10 + "\n");

            Console.ReadLine();
        }
    }
}

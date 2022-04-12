using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia as medidas(b, h) de um retângulo. Informe a
            //área calculada e se é um quadrado ou não.

            float baseQuadrilatero;
            float alturaQuadrilatero;

            Console.WriteLine("Informe a base, em cm, do quadrilátero de ângulos retos");
            baseQuadrilatero = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura, em cm, do quadrilátero de ângulos retos");
            alturaQuadrilatero = float.Parse(Console.ReadLine());

            float areaQuadrilatero = alturaQuadrilatero * baseQuadrilatero;

            if (baseQuadrilatero == alturaQuadrilatero)
            {
                Console.WriteLine("O quadrilátero descrito é um quadrado.");
            }

            else
            {
                Console.WriteLine("O quadrilátero descrito é um retângulo.");
            }

            Console.WriteLine("A área do quadrilátero é: " + areaQuadrilatero + "cm.");
            Console.ReadLine();
        }
    }
}

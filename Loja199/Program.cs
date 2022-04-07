using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja199
{
    class Program
    {
        static void Main(string[] args)
        {
            int item1;
            int item2;
            int item3;
            int item4;
            int item5;
            float preço1;
            float preço2;
            float preço3;
            float preço4;
            float preço5;
            string itemName1;
            string itemName2;
            string itemName3;
            string itemName4;
            string itemName5;

            Console.WriteLine("Nome do produto 1: ");
            itemName1 = (Console.ReadLine());
            Console.WriteLine("Valor do Produto 1: ");
            preço1 = float.Parse(Console.ReadLine());

            int i = 0;

            do
            {
                Console.WriteLine("Há outro produto para registrar nesta nota?\n Digite S para sim ou N para não ");
                string input0 = Console.ReadLine();
                input0 = input0.ToLower();

                if (input0 == "s")
                {
                    i = 1;

                    Console.WriteLine("Nome do produto 2: ");
                    itemName2 = (Console.ReadLine());
                    Console.WriteLine("Valor do Produto 2: ");
                    preço2 = float.Parse(Console.ReadLine());

                    i = 0;

                    do
                    {
                        Console.WriteLine("Há outro produto para registrar nesta nota?\n Digite S para sim ou N para não ");
                        string input1 = Console.ReadLine();
                        input1 = input1.ToLower();

                        if (input1 == "s")
                        {
                            i = 1;

                            Console.WriteLine("Nome do produto 3: ");
                            itemName3 = (Console.ReadLine());
                            Console.WriteLine("Valor do Produto 3: ");
                            preço3 = float.Parse(Console.ReadLine());

                            i = 0;

                            do
                            {
                                Console.WriteLine("Há outro produto para registrar nesta nota?\n Digite S para sim ou N para não ");
                                string input2 = Console.ReadLine();
                                input2 = input2.ToLower();

                                if (input2 == "s")
                                {
                                    i = 1;

                                    Console.WriteLine("Nome do produto 4: ");
                                    itemName4 = (Console.ReadLine());
                                    Console.WriteLine("Valor do Produto 4: ");
                                    preço4 = float.Parse(Console.ReadLine());

                                    i = 0;

                                    do
                                    {
                                        Console.WriteLine("Há outro produto para registrar nesta nota?\n Digite S para sim ou N para não ");
                                        string input3 = Console.ReadLine();
                                        input3 = input3.ToLower();

                                        if (input3 == "s")
                                        {
                                            i = 1;

                                            Console.WriteLine("Nome do produto 5: ");
                                            itemName5 = (Console.ReadLine());
                                            Console.WriteLine("Valor do Produto 5: ");
                                            preço5 = float.Parse(Console.ReadLine());

                                            i = 1;

                                            float valorFinal = preço1 + preço2 + preço3 + preço4 + preço5;
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Produto 1: " + itemName1 + "; Preço: R$" + preço1 + "\n" +
                                                              "Produto 2: " + itemName2 + "; Preço: R$" + preço2 + "\n" +
                                                              "Produto 3: " + itemName3 + "; Preço: R$" + preço3 + "\n" +
                                                              "Produto 4: " + itemName4 + "; Preço: R$" + preço4 + "\n" +
                                                              "Produto 5: " + itemName5 + "; Preço: R$" + preço5 + "\n" +
                                                              ".....................................................\n" +
                                                              "TOTAL: R$" + valorFinal);
                                            Console.ReadLine();

                                        }

                                        else if (input0 == "n")
                                        {
                                            i = 1;

                                            float valorFinal = preço1 + preço2 + preço3 + preço4;
                                            Console.WriteLine(" ");
                                            Console.WriteLine("Produto 1: " + itemName1 + "; Preço: R$" + preço1 + "\n" +
                                                              "Produto 2: " + itemName2 + "; Preço: R$" + preço2 + "\n" +
                                                              "Produto 3: " + itemName3 + "; Preço: R$" + preço3 + "\n" +
                                                              "Produto 4: " + itemName4 + "; Preço: R$" + preço4 + "\n" +
                                                              "...................................................\n" +
                                                              "TOTAL: R$" + valorFinal);
                                            Console.ReadLine();
                                        }

                                        else
                                        {
                                            Console.WriteLine("Caractere digitado é inválido. Tente novamente.");
                                            Console.ReadLine();
                                        }
                                    }
                                    while (i == 0);
                                }

                                else if (input0 == "n")
                                {
                                    i = 1;

                                    float valorFinal = preço1 + preço2 + preço3;
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Produto 1: " + itemName1 + "; Preço: R$" + preço1 + "\n" +
                                                      "Produto 2: " + itemName2 + "; Preço: R$" + preço2 + "\n" +
                                                      "Produto 3: " + itemName3 + "; Preço: R$" + preço3 + "\n" +
                                                      "...................................................\n" +
                                                      "TOTAL: R$" + valorFinal);
                                    Console.ReadLine();
                                }

                                else
                                {
                                    Console.WriteLine("Caractere digitado é inválido. Tente novamente.");
                                    Console.ReadLine();
                                }
                            }
                            while (i == 0);

                        }

                        else if (input0 == "n")
                        {
                            i = 1;

                            float valorFinal = preço1 + preço2;
                            Console.WriteLine(" ");
                            Console.WriteLine("Produto 1: " + itemName1 + "; Preço: R$" + preço1 + "\n" +
                                              "Produto 2: " + itemName2 + "; Preço: R$" + preço2 + "\n" +
                                              "...................................................\n" +
                                              "TOTAL: R$" + valorFinal);
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("Caractere digitado é inválido. Tente novamente.");
                            Console.ReadLine();
                        }
                    }
                    while (i == 0);
                }

                else if (input0 == "n")
                {
                    i = 1;

                    float valorFinal = preço1;
                    Console.WriteLine(" ");
                    Console.WriteLine("Produto 1: " + itemName1 + "; Preço: R$" + preço1 + "\n" +
                                      "...................................................\n" +
                                      "TOTAL: R$" + valorFinal);
                    Console.ReadLine();

                }

                else
                {
                    Console.WriteLine("Caractere digitado é inválido. Tente novamente.");
                    Console.ReadLine();
                }
            }
            while (i == 0);
        }
    }
}

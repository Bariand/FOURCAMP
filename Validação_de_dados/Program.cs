using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validação_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite o nome, e-mail, rg e cpf da pessoa. Faça uma
            //validação simples para verificar se todos os campos
            //foram preenchidos.

            int i = 0;

            string nome;
            string email;
            int valorRG;
            int valorCPF;

            while (i == 0)
            {
                Console.WriteLine("Diga seu nome:");
                nome = Console.ReadLine();
                nome = nome.ToLower();

                if (nome == null)
                {
                    Console.WriteLine("Você não digitou nenhum nome.");
                    Console.ReadLine();
                }

                else
                {
                    int j = 0;

                    while (j == 0)
                    {
                        Console.WriteLine(nome + ". Este é o seu nome?\n" +
                                      "(S)im\n" +
                                      "(N)ão");

                        string inputQ1 = Console.ReadLine();
                        inputQ1 = inputQ1.ToLower();

                        if (inputQ1 == "s" || inputQ1 == "sim")
                        {
                            i = 1;
                            j = 1;
                        }

                        else if (inputQ1 == "n" || inputQ1 == "não" || inputQ1 == "nao")
                        {
                            j = 1;
                        }

                        else
                        {
                            Console.WriteLine("Input desconhecido. Pressione qualquer tecla para continuar.");
                            Console.ReadLine();
                        }
                    }
                }
            }

            i = 0;
            while (i == 0)
            {
                Console.WriteLine("Escreva seu e-mail:");
                email = Console.ReadLine();
                email = email.ToLower();

                if (email == null)
                {
                    Console.WriteLine("Você não digitou e-mail algum.");
                    Console.ReadLine();
                }

                else
                {
                    int j = 0;

                    while (j == 0)
                    {
                        Console.WriteLine(email + ". Este é o seu email?\n" +
                                      "(S)im\n" +
                                      "(N)ão");

                        string inputQ1 = Console.ReadLine();
                        inputQ1 = inputQ1.ToLower();

                        if (inputQ1 == "s" || inputQ1 == "sim")
                        {
                            i = 1;
                            j = 1;
                        }

                        else if (inputQ1 == "n" || inputQ1 == "não" || inputQ1 == "nao")
                        {
                            j = 1;
                        }

                        else
                        {
                            Console.WriteLine("Input desconhecido. Pressione qualquer tecla para continuar.");
                            Console.ReadLine();
                        }
                    }
                }
            }

            i = 0;
            while (i == 0)
            {
                Console.WriteLine("Escreva seu RG (apenas números):");
                valorRG = int.Parse(Console.ReadLine());

                if (valorRG == 0)
                {
                    Console.WriteLine("Você não digitou valor algum.");
                    Console.ReadLine();
                }

                else
                {
                    int j = 0;

                    while (j == 0)
                    {
                        Console.WriteLine(valorRG + ". Este é o seu RG?\n" +
                                      "(S)im\n" +
                                      "(N)ão");

                        string inputQ1 = Console.ReadLine();
                        inputQ1 = inputQ1.ToLower();

                        if (inputQ1 == "s" || inputQ1 == "sim")
                        {
                            i = 1;
                            j = 1;
                        }

                        else if (inputQ1 == "n" || inputQ1 == "não" || inputQ1 == "nao")
                        {
                            j = 1;
                        }

                        else
                        {
                            Console.WriteLine("Input desconhecido. Pressione qualquer tecla para continuar.");
                            Console.ReadLine();
                        }
                    }
                }
            }

            i = 0;
            while (i == 0)
            {
                Console.WriteLine("Escreva seu CPF (apenas números):");
                valorCPF = int.Parse(Console.ReadLine());

                if (valorCPF == 0)
                {
                    Console.WriteLine("Você não digitou valor algum.");
                    Console.ReadLine();
                }

                else
                {
                    int j = 0;

                    while (j == 0)
                    {
                        Console.WriteLine(valorCPF + ". Este é o seu CPF?\n" +
                                      "(S)im\n" +
                                      "(N)ão");

                        string inputQ1 = Console.ReadLine();
                        inputQ1 = inputQ1.ToLower();

                        if (inputQ1 == "s" || inputQ1 == "sim")
                        {
                            i = 1;
                            j = 1;
                        }

                        else if (inputQ1 == "n" || inputQ1 == "não" || inputQ1 == "nao")
                        {
                            j = 1;
                        }

                        else
                        {
                            Console.WriteLine("Input desconhecido. Pressione qualquer tecla para continuar.");
                            Console.ReadLine();
                        }
                    }
                }
            }

            Console.WriteLine("Aperte qualquer tecla para fechar o programa.");
            Console.ReadLine();
        }
    }
}

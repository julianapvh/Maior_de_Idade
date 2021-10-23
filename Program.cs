using System;
using System.Diagnostics;

namespace Maior_de_Idade
{

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa um = new Pessoa();
            Pessoa dois = new Pessoa();
            Pessoa tres = new Pessoa();

            Console.WriteLine("Qual pessoa é a mais velha?");
            Console.Write("\nNome da primeira pessoa: ");
            um = new Pessoa();
            um.Nome = Console.ReadLine();
            Console.Write("Idade da primeira pessoa: ");
            um.Idade = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nNome da segunda pessoa: ");
            dois = new Pessoa();
            dois.Nome = Console.ReadLine();
            Console.Write("Idade da segunda pessoa: ");
            dois.Idade = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nNome da terceira pessoa: ");
            tres = new Pessoa();
            string nome = Console.ReadLine();
            Console.Write("Idade da terceira pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            tres = new Pessoa(nome, idade);

            if ((um.Idade >= dois.Idade) && (um.Idade >= tres.Idade))
            {
                Console.WriteLine("\nA pessoa mais velha é: ");
                um.ExibirDados();

            }
            else
            {
                if ((dois.Idade >= tres.Idade) && (dois.Idade >= um.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    dois.ExibirDados();
                }
                else
                {
                    if ((tres.Idade >= um.Idade) && (tres.Idade >= dois.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        tres.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade");
                    }
           
                    Console.ReadKey();
                }
            }
        }
    }
}





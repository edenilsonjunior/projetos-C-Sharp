using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Maior de 5--");

            int maior = int.MinValue;

            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Informe o {i}º número:");
                int numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                    maior = numero;
            }

            Console.WriteLine($"Maior número informado:{maior}");

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

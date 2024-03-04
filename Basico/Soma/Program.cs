using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Soma--");

            int soma = 0;
            for (int i = 1; i < 6; i++)
            {                
                Console.Write($"Informe o {i}º número:");
                int numero = int.Parse(Console.ReadLine());
                //soma = soma + numero;
                soma += numero;
            }                     
                        
            Console.WriteLine($"Soma:{soma}");

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Inteiros--");

            int maiorNumero = 0;

            do
            {
                Console.Write("Digite um número ou 0 para sair:");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                    break;

                if (numero < 0)
                {
                    Console.WriteLine("Informe somente números positivos por favor.");
                    continue;
                }

                if (numero > maiorNumero)
                    maiorNumero = numero;

            } while (true);

            Console.WriteLine($"O maior número é: {maiorNumero}");

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

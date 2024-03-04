using System;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Senha--");

            Console.Write("Informe sua senha:");
            string senha = Console.ReadLine();

            if (senha == "123") //ED Composta (Atendendo 2 possibilidades => V ou F)
            {
                Console.WriteLine("Senha corrreta!");
                Console.WriteLine("Você vai ter acesso a uma novidade!");
            }
            else
            {
                Console.WriteLine("Senha incorrreta!");
                Console.WriteLine("Tente novamente!");
            }

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

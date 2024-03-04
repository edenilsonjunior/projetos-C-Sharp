using System;

namespace Acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SENHACORRETA = "904087";

            Console.WriteLine("--Bem vindo ao programa Acesso--");

            Console.Write("Informe sua senha:");
            string senha = Console.ReadLine();

            if (senha == SENHACORRETA)
                Console.WriteLine("Acesso permitido!");
            else
                Console.WriteLine("Você não tem acesso ao sistema!");

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

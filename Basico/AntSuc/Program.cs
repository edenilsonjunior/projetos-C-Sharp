using System;

namespace AntSuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Antecessor e Sucessor--");

            Console.Write("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            //int antecessor = numero - 1;
            //int sucessor = numero + 1;

            Console.WriteLine($"Antecessor: {numero - 1}");
            Console.WriteLine($"Sucessor: {numero + 1}");

            //Console.WriteLine($"Antecessor: {numero - 1} \nSucessor: {numero + 1}");

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

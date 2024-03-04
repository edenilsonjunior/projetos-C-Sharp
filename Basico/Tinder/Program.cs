using System;

/*
 * Zequinha está procurando uma namorada no Tinder. Para isso, ele preencheu seu cadastro com algumas preferências:
 
• sexo: "feminino"
• altura: entre 1.60 e 1.75
• peso: entre 50 e 80
• idade: entre 22 e 30
• cabelo: "loiro" ou "ruivo"

Assim, faça um programa que receba os seguintes dados de um perfil: nome, sexo, altura, peso, idade e cabelo e determine se este perfil é compatível com o perfil cadastrado pelo Zequinha. Então, após à execução, o programa deve imprimir o nome do perfil e se ele é compatível ou não com o perfil do Zequinha, como, por exemplo: "Joana é compatível" ou "Joana não é compatível".
 * 
 */

namespace Tinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Tinder--");

            Console.Write("Qual seu nome:");
            string nome = Console.ReadLine();

            Console.Write("Qual seu sexo (1-Feminino 2-Masculino):");
            int sexo = int.Parse(Console.ReadLine());
            
            Console.Write("Qual sua altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Qual seu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Qual sua idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a cor do seu cabelo (1-Loiro 2-Ruivo 3-Nenhum dos dois):");
            int corCabelo = int.Parse(Console.ReadLine());

            //CUIDADO => Operador || junto com o operador &&
            if (sexo == 1 && altura >= 1.60 && altura <= 1.75 && peso >= 50 && peso <= 80 && idade >= 22 && idade <= 30 && (corCabelo == 1 || corCabelo == 2))  //utilização dos operadores lógicos.
                Console.WriteLine($"{nome} é compatível.");
            else
                Console.WriteLine($"{nome} não é compatível.");

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

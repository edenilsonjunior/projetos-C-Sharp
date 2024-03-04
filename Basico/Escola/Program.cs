using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Escola--");

            const int NUMEROTOTALAULAS = 80;
            const int LIMITEFALTAS = (int) (NUMEROTOTALAULAS * 0.25) + 1;
            const double LIMITEMEDIA = 7;

            Console.Write("Informe o número de faltas:");
            int faltas = int.Parse(Console.ReadLine());

            if (faltas < LIMITEFALTAS)
            {
                Console.Write("Informe a primeira nota:");
                double nota1 = double.Parse(Console.ReadLine());

                Console.Write("Informe a segunda nota:");
                double nota2 = double.Parse(Console.ReadLine());

                Console.Write("Informe a terceira nota:");
                double nota3 = double.Parse(Console.ReadLine());

                double media = (nota1 + nota2 + nota3) / 3;

                if (media >= LIMITEMEDIA)
                    Console.WriteLine("Aprovado");
                else
                    Console.WriteLine("Reprovado por Média");
            }                
            else
                Console.WriteLine(" Reprovado por Falta");
            
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

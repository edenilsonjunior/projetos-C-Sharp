using System;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {          

            Console.WriteLine("--Bem vindo ao programa Loteria--");

            #region "Entrada de dados"

            Console.Write("Valor apostado pelo Amigo1:");
            double valorApostadoAmigo1 = double.Parse(Console.ReadLine());

            Console.Write("Valor apostado pelo Amigo2:");
            double valorApostadoAmigo2 = double.Parse(Console.ReadLine());

            Console.Write("Valor apostado pelo Amigo3:");
            double valorApostadoAmigo3 = double.Parse(Console.ReadLine());

            Console.Write("Valor do prêmio:");
            double valorPremio = double.Parse(Console.ReadLine());

            #endregion

            #region "Processamento"

            double valorTotalApostado = valorApostadoAmigo1 + valorApostadoAmigo2 + valorApostadoAmigo3;
            double proporcaoPremio = valorPremio / valorTotalApostado;

            double valorPremioAmigo1 = valorApostadoAmigo1 * proporcaoPremio;
            double valorPremioAmigo2 = valorApostadoAmigo2 * proporcaoPremio;
            double valorPremioAmigo3 = valorApostadoAmigo3 * proporcaoPremio;

            #endregion

            #region "Saída"

            Console.WriteLine($"Valor prêmio Amigo1: {valorPremioAmigo1:0.00}");
            Console.WriteLine($"Valor prêmio Amigo2: {valorPremioAmigo2:0.00}");
            Console.WriteLine($"Valor prêmio Amigo3: {valorPremioAmigo3:0.00}");

            #endregion

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

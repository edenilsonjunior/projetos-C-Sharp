using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            string opcaoJogador, sair;
            int numeroJogador, numeroComputador, pontosJogador = 0, pontosComputador = 0, nroRodada = 0;
            Random roleta = new Random();
              
            do
            {
                Console.WriteLine($"-----Rodada: {nroRodada++}-----");

                Console.Write("Você quer par (p) ou ímpar (i)? ");
                opcaoJogador = Console.ReadLine();

                Console.Write("Informe um número inteiro: ");
                numeroJogador = int.Parse(Console.ReadLine());

                numeroComputador = roleta.Next(100);
                int soma = numeroJogador + numeroComputador;


                Console.WriteLine($"Escolha jogador: {numeroJogador}");
                Console.WriteLine($"Escolha Computador: {numeroComputador}");

                if (soma % 2 == 0)
                {
                    if(opcaoJogador == "p")
                    {
                        Console.WriteLine($"Resultado da rodada {nroRodada}: Vitoria do jogador!");
                        pontosJogador++;
                    }
                    else
                    {
                        Console.WriteLine($"Resultado da rodada {nroRodada}: Vitoria do computador!");
                        pontosComputador++;
                    }
                }
                else if(soma % 2 != 0)
                {
                    if(opcaoJogador == "i")
                    {
                        Console.WriteLine($"Resultado da rodada {nroRodada}: Vitoria do jogador!");
                        pontosJogador++;
                    }
                    else
                    {
                        Console.WriteLine($"Resultado da rodada {nroRodada}: Vitoria do computador!");
                        pontosComputador++;
                    }
                }
                Console.WriteLine("--------------------");

                Console.WriteLine("Deseja jogar novamente? (s/n)");
                sair = Console.ReadLine();
            }
            while (sair == "s");

            if(pontosJogador > pontosComputador)
            {
                Console.WriteLine($"Placar final: Jogador {pontosJogador} x Computador {pontosComputador} (Jogador ganhou)");
            }
            else if(pontosJogador < pontosComputador)
            {
                Console.WriteLine($"Placar final: Jogador {pontosJogador} x Computador {pontosComputador} (Computador ganhou)");
            }
            else
            {
                Console.WriteLine($"Placar final: Jogador {pontosJogador} x Computador {pontosComputador} (Empate)");
            }


            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}

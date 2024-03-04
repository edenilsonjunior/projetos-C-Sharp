using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoTurbo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Eleição Turbo--");

            int totalVotosContabilizadosComSucesso = 0, totalVotosNulos = 0, totalVotosBrancos = 0;

            int continuar;

            string votos = "";

            do
            {
                Console.Write("Candidatos: 1, 2, 3, 4\nVoto nulo: 5\nVoto branco: 6\n");
                Console.Write("Digite um voto:");
                int voto = int.Parse(Console.ReadLine());
                votos += voto;

                switch (voto)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Voto contabilizado com sucesso...");
                        totalVotosContabilizadosComSucesso++;
                        break;
                    case 5:
                        Console.WriteLine("Voto nulo contabilizado...");
                        totalVotosNulos++;
                        break;
                    case 6:
                        Console.WriteLine("Voto branco contabilizado...");
                        totalVotosBrancos++;
                        break;
                    default: 
                        Console.WriteLine("Voto inválido.");
                        break;
                }

                Console.Write("Deseja votar novamente (0-não 1-sim):");
                continuar = int.Parse(Console.ReadLine());  

            } while (continuar == 1);

            Console.WriteLine("--Total de Votos--");
            Console.WriteLine($"Contabilizados com sucesso:{totalVotosContabilizadosComSucesso}");
            Console.WriteLine($"Nulos:{totalVotosNulos}");
            Console.WriteLine($"Brancos:{totalVotosBrancos}");

            for (int i = 0; i < votos.Length; i++)
            {
                Console.WriteLine(votos[i]);
            }

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

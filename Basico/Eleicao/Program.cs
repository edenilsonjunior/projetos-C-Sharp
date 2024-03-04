using System;

namespace Eleicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa Eleição--");

            Console.Write("Candidatos: 1, 2, 3, 4\nVoto nulo: 5\nVoto branco: 6\n");
            Console.Write("Digite um voto:");
            int voto = int.Parse(Console.ReadLine());

            #region "Estrutura de Decisão Simples"

            if (voto == 1)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 2)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 3)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso...");

            if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");

            if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            
            #endregion

            #region "Estrutura de Decisão Composta e Aninhada, com uma ED simples no final"

            if (voto == 1)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else
                if (voto == 2)
                    Console.WriteLine("Voto contabilizado com sucesso...");
                else
                    if (voto == 3)
                        Console.WriteLine("Voto contabilizado com sucesso...");
                    else
                        if (voto == 4)
                            Console.WriteLine("Voto contabilizado com sucesso...");
                        else
                            if (voto == 5)
                                Console.WriteLine("Voto nulo contabilizado...");
                            else
                                if (voto == 6)
                                    Console.WriteLine("Voto branco contabilizado...");
                                else
                                    Console.WriteLine("Voto inválido");

            #endregion

            #region "Estrutura de Decisão Encadeada"

            if (voto == 1)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 2)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 3)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido");

            #endregion

            #region "switch v1"

            switch (voto)
            {
                case 1:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 2:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 3:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 4:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 5:
                    Console.WriteLine("Voto nulo contabilizado...");
                    break;
                case 6:
                    Console.WriteLine("Voto branco contabilizado...");
                    break;
                default: // (else)
                    Console.WriteLine("Voto inválido");
                    break;
            }

            #endregion

            #region " **** switch v2 **** "

            switch (voto)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case 5:
                    Console.WriteLine("Voto nulo contabilizado...");
                    break;
                case 6:
                    Console.WriteLine("Voto branco contabilizado...");
                    break;
                default: // (else)
                    Console.WriteLine("Voto inválido");
                    break;
            }

            #endregion

            #region "Estrutura de decisão com operador lógico"

            //if (voto == 1 || voto == 2 || voto == 3 || voto == 4)
            if (voto > 0 && voto < 5)            
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido");

            #endregion

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

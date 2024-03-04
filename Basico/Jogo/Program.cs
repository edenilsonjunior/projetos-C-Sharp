using System;

/*
 Faça um programa que receba um golpe que um personagem deve executar. O programa
deve ficar solicitando golpes até o usuário responder que não deseja mais executá-lo. Para
identificar os golpes, utilize 3 teclas: c (chute), s (soco) e m (magia), onde: chute vale 2
pontos, soco 4 pontos e magia 10 pontos. No final, o programa deve exibir para o usuário o
número e a pontuação obtida por cada tipo de golpe, bem como a pontuação total do
usuário.
 */


namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Programa do Jogo--\n");

            const int PONTOSPORCADACHUTE = 2, PONTOSPORCADASOCO = 4, PONTOSPORCADAMAGIA = 10;
            const string CHUTE = "c", SOCO = "s", MAGIA = "m";
            int pontosPorChute = 0, pontosPorSoco = 0, pontosPorMagia = 0;

            string respostaUsuario = "";
            
            do
            {
                Console.Write($"Informe o golpe ({CHUTE}-chute {SOCO}-soco {MAGIA}-magia):");
                string golpe = Console.ReadLine().ToLower();

                switch (golpe)
                {
                    case CHUTE:
                        pontosPorChute += PONTOSPORCADACHUTE;
                        break;
                    case SOCO:
                        pontosPorSoco += PONTOSPORCADASOCO;
                        break;
                    case MAGIA:
                        pontosPorMagia += PONTOSPORCADAMAGIA;
                        break;
                    default:
                        break;
                }

                Console.Write("Deseja entrar com mais um golpe (s-sim n-não)?");
                respostaUsuario = Console.ReadLine().ToLower();

            } while (respostaUsuario == "s");

            Console.WriteLine($"Número de chutes: {pontosPorChute / PONTOSPORCADACHUTE}");
            Console.WriteLine($"Pontos por chutes: {pontosPorChute}");

            Console.WriteLine($"Número de socos: {pontosPorSoco / PONTOSPORCADASOCO}");
            Console.WriteLine($"Pontos por socos: {pontosPorSoco}");

            Console.WriteLine($"Número de magia: {pontosPorMagia / PONTOSPORCADAMAGIA}");
            Console.WriteLine($"Pontos por magia: {pontosPorMagia}");

            Console.WriteLine($"Pontuação total:{pontosPorChute + pontosPorSoco + pontosPorMagia}");

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}

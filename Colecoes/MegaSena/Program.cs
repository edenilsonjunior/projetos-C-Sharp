using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mega Sena");

            Random random = new Random();

            List<int> naoSorteados = new List<int>(60);
            HashSet<int> sorteados = new HashSet<int>(6);

            for (int i = 1; i < 61; i++)
            {
                naoSorteados.Add(i);
            }

            for (int i = 0; i < 6; i++)
            {
                int sorteado = random.Next(1, 61); //primeiro entra, segundo nao

                if (!sorteados.Add(sorteado))
                {
                    i--;
                    continue;
                }
                
                naoSorteados.Remove(sorteado);

                #region "Foreach manual"

                /*bool achou = false;
                foreach (var item in sorteados)
                {
                    if (item == sorteado)
                    {
                        i--;
                        achou = true;
                        break;
                    }
                        
                }               

                if (!achou)
                {
                    sorteados.Add(sorteado);
                    naoSorteados.Remove(sorteado);
                }*/

                #endregion
            }
            Console.Write("Numeros Sorteados: ");
            foreach (var item in sorteados)
            {

                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.Write("Numeros não Sorteados: ");
            foreach (var item in naoSorteados)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nPrima Enter para sair");
            Console.ReadLine();
        }
    }
}
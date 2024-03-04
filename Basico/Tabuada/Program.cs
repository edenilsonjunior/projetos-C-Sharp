using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Interação com usuário utilizando Estrutura de Repetição"

            //int continuarDo = 1;
            //do
            //{
            //    Console.Write("Deseja continuar Do 0-não 1-sim:");
            //    continuarDo = int.Parse(Console.ReadLine());

            //} while (continuarDo == 1);

            //int continuarWhile = 1;
            //while (continuarWhile == 1)            
            //{                
            //    Console.Write("Deseja continuar While 0-não 1-sim:");
            //    continuarWhile = int.Parse(Console.ReadLine());
            //}

            //for (int continuarFor = 1; continuarFor == 1;)
            //{
            //    Console.Write("Deseja continuar For 0-não 1-sim:");
            //    continuarFor = int.Parse(Console.ReadLine());
            //}
            #endregion


            Console.WriteLine("--Bem vindo ao programa Tabuada--");

            Console.Write("Informe o número para calculo de tabuada:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");

            Console.WriteLine("--Tabuada com for--");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine("--Tabuada com while--");
            int j = 0;
            while (j < 11)
            {
                Console.WriteLine($"{numero} x {j} = {numero * j}");
                j++;
            }

            Console.WriteLine("--Tabuada com do while--");
            j = 0;
            do
            {
                Console.WriteLine($"{numero} x {j} = {numero * j}");
                j++;
            } while (j < 11);

            
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

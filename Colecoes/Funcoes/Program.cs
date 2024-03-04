using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Início--");

            int x = 5;
            PularLinhas(ref x);

            Console.WriteLine("--Meio--");

            //PularLinhas(ref 2);

            Console.WriteLine("--Fim--");

            PularLinha();

            int soma = Somar(2, 3);


            int y = 2;
            int z = y;
            int[] a = new int[3];
            int[] b = a;

            Funcao(b);


            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }

        static void Funcao(int[] x)
        {

        }
        static void PularLinhas(ref int x)
        {            
            x = 3;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
            }
            //return;
        }

        static void PularLinha()
        {
            Console.WriteLine();
        }       

        static int Somar(int n1, int n2)
        {
            return n1 + n2;            
        }
    }
}

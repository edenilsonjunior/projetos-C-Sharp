using System;

namespace Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Programa Pares--");

            #region "for"

            for (int i = 10; i < 101; i+=2) //2 em 2 e não tem verificação (if)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i < 101; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            #endregion

            #region "while"

            int j = 10;
            while (j < 101)
            {
                Console.WriteLine(j);
                j += 2;
            }

            #endregion

            #region "do while"

            j = 10;
            do
            {
                Console.WriteLine(j);
                j += 2;
            } while (j < 101);

            #endregion

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = ++x;
            Console.Write($"Valor de y = {y}");

            x = 3;
            int z = x++;
            Console.Write($"Valor de z = {z}");

            Console.ReadLine();

        }
    }
}

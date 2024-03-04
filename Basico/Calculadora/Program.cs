using System;

namespace Calculadora 
{ 
    internal class Program 
    {
        /*
         * Dicionário de dados
         * numero => num
         * valor => val
         * salario => sal
         */

        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa calculadora--");

            Console.Write("Digite um número:");
            int numero1 = int.Parse(Console.ReadLine()); //declaração da variável numero1 do tipo string

            Console.Write("Digite outro número:");
            int numero2 = int.Parse(Console.ReadLine()); //declaração da variável numero2 do tipo string

            //Console.WriteLine("Soma de {0} com {1} = {2}",numero1,numero2,numero1 + numero2);
            //Console.WriteLine("Soma de " + numero1 + " com " + numero2 + " = " + (numero1 + numero2));
            
            //Operadores aritméticos básicos
            Console.WriteLine($"Soma:{numero1 + numero2}"); //adição
            Console.WriteLine($"Subtração:{numero1 - numero2}"); //subtração
            Console.WriteLine($"Multiplicação:{numero1 * numero2}"); // multiplicação
            Console.WriteLine($"Divisão:{numero1 / numero2}"); //Divisão
            Console.WriteLine($"Resto:{numero1 % numero2}"); // Módulo (resto)

            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    } 
}
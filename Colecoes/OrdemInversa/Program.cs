using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemInversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> fila = new Queue<int>();
            Stack<int> pilha = new Stack<int>();

            int resposta;
            do
            {
                Console.Write("Informe um número:");
                fila.Enqueue(int.Parse(Console.ReadLine()));

                Console.Write("Deseja inserir outro número 0-não 1 sim?");
                resposta = int.Parse(Console.ReadLine());   

            } while (resposta == 1);
                        

            Console.Write("O números informados foram:");
            //foreach (var item in fila)
            //{
            //    Console.Write($" {item} ");
            //    pilha.Push(item);
            //}

            //int count = fila.Count; //obter o tamanho da coleção antes do processo de iteração. CUIDADO!
            //for (int i = 0; i < count; i++)
            //{
            //    int elemento = fila.ElementAt(i);
            //    Console.Write($" {elemento} ");
            //    pilha.Push(elemento);
            //}

            //int qtdeElementosFila = fila.Count;
            //for (int i = 0; i < qtdeElementosFila; i++)
            //{
            //    int elemento = fila.Dequeue();
            //    Console.Write($" {elemento} ");
            //    pilha.Push(elemento);
            //}

            Console.Write("\nO números na ordem inversa são:");
            //foreach (var item in pilha)
            //{
            //    Console.Write($" {item} ");
            //}
            int qtdeElementosPilha = pilha.Count;
            for (int i = 0; i < qtdeElementosPilha; i++)
            {
                int elemento = pilha.Pop();
                Console.Write($" {elemento} ");
            }

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}

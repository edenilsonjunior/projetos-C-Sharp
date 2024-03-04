using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDeBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int ADICIONAR = 1, CHAMAR = 2, IMPRIMIR = 3, SAIR = 4, OPCAOINVALIDA = int.MinValue;

            Queue<string> fila = new Queue<string>();
            int opcao;

            do
            {
                Console.WriteLine($"{ADICIONAR}-Adicionar o nome do cliente");
                Console.WriteLine($"{CHAMAR}-Chamar o nome do cliente");
                Console.WriteLine($"{IMPRIMIR}-Imprimir a fila");
                Console.WriteLine($"{SAIR}-Sair do programa");
                
                Console.Write("Informe uma opção do menu:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case ADICIONAR:
                        Console.Write("Informe o nome do cliente:");
                        fila.Enqueue(Console.ReadLine());
                        break;
                    case CHAMAR:
                        if (fila.Count > 0)
                            Console.WriteLine($"Próximo cliente: {fila.Dequeue()}");
                        else
                            Console.WriteLine("Fila Vazia");
                        break;
                    case IMPRIMIR:
                        if (fila.Count > 0)
                            foreach (var nomeCliente in fila)
                            {
                                Console.WriteLine($"-{nomeCliente}");
                            }
                        else
                            Console.WriteLine("Fila Vazia");
                        break;
                    case SAIR:
                        if (fila.Count == 0)
                            Console.WriteLine("Saindo do programa");                            
                        else
                        {
                            Console.WriteLine("Programa não pode ser encerrado, pois existem clientes na fila");
                            opcao = OPCAOINVALIDA;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != SAIR);

            Console.WriteLine("Banco Fechou... Pressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}

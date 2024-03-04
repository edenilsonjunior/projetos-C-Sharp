using System;

namespace Pesca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PESOMAXIMOPERMITIDOEMKG = 50;
            const double MULTAPORKGEXCEDIDO = 4;

            Console.WriteLine("--Programa Pesca--");

            Console.Write("Informe o peso pescado em Kg:");
            double pesoPescado = double.Parse(Console.ReadLine());
                        
            double multaPagaPeloPescador = 0;
            double pesoExcedidoEmKg = 0;

            if (pesoPescado > PESOMAXIMOPERMITIDOEMKG)
            {                
                pesoExcedidoEmKg = pesoPescado - PESOMAXIMOPERMITIDOEMKG;
                multaPagaPeloPescador = pesoExcedidoEmKg * MULTAPORKGEXCEDIDO;
            }           
                        
            Console.WriteLine($"Peso excedido: {pesoExcedidoEmKg:0.00} Kg.");
            Console.WriteLine($"Multa: R$ {multaPagaPeloPescador:0.00}.");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}

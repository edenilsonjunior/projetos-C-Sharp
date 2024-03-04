using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Bem vindo ao programa POSTO--\n");

            const double VALORLITROALCOOL = 3.9;
            const double VALORLITROGASOLINA = 6.5;
            const double VALORDESCONTOLITROALCOOLATE20LITROS = 0.03;
            const double VALORDESCONTOLITROALCOOLACIMA20LITROS = 0.05;
            const double VALORDESCONTOLITROGASOLINAATE20LITROS = 0.04;
            const double VALORDESCONTOLITROGASOLINAACIMA20LITROS = 0.06;
            const double LIMITELITROSCOMBUSTIVELPARADESCONTO = 20;
            const int ALCOOL = 1, GASOLINA = 2;
            
            Console.Write("Informe o tipo do combustível (1-Álcool 2-Gasolina):");
            int tipoCombustivel = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade em litros:");
            double litros = double.Parse(Console.ReadLine());

            double valorTotal = 0;

            #region "Estrutura de Decisão"

            //if (tipoCombustivel == ALCOOL)
            //{
            //    if (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO)
            //        valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLATE20LITROS) * litros;
            //    else
            //        valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLACIMA20LITROS) * litros;
            //}
            //else if (tipoCombustivel == GASOLINA)
            //{
            //    if (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO)
            //        valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAATE20LITROS) * litros;
            //    else
            //        valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAACIMA20LITROS) * litros;
            //}
            //else // Pode colocar se conversar com alguém que passou a tarefa.
            //{
            //    Console.WriteLine("Tipo de combustível inválido.");
            //}

            //Console.WriteLine($"\nValor a ser pago If: R$ {valorTotal:0.00}.\n");

            #endregion

            #region "switch case"

            //switch (tipoCombustivel)
            //{
            //    case ALCOOL:
            //        if (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO)
            //            valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLATE20LITROS) * litros;
            //        else
            //            valorTotal = VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLACIMA20LITROS) * litros;
            //        break;
            //    case GASOLINA:
            //        if (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO)
            //            valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAATE20LITROS) * litros;
            //        else
            //            valorTotal = VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAACIMA20LITROS) * litros;
            //        break;
            //    default: // Pode colocar se conversar com alguém que passou a tarefa.
            //        Console.WriteLine("Tipo de combustível inválido.");
            //        break;
            //}

            //Console.WriteLine($"\nValor a ser pago Switch: R$ {valorTotal:0.00}.\n");

            #endregion

            #region "Operador Ternário => Obter um resultado de forma direta" 

            double valorDescontoAlcool = 1 - ((litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO) ? VALORDESCONTOLITROALCOOLATE20LITROS : VALORDESCONTOLITROALCOOLACIMA20LITROS);

            double valorDescontoGasolina = 1 - ((litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO) ? VALORDESCONTOLITROGASOLINAATE20LITROS : VALORDESCONTOLITROGASOLINAACIMA20LITROS);

            double valorLitro = (tipoCombustivel == ALCOOL) ? VALORLITROALCOOL * valorDescontoAlcool : VALORLITROGASOLINA * valorDescontoGasolina; // Álcool ou qualquer coisa diferente de Álcool.

            valorTotal = valorLitro * litros;

            Console.WriteLine($"Valor total a pagar:{valorTotal:0.00}");

            #endregion

            Console.Write("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}

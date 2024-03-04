using System;


/*
    A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre salário e o número de filhos. Faça um programa para prefeitura saber:

    a. A média do salário da população.
    b. A média do número de filhos.
    c. O maior salário.
    d. O percentual de pessoas com salários até R$ 150,00.
 */
namespace Prefeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double salarioAte150 = 150;
            double somaSalario = 0, maiorSalario = 0;
            int quantidadeDePessoasComSalarioAte150 = 0;

            double somaNumeroFilhos = 0;

            int quantidadeDePessoas = 0;

            Console.WriteLine("--Bem vindo ao programa Prefeitura--");

            while (true)
            {
                Console.Write("Deseja responder o questionário? (0-não 1-sim):");
                int desejaResponder = int.Parse(Console.ReadLine());

                if (desejaResponder != 1) // return early.
                    break; //não se esqueça do "continue" que pode ser utilizado caso a necessidade seja diferente de interromper a estrutura de repetição.
                
                Console.Write("Qual seu salário?");
                double salario = double.Parse(Console.ReadLine());
                somaSalario += salario;
                if (salario > maiorSalario)
                    maiorSalario = salario;

                Console.Write("Quantos filhos você tem?");
                int numeroFilhos = int.Parse(Console.ReadLine());
                somaNumeroFilhos += numeroFilhos;

                if (salario <= salarioAte150)
                    quantidadeDePessoasComSalarioAte150++;

                quantidadeDePessoas++;
            }

            if (quantidadeDePessoas == 0)
                quantidadeDePessoas = 1;

            Console.WriteLine($"A média do salário da população é: {somaSalario / quantidadeDePessoas}.");
            Console.WriteLine($"A média do número de filhos é: {somaNumeroFilhos / quantidadeDePessoas}.");
            Console.WriteLine($"O maior salário é {maiorSalario}.");
            Console.WriteLine($"O percentual de pessoas com salários até R$ 150,00 é {(double) quantidadeDePessoasComSalarioAte150 / quantidadeDePessoas* 100}%.");
            
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}

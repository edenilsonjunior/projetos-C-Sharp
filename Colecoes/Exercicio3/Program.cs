using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Professor, tomei liberdade para estudar mais sobre como fazer uma boa documentação de código, e por isso, adicionei comentários explicativos em cada método.
                Acredito qu
                Tentei seguir um padrão XML para documentação de código, mas caso não esteja de acordo com o que o senhor espera, por favor, me avise.
             */

            Queue<int> filaComum = new Queue<int>();
            Queue<int> filaPrioritaria = new Queue<int>();
            
            List<int> senhasArmazenadas = new List<int>();
            List<int> opcoesDisponiveis = new List<int> { 1, 2, 3, 4, 5 };

            int opcao;

            do
            {
                opcao = ExibirMenu(opcoesDisponiveis);

                if(opcao == 1)
                    GerarSenhaComum(filaComum, senhasArmazenadas);
                else if(opcao == 2)
                    GerarSenhaPrioritaria(filaPrioritaria, senhasArmazenadas);
                else if(opcao == 3)
                    ChamarSenha(filaPrioritaria, filaComum);
                else if(opcao == 4)
                    EncerrarAtendimento(filaPrioritaria, filaComum);
                else if(opcao == 5)
                    VisualizarFila(filaPrioritaria, filaComum);
                else
                    Console.WriteLine("Opção inválida. Tente novamente.");  

            } while (opcao != 4);
        }

        /// <summary>
        ///  Método que exibe o menu de opções e retorna a opção escolhida.
        ///  Caso o usuario escolha uma opção inválida, o método chama ele mesmo até que o usuário escolha uma opção válida.
        /// </summary>
        /// <param name="opcoesDisponiveis">Lista com as opcoes disponiveis</param>
        /// <returns>Retorna a opcao caso ela esteja correta, ou retorna o mesmo método, até que o usuário escolha uma opção válida.</returns>
        static int ExibirMenu(List<int> opcoesDisponiveis)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Gerar senha para atendimento comum");
            Console.WriteLine("2. Gerar senha para atendimento prioritário");
            Console.WriteLine("3. Chamada da senha para atendimento");
            Console.WriteLine("4. Encerramento do atendimento");
            Console.WriteLine("5. Visualização da fila de chamada");
            Console.Write("Escolha uma opção: ");

            // Esse metodo tryParse vai tentar converter a string para int, caso não consiga, ele retorna false.
            string opcaoStr = Console.ReadLine();
            bool conversao = int.TryParse(opcaoStr, out int opcaoInt);

            if (conversao && opcoesDisponiveis.Contains(opcaoInt))
            {
                return opcaoInt;
            }

            Console.WriteLine("Opção inválida. Tente novamente.");
            return ExibirMenu(opcoesDisponiveis);
        }

        /// <summary>
        /// Gera uma senha comum e adiciona na fila de atendimento comum.
        /// </summary>
        /// <param name="filaComum">Lista com as senhas comuns</param>
        /// <param name="senhasArmazenadas">Lista com todas as senhas armazenadas</param>
        static void GerarSenhaComum(Queue<int> filaComum, List<int> senhasArmazenadas)
        {
            int senha = GerarSenha(senhasArmazenadas);
            filaComum.Enqueue(senha);
            Console.WriteLine($"Senha comum gerada: {senha}");
        }

        /// <summary>
        /// Gera uma senha prioritária e adiciona na fila de atendimento prioritário.
        /// </summary>
        /// <param name="filaPrioritaria">Lista com as senhas prioritarias</param>
        /// <param name="senhasArmazenadas">Lista com todas as senhas armazenadas</param>
        static void GerarSenhaPrioritaria(Queue<int> filaPrioritaria, List<int> senhasArmazenadas)
        {
            int senha = GerarSenha(senhasArmazenadas);
            filaPrioritaria.Enqueue(senha);
            Console.WriteLine($"Senha prioritária gerada: {senha}");
        }

        /// <summary>
        /// Método que gera uma senha para o atendimento, a senha recebe o tamanho da lista de senhas atendidas + 1.
        /// Depois adiciona a senha na lista de senhas atendidas.
        /// </summary>
        /// <param name="senhasArmazenadas">Lista com todas as senhas armazenadas</param>
        /// <returns>Retorna a senha gerada a partir da lista de senhas</returns>
        static int GerarSenha(List<int> senhasArmazenadas)
        {
            int senha = senhasArmazenadas.Count + 1;
            senhasArmazenadas.Add(senha);
            return senha;
        }

        /// <summary>
        /// Método que chama a senha para atendimento, priorizando sempre a fila prioritária.
        /// </summary>
        /// <param name="filaPrioritaria">>Uma fila com as senhas prioritaria</param>
        /// <param name="filaComum">Uma fila com as senhas comuns</param>
        static void ChamarSenha(Queue<int> filaPrioritaria, Queue<int> filaComum)
        {
            if (filaPrioritaria.Count > 0)
            {
                int senha = filaPrioritaria.Dequeue();
                Console.WriteLine($"Chamada senha prioritária: P{senha}");
            }
            else if (filaComum.Count > 0)
            {
                int senha = filaComum.Dequeue();
                Console.WriteLine($"Chamada senha comum: C{senha}");
            }
            else
            {
                Console.WriteLine("Não há mais senhas na fila de atendimento.");
            }
        }

        /// <summary>
        /// Método que encerra o atendimento, caso não tenha mais senhas nas filas.
        /// </summary>
        /// <param name="filaPrioritaria">Uma fila com as senhas prioritarias</param>
        /// <param name="filaComum">Uma fila com as senhas comuns</param>
        static void EncerrarAtendimento(Queue<int> filaPrioritaria, Queue<int> filaComum)
        {
            if (filaComum.Count == 0 && filaPrioritaria.Count == 0)
            {
                Console.WriteLine("Atendimento encerrado.");

                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Atendimento não pode ser encerrado. Ainda existem senhas na fila.");
            }
        }

        /// <summary>
        /// Método faz a visualização das filas de atendimento.
        /// </summary>
        /// <param name="filaPrioritaria">Uma fila com as senhas prioritarias</param>
        /// <param name="filaComum">Uma fila com as senhas comuns</param>
        static void VisualizarFila(Queue<int> filaPrioritaria, Queue<int> filaComum)
        {
            Console.WriteLine("\nFila prioritária:");
            foreach (int senha in filaPrioritaria)
            {
                Console.Write($"P{senha} ");
            }

            Console.WriteLine("\nFila comum:");
            foreach (int senha in filaComum)
            {
                Console.Write($"C{senha} ");
            }
        }
    }
}

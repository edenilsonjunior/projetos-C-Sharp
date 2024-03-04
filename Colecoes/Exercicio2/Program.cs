using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
a) Escreva o que você entende por Dictionary.
R: Dictionary é uma coleção de chaves e valores, onde cada chave é única e não pode ser repetida. 
Exemplo: dicionario.Add(1, "Araraquara");

Se chamar dicionario[1] o resultado será "Araraquara".

b) Escreva o que faz esse programa (por volta de 5 linhas - considere uma linha com aproximadamente 50
caracteres).
R: 
Este programa substitui algumas vogais maiúsculas e minúsculas na frase que o usuario digitar. Ele usa um Dictionary para mapear as vogais. Em seguida, o programa pede para que o usuario digite uma frase, realiza as substituições iguais no dicionário e imprime o resultado.

c) Se o usuário entrar com a palavra "Cerejeira", qual será a saída do programa. Explique como o programa
chegou nesse resultado.
R: o resultado é C3r3j31r@, o programa chama o metodo Replace para cada letra da palavra, substituindo as letras que estão no dicionário.

 */



namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> x = new Dictionary<char, char>();
            x.Add('A', '@');
            x.Add('a', '@');
            x.Add('E', '3');
            x.Add('e', '3');
            x.Add('I', '1');
            x.Add('i', '1');
            x.Add('O', '0');
            x.Add('o', '0');
            x.Add('U', '%');
            x.Add('u', '%');


            Console.Write("Digite a frase: ");
            string y = Console.ReadLine();

            string z = y;

            foreach (KeyValuePair<char, char> item in x)
            {
                z = z.Replace(item.Key, item.Value);
            }

            Console.WriteLine("Resultado: {0}", z);

            Console.ReadLine();
        }
    }
}

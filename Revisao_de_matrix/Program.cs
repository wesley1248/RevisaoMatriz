using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_de_matriz {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciado");

            Console.Write("Qual sera o tamanho da matriz?: ");
            string[] tamanho_da_matriz = Console.ReadLine().Split(',');
            int linhas = int.Parse(tamanho_da_matriz[0]);
            int colunas = int.Parse(tamanho_da_matriz[1]);
            Console.WriteLine();


            Console.WriteLine("Digite abaixo os números");
            int[,] numeros = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("Digite: ");
                    numeros[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Numeros da diagonal:");
            for (int i = 0; i < Math.Min(linhas, colunas); i++)
            {
                Console.Write(numeros[i, i] + " ");
            }
            Console.WriteLine();

            int contagem_de_numeros = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (numeros[i, j] < 0)
                    {
                        contagem_de_numeros++;
                    }
                }
            }
            Console.WriteLine("Quantidade de numeros negativos: " + contagem_de_numeros);
            Console.ReadKey();
        }
    }
}


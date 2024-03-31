using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int [4,4];
        
        for(int linha = 0; linha < 4; linha++)
        {
            for(int coluna = 0; coluna < 4; coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Escolha uma das opcao (1-5): ");
        System.Console.WriteLine("(1)- Imprimir todos elementos: ");
        System.Console.WriteLine("(2)- Somar todos elementos e exibir o resultado: ");
        System.Console.WriteLine("(3)- Somar todos elementos da terceira linha e exibir o resultado: ");
        System.Console.WriteLine("(4)- Somar os elementos da diagonal principal :");
        System.Console.WriteLine("(5)- Somar todos os elementos de índice par da segunda linha: ");

        int opcao = int.Parse(Console.ReadLine());
    }
}
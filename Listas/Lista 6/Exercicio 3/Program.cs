using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        const int LINHAS = 3;
        const int COLUNAS = 3;
        int somatorio = 0;

        int[,] numeros = new int[LINHAS, COLUNAS];
        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                numeros[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        for (int linha = 0; linha < LINHAS; linha++)
        {
            for (int coluna = 0; coluna < COLUNAS; coluna++)
            {
                if (linha == coluna)
                {
                    somatorio += numeros[linha, coluna];
                }
            }
        }
        Console.Write(somatorio);
        System.Console.WriteLine();
    }
}
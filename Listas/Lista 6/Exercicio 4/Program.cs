using System;

class Program
{
    static void Main(string[] args)
    {


        int[,] matriz = new int[3, 3];
        System.Console.WriteLine("Digite os numeros: ");

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (linha + coluna == 2)
                {
                    matriz[linha, coluna] = numero * 2;
                }
                else
                {
                    matriz[linha, coluna] = numero;
                }
            }
        }


        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                System.Console.Write(matriz[linha, coluna]);
                if (coluna < 2)
                {
                    System.Console.Write(" | ");
                }
                else
                {
                    Console.WriteLine();
                }

            }

        }

    }

}
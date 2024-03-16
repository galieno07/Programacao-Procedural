using System;
using System.Diagnostics.Contracts;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        int triaguloRetangulo;


        do
        {
            System.Console.WriteLine(" Digite o tamanho do triangulo: ");
            triaguloRetangulo = int.Parse(Console.ReadLine());
            if (triaguloRetangulo >= 1 && triaguloRetangulo <= 9)
            {
                break;
            }
            System.Console.WriteLine("Altura invalida! \n Insira uma altura entre 1 e 9");
        } while (triaguloRetangulo < 1 || triaguloRetangulo > 9);


        for (int linha = 1; linha <= triaguloRetangulo; linha++)
        {
            for (int coluna = 1; coluna <= linha; coluna++)
            {
                System.Console.Write(coluna);

            }
            System.Console.WriteLine();
        }

    }

}


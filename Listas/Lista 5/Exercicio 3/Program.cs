using System;

class Program
{
    static void Main(string[] args)
    {
        int baseRetangulo;
        int alturaRetangulo;

        do
        {
            System.Console.WriteLine("Digite a altura do triangulo: ");
            alturaRetangulo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a base do triangulo: ");
            baseRetangulo = int.Parse(Console.ReadLine());

        } while ( alturaRetangulo == baseRetangulo);

         for (int altura = 0; altura < alturaRetangulo; altura++)
        {
            for (int coluna = 0; coluna < baseRetangulo; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
       
    }
}
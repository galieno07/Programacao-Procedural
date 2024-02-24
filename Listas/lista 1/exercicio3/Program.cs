using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os valor que deseja converter: ");
        int totalvalor = int.Parse(Console.ReadLine());

        int reais = totalvalor / 100;
        int centavos = totalvalor % 100;

        Console.WriteLine("O total em dinheiro eh: " + reais + " reais e " + centavos + " centavos ");

    }
}
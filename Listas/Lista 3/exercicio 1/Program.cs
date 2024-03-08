using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_DE_HABITANTES = 3;
        double mediaSalarial = 0;
        double maiorSalario = 0;
        double somatorioSalarial = 0;
        int somatoriaFilhos = 0;
        int mediaFilhos = 0;

        for (int contador = 1; contador <= NUMERO_DE_HABITANTES; contador++)
        {
            System.Console.WriteLine("Digite o seu salarios: ");
            double salario = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a quantidade de filhos: ");
            int numerodefilhos = int.Parse(Console.ReadLine());

            somatorioSalarial = somatorioSalarial + salario;
            somatoriaFilhos = somatoriaFilhos + numerodefilhos;
            if (salario > maiorSalario)
            {
                 maiorSalario = salario;
            }
        }
        mediaSalarial = somatorioSalarial / NUMERO_DE_HABITANTES;
        mediaFilhos = somatoriaFilhos / NUMERO_DE_HABITANTES;
        System.Console.WriteLine("O media salarial e:" + mediaSalarial);
        System.Console.WriteLine("O maior salario e: " + maiorSalario);
        System.Console.WriteLine("A media de filhos e: " + mediaFilhos);
    }

}
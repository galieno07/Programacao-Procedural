using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Digite a nota do aluno: ");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());
        double nota4 = double.Parse(Console.ReadLine());

        double nota = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine(nota);
        if (nota >= 5.0)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if (nota < 5.0 && nota >= 3.0)
        {
            Console.WriteLine("Aluno em recuperacao");
        }
        else if (nota < 3.0)
        {
            Console.WriteLine("Aluno reprovado");
        }

    }

}
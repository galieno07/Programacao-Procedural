using System;

class Program
{
    static void Main(string[] args)
    {


        string[] nomes = new string[10];
        for (int contador = 0; contador < nomes.Length; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }
        System.Console.WriteLine("Quem voce esta procurando: ");
        string nomeDigitado = Console.ReadLine();
        bool validacaoDeNome = false;

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            if (nomeDigitado == nomes[contador])
            {
                validacaoDeNome = true;
                break;
            }
        }
        if (validacaoDeNome)
        {
            System.Console.WriteLine("\nACHEI ");
        }
        else
        {

            System.Console.WriteLine("\nNAO ACHEI");
        }

    }
}


using System;

class Program

{
    static void PercorrerVetor(int[] vetor)
    {
        Console.WriteLine("insira a quantidade de toneladas para cada vagão:");
        for (int peso = 0; peso < vetor.Length; peso++)
        {
            Console.Write($"Vagão {peso + 1}: ");
            vetor[peso] = Convert.ToInt32(Console.ReadLine());

        }
    }
    static void VerifiquePeso(int[] vetor)
    {

        for (int peso = 0; peso < vetor.Length; peso++)
        {
            if (vetor[peso]> 50)
            {
                System.Console.WriteLine($"Vagão {peso + 1} ultrapassou o limite de peso.");
            }
        }

    }

    static void Main(String[] args)
    {
        int[] vagoes = new int[12];
        PercorrerVetor(vagoes);
        VerifiquePeso(vagoes);
    }
}

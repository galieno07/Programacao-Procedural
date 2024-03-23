using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;

        do
        {
            int numeroRecebido = int.Parse(Console.ReadLine());
            if(numeroRecebido % 2 == 1)
            {
                numeroRecebido--;
            }
            if (numeroRecebido < 0)
            {
                break;
            }
            somatorio = somatorio + numeroRecebido;
        } while (true);

        System.Console.WriteLine("O somatorio dos impares eh: " + somatorio);
    }
}
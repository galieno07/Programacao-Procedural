ousing System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];
        for (int contador = 0; contador < 10; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }
        for (int contador = 9; contador >= 0; contador--)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine(nomes[contador]);
            }
        }
    }

}
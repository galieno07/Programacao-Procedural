using System;

class Program
{

    static bool ehPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        bool retorno = ehPar(numero);

        System.Console.WriteLine(retorno);
    }
}
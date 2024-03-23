using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        for (int soma = 10; soma >= 1; soma--)
        {
            for (int calculo = 10; calculo >= 1; calculo--)
            {
                System.Console.WriteLine(soma + " X " + calculo + " = " + soma * calculo );
                
            }
        }
        System.Console.WriteLine( );
        
    }

}
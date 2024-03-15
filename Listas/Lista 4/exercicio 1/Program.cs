using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        
        for(int soma = 1; soma <= 10; soma++)
        {
           for (int calculo = 1; calculo <=10; calculo++)
           {
            System.Console.WriteLine(soma +" X " + calculo +" = " + soma*calculo);
           } 
        Console.WriteLine();
        }
        
    }


}
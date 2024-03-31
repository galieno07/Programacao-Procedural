using System;
using System.Runtime.InteropServices;

class Program
{

    static void Main(string[] args)
    {   System.Console.WriteLine("Digite os numeros: ");
        int[] numero = new int[10];
        for (int contador = 0; contador < 10; contador++)
        {
            
                numero[contador] = int.Parse(Console.ReadLine());   

        }
            for(int contador = 0; contador < 10; contador++)
            {
                  if (contador < 10 && contador > 50)
                  {
                   System.Console.WriteLine(numero[contador]);
                  } 
                
            }
    }


}
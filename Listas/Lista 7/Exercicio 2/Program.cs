using System;
using System.Globalization;

class Program
{
    static int PegarMaiorNumero(int[] vetor)
    {
       int MaiorNumero = 0;
        
        for(int contador = 0; contador < vetor.Length; contador++)
        {  
            vetor[contador] = int.Parse(Console.ReadLine());
            if(vetor[contador] > MaiorNumero)
            {
                MaiorNumero = vetor[contador];
            }
        }
        return MaiorNumero;
    }
    
    static void Main(string[] args)
    {
        int[] vetor = new int[3];
         int MaiorElemento = PegarMaiorNumero(vetor);
        
        System.Console.WriteLine("\n O Maior Numero e :" + MaiorElemento);
    }
}
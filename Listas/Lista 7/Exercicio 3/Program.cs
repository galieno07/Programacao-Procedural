using System;

class Program
{
    static void ClassificadorNadador( int idade){
        if (idade < 12)
        {
            System.Console.WriteLine("Infantil ");
        }

        if (idade == 12 && idade <= 14)
        {
            System.Console.WriteLine("Juvenil A ");
        }
        if (idade == 15 && idade <= 17)
        {
            System.Console.WriteLine("Juvenil B");
        }
        if (idade >= 18)
        {
            System.Console.WriteLine("Adulto ");
             
        }

        
    }

    static void Main(String[] args)
    {
        int idade = int.Parse(Console.ReadLine());
        ClassificadorNadador(idade);

    }
}

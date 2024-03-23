using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int diminuir = 200;

        for (int aumentar = 0; aumentar <= 100; aumentar += 2)
        {
            System.Console.WriteLine($"{aumentar} - {diminuir}");
            diminuir -= 4;
        }

    }
}

using System;
struct Pizza
    {
        public int id;
        public string sabor;
        public double preco;
    }
class Program
{
    

    static void Main(String[]args)
    {
        System.Console.WriteLine("Digite os dados de sua pizza: ");
        Pizza pizza;

        pizza.id = Convert.ToInt32(Console.ReadLine());
        pizza.sabor = Convert.ToString(Console.ReadLine());
        pizza.preco = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine(pizza.id);
        System.Console.WriteLine(pizza.sabor);
        System.Console.WriteLine(pizza.preco);
    }

}
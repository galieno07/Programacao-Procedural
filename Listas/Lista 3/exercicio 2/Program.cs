using System;

class Program
{
    static void Main(string[] args)
    {
       double valorTotal = 0;
        int contador = 0;

        System.Console.WriteLine("Digite a quantidade de produtos: ");
        int produtos = int.Parse(Console.ReadLine());

        while (contador < produtos)
        {
            contador++;
            
            System.Console.WriteLine("Digite os valores dos produtos: ");
            double valorProdutos = double.Parse(Console.ReadLine());
            valorTotal = valorTotal + valorProdutos;
        }
        if( valorTotal <= 150)
        {
            System.Console.WriteLine("A compra nao possui frete gratis: " + valorTotal);
        }
        else if(valorTotal > 150)
        {
            System.Console.WriteLine("Parabens! Voce Ganhou Um Frete Gratis Em Sua Compra De Valor: " + valorTotal);
        }
             



    }


}
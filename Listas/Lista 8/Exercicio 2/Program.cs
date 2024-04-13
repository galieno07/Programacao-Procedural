using System;
using System.Data.Common;
struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool dispoivelEmEstoque;
}
class Program
{

    static void Main(String[] args)
    {
        Produto[] produtos = new Produto[4];
        System.Console.WriteLine("Digite os dados dos seus produtos : ");

        for (int i = 0; i < produtos.Length; i++)
        {
            produtos[i].id = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].dispoivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }
        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i].dispoivelEmEstoque == true)
            {
                System.Console.WriteLine("\n" + produtos[i].nome + "\n" + produtos[i].preco);
            }
        }

    }

}
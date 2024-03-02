using System;
using System.Reflection;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do usuario: ");
        string nome = (Console.ReadLine());
            
        Console.WriteLine("Digite a senha: ");
      string senha = (Console.ReadLine());

        if(nome == "admin")
        {
            Console.WriteLine("Login realizado com sucesso");
        }
        else if(senha == "123senha")
        {
        Console.WriteLine("Login realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Credenciais Invalidas");
        } 

        
            
        
        

 
    }

    



}


   
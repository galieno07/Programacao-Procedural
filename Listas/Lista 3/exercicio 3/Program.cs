using System;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        const string USUARIO_CORRETO = "admin";
        const string SENHA_CORRETA = "123senha";
        const int TENTATIVAS_MAXIMAS = 3;
        int contadorTentativas = 1;
        do
        {   contadorTentativas++;
            System.Console.WriteLine("Digite o nome do usuario: ");
            string respostaUsuario = Console.ReadLine();
            System.Console.WriteLine("Digite a senha: ");
            string respostaSenha = Console.ReadLine();
            if (respostaUsuario == USUARIO_CORRETO && respostaSenha == SENHA_CORRETA)
            {
                System.Console.WriteLine("Login realizado com sucesso ");
                break;
            }
            else if (contadorTentativas > TENTATIVAS_MAXIMAS)
            {
                System.Console.WriteLine("Sua conta foi bloqueada");
            }
        }
        while (contadorTentativas <= TENTATIVAS_MAXIMAS);
        


    }

}
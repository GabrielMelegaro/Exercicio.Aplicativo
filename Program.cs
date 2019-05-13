using System;

namespace Ex.Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao){
                case 1:
                    UsuarioViewController.CadastrarUsuario();
                break;
                case 2:
                break;
                case 3:
                break;

                default:
                break;
            }
        
        }
    }
}

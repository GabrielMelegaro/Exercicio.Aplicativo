using System;
using Ex.Aplicativo.Controller;
using Ex.Aplicativo.Model;
using Ex.Aplicativo.Repositorio;
using Ex.Aplicativo.Utils;

namespace Ex.Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int opcaoLogado = 0;
            do{
                MenuUtils.MenuDeslogado();
                
                opcao = int.Parse(Console.ReadLine());
                switch (opcao){
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                    break;
                    case 2:
                        UsuarioViewController.ListarUsuario();
                        Console.ReadLine();
                        
                    break;
                    case 3:
                    
                    break;
                    case 4:
                        UsuarioViewModel resposta = UsuarioViewController.LoginUsuario();
                        if(resposta != null){
                        MenuUtils.MenuLogado();
                        opcaoLogado = int.Parse(Console.ReadLine());
                        switch(opcaoLogado){
                            case 1:
                            //Cadastrar Receita;
                            TransacaoViewController.CadastrarReceita();
                            break;
                            case 2:
                            //Cadastrar Despesa
                            TransacaoViewController.CadastrarDespesa();
                            break;
                            case 3: 
                            TransacaoRepositorio.Listar();
                            //Listar
                            break;
                            case 0:
                            //Sair
                            break;

                        }
                        

                        }
                    break;
                    case 0:
                    Console.WriteLine("Tchau, Até Mais (;-;)");
                    break;
                    default:
                    Console.WriteLine("Esse comando não existe!!");
                    break;
                }
            }while(true);
        }
    }
}
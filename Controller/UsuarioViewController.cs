using System;
using Ex.Aplicativo.Model;
using Ex.Aplicativo.Repositorio;

namespace Ex.Aplicativo.Controller
{
    public class UsuarioViewController
    {
        public static void CadastrarUsuario(){
            string nome,email,senha;
            DateTime dataNascimento;

            Console.WriteLine("Digite o nome do usuario:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuario:");
            email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario:");
            senha = Console.ReadLine();
            
            Console.WriteLine("Digite a Data de Nascimento:");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataNascimento = dataNascimento;

            UsuarioRepositorio.Inserir(usuario);
        
            Console.WriteLine($"{usuario.Nome} cadastrado com sucesso!");
        }//fim cadastrar usuario
        public static LoginUsuario(){
            string email, senha;

            Console.WriteLine("Digite o email do usuario:");
            email = Console.ReadLine();

            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = UsuarioRepositorio.BuscarUsuario(email, senha);
        
            if(usuarioRecuperado != null){
                return usuarioRecuperado;
            }
            Console.WriteLine("Usuario ou Senha Inválido");        
            return null;
        }
    }
}
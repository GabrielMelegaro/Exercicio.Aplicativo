using System;
using Ex.Aplicativo.Model;
using Ex.Aplicativo.Repositorio;

namespace Ex.Aplicativo.Controller
{
    public class TransacaoViewController
    {
        public static void CadastrarReceita(){
            float preco;
            string descricao;

            Console.WriteLine("Digite um preço para a sua receita:");
            preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a descrição da receita:");
            descricao = Console.ReadLine();
            
            TransacaoViewModel  transacao = new TransacaoViewModel();
            transacao.Descricao = descricao;
            transacao.Preco = preco;

            TransacaoRepositorio.Inserir(transacao);

        }
        public static void CadastrarDespesa(){
            int IdUsuario;

            IdUsuario = int.Parse(Console.ReadLine());
        }
    }
}
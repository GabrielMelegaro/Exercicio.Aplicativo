using System.Collections.Generic;
using System.IO;
using Ex.Aplicativo.Model;

namespace Ex.Aplicativo.Repositorio
{
    public class TransacaoRepositorio
    {
        public static TransacaoViewModel Inserir(TransacaoViewModel transacao){
            //Aqti
            List<TransacaoViewModel> listaDeUsuarios = Listar();


            StreamWriter sw = new StreamWriter("transacao.csv", true);
            
            sw.WriteLine($"{transacao.IdUsuario};{transacao.Preco};{transacao.Descricao};");

            sw.Close();
        
            return transacao;
        }
        public static List<TransacaoViewModel> Listar(){
            List<TransacaoViewModel> listaDeTransacoes = new List<TransacaoViewModel>();
            TransacaoViewModel transacao;

            if(!File.Exists("transacao.csv")){
                return null;
            }

            string[] Transacao = File.ReadAllLines("transacao.csv");
            
            foreach(var item in Transacao){
                if(item != null){
                    string[] dadosDaTransacao = item.Split(";");
                    transacao = new TransacaoViewModel();
                    transacao.IdUsuario = int.Parse(dadosDaTransacao[0]);
                    transacao.Preco = float.Parse(dadosDaTransacao[1]);
                    transacao.Descricao = dadosDaTransacao[2];

                    listaDeTransacoes.Add(transacao);
                }
            }
            return listaDeTransacoes;
        }
    }
}
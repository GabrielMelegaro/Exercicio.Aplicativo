using System;

namespace Ex.Aplicativo.Model
{
    public class UsuarioViewModel : BaseViewModel
    {
        public string Nome {get;set;}
        public string Email{get;set;}
        public string Senha{get;set;}
        public DateTime DataNascimento{get;set;}
    }
}
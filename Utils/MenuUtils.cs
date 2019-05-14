using System;

namespace Ex.Aplicativo.Utils
{
    public class MenuUtils
    {
        public static void MenuDeslogado(){
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|| Bem-Vindo ao Aplicativo Financeiro ||");
            Console.ResetColor();
            Console.WriteLine("========================================");
            Console.WriteLine("||      1 - Cadastro De Usuario       ||");
            Console.WriteLine("||        2 - Listar Usuario          ||");
            Console.WriteLine("||     3 - Cadastro de Transação      ||");
            Console.WriteLine("||        4 - Login De Usuario        ||");
            Console.WriteLine("||             0 - Sair               ||");
            Console.WriteLine("========================================");
        }
        public static void MenuLogado(){
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("||             Transações             ||");
            Console.ResetColor();
            Console.WriteLine("========================================");
            Console.WriteLine("||      1 - Cadastrar Receita         ||");
            Console.WriteLine("||      2 - Cadastrar Despesa         ||");
            Console.WriteLine("||             3 - Listar             ||");
            Console.WriteLine("||             0 - Sair               ||");
            Console.WriteLine("========================================");
        }
    }
}
using System;

namespace Ex.Aplicativo.Utils
{
    public class MenuUtils
    {
        public static void MenuDeslogado(){
        string barraMenu = "========================================";
            Console.WriteLine(barraMenu);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|| Bem-Vindo ao Aplicativo Financeiro ||");
            Console.ResetColor();
            Console.WriteLine(barraMenu);
            Console.WriteLine("||      1 - Cadastro De Usuario       ||");
            Console.WriteLine("||       2 - Login De Usuario         ||");
            Console.WriteLine("||     3 - Cadastro de Transação      ||");
            Console.WriteLine(barraMenu);
        }
    }
}
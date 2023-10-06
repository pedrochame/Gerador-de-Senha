using System;
using System.Collections.Generic;

namespace GeradorSenha
{
    internal class Program
    {
        static string geraSenha(List<string> senhasGeradas)
        {

            string s;
            Random rnd = new Random();

            while (true)
            {
                s = "";
                //A senha terá aleatoriamente entre 10 e 20 caracteres
                for (int i = 0; i < rnd.Next(10, 21); i++)
                {
                    //Tabela ASCII: 33 até 126 incluem letras maiúsculas, minúsculas, números e símbolos
                    int x = rnd.Next(33, 127);
                    s += Convert.ToChar(x);
                }
                //Se a senha atual já tiver sido gerada, ela é gerada novamente
                if (!senhasGeradas.Contains(s))
                {
                    break;
                }
            }
            //A senha gerada é armazenada numa lista, para que não se repita durante a execução do programa
            senhasGeradas.Add(s);
            return s;
        }

        static void Main(string[] args)
        {
            List<string> senhasGeradas = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("GERADOR DE Senha!");
                Console.WriteLine("\nSenha: " + geraSenha(senhasGeradas));
                Console.Write("\nTecle algo para gerar novamente (0 para sair). ");
                string x = Console.ReadLine();
                if (x == "0") { break; }
            }
        }
    }
}